Public Class rmsDashboard

    Public Shared adminName As String = ""
    'user control reference
    Dim reserv As New ctrlReservations
    Dim inve As New ctrlInventory
    Dim guide As New ctrlTourGuides
    Dim customer As New ctrlCustomers
    Dim overview As New ctrlOverview
    Dim rules As New ctrlRules
    Dim notifs As New ctrlNotif
    Dim transac As New ctrlTransaction
    Dim settings As New ctrlUserSettings

    Private Sub centerLoc()
        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Dim formWidth As Integer = Width
        Dim formHeight As Integer = Height
        Dim x As Integer = (screenWidth - formWidth) \ 2
        Dim y As Integer = (screenHeight - formHeight) \ 2
        Me.Location = New Point(x, y)
    End Sub

    Private Sub rmsDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        centerLoc()
        connectToMongo()
        InitializeDraggablePanel(panelTop)
        labelAdminName.Text = adminName
        'load panelz
        admPanel.Controls.Add(reserv)
        admPanel.Controls.Add(inve)
        admPanel.Controls.Add(guide)
        admPanel.Controls.Add(customer)
        admPanel.Controls.Add(overview)
        admPanel.Controls.Add(rules)
        admPanel.Controls.Add(notifs)
        admPanel.Controls.Add(transac)
        admPanel.Controls.Add(settings)

        btnOverview.PerformClick()
        overview.BringToFront()

        Timer1.Interval = 1000
        Timer1.Start()
    End Sub

    Private Sub rmsDashboard_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        centerLoc()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        rmsLogin.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = DateTime.Now.ToString("MMM d, yyyy h:mm:ss tt")
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

    Private Sub btnTransacHist_Click(sender As Object, e As EventArgs) Handles btnOverview.Click
        resetButtonColor()
        activeButtonColor(sender, e)
        overview.BringToFront()
    End Sub

    Private Sub btnRules_Click(sender As Object, e As EventArgs) Handles btnRules.Click
        resetButtonColor()
        activeButtonColor(sender, e)
        rules.BringToFront()
    End Sub

    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        resetButtonColor()
        activeButtonColor(sender, e)
        transac.BringToFront()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        resetButtonColor()
        activeButtonColor(sender, e)
        settings.BringToFront()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        btnOverview.PerformClick()
        overview.BringToFront()
        Me.Hide()
        resetButtonColor()
        loadRMSLogin()
        clearLoginForm()
        adminName = ""
        rmsLogin.Show()
        rmsLogin.tboxUsername.Focus()
    End Sub

End Class