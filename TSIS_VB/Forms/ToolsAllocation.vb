Imports System.Data.OleDb
Imports System.IO
Imports System.Text

Public Partial Class ToolsAllocation

    Private Sub ToolsAllocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Using connection = New OleDbConnection(My.Settings.ConnectionString)
                connection.Open()
                Using fetchMRNCommand = New OleDbCommand("SELECT * FROM MRN WHERE Processed = 0", connection)
                    Using reader = fetchMRNCommand.ExecuteReader()
                        While reader IsNot Nothing AndAlso reader.Read()
                            MRNComboBox.Items.Add("{reader[")
                        End While
                    End Using
                End Using

                CheckMRNAvailability()
                MRNComboBox.SelectedIndex = 0
            End Using
        Catch exception As Exception
            MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub


    Private Sub AllocateButton_Click(sender As Object, e As EventArgs) Handles AllocateButton.Click
        Try
            Dim unitName = MRNComboBox.SelectedItem.ToString().Split("-"C)(0).Trim()
            Dim requestDate = MRNComboBox.SelectedItem.ToString().Split("-"C)(1).Trim()
            Dim requiredToolsQuantities = New List(Of Integer)()

            Using connection = New OleDbConnection(My.Settings.ConnectionString)
                connection.Open()
                Using fetchData = New OleDbCommand("SELECT * FROM MRN", connection)
                    Using reader = fetchData.ExecuteReader()
                        While reader IsNot Nothing AndAlso reader.Read()
                            If reader("UnitName").ToString() = unitName AndAlso reader("RequestDate").ToString() = requestDate AndAlso Boolean.Parse(reader("Processed").ToString()) = False Then
                                requiredToolsQuantities.Add(Integer.Parse(reader("Wrenches").ToString()))
                                requiredToolsQuantities.Add(Integer.Parse(reader("Ratchets").ToString()))
                                requiredToolsQuantities.Add(Integer.Parse(reader("Hammers").ToString()))
                                requiredToolsQuantities.Add(Integer.Parse(reader("Sockets").ToString()))
                                requiredToolsQuantities.Add(Integer.Parse(reader("Pliers").ToString()))
                            End If
                        End While
                    End Using
                End Using

                CreateReport(Stock.GetCurrentStock(), requiredToolsQuantities, unitName, requestDate)
            End Using

            CheckMRNAvailability()
        Catch exception As Exception
            MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub ReportTextBox_DoubleClick(sender As Object, e As EventArgs) Handles ReportTextBox.DoubleClick
        Using saveFileDialog = New SaveFileDialog()
            saveFileDialog.Filter = "Text File (*.txt)|*.txt"
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                File.WriteAllText(saveFileDialog.FileName, ReportTextBox.Text)
                MessageBox.Show("Report successfully exported to " + saveFileDialog.FileName, "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub

    Private Sub CreateReport(stock1 As List(Of Integer), required As List(Of Integer), unitName As String, requestDate As String)
        Dim reportWriter = New StringBuilder()

        reportWriter.AppendLine("Material Request Note (MRN) Report")
        reportWriter.AppendLine(New String("="C, "Material Request Note (MRN) Report".Length) + Environment.NewLine)
        reportWriter.AppendLine("Requested By: " + unitName)
        reportWriter.AppendLine("Requested On: " + requestDate + Environment.NewLine)

        reportWriter.AppendLine("Required Tools:")
        reportWriter.AppendLine(New String("-"C, "Required Tools:".Length) + Environment.NewLine)
        reportWriter.AppendLine("Wrenches: " + required(0))
        reportWriter.AppendLine("Ratchets: " + required(1))
        reportWriter.AppendLine("Hammers: " + required(2))
        reportWriter.AppendLine("Sockets: " + required(3))
        reportWriter.AppendLine("Pliers: " + required(4) + Environment.NewLine)

        reportWriter.AppendLine("Avalaible in Stock:")
        reportWriter.AppendLine(New String("-"C, "Avalaible in Stock:".Length) + Environment.NewLine)
        reportWriter.AppendLine("Wrenches: " + stock1(0))
        reportWriter.AppendLine("Ratchets: " + stock1(1))
        reportWriter.AppendLine("Hammers: " + stock1(2))
        reportWriter.AppendLine("Sockets: " + stock1(3))
        reportWriter.AppendLine("Pliers: " + stock1(4) + Environment.NewLine)

        If IsSufficient(stock1, required) Then
            reportWriter.AppendLine("The request cannot be processed due to the following insufficient tools:" + Environment.NewLine)
            If required(0) > stock1(0) Then
                reportWriter.AppendLine("Wrenches: {required[0] - stock[0]} Lacking")
            End If
            If required(1) > stock1(1) Then
                reportWriter.AppendLine("Ratchets: {required[1] - stock[1]} Lacking")
            End If
            If required(2) > stock1(2) Then
                reportWriter.AppendLine("Hammers: {required[2] - stock[2]} Lacking")
            End If
            If required(3) > stock1(3) Then
                reportWriter.AppendLine("Sockets: {required[3] - stock[3]} Lacking")
            End If
            If required(4) > stock1(4) Then
                reportWriter.AppendLine("Pliers: {required[4] - stock[4]} Lacking")
            End If
        Else
            reportWriter.AppendLine("The request has been processed!" + Environment.NewLine)
            Dim difference As List(Of Integer) = GetDifference(stock1, required)
            Stock.Update(difference(0), difference(1), difference(2), difference(3), difference(4))
            stock1 = Stock.GetCurrentStock()

            reportWriter.AppendLine("Current Stock:")
            reportWriter.AppendLine(New String("-"C, "Avalaible in Stock:".Length) + Environment.NewLine)
            reportWriter.AppendLine("Wrenches: " + stock1(0))
            reportWriter.AppendLine("Ratchets: " + stock1(1))
            reportWriter.AppendLine("Hammers: " + stock1(2))
            reportWriter.AppendLine("Sockets: " + stock1(3))
            reportWriter.AppendLine("Pliers: " + stock1(4) + Environment.NewLine)

            RemoveProcessedMRN(unitName, requestDate)
            If CheckMRNAvailability() Then
                MRNComboBox.SelectedIndex = 0
            End If
            Stock.Reorder()
        End If

        ReportTextBox.Text = reportWriter.ToString()
    End Sub

    Private Shared Function IsSufficient(stock As List(Of Integer), required As List(Of Integer)) As Boolean
        Return stock.Where(Function(t, index) t < required(index)).Any()
    End Function

    Private Shared Function GetDifference(stock As List(Of Integer), required As List(Of Integer)) As List(Of Integer)
        Return stock.[Select](Function(t, index) t - required(index)).ToList()
    End Function

    Private Sub RemoveProcessedMRN(unitName As String, requestDate As String)
        Using connection = New OleDbConnection(My.Settings.ConnectionString)
            connection.Open()
            Dim command = "UPDATE MRN SET Processed = @processed WHERE UnitName = @name AND RequestDate = @date"
            Using processRowCommand = New OleDbCommand(command, connection)
                processRowCommand.Parameters.AddWithValue("@processed", True)
                processRowCommand.Parameters.AddWithValue("@name", unitName)
                processRowCommand.Parameters.AddWithValue("@date", requestDate)

                processRowCommand.ExecuteNonQuery()
            End Using
        End Using
        MRNComboBox.Items.RemoveAt(MRNComboBox.SelectedIndex)
    End Sub

    Private Function CheckMRNAvailability() As Boolean
        If MRNComboBox.Items.Count <> 0 Then
            Return True
        End If

        MRNComboBox.Items.Add("No Unprocessed MRN Avalaible")
        MRNComboBox.SelectedIndex = 0
        MRNComboBox.Enabled = False
        AllocateButton.Enabled = False
        Return False
    End Function
End Class