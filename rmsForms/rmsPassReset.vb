Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class rmsPassReset
    Dim searchUsername As String
    Dim searchEmail As String
    Private Sub resetPanel()
        panelResetUsername.Visible = True
        panelResetEmail.Visible = False
        panelResetNewPass.Visible = False
        tbxResetUsername.Focus()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim response As DialogResult = MessageBox.Show("Cancel password reset and return to Login?", "Confirmation", MessageBoxButtons.YesNo)
        If response = DialogResult.Yes Then
            Me.Close()
            rmsLogin.StartPosition = FormStartPosition.CenterScreen
            rmsLogin.Show()
        End If
    End Sub
    Private Sub lblReturnToLogin_Click(sender As Object, e As EventArgs) Handles lblReturnToLogin.Click
        Me.Close()
        rmsLogin.Show()
    End Sub
    Private Sub lblReturnToUsername_Click(sender As Object, e As EventArgs) Handles lblReturnToUsername.Click
        resetPanel()
        tbxResetUsername.Focus()
    End Sub
    Private Sub lblResetReturnToEmail_Click(sender As Object, e As EventArgs) Handles lblResetReturnToEmail.Click
        panelResetUsername.Visible = False
        panelResetEmail.Visible = True
        panelResetNewPass.Visible = False
        tbxResetEmail.Focus()
    End Sub
    Private Sub btnResetContinue_Click(sender As Object, e As EventArgs) Handles btnResetContinue.Click
        searchUsername = tbxResetUsername.Text.Trim()
        If tbxResetUsername.Text = "" Then
            tbxResetUsername.Focus()
        Else
            'search for username in the database
            Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("username", searchUsername)
            Dim userExists = rmsSharedVar.colAdmin.Find(filter).Any()
            If userExists Then
                'proceed to the next panel if theres a mathc
                lblResetUsernameError.Visible = False
                panelResetUsername.Visible = False
                panelResetEmail.Visible = True
                panelResetNewPass.Visible = False
                tbxResetEmail.Focus()
            Else
                'user not found, show an error message
                lblResetUsernameError.Visible = True
            End If
        End If
    End Sub
    Private Sub btnResetEmailContinue_Click(sender As Object, e As EventArgs) Handles btnResetEmailContinue.Click
        searchEmail = tbxResetEmail.Text.Trim()
        If tbxResetEmail.Text = "" Then
            tbxResetEmail.Focus()
        Else
            'check if email matches w/ username in db
            Dim filter = Builders(Of BsonDocument).Filter.And(
            Builders(Of BsonDocument).Filter.Eq(Of String)("username", searchUsername),
            Builders(Of BsonDocument).Filter.Eq(Of String)("email", searchEmail)
        )
            Dim emailMatch = rmsSharedVar.colAdmin.Find(filter).Any()
            If emailMatch Then
                'proceed to the next panel
                lblResetEmailError.Visible = False
                panelResetUsername.Visible = False
                panelResetEmail.Visible = False
                panelResetNewPass.Visible = True
                tbxResetNewPass.Focus()
            Else
                'email does not match
                lblResetEmailError.Visible = True
            End If
        End If
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim newPass As String = tbxResetNewPass.Text.Trim()
        Dim confirmPass As String = tbxResetNewPass2.Text.Trim
        If tbxResetNewPass.Text = "" Or tbxResetNewPass2.Text = "" Then
            If tbxResetNewPass.Text = "" Then
                tbxResetNewPass.Focus()
            ElseIf tbxResetNewPass2.Text = "" Then
                tbxResetNewPass2.Focus()
            End If
        Else
                If newPass = confirmPass AndAlso newPass.Length >= 8 Then
                Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("username", searchUsername)
                Dim updatePass = Builders(Of BsonDocument).Update.Set(Of String)("password", newPass)
                'perform pass reset
                Dim result = rmsSharedVar.colAdmin.UpdateOne(filter, updatePass)
                If result.ModifiedCount > 0 Then
                    lblResetPassError.Visible = False
                    MessageBox.Show("Password reset successful! You may now login your account.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    rmsLogin.Show()
                    Me.Close()
                Else
                    MessageBox.Show("Failed to update password. Please try again.")
                End If
            Else
                'show error
                lblResetPassError.Visible = True
            End If
        End If
    End Sub
    Private Sub tbxReset_TextChanged(sender As Object, e As EventArgs) Handles tbxResetUsername.TextChanged, tbxResetEmail.TextChanged, tbxResetNewPass.TextChanged, tbxResetNewPass2.TextChanged
        If sender Is tbxResetUsername Then
            Dim cursorPos As Integer = tbxResetUsername.SelectionStart
            'para walang space na ma-input
            tbxResetUsername.Text = tbxResetUsername.Text.Replace(" ", "")
            tbxResetUsername.SelectionStart = cursorPos
        ElseIf sender Is tbxResetEmail Then
            Dim cursorPos As Integer = tbxResetEmail.SelectionStart
            'para walang space na ma-input
            tbxResetEmail.Text = tbxResetEmail.Text.Replace(" ", "")
            tbxResetEmail.SelectionStart = cursorPos
        ElseIf sender Is tbxResetNewPass Then
            Dim cursorPos As Integer = tbxResetNewPass.SelectionStart
            'para walang space na ma-input
            tbxResetNewPass.Text = tbxResetNewPass.Text.Replace(" ", "")
            tbxResetNewPass.SelectionStart = cursorPos
        ElseIf sender Is tbxResetNewPass2 Then
            Dim cursorPos As Integer = tbxResetNewPass2.SelectionStart
            'para walang space na ma-input
            tbxResetNewPass2.Text = tbxResetNewPass2.Text.Replace(" ", "")
            tbxResetNewPass2.SelectionStart = cursorPos
        End If
    End Sub
    Private Sub rmsPassReset_Load(sender As Object, e As EventArgs) Handles Me.Load
        initializeDraggablePanel(panelTop)
        resetPanel()
    End Sub
    Private Sub rmsPassReset_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = False Then
            'closeMongoConn()
            searchUsername = Nothing
            searchEmail = Nothing
        ElseIf Me.Visible = True Then
            resetPanel()
            tbxResetUsername.Focus()
        End If
    End Sub
End Class