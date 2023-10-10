<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrlTransactions
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbxReservFilter = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnViewRes = New System.Windows.Forms.Button()
        Me.btnUpdRes = New System.Windows.Forms.Button()
        Me.btnAddTransac = New System.Windows.Forms.Button()
        Me.cbxReservStatus = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbxReservTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dateTimeReserv = New System.Windows.Forms.DateTimePicker()
        Me.tbxReservFName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxReservMName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxReservSName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxReservPerson = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxReservTimeSlot = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbxReservID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxReservTour = New System.Windows.Forms.ComboBox()
        Me.lblReservCounter = New System.Windows.Forms.Label()
        Me.tbxAddPerson = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbxAddTimeSlot = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbxAddTour = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tbxAddSname = New System.Windows.Forms.TextBox()
        Me.tbxAddTotal = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbxAddMName = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dateTimeAdd = New System.Windows.Forms.DateTimePicker()
        Me.tbxAddFName = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblTransacPesoSign = New System.Windows.Forms.Label()
        Me.lblClearAdd = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblClearRes = New System.Windows.Forms.Label()
        Me.lblTransacCounter = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxReservFilter
        '
        Me.cbxReservFilter.BackColor = System.Drawing.Color.White
        Me.cbxReservFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxReservFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxReservFilter.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxReservFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.cbxReservFilter.FormattingEnabled = True
        Me.cbxReservFilter.ItemHeight = 18
        Me.cbxReservFilter.Items.AddRange(New Object() {"PENDING", "ONGOING", "CANCELED"})
        Me.cbxReservFilter.Location = New System.Drawing.Point(925, 18)
        Me.cbxReservFilter.Name = "cbxReservFilter"
        Me.cbxReservFilter.Size = New System.Drawing.Size(142, 26)
        Me.cbxReservFilter.TabIndex = 65
        Me.cbxReservFilter.Visible = False
        '
        'Timer1
        '
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column4, Me.Column5, Me.Column6, Me.Column3, Me.Column7, Me.Column8})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.DarkGray
        Me.DataGridView1.Location = New System.Drawing.Point(30, 59)
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
        Me.DataGridView1.Size = New System.Drawing.Size(1103, 297)
        Me.DataGridView1.TabIndex = 95
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 25
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "FIRST NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "MIDDLE NAME"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "SURNAME"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "TOUR NAME"
        Me.Column6.Name = "Column6"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "DATE"
        Me.Column3.Name = "Column3"
        '
        'Column7
        '
        Me.Column7.HeaderText = "TIME SLOT"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 110
        '
        'Column8
        '
        Me.Column8.HeaderText = "STATUS"
        Me.Column8.Name = "Column8"
        '
        'btnViewRes
        '
        Me.btnViewRes.BackColor = System.Drawing.Color.Gainsboro
        Me.btnViewRes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewRes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnViewRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewRes.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewRes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnViewRes.Location = New System.Drawing.Point(1073, 18)
        Me.btnViewRes.Name = "btnViewRes"
        Me.btnViewRes.Size = New System.Drawing.Size(60, 27)
        Me.btnViewRes.TabIndex = 96
        Me.btnViewRes.Text = "View"
        Me.btnViewRes.UseVisualStyleBackColor = False
        Me.btnViewRes.Visible = False
        '
        'btnUpdRes
        '
        Me.btnUpdRes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnUpdRes.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnUpdRes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdRes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnUpdRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdRes.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdRes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnUpdRes.Location = New System.Drawing.Point(823, 194)
        Me.btnUpdRes.Name = "btnUpdRes"
        Me.btnUpdRes.Size = New System.Drawing.Size(121, 44)
        Me.btnUpdRes.TabIndex = 106
        Me.btnUpdRes.Text = "Update"
        Me.btnUpdRes.UseVisualStyleBackColor = False
        '
        'btnAddTransac
        '
        Me.btnAddTransac.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddTransac.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnAddTransac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddTransac.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnAddTransac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddTransac.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTransac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnAddTransac.Location = New System.Drawing.Point(828, 167)
        Me.btnAddTransac.Name = "btnAddTransac"
        Me.btnAddTransac.Size = New System.Drawing.Size(121, 44)
        Me.btnAddTransac.TabIndex = 105
        Me.btnAddTransac.Text = "Add"
        Me.btnAddTransac.UseVisualStyleBackColor = False
        '
        'cbxReservStatus
        '
        Me.cbxReservStatus.BackColor = System.Drawing.Color.White
        Me.cbxReservStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxReservStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxReservStatus.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxReservStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cbxReservStatus.FormattingEnabled = True
        Me.cbxReservStatus.ItemHeight = 22
        Me.cbxReservStatus.Items.AddRange(New Object() {"PENDING", "ONGOING", "DONE", "CANCELED"})
        Me.cbxReservStatus.Location = New System.Drawing.Point(549, 194)
        Me.cbxReservStatus.Name = "cbxReservStatus"
        Me.cbxReservStatus.Size = New System.Drawing.Size(121, 30)
        Me.cbxReservStatus.TabIndex = 104
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(546, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 18)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "STATUS:"
        '
        'tbxReservTotal
        '
        Me.tbxReservTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbxReservTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxReservTotal.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxReservTotal.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxReservTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.tbxReservTotal.Location = New System.Drawing.Point(725, 130)
        Me.tbxReservTotal.MaxLength = 11
        Me.tbxReservTotal.Name = "tbxReservTotal"
        Me.tbxReservTotal.ReadOnly = True
        Me.tbxReservTotal.Size = New System.Drawing.Size(252, 41)
        Me.tbxReservTotal.TabIndex = 100
        Me.tbxReservTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(722, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 18)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "TOTAL PRICE:"
        '
        'dateTimeReserv
        '
        Me.dateTimeReserv.CalendarForeColor = System.Drawing.Color.WhiteSmoke
        Me.dateTimeReserv.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.dateTimeReserv.Checked = False
        Me.dateTimeReserv.CustomFormat = "MM-dd-yyyy"
        Me.dateTimeReserv.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimeReserv.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateTimeReserv.Location = New System.Drawing.Point(418, 130)
        Me.dateTimeReserv.Name = "dateTimeReserv"
        Me.dateTimeReserv.Size = New System.Drawing.Size(163, 26)
        Me.dateTimeReserv.TabIndex = 109
        '
        'tbxReservFName
        '
        Me.tbxReservFName.BackColor = System.Drawing.Color.White
        Me.tbxReservFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxReservFName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxReservFName.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxReservFName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxReservFName.Location = New System.Drawing.Point(56, 65)
        Me.tbxReservFName.MaxLength = 11
        Me.tbxReservFName.Name = "tbxReservFName"
        Me.tbxReservFName.Size = New System.Drawing.Size(311, 30)
        Me.tbxReservFName.TabIndex = 111
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(53, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 18)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "FIRST NAME:"
        '
        'tbxReservMName
        '
        Me.tbxReservMName.BackColor = System.Drawing.Color.White
        Me.tbxReservMName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxReservMName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxReservMName.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxReservMName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxReservMName.Location = New System.Drawing.Point(56, 130)
        Me.tbxReservMName.MaxLength = 11
        Me.tbxReservMName.Name = "tbxReservMName"
        Me.tbxReservMName.Size = New System.Drawing.Size(311, 30)
        Me.tbxReservMName.TabIndex = 113
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(53, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 18)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "MIDDLE NAME:"
        '
        'tbxReservSName
        '
        Me.tbxReservSName.BackColor = System.Drawing.Color.White
        Me.tbxReservSName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxReservSName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxReservSName.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxReservSName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxReservSName.Location = New System.Drawing.Point(56, 194)
        Me.tbxReservSName.MaxLength = 11
        Me.tbxReservSName.Name = "tbxReservSName"
        Me.tbxReservSName.Size = New System.Drawing.Size(311, 30)
        Me.tbxReservSName.TabIndex = 115
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(53, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 18)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "SURNAME:"
        '
        'tbxReservPerson
        '
        Me.tbxReservPerson.BackColor = System.Drawing.Color.White
        Me.tbxReservPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxReservPerson.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxReservPerson.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxReservPerson.Location = New System.Drawing.Point(588, 130)
        Me.tbxReservPerson.MaxLength = 2
        Me.tbxReservPerson.Name = "tbxReservPerson"
        Me.tbxReservPerson.Size = New System.Drawing.Size(82, 30)
        Me.tbxReservPerson.TabIndex = 124
        Me.tbxReservPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(585, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 18)
        Me.Label10.TabIndex = 123
        Me.Label10.Text = "# OF PERSON:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(415, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 18)
        Me.Label9.TabIndex = 122
        Me.Label9.Text = "RESERVATION DATE:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(415, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 18)
        Me.Label7.TabIndex = 120
        Me.Label7.Text = "TIME SLOT:"
        '
        'cbxReservTimeSlot
        '
        Me.cbxReservTimeSlot.BackColor = System.Drawing.Color.White
        Me.cbxReservTimeSlot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxReservTimeSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxReservTimeSlot.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxReservTimeSlot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cbxReservTimeSlot.FormattingEnabled = True
        Me.cbxReservTimeSlot.ItemHeight = 22
        Me.cbxReservTimeSlot.Items.AddRange(New Object() {"MORNING", "AFTERNOON", "EVENING"})
        Me.cbxReservTimeSlot.Location = New System.Drawing.Point(418, 194)
        Me.cbxReservTimeSlot.Name = "cbxReservTimeSlot"
        Me.cbxReservTimeSlot.Size = New System.Drawing.Size(121, 30)
        Me.cbxReservTimeSlot.TabIndex = 121
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(722, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 18)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "RESERVATION ID:"
        '
        'tbxReservID
        '
        Me.tbxReservID.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.tbxReservID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxReservID.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxReservID.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxReservID.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tbxReservID.Location = New System.Drawing.Point(725, 67)
        Me.tbxReservID.MaxLength = 11
        Me.tbxReservID.Name = "tbxReservID"
        Me.tbxReservID.ReadOnly = True
        Me.tbxReservID.Size = New System.Drawing.Size(252, 25)
        Me.tbxReservID.TabIndex = 119
        Me.tbxReservID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(415, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 18)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "NAME OF TOUR:"
        '
        'cbxReservTour
        '
        Me.cbxReservTour.BackColor = System.Drawing.Color.White
        Me.cbxReservTour.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbxReservTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxReservTour.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxReservTour.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cbxReservTour.FormattingEnabled = True
        Me.cbxReservTour.ItemHeight = 22
        Me.cbxReservTour.Location = New System.Drawing.Point(418, 65)
        Me.cbxReservTour.Name = "cbxReservTour"
        Me.cbxReservTour.Size = New System.Drawing.Size(252, 30)
        Me.cbxReservTour.TabIndex = 117
        '
        'lblReservCounter
        '
        Me.lblReservCounter.AutoSize = True
        Me.lblReservCounter.BackColor = System.Drawing.Color.Transparent
        Me.lblReservCounter.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReservCounter.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblReservCounter.Location = New System.Drawing.Point(27, 31)
        Me.lblReservCounter.Name = "lblReservCounter"
        Me.lblReservCounter.Size = New System.Drawing.Size(282, 14)
        Me.lblReservCounter.TabIndex = 125
        Me.lblReservCounter.Text = "Reservation count: 0 Pending, 0 Canceled"
        Me.lblReservCounter.Visible = False
        '
        'tbxAddPerson
        '
        Me.tbxAddPerson.BackColor = System.Drawing.Color.White
        Me.tbxAddPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxAddPerson.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAddPerson.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxAddPerson.Location = New System.Drawing.Point(599, 130)
        Me.tbxAddPerson.MaxLength = 2
        Me.tbxAddPerson.Name = "tbxAddPerson"
        Me.tbxAddPerson.Size = New System.Drawing.Size(71, 30)
        Me.tbxAddPerson.TabIndex = 124
        Me.tbxAddPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Location = New System.Drawing.Point(585, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 18)
        Me.Label11.TabIndex = 123
        Me.Label11.Text = "# OF PERSON:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Location = New System.Drawing.Point(415, 113)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 18)
        Me.Label12.TabIndex = 122
        Me.Label12.Text = "RESERVATION DATE:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label13.Location = New System.Drawing.Point(415, 183)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 18)
        Me.Label13.TabIndex = 120
        Me.Label13.Text = "TIME SLOT:"
        '
        'cbxAddTimeSlot
        '
        Me.cbxAddTimeSlot.BackColor = System.Drawing.Color.White
        Me.cbxAddTimeSlot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxAddTimeSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAddTimeSlot.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxAddTimeSlot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cbxAddTimeSlot.FormattingEnabled = True
        Me.cbxAddTimeSlot.ItemHeight = 22
        Me.cbxAddTimeSlot.Items.AddRange(New Object() {"MORNING", "AFTERNOON", "EVENING"})
        Me.cbxAddTimeSlot.Location = New System.Drawing.Point(418, 202)
        Me.cbxAddTimeSlot.Name = "cbxAddTimeSlot"
        Me.cbxAddTimeSlot.Size = New System.Drawing.Size(252, 30)
        Me.cbxAddTimeSlot.TabIndex = 121
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label15.Location = New System.Drawing.Point(415, 46)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(97, 18)
        Me.Label15.TabIndex = 116
        Me.Label15.Text = "NAME OF TOUR:"
        '
        'cbxAddTour
        '
        Me.cbxAddTour.BackColor = System.Drawing.Color.White
        Me.cbxAddTour.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxAddTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAddTour.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxAddTour.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cbxAddTour.FormattingEnabled = True
        Me.cbxAddTour.ItemHeight = 22
        Me.cbxAddTour.Location = New System.Drawing.Point(418, 65)
        Me.cbxAddTour.Name = "cbxAddTour"
        Me.cbxAddTour.Size = New System.Drawing.Size(252, 30)
        Me.cbxAddTour.TabIndex = 117
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label16.Location = New System.Drawing.Point(53, 44)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 18)
        Me.Label16.TabIndex = 110
        Me.Label16.Text = "FIRST NAME:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label17.Location = New System.Drawing.Point(721, 87)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(82, 18)
        Me.Label17.TabIndex = 99
        Me.Label17.Text = "TOTAL PRICE:"
        '
        'tbxAddSname
        '
        Me.tbxAddSname.BackColor = System.Drawing.Color.White
        Me.tbxAddSname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxAddSname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxAddSname.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAddSname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxAddSname.Location = New System.Drawing.Point(56, 204)
        Me.tbxAddSname.MaxLength = 11
        Me.tbxAddSname.Name = "tbxAddSname"
        Me.tbxAddSname.Size = New System.Drawing.Size(311, 30)
        Me.tbxAddSname.TabIndex = 115
        '
        'tbxAddTotal
        '
        Me.tbxAddTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbxAddTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxAddTotal.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxAddTotal.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAddTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.tbxAddTotal.Location = New System.Drawing.Point(724, 108)
        Me.tbxAddTotal.MaxLength = 11
        Me.tbxAddTotal.Name = "tbxAddTotal"
        Me.tbxAddTotal.ReadOnly = True
        Me.tbxAddTotal.Size = New System.Drawing.Size(252, 41)
        Me.tbxAddTotal.TabIndex = 100
        Me.tbxAddTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label18.Location = New System.Drawing.Point(53, 185)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 18)
        Me.Label18.TabIndex = 114
        Me.Label18.Text = "SURNAME:"
        '
        'tbxAddMName
        '
        Me.tbxAddMName.BackColor = System.Drawing.Color.White
        Me.tbxAddMName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxAddMName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxAddMName.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAddMName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxAddMName.Location = New System.Drawing.Point(56, 133)
        Me.tbxAddMName.MaxLength = 11
        Me.tbxAddMName.Name = "tbxAddMName"
        Me.tbxAddMName.Size = New System.Drawing.Size(311, 30)
        Me.tbxAddMName.TabIndex = 113
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label20.Location = New System.Drawing.Point(53, 114)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(92, 18)
        Me.Label20.TabIndex = 112
        Me.Label20.Text = "MIDDLE NAME:"
        '
        'dateTimeAdd
        '
        Me.dateTimeAdd.CalendarForeColor = System.Drawing.Color.WhiteSmoke
        Me.dateTimeAdd.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.dateTimeAdd.Checked = False
        Me.dateTimeAdd.CustomFormat = "MM-dd-yyyy"
        Me.dateTimeAdd.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimeAdd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateTimeAdd.Location = New System.Drawing.Point(418, 134)
        Me.dateTimeAdd.Name = "dateTimeAdd"
        Me.dateTimeAdd.Size = New System.Drawing.Size(175, 26)
        Me.dateTimeAdd.TabIndex = 109
        '
        'tbxAddFName
        '
        Me.tbxAddFName.BackColor = System.Drawing.Color.White
        Me.tbxAddFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxAddFName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxAddFName.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAddFName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxAddFName.Location = New System.Drawing.Point(56, 65)
        Me.tbxAddFName.MaxLength = 11
        Me.tbxAddFName.Name = "tbxAddFName"
        Me.tbxAddFName.Size = New System.Drawing.Size(311, 30)
        Me.tbxAddFName.TabIndex = 111
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(45, 375)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1074, 313)
        Me.TabControl1.TabIndex = 127
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.lblTransacPesoSign)
        Me.TabPage1.Controls.Add(Me.lblClearAdd)
        Me.TabPage1.Controls.Add(Me.tbxAddPerson)
        Me.TabPage1.Controls.Add(Me.tbxAddFName)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.dateTimeAdd)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.cbxAddTimeSlot)
        Me.TabPage1.Controls.Add(Me.tbxAddMName)
        Me.TabPage1.Controls.Add(Me.btnAddTransac)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.cbxAddTour)
        Me.TabPage1.Controls.Add(Me.tbxAddTotal)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.tbxAddSname)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1066, 280)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = " Add Transaction"
        '
        'lblTransacPesoSign
        '
        Me.lblTransacPesoSign.AutoSize = True
        Me.lblTransacPesoSign.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTransacPesoSign.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransacPesoSign.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.lblTransacPesoSign.Location = New System.Drawing.Point(728, 110)
        Me.lblTransacPesoSign.Name = "lblTransacPesoSign"
        Me.lblTransacPesoSign.Size = New System.Drawing.Size(39, 37)
        Me.lblTransacPesoSign.TabIndex = 126
        Me.lblTransacPesoSign.Text = "₱"
        '
        'lblClearAdd
        '
        Me.lblClearAdd.AutoSize = True
        Me.lblClearAdd.BackColor = System.Drawing.Color.Transparent
        Me.lblClearAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClearAdd.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearAdd.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblClearAdd.Location = New System.Drawing.Point(747, 182)
        Me.lblClearAdd.Name = "lblClearAdd"
        Me.lblClearAdd.Size = New System.Drawing.Size(75, 18)
        Me.lblClearAdd.TabIndex = 125
        Me.lblClearAdd.Text = "Clear Form"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.lblClearRes)
        Me.TabPage2.Controls.Add(Me.tbxReservPerson)
        Me.TabPage2.Controls.Add(Me.tbxReservID)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.tbxReservFName)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.dateTimeReserv)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.cbxReservTimeSlot)
        Me.TabPage2.Controls.Add(Me.cbxReservStatus)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.tbxReservMName)
        Me.TabPage2.Controls.Add(Me.btnUpdRes)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.tbxReservTotal)
        Me.TabPage2.Controls.Add(Me.cbxReservTour)
        Me.TabPage2.Controls.Add(Me.tbxReservSName)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1066, 280)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = " Update Reservation"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(729, 132)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 37)
        Me.Label14.TabIndex = 129
        Me.Label14.Text = "₱"
        '
        'lblClearRes
        '
        Me.lblClearRes.AutoSize = True
        Me.lblClearRes.BackColor = System.Drawing.Color.Transparent
        Me.lblClearRes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClearRes.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearRes.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblClearRes.Location = New System.Drawing.Point(742, 209)
        Me.lblClearRes.Name = "lblClearRes"
        Me.lblClearRes.Size = New System.Drawing.Size(75, 18)
        Me.lblClearRes.TabIndex = 126
        Me.lblClearRes.Text = "Clear Form"
        '
        'lblTransacCounter
        '
        Me.lblTransacCounter.AutoSize = True
        Me.lblTransacCounter.BackColor = System.Drawing.Color.Transparent
        Me.lblTransacCounter.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransacCounter.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTransacCounter.Location = New System.Drawing.Point(27, 31)
        Me.lblTransacCounter.Name = "lblTransacCounter"
        Me.lblTransacCounter.Size = New System.Drawing.Size(224, 14)
        Me.lblTransacCounter.TabIndex = 128
        Me.lblTransacCounter.Text = "Total transactions made today: 0"
        '
        'ctrlTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.lblTransacCounter)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblReservCounter)
        Me.Controls.Add(Me.btnViewRes)
        Me.Controls.Add(Me.cbxReservFilter)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ctrlTransactions"
        Me.Size = New System.Drawing.Size(1161, 738)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxReservFilter As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnViewRes As Button
    Friend WithEvents btnUpdRes As Button
    Friend WithEvents btnAddTransac As Button
    Friend WithEvents cbxReservStatus As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbxReservTotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dateTimeReserv As DateTimePicker
    Friend WithEvents tbxReservFName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbxReservMName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxReservSName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbxReservTour As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbxReservID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbxReservTimeSlot As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbxReservPerson As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblReservCounter As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lblClearAdd As Label
    Friend WithEvents lblClearRes As Label
    Friend WithEvents tbxAddPerson As TextBox
    Friend WithEvents cbxAddTimeSlot As ComboBox
    Friend WithEvents cbxAddTour As ComboBox
    Friend WithEvents tbxAddSname As TextBox
    Friend WithEvents tbxAddTotal As TextBox
    Friend WithEvents tbxAddMName As TextBox
    Friend WithEvents dateTimeAdd As DateTimePicker
    Friend WithEvents tbxAddFName As TextBox
    Friend WithEvents lblTransacCounter As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents lblTransacPesoSign As Label
    Friend WithEvents Label14 As Label
End Class
