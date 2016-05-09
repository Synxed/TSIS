<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CurrentStock
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CurrentStock))
        Me.HammersLabel = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.PliersLabel = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.SocketsLabel = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.RatchetsLabel = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.WrenchesLabel = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.StockChecker = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout
        '
        'HammersLabel
        '
        Me.HammersLabel.AutoSize = true
        Me.HammersLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.HammersLabel.Location = New System.Drawing.Point(12, 101)
        Me.HammersLabel.Name = "HammersLabel"
        Me.HammersLabel.Size = New System.Drawing.Size(16, 17)
        Me.HammersLabel.TabIndex = 23
        Me.HammersLabel.Text = "0"
        '
        'label10
        '
        Me.label10.AutoSize = true
        Me.label10.Location = New System.Drawing.Point(12, 88)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(57, 13)
        Me.label10.TabIndex = 22
        Me.label10.Text = "Hammers:"
        '
        'PliersLabel
        '
        Me.PliersLabel.AutoSize = true
        Me.PliersLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.PliersLabel.Location = New System.Drawing.Point(114, 62)
        Me.PliersLabel.Name = "PliersLabel"
        Me.PliersLabel.Size = New System.Drawing.Size(16, 17)
        Me.PliersLabel.TabIndex = 21
        Me.PliersLabel.Text = "0"
        '
        'label4
        '
        Me.label4.AutoSize = true
        Me.label4.Location = New System.Drawing.Point(114, 49)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(37, 13)
        Me.label4.TabIndex = 20
        Me.label4.Text = "Pliers:"
        '
        'SocketsLabel
        '
        Me.SocketsLabel.AutoSize = true
        Me.SocketsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.SocketsLabel.Location = New System.Drawing.Point(114, 22)
        Me.SocketsLabel.Name = "SocketsLabel"
        Me.SocketsLabel.Size = New System.Drawing.Size(16, 17)
        Me.SocketsLabel.TabIndex = 19
        Me.SocketsLabel.Text = "0"
        '
        'label8
        '
        Me.label8.AutoSize = true
        Me.label8.Location = New System.Drawing.Point(114, 9)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(49, 13)
        Me.label8.TabIndex = 18
        Me.label8.Text = "Sockets:"
        '
        'RatchetsLabel
        '
        Me.RatchetsLabel.AutoSize = true
        Me.RatchetsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.RatchetsLabel.Location = New System.Drawing.Point(12, 62)
        Me.RatchetsLabel.Name = "RatchetsLabel"
        Me.RatchetsLabel.Size = New System.Drawing.Size(16, 17)
        Me.RatchetsLabel.TabIndex = 17
        Me.RatchetsLabel.Text = "0"
        '
        'label6
        '
        Me.label6.AutoSize = true
        Me.label6.Location = New System.Drawing.Point(12, 49)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(54, 13)
        Me.label6.TabIndex = 16
        Me.label6.Text = "Ratchets:"
        '
        'WrenchesLabel
        '
        Me.WrenchesLabel.AutoSize = true
        Me.WrenchesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.WrenchesLabel.Location = New System.Drawing.Point(12, 22)
        Me.WrenchesLabel.Name = "WrenchesLabel"
        Me.WrenchesLabel.Size = New System.Drawing.Size(16, 17)
        Me.WrenchesLabel.TabIndex = 15
        Me.WrenchesLabel.Text = "0"
        '
        'label1
        '
        Me.label1.AutoSize = true
        Me.label1.Location = New System.Drawing.Point(12, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(61, 13)
        Me.label1.TabIndex = 14
        Me.label1.Text = "Wrenches:"
        '
        'StockChecker
        '
        '
        'CurrentStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(218, 132)
        Me.Controls.Add(Me.HammersLabel)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.PliersLabel)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.SocketsLabel)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.RatchetsLabel)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.WrenchesLabel)
        Me.Controls.Add(Me.label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "CurrentStock"
        Me.Text = "Current Stock"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Private WithEvents HammersLabel As Label
    Private WithEvents label10 As Label
    Private WithEvents PliersLabel As Label
    Private WithEvents label4 As Label
    Private WithEvents SocketsLabel As Label
    Private WithEvents label8 As Label
    Private WithEvents RatchetsLabel As Label
    Private WithEvents label6 As Label
    Private WithEvents WrenchesLabel As Label
    Private WithEvents label1 As Label
    Friend WithEvents StockChecker As Timer
End Class
