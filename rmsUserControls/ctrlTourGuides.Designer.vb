﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.cbxUpdEmpGender = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbxUpdEmpEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbxUpdEmpPhone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbxUpdEmpRFID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbxUpdEmpSname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbxUpdEmpMname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxUpdEmpFname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvTourGuide = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbxSearch = New System.Windows.Forms.TextBox()
        Me.btnSearchEmp = New System.Windows.Forms.Button()
        Me.tabTourGuide = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblUpdEmpID = New System.Windows.Forms.Label()
        Me.btnDelEmp = New System.Windows.Forms.Button()
        Me.btnUpdEmp = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.tbxAddEmpFname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbxAddEmpGender = New System.Windows.Forms.ComboBox()
        Me.tbxAddEmpMname = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbxAddEmpEmail = New System.Windows.Forms.TextBox()
        Me.tbxAddEmpSname = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbxAddEmpPhone = New System.Windows.Forms.TextBox()
        Me.tbxAddEmpRFID = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnAddEmp = New System.Windows.Forms.Button()
        Me.btnRemoveFilter = New System.Windows.Forms.Button()
        CType(Me.dgvTourGuide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTourGuide.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxUpdEmpGender
        '
        Me.cbxUpdEmpGender.BackColor = System.Drawing.Color.White
        Me.cbxUpdEmpGender.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxUpdEmpGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxUpdEmpGender.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxUpdEmpGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.cbxUpdEmpGender.FormattingEnabled = True
        Me.cbxUpdEmpGender.ItemHeight = 22
        Me.cbxUpdEmpGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.cbxUpdEmpGender.Location = New System.Drawing.Point(727, 53)
        Me.cbxUpdEmpGender.Name = "cbxUpdEmpGender"
        Me.cbxUpdEmpGender.Size = New System.Drawing.Size(83, 30)
        Me.cbxUpdEmpGender.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(724, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 18)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "GENDER:"
        '
        'tbxUpdEmpEmail
        '
        Me.tbxUpdEmpEmail.BackColor = System.Drawing.Color.White
        Me.tbxUpdEmpEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxUpdEmpEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tbxUpdEmpEmail.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUpdEmpEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxUpdEmpEmail.Location = New System.Drawing.Point(499, 185)
        Me.tbxUpdEmpEmail.Name = "tbxUpdEmpEmail"
        Me.tbxUpdEmpEmail.Size = New System.Drawing.Size(311, 30)
        Me.tbxUpdEmpEmail.TabIndex = 6
        Me.tbxUpdEmpEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(496, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 18)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "EMAIL:"
        '
        'tbxUpdEmpPhone
        '
        Me.tbxUpdEmpPhone.BackColor = System.Drawing.Color.White
        Me.tbxUpdEmpPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxUpdEmpPhone.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUpdEmpPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxUpdEmpPhone.Location = New System.Drawing.Point(499, 119)
        Me.tbxUpdEmpPhone.MaxLength = 11
        Me.tbxUpdEmpPhone.Name = "tbxUpdEmpPhone"
        Me.tbxUpdEmpPhone.Size = New System.Drawing.Size(311, 30)
        Me.tbxUpdEmpPhone.TabIndex = 5
        Me.tbxUpdEmpPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(496, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 18)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "PHONE NUMBER:"
        '
        'tbxUpdEmpRFID
        '
        Me.tbxUpdEmpRFID.BackColor = System.Drawing.Color.White
        Me.tbxUpdEmpRFID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxUpdEmpRFID.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUpdEmpRFID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxUpdEmpRFID.Location = New System.Drawing.Point(499, 53)
        Me.tbxUpdEmpRFID.Name = "tbxUpdEmpRFID"
        Me.tbxUpdEmpRFID.Size = New System.Drawing.Size(222, 30)
        Me.tbxUpdEmpRFID.TabIndex = 3
        Me.tbxUpdEmpRFID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(496, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 18)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "RFID NO."
        '
        'tbxUpdEmpSname
        '
        Me.tbxUpdEmpSname.BackColor = System.Drawing.Color.White
        Me.tbxUpdEmpSname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxUpdEmpSname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxUpdEmpSname.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUpdEmpSname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxUpdEmpSname.Location = New System.Drawing.Point(100, 185)
        Me.tbxUpdEmpSname.Name = "tbxUpdEmpSname"
        Me.tbxUpdEmpSname.Size = New System.Drawing.Size(311, 30)
        Me.tbxUpdEmpSname.TabIndex = 2
        Me.tbxUpdEmpSname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(97, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 18)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "SURNAME:"
        '
        'tbxUpdEmpMname
        '
        Me.tbxUpdEmpMname.BackColor = System.Drawing.Color.White
        Me.tbxUpdEmpMname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxUpdEmpMname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxUpdEmpMname.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUpdEmpMname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxUpdEmpMname.Location = New System.Drawing.Point(100, 119)
        Me.tbxUpdEmpMname.Name = "tbxUpdEmpMname"
        Me.tbxUpdEmpMname.Size = New System.Drawing.Size(311, 30)
        Me.tbxUpdEmpMname.TabIndex = 1
        Me.tbxUpdEmpMname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(97, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 18)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "MIDDLE NAME:"
        '
        'tbxUpdEmpFname
        '
        Me.tbxUpdEmpFname.BackColor = System.Drawing.Color.White
        Me.tbxUpdEmpFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxUpdEmpFname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxUpdEmpFname.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUpdEmpFname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxUpdEmpFname.Location = New System.Drawing.Point(100, 53)
        Me.tbxUpdEmpFname.Name = "tbxUpdEmpFname"
        Me.tbxUpdEmpFname.Size = New System.Drawing.Size(311, 30)
        Me.tbxUpdEmpFname.TabIndex = 0
        Me.tbxUpdEmpFname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(97, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 18)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "FIRST NAME:"
        '
        'dgvTourGuide
        '
        Me.dgvTourGuide.AllowUserToAddRows = False
        Me.dgvTourGuide.AllowUserToOrderColumns = True
        Me.dgvTourGuide.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvTourGuide.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTourGuide.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTourGuide.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTourGuide.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTourGuide.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgvTourGuide.EnableHeadersVisualStyles = False
        Me.dgvTourGuide.GridColor = System.Drawing.Color.DimGray
        Me.dgvTourGuide.Location = New System.Drawing.Point(35, 58)
        Me.dgvTourGuide.MultiSelect = False
        Me.dgvTourGuide.Name = "dgvTourGuide"
        Me.dgvTourGuide.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTourGuide.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTourGuide.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvTourGuide.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTourGuide.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTourGuide.ShowEditingIcon = False
        Me.dgvTourGuide.Size = New System.Drawing.Size(1092, 287)
        Me.dgvTourGuide.TabIndex = 47
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
        'tbxSearch
        '
        Me.tbxSearch.BackColor = System.Drawing.Color.White
        Me.tbxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxSearch.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxSearch.Location = New System.Drawing.Point(785, 24)
        Me.tbxSearch.Name = "tbxSearch"
        Me.tbxSearch.Size = New System.Drawing.Size(232, 26)
        Me.tbxSearch.TabIndex = 87
        Me.tbxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSearchEmp
        '
        Me.btnSearchEmp.BackColor = System.Drawing.Color.GhostWhite
        Me.btnSearchEmp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchEmp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnSearchEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchEmp.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchEmp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnSearchEmp.Location = New System.Drawing.Point(1028, 24)
        Me.btnSearchEmp.Name = "btnSearchEmp"
        Me.btnSearchEmp.Size = New System.Drawing.Size(66, 26)
        Me.btnSearchEmp.TabIndex = 97
        Me.btnSearchEmp.Text = "Search"
        Me.btnSearchEmp.UseVisualStyleBackColor = False
        '
        'tabTourGuide
        '
        Me.tabTourGuide.Controls.Add(Me.TabPage1)
        Me.tabTourGuide.Controls.Add(Me.TabPage2)
        Me.tabTourGuide.Location = New System.Drawing.Point(35, 362)
        Me.tabTourGuide.Name = "tabTourGuide"
        Me.tabTourGuide.SelectedIndex = 0
        Me.tabTourGuide.Size = New System.Drawing.Size(1092, 354)
        Me.tabTourGuide.TabIndex = 128
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.lblUpdEmpID)
        Me.TabPage1.Controls.Add(Me.btnDelEmp)
        Me.TabPage1.Controls.Add(Me.btnUpdEmp)
        Me.TabPage1.Controls.Add(Me.tbxUpdEmpFname)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.cbxUpdEmpGender)
        Me.TabPage1.Controls.Add(Me.tbxUpdEmpMname)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.tbxUpdEmpEmail)
        Me.TabPage1.Controls.Add(Me.tbxUpdEmpSname)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.tbxUpdEmpPhone)
        Me.TabPage1.Controls.Add(Me.tbxUpdEmpRFID)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1084, 321)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "  Update tour guide   "
        '
        'lblUpdEmpID
        '
        Me.lblUpdEmpID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUpdEmpID.BackColor = System.Drawing.Color.LawnGreen
        Me.lblUpdEmpID.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdEmpID.ForeColor = System.Drawing.Color.LightGray
        Me.lblUpdEmpID.Location = New System.Drawing.Point(809, 300)
        Me.lblUpdEmpID.Margin = New System.Windows.Forms.Padding(0)
        Me.lblUpdEmpID.Name = "lblUpdEmpID"
        Me.lblUpdEmpID.Size = New System.Drawing.Size(272, 18)
        Me.lblUpdEmpID.TabIndex = 10001
        Me.lblUpdEmpID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelEmp
        '
        Me.btnDelEmp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelEmp.BackColor = System.Drawing.Color.Firebrick
        Me.btnDelEmp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelEmp.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnDelEmp.FlatAppearance.BorderSize = 0
        Me.btnDelEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelEmp.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelEmp.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDelEmp.Location = New System.Drawing.Point(898, 213)
        Me.btnDelEmp.Name = "btnDelEmp"
        Me.btnDelEmp.Size = New System.Drawing.Size(109, 38)
        Me.btnDelEmp.TabIndex = 8
        Me.btnDelEmp.Text = "Delete"
        Me.btnDelEmp.UseVisualStyleBackColor = False
        '
        'btnUpdEmp
        '
        Me.btnUpdEmp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnUpdEmp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdEmp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnUpdEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdEmp.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdEmp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnUpdEmp.Location = New System.Drawing.Point(881, 125)
        Me.btnUpdEmp.Name = "btnUpdEmp"
        Me.btnUpdEmp.Size = New System.Drawing.Size(144, 58)
        Me.btnUpdEmp.TabIndex = 7
        Me.btnUpdEmp.Text = "Update Info"
        Me.btnUpdEmp.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.btnClearForm)
        Me.TabPage2.Controls.Add(Me.tbxAddEmpFname)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.cbxAddEmpGender)
        Me.TabPage2.Controls.Add(Me.tbxAddEmpMname)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.tbxAddEmpEmail)
        Me.TabPage2.Controls.Add(Me.tbxAddEmpSname)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.tbxAddEmpPhone)
        Me.TabPage2.Controls.Add(Me.tbxAddEmpRFID)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.btnAddEmp)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1084, 309)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "  Add new tour guide   "
        '
        'btnClearForm
        '
        Me.btnClearForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClearForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearForm.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnClearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearForm.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearForm.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnClearForm.Location = New System.Drawing.Point(879, 201)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(132, 39)
        Me.btnClearForm.TabIndex = 58
        Me.btnClearForm.Text = "Clear Form"
        Me.btnClearForm.UseVisualStyleBackColor = False
        '
        'tbxAddEmpFname
        '
        Me.tbxAddEmpFname.BackColor = System.Drawing.Color.White
        Me.tbxAddEmpFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxAddEmpFname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxAddEmpFname.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAddEmpFname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxAddEmpFname.Location = New System.Drawing.Point(100, 53)
        Me.tbxAddEmpFname.Name = "tbxAddEmpFname"
        Me.tbxAddEmpFname.Size = New System.Drawing.Size(311, 30)
        Me.tbxAddEmpFname.TabIndex = 44
        Me.tbxAddEmpFname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(97, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 18)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "FIRST NAME:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(97, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 18)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "MIDDLE NAME:"
        '
        'cbxAddEmpGender
        '
        Me.cbxAddEmpGender.BackColor = System.Drawing.Color.White
        Me.cbxAddEmpGender.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxAddEmpGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAddEmpGender.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxAddEmpGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.cbxAddEmpGender.FormattingEnabled = True
        Me.cbxAddEmpGender.ItemHeight = 22
        Me.cbxAddEmpGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.cbxAddEmpGender.Location = New System.Drawing.Point(727, 53)
        Me.cbxAddEmpGender.Name = "cbxAddEmpGender"
        Me.cbxAddEmpGender.Size = New System.Drawing.Size(83, 30)
        Me.cbxAddEmpGender.TabIndex = 48
        '
        'tbxAddEmpMname
        '
        Me.tbxAddEmpMname.BackColor = System.Drawing.Color.White
        Me.tbxAddEmpMname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxAddEmpMname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxAddEmpMname.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAddEmpMname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxAddEmpMname.Location = New System.Drawing.Point(100, 119)
        Me.tbxAddEmpMname.Name = "tbxAddEmpMname"
        Me.tbxAddEmpMname.Size = New System.Drawing.Size(311, 30)
        Me.tbxAddEmpMname.TabIndex = 45
        Me.tbxAddEmpMname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(724, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 18)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "GENDER:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Location = New System.Drawing.Point(97, 166)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 18)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "SURNAME:"
        '
        'tbxAddEmpEmail
        '
        Me.tbxAddEmpEmail.BackColor = System.Drawing.Color.White
        Me.tbxAddEmpEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxAddEmpEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tbxAddEmpEmail.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAddEmpEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxAddEmpEmail.Location = New System.Drawing.Point(499, 185)
        Me.tbxAddEmpEmail.Name = "tbxAddEmpEmail"
        Me.tbxAddEmpEmail.Size = New System.Drawing.Size(311, 30)
        Me.tbxAddEmpEmail.TabIndex = 50
        Me.tbxAddEmpEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbxAddEmpSname
        '
        Me.tbxAddEmpSname.BackColor = System.Drawing.Color.White
        Me.tbxAddEmpSname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxAddEmpSname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxAddEmpSname.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAddEmpSname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxAddEmpSname.Location = New System.Drawing.Point(100, 185)
        Me.tbxAddEmpSname.Name = "tbxAddEmpSname"
        Me.tbxAddEmpSname.Size = New System.Drawing.Size(311, 30)
        Me.tbxAddEmpSname.TabIndex = 46
        Me.tbxAddEmpSname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Location = New System.Drawing.Point(496, 166)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 18)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "EMAIL:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label13.Location = New System.Drawing.Point(496, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 18)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "RFID NO."
        '
        'tbxAddEmpPhone
        '
        Me.tbxAddEmpPhone.BackColor = System.Drawing.Color.White
        Me.tbxAddEmpPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxAddEmpPhone.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAddEmpPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxAddEmpPhone.Location = New System.Drawing.Point(499, 119)
        Me.tbxAddEmpPhone.MaxLength = 11
        Me.tbxAddEmpPhone.Name = "tbxAddEmpPhone"
        Me.tbxAddEmpPhone.Size = New System.Drawing.Size(311, 30)
        Me.tbxAddEmpPhone.TabIndex = 49
        Me.tbxAddEmpPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbxAddEmpRFID
        '
        Me.tbxAddEmpRFID.BackColor = System.Drawing.Color.White
        Me.tbxAddEmpRFID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxAddEmpRFID.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAddEmpRFID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxAddEmpRFID.Location = New System.Drawing.Point(499, 53)
        Me.tbxAddEmpRFID.Name = "tbxAddEmpRFID"
        Me.tbxAddEmpRFID.Size = New System.Drawing.Size(222, 30)
        Me.tbxAddEmpRFID.TabIndex = 47
        Me.tbxAddEmpRFID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label14.Location = New System.Drawing.Point(496, 100)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 18)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "PHONE NUMBER:"
        '
        'btnAddEmp
        '
        Me.btnAddEmp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnAddEmp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddEmp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddEmp.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEmp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnAddEmp.Location = New System.Drawing.Point(861, 120)
        Me.btnAddEmp.Name = "btnAddEmp"
        Me.btnAddEmp.Size = New System.Drawing.Size(166, 57)
        Me.btnAddEmp.TabIndex = 5
        Me.btnAddEmp.Text = "Add Tour Guide"
        Me.btnAddEmp.UseVisualStyleBackColor = False
        '
        'btnRemoveFilter
        '
        Me.btnRemoveFilter.BackColor = System.Drawing.Color.Gainsboro
        Me.btnRemoveFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoveFilter.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRemoveFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRemoveFilter.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnRemoveFilter.Location = New System.Drawing.Point(1100, 24)
        Me.btnRemoveFilter.Name = "btnRemoveFilter"
        Me.btnRemoveFilter.Size = New System.Drawing.Size(27, 27)
        Me.btnRemoveFilter.TabIndex = 129
        Me.btnRemoveFilter.Text = "X"
        Me.btnRemoveFilter.UseVisualStyleBackColor = False
        '
        'ctrlTourGuides
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.btnRemoveFilter)
        Me.Controls.Add(Me.tabTourGuide)
        Me.Controls.Add(Me.btnSearchEmp)
        Me.Controls.Add(Me.tbxSearch)
        Me.Controls.Add(Me.dgvTourGuide)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ctrlTourGuides"
        Me.Size = New System.Drawing.Size(1161, 738)
        CType(Me.dgvTourGuide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTourGuide.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxUpdEmpGender As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbxUpdEmpEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbxUpdEmpPhone As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbxUpdEmpRFID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbxUpdEmpSname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbxUpdEmpMname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxUpdEmpFname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvTourGuide As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents tbxSearch As TextBox
    Friend WithEvents btnSearchEmp As Button
    Friend WithEvents tabTourGuide As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnDelEmp As Button
    Friend WithEvents btnUpdEmp As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnAddEmp As Button
    Friend WithEvents lblUpdEmpID As Label
    Friend WithEvents btnRemoveFilter As Button
    Friend WithEvents btnClearForm As Button
    Friend WithEvents tbxAddEmpFname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbxAddEmpGender As ComboBox
    Friend WithEvents tbxAddEmpMname As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents tbxAddEmpEmail As TextBox
    Friend WithEvents tbxAddEmpSname As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents tbxAddEmpPhone As TextBox
    Friend WithEvents tbxAddEmpRFID As TextBox
    Friend WithEvents Label14 As Label
End Class
