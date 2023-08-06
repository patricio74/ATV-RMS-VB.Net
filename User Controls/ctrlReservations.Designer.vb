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
        Me.components = New System.ComponentModel.Container()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelRes = New System.Windows.Forms.Button()
        Me.btnUpdRes = New System.Windows.Forms.Button()
        Me.btnAddRes = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(45, 70)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1085, 280)
        Me.ListView1.TabIndex = 13
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Customer Name"
        Me.ColumnHeader1.Width = 260
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ATV Tour"
        Me.ColumnHeader2.Width = 220
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tour Guide"
        Me.ColumnHeader3.Width = 217
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date"
        Me.ColumnHeader4.Width = 159
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Rate"
        Me.ColumnHeader5.Width = 137
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.White
        Me.ComboBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.ItemHeight = 18
        Me.ComboBox2.Items.AddRange(New Object() {"APRIL", "AUGUST", "DECEMBER", "FEBRUARY", "JANUARY", "JULY", "JUNE", "MARCH", "MAY", "NOVEMBER", "OCTOBER", "SEPTEMBER"})
        Me.ComboBox2.Location = New System.Drawing.Point(846, 38)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(146, 26)
        Me.ComboBox2.TabIndex = 65
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefresh.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnRefresh.Location = New System.Drawing.Point(998, 38)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(66, 26)
        Me.btnRefresh.TabIndex = 67
        Me.btnRefresh.Text = "View"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(964, 652)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(121, 44)
        Me.btnClear.TabIndex = 94
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDelRes
        '
        Me.btnDelRes.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnDelRes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelRes.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnDelRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelRes.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelRes.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDelRes.Location = New System.Drawing.Point(837, 652)
        Me.btnDelRes.Name = "btnDelRes"
        Me.btnDelRes.Size = New System.Drawing.Size(121, 44)
        Me.btnDelRes.TabIndex = 93
        Me.btnDelRes.Text = "Delete"
        Me.btnDelRes.UseVisualStyleBackColor = False
        '
        'btnUpdRes
        '
        Me.btnUpdRes.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnUpdRes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdRes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnUpdRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdRes.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdRes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnUpdRes.Location = New System.Drawing.Point(710, 652)
        Me.btnUpdRes.Name = "btnUpdRes"
        Me.btnUpdRes.Size = New System.Drawing.Size(121, 44)
        Me.btnUpdRes.TabIndex = 92
        Me.btnUpdRes.Text = "Update"
        Me.btnUpdRes.UseVisualStyleBackColor = False
        '
        'btnAddRes
        '
        Me.btnAddRes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnAddRes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddRes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnAddRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRes.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnAddRes.Location = New System.Drawing.Point(583, 652)
        Me.btnAddRes.Name = "btnAddRes"
        Me.btnAddRes.Size = New System.Drawing.Size(121, 44)
        Me.btnAddRes.TabIndex = 91
        Me.btnAddRes.Text = "Add"
        Me.btnAddRes.UseVisualStyleBackColor = False
        '
        'ctrlReservations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelRes)
        Me.Controls.Add(Me.btnUpdRes)
        Me.Controls.Add(Me.btnAddRes)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ListView1)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ctrlReservations"
        Me.Size = New System.Drawing.Size(1161, 738)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelRes As Button
    Friend WithEvents btnUpdRes As Button
    Friend WithEvents btnAddRes As Button
    Friend WithEvents Timer1 As Timer
End Class
