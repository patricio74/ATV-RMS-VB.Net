Imports ATV_RMS.ctrlTransactions
Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class ctrlReservations
    Dim tourPrice As Double = 0
    Dim numberOfPerson As Double = 0
    Dim totalPrice As Double = 0
    Private Sub clearAddResTab()
        cbxReservFilter.SelectedIndex = 0
        dgvReservs.ClearSelection()
        tbxNewFName.Clear()
        tbxNewMName.Clear()
        tbxNewSName.Clear()
        cbxNewTour.SelectedIndex = -1
        dateTimeNew.Value = DateTime.Now
        tbxNewPerson.Clear()
        cbxNewTimeSlot.SelectedIndex = -1
        tbxNewTotal.Clear()
    End Sub
    Private Sub clearUpdResTab()
        cbxReservFilter.SelectedIndex = 0
        dgvReservs.ClearSelection()
        'lblPendingRes. reset mo count
        lblUpdReservID.Text = "-"
        tbxReservFName.Clear()
        tbxReservMName.Clear()
        tbxReservSName.Clear()
        cbxReservTour.SelectedIndex = -1
        tbxReservPerson.Clear()
        dateTimeReserv.Value = DateTime.Now
        cbxReservStatus.SelectedIndex = -1
        cbxReservTimeSlot.SelectedIndex = -1
        tbxReservTotal.Clear()
        tourPrice = 0
        numberOfPerson = 0
        totalPrice = 0
    End Sub

    Private reservz As List(Of resDoc)
    Public Class resDoc
        Public Property resID As String
        Public Property resFname As String '
        Public Property resMname As String
        Public Property resSname As String
        Public Property resTourName As String
        Public Property resTourPrice As String
        Public Property resDuration As String
        Public Property resReservDate As String
        Public Property resTotalPerson As String
        Public Property resTimeSlot As String
        Public Property resStatus As String
        Public Property resBalance As String
        Public Property resInitPayment As String
        Public Property resTotalPayment As String
        Public Property resGcashNum As String
        Public Property resCustomerID As String
    End Class
    Private Sub populateReserv()
        If rmsDashboard.switchReserv = True Then
            'dgvReservs.Rows.Clear()
            Dim reservDocList As List(Of BsonDocument) = rmsSharedVar.colReserv.Find(New BsonDocument()).ToList()
            reservz = New List(Of resDoc)()
            For Each document As BsonDocument In reservDocList
                Dim idElement = document.GetElement("_id")
                Dim tr As New resDoc() With {
                .resID = idElement.Value.AsObjectId.ToString,
                .resFname = document("FName").ToString,
                .resMname = document("MName").ToString,
                .resSname = document("Sname").ToString,
                .resTourName = document("tourName").ToString,
                .resTourPrice = document("tourPrice").ToString,
                .resDuration = document("duration").ToString,
                .resReservDate = document("reservDate").ToString,
                .resTotalPerson = document("totalPerson").ToString,
                .resTimeSlot = document("timeSlot").ToString,
                .resStatus = document("status").ToString,
                .resBalance = document("Balance").ToString,
                .resInitPayment = document("InitialPayment").ToString,
                .resTotalPayment = document("TotalPayment").ToString,
                .resCustomerID = document("customer").ToString
                }
                reservz.Add(tr)
            Next
            dgvReservs.Rows.Clear()
            For Each doc In reservz
                Dim resName As String = $"{doc.resFname} {doc.resMname} {doc.resSname}".Trim()
                dgvReservs.Rows.Add(doc.resID, resName, doc.resTourName, doc.resReservDate, doc.resTimeSlot, doc.resStatus)
            Next
            dgvReservs.ClearSelection()
        End If
    End Sub











    'wag iclear yung reservform pag lumipat sa ibang form
    Private Sub ctrlReservations_Load(sender As Object, e As EventArgs) Handles Me.Load
        populateReserv()
    End Sub
    Private Sub ctrlReservations_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            populateReserv()
        End If
    End Sub





    Private Sub lblClearNew_Click(sender As Object, e As EventArgs) Handles lblClearNew.Click
        populateReserv()
    End Sub


End Class