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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvTransactions = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabTransactions = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cbxAddTimeSlot = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblTourPrice = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbxAddPerson = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblClearAdd = New System.Windows.Forms.Label()
        Me.btnAddAtv = New System.Windows.Forms.Button()
        Me.tbxAddFName = New System.Windows.Forms.TextBox()
        Me.tbxAddMName = New System.Windows.Forms.TextBox()
        Me.cbxAddTourGuide = New System.Windows.Forms.ComboBox()
        Me.btnAddConfirm = New System.Windows.Forms.Button()
        Me.cbxAddTour = New System.Windows.Forms.ComboBox()
        Me.tbxAddTotal = New System.Windows.Forms.TextBox()
        Me.tbxAddSname = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbxAddInitPayment = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbxAddChange = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbxAddNewPayment = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblWaitID = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.tbxWaitBalance = New System.Windows.Forms.TextBox()
        Me.tbxWaitTour = New System.Windows.Forms.TextBox()
        Me.tbxWaitSname = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbxWaitMName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnStartTrail = New System.Windows.Forms.Button()
        Me.btnWaitAtv = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxWaitTourGuide = New System.Windows.Forms.ComboBox()
        Me.lblWaitClear = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxWaitPerson = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbxWaitFName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbxWaitTotPrice = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lblTransacID = New System.Windows.Forms.Label()
        Me.tbxOnGTrailDate = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.tbxOnGTourPrice = New System.Windows.Forms.TextBox()
        Me.tbxOnGTourGuide = New System.Windows.Forms.TextBox()
        Me.btnOnGViewAtv = New System.Windows.Forms.Button()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.lblOnGClear = New System.Windows.Forms.Label()
        Me.btnEndTrail = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.tbxOnGPerson = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.tbxOnGName = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.tbxOnGTour = New System.Windows.Forms.TextBox()
        Me.tbxOnGTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.lblTodayTransac = New System.Windows.Forms.Label()
        Me.lblWaiting = New System.Windows.Forms.Label()
        Me.lblOngoing = New System.Windows.Forms.Label()
        Me.dgvViewAtv = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTransactions.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvViewAtv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTransactions
        '
        Me.dgvTransactions.AllowUserToAddRows = False
        Me.dgvTransactions.AllowUserToOrderColumns = True
        Me.dgvTransactions.AllowUserToResizeColumns = False
        Me.dgvTransactions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTransactions.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransactions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.dgvTransactions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvTransactions.EnableHeadersVisualStyles = False
        Me.dgvTransactions.GridColor = System.Drawing.Color.DimGray
        Me.dgvTransactions.Location = New System.Drawing.Point(43, 75)
        Me.dgvTransactions.MultiSelect = False
        Me.dgvTransactions.Name = "dgvTransactions"
        Me.dgvTransactions.ReadOnly = True
        Me.dgvTransactions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransactions.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvTransactions.RowHeadersVisible = False
        Me.dgvTransactions.RowHeadersWidth = 51
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.dgvTransactions.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTransactions.ShowEditingIcon = False
        Me.dgvTransactions.Size = New System.Drawing.Size(1239, 335)
        Me.dgvTransactions.TabIndex = 95
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "CUSTOMER NAME"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "TOUR NAME"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 300
        '
        'Column6
        '
        Me.Column6.HeaderText = "DATE"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 200
        '
        'Column7
        '
        Me.Column7.HeaderText = "TIME SLOT"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 110
        '
        'Column8
        '
        Me.Column8.HeaderText = "STATUS"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 125
        '
        'tabTransactions
        '
        Me.tabTransactions.Controls.Add(Me.TabPage1)
        Me.tabTransactions.Controls.Add(Me.TabPage2)
        Me.tabTransactions.Controls.Add(Me.TabPage3)
        Me.tabTransactions.Location = New System.Drawing.Point(43, 440)
        Me.tabTransactions.Name = "tabTransactions"
        Me.tabTransactions.SelectedIndex = 0
        Me.tabTransactions.Size = New System.Drawing.Size(1239, 372)
        Me.tabTransactions.TabIndex = 127
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.cbxAddTimeSlot)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.lblTourPrice)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.cbxAddPerson)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.lblClearAdd)
        Me.TabPage1.Controls.Add(Me.btnAddAtv)
        Me.TabPage1.Controls.Add(Me.tbxAddFName)
        Me.TabPage1.Controls.Add(Me.tbxAddMName)
        Me.TabPage1.Controls.Add(Me.cbxAddTourGuide)
        Me.TabPage1.Controls.Add(Me.btnAddConfirm)
        Me.TabPage1.Controls.Add(Me.cbxAddTour)
        Me.TabPage1.Controls.Add(Me.tbxAddTotal)
        Me.TabPage1.Controls.Add(Me.tbxAddSname)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.tbxAddInitPayment)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.tbxAddChange)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.tbxAddNewPayment)
        Me.TabPage1.Controls.Add(Me.Label39)
        Me.TabPage1.Location = New System.Drawing.Point(4, 33)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1231, 335)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "  Walk-in Transaction   "
        '
        'cbxAddTimeSlot
        '
        Me.cbxAddTimeSlot.BackColor = System.Drawing.Color.White
        Me.cbxAddTimeSlot.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbxAddTimeSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAddTimeSlot.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbxAddTimeSlot.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxAddTimeSlot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cbxAddTimeSlot.FormattingEnabled = True
        Me.cbxAddTimeSlot.ItemHeight = 26
        Me.cbxAddTimeSlot.Items.AddRange(New Object() {"Morning", "Afternoon", "Evening"})
        Me.cbxAddTimeSlot.Location = New System.Drawing.Point(168, 270)
        Me.cbxAddTimeSlot.Name = "cbxAddTimeSlot"
        Me.cbxAddTimeSlot.Size = New System.Drawing.Size(103, 34)
        Me.cbxAddTimeSlot.TabIndex = 4
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label24.Location = New System.Drawing.Point(165, 249)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(88, 20)
        Me.Label24.TabIndex = 1036
        Me.Label24.Text = "TIME SLOT:"
        '
        'lblTourPrice
        '
        Me.lblTourPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTourPrice.AutoSize = True
        Me.lblTourPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblTourPrice.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTourPrice.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTourPrice.Location = New System.Drawing.Point(771, 26)
        Me.lblTourPrice.Name = "lblTourPrice"
        Me.lblTourPrice.Size = New System.Drawing.Size(42, 20)
        Me.lblTourPrice.TabIndex = 1034
        Me.lblTourPrice.Text = "0.00"
        Me.lblTourPrice.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(571, 194)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(30, 29)
        Me.Label23.TabIndex = 1033
        Me.Label23.Text = "₱"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.White
        Me.Label22.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(923, 122)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(30, 29)
        Me.Label22.TabIndex = 1032
        Me.Label22.Text = "₱"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(923, 49)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(30, 29)
        Me.Label21.TabIndex = 1031
        Me.Label21.Text = "₱"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(571, 272)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 43)
        Me.Label10.TabIndex = 1030
        Me.Label10.Text = "₱"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label17.Location = New System.Drawing.Point(68, 173)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 20)
        Me.Label17.TabIndex = 1021
        Me.Label17.Text = "SURNAME:"
        '
        'cbxAddPerson
        '
        Me.cbxAddPerson.BackColor = System.Drawing.Color.White
        Me.cbxAddPerson.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbxAddPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbxAddPerson.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxAddPerson.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cbxAddPerson.FormattingEnabled = True
        Me.cbxAddPerson.ItemHeight = 26
        Me.cbxAddPerson.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cbxAddPerson.Location = New System.Drawing.Point(71, 270)
        Me.cbxAddPerson.Name = "cbxAddPerson"
        Me.cbxAddPerson.Size = New System.Drawing.Size(76, 34)
        Me.cbxAddPerson.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label13.Location = New System.Drawing.Point(68, 100)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 20)
        Me.Label13.TabIndex = 1020
        Me.Label13.Text = "MIDDLE NAME:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(470, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 1019
        Me.Label2.Text = "TOUR GUIDE:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Location = New System.Drawing.Point(470, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 20)
        Me.Label12.TabIndex = 1015
        Me.Label12.Text = "TRAIL NAME:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label15.Location = New System.Drawing.Point(68, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 20)
        Me.Label15.TabIndex = 1014
        Me.Label15.Text = "FIRST NAME:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Location = New System.Drawing.Point(68, 249)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 20)
        Me.Label11.TabIndex = 1017
        Me.Label11.Text = "# OF PERSON:"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label16.Location = New System.Drawing.Point(479, 279)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 20)
        Me.Label16.TabIndex = 1012
        Me.Label16.Text = "TOTAL PRICE:"
        '
        'lblClearAdd
        '
        Me.lblClearAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClearAdd.AutoSize = True
        Me.lblClearAdd.BackColor = System.Drawing.Color.Transparent
        Me.lblClearAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClearAdd.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearAdd.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblClearAdd.Location = New System.Drawing.Point(1016, 261)
        Me.lblClearAdd.Name = "lblClearAdd"
        Me.lblClearAdd.Size = New System.Drawing.Size(97, 23)
        Me.lblClearAdd.TabIndex = 13
        Me.lblClearAdd.Text = "Clear Form"
        '
        'btnAddAtv
        '
        Me.btnAddAtv.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAddAtv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddAtv.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddAtv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAtv.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAtv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnAddAtv.Location = New System.Drawing.Point(294, 269)
        Me.btnAddAtv.Name = "btnAddAtv"
        Me.btnAddAtv.Size = New System.Drawing.Size(110, 31)
        Me.btnAddAtv.TabIndex = 5
        Me.btnAddAtv.Text = "Select ATV"
        Me.btnAddAtv.UseVisualStyleBackColor = False
        '
        'tbxAddFName
        '
        Me.tbxAddFName.BackColor = System.Drawing.Color.White
        Me.tbxAddFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxAddFName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxAddFName.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAddFName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxAddFName.Location = New System.Drawing.Point(71, 47)
        Me.tbxAddFName.Name = "tbxAddFName"
        Me.tbxAddFName.Size = New System.Drawing.Size(333, 35)
        Me.tbxAddFName.TabIndex = 0
        '
        'tbxAddMName
        '
        Me.tbxAddMName.BackColor = System.Drawing.Color.White
        Me.tbxAddMName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxAddMName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxAddMName.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAddMName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxAddMName.Location = New System.Drawing.Point(71, 119)
        Me.tbxAddMName.Name = "tbxAddMName"
        Me.tbxAddMName.Size = New System.Drawing.Size(333, 35)
        Me.tbxAddMName.TabIndex = 1
        '
        'cbxAddTourGuide
        '
        Me.cbxAddTourGuide.BackColor = System.Drawing.Color.White
        Me.cbxAddTourGuide.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbxAddTourGuide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAddTourGuide.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbxAddTourGuide.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxAddTourGuide.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cbxAddTourGuide.FormattingEnabled = True
        Me.cbxAddTourGuide.ItemHeight = 26
        Me.cbxAddTourGuide.Location = New System.Drawing.Point(473, 121)
        Me.cbxAddTourGuide.Name = "cbxAddTourGuide"
        Me.cbxAddTourGuide.Size = New System.Drawing.Size(368, 34)
        Me.cbxAddTourGuide.TabIndex = 7
        '
        'btnAddConfirm
        '
        Me.btnAddConfirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnAddConfirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddConfirm.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddConfirm.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddConfirm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAddConfirm.Location = New System.Drawing.Point(927, 185)
        Me.btnAddConfirm.Name = "btnAddConfirm"
        Me.btnAddConfirm.Size = New System.Drawing.Size(221, 57)
        Me.btnAddConfirm.TabIndex = 12
        Me.btnAddConfirm.Text = "Confirm transaction"
        Me.btnAddConfirm.UseVisualStyleBackColor = False
        '
        'cbxAddTour
        '
        Me.cbxAddTour.BackColor = System.Drawing.Color.White
        Me.cbxAddTour.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbxAddTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAddTour.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbxAddTour.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxAddTour.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cbxAddTour.FormattingEnabled = True
        Me.cbxAddTour.ItemHeight = 26
        Me.cbxAddTour.Location = New System.Drawing.Point(473, 48)
        Me.cbxAddTour.Name = "cbxAddTour"
        Me.cbxAddTour.Size = New System.Drawing.Size(368, 34)
        Me.cbxAddTour.TabIndex = 6
        '
        'tbxAddTotal
        '
        Me.tbxAddTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxAddTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbxAddTotal.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxAddTotal.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAddTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.tbxAddTotal.Location = New System.Drawing.Point(567, 269)
        Me.tbxAddTotal.MaxLength = 11
        Me.tbxAddTotal.Name = "tbxAddTotal"
        Me.tbxAddTotal.ReadOnly = True
        Me.tbxAddTotal.Size = New System.Drawing.Size(274, 50)
        Me.tbxAddTotal.TabIndex = 9
        Me.tbxAddTotal.TabStop = False
        Me.tbxAddTotal.Text = "0.00"
        Me.tbxAddTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxAddSname
        '
        Me.tbxAddSname.BackColor = System.Drawing.Color.White
        Me.tbxAddSname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxAddSname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxAddSname.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAddSname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxAddSname.Location = New System.Drawing.Point(71, 192)
        Me.tbxAddSname.Name = "tbxAddSname"
        Me.tbxAddSname.Size = New System.Drawing.Size(333, 35)
        Me.tbxAddSname.TabIndex = 2
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label20.Location = New System.Drawing.Point(916, 26)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(180, 20)
        Me.Label20.TabIndex = 1027
        Me.Label20.Text = "DOWN PAYMENT TOTAL:"
        '
        'tbxAddInitPayment
        '
        Me.tbxAddInitPayment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxAddInitPayment.BackColor = System.Drawing.Color.White
        Me.tbxAddInitPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxAddInitPayment.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxAddInitPayment.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAddInitPayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxAddInitPayment.Location = New System.Drawing.Point(919, 47)
        Me.tbxAddInitPayment.Name = "tbxAddInitPayment"
        Me.tbxAddInitPayment.ReadOnly = True
        Me.tbxAddInitPayment.Size = New System.Drawing.Size(241, 35)
        Me.tbxAddInitPayment.TabIndex = 10
        Me.tbxAddInitPayment.TabStop = False
        Me.tbxAddInitPayment.Text = "0.00"
        Me.tbxAddInitPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label19.Location = New System.Drawing.Point(916, 99)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(73, 20)
        Me.Label19.TabIndex = 1025
        Me.Label19.Text = "CHANGE:"
        '
        'tbxAddChange
        '
        Me.tbxAddChange.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxAddChange.BackColor = System.Drawing.Color.White
        Me.tbxAddChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxAddChange.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxAddChange.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAddChange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxAddChange.Location = New System.Drawing.Point(919, 120)
        Me.tbxAddChange.Name = "tbxAddChange"
        Me.tbxAddChange.ReadOnly = True
        Me.tbxAddChange.Size = New System.Drawing.Size(241, 35)
        Me.tbxAddChange.TabIndex = 11
        Me.tbxAddChange.TabStop = False
        Me.tbxAddChange.Text = "0.00"
        Me.tbxAddChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label18.Location = New System.Drawing.Point(469, 199)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(114, 20)
        Me.Label18.TabIndex = 1023
        Me.Label18.Text = "ADD PAYMENT:"
        '
        'tbxAddNewPayment
        '
        Me.tbxAddNewPayment.BackColor = System.Drawing.Color.White
        Me.tbxAddNewPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxAddNewPayment.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAddNewPayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxAddNewPayment.Location = New System.Drawing.Point(567, 192)
        Me.tbxAddNewPayment.MaxLength = 6
        Me.tbxAddNewPayment.Name = "tbxAddNewPayment"
        Me.tbxAddNewPayment.Size = New System.Drawing.Size(274, 35)
        Me.tbxAddNewPayment.TabIndex = 8
        Me.tbxAddNewPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label39.Location = New System.Drawing.Point(719, 26)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(68, 20)
        Me.Label39.TabIndex = 1038
        Me.Label39.Text = "PRICE: ₱"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.lblWaitID)
        Me.TabPage2.Controls.Add(Me.Label25)
        Me.TabPage2.Controls.Add(Me.Label26)
        Me.TabPage2.Controls.Add(Me.tbxWaitBalance)
        Me.TabPage2.Controls.Add(Me.tbxWaitTour)
        Me.TabPage2.Controls.Add(Me.tbxWaitSname)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.tbxWaitMName)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.btnStartTrail)
        Me.TabPage2.Controls.Add(Me.btnWaitAtv)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.cbxWaitTourGuide)
        Me.TabPage2.Controls.Add(Me.lblWaitClear)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.tbxWaitPerson)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.tbxWaitFName)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.tbxWaitTotPrice)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Location = New System.Drawing.Point(4, 33)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1231, 335)
        Me.TabPage2.TabIndex = 5
        Me.TabPage2.Text = "  Waiting List   "
        '
        'lblWaitID
        '
        Me.lblWaitID.BackColor = System.Drawing.Color.Transparent
        Me.lblWaitID.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaitID.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblWaitID.Location = New System.Drawing.Point(935, 318)
        Me.lblWaitID.Name = "lblWaitID"
        Me.lblWaitID.Size = New System.Drawing.Size(296, 18)
        Me.lblWaitID.TabIndex = 1040
        Me.lblWaitID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(889, 154)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(30, 29)
        Me.Label25.TabIndex = 1039
        Me.Label25.Text = "₱"
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label26.Location = New System.Drawing.Point(882, 129)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(163, 20)
        Me.Label26.TabIndex = 1038
        Me.Label26.Text = "REMAINING BALANCE:"
        '
        'tbxWaitBalance
        '
        Me.tbxWaitBalance.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxWaitBalance.BackColor = System.Drawing.Color.White
        Me.tbxWaitBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxWaitBalance.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxWaitBalance.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxWaitBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxWaitBalance.Location = New System.Drawing.Point(885, 150)
        Me.tbxWaitBalance.Name = "tbxWaitBalance"
        Me.tbxWaitBalance.ReadOnly = True
        Me.tbxWaitBalance.Size = New System.Drawing.Size(240, 35)
        Me.tbxWaitBalance.TabIndex = 1037
        Me.tbxWaitBalance.TabStop = False
        Me.tbxWaitBalance.Text = "0.00"
        Me.tbxWaitBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxWaitTour
        '
        Me.tbxWaitTour.BackColor = System.Drawing.Color.White
        Me.tbxWaitTour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxWaitTour.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxWaitTour.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxWaitTour.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxWaitTour.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxWaitTour.Location = New System.Drawing.Point(449, 67)
        Me.tbxWaitTour.Name = "tbxWaitTour"
        Me.tbxWaitTour.ReadOnly = True
        Me.tbxWaitTour.Size = New System.Drawing.Size(341, 35)
        Me.tbxWaitTour.TabIndex = 1036
        '
        'tbxWaitSname
        '
        Me.tbxWaitSname.BackColor = System.Drawing.Color.White
        Me.tbxWaitSname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxWaitSname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxWaitSname.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxWaitSname.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxWaitSname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxWaitSname.Location = New System.Drawing.Point(80, 234)
        Me.tbxWaitSname.Name = "tbxWaitSname"
        Me.tbxWaitSname.ReadOnly = True
        Me.tbxWaitSname.Size = New System.Drawing.Size(311, 35)
        Me.tbxWaitSname.TabIndex = 1034
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label14.Location = New System.Drawing.Point(77, 213)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 20)
        Me.Label14.TabIndex = 1035
        Me.Label14.Text = "SURNAME:"
        '
        'tbxWaitMName
        '
        Me.tbxWaitMName.BackColor = System.Drawing.Color.White
        Me.tbxWaitMName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxWaitMName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxWaitMName.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxWaitMName.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxWaitMName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxWaitMName.Location = New System.Drawing.Point(80, 149)
        Me.tbxWaitMName.Name = "tbxWaitMName"
        Me.tbxWaitMName.ReadOnly = True
        Me.tbxWaitMName.Size = New System.Drawing.Size(311, 35)
        Me.tbxWaitMName.TabIndex = 1032
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(77, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 20)
        Me.Label7.TabIndex = 1033
        Me.Label7.Text = "MIDDLE NAME:"
        '
        'btnStartTrail
        '
        Me.btnStartTrail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnStartTrail.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnStartTrail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStartTrail.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnStartTrail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStartTrail.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartTrail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnStartTrail.Location = New System.Drawing.Point(916, 213)
        Me.btnStartTrail.Name = "btnStartTrail"
        Me.btnStartTrail.Size = New System.Drawing.Size(193, 60)
        Me.btnStartTrail.TabIndex = 1031
        Me.btnStartTrail.Text = "Start Trail"
        Me.btnStartTrail.UseVisualStyleBackColor = False
        '
        'btnWaitAtv
        '
        Me.btnWaitAtv.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnWaitAtv.BackColor = System.Drawing.Color.Gainsboro
        Me.btnWaitAtv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWaitAtv.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnWaitAtv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWaitAtv.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWaitAtv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnWaitAtv.Location = New System.Drawing.Point(621, 231)
        Me.btnWaitAtv.Name = "btnWaitAtv"
        Me.btnWaitAtv.Size = New System.Drawing.Size(119, 37)
        Me.btnWaitAtv.TabIndex = 6
        Me.btnWaitAtv.Text = "Assign ATVs"
        Me.btnWaitAtv.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(446, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 20)
        Me.Label1.TabIndex = 1030
        Me.Label1.Text = "ASSIGN TOUR GUIDE:"
        '
        'cbxWaitTourGuide
        '
        Me.cbxWaitTourGuide.BackColor = System.Drawing.Color.White
        Me.cbxWaitTourGuide.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbxWaitTourGuide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxWaitTourGuide.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxWaitTourGuide.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cbxWaitTourGuide.FormattingEnabled = True
        Me.cbxWaitTourGuide.ItemHeight = 26
        Me.cbxWaitTourGuide.Location = New System.Drawing.Point(449, 150)
        Me.cbxWaitTourGuide.Name = "cbxWaitTourGuide"
        Me.cbxWaitTourGuide.Size = New System.Drawing.Size(341, 34)
        Me.cbxWaitTourGuide.TabIndex = 5
        '
        'lblWaitClear
        '
        Me.lblWaitClear.AutoSize = True
        Me.lblWaitClear.BackColor = System.Drawing.Color.Transparent
        Me.lblWaitClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblWaitClear.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaitClear.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblWaitClear.Location = New System.Drawing.Point(976, 290)
        Me.lblWaitClear.Name = "lblWaitClear"
        Me.lblWaitClear.Size = New System.Drawing.Size(97, 23)
        Me.lblWaitClear.TabIndex = 9
        Me.lblWaitClear.Text = "Clear Form"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(889, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 43)
        Me.Label3.TabIndex = 1029
        Me.Label3.Text = "₱"
        '
        'tbxWaitPerson
        '
        Me.tbxWaitPerson.BackColor = System.Drawing.Color.White
        Me.tbxWaitPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxWaitPerson.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxWaitPerson.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxWaitPerson.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxWaitPerson.Location = New System.Drawing.Point(492, 234)
        Me.tbxWaitPerson.MaxLength = 1
        Me.tbxWaitPerson.Name = "tbxWaitPerson"
        Me.tbxWaitPerson.ReadOnly = True
        Me.tbxWaitPerson.Size = New System.Drawing.Size(76, 35)
        Me.tbxWaitPerson.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(489, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 1028
        Me.Label4.Text = "# OF PERSON:"
        '
        'tbxWaitFName
        '
        Me.tbxWaitFName.BackColor = System.Drawing.Color.White
        Me.tbxWaitFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxWaitFName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxWaitFName.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxWaitFName.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxWaitFName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxWaitFName.Location = New System.Drawing.Point(80, 67)
        Me.tbxWaitFName.Name = "tbxWaitFName"
        Me.tbxWaitFName.ReadOnly = True
        Me.tbxWaitFName.Size = New System.Drawing.Size(311, 35)
        Me.tbxWaitFName.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(446, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 1026
        Me.Label5.Text = "TRAIL NAME:"
        '
        'tbxWaitTotPrice
        '
        Me.tbxWaitTotPrice.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbxWaitTotPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxWaitTotPrice.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxWaitTotPrice.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxWaitTotPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxWaitTotPrice.Location = New System.Drawing.Point(885, 64)
        Me.tbxWaitTotPrice.MaxLength = 11
        Me.tbxWaitTotPrice.Name = "tbxWaitTotPrice"
        Me.tbxWaitTotPrice.ReadOnly = True
        Me.tbxWaitTotPrice.Size = New System.Drawing.Size(240, 50)
        Me.tbxWaitTotPrice.TabIndex = 4
        Me.tbxWaitTotPrice.Text = "0.00"
        Me.tbxWaitTotPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(77, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 20)
        Me.Label8.TabIndex = 1025
        Me.Label8.Text = "FIRST NAME:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(882, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 20)
        Me.Label9.TabIndex = 1023
        Me.Label9.Text = "TOTAL PRICE:"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.dgvViewAtv)
        Me.TabPage3.Controls.Add(Me.lblTransacID)
        Me.TabPage3.Controls.Add(Me.tbxOnGTrailDate)
        Me.TabPage3.Controls.Add(Me.Label38)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.Label37)
        Me.TabPage3.Controls.Add(Me.tbxOnGTourPrice)
        Me.TabPage3.Controls.Add(Me.tbxOnGTourGuide)
        Me.TabPage3.Controls.Add(Me.btnOnGViewAtv)
        Me.TabPage3.Controls.Add(Me.Label34)
        Me.TabPage3.Controls.Add(Me.lblOnGClear)
        Me.TabPage3.Controls.Add(Me.btnEndTrail)
        Me.TabPage3.Controls.Add(Me.Label28)
        Me.TabPage3.Controls.Add(Me.tbxOnGPerson)
        Me.TabPage3.Controls.Add(Me.Label29)
        Me.TabPage3.Controls.Add(Me.tbxOnGName)
        Me.TabPage3.Controls.Add(Me.Label31)
        Me.TabPage3.Controls.Add(Me.tbxOnGTour)
        Me.TabPage3.Controls.Add(Me.tbxOnGTotalPrice)
        Me.TabPage3.Controls.Add(Me.Label35)
        Me.TabPage3.Controls.Add(Me.Label36)
        Me.TabPage3.Location = New System.Drawing.Point(4, 33)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1231, 335)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "  Ongoing Transactions   "
        '
        'lblTransacID
        '
        Me.lblTransacID.BackColor = System.Drawing.Color.Transparent
        Me.lblTransacID.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransacID.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTransacID.Location = New System.Drawing.Point(932, 318)
        Me.lblTransacID.Name = "lblTransacID"
        Me.lblTransacID.Size = New System.Drawing.Size(296, 18)
        Me.lblTransacID.TabIndex = 1050
        Me.lblTransacID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbxOnGTrailDate
        '
        Me.tbxOnGTrailDate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbxOnGTrailDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxOnGTrailDate.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxOnGTrailDate.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxOnGTrailDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxOnGTrailDate.Location = New System.Drawing.Point(486, 237)
        Me.tbxOnGTrailDate.MaxLength = 11
        Me.tbxOnGTrailDate.Name = "tbxOnGTrailDate"
        Me.tbxOnGTrailDate.ReadOnly = True
        Me.tbxOnGTrailDate.Size = New System.Drawing.Size(271, 35)
        Me.tbxOnGTrailDate.TabIndex = 1048
        Me.tbxOnGTrailDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label38.Location = New System.Drawing.Point(483, 216)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(144, 20)
        Me.Label38.TabIndex = 1049
        Me.Label38.Text = "TRAIL START DATE:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(488, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 29)
        Me.Label6.TabIndex = 1047
        Me.Label6.Text = "₱"
        '
        'Label37
        '
        Me.Label37.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label37.Location = New System.Drawing.Point(483, 52)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(175, 20)
        Me.Label37.TabIndex = 1044
        Me.Label37.Text = "TRAIL PRICE PER HEAD:"
        '
        'tbxOnGTourPrice
        '
        Me.tbxOnGTourPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxOnGTourPrice.BackColor = System.Drawing.Color.White
        Me.tbxOnGTourPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxOnGTourPrice.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxOnGTourPrice.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxOnGTourPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxOnGTourPrice.Location = New System.Drawing.Point(486, 73)
        Me.tbxOnGTourPrice.MaxLength = 6
        Me.tbxOnGTourPrice.Name = "tbxOnGTourPrice"
        Me.tbxOnGTourPrice.ReadOnly = True
        Me.tbxOnGTourPrice.Size = New System.Drawing.Size(181, 35)
        Me.tbxOnGTourPrice.TabIndex = 1043
        Me.tbxOnGTourPrice.TabStop = False
        Me.tbxOnGTourPrice.Text = "0.00"
        Me.tbxOnGTourPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxOnGTourGuide
        '
        Me.tbxOnGTourGuide.BackColor = System.Drawing.Color.White
        Me.tbxOnGTourGuide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxOnGTourGuide.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxOnGTourGuide.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxOnGTourGuide.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxOnGTourGuide.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxOnGTourGuide.Location = New System.Drawing.Point(30, 237)
        Me.tbxOnGTourGuide.Name = "tbxOnGTourGuide"
        Me.tbxOnGTourGuide.ReadOnly = True
        Me.tbxOnGTourGuide.Size = New System.Drawing.Size(408, 35)
        Me.tbxOnGTourGuide.TabIndex = 1007
        '
        'btnOnGViewAtv
        '
        Me.btnOnGViewAtv.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnOnGViewAtv.BackColor = System.Drawing.Color.Gainsboro
        Me.btnOnGViewAtv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOnGViewAtv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnOnGViewAtv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOnGViewAtv.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOnGViewAtv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnOnGViewAtv.Location = New System.Drawing.Point(686, 289)
        Me.btnOnGViewAtv.Name = "btnOnGViewAtv"
        Me.btnOnGViewAtv.Size = New System.Drawing.Size(155, 40)
        Me.btnOnGViewAtv.TabIndex = 6
        Me.btnOnGViewAtv.Text = "View ATVs in use"
        Me.btnOnGViewAtv.UseVisualStyleBackColor = False
        Me.btnOnGViewAtv.Visible = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label34.Location = New System.Drawing.Point(27, 216)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(101, 20)
        Me.Label34.TabIndex = 1006
        Me.Label34.Text = "TOUR GUIDE:"
        '
        'lblOnGClear
        '
        Me.lblOnGClear.AutoSize = True
        Me.lblOnGClear.BackColor = System.Drawing.Color.Transparent
        Me.lblOnGClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblOnGClear.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnGClear.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblOnGClear.Location = New System.Drawing.Point(1125, 11)
        Me.lblOnGClear.Name = "lblOnGClear"
        Me.lblOnGClear.Size = New System.Drawing.Size(97, 23)
        Me.lblOnGClear.TabIndex = 9
        Me.lblOnGClear.Text = "Clear Form"
        '
        'btnEndTrail
        '
        Me.btnEndTrail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEndTrail.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnEndTrail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEndTrail.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnEndTrail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEndTrail.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEndTrail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEndTrail.Location = New System.Drawing.Point(931, 237)
        Me.btnEndTrail.Name = "btnEndTrail"
        Me.btnEndTrail.Size = New System.Drawing.Size(192, 62)
        Me.btnEndTrail.TabIndex = 8
        Me.btnEndTrail.Text = "End Trail"
        Me.btnEndTrail.UseVisualStyleBackColor = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label28.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(490, 155)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(30, 29)
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
        Me.tbxOnGPerson.Location = New System.Drawing.Point(710, 74)
        Me.tbxOnGPerson.MaxLength = 1
        Me.tbxOnGPerson.Name = "tbxOnGPerson"
        Me.tbxOnGPerson.ReadOnly = True
        Me.tbxOnGPerson.Size = New System.Drawing.Size(82, 35)
        Me.tbxOnGPerson.TabIndex = 3
        Me.tbxOnGPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label29.Location = New System.Drawing.Point(682, 52)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(110, 20)
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
        Me.tbxOnGName.Location = New System.Drawing.Point(30, 73)
        Me.tbxOnGName.Name = "tbxOnGName"
        Me.tbxOnGName.ReadOnly = True
        Me.tbxOnGName.Size = New System.Drawing.Size(408, 35)
        Me.tbxOnGName.TabIndex = 0
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label31.Location = New System.Drawing.Point(27, 134)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(100, 20)
        Me.Label31.TabIndex = 156
        Me.Label31.Text = "TRAIL NAME:"
        '
        'tbxOnGTour
        '
        Me.tbxOnGTour.BackColor = System.Drawing.Color.White
        Me.tbxOnGTour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxOnGTour.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxOnGTour.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxOnGTour.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxOnGTour.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxOnGTour.Location = New System.Drawing.Point(30, 155)
        Me.tbxOnGTour.Name = "tbxOnGTour"
        Me.tbxOnGTour.ReadOnly = True
        Me.tbxOnGTour.Size = New System.Drawing.Size(408, 35)
        Me.tbxOnGTour.TabIndex = 1
        '
        'tbxOnGTotalPrice
        '
        Me.tbxOnGTotalPrice.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbxOnGTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxOnGTotalPrice.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxOnGTotalPrice.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxOnGTotalPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxOnGTotalPrice.Location = New System.Drawing.Point(486, 153)
        Me.tbxOnGTotalPrice.MaxLength = 11
        Me.tbxOnGTotalPrice.Name = "tbxOnGTotalPrice"
        Me.tbxOnGTotalPrice.ReadOnly = True
        Me.tbxOnGTotalPrice.Size = New System.Drawing.Size(271, 35)
        Me.tbxOnGTotalPrice.TabIndex = 4
        Me.tbxOnGTotalPrice.Text = "0.00"
        Me.tbxOnGTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label35.Location = New System.Drawing.Point(27, 52)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(91, 20)
        Me.Label35.TabIndex = 154
        Me.Label35.Text = "CUSTOMER:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label36.Location = New System.Drawing.Point(483, 132)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(104, 20)
        Me.Label36.TabIndex = 150
        Me.Label36.Text = "TOTAL PRICE:"
        '
        'lblTodayTransac
        '
        Me.lblTodayTransac.BackColor = System.Drawing.Color.Transparent
        Me.lblTodayTransac.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodayTransac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.lblTodayTransac.Location = New System.Drawing.Point(39, 32)
        Me.lblTodayTransac.Name = "lblTodayTransac"
        Me.lblTodayTransac.Size = New System.Drawing.Size(228, 20)
        Me.lblTodayTransac.TabIndex = 129
        Me.lblTodayTransac.Text = "TOTAL TRANSACTION TODAY:"
        Me.lblTodayTransac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWaiting
        '
        Me.lblWaiting.AutoSize = True
        Me.lblWaiting.BackColor = System.Drawing.Color.Transparent
        Me.lblWaiting.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaiting.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblWaiting.Location = New System.Drawing.Point(273, 34)
        Me.lblWaiting.Name = "lblWaiting"
        Me.lblWaiting.Size = New System.Drawing.Size(91, 23)
        Me.lblWaiting.TabIndex = 130
        Me.lblWaiting.Text = "Waiting: 0"
        '
        'lblOngoing
        '
        Me.lblOngoing.AutoSize = True
        Me.lblOngoing.BackColor = System.Drawing.Color.Transparent
        Me.lblOngoing.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOngoing.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblOngoing.Location = New System.Drawing.Point(402, 34)
        Me.lblOngoing.Name = "lblOngoing"
        Me.lblOngoing.Size = New System.Drawing.Size(96, 23)
        Me.lblOngoing.TabIndex = 131
        Me.lblOngoing.Text = "Ongoing: 0"
        '
        'dgvViewAtv
        '
        Me.dgvViewAtv.AllowUserToAddRows = False
        Me.dgvViewAtv.AllowUserToOrderColumns = True
        Me.dgvViewAtv.AllowUserToResizeColumns = False
        Me.dgvViewAtv.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvViewAtv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvViewAtv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvViewAtv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvViewAtv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvViewAtv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.dgvViewAtv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvViewAtv.EnableHeadersVisualStyles = False
        Me.dgvViewAtv.GridColor = System.Drawing.Color.DimGray
        Me.dgvViewAtv.Location = New System.Drawing.Point(832, 52)
        Me.dgvViewAtv.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvViewAtv.MultiSelect = False
        Me.dgvViewAtv.Name = "dgvViewAtv"
        Me.dgvViewAtv.ReadOnly = True
        Me.dgvViewAtv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvViewAtv.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvViewAtv.RowHeadersVisible = False
        Me.dgvViewAtv.RowHeadersWidth = 51
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.dgvViewAtv.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvViewAtv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvViewAtv.ShowEditingIcon = False
        Me.dgvViewAtv.Size = New System.Drawing.Size(371, 162)
        Me.dgvViewAtv.TabIndex = 1051
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.HeaderText = "ATVs in use:"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ctrlTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.lblOngoing)
        Me.Controls.Add(Me.lblWaiting)
        Me.Controls.Add(Me.lblTodayTransac)
        Me.Controls.Add(Me.tabTransactions)
        Me.Controls.Add(Me.dgvTransactions)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ctrlTransactions"
        Me.Size = New System.Drawing.Size(1333, 884)
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTransactions.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgvViewAtv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvTransactions As DataGridView
    Friend WithEvents tabTransactions As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents lblTodayTransac As Label
    Friend WithEvents lblWaiting As Label
    Friend WithEvents lblOngoing As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents tbxOnGPerson As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents tbxOnGName As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents tbxOnGTour As TextBox
    Friend WithEvents tbxOnGTotalPrice As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents lblOnGClear As Label
    Friend WithEvents btnEndTrail As Button
    Friend WithEvents Label34 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnOnGViewAtv As Button
    Friend WithEvents btnWaitAtv As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxWaitTourGuide As ComboBox
    Friend WithEvents lblWaitClear As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxWaitPerson As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbxWaitFName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbxWaitTotPrice As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnAddAtv As Button
    Friend WithEvents lblClearAdd As Label
    Friend WithEvents cbxAddTourGuide As ComboBox
    Friend WithEvents tbxAddFName As TextBox
    Friend WithEvents tbxAddMName As TextBox
    Friend WithEvents btnAddConfirm As Button
    Friend WithEvents cbxAddTour As ComboBox
    Friend WithEvents tbxAddTotal As TextBox
    Friend WithEvents tbxAddSname As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnStartTrail As Button
    Friend WithEvents tbxWaitSname As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents tbxWaitMName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents tbxAddChange As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents tbxAddNewPayment As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents tbxAddInitPayment As TextBox
    Public WithEvents cbxAddPerson As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lblTourPrice As Label
    Public WithEvents cbxAddTimeSlot As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents tbxWaitTour As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents tbxWaitBalance As TextBox
    Friend WithEvents tbxOnGTourGuide As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents tbxOnGTourPrice As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents tbxOnGTrailDate As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents lblWaitID As Label
    Friend WithEvents lblTransacID As Label
    Friend WithEvents dgvViewAtv As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
