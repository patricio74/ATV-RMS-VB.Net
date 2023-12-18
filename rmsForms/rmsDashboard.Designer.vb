<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rmsDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rmsDashboard))
        Me.labelTitle2 = New System.Windows.Forms.Label()
        Me.labelTItle = New System.Windows.Forms.Label()
        Me.panelSide = New System.Windows.Forms.Panel()
        Me.btnTGuides = New System.Windows.Forms.Button()
        Me.btnReserv = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnAdminSettings = New System.Windows.Forms.Button()
        Me.btnRules = New System.Windows.Forms.Button()
        Me.btnTrails = New System.Windows.Forms.Button()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.btnPending = New System.Windows.Forms.Button()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnOverview = New System.Windows.Forms.Button()
        Me.btnTransac = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.admPanel = New System.Windows.Forms.Panel()
        Me.dashboardTimer = New System.Windows.Forms.Timer(Me.components)
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.panelSide.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelTitle2
        '
        Me.labelTitle2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelTitle2.BackColor = System.Drawing.Color.Transparent
        Me.labelTitle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.labelTitle2.Location = New System.Drawing.Point(0, 135)
        Me.labelTitle2.Name = "labelTitle2"
        Me.labelTitle2.Size = New System.Drawing.Size(205, 13)
        Me.labelTitle2.TabIndex = 1
        Me.labelTitle2.Text = "Rental Management System"
        Me.labelTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelTItle
        '
        Me.labelTItle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelTItle.BackColor = System.Drawing.Color.Transparent
        Me.labelTItle.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTItle.ForeColor = System.Drawing.Color.White
        Me.labelTItle.Location = New System.Drawing.Point(0, 103)
        Me.labelTItle.Name = "labelTItle"
        Me.labelTItle.Size = New System.Drawing.Size(205, 29)
        Me.labelTItle.TabIndex = 0
        Me.labelTItle.Text = "ATVRMS"
        Me.labelTItle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelSide
        '
        Me.panelSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.panelSide.Controls.Add(Me.btnTGuides)
        Me.panelSide.Controls.Add(Me.btnReserv)
        Me.panelSide.Controls.Add(Me.btnInventory)
        Me.panelSide.Controls.Add(Me.btnAdminSettings)
        Me.panelSide.Controls.Add(Me.btnRules)
        Me.panelSide.Controls.Add(Me.btnTrails)
        Me.panelSide.Controls.Add(Me.lblDateTime)
        Me.panelSide.Controls.Add(Me.btnPending)
        Me.panelSide.Controls.Add(Me.btnCustomers)
        Me.panelSide.Controls.Add(Me.btnLogout)
        Me.panelSide.Controls.Add(Me.btnOverview)
        Me.panelSide.Controls.Add(Me.btnTransac)
        Me.panelSide.Controls.Add(Me.picLogo)
        Me.panelSide.Controls.Add(Me.labelTitle2)
        Me.panelSide.Controls.Add(Me.labelTItle)
        Me.panelSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelSide.Location = New System.Drawing.Point(0, 30)
        Me.panelSide.Margin = New System.Windows.Forms.Padding(0)
        Me.panelSide.Name = "panelSide"
        Me.panelSide.Size = New System.Drawing.Size(205, 738)
        Me.panelSide.TabIndex = 0
        '
        'btnTGuides
        '
        Me.btnTGuides.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTGuides.BackColor = System.Drawing.Color.Transparent
        Me.btnTGuides.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTGuides.FlatAppearance.BorderSize = 0
        Me.btnTGuides.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnTGuides.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTGuides.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTGuides.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnTGuides.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTGuides.Location = New System.Drawing.Point(0, 446)
        Me.btnTGuides.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTGuides.Name = "btnTGuides"
        Me.btnTGuides.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnTGuides.Size = New System.Drawing.Size(205, 43)
        Me.btnTGuides.TabIndex = 8
        Me.btnTGuides.Text = "Tour Guides"
        Me.btnTGuides.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTGuides.UseVisualStyleBackColor = True
        '
        'btnReserv
        '
        Me.btnReserv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReserv.BackColor = System.Drawing.Color.Transparent
        Me.btnReserv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReserv.FlatAppearance.BorderSize = 0
        Me.btnReserv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnReserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReserv.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReserv.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnReserv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReserv.Location = New System.Drawing.Point(0, 317)
        Me.btnReserv.Margin = New System.Windows.Forms.Padding(0)
        Me.btnReserv.Name = "btnReserv"
        Me.btnReserv.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnReserv.Size = New System.Drawing.Size(205, 43)
        Me.btnReserv.TabIndex = 5
        Me.btnReserv.Text = "Reservations"
        Me.btnReserv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReserv.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInventory.BackColor = System.Drawing.Color.Transparent
        Me.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInventory.FlatAppearance.BorderSize = 0
        Me.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventory.Location = New System.Drawing.Point(0, 403)
        Me.btnInventory.Margin = New System.Windows.Forms.Padding(0)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnInventory.Size = New System.Drawing.Size(205, 43)
        Me.btnInventory.TabIndex = 7
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'btnAdminSettings
        '
        Me.btnAdminSettings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdminSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnAdminSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdminSettings.FlatAppearance.BorderSize = 0
        Me.btnAdminSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAdminSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAdminSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdminSettings.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnAdminSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdminSettings.Location = New System.Drawing.Point(0, 638)
        Me.btnAdminSettings.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAdminSettings.Name = "btnAdminSettings"
        Me.btnAdminSettings.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.btnAdminSettings.Size = New System.Drawing.Size(205, 60)
        Me.btnAdminSettings.TabIndex = 12
        Me.btnAdminSettings.Text = "User's full name"
        Me.btnAdminSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdminSettings.UseVisualStyleBackColor = True
        '
        'btnRules
        '
        Me.btnRules.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRules.BackColor = System.Drawing.Color.Transparent
        Me.btnRules.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRules.FlatAppearance.BorderSize = 0
        Me.btnRules.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRules.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRules.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnRules.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRules.Location = New System.Drawing.Point(0, 575)
        Me.btnRules.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRules.Name = "btnRules"
        Me.btnRules.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnRules.Size = New System.Drawing.Size(205, 43)
        Me.btnRules.TabIndex = 11
        Me.btnRules.Text = "Rules && Regulations"
        Me.btnRules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRules.UseVisualStyleBackColor = True
        '
        'btnTrails
        '
        Me.btnTrails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTrails.BackColor = System.Drawing.Color.Transparent
        Me.btnTrails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTrails.FlatAppearance.BorderSize = 0
        Me.btnTrails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnTrails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrails.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrails.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnTrails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTrails.Location = New System.Drawing.Point(0, 360)
        Me.btnTrails.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTrails.Name = "btnTrails"
        Me.btnTrails.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnTrails.Size = New System.Drawing.Size(205, 43)
        Me.btnTrails.TabIndex = 6
        Me.btnTrails.Text = "ATV Trails"
        Me.btnTrails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTrails.UseVisualStyleBackColor = True
        '
        'lblDateTime
        '
        Me.lblDateTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblDateTime.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.lblDateTime.Location = New System.Drawing.Point(0, 169)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(205, 21)
        Me.lblDateTime.TabIndex = 2
        Me.lblDateTime.Text = "MMM d, yyyy hh:mm:ss tt"
        Me.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPending
        '
        Me.btnPending.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPending.BackColor = System.Drawing.Color.Transparent
        Me.btnPending.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPending.FlatAppearance.BorderSize = 0
        Me.btnPending.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPending.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPending.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnPending.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPending.Location = New System.Drawing.Point(0, 532)
        Me.btnPending.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPending.Name = "btnPending"
        Me.btnPending.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnPending.Size = New System.Drawing.Size(205, 43)
        Me.btnPending.TabIndex = 10
        Me.btnPending.Text = "Pending Accounts"
        Me.btnPending.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPending.UseVisualStyleBackColor = True
        '
        'btnCustomers
        '
        Me.btnCustomers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCustomers.BackColor = System.Drawing.Color.Transparent
        Me.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomers.FlatAppearance.BorderSize = 0
        Me.btnCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomers.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomers.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.Location = New System.Drawing.Point(0, 489)
        Me.btnCustomers.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnCustomers.Size = New System.Drawing.Size(205, 43)
        Me.btnCustomers.TabIndex = 9
        Me.btnCustomers.Text = "Manage Customers"
        Me.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.AutoSize = True
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(71, 703)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(61, 24)
        Me.btnLogout.TabIndex = 13
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnOverview
        '
        Me.btnOverview.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOverview.BackColor = System.Drawing.Color.Transparent
        Me.btnOverview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOverview.FlatAppearance.BorderSize = 0
        Me.btnOverview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOverview.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOverview.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnOverview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOverview.Location = New System.Drawing.Point(0, 231)
        Me.btnOverview.Margin = New System.Windows.Forms.Padding(0)
        Me.btnOverview.Name = "btnOverview"
        Me.btnOverview.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnOverview.Size = New System.Drawing.Size(205, 43)
        Me.btnOverview.TabIndex = 3
        Me.btnOverview.Text = "Overview"
        Me.btnOverview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOverview.UseVisualStyleBackColor = True
        '
        'btnTransac
        '
        Me.btnTransac.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTransac.BackColor = System.Drawing.Color.Transparent
        Me.btnTransac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransac.FlatAppearance.BorderSize = 0
        Me.btnTransac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnTransac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransac.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransac.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnTransac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransac.Location = New System.Drawing.Point(0, 274)
        Me.btnTransac.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTransac.Name = "btnTransac"
        Me.btnTransac.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnTransac.Size = New System.Drawing.Size(205, 43)
        Me.btnTransac.TabIndex = 4
        Me.btnTransac.Text = "Transactions"
        Me.btnTransac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransac.UseVisualStyleBackColor = True
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.BackgroundImage = Global.ATV_RMS.My.Resources.Resources.logo
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picLogo.Location = New System.Drawing.Point(43, 18)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(148, 86)
        Me.picLogo.TabIndex = 4
        Me.picLogo.TabStop = False
        '
        'admPanel
        '
        Me.admPanel.BackColor = System.Drawing.Color.Transparent
        Me.admPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.admPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.admPanel.Location = New System.Drawing.Point(205, 30)
        Me.admPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.admPanel.Name = "admPanel"
        Me.admPanel.Size = New System.Drawing.Size(1161, 738)
        Me.admPanel.TabIndex = 1
        '
        'dashboardTimer
        '
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.panelTop.Controls.Add(Me.btnMinimize)
        Me.panelTop.Controls.Add(Me.btnClose)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Margin = New System.Windows.Forms.Padding(0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(1366, 30)
        Me.panelTop.TabIndex = 2
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnMinimize.Location = New System.Drawing.Point(1303, 0)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(30, 30)
        Me.btnMinimize.TabIndex = 0
        Me.btnMinimize.TabStop = False
        Me.btnMinimize.Text = "—"
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Red
        Me.btnClose.Location = New System.Drawing.Point(1336, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.TabIndex = 1
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "x"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'rmsDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.admPanel)
        Me.Controls.Add(Me.panelSide)
        Me.Controls.Add(Me.panelTop)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "rmsDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "z"
        Me.panelSide.ResumeLayout(False)
        Me.panelSide.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents labelTitle2 As Label
    Private WithEvents picLogo As PictureBox
    Private WithEvents labelTItle As Label
    Friend WithEvents panelSide As Panel
    Friend WithEvents btnTransac As Button
    Friend WithEvents btnOverview As Button
    Friend WithEvents btnPending As Button
    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnTGuides As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnRules As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents admPanel As Panel
    Friend WithEvents btnAdminSettings As Button
    Friend WithEvents btnTrails As Button
    Private WithEvents lblDateTime As Label
    Friend WithEvents dashboardTimer As Timer
    Private WithEvents panelTop As Panel
    Private WithEvents btnMinimize As Button
    Public WithEvents btnClose As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnReserv As Button
End Class
