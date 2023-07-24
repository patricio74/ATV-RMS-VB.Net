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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rmsDashboard))
        Me.labelTitle2 = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.labelTItle = New System.Windows.Forms.Label()
        Me.panelSide = New System.Windows.Forms.Panel()
        Me.labelAdminName = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnRules = New System.Windows.Forms.Button()
        Me.btnTransacHist = New System.Windows.Forms.Button()
        Me.btnNotif = New System.Windows.Forms.Button()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.btnReservations = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnTGuides = New System.Windows.Forms.Button()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.admPanel = New System.Windows.Forms.Panel()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSide.SuspendLayout()
        Me.panelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelTitle2
        '
        Me.labelTitle2.AutoSize = True
        Me.labelTitle2.BackColor = System.Drawing.Color.Transparent
        Me.labelTitle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.labelTitle2.Location = New System.Drawing.Point(20, 152)
        Me.labelTitle2.Name = "labelTitle2"
        Me.labelTitle2.Size = New System.Drawing.Size(167, 13)
        Me.labelTitle2.TabIndex = 2
        Me.labelTitle2.Text = "Rental Management System"
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.BackgroundImage = CType(resources.GetObject("picLogo.BackgroundImage"), System.Drawing.Image)
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picLogo.Location = New System.Drawing.Point(64, 36)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(75, 75)
        Me.picLogo.TabIndex = 4
        Me.picLogo.TabStop = False
        '
        'labelTItle
        '
        Me.labelTItle.AutoSize = True
        Me.labelTItle.BackColor = System.Drawing.Color.Transparent
        Me.labelTItle.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTItle.ForeColor = System.Drawing.Color.White
        Me.labelTItle.Location = New System.Drawing.Point(32, 120)
        Me.labelTItle.Name = "labelTItle"
        Me.labelTItle.Size = New System.Drawing.Size(137, 29)
        Me.labelTItle.TabIndex = 1
        Me.labelTItle.Text = "ATV-RMS"
        '
        'panelSide
        '
        Me.panelSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.panelSide.Controls.Add(Me.labelAdminName)
        Me.panelSide.Controls.Add(Me.btnLogout)
        Me.panelSide.Controls.Add(Me.btnRules)
        Me.panelSide.Controls.Add(Me.btnTransacHist)
        Me.panelSide.Controls.Add(Me.btnNotif)
        Me.panelSide.Controls.Add(Me.btnCustomers)
        Me.panelSide.Controls.Add(Me.btnReservations)
        Me.panelSide.Controls.Add(Me.btnInventory)
        Me.panelSide.Controls.Add(Me.btnTGuides)
        Me.panelSide.Controls.Add(Me.picLogo)
        Me.panelSide.Controls.Add(Me.labelTitle2)
        Me.panelSide.Controls.Add(Me.labelTItle)
        Me.panelSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelSide.Location = New System.Drawing.Point(0, 30)
        Me.panelSide.Margin = New System.Windows.Forms.Padding(0)
        Me.panelSide.Name = "panelSide"
        Me.panelSide.Size = New System.Drawing.Size(205, 694)
        Me.panelSide.TabIndex = 0
        '
        'labelAdminName
        '
        Me.labelAdminName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelAdminName.BackColor = System.Drawing.Color.Transparent
        Me.labelAdminName.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelAdminName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.labelAdminName.Location = New System.Drawing.Point(0, 611)
        Me.labelAdminName.Margin = New System.Windows.Forms.Padding(0)
        Me.labelAdminName.Name = "labelAdminName"
        Me.labelAdminName.Size = New System.Drawing.Size(205, 31)
        Me.labelAdminName.TabIndex = 5
        Me.labelAdminName.Text = "Admin name"
        Me.labelAdminName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 642)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(205, 30)
        Me.btnLogout.TabIndex = 11
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
        Me.btnRules.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRules.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnRules.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRules.Location = New System.Drawing.Point(0, 535)
        Me.btnRules.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRules.Name = "btnRules"
        Me.btnRules.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnRules.Size = New System.Drawing.Size(205, 49)
        Me.btnRules.TabIndex = 10
        Me.btnRules.Text = "Rules && Regulations"
        Me.btnRules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRules.UseVisualStyleBackColor = True
        '
        'btnTransacHist
        '
        Me.btnTransacHist.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTransacHist.BackColor = System.Drawing.Color.Transparent
        Me.btnTransacHist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransacHist.FlatAppearance.BorderSize = 0
        Me.btnTransacHist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.btnTransacHist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransacHist.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransacHist.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnTransacHist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransacHist.Location = New System.Drawing.Point(0, 483)
        Me.btnTransacHist.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTransacHist.Name = "btnTransacHist"
        Me.btnTransacHist.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnTransacHist.Size = New System.Drawing.Size(205, 49)
        Me.btnTransacHist.TabIndex = 9
        Me.btnTransacHist.Text = "Transaction History"
        Me.btnTransacHist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransacHist.UseVisualStyleBackColor = True
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
        Me.btnNotif.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotif.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnNotif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNotif.Location = New System.Drawing.Point(0, 431)
        Me.btnNotif.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNotif.Name = "btnNotif"
        Me.btnNotif.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnNotif.Size = New System.Drawing.Size(205, 49)
        Me.btnNotif.TabIndex = 8
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
        Me.btnCustomers.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomers.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.Location = New System.Drawing.Point(0, 379)
        Me.btnCustomers.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnCustomers.Size = New System.Drawing.Size(205, 49)
        Me.btnCustomers.TabIndex = 7
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
        Me.btnReservations.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservations.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnReservations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReservations.Location = New System.Drawing.Point(0, 223)
        Me.btnReservations.Margin = New System.Windows.Forms.Padding(0)
        Me.btnReservations.Name = "btnReservations"
        Me.btnReservations.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnReservations.Size = New System.Drawing.Size(205, 49)
        Me.btnReservations.TabIndex = 4
        Me.btnReservations.Text = "Reservations"
        Me.btnReservations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReservations.UseVisualStyleBackColor = False
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
        Me.btnInventory.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventory.Location = New System.Drawing.Point(0, 275)
        Me.btnInventory.Margin = New System.Windows.Forms.Padding(0)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnInventory.Size = New System.Drawing.Size(205, 49)
        Me.btnInventory.TabIndex = 5
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
        Me.btnTGuides.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTGuides.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnTGuides.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTGuides.Location = New System.Drawing.Point(0, 327)
        Me.btnTGuides.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTGuides.Name = "btnTGuides"
        Me.btnTGuides.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnTGuides.Size = New System.Drawing.Size(205, 49)
        Me.btnTGuides.TabIndex = 6
        Me.btnTGuides.Text = "Tour Guides"
        Me.btnTGuides.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTGuides.UseVisualStyleBackColor = True
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
        Me.panelTop.Size = New System.Drawing.Size(1236, 30)
        Me.panelTop.TabIndex = 12
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnMinimize.Location = New System.Drawing.Point(1173, 0)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(30, 30)
        Me.btnMinimize.TabIndex = 13
        Me.btnMinimize.Text = "—"
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Red
        Me.btnClose.Location = New System.Drawing.Point(1206, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "x"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'admPanel
        '
        Me.admPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.admPanel.BackColor = System.Drawing.Color.Transparent
        Me.admPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.admPanel.Location = New System.Drawing.Point(205, 30)
        Me.admPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.admPanel.Name = "admPanel"
        Me.admPanel.Size = New System.Drawing.Size(1031, 694)
        Me.admPanel.TabIndex = 3
        '
        'rmsDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1236, 724)
        Me.Controls.Add(Me.panelSide)
        Me.Controls.Add(Me.admPanel)
        Me.Controls.Add(Me.panelTop)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "rmsDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ATV-RMS Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSide.ResumeLayout(False)
        Me.panelSide.PerformLayout()
        Me.panelTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents labelTitle2 As Label
    Private WithEvents picLogo As PictureBox
    Private WithEvents labelTItle As Label
    Friend WithEvents panelSide As Panel
    Friend WithEvents btnReservations As Button
    Friend WithEvents btnTransacHist As Button
    Friend WithEvents btnNotif As Button
    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnTGuides As Button
    Friend WithEvents btnInventory As Button
    Private WithEvents panelTop As Panel
    Private WithEvents btnMinimize As Button
    Private WithEvents btnClose As Button
    Friend WithEvents btnRules As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents admPanel As Panel
    Private WithEvents labelAdminName As Label
End Class
