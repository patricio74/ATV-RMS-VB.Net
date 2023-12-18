<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrlReservations
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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tbxReservInitPaid = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbxReservTimeSlot = New System.Windows.Forms.TextBox()
        Me.tbxReservDate = New System.Windows.Forms.TextBox()
        Me.btnMoveToWaitList = New System.Windows.Forms.Button()
        Me.tbxReservTour = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbxReservBalance = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxReservPerson = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbxReservCustName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxReservStatus = New System.Windows.Forms.ComboBox()
        Me.btnUpdRes = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbxReservTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnFilterRes = New System.Windows.Forms.Button()
        Me.dgvReservs = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbxReservFilter = New System.Windows.Forms.ComboBox()
        Me.tabReservations = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.rad100 = New System.Windows.Forms.RadioButton()
        Me.rad75 = New System.Windows.Forms.RadioButton()
        Me.rad50 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tbxNewInitPayment = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbxNewBalance = New System.Windows.Forms.TextBox()
        Me.lblTourPrice = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.cbxNewPerson = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbxNewFName = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cbxNewTimeSlot = New System.Windows.Forms.ComboBox()
        Me.tbxNewMName = New System.Windows.Forms.TextBox()
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
        Me.lblClearForm = New System.Windows.Forms.Label()
        Me.lblPendingRes = New System.Windows.Forms.Label()
        Me.lblTodayRes = New System.Windows.Forms.Label()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvReservs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabReservations.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.tbxReservInitPaid)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.tbxReservTimeSlot)
        Me.TabPage2.Controls.Add(Me.tbxReservDate)
        Me.TabPage2.Controls.Add(Me.btnMoveToWaitList)
        Me.TabPage2.Controls.Add(Me.tbxReservTour)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.tbxReservBalance)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.tbxReservPerson)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.tbxReservCustName)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.cbxReservStatus)
        Me.TabPage2.Controls.Add(Me.btnUpdRes)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.tbxReservTotal)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1095, 280)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "  Update Reservation   "
        '
        'tbxReservInitPaid
        '
        Me.tbxReservInitPaid.BackColor = System.Drawing.Color.White
        Me.tbxReservInitPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxReservInitPaid.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxReservInitPaid.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxReservInitPaid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxReservInitPaid.Location = New System.Drawing.Point(529, 54)
        Me.tbxReservInitPaid.Name = "tbxReservInitPaid"
        Me.tbxReservInitPaid.ReadOnly = True
        Me.tbxReservInitPaid.Size = New System.Drawing.Size(205, 30)
        Me.tbxReservInitPaid.TabIndex = 143
        Me.tbxReservInitPaid.Text = "0.00"
        Me.tbxReservInitPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label15.Location = New System.Drawing.Point(448, 62)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 18)
        Me.Label15.TabIndex = 142
        Me.Label15.Text = "TOTAL PAID:"
        '
        'tbxReservTimeSlot
        '
        Me.tbxReservTimeSlot.BackColor = System.Drawing.Color.White
        Me.tbxReservTimeSlot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxReservTimeSlot.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxReservTimeSlot.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxReservTimeSlot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxReservTimeSlot.Location = New System.Drawing.Point(196, 205)
        Me.tbxReservTimeSlot.Name = "tbxReservTimeSlot"
        Me.tbxReservTimeSlot.ReadOnly = True
        Me.tbxReservTimeSlot.Size = New System.Drawing.Size(112, 30)
        Me.tbxReservTimeSlot.TabIndex = 141
        '
        'tbxReservDate
        '
        Me.tbxReservDate.BackColor = System.Drawing.Color.White
        Me.tbxReservDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxReservDate.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxReservDate.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxReservDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxReservDate.Location = New System.Drawing.Point(50, 205)
        Me.tbxReservDate.Name = "tbxReservDate"
        Me.tbxReservDate.ReadOnly = True
        Me.tbxReservDate.Size = New System.Drawing.Size(133, 30)
        Me.tbxReservDate.TabIndex = 140
        '
        'btnMoveToWaitList
        '
        Me.btnMoveToWaitList.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnMoveToWaitList.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnMoveToWaitList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMoveToWaitList.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnMoveToWaitList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoveToWaitList.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveToWaitList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMoveToWaitList.Location = New System.Drawing.Point(800, 147)
        Me.btnMoveToWaitList.Name = "btnMoveToWaitList"
        Me.btnMoveToWaitList.Size = New System.Drawing.Size(220, 60)
        Me.btnMoveToWaitList.TabIndex = 139
        Me.btnMoveToWaitList.Text = "Move to wait list"
        Me.btnMoveToWaitList.UseVisualStyleBackColor = False
        '
        'tbxReservTour
        '
        Me.tbxReservTour.BackColor = System.Drawing.Color.White
        Me.tbxReservTour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxReservTour.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxReservTour.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxReservTour.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxReservTour.Location = New System.Drawing.Point(49, 128)
        Me.tbxReservTour.Name = "tbxReservTour"
        Me.tbxReservTour.ReadOnly = True
        Me.tbxReservTour.Size = New System.Drawing.Size(351, 30)
        Me.tbxReservTour.TabIndex = 138
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(455, 196)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 37)
        Me.Label14.TabIndex = 129
        Me.Label14.Text = "₱"
        '
        'tbxReservBalance
        '
        Me.tbxReservBalance.BackColor = System.Drawing.Color.White
        Me.tbxReservBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxReservBalance.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxReservBalance.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxReservBalance.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxReservBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxReservBalance.Location = New System.Drawing.Point(529, 114)
        Me.tbxReservBalance.Name = "tbxReservBalance"
        Me.tbxReservBalance.ReadOnly = True
        Me.tbxReservBalance.Size = New System.Drawing.Size(205, 30)
        Me.tbxReservBalance.TabIndex = 1
        Me.tbxReservBalance.Text = "0.00"
        Me.tbxReservBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(459, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 18)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "BALANCE:"
        '
        'tbxReservPerson
        '
        Me.tbxReservPerson.BackColor = System.Drawing.Color.White
        Me.tbxReservPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxReservPerson.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxReservPerson.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxReservPerson.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxReservPerson.Location = New System.Drawing.Point(319, 205)
        Me.tbxReservPerson.MaxLength = 1
        Me.tbxReservPerson.Name = "tbxReservPerson"
        Me.tbxReservPerson.ReadOnly = True
        Me.tbxReservPerson.Size = New System.Drawing.Size(82, 30)
        Me.tbxReservPerson.TabIndex = 5
        Me.tbxReservPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(316, 185)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 18)
        Me.Label10.TabIndex = 123
        Me.Label10.Text = "# OF PERSON:"
        '
        'tbxReservCustName
        '
        Me.tbxReservCustName.BackColor = System.Drawing.Color.White
        Me.tbxReservCustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxReservCustName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxReservCustName.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxReservCustName.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxReservCustName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxReservCustName.Location = New System.Drawing.Point(49, 54)
        Me.tbxReservCustName.Name = "tbxReservCustName"
        Me.tbxReservCustName.ReadOnly = True
        Me.tbxReservCustName.Size = New System.Drawing.Size(351, 30)
        Me.tbxReservCustName.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(47, 186)
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
        Me.Label7.Location = New System.Drawing.Point(193, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 18)
        Me.Label7.TabIndex = 120
        Me.Label7.Text = "TIME SLOT:"
        '
        'cbxReservStatus
        '
        Me.cbxReservStatus.BackColor = System.Drawing.Color.White
        Me.cbxReservStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbxReservStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxReservStatus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbxReservStatus.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxReservStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cbxReservStatus.FormattingEnabled = True
        Me.cbxReservStatus.ItemHeight = 22
        Me.cbxReservStatus.Items.AddRange(New Object() {"Pending", "Canceled"})
        Me.cbxReservStatus.Location = New System.Drawing.Point(783, 79)
        Me.cbxReservStatus.Name = "cbxReservStatus"
        Me.cbxReservStatus.Size = New System.Drawing.Size(115, 30)
        Me.cbxReservStatus.TabIndex = 7
        '
        'btnUpdRes
        '
        Me.btnUpdRes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnUpdRes.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUpdRes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdRes.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnUpdRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdRes.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdRes.ForeColor = System.Drawing.Color.White
        Me.btnUpdRes.Location = New System.Drawing.Point(918, 74)
        Me.btnUpdRes.Name = "btnUpdRes"
        Me.btnUpdRes.Size = New System.Drawing.Size(120, 38)
        Me.btnUpdRes.TabIndex = 9
        Me.btnUpdRes.Text = "Update"
        Me.btnUpdRes.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(780, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 18)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "CHANGE STATUS:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(46, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 18)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "TOUR NAME:"
        '
        'tbxReservTotal
        '
        Me.tbxReservTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbxReservTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxReservTotal.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxReservTotal.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxReservTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.tbxReservTotal.Location = New System.Drawing.Point(451, 194)
        Me.tbxReservTotal.MaxLength = 11
        Me.tbxReservTotal.Name = "tbxReservTotal"
        Me.tbxReservTotal.ReadOnly = True
        Me.tbxReservTotal.Size = New System.Drawing.Size(283, 41)
        Me.tbxReservTotal.TabIndex = 8
        Me.tbxReservTotal.Text = "0.00"
        Me.tbxReservTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(46, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 18)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "CUSTOMER NAME:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(448, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 18)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "TOTAL PRICE:"
        '
        'btnFilterRes
        '
        Me.btnFilterRes.BackColor = System.Drawing.Color.Gainsboro
        Me.btnFilterRes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFilterRes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnFilterRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilterRes.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilterRes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnFilterRes.Location = New System.Drawing.Point(1073, 18)
        Me.btnFilterRes.Name = "btnFilterRes"
        Me.btnFilterRes.Size = New System.Drawing.Size(60, 27)
        Me.btnFilterRes.TabIndex = 135
        Me.btnFilterRes.Text = "View"
        Me.btnFilterRes.UseVisualStyleBackColor = False
        '
        'dgvReservs
        '
        Me.dgvReservs.AllowUserToAddRows = False
        Me.dgvReservs.AllowUserToOrderColumns = True
        Me.dgvReservs.AllowUserToResizeColumns = False
        Me.dgvReservs.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvReservs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvReservs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle16.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReservs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvReservs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReservs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.dgvReservs.EnableHeadersVisualStyles = False
        Me.dgvReservs.GridColor = System.Drawing.Color.DimGray
        Me.dgvReservs.Location = New System.Drawing.Point(30, 59)
        Me.dgvReservs.MultiSelect = False
        Me.dgvReservs.Name = "dgvReservs"
        Me.dgvReservs.ReadOnly = True
        Me.dgvReservs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReservs.RowHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvReservs.RowHeadersVisible = False
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White
        Me.dgvReservs.RowsDefaultCellStyle = DataGridViewCellStyle18
        Me.dgvReservs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReservs.ShowEditingIcon = False
        Me.dgvReservs.Size = New System.Drawing.Size(1103, 320)
        Me.dgvReservs.TabIndex = 134
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
        Me.Column6.HeaderText = "RESERVATION DATE"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 180
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
        'cbxReservFilter
        '
        Me.cbxReservFilter.BackColor = System.Drawing.Color.White
        Me.cbxReservFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxReservFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxReservFilter.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxReservFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.cbxReservFilter.FormattingEnabled = True
        Me.cbxReservFilter.ItemHeight = 18
        Me.cbxReservFilter.Items.AddRange(New Object() {"All", "Pending", "Canceled"})
        Me.cbxReservFilter.Location = New System.Drawing.Point(944, 18)
        Me.cbxReservFilter.Name = "cbxReservFilter"
        Me.cbxReservFilter.Size = New System.Drawing.Size(123, 26)
        Me.cbxReservFilter.TabIndex = 133
        '
        'tabReservations
        '
        Me.tabReservations.Controls.Add(Me.TabPage1)
        Me.tabReservations.Controls.Add(Me.TabPage2)
        Me.tabReservations.Location = New System.Drawing.Point(30, 399)
        Me.tabReservations.Name = "tabReservations"
        Me.tabReservations.SelectedIndex = 0
        Me.tabReservations.Size = New System.Drawing.Size(1103, 313)
        Me.tabReservations.TabIndex = 136
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.lblTourPrice)
        Me.TabPage1.Controls.Add(Me.Label39)
        Me.TabPage1.Controls.Add(Me.cbxNewPerson)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.tbxNewFName)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.cbxNewTimeSlot)
        Me.TabPage1.Controls.Add(Me.tbxNewMName)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.tbxNewTotal)
        Me.TabPage1.Controls.Add(Me.cbxNewTour)
        Me.TabPage1.Controls.Add(Me.tbxNewSName)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.Label27)
        Me.TabPage1.Controls.Add(Me.btnAddRes)
        Me.TabPage1.Controls.Add(Me.dateTimeNew)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1095, 280)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "  Add Reservation   "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.rad100)
        Me.GroupBox1.Controls.Add(Me.rad75)
        Me.GroupBox1.Controls.Add(Me.rad50)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.tbxNewInitPayment)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.tbxNewBalance)
        Me.GroupBox1.Location = New System.Drawing.Point(751, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 155)
        Me.GroupBox1.TabIndex = 1044
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Initial Payment"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(41, 30)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 18)
        Me.Label16.TabIndex = 1048
        Me.Label16.Text = "CHOOSE:"
        '
        'rad100
        '
        Me.rad100.BackColor = System.Drawing.Color.Transparent
        Me.rad100.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad100.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.rad100.Location = New System.Drawing.Point(231, 25)
        Me.rad100.Name = "rad100"
        Me.rad100.Size = New System.Drawing.Size(58, 24)
        Me.rad100.TabIndex = 1047
        Me.rad100.TabStop = True
        Me.rad100.Text = "100%"
        Me.rad100.UseVisualStyleBackColor = False
        '
        'rad75
        '
        Me.rad75.BackColor = System.Drawing.Color.Transparent
        Me.rad75.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad75.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.rad75.Location = New System.Drawing.Point(167, 25)
        Me.rad75.Name = "rad75"
        Me.rad75.Size = New System.Drawing.Size(58, 24)
        Me.rad75.TabIndex = 1046
        Me.rad75.TabStop = True
        Me.rad75.Text = "75%"
        Me.rad75.UseVisualStyleBackColor = False
        '
        'rad50
        '
        Me.rad50.BackColor = System.Drawing.Color.Transparent
        Me.rad50.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad50.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.rad50.Location = New System.Drawing.Point(103, 25)
        Me.rad50.Name = "rad50"
        Me.rad50.Size = New System.Drawing.Size(58, 24)
        Me.rad50.TabIndex = 1045
        Me.rad50.TabStop = True
        Me.rad50.Text = "50%"
        Me.rad50.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(15, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 18)
        Me.Label3.TabIndex = 1044
        Me.Label3.Text = "EQUIVALENT:"
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(107, 61)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(24, 24)
        Me.Label23.TabIndex = 1036
        Me.Label23.Text = "₱"
        '
        'tbxNewInitPayment
        '
        Me.tbxNewInitPayment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxNewInitPayment.BackColor = System.Drawing.Color.White
        Me.tbxNewInitPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxNewInitPayment.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNewInitPayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxNewInitPayment.Location = New System.Drawing.Point(103, 59)
        Me.tbxNewInitPayment.MaxLength = 6
        Me.tbxNewInitPayment.Name = "tbxNewInitPayment"
        Me.tbxNewInitPayment.ReadOnly = True
        Me.tbxNewInitPayment.Size = New System.Drawing.Size(179, 30)
        Me.tbxNewInitPayment.TabIndex = 1034
        Me.tbxNewInitPayment.Text = "0.00"
        Me.tbxNewInitPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(33, 113)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 18)
        Me.Label11.TabIndex = 1041
        Me.Label11.Text = "BALANCE:"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(107, 107)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 24)
        Me.Label13.TabIndex = 1043
        Me.Label13.Text = "₱"
        '
        'tbxNewBalance
        '
        Me.tbxNewBalance.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxNewBalance.BackColor = System.Drawing.Color.White
        Me.tbxNewBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxNewBalance.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxNewBalance.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNewBalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxNewBalance.Location = New System.Drawing.Point(103, 105)
        Me.tbxNewBalance.Name = "tbxNewBalance"
        Me.tbxNewBalance.ReadOnly = True
        Me.tbxNewBalance.Size = New System.Drawing.Size(179, 30)
        Me.tbxNewBalance.TabIndex = 1042
        Me.tbxNewBalance.Text = "0.00"
        Me.tbxNewBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTourPrice
        '
        Me.lblTourPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTourPrice.AutoSize = True
        Me.lblTourPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblTourPrice.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTourPrice.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTourPrice.Location = New System.Drawing.Point(647, 30)
        Me.lblTourPrice.Name = "lblTourPrice"
        Me.lblTourPrice.Size = New System.Drawing.Size(33, 18)
        Me.lblTourPrice.TabIndex = 1039
        Me.lblTourPrice.Text = "0.00"
        Me.lblTourPrice.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label39.Location = New System.Drawing.Point(593, 29)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(54, 18)
        Me.Label39.TabIndex = 1040
        Me.Label39.Text = "PRICE: ₱"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'cbxNewPerson
        '
        Me.cbxNewPerson.BackColor = System.Drawing.Color.White
        Me.cbxNewPerson.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbxNewPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxNewPerson.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbxNewPerson.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxNewPerson.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cbxNewPerson.FormattingEnabled = True
        Me.cbxNewPerson.ItemHeight = 22
        Me.cbxNewPerson.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cbxNewPerson.Location = New System.Drawing.Point(664, 127)
        Me.cbxNewPerson.Name = "cbxNewPerson"
        Me.cbxNewPerson.Size = New System.Drawing.Size(53, 30)
        Me.cbxNewPerson.TabIndex = 1018
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(427, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 37)
        Me.Label5.TabIndex = 147
        Me.Label5.Text = "₱"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label19.Location = New System.Drawing.Point(632, 109)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 18)
        Me.Label19.TabIndex = 145
        Me.Label19.Text = "# OF PERSON:"
        '
        'tbxNewFName
        '
        Me.tbxNewFName.BackColor = System.Drawing.Color.White
        Me.tbxNewFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxNewFName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxNewFName.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNewFName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxNewFName.Location = New System.Drawing.Point(39, 50)
        Me.tbxNewFName.Name = "tbxNewFName"
        Me.tbxNewFName.Size = New System.Drawing.Size(311, 30)
        Me.tbxNewFName.TabIndex = 0
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label21.Location = New System.Drawing.Point(525, 109)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(70, 18)
        Me.Label21.TabIndex = 143
        Me.Label21.Text = "TIME SLOT:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label22.Location = New System.Drawing.Point(36, 108)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(92, 18)
        Me.Label22.TabIndex = 137
        Me.Label22.Text = "MIDDLE NAME:"
        '
        'cbxNewTimeSlot
        '
        Me.cbxNewTimeSlot.BackColor = System.Drawing.Color.White
        Me.cbxNewTimeSlot.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbxNewTimeSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxNewTimeSlot.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbxNewTimeSlot.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxNewTimeSlot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cbxNewTimeSlot.FormattingEnabled = True
        Me.cbxNewTimeSlot.ItemHeight = 22
        Me.cbxNewTimeSlot.Items.AddRange(New Object() {"Morning", "Afternoon", "Evening"})
        Me.cbxNewTimeSlot.Location = New System.Drawing.Point(528, 128)
        Me.cbxNewTimeSlot.Name = "cbxNewTimeSlot"
        Me.cbxNewTimeSlot.Size = New System.Drawing.Size(113, 30)
        Me.cbxNewTimeSlot.TabIndex = 6
        '
        'tbxNewMName
        '
        Me.tbxNewMName.BackColor = System.Drawing.Color.White
        Me.tbxNewMName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxNewMName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxNewMName.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNewMName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxNewMName.Location = New System.Drawing.Point(39, 127)
        Me.tbxNewMName.Name = "tbxNewMName"
        Me.tbxNewMName.Size = New System.Drawing.Size(311, 30)
        Me.tbxNewMName.TabIndex = 1
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label24.Location = New System.Drawing.Point(36, 187)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(66, 18)
        Me.Label24.TabIndex = 139
        Me.Label24.Text = "SURNAME:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label25.Location = New System.Drawing.Point(391, 31)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(78, 18)
        Me.Label25.TabIndex = 141
        Me.Label25.Text = "TOUR NAME:"
        '
        'tbxNewTotal
        '
        Me.tbxNewTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbxNewTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxNewTotal.Cursor = System.Windows.Forms.Cursors.No
        Me.tbxNewTotal.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNewTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.tbxNewTotal.Location = New System.Drawing.Point(423, 196)
        Me.tbxNewTotal.MaxLength = 11
        Me.tbxNewTotal.Name = "tbxNewTotal"
        Me.tbxNewTotal.ReadOnly = True
        Me.tbxNewTotal.Size = New System.Drawing.Size(267, 41)
        Me.tbxNewTotal.TabIndex = 8
        Me.tbxNewTotal.Text = "0.00"
        Me.tbxNewTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbxNewTour
        '
        Me.cbxNewTour.BackColor = System.Drawing.Color.White
        Me.cbxNewTour.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbxNewTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxNewTour.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbxNewTour.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxNewTour.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cbxNewTour.FormattingEnabled = True
        Me.cbxNewTour.ItemHeight = 22
        Me.cbxNewTour.Location = New System.Drawing.Point(394, 50)
        Me.cbxNewTour.Name = "cbxNewTour"
        Me.cbxNewTour.Size = New System.Drawing.Size(323, 30)
        Me.cbxNewTour.TabIndex = 3
        '
        'tbxNewSName
        '
        Me.tbxNewSName.BackColor = System.Drawing.Color.White
        Me.tbxNewSName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxNewSName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxNewSName.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNewSName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxNewSName.Location = New System.Drawing.Point(39, 206)
        Me.tbxNewSName.Name = "tbxNewSName"
        Me.tbxNewSName.Size = New System.Drawing.Size(311, 30)
        Me.tbxNewSName.TabIndex = 2
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label26.Location = New System.Drawing.Point(36, 31)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(79, 18)
        Me.Label26.TabIndex = 135
        Me.Label26.Text = "FIRST NAME:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label27.Location = New System.Drawing.Point(420, 175)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(82, 18)
        Me.Label27.TabIndex = 131
        Me.Label27.Text = "TOTAL PRICE:"
        '
        'btnAddRes
        '
        Me.btnAddRes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddRes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnAddRes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddRes.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRes.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnAddRes.Location = New System.Drawing.Point(804, 197)
        Me.btnAddRes.Name = "btnAddRes"
        Me.btnAddRes.Size = New System.Drawing.Size(205, 54)
        Me.btnAddRes.TabIndex = 9
        Me.btnAddRes.Text = "Add Reservation"
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
        Me.dateTimeNew.Location = New System.Drawing.Point(394, 129)
        Me.dateTimeNew.Name = "dateTimeNew"
        Me.dateTimeNew.Size = New System.Drawing.Size(116, 26)
        Me.dateTimeNew.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Location = New System.Drawing.Point(391, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 18)
        Me.Label12.TabIndex = 122
        Me.Label12.Text = "RESERVATION DATE:"
        '
        'lblClearForm
        '
        Me.lblClearForm.AutoSize = True
        Me.lblClearForm.BackColor = System.Drawing.Color.Transparent
        Me.lblClearForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClearForm.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearForm.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblClearForm.Location = New System.Drawing.Point(1051, 399)
        Me.lblClearForm.Name = "lblClearForm"
        Me.lblClearForm.Size = New System.Drawing.Size(75, 18)
        Me.lblClearForm.TabIndex = 10
        Me.lblClearForm.Text = "Clear Form"
        '
        'lblPendingRes
        '
        Me.lblPendingRes.AutoSize = True
        Me.lblPendingRes.BackColor = System.Drawing.Color.Transparent
        Me.lblPendingRes.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendingRes.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblPendingRes.Location = New System.Drawing.Point(230, 20)
        Me.lblPendingRes.Name = "lblPendingRes"
        Me.lblPendingRes.Size = New System.Drawing.Size(74, 18)
        Me.lblPendingRes.TabIndex = 138
        Me.lblPendingRes.Text = "Pending: 0"
        '
        'lblTodayRes
        '
        Me.lblTodayRes.BackColor = System.Drawing.Color.Transparent
        Me.lblTodayRes.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodayRes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.lblTodayRes.Location = New System.Drawing.Point(26, 18)
        Me.lblTodayRes.Name = "lblTodayRes"
        Me.lblTodayRes.Size = New System.Drawing.Size(198, 20)
        Me.lblTodayRes.TabIndex = 137
        Me.lblTodayRes.Text = "TOTAL RESERVATIONS "
        Me.lblTodayRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ctrlReservations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.lblPendingRes)
        Me.Controls.Add(Me.lblTodayRes)
        Me.Controls.Add(Me.btnFilterRes)
        Me.Controls.Add(Me.cbxReservFilter)
        Me.Controls.Add(Me.lblClearForm)
        Me.Controls.Add(Me.tabReservations)
        Me.Controls.Add(Me.dgvReservs)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ctrlReservations"
        Me.Size = New System.Drawing.Size(1161, 738)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvReservs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabReservations.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label14 As Label
    Friend WithEvents tbxReservPerson As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbxReservCustName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxReservStatus As ComboBox
    Friend WithEvents tbxReservBalance As TextBox
    Friend WithEvents btnUpdRes As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbxReservTotal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnFilterRes As Button
    Friend WithEvents dgvReservs As DataGridView
    Friend WithEvents cbxReservFilter As ComboBox
    Friend WithEvents tabReservations As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lblClearForm As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents tbxNewFName As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents cbxNewTimeSlot As ComboBox
    Friend WithEvents tbxNewMName As TextBox
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
    Friend WithEvents lblPendingRes As Label
    Friend WithEvents lblTodayRes As Label
    Friend WithEvents tbxReservTour As TextBox
    Public WithEvents cbxNewPerson As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents tbxNewInitPayment As TextBox
    Friend WithEvents lblTourPrice As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents tbxNewBalance As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnMoveToWaitList As Button
    Friend WithEvents tbxReservTimeSlot As TextBox
    Friend WithEvents tbxReservDate As TextBox
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents tbxReservInitPaid As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rad100 As RadioButton
    Friend WithEvents rad75 As RadioButton
    Friend WithEvents rad50 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label16 As Label
End Class
