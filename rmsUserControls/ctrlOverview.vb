Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class ctrlOverview

    Dim collection As IMongoCollection(Of BsonDocument) = connectToMongo.GetCollection(Of BsonDocument)("custReservations")

    'pangcount sa reservations
    Dim pendingResFilter = Builders(Of BsonDocument).Filter.Eq(Of String)("status", "Pending")
    Dim canceledResFilter = Builders(Of BsonDocument).Filter.Eq(Of String)("status", "Canceled")
    Dim pendingReserv As Long = collection.CountDocuments(pendingResFilter)
    Dim canceledReserv As Long = collection.CountDocuments(canceledResFilter)

    Private Sub ctrlOverview_Load(sender As Object, e As EventArgs) Handles Me.Load
        'para sa combobox sa reservation dgv
        Dim currentYear As Integer = DateTime.Now.Year
        For i As Integer = currentYear To currentYear + 1
            cbxYear.Items.Add(i.ToString())
        Next
        cbxYear.SelectedIndex = -1

        'add mo sa module to kasama ng ibang panel label
        lblReservPending.Text = pendingReserv
        lblReservCanceled.Text = "Canceled Reservations: " + canceledReserv.ToString
    End Sub

    Private Sub MouseEnterHandler(sender As Object, e As EventArgs) Handles panelReserv.MouseEnter,
        lblReserv.MouseEnter, lblReservCanceled.MouseEnter, lblReservPending.MouseEnter,
        panelATV.MouseEnter, lblAtvAvail.MouseEnter, lblAtv.MouseEnter, lblAtvInUse.MouseEnter, lblAtvMainten.MouseEnter,
        panelCustomer.MouseEnter, lblCustMonth.MouseEnter, lblCust.MouseEnter, lblCustYest.MouseEnter,
        panelRevenue.MouseEnter, lblRevMonth.MouseEnter, lblRev.MouseEnter, lblRevYest.MouseEnter
        If sender Is panelReserv OrElse sender Is lblReserv OrElse sender Is lblReservCanceled OrElse sender Is lblReservPending Then
            panelReserv.BackColor = Color.MediumOrchid
        ElseIf sender Is panelATV OrElse sender Is lblAtv OrElse sender Is lblAtvAvail OrElse sender Is lblAtvInUse OrElse sender Is lblAtvMainten Then
            panelATV.BackColor = Color.LightSkyBlue
        ElseIf sender Is panelCustomer OrElse sender Is lblCust OrElse sender Is lblCustMonth OrElse sender Is lblCustYest Then
            panelCustomer.BackColor = Color.MediumSlateBlue
        ElseIf sender Is panelRevenue OrElse sender Is lblRev OrElse sender Is lblRevMonth OrElse sender Is lblRevYest Then
            panelRevenue.BackColor = Color.Aquamarine
        End If
    End Sub

    Private Sub MouseLeaveHandler(sender As Object, e As EventArgs) Handles panelReserv.MouseLeave,
        lblReserv.MouseLeave, lblReservCanceled.MouseLeave, lblReservPending.MouseLeave,
        panelATV.MouseLeave, lblAtvAvail.MouseLeave, lblAtv.MouseLeave, lblAtvInUse.MouseLeave, lblAtvMainten.MouseLeave,
        panelCustomer.MouseLeave, lblCustMonth.MouseLeave, lblCust.MouseLeave, lblCustYest.MouseLeave,
        panelRevenue.MouseLeave, lblRevMonth.MouseLeave, lblRev.MouseLeave, lblRevYest.MouseLeave
        If sender Is panelReserv OrElse sender Is lblReserv OrElse sender Is lblReservCanceled OrElse sender Is lblReservPending Then
            panelReserv.BackColor = Color.DarkOrchid
        ElseIf sender Is panelATV OrElse sender Is lblAtv OrElse sender Is lblAtvAvail OrElse sender Is lblAtvInUse OrElse sender Is lblAtvMainten Then
            panelATV.BackColor = Color.DeepSkyBlue
        ElseIf sender Is panelCustomer OrElse sender Is lblCust OrElse sender Is lblCustMonth OrElse sender Is lblCustYest Then
            panelCustomer.BackColor = Color.SlateBlue
        ElseIf sender Is panelRevenue OrElse sender Is lblRev OrElse sender Is lblRevMonth OrElse sender Is lblRevYest Then
            panelRevenue.BackColor = Color.SpringGreen
        End If
    End Sub


End Class
