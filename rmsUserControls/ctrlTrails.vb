Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class ctrlTrails
    Private Sub clearAddForm()
        populateTrails()
        dgvTrails.ClearSelection()
        addTrailName.Clear()
        addDescription.Clear()
        addMinPerson.Clear()
        addDuration.Clear()
        addPrice.Clear()
    End Sub
    Private Sub clearUpdateForm()
        populateTrails()
        dgvTrails.ClearSelection()
        lblUpdTrailID.Text = ""
        updTrailName.Clear()
        updDescription.Clear()
        updMinPerson.Clear()
        updDuration.Clear()
        updPrice.Clear()
    End Sub
    Private Sub ctrlTrails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateTrails()
    End Sub
    'suppress enter key sound sa mga textboxes
    Private Sub suppressKeyPre(sender As Object, e As KeyPressEventArgs) Handles addTrailName.KeyPress, addDuration.KeyPress, addMinPerson.KeyPress,
        addPrice.KeyPress, addDescription.KeyPress, updTrailName.KeyPress, updDuration.KeyPress, updMinPerson.KeyPress, updPrice.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub
    Private Sub textbx_Leave(sender As Object, e As EventArgs) Handles addTrailName.Leave, addDuration.Leave, addDescription.Leave
        'trim multiple space ng mga textboxes
        addTrailName.Text = System.Text.RegularExpressions.Regex.Replace(addTrailName.Text, "\s+", " ")
        addDuration.Text = System.Text.RegularExpressions.Regex.Replace(addDuration.Text, "\s+", " ")
        addDescription.Text = System.Text.RegularExpressions.Regex.Replace(addDescription.Text, "\s+", " ")
        addTrailName.Text = addTrailName.Text.Trim
        addDuration.Text = addDuration.Text.Trim
        addDescription.Text = addDescription.Text.Trim
        updTrailName.Text = System.Text.RegularExpressions.Regex.Replace(updTrailName.Text, "\s+", " ")
        updDuration.Text = System.Text.RegularExpressions.Regex.Replace(updTrailName.Text, "\s+", " ")
        updDescription.Text = System.Text.RegularExpressions.Regex.Replace(updTrailName.Text, "\s+", " ")
        updTrailName.Text = updTrailName.Text.Trim
        updDuration.Text = updTrailName.Text.Trim
        updDescription.Text = updTrailName.Text.Trim
    End Sub
    Private Sub populateTrails()
        If Me.Visible = True Then
            Dim colTrails = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("rmsAtvTours")
            Dim filter = Builders(Of BsonDocument).Filter.Empty
            Dim trailzList = colTrails.Find(filter).ToList()
            dgvTrails.Rows.Clear()
            For Each doc As BsonDocument In trailzList
                Dim trailID As String = doc("_id").AsObjectId.ToString
                Dim trailName As String = doc("nameOfTour").AsString
                Dim trailDesc As String = doc("description").AsString
                Dim trailMinPerson As String = doc("minimumPax").AsString
                Dim trailDuration As String = doc("duration").AsString
                Dim trailPrice As String = doc("price").AsString
                dgvTrails.Rows.Add(trailID, trailName, trailDesc, trailMinPerson, trailDuration, trailPrice)
                dgvTrails.ClearSelection()
            Next
        End If
    End Sub
    Private Sub dgvTrails_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTrails.CellClick
        If dgvTrails.SelectedRows.Count > 0 Then
            tabTrails.SelectedIndex = 1 'update trails tab
            Dim selectedRow As DataGridViewRow = dgvTrails.SelectedRows(0)
            Dim selectedId As String = selectedRow.Cells("Column1").Value.ToString()
            Dim selectedName As String = selectedRow.Cells("Column2").Value.ToString()
            Dim selectedDesc As String = selectedRow.Cells("Column3").Value.ToString()
            Dim selectedPerson As String = selectedRow.Cells("Column4").Value.ToString()
            Dim selectedDuration As String = selectedRow.Cells("Column5").Value.ToString()
            Dim selectedPrice As String = selectedRow.Cells("Column6").Value.ToString()
            lblUpdTrailID.Text = selectedId
            updTrailName.Text = selectedName
            updDescription.Text = selectedDesc
            updMinPerson.Text = selectedPerson
            updDuration.Text = selectedDuration
            updPrice.Text = selectedPrice
        End If
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabTrails.SelectedIndexChanged
        If tabTrails.SelectedIndex = 0 Then 'add trail tab
            clearUpdateForm()
        ElseIf tabTrails.SelectedIndex = 1 Then 'update trail tab
            'clearAddForm()
        End If
    End Sub
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnAddTrail.Click, btnUpdTrail.Click, btnDelTrail.Click
        If sender Is btnAddTrail Then
            'check muna kung nafill out lahat ng form bago mag-update
            If String.IsNullOrEmpty(addTrailName.Text) OrElse String.IsNullOrEmpty(addDuration.Text) OrElse String.IsNullOrEmpty(addMinPerson.Text) OrElse String.IsNullOrEmpty(addPrice.Text) OrElse String.IsNullOrEmpty(addDescription.Text) Then
                MessageBox.Show("Please fill in all fields to continue.")
            Else
                Dim addConfirmation As DialogResult = MessageBox.Show("Do you want to add this trail to the database?", "Confirmation", MessageBoxButtons.YesNo)
                If addConfirmation = DialogResult.Yes Then
                    Dim colTrails = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("rmsAtvTours")
                    Dim newTrail As String = addTrailName.Text
                    Dim newDuration As String = addDuration.Text
                    Dim newPerson As String = addMinPerson.Text
                    Dim newPrice As String = addPrice.Text
                    Dim newDescr As String = addDescription.Text
                    Dim newDate As String = DateTime.UtcNow.ToString("o")
                    Dim docNewTrail As New BsonDocument() From {
                        {"nameOfTour", newTrail},
                        {"duration", newDuration},
                        {"minimumPax", newPerson},
                        {"price", newPrice},
                        {"description", newDescr},
                        {"dateAdded", newDate}
                    }
                    Try
                        colTrails.InsertOne(docNewTrail)
                        MessageBox.Show("New trail added to the database")
                        clearAddForm()
                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If

        ElseIf sender Is btnUpdTrail Then
            'check muna kung nafill out lahat ng form bago mag-update
            If String.IsNullOrEmpty(updTrailName.Text) OrElse String.IsNullOrEmpty(updDuration.Text) OrElse String.IsNullOrEmpty(updMinPerson.Text) OrElse String.IsNullOrEmpty(updPrice.Text) OrElse String.IsNullOrEmpty(updDescription.Text) Then
                MessageBox.Show("Please fill in all fields to continue.")
            Else
                Dim updConfirmation As DialogResult = MessageBox.Show("Do you want to update this trail?", "Confirmation", MessageBoxButtons.YesNo)
                If updConfirmation = DialogResult.Yes Then



                    'update doc where id=updTrailID.text



                    clearUpdateForm()
                End If
            End If

        ElseIf sender Is btnDelTrail Then
            Dim addConfirmation As DialogResult = MessageBox.Show("Are you sure you want to delete this trail?", "Confirmation", MessageBoxButtons.YesNo)
            If addConfirmation = DialogResult.Yes Then
                If dgvTrails.SelectedRows.Count > 0 Then
                    Dim selectedTrail As String = dgvTrails.SelectedRows(0).Cells("Column1").Value.ToString()
                    Dim objectId As ObjectId
                    If ObjectId.TryParse(selectedTrail, objectId) Then
                        Dim delFilter = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", objectId)
                        Dim colTrails = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("rmsAtvTours")
                        colTrails.DeleteOne(delFilter)


                        'insert copy to archive coll

                        clearUpdateForm()
                    Else
                        MessageBox.Show("Unable to delete ATV Trail.")
                    End If
                Else
                    MessageBox.Show("No row selected for deletion.")
                End If
            End If
        End If
    End Sub
    Private Sub lblClear_Click(sender As Object, e As EventArgs) Handles lblClearAdd.Click, lblClearUpdate.Click
        If sender Is lblClearAdd Then
            clearAddForm()
        ElseIf sender Is lblClearUpdate Then
            clearUpdateForm()
        End If
    End Sub
    Private Sub ctrlTrails_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = False Then
            closeMongoConn()
            clearAddForm()
            clearUpdateForm()
            tabTrails.SelectedIndex = 0
        End If
    End Sub
    Private Sub numberz_TextChanged(sender As Object, e As KeyPressEventArgs) Handles addMinPerson.KeyPress, addPrice.KeyPress, updMinPerson.KeyPress, updPrice.KeyPress
        'check if the inputted char is a number,backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
