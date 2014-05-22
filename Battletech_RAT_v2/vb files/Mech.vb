﻿Public Class Mech

    Protected pilot As Pilot
    Property Name As String

    Public Sub New(ByVal value As String)

        Name = value
    End Sub

    Public Sub addPilot(ByRef pilotPassed As Pilot)

        Me.pilot.Name = pilotPassed.Name
        Me.pilot.GunnerySkill = pilotPassed.GunnerySkill
        Me.pilot.PilotSkill = pilotPassed.PilotSkill
    End Sub

    Public Sub RemovePilot()

        ' There's no way to set a value to null in vb, so
        ' I just made the pilot skills really terrible
        Me.pilot.Name = ""
        Me.pilot.GunnerySkill = 8
        Me.pilot.PilotSkill = 9
    End Sub

    Public Overrides Function ToString() As String

        ' ensure that pilot contains something
        If (pilot.Name = "") Then

            Return Name
        Else

            Return Name & ": " & pilot.Name & " (" & pilot.GunnerySkill & "/" & pilot.PilotSkill & ")"
        End If
    End Function
End Class
