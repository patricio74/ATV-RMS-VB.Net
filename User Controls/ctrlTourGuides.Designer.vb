<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrlTourGuides
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnDelEmp = New System.Windows.Forms.Button()
        Me.btnUpdEmp = New System.Windows.Forms.Button()
        Me.btnAddEmp = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
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
        Me.combGender.Location = New System.Drawing.Point(941, 447)
        Me.combGender.Name = "combGender"
        Me.combGender.Size = New System.Drawing.Size(102, 32)
        Me.combGender.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(924, 422)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 22)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Gender:"
        '
        'txtbxEmail
        '
        Me.txtbxEmail.BackColor = System.Drawing.Color.White
        Me.txtbxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbxEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtbxEmail.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtbxEmail.Location = New System.Drawing.Point(754, 597)
        Me.txtbxEmail.Name = "txtbxEmail"
        Me.txtbxEmail.Size = New System.Drawing.Size(289, 35)
        Me.txtbxEmail.TabIndex = 42
        Me.txtbxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(755, 572)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 22)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Email:"
        '
        'txtbxContNum
        '
        Me.txtbxContNum.BackColor = System.Drawing.Color.White
        Me.txtbxContNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbxContNum.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxContNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtbxContNum.Location = New System.Drawing.Point(754, 520)
        Me.txtbxContNum.MaxLength = 11
        Me.txtbxContNum.Name = "txtbxContNum"
        Me.txtbxContNum.Size = New System.Drawing.Size(289, 35)
        Me.txtbxContNum.TabIndex = 40
        Me.txtbxContNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(755, 495)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 22)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Contact number:"
        '
        'txtbxEmpNo
        '
        Me.txtbxEmpNo.BackColor = System.Drawing.Color.White
        Me.txtbxEmpNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbxEmpNo.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEmpNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtbxEmpNo.Location = New System.Drawing.Point(754, 444)
        Me.txtbxEmpNo.Name = "txtbxEmpNo"
        Me.txtbxEmpNo.Size = New System.Drawing.Size(181, 35)
        Me.txtbxEmpNo.TabIndex = 38
        Me.txtbxEmpNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(755, 419)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 22)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "RFID no."
        '
        'txtbxSurname
        '
        Me.txtbxSurname.BackColor = System.Drawing.Color.White
        Me.txtbxSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbxSurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbxSurname.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxSurname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtbxSurname.Location = New System.Drawing.Point(104, 597)
        Me.txtbxSurname.Name = "txtbxSurname"
        Me.txtbxSurname.Size = New System.Drawing.Size(336, 35)
        Me.txtbxSurname.TabIndex = 36
        Me.txtbxSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(100, 572)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 22)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Surname:"
        '
        'txtbxMidname
        '
        Me.txtbxMidname.BackColor = System.Drawing.Color.White
        Me.txtbxMidname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbxMidname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbxMidname.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxMidname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtbxMidname.Location = New System.Drawing.Point(104, 520)
        Me.txtbxMidname.Name = "txtbxMidname"
        Me.txtbxMidname.Size = New System.Drawing.Size(336, 35)
        Me.txtbxMidname.TabIndex = 34
        Me.txtbxMidname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(100, 495)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 22)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Middle name:"
        '
        'txtbxFrstname
        '
        Me.txtbxFrstname.BackColor = System.Drawing.Color.White
        Me.txtbxFrstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbxFrstname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbxFrstname.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxFrstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtbxFrstname.Location = New System.Drawing.Point(104, 444)
        Me.txtbxFrstname.Name = "txtbxFrstname"
        Me.txtbxFrstname.Size = New System.Drawing.Size(336, 35)
        Me.txtbxFrstname.TabIndex = 32
        Me.txtbxFrstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(100, 425)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 22)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "First name:"
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
        Me.ListView1.Location = New System.Drawing.Point(35, 38)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1092, 360)
        Me.ListView1.TabIndex = 29
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
        'btnDelEmp
        '
        Me.btnDelEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnDelEmp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelEmp.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnDelEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelEmp.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelEmp.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDelEmp.Location = New System.Drawing.Point(812, 657)
        Me.btnDelEmp.Name = "btnDelEmp"
        Me.btnDelEmp.Size = New System.Drawing.Size(121, 44)
        Me.btnDelEmp.TabIndex = 28
        Me.btnDelEmp.Text = "Delete"
        Me.btnDelEmp.UseVisualStyleBackColor = False
        '
        'btnUpdEmp
        '
        Me.btnUpdEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnUpdEmp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdEmp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnUpdEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdEmp.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdEmp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnUpdEmp.Location = New System.Drawing.Point(674, 657)
        Me.btnUpdEmp.Name = "btnUpdEmp"
        Me.btnUpdEmp.Size = New System.Drawing.Size(121, 44)
        Me.btnUpdEmp.TabIndex = 27
        Me.btnUpdEmp.Text = "Update"
        Me.btnUpdEmp.UseVisualStyleBackColor = False
        '
        'btnAddEmp
        '
        Me.btnAddEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnAddEmp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddEmp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddEmp.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEmp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnAddEmp.Location = New System.Drawing.Point(539, 657)
        Me.btnAddEmp.Name = "btnAddEmp"
        Me.btnAddEmp.Size = New System.Drawing.Size(121, 44)
        Me.btnAddEmp.TabIndex = 26
        Me.btnAddEmp.Text = "Add"
        Me.btnAddEmp.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(950, 657)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(121, 44)
        Me.btnClear.TabIndex = 46
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'ctrlTourGuides
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.btnClear)
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
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnDelEmp)
        Me.Controls.Add(Me.btnUpdEmp)
        Me.Controls.Add(Me.btnAddEmp)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ctrlTourGuides"
        Me.Size = New System.Drawing.Size(1161, 738)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents Label2 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents btnDelEmp As Button
    Friend WithEvents btnUpdEmp As Button
    Friend WithEvents btnAddEmp As Button
    Friend WithEvents btnClear As Button
End Class
