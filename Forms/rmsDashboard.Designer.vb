﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnTransaction = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnRules = New System.Windows.Forms.Button()
        Me.btnOverview = New System.Windows.Forms.Button()
        Me.btnNotif = New System.Windows.Forms.Button()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.btnReservations = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnTGuides = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.labelAdminName = New System.Windows.Forms.Label()
        Me.admPanel = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.panelSide.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelTitle2
        '
        Me.labelTitle2.AutoSize = True
        Me.labelTitle2.BackColor = System.Drawing.Color.Transparent
        Me.labelTitle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.labelTitle2.Location = New System.Drawing.Point(20, 137)
        Me.labelTitle2.Name = "labelTitle2"
        Me.labelTitle2.Size = New System.Drawing.Size(167, 13)
        Me.labelTitle2.TabIndex = 2
        Me.labelTitle2.Text = "Rental Management System"
        '
        'labelTItle
        '
        Me.labelTItle.AutoSize = True
        Me.labelTItle.BackColor = System.Drawing.Color.Transparent
        Me.labelTItle.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTItle.ForeColor = System.Drawing.Color.White
        Me.labelTItle.Location = New System.Drawing.Point(32, 105)
        Me.labelTItle.Name = "labelTItle"
        Me.labelTItle.Size = New System.Drawing.Size(137, 29)
        Me.labelTItle.TabIndex = 1
        Me.labelTItle.Text = "ATV-RMS"
        '
        'panelSide
        '
        Me.panelSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.panelSide.Controls.Add(Me.lblDateTime)
        Me.panelSide.Controls.Add(Me.btnSettings)
        Me.panelSide.Controls.Add(Me.btnTransaction)
        Me.panelSide.Controls.Add(Me.btnLogout)
        Me.panelSide.Controls.Add(Me.btnRules)
        Me.panelSide.Controls.Add(Me.btnOverview)
        Me.panelSide.Controls.Add(Me.btnNotif)
        Me.panelSide.Controls.Add(Me.btnCustomers)
        Me.panelSide.Controls.Add(Me.btnReservations)
        Me.panelSide.Controls.Add(Me.btnInventory)
        Me.panelSide.Controls.Add(Me.btnTGuides)
        Me.panelSide.Controls.Add(Me.picLogo)
        Me.panelSide.Controls.Add(Me.labelTitle2)
        Me.panelSide.Controls.Add(Me.labelTItle)
        Me.panelSide.Controls.Add(Me.labelAdminName)
        Me.panelSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelSide.Location = New System.Drawing.Point(0, 30)
        Me.panelSide.Margin = New System.Windows.Forms.Padding(0)
        Me.panelSide.Name = "panelSide"
        Me.panelSide.Size = New System.Drawing.Size(205, 738)
        Me.panelSide.TabIndex = 0
        '
        'lblDateTime
        '
        Me.lblDateTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblDateTime.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.lblDateTime.Location = New System.Drawing.Point(0, 164)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(205, 21)
        Me.lblDateTime.TabIndex = 3
        Me.lblDateTime.Text = "MMM d, yyyy hh:mm:ss tt"
        Me.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSettings
        '
        Me.btnSettings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.Location = New System.Drawing.Point(0, 562)
        Me.btnSettings.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnSettings.Size = New System.Drawing.Size(205, 43)
        Me.btnSettings.TabIndex = 13
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnTransaction
        '
        Me.btnTransaction.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTransaction.BackColor = System.Drawing.Color.Transparent
        Me.btnTransaction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransaction.FlatAppearance.BorderSize = 0
        Me.btnTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaction.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaction.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransaction.Location = New System.Drawing.Point(0, 261)
        Me.btnTransaction.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnTransaction.Size = New System.Drawing.Size(205, 43)
        Me.btnTransaction.TabIndex = 5
        Me.btnTransaction.Text = "Transaction"
        Me.btnTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransaction.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.AutoSize = True
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 701)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(205, 26)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnRules
        '
        Me.btnRules.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRules.BackColor = System.Drawing.Color.Transparent
        Me.btnRules.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRules.FlatAppearance.BorderSize = 0
        Me.btnRules.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.btnRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRules.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRules.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnRules.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRules.Location = New System.Drawing.Point(0, 519)
        Me.btnRules.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRules.Name = "btnRules"
        Me.btnRules.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnRules.Size = New System.Drawing.Size(205, 43)
        Me.btnRules.TabIndex = 12
        Me.btnRules.Text = "Rules && Regulations"
        Me.btnRules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRules.UseVisualStyleBackColor = True
        '
        'btnOverview
        '
        Me.btnOverview.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOverview.BackColor = System.Drawing.Color.Transparent
        Me.btnOverview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOverview.FlatAppearance.BorderSize = 0
        Me.btnOverview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.btnOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOverview.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOverview.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnOverview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOverview.Location = New System.Drawing.Point(0, 218)
        Me.btnOverview.Margin = New System.Windows.Forms.Padding(0)
        Me.btnOverview.Name = "btnOverview"
        Me.btnOverview.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnOverview.Size = New System.Drawing.Size(205, 43)
        Me.btnOverview.TabIndex = 6
        Me.btnOverview.Text = "Overview"
        Me.btnOverview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOverview.UseVisualStyleBackColor = True
        '
        'btnNotif
        '
        Me.btnNotif.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNotif.BackColor = System.Drawing.Color.Transparent
        Me.btnNotif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNotif.FlatAppearance.BorderSize = 0
        Me.btnNotif.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.btnNotif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotif.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotif.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnNotif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNotif.Location = New System.Drawing.Point(0, 476)
        Me.btnNotif.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNotif.Name = "btnNotif"
        Me.btnNotif.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnNotif.Size = New System.Drawing.Size(205, 43)
        Me.btnNotif.TabIndex = 11
        Me.btnNotif.Text = "Notifications"
        Me.btnNotif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNotif.UseVisualStyleBackColor = True
        '
        'btnCustomers
        '
        Me.btnCustomers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCustomers.BackColor = System.Drawing.Color.Transparent
        Me.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomers.FlatAppearance.BorderSize = 0
        Me.btnCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomers.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomers.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.Location = New System.Drawing.Point(0, 433)
        Me.btnCustomers.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnCustomers.Size = New System.Drawing.Size(205, 43)
        Me.btnCustomers.TabIndex = 10
        Me.btnCustomers.Text = "Manage Customers"
        Me.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'btnReservations
        '
        Me.btnReservations.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReservations.BackColor = System.Drawing.Color.Transparent
        Me.btnReservations.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReservations.FlatAppearance.BorderSize = 0
        Me.btnReservations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.btnReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReservations.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservations.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnReservations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReservations.Location = New System.Drawing.Point(0, 304)
        Me.btnReservations.Margin = New System.Windows.Forms.Padding(0)
        Me.btnReservations.Name = "btnReservations"
        Me.btnReservations.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnReservations.Size = New System.Drawing.Size(205, 43)
        Me.btnReservations.TabIndex = 7
        Me.btnReservations.Text = "Reservations"
        Me.btnReservations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReservations.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInventory.BackColor = System.Drawing.Color.Transparent
        Me.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInventory.FlatAppearance.BorderSize = 0
        Me.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventory.Location = New System.Drawing.Point(0, 347)
        Me.btnInventory.Margin = New System.Windows.Forms.Padding(0)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnInventory.Size = New System.Drawing.Size(205, 43)
        Me.btnInventory.TabIndex = 8
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'btnTGuides
        '
        Me.btnTGuides.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTGuides.BackColor = System.Drawing.Color.Transparent
        Me.btnTGuides.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTGuides.FlatAppearance.BorderSize = 0
        Me.btnTGuides.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.btnTGuides.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTGuides.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTGuides.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnTGuides.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTGuides.Location = New System.Drawing.Point(0, 390)
        Me.btnTGuides.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTGuides.Name = "btnTGuides"
        Me.btnTGuides.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnTGuides.Size = New System.Drawing.Size(205, 43)
        Me.btnTGuides.TabIndex = 9
        Me.btnTGuides.Text = "Tour Guides"
        Me.btnTGuides.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTGuides.UseVisualStyleBackColor = True
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.BackgroundImage = CType(resources.GetObject("picLogo.BackgroundImage"), System.Drawing.Image)
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picLogo.Location = New System.Drawing.Point(69, 32)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(65, 65)
        Me.picLogo.TabIndex = 4
        Me.picLogo.TabStop = False
        '
        'labelAdminName
        '
        Me.labelAdminName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelAdminName.BackColor = System.Drawing.Color.Transparent
        Me.labelAdminName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelAdminName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.labelAdminName.Location = New System.Drawing.Point(0, 633)
        Me.labelAdminName.Margin = New System.Windows.Forms.Padding(0)
        Me.labelAdminName.Name = "labelAdminName"
        Me.labelAdminName.Size = New System.Drawing.Size(205, 68)
        Me.labelAdminName.TabIndex = 4
        Me.labelAdminName.Text = "Admin name"
        Me.labelAdminName.TextAlign = System.Drawing.ContentAlignment.BottomCenter
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
        'Timer1
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
        Me.Text = "ATV-RMS Dashboard"
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
    Friend WithEvents btnReservations As Button
    Friend WithEvents btnOverview As Button
    Friend WithEvents btnNotif As Button
    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnTGuides As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnRules As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents admPanel As Panel
    Private WithEvents labelAdminName As Label
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnTransaction As Button
    Private WithEvents lblDateTime As Label
    Friend WithEvents Timer1 As Timer
    Private WithEvents panelTop As Panel
    Private WithEvents btnMinimize As Button
    Private WithEvents btnClose As Button
End Class
