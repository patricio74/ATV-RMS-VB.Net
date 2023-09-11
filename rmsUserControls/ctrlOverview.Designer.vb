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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnViewReserv = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvReviews = New System.Windows.Forms.DataGridView()
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
        Me.dgvReservations = New System.Windows.Forms.DataGridView()
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvReviews, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgvActivities, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvReservations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelReserv.SuspendLayout()
        Me.panelATV.SuspendLayout()
        Me.panelCustomer.SuspendLayout()
        Me.panelRevenue.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnViewReserv
        '
        Me.btnViewReserv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnViewReserv.BackColor = System.Drawing.Color.Gainsboro
        Me.btnViewReserv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewReserv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnViewReserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewReserv.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewReserv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnViewReserv.Location = New System.Drawing.Point(338, 22)
        Me.btnViewReserv.Name = "btnViewReserv"
        Me.btnViewReserv.Size = New System.Drawing.Size(57, 26)
        Me.btnViewReserv.TabIndex = 23
        Me.btnViewReserv.Text = "View"
        Me.btnViewReserv.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.dgvReviews)
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(43, 172)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.GroupBox3.Size = New System.Drawing.Size(630, 246)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Customer Reviews"
        '
        'dgvReviews
        '
        Me.dgvReviews.AllowUserToAddRows = False
        Me.dgvReviews.AllowUserToOrderColumns = True
        Me.dgvReviews.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.dgvReviews.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvReviews.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReviews.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReviews.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dgvReviews.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReviews.EnableHeadersVisualStyles = False
        Me.dgvReviews.GridColor = System.Drawing.Color.DarkGray
        Me.dgvReviews.Location = New System.Drawing.Point(0, 23)
        Me.dgvReviews.MultiSelect = False
        Me.dgvReviews.Name = "dgvReviews"
        Me.dgvReviews.ReadOnly = True
        Me.dgvReviews.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReviews.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvReviews.RowHeadersVisible = False
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.dgvReviews.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvReviews.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReviews.ShowEditingIcon = False
        Me.dgvReviews.Size = New System.Drawing.Size(630, 223)
        Me.dgvReviews.TabIndex = 35
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Ratings"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 145
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
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle13.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvActivities.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
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
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvActivities.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvActivities.RowHeadersVisible = False
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.dgvActivities.RowsDefaultCellStyle = DataGridViewCellStyle15
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
        Me.GroupBox1.Controls.Add(Me.dgvReservations)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(697, 172)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.GroupBox1.Size = New System.Drawing.Size(417, 529)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reservations Calendar"
        '
        'cbxYear
        '
        Me.cbxYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxYear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxYear.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxYear.FormattingEnabled = True
        Me.cbxYear.Location = New System.Drawing.Point(265, 22)
        Me.cbxYear.Name = "cbxYear"
        Me.cbxYear.Size = New System.Drawing.Size(67, 26)
        Me.cbxYear.TabIndex = 37
        '
        'cbxMonth
        '
        Me.cbxMonth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxMonth.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMonth.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMonth.FormattingEnabled = True
        Me.cbxMonth.Location = New System.Drawing.Point(146, 22)
        Me.cbxMonth.Name = "cbxMonth"
        Me.cbxMonth.Size = New System.Drawing.Size(113, 26)
        Me.cbxMonth.TabIndex = 36
        '
        'dgvReservations
        '
        Me.dgvReservations.AllowUserToAddRows = False
        Me.dgvReservations.AllowUserToOrderColumns = True
        Me.dgvReservations.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.dgvReservations.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvReservations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle16.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReservations.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReservations.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.dgvReservations.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvReservations.EnableHeadersVisualStyles = False
        Me.dgvReservations.GridColor = System.Drawing.Color.DarkGray
        Me.dgvReservations.Location = New System.Drawing.Point(0, 55)
        Me.dgvReservations.MultiSelect = False
        Me.dgvReservations.Name = "dgvReservations"
        Me.dgvReservations.ReadOnly = True
        Me.dgvReservations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReservations.RowHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvReservations.RowHeadersVisible = False
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.dgvReservations.RowsDefaultCellStyle = DataGridViewCellStyle18
        Me.dgvReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReservations.ShowEditingIcon = False
        Me.dgvReservations.Size = New System.Drawing.Size(417, 474)
        Me.dgvReservations.TabIndex = 35
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Day"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 75
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.HeaderText = "Reservations"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'panelReserv
        '
        Me.panelReserv.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.panelReserv.Controls.Add(Me.lblReservPending)
        Me.panelReserv.Controls.Add(Me.lblReservCanceled)
        Me.panelReserv.Controls.Add(Me.lblReserv)
        Me.panelReserv.ForeColor = System.Drawing.Color.WhiteSmoke
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
        Me.lblReservPending.Size = New System.Drawing.Size(252, 51)
        Me.lblReservPending.TabIndex = 34
        Me.lblReservPending.Text = "0"
        Me.lblReservPending.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblReservCanceled
        '
        Me.lblReservCanceled.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblReservCanceled.BackColor = System.Drawing.Color.Transparent
        Me.lblReservCanceled.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReservCanceled.ForeColor = System.Drawing.Color.LightGray
        Me.lblReservCanceled.Location = New System.Drawing.Point(0, 91)
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
        Me.lblReserv.Location = New System.Drawing.Point(0, 51)
        Me.lblReserv.Name = "lblReserv"
        Me.lblReserv.Size = New System.Drawing.Size(252, 26)
        Me.lblReserv.TabIndex = 35
        Me.lblReserv.Text = "Pending Reservation"
        Me.lblReserv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelATV
        '
        Me.panelATV.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.panelATV.Controls.Add(Me.lblAtv)
        Me.panelATV.Controls.Add(Me.lblAtvMainten)
        Me.panelATV.Controls.Add(Me.lblAtvInUse)
        Me.panelATV.Controls.Add(Me.lblAtvAvail)
        Me.panelATV.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.panelATV.Location = New System.Drawing.Point(296, 28)
        Me.panelATV.Name = "panelATV"
        Me.panelATV.Size = New System.Drawing.Size(266, 124)
        Me.panelATV.TabIndex = 39
        '
        'lblAtv
        '
        Me.lblAtv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAtv.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblAtv.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.lblAtv.Location = New System.Drawing.Point(0, 51)
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
        Me.lblAtvMainten.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtvMainten.ForeColor = System.Drawing.Color.LightGray
        Me.lblAtvMainten.Location = New System.Drawing.Point(0, 102)
        Me.lblAtvMainten.Name = "lblAtvMainten"
        Me.lblAtvMainten.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblAtvMainten.Size = New System.Drawing.Size(266, 18)
        Me.lblAtvMainten.TabIndex = 40
        Me.lblAtvMainten.Text = "Under maintenance:  0"
        Me.lblAtvMainten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAtvInUse
        '
        Me.lblAtvInUse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAtvInUse.BackColor = System.Drawing.Color.Transparent
        Me.lblAtvInUse.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtvInUse.ForeColor = System.Drawing.Color.LightGray
        Me.lblAtvInUse.Location = New System.Drawing.Point(0, 76)
        Me.lblAtvInUse.Name = "lblAtvInUse"
        Me.lblAtvInUse.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblAtvInUse.Size = New System.Drawing.Size(266, 23)
        Me.lblAtvInUse.TabIndex = 39
        Me.lblAtvInUse.Text = "Currently in-use: 0"
        Me.lblAtvInUse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAtvAvail
        '
        Me.lblAtvAvail.BackColor = System.Drawing.Color.Transparent
        Me.lblAtvAvail.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAtvAvail.Font = New System.Drawing.Font("Trebuchet MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtvAvail.ForeColor = System.Drawing.Color.White
        Me.lblAtvAvail.Location = New System.Drawing.Point(0, 0)
        Me.lblAtvAvail.Name = "lblAtvAvail"
        Me.lblAtvAvail.Size = New System.Drawing.Size(266, 51)
        Me.lblAtvAvail.TabIndex = 37
        Me.lblAtvAvail.Text = "0"
        Me.lblAtvAvail.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'panelCustomer
        '
        Me.panelCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.panelCustomer.Controls.Add(Me.lblCustYest)
        Me.panelCustomer.Controls.Add(Me.lblCust)
        Me.panelCustomer.Controls.Add(Me.lblCustMonth)
        Me.panelCustomer.ForeColor = System.Drawing.Color.WhiteSmoke
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
        Me.lblCustYest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustYest.ForeColor = System.Drawing.Color.LightGray
        Me.lblCustYest.Location = New System.Drawing.Point(0, 91)
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
        Me.lblCust.Location = New System.Drawing.Point(0, 51)
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
        Me.lblCustMonth.Size = New System.Drawing.Size(264, 51)
        Me.lblCustMonth.TabIndex = 37
        Me.lblCustMonth.Text = "0"
        Me.lblCustMonth.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'panelRevenue
        '
        Me.panelRevenue.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.panelRevenue.Controls.Add(Me.lblRevYest)
        Me.panelRevenue.Controls.Add(Me.lblRev)
        Me.panelRevenue.Controls.Add(Me.lblRevMonth)
        Me.panelRevenue.ForeColor = System.Drawing.Color.WhiteSmoke
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
        Me.lblRevYest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRevYest.ForeColor = System.Drawing.Color.LightGray
        Me.lblRevYest.Location = New System.Drawing.Point(0, 91)
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
        Me.lblRev.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblRev.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRev.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.lblRev.Location = New System.Drawing.Point(0, 51)
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
        Me.lblRevMonth.ForeColor = System.Drawing.Color.White
        Me.lblRevMonth.Location = New System.Drawing.Point(0, 0)
        Me.lblRevMonth.Name = "lblRevMonth"
        Me.lblRevMonth.Size = New System.Drawing.Size(274, 51)
        Me.lblRevMonth.TabIndex = 37
        Me.lblRevMonth.Text = "₱0"
        Me.lblRevMonth.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Timer1
        '
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
        CType(Me.dgvReviews, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgvActivities, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvReservations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelReserv.ResumeLayout(False)
        Me.panelATV.ResumeLayout(False)
        Me.panelCustomer.ResumeLayout(False)
        Me.panelRevenue.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnViewReserv As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents dgvReviews As DataGridView
    Friend WithEvents dgvActivities As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbxYear As ComboBox
    Friend WithEvents cbxMonth As ComboBox
    Friend WithEvents panelReserv As Panel
    Friend WithEvents lblReserv As Label
    Friend WithEvents panelATV As Panel
    Friend WithEvents lblAtv As Label
    Friend WithEvents panelCustomer As Panel
    Friend WithEvents lblCust As Label
    Friend WithEvents panelRevenue As Panel
    Friend WithEvents lblRev As Label
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Public WithEvents lblReservPending As Label
    Public WithEvents lblReservCanceled As Label
    Public WithEvents lblAtvInUse As Label
    Public WithEvents lblAtvAvail As Label
    Public WithEvents lblAtvMainten As Label
    Public WithEvents lblCustYest As Label
    Public WithEvents lblCustMonth As Label
    Public WithEvents lblRevYest As Label
    Public WithEvents lblRevMonth As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents dgvReservations As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
