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
        btnReservations.ForeColor = ColorTranslator.FromHtml("#151515")
        btnReservations.BackColor = ColorTranslator.FromHtml("#ffc048")
        admPanel.Controls.Clear()

    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        resetButtonColor()
        btnInventory.ForeColor = ColorTranslator.FromHtml("#151515")
        btnInventory.BackColor = ColorTranslator.FromHtml("#ffc048")
        admPanel.Controls.Clear()

    End Sub

    Private Sub btnTGuides_Click(sender As Object, e As EventArgs) Handles btnTGuides.Click
        resetButtonColor()
        btnTGuides.ForeColor = ColorTranslator.FromHtml("#151515")
        btnTGuides.BackColor = ColorTranslator.FromHtml("#ffc048")
        admPanel.Controls.Clear()

    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        resetButtonColor()
        btnCustomers.ForeColor = ColorTranslator.FromHtml("#151515")
        btnCustomers.BackColor = ColorTranslator.FromHtml("#ffc048")
        admPanel.Controls.Clear()

    End Sub

    Private Sub btnNotif_Click(sender As Object, e As EventArgs) Handles btnNotif.Click
        resetButtonColor()
        btnNotif.ForeColor = ColorTranslator.FromHtml("#151515")
        btnNotif.BackColor = ColorTranslator.FromHtml("#ffc048")
        admPanel.Controls.Clear()

    End Sub

    Private Sub btnTransacHist_Click(sender As Object, e As EventArgs) Handles btnTransacHist.Click
        resetButtonColor()
        btnTransacHist.ForeColor = ColorTranslator.FromHtml("#151515")
        btnTransacHist.BackColor = ColorTranslator.FromHtml("#ffc048")
        admPanel.Controls.Clear()

    End Sub

    Private Sub btnRules_Click(sender As Object, e As EventArgs) Handles btnRules.Click
        resetButtonColor()
        btnRules.ForeColor = ColorTranslator.FromHtml("#151515")
        btnRules.BackColor = ColorTranslator.FromHtml("#ffc048")
        admPanel.Controls.Clear()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        resetButtonColor()
        loadRMSLogin()
        clearLoginForm()
        rmsLogin.Show()
    End Sub


End Class
