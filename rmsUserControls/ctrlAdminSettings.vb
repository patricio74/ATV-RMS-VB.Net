Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class ctrlAdminSettings
    Private originalUserData As BsonDocument 'store the original user data
    Dim usrID = rmsSharedVar.admnID
    Dim usrPass As String
    Private Sub clearUsrInfo()
        usrFName.Clear()
        usrMName.Clear()
        usrSName.Clear()
        usrRFID.Clear()
        usrEmail.Clear()
        usrPhone.Clear()
        usrUsername.Clear()
        usrOldPword.Clear()
        usrPword.Clear()
        usrPword2.Clear()
        lblCreationDate.Text = "----------"
        lblUsrRole.Text = "----------"
    End Sub
    'suppress enter key sound sa mga textboxes
    Private Sub suppressKeyPre(sender As Object, e As KeyPressEventArgs) Handles usrFName.KeyPress, usrMName.KeyPress, usrSName.KeyPress,
    usrPhone.KeyPress, usrRFID.KeyPress, usrEmail.KeyPress, usrUsername.KeyPress, usrOldPword.KeyPress, usrPword.KeyPress, usrPword2.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub
    Private Sub loadUsrDoc()
        If rmsDashboard.switchSett = True Then
            'find the user by _id
            Dim objctId As ObjectId
            If ObjectId.TryParse(usrID, objctId) Then
                Dim filter = Builders(Of BsonDocument).Filter.Eq(Function(doc) doc("_id"), objctId)
                'find usr docu
                Dim userDocument = rmsSharedVar.colAdmin.Find(filter).FirstOrDefault()
                If userDocument IsNot Nothing Then
                    'save the original doc for later comparison
                    originalUserData = userDocument
                    'populate form
                    usrFName.Text = userDocument("FName").AsString
                    usrMName.Text = userDocument("MName").AsString
                    usrSName.Text = userDocument("Sname").AsString
                    usrRFID.Text = userDocument("RFID").AsString
                    usrEmail.Text = userDocument("email").AsString
                    usrPhone.Text = userDocument("phone").AsString
                    usrUsername.Text = userDocument("username").AsString
                    lblCreationDate.Text = userDocument("accountCreationDate").AsString
                    lblUsrRole.Text = userDocument("role").AsString
                    usrPass = userDocument("password")
                Else
                    MessageBox.Show("User not found.")
                End If
            End If
        End If
    End Sub
    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        clearUsrInfo()
        loadUsrDoc()
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If tabAdmn.SelectedIndex = 0 Then 'user info
            If String.IsNullOrEmpty(usrFName.Text) OrElse String.IsNullOrEmpty(usrSName.Text) OrElse String.IsNullOrEmpty(usrUsername.Text) Then
                MessageBox.Show("Please fill in all fields to continue.")
            Else
                Dim updConfirmation As DialogResult = MessageBox.Show("Are you sure you want to update your info?", "Confirmation", MessageBoxButtons.YesNo)
                If updConfirmation = DialogResult.Yes Then
                    Try
                        Dim objctId As ObjectId
                        If ObjectId.TryParse(usrID, objctId) Then
                            Dim filter = Builders(Of BsonDocument).Filter.Eq(Function(doc) doc("_id"), objctId)
                            Dim update = Builders(Of BsonDocument).Update.Set(Of String)("FName", usrFName.Text).
                                                                Set(Of String)("MName", usrMName.Text).
                                                                Set(Of String)("Sname", usrSName.Text).
                                                                Set(Of String)("username", usrUsername.Text)
                            rmsSharedVar.colAdmin.UpdateOne(filter, update)
                            MessageBox.Show("Account updated successfully!")
                            rmsSharedVar.currentUser = usrFName.Text + " " + usrMName.Text + " " + usrSName.Text
                            rmsDashboard.btnAdminSettings.Text = rmsSharedVar.currentUser
                            clearUsrInfo()
                            loadUsrDoc()
                        End If
                    Catch ex As Exception
                        MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                ElseIf updConfirmation = DialogResult.No Then
                    clearUsrInfo()
                    loadUsrDoc()
                End If
            End If
        ElseIf tabAdmn.SelectedIndex = 1 Then 'contacts
            If String.IsNullOrEmpty(usrRFID.Text) OrElse String.IsNullOrEmpty(usrEmail.Text) OrElse String.IsNullOrEmpty(usrPhone.Text) Then
                MessageBox.Show("Please fill in all fields to continue.")
            Else
                Dim updConfirmation As DialogResult = MessageBox.Show("Are you sure you want to update your info?", "Confirmation", MessageBoxButtons.YesNo)
                If updConfirmation = DialogResult.Yes Then
                    Try
                        Dim objctId As ObjectId
                        If ObjectId.TryParse(usrID, objctId) Then
                            Dim filter = Builders(Of BsonDocument).Filter.Eq(Function(doc) doc("_id"), objctId)
                            Dim update = Builders(Of BsonDocument).Update.Set(Of String)("RFID", usrRFID.Text).
                                                                Set(Of String)("email", usrEmail.Text).
                                                                Set(Of String)("phone", usrPhone.Text)
                            rmsSharedVar.colAdmin.UpdateOne(filter, update)
                            MessageBox.Show("Contact details updated successfully!")
                            clearUsrInfo()
                            loadUsrDoc()
                        End If
                    Catch ex As Exception
                        MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                ElseIf updConfirmation = DialogResult.No Then
                    clearUsrInfo()
                    loadUsrDoc()
                End If
            End If
        ElseIf tabAdmn.SelectedIndex = 2 Then 'acc security
            If String.IsNullOrEmpty(usrOldPword.Text) OrElse String.IsNullOrEmpty(usrPword.Text) OrElse String.IsNullOrEmpty(usrPword2.Text) OrElse usrPword2.Text = usrPass Then
                MessageBox.Show("Please make sure to fill in all fields/new password is not the same with your current password.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                clearUsrInfo()
                loadUsrDoc()
            Else
                Dim updConfirmation As DialogResult = MessageBox.Show("Are you sure you want to update your info?", "Confirmation", MessageBoxButtons.YesNo)
                If updConfirmation = DialogResult.Yes Then
                    If usrOldPword.Text <> usrPass Then
                        MessageBox.Show("The current password you entered does not match with the database record!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        If usrPword.Text <> usrPword2.Text Then
                            MessageBox.Show("New password does not matched! Please re-enter your new password.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            Try
                                Dim objectId As ObjectId
                                If ObjectId.TryParse(usrID, objectId) Then
                                    Dim filter = Builders(Of BsonDocument).Filter.Eq(Function(doc) doc("_id"), objectId)
                                    Dim update = Builders(Of BsonDocument).Update.Set(Of String)("password", usrPword2.Text)
                                    rmsSharedVar.colAdmin.UpdateOne(filter, update)
                                    MessageBox.Show("Password updated successfully!")
                                    clearUsrInfo()
                                    loadUsrDoc()
                                End If
                            Catch ex As Exception
                                MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        End If
                    End If
                ElseIf updConfirmation = DialogResult.No Then
                    clearUsrInfo()
                    loadUsrDoc()
                End If
            End If
        End If
    End Sub
    Private Sub btnDeleteAcc_Click(sender As Object, e As EventArgs) Handles btnDeleteAcc.Click
        'move to archive then back to login form
        Dim result = MessageBox.Show("Are you sure you want to delete your account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            moveToArchive(usrID)
        ElseIf result = DialogResult.No Then
        End If
    End Sub
    'move account to archive collection
    Private Sub moveToArchive(usrID As String)
        Try
            Dim objectId As ObjectId
            If ObjectId.TryParse(usrID, objectId) Then
                Dim filter = Builders(Of BsonDocument).Filter.Eq(Function(doc) doc("_id"), objectId)
                Dim document = rmsSharedVar.colAdmin.Find(filter).FirstOrDefault()
                If document IsNot Nothing Then
                    'Add date to accountDeletionDate bago iarchive
                    document.Add("accountDeletionDate", DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                    rmsSharedVar.archiveAdmin.InsertOne(document)
                    rmsSharedVar.colAdmin.DeleteOne(filter)
                    MessageBox.Show("Account deleted successfully!")
                    clearUsrInfo()
                    rmsDashboard.Close()
                    loadRMSLogin()
                    rmsLogin.Show()
                    rmsLogin.tboxUsername.Focus()
                Else
                    MessageBox.Show("Account not found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            loadUsrDoc()
        End Try
    End Sub
    Private Sub ctrlAdminSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadUsrDoc()
    End Sub
    Private Sub ctrlAdminSettings_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = False Then
            'closeMongoConn()
            clearUsrInfo()
            tabAdmn.SelectedIndex = 0
        ElseIf Me.Visible = True Then
            loadUsrDoc()
        End If
    End Sub
    Private Sub settings_TextChanged(sender As Object, e As EventArgs) Handles usrUsername.TextChanged, usrPhone.TextChanged, usrRFID.TextChanged, usrEmail.TextChanged,
        usrPword2.TextChanged, usrPword.TextChanged, usrOldPword.TextChanged
        'para walang space na ma-input
        If sender Is usrUsername Then
            Dim cursorPos As Integer = usrUsername.SelectionStart
            usrUsername.Text = usrUsername.Text.Replace(" ", "")
            usrUsername.SelectionStart = cursorPos
        ElseIf sender Is usrPhone Then
            Dim cursorPos As Integer = usrPhone.SelectionStart
            usrPhone.Text = usrPhone.Text.Replace(" ", "")
            usrPhone.SelectionStart = cursorPos
        ElseIf sender Is usrRFID Then
            Dim cursorPos As Integer = usrRFID.SelectionStart
            usrRFID.Text = usrRFID.Text.Replace(" ", "")
            usrRFID.SelectionStart = cursorPos
        ElseIf sender Is usrEmail Then
            Dim cursorPos As Integer = usrEmail.SelectionStart
            usrEmail.Text = usrEmail.Text.Replace(" ", "")
            usrEmail.SelectionStart = cursorPos
        ElseIf sender Is usrOldPword Then
            Dim cursorPos As Integer = usrOldPword.SelectionStart
            usrOldPword.Text = usrOldPword.Text.Replace(" ", "")
            usrOldPword.SelectionStart = cursorPos
        ElseIf sender Is usrPword Then
            Dim cursorPos As Integer = usrPword.SelectionStart
            usrPword.Text = usrPword.Text.Replace(" ", "")
            usrPword.SelectionStart = cursorPos
        ElseIf sender Is usrPword2 Then
            Dim cursorPos As Integer = usrPword2.SelectionStart
            usrPword2.Text = usrPword2.Text.Replace(" ", "")
            usrPword2.SelectionStart = cursorPos
        End If
    End Sub
End Class