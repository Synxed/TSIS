Imports System.Text

Public Class Report
    Private Shared _writer As New StringBuilder()

    Public Shared Property Writer As String
        Get
            Return _writer.ToString()
        End Get
        Set
            _writer.AppendLine(value)
        End Set
    End Property
End Class