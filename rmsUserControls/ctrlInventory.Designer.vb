<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ctrlInventory
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
        Me.cbxUpdStatus = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.updID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.updBrand = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rtbxUpdDesc = New System.Windows.Forms.RichTextBox()
        Me.updModel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnUpdAtv = New System.Windows.Forms.Button()
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabInventory = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnDelAtv = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cbxAddStatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addBrand = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.addModel = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rtbxAddDesc = New System.Windows.Forms.RichTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblClearAtv = New System.Windows.Forms.Label()
        Me.btnAddAtv = New System.Windows.Forms.Button()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabInventory.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxUpdStatus
        '
        Me.cbxUpdStatus.BackColor = System.Drawing.Color.White
        Me.cbxUpdStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxUpdStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxUpdStatus.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxUpdStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cbxUpdStatus.FormattingEnabled = True
        Me.cbxUpdStatus.ItemHeight = 22
        Me.cbxUpdStatus.Items.AddRange(New Object() {"AVAILABLE", "NOT AVAILABLE", "MAINTENANCE"})
        Me.cbxUpdStatus.Location = New System.Drawing.Point(253, 64)
        Me.cbxUpdStatus.Name = "cbxUpdStatus"
        Me.cbxUpdStatus.Size = New System.Drawing.Size(139, 30)
        Me.cbxUpdStatus.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(250, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 18)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "STATUS"
        '
        'updID
        '
        Me.updID.BackColor = System.Drawing.Color.White
        Me.updID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.updID.Cursor = System.Windows.Forms.Cursors.No
        Me.updID.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.updID.Location = New System.Drawing.Point(56, 63)
        Me.updID.Name = "updID"
        Me.updID.ReadOnly = True
        Me.updID.Size = New System.Drawing.Size(191, 30)
        Me.updID.TabIndex = 0
        Me.updID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(53, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 18)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(459, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 18)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "DESCRIPTION:"
        '
        'updBrand
        '
        Me.updBrand.BackColor = System.Drawing.Color.White
        Me.updBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.updBrand.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.updBrand.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updBrand.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.updBrand.Location = New System.Drawing.Point(56, 136)
        Me.updBrand.Name = "updBrand"
        Me.updBrand.Size = New System.Drawing.Size(336, 30)
        Me.updBrand.TabIndex = 2
        Me.updBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(53, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 18)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "BRAND"
        '
        'rtbxUpdDesc
        '
        Me.rtbxUpdDesc.BackColor = System.Drawing.Color.White
        Me.rtbxUpdDesc.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbxUpdDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.rtbxUpdDesc.Location = New System.Drawing.Point(462, 46)
        Me.rtbxUpdDesc.Name = "rtbxUpdDesc"
        Me.rtbxUpdDesc.Size = New System.Drawing.Size(552, 187)
        Me.rtbxUpdDesc.TabIndex = 4
        Me.rtbxUpdDesc.Text = ""
        '
        'updModel
        '
        Me.updModel.BackColor = System.Drawing.Color.White
        Me.updModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.updModel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.updModel.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updModel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.updModel.Location = New System.Drawing.Point(56, 214)
        Me.updModel.Name = "updModel"
        Me.updModel.Size = New System.Drawing.Size(336, 30)
        Me.updModel.TabIndex = 3
        Me.updModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(54, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 18)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "MODEL"
        '
        'btnUpdAtv
        '
        Me.btnUpdAtv.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnUpdAtv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdAtv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnUpdAtv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdAtv.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdAtv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnUpdAtv.Location = New System.Drawing.Point(719, 246)
        Me.btnUpdAtv.Name = "btnUpdAtv"
        Me.btnUpdAtv.Size = New System.Drawing.Size(136, 44)
        Me.btnUpdAtv.TabIndex = 5
        Me.btnUpdAtv.Text = "Update ATV"
        Me.btnUpdAtv.UseVisualStyleBackColor = False
        '
        'dgvInventory
        '
        Me.dgvInventory.AllowUserToAddRows = False
        Me.dgvInventory.AllowUserToOrderColumns = True
        Me.dgvInventory.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvInventory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInventory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvInventory.EnableHeadersVisualStyles = False
        Me.dgvInventory.GridColor = System.Drawing.Color.DimGray
        Me.dgvInventory.Location = New System.Drawing.Point(33, 27)
        Me.dgvInventory.MultiSelect = False
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.ReadOnly = True
        Me.dgvInventory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInventory.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvInventory.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvInventory.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInventory.ShowEditingIcon = False
        Me.dgvInventory.Size = New System.Drawing.Size(1095, 317)
        Me.dgvInventory.TabIndex = 95
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
        Me.Column2.HeaderText = "BRAND"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "MODEL"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "STATUS"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "DESCRIPTION"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'tabInventory
        '
        Me.tabInventory.Controls.Add(Me.TabPage1)
        Me.tabInventory.Controls.Add(Me.TabPage2)
        Me.tabInventory.Location = New System.Drawing.Point(44, 366)
        Me.tabInventory.Name = "tabInventory"
        Me.tabInventory.SelectedIndex = 0
        Me.tabInventory.Size = New System.Drawing.Size(1077, 347)
        Me.tabInventory.TabIndex = 127
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.btnDelAtv)
        Me.TabPage1.Controls.Add(Me.cbxUpdStatus)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.btnUpdAtv)
        Me.TabPage1.Controls.Add(Me.updBrand)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.updModel)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.updID)
        Me.TabPage1.Controls.Add(Me.rtbxUpdDesc)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1069, 314)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "  Update ATV   "
        '
        'btnDelAtv
        '
        Me.btnDelAtv.BackColor = System.Drawing.Color.Transparent
        Me.btnDelAtv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelAtv.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnDelAtv.FlatAppearance.BorderSize = 0
        Me.btnDelAtv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelAtv.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelAtv.ForeColor = System.Drawing.Color.Red
        Me.btnDelAtv.Location = New System.Drawing.Point(881, 254)
        Me.btnDelAtv.Name = "btnDelAtv"
        Me.btnDelAtv.Size = New System.Drawing.Size(112, 30)
        Me.btnDelAtv.TabIndex = 6
        Me.btnDelAtv.Text = "Delete ATV"
        Me.btnDelAtv.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.cbxAddStatus)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.addBrand)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.addModel)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.rtbxAddDesc)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.lblClearAtv)
        Me.TabPage2.Controls.Add(Me.btnAddAtv)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1069, 314)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "  Add new ATV   "
        '
        'cbxAddStatus
        '
        Me.cbxAddStatus.BackColor = System.Drawing.Color.White
        Me.cbxAddStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxAddStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAddStatus.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxAddStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.cbxAddStatus.FormattingEnabled = True
        Me.cbxAddStatus.ItemHeight = 22
        Me.cbxAddStatus.Items.AddRange(New Object() {"AVAILABLE", "NOT AVAILABLE"})
        Me.cbxAddStatus.Location = New System.Drawing.Point(56, 218)
        Me.cbxAddStatus.Name = "cbxAddStatus"
        Me.cbxAddStatus.Size = New System.Drawing.Size(139, 30)
        Me.cbxAddStatus.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(54, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 18)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "BRAND"
        '
        'addBrand
        '
        Me.addBrand.BackColor = System.Drawing.Color.White
        Me.addBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.addBrand.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.addBrand.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBrand.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.addBrand.Location = New System.Drawing.Point(57, 61)
        Me.addBrand.Name = "addBrand"
        Me.addBrand.Size = New System.Drawing.Size(336, 30)
        Me.addBrand.TabIndex = 0
        Me.addBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(459, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 18)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "DESCRIPTION:"
        '
        'addModel
        '
        Me.addModel.BackColor = System.Drawing.Color.White
        Me.addModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.addModel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.addModel.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addModel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.addModel.Location = New System.Drawing.Point(56, 140)
        Me.addModel.Name = "addModel"
        Me.addModel.Size = New System.Drawing.Size(336, 30)
        Me.addModel.TabIndex = 1
        Me.addModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(54, 119)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 18)
        Me.Label9.TabIndex = 135
        Me.Label9.Text = "MODEL"
        '
        'rtbxAddDesc
        '
        Me.rtbxAddDesc.BackColor = System.Drawing.Color.White
        Me.rtbxAddDesc.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbxAddDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.rtbxAddDesc.Location = New System.Drawing.Point(462, 45)
        Me.rtbxAddDesc.Name = "rtbxAddDesc"
        Me.rtbxAddDesc.Size = New System.Drawing.Size(552, 187)
        Me.rtbxAddDesc.TabIndex = 3
        Me.rtbxAddDesc.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(53, 197)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 18)
        Me.Label10.TabIndex = 132
        Me.Label10.Text = "STATUS"
        '
        'lblClearAtv
        '
        Me.lblClearAtv.BackColor = System.Drawing.Color.Transparent
        Me.lblClearAtv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClearAtv.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearAtv.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblClearAtv.Location = New System.Drawing.Point(877, 258)
        Me.lblClearAtv.Name = "lblClearAtv"
        Me.lblClearAtv.Size = New System.Drawing.Size(101, 29)
        Me.lblClearAtv.TabIndex = 6
        Me.lblClearAtv.Text = "Clear Form"
        '
        'btnAddAtv
        '
        Me.btnAddAtv.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnAddAtv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddAtv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnAddAtv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAtv.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAtv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnAddAtv.Location = New System.Drawing.Point(719, 246)
        Me.btnAddAtv.Name = "btnAddAtv"
        Me.btnAddAtv.Size = New System.Drawing.Size(136, 44)
        Me.btnAddAtv.TabIndex = 5
        Me.btnAddAtv.Text = "Add ATV"
        Me.btnAddAtv.UseVisualStyleBackColor = False
        '
        'ctrlInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.tabInventory)
        Me.Controls.Add(Me.dgvInventory)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ctrlInventory"
        Me.Size = New System.Drawing.Size(1161, 738)
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabInventory.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbxUpdStatus As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents updID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents updBrand As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rtbxUpdDesc As RichTextBox
    Friend WithEvents updModel As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnUpdAtv As Button
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents tabInventory As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnDelAtv As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lblClearAtv As Label
    Friend WithEvents btnAddAtv As Button
    Friend WithEvents cbxAddStatus As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents addBrand As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents addModel As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents rtbxAddDesc As RichTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
