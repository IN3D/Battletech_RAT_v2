Public Class Pilot

    Property Name As String
    Property PilotSkill As Integer
    Property GunnerySkill As Integer

    Public Sub New(ByVal name As String, ByVal piloting As Integer, ByVal gunnery As Integer)

        Me.Name = name
        Me.PilotSkill = piloting
        Me.GunnerySkill = gunnery
    End Sub
End Class
