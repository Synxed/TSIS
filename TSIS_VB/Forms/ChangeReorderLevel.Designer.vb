<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeReorderLevel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangeReorderLevel))
        Me.DefaultButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.PliersNumericBoxP = New System.Windows.Forms.NumericUpDown()
        Me.SocketsNumericBox = New System.Windows.Forms.NumericUpDown()
        Me.HammersNumericBox = New System.Windows.Forms.NumericUpDown()
        Me.RatchetsNumericBox = New System.Windows.Forms.NumericUpDown()
        Me.WrenchesNumericBox = New System.Windows.Forms.NumericUpDown()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        CType(Me.PliersNumericBoxP,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SocketsNumericBox,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.HammersNumericBox,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RatchetsNumericBox,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.WrenchesNumericBox,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'DefaultButton
        '
        Me.DefaultButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DefaultButton.Location = New System.Drawing.Point(182, 150)
        Me.DefaultButton.Name = "DefaultButton"
        Me.DefaultButton.Size = New System.Drawing.Size(75, 23)
        Me.DefaultButton.TabIndex = 41
        Me.DefaultButton.Text = "Default"
        Me.DefaultButton.UseVisualStyleBackColor = true
        '
        'UpdateButton
        '
        Me.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateButton.Location = New System.Drawing.Point(12, 150)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateButton.TabIndex = 40
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = true
        '
        'PliersNumericBoxP
        '
        Me.PliersNumericBoxP.Location = New System.Drawing.Point(76, 122)
        Me.PliersNumericBoxP.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.PliersNumericBoxP.Name = "PliersNumericBoxP"
        Me.PliersNumericBoxP.Size = New System.Drawing.Size(181, 22)
        Me.PliersNumericBoxP.TabIndex = 39
        '
        'SocketsNumericBox
        '
        Me.SocketsNumericBox.Location = New System.Drawing.Point(76, 94)
        Me.SocketsNumericBox.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.SocketsNumericBox.Name = "SocketsNumericBox"
        Me.SocketsNumericBox.Size = New System.Drawing.Size(181, 22)
        Me.SocketsNumericBox.TabIndex = 38
        '
        'HammersNumericBox
        '
        Me.HammersNumericBox.Location = New System.Drawing.Point(76, 66)
        Me.HammersNumericBox.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.HammersNumericBox.Name = "HammersNumericBox"
        Me.HammersNumericBox.Size = New System.Drawing.Size(181, 22)
        Me.HammersNumericBox.TabIndex = 37
        '
        'RatchetsNumericBox
        '
        Me.RatchetsNumericBox.Location = New System.Drawing.Point(76, 38)
        Me.RatchetsNumericBox.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.RatchetsNumericBox.Name = "RatchetsNumericBox"
        Me.RatchetsNumericBox.Size = New System.Drawing.Size(181, 22)
        Me.RatchetsNumericBox.TabIndex = 36
        '
        'WrenchesNumericBox
        '
        Me.WrenchesNumericBox.Location = New System.Drawing.Point(76, 10)
        Me.WrenchesNumericBox.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.WrenchesNumericBox.Name = "WrenchesNumericBox"
        Me.WrenchesNumericBox.Size = New System.Drawing.Size(181, 22)
        Me.WrenchesNumericBox.TabIndex = 35
        '
        'label6
        '
        Me.label6.AutoSize = true
        Me.label6.Location = New System.Drawing.Point(16, 68)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(54, 13)
        Me.label6.TabIndex = 34
        Me.label6.Text = "Hammers"
        '
        'label5
        '
        Me.label5.AutoSize = true
        Me.label5.Location = New System.Drawing.Point(30, 124)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(37, 13)
        Me.label5.TabIndex = 33
        Me.label5.Text = "Pliers:"
        '
        'label4
        '
        Me.label4.AutoSize = true
        Me.label4.Location = New System.Drawing.Point(21, 96)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(49, 13)
        Me.label4.TabIndex = 32
        Me.label4.Text = "Sockets:"
        '
        'label3
        '
        Me.label3.AutoSize = true
        Me.label3.Location = New System.Drawing.Point(16, 40)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(54, 13)
        Me.label3.TabIndex = 31
        Me.label3.Text = "Ratchets:"
        '
        'label2
        '
        Me.label2.AutoSize = true
        Me.label2.Location = New System.Drawing.Point(9, 12)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(61, 13)
        Me.label2.TabIndex = 30
        Me.label2.Text = "Wrenches:"
        '
        'ChangeReorderLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 183)
        Me.Controls.Add(Me.DefaultButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.PliersNumericBoxP)
        Me.Controls.Add(Me.SocketsNumericBox)
        Me.Controls.Add(Me.HammersNumericBox)
        Me.Controls.Add(Me.RatchetsNumericBox)
        Me.Controls.Add(Me.WrenchesNumericBox)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "ChangeReorderLevel"
        Me.Text = "Change Reorder Level"
        CType(Me.PliersNumericBoxP,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SocketsNumericBox,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.HammersNumericBox,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RatchetsNumericBox,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.WrenchesNumericBox,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Private WithEvents DefaultButton As Button
    Private WithEvents UpdateButton As Button
    Private WithEvents PliersNumericBoxP As NumericUpDown
    Private WithEvents SocketsNumericBox As NumericUpDown
    Private WithEvents HammersNumericBox As NumericUpDown
    Private WithEvents RatchetsNumericBox As NumericUpDown
    Private WithEvents WrenchesNumericBox As NumericUpDown
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
End Class
