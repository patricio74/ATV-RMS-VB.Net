Public Class rmsDashboard

    Public Shared adminName As String = ""

    'user control reference
    Dim reserv As New ctrlReservations
    Dim inve As New ctrlInventory
    Dim guide As New ctrlTourGuides
    Dim customer As New ctrlCustomers
    Dim transac As New ctrlTransacHist
    Dim rules As New ctrlRules
    Dim notifs As New ctrlNotif

    Private Sub rmsDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        connectToMongo()
        labelAdminName.Text = adminName
        'load panelz
        admPanel.Controls.Add(reserv)
        admPanel.Controls.Add(inve)
        admPanel.Controls.Add(guide)
        admPanel.Controls.Add(customer)
        admPanel.Controls.Add(transac)
        admPanel.Controls.Add(rules)
        admPanel.Controls.Add(notifs)

        btnTransacHist.PerformClick()
        transac.BringToFront()
    End Sub

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
        reserv.BringToFront()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        resetButtonColor()
        activeButtonColor(sender, e)
        inve.BringToFront()
    End Sub

    Private Sub btnTGuides_Click(sender As Object, e As EventArgs) Handles btnTGuides.Click
        resetButtonColor()
        activeButtonColor(sender, e)
        guide.BringToFront()
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        resetButtonColor()
        activeButtonColor(sender, e)
        customer.BringToFront()
    End Sub

    Private Sub btnNotif_Click(sender As Object, e As EventArgs) Handles btnNotif.Click
        resetButtonColor()
        activeButtonColor(sender, e)
        notifs.BringToFront()
    End Sub

    Private Sub btnTransacHist_Click(sender As Object, e As EventArgs) Handles btnTransacHist.Click
        resetButtonColor()
        activeButtonColor(sender, e)
        transac.BringToFront()
    End Sub

    Private Sub btnRules_Click(sender As Object, e As EventArgs) Handles btnRules.Click
        resetButtonColor()
        activeButtonColor(sender, e)
        rules.BringToFront()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        resetButtonColor()
        loadRMSLogin()
        clearLoginForm()
        adminName = ""
        rmsLogin.Show()
    End Sub

End Class
