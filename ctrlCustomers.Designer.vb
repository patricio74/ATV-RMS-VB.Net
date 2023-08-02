<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlCustomers
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.combGender = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtbxEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbxContNum = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbxEmpNo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtbxSurname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbxMidname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbxFrstname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnDelCust = New System.Windows.Forms.Button()
        Me.btnUpdCust = New System.Windows.Forms.Button()
        Me.btnAddCust = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1089, 35)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "C  U  S  T  O  M  E  R    I  N  F  O"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'combGender
        '
        Me.combGender.BackColor = System.Drawing.Color.White
        Me.combGender.Cursor = System.Windows.Forms.Cursors.Hand
        Me.combGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combGender.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.combGender.FormattingEnabled = True
        Me.combGender.ItemHeight = 24
        Me.combGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.combGender.Location = New System.Drawing.Point(906, 423)
        Me.combGender.Name = "combGender"
        Me.combGender.Size = New System.Drawing.Size(99, 32)
        Me.combGender.TabIndex = 84
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(902, 398)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 22)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "Gender:"
        '
        'txtbxEmail
        '
        Me.txtbxEmail.BackColor = System.Drawing.Color.White
        Me.txtbxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbxEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtbxEmail.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtbxEmail.Location = New System.Drawing.Point(716, 576)
        Me.txtbxEmail.Name = "txtbxEmail"
        Me.txtbxEmail.Size = New System.Drawing.Size(289, 35)
        Me.txtbxEmail.TabIndex = 82
        Me.txtbxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(717, 551)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 22)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Email:"
        '
        'txtbxContNum
        '
        Me.txtbxContNum.BackColor = System.Drawing.Color.White
        Me.txtbxContNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbxContNum.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxContNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtbxContNum.Location = New System.Drawing.Point(716, 499)
        Me.txtbxContNum.MaxLength = 11
        Me.txtbxContNum.Name = "txtbxContNum"
        Me.txtbxContNum.Size = New System.Drawing.Size(289, 35)
        Me.txtbxContNum.TabIndex = 80
        Me.txtbxContNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(717, 474)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 22)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Contact number:"
        '
        'txtbxEmpNo
        '
        Me.txtbxEmpNo.BackColor = System.Drawing.Color.White
        Me.txtbxEmpNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbxEmpNo.Enabled = False
        Me.txtbxEmpNo.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEmpNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtbxEmpNo.Location = New System.Drawing.Point(716, 423)
        Me.txtbxEmpNo.Name = "txtbxEmpNo"
        Me.txtbxEmpNo.ReadOnly = True
        Me.txtbxEmpNo.Size = New System.Drawing.Size(184, 35)
        Me.txtbxEmpNo.TabIndex = 78
        Me.txtbxEmpNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(717, 398)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 22)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "RFID no."
        '
        'txtbxSurname
        '
        Me.txtbxSurname.BackColor = System.Drawing.Color.White
        Me.txtbxSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbxSurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbxSurname.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxSurname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtbxSurname.Location = New System.Drawing.Point(89, 576)
        Me.txtbxSurname.Name = "txtbxSurname"
        Me.txtbxSurname.Size = New System.Drawing.Size(336, 35)
        Me.txtbxSurname.TabIndex = 76
        Me.txtbxSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(85, 551)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 22)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Surname:"
        '
        'txtbxMidname
        '
        Me.txtbxMidname.BackColor = System.Drawing.Color.White
        Me.txtbxMidname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbxMidname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbxMidname.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxMidname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtbxMidname.Location = New System.Drawing.Point(89, 499)
        Me.txtbxMidname.Name = "txtbxMidname"
        Me.txtbxMidname.Size = New System.Drawing.Size(336, 35)
        Me.txtbxMidname.TabIndex = 74
        Me.txtbxMidname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(85, 474)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 22)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Middle name:"
        '
        'txtbxFrstname
        '
        Me.txtbxFrstname.BackColor = System.Drawing.Color.White
        Me.txtbxFrstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbxFrstname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbxFrstname.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxFrstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtbxFrstname.Location = New System.Drawing.Point(89, 423)
        Me.txtbxFrstname.Name = "txtbxFrstname"
        Me.txtbxFrstname.Size = New System.Drawing.Size(336, 35)
        Me.txtbxFrstname.TabIndex = 72
        Me.txtbxFrstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(85, 404)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 22)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "First name:"
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListView1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(56, 38)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(998, 342)
        Me.ListView1.TabIndex = 70
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "RFID no."
        Me.ColumnHeader1.Width = 66
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Firstname"
        Me.ColumnHeader2.Width = 167
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Middlename"
        Me.ColumnHeader3.Width = 154
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Surname"
        Me.ColumnHeader4.Width = 158
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Gender"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Contact number"
        Me.ColumnHeader6.Width = 139
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Email"
        Me.ColumnHeader7.Width = 193
        '
        'btnDelCust
        '
        Me.btnDelCust.BackColor = System.Drawing.Color.DarkGray
        Me.btnDelCust.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelCust.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnDelCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelCust.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelCust.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnDelCust.Location = New System.Drawing.Point(696, 644)
        Me.btnDelCust.Name = "btnDelCust"
        Me.btnDelCust.Size = New System.Drawing.Size(134, 50)
        Me.btnDelCust.TabIndex = 69
        Me.btnDelCust.Text = "Delete"
        Me.btnDelCust.UseVisualStyleBackColor = False
        '
        'btnUpdCust
        '
        Me.btnUpdCust.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnUpdCust.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdCust.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnUpdCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdCust.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdCust.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnUpdCust.Location = New System.Drawing.Point(556, 644)
        Me.btnUpdCust.Name = "btnUpdCust"
        Me.btnUpdCust.Size = New System.Drawing.Size(134, 50)
        Me.btnUpdCust.TabIndex = 68
        Me.btnUpdCust.Text = "Update"
        Me.btnUpdCust.UseVisualStyleBackColor = False
        '
        'btnAddCust
        '
        Me.btnAddCust.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnAddCust.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddCust.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnAddCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCust.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCust.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnAddCust.Location = New System.Drawing.Point(416, 644)
        Me.btnAddCust.Name = "btnAddCust"
        Me.btnAddCust.Size = New System.Drawing.Size(134, 50)
        Me.btnAddCust.TabIndex = 67
        Me.btnAddCust.Text = "Add"
        Me.btnAddCust.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(451, 423)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(240, 188)
        Me.PictureBox1.TabIndex = 85
        Me.PictureBox1.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(836, 644)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(134, 50)
        Me.btnCancel.TabIndex = 86
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'ctrlCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.combGender)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtbxEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtbxContNum)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtbxEmpNo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtbxSurname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtbxMidname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbxFrstname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnDelCust)
        Me.Controls.Add(Me.btnUpdCust)
        Me.Controls.Add(Me.btnAddCust)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ctrlCustomers"
        Me.Size = New System.Drawing.Size(1095, 730)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents combGender As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtbxEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbxContNum As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbxEmpNo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtbxSurname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbxMidname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbxFrstname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents btnDelCust As Button
    Friend WithEvents btnUpdCust As Button
    Friend WithEvents btnAddCust As Button
    Friend WithEvents btnCancel As Button
End Class
