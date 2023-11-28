<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlAdminSettings
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.usrPword = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.usrRFID = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.usrEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.usrPhone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.usrPword2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblCreationDate = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.usrOldPword = New System.Windows.Forms.TextBox()
        Me.btnDeleteAcc = New System.Windows.Forms.Button()
        Me.admnTab = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.usrFName = New System.Windows.Forms.TextBox()
        Me.usrUsername = New System.Windows.Forms.TextBox()
        Me.usrSName = New System.Windows.Forms.TextBox()
        Me.usrMName = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.admnTab.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUpdate.Location = New System.Drawing.Point(659, 579)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(168, 48)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Update Info"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(87, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FIRST NAME:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(87, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "SURNAME:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(87, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "MIDDLE NAME:"
        '
        'btnUndo
        '
        Me.btnUndo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnUndo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnUndo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUndo.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUndo.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUndo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnUndo.Location = New System.Drawing.Point(467, 579)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(172, 48)
        Me.btnUndo.TabIndex = 0
        Me.btnUndo.Text = "Undo Changes"
        Me.btnUndo.UseVisualStyleBackColor = False
        '
        'usrPword
        '
        Me.usrPword.BackColor = System.Drawing.Color.White
        Me.usrPword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usrPword.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrPword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.usrPword.Location = New System.Drawing.Point(90, 161)
        Me.usrPword.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.usrPword.Name = "usrPword"
        Me.usrPword.Size = New System.Drawing.Size(331, 32)
        Me.usrPword.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(87, 143)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 18)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "NEW PASSWORD:"
        '
        'usrRFID
        '
        Me.usrRFID.BackColor = System.Drawing.Color.White
        Me.usrRFID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usrRFID.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrRFID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.usrRFID.Location = New System.Drawing.Point(90, 74)
        Me.usrRFID.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.usrRFID.MaxLength = 11
        Me.usrRFID.Name = "usrRFID"
        Me.usrRFID.Size = New System.Drawing.Size(331, 32)
        Me.usrRFID.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(87, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 18)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "RFID No.:"
        '
        'usrEmail
        '
        Me.usrEmail.BackColor = System.Drawing.Color.White
        Me.usrEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usrEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.usrEmail.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.usrEmail.Location = New System.Drawing.Point(90, 161)
        Me.usrEmail.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.usrEmail.Name = "usrEmail"
        Me.usrEmail.Size = New System.Drawing.Size(331, 32)
        Me.usrEmail.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(87, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 18)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "EMAIL ADDRESS:"
        '
        'usrPhone
        '
        Me.usrPhone.BackColor = System.Drawing.Color.White
        Me.usrPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usrPhone.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.usrPhone.Location = New System.Drawing.Point(90, 247)
        Me.usrPhone.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.usrPhone.MaxLength = 11
        Me.usrPhone.Name = "usrPhone"
        Me.usrPhone.Size = New System.Drawing.Size(331, 32)
        Me.usrPhone.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(87, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 18)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "PHONE NUMBER:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(87, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "USERNAME:"
        '
        'usrPword2
        '
        Me.usrPword2.BackColor = System.Drawing.Color.White
        Me.usrPword2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usrPword2.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrPword2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.usrPword2.Location = New System.Drawing.Point(90, 247)
        Me.usrPword2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.usrPword2.Name = "usrPword2"
        Me.usrPword2.Size = New System.Drawing.Size(331, 32)
        Me.usrPword2.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(87, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 18)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "RE-ENTER NEW PASSWORD:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(87, 333)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 18)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Account creation date:"
        '
        'lblCreationDate
        '
        Me.lblCreationDate.BackColor = System.Drawing.Color.Transparent
        Me.lblCreationDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreationDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.lblCreationDate.Location = New System.Drawing.Point(242, 333)
        Me.lblCreationDate.Name = "lblCreationDate"
        Me.lblCreationDate.Size = New System.Drawing.Size(204, 18)
        Me.lblCreationDate.TabIndex = 7
        Me.lblCreationDate.Text = "----------"
        Me.lblCreationDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(87, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "CURRENT PASSWORD:"
        '
        'usrOldPword
        '
        Me.usrOldPword.BackColor = System.Drawing.Color.White
        Me.usrOldPword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usrOldPword.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrOldPword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.usrOldPword.Location = New System.Drawing.Point(90, 74)
        Me.usrOldPword.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.usrOldPword.Name = "usrOldPword"
        Me.usrOldPword.Size = New System.Drawing.Size(331, 32)
        Me.usrOldPword.TabIndex = 1
        '
        'btnDeleteAcc
        '
        Me.btnDeleteAcc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteAcc.BackColor = System.Drawing.Color.Firebrick
        Me.btnDeleteAcc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteAcc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnDeleteAcc.FlatAppearance.BorderSize = 0
        Me.btnDeleteAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteAcc.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAcc.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDeleteAcc.Location = New System.Drawing.Point(90, 326)
        Me.btnDeleteAcc.Name = "btnDeleteAcc"
        Me.btnDeleteAcc.Size = New System.Drawing.Size(139, 30)
        Me.btnDeleteAcc.TabIndex = 6
        Me.btnDeleteAcc.Text = "Delete account"
        Me.btnDeleteAcc.UseVisualStyleBackColor = False
        '
        'admnTab
        '
        Me.admnTab.Controls.Add(Me.TabPage1)
        Me.admnTab.Controls.Add(Me.TabPage2)
        Me.admnTab.Controls.Add(Me.TabPage3)
        Me.admnTab.Location = New System.Drawing.Point(309, 76)
        Me.admnTab.Name = "admnTab"
        Me.admnTab.SelectedIndex = 0
        Me.admnTab.Size = New System.Drawing.Size(547, 482)
        Me.admnTab.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.usrFName)
        Me.TabPage1.Controls.Add(Me.usrUsername)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.usrSName)
        Me.TabPage1.Controls.Add(Me.usrMName)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(539, 449)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "   User Information   "
        '
        'usrFName
        '
        Me.usrFName.BackColor = System.Drawing.Color.White
        Me.usrFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usrFName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.usrFName.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrFName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.usrFName.Location = New System.Drawing.Point(90, 74)
        Me.usrFName.MaxLength = 11
        Me.usrFName.Name = "usrFName"
        Me.usrFName.Size = New System.Drawing.Size(331, 32)
        Me.usrFName.TabIndex = 1
        '
        'usrUsername
        '
        Me.usrUsername.BackColor = System.Drawing.Color.White
        Me.usrUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usrUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.usrUsername.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.usrUsername.Location = New System.Drawing.Point(90, 326)
        Me.usrUsername.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.usrUsername.MaxLength = 25
        Me.usrUsername.Name = "usrUsername"
        Me.usrUsername.Size = New System.Drawing.Size(331, 32)
        Me.usrUsername.TabIndex = 7
        '
        'usrSName
        '
        Me.usrSName.BackColor = System.Drawing.Color.White
        Me.usrSName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usrSName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.usrSName.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrSName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.usrSName.Location = New System.Drawing.Point(90, 247)
        Me.usrSName.MaxLength = 11
        Me.usrSName.Name = "usrSName"
        Me.usrSName.Size = New System.Drawing.Size(331, 32)
        Me.usrSName.TabIndex = 5
        '
        'usrMName
        '
        Me.usrMName.BackColor = System.Drawing.Color.White
        Me.usrMName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usrMName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.usrMName.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrMName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.usrMName.Location = New System.Drawing.Point(90, 161)
        Me.usrMName.MaxLength = 11
        Me.usrMName.Name = "usrMName"
        Me.usrMName.Size = New System.Drawing.Size(331, 32)
        Me.usrMName.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.lblCreationDate)
        Me.TabPage2.Controls.Add(Me.usrRFID)
        Me.TabPage2.Controls.Add(Me.usrPhone)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.usrEmail)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(539, 449)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "   Contact Details   "
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.usrOldPword)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.btnDeleteAcc)
        Me.TabPage3.Controls.Add(Me.usrPword)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.usrPword2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(539, 449)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "   Account Security   "
        '
        'ctrlAdminSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.admnTab)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.btnUpdate)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ctrlAdminSettings"
        Me.Size = New System.Drawing.Size(1161, 738)
        Me.admnTab.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnUndo As Button
    Friend WithEvents usrPword As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents usrRFID As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents usrEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents usrPhone As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents usrPword2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCreationDate As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnDeleteAcc As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents usrOldPword As TextBox
    Friend WithEvents admnTab As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents usrFName As TextBox
    Friend WithEvents usrUsername As TextBox
    Friend WithEvents usrSName As TextBox
    Friend WithEvents usrMName As TextBox
End Class
