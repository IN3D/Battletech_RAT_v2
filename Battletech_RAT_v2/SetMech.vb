Public Class SetMech

    Private Sub SetMech_Load(sender As Object, e As EventArgs) Handles Me.Load

        TextBoxMechName.Text = Model.rootUnitList(Model.selectedUnit) _
            .mechList(Model.selectedMech).Name

        If (Model.rootUnitList(Model.selectedUnit).mechList(Model.selectedUnit) _
            .getPilotName <> Nothing Or Model.rootUnitList(Model.selectedUnit) _
            .mechList(Model.selectedUnit).getPilotName <> "") Then

            TextBoxPilotName.Text = Model.rootUnitList(Model.selectedUnit) _
                .mechList(Model.selectedMech).getPilotName
        End If

        If (Model.rootUnitList(Model.selectedUnit).mechList(Model.selectedUnit) _
            .getPilotGunnery <> Nothing) Then

            TextBoxPilotGunnery.Text = Model.rootUnitList(Model.selectedUnit) _
                .mechList(Model.selectedMech).getPilotGunnery.ToString()
        End If

        If (Model.rootUnitList(Model.selectedUnit).mechList(Model.selectedUnit) _
            .getPilotPiloting <> Nothing) Then

            TextBoxPilotGunnery.Text = Model.rootUnitList(Model.selectedUnit) _
                .mechList(Model.selectedUnit).getPilotPiloting.ToString()
        End If

    End Sub

    Private Sub ButtonSet_Click(sender As Object, e As EventArgs) Handles ButtonSet.Click

        If (TextBoxMechName.Text <> "") Then

            Model.rootUnitList(Model.selectedUnit).mechList(Model.selectedMech).Name = _
                TextBoxMechName.Text

            If (TextBoxPilotName.Text <> "" And TextBoxPilotGunnery.Text <> "" And _
                TextBoxPilotPiloting.Text <> "") Then

                Dim pilotName As String = TextBoxPilotName.Text
                Dim pilotGunnery As Integer = CInt(TextBoxPilotGunnery.Text)
                Dim pilotPiloting As Integer = CInt(TextBoxPilotPiloting.Text)

                Dim tempPilot = New Pilot(pilotName, pilotPiloting, pilotGunnery)

                Model.rootUnitList(Model.selectedUnit).mechList(Model.selectedMech) _
                    .addPilot(tempPilot)
            Else

                ' do nothing
            End If

            UnitDesigner.resetListBox()
            Me.Close()
        Else

            LabelError.Text = "Please set a name for this mech!"
        End If
    End Sub
End Class