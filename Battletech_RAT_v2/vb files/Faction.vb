Public Class Faction

    Public techList As New LinkedList(Of Tech)

    Property Name As String

    Public Sub New(ByVal value As String)

        Name = value
    End Sub
End Class
