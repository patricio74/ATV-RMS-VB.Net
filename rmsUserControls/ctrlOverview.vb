Imports System.Globalization
Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class ctrlOverview

    Private Sub ctrlOverview_Load(sender As Object, e As EventArgs) Handles Me.Load
        'para sa combobox year sa reservation dgv
        Dim currentYear As Integer = DateTime.Now.Year
        For i As Integer = currentYear To currentYear + 1
            cbxYear.Items.Add(i.ToString())
        Next
        cbxYear.SelectedIndex = -1

        'refresh content every 3secs
        Timer1.Interval = 3000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        loadStats()
    End Sub

    Private Sub loadStats()
        Dim currentDate As DateTime = DateTime.UtcNow
        Dim firstDayOfMonth As DateTime = New DateTime(currentDate.Year, currentDate.Month, 1, 0, 0, 0, DateTimeKind.Utc)
        Dim lastDayOfMonth As DateTime = firstDayOfMonth.AddMonths(1).AddSeconds(-1)
        Dim yesterday As DateTime = currentDate.AddDays(-1)
        Dim startOfYesterday As DateTime = New DateTime(yesterday.Year, yesterday.Month, yesterday.Day, 0, 0, 0, DateTimeKind.Utc)
        Dim endOfYesterday As DateTime = startOfYesterday.AddHours(23).AddMinutes(59).AddSeconds(59)

        'pangcount sa reservations
        Dim colReserv As IMongoCollection(Of BsonDocument) = connectToMongo.GetCollection(Of BsonDocument)("custReservations")
        Dim pendingResFilter = Builders(Of BsonDocument).Filter.Eq(Of String)("status", "Pending")
        Dim canceledResFilter = Builders(Of BsonDocument).Filter.Eq(Of String)("status", "Canceled")
        Dim pendingReserv As Long = colReserv.CountDocuments(pendingResFilter)
        Dim canceledReserv As Long = colReserv.CountDocuments(canceledResFilter)
        lblReservPending.Text = pendingReserv
        lblReservCanceled.Text = "Canceled Reservations: " + canceledReserv.ToString

        'count customers this month, yesterday
        Dim colCustCount As IMongoCollection(Of BsonDocument) = connectToMongo.GetCollection(Of BsonDocument)("logTransactions")
        Dim custDocs As List(Of BsonDocument) = colCustCount.Find(New BsonDocument()).ToList()
        Dim customersThisMonth As Long = 0
        For Each doc As BsonDocument In custDocs
            Dim reservDate As DateTime = DateTime.ParseExact(doc("reservDate").ToString(), "yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal)
            If reservDate >= firstDayOfMonth AndAlso reservDate <= lastDayOfMonth Then
                customersThisMonth += 1
            End If
        Next
        Dim customersYesterday As Long = 0
        For Each doc As BsonDocument In custDocs
            Dim reservDate As DateTime = DateTime.ParseExact(doc("reservDate").ToString(), "yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal)
            If reservDate >= startOfYesterday AndAlso reservDate <= endOfYesterday Then
                customersYesterday += 1
            End If
        Next
        lblCustMonth.Text = customersThisMonth.ToString()
        lblCustYest.Text = "Total number yesterday: " & customersYesterday.ToString()

        'count revenue for this month, yesterday
        Dim colRevenue As IMongoCollection(Of BsonDocument) = connectToMongo.GetCollection(Of BsonDocument)("logTransactions")
        Dim totalRevenueThisMonth As Decimal = 0
        For Each doc As BsonDocument In colRevenue.Find(New BsonDocument()).ToList()
            Dim reservDate As DateTime = DateTime.ParseExact(doc("reservDate").ToString(), "yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal)
            If reservDate >= firstDayOfMonth AndAlso reservDate <= lastDayOfMonth Then
                totalRevenueThisMonth += Convert.ToDecimal(doc("totalPrice").ToString())
            End If
        Next
        Dim totalRevenueYesterday As Decimal = 0
        For Each doc As BsonDocument In colRevenue.Find(New BsonDocument()).ToList()
            Dim reservDate As DateTime = DateTime.ParseExact(doc("reservDate").ToString(), "yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal)
            If reservDate >= startOfYesterday AndAlso reservDate <= endOfYesterday Then
                totalRevenueYesterday += Convert.ToDecimal(doc("totalPrice").ToString())
            End If
        Next
        lblRevMonth.Text = "₱" & totalRevenueThisMonth.ToString("#,##0")
        lblRevYest.Text = "Total yesterday: ₱" & totalRevenueYesterday.ToString("#,##0")

    End Sub

    Private Sub MouseEnterHandler(sender As Object, e As EventArgs) Handles panelReserv.MouseEnter,
        lblReserv.MouseEnter, lblReservCanceled.MouseEnter, lblReservPending.MouseEnter,
        panelATV.MouseEnter, lblAtvAvail.MouseEnter, lblAtv.MouseEnter, lblAtvInUse.MouseEnter, lblAtvMainten.MouseEnter,
        panelCustomer.MouseEnter, lblCustMonth.MouseEnter, lblCust.MouseEnter, lblCustYest.MouseEnter,
        panelRevenue.MouseEnter, lblRevMonth.MouseEnter, lblRev.MouseEnter, lblRevYest.MouseEnter
        If sender Is panelReserv OrElse sender Is lblReserv OrElse sender Is lblReservCanceled OrElse sender Is lblReservPending Then
            panelReserv.BackColor = ColorTranslator.FromHtml("#6c849c")
        ElseIf sender Is panelATV OrElse sender Is lblAtv OrElse sender Is lblAtvAvail OrElse sender Is lblAtvInUse OrElse sender Is lblAtvMainten Then
            panelATV.BackColor = ColorTranslator.FromHtml("#6c849c")
        ElseIf sender Is panelCustomer OrElse sender Is lblCust OrElse sender Is lblCustMonth OrElse sender Is lblCustYest Then
            panelCustomer.BackColor = ColorTranslator.FromHtml("#6c849c")
        ElseIf sender Is panelRevenue OrElse sender Is lblRev OrElse sender Is lblRevMonth OrElse sender Is lblRevYest Then
            panelRevenue.BackColor = ColorTranslator.FromHtml("#6c849c")
        End If
    End Sub

    Private Sub MouseLeaveHandler(sender As Object, e As EventArgs) Handles panelReserv.MouseLeave,
        lblReserv.MouseLeave, lblReservCanceled.MouseLeave, lblReservPending.MouseLeave,
        panelATV.MouseLeave, lblAtvAvail.MouseLeave, lblAtv.MouseLeave, lblAtvInUse.MouseLeave, lblAtvMainten.MouseLeave,
        panelCustomer.MouseLeave, lblCustMonth.MouseLeave, lblCust.MouseLeave, lblCustYest.MouseLeave,
        panelRevenue.MouseLeave, lblRevMonth.MouseLeave, lblRev.MouseLeave, lblRevYest.MouseLeave
        If sender Is panelReserv OrElse sender Is lblReserv OrElse sender Is lblReservCanceled OrElse sender Is lblReservPending Then
            panelReserv.BackColor = ColorTranslator.FromHtml("#1e272e")
        ElseIf sender Is panelATV OrElse sender Is lblAtv OrElse sender Is lblAtvAvail OrElse sender Is lblAtvInUse OrElse sender Is lblAtvMainten Then
            panelATV.BackColor = ColorTranslator.FromHtml("#1e272e")
        ElseIf sender Is panelCustomer OrElse sender Is lblCust OrElse sender Is lblCustMonth OrElse sender Is lblCustYest Then
            panelCustomer.BackColor = ColorTranslator.FromHtml("#1e272e")
        ElseIf sender Is panelRevenue OrElse sender Is lblRev OrElse sender Is lblRevMonth OrElse sender Is lblRevYest Then
            panelRevenue.BackColor = ColorTranslator.FromHtml("#1e272e")
        End If
    End Sub

    Public Class Reservation
        Public Property _id As ObjectId
        Public Property FName As String
        Public Property MName As String
        Public Property Sname As String
        Public Property tourName As String
        Public Property tourPrice As String
        Public Property reservDate As String
        Public Property timeSlot As String
        Public Property status As String
        Public Property totalPerson As String
    End Class

    Private Sub btnViewReserv_Click(sender As Object, e As EventArgs) Handles btnViewReserv.Click
        Try
            Dim selectedMonth As String = cbxMonth.SelectedItem.ToString()
            Dim selectedYear As Integer = Convert.ToInt32(cbxYear.SelectedItem)
            Dim selectedDate As String = $"{selectedYear}-{selectedMonth.PadLeft(2, "0")}"
            Dim reservations As New List(Of Reservation)()
            Dim col As IMongoCollection(Of BsonDocument) = connectToMongo.GetCollection(Of BsonDocument)("custReservations")
            Dim filter As New BsonDocument()
            Dim bsonReservations As List(Of BsonDocument) = col.Find(filter).ToList()
            For Each bsonReservation As BsonDocument In bsonReservations
                Dim reservation As New Reservation()
                reservation.FName = bsonReservation("FName").ToString()
                reservation.MName = bsonReservation("MName").ToString()
                reservation.Sname = bsonReservation("Sname").ToString()
                reservation.tourName = bsonReservation("tourName").ToString()
                reservation.tourPrice = bsonReservation("tourPrice").ToString()
                reservation.reservDate = bsonReservation("reservDate").ToString()
                reservation.timeSlot = bsonReservation("timeSlot").ToString()
                reservation.status = bsonReservation("status").ToString()
                reservation.totalPerson = bsonReservation("totalPerson").ToString()
                reservations.Add(reservation)
            Next
            dgvReservations.Rows.Clear()
            For Each reservation As Reservation In reservations
                If reservation.reservDate.StartsWith(selectedDate) Then
                    Dim dayOfMonth As Integer = DateTime.Parse(reservation.reservDate).Day
                    dgvReservations.Rows.Add(dayOfMonth, $"{reservation.FName} {reservation.Sname}", reservation.tourName)
                End If
            Next
            dgvReservations.Refresh()
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class