﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnResetDate = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnRefreshReviews = New System.Windows.Forms.Button()
        Me.dgvReviews = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rtbxReview = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvReservations = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.panelReserv = New System.Windows.Forms.Panel()
        Me.lblReservPending = New System.Windows.Forms.Label()
        Me.lblReservCanceled = New System.Windows.Forms.Label()
        Me.lblReserv = New System.Windows.Forms.Label()
        Me.panelATV = New System.Windows.Forms.Panel()
        Me.lblAtvAvail = New System.Windows.Forms.Label()
        Me.lblAtv = New System.Windows.Forms.Label()
        Me.lblAtvMainten = New System.Windows.Forms.Label()
        Me.lblAtvInUse = New System.Windows.Forms.Label()
        Me.panelCustomer = New System.Windows.Forms.Panel()
        Me.lblCustMonth = New System.Windows.Forms.Label()
        Me.lblCust = New System.Windows.Forms.Label()
        Me.lblCustYest = New System.Windows.Forms.Label()
        Me.panelRevenue = New System.Windows.Forms.Panel()
        Me.lblRevMonth = New System.Windows.Forms.Label()
        Me.lblRevYest = New System.Windows.Forms.Label()
        Me.lblRev = New System.Windows.Forms.Label()
        Me.overviewTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvReviews, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvReservations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelReserv.SuspendLayout()
        Me.panelATV.SuspendLayout()
        Me.panelCustomer.SuspendLayout()
        Me.panelRevenue.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnResetDate
        '
        Me.btnResetDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnResetDate.BackColor = System.Drawing.Color.Gainsboro
        Me.btnResetDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResetDate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnResetDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetDate.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnResetDate.Location = New System.Drawing.Point(1022, 20)
        Me.btnResetDate.Name = "btnResetDate"
        Me.btnResetDate.Size = New System.Drawing.Size(62, 26)
        Me.btnResetDate.TabIndex = 23
        Me.btnResetDate.Text = "Reset"
        Me.btnResetDate.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.btnRefreshReviews)
        Me.GroupBox3.Controls.Add(Me.dgvReviews)
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(572, 661)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.GroupBox3.Size = New System.Drawing.Size(579, 43)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Customer Reviews"
        Me.GroupBox3.Visible = False
        '
        'btnRefreshReviews
        '
        Me.btnRefreshReviews.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefreshReviews.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRefreshReviews.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefreshReviews.FlatAppearance.BorderSize = 0
        Me.btnRefreshReviews.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefreshReviews.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshReviews.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnRefreshReviews.Location = New System.Drawing.Point(505, 26)
        Me.btnRefreshReviews.Name = "btnRefreshReviews"
        Me.btnRefreshReviews.Size = New System.Drawing.Size(61, 28)
        Me.btnRefreshReviews.TabIndex = 44
        Me.btnRefreshReviews.Text = "refresh"
        Me.btnRefreshReviews.UseVisualStyleBackColor = False
        '
        'dgvReviews
        '
        Me.dgvReviews.AllowUserToAddRows = False
        Me.dgvReviews.AllowUserToOrderColumns = True
        Me.dgvReviews.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgvReviews.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvReviews.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReviews.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReviews.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dgvReviews.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReviews.EnableHeadersVisualStyles = False
        Me.dgvReviews.GridColor = System.Drawing.Color.DarkGray
        Me.dgvReviews.Location = New System.Drawing.Point(0, 23)
        Me.dgvReviews.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvReviews.MultiSelect = False
        Me.dgvReviews.Name = "dgvReviews"
        Me.dgvReviews.ReadOnly = True
        Me.dgvReviews.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReviews.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvReviews.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.dgvReviews.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvReviews.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReviews.ShowEditingIcon = False
        Me.dgvReviews.Size = New System.Drawing.Size(579, 20)
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
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.HeaderText = "Review"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'rtbxReview
        '
        Me.rtbxReview.BackColor = System.Drawing.Color.DarkGray
        Me.rtbxReview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbxReview.Cursor = System.Windows.Forms.Cursors.No
        Me.rtbxReview.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbxReview.ForeColor = System.Drawing.Color.White
        Me.rtbxReview.Location = New System.Drawing.Point(572, 716)
        Me.rtbxReview.Margin = New System.Windows.Forms.Padding(0)
        Me.rtbxReview.Name = "rtbxReview"
        Me.rtbxReview.ReadOnly = True
        Me.rtbxReview.Size = New System.Drawing.Size(579, 12)
        Me.rtbxReview.TabIndex = 43
        Me.rtbxReview.Text = "Reviews from selected row will be shown here."
        Me.rtbxReview.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.dgvReservations)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.btnResetDate)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(31, 246)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.GroupBox1.Size = New System.Drawing.Size(1104, 455)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reservations Calendar"
        '
        'dgvReservations
        '
        Me.dgvReservations.AllowUserToAddRows = False
        Me.dgvReservations.AllowUserToOrderColumns = True
        Me.dgvReservations.AllowUserToResizeColumns = False
        Me.dgvReservations.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvReservations.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.dgvReservations.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvReservations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReservations.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReservations.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvReservations.EnableHeadersVisualStyles = False
        Me.dgvReservations.GridColor = System.Drawing.Color.DarkGray
        Me.dgvReservations.Location = New System.Drawing.Point(0, 56)
        Me.dgvReservations.MultiSelect = False
        Me.dgvReservations.Name = "dgvReservations"
        Me.dgvReservations.ReadOnly = True
        Me.dgvReservations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReservations.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvReservations.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.dgvReservations.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReservations.ShowEditingIcon = False
        Me.dgvReservations.Size = New System.Drawing.Size(1104, 399)
        Me.dgvReservations.TabIndex = 35
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Customer Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Tour Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Time Slot"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "No. of Person"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(723, 21)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(293, 26)
        Me.DateTimePicker1.TabIndex = 38
        '
        'panelReserv
        '
        Me.panelReserv.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.panelReserv.Controls.Add(Me.lblReservPending)
        Me.panelReserv.Controls.Add(Me.lblReservCanceled)
        Me.panelReserv.Controls.Add(Me.lblReserv)
        Me.panelReserv.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.panelReserv.Location = New System.Drawing.Point(31, 40)
        Me.panelReserv.Name = "panelReserv"
        Me.panelReserv.Size = New System.Drawing.Size(264, 176)
        Me.panelReserv.TabIndex = 38
        '
        'lblReservPending
        '
        Me.lblReservPending.BackColor = System.Drawing.Color.Transparent
        Me.lblReservPending.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblReservPending.Font = New System.Drawing.Font("Trebuchet MS", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReservPending.ForeColor = System.Drawing.Color.White
        Me.lblReservPending.Location = New System.Drawing.Point(0, 44)
        Me.lblReservPending.Name = "lblReservPending"
        Me.lblReservPending.Size = New System.Drawing.Size(264, 77)
        Me.lblReservPending.TabIndex = 34
        Me.lblReservPending.Text = "999"
        Me.lblReservPending.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblReservCanceled
        '
        Me.lblReservCanceled.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblReservCanceled.BackColor = System.Drawing.Color.Transparent
        Me.lblReservCanceled.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReservCanceled.ForeColor = System.Drawing.Color.LightGray
        Me.lblReservCanceled.Location = New System.Drawing.Point(0, 133)
        Me.lblReservCanceled.Name = "lblReservCanceled"
        Me.lblReservCanceled.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblReservCanceled.Size = New System.Drawing.Size(264, 23)
        Me.lblReservCanceled.TabIndex = 36
        Me.lblReservCanceled.Text = "Canceled Reservations:  0"
        Me.lblReservCanceled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblReserv
        '
        Me.lblReserv.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblReserv.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblReserv.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReserv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.lblReserv.Location = New System.Drawing.Point(0, 0)
        Me.lblReserv.Name = "lblReserv"
        Me.lblReserv.Size = New System.Drawing.Size(264, 44)
        Me.lblReserv.TabIndex = 35
        Me.lblReserv.Text = "Pending Reservation"
        Me.lblReserv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelATV
        '
        Me.panelATV.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.panelATV.Controls.Add(Me.lblAtvAvail)
        Me.panelATV.Controls.Add(Me.lblAtv)
        Me.panelATV.Controls.Add(Me.lblAtvMainten)
        Me.panelATV.Controls.Add(Me.lblAtvInUse)
        Me.panelATV.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.panelATV.Location = New System.Drawing.Point(310, 40)
        Me.panelATV.Name = "panelATV"
        Me.panelATV.Size = New System.Drawing.Size(264, 176)
        Me.panelATV.TabIndex = 39
        '
        'lblAtvAvail
        '
        Me.lblAtvAvail.BackColor = System.Drawing.Color.Transparent
        Me.lblAtvAvail.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAtvAvail.Font = New System.Drawing.Font("Trebuchet MS", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtvAvail.ForeColor = System.Drawing.Color.White
        Me.lblAtvAvail.Location = New System.Drawing.Point(0, 44)
        Me.lblAtvAvail.Name = "lblAtvAvail"
        Me.lblAtvAvail.Size = New System.Drawing.Size(264, 77)
        Me.lblAtvAvail.TabIndex = 37
        Me.lblAtvAvail.Text = "99999"
        Me.lblAtvAvail.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblAtv
        '
        Me.lblAtv.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblAtv.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAtv.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.lblAtv.Location = New System.Drawing.Point(0, 0)
        Me.lblAtv.Name = "lblAtv"
        Me.lblAtv.Size = New System.Drawing.Size(264, 44)
        Me.lblAtv.TabIndex = 38
        Me.lblAtv.Text = "Available ATV"
        Me.lblAtv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAtvMainten
        '
        Me.lblAtvMainten.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAtvMainten.BackColor = System.Drawing.Color.Transparent
        Me.lblAtvMainten.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtvMainten.ForeColor = System.Drawing.Color.LightGray
        Me.lblAtvMainten.Location = New System.Drawing.Point(0, 149)
        Me.lblAtvMainten.Name = "lblAtvMainten"
        Me.lblAtvMainten.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblAtvMainten.Size = New System.Drawing.Size(264, 18)
        Me.lblAtvMainten.TabIndex = 40
        Me.lblAtvMainten.Text = "Under maintenance:  0"
        Me.lblAtvMainten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAtvInUse
        '
        Me.lblAtvInUse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAtvInUse.BackColor = System.Drawing.Color.Transparent
        Me.lblAtvInUse.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtvInUse.ForeColor = System.Drawing.Color.LightGray
        Me.lblAtvInUse.Location = New System.Drawing.Point(0, 124)
        Me.lblAtvInUse.Name = "lblAtvInUse"
        Me.lblAtvInUse.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblAtvInUse.Size = New System.Drawing.Size(264, 23)
        Me.lblAtvInUse.TabIndex = 39
        Me.lblAtvInUse.Text = "Currently in-use: 0"
        Me.lblAtvInUse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelCustomer
        '
        Me.panelCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.panelCustomer.Controls.Add(Me.lblCustMonth)
        Me.panelCustomer.Controls.Add(Me.lblCust)
        Me.panelCustomer.Controls.Add(Me.lblCustYest)
        Me.panelCustomer.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.panelCustomer.Location = New System.Drawing.Point(590, 40)
        Me.panelCustomer.Name = "panelCustomer"
        Me.panelCustomer.Size = New System.Drawing.Size(264, 176)
        Me.panelCustomer.TabIndex = 41
        '
        'lblCustMonth
        '
        Me.lblCustMonth.BackColor = System.Drawing.Color.Transparent
        Me.lblCustMonth.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCustMonth.Font = New System.Drawing.Font("Trebuchet MS", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustMonth.ForeColor = System.Drawing.Color.White
        Me.lblCustMonth.Location = New System.Drawing.Point(0, 44)
        Me.lblCustMonth.Name = "lblCustMonth"
        Me.lblCustMonth.Size = New System.Drawing.Size(264, 77)
        Me.lblCustMonth.TabIndex = 38
        Me.lblCustMonth.Text = "9999"
        Me.lblCustMonth.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblCust
        '
        Me.lblCust.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblCust.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCust.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCust.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.lblCust.Location = New System.Drawing.Point(0, 0)
        Me.lblCust.Name = "lblCust"
        Me.lblCust.Size = New System.Drawing.Size(264, 44)
        Me.lblCust.TabIndex = 37
        Me.lblCust.Text = "Customers This Month"
        Me.lblCust.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCustYest
        '
        Me.lblCustYest.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCustYest.BackColor = System.Drawing.Color.Transparent
        Me.lblCustYest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustYest.ForeColor = System.Drawing.Color.LightGray
        Me.lblCustYest.Location = New System.Drawing.Point(0, 134)
        Me.lblCustYest.Name = "lblCustYest"
        Me.lblCustYest.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblCustYest.Size = New System.Drawing.Size(264, 23)
        Me.lblCustYest.TabIndex = 40
        Me.lblCustYest.Text = "Total yesterday:  0"
        Me.lblCustYest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelRevenue
        '
        Me.panelRevenue.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.panelRevenue.Controls.Add(Me.lblRevMonth)
        Me.panelRevenue.Controls.Add(Me.lblRevYest)
        Me.panelRevenue.Controls.Add(Me.lblRev)
        Me.panelRevenue.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.panelRevenue.Location = New System.Drawing.Point(871, 40)
        Me.panelRevenue.Name = "panelRevenue"
        Me.panelRevenue.Size = New System.Drawing.Size(264, 178)
        Me.panelRevenue.TabIndex = 42
        '
        'lblRevMonth
        '
        Me.lblRevMonth.BackColor = System.Drawing.Color.Transparent
        Me.lblRevMonth.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRevMonth.Font = New System.Drawing.Font("Trebuchet MS", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRevMonth.ForeColor = System.Drawing.Color.White
        Me.lblRevMonth.Location = New System.Drawing.Point(0, 44)
        Me.lblRevMonth.Name = "lblRevMonth"
        Me.lblRevMonth.Size = New System.Drawing.Size(264, 77)
        Me.lblRevMonth.TabIndex = 37
        Me.lblRevMonth.Text = "₱9999999"
        Me.lblRevMonth.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblRevYest
        '
        Me.lblRevYest.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRevYest.BackColor = System.Drawing.Color.Transparent
        Me.lblRevYest.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRevYest.ForeColor = System.Drawing.Color.LightGray
        Me.lblRevYest.Location = New System.Drawing.Point(0, 136)
        Me.lblRevYest.Name = "lblRevYest"
        Me.lblRevYest.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lblRevYest.Size = New System.Drawing.Size(264, 23)
        Me.lblRevYest.TabIndex = 40
        Me.lblRevYest.Text = "Total yesterday:  ₱0"
        Me.lblRevYest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRev
        '
        Me.lblRev.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblRev.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRev.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRev.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.lblRev.Location = New System.Drawing.Point(0, 0)
        Me.lblRev.Name = "lblRev"
        Me.lblRev.Size = New System.Drawing.Size(264, 44)
        Me.lblRev.TabIndex = 38
        Me.lblRev.Text = "Revenue This Month"
        Me.lblRev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'overviewTimer
        '
        '
        'ctrlOverview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.panelATV)
        Me.Controls.Add(Me.panelReserv)
        Me.Controls.Add(Me.panelCustomer)
        Me.Controls.Add(Me.panelRevenue)
        Me.Controls.Add(Me.rtbxReview)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ctrlOverview"
        Me.Size = New System.Drawing.Size(1161, 738)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvReviews, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvReservations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelReserv.ResumeLayout(False)
        Me.panelATV.ResumeLayout(False)
        Me.panelCustomer.ResumeLayout(False)
        Me.panelRevenue.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnResetDate As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvReviews As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents panelReserv As Panel
    Friend WithEvents lblReserv As Label
    Friend WithEvents panelATV As Panel
    Friend WithEvents lblAtv As Label
    Friend WithEvents panelCustomer As Panel
    Friend WithEvents lblCust As Label
    Friend WithEvents panelRevenue As Panel
    Friend WithEvents lblRev As Label
    Public WithEvents lblReservPending As Label
    Public WithEvents lblReservCanceled As Label
    Public WithEvents lblAtvInUse As Label
    Public WithEvents lblAtvAvail As Label
    Public WithEvents lblAtvMainten As Label
    Public WithEvents lblCustYest As Label
    Public WithEvents lblCustMonth As Label
    Public WithEvents lblRevYest As Label
    Public WithEvents lblRevMonth As Label
    Friend WithEvents overviewTimer As Timer
    Friend WithEvents dgvReservations As DataGridView
    Friend WithEvents rtbxReview As RichTextBox
    Friend WithEvents btnRefreshReviews As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
