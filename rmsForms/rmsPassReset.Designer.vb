<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rmsPassReset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rmsPassReset))
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.labelFormTitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.panelResetEmail = New System.Windows.Forms.Panel()
        Me.lblResetEmailError = New System.Windows.Forms.Label()
        Me.lblReturnToUsername = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnResetEmailContinue = New System.Windows.Forms.Button()
        Me.tbxResetEmail = New System.Windows.Forms.TextBox()
        Me.panelResetUsername = New System.Windows.Forms.Panel()
        Me.lblResetUsernameError = New System.Windows.Forms.Label()
        Me.lblReturnToLogin = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnResetContinue = New System.Windows.Forms.Button()
        Me.tbxResetUsername = New System.Windows.Forms.TextBox()
        Me.panelResetNewPass = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbxResetNewPass2 = New System.Windows.Forms.TextBox()
        Me.lblResetPassError = New System.Windows.Forms.Label()
        Me.lblResetReturnToEmail = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.tbxResetNewPass = New System.Windows.Forms.TextBox()
        Me.panelTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelResetEmail.SuspendLayout()
        Me.panelResetUsername.SuspendLayout()
        Me.panelResetNewPass.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.panelTop.Controls.Add(Me.labelFormTitle)
        Me.panelTop.Controls.Add(Me.PictureBox1)
        Me.panelTop.Controls.Add(Me.btnClose)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Margin = New System.Windows.Forms.Padding(0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(406, 30)
        Me.panelTop.TabIndex = 53
        '
        'labelFormTitle
        '
        Me.labelFormTitle.AutoSize = True
        Me.labelFormTitle.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelFormTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.labelFormTitle.Location = New System.Drawing.Point(33, 5)
        Me.labelFormTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.labelFormTitle.Name = "labelFormTitle"
        Me.labelFormTitle.Size = New System.Drawing.Size(116, 20)
        Me.labelFormTitle.TabIndex = 20
        Me.labelFormTitle.Text = "Reset Password"
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
        Me.btnClose.Location = New System.Drawing.Point(376, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "x"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'panelResetEmail
        '
        Me.panelResetEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.panelResetEmail.Controls.Add(Me.lblResetEmailError)
        Me.panelResetEmail.Controls.Add(Me.lblReturnToUsername)
        Me.panelResetEmail.Controls.Add(Me.Label5)
        Me.panelResetEmail.Controls.Add(Me.btnResetEmailContinue)
        Me.panelResetEmail.Controls.Add(Me.tbxResetEmail)
        Me.panelResetEmail.Location = New System.Drawing.Point(0, 30)
        Me.panelResetEmail.Name = "panelResetEmail"
        Me.panelResetEmail.Size = New System.Drawing.Size(406, 245)
        Me.panelResetEmail.TabIndex = 55
        '
        'lblResetEmailError
        '
        Me.lblResetEmailError.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblResetEmailError.BackColor = System.Drawing.Color.Firebrick
        Me.lblResetEmailError.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblResetEmailError.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResetEmailError.ForeColor = System.Drawing.Color.White
        Me.lblResetEmailError.Location = New System.Drawing.Point(0, 132)
        Me.lblResetEmailError.Margin = New System.Windows.Forms.Padding(0)
        Me.lblResetEmailError.Name = "lblResetEmailError"
        Me.lblResetEmailError.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.lblResetEmailError.Size = New System.Drawing.Size(406, 22)
        Me.lblResetEmailError.TabIndex = 60
        Me.lblResetEmailError.Text = "Email address does not match. Try again."
        Me.lblResetEmailError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblResetEmailError.Visible = False
        '
        'lblReturnToUsername
        '
        Me.lblReturnToUsername.AutoSize = True
        Me.lblReturnToUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblReturnToUsername.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblReturnToUsername.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturnToUsername.ForeColor = System.Drawing.Color.White
        Me.lblReturnToUsername.Location = New System.Drawing.Point(9, 13)
        Me.lblReturnToUsername.Margin = New System.Windows.Forms.Padding(0)
        Me.lblReturnToUsername.Name = "lblReturnToUsername"
        Me.lblReturnToUsername.Size = New System.Drawing.Size(57, 13)
        Me.lblReturnToUsername.TabIndex = 62
        Me.lblReturnToUsername.Text = "<- back"
        Me.lblReturnToUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(37, 52)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(327, 39)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Enter email address associated with your account:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnResetEmailContinue
        '
        Me.btnResetEmailContinue.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnResetEmailContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnResetEmailContinue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResetEmailContinue.FlatAppearance.BorderSize = 0
        Me.btnResetEmailContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetEmailContinue.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetEmailContinue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnResetEmailContinue.Location = New System.Drawing.Point(144, 165)
        Me.btnResetEmailContinue.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetEmailContinue.Name = "btnResetEmailContinue"
        Me.btnResetEmailContinue.Size = New System.Drawing.Size(118, 37)
        Me.btnResetEmailContinue.TabIndex = 1
        Me.btnResetEmailContinue.Text = "continue"
        Me.btnResetEmailContinue.UseVisualStyleBackColor = False
        '
        'tbxResetEmail
        '
        Me.tbxResetEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxResetEmail.BackColor = System.Drawing.Color.White
        Me.tbxResetEmail.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxResetEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxResetEmail.Location = New System.Drawing.Point(40, 94)
        Me.tbxResetEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.tbxResetEmail.MaxLength = 40
        Me.tbxResetEmail.Name = "tbxResetEmail"
        Me.tbxResetEmail.Size = New System.Drawing.Size(324, 33)
        Me.tbxResetEmail.TabIndex = 0
        Me.tbxResetEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'panelResetUsername
        '
        Me.panelResetUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.panelResetUsername.Controls.Add(Me.lblResetUsernameError)
        Me.panelResetUsername.Controls.Add(Me.lblReturnToLogin)
        Me.panelResetUsername.Controls.Add(Me.Label1)
        Me.panelResetUsername.Controls.Add(Me.btnResetContinue)
        Me.panelResetUsername.Controls.Add(Me.tbxResetUsername)
        Me.panelResetUsername.Location = New System.Drawing.Point(0, 30)
        Me.panelResetUsername.Name = "panelResetUsername"
        Me.panelResetUsername.Size = New System.Drawing.Size(406, 245)
        Me.panelResetUsername.TabIndex = 56
        '
        'lblResetUsernameError
        '
        Me.lblResetUsernameError.BackColor = System.Drawing.Color.Firebrick
        Me.lblResetUsernameError.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblResetUsernameError.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResetUsernameError.ForeColor = System.Drawing.Color.White
        Me.lblResetUsernameError.Location = New System.Drawing.Point(0, 129)
        Me.lblResetUsernameError.Margin = New System.Windows.Forms.Padding(0)
        Me.lblResetUsernameError.Name = "lblResetUsernameError"
        Me.lblResetUsernameError.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.lblResetUsernameError.Size = New System.Drawing.Size(406, 22)
        Me.lblResetUsernameError.TabIndex = 60
        Me.lblResetUsernameError.Text = "No user found. Please try again."
        Me.lblResetUsernameError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblResetUsernameError.Visible = False
        '
        'lblReturnToLogin
        '
        Me.lblReturnToLogin.AutoSize = True
        Me.lblReturnToLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblReturnToLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblReturnToLogin.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturnToLogin.ForeColor = System.Drawing.Color.White
        Me.lblReturnToLogin.Location = New System.Drawing.Point(9, 13)
        Me.lblReturnToLogin.Margin = New System.Windows.Forms.Padding(0)
        Me.lblReturnToLogin.Name = "lblReturnToLogin"
        Me.lblReturnToLogin.Size = New System.Drawing.Size(120, 13)
        Me.lblReturnToLogin.TabIndex = 62
        Me.lblReturnToLogin.Text = "<- return to login"
        Me.lblReturnToLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(40, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 22)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Enter your username:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnResetContinue
        '
        Me.btnResetContinue.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnResetContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnResetContinue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResetContinue.FlatAppearance.BorderSize = 0
        Me.btnResetContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetContinue.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetContinue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnResetContinue.Location = New System.Drawing.Point(144, 160)
        Me.btnResetContinue.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetContinue.Name = "btnResetContinue"
        Me.btnResetContinue.Size = New System.Drawing.Size(118, 37)
        Me.btnResetContinue.TabIndex = 1
        Me.btnResetContinue.Text = "continue"
        Me.btnResetContinue.UseVisualStyleBackColor = False
        '
        'tbxResetUsername
        '
        Me.tbxResetUsername.BackColor = System.Drawing.Color.White
        Me.tbxResetUsername.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxResetUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxResetUsername.Location = New System.Drawing.Point(40, 91)
        Me.tbxResetUsername.Margin = New System.Windows.Forms.Padding(0)
        Me.tbxResetUsername.MaxLength = 40
        Me.tbxResetUsername.Name = "tbxResetUsername"
        Me.tbxResetUsername.Size = New System.Drawing.Size(324, 33)
        Me.tbxResetUsername.TabIndex = 0
        Me.tbxResetUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'panelResetNewPass
        '
        Me.panelResetNewPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.panelResetNewPass.Controls.Add(Me.Label4)
        Me.panelResetNewPass.Controls.Add(Me.tbxResetNewPass2)
        Me.panelResetNewPass.Controls.Add(Me.lblResetPassError)
        Me.panelResetNewPass.Controls.Add(Me.lblResetReturnToEmail)
        Me.panelResetNewPass.Controls.Add(Me.Label3)
        Me.panelResetNewPass.Controls.Add(Me.btnReset)
        Me.panelResetNewPass.Controls.Add(Me.tbxResetNewPass)
        Me.panelResetNewPass.Location = New System.Drawing.Point(0, 30)
        Me.panelResetNewPass.Name = "panelResetNewPass"
        Me.panelResetNewPass.Size = New System.Drawing.Size(406, 245)
        Me.panelResetNewPass.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(41, 99)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(324, 22)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Re-enter password:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbxResetNewPass2
        '
        Me.tbxResetNewPass2.BackColor = System.Drawing.Color.White
        Me.tbxResetNewPass2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxResetNewPass2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxResetNewPass2.Location = New System.Drawing.Point(41, 124)
        Me.tbxResetNewPass2.Margin = New System.Windows.Forms.Padding(0)
        Me.tbxResetNewPass2.MaxLength = 40
        Me.tbxResetNewPass2.Name = "tbxResetNewPass2"
        Me.tbxResetNewPass2.Size = New System.Drawing.Size(324, 33)
        Me.tbxResetNewPass2.TabIndex = 1
        Me.tbxResetNewPass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblResetPassError
        '
        Me.lblResetPassError.BackColor = System.Drawing.Color.Firebrick
        Me.lblResetPassError.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblResetPassError.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResetPassError.ForeColor = System.Drawing.Color.White
        Me.lblResetPassError.Location = New System.Drawing.Point(0, 160)
        Me.lblResetPassError.Margin = New System.Windows.Forms.Padding(0)
        Me.lblResetPassError.Name = "lblResetPassError"
        Me.lblResetPassError.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.lblResetPassError.Size = New System.Drawing.Size(406, 22)
        Me.lblResetPassError.TabIndex = 60
        Me.lblResetPassError.Text = "Passwords must match/be at least 8 characters."
        Me.lblResetPassError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblResetPassError.Visible = False
        '
        'lblResetReturnToEmail
        '
        Me.lblResetReturnToEmail.AutoSize = True
        Me.lblResetReturnToEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblResetReturnToEmail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblResetReturnToEmail.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResetReturnToEmail.ForeColor = System.Drawing.Color.White
        Me.lblResetReturnToEmail.Location = New System.Drawing.Point(9, 13)
        Me.lblResetReturnToEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.lblResetReturnToEmail.Name = "lblResetReturnToEmail"
        Me.lblResetReturnToEmail.Size = New System.Drawing.Size(57, 13)
        Me.lblResetReturnToEmail.TabIndex = 62
        Me.lblResetReturnToEmail.Text = "<- back"
        Me.lblResetReturnToEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(40, 36)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(324, 22)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Enter your new password:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnReset.Location = New System.Drawing.Point(144, 185)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(0)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(118, 37)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'tbxResetNewPass
        '
        Me.tbxResetNewPass.BackColor = System.Drawing.Color.White
        Me.tbxResetNewPass.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxResetNewPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxResetNewPass.Location = New System.Drawing.Point(40, 61)
        Me.tbxResetNewPass.Margin = New System.Windows.Forms.Padding(0)
        Me.tbxResetNewPass.MaxLength = 40
        Me.tbxResetNewPass.Name = "tbxResetNewPass"
        Me.tbxResetNewPass.Size = New System.Drawing.Size(324, 33)
        Me.tbxResetNewPass.TabIndex = 0
        Me.tbxResetNewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rmsPassReset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(406, 279)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.panelResetUsername)
        Me.Controls.Add(Me.panelResetEmail)
        Me.Controls.Add(Me.panelResetNewPass)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rmsPassReset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reset Password"
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelResetEmail.ResumeLayout(False)
        Me.panelResetEmail.PerformLayout()
        Me.panelResetUsername.ResumeLayout(False)
        Me.panelResetUsername.PerformLayout()
        Me.panelResetNewPass.ResumeLayout(False)
        Me.panelResetNewPass.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panelTop As Panel
    Private WithEvents labelFormTitle As Label
    Private WithEvents PictureBox1 As PictureBox
    Private WithEvents btnClose As Button
    Friend WithEvents panelResetEmail As Panel
    Public WithEvents lblResetEmailError As Label
    Public WithEvents lblReturnToUsername As Label
    Public WithEvents Label5 As Label
    Private WithEvents btnResetEmailContinue As Button
    Public WithEvents tbxResetEmail As TextBox
    Friend WithEvents panelResetUsername As Panel
    Public WithEvents lblResetUsernameError As Label
    Public WithEvents lblReturnToLogin As Label
    Public WithEvents Label1 As Label
    Private WithEvents btnResetContinue As Button
    Public WithEvents tbxResetUsername As TextBox
    Friend WithEvents panelResetNewPass As Panel
    Public WithEvents lblResetPassError As Label
    Public WithEvents lblResetReturnToEmail As Label
    Public WithEvents Label3 As Label
    Private WithEvents btnReset As Button
    Public WithEvents tbxResetNewPass As TextBox
    Public WithEvents Label4 As Label
    Public WithEvents tbxResetNewPass2 As TextBox
End Class
