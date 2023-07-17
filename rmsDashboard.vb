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
        btnReservations.ForeColor = Color.Goldenrod
        btnReservations.BackColor = ColorTranslator.FromHtml("#252525")
        admPanel.Controls.Clear()

    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        resetButtonColor()
        btnInventory.ForeColor = Color.Goldenrod
        btnInventory.BackColor = ColorTranslator.FromHtml("#252525")
        admPanel.Controls.Clear()

    End Sub

    Private Sub btnTGuides_Click(sender As Object, e As EventArgs) Handles btnTGuides.Click
        resetButtonColor()
        btnTGuides.ForeColor = Color.Goldenrod
        btnTGuides.BackColor = ColorTranslator.FromHtml("#252525")
        admPanel.Controls.Clear()

    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        resetButtonColor()
        btnCustomers.ForeColor = Color.Goldenrod
        btnCustomers.BackColor = ColorTranslator.FromHtml("#252525")
        admPanel.Controls.Clear()

    End Sub

    Private Sub btnNotif_Click(sender As Object, e As EventArgs) Handles btnNotif.Click
        resetButtonColor()
        btnNotif.ForeColor = Color.Goldenrod
        btnNotif.BackColor = ColorTranslator.FromHtml("#252525")
        admPanel.Controls.Clear()

    End Sub

    Private Sub btnTransacHist_Click(sender As Object, e As EventArgs) Handles btnTransacHist.Click
        resetButtonColor()
        btnTransacHist.ForeColor = Color.Goldenrod
        btnTransacHist.BackColor = ColorTranslator.FromHtml("#252525")
        admPanel.Controls.Clear()

    End Sub

    Private Sub btnRules_Click(sender As Object, e As EventArgs) Handles btnRules.Click
        resetButtonColor()
        btnRules.ForeColor = Color.Goldenrod
        btnRules.BackColor = ColorTranslator.FromHtml("#252525")
        admPanel.Controls.Clear()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        resetButtonColor()
        rmsLogin.Show()
    End Sub
End Class
