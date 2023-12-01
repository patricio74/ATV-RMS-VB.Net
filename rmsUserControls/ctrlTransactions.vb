Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class ctrlTransactions
    Dim tourPrice As Double = 0
    Dim numberOfPerson As Double = 0
    Dim totalPrice As Double = 0
    Private Sub clearAddResTab()
        cbxTransacFilter.SelectedIndex = 0
        tbxNewFName.Clear()
        tbxNewMName.Clear()
        tbxNewSName.Clear()
        cbxNewTour.SelectedIndex = -1
        dateTimeNew.Value = DateTime.Now
        tbxNewPerson.Clear()
        cbxNewTimeSlot.SelectedIndex = -1
        cbxNewStatus.SelectedIndex = -1
        tbxNewTotal.Clear()
    End Sub
    Private Sub clearUpdResTab()
        cbxTransacFilter.SelectedIndex = 0
        dgvTransactions.ClearSelection()
        lblUpdReservID.Text = ""
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
    Private Sub clearAddTransacTab()
        cbxTransacFilter.SelectedIndex = 0
        dgvTransactions.ClearSelection()
        tbxAddFName.Clear()
        tbxAddMName.Clear()
        tbxAddSname.Clear()
        cbxAddTour.SelectedIndex = -1
        dateTimeNew.Value = DateTime.Now
        cbxAddTour.SelectedIndex = -1
        cbxAddTimeSlot.SelectedIndex = -1
        tbxAddPerson.Clear()
        tbxAddTotal.Clear()
        cbxAddAtv.SelectedIndex = -1
        cbxAddTourGuide.SelectedIndex = -1
        tourPrice = 0
        numberOfPerson = 0
        totalPrice = 0
    End Sub
    Private Sub clearOngoingTab()
        cbxTransacFilter.SelectedIndex = 0
        tbxOnGName.Clear()
        tbxOnGTour.Clear()
        tbxOnGTime.Clear()
        tbxOnGPerson.Clear()
        cbxOnGAtv.SelectedIndex = -1
        cbxOnGTourGuide.SelectedIndex = -1
        tbxOnGTotal.Clear()
        cbxOnGStatus.SelectedIndex = -1
    End Sub
    Private Function cbxToursList()
        Dim filter As New BsonDocument()
        Dim tourData As List(Of BsonDocument) = rmsSharedVar.colTrails.Find(filter).ToList()
        Return tourData
    End Function
    Private Sub reloadTrailList()
        'clear combobox then repopulate list
        cbxReservTour.Items.Clear()
        cbxReservTour.SelectedIndex = -1
        cbxAddTour.Items.Clear()
        cbxAddTour.SelectedIndex = -1
        cbxNewTour.Items.Clear()
        cbxNewTour.SelectedIndex = -1
        Dim tourData As List(Of BsonDocument) = cbxToursList()
        For Each tourDocument As BsonDocument In tourData
            cbxAddTour.Items.Add(tourDocument("nameOfTour").ToString())
            cbxNewTour.Items.Add(tourDocument("nameOfTour").ToString())
            cbxReservTour.Items.Add(tourDocument("nameOfTour").ToString())
        Next
    End Sub
    Private Sub ctrlTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reloadTrailList()
        populateTransac()
    End Sub
    Private Sub suppressKeyPre(sender As Object, e As KeyPressEventArgs) Handles tbxAddFName.KeyPress, tbxAddMName.KeyPress, tbxAddSname.KeyPress,
        tbxAddPerson.KeyPress, tbxAddTotal.KeyPress,
        tbxOnGName.KeyPress, tbxOnGTour.KeyPress, tbxOnGTime.KeyPress, tbxOnGPerson.KeyPress, tbxOnGTour.KeyPress, tbxReservTotal.KeyPress, tbxReservSName.KeyPress, tbxReservPerson.KeyPress, tbxReservMName.KeyPress, tbxReservFName.KeyPress, tbxNewTotal.KeyPress, tbxNewSName.KeyPress, tbxNewPerson.KeyPress, tbxNewMName.KeyPress, tbxNewFName.KeyPress
        'suppress enter key sound sa mga textboxes
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub
    Private Sub clearForm(sender As Object, e As EventArgs) Handles lblClearAdd.Click, lblClearUpd.Click, lblClearNew.Click
        If sender Is lblClearAdd Then
            clearAddTransacTab()
        ElseIf sender Is lblClearNew Then
            clearAddResTab()
        ElseIf sender Is lblClearUpd Then
            clearUpdResTab()
        ElseIf sender Is lblClearTransac Then
            clearOngoingTab()
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabTransactions.SelectedIndexChanged
        If tabTransactions.SelectedIndex = 0 Then 'walk-in transac tab
            reloadTrailList()
            clearUpdResTab()
            populateTransac()
            'add code to display transacdb to dgv

        ElseIf tabTransactions.SelectedIndex = 1 Then 'add reserv tab
            reloadTrailList()
            clearAddTransacTab()
            clearUpdResTab()
            populateTransac()
            'add code to display reservations to dgv

        ElseIf tabTransactions.SelectedIndex = 2 Then 'upd reserv tab
            reloadTrailList()
            'add code to display reservations to dgv

        ElseIf tabTransactions.SelectedIndex = 3 Then 'waiting list tab
            populateTransac()

        ElseIf tabTransactions.SelectedIndex = 4 Then 'ongoing tab
            reloadTrailList()
            clearAddTransacTab()
            clearUpdResTab()
            'add code to display transacdb to dgv

        End If
    End Sub




    '!!!!!gawan mo ng list kagaya sa customerz
    Private Sub populateTransac()
        If Me.Visible = True Then
            Dim filter = Builders(Of BsonDocument).Filter.Empty
            Dim transacList = rmsSharedVar.colTransac.Find(filter).ToList()
            dgvTransactions.Rows.Clear()
            For Each doc As BsonDocument In transacList
                Dim transacID As String = doc("_id").AsObjectId.ToString
                Dim transacFName As String = doc("FName").AsString
                Dim transacMName As String = doc("MName").AsString
                Dim transacSName As String = doc("Sname").AsString
                Dim transacTour As String = doc("tourName").AsString
                Dim transacDate As String = doc("transacStart").AsString
                Dim transacTime As String = doc("timeSlot").AsString
                Dim transacStatus As String = doc("status").AsString
                dgvTransactions.Rows.Add(transacID, transacFName, transacMName, transacSName, transacTour, transacDate, transacTime, transacStatus)
                dgvTransactions.ClearSelection()
            Next
        End If
    End Sub
    Private Sub dgvTransac_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransactions.CellClick
        Try
            Dim selectedRow As DataGridViewRow = dgvTransactions.SelectedRows(0)
            If dgvTransactions.SelectedRows(0).Cells.Count > 0 Then
                tabTransactions.SelectedIndex = 2 'update reservation tab
                Dim selectedId As String = selectedRow.Cells("Column1").Value.ToString()
                Dim selectedFName As String = selectedRow.Cells("Column2").Value.ToString()
                Dim selectedMName As String = selectedRow.Cells("Column3").Value.ToString()
                Dim selectedSName As String = selectedRow.Cells("Column4").Value.ToString()
                Dim selectedTour As String = selectedRow.Cells("Column5").Value.ToString()
                Dim selectedDate As String = selectedRow.Cells("Column6").Value.ToString()
                Dim selectedTime As String = selectedRow.Cells("Column7").Value.ToString()
                Dim selectedStatus As String = selectedRow.Cells("Column8").Value.ToString()
                lblUpdReservID.Text = selectedId
                tbxReservFName.Text = selectedFName
                tbxReservMName.Text = selectedMName
                tbxReservSName.Text = selectedSName
                cbxReservTour.Text = selectedTour
                dateTimeReserv.Value = selectedDate
                cbxReservTimeSlot.Text = selectedTime
                cbxReservStatus.Text = selectedStatus
                'number of person
                'price
            End If
        Catch ex As Exception
            'MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub





    'ADD TRANSACTIONS CODE
    '!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    Private Sub cbxAddTour_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxAddTour.SelectedIndexChanged
        If cbxAddTour.SelectedItem IsNot Nothing Then
            Dim selectedTourName As String = cbxAddTour.SelectedItem.ToString()
            Dim tourData As List(Of BsonDocument) = cbxToursList()
            If tourData IsNot Nothing Then
                Dim selectedTour = tourData.FirstOrDefault(Function(t) t("nameOfTour").ToString() = selectedTourName)
                If selectedTour IsNot Nothing Then
                    Dim tourPriceString As String = selectedTour("price").ToString()
                    If Double.TryParse(tourPriceString, tourPrice) Then
                        If tbxAddPerson IsNot Nothing AndAlso Not String.IsNullOrEmpty(tbxAddPerson.Text) Then
                            If Double.TryParse(tbxAddPerson.Text, numberOfPerson) Then
                                totalPrice = tourPrice * numberOfPerson
                                tbxAddTotal.Text = totalPrice.ToString()
                            Else
                                tbxAddTotal.Clear()
                            End If
                        Else
                            tbxAddTotal.Clear()
                        End If
                    End If
                Else
                End If
            Else
            End If
        End If
    End Sub
    Private Sub btnAddTransac_Click(sender As Object, e As EventArgs) Handles btnAddTransac.Click
        If String.IsNullOrEmpty(tbxAddFName.Text) OrElse String.IsNullOrEmpty(tbxAddMName.Text) OrElse String.IsNullOrEmpty(tbxAddSname.Text) OrElse cbxAddTour.SelectedIndex = -1 OrElse cbxAddTimeSlot.SelectedIndex = -1 OrElse String.IsNullOrEmpty(tbxAddTotal.Text) OrElse String.IsNullOrEmpty(tbxAddPerson.Text) Then
            MessageBox.Show("Please fill in all fields to continue.")
        Else
            Dim transacConfirmation As DialogResult = MessageBox.Show("Do you want to add this transaction to the database?", "Confirmation", MessageBoxButtons.YesNo)
            If transacConfirmation = DialogResult.Yes Then
                Try
                    Dim transacDoc As New BsonDocument From {
                    {"FName", tbxAddFName.Text},
                    {"MName", tbxAddMName.Text},
                    {"Sname", tbxAddSname.Text},
                    {"tourName", cbxAddTour.SelectedItem.ToString()},
                    {"tourPrice", tbxAddTotal.Text},
                    {"totalPerson", tbxAddPerson.Text},
                    {"totalPrice", tbxAddTotal.Text},
                    {"transacStart", DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ")},
                    {"timeSlot", cbxAddTimeSlot.SelectedItem.ToString},
                    {"status", "Ongoing"}
                }
                    rmsSharedVar.colTransac.InsertOne(transacDoc)
                    MessageBox.Show("Transaction saved.")
                    populateTransac()
                    clearAddTransacTab()
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub







    'UPDATE RESERVATONS CODE
    '!!!!!!!!!!!!!!!!!!!!!!
    Private Sub btnUpdRes_Click(sender As Object, e As EventArgs) Handles btnUpdRes.Click
        If String.IsNullOrEmpty(tbxReservFName.Text) OrElse String.IsNullOrEmpty(tbxReservMName.Text) OrElse String.IsNullOrEmpty(tbxReservSName.Text) OrElse cbxReservTour.SelectedIndex = -1 OrElse cbxReservStatus.SelectedIndex = -1 OrElse cbxReservTimeSlot.SelectedIndex = -1 OrElse String.IsNullOrEmpty(tbxReservTotal.Text) Then
            MessageBox.Show("Please select a reservation to update.")
        Else
            Dim reservConfirmation As DialogResult = MessageBox.Show("Save changes to reservation?", "Confirmation", MessageBoxButtons.YesNo)
            If reservConfirmation = DialogResult.Yes Then
                Try
                    Dim filterID = Builders(Of BsonDocument).Filter.Eq(Of String)("_id", lblUpdReservID.Text)
                    Dim resUpdate = Builders(Of BsonDocument).Update.Set(Of String)("FName", tbxReservFName.Text).Set(Of String)("MName", tbxReservMName.Text).Set(Of String)("Sname", tbxReservSName.Text).Set(Of String)("tourName", cbxReservTour.SelectedItem.ToString).Set(Of String)("tourPrice", tbxReservTotal.Text).Set(Of String)("reservDate", dateTimeReserv.Value.ToString("yyyy-MM-ddTHH:mm:ssZ")).Set(Of String)("timeSlot", cbxReservTimeSlot.SelectedItem.ToString).Set(Of String)("status", cbxReservStatus.SelectedItem.ToString)
                    Dim updateResult = rmsSharedVar.colReserv.UpdateOne(filterID, resUpdate)
                    If updateResult.ModifiedCount > 0 Then
                        MessageBox.Show("Reservation updated successfully.")
                        populateTransac()
                        clearUpdResTab()
                    Else
                        MessageBox.Show("Reservation not found or no update occurred.")
                        'REFRESH DGV()
                    End If
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub
    Private Sub cbxReservTour_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxReservTour.SelectedIndexChanged
        If cbxReservTour.SelectedItem IsNot Nothing Then
            Dim selectedTourName As String = cbxReservTour.SelectedItem.ToString()
            Dim tourData As List(Of BsonDocument) = cbxToursList()
            If tourData IsNot Nothing Then
                Dim selectedTour = tourData.FirstOrDefault(Function(t) t("nameOfTour").ToString() = selectedTourName)
                If selectedTour IsNot Nothing Then
                    Dim tourPriceString As String = selectedTour("price").ToString()
                    If Double.TryParse(tourPriceString, tourPrice) Then
                        If tbxReservPerson IsNot Nothing AndAlso Not String.IsNullOrEmpty(tbxReservPerson.Text) Then
                            If Double.TryParse(tbxReservPerson.Text, numberOfPerson) Then
                                totalPrice = tourPrice * numberOfPerson
                                tbxReservTotal.Text = totalPrice.ToString()
                            Else
                                tbxReservTotal.Clear()
                            End If
                        Else
                            tbxReservTotal.Clear()
                        End If
                    End If
                Else
                End If
            Else
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
    Private Sub tbxReservPerson_TextChanged(sender As Object, e As EventArgs) Handles tbxReservPerson.TextChanged
        If tbxReservPerson.Text = "" Then
            tbxReservTotal.Clear()
        ElseIf tbxReservPerson.Text IsNot "" Then
            Double.TryParse(tbxReservPerson.Text, numberOfPerson)
            totalPrice = tourPrice * numberOfPerson
            tbxReservTotal.Text = totalPrice
        End If
    End Sub
    Private Sub tbxPerson(sender As Object, e As KeyPressEventArgs) Handles tbxAddPerson.KeyPress, tbxReservPerson.KeyPress
        'check if the inputted char is a number,backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub ctrlTransactions_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = False Then
            closeMongoConn()
            clearAddTransacTab()
            clearUpdResTab()
            reloadTrailList()
            tabTransactions.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnViewTransac_Click(sender As Object, e As EventArgs) Handles btnViewTransac.Click
        'view dgv w/ filter
    End Sub
End Class