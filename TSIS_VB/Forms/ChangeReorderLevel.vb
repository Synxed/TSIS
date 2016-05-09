Public Partial Class ChangeReorderLevel

    Private Sub ChangeReorderLevel_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        WrenchesNumericBox.Value = My.Settings.WrenchsReorderLevel
        RatchetsNumericBox.Value = My.Settings.RatchetsReorderLevel
        HammersNumericBox.Value = My.Settings.HammersReorderLevel
        SocketsNumericBox.Value = My.Settings.SocketsReorderLevel
        PliersNumericBoxP.Value = My.Settings.PliersReorderLevel
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As System.EventArgs) Handles UpdateButton.Click
        My.Settings.WrenchsReorderLevel = CType(WrenchesNumericBox.Value, Integer)
        My.Settings.RatchetsReorderLevel = CType(RatchetsNumericBox.Value, Integer)
        My.Settings.HammersReorderLevel = CType(HammersNumericBox.Value, Integer)
        My.Settings.SocketsReorderLevel = CType(SocketsNumericBox.Value, Integer)
        My.Settings.PliersReorderLevel = CType(PliersNumericBoxP.Value, Integer)

        My.Settings.Save()
    End Sub

    Private Sub DefaultButton_Click(sender As Object, e As System.EventArgs) Handles DefaultButton.Click
        WrenchesNumericBox.Value = 5000
        RatchetsNumericBox.Value = 5000
        HammersNumericBox.Value = 5000
        SocketsNumericBox.Value = 25000
        PliersNumericBoxP.Value = 5000

        UpdateButton_Click(sender, e)
    End Sub
End Class