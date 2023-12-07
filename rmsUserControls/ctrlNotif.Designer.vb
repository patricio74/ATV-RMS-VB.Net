<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrlNotif
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbxApplicantName = New System.Windows.Forms.TextBox()
        Me.tbxApplicantAddress = New System.Windows.Forms.TextBox()
        Me.gboxPendingResume = New System.Windows.Forms.GroupBox()
        Me.tbxApplicantPhone = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAcceptApplicant = New System.Windows.Forms.Button()
        Me.tbxApplicantEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvPendingTourGuides = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnClearApplicant = New System.Windows.Forms.Button()
        Me.btnDownloadResume = New System.Windows.Forms.Button()
        Me.gboxPendingAdmin = New System.Windows.Forms.GroupBox()
        Me.tbxAdminRFID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbxAdminPhone = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvPendingAdminAcc = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbxAdminEmail = New System.Windows.Forms.TextBox()
        Me.btnClearAdmin = New System.Windows.Forms.Button()
        Me.btnApproveAdmin = New System.Windows.Forms.Button()
        Me.tbxAdminName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbxAdminRole = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gboxPendingResume.SuspendLayout()
        CType(Me.dgvPendingTourGuides, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxPendingAdmin.SuspendLayout()
        CType(Me.dgvPendingAdminAcc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(25, 359)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 18)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "applicant name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(25, 423)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 18)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "address:"
        '
        'tbxApplicantName
        '
        Me.tbxApplicantName.BackColor = System.Drawing.Color.White
        Me.tbxApplicantName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxApplicantName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxApplicantName.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbxApplicantName.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxApplicantName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxApplicantName.Location = New System.Drawing.Point(28, 377)
        Me.tbxApplicantName.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.tbxApplicantName.Name = "tbxApplicantName"
        Me.tbxApplicantName.ReadOnly = True
        Me.tbxApplicantName.Size = New System.Drawing.Size(457, 32)
        Me.tbxApplicantName.TabIndex = 0
        '
        'tbxApplicantAddress
        '
        Me.tbxApplicantAddress.BackColor = System.Drawing.Color.White
        Me.tbxApplicantAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxApplicantAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxApplicantAddress.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbxApplicantAddress.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxApplicantAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxApplicantAddress.Location = New System.Drawing.Point(28, 441)
        Me.tbxApplicantAddress.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.tbxApplicantAddress.Name = "tbxApplicantAddress"
        Me.tbxApplicantAddress.ReadOnly = True
        Me.tbxApplicantAddress.Size = New System.Drawing.Size(457, 32)
        Me.tbxApplicantAddress.TabIndex = 1
        '
        'gboxPendingResume
        '
        Me.gboxPendingResume.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.gboxPendingResume.Controls.Add(Me.tbxApplicantPhone)
        Me.gboxPendingResume.Controls.Add(Me.Label2)
        Me.gboxPendingResume.Controls.Add(Me.btnAcceptApplicant)
        Me.gboxPendingResume.Controls.Add(Me.tbxApplicantEmail)
        Me.gboxPendingResume.Controls.Add(Me.Label4)
        Me.gboxPendingResume.Controls.Add(Me.dgvPendingTourGuides)
        Me.gboxPendingResume.Controls.Add(Me.tbxApplicantAddress)
        Me.gboxPendingResume.Controls.Add(Me.btnClearApplicant)
        Me.gboxPendingResume.Controls.Add(Me.btnDownloadResume)
        Me.gboxPendingResume.Controls.Add(Me.tbxApplicantName)
        Me.gboxPendingResume.Controls.Add(Me.Label1)
        Me.gboxPendingResume.Controls.Add(Me.Label7)
        Me.gboxPendingResume.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxPendingResume.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.gboxPendingResume.Location = New System.Drawing.Point(46, 26)
        Me.gboxPendingResume.Name = "gboxPendingResume"
        Me.gboxPendingResume.Size = New System.Drawing.Size(517, 680)
        Me.gboxPendingResume.TabIndex = 67
        Me.gboxPendingResume.TabStop = False
        Me.gboxPendingResume.Text = "PENDING TOUR GUIDE APPLICANTS"
        '
        'tbxApplicantPhone
        '
        Me.tbxApplicantPhone.BackColor = System.Drawing.Color.White
        Me.tbxApplicantPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxApplicantPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tbxApplicantPhone.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbxApplicantPhone.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxApplicantPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxApplicantPhone.Location = New System.Drawing.Point(28, 568)
        Me.tbxApplicantPhone.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.tbxApplicantPhone.Name = "tbxApplicantPhone"
        Me.tbxApplicantPhone.ReadOnly = True
        Me.tbxApplicantPhone.Size = New System.Drawing.Size(457, 32)
        Me.tbxApplicantPhone.TabIndex = 68
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(25, 550)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 18)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "phone:"
        '
        'btnAcceptApplicant
        '
        Me.btnAcceptApplicant.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAcceptApplicant.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAcceptApplicant.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnAcceptApplicant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAcceptApplicant.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcceptApplicant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnAcceptApplicant.Location = New System.Drawing.Point(72, 621)
        Me.btnAcceptApplicant.Name = "btnAcceptApplicant"
        Me.btnAcceptApplicant.Size = New System.Drawing.Size(200, 41)
        Me.btnAcceptApplicant.TabIndex = 4
        Me.btnAcceptApplicant.Text = "Accept Applicant"
        Me.btnAcceptApplicant.UseVisualStyleBackColor = False
        '
        'tbxApplicantEmail
        '
        Me.tbxApplicantEmail.BackColor = System.Drawing.Color.White
        Me.tbxApplicantEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxApplicantEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tbxApplicantEmail.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbxApplicantEmail.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxApplicantEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxApplicantEmail.Location = New System.Drawing.Point(28, 506)
        Me.tbxApplicantEmail.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.tbxApplicantEmail.Name = "tbxApplicantEmail"
        Me.tbxApplicantEmail.ReadOnly = True
        Me.tbxApplicantEmail.Size = New System.Drawing.Size(457, 32)
        Me.tbxApplicantEmail.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(25, 488)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 18)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "email:"
        '
        'dgvPendingTourGuides
        '
        Me.dgvPendingTourGuides.AllowUserToAddRows = False
        Me.dgvPendingTourGuides.AllowUserToOrderColumns = True
        Me.dgvPendingTourGuides.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvPendingTourGuides.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPendingTourGuides.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPendingTourGuides.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvPendingTourGuides.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPendingTourGuides.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvPendingTourGuides.EnableHeadersVisualStyles = False
        Me.dgvPendingTourGuides.GridColor = System.Drawing.Color.DimGray
        Me.dgvPendingTourGuides.Location = New System.Drawing.Point(0, 37)
        Me.dgvPendingTourGuides.MultiSelect = False
        Me.dgvPendingTourGuides.Name = "dgvPendingTourGuides"
        Me.dgvPendingTourGuides.ReadOnly = True
        Me.dgvPendingTourGuides.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPendingTourGuides.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvPendingTourGuides.RowHeadersVisible = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPendingTourGuides.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvPendingTourGuides.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPendingTourGuides.ShowEditingIcon = False
        Me.dgvPendingTourGuides.Size = New System.Drawing.Size(517, 293)
        Me.dgvPendingTourGuides.TabIndex = 65
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
        Me.Column2.HeaderText = "NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "PHONE"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "EMAIL"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'btnClearApplicant
        '
        Me.btnClearApplicant.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnClearApplicant.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearApplicant.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnClearApplicant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearApplicant.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearApplicant.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnClearApplicant.Location = New System.Drawing.Point(284, 621)
        Me.btnClearApplicant.Name = "btnClearApplicant"
        Me.btnClearApplicant.Size = New System.Drawing.Size(148, 41)
        Me.btnClearApplicant.TabIndex = 5
        Me.btnClearApplicant.Text = "Clear Form"
        Me.btnClearApplicant.UseVisualStyleBackColor = False
        '
        'btnDownloadResume
        '
        Me.btnDownloadResume.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnDownloadResume.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDownloadResume.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnDownloadResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDownloadResume.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDownloadResume.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnDownloadResume.Location = New System.Drawing.Point(358, 339)
        Me.btnDownloadResume.Name = "btnDownloadResume"
        Me.btnDownloadResume.Size = New System.Drawing.Size(127, 28)
        Me.btnDownloadResume.TabIndex = 3
        Me.btnDownloadResume.Text = "Download resume"
        Me.btnDownloadResume.UseVisualStyleBackColor = False
        '
        'gboxPendingAdmin
        '
        Me.gboxPendingAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.gboxPendingAdmin.Controls.Add(Me.tbxAdminRole)
        Me.gboxPendingAdmin.Controls.Add(Me.Label5)
        Me.gboxPendingAdmin.Controls.Add(Me.tbxAdminRFID)
        Me.gboxPendingAdmin.Controls.Add(Me.Label6)
        Me.gboxPendingAdmin.Controls.Add(Me.tbxAdminPhone)
        Me.gboxPendingAdmin.Controls.Add(Me.Label3)
        Me.gboxPendingAdmin.Controls.Add(Me.dgvPendingAdminAcc)
        Me.gboxPendingAdmin.Controls.Add(Me.tbxAdminEmail)
        Me.gboxPendingAdmin.Controls.Add(Me.btnClearAdmin)
        Me.gboxPendingAdmin.Controls.Add(Me.btnApproveAdmin)
        Me.gboxPendingAdmin.Controls.Add(Me.tbxAdminName)
        Me.gboxPendingAdmin.Controls.Add(Me.Label8)
        Me.gboxPendingAdmin.Controls.Add(Me.Label10)
        Me.gboxPendingAdmin.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxPendingAdmin.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.gboxPendingAdmin.Location = New System.Drawing.Point(597, 26)
        Me.gboxPendingAdmin.Name = "gboxPendingAdmin"
        Me.gboxPendingAdmin.Size = New System.Drawing.Size(517, 680)
        Me.gboxPendingAdmin.TabIndex = 69
        Me.gboxPendingAdmin.TabStop = False
        Me.gboxPendingAdmin.Text = "PENDING ADMIN ACCOUNT"
        '
        'tbxAdminRFID
        '
        Me.tbxAdminRFID.BackColor = System.Drawing.Color.White
        Me.tbxAdminRFID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxAdminRFID.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tbxAdminRFID.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbxAdminRFID.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAdminRFID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxAdminRFID.Location = New System.Drawing.Point(28, 568)
        Me.tbxAdminRFID.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.tbxAdminRFID.Name = "tbxAdminRFID"
        Me.tbxAdminRFID.ReadOnly = True
        Me.tbxAdminRFID.Size = New System.Drawing.Size(309, 32)
        Me.tbxAdminRFID.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(25, 550)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 18)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "RFID:"
        '
        'tbxAdminPhone
        '
        Me.tbxAdminPhone.BackColor = System.Drawing.Color.White
        Me.tbxAdminPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxAdminPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tbxAdminPhone.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbxAdminPhone.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAdminPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxAdminPhone.Location = New System.Drawing.Point(28, 506)
        Me.tbxAdminPhone.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.tbxAdminPhone.Name = "tbxAdminPhone"
        Me.tbxAdminPhone.ReadOnly = True
        Me.tbxAdminPhone.Size = New System.Drawing.Size(457, 32)
        Me.tbxAdminPhone.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(25, 488)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 18)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "phone:"
        '
        'dgvPendingAdminAcc
        '
        Me.dgvPendingAdminAcc.AllowUserToAddRows = False
        Me.dgvPendingAdminAcc.AllowUserToOrderColumns = True
        Me.dgvPendingAdminAcc.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvPendingAdminAcc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPendingAdminAcc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPendingAdminAcc.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvPendingAdminAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPendingAdminAcc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column7, Me.Column8})
        Me.dgvPendingAdminAcc.EnableHeadersVisualStyles = False
        Me.dgvPendingAdminAcc.GridColor = System.Drawing.Color.DimGray
        Me.dgvPendingAdminAcc.Location = New System.Drawing.Point(0, 37)
        Me.dgvPendingAdminAcc.MultiSelect = False
        Me.dgvPendingAdminAcc.Name = "dgvPendingAdminAcc"
        Me.dgvPendingAdminAcc.ReadOnly = True
        Me.dgvPendingAdminAcc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPendingAdminAcc.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvPendingAdminAcc.RowHeadersVisible = False
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPendingAdminAcc.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvPendingAdminAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPendingAdminAcc.ShowEditingIcon = False
        Me.dgvPendingAdminAcc.Size = New System.Drawing.Size(517, 293)
        Me.dgvPendingAdminAcc.TabIndex = 65
        '
        'Column6
        '
        Me.Column6.HeaderText = "ID"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 25
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.HeaderText = "NAME"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.HeaderText = "EMAIL"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'tbxAdminEmail
        '
        Me.tbxAdminEmail.BackColor = System.Drawing.Color.White
        Me.tbxAdminEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxAdminEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tbxAdminEmail.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbxAdminEmail.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAdminEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxAdminEmail.Location = New System.Drawing.Point(28, 441)
        Me.tbxAdminEmail.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.tbxAdminEmail.Name = "tbxAdminEmail"
        Me.tbxAdminEmail.ReadOnly = True
        Me.tbxAdminEmail.Size = New System.Drawing.Size(457, 32)
        Me.tbxAdminEmail.TabIndex = 1
        '
        'btnClearAdmin
        '
        Me.btnClearAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnClearAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearAdmin.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnClearAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearAdmin.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAdmin.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnClearAdmin.Location = New System.Drawing.Point(294, 621)
        Me.btnClearAdmin.Name = "btnClearAdmin"
        Me.btnClearAdmin.Size = New System.Drawing.Size(148, 41)
        Me.btnClearAdmin.TabIndex = 6
        Me.btnClearAdmin.Text = "Clear Form"
        Me.btnClearAdmin.UseVisualStyleBackColor = False
        '
        'btnApproveAdmin
        '
        Me.btnApproveAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnApproveAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApproveAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnApproveAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApproveAdmin.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApproveAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnApproveAdmin.Location = New System.Drawing.Point(82, 621)
        Me.btnApproveAdmin.Name = "btnApproveAdmin"
        Me.btnApproveAdmin.Size = New System.Drawing.Size(200, 41)
        Me.btnApproveAdmin.TabIndex = 5
        Me.btnApproveAdmin.Text = "Approve admin"
        Me.btnApproveAdmin.UseVisualStyleBackColor = False
        '
        'tbxAdminName
        '
        Me.tbxAdminName.BackColor = System.Drawing.Color.White
        Me.tbxAdminName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxAdminName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxAdminName.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbxAdminName.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAdminName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxAdminName.Location = New System.Drawing.Point(28, 377)
        Me.tbxAdminName.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.tbxAdminName.Name = "tbxAdminName"
        Me.tbxAdminName.ReadOnly = True
        Me.tbxAdminName.Size = New System.Drawing.Size(457, 32)
        Me.tbxAdminName.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(25, 359)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 18)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "name:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(25, 423)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 18)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "email:"
        '
        'tbxAdminRole
        '
        Me.tbxAdminRole.BackColor = System.Drawing.Color.White
        Me.tbxAdminRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxAdminRole.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tbxAdminRole.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbxAdminRole.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAdminRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.tbxAdminRole.Location = New System.Drawing.Point(343, 568)
        Me.tbxAdminRole.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.tbxAdminRole.Name = "tbxAdminRole"
        Me.tbxAdminRole.ReadOnly = True
        Me.tbxAdminRole.Size = New System.Drawing.Size(142, 32)
        Me.tbxAdminRole.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(340, 550)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 18)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "role:"
        '
        'ctrlNotif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.gboxPendingAdmin)
        Me.Controls.Add(Me.gboxPendingResume)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ctrlNotif"
        Me.Size = New System.Drawing.Size(1161, 738)
        Me.gboxPendingResume.ResumeLayout(False)
        Me.gboxPendingResume.PerformLayout()
        CType(Me.dgvPendingTourGuides, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxPendingAdmin.ResumeLayout(False)
        Me.gboxPendingAdmin.PerformLayout()
        CType(Me.dgvPendingAdminAcc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbxApplicantName As TextBox
    Friend WithEvents tbxApplicantAddress As TextBox
    Friend WithEvents gboxPendingResume As GroupBox
    Friend WithEvents dgvPendingTourGuides As DataGridView
    Friend WithEvents btnClearApplicant As Button
    Friend WithEvents btnDownloadResume As Button
    Friend WithEvents btnAcceptApplicant As Button
    Friend WithEvents tbxApplicantEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents gboxPendingAdmin As GroupBox
    Friend WithEvents dgvPendingAdminAcc As DataGridView
    Friend WithEvents tbxAdminEmail As TextBox
    Friend WithEvents btnClearAdmin As Button
    Friend WithEvents btnApproveAdmin As Button
    Friend WithEvents tbxAdminName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents tbxApplicantPhone As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents tbxAdminRFID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbxAdminPhone As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxAdminRole As TextBox
    Friend WithEvents Label5 As Label
End Class
