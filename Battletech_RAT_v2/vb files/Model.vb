' A Module to track persistent as defined by the user.
' Created on 6/4/14 by Eric Hopkins
Public Module Model

    Public Style As Integer = 0
    Public selectedMech As Integer = 0
    Public selectedUnit As Integer = 0

    Public OverallUnitName As String = "My Unit"

    ' Weight is used here because it holds a mech list
    Public rootUnitList As New LinkedList(Of Weight)
End Module
