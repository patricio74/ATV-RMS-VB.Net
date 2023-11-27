<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlReservations
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnDelRes = New System.Windows.Forms.Button()
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
        Me.btnViewRes = New System.Windows.Forms.Button()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTransactions = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbxReservFilter = New System.Windows.Forms.ComboBox()
        Me.tabTransactions = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
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
        Me.lblTodayCanceled = New System.Windows.Forms.Label()
        Me.lblTodayPending = New System.Windows.Forms.Label()
        Me.lblTodayRes = New System.Windows.Forms.Label()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTransactions.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.btnDelRes)
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
        'btnDelRes
        '
        Me.btnDelRes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDelRes.BackColor = System.Drawing.Color.Firebrick
        Me.btnDelRes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelRes.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnDelRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelRes.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelRes.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDelRes.Location = New System.Drawing.Point(831, 153)
        Me.btnDelRes.Name = "btnDelRes"
        Me.btnDelRes.Size = New System.Drawing.Size(178, 44)
        Me.btnDelRes.TabIndex = 10
        Me.btnDelRes.Text = "Cancel Reservation"
        Me.btnDelRes.UseVisualStyleBackColor = False
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
        Me.Label14.Size = New System.Drawing.Size(39, 37)
        Me.Label14.TabIndex = 129
        Me.Label14.Text = "₱"
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
        Me.lblClearUpd.Size = New System.Drawing.Size(75, 18)
        Me.lblClearUpd.TabIndex = 11
        Me.lblClearUpd.Text = "Clear Form"
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
        Me.tbxReservPerson.TabIndex = 5
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
        Me.Label10.Size = New System.Drawing.Size(85, 18)
        Me.Label10.TabIndex = 123
        Me.Label10.Text = "# OF PERSON:"
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
        Me.tbxReservFName.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(415, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 18)
        Me.Label9.TabIndex = 122
        Me.Label9.Text = "RESERVATION DATE:"
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
        Me.dateTimeReserv.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(415, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 18)
        Me.Label7.TabIndex = 120
        Me.Label7.Text = "TIME SLOT:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(53, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 18)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "MIDDLE NAME:"
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
        Me.cbxReservTimeSlot.TabIndex = 6
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
        Me.cbxReservStatus.Items.AddRange(New Object() {"PENDING", "CANCELED"})
        Me.cbxReservStatus.Location = New System.Drawing.Point(549, 188)
        Me.cbxReservStatus.Name = "cbxReservStatus"
        Me.cbxReservStatus.Size = New System.Drawing.Size(121, 30)
        Me.cbxReservStatus.TabIndex = 7
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
        Me.tbxReservMName.TabIndex = 1
        '
        'btnUpdRes
        '
        Me.btnUpdRes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnUpdRes.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUpdRes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdRes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnUpdRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdRes.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdRes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnUpdRes.Location = New System.Drawing.Point(723, 153)
        Me.btnUpdRes.Name = "btnUpdRes"
        Me.btnUpdRes.Size = New System.Drawing.Size(102, 44)
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
        Me.Label8.Location = New System.Drawing.Point(546, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 18)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "STATUS:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(53, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 18)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "SURNAME:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(415, 40)
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
        Me.tbxReservTotal.Location = New System.Drawing.Point(723, 81)
        Me.tbxReservTotal.MaxLength = 11
        Me.tbxReservTotal.Name = "tbxReservTotal"
        Me.tbxReservTotal.ReadOnly = True
        Me.tbxReservTotal.Size = New System.Drawing.Size(286, 41)
        Me.tbxReservTotal.TabIndex = 8
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
        Me.cbxReservTour.TabIndex = 3
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
        Me.tbxReservSName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(53, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 18)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "FIRST NAME:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(720, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 18)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "TOTAL PRICE:"
        '
        'btnViewRes
        '
        Me.btnViewRes.BackColor = System.Drawing.Color.Gainsboro
        Me.btnViewRes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewRes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnViewRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewRes.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewRes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnViewRes.Location = New System.Drawing.Point(1073, 18)
        Me.btnViewRes.Name = "btnViewRes"
        Me.btnViewRes.Size = New System.Drawing.Size(60, 27)
        Me.btnViewRes.TabIndex = 135
        Me.btnViewRes.Text = "View"
        Me.btnViewRes.UseVisualStyleBackColor = False
        Me.btnViewRes.Visible = False
        '
        'Column8
        '
        Me.Column8.HeaderText = "STATUS"
        Me.Column8.Name = "Column8"
        '
        'Column7
        '
        Me.Column7.HeaderText = "TIME SLOT"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 110
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "DATE"
        Me.Column6.Name = "Column6"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "SURNAME"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "MIDDLE NAME"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "FIRST NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 25
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
        Me.dgvTransactions.EnableHeadersVisualStyles = False
        Me.dgvTransactions.GridColor = System.Drawing.Color.DimGray
        Me.dgvTransactions.Location = New System.Drawing.Point(30, 59)
        Me.dgvTransactions.MultiSelect = False
        Me.dgvTransactions.Name = "dgvTransactions"
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
        Me.dgvTransactions.Size = New System.Drawing.Size(1103, 303)
        Me.dgvTransactions.TabIndex = 134
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "TOUR NAME"
        Me.Column5.Name = "Column5"
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
        Me.cbxReservFilter.Items.AddRange(New Object() {"PENDING", "CANCELED"})
        Me.cbxReservFilter.Location = New System.Drawing.Point(925, 18)
        Me.cbxReservFilter.Name = "cbxReservFilter"
        Me.cbxReservFilter.Size = New System.Drawing.Size(142, 26)
        Me.cbxReservFilter.TabIndex = 133
        Me.cbxReservFilter.Visible = False
        '
        'tabTransactions
        '
        Me.tabTransactions.Controls.Add(Me.TabPage1)
        Me.tabTransactions.Controls.Add(Me.TabPage2)
        Me.tabTransactions.Location = New System.Drawing.Point(45, 385)
        Me.tabTransactions.Name = "tabTransactions"
        Me.tabTransactions.SelectedIndex = 0
        Me.tabTransactions.Size = New System.Drawing.Size(1074, 313)
        Me.tabTransactions.TabIndex = 136
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.lblClearNew)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.tbxNewPerson)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.tbxNewFName)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.cbxNewTimeSlot)
        Me.TabPage1.Controls.Add(Me.cbxNewStatus)
        Me.TabPage1.Controls.Add(Me.tbxNewMName)
        Me.TabPage1.Controls.Add(Me.Label23)
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
        Me.TabPage1.Size = New System.Drawing.Size(1066, 280)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "  Add Reservation   "
        '
        'lblClearNew
        '
        Me.lblClearNew.AutoSize = True
        Me.lblClearNew.BackColor = System.Drawing.Color.Transparent
        Me.lblClearNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClearNew.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearNew.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblClearNew.Location = New System.Drawing.Point(850, 208)
        Me.lblClearNew.Name = "lblClearNew"
        Me.lblClearNew.Size = New System.Drawing.Size(75, 18)
        Me.lblClearNew.TabIndex = 10
        Me.lblClearNew.Text = "Clear Form"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(750, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 37)
        Me.Label5.TabIndex = 147
        Me.Label5.Text = "₱"
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
        Me.tbxNewPerson.TabIndex = 5
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
        Me.tbxNewFName.Location = New System.Drawing.Point(63, 58)
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
        Me.Label21.Location = New System.Drawing.Point(418, 168)
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
        Me.Label22.Location = New System.Drawing.Point(60, 104)
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
        Me.cbxNewTimeSlot.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxNewTimeSlot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cbxNewTimeSlot.FormattingEnabled = True
        Me.cbxNewTimeSlot.ItemHeight = 22
        Me.cbxNewTimeSlot.Items.AddRange(New Object() {"MORNING", "AFTERNOON", "EVENING"})
        Me.cbxNewTimeSlot.Location = New System.Drawing.Point(421, 187)
        Me.cbxNewTimeSlot.Name = "cbxNewTimeSlot"
        Me.cbxNewTimeSlot.Size = New System.Drawing.Size(116, 30)
        Me.cbxNewTimeSlot.TabIndex = 6
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
        Me.cbxNewStatus.TabIndex = 7
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
        Me.tbxNewMName.TabIndex = 1
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label23.Location = New System.Drawing.Point(554, 168)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(52, 18)
        Me.Label23.TabIndex = 133
        Me.Label23.Text = "STATUS:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label24.Location = New System.Drawing.Point(60, 168)
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
        Me.Label25.Location = New System.Drawing.Point(418, 39)
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
        Me.tbxNewTotal.Location = New System.Drawing.Point(746, 81)
        Me.tbxNewTotal.MaxLength = 11
        Me.tbxNewTotal.Name = "tbxNewTotal"
        Me.tbxNewTotal.ReadOnly = True
        Me.tbxNewTotal.Size = New System.Drawing.Size(272, 41)
        Me.tbxNewTotal.TabIndex = 8
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
        Me.cbxNewTour.TabIndex = 3
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
        Me.tbxNewSName.TabIndex = 2
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label26.Location = New System.Drawing.Point(60, 39)
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
        Me.Label27.Location = New System.Drawing.Point(743, 60)
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
        Me.btnAddRes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnAddRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRes.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnAddRes.Location = New System.Drawing.Point(788, 156)
        Me.btnAddRes.Name = "btnAddRes"
        Me.btnAddRes.Size = New System.Drawing.Size(194, 44)
        Me.btnAddRes.TabIndex = 9
        Me.btnAddRes.Text = "Save Reservation"
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
        Me.dateTimeNew.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Location = New System.Drawing.Point(418, 103)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 18)
        Me.Label12.TabIndex = 122
        Me.Label12.Text = "RESERVATION DATE:"
        '
        'lblTodayCanceled
        '
        Me.lblTodayCanceled.AutoSize = True
        Me.lblTodayCanceled.BackColor = System.Drawing.Color.Transparent
        Me.lblTodayCanceled.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodayCanceled.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTodayCanceled.Location = New System.Drawing.Point(584, 31)
        Me.lblTodayCanceled.Name = "lblTodayCanceled"
        Me.lblTodayCanceled.Size = New System.Drawing.Size(81, 18)
        Me.lblTodayCanceled.TabIndex = 139
        Me.lblTodayCanceled.Text = "Canceled: 0"
        '
        'lblTodayPending
        '
        Me.lblTodayPending.AutoSize = True
        Me.lblTodayPending.BackColor = System.Drawing.Color.Transparent
        Me.lblTodayPending.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodayPending.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTodayPending.Location = New System.Drawing.Point(466, 31)
        Me.lblTodayPending.Name = "lblTodayPending"
        Me.lblTodayPending.Size = New System.Drawing.Size(74, 18)
        Me.lblTodayPending.TabIndex = 138
        Me.lblTodayPending.Text = "Pending: 0"
        '
        'lblTodayRes
        '
        Me.lblTodayRes.BackColor = System.Drawing.Color.Transparent
        Me.lblTodayRes.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodayRes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.lblTodayRes.Location = New System.Drawing.Point(456, 9)
        Me.lblTodayRes.Name = "lblTodayRes"
        Me.lblTodayRes.Size = New System.Drawing.Size(229, 20)
        Me.lblTodayRes.TabIndex = 137
        Me.lblTodayRes.Text = "TOTAL RESERVATIONS "
        Me.lblTodayRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ctrlReservations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.lblTodayCanceled)
        Me.Controls.Add(Me.lblTodayPending)
        Me.Controls.Add(Me.lblTodayRes)
        Me.Controls.Add(Me.btnViewRes)
        Me.Controls.Add(Me.dgvTransactions)
        Me.Controls.Add(Me.cbxReservFilter)
        Me.Controls.Add(Me.tabTransactions)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ctrlReservations"
        Me.Size = New System.Drawing.Size(1161, 738)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTransactions.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents btnViewRes As Button
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents dgvTransactions As DataGridView
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents cbxReservFilter As ComboBox
    Friend WithEvents tabTransactions As TabControl
    Friend WithEvents TabPage1 As TabPage
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
    Friend WithEvents btnDelRes As Button
    Friend WithEvents lblTodayCanceled As Label
    Friend WithEvents lblTodayPending As Label
    Friend WithEvents lblTodayRes As Label
End Class
