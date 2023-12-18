﻿Imports System.Globalization
Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class ctrlReservations
    Dim tourPrice As Double = 0.00
    Dim numberOfPerson As Double = 0
    Dim totalPrice As Double = 0.00
    'initpaym saka balance pa


    '
    '
    '
    '
    Private Sub clearAddResTab()
        cbxReservFilter.SelectedIndex = 0
        'dgvReservs.ClearSelection()
        tbxNewFName.Clear()
        tbxNewMName.Clear()
        tbxNewSName.Clear()
        cbxNewTour.SelectedIndex = -1
        dateTimeNew.Value = DateTime.Now
        cbxNewPerson.SelectedIndex = -1
        cbxNewTimeSlot.SelectedIndex = -1
        tbxNewTotal.Clear()
    End Sub
    Private Sub clearUpdResTab()
        cbxReservFilter.SelectedIndex = 0
        'dgvReservs.ClearSelection()
        tbxReservCustName.Clear()
        tbxReservBalance.Clear()
        tbxReservTotalPaid.Clear()
        tbxReservTour.Clear()
        tbxReservPerson.Clear()
        tbxReservDate.Clear()
        cbxReservStatus.SelectedIndex = -1
        tbxReservTimeSlot.Clear()
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
        'Public Property resDuration As String
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
    Private Sub suppressKeyPre(sender As Object, e As KeyPressEventArgs) Handles tbxNewFName.KeyPress, tbxNewMName.KeyPress, tbxNewSName.KeyPress,
            tbxReservCustName.KeyPress, tbxReservBalance.KeyPress, tbxReservTour.KeyPress, tbxReservPerson.KeyPress, tbxReservTotal.KeyPress
        'suppress enter key sound sa mga textboxes
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub
    Private Sub tbxPerson(sender As Object, e As KeyPressEventArgs) Handles tbxReservPerson.KeyPress, tbxAddInitPayment.KeyPress
        'check if the inputted char is a number,backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub lblClearForm_Click(sender As Object, e As EventArgs) Handles lblClearUpd.Click, lblClearNew.Click
        If sender Is lblClearNew Then
            populateReserv()
            clearAddResTab()
        ElseIf sender Is lblClearUpd Then
            populateReserv()
            clearUpdResTab()
        End If
    End Sub
    Private Sub reservCounter()
        'count reservation  docs
        Dim resCount = rmsSharedVar.colReserv.CountDocuments(Builders(Of BsonDocument).Filter.Eq(Of String)("status", "Pending"))
        'display total count
        lblPendingRes.Text = $"Pending: {resCount}"
    End Sub
    Private Sub btnFilterRes_Click(sender As Object, e As EventArgs) Handles btnFilterRes.Click
        If cbxReservFilter.SelectedIndex = 0 Then 'show all reserv sa dgv
            populateReserv()
        ElseIf cbxReservFilter.SelectedIndex = 1 Then 'show pending only
            dgvFilteredRes("Pending")
        ElseIf cbxReservFilter.SelectedIndex = 2 Then 'show canceled reservationbs
            dgvFilteredRes("Canceled")
        End If
    End Sub
    Private Sub dgvFilteredRes(status As String)
        If rmsDashboard.switchReserv = True Then
            'sort dgv reserDate in ascending order
            reservz.Sort(Function(x, y) DateTime.Compare(DateTime.Parse(x.resReservDate), DateTime.Parse(y.resReservDate)))
            'filter reservations based on status
            Dim filteredReservz = reservz.Where(Function(reservation) reservation.resStatus = status).ToList()
            dgvReservs.Rows.Clear()
            For Each doc In filteredReservz
                Dim resName As String = $"{doc.resFname} {doc.resMname} {doc.resSname}".Trim()
                Dim reservDate As DateTime = DateTime.Parse(doc.resReservDate)
                Dim formattedDate As String = reservDate.ToString("MMMM dd, yyyy")
                dgvReservs.Rows.Add(resName, doc.resTourName, formattedDate, doc.resTimeSlot, doc.resStatus)
            Next
            dgvReservs.ClearSelection()
            reservCounter()
        End If
    End Sub
    Private Sub populateReserv()
        If rmsDashboard.switchReserv = True Then
            Dim reservDocList As List(Of BsonDocument) = rmsSharedVar.colReserv.Find(New BsonDocument()).ToList()
            reservz = New List(Of resDoc)()
            For Each document As BsonDocument In reservDocList
                Dim idElement = document.GetElement("_id")
                Dim resv As New resDoc() With {
                .resID = idElement.Value.AsObjectId.ToString,
                .resFname = document("FName").ToString,
                .resMname = document("MName").ToString,
                .resSname = document("Sname").ToString,
                .resTourName = document("tourName").ToString,
                .resTourPrice = document("tourPrice").ToString,
                .resReservDate = document("reservDate").ToString,
                .resTotalPerson = document("totalPerson").ToString,
                .resTimeSlot = document("timeSlot").ToString,
                .resStatus = document("status").ToString,
                .resBalance = document("Balance").ToString,
                .resInitPayment = document("InitialPayment").ToString,
                .resTotalPayment = document("TotalPayment").ToString,
                .resCustomerID = document("customer").ToString
                }
                '.resDuration = document("duration").ToString,
                '.resGcashNum = document("gCashNum").ToString,
                reservz.Add(resv)
            Next
            'sort reservation in ascending order
            reservz.Sort(Function(x, y) DateTime.Compare(DateTime.Parse(x.resReservDate), DateTime.Parse(y.resReservDate)))
            'clear existing rows
            dgvReservs.Rows.Clear()
            For Each doc In reservz
                Dim resName As String = $"{doc.resFname} {doc.resMname} {doc.resSname}".Trim()
                'convert to datetime object
                Dim reservDate As DateTime = DateTime.Parse(doc.resReservDate)
                'change format para mas readable
                Dim formattedDate As String = reservDate.ToString("MMMM dd, yyyy")
                dgvReservs.Rows.Add(resName, doc.resTourName, formattedDate, doc.resTimeSlot, doc.resStatus)
            Next
            dgvReservs.ClearSelection()
            reservCounter()
        End If
    End Sub
    Private Sub dgvReservs_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReservs.CellClick
        If e.RowIndex >= 0 Then
            If reservz IsNot Nothing AndAlso e.RowIndex < reservz.Count Then
                tabReservations.SelectedIndex = 1 'switch to update tab
                'populate tab
                Dim selectedReserv As resDoc = reservz(e.RowIndex)
                Dim fullName As String = selectedReserv.resFname + " " + selectedReserv.resMname + " " + selectedReserv.resSname.Trim
                tbxReservCustName.Text = fullName
                tbxReservTotalPaid.Text = selectedReserv.resInitPayment
                tbxReservBalance.Text = selectedReserv.resBalance
                tbxReservTour.Text = selectedReserv.resTourName
                'change format para mas readable
                Dim resDate As DateTime = selectedReserv.resReservDate.ToString
                Dim formattedDate As String = resDate.ToString("MMM. dd, yyyy")
                tbxReservDate.Text = formattedDate
                tbxReservPerson.Text = selectedReserv.resTotalPerson
                tbxReservTimeSlot.Text = selectedReserv.resTimeSlot
                cbxReservStatus.Text = selectedReserv.resStatus
                Dim resTotal As Double = selectedReserv.resTotalPayment
                tbxReservTotal.Text = resTotal.ToString("N2")
            End If
        End If
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabReservations.SelectedIndexChanged
        If tabReservations.SelectedIndex = 0 Then 'add reserv tab
            clearUpdResTab()
            populateReserv()
        ElseIf tabReservations.SelectedIndex = 1 Then 'update reserv tab
            'wag icall yung populteReserv para di mawala selected row
        End If
    End Sub
    '!!!!!!!!!UPDATE TAB
    Private Sub btnUpdRes_Click(sender As Object, e As EventArgs) Handles btnUpdRes.Click
        'update reservdoc
        If dgvReservs.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvReservs.SelectedRows(0)
            Dim selectedRes = reservz(selectedRow.Index)
            Dim resID As String = selectedRes.resID
            If String.IsNullOrEmpty(tbxReservCustName.Text) OrElse String.IsNullOrEmpty(tbxReservBalance.Text) OrElse String.IsNullOrEmpty(tbxReservTotalPaid.Text) OrElse String.IsNullOrEmpty(tbxReservTour.Text) OrElse String.IsNullOrEmpty(tbxReservPerson.Text) OrElse String.IsNullOrEmpty(tbxReservTotal.Text) OrElse String.IsNullOrEmpty(tbxReservDate.Text) OrElse String.IsNullOrEmpty(tbxReservTimeSlot.Text) OrElse cbxReservStatus.SelectedIndex = -1 Then
                MessageBox.Show("Please fill in all fields to continue.")
            Else
                Dim updConfirmation As DialogResult = MessageBox.Show("Do you want to update this info?", "Confirmation", MessageBoxButtons.YesNo)
                If updConfirmation = DialogResult.Yes Then
                    Try
                        Dim objectId As ObjectId
                        If ObjectId.TryParse(resID, objectId) Then
                            Dim filter = Builders(Of BsonDocument).Filter.Eq(Function(doc) doc("_id"), objectId)
                            Dim update = Builders(Of BsonDocument).Update.Set(Of String)("status", cbxReservStatus.SelectedItem.ToString)
                            rmsSharedVar.colReserv.UpdateOne(filter, update)
                            MessageBox.Show("Reservation status updated successfully.")
                            populateReserv()
                            clearUpdResTab()
                        End If
                    Catch ex As Exception
                        MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        Else
            MessageBox.Show("Please select a reservation to continue.")
            populateReserv()
        End If
    End Sub
    Private Sub btnMoveToWaitList_Click(sender As Object, e As EventArgs) Handles btnMoveToWaitList.Click
        'move selected doc sa wait list
        If dgvReservs.SelectedRows.Count > 0 Then
            Dim selectedRes = reservz(dgvReservs.SelectedRows(0).Index)
            Dim pendingResID As String = selectedRes.resID
            Dim selectedStat As String = selectedRes.resStatus
            Dim selectedResDate As DateTime = DateTime.ParseExact(selectedRes.resReservDate, "yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture)
            'check if status=Pending,resDate=date ngayon
            If selectedStat = "Pending" Then
                If selectedResDate.Date = DateTime.Now.Date Then
                    Dim waitConfirmation = MessageBox.Show("Move this reservation to waiting list?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    'move selected reservation sa transac collection
                    If waitConfirmation = DialogResult.Yes Then
                        moveToWaitList(pendingResID)
                    ElseIf waitConfirmation = DialogResult.No Then
                        populateReserv()
                    End If
                Else
                    MessageBox.Show("Selected reservation is not scheduled for today.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Selected reservation status is 'CANCELED'.", "Unable to move to wait list!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
                MessageBox.Show("Please select a reservation first.")
            populateReserv()
        End If
    End Sub
    Private Sub moveToWaitList(pendingResID As String)
        Try
            Dim objectId As ObjectId
            If ObjectId.TryParse(pendingResID, objectId) Then
                Dim filter = Builders(Of BsonDocument).Filter.Eq(Function(doc) doc("_id"), objectId)
                Dim document = rmsSharedVar.colReserv.Find(filter).FirstOrDefault()
                Dim waitStartDate As String = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ")
                If document IsNot Nothing Then
                    'add some fields before moving to transac col
                    document.Add("change", "0.00")
                    document.Add("tourGuide", "")
                    document.Add("transacStart", waitStartDate.ToString)
                    document.Set("status", "waiting")
                    rmsSharedVar.colTransac.InsertOne(document)
                    rmsSharedVar.colReserv.DeleteOne(filter)
                    MessageBox.Show("Reservation moved to wait list.")
                    populateReserv()
                    clearUpdResTab()
                Else
                    MessageBox.Show("Reservation not found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    populateReserv()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            populateReserv()
        End Try
    End Sub
    '!!!!!!!!!!!!!!!!ADD TAB
    Private Function cbxToursList()
        Dim filter As New BsonDocument()
        Dim tourData As List(Of BsonDocument) = rmsSharedVar.colTrails.Find(filter).ToList()
        Return tourData
    End Function
    Private Sub reloadTrailList()
        'clear combobox then repopulate list
        cbxNewTour.Items.Clear()
        cbxNewTour.SelectedIndex = -1
        Dim tourData As List(Of BsonDocument) = cbxToursList()
        For Each tourDocument As BsonDocument In tourData
            cbxNewTour.Items.Add(tourDocument("nameOfTour").ToString())
        Next
    End Sub
    Private Sub cbxIndexChanged(sender As Object, e As EventArgs) Handles cbxNewTour.SelectedIndexChanged
        'set tour price
        If cbxNewTour.SelectedItem IsNot Nothing Then
            Dim selectedTourName As String = cbxNewTour.SelectedItem.ToString()
            Dim tourData As List(Of BsonDocument) = cbxToursList()
            If tourData IsNot Nothing Then
                Dim selectedTour = tourData.FirstOrDefault(Function(t) t("nameOfTour").ToString() = selectedTourName)
                If selectedTour IsNot Nothing Then
                    Dim tourPriceString As String = selectedTour("price").ToString()
                    lblTourPrice.Text = tourPriceString
                    If Double.TryParse(tourPriceString, tourPrice) Then
                        If cbxNewTour IsNot Nothing AndAlso Not String.IsNullOrEmpty(cbxNewPerson.Text) AndAlso cbxNewPerson.SelectedIndex <> -1 Then
                            If Double.TryParse(cbxNewPerson.Text, numberOfPerson) Then
                                totalPrice = tourPrice * numberOfPerson
                                tbxNewTotal.Text = totalPrice.ToString("N2")
                            Else
                                tbxNewTotal.Text = "0.00"
                                numberOfPerson = 0
                            End If
                        Else
                            tbxNewTotal.Text = "0.00"
                            numberOfPerson = 0
                        End If
                    End If
                Else
                End If
            Else
            End If
        End If
    End Sub
    Private Sub tbxAddPerson_TextChanged(sender As Object, e As EventArgs)
        'compute total on textchange

    End Sub
    Private Sub btnAddRes_Click(sender As Object, e As EventArgs) Handles btnAddRes.Click
        'insert sa db
    End Sub





    Private Sub ctrlReservations_Load(sender As Object, e As EventArgs) Handles Me.Load
        'disable dgv sorting on column header clikc
        For Each column As DataGridViewColumn In dgvReservs.Columns
            column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        populateReserv()
        reloadTrailList()
        cbxReservFilter.SelectedIndex = 0 'selected item=all
    End Sub
    Private Sub ctrlReservations_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            'reset filter
            cbxReservFilter.SelectedIndex = 0 'selected item=all
            populateReserv()
            reloadTrailList()
        ElseIf Me.Visible = False Then
            'wag na iclear yung add reserv tab pag lumipat sa ibang form
            tabReservations.SelectedIndex = 0
            clearUpdResTab()
        End If
    End Sub
End Class