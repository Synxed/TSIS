Public Class CurrentStock
    Private Sub StockChecker_Tick(sender As Object, e As EventArgs) Handles StockChecker.Tick

        Dim currentStock = Stock.GetCurrentStock()
        WrenchesLabel.Text = currentStock(0).ToString()
        RatchetsLabel.Text = currentStock(1).ToString()
        HammersLabel.Text = currentStock(2).ToString()
        SocketsLabel.Text = currentStock(3).ToString()
        PliersLabel.Text = currentStock(4).ToString()
    End Sub
End Class