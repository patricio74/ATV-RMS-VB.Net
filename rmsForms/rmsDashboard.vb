Public Class rmsDashboard
    'user control reference
    Dim overview As New ctrlOverview
    Dim reservv As New ctrlReservations
    Dim transac As New ctrlTransactions
    Dim trails As New ctrlTrails
    Dim customer As New ctrlCustomers
    Dim notifs As New ctrlNotif
    Dim inve As New ctrlInventory
    Dim guide As New ctrlTourGuides
    Dim rules As New ctrlRules
    Dim settings As New ctrlAdminSettings
    Private Sub centerLoc()
        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Dim formWidth As Integer = Width
        Dim formHeight As Integer = Height
        Dim x As Integer = (screenWidth - formWidth) \ 2
        Dim y As Integer = (screenHeight - formHeight) \ 2
        Me.Location = New Point(x, y)
    End Sub
    Private Sub hidePanels()
        overview.Visible = False
        reservv.Visible = False
        transac.Visible = False
        trails.Visible = False
        customer.Visible = False
        notifs.Visible = False
        inve.Visible = False
        guide.Visible = False
        rules.Visible = False
        settings.Visible = False
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles dashboardTimer.Tick
        lblDateTime.Text = DateTime.Now.ToString("MMM d, yyyy h:mm:ss tt")
    End Sub
    Private Sub resetButtonColor()
        Dim defaultForeColor As Color = ColorTranslator.FromHtml("#f5f5f5")
        Dim defaultBackColor As Color = ColorTranslator.FromHtml("#1e272e")
        Dim buttons As Button() = {
            btnOverview,
            btnReserv,
            btnTransac,
            btnTrails,
            btnCustomers,
            btnNotif,
            btnInventory,
            btnTGuides,
            btnRules
        }
        For Each btn In buttons
            btn.ForeColor = defaultForeColor
            btn.BackColor = defaultBackColor
        Next
    End Sub
    Private Sub activeButtonColor(sender As Object, e As EventArgs)
        Dim activeBtn As Button = CType(sender, Button)
        activeBtn.ForeColor = ColorTranslator.FromHtml("#151515")
        activeBtn.BackColor = ColorTranslator.FromHtml("#ffc048")
    End Sub
    Private Sub rmsDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        centerLoc()
        initializeDraggablePanel(panelTop)
        btnAdminSettings.Text = rmsSharedVar.currentUser
        'load panelz
        admPanel.Controls.Add(overview)
        admPanel.Controls.Add(reservv)
        admPanel.Controls.Add(transac)
        admPanel.Controls.Add(trails)
        admPanel.Controls.Add(customer)
        admPanel.Controls.Add(notifs)
        admPanel.Controls.Add(inve)
        admPanel.Controls.Add(guide)
        admPanel.Controls.Add(rules)
        admPanel.Controls.Add(settings)
        resetButtonColor()
        btnOverview.PerformClick()
        hidePanels()
        overview.Visible = True
        dashboardTimer.Interval = 1000
        dashboardTimer.Start()
    End Sub
    Private Sub btnClick(sender As Object, e As EventArgs) Handles btnOverview.Click, btnReserv.Click, btnTransac.Click, btnTrails.Click,
        btnCustomers.Click, btnNotif.Click, btnInventory.Click, btnTGuides.Click, btnRules.Click, btnAdminSettings.Click, btnLogout.Click, btnClose.Click, btnMinimize.Click
        If sender Is btnClose Then
            Dim response As DialogResult = MessageBox.Show(" Are you sure you want to close ATV-RMS app?", "Confirmation", MessageBoxButtons.YesNo)
            If response = DialogResult.Yes Then
                rmsSharedVar.admnID = Nothing
                rmsSharedVar.currentUser = Nothing
                Me.Close()
                rmsLogin.Close()
            End If
        ElseIf sender Is btnMinimize Then
            Me.WindowState = FormWindowState.Minimized
        ElseIf sender Is btnOverview Then
            resetButtonColor()
            activeButtonColor(sender, e)
            hidePanels()
            overview.Visible = True
        ElseIf sender Is btnReserv Then
            resetButtonColor()
            activeButtonColor(sender, e)
            hidePanels()
            reservv.Visible = True
        ElseIf sender Is btnTransac Then
            resetButtonColor()
            activeButtonColor(sender, e)
            hidePanels()
            transac.Visible = True
        ElseIf sender Is btnTrails Then
            resetButtonColor()
            activeButtonColor(sender, e)
            hidePanels()
            trails.Visible = True
        ElseIf sender Is btnCustomers Then
            resetButtonColor()
            activeButtonColor(sender, e)
            hidePanels()
            customer.Visible = True
        ElseIf sender Is btnNotif Then
            resetButtonColor()
            activeButtonColor(sender, e)
            hidePanels()
            notifs.Visible = True
        ElseIf sender Is btnInventory Then
            resetButtonColor()
            activeButtonColor(sender, e)
            hidePanels()
            inve.Visible = True
        ElseIf sender Is btnTGuides Then
            resetButtonColor()
            activeButtonColor(sender, e)
            hidePanels()
            guide.Visible = True
        ElseIf sender Is btnRules Then
            resetButtonColor()
            activeButtonColor(sender, e)
            hidePanels()
            rules.Visible = True
        ElseIf sender Is btnAdminSettings Then
            resetButtonColor()
            hidePanels()
            settings.Visible = True
        ElseIf sender Is btnLogout Then
            rmsSharedVar.admnID = Nothing
            rmsSharedVar.currentUser = Nothing
            Me.Close()
            resetButtonColor()
            loadRMSLogin()
            rmsLogin.Show()
            rmsLogin.tboxUsername.Focus()
        End If
    End Sub
    Private Sub rmsDashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        rmsSharedVar.admnID = Nothing
        rmsSharedVar.currentUser = Nothing
        rmsSharedVar.role = Nothing
        closeMongoConn()
    End Sub
End Class