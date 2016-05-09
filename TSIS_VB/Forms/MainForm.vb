Imports System.IO

Public Partial Class MainForm
    Private _isAdmin As Boolean

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        CredentialGroupBox.Enabled = False

        If UsernameTextBox.Text = "Admin" AndAlso PasswordTextBox.Text = "Password" Then
            OperationsGroupBox.Enabled = True
            _isAdmin = True
        Else
            OperationsGroupBox.Enabled = True
            For Each control As Control In OperationsGroupBox.Controls.Cast(Of Control)()
                If control.Tag.ToString() <> ("User Access") Then
                    control.Enabled = False
                End If
            Next
        End If
    End Sub

    Private Sub OpenButton_Click(sender As Object, e As EventArgs) Handles OpenButton.Click
        Dim selectedOperation = OperationsGroupBox.Controls.OfType(Of RadioButton)().FirstOrDefault(Function(r) r.Checked)
        Select Case selectedOperation.Name
            Case "MRNGeneratorRadioButton"
                MRN.Show()
                Exit Select

            Case "ToolsAllocationRadioButton"
                ToolsAllocation.Show()
                Exit Select

            Case "UpdateStocksRadioButton"
                UpdateStocks.Show()
                Exit Select

            Case "ChangeReorderRadioButton"
                ChangeReorderLevel.Show()
                Exit Select

            Case "CheckStockRadioButton"
                CurrentStock.Show()
                Exit Select
        End Select
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged, PasswordTextBox.TextChanged
        LoginButton.Enabled = Not (UsernameTextBox.Text = String.Empty OrElse PasswordTextBox.Text = String.Empty)
    End Sub

    Private Sub AboutStatusStripLabel_Click(sender As Object, e As EventArgs) Handles AboutStatusStripLabel.Click
        About.Show()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currentStock = Stock.GetCurrentStock()

        Report.Writer = "Report of Tool Stores Inventory System"
        Report.Writer = New String("="C, "Report of Tool Stores Inventory System".Length) + Environment.NewLine
        Report.Writer = "Date: {DateTime.Today.ToString("
        Report.Writer = "Stock: {currentStock[0]} Wrenches, " + "{currentStock[1]} Ratchets, {currentStock[2]} Hammers," + "{currentStock[3]} Sockets, {currentStock[4]} Pliers{Environment.NewLine}"

    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not _isAdmin Then
            Return
        End If

        Dim saveReport = MessageBox.Show("Export session report?", "Session Report", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If saveReport = DialogResult.Yes Then
            Using saveFileDialog = New SaveFileDialog()
                saveFileDialog.Filter = "Text File (*.txt)|*.txt"
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    Dim currentStock = Stock.GetCurrentStock()

                    Report.Writer = "{Environment.NewLine}Final Stock: {currentStock[0]} Wrenches, " + "{currentStock[1]} Ratchets, {currentStock[2]} Hammers," + "{currentStock[3]} Sockets, {currentStock[4]} Pliers"

                    File.WriteAllText(saveFileDialog.FileName, Report.Writer)
                    MessageBox.Show("Report successfully exported to " + saveFileDialog.FileName, "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        End If
    End Sub
End Class