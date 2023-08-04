<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rmsRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rmsRegistration))
        Me.labelFormTitle = New System.Windows.Forms.Label()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.regFname = New System.Windows.Forms.TextBox()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.picboxLogo = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.panelBottom = New System.Windows.Forms.Panel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.labelLogin = New System.Windows.Forms.Label()
        Me.labelLoginSwitch = New System.Windows.Forms.Label()
        Me.regRFID = New System.Windows.Forms.TextBox()
        Me.labelTItle = New System.Windows.Forms.Label()
        Me.labelTitle2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.regSname = New System.Windows.Forms.TextBox()
        Me.regPhone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.regUsername = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.regPassw = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.regEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.panelTop.SuspendLayout()
        CType(Me.picboxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelFormTitle
        '
        Me.labelFormTitle.AutoSize = True
        Me.labelFormTitle.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelFormTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.labelFormTitle.Location = New System.Drawing.Point(33, 7)
        Me.labelFormTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.labelFormTitle.Name = "labelFormTitle"
        Me.labelFormTitle.Size = New System.Drawing.Size(68, 16)
        Me.labelFormTitle.TabIndex = 18
        Me.labelFormTitle.Text = "ATV-RMS"
        '
        'btnReg
        '
        Me.btnReg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReg.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnReg.Location = New System.Drawing.Point(180, 523)
        Me.btnReg.Margin = New System.Windows.Forms.Padding(0)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(131, 45)
        Me.btnReg.TabIndex = 16
        Me.btnReg.Text = "Register"
        Me.btnReg.UseVisualStyleBackColor = False
        '
        'regFname
        '
        Me.regFname.BackColor = System.Drawing.Color.White
        Me.regFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.regFname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.regFname.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regFname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.regFname.Location = New System.Drawing.Point(60, 174)
        Me.regFname.Margin = New System.Windows.Forms.Padding(0)
        Me.regFname.MaxLength = 40
        Me.regFname.Name = "regFname"
        Me.regFname.Size = New System.Drawing.Size(182, 30)
        Me.regFname.TabIndex = 3
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
        Me.btnMinimize.Location = New System.Drawing.Point(422, 0)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(30, 30)
        Me.btnMinimize.TabIndex = 19
        Me.btnMinimize.Text = "—"
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.panelTop.Controls.Add(Me.labelFormTitle)
        Me.panelTop.Controls.Add(Me.btnMinimize)
        Me.panelTop.Controls.Add(Me.picboxLogo)
        Me.panelTop.Controls.Add(Me.btnClose)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Margin = New System.Windows.Forms.Padding(0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(485, 30)
        Me.panelTop.TabIndex = 17
        '
        'picboxLogo
        '
        Me.picboxLogo.BackColor = System.Drawing.Color.Transparent
        Me.picboxLogo.BackgroundImage = CType(resources.GetObject("picboxLogo.BackgroundImage"), System.Drawing.Image)
        Me.picboxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picboxLogo.Location = New System.Drawing.Point(9, 5)
        Me.picboxLogo.Name = "picboxLogo"
        Me.picboxLogo.Size = New System.Drawing.Size(20, 20)
        Me.picboxLogo.TabIndex = 4
        Me.picboxLogo.TabStop = False
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
        Me.btnClose.Location = New System.Drawing.Point(455, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.TabIndex = 20
        Me.btnClose.Text = "x"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'panelBottom
        '
        Me.panelBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panelBottom.Controls.Add(Me.label1)
        Me.panelBottom.Controls.Add(Me.labelLogin)
        Me.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelBottom.Location = New System.Drawing.Point(0, 621)
        Me.panelBottom.Margin = New System.Windows.Forms.Padding(0)
        Me.panelBottom.Name = "panelBottom"
        Me.panelBottom.Size = New System.Drawing.Size(485, 80)
        Me.panelBottom.TabIndex = 21
        '
        'label1
        '
        Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.label1.Location = New System.Drawing.Point(131, 30)
        Me.label1.Margin = New System.Windows.Forms.Padding(0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(180, 16)
        Me.label1.TabIndex = 22
        Me.label1.Text = "Already have an account?"
        '
        'labelLogin
        '
        Me.labelLogin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelLogin.AutoSize = True
        Me.labelLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelLogin.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelLogin.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.labelLogin.Location = New System.Drawing.Point(307, 30)
        Me.labelLogin.Margin = New System.Windows.Forms.Padding(0)
        Me.labelLogin.Name = "labelLogin"
        Me.labelLogin.Size = New System.Drawing.Size(46, 16)
        Me.labelLogin.TabIndex = 23
        Me.labelLogin.Text = "Login"
        '
        'labelLoginSwitch
        '
        Me.labelLoginSwitch.AutoSize = True
        Me.labelLoginSwitch.BackColor = System.Drawing.Color.Transparent
        Me.labelLoginSwitch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelLoginSwitch.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelLoginSwitch.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.labelLoginSwitch.Location = New System.Drawing.Point(57, 158)
        Me.labelLoginSwitch.Margin = New System.Windows.Forms.Padding(0)
        Me.labelLoginSwitch.Name = "labelLoginSwitch"
        Me.labelLoginSwitch.Size = New System.Drawing.Size(70, 14)
        Me.labelLoginSwitch.TabIndex = 2
        Me.labelLoginSwitch.Text = "first name"
        Me.labelLoginSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'regRFID
        '
        Me.regRFID.BackColor = System.Drawing.Color.White
        Me.regRFID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.regRFID.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regRFID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.regRFID.Location = New System.Drawing.Point(60, 473)
        Me.regRFID.Margin = New System.Windows.Forms.Padding(0)
        Me.regRFID.MaxLength = 12
        Me.regRFID.Name = "regRFID"
        Me.regRFID.Size = New System.Drawing.Size(366, 30)
        Me.regRFID.TabIndex = 15
        '
        'labelTItle
        '
        Me.labelTItle.AutoSize = True
        Me.labelTItle.BackColor = System.Drawing.Color.Transparent
        Me.labelTItle.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTItle.ForeColor = System.Drawing.Color.White
        Me.labelTItle.Location = New System.Drawing.Point(53, 62)
        Me.labelTItle.Name = "labelTItle"
        Me.labelTItle.Size = New System.Drawing.Size(226, 40)
        Me.labelTItle.TabIndex = 0
        Me.labelTItle.Text = "Register Now!"
        '
        'labelTitle2
        '
        Me.labelTitle2.AutoSize = True
        Me.labelTitle2.BackColor = System.Drawing.Color.Transparent
        Me.labelTitle2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle2.ForeColor = System.Drawing.Color.Gainsboro
        Me.labelTitle2.Location = New System.Drawing.Point(57, 107)
        Me.labelTitle2.Name = "labelTitle2"
        Me.labelTitle2.Size = New System.Drawing.Size(243, 14)
        Me.labelTitle2.TabIndex = 1
        Me.labelTitle2.Text = "Fill out the form to create an account."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(243, 158)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "surname"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'regSname
        '
        Me.regSname.BackColor = System.Drawing.Color.White
        Me.regSname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.regSname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.regSname.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regSname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.regSname.Location = New System.Drawing.Point(246, 174)
        Me.regSname.Margin = New System.Windows.Forms.Padding(0)
        Me.regSname.MaxLength = 40
        Me.regSname.Name = "regSname"
        Me.regSname.Size = New System.Drawing.Size(180, 30)
        Me.regSname.TabIndex = 5
        '
        'regPhone
        '
        Me.regPhone.BackColor = System.Drawing.Color.White
        Me.regPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.regPhone.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.regPhone.Location = New System.Drawing.Point(60, 292)
        Me.regPhone.Margin = New System.Windows.Forms.Padding(0)
        Me.regPhone.MaxLength = 13
        Me.regPhone.Name = "regPhone"
        Me.regPhone.Size = New System.Drawing.Size(366, 30)
        Me.regPhone.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(57, 276)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 14)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "phone number"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(57, 457)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 14)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "RFID no."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'regUsername
        '
        Me.regUsername.BackColor = System.Drawing.Color.White
        Me.regUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.regUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.regUsername.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.regUsername.Location = New System.Drawing.Point(60, 352)
        Me.regUsername.Margin = New System.Windows.Forms.Padding(0)
        Me.regUsername.MaxLength = 25
        Me.regUsername.Name = "regUsername"
        Me.regUsername.Size = New System.Drawing.Size(366, 30)
        Me.regUsername.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(57, 336)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 14)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "username"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'regPassw
        '
        Me.regPassw.BackColor = System.Drawing.Color.White
        Me.regPassw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.regPassw.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regPassw.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.regPassw.Location = New System.Drawing.Point(60, 413)
        Me.regPassw.Margin = New System.Windows.Forms.Padding(0)
        Me.regPassw.MaxLength = 25
        Me.regPassw.Name = "regPassw"
        Me.regPassw.Size = New System.Drawing.Size(366, 30)
        Me.regPassw.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(57, 397)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 14)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "password"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'regEmail
        '
        Me.regEmail.BackColor = System.Drawing.Color.White
        Me.regEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.regEmail.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.regEmail.Location = New System.Drawing.Point(60, 233)
        Me.regEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.regEmail.MaxLength = 40
        Me.regEmail.Name = "regEmail"
        Me.regEmail.Size = New System.Drawing.Size(366, 30)
        Me.regEmail.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(57, 217)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 14)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "email"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rmsRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(485, 701)
        Me.Controls.Add(Me.regEmail)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.regPassw)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.regUsername)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.regPhone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.regSname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.regRFID)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.panelBottom)
        Me.Controls.Add(Me.labelLoginSwitch)
        Me.Controls.Add(Me.regFname)
        Me.Controls.Add(Me.labelTItle)
        Me.Controls.Add(Me.labelTitle2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rmsRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register - ATV-RMS"
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        CType(Me.picboxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBottom.ResumeLayout(False)
        Me.panelBottom.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents labelFormTitle As Label
    Private WithEvents btnReg As Button
    Private WithEvents btnMinimize As Button
    Private WithEvents panelTop As Panel
    Private WithEvents picboxLogo As PictureBox
    Private WithEvents btnClose As Button
    Private WithEvents panelBottom As Panel
    Private WithEvents label1 As Label
    Private WithEvents labelLogin As Label
    Public WithEvents labelLoginSwitch As Label
    Public WithEvents regRFID As TextBox
    Private WithEvents labelTItle As Label
    Private WithEvents labelTitle2 As Label
    Public WithEvents Label3 As Label
    Public WithEvents Label4 As Label
    Public WithEvents Label5 As Label
    Public WithEvents Label6 As Label
    Public WithEvents Label7 As Label
    Public WithEvents Label8 As Label
    Public WithEvents regFname As TextBox
    Public WithEvents regSname As TextBox
    Public WithEvents regPhone As TextBox
    Public WithEvents regUsername As TextBox
    Public WithEvents regPassw As TextBox
    Public WithEvents regEmail As TextBox
End Class
