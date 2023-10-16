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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rmsLogin))
        Me.tboxUsername = New System.Windows.Forms.TextBox()
        Me.tboxPassword = New System.Windows.Forms.TextBox()
        Me.checkShow = New System.Windows.Forms.CheckBox()
        Me.labelForgotPass = New System.Windows.Forms.Label()
        Me.tboxRFID = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblSwitchLoginPass = New System.Windows.Forms.Label()
        Me.labelRegister = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panelBottom = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.labelFormTitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.panelPassLogin = New System.Windows.Forms.Panel()
        Me.lblLoginError = New System.Windows.Forms.Label()
        Me.lblSwitchLoginRFID = New System.Windows.Forms.Label()
        Me.lblUserError = New System.Windows.Forms.Label()
        Me.lblPassError = New System.Windows.Forms.Label()
        Me.labelPword = New System.Windows.Forms.Label()
        Me.labelUser = New System.Windows.Forms.Label()
        Me.panelRFIDLogin = New System.Windows.Forms.Panel()
        Me.lblRFIDErr = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.labelTItle = New System.Windows.Forms.Label()
        Me.picboxLogo = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelBottom.SuspendLayout()
        Me.panelTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelPassLogin.SuspendLayout()
        Me.panelRFIDLogin.SuspendLayout()
        CType(Me.picboxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tboxUsername
        '
        Me.tboxUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tboxUsername.BackColor = System.Drawing.Color.White
        Me.tboxUsername.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tboxUsername.Location = New System.Drawing.Point(67, 33)
        Me.tboxUsername.Margin = New System.Windows.Forms.Padding(0)
        Me.tboxUsername.MaxLength = 40
        Me.tboxUsername.Name = "tboxUsername"
        Me.tboxUsername.Size = New System.Drawing.Size(324, 33)
        Me.tboxUsername.TabIndex = 5
        Me.tboxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tboxPassword
        '
        Me.tboxPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tboxPassword.BackColor = System.Drawing.Color.White
        Me.tboxPassword.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tboxPassword.Location = New System.Drawing.Point(67, 100)
        Me.tboxPassword.Margin = New System.Windows.Forms.Padding(0)
        Me.tboxPassword.MaxLength = 25
        Me.tboxPassword.Name = "tboxPassword"
        Me.tboxPassword.Size = New System.Drawing.Size(324, 33)
        Me.tboxPassword.TabIndex = 7
        Me.tboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tboxPassword.UseSystemPasswordChar = True
        '
        'checkShow
        '
        Me.checkShow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkShow.AutoSize = True
        Me.checkShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.checkShow.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkShow.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.checkShow.Location = New System.Drawing.Point(332, 134)
        Me.checkShow.Margin = New System.Windows.Forms.Padding(0)
        Me.checkShow.Name = "checkShow"
        Me.checkShow.Size = New System.Drawing.Size(60, 18)
        Me.checkShow.TabIndex = 8
        Me.checkShow.Text = "show"
        Me.checkShow.UseVisualStyleBackColor = True
        '
        'labelForgotPass
        '
        Me.labelForgotPass.AutoSize = True
        Me.labelForgotPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelForgotPass.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelForgotPass.ForeColor = System.Drawing.Color.White
        Me.labelForgotPass.Location = New System.Drawing.Point(160, 14)
        Me.labelForgotPass.Name = "labelForgotPass"
        Me.labelForgotPass.Size = New System.Drawing.Size(137, 16)
        Me.labelForgotPass.TabIndex = 15
        Me.labelForgotPass.Text = "Forgot Password?"
        '
        'tboxRFID
        '
        Me.tboxRFID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tboxRFID.BackColor = System.Drawing.Color.White
        Me.tboxRFID.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxRFID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tboxRFID.Location = New System.Drawing.Point(67, 74)
        Me.tboxRFID.Margin = New System.Windows.Forms.Padding(0)
        Me.tboxRFID.MaxLength = 12
        Me.tboxRFID.Name = "tboxRFID"
        Me.tboxRFID.Size = New System.Drawing.Size(324, 33)
        Me.tboxRFID.TabIndex = 12
        Me.tboxRFID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tboxRFID.UseSystemPasswordChar = True
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.BackColor = System.Drawing.Color.Transparent
        Me.label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.ForeColor = System.Drawing.Color.Gainsboro
        Me.label9.Location = New System.Drawing.Point(64, 54)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(69, 16)
        Me.label9.TabIndex = 11
        Me.label9.Text = "RFID No."
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(167, 182)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(126, 45)
        Me.btnLogin.TabIndex = 9
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblSwitchLoginPass
        '
        Me.lblSwitchLoginPass.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSwitchLoginPass.AutoSize = True
        Me.lblSwitchLoginPass.BackColor = System.Drawing.Color.Transparent
        Me.lblSwitchLoginPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSwitchLoginPass.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSwitchLoginPass.ForeColor = System.Drawing.Color.White
        Me.lblSwitchLoginPass.Location = New System.Drawing.Point(177, 145)
        Me.lblSwitchLoginPass.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSwitchLoginPass.Name = "lblSwitchLoginPass"
        Me.lblSwitchLoginPass.Size = New System.Drawing.Size(101, 14)
        Me.lblSwitchLoginPass.TabIndex = 13
        Me.lblSwitchLoginPass.Text = "Use Password"
        Me.lblSwitchLoginPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelRegister
        '
        Me.labelRegister.AutoSize = True
        Me.labelRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelRegister.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelRegister.ForeColor = System.Drawing.Color.White
        Me.labelRegister.Location = New System.Drawing.Point(290, 40)
        Me.labelRegister.Margin = New System.Windows.Forms.Padding(0)
        Me.labelRegister.Name = "labelRegister"
        Me.labelRegister.Size = New System.Drawing.Size(67, 16)
        Me.labelRegister.TabIndex = 17
        Me.labelRegister.Text = "Register"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.label1.Location = New System.Drawing.Point(99, 40)
        Me.label1.Margin = New System.Windows.Forms.Padding(0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(192, 16)
        Me.label1.TabIndex = 16
        Me.label1.Text = "Don't have an account yet?"
        '
        'panelBottom
        '
        Me.panelBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panelBottom.Controls.Add(Me.labelForgotPass)
        Me.panelBottom.Controls.Add(Me.label1)
        Me.panelBottom.Controls.Add(Me.labelRegister)
        Me.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelBottom.Location = New System.Drawing.Point(0, 597)
        Me.panelBottom.Margin = New System.Windows.Forms.Padding(0)
        Me.panelBottom.Name = "panelBottom"
        Me.panelBottom.Size = New System.Drawing.Size(460, 80)
        Me.panelBottom.TabIndex = 14
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
        Me.btnClose.Location = New System.Drawing.Point(430, 0)
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
        Me.panelTop.Controls.Add(Me.labelFormTitle)
        Me.panelTop.Controls.Add(Me.PictureBox1)
        Me.panelTop.Controls.Add(Me.btnMinimize)
        Me.panelTop.Controls.Add(Me.btnClose)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Margin = New System.Windows.Forms.Padding(0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(460, 30)
        Me.panelTop.TabIndex = 18
        '
        'labelFormTitle
        '
        Me.labelFormTitle.AutoSize = True
        Me.labelFormTitle.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelFormTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.labelFormTitle.Location = New System.Drawing.Point(33, 5)
        Me.labelFormTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.labelFormTitle.Name = "labelFormTitle"
        Me.labelFormTitle.Size = New System.Drawing.Size(112, 20)
        Me.labelFormTitle.TabIndex = 20
        Me.labelFormTitle.Text = "ATV-RMS Login"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.ATV_RMS.My.Resources.Resources.logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(9, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
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
        Me.btnMinimize.Location = New System.Drawing.Point(397, 0)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(30, 30)
        Me.btnMinimize.TabIndex = 19
        Me.btnMinimize.Text = "—"
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'panelPassLogin
        '
        Me.panelPassLogin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelPassLogin.BackColor = System.Drawing.Color.Transparent
        Me.panelPassLogin.Controls.Add(Me.lblLoginError)
        Me.panelPassLogin.Controls.Add(Me.lblSwitchLoginRFID)
        Me.panelPassLogin.Controls.Add(Me.lblUserError)
        Me.panelPassLogin.Controls.Add(Me.lblPassError)
        Me.panelPassLogin.Controls.Add(Me.labelPword)
        Me.panelPassLogin.Controls.Add(Me.labelUser)
        Me.panelPassLogin.Controls.Add(Me.btnLogin)
        Me.panelPassLogin.Controls.Add(Me.checkShow)
        Me.panelPassLogin.Controls.Add(Me.tboxUsername)
        Me.panelPassLogin.Controls.Add(Me.tboxPassword)
        Me.panelPassLogin.Location = New System.Drawing.Point(0, 269)
        Me.panelPassLogin.Name = "panelPassLogin"
        Me.panelPassLogin.Size = New System.Drawing.Size(460, 264)
        Me.panelPassLogin.TabIndex = 3
        '
        'lblLoginError
        '
        Me.lblLoginError.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoginError.BackColor = System.Drawing.Color.Firebrick
        Me.lblLoginError.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLoginError.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginError.ForeColor = System.Drawing.Color.White
        Me.lblLoginError.Location = New System.Drawing.Point(0, 156)
        Me.lblLoginError.Margin = New System.Windows.Forms.Padding(0)
        Me.lblLoginError.Name = "lblLoginError"
        Me.lblLoginError.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.lblLoginError.Size = New System.Drawing.Size(460, 22)
        Me.lblLoginError.TabIndex = 20
        Me.lblLoginError.Text = "*Authentication error message here."
        Me.lblLoginError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLoginError.Visible = False
        '
        'lblSwitchLoginRFID
        '
        Me.lblSwitchLoginRFID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSwitchLoginRFID.AutoSize = True
        Me.lblSwitchLoginRFID.BackColor = System.Drawing.Color.Transparent
        Me.lblSwitchLoginRFID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSwitchLoginRFID.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSwitchLoginRFID.ForeColor = System.Drawing.Color.White
        Me.lblSwitchLoginRFID.Location = New System.Drawing.Point(179, 240)
        Me.lblSwitchLoginRFID.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSwitchLoginRFID.Name = "lblSwitchLoginRFID"
        Me.lblSwitchLoginRFID.Size = New System.Drawing.Size(104, 14)
        Me.lblSwitchLoginRFID.TabIndex = 49
        Me.lblSwitchLoginRFID.Text = "Use RFID Card"
        Me.lblSwitchLoginRFID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUserError
        '
        Me.lblUserError.BackColor = System.Drawing.Color.Transparent
        Me.lblUserError.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserError.ForeColor = System.Drawing.Color.Red
        Me.lblUserError.Location = New System.Drawing.Point(181, 13)
        Me.lblUserError.Name = "lblUserError"
        Me.lblUserError.Size = New System.Drawing.Size(210, 19)
        Me.lblUserError.TabIndex = 48
        Me.lblUserError.Text = "This field is required."
        Me.lblUserError.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.lblUserError.Visible = False
        '
        'lblPassError
        '
        Me.lblPassError.BackColor = System.Drawing.Color.Transparent
        Me.lblPassError.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassError.ForeColor = System.Drawing.Color.Red
        Me.lblPassError.Location = New System.Drawing.Point(181, 80)
        Me.lblPassError.Name = "lblPassError"
        Me.lblPassError.Size = New System.Drawing.Size(210, 19)
        Me.lblPassError.TabIndex = 47
        Me.lblPassError.Text = "This field is required."
        Me.lblPassError.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.lblPassError.Visible = False
        '
        'labelPword
        '
        Me.labelPword.AutoSize = True
        Me.labelPword.BackColor = System.Drawing.Color.Transparent
        Me.labelPword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelPword.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPword.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.labelPword.Location = New System.Drawing.Point(64, 81)
        Me.labelPword.Margin = New System.Windows.Forms.Padding(0)
        Me.labelPword.Name = "labelPword"
        Me.labelPword.Size = New System.Drawing.Size(77, 16)
        Me.labelPword.TabIndex = 6
        Me.labelPword.Text = "password"
        Me.labelPword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelUser
        '
        Me.labelUser.AutoSize = True
        Me.labelUser.BackColor = System.Drawing.Color.Transparent
        Me.labelUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelUser.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelUser.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.labelUser.Location = New System.Drawing.Point(64, 14)
        Me.labelUser.Margin = New System.Windows.Forms.Padding(0)
        Me.labelUser.Name = "labelUser"
        Me.labelUser.Size = New System.Drawing.Size(80, 16)
        Me.labelUser.TabIndex = 4
        Me.labelUser.Text = "username"
        Me.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelRFIDLogin
        '
        Me.panelRFIDLogin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelRFIDLogin.BackColor = System.Drawing.Color.Transparent
        Me.panelRFIDLogin.Controls.Add(Me.lblRFIDErr)
        Me.panelRFIDLogin.Controls.Add(Me.label9)
        Me.panelRFIDLogin.Controls.Add(Me.tboxRFID)
        Me.panelRFIDLogin.Controls.Add(Me.lblSwitchLoginPass)
        Me.panelRFIDLogin.Location = New System.Drawing.Point(0, 269)
        Me.panelRFIDLogin.Name = "panelRFIDLogin"
        Me.panelRFIDLogin.Size = New System.Drawing.Size(460, 246)
        Me.panelRFIDLogin.TabIndex = 10
        '
        'lblRFIDErr
        '
        Me.lblRFIDErr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRFIDErr.BackColor = System.Drawing.Color.Firebrick
        Me.lblRFIDErr.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRFIDErr.ForeColor = System.Drawing.Color.White
        Me.lblRFIDErr.Location = New System.Drawing.Point(0, 117)
        Me.lblRFIDErr.Name = "lblRFIDErr"
        Me.lblRFIDErr.Size = New System.Drawing.Size(460, 19)
        Me.lblRFIDErr.TabIndex = 13
        Me.lblRFIDErr.Text = "*label for error message."
        Me.lblRFIDErr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblRFIDErr.Visible = False
        '
        'labelTItle
        '
        Me.labelTItle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelTItle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.labelTItle.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTItle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.labelTItle.Location = New System.Drawing.Point(0, 66)
        Me.labelTItle.Name = "labelTItle"
        Me.labelTItle.Size = New System.Drawing.Size(460, 51)
        Me.labelTItle.TabIndex = 19
        Me.labelTItle.Text = "Welcome to ATV-RMS!"
        Me.labelTItle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picboxLogo
        '
        Me.picboxLogo.BackColor = System.Drawing.Color.Transparent
        Me.picboxLogo.BackgroundImage = Global.ATV_RMS.My.Resources.Resources.logo
        Me.picboxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picboxLogo.Location = New System.Drawing.Point(102, 118)
        Me.picboxLogo.Name = "picboxLogo"
        Me.picboxLogo.Size = New System.Drawing.Size(303, 159)
        Me.picboxLogo.TabIndex = 4
        Me.picboxLogo.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(0, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(460, 10)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "                    "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rmsLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(460, 677)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.labelTItle)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.panelBottom)
        Me.Controls.Add(Me.picboxLogo)
        Me.Controls.Add(Me.panelPassLogin)
        Me.Controls.Add(Me.panelRFIDLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rmsLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login - ATV-RMS"
        Me.panelBottom.ResumeLayout(False)
        Me.panelBottom.PerformLayout()
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelPassLogin.ResumeLayout(False)
        Me.panelPassLogin.PerformLayout()
        Me.panelRFIDLogin.ResumeLayout(False)
        Me.panelRFIDLogin.PerformLayout()
        CType(Me.picboxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents picboxLogo As PictureBox
    Private WithEvents labelForgotPass As Label
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
    Public WithEvents lblSwitchLoginPass As Label
    Public WithEvents labelUser As Label
    Public WithEvents labelPword As Label
    Private WithEvents labelFormTitle As Label
    Friend WithEvents ToolTip1 As ToolTip
    Private WithEvents labelTItle As Label
    Public WithEvents lblLoginError As Label
    Public WithEvents lblRFIDErr As Label
    Public WithEvents lblPassError As Label
    Public WithEvents lblUserError As Label
    Public WithEvents lblSwitchLoginRFID As Label
    Private WithEvents PictureBox1 As PictureBox
    Private WithEvents Label2 As Label
End Class
