Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class ctrlTrails
    Private trailz As List(Of trailDoc)
    Public Class trailDoc
        Public Property trailID As String
        Public Property trailName As String
        Public Property duration As String
        Public Property minimumPax As String
        Public Property description As String
        Public Property price As String
        Public Property dateAdded As String
    End Class
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
    Private Sub textbx_Leave(sender As Object, e As EventArgs) Handles addTrailName.Leave, addDuration.Leave, addDescription.Leave, updTrailName.Leave, updDuration.Leave, updDescription.Leave
        'trim multiple space ng mga textboxes
        addTrailName.Text = System.Text.RegularExpressions.Regex.Replace(addTrailName.Text, "\s+", " ")
        addDuration.Text = System.Text.RegularExpressions.Regex.Replace(addDuration.Text, "\s+", " ")
        addDescription.Text = System.Text.RegularExpressions.Regex.Replace(addDescription.Text, "\s+", " ")
        addTrailName.Text = addTrailName.Text.Trim
        addDuration.Text = addDuration.Text.Trim
        addDescription.Text = addDescription.Text.Trim
        updTrailName.Text = System.Text.RegularExpressions.Regex.Replace(updTrailName.Text, "\s+", " ")
        updDuration.Text = System.Text.RegularExpressions.Regex.Replace(updDuration.Text, "\s+", " ")
        updDescription.Text = System.Text.RegularExpressions.Regex.Replace(updDescription.Text, "\s+", " ")
        updTrailName.Text = updTrailName.Text.Trim
        updDuration.Text = updDuration.Text.Trim
        updDescription.Text = updDescription.Text.Trim
    End Sub
    Private Sub populateTrails()
        If Me.Visible = True Then
            dgvTrails.Rows.Clear()
            Dim trailDocList As List(Of BsonDocument) = rmsSharedVar.colTrails.Find(New BsonDocument()).ToList()
            trailz = New List(Of trailDoc)()
            For Each document As BsonDocument In trailDocList
                Dim idElement = document.GetElement("_id")
                Dim traillist As New trailDoc() With {
                    .trailID = idElement.Value.AsObjectId.ToString,
                    .trailName = document("nameOfTour").ToString,
                    .description = document("description").ToString,
                    .minimumPax = document("minimumPax").ToString,
                    .duration = document("duration").ToString,
                    .price = document("price").ToString,
                    .dateAdded = document("dateAdded").ToString
                }
                trailz.Add(traillist)
            Next
            dgvTrails.Rows.Clear()
            For Each trail In trailz
                dgvTrails.Rows.Add(trail.trailID, trail.trailName, trail.description, trail.minimumPax, trail.duration, trail.price)
            Next
            dgvTrails.ClearSelection()
        End If
    End Sub
    Private Sub dgvTrails_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTrails.CellClick
        If e.RowIndex >= 0 Then
            tabTrails.SelectedIndex = 1 'update trails tab
            If trailz IsNot Nothing AndAlso e.RowIndex < trailz.Count Then
                Dim selectedTrail = trailz(e.RowIndex)
                lblUpdTrailID.Text = selectedTrail.trailID
                updTrailName.Text = selectedTrail.trailName
                updDescription.Text = selectedTrail.description
                updMinPerson.Text = selectedTrail.minimumPax
                updDuration.Text = selectedTrail.duration
                updPrice.Text = selectedTrail.price
            End If
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
            'check muna kung may blangko sa form bago mag-update
            If String.IsNullOrEmpty(addTrailName.Text) OrElse String.IsNullOrEmpty(addDuration.Text) OrElse String.IsNullOrEmpty(addMinPerson.Text) OrElse String.IsNullOrEmpty(addPrice.Text) OrElse String.IsNullOrEmpty(addDescription.Text) Then
                MessageBox.Show("Please fill in all fields to continue.")
            Else
                Dim addConfirmation As DialogResult = MessageBox.Show("Do you want to add this trail to the database?", "Confirmation", MessageBoxButtons.YesNo)
                If addConfirmation = DialogResult.Yes Then
                    Dim newTrail As String = addTrailName.Text
                    Dim newDuration As String = addDuration.Text
                    Dim newPerson As String = addMinPerson.Text
                    Dim newPrice As String = addPrice.Text
                    Dim newDescr As String = addDescription.Text
                    Dim newDate As String = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ")
                    Dim docNewTrail As New BsonDocument() From {
                        {"nameOfTour", newTrail},
                        {"duration", newDuration},
                        {"minimumPax", newPerson},
                        {"price", newPrice},
                        {"description", newDescr},
                        {"dateAdded", newDate}
                    }
                    Try
                        rmsSharedVar.colTrails.InsertOne(docNewTrail)
                        MessageBox.Show("New trail added to the database")
                        clearAddForm()
                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If

        ElseIf sender Is btnUpdTrail Then
            If dgvTrails.SelectedRows.Count > 0 Then
                Dim selectedRow = dgvTrails.SelectedRows(0)
                Dim selectedTrail = trailz(selectedRow.Index)
                Dim trailID As String = selectedTrail.trailID
                If String.IsNullOrEmpty(updTrailName.Text) OrElse String.IsNullOrEmpty(updDuration.Text) OrElse String.IsNullOrEmpty(updMinPerson.Text) OrElse String.IsNullOrEmpty(updPrice.Text) OrElse String.IsNullOrEmpty(updDescription.Text) Then
                    MessageBox.Show("Please fill in all fields to continue.")
                Else
                    Dim updConfirmation As DialogResult = MessageBox.Show("Do you want to update this trail?", "Confirmation", MessageBoxButtons.YesNo)
                    If updConfirmation = DialogResult.Yes Then
                        Try
                            Dim objectId As ObjectId
                            If ObjectId.TryParse(trailID, objectId) Then
                                Dim filter = Builders(Of BsonDocument).Filter.Eq(Function(doc) doc("_id"), objectId)
                                Dim update = Builders(Of BsonDocument).Update.Set(Of String)("nameOfTour", updTrailName.Text).
                                Set(Of String)("duration", updDuration.Text).
                                Set(Of String)("minimumPax", updMinPerson.Text).
                                Set(Of String)("price", updPrice.Text).
                                Set(Of String)("description", updDescription.Text)
                                rmsSharedVar.colTrails.UpdateOne(filter, update)
                                MessageBox.Show("ATV Trail updated successfully.")
                                populateTrails()
                                clearUpdateForm()
                            End If
                        Catch ex As Exception
                            MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If
                End If
            Else
                MessageBox.Show("Please select an ATV trail to update.")
                populateTrails()
            End If

        ElseIf sender Is btnDelTrail Then
            If dgvTrails.SelectedRows.Count > 0 Then
                Dim selectedTrail = trailz(dgvTrails.SelectedRows(0).Index)
                Dim trailID As String = selectedTrail.trailID
                Dim delConfirmation = MessageBox.Show("Are you sure you want to remove this trail?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                'move customer data to archive collection
                If delConfirmation = DialogResult.Yes Then
                    moveToArchive(trailID)
                ElseIf delConfirmation = DialogResult.No Then
                    populateTrails()
                End If
            Else
                MessageBox.Show("No trail selected for deletion.")
                populateTrails()
            End If
        End If
    End Sub
    Private Sub moveToArchive(trailID As String)
        Try
            Dim objectId As ObjectId
            If ObjectId.TryParse(trailID, objectId) Then
                Dim filter = Builders(Of BsonDocument).Filter.Eq(Function(doc) doc("_id"), objectId)
                Dim document = rmsSharedVar.colTrails.Find(filter).FirstOrDefault()
                If document IsNot Nothing Then
                    'Add date to accountDeletionDate bago iarchive
                    document.Add("accountDeletionDate", DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                    rmsSharedVar.archiveTrail.InsertOne(document)
                    rmsSharedVar.colTrails.DeleteOne(filter)
                    MessageBox.Show("ATV trail deleted successfully.")
                    populateTrails()
                    clearUpdateForm()
                Else
                    MessageBox.Show("ATV trail not found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    populateTrails()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            populateTrails()
        End Try
    End Sub
    Private Sub lblClear_Click(sender As Object, e As EventArgs) Handles lblClearAdd.Click, lblClearUpdate.Click
        If sender Is lblClearAdd Then
            clearAddForm()
        ElseIf sender Is lblClearUpdate Then
            clearUpdateForm()
        End If
    End Sub
    Private Sub numberz_TextChanged(sender As Object, e As KeyPressEventArgs) Handles addMinPerson.KeyPress, addPrice.KeyPress, updMinPerson.KeyPress, updPrice.KeyPress
        'check if the inputted char is a number,backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
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
End Class
