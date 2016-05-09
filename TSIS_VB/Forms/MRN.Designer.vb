<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MRN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MRN))
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.GenerateButton = New System.Windows.Forms.Button()
        Me.RequiredToolsGroupBox = New System.Windows.Forms.GroupBox()
        Me.PliersNumericBox = New System.Windows.Forms.NumericUpDown()
        Me.SocketsNumericBox = New System.Windows.Forms.NumericUpDown()
        Me.HammersNumericBox = New System.Windows.Forms.NumericUpDown()
        Me.RatchetsNumericBox = New System.Windows.Forms.NumericUpDown()
        Me.WrenchesNumericBox = New System.Windows.Forms.NumericUpDown()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.UnitNameTextBox = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.RequiredToolsGroupBox.SuspendLayout
        CType(Me.PliersNumericBox,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SocketsNumericBox,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.HammersNumericBox,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RatchetsNumericBox,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.WrenchesNumericBox,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'ResetButton
        '
        Me.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ResetButton.Location = New System.Drawing.Point(197, 214)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(75, 23)
        Me.ResetButton.TabIndex = 9
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = true
        '
        'GenerateButton
        '
        Me.GenerateButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GenerateButton.Location = New System.Drawing.Point(12, 214)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(75, 23)
        Me.GenerateButton.TabIndex = 8
        Me.GenerateButton.Text = "Generate"
        Me.GenerateButton.UseVisualStyleBackColor = true
        '
        'RequiredToolsGroupBox
        '
        Me.RequiredToolsGroupBox.Controls.Add(Me.PliersNumericBox)
        Me.RequiredToolsGroupBox.Controls.Add(Me.SocketsNumericBox)
        Me.RequiredToolsGroupBox.Controls.Add(Me.HammersNumericBox)
        Me.RequiredToolsGroupBox.Controls.Add(Me.RatchetsNumericBox)
        Me.RequiredToolsGroupBox.Controls.Add(Me.WrenchesNumericBox)
        Me.RequiredToolsGroupBox.Controls.Add(Me.label6)
        Me.RequiredToolsGroupBox.Controls.Add(Me.label5)
        Me.RequiredToolsGroupBox.Controls.Add(Me.label4)
        Me.RequiredToolsGroupBox.Controls.Add(Me.label3)
        Me.RequiredToolsGroupBox.Controls.Add(Me.label2)
        Me.RequiredToolsGroupBox.Location = New System.Drawing.Point(12, 39)
        Me.RequiredToolsGroupBox.Name = "RequiredToolsGroupBox"
        Me.RequiredToolsGroupBox.Size = New System.Drawing.Size(260, 169)
        Me.RequiredToolsGroupBox.TabIndex = 7
        Me.RequiredToolsGroupBox.TabStop = false
        Me.RequiredToolsGroupBox.Text = "Required Tools"
        '
        'PliersNumericBox
        '
        Me.PliersNumericBox.Location = New System.Drawing.Point(73, 134)
        Me.PliersNumericBox.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.PliersNumericBox.Name = "PliersNumericBox"
        Me.PliersNumericBox.Size = New System.Drawing.Size(181, 20)
        Me.PliersNumericBox.TabIndex = 17
        '
        'SocketsNumericBox
        '
        Me.SocketsNumericBox.Location = New System.Drawing.Point(73, 106)
        Me.SocketsNumericBox.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.SocketsNumericBox.Name = "SocketsNumericBox"
        Me.SocketsNumericBox.Size = New System.Drawing.Size(181, 20)
        Me.SocketsNumericBox.TabIndex = 16
        '
        'HammersNumericBox
        '
        Me.HammersNumericBox.Location = New System.Drawing.Point(73, 78)
        Me.HammersNumericBox.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.HammersNumericBox.Name = "HammersNumericBox"
        Me.HammersNumericBox.Size = New System.Drawing.Size(181, 20)
        Me.HammersNumericBox.TabIndex = 15
        '
        'RatchetsNumericBox
        '
        Me.RatchetsNumericBox.Location = New System.Drawing.Point(73, 50)
        Me.RatchetsNumericBox.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.RatchetsNumericBox.Name = "RatchetsNumericBox"
        Me.RatchetsNumericBox.Size = New System.Drawing.Size(181, 20)
        Me.RatchetsNumericBox.TabIndex = 14
        '
        'WrenchesNumericBox
        '
        Me.WrenchesNumericBox.Location = New System.Drawing.Point(73, 22)
        Me.WrenchesNumericBox.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.WrenchesNumericBox.Name = "WrenchesNumericBox"
        Me.WrenchesNumericBox.Size = New System.Drawing.Size(181, 20)
        Me.WrenchesNumericBox.TabIndex = 13
        '
        'label6
        '
        Me.label6.AutoSize = true
        Me.label6.Location = New System.Drawing.Point(13, 80)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(51, 13)
        Me.label6.TabIndex = 12
        Me.label6.Text = "Hammers"
        '
        'label5
        '
        Me.label5.AutoSize = true
        Me.label5.Location = New System.Drawing.Point(27, 136)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(35, 13)
        Me.label5.TabIndex = 10
        Me.label5.Text = "Pliers:"
        '
        'label4
        '
        Me.label4.AutoSize = true
        Me.label4.Location = New System.Drawing.Point(18, 108)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(49, 13)
        Me.label4.TabIndex = 8
        Me.label4.Text = "Sockets:"
        '
        'label3
        '
        Me.label3.AutoSize = true
        Me.label3.Location = New System.Drawing.Point(13, 52)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(53, 13)
        Me.label3.TabIndex = 6
        Me.label3.Text = "Ratchets:"
        '
        'label2
        '
        Me.label2.AutoSize = true
        Me.label2.Location = New System.Drawing.Point(6, 24)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(59, 13)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Wrenches:"
        '
        'UnitNameTextBox
        '
        Me.UnitNameTextBox.Location = New System.Drawing.Point(83, 11)
        Me.UnitNameTextBox.Name = "UnitNameTextBox"
        Me.UnitNameTextBox.Size = New System.Drawing.Size(189, 20)
        Me.UnitNameTextBox.TabIndex = 6
        '
        'label1
        '
        Me.label1.AutoSize = true
        Me.label1.Location = New System.Drawing.Point(12, 14)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(60, 13)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Unit Name:"
        '
        'MRN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 248)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.GenerateButton)
        Me.Controls.Add(Me.RequiredToolsGroupBox)
        Me.Controls.Add(Me.UnitNameTextBox)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "MRN"
        Me.Text = "MRN"
        Me.RequiredToolsGroupBox.ResumeLayout(false)
        Me.RequiredToolsGroupBox.PerformLayout
        CType(Me.PliersNumericBox,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SocketsNumericBox,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.HammersNumericBox,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RatchetsNumericBox,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.WrenchesNumericBox,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Private WithEvents ResetButton As Button
    Private WithEvents GenerateButton As Button
    Private WithEvents RequiredToolsGroupBox As GroupBox
    Private WithEvents PliersNumericBox As NumericUpDown
    Private WithEvents SocketsNumericBox As NumericUpDown
    Private WithEvents HammersNumericBox As NumericUpDown
    Private WithEvents RatchetsNumericBox As NumericUpDown
    Private WithEvents WrenchesNumericBox As NumericUpDown
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents UnitNameTextBox As TextBox
    Private WithEvents label1 As Label
End Class
