<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class selectATV
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(selectATV))
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.labelFormTitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblATVCount = New System.Windows.Forms.Label()
        Me.lblClearList = New System.Windows.Forms.Label()
        Me.btnSaveList = New System.Windows.Forms.Button()
        Me.atvCheckList = New System.Windows.Forms.CheckedListBox()
        Me.panelTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.panelTop.Controls.Add(Me.labelFormTitle)
        Me.panelTop.Controls.Add(Me.PictureBox1)
        Me.panelTop.Controls.Add(Me.btnClose)
        Me.panelTop.Location = New System.Drawing.Point(4, 4)
        Me.panelTop.Margin = New System.Windows.Forms.Padding(0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(365, 30)
        Me.panelTop.TabIndex = 19
        '
        'labelFormTitle
        '
        Me.labelFormTitle.AutoSize = True
        Me.labelFormTitle.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelFormTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.labelFormTitle.Location = New System.Drawing.Point(33, 5)
        Me.labelFormTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.labelFormTitle.Name = "labelFormTitle"
        Me.labelFormTitle.Size = New System.Drawing.Size(90, 20)
        Me.labelFormTitle.TabIndex = 20
        Me.labelFormTitle.Text = "Select ATVs"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.ATV_RMS.My.Resources.Resources.logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(9, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
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
        Me.btnClose.Location = New System.Drawing.Point(335, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.TabIndex = 20
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "x"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.lblATVCount)
        Me.Panel1.Controls.Add(Me.lblClearList)
        Me.Panel1.Controls.Add(Me.btnSaveList)
        Me.Panel1.Controls.Add(Me.atvCheckList)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(4, 34)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(365, 352)
        Me.Panel1.TabIndex = 20
        '
        'lblATVCount
        '
        Me.lblATVCount.Location = New System.Drawing.Point(3, 19)
        Me.lblATVCount.Name = "lblATVCount"
        Me.lblATVCount.Padding = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblATVCount.Size = New System.Drawing.Size(359, 21)
        Me.lblATVCount.TabIndex = 14
        Me.lblATVCount.Text = "Please select x ATV:"
        '
        'lblClearList
        '
        Me.lblClearList.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblClearList.AutoSize = True
        Me.lblClearList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClearList.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClearList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.lblClearList.Location = New System.Drawing.Point(118, 314)
        Me.lblClearList.Name = "lblClearList"
        Me.lblClearList.Size = New System.Drawing.Size(114, 22)
        Me.lblClearList.TabIndex = 13
        Me.lblClearList.Text = "clear selection"
        '
        'btnSaveList
        '
        Me.btnSaveList.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSaveList.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnSaveList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveList.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnSaveList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveList.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveList.ForeColor = System.Drawing.Color.White
        Me.btnSaveList.Location = New System.Drawing.Point(65, 253)
        Me.btnSaveList.Name = "btnSaveList"
        Me.btnSaveList.Size = New System.Drawing.Size(228, 54)
        Me.btnSaveList.TabIndex = 12
        Me.btnSaveList.Text = "Save selection"
        Me.btnSaveList.UseVisualStyleBackColor = False
        '
        'atvCheckList
        '
        Me.atvCheckList.BackColor = System.Drawing.Color.WhiteSmoke
        Me.atvCheckList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.atvCheckList.CheckOnClick = True
        Me.atvCheckList.Cursor = System.Windows.Forms.Cursors.Default
        Me.atvCheckList.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atvCheckList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.atvCheckList.FormattingEnabled = True
        Me.atvCheckList.HorizontalScrollbar = True
        Me.atvCheckList.Items.AddRange(New Object() {"ATV1", "ATV2", "ATV3", "ATV4", "ATV5", "ATV6", "ATV7", "ATV8", "ATV9"})
        Me.atvCheckList.Location = New System.Drawing.Point(37, 43)
        Me.atvCheckList.Name = "atvCheckList"
        Me.atvCheckList.Size = New System.Drawing.Size(285, 198)
        Me.atvCheckList.TabIndex = 0
        '
        'selectATV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(373, 390)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelTop)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "selectATV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "selectATV"
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents panelTop As Panel
    Private WithEvents labelFormTitle As Label
    Private WithEvents PictureBox1 As PictureBox
    Private WithEvents btnClose As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents atvCheckList As CheckedListBox
    Friend WithEvents btnSaveList As Button
    Friend WithEvents lblClearList As Label
    Friend WithEvents lblATVCount As Label
End Class
