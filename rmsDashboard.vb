Public Class rmsDashboard

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        rmsLogin.Close()
    End Sub

    Private Sub btnReservations_Click(sender As Object, e As EventArgs) Handles btnReservations.Click
        resetButtonColor()
        activeButtonColor(sender, e)
        admPanel.Controls.Clear()

    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        resetButtonColor()
        activeButtonColor(sender, e)
        admPanel.Controls.Clear()

    End Sub

    Private Sub btnTGuides_Click(sender As Object, e As EventArgs) Handles btnTGuides.Click
        resetButtonColor()
        activeButtonColor(sender, e)
        admPanel.Controls.Clear()

    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        resetButtonColor()
        activeButtonColor(sender, e)
        admPanel.Controls.Clear()

    End Sub

    Private Sub btnNotif_Click(sender As Object, e As EventArgs) Handles btnNotif.Click
        resetButtonColor()
        activeButtonColor(sender, e)
        admPanel.Controls.Clear()

    End Sub

    Private Sub btnTransacHist_Click(sender As Object, e As EventArgs) Handles btnTransacHist.Click
        resetButtonColor()
        activeButtonColor(sender, e)
        admPanel.Controls.Clear()

    End Sub

    Private Sub btnRules_Click(sender As Object, e As EventArgs) Handles btnRules.Click
        resetButtonColor()
        activeButtonColor(sender, e)
        admPanel.Controls.Clear()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        resetButtonColor()
        admPanel.Controls.Clear()
        loadRMSLogin()
        clearLoginForm()
        rmsLogin.Show()
    End Sub


End Class
