Public Class rmsRegistration
    Private Sub labelLogin_Click(sender As Object, e As EventArgs) Handles labelLogin.Click
        rmsLogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        clearRegForm()
        rmsLogin.Close()
    End Sub
End Class