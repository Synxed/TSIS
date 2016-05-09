<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateStocks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateStocks))
        Me.ManualRestockGroupBox = New System.Windows.Forms.GroupBox()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.RestockButton = New System.Windows.Forms.Button()
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
        Me.ReorderGroupBox = New System.Windows.Forms.GroupBox()
        Me.ProcessAllButton = New System.Windows.Forms.Button()
        Me.ProcessButton = New System.Windows.Forms.Button()
        Me.ReorderComboBox = New System.Windows.Forms.ComboBox()
        Me.ManualRestockGroupBox.SuspendLayout
        CType(Me.PliersNumericBox,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SocketsNumericBox,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.HammersNumericBox,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RatchetsNumericBox,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.WrenchesNumericBox,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ReorderGroupBox.SuspendLayout
        Me.SuspendLayout
        '
        'ManualRestockGroupBox
        '
        Me.ManualRestockGroupBox.Controls.Add(Me.ResetButton)
        Me.ManualRestockGroupBox.Controls.Add(Me.RestockButton)
        Me.ManualRestockGroupBox.Controls.Add(Me.PliersNumericBox)
        Me.ManualRestockGroupBox.Controls.Add(Me.SocketsNumericBox)
        Me.ManualRestockGroupBox.Controls.Add(Me.HammersNumericBox)
        Me.ManualRestockGroupBox.Controls.Add(Me.RatchetsNumericBox)
        Me.ManualRestockGroupBox.Controls.Add(Me.WrenchesNumericBox)
        Me.ManualRestockGroupBox.Controls.Add(Me.label6)
        Me.ManualRestockGroupBox.Controls.Add(Me.label5)
        Me.ManualRestockGroupBox.Controls.Add(Me.label4)
        Me.ManualRestockGroupBox.Controls.Add(Me.label3)
        Me.ManualRestockGroupBox.Controls.Add(Me.label2)
        Me.ManualRestockGroupBox.Location = New System.Drawing.Point(12, 93)
        Me.ManualRestockGroupBox.Name = "ManualRestockGroupBox"
        Me.ManualRestockGroupBox.Size = New System.Drawing.Size(260, 191)
        Me.ManualRestockGroupBox.TabIndex = 5
        Me.ManualRestockGroupBox.TabStop = false
        Me.ManualRestockGroupBox.Text = "Manual Restock"
        '
        'ResetButton
        '
        Me.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ResetButton.Location = New System.Drawing.Point(179, 162)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(75, 23)
        Me.ResetButton.TabIndex = 19
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = true
        '
        'RestockButton
        '
        Me.RestockButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RestockButton.Location = New System.Drawing.Point(6, 162)
        Me.RestockButton.Name = "RestockButton"
        Me.RestockButton.Size = New System.Drawing.Size(75, 23)
        Me.RestockButton.TabIndex = 18
        Me.RestockButton.Text = "Restock"
        Me.RestockButton.UseVisualStyleBackColor = true
        '
        'PliersNumericBox
        '
        Me.PliersNumericBox.Location = New System.Drawing.Point(73, 134)
        Me.PliersNumericBox.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.PliersNumericBox.Name = "PliersNumericBox"
        Me.PliersNumericBox.Size = New System.Drawing.Size(181, 22)
        Me.PliersNumericBox.TabIndex = 17
        '
        'SocketsNumericBox
        '
        Me.SocketsNumericBox.Location = New System.Drawing.Point(73, 106)
        Me.SocketsNumericBox.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.SocketsNumericBox.Name = "SocketsNumericBox"
        Me.SocketsNumericBox.Size = New System.Drawing.Size(181, 22)
        Me.SocketsNumericBox.TabIndex = 16
        '
        'HammersNumericBox
        '
        Me.HammersNumericBox.Location = New System.Drawing.Point(73, 78)
        Me.HammersNumericBox.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.HammersNumericBox.Name = "HammersNumericBox"
        Me.HammersNumericBox.Size = New System.Drawing.Size(181, 22)
        Me.HammersNumericBox.TabIndex = 15
        '
        'RatchetsNumericBox
        '
        Me.RatchetsNumericBox.Location = New System.Drawing.Point(73, 50)
        Me.RatchetsNumericBox.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.RatchetsNumericBox.Name = "RatchetsNumericBox"
        Me.RatchetsNumericBox.Size = New System.Drawing.Size(181, 22)
        Me.RatchetsNumericBox.TabIndex = 14
        '
        'WrenchesNumericBox
        '
        Me.WrenchesNumericBox.Location = New System.Drawing.Point(73, 22)
        Me.WrenchesNumericBox.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.WrenchesNumericBox.Name = "WrenchesNumericBox"
        Me.WrenchesNumericBox.Size = New System.Drawing.Size(181, 22)
        Me.WrenchesNumericBox.TabIndex = 13
        '
        'label6
        '
        Me.label6.AutoSize = true
        Me.label6.Location = New System.Drawing.Point(13, 80)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(54, 13)
        Me.label6.TabIndex = 12
        Me.label6.Text = "Hammers"
        '
        'label5
        '
        Me.label5.AutoSize = true
        Me.label5.Location = New System.Drawing.Point(27, 136)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(37, 13)
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
        Me.label3.Size = New System.Drawing.Size(54, 13)
        Me.label3.TabIndex = 6
        Me.label3.Text = "Ratchets:"
        '
        'label2
        '
        Me.label2.AutoSize = true
        Me.label2.Location = New System.Drawing.Point(6, 24)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(61, 13)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Wrenches:"
        '
        'ReorderGroupBox
        '
        Me.ReorderGroupBox.Controls.Add(Me.ProcessAllButton)
        Me.ReorderGroupBox.Controls.Add(Me.ProcessButton)
        Me.ReorderGroupBox.Controls.Add(Me.ReorderComboBox)
        Me.ReorderGroupBox.Location = New System.Drawing.Point(12, 9)
        Me.ReorderGroupBox.Name = "ReorderGroupBox"
        Me.ReorderGroupBox.Size = New System.Drawing.Size(260, 78)
        Me.ReorderGroupBox.TabIndex = 4
        Me.ReorderGroupBox.TabStop = false
        Me.ReorderGroupBox.Text = "Reorders"
        '
        'ProcessAllButton
        '
        Me.ProcessAllButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProcessAllButton.Location = New System.Drawing.Point(179, 48)
        Me.ProcessAllButton.Name = "ProcessAllButton"
        Me.ProcessAllButton.Size = New System.Drawing.Size(75, 23)
        Me.ProcessAllButton.TabIndex = 2
        Me.ProcessAllButton.Text = "Process All"
        Me.ProcessAllButton.UseVisualStyleBackColor = true
        '
        'ProcessButton
        '
        Me.ProcessButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProcessButton.Location = New System.Drawing.Point(6, 48)
        Me.ProcessButton.Name = "ProcessButton"
        Me.ProcessButton.Size = New System.Drawing.Size(75, 23)
        Me.ProcessButton.TabIndex = 1
        Me.ProcessButton.Text = "Process"
        Me.ProcessButton.UseVisualStyleBackColor = true
        '
        'ReorderComboBox
        '
        Me.ReorderComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReorderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ReorderComboBox.FormattingEnabled = true
        Me.ReorderComboBox.Location = New System.Drawing.Point(7, 21)
        Me.ReorderComboBox.Name = "ReorderComboBox"
        Me.ReorderComboBox.Size = New System.Drawing.Size(247, 21)
        Me.ReorderComboBox.TabIndex = 0
        '
        'UpdateStocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 293)
        Me.Controls.Add(Me.ManualRestockGroupBox)
        Me.Controls.Add(Me.ReorderGroupBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "UpdateStocks"
        Me.Text = "Update Stock"
        Me.ManualRestockGroupBox.ResumeLayout(false)
        Me.ManualRestockGroupBox.PerformLayout
        CType(Me.PliersNumericBox,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SocketsNumericBox,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.HammersNumericBox,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RatchetsNumericBox,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.WrenchesNumericBox,System.ComponentModel.ISupportInitialize).EndInit
        Me.ReorderGroupBox.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Private WithEvents ManualRestockGroupBox As GroupBox
    Private WithEvents ResetButton As Button
    Private WithEvents RestockButton As Button
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
    Private WithEvents ReorderGroupBox As GroupBox
    Private WithEvents ProcessAllButton As Button
    Private WithEvents ProcessButton As Button
    Private WithEvents ReorderComboBox As ComboBox
End Class
