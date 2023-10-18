<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rmsRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rmsRegistration))
        Me.labelFormTitle = New System.Windows.Forms.Label()
        Me.regFName = New System.Windows.Forms.TextBox()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.picboxLogo = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.panelBottom = New System.Windows.Forms.Panel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.labelLogin = New System.Windows.Forms.Label()
        Me.lblRegFName = New System.Windows.Forms.Label()
        Me.regRFID = New System.Windows.Forms.TextBox()
        Me.labelTitle = New System.Windows.Forms.Label()
        Me.labelTitle2 = New System.Windows.Forms.Label()
        Me.lblRegMName = New System.Windows.Forms.Label()
        Me.regMName = New System.Windows.Forms.TextBox()
        Me.regPhone = New System.Windows.Forms.TextBox()
        Me.lblRegPhone = New System.Windows.Forms.Label()
        Me.lblRegRFID = New System.Windows.Forms.Label()
        Me.regUsername = New System.Windows.Forms.TextBox()
        Me.lblRegUsername = New System.Windows.Forms.Label()
        Me.regPassw = New System.Windows.Forms.TextBox()
        Me.lblRegPassw = New System.Windows.Forms.Label()
        Me.regEmail = New System.Windows.Forms.TextBox()
        Me.lblRegEmail = New System.Windows.Forms.Label()
        Me.regSname = New System.Windows.Forms.TextBox()
        Me.lblRegSname = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblPanel1Note = New System.Windows.Forms.Label()
        Me.btnNext1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblPhoneInvalid = New System.Windows.Forms.Label()
        Me.lblPanel2Note = New System.Windows.Forms.Label()
        Me.lblRFIDUsed = New System.Windows.Forms.Label()
        Me.lblEmailUsed = New System.Windows.Forms.Label()
        Me.btnRet1 = New System.Windows.Forms.Button()
        Me.lblHello = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnNext2 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblUsernameShort = New System.Windows.Forms.Label()
        Me.lblPassShort = New System.Windows.Forms.Label()
        Me.lblPanel3Note = New System.Windows.Forms.Label()
        Me.btnRet2 = New System.Windows.Forms.Button()
        Me.regPassw2 = New System.Windows.Forms.TextBox()
        Me.lblRegPassw2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnNext3 = New System.Windows.Forms.Button()
        Me.lblPassError = New System.Windows.Forms.Label()
        Me.lblUsernameUsed = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.panelSname = New System.Windows.Forms.Label()
        Me.panelFName = New System.Windows.Forms.Label()
        Me.panelMName = New System.Windows.Forms.Label()
        Me.panelEmail = New System.Windows.Forms.Label()
        Me.panelPhone = New System.Windows.Forms.Label()
        Me.panelRFID = New System.Windows.Forms.Label()
        Me.panelPasswor = New System.Windows.Forms.Label()
        Me.panelUsernam = New System.Windows.Forms.Label()
        Me.lblReg3 = New System.Windows.Forms.Label()
        Me.lblReg1 = New System.Windows.Forms.Label()
        Me.lblReg2 = New System.Windows.Forms.Label()
        Me.lblReg4 = New System.Windows.Forms.Label()
        Me.lblReg5 = New System.Windows.Forms.Label()
        Me.lblReg6 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblReg8 = New System.Windows.Forms.Label()
        Me.lblReg7 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnRegOk = New System.Windows.Forms.Button()
        Me.lblPendingUserMessage = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.panelTop.SuspendLayout()
        CType(Me.picboxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBottom.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelFormTitle
        '
        Me.labelFormTitle.AutoSize = True
        Me.labelFormTitle.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelFormTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.labelFormTitle.Location = New System.Drawing.Point(33, 5)
        Me.labelFormTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.labelFormTitle.Name = "labelFormTitle"
        Me.labelFormTitle.Size = New System.Drawing.Size(70, 20)
        Me.labelFormTitle.TabIndex = 0
        Me.labelFormTitle.Text = "ATV-RMS"
        '
        'regFName
        '
        Me.regFName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.regFName.BackColor = System.Drawing.Color.White
        Me.regFName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.regFName.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regFName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.regFName.Location = New System.Drawing.Point(58, 190)
        Me.regFName.Margin = New System.Windows.Forms.Padding(0)
        Me.regFName.MaxLength = 40
        Me.regFName.Name = "regFName"
        Me.regFName.Size = New System.Drawing.Size(344, 33)
        Me.regFName.TabIndex = 3
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
        Me.btnMinimize.TabIndex = 0
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
        Me.panelTop.Size = New System.Drawing.Size(460, 30)
        Me.panelTop.TabIndex = 5
        '
        'picboxLogo
        '
        Me.picboxLogo.BackColor = System.Drawing.Color.Transparent
        Me.picboxLogo.BackgroundImage = Global.ATV_RMS.My.Resources.Resources.logo
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
        Me.btnClose.Location = New System.Drawing.Point(430, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "x"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'panelBottom
        '
        Me.panelBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panelBottom.Controls.Add(Me.label1)
        Me.panelBottom.Controls.Add(Me.labelLogin)
        Me.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelBottom.Location = New System.Drawing.Point(0, 597)
        Me.panelBottom.Margin = New System.Windows.Forms.Padding(0)
        Me.panelBottom.Name = "panelBottom"
        Me.panelBottom.Size = New System.Drawing.Size(460, 80)
        Me.panelBottom.TabIndex = 4
        '
        'label1
        '
        Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.label1.Location = New System.Drawing.Point(116, 28)
        Me.label1.Margin = New System.Windows.Forms.Padding(0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(180, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Already have an account?"
        '
        'labelLogin
        '
        Me.labelLogin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelLogin.AutoSize = True
        Me.labelLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelLogin.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelLogin.ForeColor = System.Drawing.Color.White
        Me.labelLogin.Location = New System.Drawing.Point(292, 28)
        Me.labelLogin.Margin = New System.Windows.Forms.Padding(0)
        Me.labelLogin.Name = "labelLogin"
        Me.labelLogin.Size = New System.Drawing.Size(46, 16)
        Me.labelLogin.TabIndex = 1
        Me.labelLogin.Text = "Login"
        '
        'lblRegFName
        '
        Me.lblRegFName.AutoSize = True
        Me.lblRegFName.BackColor = System.Drawing.Color.Transparent
        Me.lblRegFName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRegFName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegFName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblRegFName.Location = New System.Drawing.Point(55, 171)
        Me.lblRegFName.Margin = New System.Windows.Forms.Padding(0)
        Me.lblRegFName.Name = "lblRegFName"
        Me.lblRegFName.Size = New System.Drawing.Size(90, 16)
        Me.lblRegFName.TabIndex = 2
        Me.lblRegFName.Text = "first name*"
        Me.lblRegFName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'regRFID
        '
        Me.regRFID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.regRFID.BackColor = System.Drawing.Color.White
        Me.regRFID.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regRFID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.regRFID.Location = New System.Drawing.Point(58, 334)
        Me.regRFID.Margin = New System.Windows.Forms.Padding(0)
        Me.regRFID.MaxLength = 12
        Me.regRFID.Name = "regRFID"
        Me.regRFID.Size = New System.Drawing.Size(344, 33)
        Me.regRFID.TabIndex = 2
        '
        'labelTitle
        '
        Me.labelTitle.AutoSize = True
        Me.labelTitle.BackColor = System.Drawing.Color.Transparent
        Me.labelTitle.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.labelTitle.Location = New System.Drawing.Point(50, 50)
        Me.labelTitle.Name = "labelTitle"
        Me.labelTitle.Size = New System.Drawing.Size(283, 43)
        Me.labelTitle.TabIndex = 0
        Me.labelTitle.Text = "REGISTER HERE!"
        '
        'labelTitle2
        '
        Me.labelTitle2.AutoSize = True
        Me.labelTitle2.BackColor = System.Drawing.Color.Transparent
        Me.labelTitle2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle2.ForeColor = System.Drawing.Color.Gainsboro
        Me.labelTitle2.Location = New System.Drawing.Point(55, 95)
        Me.labelTitle2.Name = "labelTitle2"
        Me.labelTitle2.Size = New System.Drawing.Size(243, 14)
        Me.labelTitle2.TabIndex = 1
        Me.labelTitle2.Text = "Fill out the form to create an account."
        '
        'lblRegMName
        '
        Me.lblRegMName.AutoSize = True
        Me.lblRegMName.BackColor = System.Drawing.Color.Transparent
        Me.lblRegMName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRegMName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegMName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblRegMName.Location = New System.Drawing.Point(55, 243)
        Me.lblRegMName.Margin = New System.Windows.Forms.Padding(0)
        Me.lblRegMName.Name = "lblRegMName"
        Me.lblRegMName.Size = New System.Drawing.Size(101, 16)
        Me.lblRegMName.TabIndex = 4
        Me.lblRegMName.Text = "middle name"
        Me.lblRegMName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'regMName
        '
        Me.regMName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.regMName.BackColor = System.Drawing.Color.White
        Me.regMName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.regMName.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regMName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.regMName.Location = New System.Drawing.Point(58, 261)
        Me.regMName.Margin = New System.Windows.Forms.Padding(0)
        Me.regMName.MaxLength = 40
        Me.regMName.Name = "regMName"
        Me.regMName.Size = New System.Drawing.Size(344, 33)
        Me.regMName.TabIndex = 5
        '
        'regPhone
        '
        Me.regPhone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.regPhone.BackColor = System.Drawing.Color.White
        Me.regPhone.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.regPhone.Location = New System.Drawing.Point(58, 261)
        Me.regPhone.Margin = New System.Windows.Forms.Padding(0)
        Me.regPhone.MaxLength = 13
        Me.regPhone.Name = "regPhone"
        Me.regPhone.Size = New System.Drawing.Size(344, 33)
        Me.regPhone.TabIndex = 1
        '
        'lblRegPhone
        '
        Me.lblRegPhone.AutoSize = True
        Me.lblRegPhone.BackColor = System.Drawing.Color.Transparent
        Me.lblRegPhone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRegPhone.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegPhone.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblRegPhone.Location = New System.Drawing.Point(55, 242)
        Me.lblRegPhone.Margin = New System.Windows.Forms.Padding(0)
        Me.lblRegPhone.Name = "lblRegPhone"
        Me.lblRegPhone.Size = New System.Drawing.Size(112, 16)
        Me.lblRegPhone.TabIndex = 4
        Me.lblRegPhone.Text = "phone number"
        Me.lblRegPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRegRFID
        '
        Me.lblRegRFID.AutoSize = True
        Me.lblRegRFID.BackColor = System.Drawing.Color.Transparent
        Me.lblRegRFID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRegRFID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegRFID.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblRegRFID.Location = New System.Drawing.Point(55, 315)
        Me.lblRegRFID.Margin = New System.Windows.Forms.Padding(0)
        Me.lblRegRFID.Name = "lblRegRFID"
        Me.lblRegRFID.Size = New System.Drawing.Size(68, 16)
        Me.lblRegRFID.TabIndex = 6
        Me.lblRegRFID.Text = "RFID no."
        Me.lblRegRFID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'regUsername
        '
        Me.regUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.regUsername.BackColor = System.Drawing.Color.White
        Me.regUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.regUsername.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.regUsername.Location = New System.Drawing.Point(58, 190)
        Me.regUsername.Margin = New System.Windows.Forms.Padding(0)
        Me.regUsername.MaxLength = 25
        Me.regUsername.Name = "regUsername"
        Me.regUsername.Size = New System.Drawing.Size(344, 33)
        Me.regUsername.TabIndex = 0
        '
        'lblRegUsername
        '
        Me.lblRegUsername.AutoSize = True
        Me.lblRegUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblRegUsername.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRegUsername.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegUsername.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblRegUsername.Location = New System.Drawing.Point(55, 171)
        Me.lblRegUsername.Margin = New System.Windows.Forms.Padding(0)
        Me.lblRegUsername.Name = "lblRegUsername"
        Me.lblRegUsername.Size = New System.Drawing.Size(80, 16)
        Me.lblRegUsername.TabIndex = 10
        Me.lblRegUsername.Text = "username"
        Me.lblRegUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'regPassw
        '
        Me.regPassw.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.regPassw.BackColor = System.Drawing.Color.White
        Me.regPassw.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regPassw.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.regPassw.Location = New System.Drawing.Point(58, 261)
        Me.regPassw.Margin = New System.Windows.Forms.Padding(0)
        Me.regPassw.MaxLength = 25
        Me.regPassw.Name = "regPassw"
        Me.regPassw.Size = New System.Drawing.Size(344, 33)
        Me.regPassw.TabIndex = 1
        '
        'lblRegPassw
        '
        Me.lblRegPassw.AutoSize = True
        Me.lblRegPassw.BackColor = System.Drawing.Color.Transparent
        Me.lblRegPassw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRegPassw.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegPassw.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblRegPassw.Location = New System.Drawing.Point(55, 242)
        Me.lblRegPassw.Margin = New System.Windows.Forms.Padding(0)
        Me.lblRegPassw.Name = "lblRegPassw"
        Me.lblRegPassw.Size = New System.Drawing.Size(77, 16)
        Me.lblRegPassw.TabIndex = 12
        Me.lblRegPassw.Text = "password"
        Me.lblRegPassw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'regEmail
        '
        Me.regEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.regEmail.BackColor = System.Drawing.Color.White
        Me.regEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.regEmail.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.regEmail.Location = New System.Drawing.Point(58, 190)
        Me.regEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.regEmail.MaxLength = 40
        Me.regEmail.Name = "regEmail"
        Me.regEmail.Size = New System.Drawing.Size(344, 33)
        Me.regEmail.TabIndex = 0
        '
        'lblRegEmail
        '
        Me.lblRegEmail.AutoSize = True
        Me.lblRegEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblRegEmail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRegEmail.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegEmail.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblRegEmail.Location = New System.Drawing.Point(55, 171)
        Me.lblRegEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.lblRegEmail.Name = "lblRegEmail"
        Me.lblRegEmail.Size = New System.Drawing.Size(47, 16)
        Me.lblRegEmail.TabIndex = 2
        Me.lblRegEmail.Text = "email"
        Me.lblRegEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'regSname
        '
        Me.regSname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.regSname.BackColor = System.Drawing.Color.White
        Me.regSname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.regSname.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regSname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.regSname.Location = New System.Drawing.Point(58, 334)
        Me.regSname.Margin = New System.Windows.Forms.Padding(0)
        Me.regSname.MaxLength = 40
        Me.regSname.Name = "regSname"
        Me.regSname.Size = New System.Drawing.Size(344, 33)
        Me.regSname.TabIndex = 7
        '
        'lblRegSname
        '
        Me.lblRegSname.AutoSize = True
        Me.lblRegSname.BackColor = System.Drawing.Color.Transparent
        Me.lblRegSname.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRegSname.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegSname.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblRegSname.Location = New System.Drawing.Point(55, 315)
        Me.lblRegSname.Margin = New System.Windows.Forms.Padding(0)
        Me.lblRegSname.Name = "lblRegSname"
        Me.lblRegSname.Size = New System.Drawing.Size(80, 16)
        Me.lblRegSname.TabIndex = 6
        Me.lblRegSname.Text = "surname*"
        Me.lblRegSname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.lblPanel1Note)
        Me.Panel1.Controls.Add(Me.btnNext1)
        Me.Panel1.Controls.Add(Me.labelTitle)
        Me.Panel1.Controls.Add(Me.regSname)
        Me.Panel1.Controls.Add(Me.labelTitle2)
        Me.Panel1.Controls.Add(Me.lblRegSname)
        Me.Panel1.Controls.Add(Me.regFName)
        Me.Panel1.Controls.Add(Me.lblRegFName)
        Me.Panel1.Controls.Add(Me.lblRegMName)
        Me.Panel1.Controls.Add(Me.regMName)
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(460, 567)
        Me.Panel1.TabIndex = 1
        '
        'lblPanel1Note
        '
        Me.lblPanel1Note.BackColor = System.Drawing.Color.Firebrick
        Me.lblPanel1Note.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPanel1Note.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPanel1Note.ForeColor = System.Drawing.Color.White
        Me.lblPanel1Note.Location = New System.Drawing.Point(0, 503)
        Me.lblPanel1Note.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPanel1Note.Name = "lblPanel1Note"
        Me.lblPanel1Note.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.lblPanel1Note.Size = New System.Drawing.Size(460, 22)
        Me.lblPanel1Note.TabIndex = 12
        Me.lblPanel1Note.Text = "*Please fill out the required field/s to proceed."
        Me.lblPanel1Note.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPanel1Note.Visible = False
        '
        'btnNext1
        '
        Me.btnNext1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNext1.BackColor = System.Drawing.Color.Transparent
        Me.btnNext1.BackgroundImage = Global.ATV_RMS.My.Resources.Resources._next
        Me.btnNext1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNext1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnNext1.FlatAppearance.BorderSize = 0
        Me.btnNext1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNext1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNext1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext1.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnNext1.Location = New System.Drawing.Point(188, 411)
        Me.btnNext1.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNext1.Name = "btnNext1"
        Me.btnNext1.Size = New System.Drawing.Size(85, 85)
        Me.btnNext1.TabIndex = 9
        Me.btnNext1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.lblPhoneInvalid)
        Me.Panel2.Controls.Add(Me.lblPanel2Note)
        Me.Panel2.Controls.Add(Me.lblRFIDUsed)
        Me.Panel2.Controls.Add(Me.lblEmailUsed)
        Me.Panel2.Controls.Add(Me.btnRet1)
        Me.Panel2.Controls.Add(Me.lblHello)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.regEmail)
        Me.Panel2.Controls.Add(Me.btnNext2)
        Me.Panel2.Controls.Add(Me.lblRegEmail)
        Me.Panel2.Controls.Add(Me.regRFID)
        Me.Panel2.Controls.Add(Me.lblRegPhone)
        Me.Panel2.Controls.Add(Me.regPhone)
        Me.Panel2.Controls.Add(Me.lblRegRFID)
        Me.Panel2.Location = New System.Drawing.Point(0, 30)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(460, 567)
        Me.Panel2.TabIndex = 1
        '
        'lblPhoneInvalid
        '
        Me.lblPhoneInvalid.BackColor = System.Drawing.Color.Transparent
        Me.lblPhoneInvalid.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPhoneInvalid.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneInvalid.ForeColor = System.Drawing.Color.Red
        Me.lblPhoneInvalid.Location = New System.Drawing.Point(173, 242)
        Me.lblPhoneInvalid.Name = "lblPhoneInvalid"
        Me.lblPhoneInvalid.Size = New System.Drawing.Size(229, 19)
        Me.lblPhoneInvalid.TabIndex = 48
        Me.lblPhoneInvalid.Text = "Invalid phone number"
        Me.lblPhoneInvalid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPhoneInvalid.Visible = False
        '
        'lblPanel2Note
        '
        Me.lblPanel2Note.BackColor = System.Drawing.Color.Firebrick
        Me.lblPanel2Note.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPanel2Note.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPanel2Note.ForeColor = System.Drawing.Color.White
        Me.lblPanel2Note.Location = New System.Drawing.Point(0, 503)
        Me.lblPanel2Note.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPanel2Note.Name = "lblPanel2Note"
        Me.lblPanel2Note.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.lblPanel2Note.Size = New System.Drawing.Size(460, 22)
        Me.lblPanel2Note.TabIndex = 47
        Me.lblPanel2Note.Text = "Please provide your contact details to proceed."
        Me.lblPanel2Note.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPanel2Note.Visible = False
        '
        'lblRFIDUsed
        '
        Me.lblRFIDUsed.BackColor = System.Drawing.Color.Transparent
        Me.lblRFIDUsed.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRFIDUsed.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRFIDUsed.ForeColor = System.Drawing.Color.Red
        Me.lblRFIDUsed.Location = New System.Drawing.Point(173, 315)
        Me.lblRFIDUsed.Name = "lblRFIDUsed"
        Me.lblRFIDUsed.Size = New System.Drawing.Size(229, 19)
        Me.lblRFIDUsed.TabIndex = 46
        Me.lblRFIDUsed.Text = "This RFID is already in use"
        Me.lblRFIDUsed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblRFIDUsed.Visible = False
        '
        'lblEmailUsed
        '
        Me.lblEmailUsed.BackColor = System.Drawing.Color.Transparent
        Me.lblEmailUsed.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEmailUsed.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailUsed.ForeColor = System.Drawing.Color.Red
        Me.lblEmailUsed.Location = New System.Drawing.Point(173, 171)
        Me.lblEmailUsed.Name = "lblEmailUsed"
        Me.lblEmailUsed.Size = New System.Drawing.Size(229, 19)
        Me.lblEmailUsed.TabIndex = 45
        Me.lblEmailUsed.Text = "This email is already in use"
        Me.lblEmailUsed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblEmailUsed.Visible = False
        '
        'btnRet1
        '
        Me.btnRet1.AutoSize = True
        Me.btnRet1.BackColor = System.Drawing.Color.Transparent
        Me.btnRet1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRet1.FlatAppearance.BorderSize = 0
        Me.btnRet1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnRet1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRet1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRet1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRet1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnRet1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRet1.Location = New System.Drawing.Point(9, 11)
        Me.btnRet1.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRet1.Name = "btnRet1"
        Me.btnRet1.Size = New System.Drawing.Size(67, 28)
        Me.btnRet1.TabIndex = 4
        Me.btnRet1.Text = "< Return"
        Me.btnRet1.UseVisualStyleBackColor = True
        '
        'lblHello
        '
        Me.lblHello.AutoSize = True
        Me.lblHello.BackColor = System.Drawing.Color.Transparent
        Me.lblHello.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHello.ForeColor = System.Drawing.Color.White
        Me.lblHello.Location = New System.Drawing.Point(50, 52)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(185, 40)
        Me.lblHello.TabIndex = 0
        Me.lblHello.Text = "Hi, +NAME!"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label10.Location = New System.Drawing.Point(55, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(173, 14)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Enter your contact details."
        '
        'btnNext2
        '
        Me.btnNext2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNext2.BackColor = System.Drawing.Color.Transparent
        Me.btnNext2.BackgroundImage = Global.ATV_RMS.My.Resources.Resources._next
        Me.btnNext2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNext2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnNext2.FlatAppearance.BorderSize = 0
        Me.btnNext2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNext2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNext2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext2.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnNext2.Location = New System.Drawing.Point(188, 411)
        Me.btnNext2.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNext2.Name = "btnNext2"
        Me.btnNext2.Size = New System.Drawing.Size(85, 85)
        Me.btnNext2.TabIndex = 3
        Me.btnNext2.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.lblUsernameShort)
        Me.Panel3.Controls.Add(Me.lblPassShort)
        Me.Panel3.Controls.Add(Me.lblPanel3Note)
        Me.Panel3.Controls.Add(Me.btnRet2)
        Me.Panel3.Controls.Add(Me.regPassw2)
        Me.Panel3.Controls.Add(Me.lblRegPassw2)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.btnNext3)
        Me.Panel3.Controls.Add(Me.regPassw)
        Me.Panel3.Controls.Add(Me.regUsername)
        Me.Panel3.Controls.Add(Me.lblRegPassw)
        Me.Panel3.Controls.Add(Me.lblRegUsername)
        Me.Panel3.Controls.Add(Me.lblPassError)
        Me.Panel3.Controls.Add(Me.lblUsernameUsed)
        Me.Panel3.Location = New System.Drawing.Point(0, 30)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(460, 567)
        Me.Panel3.TabIndex = 2
        '
        'lblUsernameShort
        '
        Me.lblUsernameShort.BackColor = System.Drawing.Color.Transparent
        Me.lblUsernameShort.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblUsernameShort.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsernameShort.ForeColor = System.Drawing.Color.Red
        Me.lblUsernameShort.Location = New System.Drawing.Point(173, 171)
        Me.lblUsernameShort.Name = "lblUsernameShort"
        Me.lblUsernameShort.Size = New System.Drawing.Size(229, 19)
        Me.lblUsernameShort.TabIndex = 52
        Me.lblUsernameShort.Text = "username too short"
        Me.lblUsernameShort.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblUsernameShort.Visible = False
        '
        'lblPassShort
        '
        Me.lblPassShort.BackColor = System.Drawing.Color.Transparent
        Me.lblPassShort.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPassShort.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassShort.ForeColor = System.Drawing.Color.Red
        Me.lblPassShort.Location = New System.Drawing.Point(173, 242)
        Me.lblPassShort.Name = "lblPassShort"
        Me.lblPassShort.Size = New System.Drawing.Size(229, 19)
        Me.lblPassShort.TabIndex = 51
        Me.lblPassShort.Text = "password too short"
        Me.lblPassShort.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPassShort.Visible = False
        '
        'lblPanel3Note
        '
        Me.lblPanel3Note.BackColor = System.Drawing.Color.Firebrick
        Me.lblPanel3Note.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPanel3Note.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPanel3Note.ForeColor = System.Drawing.Color.White
        Me.lblPanel3Note.Location = New System.Drawing.Point(0, 503)
        Me.lblPanel3Note.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPanel3Note.Name = "lblPanel3Note"
        Me.lblPanel3Note.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.lblPanel3Note.Size = New System.Drawing.Size(460, 22)
        Me.lblPanel3Note.TabIndex = 49
        Me.lblPanel3Note.Text = "Unable to proceed: Please fill out empty field/s."
        Me.lblPanel3Note.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPanel3Note.Visible = False
        '
        'btnRet2
        '
        Me.btnRet2.AutoSize = True
        Me.btnRet2.BackColor = System.Drawing.Color.Transparent
        Me.btnRet2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRet2.FlatAppearance.BorderSize = 0
        Me.btnRet2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btnRet2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRet2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRet2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRet2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnRet2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRet2.Location = New System.Drawing.Point(9, 11)
        Me.btnRet2.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRet2.Name = "btnRet2"
        Me.btnRet2.Size = New System.Drawing.Size(67, 28)
        Me.btnRet2.TabIndex = 4
        Me.btnRet2.Text = "< Return"
        Me.btnRet2.UseVisualStyleBackColor = True
        '
        'regPassw2
        '
        Me.regPassw2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.regPassw2.BackColor = System.Drawing.Color.White
        Me.regPassw2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regPassw2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.regPassw2.Location = New System.Drawing.Point(58, 334)
        Me.regPassw2.Margin = New System.Windows.Forms.Padding(0)
        Me.regPassw2.MaxLength = 25
        Me.regPassw2.Name = "regPassw2"
        Me.regPassw2.Size = New System.Drawing.Size(344, 33)
        Me.regPassw2.TabIndex = 2
        '
        'lblRegPassw2
        '
        Me.lblRegPassw2.AutoSize = True
        Me.lblRegPassw2.BackColor = System.Drawing.Color.Transparent
        Me.lblRegPassw2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRegPassw2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegPassw2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblRegPassw2.Location = New System.Drawing.Point(55, 315)
        Me.lblRegPassw2.Margin = New System.Windows.Forms.Padding(0)
        Me.lblRegPassw2.Name = "lblRegPassw2"
        Me.lblRegPassw2.Size = New System.Drawing.Size(142, 16)
        Me.lblRegPassw2.TabIndex = 17
        Me.lblRegPassw2.Text = "re-enter password"
        Me.lblRegPassw2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(50, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(289, 43)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "ALMOST DONE..."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label12.Location = New System.Drawing.Point(55, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(247, 14)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Create your username and password."
        '
        'btnNext3
        '
        Me.btnNext3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNext3.BackColor = System.Drawing.Color.Transparent
        Me.btnNext3.BackgroundImage = Global.ATV_RMS.My.Resources.Resources._next
        Me.btnNext3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNext3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnNext3.FlatAppearance.BorderSize = 0
        Me.btnNext3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNext3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNext3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext3.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnNext3.Location = New System.Drawing.Point(188, 411)
        Me.btnNext3.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNext3.Name = "btnNext3"
        Me.btnNext3.Size = New System.Drawing.Size(85, 85)
        Me.btnNext3.TabIndex = 3
        Me.btnNext3.UseVisualStyleBackColor = False
        '
        'lblPassError
        '
        Me.lblPassError.BackColor = System.Drawing.Color.Transparent
        Me.lblPassError.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPassError.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassError.ForeColor = System.Drawing.Color.Red
        Me.lblPassError.Location = New System.Drawing.Point(173, 315)
        Me.lblPassError.Name = "lblPassError"
        Me.lblPassError.Size = New System.Drawing.Size(229, 19)
        Me.lblPassError.TabIndex = 50
        Me.lblPassError.Text = "password not matched"
        Me.lblPassError.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPassError.Visible = False
        '
        'lblUsernameUsed
        '
        Me.lblUsernameUsed.BackColor = System.Drawing.Color.Transparent
        Me.lblUsernameUsed.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsernameUsed.ForeColor = System.Drawing.Color.Red
        Me.lblUsernameUsed.Location = New System.Drawing.Point(173, 171)
        Me.lblUsernameUsed.Name = "lblUsernameUsed"
        Me.lblUsernameUsed.Size = New System.Drawing.Size(229, 19)
        Me.lblUsernameUsed.TabIndex = 48
        Me.lblUsernameUsed.Text = "username already in use"
        Me.lblUsernameUsed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblUsernameUsed.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.btnReg)
        Me.Panel4.Controls.Add(Me.panelSname)
        Me.Panel4.Controls.Add(Me.panelFName)
        Me.Panel4.Controls.Add(Me.panelMName)
        Me.Panel4.Controls.Add(Me.panelEmail)
        Me.Panel4.Controls.Add(Me.panelPhone)
        Me.Panel4.Controls.Add(Me.panelRFID)
        Me.Panel4.Controls.Add(Me.panelPasswor)
        Me.Panel4.Controls.Add(Me.panelUsernam)
        Me.Panel4.Controls.Add(Me.lblReg3)
        Me.Panel4.Controls.Add(Me.lblReg1)
        Me.Panel4.Controls.Add(Me.lblReg2)
        Me.Panel4.Controls.Add(Me.lblReg4)
        Me.Panel4.Controls.Add(Me.lblReg5)
        Me.Panel4.Controls.Add(Me.lblReg6)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.lblReg8)
        Me.Panel4.Controls.Add(Me.lblReg7)
        Me.Panel4.Location = New System.Drawing.Point(0, 30)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(460, 567)
        Me.Panel4.TabIndex = 3
        '
        'btnReg
        '
        Me.btnReg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReg.FlatAppearance.BorderSize = 0
        Me.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReg.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnReg.Location = New System.Drawing.Point(156, 459)
        Me.btnReg.Margin = New System.Windows.Forms.Padding(0)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(146, 45)
        Me.btnReg.TabIndex = 0
        Me.btnReg.Text = "REGISTER"
        Me.btnReg.UseVisualStyleBackColor = False
        '
        'panelSname
        '
        Me.panelSname.AutoSize = True
        Me.panelSname.BackColor = System.Drawing.Color.Transparent
        Me.panelSname.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelSname.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelSname.ForeColor = System.Drawing.Color.White
        Me.panelSname.Location = New System.Drawing.Point(170, 226)
        Me.panelSname.Margin = New System.Windows.Forms.Padding(0)
        Me.panelSname.Name = "panelSname"
        Me.panelSname.Size = New System.Drawing.Size(70, 16)
        Me.panelSname.TabIndex = 6
        Me.panelSname.Text = "SURNAME"
        Me.panelSname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelFName
        '
        Me.panelFName.AutoSize = True
        Me.panelFName.BackColor = System.Drawing.Color.Transparent
        Me.panelFName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelFName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelFName.ForeColor = System.Drawing.Color.White
        Me.panelFName.Location = New System.Drawing.Point(170, 161)
        Me.panelFName.Margin = New System.Windows.Forms.Padding(0)
        Me.panelFName.Name = "panelFName"
        Me.panelFName.Size = New System.Drawing.Size(88, 16)
        Me.panelFName.TabIndex = 2
        Me.panelFName.Text = "FIRST NAME"
        Me.panelFName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelMName
        '
        Me.panelMName.AutoSize = True
        Me.panelMName.BackColor = System.Drawing.Color.Transparent
        Me.panelMName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelMName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelMName.ForeColor = System.Drawing.Color.White
        Me.panelMName.Location = New System.Drawing.Point(170, 193)
        Me.panelMName.Margin = New System.Windows.Forms.Padding(0)
        Me.panelMName.Name = "panelMName"
        Me.panelMName.Size = New System.Drawing.Size(98, 16)
        Me.panelMName.TabIndex = 4
        Me.panelMName.Text = "MIDDLE NAME"
        Me.panelMName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelEmail
        '
        Me.panelEmail.AutoSize = True
        Me.panelEmail.BackColor = System.Drawing.Color.Transparent
        Me.panelEmail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelEmail.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelEmail.ForeColor = System.Drawing.Color.White
        Me.panelEmail.Location = New System.Drawing.Point(170, 259)
        Me.panelEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.panelEmail.Name = "panelEmail"
        Me.panelEmail.Size = New System.Drawing.Size(47, 16)
        Me.panelEmail.TabIndex = 8
        Me.panelEmail.Text = "EMAIL"
        Me.panelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelPhone
        '
        Me.panelPhone.AutoSize = True
        Me.panelPhone.BackColor = System.Drawing.Color.Transparent
        Me.panelPhone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelPhone.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelPhone.ForeColor = System.Drawing.Color.White
        Me.panelPhone.Location = New System.Drawing.Point(170, 292)
        Me.panelPhone.Margin = New System.Windows.Forms.Padding(0)
        Me.panelPhone.Name = "panelPhone"
        Me.panelPhone.Size = New System.Drawing.Size(51, 16)
        Me.panelPhone.TabIndex = 10
        Me.panelPhone.Text = "PHONE"
        Me.panelPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelRFID
        '
        Me.panelRFID.AutoSize = True
        Me.panelRFID.BackColor = System.Drawing.Color.Transparent
        Me.panelRFID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelRFID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelRFID.ForeColor = System.Drawing.Color.White
        Me.panelRFID.Location = New System.Drawing.Point(170, 327)
        Me.panelRFID.Margin = New System.Windows.Forms.Padding(0)
        Me.panelRFID.Name = "panelRFID"
        Me.panelRFID.Size = New System.Drawing.Size(63, 16)
        Me.panelRFID.TabIndex = 12
        Me.panelRFID.Text = "RFID no."
        Me.panelRFID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelPasswor
        '
        Me.panelPasswor.AutoSize = True
        Me.panelPasswor.BackColor = System.Drawing.Color.Transparent
        Me.panelPasswor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelPasswor.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelPasswor.ForeColor = System.Drawing.Color.White
        Me.panelPasswor.Location = New System.Drawing.Point(170, 396)
        Me.panelPasswor.Margin = New System.Windows.Forms.Padding(0)
        Me.panelPasswor.Name = "panelPasswor"
        Me.panelPasswor.Size = New System.Drawing.Size(82, 16)
        Me.panelPasswor.TabIndex = 16
        Me.panelPasswor.Text = "PASSWORD"
        Me.panelPasswor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelUsernam
        '
        Me.panelUsernam.AutoSize = True
        Me.panelUsernam.BackColor = System.Drawing.Color.Transparent
        Me.panelUsernam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelUsernam.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelUsernam.ForeColor = System.Drawing.Color.White
        Me.panelUsernam.Location = New System.Drawing.Point(170, 362)
        Me.panelUsernam.Margin = New System.Windows.Forms.Padding(0)
        Me.panelUsernam.Name = "panelUsernam"
        Me.panelUsernam.Size = New System.Drawing.Size(78, 16)
        Me.panelUsernam.TabIndex = 14
        Me.panelUsernam.Text = "USERNAME"
        Me.panelUsernam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblReg3
        '
        Me.lblReg3.AutoSize = True
        Me.lblReg3.BackColor = System.Drawing.Color.Transparent
        Me.lblReg3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblReg3.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReg3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblReg3.Location = New System.Drawing.Point(85, 223)
        Me.lblReg3.Margin = New System.Windows.Forms.Padding(0)
        Me.lblReg3.Name = "lblReg3"
        Me.lblReg3.Size = New System.Drawing.Size(77, 20)
        Me.lblReg3.TabIndex = 5
        Me.lblReg3.Text = "SURNAME"
        Me.lblReg3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblReg1
        '
        Me.lblReg1.AutoSize = True
        Me.lblReg1.BackColor = System.Drawing.Color.Transparent
        Me.lblReg1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblReg1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReg1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblReg1.Location = New System.Drawing.Point(69, 159)
        Me.lblReg1.Margin = New System.Windows.Forms.Padding(0)
        Me.lblReg1.Name = "lblReg1"
        Me.lblReg1.Size = New System.Drawing.Size(94, 20)
        Me.lblReg1.TabIndex = 1
        Me.lblReg1.Text = "FIRST NAME"
        Me.lblReg1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblReg2
        '
        Me.lblReg2.AutoSize = True
        Me.lblReg2.BackColor = System.Drawing.Color.Transparent
        Me.lblReg2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblReg2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReg2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblReg2.Location = New System.Drawing.Point(56, 190)
        Me.lblReg2.Margin = New System.Windows.Forms.Padding(0)
        Me.lblReg2.Name = "lblReg2"
        Me.lblReg2.Size = New System.Drawing.Size(108, 20)
        Me.lblReg2.TabIndex = 3
        Me.lblReg2.Text = "MIDDLE NAME"
        Me.lblReg2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblReg4
        '
        Me.lblReg4.AutoSize = True
        Me.lblReg4.BackColor = System.Drawing.Color.Transparent
        Me.lblReg4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblReg4.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReg4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblReg4.Location = New System.Drawing.Point(109, 256)
        Me.lblReg4.Margin = New System.Windows.Forms.Padding(0)
        Me.lblReg4.Name = "lblReg4"
        Me.lblReg4.Size = New System.Drawing.Size(52, 20)
        Me.lblReg4.TabIndex = 7
        Me.lblReg4.Text = "EMAIL"
        Me.lblReg4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblReg5
        '
        Me.lblReg5.AutoSize = True
        Me.lblReg5.BackColor = System.Drawing.Color.Transparent
        Me.lblReg5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblReg5.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReg5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblReg5.Location = New System.Drawing.Point(103, 289)
        Me.lblReg5.Margin = New System.Windows.Forms.Padding(0)
        Me.lblReg5.Name = "lblReg5"
        Me.lblReg5.Size = New System.Drawing.Size(58, 20)
        Me.lblReg5.TabIndex = 9
        Me.lblReg5.Text = "PHONE"
        Me.lblReg5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblReg6
        '
        Me.lblReg6.AutoSize = True
        Me.lblReg6.BackColor = System.Drawing.Color.Transparent
        Me.lblReg6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblReg6.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReg6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblReg6.Location = New System.Drawing.Point(89, 324)
        Me.lblReg6.Margin = New System.Windows.Forms.Padding(0)
        Me.lblReg6.Name = "lblReg6"
        Me.lblReg6.Size = New System.Drawing.Size(73, 20)
        Me.lblReg6.TabIndex = 11
        Me.lblReg6.Text = "RFID NO."
        Me.lblReg6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(0, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(460, 40)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "REGISTRATION SUMMARY"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(0, 94)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(460, 24)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Please check your details below before you proceed."
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblReg8
        '
        Me.lblReg8.AutoSize = True
        Me.lblReg8.BackColor = System.Drawing.Color.Transparent
        Me.lblReg8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblReg8.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReg8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblReg8.Location = New System.Drawing.Point(71, 393)
        Me.lblReg8.Margin = New System.Windows.Forms.Padding(0)
        Me.lblReg8.Name = "lblReg8"
        Me.lblReg8.Size = New System.Drawing.Size(86, 20)
        Me.lblReg8.TabIndex = 15
        Me.lblReg8.Text = "PASSWORD"
        Me.lblReg8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblReg7
        '
        Me.lblReg7.AutoSize = True
        Me.lblReg7.BackColor = System.Drawing.Color.Transparent
        Me.lblReg7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblReg7.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReg7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblReg7.Location = New System.Drawing.Point(77, 358)
        Me.lblReg7.Margin = New System.Windows.Forms.Padding(0)
        Me.lblReg7.Name = "lblReg7"
        Me.lblReg7.Size = New System.Drawing.Size(86, 20)
        Me.lblReg7.TabIndex = 13
        Me.lblReg7.Text = "USERNAME"
        Me.lblReg7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.Controls.Add(Me.btnRegOk)
        Me.Panel5.Controls.Add(Me.lblPendingUserMessage)
        Me.Panel5.Controls.Add(Me.lblDateTime)
        Me.Panel5.Controls.Add(Me.Label21)
        Me.Panel5.Location = New System.Drawing.Point(0, 30)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(460, 567)
        Me.Panel5.TabIndex = 7
        '
        'btnRegOk
        '
        Me.btnRegOk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnRegOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegOk.FlatAppearance.BorderSize = 0
        Me.btnRegOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegOk.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegOk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnRegOk.Location = New System.Drawing.Point(179, 450)
        Me.btnRegOk.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRegOk.Name = "btnRegOk"
        Me.btnRegOk.Size = New System.Drawing.Size(100, 37)
        Me.btnRegOk.TabIndex = 0
        Me.btnRegOk.Text = "Done"
        Me.btnRegOk.UseVisualStyleBackColor = False
        '
        'lblPendingUserMessage
        '
        Me.lblPendingUserMessage.BackColor = System.Drawing.Color.Transparent
        Me.lblPendingUserMessage.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPendingUserMessage.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendingUserMessage.ForeColor = System.Drawing.Color.White
        Me.lblPendingUserMessage.Location = New System.Drawing.Point(37, 184)
        Me.lblPendingUserMessage.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPendingUserMessage.Name = "lblPendingUserMessage"
        Me.lblPendingUserMessage.Size = New System.Drawing.Size(388, 246)
        Me.lblPendingUserMessage.TabIndex = 38
        Me.lblPendingUserMessage.Text = resources.GetString("lblPendingUserMessage.Text")
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.BackColor = System.Drawing.Color.Transparent
        Me.lblDateTime.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDateTime.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.Color.White
        Me.lblDateTime.Location = New System.Drawing.Point(34, 141)
        Me.lblDateTime.Margin = New System.Windows.Forms.Padding(0)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(96, 18)
        Me.lblDateTime.TabIndex = 30
        Me.lblDateTime.Text = "Date and Time"
        Me.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(32, 39)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(383, 43)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Registration Notice"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rmsRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(460, 677)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.panelBottom)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
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
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents labelFormTitle As Label
    Private WithEvents btnMinimize As Button
    Private WithEvents panelTop As Panel
    Private WithEvents picboxLogo As PictureBox
    Private WithEvents btnClose As Button
    Private WithEvents panelBottom As Panel
    Private WithEvents label1 As Label
    Private WithEvents labelLogin As Label
    Public WithEvents lblRegFName As Label
    Public WithEvents regRFID As TextBox
    Private WithEvents labelTitle As Label
    Private WithEvents labelTitle2 As Label
    Public WithEvents lblRegMName As Label
    Public WithEvents lblRegPhone As Label
    Public WithEvents lblRegRFID As Label
    Public WithEvents lblRegUsername As Label
    Public WithEvents lblRegPassw As Label
    Public WithEvents lblRegEmail As Label
    Public WithEvents regFName As TextBox
    Public WithEvents regMName As TextBox
    Public WithEvents regPhone As TextBox
    Public WithEvents regUsername As TextBox
    Public WithEvents regPassw As TextBox
    Public WithEvents regEmail As TextBox
    Public WithEvents regSname As TextBox
    Public WithEvents lblRegSname As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Private WithEvents lblHello As Label
    Private WithEvents Label10 As Label
    Private WithEvents btnNext2 As Button
    Friend WithEvents Panel3 As Panel
    Private WithEvents Label11 As Label
    Private WithEvents Label12 As Label
    Private WithEvents btnNext3 As Button
    Public WithEvents regPassw2 As TextBox
    Public WithEvents lblRegPassw2 As Label
    Friend WithEvents Panel4 As Panel
    Public WithEvents lblReg4 As Label
    Public WithEvents lblReg5 As Label
    Public WithEvents lblReg6 As Label
    Private WithEvents Label15 As Label
    Private WithEvents Label16 As Label
    Public WithEvents lblReg8 As Label
    Public WithEvents lblReg7 As Label
    Public WithEvents panelSname As Label
    Public WithEvents panelFName As Label
    Public WithEvents panelMName As Label
    Public WithEvents panelEmail As Label
    Public WithEvents panelPhone As Label
    Public WithEvents panelRFID As Label
    Public WithEvents panelPasswor As Label
    Public WithEvents panelUsernam As Label
    Public WithEvents lblReg3 As Label
    Public WithEvents lblReg1 As Label
    Public WithEvents lblReg2 As Label
    Private WithEvents btnNext1 As Button
    Friend WithEvents btnRet1 As Button
    Friend WithEvents btnRet2 As Button
    Private WithEvents btnReg As Button
    Public WithEvents lblPanel1Note As Label
    Private WithEvents lblEmailUsed As Label
    Private WithEvents lblRFIDUsed As Label
    Public WithEvents lblPanel2Note As Label
    Public WithEvents lblPanel3Note As Label
    Private WithEvents lblPassError As Label
    Friend WithEvents Panel5 As Panel
    Private WithEvents btnRegOk As Button
    Public WithEvents lblPendingUserMessage As Label
    Public WithEvents lblDateTime As Label
    Private WithEvents Label21 As Label
    Private WithEvents lblPassShort As Label
    Private WithEvents lblPhoneInvalid As Label
    Private WithEvents lblUsernameShort As Label
    Private WithEvents lblUsernameUsed As Label
End Class
