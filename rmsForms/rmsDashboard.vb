Public Class rmsDashboard
    'user control reference
    Dim overview As New ctrlOverview
    Dim reservv As New ctrlReservations
    Dim transac As New ctrlTransactions
    Dim trails As New ctrlTrails
    Dim customer As New ctrlCustomers
    Dim pending As New ctrlNotif
    Dim inventory As New ctrlInventory
    Dim guide As New ctrlTourGuides
    Dim rules As New ctrlRules
    Dim settings As New ctrlAdminSettings

    'variable pangswitch sa connection ng mga form
    'para di magsabay sabay connection sa db
    Public switchOverview As Boolean = False
    Public switchReserv As Boolean = False
    Public switchTransac As Boolean = False
    Public switchTrail As Boolean = False
    Public switchInven As Boolean = False
    Public switchTgui As Boolean = False
    Public switchCust As Boolean = False
    Public switchPendi As Boolean = False
    Public switchSett As Boolean = False
    'switch off all conn
    Public Sub switchOff()
        switchOverview = False
        switchReserv = False
        switchTransac = False
        switchTrail = False
        switchInven = False
        switchTgui = False
        switchCust = False
        switchPendi = False
        switchSett = False
    End Sub
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
        pending.Visible = False
        inventory.Visible = False
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
            btnPending,
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
        admPanel.Controls.Add(pending)
        admPanel.Controls.Add(inventory)
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
        btnCustomers.Click, btnPending.Click, btnInventory.Click, btnTGuides.Click, btnRules.Click, btnAdminSettings.Click, btnLogout.Click, btnClose.Click, btnMinimize.Click
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
            switchOff()
            switchOverview = True
            overview.Visible = True
        ElseIf sender Is btnReserv Then
            resetButtonColor()
            activeButtonColor(sender, e)
            hidePanels()
            switchOff()
            switchReserv = True
            reservv.Visible = True
        ElseIf sender Is btnTransac Then
            resetButtonColor()
            activeButtonColor(sender, e)
            hidePanels()
            switchOff()
            switchTransac = True
            transac.Visible = True
        ElseIf sender Is btnTrails Then
            resetButtonColor()
            activeButtonColor(sender, e)
            hidePanels()
            switchOff()
            switchTrail = True
            trails.Visible = True
        ElseIf sender Is btnCustomers Then
            resetButtonColor()
            activeButtonColor(sender, e)
            hidePanels()
            switchOff()
            switchCust = True
            customer.Visible = True
        ElseIf sender Is btnPending Then
            resetButtonColor()
            activeButtonColor(sender, e)
            hidePanels()
            switchOff()
            switchPendi = True
            pending.Visible = True
        ElseIf sender Is btnInventory Then
            resetButtonColor()
            activeButtonColor(sender, e)
            hidePanels()
            switchOff()
            switchInven = True
            inventory.Visible = True
        ElseIf sender Is btnTGuides Then
            resetButtonColor()
            activeButtonColor(sender, e)
            hidePanels()
            switchOff()
            switchTgui = True
            guide.Visible = True
        ElseIf sender Is btnRules Then
            resetButtonColor()
            activeButtonColor(sender, e)
            hidePanels()
            switchOff()
            rules.Visible = True
        ElseIf sender Is btnAdminSettings Then
            resetButtonColor()
            hidePanels()
            switchOff()
            switchSett = True
            settings.Visible = True
        ElseIf sender Is btnLogout Then
            rmsSharedVar.admnID = Nothing
            rmsSharedVar.currentUser = Nothing
            switchOff()
            resetButtonColor()
            Me.Close()
            loadRMSLogin()
            rmsLogin.Show()
            rmsLogin.tboxUsername.Focus()
        End If
    End Sub
    Private Sub rmsDashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        rmsSharedVar.admnID = Nothing
        rmsSharedVar.currentUser = Nothing
        'closeMongoConn()
    End Sub
End Class