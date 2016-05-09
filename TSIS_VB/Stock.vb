Imports System.Data.OleDb

Class Stock
    Public Shared Sub Restock(wrenches As Integer, ratchets As Integer, hammers As Integer, sockets As Integer, pliers As Integer)
        AddToStock(wrenches, ratchets, hammers, sockets, pliers)
    End Sub

    Public Shared Sub Update(wrenches As Integer, ratchets As Integer, hammers As Integer, sockets As Integer, pliers As Integer)
        UpdateStock(wrenches, ratchets, hammers, sockets, pliers)
    End Sub

    Public Shared Sub Reorder()
        Dim currentStock As Object = GetCurrentStock()
        Dim toolsToRestock As New List(Of Integer)() From { _
                0, _
                0, _
                0, _
                0, _
                0 _
                }

        If currentStock(0) < My.Settings.WrenchsReorderLevel Then
            toolsToRestock(0) = 5000
        End If
        If currentStock(1) < My.Settings.RatchetsReorderLevel Then
            toolsToRestock(1) = 5000
        End If
        If currentStock(2) < My.Settings.HammersReorderLevel Then
            toolsToRestock(2) = 5000
        End If
        If currentStock(3) < My.Settings.SocketsReorderLevel Then
            toolsToRestock(3) = 25000
        End If
        If currentStock(4) < My.Settings.PliersReorderLevel Then
            toolsToRestock(4) = 5000
        End If

        If Not toolsToRestock.Any(Function(tool) tool > 0) Then
            Return
        End If

        Using connection As New OleDbConnection(My.Settings.ConnectionString)
            connection.Open()
            Dim command As Object = "INSERT INTO Reorders (ReorderTime, Wrenches, Ratchets, Hammers, Sockets, Pliers, Processed)" + "Values (@ReorderTime, @Wrenches, @Ratchets, @Hammers, @Sockets, @Pliers, @Processed)"

            Using addQueryCommand As New OleDbCommand(command, connection)
                addQueryCommand.Parameters.AddWithValue("@RequestDate", DateTime.Today.ToString("G"))
                addQueryCommand.Parameters.AddWithValue("@Wrenches", toolsToRestock(0))
                addQueryCommand.Parameters.AddWithValue("@Ratchets", toolsToRestock(1))
                addQueryCommand.Parameters.AddWithValue("@Hammers", toolsToRestock(2))
                addQueryCommand.Parameters.AddWithValue("@Sockets", toolsToRestock(3))
                addQueryCommand.Parameters.AddWithValue("@Pliers", toolsToRestock(4))
                addQueryCommand.Parameters.AddWithValue("@Processed", False)

                addQueryCommand.ExecuteNonQuery()
            End Using
        End Using

        Report.Writer = "{DateTime.Now.ToShortTimeString()}: (Reorder Request Created) " + "{toolsToRestock[0]} Wrenches, {toolsToRestock[1]} Ratchets, " + "{toolsToRestock[2]} Hammers, {toolsToRestock[3]} Sockets, " + "{toolsToRestock[4]} Pliers"
    End Sub

    Public Shared Sub UpdateReorderLevel(wrenches As Integer, ratchets As Integer, hammers As Integer, sockets As Integer, pliers As Integer)
        My.Settings.WrenchsReorderLevel = wrenches
        My.Settings.RatchetsReorderLevel = ratchets
        My.Settings.HammersReorderLevel = hammers
        My.Settings.SocketsReorderLevel = sockets
        My.Settings.PliersReorderLevel = pliers
        My.Settings.Save()
    End Sub

    Public Shared Function GetCurrentStock() As List(Of Integer)
        Dim stockQuantities As New List(Of Integer)()

        Using connection As New OleDbConnection(My.Settings.ConnectionString)
            connection.Open()
            Using fetchData As New OleDbCommand("SELECT * FROM Stock", connection)
                Using reader As Object = fetchData.ExecuteReader()
                    While reader IsNot Nothing AndAlso reader.Read()
                        stockQuantities.Add(Integer.Parse(reader("Wrenches").ToString()))
                        stockQuantities.Add(Integer.Parse(reader("Ratchets").ToString()))
                        stockQuantities.Add(Integer.Parse(reader("Hammers").ToString()))
                        stockQuantities.Add(Integer.Parse(reader("Sockets").ToString()))
                        stockQuantities.Add(Integer.Parse(reader("Pliers").ToString()))
                    End While
                End Using
            End Using
        End Using

        Return stockQuantities
    End Function

    Private Shared Sub AddToStock(Optional wrenches As Integer = 0, Optional ratchets As Integer = 0, Optional hammers As Integer = 0, Optional sockets As Integer = 0, Optional pliers As Integer = 0)
        Dim currentStock As Object = GetCurrentStock()
        Dim connectionString As Object = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""Database.accdb"""

        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Dim command As Object = "UPDATE Stock SET Wrenches=?, Ratchets=?, Hammers=?, Sockets=?, Pliers=?"
            Using updateStock As New OleDbCommand(command, connection)
                updateStock.Parameters.Add("@wrenches", OleDbType.VarChar).Value = currentStock(0) + wrenches
                updateStock.Parameters.Add("@ratchets", OleDbType.VarChar).Value = currentStock(1) + ratchets
                updateStock.Parameters.Add("@hammers", OleDbType.VarChar).Value = currentStock(2) + hammers
                updateStock.Parameters.Add("@sockets", OleDbType.VarChar).Value = currentStock(3) + sockets
                updateStock.Parameters.Add("@pliers", OleDbType.VarChar).Value = currentStock(4) + pliers

                updateStock.ExecuteNonQuery()
            End Using
        End Using

        Report.Writer = "{DateTime.Now.ToShortTimeString()}: (Restock) " + "{wrenches} Wrenches, {ratchets} Ratchets, {hammers} Hammers," + "{sockets} Sockets, {pliers} Pliers"
    End Sub

    Private Shared Sub UpdateStock(wrenches As Integer, ratchets As Integer, hammers As Integer, sockets As Integer, pliers As Integer)
        Using connection As New OleDbConnection(My.Settings.ConnectionString)
            connection.Open()

            Dim command As Object = "UPDATE Stock SET Wrenches=?, Ratchets=?, Hammers=?, Sockets=?, Pliers=?"
            Using updateStock As New OleDbCommand(command, connection)
                updateStock.Parameters.Add("@wrenches", OleDbType.VarChar).Value = wrenches
                updateStock.Parameters.Add("@ratchets", OleDbType.VarChar).Value = ratchets
                updateStock.Parameters.Add("@hammers", OleDbType.VarChar).Value = hammers
                updateStock.Parameters.Add("@sockets", OleDbType.VarChar).Value = sockets
                updateStock.Parameters.Add("@pliers", OleDbType.VarChar).Value = pliers

                updateStock.ExecuteNonQuery()
            End Using
        End Using

        Report.Writer = "{DateTime.Now.ToShortTimeString()}: (Stock Updated) " + "{wrenches} Wrenches, {ratchets} Ratchets, {hammers} Hammers," + "{sockets} Sockets, {pliers} Pliers"
    End Sub
End Class