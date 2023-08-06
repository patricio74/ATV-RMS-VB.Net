<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrlCustomers
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
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbxEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbxPhone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbxCustID = New System.Windows.Forms.TextBox()
        Me.tbxSurname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbxMidname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxFirname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDelCust = New System.Windows.Forms.Button()
        Me.btnUpdCust = New System.Windows.Forms.Button()
        Me.btnAddCust = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbxStreet = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxBarangay = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbxMuniCity = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbCountry = New System.Windows.Forms.ComboBox()
        Me.tbxProvince = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbGender
        '
        Me.cmbGender.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbGender.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.ItemHeight = 20
        Me.cmbGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.cmbGender.Location = New System.Drawing.Point(467, 641)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(120, 28)
        Me.cmbGender.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(404, 647)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 18)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "GENDER:"
        '
        'tbxEmail
        '
        Me.tbxEmail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tbxEmail.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxEmail.Location = New System.Drawing.Point(75, 661)
        Me.tbxEmail.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.tbxEmail.Name = "tbxEmail"
        Me.tbxEmail.Size = New System.Drawing.Size(296, 26)
        Me.tbxEmail.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(72, 643)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "EMAIL ADDRESS:"
        '
        'tbxPhone
        '
        Me.tbxPhone.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxPhone.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxPhone.Location = New System.Drawing.Point(75, 601)
        Me.tbxPhone.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.tbxPhone.MaxLength = 11
        Me.tbxPhone.Name = "tbxPhone"
        Me.tbxPhone.Size = New System.Drawing.Size(296, 26)
        Me.tbxPhone.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(72, 586)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "CONTACT NUMBER:"
        '
        'tbxCustID
        '
        Me.tbxCustID.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbxCustID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxCustID.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbxCustID.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCustID.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tbxCustID.Location = New System.Drawing.Point(407, 416)
        Me.tbxCustID.Name = "tbxCustID"
        Me.tbxCustID.ReadOnly = True
        Me.tbxCustID.Size = New System.Drawing.Size(180, 13)
        Me.tbxCustID.TabIndex = 23
        Me.tbxCustID.Visible = False
        '
        'tbxSurname
        '
        Me.tbxSurname.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbxSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxSurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxSurname.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxSurname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxSurname.Location = New System.Drawing.Point(76, 542)
        Me.tbxSurname.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.tbxSurname.Name = "tbxSurname"
        Me.tbxSurname.Size = New System.Drawing.Size(296, 26)
        Me.tbxSurname.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(72, 523)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "SURNAME:"
        '
        'tbxMidname
        '
        Me.tbxMidname.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbxMidname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxMidname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxMidname.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxMidname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxMidname.Location = New System.Drawing.Point(76, 486)
        Me.tbxMidname.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.tbxMidname.Name = "tbxMidname"
        Me.tbxMidname.Size = New System.Drawing.Size(296, 26)
        Me.tbxMidname.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(72, 467)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "MIDDLE NAME:"
        '
        'tbxFirname
        '
        Me.tbxFirname.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbxFirname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxFirname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxFirname.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxFirname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxFirname.Location = New System.Drawing.Point(76, 427)
        Me.tbxFirname.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.tbxFirname.Name = "tbxFirname"
        Me.tbxFirname.Size = New System.Drawing.Size(296, 26)
        Me.tbxFirname.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(72, 408)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FIRST NAME:"
        '
        'btnDelCust
        '
        Me.btnDelCust.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnDelCust.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelCust.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnDelCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelCust.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelCust.ForeColor = System.Drawing.Color.Red
        Me.btnDelCust.Location = New System.Drawing.Point(963, 569)
        Me.btnDelCust.Name = "btnDelCust"
        Me.btnDelCust.Size = New System.Drawing.Size(121, 44)
        Me.btnDelCust.TabIndex = 26
        Me.btnDelCust.Text = "Delete"
        Me.btnDelCust.UseVisualStyleBackColor = False
        '
        'btnUpdCust
        '
        Me.btnUpdCust.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnUpdCust.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdCust.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnUpdCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdCust.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdCust.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnUpdCust.Location = New System.Drawing.Point(963, 493)
        Me.btnUpdCust.Name = "btnUpdCust"
        Me.btnUpdCust.Size = New System.Drawing.Size(121, 44)
        Me.btnUpdCust.TabIndex = 25
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
        Me.btnAddCust.Location = New System.Drawing.Point(963, 419)
        Me.btnAddCust.Name = "btnAddCust"
        Me.btnAddCust.Size = New System.Drawing.Size(121, 44)
        Me.btnAddCust.TabIndex = 24
        Me.btnAddCust.Text = "Add"
        Me.btnAddCust.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(407, 436)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 180)
        Me.PictureBox1.TabIndex = 85
        Me.PictureBox1.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightGray
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(963, 643)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(121, 44)
        Me.btnClear.TabIndex = 27
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
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
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.DarkGray
        Me.DataGridView1.Location = New System.Drawing.Point(44, 36)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
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
        Me.DataGridView1.Size = New System.Drawing.Size(1077, 354)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "FULLNAME"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 215
        '
        'Column2
        '
        Me.Column2.HeaderText = "EMAIL ADDRESS"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 250
        '
        'Column3
        '
        Me.Column3.HeaderText = "PHONE NUMBER"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 147
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "ADDRESS"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "USERNAME"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 175
        '
        'tbxStreet
        '
        Me.tbxStreet.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbxStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxStreet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxStreet.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxStreet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxStreet.Location = New System.Drawing.Point(618, 427)
        Me.tbxStreet.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.tbxStreet.Name = "tbxStreet"
        Me.tbxStreet.Size = New System.Drawing.Size(296, 26)
        Me.tbxStreet.TabIndex = 14
        Me.tbxStreet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(614, 408)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 18)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "STREET:"
        '
        'tbxBarangay
        '
        Me.tbxBarangay.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbxBarangay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxBarangay.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxBarangay.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxBarangay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxBarangay.Location = New System.Drawing.Point(618, 486)
        Me.tbxBarangay.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.tbxBarangay.Name = "tbxBarangay"
        Me.tbxBarangay.Size = New System.Drawing.Size(296, 26)
        Me.tbxBarangay.TabIndex = 16
        Me.tbxBarangay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(614, 467)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "BARANGAY:"
        '
        'tbxMuniCity
        '
        Me.tbxMuniCity.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbxMuniCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxMuniCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxMuniCity.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxMuniCity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxMuniCity.Location = New System.Drawing.Point(618, 542)
        Me.tbxMuniCity.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.tbxMuniCity.Name = "tbxMuniCity"
        Me.tbxMuniCity.Size = New System.Drawing.Size(296, 26)
        Me.tbxMuniCity.TabIndex = 18
        Me.tbxMuniCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(615, 524)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 18)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "MUNICIPALITY/CITY:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(614, 583)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 18)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "PROVINCE:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Location = New System.Drawing.Point(614, 643)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 18)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "COUNTRY:"
        '
        'cmbCountry
        '
        Me.cmbCountry.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbCountry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCountry.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCountry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cmbCountry.FormattingEnabled = True
        Me.cmbCountry.ItemHeight = 20
        Me.cmbCountry.Items.AddRange(New Object() {"PHILIPPINES", "CAVITE"})
        Me.cmbCountry.Location = New System.Drawing.Point(617, 661)
        Me.cmbCountry.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.cmbCountry.Name = "cmbCountry"
        Me.cmbCountry.Size = New System.Drawing.Size(296, 28)
        Me.cmbCountry.TabIndex = 22
        '
        'tbxProvince
        '
        Me.tbxProvince.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbxProvince.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxProvince.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxProvince.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxProvince.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxProvince.Location = New System.Drawing.Point(617, 601)
        Me.tbxProvince.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.tbxProvince.Name = "tbxProvince"
        Me.tbxProvince.Size = New System.Drawing.Size(296, 26)
        Me.tbxProvince.TabIndex = 20
        Me.tbxProvince.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ctrlCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.tbxProvince)
        Me.Controls.Add(Me.cmbCountry)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tbxMuniCity)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbxBarangay)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbxStreet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbxEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbxPhone)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbxCustID)
        Me.Controls.Add(Me.tbxSurname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbxMidname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbxFirname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelCust)
        Me.Controls.Add(Me.btnUpdCust)
        Me.Controls.Add(Me.btnAddCust)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ctrlCustomers"
        Me.Size = New System.Drawing.Size(1161, 738)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbxEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbxPhone As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbxCustID As TextBox
    Friend WithEvents tbxSurname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbxMidname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxFirname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelCust As Button
    Friend WithEvents btnUpdCust As Button
    Friend WithEvents btnAddCust As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tbxStreet As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxBarangay As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbxMuniCity As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbCountry As ComboBox
    Friend WithEvents tbxProvince As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
