<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rmsDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rmsDashboard))
        Me.labelTitle2 = New System.Windows.Forms.Label()
        Me.picboxLogo = New System.Windows.Forms.PictureBox()
        Me.labelTItle = New System.Windows.Forms.Label()
        Me.panelSide = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnRules = New System.Windows.Forms.Button()
        Me.btnTransacHist = New System.Windows.Forms.Button()
        Me.btnNotif = New System.Windows.Forms.Button()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.btnTGuides = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnReservations = New System.Windows.Forms.Button()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.admPanel = New System.Windows.Forms.Panel()
        CType(Me.picboxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSide.SuspendLayout()
        Me.panelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelTitle2
        '
        Me.labelTitle2.AutoSize = True
        Me.labelTitle2.BackColor = System.Drawing.Color.Transparent
        Me.labelTitle2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.labelTitle2.Location = New System.Drawing.Point(37, 133)
        Me.labelTitle2.Name = "labelTitle2"
        Me.labelTitle2.Size = New System.Drawing.Size(169, 18)
        Me.labelTitle2.TabIndex = 16
        Me.labelTitle2.Text = "Rental Management System"
        '
        'picboxLogo
        '
        Me.picboxLogo.BackColor = System.Drawing.Color.Transparent
        Me.picboxLogo.BackgroundImage = CType(resources.GetObject("picboxLogo.BackgroundImage"), System.Drawing.Image)
        Me.picboxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picboxLogo.Location = New System.Drawing.Point(94, 48)
        Me.picboxLogo.Name = "picboxLogo"
        Me.picboxLogo.Size = New System.Drawing.Size(55, 55)
        Me.picboxLogo.TabIndex = 4
        Me.picboxLogo.TabStop = False
        '
        'labelTItle
        '
        Me.labelTItle.AutoSize = True
        Me.labelTItle.BackColor = System.Drawing.Color.Transparent
        Me.labelTItle.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTItle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.labelTItle.Location = New System.Drawing.Point(56, 103)
        Me.labelTItle.Name = "labelTItle"
        Me.labelTItle.Size = New System.Drawing.Size(133, 37)
        Me.labelTItle.TabIndex = 15
        Me.labelTItle.Text = "ATV-RMS"
        '
        'panelSide
        '
        Me.panelSide.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelSide.Controls.Add(Me.btnLogout)
        Me.panelSide.Controls.Add(Me.btnRules)
        Me.panelSide.Controls.Add(Me.btnTransacHist)
        Me.panelSide.Controls.Add(Me.btnNotif)
        Me.panelSide.Controls.Add(Me.btnCustomers)
        Me.panelSide.Controls.Add(Me.btnTGuides)
        Me.panelSide.Controls.Add(Me.btnInventory)
        Me.panelSide.Controls.Add(Me.btnReservations)
        Me.panelSide.Controls.Add(Me.picboxLogo)
        Me.panelSide.Controls.Add(Me.labelTitle2)
        Me.panelSide.Controls.Add(Me.labelTItle)
        Me.panelSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelSide.Location = New System.Drawing.Point(0, 35)
        Me.panelSide.Name = "panelSide"
        Me.panelSide.Size = New System.Drawing.Size(238, 689)
        Me.panelSide.TabIndex = 17
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnLogout.Location = New System.Drawing.Point(0, 648)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(238, 30)
        Me.btnLogout.TabIndex = 24
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnRules
        '
        Me.btnRules.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRules.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRules.FlatAppearance.BorderSize = 0
        Me.btnRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRules.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRules.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnRules.Location = New System.Drawing.Point(0, 548)
        Me.btnRules.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRules.Name = "btnRules"
        Me.btnRules.Size = New System.Drawing.Size(238, 49)
        Me.btnRules.TabIndex = 23
        Me.btnRules.Text = "Rules && Regulations"
        Me.btnRules.UseVisualStyleBackColor = False
        '
        'btnTransacHist
        '
        Me.btnTransacHist.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnTransacHist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransacHist.FlatAppearance.BorderSize = 0
        Me.btnTransacHist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransacHist.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransacHist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnTransacHist.Location = New System.Drawing.Point(0, 491)
        Me.btnTransacHist.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTransacHist.Name = "btnTransacHist"
        Me.btnTransacHist.Size = New System.Drawing.Size(238, 49)
        Me.btnTransacHist.TabIndex = 22
        Me.btnTransacHist.Text = "Transaction History"
        Me.btnTransacHist.UseVisualStyleBackColor = False
        '
        'btnNotif
        '
        Me.btnNotif.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNotif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNotif.FlatAppearance.BorderSize = 0
        Me.btnNotif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotif.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotif.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnNotif.Location = New System.Drawing.Point(0, 434)
        Me.btnNotif.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNotif.Name = "btnNotif"
        Me.btnNotif.Size = New System.Drawing.Size(238, 49)
        Me.btnNotif.TabIndex = 21
        Me.btnNotif.Text = "Notifications"
        Me.btnNotif.UseVisualStyleBackColor = False
        '
        'btnCustomers
        '
        Me.btnCustomers.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomers.FlatAppearance.BorderSize = 0
        Me.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomers.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnCustomers.Location = New System.Drawing.Point(0, 377)
        Me.btnCustomers.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(238, 49)
        Me.btnCustomers.TabIndex = 20
        Me.btnCustomers.Text = "Manage Customers"
        Me.btnCustomers.UseVisualStyleBackColor = False
        '
        'btnTGuides
        '
        Me.btnTGuides.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnTGuides.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTGuides.FlatAppearance.BorderSize = 0
        Me.btnTGuides.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTGuides.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTGuides.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnTGuides.Location = New System.Drawing.Point(0, 320)
        Me.btnTGuides.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTGuides.Name = "btnTGuides"
        Me.btnTGuides.Size = New System.Drawing.Size(238, 49)
        Me.btnTGuides.TabIndex = 19
        Me.btnTGuides.Text = "Tour Guides"
        Me.btnTGuides.UseVisualStyleBackColor = False
        '
        'btnInventory
        '
        Me.btnInventory.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInventory.FlatAppearance.BorderSize = 0
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnInventory.Location = New System.Drawing.Point(0, 263)
        Me.btnInventory.Margin = New System.Windows.Forms.Padding(0)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(238, 49)
        Me.btnInventory.TabIndex = 18
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.UseVisualStyleBackColor = False
        '
        'btnReservations
        '
        Me.btnReservations.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnReservations.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReservations.FlatAppearance.BorderSize = 0
        Me.btnReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReservations.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservations.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnReservations.Location = New System.Drawing.Point(0, 206)
        Me.btnReservations.Margin = New System.Windows.Forms.Padding(0)
        Me.btnReservations.Name = "btnReservations"
        Me.btnReservations.Size = New System.Drawing.Size(238, 49)
        Me.btnReservations.TabIndex = 17
        Me.btnReservations.Text = "Reservations"
        Me.btnReservations.UseVisualStyleBackColor = False
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
        Me.panelTop.Size = New System.Drawing.Size(1236, 35)
        Me.panelTop.TabIndex = 19
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnMinimize.Location = New System.Drawing.Point(1177, -1)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(22, 30)
        Me.btnMinimize.TabIndex = 3
        Me.btnMinimize.Text = "_"
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Red
        Me.btnClose.Location = New System.Drawing.Point(1204, 2)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(21, 30)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "x"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'admPanel
        '
        Me.admPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.admPanel.BackColor = System.Drawing.Color.Transparent
        Me.admPanel.Location = New System.Drawing.Point(238, 35)
        Me.admPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.admPanel.Name = "admPanel"
        Me.admPanel.Size = New System.Drawing.Size(998, 689)
        Me.admPanel.TabIndex = 101
        '
        'rmsDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1236, 724)
        Me.Controls.Add(Me.admPanel)
        Me.Controls.Add(Me.panelSide)
        Me.Controls.Add(Me.panelTop)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "rmsDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picboxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSide.ResumeLayout(False)
        Me.panelSide.PerformLayout()
        Me.panelTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents labelTitle2 As Label
    Private WithEvents picboxLogo As PictureBox
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
End Class
