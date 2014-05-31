Public Class Mech

    Protected pilot As New Pilot(Nothing, Nothing, Nothing)
    Property Name As String

    Public Sub New(ByVal value As String)

        Name = value
    End Sub

    Public Sub New(ByVal mech As Mech)

        Me.Name = mech.Name

        If (mech.pilot.Name <> Nothing) Then

            Me.pilot.Name = mech.pilot.Name
            Me.pilot.GunnerySkill = mech.pilot.GunnerySkill
            Me.pilot.PilotSkill = mech.pilot.PilotSkill
        End If
    End Sub

    Public Sub addPilot(ByRef pilotPassed As Pilot)

        Me.pilot.Name = pilotPassed.Name
        Me.pilot.GunnerySkill = pilotPassed.GunnerySkill
        Me.pilot.PilotSkill = pilotPassed.PilotSkill
    End Sub

    Public Sub RemovePilot()

        ' There's no way to set a value to null in vb, so
        ' I just made the pilot skills really terrible
        ' EDIT: maybe nothing works?
        Me.pilot.Name = ""
        Me.pilot.GunnerySkill = Nothing
        Me.pilot.PilotSkill = Nothing
    End Sub

    Public Overrides Function ToString() As String

        ' ensure that pilot contains something
        If (Me.pilot.Name = Nothing) Then

            Return Name
        Else

            Return Name & ": " & pilot.Name & " (" & pilot.GunnerySkill.ToString & "/" & pilot.PilotSkill.ToString & ")"
        End If
    End Function
End Class
