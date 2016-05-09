Imports System.Data.OleDb
Imports System.Text

Public Partial Class UpdateStocks

    Private Sub UpdateStocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Using connection = New OleDbConnection(My.Settings.ConnectionString)
                connection.Open()
                Using fetchMRNCommand = New OleDbCommand("SELECT * FROM Reorders WHERE Processed = 0", connection)
                    Using reader = fetchMRNCommand.ExecuteReader()
                        While reader IsNot Nothing AndAlso reader.Read()
                            Dim item = New StringBuilder()
                            item.Append(reader("ReorderTime") + " - ")
                            If Integer.Parse(reader("Wrenches").ToString()) > 0 Then
                                item.Append("W{reader[")
                            End If
                            If Integer.Parse(reader("Ratchets").ToString()) > 0 Then
                                item.Append("R{reader[")
                            End If
                            If Integer.Parse(reader("Hammers").ToString()) > 0 Then
                                item.Append("H{reader[")
                            End If
                            If Integer.Parse(reader("Sockets").ToString()) > 0 Then
                                item.Append("S{reader[")
                            End If
                            If Integer.Parse(reader("Pliers").ToString()) > 0 Then
                                item.Append("P{reader[")
                            End If

                            ReorderComboBox.Items.Add(item.ToString().Trim())
                        End While
                    End Using
                End Using

                CheckReorderAvailability()
                ReorderComboBox.SelectedIndex = 0
            End Using
        Catch exception As Exception
            MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub ProcessButton_Click(sender As Object, e As EventArgs) Handles ProcessButton.Click
        If ProcessReorder(ReorderComboBox.SelectedItem.ToString().Split("-"C)(0).Trim()) Then
            ReorderComboBox.Items.RemoveAt(ReorderComboBox.SelectedIndex)
            If CheckReorderAvailability() Then
                ReorderComboBox.SelectedIndex = 0
            End If

            MessageBox.Show("The Reorder has been successfully processed!", "Reorder Processed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ProcessAllButton_Click(sender As Object, e As EventArgs) Handles ProcessAllButton.Click
        If ReorderComboBox.Items.Cast(Of String)().Any(Function(reorder) Not ProcessReorder(reorder.Split("-"C)(0).Trim())) Then
            Return
        End If

        ReorderComboBox.Items.Clear()
        CheckReorderAvailability()

        MessageBox.Show("All reorders have been successfully processed.", "Reorders Processed", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub RestockButton_Click(sender As Object, e As EventArgs) Handles RestockButton.Click
        Try
            Stock.Restock(CType(WrenchesNumericBox.Value, Integer), CType(RatchetsNumericBox.Value, Integer), CType(HammersNumericBox.Value, Integer), CType(SocketsNumericBox.Value, Integer), CType(PliersNumericBox.Value, Integer))

            MessageBox.Show("Successfully Restocked!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch exception As Exception
            MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        For Each numericBox As Object In ManualRestockGroupBox.Controls.OfType(Of NumericUpDown)()
            numericBox.Value = numericBox.Minimum
        Next
    End Sub

    Private Function ProcessReorder(time As String) As Boolean
        Try
            Using connection = New OleDbConnection(My.Settings.ConnectionString)
                connection.Open()
                Using fetchReorderData = New OleDbCommand("SELECT * FROM Reorders WHERE ReorderTime = '{time}'", connection)
                    Using reader = fetchReorderData.ExecuteReader()
                        If reader Is Nothing Then
                            Return False
                        End If
                        reader.Read()

                        Stock.Restock(Integer.Parse(reader("Wrenches").ToString()), Integer.Parse(reader("Ratchets").ToString()), Integer.Parse(reader("Hammers").ToString()), Integer.Parse(reader("Sockets").ToString()), Integer.Parse(reader("Pliers").ToString()))
                    End Using
                End Using

                Using processRowCommand = New OleDbCommand("UPDATE Reorders SET Processed = @processed WHERE ReorderTime = @time", connection)
                    processRowCommand.Parameters.AddWithValue("@processed", True)
                    processRowCommand.Parameters.AddWithValue("@time", time)

                    processRowCommand.ExecuteNonQuery()
                End Using
            End Using

            Return True
        Catch exception As Exception
            MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])

            Return False
        End Try
    End Function

    Private Function CheckReorderAvailability() As Boolean
        If ReorderComboBox.Items.Count <> 0 Then
            Return True
        End If

        ReorderComboBox.Items.Add("No Unprocessed Reorder Avalaible")
        ReorderComboBox.SelectedIndex = 0
        ReorderGroupBox.Enabled = False
        Return False
    End Function
End Class