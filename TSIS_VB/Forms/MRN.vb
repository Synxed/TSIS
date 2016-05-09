Imports System.Data.OleDb

Public Partial Class MRN

    Private Sub GenerateButton_Click(sender As Object, e As EventArgs) Handles GenerateButton.Click
        If UnitNameTextBox.Text = String.Empty Then
            MessageBox.Show("Please enter a valid Unit Name.", "Invalid Unit Name", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return
        End If

        Try
            Using connection As New OleDbConnection(My.Settings.ConnectionString)
                connection.Open()
                Dim command = "INSERT INTO MRN (UnitName, RequestDate, Wrenches, Ratchets, Hammers, Sockets, Pliers, Processed)" + "Values (@UnitName, @RequestDate, @Wrenches, @Ratchets, @Hammers, @Sockets, @Pliers, @Processed)"

                Using newMRNCommand = New OleDbCommand(command, connection)
                    newMRNCommand.Parameters.AddWithValue("@UnitName", UnitNameTextBox.Text)
                    newMRNCommand.Parameters.AddWithValue("@RequestDate", DateTime.Today.ToString("G"))
                    newMRNCommand.Parameters.AddWithValue("@Wrenches", WrenchesNumericBox.Value)
                    newMRNCommand.Parameters.AddWithValue("@Ratchets", RatchetsNumericBox.Value)
                    newMRNCommand.Parameters.AddWithValue("@Hammers", HammersNumericBox.Value)
                    newMRNCommand.Parameters.AddWithValue("@Sockets", SocketsNumericBox.Value)
                    newMRNCommand.Parameters.AddWithValue("@Pliers", PliersNumericBox.Value)
                    newMRNCommand.Parameters.AddWithValue("@Processed", False)

                    newMRNCommand.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("The MRN has been successfully generated and added to the database.", "MRN Generation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Report.Writer = "{DateTime.Now.ToShortTimeString()}: (MRN Generated) " + "{UnitNameTextBox.Text} | {DateTime.Today.ToString("
        Catch exception As Exception
            MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        UnitNameTextBox.Clear()
        For Each numericBox As Object In RequiredToolsGroupBox.Controls.OfType(Of NumericUpDown)()
            numericBox.Value = numericBox.Minimum
        Next
    End Sub
End Class