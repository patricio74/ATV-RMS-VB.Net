Imports ATV_RMS.ctrlNotif
Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class ctrlTransactions
    Dim tourPrice As Double = 0
    Dim numberOfPerson As Double = 0
    Dim totalPrice As Double = 0
    Private Sub clearAddTransacTab()
        dgvTransactions.ClearSelection()
        tbxAddFName.Clear()
        tbxAddMName.Clear()
        tbxAddSname.Clear()
        cbxAddTour.SelectedIndex = -1
        'dateTimeNew.Value = DateTime.Now
        cbxAddTour.SelectedIndex = -1
        cbxAddTimeSlot.SelectedIndex = -1
        tbxAddPerson.Clear()
        tbxAddTotal.Clear()
        cbxAddTourGuide.SelectedIndex = -1
        tourPrice = 0
        numberOfPerson = 0
        totalPrice = 0
    End Sub
    Private Sub clearWaitList()
        tbxWaitCustName.Clear()
        tbxWaitPerson.Clear()
        tbxWaitTimeSlot.Clear()
        tbxWaitTotPrice.Clear()
        cbxWaitTour.SelectedIndex = -1
        cbxWaitStatus.SelectedIndex = -1
        cbxWaitTourGuide.SelectedIndex = -1
        tourPrice = 0
        numberOfPerson = 0
        totalPrice = 0
    End Sub
    Private Sub clearOngoingTab()
        tbxOnGName.Clear()
        tbxOnGTour.Clear()
        tbxOnGTime.Clear()
        tbxOnGPerson.Clear()
        tbxOnGTotal.Clear()
        cbxOnGTourGuide.SelectedIndex = -1
        cbxOnGStatus.SelectedIndex = -1
        tourPrice = 0
        numberOfPerson = 0
        totalPrice = 0
    End Sub
    Private Function cbxToursList()
        Dim filter As New BsonDocument()
        Dim tourData As List(Of BsonDocument) = rmsSharedVar.colTrails.Find(filter).ToList()
        Return tourData
    End Function
    Private Sub reloadTrailList()
        'clear combobox then repopulate list
        cbxAddTour.Items.Clear()
        cbxAddTour.SelectedIndex = -1
        Dim tourData As List(Of BsonDocument) = cbxToursList()
        For Each tourDocument As BsonDocument In tourData
            cbxAddTour.Items.Add(tourDocument("nameOfTour").ToString())
        Next
    End Sub
    Private Sub suppressKeyPre(sender As Object, e As KeyPressEventArgs) Handles tbxOnGName.KeyPress, tbxOnGTour.KeyPress, tbxOnGTime.KeyPress, tbxOnGPerson.KeyPress,
        tbxOnGTour.KeyPress, tbxAddTotal.KeyPress, tbxAddSname.KeyPress, tbxAddPerson.KeyPress, tbxAddMName.KeyPress, tbxAddFName.KeyPress, tbxWaitCustName.KeyPress,
        tbxWaitPerson.KeyPress, tbxWaitTimeSlot.KeyPress, tbxWaitTotPrice.KeyPress
        'suppress enter key sound sa mga textboxes
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub
    Private Sub clearForm(sender As Object, e As EventArgs) Handles lblOnGClear.Click, lblClearAdd.Click, lblWaitClear.Click
        If sender Is lblClearAdd Then
            clearAddTransacTab()
        ElseIf sender Is lblWaitClear Then
            clearWaitList()
        ElseIf sender Is lblOnGClear Then
            clearOngoingTab()
        End If
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabTransactions.SelectedIndexChanged
        If tabTransactions.SelectedIndex = 0 Then 'walk-in transac tab
            reloadTrailList()
            populateTransac()
            clearWaitList()
            clearOngoingTab()
        ElseIf tabTransactions.SelectedIndex = 1 Then 'waiting list tab
            reloadTrailList()
            populateTransac()
            clearAddTransacTab()
            clearOngoingTab()
        ElseIf tabTransactions.SelectedIndex = 2 Then 'ongoing tab
            reloadTrailList()
            populateTransac()
            clearAddTransacTab()
            clearWaitList()
        End If
    End Sub
    Private tranzac As List(Of trDoc)
    Public Class trDoc
        Public Property trID As String
        Public Property trFname As String '
        Public Property trMname As String
        Public Property trSname As String
        Public Property trTourName As String
        Public Property trTourPrice As String
        Public Property trReservDate As String
        Public Property trTimeSlot As String
        Public Property trStatus As String
        Public Property trTotalPerson As String
        Public Property trTotalPrice As String
        Public Property trTransacStart As String
        Public Property trCustomerID As String
    End Class
    Private Sub populateTransac()
        If rmsDashboard.switchTransac = True Then
            dgvTransactions.Rows.Clear()
            'retrieve docs with status "waiting" or "ongoing"
            Dim filter = Builders(Of BsonDocument).Filter.In(Of String)("status", {"waiting", "ongoing"})
            Dim trDocList As List(Of BsonDocument) = rmsSharedVar.colTransac.Find(filter).ToList()
            tranzac = New List(Of trDoc)()
            For Each document As BsonDocument In trDocList
                Dim idElement = document.GetElement("_id")
                Dim tr As New trDoc() With {
                .trID = idElement.Value.AsObjectId.ToString,
                .trFname = document("FName").ToString,
                .trMname = document("MName").ToString,
                .trSname = document("Sname").ToString,
                .trTourName = document("tourName").ToString,
                .trTourPrice = document("tourPrice").ToString,
                .trReservDate = document("reservDate").ToString,
                .trTimeSlot = document("timeSlot").ToString,
                .trStatus = document("status").ToString,
                .trTotalPerson = document("totalPerson").ToString,
                .trTotalPrice = document("totalPrice").ToString,
                .trTransacStart = document("transacStart").ToString,
                .trCustomerID = document("customer").ToString
                }
                tranzac.Add(tr)
            Next
            dgvTransactions.Rows.Clear()
            For Each doc In tranzac
                Dim applicant As String = $"{doc.trFname} {doc.trMname} {doc.trSname}".Trim()
                dgvTransactions.Rows.Add(doc.trID, applicant, doc.trTourName, doc.trTransacStart, doc.trTimeSlot, doc.trStatus)
            Next
            dgvTransactions.ClearSelection()
        End If
    End Sub
    Private Sub dgvTransactions_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransactions.CellClick
        If e.RowIndex >= 0 Then
            If tranzac IsNot Nothing AndAlso e.RowIndex < tranzac.Count Then
                Dim selTransac = tranzac(e.RowIndex)
                Dim applicantName As String = $"{selTransac.trFname} {selTransac.trMname} {selTransac.trSname}".Trim()
                tbxAddFName.Text = selTransac.trFname
                tbxAddMName.Text = selTransac.trMname
            End If
        End If
    End Sub






    'compute total price
    Private Sub tbxAddPerson_TextChanged(sender As Object, e As EventArgs) Handles tbxAddPerson.TextChanged
        If tbxAddPerson.Text = "" Then
            tbxAddTotal.Clear()
        ElseIf tbxAddPerson.Text IsNot "" Then
            Double.TryParse(tbxAddPerson.Text, numberOfPerson)
            totalPrice = tourPrice * numberOfPerson
            tbxAddTotal.Text = totalPrice
        End If
    End Sub
    'compute total price
    Private Sub tbxReservPerson_TextChanged(sender As Object, e As EventArgs)
        If tbxWaitPerson.Text = "" Then
            tbxWaitTotPrice.Clear()
        ElseIf tbxWaitPerson.Text IsNot "" Then
            Double.TryParse(tbxWaitPerson.Text, numberOfPerson)
            totalPrice = tourPrice * numberOfPerson
            tbxWaitTotPrice.Text = totalPrice
        End If
    End Sub
    Private Sub tbxPerson(sender As Object, e As KeyPressEventArgs) Handles tbxAddFName.KeyPress, tbxAddMName.KeyPress, tbxAddSname.KeyPress, tbxAddPerson.KeyPress,
            tbxWaitCustName.KeyPress, tbxWaitTotPrice.KeyPress, tbxWaitPerson.KeyPress, tbxWaitTimeSlot.KeyPress
        'check if the inputted char is a number,backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub ctrlTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reloadTrailList()
        populateTransac()
    End Sub
    Private Sub ctrlTransactions_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            reloadTrailList()
            populateTransac()
        ElseIf Me.Visible = False Then
            'closeMongoConn()
            clearAddTransacTab()
            reloadTrailList()
            tabTransactions.SelectedIndex = 0
        End If
    End Sub
End Class