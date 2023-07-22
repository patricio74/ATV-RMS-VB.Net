<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rmsLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rmsLogin))
        Me.picboxLogo = New System.Windows.Forms.PictureBox()
        Me.labelTitle2 = New System.Windows.Forms.Label()
        Me.labelTItle = New System.Windows.Forms.Label()
        Me.tboxUsername = New System.Windows.Forms.TextBox()
        Me.tboxPassword = New System.Windows.Forms.TextBox()
        Me.labelPassword = New System.Windows.Forms.Label()
        Me.labelUsername = New System.Windows.Forms.Label()
        Me.checkShow = New System.Windows.Forms.CheckBox()
        Me.labelForgotPass = New System.Windows.Forms.Label()
        Me.tboxRFID = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.labelLoginSwitch = New System.Windows.Forms.Label()
        Me.labelRegister = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panelBottom = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.panelPassLogin = New System.Windows.Forms.Panel()
        Me.panelRFIDLogin = New System.Windows.Forms.Panel()
        CType(Me.picboxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBottom.SuspendLayout()
        Me.panelTop.SuspendLayout()
        Me.panelPassLogin.SuspendLayout()
        Me.panelRFIDLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'picboxLogo
        '
        Me.picboxLogo.BackColor = System.Drawing.Color.Transparent
        Me.picboxLogo.BackgroundImage = CType(resources.GetObject("picboxLogo.BackgroundImage"), System.Drawing.Image)
        Me.picboxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picboxLogo.Location = New System.Drawing.Point(173, 69)
        Me.picboxLogo.Name = "picboxLogo"
        Me.picboxLogo.Size = New System.Drawing.Size(75, 75)
        Me.picboxLogo.TabIndex = 4
        Me.picboxLogo.TabStop = False
        '
        'labelTitle2
        '
        Me.labelTitle2.AutoSize = True
        Me.labelTitle2.BackColor = System.Drawing.Color.Transparent
        Me.labelTitle2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.labelTitle2.Location = New System.Drawing.Point(110, 192)
        Me.labelTitle2.Name = "labelTitle2"
        Me.labelTitle2.Size = New System.Drawing.Size(193, 20)
        Me.labelTitle2.TabIndex = 1
        Me.labelTitle2.Text = "Rental Management System"
        '
        'labelTItle
        '
        Me.labelTItle.AutoSize = True
        Me.labelTItle.BackColor = System.Drawing.Color.Transparent
        Me.labelTItle.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTItle.ForeColor = System.Drawing.Color.White
        Me.labelTItle.Location = New System.Drawing.Point(102, 141)
        Me.labelTItle.Name = "labelTItle"
        Me.labelTItle.Size = New System.Drawing.Size(216, 61)
        Me.labelTItle.TabIndex = 0
        Me.labelTItle.Text = "ATV-RMS"
        '
        'tboxUsername
        '
        Me.tboxUsername.BackColor = System.Drawing.Color.White
        Me.tboxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboxUsername.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tboxUsername.Location = New System.Drawing.Point(63, 8)
        Me.tboxUsername.Margin = New System.Windows.Forms.Padding(0)
        Me.tboxUsername.MaxLength = 25
        Me.tboxUsername.Name = "tboxUsername"
        Me.tboxUsername.Size = New System.Drawing.Size(291, 32)
        Me.tboxUsername.TabIndex = 9
        Me.tboxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tboxPassword
        '
        Me.tboxPassword.BackColor = System.Drawing.Color.White
        Me.tboxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboxPassword.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tboxPassword.Location = New System.Drawing.Point(63, 61)
        Me.tboxPassword.Margin = New System.Windows.Forms.Padding(0)
        Me.tboxPassword.MaxLength = 25
        Me.tboxPassword.Name = "tboxPassword"
        Me.tboxPassword.Size = New System.Drawing.Size(291, 32)
        Me.tboxPassword.TabIndex = 11
        Me.tboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tboxPassword.UseSystemPasswordChar = True
        '
        'labelPassword
        '
        Me.labelPassword.BackColor = System.Drawing.Color.White
        Me.labelPassword.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.labelPassword.Location = New System.Drawing.Point(136, 65)
        Me.labelPassword.Name = "labelPassword"
        Me.labelPassword.Size = New System.Drawing.Size(145, 24)
        Me.labelPassword.TabIndex = 10
        Me.labelPassword.Text = "password"
        Me.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelUsername
        '
        Me.labelUsername.BackColor = System.Drawing.Color.White
        Me.labelUsername.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.labelUsername.Location = New System.Drawing.Point(136, 12)
        Me.labelUsername.Name = "labelUsername"
        Me.labelUsername.Size = New System.Drawing.Size(145, 24)
        Me.labelUsername.TabIndex = 8
        Me.labelUsername.Text = "username "
        Me.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'checkShow
        '
        Me.checkShow.AutoSize = True
        Me.checkShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.checkShow.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkShow.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.checkShow.Location = New System.Drawing.Point(299, 96)
        Me.checkShow.Margin = New System.Windows.Forms.Padding(0)
        Me.checkShow.Name = "checkShow"
        Me.checkShow.Size = New System.Drawing.Size(55, 22)
        Me.checkShow.TabIndex = 12
        Me.checkShow.Text = "show"
        Me.checkShow.UseVisualStyleBackColor = True
        '
        'labelForgotPass
        '
        Me.labelForgotPass.AutoSize = True
        Me.labelForgotPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelForgotPass.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelForgotPass.ForeColor = System.Drawing.Color.White
        Me.labelForgotPass.Location = New System.Drawing.Point(147, 31)
        Me.labelForgotPass.Name = "labelForgotPass"
        Me.labelForgotPass.Size = New System.Drawing.Size(114, 18)
        Me.labelForgotPass.TabIndex = 3
        Me.labelForgotPass.Text = "Forgot Password?"
        '
        'tboxRFID
        '
        Me.tboxRFID.BackColor = System.Drawing.Color.White
        Me.tboxRFID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboxRFID.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxRFID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tboxRFID.Location = New System.Drawing.Point(63, 62)
        Me.tboxRFID.Margin = New System.Windows.Forms.Padding(0)
        Me.tboxRFID.MaxLength = 12
        Me.tboxRFID.Name = "tboxRFID"
        Me.tboxRFID.Size = New System.Drawing.Size(291, 35)
        Me.tboxRFID.TabIndex = 15
        Me.tboxRFID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tboxRFID.UseSystemPasswordChar = True
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.BackColor = System.Drawing.Color.Transparent
        Me.label9.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.ForeColor = System.Drawing.Color.White
        Me.label9.Location = New System.Drawing.Point(93, 37)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(234, 22)
        Me.label9.TabIndex = 14
        Me.label9.Text = "Swipe your RFID card to login"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(136, 122)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(145, 47)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'labelLoginSwitch
        '
        Me.labelLoginSwitch.BackColor = System.Drawing.Color.Transparent
        Me.labelLoginSwitch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelLoginSwitch.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelLoginSwitch.ForeColor = System.Drawing.Color.White
        Me.labelLoginSwitch.Location = New System.Drawing.Point(136, 447)
        Me.labelLoginSwitch.Margin = New System.Windows.Forms.Padding(0)
        Me.labelLoginSwitch.Name = "labelLoginSwitch"
        Me.labelLoginSwitch.Size = New System.Drawing.Size(145, 21)
        Me.labelLoginSwitch.TabIndex = 2
        Me.labelLoginSwitch.Text = "Use RFID Card"
        Me.labelLoginSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelRegister
        '
        Me.labelRegister.AutoSize = True
        Me.labelRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelRegister.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelRegister.ForeColor = System.Drawing.Color.White
        Me.labelRegister.Location = New System.Drawing.Point(254, 64)
        Me.labelRegister.Margin = New System.Windows.Forms.Padding(0)
        Me.labelRegister.Name = "labelRegister"
        Me.labelRegister.Size = New System.Drawing.Size(58, 18)
        Me.labelRegister.TabIndex = 5
        Me.labelRegister.Text = "Register"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.label1.Location = New System.Drawing.Point(91, 64)
        Me.label1.Margin = New System.Windows.Forms.Padding(0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(163, 18)
        Me.label1.TabIndex = 4
        Me.label1.Text = "Don't have an account yet?"
        '
        'panelBottom
        '
        Me.panelBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panelBottom.Controls.Add(Me.labelForgotPass)
        Me.panelBottom.Controls.Add(Me.label1)
        Me.panelBottom.Controls.Add(Me.labelRegister)
        Me.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelBottom.Location = New System.Drawing.Point(0, 530)
        Me.panelBottom.Margin = New System.Windows.Forms.Padding(0)
        Me.panelBottom.Name = "panelBottom"
        Me.panelBottom.Size = New System.Drawing.Size(415, 125)
        Me.panelBottom.TabIndex = 17
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
        Me.btnClose.Location = New System.Drawing.Point(385, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.TabIndex = 20
        Me.btnClose.Text = "x"
        Me.btnClose.UseVisualStyleBackColor = False
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
        Me.panelTop.Size = New System.Drawing.Size(415, 30)
        Me.panelTop.TabIndex = 18
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
        Me.btnMinimize.Location = New System.Drawing.Point(352, 0)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(30, 30)
        Me.btnMinimize.TabIndex = 19
        Me.btnMinimize.Text = "—"
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'panelPassLogin
        '
        Me.panelPassLogin.BackColor = System.Drawing.Color.Transparent
        Me.panelPassLogin.Controls.Add(Me.btnLogin)
        Me.panelPassLogin.Controls.Add(Me.labelUsername)
        Me.panelPassLogin.Controls.Add(Me.checkShow)
        Me.panelPassLogin.Controls.Add(Me.labelPassword)
        Me.panelPassLogin.Controls.Add(Me.tboxUsername)
        Me.panelPassLogin.Controls.Add(Me.tboxPassword)
        Me.panelPassLogin.Location = New System.Drawing.Point(0, 271)
        Me.panelPassLogin.Name = "panelPassLogin"
        Me.panelPassLogin.Size = New System.Drawing.Size(415, 175)
        Me.panelPassLogin.TabIndex = 6
        '
        'panelRFIDLogin
        '
        Me.panelRFIDLogin.BackColor = System.Drawing.Color.Transparent
        Me.panelRFIDLogin.Controls.Add(Me.label9)
        Me.panelRFIDLogin.Controls.Add(Me.tboxRFID)
        Me.panelRFIDLogin.Location = New System.Drawing.Point(0, 268)
        Me.panelRFIDLogin.Name = "panelRFIDLogin"
        Me.panelRFIDLogin.Size = New System.Drawing.Size(415, 136)
        Me.panelRFIDLogin.TabIndex = 7
        '
        'rmsLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(415, 655)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.labelLoginSwitch)
        Me.Controls.Add(Me.picboxLogo)
        Me.Controls.Add(Me.labelTitle2)
        Me.Controls.Add(Me.labelTItle)
        Me.Controls.Add(Me.panelBottom)
        Me.Controls.Add(Me.panelPassLogin)
        Me.Controls.Add(Me.panelRFIDLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rmsLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picboxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBottom.ResumeLayout(False)
        Me.panelBottom.PerformLayout()
        Me.panelTop.ResumeLayout(False)
        Me.panelPassLogin.ResumeLayout(False)
        Me.panelPassLogin.PerformLayout()
        Me.panelRFIDLogin.ResumeLayout(False)
        Me.panelRFIDLogin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents picboxLogo As PictureBox
    Private WithEvents labelTitle2 As Label
    Private WithEvents labelTItle As Label
    Private WithEvents labelForgotPass As Label
    Private WithEvents labelPassword As Label
    Private WithEvents labelUsername As Label
    Private WithEvents btnLogin As Button
    Private WithEvents label9 As Label
    Private WithEvents labelRegister As Label
    Private WithEvents label1 As Label
    Private WithEvents panelBottom As Panel
    Private WithEvents btnClose As Button
    Private WithEvents panelTop As Panel
    Friend WithEvents panelPassLogin As Panel
    Friend WithEvents panelRFIDLogin As Panel
    Private WithEvents btnMinimize As Button
    Public WithEvents tboxUsername As TextBox
    Public WithEvents tboxRFID As TextBox
    Public WithEvents tboxPassword As TextBox
    Public WithEvents checkShow As CheckBox
    Public WithEvents labelLoginSwitch As Label
End Class
