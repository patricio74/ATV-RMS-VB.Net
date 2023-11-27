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
    End Sub
    'suppress enter key sound sa mga textboxes
    Private Sub suppressKeyPre(sender As Object, e As KeyPressEventArgs) Handles usrFName.KeyPress, usrMName.KeyPress, usrSName.KeyPress,
    usrPhone.KeyPress, usrRFID.KeyPress, usrEmail.KeyPress, usrUsername.KeyPress, usrOldPword.KeyPress, usrPword.KeyPress, usrPword2.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub
    Private Sub loadUsrDoc()
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
                usrFName.Text = userDocument("First Name").AsString
                usrMName.Text = userDocument("Middle Name").AsString
                usrSName.Text = userDocument("Surname").AsString
                usrRFID.Text = userDocument("RFID").AsString
                usrEmail.Text = userDocument("Email").AsString
                usrPhone.Text = userDocument("Phone").AsString
                usrUsername.Text = userDocument("Username").AsString
                lblCreationDate.Text = userDocument("accountCreationDate").AsString
                usrPass = userDocument("Password")
            Else
                MessageBox.Show("User not found.")
            End If
        End If
    End Sub
    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        clearUsrInfo()
        loadUsrDoc()
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If admnTab.SelectedIndex = 0 Then 'user info
            If String.IsNullOrEmpty(usrFName.Text) OrElse String.IsNullOrEmpty(usrSName.Text) OrElse String.IsNullOrEmpty(usrUsername.Text) Then
                MessageBox.Show("Please fill in all fields to continue.")
            Else
                Dim updConfirmation As DialogResult = MessageBox.Show("Are you sure you want to update your info?", "Confirmation", MessageBoxButtons.YesNo)
                If updConfirmation = DialogResult.Yes Then
                    Try
                        Dim objctId As ObjectId
                        If ObjectId.TryParse(usrID, objctId) Then
                            Dim filter = Builders(Of BsonDocument).Filter.Eq(Function(doc) doc("_id"), objctId)
                            Dim update = Builders(Of BsonDocument).Update.Set(Of String)("First Name", usrFName.Text).
                                                                Set(Of String)("Middle Name", usrMName.Text).
                                                                Set(Of String)("Surname", usrSName.Text).
                                                                Set(Of String)("Username", usrUsername.Text)
                            rmsSharedVar.colAdmin.UpdateOne(filter, update)
                            MessageBox.Show("Account updated successfully!")
                            clearUsrInfo()
                            loadUsrDoc()
                        End If
                    Catch ex As Exception
                        MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        ElseIf admnTab.SelectedIndex = 1 Then 'contacts
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
                                                                Set(Of String)("Email", usrEmail.Text).
                                                                Set(Of String)("Phone", usrPhone.Text)
                            rmsSharedVar.colAdmin.UpdateOne(filter, update)
                            MessageBox.Show("Account updated successfully!")
                            clearUsrInfo()
                            loadUsrDoc()
                        End If
                    Catch ex As Exception
                        MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        ElseIf admnTab.SelectedIndex = 2 Then 'acc security
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
                                    Dim update = Builders(Of BsonDocument).Update.Set(Of String)("Password", usrPword2.Text)
                                    rmsSharedVar.colAdmin.UpdateOne(filter, update)
                                    MessageBox.Show("Account updated successfully!")
                                    clearUsrInfo()
                                    loadUsrDoc()
                                End If
                            Catch ex As Exception
                                MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        End If
                    End If
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
                    MessageBox.Show("Account deleted successfully.")
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
        loadUsrDoc
    End Sub
    Private Sub ctrlAdminSettings_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = False Then
            closeMongoConn()
            clearUsrInfo()
        ElseIf Me.Visible = True Then
            loadUsrDoc()
        End If
    End Sub
End Class
