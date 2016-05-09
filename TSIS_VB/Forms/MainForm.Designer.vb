<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.OperationsGroupBox = New System.Windows.Forms.GroupBox()
        Me.OpenButton = New System.Windows.Forms.Button()
        Me.UpdateStocksRadioButton = New System.Windows.Forms.RadioButton()
        Me.CheckStockRadioButton = New System.Windows.Forms.RadioButton()
        Me.ChangeReorderRadioButton = New System.Windows.Forms.RadioButton()
        Me.ToolsAllocationRadioButton = New System.Windows.Forms.RadioButton()
        Me.MRNGeneratorRadioButton = New System.Windows.Forms.RadioButton()
        Me.CredentialGroupBox = New System.Windows.Forms.GroupBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.TSISStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.AboutStatusStripLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.OperationsGroupBox.SuspendLayout
        Me.CredentialGroupBox.SuspendLayout
        Me.TSISStatusStrip.SuspendLayout
        Me.SuspendLayout
        '
        'OperationsGroupBox
        '
        Me.OperationsGroupBox.Controls.Add(Me.OpenButton)
        Me.OperationsGroupBox.Controls.Add(Me.UpdateStocksRadioButton)
        Me.OperationsGroupBox.Controls.Add(Me.CheckStockRadioButton)
        Me.OperationsGroupBox.Controls.Add(Me.ChangeReorderRadioButton)
        Me.OperationsGroupBox.Controls.Add(Me.ToolsAllocationRadioButton)
        Me.OperationsGroupBox.Controls.Add(Me.MRNGeneratorRadioButton)
        Me.OperationsGroupBox.Enabled = false
        Me.OperationsGroupBox.Location = New System.Drawing.Point(11, 126)
        Me.OperationsGroupBox.Name = "OperationsGroupBox"
        Me.OperationsGroupBox.Size = New System.Drawing.Size(260, 168)
        Me.OperationsGroupBox.TabIndex = 3
        Me.OperationsGroupBox.TabStop = false
        Me.OperationsGroupBox.Text = "Operations"
        '
        'OpenButton
        '
        Me.OpenButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OpenButton.Location = New System.Drawing.Point(6, 136)
        Me.OpenButton.Name = "OpenButton"
        Me.OpenButton.Size = New System.Drawing.Size(75, 23)
        Me.OpenButton.TabIndex = 5
        Me.OpenButton.Tag = "User Access"
        Me.OpenButton.Text = "Open"
        Me.OpenButton.UseVisualStyleBackColor = true
        '
        'UpdateStocksRadioButton
        '
        Me.UpdateStocksRadioButton.AutoSize = true
        Me.UpdateStocksRadioButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateStocksRadioButton.Location = New System.Drawing.Point(6, 67)
        Me.UpdateStocksRadioButton.Name = "UpdateStocksRadioButton"
        Me.UpdateStocksRadioButton.Size = New System.Drawing.Size(99, 17)
        Me.UpdateStocksRadioButton.TabIndex = 4
        Me.UpdateStocksRadioButton.Tag = "4"
        Me.UpdateStocksRadioButton.Text = "Update Stocks"
        Me.UpdateStocksRadioButton.UseVisualStyleBackColor = true
        '
        'CheckStockRadioButton
        '
        Me.CheckStockRadioButton.AutoSize = true
        Me.CheckStockRadioButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckStockRadioButton.Location = New System.Drawing.Point(6, 113)
        Me.CheckStockRadioButton.Name = "CheckStockRadioButton"
        Me.CheckStockRadioButton.Size = New System.Drawing.Size(149, 17)
        Me.CheckStockRadioButton.TabIndex = 3
        Me.CheckStockRadioButton.Tag = "5"
        Me.CheckStockRadioButton.Text = "Check Stock (Read Only)"
        Me.CheckStockRadioButton.UseVisualStyleBackColor = true
        '
        'ChangeReorderRadioButton
        '
        Me.ChangeReorderRadioButton.AutoSize = true
        Me.ChangeReorderRadioButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChangeReorderRadioButton.Location = New System.Drawing.Point(6, 90)
        Me.ChangeReorderRadioButton.Name = "ChangeReorderRadioButton"
        Me.ChangeReorderRadioButton.Size = New System.Drawing.Size(137, 17)
        Me.ChangeReorderRadioButton.TabIndex = 2
        Me.ChangeReorderRadioButton.Tag = "3"
        Me.ChangeReorderRadioButton.Text = "Change Reorder Level"
        Me.ChangeReorderRadioButton.UseVisualStyleBackColor = true
        '
        'ToolsAllocationRadioButton
        '
        Me.ToolsAllocationRadioButton.AutoSize = true
        Me.ToolsAllocationRadioButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ToolsAllocationRadioButton.Location = New System.Drawing.Point(6, 44)
        Me.ToolsAllocationRadioButton.Name = "ToolsAllocationRadioButton"
        Me.ToolsAllocationRadioButton.Size = New System.Drawing.Size(169, 17)
        Me.ToolsAllocationRadioButton.TabIndex = 1
        Me.ToolsAllocationRadioButton.Tag = "2"
        Me.ToolsAllocationRadioButton.Text = "Tools Allocation as per MRN"
        Me.ToolsAllocationRadioButton.UseVisualStyleBackColor = true
        '
        'MRNGeneratorRadioButton
        '
        Me.MRNGeneratorRadioButton.AutoSize = true
        Me.MRNGeneratorRadioButton.Checked = true
        Me.MRNGeneratorRadioButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MRNGeneratorRadioButton.Location = New System.Drawing.Point(6, 21)
        Me.MRNGeneratorRadioButton.Name = "MRNGeneratorRadioButton"
        Me.MRNGeneratorRadioButton.Size = New System.Drawing.Size(195, 17)
        Me.MRNGeneratorRadioButton.TabIndex = 0
        Me.MRNGeneratorRadioButton.TabStop = true
        Me.MRNGeneratorRadioButton.Tag = "User Access"
        Me.MRNGeneratorRadioButton.Text = "Material Request Note Generator"
        Me.MRNGeneratorRadioButton.UseVisualStyleBackColor = true
        '
        'CredentialGroupBox
        '
        Me.CredentialGroupBox.Controls.Add(Me.LoginButton)
        Me.CredentialGroupBox.Controls.Add(Me.label2)
        Me.CredentialGroupBox.Controls.Add(Me.PasswordTextBox)
        Me.CredentialGroupBox.Controls.Add(Me.label1)
        Me.CredentialGroupBox.Controls.Add(Me.UsernameTextBox)
        Me.CredentialGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.CredentialGroupBox.Name = "CredentialGroupBox"
        Me.CredentialGroupBox.Size = New System.Drawing.Size(259, 108)
        Me.CredentialGroupBox.TabIndex = 2
        Me.CredentialGroupBox.TabStop = false
        Me.CredentialGroupBox.Text = "Login"
        '
        'LoginButton
        '
        Me.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginButton.Location = New System.Drawing.Point(9, 77)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(75, 23)
        Me.LoginButton.TabIndex = 5
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = true
        '
        'label2
        '
        Me.label2.AutoSize = true
        Me.label2.Location = New System.Drawing.Point(8, 52)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(59, 13)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Password:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(73, 49)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(180, 22)
        Me.PasswordTextBox.TabIndex = 3
        Me.PasswordTextBox.Text = "Password"
        '
        'label1
        '
        Me.label1.AutoSize = true
        Me.label1.Location = New System.Drawing.Point(6, 24)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(61, 13)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Username:"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(73, 21)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(180, 22)
        Me.UsernameTextBox.TabIndex = 1
        Me.UsernameTextBox.Text = "Admin"
        '
        'TSISStatusStrip
        '
        Me.TSISStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel1, Me.toolStripStatusLabel3, Me.AboutStatusStripLabel})
        Me.TSISStatusStrip.Location = New System.Drawing.Point(0, 300)
        Me.TSISStatusStrip.Name = "TSISStatusStrip"
        Me.TSISStatusStrip.Size = New System.Drawing.Size(284, 22)
        Me.TSISStatusStrip.SizingGrip = false
        Me.TSISStatusStrip.TabIndex = 4
        Me.TSISStatusStrip.Text = "statusStrip1"
        '
        'toolStripStatusLabel1
        '
        Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
        Me.toolStripStatusLabel1.Size = New System.Drawing.Size(154, 17)
        Me.toolStripStatusLabel1.Text = "CS492 VB Project (2014 - 18)"
        '
        'toolStripStatusLabel3
        '
        Me.toolStripStatusLabel3.Name = "toolStripStatusLabel3"
        Me.toolStripStatusLabel3.Size = New System.Drawing.Size(75, 17)
        Me.toolStripStatusLabel3.Spring = true
        '
        'AboutStatusStripLabel
        '
        Me.AboutStatusStripLabel.IsLink = true
        Me.AboutStatusStripLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AboutStatusStripLabel.LinkColor = System.Drawing.Color.Blue
        Me.AboutStatusStripLabel.Name = "AboutStatusStripLabel"
        Me.AboutStatusStripLabel.Size = New System.Drawing.Size(40, 17)
        Me.AboutStatusStripLabel.Text = "About"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 322)
        Me.Controls.Add(Me.TSISStatusStrip)
        Me.Controls.Add(Me.OperationsGroupBox)
        Me.Controls.Add(Me.CredentialGroupBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "MainForm"
        Me.Text = "TSIS"
        Me.OperationsGroupBox.ResumeLayout(false)
        Me.OperationsGroupBox.PerformLayout
        Me.CredentialGroupBox.ResumeLayout(false)
        Me.CredentialGroupBox.PerformLayout
        Me.TSISStatusStrip.ResumeLayout(false)
        Me.TSISStatusStrip.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Private WithEvents OperationsGroupBox As GroupBox
    Private WithEvents OpenButton As Button
    Private WithEvents UpdateStocksRadioButton As RadioButton
    Private WithEvents CheckStockRadioButton As RadioButton
    Private WithEvents ChangeReorderRadioButton As RadioButton
    Private WithEvents ToolsAllocationRadioButton As RadioButton
    Private WithEvents MRNGeneratorRadioButton As RadioButton
    Private WithEvents CredentialGroupBox As GroupBox
    Private WithEvents LoginButton As Button
    Private WithEvents label2 As Label
    Private WithEvents PasswordTextBox As TextBox
    Private WithEvents label1 As Label
    Private WithEvents UsernameTextBox As TextBox
    Private WithEvents TSISStatusStrip As StatusStrip
    Private WithEvents toolStripStatusLabel1 As ToolStripStatusLabel
    Private WithEvents toolStripStatusLabel3 As ToolStripStatusLabel
    Private WithEvents AboutStatusStripLabel As ToolStripStatusLabel
End Class
