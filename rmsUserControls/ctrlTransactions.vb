Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class ctrlTransactions
    Dim tourPrice As Double = 0
    Dim numberOfPerson As Double = 0
    Dim totalPrice As Double = 0
    Private Sub clearUpdResTab()
        cbxReservFilter.SelectedIndex = -1
        dgvTransactions.ClearSelection()
        tbxReservID.Clear()
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
        cbxReservFilter.SelectedIndex = -1
        dgvTransactions.ClearSelection()
        tbxAddFName.Clear()
        tbxAddMName.Clear()
        tbxAddSname.Clear()
        cbxAddTour.SelectedIndex = -1
        tbxAddPerson.Clear()
        dateTimeNew.Value = DateTime.Now
        cbxAddTimeSlot.SelectedIndex = -1
        tbxAddTotal.Clear()
        tourPrice = 0
        numberOfPerson = 0
        totalPrice = 0
    End Sub
    Private Sub reloadTrailList()
        'clear combobox then repopulate list
        cbxReservTour.Items.Clear()
        cbxReservTour.SelectedIndex = -1
        cbxAddTour.Items.Clear()
        cbxAddTour.SelectedIndex = -1
        Dim tourData As List(Of BsonDocument) = cbxToursList()
        For Each tourDocument As BsonDocument In tourData
            cbxReservTour.Items.Add(tourDocument("nameOfTour").ToString())
            cbxAddTour.Items.Add(tourDocument("nameOfTour").ToString())
        Next
    End Sub



    Private Sub ctrlTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'refresh content every 3secs
        transacTimer.Interval = 3000
        transacTimer.Start()
        reloadTrailList()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles transacTimer.Tick
        'ADD CODE PARA IREFRESH DGV PAG NASA ADD TRANSAC,ADD RES TAB
    End Sub
    Private Sub suppressKeyPre(sender As Object, e As KeyPressEventArgs) Handles tbxReservID.KeyPress, tbxReservFName.KeyPress, tbxReservMName.KeyPress,
        tbxReservSName.KeyPress, tbxReservPerson.KeyPress, tbxReservTotal.KeyPress, tbxAddFName.KeyPress, tbxAddMName.KeyPress, tbxAddSname.KeyPress,
        tbxAddPerson.KeyPress, tbxAddTotal.KeyPress, tbxNewFName.KeyPress, tbxNewMName.KeyPress, tbxNewSName.KeyPress, tbxNewPerson.KeyPress, tbxNewTotal.KeyPress,
        tbxOnGName.KeyPress, tbxOnGTour.KeyPress, tbxOnGTime.KeyPress, tbxOnGPerson.KeyPress, tbxOnGTour.KeyPress
        'suppress enter key sound sa mga textboxes
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub
    Private Sub clearForm(sender As Object, e As EventArgs) Handles lblClearAdd.Click, lblClearUpd.Click
        If sender Is lblClearAdd Then
            clearAddTransacTab()
        ElseIf sender Is lblClearUpd Then
            clearUpdResTab()
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabTransactions.SelectedIndexChanged
        If tabTransactions.SelectedIndex = 0 Then 'walk-in transac tab
            cbxReservFilter.Visible = False
            btnViewRes.Visible = False
            reloadTrailList()
            clearUpdResTab()
            'add code to display transacdb to dgv

        ElseIf tabTransactions.SelectedIndex = 1 Then 'add reserv tab
            cbxReservFilter.Visible = False
            btnViewRes.Visible = False
            reloadTrailList()
            clearAddTransacTab()
            'add code to display reservations to dgv

        ElseIf tabTransactions.SelectedIndex = 2 Then 'upd reserv tab
            cbxReservFilter.Visible = True
            btnViewRes.Visible = True
            reloadTrailList()
            clearAddTransacTab()
            'add code to display reservations to dgv

        ElseIf tabTransactions.SelectedIndex = 3 Then 'ongoing tab
            cbxReservFilter.Visible = False
            btnViewRes.Visible = False
            reloadTrailList()
            clearUpdResTab()
            'add code to display transacdb to dgv

        End If
    End Sub
    Private Function cbxToursList()
        Dim filter As New BsonDocument()
        Dim tourData As List(Of BsonDocument) = rmsSharedVar.colAtvTrails.Find(filter).ToList()
        Return tourData
    End Function







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
                    'REFRESH DGV CODE DITO!!!!!
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
                    Dim filterID = Builders(Of BsonDocument).Filter.Eq(Of String)("_id", tbxReservID.Text)
                    Dim resUpdate = Builders(Of BsonDocument).Update.Set(Of String)("FName", tbxReservFName.Text).Set(Of String)("MName", tbxReservMName.Text).Set(Of String)("Sname", tbxReservSName.Text).Set(Of String)("tourName", cbxReservTour.SelectedItem.ToString).Set(Of String)("tourPrice", tbxReservTotal.Text).Set(Of String)("reservDate", dateTimeReserv.Value.ToString("yyyy-MM-ddTHH:mm:ssZ")).Set(Of String)("timeSlot", cbxReservTimeSlot.SelectedItem.ToString).Set(Of String)("status", cbxReservStatus.SelectedItem.ToString)
                    Dim updateResult = rmsSharedVar.colReserv.UpdateOne(filterID, resUpdate)
                    If updateResult.ModifiedCount > 0 Then
                        MessageBox.Show("Reservation updated successfully.")
                        'REFRESH DGV!!!!()
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
End Class