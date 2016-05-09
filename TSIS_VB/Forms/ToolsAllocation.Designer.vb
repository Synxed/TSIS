<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToolsAllocation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ToolsAllocation))
        Me.ReportTextBox = New System.Windows.Forms.TextBox()
        Me.AllocateButton = New System.Windows.Forms.Button()
        Me.MRNComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout
        '
        'ReportTextBox
        '
        Me.ReportTextBox.Location = New System.Drawing.Point(11, 39)
        Me.ReportTextBox.Multiline = true
        Me.ReportTextBox.Name = "ReportTextBox"
        Me.ReportTextBox.ReadOnly = true
        Me.ReportTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ReportTextBox.Size = New System.Drawing.Size(339, 211)
        Me.ReportTextBox.TabIndex = 5
        Me.ReportTextBox.TabStop = false
        '
        'AllocateButton
        '
        Me.AllocateButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AllocateButton.Location = New System.Drawing.Point(277, 12)
        Me.AllocateButton.Name = "AllocateButton"
        Me.AllocateButton.Size = New System.Drawing.Size(75, 23)
        Me.AllocateButton.TabIndex = 4
        Me.AllocateButton.Text = "Allocate"
        Me.AllocateButton.UseVisualStyleBackColor = true
        '
        'MRNComboBox
        '
        Me.MRNComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MRNComboBox.FormattingEnabled = true
        Me.MRNComboBox.Location = New System.Drawing.Point(11, 12)
        Me.MRNComboBox.Name = "MRNComboBox"
        Me.MRNComboBox.Size = New System.Drawing.Size(260, 21)
        Me.MRNComboBox.TabIndex = 3
        '
        'ToolsAllocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 262)
        Me.Controls.Add(Me.ReportTextBox)
        Me.Controls.Add(Me.AllocateButton)
        Me.Controls.Add(Me.MRNComboBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "ToolsAllocation"
        Me.Text = "Tools Allocation"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Private WithEvents ReportTextBox As TextBox
    Private WithEvents AllocateButton As Button
    Private WithEvents MRNComboBox As ComboBox
End Class
