Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class atvMaintenance
    Private Sub clearForm()
        cbxType.SelectedIndex = -1
        tbxOtherInfo.Clear()
        tbxCost.Clear()
    End Sub
    Private Sub lblClearForm_Click(sender As Object, e As EventArgs) Handles lblClearForm.Click
        clearForm()
    End Sub
    'suppress enter key sound sa mga textboxes
    Private Sub suppressKeyPre(sender As Object, e As KeyPressEventArgs) Handles tbxOtherInfo.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbxCost.KeyPress
        'check if the inputted char is a number,backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True ' Suppress the key press
        End If
    End Sub
    Private Sub btnSaveMaintenanceInfo_Click(sender As Object, e As EventArgs) Handles btnSaveMaintenanceInfo.Click
        'check muna kung may blangko sa form bago mag-update
        If cbxType.SelectedIndex = -1 OrElse String.IsNullOrEmpty(tbxOtherInfo.Text) OrElse String.IsNullOrEmpty(tbxCost.Text) Then
            MessageBox.Show("Please fill in all fields to continue.")
        Else
            If rmsSharedVar.maintenanceID IsNot Nothing Then
                'insert info sa logs
                Dim maintType As String = cbxType.Text
                Dim maintOtherInfo As String = tbxOtherInfo.Text
                Dim maintCost As String = tbxCost.Text
                Dim maintDate As String = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ")
                Dim docNewAtv As New BsonDocument() From {
                    {"atvID", rmsSharedVar.maintenanceID.ToString},
                    {"maintenanceType", maintType},
                    {"otherType", maintOtherInfo},
                    {"maintenanceCost", maintCost},
                    {"maintenanceDate", maintDate}
                }
                Try
                    rmsSharedVar.colAtvMaintenance.InsertOne(docNewAtv)
                    MessageBox.Show("ATV maintenance info saved.")
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                'update status ng selected atv to "MAINTENANCE"
                Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("_id", rmsSharedVar.maintenanceID)
                Dim update As UpdateDefinition(Of BsonDocument) = Builders(Of BsonDocument).Update.Set(Of String)("status", "MAINTENANCE")
                rmsSharedVar.colInventory.UpdateOne(filter, update)
            Else
                MessageBox.Show("ATV ID is empty.")
            End If
        End If
    End Sub
    Private Sub atvMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initializeDraggablePanel(panelTop)
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim response As DialogResult = MessageBox.Show("Are you sure you want to clear the selection and exit?", "Confirmation", MessageBoxButtons.YesNo)
        If response = DialogResult.Yes Then
            rmsSharedVar.maintenanceID = Nothing
            rmsSharedVar.openMaintenanceForm = False
            clearForm()
            Me.Close()
        End If
    End Sub
    Private Sub atvMaintenance_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        rmsSharedVar.maintenanceID = Nothing
        rmsSharedVar.openMaintenanceForm = False
        clearForm()
    End Sub
End Class