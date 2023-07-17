Public Class rmsLogin
    Private Sub rmsLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelRFIDLogin.Hide()
        panelPassLogin.Show()
        labelPassSwitch.Hide()
        labelRFIDSwitch.Show()
        checkShow.Checked = False
        tboxUsername.Focus()
    End Sub
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub labelRFID_Click(sender As Object, e As EventArgs) Handles labelRFIDSwitch.Click
        panelRFIDLogin.Show()
        panelPassLogin.Hide()
        labelPassSwitch.Show()
        labelRFIDSwitch.Hide()
        tboxPassword.Clear()
        checkShow.Checked = False
        tboxRFID.Focus()
    End Sub
    Private Sub labelPassSwitch_Click(sender As Object, e As EventArgs) Handles labelPassSwitch.Click
        panelRFIDLogin.Hide()
        panelPassLogin.Show()
        labelPassSwitch.Hide()
        labelRFIDSwitch.Show()
        tboxRFID.Clear()
        checkShow.Checked = False
        tboxUsername.Focus()
    End Sub

    Private Sub labelForgotPass_Click(sender As Object, e As EventArgs) Handles labelForgotPass.Click
        'add code para ireset yung pass. send sms code gamit gsm module pag may match na username sa db
        MessageBox.Show("Relax and try to remember your password.", "Forgot Password?", MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub

    Private Sub labelRegister_Click(sender As Object, e As EventArgs) Handles labelRegister.Click
        Process.Start("https://youtu.be/dQw4w9WgXcQ")
    End Sub

    Private Sub checkShow_CheckedChanged(sender As Object, e As EventArgs) Handles checkShow.CheckedChanged
        If checkShow.Checked = True Then
            tboxPassword.UseSystemPasswordChar = False
            tboxPassword.Focus()
        Else
            tboxPassword.UseSystemPasswordChar = True
            tboxPassword.Focus()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        rmsDashboard.Show()
        Me.Hide()
    End Sub
End Class