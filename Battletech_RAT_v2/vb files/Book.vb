Public Class Book

    Public factionList As New LinkedList(Of Faction)

    Property Name As String

    Public Sub New(ByVal value As String)

        Name = value
    End Sub
End Class
