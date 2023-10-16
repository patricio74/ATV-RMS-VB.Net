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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.combGender = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbxEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbxContNum = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbxEmpNo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbxSurname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbxMidname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxFrstname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDelEmp = New System.Windows.Forms.Button()
        Me.btnUpdEmp = New System.Windows.Forms.Button()
        Me.btnAddEmp = New System.Windows.Forms.Button()
        Me.tbxSearch = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblClearAdd = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'combGender
        '
        Me.combGender.BackColor = System.Drawing.Color.White
        Me.combGender.Cursor = System.Windows.Forms.Cursors.Hand
        Me.combGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combGender.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.combGender.FormattingEnabled = True
        Me.combGender.ItemHeight = 22
        Me.combGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.combGender.Location = New System.Drawing.Point(723, 507)
        Me.combGender.Name = "combGender"
        Me.combGender.Size = New System.Drawing.Size(83, 30)
        Me.combGender.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(720, 489)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 18)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "GENDER:"
        '
        'tbxEmail
        '
        Me.tbxEmail.BackColor = System.Drawing.Color.White
        Me.tbxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tbxEmail.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxEmail.Location = New System.Drawing.Point(515, 640)
        Me.tbxEmail.Name = "tbxEmail"
        Me.tbxEmail.Size = New System.Drawing.Size(291, 30)
        Me.tbxEmail.TabIndex = 42
        Me.tbxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(512, 621)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 18)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "EMAIL:"
        '
        'tbxContNum
        '
        Me.tbxContNum.BackColor = System.Drawing.Color.White
        Me.tbxContNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxContNum.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxContNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxContNum.Location = New System.Drawing.Point(515, 574)
        Me.tbxContNum.MaxLength = 11
        Me.tbxContNum.Name = "tbxContNum"
        Me.tbxContNum.Size = New System.Drawing.Size(291, 30)
        Me.tbxContNum.TabIndex = 40
        Me.tbxContNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(512, 555)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 18)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "PHONE NUMBER:"
        '
        'tbxEmpNo
        '
        Me.tbxEmpNo.BackColor = System.Drawing.Color.White
        Me.tbxEmpNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxEmpNo.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxEmpNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxEmpNo.Location = New System.Drawing.Point(515, 508)
        Me.tbxEmpNo.Name = "tbxEmpNo"
        Me.tbxEmpNo.Size = New System.Drawing.Size(202, 30)
        Me.tbxEmpNo.TabIndex = 38
        Me.tbxEmpNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(512, 489)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 18)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "RFID NO."
        '
        'tbxSurname
        '
        Me.tbxSurname.BackColor = System.Drawing.Color.White
        Me.tbxSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxSurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxSurname.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxSurname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxSurname.Location = New System.Drawing.Point(116, 640)
        Me.tbxSurname.Name = "tbxSurname"
        Me.tbxSurname.Size = New System.Drawing.Size(311, 30)
        Me.tbxSurname.TabIndex = 36
        Me.tbxSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(113, 621)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 18)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "SURNAME:"
        '
        'tbxMidname
        '
        Me.tbxMidname.BackColor = System.Drawing.Color.White
        Me.tbxMidname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxMidname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxMidname.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxMidname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxMidname.Location = New System.Drawing.Point(116, 574)
        Me.tbxMidname.Name = "tbxMidname"
        Me.tbxMidname.Size = New System.Drawing.Size(311, 30)
        Me.tbxMidname.TabIndex = 34
        Me.tbxMidname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(113, 555)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 18)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "MIDDLE NAME:"
        '
        'tbxFrstname
        '
        Me.tbxFrstname.BackColor = System.Drawing.Color.White
        Me.tbxFrstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxFrstname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxFrstname.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxFrstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxFrstname.Location = New System.Drawing.Point(116, 508)
        Me.tbxFrstname.Name = "tbxFrstname"
        Me.tbxFrstname.Size = New System.Drawing.Size(311, 30)
        Me.tbxFrstname.TabIndex = 32
        Me.tbxFrstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(113, 489)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 18)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "FIRST NAME:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.DarkGray
        Me.DataGridView1.Location = New System.Drawing.Point(35, 70)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(1092, 385)
        Me.DataGridView1.TabIndex = 47
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "RFID NO."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "FIRST NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "MIDDLE NAME"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "SURNAME"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "GENDER"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 80
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "PHONE NUMBER"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.HeaderText = "EMAIL ADDRESS"
        Me.Column7.Name = "Column7"
        '
        'btnDelEmp
        '
        Me.btnDelEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnDelEmp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelEmp.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnDelEmp.FlatAppearance.BorderSize = 0
        Me.btnDelEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelEmp.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelEmp.ForeColor = System.Drawing.Color.Red
        Me.btnDelEmp.Location = New System.Drawing.Point(895, 609)
        Me.btnDelEmp.Name = "btnDelEmp"
        Me.btnDelEmp.Size = New System.Drawing.Size(121, 44)
        Me.btnDelEmp.TabIndex = 50
        Me.btnDelEmp.Text = "Delete"
        Me.btnDelEmp.UseVisualStyleBackColor = False
        '
        'btnUpdEmp
        '
        Me.btnUpdEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnUpdEmp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdEmp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnUpdEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdEmp.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdEmp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnUpdEmp.Location = New System.Drawing.Point(895, 554)
        Me.btnUpdEmp.Name = "btnUpdEmp"
        Me.btnUpdEmp.Size = New System.Drawing.Size(121, 44)
        Me.btnUpdEmp.TabIndex = 49
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
        Me.btnAddEmp.Location = New System.Drawing.Point(895, 498)
        Me.btnAddEmp.Name = "btnAddEmp"
        Me.btnAddEmp.Size = New System.Drawing.Size(121, 44)
        Me.btnAddEmp.TabIndex = 48
        Me.btnAddEmp.Text = "Add"
        Me.btnAddEmp.UseVisualStyleBackColor = False
        '
        'tbxSearch
        '
        Me.tbxSearch.BackColor = System.Drawing.Color.White
        Me.tbxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxSearch.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxSearch.Location = New System.Drawing.Point(814, 35)
        Me.tbxSearch.Name = "tbxSearch"
        Me.tbxSearch.Size = New System.Drawing.Size(202, 26)
        Me.tbxSearch.TabIndex = 87
        Me.tbxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(1022, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 27)
        Me.Button1.TabIndex = 97
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblClearAdd
        '
        Me.lblClearAdd.AutoSize = True
        Me.lblClearAdd.BackColor = System.Drawing.Color.Transparent
        Me.lblClearAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClearAdd.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearAdd.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblClearAdd.Location = New System.Drawing.Point(919, 666)
        Me.lblClearAdd.Name = "lblClearAdd"
        Me.lblClearAdd.Size = New System.Drawing.Size(75, 18)
        Me.lblClearAdd.TabIndex = 126
        Me.lblClearAdd.Text = "Clear Form"
        '
        'ctrlTourGuides
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.lblClearAdd)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbxSearch)
        Me.Controls.Add(Me.btnDelEmp)
        Me.Controls.Add(Me.btnUpdEmp)
        Me.Controls.Add(Me.btnAddEmp)
        Me.Controls.Add(Me.combGender)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbxEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbxContNum)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbxEmpNo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbxSurname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbxMidname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbxFrstname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ctrlTourGuides"
        Me.Size = New System.Drawing.Size(1161, 738)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents combGender As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbxEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbxContNum As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbxEmpNo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbxSurname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbxMidname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxFrstname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents btnDelEmp As Button
    Friend WithEvents btnUpdEmp As Button
    Friend WithEvents btnAddEmp As Button
    Friend WithEvents tbxSearch As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblClearAdd As Label
End Class
