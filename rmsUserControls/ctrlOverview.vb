Imports System.Globalization
Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class ctrlOverview
    Dim currentDate As DateTime = DateTime.UtcNow
    Dim firstDayOfMonth As DateTime = New DateTime(currentDate.Year, currentDate.Month, 1, 0, 0, 0, DateTimeKind.Utc)
    Dim lastDayOfMonth As DateTime = firstDayOfMonth.AddMonths(1).AddSeconds(-1)
    Dim yesterday As DateTime = currentDate.AddDays(-1)
    Dim today As DateTime = currentDate
    Dim todayDate As DateTime = New DateTime(today.Year, today.Month, today.Day, 0, 0, 0, DateTimeKind.Utc)
    Dim tomorrow As DateTime = currentDate.AddDays(+1)
    Dim tomorrowDate As DateTime = New DateTime(tomorrow.Year, tomorrow.Month, tomorrow.Day, 0, 0, 0, DateTimeKind.Utc)
    Dim startOfYesterday As DateTime = New DateTime(yesterday.Year, yesterday.Month, yesterday.Day, 0, 0, 0, DateTimeKind.Utc)
    Dim endOfYesterday As DateTime = startOfYesterday.AddHours(23).AddMinutes(59).AddSeconds(59)
    Private Sub ctrlOverview_Load(sender As Object, e As EventArgs) Handles Me.Load
        'refresh content kada 3secs
        overviewTimer.Interval = 3000
        overviewTimer.Start()
        DateTimePicker1.Value = DateTime.Now.Date
        loadStats()
        loadReviews()
        loadReservationz(DateTime.Now)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles overviewTimer.Tick
        If Me.Visible = True Then
            loadStats()
        Else
        End If
    End Sub
    Private Sub MouseEnterHandler(sender As Object, e As EventArgs) Handles panelReserv.MouseEnter,
        lblReserv.MouseEnter, lblReservCanceled.MouseEnter, lblReservPending.MouseEnter,
        panelATV.MouseEnter, lblAtvAvail.MouseEnter, lblAtv.MouseEnter, lblAtvInUse.MouseEnter, lblAtvMainten.MouseEnter,
        panelCustomer.MouseEnter, lblCustMonth.MouseEnter, lblCust.MouseEnter, lblCustYest.MouseEnter,
        panelRevenue.MouseEnter, lblRevMonth.MouseEnter, lblRev.MouseEnter, lblRevYest.MouseEnter
        If sender Is panelReserv OrElse sender Is lblReserv OrElse sender Is lblReservCanceled OrElse sender Is lblReservPending Then
            panelReserv.BackColor = ColorTranslator.FromHtml("#f5f5f5")
            lblReservPending.ForeColor = ColorTranslator.FromHtml("#1e272e")
            lblReserv.BackColor = ColorTranslator.FromHtml("#151515")
            lblReserv.ForeColor = ColorTranslator.FromHtml("#f5f5f5")
            lblReservCanceled.ForeColor = ColorTranslator.FromHtml("#1e272e")
        ElseIf sender Is panelATV OrElse sender Is lblAtv OrElse sender Is lblAtvAvail OrElse sender Is lblAtvInUse OrElse sender Is lblAtvMainten Then
            panelATV.BackColor = ColorTranslator.FromHtml("#f5f5f5")
            lblAtvAvail.ForeColor = ColorTranslator.FromHtml("#1e272e")
            lblAtv.BackColor = ColorTranslator.FromHtml("#151515")
            lblAtv.ForeColor = ColorTranslator.FromHtml("#f5f5f5")
            lblAtvInUse.ForeColor = ColorTranslator.FromHtml("#1e272e")
            lblAtvMainten.ForeColor = ColorTranslator.FromHtml("#1e272e")
        ElseIf sender Is panelCustomer OrElse sender Is lblCust OrElse sender Is lblCustMonth OrElse sender Is lblCustYest Then
            panelCustomer.BackColor = ColorTranslator.FromHtml("#f5f5f5")
            lblCustMonth.ForeColor = ColorTranslator.FromHtml("#1e272e")
            lblCust.ForeColor = ColorTranslator.FromHtml("#f5f5f5")
            lblCust.BackColor = ColorTranslator.FromHtml("#151515")
            lblCustYest.ForeColor = ColorTranslator.FromHtml("#1e272e")
        ElseIf sender Is panelRevenue OrElse sender Is lblRev OrElse sender Is lblRevMonth OrElse sender Is lblRevYest Then
            panelRevenue.BackColor = ColorTranslator.FromHtml("#f5f5f5")
            lblRevMonth.ForeColor = ColorTranslator.FromHtml("#1e272e")
            lblRev.ForeColor = ColorTranslator.FromHtml("#f5f5f5")
            lblRev.BackColor = ColorTranslator.FromHtml("#151515")
            lblRevYest.ForeColor = ColorTranslator.FromHtml("#1e272e")
        End If
    End Sub
    Private Sub MouseLeaveHandler(sender As Object, e As EventArgs) Handles panelReserv.MouseLeave,
        lblReserv.MouseLeave, lblReservCanceled.MouseLeave, lblReservPending.MouseLeave,
        panelATV.MouseLeave, lblAtvAvail.MouseLeave, lblAtv.MouseLeave, lblAtvInUse.MouseLeave, lblAtvMainten.MouseLeave,
        panelCustomer.MouseLeave, lblCustMonth.MouseLeave, lblCust.MouseLeave, lblCustYest.MouseLeave,
        panelRevenue.MouseLeave, lblRevMonth.MouseLeave, lblRev.MouseLeave, lblRevYest.MouseLeave
        If sender Is panelReserv OrElse sender Is lblReserv OrElse sender Is lblReservCanceled OrElse sender Is lblReservPending Then
            panelReserv.BackColor = ColorTranslator.FromHtml("#1e272e")
            lblReservPending.ForeColor = ColorTranslator.FromHtml("#ffffff")
            lblReserv.BackColor = ColorTranslator.FromHtml("#f5f5f5")
            lblReserv.ForeColor = ColorTranslator.FromHtml("#151515")
            lblReservCanceled.ForeColor = ColorTranslator.FromHtml("#d3d3d3")
        ElseIf sender Is panelATV OrElse sender Is lblAtv OrElse sender Is lblAtvAvail OrElse sender Is lblAtvInUse OrElse sender Is lblAtvMainten Then
            panelATV.BackColor = ColorTranslator.FromHtml("#1e272e")
            lblAtvAvail.ForeColor = ColorTranslator.FromHtml("#ffffff")
            lblAtv.BackColor = ColorTranslator.FromHtml("#f5f5f5")
            lblAtv.ForeColor = ColorTranslator.FromHtml("#151515")
            lblAtvInUse.ForeColor = ColorTranslator.FromHtml("#d3d3d3")
            lblAtvMainten.ForeColor = ColorTranslator.FromHtml("#d3d3d3")
        ElseIf sender Is panelCustomer OrElse sender Is lblCust OrElse sender Is lblCustMonth OrElse sender Is lblCustYest Then
            panelCustomer.BackColor = ColorTranslator.FromHtml("#1e272e")
            lblCustMonth.ForeColor = ColorTranslator.FromHtml("#ffffff")
            lblCust.BackColor = ColorTranslator.FromHtml("#f5f5f5")
            lblCust.ForeColor = ColorTranslator.FromHtml("#151515")
            lblCustYest.ForeColor = ColorTranslator.FromHtml("#d3d3d3")
        ElseIf sender Is panelRevenue OrElse sender Is lblRev OrElse sender Is lblRevMonth OrElse sender Is lblRevYest Then
            panelRevenue.BackColor = ColorTranslator.FromHtml("#1e272e")
            lblRevMonth.ForeColor = ColorTranslator.FromHtml("#ffffff")
            lblRev.ForeColor = ColorTranslator.FromHtml("#151515")
            lblRev.BackColor = ColorTranslator.FromHtml("#f5f5f5")
            lblRevYest.ForeColor = ColorTranslator.FromHtml("#d3d3d3")
        End If
    End Sub
    Private Sub loadStats()
        If Me.Visible = True Then
            'pangcount sa reservations
            Dim pendingResFilter = Builders(Of BsonDocument).Filter.Eq(Of String)("status", "Pending")
            Dim canceledResFilter = Builders(Of BsonDocument).Filter.Eq(Of String)("status", "Canceled")
            Dim pendingReserv As Long = rmsSharedVar.colReserv.CountDocuments(pendingResFilter)
            Dim canceledReserv As Long = rmsSharedVar.colReserv.CountDocuments(canceledResFilter)
            lblReservPending.Text = pendingReserv
            lblReservCanceled.Text = "Canceled Reservations: " + canceledReserv.ToString

            'count all ATVs sa inventory, currently in-use
            Dim totalAtv As Long = rmsSharedVar.colInventory.EstimatedDocumentCount()
            lblAtvAvail.Text = totalAtv.ToString()
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.And(
            Builders(Of BsonDocument).Filter.Eq(Of String)("status", "in-use"),
            Builders(Of BsonDocument).Filter.Gte(Of String)("date", todayDate),
            Builders(Of BsonDocument).Filter.Lt(Of String)("date", tomorrowDate)
            )
            'palitan mo to; count doc where status=in-use
            lblAtvInUse.Text = "Currently in-use: " & totalAtv.ToString()

            'count customers this month, yesterday
            Dim custDocs As List(Of BsonDocument) = rmsSharedVar.colTransac.Find(New BsonDocument()).ToList()
            Dim customersThisMonth As Long = 0
            For Each doc As BsonDocument In custDocs
                Dim dateString As String = doc("transacStart").ToString()
                Dim transacDate As DateTime
                If DateTime.TryParseExact(dateString, "yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal, transacDate) Then
                    If transacDate >= firstDayOfMonth AndAlso transacDate <= lastDayOfMonth Then
                        customersThisMonth += 1
                    End If
                End If
            Next
            Dim customersYesterday As Long = 0
            For Each doc As BsonDocument In custDocs
                Dim dateString As String = doc("transacStart").ToString()
                Dim transacDate As DateTime
                If DateTime.TryParseExact(dateString, "yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal, transacDate) Then
                    If transacDate >= startOfYesterday AndAlso transacDate <= endOfYesterday Then
                        customersYesterday += 1
                    End If
                End If
            Next
            lblCustMonth.Text = customersThisMonth.ToString()
            lblCustYest.Text = "Total yesterday: " & customersYesterday.ToString()

            'count revenue for this month, yesterday
            Dim totalRevenueThisMonth As Decimal = 0
            For Each doc As BsonDocument In rmsSharedVar.colTransac.Find(New BsonDocument()).ToList()
                Dim transacDate As DateTime = DateTime.ParseExact(doc("transacStart").ToString(), "yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal)
                If transacDate >= firstDayOfMonth AndAlso transacDate <= lastDayOfMonth Then
                    totalRevenueThisMonth += Convert.ToDecimal(doc("totalPrice").ToString())
                End If
            Next
            Dim totalRevenueYesterday As Decimal = 0
            For Each doc As BsonDocument In rmsSharedVar.colTransac.Find(New BsonDocument()).ToList()
                Dim transacDate As DateTime = DateTime.ParseExact(doc("transacStart").ToString(), "yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal)
                If transacDate >= startOfYesterday AndAlso transacDate <= endOfYesterday Then
                    totalRevenueYesterday += Convert.ToDecimal(doc("totalPrice").ToString())
                End If
            Next
            lblRevMonth.Text = "₱" & totalRevenueThisMonth.ToString("#,##0")
            lblRevYest.Text = "Total yesterday: ₱" & totalRevenueYesterday.ToString("#,##0")
        Else
        End If
    End Sub
    Private Sub loadReviews()
        If Me.Visible = True Then
            'display reviews sa dgvReviews
            'Load the data from MongoDB and sort by reviewDate in descending order
            Dim sort = Builders(Of BsonDocument).Sort.Descending("reviewDate")
            Dim documents = rmsSharedVar.colReviews.Find(New BsonDocument()).Sort(sort).ToList()

            dgvReviews.Rows.Clear()
            For Each doc In documents
                dgvReviews.Rows.Add(doc("Rating").ToString(), doc("Name").ToString(), doc("Review").ToString())
                dgvReviews.ClearSelection()
            Next
        Else
        End If
    End Sub
    Private Sub dgvReviews_SelectionChanged(sender As Object, e As EventArgs) Handles dgvReviews.SelectionChanged
        'Check if a row is selected
        If dgvReviews.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvReviews.SelectedRows(0)
            Dim reviewContent As String = selectedRow.Cells(2).Value.ToString()
            rtbxReview.Text = reviewContent
        Else
            rtbxReview.Clear()
        End If
    End Sub
    Private Sub btnRefreshReviews_Click(sender As Object, e As EventArgs) Handles btnRefreshReviews.Click
        loadReviews()
    End Sub





    Private Sub loadReservationz(selectedDate As Date)
        If Me.Visible = True Then
            'Display reservations sa dgvReserv
            Dim dtpSelectedDate As Date = selectedDate
            'selected date range; 12am-1159pm
            Dim dtpCalStart As Date = New DateTime(dtpSelectedDate.Year, dtpSelectedDate.Month, dtpSelectedDate.Day, 0, 0, 0, DateTimeKind.Utc)
            Dim dtpCalEnd As Date = dtpCalStart.AddDays(+1)
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.And(
                Builders(Of BsonDocument).Filter.Gte(Of DateTime)("reservDate", dtpCalStart),
                Builders(Of BsonDocument).Filter.Lt(Of DateTime)("reservDate", dtpCalEnd))
            Dim reservations = rmsSharedVar.colReserv.Find(filter).ToList()
            dgvReservations.Rows.Clear()
            For Each reservDoc As BsonDocument In reservations
                Dim fullName As String = String.Join(" ", reservDoc("FName"), reservDoc("MName"), reservDoc("Sname"))
                dgvReservations.Rows.Add(fullName, reservDoc("tourName").ToString(), reservDoc("timeSlot").ToString(), reservDoc("totalPerson").ToString())
                dgvReservations.ClearSelection()
            Next


            'may mali pa sa logic, di navview reservation sa selected dtp date
            'sa date format yung mali


        Else
        End If
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim selectedDate As Date = DateTimePicker1.Value
        loadReservationz(selectedDate)
        'MessageBox.Show("Unable to fetch data from the database.", "Connection error!", MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub
    Private Sub btnResetDate_Click(sender As Object, e As EventArgs) Handles btnResetDate.Click
        DateTimePicker1.Value = DateTime.Now
        Dim selectedDate As Date = DateTimePicker1.Value
        loadReservationz(selectedDate)
    End Sub



    Private Sub ctrlOverview_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = False Then
            closeMongoConn()
        End If
    End Sub
End Class