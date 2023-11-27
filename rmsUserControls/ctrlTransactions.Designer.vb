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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbxTransacFilter = New System.Windows.Forms.ComboBox()
        Me.dgvTransactions = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnViewTransac = New System.Windows.Forms.Button()
        Me.btnAddTransac = New System.Windows.Forms.Button()
        Me.tbxAddPerson = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
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
        Me.tbxAddFName = New System.Windows.Forms.TextBox()
        Me.tabTransactions = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.lblTransacPesoSign = New System.Windows.Forms.Label()
        Me.lblClearAdd = New System.Windows.Forms.Label()
        Me.cbxAddTourGuide = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.cbxAddAtv = New System.Windows.Forms.ComboBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.lblClearNew = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbxNewPerson = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbxNewFName = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cbxNewTimeSlot = New System.Windows.Forms.ComboBox()
        Me.cbxNewStatus = New System.Windows.Forms.ComboBox()
        Me.tbxNewMName = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.tbxNewTotal = New System.Windows.Forms.TextBox()
        Me.cbxNewTour = New System.Windows.Forms.ComboBox()
        Me.tbxNewSName = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.btnAddRes = New System.Windows.Forms.Button()
        Me.dateTimeNew = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblUpdReservID = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblClearUpd = New System.Windows.Forms.Label()
        Me.tbxReservPerson = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbxReservFName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dateTimeReserv = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxReservTimeSlot = New System.Windows.Forms.ComboBox()
        Me.cbxReservStatus = New System.Windows.Forms.ComboBox()
        Me.tbxReservMName = New System.Windows.Forms.TextBox()
        Me.btnUpdRes = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbxReservTotal = New System.Windows.Forms.TextBox()
        Me.cbxReservTour = New System.Windows.Forms.ComboBox()
        Me.tbxReservSName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.cbxOnGTourGuide = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cbxOnGAtv = New System.Windows.Forms.ComboBox()
        Me.lblClearTransac = New System.Windows.Forms.Label()
        Me.btnUpdTransac = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.tbxOnGPerson = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.tbxOnGName = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cbxOnGStatus = New System.Windows.Forms.ComboBox()
        Me.tbxOnGTour = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.tbxOnGTotal = New System.Windows.Forms.TextBox()
        Me.tbxOnGTime = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.tbxTransacID = New System.Windows.Forms.TextBox()
        Me.lblTodayTransac = New System.Windows.Forms.Label()
        Me.lblTodayWaiting = New System.Windows.Forms.Label()
        Me.lblTodayOngoing = New System.Windows.Forms.Label()
        Me.lblTodayDone = New System.Windows.Forms.Label()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTransactions.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxTransacFilter
        '
        Me.cbxTransacFilter.BackColor = System.Drawing.Color.White
        Me.cbxTransacFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxTransacFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTransacFilter.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTransacFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.cbxTransacFilter.FormattingEnabled = True
        Me.cbxTransacFilter.ItemHeight = 18
        Me.cbxTransacFilter.Items.AddRange(New Object() {"ALL", "WAITING", "ONGOING", "TODAY"})
        Me.cbxTransacFilter.Location = New System.Drawing.Point(925, 18)
        Me.cbxTransacFilter.Name = "cbxTransacFilter"
        Me.cbxTransacFilter.Size = New System.Drawing.Size(142, 26)
        Me.cbxTransacFilter.TabIndex = 65
        '
        'dgvTransactions
        '
        Me.dgvTransactions.AllowUserToAddRows = False
        Me.dgvTransactions.AllowUserToOrderColumns = True
        Me.dgvTransactions.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransactions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.dgvTransactions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvTransactions.EnableHeadersVisualStyles = False
        Me.dgvTransactions.GridColor = System.Drawing.Color.DimGray
        Me.dgvTransactions.Location = New System.Drawing.Point(30, 59)
        Me.dgvTransactions.MultiSelect = False
        Me.dgvTransactions.Name = "dgvTransactions"
        Me.dgvTransactions.ReadOnly = True
        Me.dgvTransactions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransactions.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTransactions.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvTransactions.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTransactions.ShowEditingIcon = False
        Me.dgvTransactions.Size = New System.Drawing.Size(1103, 304)
        Me.dgvTransactions.TabIndex = 95
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
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "TOUR NAME"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "DATE"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "TIME SLOT"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 110
        '
        'Column8
        '
        Me.Column8.HeaderText = "STATUS"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'btnViewTransac
        '
        Me.btnViewTransac.BackColor = System.Drawing.Color.Gainsboro
        Me.btnViewTransac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewTransac.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnViewTransac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewTransac.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewTransac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnViewTransac.Location = New System.Drawing.Point(1073, 18)
        Me.btnViewTransac.Name = "btnViewTransac"
        Me.btnViewTransac.Size = New System.Drawing.Size(60, 27)
        Me.btnViewTransac.TabIndex = 96
        Me.btnViewTransac.Text = "View"
        Me.btnViewTransac.UseVisualStyleBackColor = False
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
        Me.btnAddTransac.Location = New System.Drawing.Point(762, 176)
        Me.btnAddTransac.Name = "btnAddTransac"
        Me.btnAddTransac.Size = New System.Drawing.Size(204, 44)
        Me.btnAddTransac.TabIndex = 9
        Me.btnAddTransac.Text = "Confirm transaction"
        Me.btnAddTransac.UseVisualStyleBackColor = False
        '
        'tbxAddPerson
        '
        Me.tbxAddPerson.BackColor = System.Drawing.Color.White
        Me.tbxAddPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxAddPerson.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAddPerson.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxAddPerson.Location = New System.Drawing.Point(583, 122)
        Me.tbxAddPerson.MaxLength = 1
        Me.tbxAddPerson.Name = "tbxAddPerson"
        Me.tbxAddPerson.Size = New System.Drawing.Size(82, 30)
        Me.tbxAddPerson.TabIndex = 5
        Me.tbxAddPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Location = New System.Drawing.Point(580, 102)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 18)
        Me.Label11.TabIndex = 123
        Me.Label11.Text = "# OF PERSON:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label13.Location = New System.Drawing.Point(410, 102)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 18)
        Me.Label13.TabIndex = 120
        Me.Label13.Text = "TIME SLOT:"
        '
        'cbxAddTimeSlot
        '
        Me.cbxAddTimeSlot.BackColor = System.Drawing.Color.White
        Me.cbxAddTimeSlot.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbxAddTimeSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAddTimeSlot.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxAddTimeSlot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cbxAddTimeSlot.FormattingEnabled = True
        Me.cbxAddTimeSlot.ItemHeight = 22
        Me.cbxAddTimeSlot.Items.AddRange(New Object() {"MORNING", "AFTERNOON", "EVENING"})
        Me.cbxAddTimeSlot.Location = New System.Drawing.Point(413, 121)
        Me.cbxAddTimeSlot.Name = "cbxAddTimeSlot"
        Me.cbxAddTimeSlot.Size = New System.Drawing.Size(154, 30)
        Me.cbxAddTimeSlot.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label15.Location = New System.Drawing.Point(410, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 18)
        Me.Label15.TabIndex = 116
        Me.Label15.Text = "TOUR NAME:"
        '
        'cbxAddTour
        '
        Me.cbxAddTour.BackColor = System.Drawing.Color.White
        Me.cbxAddTour.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbxAddTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAddTour.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxAddTour.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cbxAddTour.FormattingEnabled = True
        Me.cbxAddTour.ItemHeight = 22
        Me.cbxAddTour.Location = New System.Drawing.Point(413, 51)
        Me.cbxAddTour.Name = "cbxAddTour"
        Me.cbxAddTour.Size = New System.Drawing.Size(252, 30)
        Me.cbxAddTour.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label16.Location = New System.Drawing.Point(54, 30)
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
        Me.Label17.Location = New System.Drawing.Point(410, 171)
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
        Me.tbxAddSname.Location = New System.Drawing.Point(57, 190)
        Me.tbxAddSname.Name = "tbxAddSname"
        Me.tbxAddSname.Size = New System.Drawing.Size(311, 30)
        Me.tbxAddSname.TabIndex = 2
        '
        'tbxAddTotal
        '
        Me.tbxAddTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbxAddTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxAddTotal.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxAddTotal.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAddTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.tbxAddTotal.Location = New System.Drawing.Point(413, 192)
        Me.tbxAddTotal.MaxLength = 11
        Me.tbxAddTotal.Name = "tbxAddTotal"
        Me.tbxAddTotal.ReadOnly = True
        Me.tbxAddTotal.Size = New System.Drawing.Size(252, 41)
        Me.tbxAddTotal.TabIndex = 6
        Me.tbxAddTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label18.Location = New System.Drawing.Point(54, 171)
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
        Me.tbxAddMName.Location = New System.Drawing.Point(57, 119)
        Me.tbxAddMName.Name = "tbxAddMName"
        Me.tbxAddMName.Size = New System.Drawing.Size(311, 30)
        Me.tbxAddMName.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label20.Location = New System.Drawing.Point(54, 100)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(92, 18)
        Me.Label20.TabIndex = 112
        Me.Label20.Text = "MIDDLE NAME:"
        '
        'tbxAddFName
        '
        Me.tbxAddFName.BackColor = System.Drawing.Color.White
        Me.tbxAddFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxAddFName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxAddFName.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAddFName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxAddFName.Location = New System.Drawing.Point(57, 51)
        Me.tbxAddFName.Name = "tbxAddFName"
        Me.tbxAddFName.Size = New System.Drawing.Size(311, 30)
        Me.tbxAddFName.TabIndex = 0
        '
        'tabTransactions
        '
        Me.tabTransactions.Controls.Add(Me.TabPage1)
        Me.tabTransactions.Controls.Add(Me.TabPage5)
        Me.tabTransactions.Controls.Add(Me.TabPage2)
        Me.tabTransactions.Controls.Add(Me.TabPage4)
        Me.tabTransactions.Controls.Add(Me.TabPage3)
        Me.tabTransactions.Location = New System.Drawing.Point(45, 386)
        Me.tabTransactions.Name = "tabTransactions"
        Me.tabTransactions.SelectedIndex = 0
        Me.tabTransactions.Size = New System.Drawing.Size(1074, 313)
        Me.tabTransactions.TabIndex = 127
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Label37)
        Me.TabPage1.Controls.Add(Me.lblTransacPesoSign)
        Me.TabPage1.Controls.Add(Me.lblClearAdd)
        Me.TabPage1.Controls.Add(Me.cbxAddTourGuide)
        Me.TabPage1.Controls.Add(Me.Label38)
        Me.TabPage1.Controls.Add(Me.tbxAddPerson)
        Me.TabPage1.Controls.Add(Me.tbxAddFName)
        Me.TabPage1.Controls.Add(Me.cbxAddAtv)
        Me.TabPage1.Controls.Add(Me.Label11)
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
        Me.TabPage1.Text = "  Walk-in Transaction   "
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label37.Location = New System.Drawing.Point(694, 95)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(79, 18)
        Me.Label37.TabIndex = 1010
        Me.Label37.Text = "TOUR GUIDE:"
        '
        'lblTransacPesoSign
        '
        Me.lblTransacPesoSign.AutoSize = True
        Me.lblTransacPesoSign.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTransacPesoSign.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransacPesoSign.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.lblTransacPesoSign.Location = New System.Drawing.Point(417, 194)
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
        Me.lblClearAdd.Location = New System.Drawing.Point(825, 232)
        Me.lblClearAdd.Name = "lblClearAdd"
        Me.lblClearAdd.Size = New System.Drawing.Size(75, 18)
        Me.lblClearAdd.TabIndex = 10
        Me.lblClearAdd.Text = "Clear Form"
        '
        'cbxAddTourGuide
        '
        Me.cbxAddTourGuide.BackColor = System.Drawing.Color.White
        Me.cbxAddTourGuide.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbxAddTourGuide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAddTourGuide.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxAddTourGuide.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cbxAddTourGuide.FormattingEnabled = True
        Me.cbxAddTourGuide.ItemHeight = 22
        Me.cbxAddTourGuide.Location = New System.Drawing.Point(697, 116)
        Me.cbxAddTourGuide.Name = "cbxAddTourGuide"
        Me.cbxAddTourGuide.Size = New System.Drawing.Size(311, 30)
        Me.cbxAddTourGuide.TabIndex = 8
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label38.Location = New System.Drawing.Point(694, 31)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(34, 18)
        Me.Label38.TabIndex = 1008
        Me.Label38.Text = "ATV:"
        '
        'cbxAddAtv
        '
        Me.cbxAddAtv.BackColor = System.Drawing.Color.White
        Me.cbxAddAtv.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbxAddAtv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAddAtv.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxAddAtv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cbxAddAtv.FormattingEnabled = True
        Me.cbxAddAtv.ItemHeight = 22
        Me.cbxAddAtv.Location = New System.Drawing.Point(697, 52)
        Me.cbxAddAtv.Name = "cbxAddAtv"
        Me.cbxAddAtv.Size = New System.Drawing.Size(311, 30)
        Me.cbxAddAtv.TabIndex = 7
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TabPage5.Controls.Add(Me.lblClearNew)
        Me.TabPage5.Controls.Add(Me.Label5)
        Me.TabPage5.Controls.Add(Me.tbxNewPerson)
        Me.TabPage5.Controls.Add(Me.Label19)
        Me.TabPage5.Controls.Add(Me.tbxNewFName)
        Me.TabPage5.Controls.Add(Me.Label21)
        Me.TabPage5.Controls.Add(Me.Label22)
        Me.TabPage5.Controls.Add(Me.cbxNewTimeSlot)
        Me.TabPage5.Controls.Add(Me.cbxNewStatus)
        Me.TabPage5.Controls.Add(Me.tbxNewMName)
        Me.TabPage5.Controls.Add(Me.Label23)
        Me.TabPage5.Controls.Add(Me.Label24)
        Me.TabPage5.Controls.Add(Me.Label25)
        Me.TabPage5.Controls.Add(Me.tbxNewTotal)
        Me.TabPage5.Controls.Add(Me.cbxNewTour)
        Me.TabPage5.Controls.Add(Me.tbxNewSName)
        Me.TabPage5.Controls.Add(Me.Label26)
        Me.TabPage5.Controls.Add(Me.Label27)
        Me.TabPage5.Controls.Add(Me.btnAddRes)
        Me.TabPage5.Controls.Add(Me.dateTimeNew)
        Me.TabPage5.Controls.Add(Me.Label12)
        Me.TabPage5.Location = New System.Drawing.Point(4, 29)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1066, 280)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "  Add Reservation   "
        '
        'lblClearNew
        '
        Me.lblClearNew.AutoSize = True
        Me.lblClearNew.BackColor = System.Drawing.Color.Transparent
        Me.lblClearNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClearNew.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearNew.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblClearNew.Location = New System.Drawing.Point(850, 204)
        Me.lblClearNew.Name = "lblClearNew"
        Me.lblClearNew.Size = New System.Drawing.Size(0, 18)
        Me.lblClearNew.TabIndex = 148
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(750, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 37)
        Me.Label5.TabIndex = 147
        '
        'tbxNewPerson
        '
        Me.tbxNewPerson.BackColor = System.Drawing.Color.White
        Me.tbxNewPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxNewPerson.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNewPerson.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxNewPerson.Location = New System.Drawing.Point(584, 122)
        Me.tbxNewPerson.MaxLength = 1
        Me.tbxNewPerson.Name = "tbxNewPerson"
        Me.tbxNewPerson.Size = New System.Drawing.Size(82, 30)
        Me.tbxNewPerson.TabIndex = 146
        Me.tbxNewPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label19.Location = New System.Drawing.Point(581, 102)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(0, 18)
        Me.Label19.TabIndex = 145
        '
        'tbxNewFName
        '
        Me.tbxNewFName.BackColor = System.Drawing.Color.White
        Me.tbxNewFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxNewFName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxNewFName.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNewFName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxNewFName.Location = New System.Drawing.Point(63, 58)
        Me.tbxNewFName.Name = "tbxNewFName"
        Me.tbxNewFName.Size = New System.Drawing.Size(311, 30)
        Me.tbxNewFName.TabIndex = 136
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label21.Location = New System.Drawing.Point(418, 168)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(0, 18)
        Me.Label21.TabIndex = 143
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label22.Location = New System.Drawing.Point(60, 104)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(0, 18)
        Me.Label22.TabIndex = 137
        '
        'cbxNewTimeSlot
        '
        Me.cbxNewTimeSlot.BackColor = System.Drawing.Color.White
        Me.cbxNewTimeSlot.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbxNewTimeSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxNewTimeSlot.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxNewTimeSlot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cbxNewTimeSlot.FormattingEnabled = True
        Me.cbxNewTimeSlot.ItemHeight = 22
        Me.cbxNewTimeSlot.Items.AddRange(New Object() {"MORNING", "AFTERNOON", "EVENING"})
        Me.cbxNewTimeSlot.Location = New System.Drawing.Point(421, 187)
        Me.cbxNewTimeSlot.Name = "cbxNewTimeSlot"
        Me.cbxNewTimeSlot.Size = New System.Drawing.Size(116, 30)
        Me.cbxNewTimeSlot.TabIndex = 144
        '
        'cbxNewStatus
        '
        Me.cbxNewStatus.BackColor = System.Drawing.Color.White
        Me.cbxNewStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbxNewStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxNewStatus.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxNewStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cbxNewStatus.FormattingEnabled = True
        Me.cbxNewStatus.ItemHeight = 22
        Me.cbxNewStatus.Items.AddRange(New Object() {"PENDING", "CANCELED"})
        Me.cbxNewStatus.Location = New System.Drawing.Point(557, 187)
        Me.cbxNewStatus.Name = "cbxNewStatus"
        Me.cbxNewStatus.Size = New System.Drawing.Size(109, 30)
        Me.cbxNewStatus.TabIndex = 134
        '
        'tbxNewMName
        '
        Me.tbxNewMName.BackColor = System.Drawing.Color.White
        Me.tbxNewMName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxNewMName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxNewMName.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNewMName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxNewMName.Location = New System.Drawing.Point(63, 123)
        Me.tbxNewMName.Name = "tbxNewMName"
        Me.tbxNewMName.Size = New System.Drawing.Size(311, 30)
        Me.tbxNewMName.TabIndex = 138
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label23.Location = New System.Drawing.Point(554, 168)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(0, 18)
        Me.Label23.TabIndex = 133
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label24.Location = New System.Drawing.Point(60, 168)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(0, 18)
        Me.Label24.TabIndex = 139
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label25.Location = New System.Drawing.Point(418, 39)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(0, 18)
        Me.Label25.TabIndex = 141
        '
        'tbxNewTotal
        '
        Me.tbxNewTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbxNewTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxNewTotal.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxNewTotal.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNewTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.tbxNewTotal.Location = New System.Drawing.Point(746, 81)
        Me.tbxNewTotal.MaxLength = 11
        Me.tbxNewTotal.Name = "tbxNewTotal"
        Me.tbxNewTotal.ReadOnly = True
        Me.tbxNewTotal.Size = New System.Drawing.Size(272, 41)
        Me.tbxNewTotal.TabIndex = 132
        Me.tbxNewTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbxNewTour
        '
        Me.cbxNewTour.BackColor = System.Drawing.Color.White
        Me.cbxNewTour.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbxNewTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxNewTour.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxNewTour.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cbxNewTour.FormattingEnabled = True
        Me.cbxNewTour.ItemHeight = 22
        Me.cbxNewTour.Location = New System.Drawing.Point(421, 58)
        Me.cbxNewTour.Name = "cbxNewTour"
        Me.cbxNewTour.Size = New System.Drawing.Size(256, 30)
        Me.cbxNewTour.TabIndex = 142
        '
        'tbxNewSName
        '
        Me.tbxNewSName.BackColor = System.Drawing.Color.White
        Me.tbxNewSName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxNewSName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxNewSName.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNewSName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxNewSName.Location = New System.Drawing.Point(63, 187)
        Me.tbxNewSName.Name = "tbxNewSName"
        Me.tbxNewSName.Size = New System.Drawing.Size(311, 30)
        Me.tbxNewSName.TabIndex = 140
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label26.Location = New System.Drawing.Point(60, 39)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(0, 18)
        Me.Label26.TabIndex = 135
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label27.Location = New System.Drawing.Point(743, 60)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(0, 18)
        Me.Label27.TabIndex = 131
        '
        'btnAddRes
        '
        Me.btnAddRes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddRes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnAddRes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddRes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnAddRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRes.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnAddRes.Location = New System.Drawing.Point(824, 143)
        Me.btnAddRes.Name = "btnAddRes"
        Me.btnAddRes.Size = New System.Drawing.Size(121, 44)
        Me.btnAddRes.TabIndex = 130
        Me.btnAddRes.Text = "Add"
        Me.btnAddRes.UseVisualStyleBackColor = False
        '
        'dateTimeNew
        '
        Me.dateTimeNew.CalendarForeColor = System.Drawing.Color.WhiteSmoke
        Me.dateTimeNew.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.dateTimeNew.Checked = False
        Me.dateTimeNew.CustomFormat = "MM-dd-yyyy"
        Me.dateTimeNew.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimeNew.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateTimeNew.Location = New System.Drawing.Point(421, 124)
        Me.dateTimeNew.Name = "dateTimeNew"
        Me.dateTimeNew.Size = New System.Drawing.Size(141, 26)
        Me.dateTimeNew.TabIndex = 109
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Location = New System.Drawing.Point(418, 103)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 18)
        Me.Label12.TabIndex = 122
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.lblUpdReservID)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.lblClearUpd)
        Me.TabPage2.Controls.Add(Me.tbxReservPerson)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.tbxReservFName)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.dateTimeReserv)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.cbxReservTimeSlot)
        Me.TabPage2.Controls.Add(Me.cbxReservStatus)
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
        Me.TabPage2.Text = "  Update Reservation   "
        '
        'lblUpdReservID
        '
        Me.lblUpdReservID.BackColor = System.Drawing.Color.Transparent
        Me.lblUpdReservID.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdReservID.ForeColor = System.Drawing.Color.LightGray
        Me.lblUpdReservID.Location = New System.Drawing.Point(791, 259)
        Me.lblUpdReservID.Margin = New System.Windows.Forms.Padding(0)
        Me.lblUpdReservID.Name = "lblUpdReservID"
        Me.lblUpdReservID.Size = New System.Drawing.Size(272, 18)
        Me.lblUpdReservID.TabIndex = 137
        Me.lblUpdReservID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(727, 83)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 37)
        Me.Label14.TabIndex = 129
        '
        'lblClearUpd
        '
        Me.lblClearUpd.AutoSize = True
        Me.lblClearUpd.BackColor = System.Drawing.Color.Transparent
        Me.lblClearUpd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClearUpd.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearUpd.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblClearUpd.Location = New System.Drawing.Point(825, 212)
        Me.lblClearUpd.Name = "lblClearUpd"
        Me.lblClearUpd.Size = New System.Drawing.Size(0, 18)
        Me.lblClearUpd.TabIndex = 126
        '
        'tbxReservPerson
        '
        Me.tbxReservPerson.BackColor = System.Drawing.Color.White
        Me.tbxReservPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxReservPerson.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxReservPerson.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxReservPerson.Location = New System.Drawing.Point(588, 124)
        Me.tbxReservPerson.MaxLength = 1
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
        Me.Label10.Location = New System.Drawing.Point(585, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 18)
        Me.Label10.TabIndex = 123
        '
        'tbxReservFName
        '
        Me.tbxReservFName.BackColor = System.Drawing.Color.White
        Me.tbxReservFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxReservFName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxReservFName.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxReservFName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxReservFName.Location = New System.Drawing.Point(56, 59)
        Me.tbxReservFName.Name = "tbxReservFName"
        Me.tbxReservFName.Size = New System.Drawing.Size(311, 30)
        Me.tbxReservFName.TabIndex = 111
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(415, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 18)
        Me.Label9.TabIndex = 122
        '
        'dateTimeReserv
        '
        Me.dateTimeReserv.CalendarForeColor = System.Drawing.Color.WhiteSmoke
        Me.dateTimeReserv.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.dateTimeReserv.Checked = False
        Me.dateTimeReserv.CustomFormat = "MM-dd-yyyy"
        Me.dateTimeReserv.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimeReserv.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateTimeReserv.Location = New System.Drawing.Point(418, 124)
        Me.dateTimeReserv.Name = "dateTimeReserv"
        Me.dateTimeReserv.Size = New System.Drawing.Size(163, 26)
        Me.dateTimeReserv.TabIndex = 109
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(415, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 18)
        Me.Label7.TabIndex = 120
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(53, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 18)
        Me.Label2.TabIndex = 112
        '
        'cbxReservTimeSlot
        '
        Me.cbxReservTimeSlot.BackColor = System.Drawing.Color.White
        Me.cbxReservTimeSlot.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbxReservTimeSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxReservTimeSlot.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxReservTimeSlot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cbxReservTimeSlot.FormattingEnabled = True
        Me.cbxReservTimeSlot.ItemHeight = 22
        Me.cbxReservTimeSlot.Items.AddRange(New Object() {"MORNING", "AFTERNOON", "EVENING"})
        Me.cbxReservTimeSlot.Location = New System.Drawing.Point(418, 188)
        Me.cbxReservTimeSlot.Name = "cbxReservTimeSlot"
        Me.cbxReservTimeSlot.Size = New System.Drawing.Size(121, 30)
        Me.cbxReservTimeSlot.TabIndex = 121
        '
        'cbxReservStatus
        '
        Me.cbxReservStatus.BackColor = System.Drawing.Color.White
        Me.cbxReservStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbxReservStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxReservStatus.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxReservStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cbxReservStatus.FormattingEnabled = True
        Me.cbxReservStatus.ItemHeight = 22
        Me.cbxReservStatus.Items.AddRange(New Object() {"PENDING", "ONGOING", "CANCELED"})
        Me.cbxReservStatus.Location = New System.Drawing.Point(549, 188)
        Me.cbxReservStatus.Name = "cbxReservStatus"
        Me.cbxReservStatus.Size = New System.Drawing.Size(121, 30)
        Me.cbxReservStatus.TabIndex = 104
        '
        'tbxReservMName
        '
        Me.tbxReservMName.BackColor = System.Drawing.Color.White
        Me.tbxReservMName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxReservMName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxReservMName.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxReservMName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxReservMName.Location = New System.Drawing.Point(56, 124)
        Me.tbxReservMName.Name = "tbxReservMName"
        Me.tbxReservMName.Size = New System.Drawing.Size(311, 30)
        Me.tbxReservMName.TabIndex = 113
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
        Me.btnUpdRes.Location = New System.Drawing.Point(798, 153)
        Me.btnUpdRes.Name = "btnUpdRes"
        Me.btnUpdRes.Size = New System.Drawing.Size(121, 44)
        Me.btnUpdRes.TabIndex = 106
        Me.btnUpdRes.Text = "Update"
        Me.btnUpdRes.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(546, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 18)
        Me.Label8.TabIndex = 103
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(53, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 18)
        Me.Label3.TabIndex = 114
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(415, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 18)
        Me.Label4.TabIndex = 116
        '
        'tbxReservTotal
        '
        Me.tbxReservTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbxReservTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxReservTotal.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxReservTotal.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxReservTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.tbxReservTotal.Location = New System.Drawing.Point(723, 81)
        Me.tbxReservTotal.MaxLength = 11
        Me.tbxReservTotal.Name = "tbxReservTotal"
        Me.tbxReservTotal.ReadOnly = True
        Me.tbxReservTotal.Size = New System.Drawing.Size(286, 41)
        Me.tbxReservTotal.TabIndex = 999
        Me.tbxReservTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.cbxReservTour.Location = New System.Drawing.Point(418, 59)
        Me.cbxReservTour.Name = "cbxReservTour"
        Me.cbxReservTour.Size = New System.Drawing.Size(252, 30)
        Me.cbxReservTour.TabIndex = 117
        '
        'tbxReservSName
        '
        Me.tbxReservSName.BackColor = System.Drawing.Color.White
        Me.tbxReservSName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxReservSName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxReservSName.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxReservSName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxReservSName.Location = New System.Drawing.Point(56, 188)
        Me.tbxReservSName.Name = "tbxReservSName"
        Me.tbxReservSName.Size = New System.Drawing.Size(311, 30)
        Me.tbxReservSName.TabIndex = 115
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(53, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 18)
        Me.Label1.TabIndex = 110
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(720, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 18)
        Me.Label6.TabIndex = 99
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1066, 280)
        Me.TabPage4.TabIndex = 5
        Me.TabPage4.Text = "  Waiting List   "
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.Label34)
        Me.TabPage3.Controls.Add(Me.cbxOnGTourGuide)
        Me.TabPage3.Controls.Add(Me.Label30)
        Me.TabPage3.Controls.Add(Me.cbxOnGAtv)
        Me.TabPage3.Controls.Add(Me.lblClearTransac)
        Me.TabPage3.Controls.Add(Me.btnUpdTransac)
        Me.TabPage3.Controls.Add(Me.Label28)
        Me.TabPage3.Controls.Add(Me.tbxOnGPerson)
        Me.TabPage3.Controls.Add(Me.Label29)
        Me.TabPage3.Controls.Add(Me.tbxOnGName)
        Me.TabPage3.Controls.Add(Me.Label31)
        Me.TabPage3.Controls.Add(Me.cbxOnGStatus)
        Me.TabPage3.Controls.Add(Me.tbxOnGTour)
        Me.TabPage3.Controls.Add(Me.Label32)
        Me.TabPage3.Controls.Add(Me.Label33)
        Me.TabPage3.Controls.Add(Me.tbxOnGTotal)
        Me.TabPage3.Controls.Add(Me.tbxOnGTime)
        Me.TabPage3.Controls.Add(Me.Label35)
        Me.TabPage3.Controls.Add(Me.Label36)
        Me.TabPage3.Controls.Add(Me.tbxTransacID)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1066, 280)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "  Ongoing Transactions   "
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label34.Location = New System.Drawing.Point(440, 95)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(79, 18)
        Me.Label34.TabIndex = 1006
        Me.Label34.Text = "TOUR GUIDE:"
        '
        'cbxOnGTourGuide
        '
        Me.cbxOnGTourGuide.BackColor = System.Drawing.Color.White
        Me.cbxOnGTourGuide.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbxOnGTourGuide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxOnGTourGuide.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxOnGTourGuide.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cbxOnGTourGuide.FormattingEnabled = True
        Me.cbxOnGTourGuide.ItemHeight = 22
        Me.cbxOnGTourGuide.Location = New System.Drawing.Point(443, 116)
        Me.cbxOnGTourGuide.Name = "cbxOnGTourGuide"
        Me.cbxOnGTourGuide.Size = New System.Drawing.Size(317, 30)
        Me.cbxOnGTourGuide.TabIndex = 5
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label30.Location = New System.Drawing.Point(440, 31)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(34, 18)
        Me.Label30.TabIndex = 1004
        Me.Label30.Text = "ATV:"
        '
        'cbxOnGAtv
        '
        Me.cbxOnGAtv.BackColor = System.Drawing.Color.White
        Me.cbxOnGAtv.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbxOnGAtv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxOnGAtv.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxOnGAtv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cbxOnGAtv.FormattingEnabled = True
        Me.cbxOnGAtv.ItemHeight = 22
        Me.cbxOnGAtv.Location = New System.Drawing.Point(443, 52)
        Me.cbxOnGAtv.Name = "cbxOnGAtv"
        Me.cbxOnGAtv.Size = New System.Drawing.Size(317, 30)
        Me.cbxOnGAtv.TabIndex = 4
        '
        'lblClearTransac
        '
        Me.lblClearTransac.AutoSize = True
        Me.lblClearTransac.BackColor = System.Drawing.Color.Transparent
        Me.lblClearTransac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClearTransac.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearTransac.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblClearTransac.Location = New System.Drawing.Point(878, 202)
        Me.lblClearTransac.Name = "lblClearTransac"
        Me.lblClearTransac.Size = New System.Drawing.Size(75, 18)
        Me.lblClearTransac.TabIndex = 9
        Me.lblClearTransac.Text = "Clear Form"
        '
        'btnUpdTransac
        '
        Me.btnUpdTransac.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnUpdTransac.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUpdTransac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdTransac.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnUpdTransac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdTransac.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdTransac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnUpdTransac.Location = New System.Drawing.Point(724, 187)
        Me.btnUpdTransac.Name = "btnUpdTransac"
        Me.btnUpdTransac.Size = New System.Drawing.Size(133, 44)
        Me.btnUpdTransac.TabIndex = 8
        Me.btnUpdTransac.Text = "End Trail"
        Me.btnUpdTransac.UseVisualStyleBackColor = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label28.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(812, 54)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(24, 24)
        Me.Label28.TabIndex = 166
        Me.Label28.Text = "₱"
        '
        'tbxOnGPerson
        '
        Me.tbxOnGPerson.BackColor = System.Drawing.Color.White
        Me.tbxOnGPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxOnGPerson.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxOnGPerson.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxOnGPerson.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxOnGPerson.Location = New System.Drawing.Point(230, 187)
        Me.tbxOnGPerson.MaxLength = 1
        Me.tbxOnGPerson.Name = "tbxOnGPerson"
        Me.tbxOnGPerson.ReadOnly = True
        Me.tbxOnGPerson.Size = New System.Drawing.Size(82, 30)
        Me.tbxOnGPerson.TabIndex = 3
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label29.Location = New System.Drawing.Point(227, 166)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(85, 18)
        Me.Label29.TabIndex = 164
        Me.Label29.Text = "# OF PERSON:"
        '
        'tbxOnGName
        '
        Me.tbxOnGName.BackColor = System.Drawing.Color.White
        Me.tbxOnGName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxOnGName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxOnGName.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxOnGName.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxOnGName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxOnGName.Location = New System.Drawing.Point(52, 51)
        Me.tbxOnGName.Name = "tbxOnGName"
        Me.tbxOnGName.ReadOnly = True
        Me.tbxOnGName.Size = New System.Drawing.Size(348, 30)
        Me.tbxOnGName.TabIndex = 0
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label31.Location = New System.Drawing.Point(49, 95)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(78, 18)
        Me.Label31.TabIndex = 156
        Me.Label31.Text = "TOUR NAME:"
        '
        'cbxOnGStatus
        '
        Me.cbxOnGStatus.BackColor = System.Drawing.Color.White
        Me.cbxOnGStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbxOnGStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxOnGStatus.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxOnGStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cbxOnGStatus.FormattingEnabled = True
        Me.cbxOnGStatus.ItemHeight = 22
        Me.cbxOnGStatus.Items.AddRange(New Object() {"ONGOING", "DONE"})
        Me.cbxOnGStatus.Location = New System.Drawing.Point(808, 116)
        Me.cbxOnGStatus.Name = "cbxOnGStatus"
        Me.cbxOnGStatus.Size = New System.Drawing.Size(186, 30)
        Me.cbxOnGStatus.TabIndex = 7
        '
        'tbxOnGTour
        '
        Me.tbxOnGTour.BackColor = System.Drawing.Color.White
        Me.tbxOnGTour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxOnGTour.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxOnGTour.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxOnGTour.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxOnGTour.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxOnGTour.Location = New System.Drawing.Point(52, 116)
        Me.tbxOnGTour.Name = "tbxOnGTour"
        Me.tbxOnGTour.ReadOnly = True
        Me.tbxOnGTour.Size = New System.Drawing.Size(348, 30)
        Me.tbxOnGTour.TabIndex = 1
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label32.Location = New System.Drawing.Point(805, 95)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(52, 18)
        Me.Label32.TabIndex = 152
        Me.Label32.Text = "STATUS:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label33.Location = New System.Drawing.Point(49, 166)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(70, 18)
        Me.Label33.TabIndex = 158
        Me.Label33.Text = "TIME SLOT:"
        '
        'tbxOnGTotal
        '
        Me.tbxOnGTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbxOnGTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxOnGTotal.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxOnGTotal.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxOnGTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxOnGTotal.Location = New System.Drawing.Point(808, 52)
        Me.tbxOnGTotal.MaxLength = 11
        Me.tbxOnGTotal.Name = "tbxOnGTotal"
        Me.tbxOnGTotal.ReadOnly = True
        Me.tbxOnGTotal.Size = New System.Drawing.Size(186, 30)
        Me.tbxOnGTotal.TabIndex = 6
        Me.tbxOnGTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbxOnGTime
        '
        Me.tbxOnGTime.BackColor = System.Drawing.Color.White
        Me.tbxOnGTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxOnGTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxOnGTime.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxOnGTime.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxOnGTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxOnGTime.Location = New System.Drawing.Point(52, 187)
        Me.tbxOnGTime.Name = "tbxOnGTime"
        Me.tbxOnGTime.ReadOnly = True
        Me.tbxOnGTime.Size = New System.Drawing.Size(153, 30)
        Me.tbxOnGTime.TabIndex = 2
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label35.Location = New System.Drawing.Point(49, 30)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(71, 18)
        Me.Label35.TabIndex = 154
        Me.Label35.Text = "CUSTOMER:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label36.Location = New System.Drawing.Point(805, 31)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(82, 18)
        Me.Label36.TabIndex = 150
        Me.Label36.Text = "TOTAL PRICE:"
        '
        'tbxTransacID
        '
        Me.tbxTransacID.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.tbxTransacID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxTransacID.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxTransacID.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxTransacID.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tbxTransacID.Location = New System.Drawing.Point(808, 260)
        Me.tbxTransacID.MaxLength = 11
        Me.tbxTransacID.Name = "tbxTransacID"
        Me.tbxTransacID.ReadOnly = True
        Me.tbxTransacID.Size = New System.Drawing.Size(252, 14)
        Me.tbxTransacID.TabIndex = 130
        Me.tbxTransacID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTodayTransac
        '
        Me.lblTodayTransac.BackColor = System.Drawing.Color.Transparent
        Me.lblTodayTransac.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodayTransac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.lblTodayTransac.Location = New System.Drawing.Point(424, 9)
        Me.lblTodayTransac.Name = "lblTodayTransac"
        Me.lblTodayTransac.Size = New System.Drawing.Size(290, 20)
        Me.lblTodayTransac.TabIndex = 129
        Me.lblTodayTransac.Text = "TOTAL TRANSACTION TODAY:"
        Me.lblTodayTransac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTodayWaiting
        '
        Me.lblTodayWaiting.AutoSize = True
        Me.lblTodayWaiting.BackColor = System.Drawing.Color.Transparent
        Me.lblTodayWaiting.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodayWaiting.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTodayWaiting.Location = New System.Drawing.Point(423, 31)
        Me.lblTodayWaiting.Name = "lblTodayWaiting"
        Me.lblTodayWaiting.Size = New System.Drawing.Size(72, 18)
        Me.lblTodayWaiting.TabIndex = 130
        Me.lblTodayWaiting.Text = "Waiting: 0"
        '
        'lblTodayOngoing
        '
        Me.lblTodayOngoing.AutoSize = True
        Me.lblTodayOngoing.BackColor = System.Drawing.Color.Transparent
        Me.lblTodayOngoing.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodayOngoing.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTodayOngoing.Location = New System.Drawing.Point(526, 31)
        Me.lblTodayOngoing.Name = "lblTodayOngoing"
        Me.lblTodayOngoing.Size = New System.Drawing.Size(75, 18)
        Me.lblTodayOngoing.TabIndex = 131
        Me.lblTodayOngoing.Text = "Ongoing: 0"
        '
        'lblTodayDone
        '
        Me.lblTodayDone.AutoSize = True
        Me.lblTodayDone.BackColor = System.Drawing.Color.Transparent
        Me.lblTodayDone.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodayDone.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTodayDone.Location = New System.Drawing.Point(642, 31)
        Me.lblTodayDone.Name = "lblTodayDone"
        Me.lblTodayDone.Size = New System.Drawing.Size(55, 18)
        Me.lblTodayDone.TabIndex = 132
        Me.lblTodayDone.Text = "Done: 0"
        '
        'ctrlTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.lblTodayDone)
        Me.Controls.Add(Me.lblTodayOngoing)
        Me.Controls.Add(Me.lblTodayWaiting)
        Me.Controls.Add(Me.lblTodayTransac)
        Me.Controls.Add(Me.tabTransactions)
        Me.Controls.Add(Me.btnViewTransac)
        Me.Controls.Add(Me.cbxTransacFilter)
        Me.Controls.Add(Me.dgvTransactions)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ctrlTransactions"
        Me.Size = New System.Drawing.Size(1161, 738)
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTransactions.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxTransacFilter As ComboBox
    Friend WithEvents dgvTransactions As DataGridView
    Friend WithEvents btnViewTransac As Button
    Friend WithEvents btnAddTransac As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents tabTransactions As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lblClearAdd As Label
    Friend WithEvents tbxAddPerson As TextBox
    Friend WithEvents cbxAddTimeSlot As ComboBox
    Friend WithEvents cbxAddTour As ComboBox
    Friend WithEvents tbxAddSname As TextBox
    Friend WithEvents tbxAddTotal As TextBox
    Friend WithEvents tbxAddMName As TextBox
    Friend WithEvents tbxAddFName As TextBox
    Friend WithEvents lblTransacPesoSign As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents tbxTransacID As TextBox
    Friend WithEvents lblTodayTransac As Label
    Friend WithEvents lblTodayWaiting As Label
    Friend WithEvents lblTodayOngoing As Label
    Friend WithEvents lblTodayDone As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents tbxOnGPerson As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents tbxOnGName As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents cbxOnGStatus As ComboBox
    Friend WithEvents tbxOnGTour As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents tbxOnGTotal As TextBox
    Friend WithEvents tbxOnGTime As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents lblClearTransac As Label
    Friend WithEvents btnUpdTransac As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Label34 As Label
    Friend WithEvents cbxOnGTourGuide As ComboBox
    Friend WithEvents Label30 As Label
    Friend WithEvents cbxOnGAtv As ComboBox
    Friend WithEvents Label37 As Label
    Friend WithEvents cbxAddTourGuide As ComboBox
    Friend WithEvents Label38 As Label
    Friend WithEvents cbxAddAtv As ComboBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents lblClearNew As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbxNewPerson As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents tbxNewFName As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents cbxNewTimeSlot As ComboBox
    Friend WithEvents cbxNewStatus As ComboBox
    Friend WithEvents tbxNewMName As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents tbxNewTotal As TextBox
    Friend WithEvents cbxNewTour As ComboBox
    Friend WithEvents tbxNewSName As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents btnAddRes As Button
    Friend WithEvents dateTimeNew As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lblUpdReservID As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblClearUpd As Label
    Friend WithEvents tbxReservPerson As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbxReservFName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dateTimeReserv As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxReservTimeSlot As ComboBox
    Friend WithEvents cbxReservStatus As ComboBox
    Friend WithEvents tbxReservMName As TextBox
    Friend WithEvents btnUpdRes As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbxReservTotal As TextBox
    Friend WithEvents cbxReservTour As ComboBox
    Friend WithEvents tbxReservSName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
End Class
