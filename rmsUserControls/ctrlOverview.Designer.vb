<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrlOverview
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnViewReserv = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvCustReviews = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dgvActivities = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxYear = New System.Windows.Forms.ComboBox()
        Me.cbxMonth = New System.Windows.Forms.ComboBox()
        Me.dgcReservations = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelReserv = New System.Windows.Forms.Panel()
        Me.lblReservPending = New System.Windows.Forms.Label()
        Me.lblReservCanceled = New System.Windows.Forms.Label()
        Me.lblReserv = New System.Windows.Forms.Label()
        Me.panelATV = New System.Windows.Forms.Panel()
        Me.lblAtv = New System.Windows.Forms.Label()
        Me.lblAtvMainten = New System.Windows.Forms.Label()
        Me.lblAtvInUse = New System.Windows.Forms.Label()
        Me.lblAtvAvail = New System.Windows.Forms.Label()
        Me.panelCustomer = New System.Windows.Forms.Panel()
        Me.lblCustYest = New System.Windows.Forms.Label()
        Me.lblCust = New System.Windows.Forms.Label()
        Me.lblCustMonth = New System.Windows.Forms.Label()
        Me.panelRevenue = New System.Windows.Forms.Panel()
        Me.lblRevYest = New System.Windows.Forms.Label()
        Me.lblRev = New System.Windows.Forms.Label()
        Me.lblRevMonth = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvCustReviews, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgvActivities, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgcReservations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelReserv.SuspendLayout()
        Me.panelATV.SuspendLayout()
        Me.panelCustomer.SuspendLayout()
        Me.panelRevenue.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnViewReserv
        '
        Me.btnViewReserv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnViewReserv.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnViewReserv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewReserv.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnViewReserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewReserv.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewReserv.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnViewReserv.Location = New System.Drawing.Point(345, 22)
        Me.btnViewReserv.Name = "btnViewReserv"
        Me.btnViewReserv.Size = New System.Drawing.Size(66, 27)
        Me.btnViewReserv.TabIndex = 23
        Me.btnViewReserv.Text = "View"
        Me.btnViewReserv.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.dgvCustReviews)
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(43, 172)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.GroupBox3.Size = New System.Drawing.Size(630, 246)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Customer Reviews"
        '
        'dgvCustReviews
        '
        Me.dgvCustReviews.AllowUserToAddRows = False
        Me.dgvCustReviews.AllowUserToOrderColumns = True
        Me.dgvCustReviews.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.dgvCustReviews.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCustReviews.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCustReviews.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCustReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustReviews.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dgvCustReviews.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCustReviews.EnableHeadersVisualStyles = False
        Me.dgvCustReviews.GridColor = System.Drawing.Color.DarkGray
        Me.dgvCustReviews.Location = New System.Drawing.Point(0, 23)
        Me.dgvCustReviews.MultiSelect = False
        Me.dgvCustReviews.Name = "dgvCustReviews"
        Me.dgvCustReviews.ReadOnly = True
        Me.dgvCustReviews.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCustReviews.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCustReviews.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.dgvCustReviews.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCustReviews.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustReviews.ShowEditingIcon = False
        Me.dgvCustReviews.Size = New System.Drawing.Size(630, 223)
        Me.dgvCustReviews.TabIndex = 35
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Ratings"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 175
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.HeaderText = "Review"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.GroupBox6.Controls.Add(Me.dgvActivities)
        Me.GroupBox6.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.GroupBox6.Location = New System.Drawing.Point(43, 435)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.GroupBox6.Size = New System.Drawing.Size(630, 266)
        Me.GroupBox6.TabIndex = 28
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Recent Activities"
        '
        'dgvActivities
        '
        Me.dgvActivities.AllowUserToAddRows = False
        Me.dgvActivities.AllowUserToOrderColumns = True
        Me.dgvActivities.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.dgvActivities.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvActivities.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvActivities.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActivities.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.dgvActivities.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvActivities.EnableHeadersVisualStyles = False
        Me.dgvActivities.GridColor = System.Drawing.Color.DarkGray
        Me.dgvActivities.Location = New System.Drawing.Point(0, 23)
        Me.dgvActivities.MultiSelect = False
        Me.dgvActivities.Name = "dgvActivities"
        Me.dgvActivities.ReadOnly = True
        Me.dgvActivities.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvActivities.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvActivities.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.dgvActivities.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvActivities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvActivities.ShowEditingIcon = False
        Me.dgvActivities.Size = New System.Drawing.Size(630, 243)
        Me.dgvActivities.TabIndex = 36
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 175
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cbxYear)
        Me.GroupBox1.Controls.Add(Me.cbxMonth)
        Me.GroupBox1.Controls.Add(Me.btnViewReserv)
        Me.GroupBox1.Controls.Add(Me.dgcReservations)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(690, 172)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.GroupBox1.Size = New System.Drawing.Size(424, 529)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reservations"
        '
        'cbxYear
        '
        Me.cbxYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxYear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxYear.FormattingEnabled = True
        Me.cbxYear.Location = New System.Drawing.Point(264, 21)
        Me.cbxYear.Name = "cbxYear"
        Me.cbxYear.Size = New System.Drawing.Size(75, 28)
        Me.cbxYear.TabIndex = 37
        '
        'cbxMonth
        '
        Me.cbxMonth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxMonth.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMonth.FormattingEnabled = True
        Me.cbxMonth.Items.AddRange(New Object() {"APRIL", "AUGUST", "DECEMBER", "FEBRUARY", "JANUARY", "JULY", "JUNE", "MARCH", "MAY", "NOVEMBER", "OCTOBER", "SEPTEMBER"})
        Me.cbxMonth.Location = New System.Drawing.Point(139, 21)
        Me.cbxMonth.Name = "cbxMonth"
        Me.cbxMonth.Size = New System.Drawing.Size(119, 28)
        Me.cbxMonth.TabIndex = 36
        '
        'dgcReservations
        '
        Me.dgcReservations.AllowUserToAddRows = False
        Me.dgcReservations.AllowUserToOrderColumns = True
        Me.dgcReservations.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.dgcReservations.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgcReservations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgcReservations.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgcReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgcReservations.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.dgcReservations.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgcReservations.EnableHeadersVisualStyles = False
        Me.dgcReservations.GridColor = System.Drawing.Color.DarkGray
        Me.dgcReservations.Location = New System.Drawing.Point(0, 55)
        Me.dgcReservations.MultiSelect = False
        Me.dgcReservations.Name = "dgcReservations"
        Me.dgcReservations.ReadOnly = True
        Me.dgcReservations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgcReservations.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgcReservations.RowHeadersVisible = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.dgcReservations.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgcReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgcReservations.ShowEditingIcon = False
        Me.dgcReservations.Size = New System.Drawing.Size(424, 474)
        Me.dgcReservations.TabIndex = 35
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "DAY"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 75
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.HeaderText = "RESERVATIONS"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'panelReserv
        '
        Me.panelReserv.BackColor = System.Drawing.Color.DarkOrchid
        Me.panelReserv.Controls.Add(Me.lblReservPending)
        Me.panelReserv.Controls.Add(Me.lblReservCanceled)
        Me.panelReserv.Controls.Add(Me.lblReserv)
        Me.panelReserv.Location = New System.Drawing.Point(30, 28)
        Me.panelReserv.Name = "panelReserv"
        Me.panelReserv.Size = New System.Drawing.Size(252, 124)
        Me.panelReserv.TabIndex = 38
        '
        'lblReservPending
        '
        Me.lblReservPending.BackColor = System.Drawing.Color.Transparent
        Me.lblReservPending.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblReservPending.Font = New System.Drawing.Font("Trebuchet MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReservPending.ForeColor = System.Drawing.Color.White
        Me.lblReservPending.Location = New System.Drawing.Point(0, 0)
        Me.lblReservPending.Name = "lblReservPending"
        Me.lblReservPending.Size = New System.Drawing.Size(252, 57)
        Me.lblReservPending.TabIndex = 34
        Me.lblReservPending.Text = "0"
        Me.lblReservPending.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblReservCanceled
        '
        Me.lblReservCanceled.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblReservCanceled.BackColor = System.Drawing.Color.Transparent
        Me.lblReservCanceled.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReservCanceled.ForeColor = System.Drawing.Color.LightGray
        Me.lblReservCanceled.Location = New System.Drawing.Point(3, 92)
        Me.lblReservCanceled.Name = "lblReservCanceled"
        Me.lblReservCanceled.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblReservCanceled.Size = New System.Drawing.Size(252, 23)
        Me.lblReservCanceled.TabIndex = 36
        Me.lblReservCanceled.Text = "Canceled Reservations:  0"
        Me.lblReservCanceled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblReserv
        '
        Me.lblReserv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblReserv.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblReserv.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReserv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.lblReserv.Location = New System.Drawing.Point(0, 59)
        Me.lblReserv.Name = "lblReserv"
        Me.lblReserv.Size = New System.Drawing.Size(252, 26)
        Me.lblReserv.TabIndex = 35
        Me.lblReserv.Text = "Pending Reservation"
        Me.lblReserv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelATV
        '
        Me.panelATV.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.panelATV.Controls.Add(Me.lblAtv)
        Me.panelATV.Controls.Add(Me.lblAtvMainten)
        Me.panelATV.Controls.Add(Me.lblAtvInUse)
        Me.panelATV.Controls.Add(Me.lblAtvAvail)
        Me.panelATV.Location = New System.Drawing.Point(296, 28)
        Me.panelATV.Name = "panelATV"
        Me.panelATV.Size = New System.Drawing.Size(266, 124)
        Me.panelATV.TabIndex = 39
        '
        'lblAtv
        '
        Me.lblAtv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAtv.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblAtv.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtv.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblAtv.Location = New System.Drawing.Point(0, 59)
        Me.lblAtv.Name = "lblAtv"
        Me.lblAtv.Size = New System.Drawing.Size(266, 26)
        Me.lblAtv.TabIndex = 38
        Me.lblAtv.Text = "Available ATV"
        Me.lblAtv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAtvMainten
        '
        Me.lblAtvMainten.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAtvMainten.BackColor = System.Drawing.Color.Transparent
        Me.lblAtvMainten.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtvMainten.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblAtvMainten.Location = New System.Drawing.Point(0, 102)
        Me.lblAtvMainten.Name = "lblAtvMainten"
        Me.lblAtvMainten.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblAtvMainten.Size = New System.Drawing.Size(266, 18)
        Me.lblAtvMainten.TabIndex = 40
        Me.lblAtvMainten.Text = "Under maintenance:  0"
        '
        'lblAtvInUse
        '
        Me.lblAtvInUse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAtvInUse.BackColor = System.Drawing.Color.Transparent
        Me.lblAtvInUse.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtvInUse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblAtvInUse.Location = New System.Drawing.Point(0, 80)
        Me.lblAtvInUse.Name = "lblAtvInUse"
        Me.lblAtvInUse.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblAtvInUse.Size = New System.Drawing.Size(266, 23)
        Me.lblAtvInUse.TabIndex = 39
        Me.lblAtvInUse.Text = "Currently in-use: 0"
        Me.lblAtvInUse.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblAtvAvail
        '
        Me.lblAtvAvail.BackColor = System.Drawing.Color.Transparent
        Me.lblAtvAvail.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAtvAvail.Font = New System.Drawing.Font("Trebuchet MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtvAvail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.lblAtvAvail.Location = New System.Drawing.Point(0, 0)
        Me.lblAtvAvail.Name = "lblAtvAvail"
        Me.lblAtvAvail.Size = New System.Drawing.Size(266, 57)
        Me.lblAtvAvail.TabIndex = 37
        Me.lblAtvAvail.Text = "0"
        Me.lblAtvAvail.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'panelCustomer
        '
        Me.panelCustomer.BackColor = System.Drawing.Color.SlateBlue
        Me.panelCustomer.Controls.Add(Me.lblCustYest)
        Me.panelCustomer.Controls.Add(Me.lblCust)
        Me.panelCustomer.Controls.Add(Me.lblCustMonth)
        Me.panelCustomer.Location = New System.Drawing.Point(576, 28)
        Me.panelCustomer.Name = "panelCustomer"
        Me.panelCustomer.Size = New System.Drawing.Size(264, 124)
        Me.panelCustomer.TabIndex = 41
        '
        'lblCustYest
        '
        Me.lblCustYest.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCustYest.BackColor = System.Drawing.Color.Transparent
        Me.lblCustYest.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustYest.ForeColor = System.Drawing.Color.LightGray
        Me.lblCustYest.Location = New System.Drawing.Point(0, 92)
        Me.lblCustYest.Name = "lblCustYest"
        Me.lblCustYest.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblCustYest.Size = New System.Drawing.Size(264, 23)
        Me.lblCustYest.TabIndex = 40
        Me.lblCustYest.Text = "Total number yesterday:  0"
        Me.lblCustYest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCust
        '
        Me.lblCust.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblCust.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCust.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.lblCust.Location = New System.Drawing.Point(0, 59)
        Me.lblCust.Name = "lblCust"
        Me.lblCust.Size = New System.Drawing.Size(264, 26)
        Me.lblCust.TabIndex = 38
        Me.lblCust.Text = "Customers This Month"
        Me.lblCust.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCustMonth
        '
        Me.lblCustMonth.BackColor = System.Drawing.Color.Transparent
        Me.lblCustMonth.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCustMonth.Font = New System.Drawing.Font("Trebuchet MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustMonth.ForeColor = System.Drawing.Color.White
        Me.lblCustMonth.Location = New System.Drawing.Point(0, 0)
        Me.lblCustMonth.Name = "lblCustMonth"
        Me.lblCustMonth.Size = New System.Drawing.Size(264, 57)
        Me.lblCustMonth.TabIndex = 37
        Me.lblCustMonth.Text = "0"
        Me.lblCustMonth.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'panelRevenue
        '
        Me.panelRevenue.BackColor = System.Drawing.Color.SpringGreen
        Me.panelRevenue.Controls.Add(Me.lblRevYest)
        Me.panelRevenue.Controls.Add(Me.lblRev)
        Me.panelRevenue.Controls.Add(Me.lblRevMonth)
        Me.panelRevenue.Location = New System.Drawing.Point(854, 28)
        Me.panelRevenue.Name = "panelRevenue"
        Me.panelRevenue.Size = New System.Drawing.Size(274, 124)
        Me.panelRevenue.TabIndex = 42
        '
        'lblRevYest
        '
        Me.lblRevYest.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRevYest.BackColor = System.Drawing.Color.Transparent
        Me.lblRevYest.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRevYest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblRevYest.Location = New System.Drawing.Point(0, 92)
        Me.lblRevYest.Name = "lblRevYest"
        Me.lblRevYest.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblRevYest.Size = New System.Drawing.Size(274, 23)
        Me.lblRevYest.TabIndex = 40
        Me.lblRevYest.Text = "Total yesterday:  ₱0"
        Me.lblRevYest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRev
        '
        Me.lblRev.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRev.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblRev.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRev.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblRev.Location = New System.Drawing.Point(0, 59)
        Me.lblRev.Name = "lblRev"
        Me.lblRev.Size = New System.Drawing.Size(274, 26)
        Me.lblRev.TabIndex = 38
        Me.lblRev.Text = "Revenue This Month"
        Me.lblRev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRevMonth
        '
        Me.lblRevMonth.BackColor = System.Drawing.Color.Transparent
        Me.lblRevMonth.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRevMonth.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRevMonth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.lblRevMonth.Location = New System.Drawing.Point(0, 0)
        Me.lblRevMonth.Name = "lblRevMonth"
        Me.lblRevMonth.Size = New System.Drawing.Size(274, 57)
        Me.lblRevMonth.TabIndex = 37
        Me.lblRevMonth.Text = "₱0"
        Me.lblRevMonth.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ctrlOverview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.panelRevenue)
        Me.Controls.Add(Me.panelCustomer)
        Me.Controls.Add(Me.panelATV)
        Me.Controls.Add(Me.panelReserv)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ctrlOverview"
        Me.Size = New System.Drawing.Size(1161, 738)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvCustReviews, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgvActivities, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgcReservations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelReserv.ResumeLayout(False)
        Me.panelATV.ResumeLayout(False)
        Me.panelCustomer.ResumeLayout(False)
        Me.panelRevenue.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnViewReserv As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents dgvCustReviews As DataGridView
    Friend WithEvents dgvActivities As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgcReservations As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents cbxYear As ComboBox
    Friend WithEvents cbxMonth As ComboBox
    Friend WithEvents panelReserv As Panel
    Friend WithEvents lblReservPending As Label
    Friend WithEvents lblReserv As Label
    Friend WithEvents lblReservCanceled As Label
    Friend WithEvents panelATV As Panel
    Friend WithEvents lblAtvInUse As Label
    Friend WithEvents lblAtv As Label
    Friend WithEvents lblAtvAvail As Label
    Friend WithEvents lblAtvMainten As Label
    Friend WithEvents panelCustomer As Panel
    Friend WithEvents lblCustYest As Label
    Friend WithEvents lblCust As Label
    Friend WithEvents lblCustMonth As Label
    Friend WithEvents panelRevenue As Panel
    Friend WithEvents lblRevYest As Label
    Friend WithEvents lblRev As Label
    Friend WithEvents lblRevMonth As Label
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
