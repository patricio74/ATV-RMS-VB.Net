Imports System.Globalization
Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class ctrlOverview
    Public Class Reservation
        Public Property ReservationDate As DateTime
        Public Property TimeSlot As String
    End Class

    Private Sub ctrlOverview_Load(sender As Object, e As EventArgs) Handles Me.Load
        'para sa combobox year sa reservation dgv
        Dim currentYear As Integer = DateTime.Now.Year
        For i As Integer = currentYear To currentYear + 1
            cbxYear.Items.Add(i.ToString())
        Next
        cbxYear.SelectedIndex = -1

        'populate months sa combobox
        For month As Integer = 1 To 12
            cbxMonth.Items.Add(DateAndTime.MonthName(month))
        Next

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


        'display reviews sa dgvReviews
        Dim colReviews As IMongoCollection(Of BsonDocument) = connectToMongo.GetCollection(Of BsonDocument)("custReviews")
        ' Load the data from MongoDB and sort by reviewDate in descending order
        Dim sort = Builders(Of BsonDocument).Sort.Descending("reviewDate")
        Dim documents = colReviews.Find(New BsonDocument()).Sort(sort).ToList()


        dgvReviews.Rows.Clear()
        ' Populate the DataGridView with data from MongoDB
        For Each doc In documents
            dgvReviews.Rows.Add(doc("Rating").ToString(), doc("Name").ToString(), doc("Review").ToString())
        Next
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

    Private Sub btnViewReserv_Click(sender As Object, e As EventArgs) Handles btnViewReserv.Click
        ' Get the selected month and year from ComboBoxes
        Dim selectedMonth As Integer = cbxMonth.SelectedIndex + 1
        Dim selectedYear As Integer = Integer.Parse(cbxYear.SelectedItem.ToString())

        ' Define a collection to store the reservations
        Dim reservations As New List(Of Reservation)()

        ' Create a filter to match reservations for the selected month and year
        Dim filter As BsonDocument = New BsonDocument(
            New BsonElement("status", "Pending"),
            New BsonElement("tourDate",
                New BsonDocument(
                    New BsonElement("$gte", New BsonDateTime(New DateTime(selectedYear, selectedMonth, 1, 0, 0, 0, DateTimeKind.Utc))),
                    New BsonElement("$lt", New BsonDateTime(New DateTime(selectedYear, selectedMonth + 1, 1, 0, 0, 0, DateTimeKind.Utc)))
                )
            )
        )

        Dim collection = connectToMongo.GetCollection(Of BsonDocument)("custReservations")
        Dim cursor = collection.Find(filter).ToCursor()
        For Each doc In cursor.ToEnumerable()
            ' Parse the BSON document into a Reservation object
            Dim reservation As New Reservation() With {
                .ReservationDate = doc("tourDate").ToUniversalTime(),
                .TimeSlot = doc("timeSlot").ToString()
            }
            reservations.Add(reservation)
        Next
        ' Bind the reservations list to the DataGridView
        dgvReservations.Rows.Clear()
        For Each reservation In reservations
            Dim day As String = reservation.ReservationDate.Day.ToString()
            Dim timeSlot As String = reservation.TimeSlot
            dgvReservations.Rows.Add(day, timeSlot)
        Next
    End Sub

End Class