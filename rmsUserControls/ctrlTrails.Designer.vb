<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlTrails
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.addPrice = New System.Windows.Forms.TextBox()
        Me.btnUpdTrail = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAddTrail = New System.Windows.Forms.Button()
        Me.addDuration = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.addTrailName = New System.Windows.Forms.TextBox()
        Me.dgvTrails = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tabTrails = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.addDescription = New System.Windows.Forms.RichTextBox()
        Me.addMinPerson = New System.Windows.Forms.TextBox()
        Me.lblTransacPesoSign = New System.Windows.Forms.Label()
        Me.lblClearAdd = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnDelTrail = New System.Windows.Forms.Button()
        Me.updDescription = New System.Windows.Forms.RichTextBox()
        Me.updMinPerson = New System.Windows.Forms.TextBox()
        Me.lblClearUpdate = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.updPrice = New System.Windows.Forms.TextBox()
        Me.lblUpdTrailID = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.updTrailName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.updDuration = New System.Windows.Forms.TextBox()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvTrails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTrails.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'addPrice
        '
        Me.addPrice.BackColor = System.Drawing.Color.White
        Me.addPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.addPrice.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.addPrice.Location = New System.Drawing.Point(14, 177)
        Me.addPrice.MaxLength = 6
        Me.addPrice.Name = "addPrice"
        Me.addPrice.Size = New System.Drawing.Size(252, 32)
        Me.addPrice.TabIndex = 3
        Me.addPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnUpdTrail
        '
        Me.btnUpdTrail.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnUpdTrail.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnUpdTrail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdTrail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnUpdTrail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdTrail.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdTrail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnUpdTrail.Location = New System.Drawing.Point(13, 479)
        Me.btnUpdTrail.Name = "btnUpdTrail"
        Me.btnUpdTrail.Size = New System.Drawing.Size(121, 44)
        Me.btnUpdTrail.TabIndex = 5
        Me.btnUpdTrail.Text = "Update"
        Me.btnUpdTrail.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(11, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 18)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "Price"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(11, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "Trail name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(11, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 18)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "Description"
        '
        'btnAddTrail
        '
        Me.btnAddTrail.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAddTrail.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnAddTrail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddTrail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnAddTrail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddTrail.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTrail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnAddTrail.Location = New System.Drawing.Point(79, 480)
        Me.btnAddTrail.Name = "btnAddTrail"
        Me.btnAddTrail.Size = New System.Drawing.Size(121, 44)
        Me.btnAddTrail.TabIndex = 5
        Me.btnAddTrail.Text = "Add Trail"
        Me.btnAddTrail.UseVisualStyleBackColor = False
        '
        'addDuration
        '
        Me.addDuration.BackColor = System.Drawing.Color.White
        Me.addDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.addDuration.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addDuration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.addDuration.Location = New System.Drawing.Point(14, 108)
        Me.addDuration.MaxLength = 20
        Me.addDuration.Name = "addDuration"
        Me.addDuration.Size = New System.Drawing.Size(118, 30)
        Me.addDuration.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(145, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "Min. person"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(11, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Duration"
        '
        'addTrailName
        '
        Me.addTrailName.BackColor = System.Drawing.Color.White
        Me.addTrailName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.addTrailName.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addTrailName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.addTrailName.Location = New System.Drawing.Point(14, 42)
        Me.addTrailName.Name = "addTrailName"
        Me.addTrailName.Size = New System.Drawing.Size(252, 30)
        Me.addTrailName.TabIndex = 0
        '
        'dgvTrails
        '
        Me.dgvTrails.AllowUserToAddRows = False
        Me.dgvTrails.AllowUserToOrderColumns = True
        Me.dgvTrails.AllowUserToResizeColumns = False
        Me.dgvTrails.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvTrails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTrails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTrails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTrails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTrails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgvTrails.EnableHeadersVisualStyles = False
        Me.dgvTrails.GridColor = System.Drawing.Color.DimGray
        Me.dgvTrails.Location = New System.Drawing.Point(32, 48)
        Me.dgvTrails.MultiSelect = False
        Me.dgvTrails.Name = "dgvTrails"
        Me.dgvTrails.ReadOnly = True
        Me.dgvTrails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTrails.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTrails.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvTrails.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTrails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTrails.ShowEditingIcon = False
        Me.dgvTrails.Size = New System.Drawing.Size(791, 642)
        Me.dgvTrails.TabIndex = 127
        '
        'tabTrails
        '
        Me.tabTrails.Controls.Add(Me.TabPage1)
        Me.tabTrails.Controls.Add(Me.TabPage2)
        Me.tabTrails.Location = New System.Drawing.Point(843, 48)
        Me.tabTrails.Name = "tabTrails"
        Me.tabTrails.SelectedIndex = 0
        Me.tabTrails.Size = New System.Drawing.Size(286, 642)
        Me.tabTrails.TabIndex = 131
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.addDescription)
        Me.TabPage1.Controls.Add(Me.addMinPerson)
        Me.TabPage1.Controls.Add(Me.lblTransacPesoSign)
        Me.TabPage1.Controls.Add(Me.btnAddTrail)
        Me.TabPage1.Controls.Add(Me.lblClearAdd)
        Me.TabPage1.Controls.Add(Me.addPrice)
        Me.TabPage1.Controls.Add(Me.addTrailName)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.addDuration)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(278, 609)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "  Add New Trail   "
        '
        'addDescription
        '
        Me.addDescription.BackColor = System.Drawing.Color.White
        Me.addDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.addDescription.Location = New System.Drawing.Point(14, 250)
        Me.addDescription.Name = "addDescription"
        Me.addDescription.Size = New System.Drawing.Size(252, 205)
        Me.addDescription.TabIndex = 4
        Me.addDescription.Text = ""
        '
        'addMinPerson
        '
        Me.addMinPerson.BackColor = System.Drawing.Color.White
        Me.addMinPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.addMinPerson.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addMinPerson.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.addMinPerson.Location = New System.Drawing.Point(148, 108)
        Me.addMinPerson.MaxLength = 2
        Me.addMinPerson.Name = "addMinPerson"
        Me.addMinPerson.Size = New System.Drawing.Size(118, 30)
        Me.addMinPerson.TabIndex = 2
        '
        'lblTransacPesoSign
        '
        Me.lblTransacPesoSign.AutoSize = True
        Me.lblTransacPesoSign.BackColor = System.Drawing.Color.White
        Me.lblTransacPesoSign.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransacPesoSign.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.lblTransacPesoSign.Location = New System.Drawing.Point(19, 180)
        Me.lblTransacPesoSign.Name = "lblTransacPesoSign"
        Me.lblTransacPesoSign.Size = New System.Drawing.Size(27, 27)
        Me.lblTransacPesoSign.TabIndex = 130
        Me.lblTransacPesoSign.Text = "₱"
        '
        'lblClearAdd
        '
        Me.lblClearAdd.AutoSize = True
        Me.lblClearAdd.BackColor = System.Drawing.Color.Transparent
        Me.lblClearAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClearAdd.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearAdd.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblClearAdd.Location = New System.Drawing.Point(102, 536)
        Me.lblClearAdd.Name = "lblClearAdd"
        Me.lblClearAdd.Size = New System.Drawing.Size(75, 18)
        Me.lblClearAdd.TabIndex = 6
        Me.lblClearAdd.Text = "Clear Form"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.btnDelTrail)
        Me.TabPage2.Controls.Add(Me.updDescription)
        Me.TabPage2.Controls.Add(Me.updMinPerson)
        Me.TabPage2.Controls.Add(Me.lblClearUpdate)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.btnUpdTrail)
        Me.TabPage2.Controls.Add(Me.updPrice)
        Me.TabPage2.Controls.Add(Me.lblUpdTrailID)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.updTrailName)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.updDuration)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(278, 609)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "  Update Trail   "
        '
        'btnDelTrail
        '
        Me.btnDelTrail.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelTrail.BackColor = System.Drawing.Color.Firebrick
        Me.btnDelTrail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelTrail.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnDelTrail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelTrail.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelTrail.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDelTrail.Location = New System.Drawing.Point(144, 479)
        Me.btnDelTrail.Name = "btnDelTrail"
        Me.btnDelTrail.Size = New System.Drawing.Size(121, 44)
        Me.btnDelTrail.TabIndex = 6
        Me.btnDelTrail.Text = "Delete"
        Me.btnDelTrail.UseVisualStyleBackColor = False
        '
        'updDescription
        '
        Me.updDescription.BackColor = System.Drawing.Color.White
        Me.updDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.updDescription.Location = New System.Drawing.Point(13, 250)
        Me.updDescription.Name = "updDescription"
        Me.updDescription.Size = New System.Drawing.Size(252, 205)
        Me.updDescription.TabIndex = 4
        Me.updDescription.Text = ""
        '
        'updMinPerson
        '
        Me.updMinPerson.BackColor = System.Drawing.Color.White
        Me.updMinPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.updMinPerson.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updMinPerson.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.updMinPerson.Location = New System.Drawing.Point(147, 109)
        Me.updMinPerson.MaxLength = 2
        Me.updMinPerson.Name = "updMinPerson"
        Me.updMinPerson.Size = New System.Drawing.Size(118, 30)
        Me.updMinPerson.TabIndex = 2
        '
        'lblClearUpdate
        '
        Me.lblClearUpdate.AutoSize = True
        Me.lblClearUpdate.BackColor = System.Drawing.Color.Transparent
        Me.lblClearUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClearUpdate.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearUpdate.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblClearUpdate.Location = New System.Drawing.Point(102, 536)
        Me.lblClearUpdate.Name = "lblClearUpdate"
        Me.lblClearUpdate.Size = New System.Drawing.Size(75, 18)
        Me.lblClearUpdate.TabIndex = 7
        Me.lblClearUpdate.Text = "Clear Form"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(18, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 27)
        Me.Label5.TabIndex = 139
        Me.Label5.Text = "₱"
        '
        'updPrice
        '
        Me.updPrice.BackColor = System.Drawing.Color.White
        Me.updPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.updPrice.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.updPrice.Location = New System.Drawing.Point(13, 178)
        Me.updPrice.MaxLength = 6
        Me.updPrice.Name = "updPrice"
        Me.updPrice.Size = New System.Drawing.Size(252, 32)
        Me.updPrice.TabIndex = 3
        Me.updPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblUpdTrailID
        '
        Me.lblUpdTrailID.BackColor = System.Drawing.Color.Transparent
        Me.lblUpdTrailID.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdTrailID.ForeColor = System.Drawing.Color.LightGray
        Me.lblUpdTrailID.Location = New System.Drawing.Point(3, 588)
        Me.lblUpdTrailID.Margin = New System.Windows.Forms.Padding(0)
        Me.lblUpdTrailID.Name = "lblUpdTrailID"
        Me.lblUpdTrailID.Size = New System.Drawing.Size(272, 18)
        Me.lblUpdTrailID.TabIndex = 136
        Me.lblUpdTrailID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(10, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 18)
        Me.Label9.TabIndex = 134
        Me.Label9.Text = "Duration"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(10, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 18)
        Me.Label10.TabIndex = 137
        Me.Label10.Text = "Price"
        '
        'updTrailName
        '
        Me.updTrailName.BackColor = System.Drawing.Color.White
        Me.updTrailName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.updTrailName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.updTrailName.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updTrailName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.updTrailName.Location = New System.Drawing.Point(13, 40)
        Me.updTrailName.Name = "updTrailName"
        Me.updTrailName.Size = New System.Drawing.Size(252, 30)
        Me.updTrailName.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Location = New System.Drawing.Point(144, 88)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 18)
        Me.Label12.TabIndex = 135
        Me.Label12.Text = "Min. person"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Location = New System.Drawing.Point(10, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 18)
        Me.Label11.TabIndex = 129
        Me.Label11.Text = "Trail name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label13.Location = New System.Drawing.Point(10, 229)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 18)
        Me.Label13.TabIndex = 133
        Me.Label13.Text = "Description"
        '
        'updDuration
        '
        Me.updDuration.BackColor = System.Drawing.Color.White
        Me.updDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.updDuration.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updDuration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.updDuration.Location = New System.Drawing.Point(13, 109)
        Me.updDuration.MaxLength = 20
        Me.updDuration.Name = "updDuration"
        Me.updDuration.Size = New System.Drawing.Size(118, 30)
        Me.updDuration.TabIndex = 1
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Trail name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Description"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Min. person"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 60
        '
        'Column5
        '
        Me.Column5.HeaderText = "Duration"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Price"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 90
        '
        'ctrlTrails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.tabTrails)
        Me.Controls.Add(Me.dgvTrails)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ctrlTrails"
        Me.Size = New System.Drawing.Size(1161, 738)
        CType(Me.dgvTrails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTrails.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents addPrice As TextBox
    Friend WithEvents btnUpdTrail As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents addDuration As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents addTrailName As TextBox
    Friend WithEvents dgvTrails As DataGridView
    Friend WithEvents btnAddTrail As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents tabTrails As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lblClearAdd As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lblClearUpdate As Label
    Friend WithEvents lblUpdTrailID As Label
    Friend WithEvents updTrailName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lblTransacPesoSign As Label
    Friend WithEvents addMinPerson As TextBox
    Friend WithEvents addDescription As RichTextBox
    Friend WithEvents updDescription As RichTextBox
    Friend WithEvents updMinPerson As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents updPrice As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents updDuration As TextBox
    Friend WithEvents btnDelTrail As Button
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
