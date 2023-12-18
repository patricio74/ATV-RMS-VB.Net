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
        Me.tbxAddBalance = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbxAddChange = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbxAddInitPayment = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
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
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.tbxOnGChange = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.tbxOnGNewPayment = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.tbxOnGRemBalance = New System.Windows.Forms.TextBox()
        Me.tbxOnGTourGuide = New System.Windows.Forms.TextBox()
        Me.btnOnGAtv = New System.Windows.Forms.Button()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.lblOnGClear = New System.Windows.Forms.Label()
        Me.btnEndTrail = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.tbxOnGPerson = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.tbxOnGName = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.tbxOnGTour = New System.Windows.Forms.TextBox()
        Me.tbxOnGTotal = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.tbxTransacID = New System.Windows.Forms.TextBox()
        Me.lblTodayTransac = New System.Windows.Forms.Label()
        Me.lblWaiting = New System.Windows.Forms.Label()
        Me.lblOngoing = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.tbxOnGTime = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTransactions.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvTransactions
        '
        Me.dgvTransactions.AllowUserToAddRows = False
        Me.dgvTransactions.AllowUserToOrderColumns = True
        Me.dgvTransactions.AllowUserToResizeColumns = False
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
        Me.dgvTransactions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.dgvTransactions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvTransactions.EnableHeadersVisualStyles = False
        Me.dgvTransactions.GridColor = System.Drawing.Color.DimGray
        Me.dgvTransactions.Location = New System.Drawing.Point(30, 43)
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
        Me.dgvTransactions.Size = New System.Drawing.Size(1103, 280)
        Me.dgvTransactions.TabIndex = 95
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "CUSTOMER NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "TOUR NAME"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 300
        '
        'Column6
        '
        Me.Column6.HeaderText = "DATE"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 200
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
        'tabTransactions
        '
        Me.tabTransactions.Controls.Add(Me.TabPage1)
        Me.tabTransactions.Controls.Add(Me.TabPage2)
        Me.tabTransactions.Controls.Add(Me.TabPage3)
        Me.tabTransactions.Location = New System.Drawing.Point(30, 342)
        Me.tabTransactions.Name = "tabTransactions"
        Me.tabTransactions.SelectedIndex = 0
        Me.tabTransactions.Size = New System.Drawing.Size(1103, 376)
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
        Me.TabPage1.Controls.Add(Me.tbxAddBalance)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.tbxAddChange)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.tbxAddInitPayment)
        Me.TabPage1.Controls.Add(Me.Label39)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1095, 343)
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
        Me.cbxAddTimeSlot.ItemHeight = 22
        Me.cbxAddTimeSlot.Items.AddRange(New Object() {"Morning", "Afternoon", "Evening"})
        Me.cbxAddTimeSlot.Location = New System.Drawing.Point(133, 270)
        Me.cbxAddTimeSlot.Name = "cbxAddTimeSlot"
        Me.cbxAddTimeSlot.Size = New System.Drawing.Size(103, 30)
        Me.cbxAddTimeSlot.TabIndex = 4
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label24.Location = New System.Drawing.Point(130, 249)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(70, 18)
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
        Me.lblTourPrice.Location = New System.Drawing.Point(663, 26)
        Me.lblTourPrice.Name = "lblTourPrice"
        Me.lblTourPrice.Size = New System.Drawing.Size(33, 18)
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
        Me.Label23.Location = New System.Drawing.Point(419, 194)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(24, 24)
        Me.Label23.TabIndex = 1033
        Me.Label23.Text = "₱"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.White
        Me.Label22.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(819, 123)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(24, 24)
        Me.Label22.TabIndex = 1032
        Me.Label22.Text = "₱"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(819, 50)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(24, 24)
        Me.Label21.TabIndex = 1031
        Me.Label21.Text = "₱"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(418, 265)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 35)
        Me.Label10.TabIndex = 1030
        Me.Label10.Text = "₱"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label17.Location = New System.Drawing.Point(43, 173)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 18)
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
        Me.cbxAddPerson.ItemHeight = 22
        Me.cbxAddPerson.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cbxAddPerson.Location = New System.Drawing.Point(46, 270)
        Me.cbxAddPerson.Name = "cbxAddPerson"
        Me.cbxAddPerson.Size = New System.Drawing.Size(76, 30)
        Me.cbxAddPerson.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label13.Location = New System.Drawing.Point(43, 100)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 18)
        Me.Label13.TabIndex = 1020
        Me.Label13.Text = "MIDDLE NAME:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(412, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 18)
        Me.Label2.TabIndex = 1019
        Me.Label2.Text = "TOUR GUIDE:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Location = New System.Drawing.Point(412, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 18)
        Me.Label12.TabIndex = 1015
        Me.Label12.Text = "TOUR NAME:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label15.Location = New System.Drawing.Point(43, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 18)
        Me.Label15.TabIndex = 1014
        Me.Label15.Text = "FIRST NAME:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Location = New System.Drawing.Point(43, 249)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 18)
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
        Me.Label16.Location = New System.Drawing.Point(412, 241)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 18)
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
        Me.lblClearAdd.Location = New System.Drawing.Point(879, 268)
        Me.lblClearAdd.Name = "lblClearAdd"
        Me.lblClearAdd.Size = New System.Drawing.Size(75, 18)
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
        Me.btnAddAtv.Location = New System.Drawing.Point(247, 269)
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
        Me.tbxAddFName.Location = New System.Drawing.Point(46, 47)
        Me.tbxAddFName.Name = "tbxAddFName"
        Me.tbxAddFName.Size = New System.Drawing.Size(311, 30)
        Me.tbxAddFName.TabIndex = 0
        '
        'tbxAddMName
        '
        Me.tbxAddMName.BackColor = System.Drawing.Color.White
        Me.tbxAddMName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxAddMName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxAddMName.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAddMName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxAddMName.Location = New System.Drawing.Point(46, 119)
        Me.tbxAddMName.Name = "tbxAddMName"
        Me.tbxAddMName.Size = New System.Drawing.Size(311, 30)
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
        Me.cbxAddTourGuide.ItemHeight = 22
        Me.cbxAddTourGuide.Location = New System.Drawing.Point(415, 120)
        Me.cbxAddTourGuide.Name = "cbxAddTourGuide"
        Me.cbxAddTourGuide.Size = New System.Drawing.Size(311, 30)
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
        Me.btnAddConfirm.Location = New System.Drawing.Point(798, 192)
        Me.btnAddConfirm.Name = "btnAddConfirm"
        Me.btnAddConfirm.Size = New System.Drawing.Size(228, 54)
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
        Me.cbxAddTour.ItemHeight = 22
        Me.cbxAddTour.Location = New System.Drawing.Point(415, 47)
        Me.cbxAddTour.Name = "cbxAddTour"
        Me.cbxAddTour.Size = New System.Drawing.Size(311, 30)
        Me.cbxAddTour.TabIndex = 6
        '
        'tbxAddTotal
        '
        Me.tbxAddTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxAddTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbxAddTotal.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxAddTotal.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAddTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.tbxAddTotal.Location = New System.Drawing.Point(415, 262)
        Me.tbxAddTotal.MaxLength = 11
        Me.tbxAddTotal.Name = "tbxAddTotal"
        Me.tbxAddTotal.ReadOnly = True
        Me.tbxAddTotal.Size = New System.Drawing.Size(311, 41)
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
        Me.tbxAddSname.Location = New System.Drawing.Point(46, 192)
        Me.tbxAddSname.Name = "tbxAddSname"
        Me.tbxAddSname.Size = New System.Drawing.Size(311, 30)
        Me.tbxAddSname.TabIndex = 2
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label20.Location = New System.Drawing.Point(813, 26)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(130, 18)
        Me.Label20.TabIndex = 1027
        Me.Label20.Text = "REMAINING BALANCE:"
        '
        'tbxAddBalance
        '
        Me.tbxAddBalance.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxAddBalance.BackColor = System.Drawing.Color.White
        Me.tbxAddBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxAddBalance.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxAddBalance.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAddBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxAddBalance.Location = New System.Drawing.Point(816, 47)
        Me.tbxAddBalance.Name = "tbxAddBalance"
        Me.tbxAddBalance.ReadOnly = True
        Me.tbxAddBalance.Size = New System.Drawing.Size(196, 30)
        Me.tbxAddBalance.TabIndex = 10
        Me.tbxAddBalance.TabStop = False
        Me.tbxAddBalance.Text = "0.00"
        Me.tbxAddBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label19.Location = New System.Drawing.Point(813, 99)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(58, 18)
        Me.Label19.TabIndex = 1025
        Me.Label19.Text = "CHANGE:"
        '
        'tbxAddChange
        '
        Me.tbxAddChange.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxAddChange.BackColor = System.Drawing.Color.White
        Me.tbxAddChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxAddChange.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxAddChange.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAddChange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxAddChange.Location = New System.Drawing.Point(816, 120)
        Me.tbxAddChange.Name = "tbxAddChange"
        Me.tbxAddChange.ReadOnly = True
        Me.tbxAddChange.Size = New System.Drawing.Size(196, 30)
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
        Me.Label18.Location = New System.Drawing.Point(412, 171)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(107, 18)
        Me.Label18.TabIndex = 1023
        Me.Label18.Text = "INITIAL PAYMENT:"
        '
        'tbxAddInitPayment
        '
        Me.tbxAddInitPayment.BackColor = System.Drawing.Color.White
        Me.tbxAddInitPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxAddInitPayment.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAddInitPayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxAddInitPayment.Location = New System.Drawing.Point(415, 192)
        Me.tbxAddInitPayment.MaxLength = 6
        Me.tbxAddInitPayment.Name = "tbxAddInitPayment"
        Me.tbxAddInitPayment.Size = New System.Drawing.Size(311, 30)
        Me.tbxAddInitPayment.TabIndex = 8
        Me.tbxAddInitPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label39.Location = New System.Drawing.Point(609, 25)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(54, 18)
        Me.Label39.TabIndex = 1038
        Me.Label39.Text = "PRICE: ₱"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
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
        Me.TabPage2.Controls.Add(Me.TextBox6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1095, 343)
        Me.TabPage2.TabIndex = 5
        Me.TabPage2.Text = "  Waiting List   "
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(788, 158)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(24, 24)
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
        Me.Label26.Location = New System.Drawing.Point(782, 134)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(130, 18)
        Me.Label26.TabIndex = 1038
        Me.Label26.Text = "REMAINING BALANCE:"
        '
        'tbxWaitBalance
        '
        Me.tbxWaitBalance.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxWaitBalance.BackColor = System.Drawing.Color.White
        Me.tbxWaitBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxWaitBalance.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxWaitBalance.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxWaitBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxWaitBalance.Location = New System.Drawing.Point(785, 155)
        Me.tbxWaitBalance.Name = "tbxWaitBalance"
        Me.tbxWaitBalance.ReadOnly = True
        Me.tbxWaitBalance.Size = New System.Drawing.Size(242, 30)
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
        Me.tbxWaitTour.Location = New System.Drawing.Point(415, 69)
        Me.tbxWaitTour.Name = "tbxWaitTour"
        Me.tbxWaitTour.ReadOnly = True
        Me.tbxWaitTour.Size = New System.Drawing.Size(311, 30)
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
        Me.tbxWaitSname.Location = New System.Drawing.Point(46, 238)
        Me.tbxWaitSname.Name = "tbxWaitSname"
        Me.tbxWaitSname.ReadOnly = True
        Me.tbxWaitSname.Size = New System.Drawing.Size(311, 30)
        Me.tbxWaitSname.TabIndex = 1034
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label14.Location = New System.Drawing.Point(43, 217)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 18)
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
        Me.tbxWaitMName.Location = New System.Drawing.Point(46, 151)
        Me.tbxWaitMName.Name = "tbxWaitMName"
        Me.tbxWaitMName.ReadOnly = True
        Me.tbxWaitMName.Size = New System.Drawing.Size(311, 30)
        Me.tbxWaitMName.TabIndex = 1032
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(43, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 18)
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
        Me.btnStartTrail.Location = New System.Drawing.Point(825, 216)
        Me.btnStartTrail.Name = "btnStartTrail"
        Me.btnStartTrail.Size = New System.Drawing.Size(183, 50)
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
        Me.btnWaitAtv.Location = New System.Drawing.Point(563, 238)
        Me.btnWaitAtv.Name = "btnWaitAtv"
        Me.btnWaitAtv.Size = New System.Drawing.Size(110, 30)
        Me.btnWaitAtv.TabIndex = 6
        Me.btnWaitAtv.Text = "Select ATV"
        Me.btnWaitAtv.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(412, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 18)
        Me.Label1.TabIndex = 1030
        Me.Label1.Text = "TOUR GUIDE:"
        '
        'cbxWaitTourGuide
        '
        Me.cbxWaitTourGuide.BackColor = System.Drawing.Color.White
        Me.cbxWaitTourGuide.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbxWaitTourGuide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxWaitTourGuide.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxWaitTourGuide.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cbxWaitTourGuide.FormattingEnabled = True
        Me.cbxWaitTourGuide.ItemHeight = 22
        Me.cbxWaitTourGuide.Location = New System.Drawing.Point(415, 152)
        Me.cbxWaitTourGuide.Name = "cbxWaitTourGuide"
        Me.cbxWaitTourGuide.Size = New System.Drawing.Size(311, 30)
        Me.cbxWaitTourGuide.TabIndex = 5
        '
        'lblWaitClear
        '
        Me.lblWaitClear.AutoSize = True
        Me.lblWaitClear.BackColor = System.Drawing.Color.Transparent
        Me.lblWaitClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblWaitClear.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaitClear.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblWaitClear.Location = New System.Drawing.Point(880, 282)
        Me.lblWaitClear.Name = "lblWaitClear"
        Me.lblWaitClear.Size = New System.Drawing.Size(75, 18)
        Me.lblWaitClear.TabIndex = 9
        Me.lblWaitClear.Text = "Clear Form"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(789, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 35)
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
        Me.tbxWaitPerson.Location = New System.Drawing.Point(415, 238)
        Me.tbxWaitPerson.MaxLength = 1
        Me.tbxWaitPerson.Name = "tbxWaitPerson"
        Me.tbxWaitPerson.ReadOnly = True
        Me.tbxWaitPerson.Size = New System.Drawing.Size(76, 30)
        Me.tbxWaitPerson.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(412, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 18)
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
        Me.tbxWaitFName.Location = New System.Drawing.Point(46, 69)
        Me.tbxWaitFName.Name = "tbxWaitFName"
        Me.tbxWaitFName.ReadOnly = True
        Me.tbxWaitFName.Size = New System.Drawing.Size(311, 30)
        Me.tbxWaitFName.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(412, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 18)
        Me.Label5.TabIndex = 1026
        Me.Label5.Text = "TOUR NAME:"
        '
        'tbxWaitTotPrice
        '
        Me.tbxWaitTotPrice.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbxWaitTotPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxWaitTotPrice.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxWaitTotPrice.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxWaitTotPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxWaitTotPrice.Location = New System.Drawing.Point(785, 69)
        Me.tbxWaitTotPrice.MaxLength = 11
        Me.tbxWaitTotPrice.Name = "tbxWaitTotPrice"
        Me.tbxWaitTotPrice.ReadOnly = True
        Me.tbxWaitTotPrice.Size = New System.Drawing.Size(242, 41)
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
        Me.Label8.Location = New System.Drawing.Point(43, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 18)
        Me.Label8.TabIndex = 1025
        Me.Label8.Text = "FIRST NAME:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(782, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 18)
        Me.Label9.TabIndex = 1023
        Me.Label9.Text = "TOTAL PRICE:"
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox6.Location = New System.Drawing.Point(840, 323)
        Me.TextBox6.MaxLength = 11
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(252, 14)
        Me.TextBox6.TabIndex = 10
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.Label32)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.Label38)
        Me.TabPage3.Controls.Add(Me.tbxOnGChange)
        Me.TabPage3.Controls.Add(Me.Label37)
        Me.TabPage3.Controls.Add(Me.tbxOnGNewPayment)
        Me.TabPage3.Controls.Add(Me.tbxOnGTourGuide)
        Me.TabPage3.Controls.Add(Me.btnOnGAtv)
        Me.TabPage3.Controls.Add(Me.Label34)
        Me.TabPage3.Controls.Add(Me.lblOnGClear)
        Me.TabPage3.Controls.Add(Me.btnEndTrail)
        Me.TabPage3.Controls.Add(Me.Label28)
        Me.TabPage3.Controls.Add(Me.tbxOnGPerson)
        Me.TabPage3.Controls.Add(Me.Label29)
        Me.TabPage3.Controls.Add(Me.tbxOnGName)
        Me.TabPage3.Controls.Add(Me.Label31)
        Me.TabPage3.Controls.Add(Me.tbxOnGTour)
        Me.TabPage3.Controls.Add(Me.tbxOnGTotal)
        Me.TabPage3.Controls.Add(Me.Label35)
        Me.TabPage3.Controls.Add(Me.Label36)
        Me.TabPage3.Controls.Add(Me.tbxTransacID)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1095, 343)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "  Ongoing Transactions   "
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.White
        Me.Label32.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label32.Location = New System.Drawing.Point(453, 201)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(24, 24)
        Me.Label32.TabIndex = 1048
        Me.Label32.Text = "₱"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(453, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 24)
        Me.Label6.TabIndex = 1047
        Me.Label6.Text = "₱"
        '
        'Label38
        '
        Me.Label38.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label38.Location = New System.Drawing.Point(447, 178)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(58, 18)
        Me.Label38.TabIndex = 1046
        Me.Label38.Text = "CHANGE:"
        '
        'tbxOnGChange
        '
        Me.tbxOnGChange.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxOnGChange.BackColor = System.Drawing.Color.White
        Me.tbxOnGChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxOnGChange.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxOnGChange.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxOnGChange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxOnGChange.Location = New System.Drawing.Point(450, 199)
        Me.tbxOnGChange.Name = "tbxOnGChange"
        Me.tbxOnGChange.ReadOnly = True
        Me.tbxOnGChange.Size = New System.Drawing.Size(277, 30)
        Me.tbxOnGChange.TabIndex = 1045
        Me.tbxOnGChange.TabStop = False
        Me.tbxOnGChange.Text = "0.00"
        Me.tbxOnGChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label37
        '
        Me.Label37.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label37.Location = New System.Drawing.Point(447, 104)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(64, 18)
        Me.Label37.TabIndex = 1044
        Me.Label37.Text = "PAYMENT:"
        '
        'tbxOnGNewPayment
        '
        Me.tbxOnGNewPayment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxOnGNewPayment.BackColor = System.Drawing.Color.White
        Me.tbxOnGNewPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxOnGNewPayment.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxOnGNewPayment.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxOnGNewPayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxOnGNewPayment.Location = New System.Drawing.Point(450, 125)
        Me.tbxOnGNewPayment.MaxLength = 6
        Me.tbxOnGNewPayment.Name = "tbxOnGNewPayment"
        Me.tbxOnGNewPayment.Size = New System.Drawing.Size(277, 30)
        Me.tbxOnGNewPayment.TabIndex = 1043
        Me.tbxOnGNewPayment.TabStop = False
        Me.tbxOnGNewPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.White
        Me.Label27.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(123, 216)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(24, 24)
        Me.Label27.TabIndex = 1042
        Me.Label27.Text = "₱"
        '
        'Label30
        '
        Me.Label30.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label30.Location = New System.Drawing.Point(117, 192)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(130, 18)
        Me.Label30.TabIndex = 1041
        Me.Label30.Text = "REMAINING BALANCE:"
        '
        'tbxOnGRemBalance
        '
        Me.tbxOnGRemBalance.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxOnGRemBalance.BackColor = System.Drawing.Color.White
        Me.tbxOnGRemBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxOnGRemBalance.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxOnGRemBalance.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxOnGRemBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxOnGRemBalance.Location = New System.Drawing.Point(120, 213)
        Me.tbxOnGRemBalance.Name = "tbxOnGRemBalance"
        Me.tbxOnGRemBalance.ReadOnly = True
        Me.tbxOnGRemBalance.Size = New System.Drawing.Size(277, 30)
        Me.tbxOnGRemBalance.TabIndex = 1040
        Me.tbxOnGRemBalance.TabStop = False
        Me.tbxOnGRemBalance.Text = "0.00"
        Me.tbxOnGRemBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxOnGTourGuide
        '
        Me.tbxOnGTourGuide.BackColor = System.Drawing.Color.White
        Me.tbxOnGTourGuide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxOnGTourGuide.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxOnGTourGuide.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxOnGTourGuide.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxOnGTourGuide.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxOnGTourGuide.Location = New System.Drawing.Point(52, 199)
        Me.tbxOnGTourGuide.Name = "tbxOnGTourGuide"
        Me.tbxOnGTourGuide.ReadOnly = True
        Me.tbxOnGTourGuide.Size = New System.Drawing.Size(348, 30)
        Me.tbxOnGTourGuide.TabIndex = 1007
        '
        'btnOnGAtv
        '
        Me.btnOnGAtv.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnOnGAtv.BackColor = System.Drawing.Color.Gainsboro
        Me.btnOnGAtv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOnGAtv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnOnGAtv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOnGAtv.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOnGAtv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnOnGAtv.Location = New System.Drawing.Point(506, 253)
        Me.btnOnGAtv.Name = "btnOnGAtv"
        Me.btnOnGAtv.Size = New System.Drawing.Size(162, 51)
        Me.btnOnGAtv.TabIndex = 6
        Me.btnOnGAtv.Text = "View ATVs in use"
        Me.btnOnGAtv.UseVisualStyleBackColor = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label34.Location = New System.Drawing.Point(49, 178)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(79, 18)
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
        Me.lblOnGClear.Location = New System.Drawing.Point(877, 249)
        Me.lblOnGClear.Name = "lblOnGClear"
        Me.lblOnGClear.Size = New System.Drawing.Size(75, 18)
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
        Me.btnEndTrail.Location = New System.Drawing.Point(816, 166)
        Me.btnEndTrail.Name = "btnEndTrail"
        Me.btnEndTrail.Size = New System.Drawing.Size(185, 59)
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
        Me.Label28.Location = New System.Drawing.Point(454, 53)
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
        Me.tbxOnGPerson.Location = New System.Drawing.Point(242, 274)
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
        Me.Label29.Location = New System.Drawing.Point(239, 253)
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
        Me.Label31.Location = New System.Drawing.Point(49, 104)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(78, 18)
        Me.Label31.TabIndex = 156
        Me.Label31.Text = "TOUR NAME:"
        '
        'tbxOnGTour
        '
        Me.tbxOnGTour.BackColor = System.Drawing.Color.White
        Me.tbxOnGTour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxOnGTour.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxOnGTour.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxOnGTour.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxOnGTour.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxOnGTour.Location = New System.Drawing.Point(52, 125)
        Me.tbxOnGTour.Name = "tbxOnGTour"
        Me.tbxOnGTour.ReadOnly = True
        Me.tbxOnGTour.Size = New System.Drawing.Size(348, 30)
        Me.tbxOnGTour.TabIndex = 1
        '
        'tbxOnGTotal
        '
        Me.tbxOnGTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbxOnGTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxOnGTotal.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxOnGTotal.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxOnGTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxOnGTotal.Location = New System.Drawing.Point(450, 51)
        Me.tbxOnGTotal.MaxLength = 11
        Me.tbxOnGTotal.Name = "tbxOnGTotal"
        Me.tbxOnGTotal.ReadOnly = True
        Me.tbxOnGTotal.Size = New System.Drawing.Size(277, 30)
        Me.tbxOnGTotal.TabIndex = 4
        Me.tbxOnGTotal.Text = "0.00"
        Me.tbxOnGTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.Label36.Location = New System.Drawing.Point(447, 30)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(82, 18)
        Me.Label36.TabIndex = 150
        Me.Label36.Text = "TOTAL PRICE:"
        '
        'tbxTransacID
        '
        Me.tbxTransacID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxTransacID.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.tbxTransacID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxTransacID.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxTransacID.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxTransacID.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tbxTransacID.Location = New System.Drawing.Point(837, 323)
        Me.tbxTransacID.MaxLength = 11
        Me.tbxTransacID.Name = "tbxTransacID"
        Me.tbxTransacID.ReadOnly = True
        Me.tbxTransacID.Size = New System.Drawing.Size(252, 14)
        Me.tbxTransacID.TabIndex = 10
        Me.tbxTransacID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTodayTransac
        '
        Me.lblTodayTransac.BackColor = System.Drawing.Color.Transparent
        Me.lblTodayTransac.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodayTransac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.lblTodayTransac.Location = New System.Drawing.Point(26, 12)
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
        Me.lblWaiting.Location = New System.Drawing.Point(260, 14)
        Me.lblWaiting.Name = "lblWaiting"
        Me.lblWaiting.Size = New System.Drawing.Size(72, 18)
        Me.lblWaiting.TabIndex = 130
        Me.lblWaiting.Text = "Waiting: 0"
        '
        'lblOngoing
        '
        Me.lblOngoing.AutoSize = True
        Me.lblOngoing.BackColor = System.Drawing.Color.Transparent
        Me.lblOngoing.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOngoing.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblOngoing.Location = New System.Drawing.Point(389, 14)
        Me.lblOngoing.Name = "lblOngoing"
        Me.lblOngoing.Size = New System.Drawing.Size(75, 18)
        Me.lblOngoing.TabIndex = 131
        Me.lblOngoing.Text = "Ongoing: 0"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.White
        Me.Label40.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label40.Location = New System.Drawing.Point(591, 267)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(24, 24)
        Me.Label40.TabIndex = 1048
        Me.Label40.Text = "₱"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.Color.White
        Me.Label41.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label41.Location = New System.Drawing.Point(610, 213)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(24, 24)
        Me.Label41.TabIndex = 1047
        Me.Label41.Text = "₱"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.White
        Me.Label42.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label42.Location = New System.Drawing.Point(610, 140)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(24, 24)
        Me.Label42.TabIndex = 1046
        Me.Label42.Text = "₱"
        '
        'Label43
        '
        Me.Label43.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label43.Location = New System.Drawing.Point(604, 116)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(130, 18)
        Me.Label43.TabIndex = 1045
        Me.Label43.Text = "REMAINING BALANCE:"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(607, 137)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(196, 30)
        Me.TextBox1.TabIndex = 1041
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "0.00"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label44
        '
        Me.Label44.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label44.Location = New System.Drawing.Point(604, 189)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(58, 18)
        Me.Label44.TabIndex = 1044
        Me.Label44.Text = "CHANGE:"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(607, 210)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(196, 30)
        Me.TextBox2.TabIndex = 1042
        Me.TextBox2.TabStop = False
        Me.TextBox2.Text = "0.00"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label45.Location = New System.Drawing.Point(584, 244)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(107, 18)
        Me.Label45.TabIndex = 1043
        Me.Label45.Text = "INITIAL PAYMENT:"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.TextBox3.Location = New System.Drawing.Point(587, 265)
        Me.TextBox3.MaxLength = 6
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(311, 30)
        Me.TextBox3.TabIndex = 1040
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxOnGTime
        '
        Me.tbxOnGTime.BackColor = System.Drawing.Color.White
        Me.tbxOnGTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxOnGTime.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxOnGTime.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxOnGTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxOnGTime.Location = New System.Drawing.Point(120, 277)
        Me.tbxOnGTime.Name = "tbxOnGTime"
        Me.tbxOnGTime.ReadOnly = True
        Me.tbxOnGTime.Size = New System.Drawing.Size(153, 30)
        Me.tbxOnGTime.TabIndex = 2
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label33.Location = New System.Drawing.Point(117, 256)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(70, 18)
        Me.Label33.TabIndex = 158
        Me.Label33.Text = "TIME SLOT:"
        '
        'ctrlTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.lblOngoing)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.lblWaiting)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.lblTodayTransac)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.tabTransactions)
        Me.Controls.Add(Me.tbxOnGRemBalance)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.tbxOnGTime)
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
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvTransactions As DataGridView
    Friend WithEvents tabTransactions As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents tbxTransacID As TextBox
    Friend WithEvents lblTodayTransac As Label
    Friend WithEvents lblWaiting As Label
    Friend WithEvents lblOngoing As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents tbxOnGPerson As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents tbxOnGName As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents tbxOnGTour As TextBox
    Friend WithEvents tbxOnGTotal As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents lblOnGClear As Label
    Friend WithEvents btnEndTrail As Button
    Friend WithEvents Label34 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnOnGAtv As Button
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
    Friend WithEvents TextBox6 As TextBox
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
    Friend WithEvents tbxAddInitPayment As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents tbxAddBalance As TextBox
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
    Friend WithEvents Label27 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents tbxOnGRemBalance As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents tbxOnGChange As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents tbxOnGNewPayment As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Label32 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label45 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents tbxOnGTime As TextBox
    Friend WithEvents Label33 As Label
End Class
