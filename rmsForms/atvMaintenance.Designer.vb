<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class atvMaintenance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(atvMaintenance))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbxCost = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxOtherInfo = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblClearForm = New System.Windows.Forms.Label()
        Me.btnSaveMaintenanceInfo = New System.Windows.Forms.Button()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.panelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.tbxCost)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cbxType)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tbxOtherInfo)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Controls.Add(Me.lblClearForm)
        Me.Panel1.Controls.Add(Me.btnSaveMaintenanceInfo)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(4, 34)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(419, 390)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 22)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Total cost:"
        '
        'tbxCost
        '
        Me.tbxCost.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxCost.BackColor = System.Drawing.Color.White
        Me.tbxCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxCost.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCost.Location = New System.Drawing.Point(118, 225)
        Me.tbxCost.Name = "tbxCost"
        Me.tbxCost.Size = New System.Drawing.Size(271, 31)
        Me.tbxCost.TabIndex = 6
        Me.tbxCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Maintenance type:"
        '
        'cbxType
        '
        Me.cbxType.BackColor = System.Drawing.Color.White
        Me.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxType.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxType.FormattingEnabled = True
        Me.cbxType.Items.AddRange(New Object() {"General Cleaning", "Oil Change", "Air Filter Replacement", "Spark Plug Replacement", "Coolant Check/Replacement", "Brake Inspection and Replacement", "Tire Inspection and Replacement", "Wheel Bearing Maintenance", "Drive Chain Inspection and Lubrication", "Suspension System Inspection/Adjustment", "Battery Check/Replacement", "Exhaust System Inspection", "Electrical System Check", "Others"})
        Me.cbxType.Location = New System.Drawing.Point(32, 89)
        Me.cbxType.Name = "cbxType"
        Me.cbxType.Size = New System.Drawing.Size(357, 26)
        Me.cbxType.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Other maintenance, notes, etc.:"
        '
        'tbxOtherInfo
        '
        Me.tbxOtherInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxOtherInfo.BackColor = System.Drawing.Color.White
        Me.tbxOtherInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxOtherInfo.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxOtherInfo.Location = New System.Drawing.Point(32, 161)
        Me.tbxOtherInfo.Name = "tbxOtherInfo"
        Me.tbxOtherInfo.Size = New System.Drawing.Size(357, 31)
        Me.tbxOtherInfo.TabIndex = 4
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(3, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Size = New System.Drawing.Size(413, 53)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "ATV MAINTENANCE INFORMATION"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblClearForm
        '
        Me.lblClearForm.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblClearForm.AutoSize = True
        Me.lblClearForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClearForm.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.lblClearForm.Location = New System.Drawing.Point(166, 354)
        Me.lblClearForm.Name = "lblClearForm"
        Me.lblClearForm.Size = New System.Drawing.Size(84, 22)
        Me.lblClearForm.TabIndex = 8
        Me.lblClearForm.Text = "clear form"
        '
        'btnSaveMaintenanceInfo
        '
        Me.btnSaveMaintenanceInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSaveMaintenanceInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnSaveMaintenanceInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveMaintenanceInfo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSaveMaintenanceInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveMaintenanceInfo.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveMaintenanceInfo.ForeColor = System.Drawing.Color.White
        Me.btnSaveMaintenanceInfo.Location = New System.Drawing.Point(113, 294)
        Me.btnSaveMaintenanceInfo.Name = "btnSaveMaintenanceInfo"
        Me.btnSaveMaintenanceInfo.Size = New System.Drawing.Size(194, 48)
        Me.btnSaveMaintenanceInfo.TabIndex = 7
        Me.btnSaveMaintenanceInfo.Text = "Save Info"
        Me.btnSaveMaintenanceInfo.UseVisualStyleBackColor = False
        '
        'panelTop
        '
        Me.panelTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.panelTop.Controls.Add(Me.btnClose)
        Me.panelTop.Location = New System.Drawing.Point(4, 4)
        Me.panelTop.Margin = New System.Windows.Forms.Padding(0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(419, 30)
        Me.panelTop.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Red
        Me.btnClose.Location = New System.Drawing.Point(389, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.TabIndex = 0
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "x"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'atvMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(428, 430)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "atvMaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "atvMaintenance"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblClearForm As Label
    Friend WithEvents btnSaveMaintenanceInfo As Button
    Private WithEvents panelTop As Panel
    Private WithEvents btnClose As Button
    Friend WithEvents tbxOtherInfo As TextBox
    Friend WithEvents cbxType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbxCost As TextBox
End Class
