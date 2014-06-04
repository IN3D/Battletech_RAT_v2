Public Class PilotAdditionForm

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click

        If (TextBoxName.Text <> "" And TextBoxPiloting.Text <> "" And TextBoxGunnery.Text <> "") Then


            Dim index As Integer = UnitDesigner.ComboBoxUnit.SelectedIndex
            Dim unitIndex As Integer = UnitDesigner.ListBoxUnits.SelectedIndex

            Dim name As String = Me.TextBoxName.Text
            Dim piloting As Integer = CInt(Me.TextBoxPiloting.Text)
            Dim gunnery As Integer = CInt(Me.TextBoxGunnery.Text)

            ' create a pilot to be passed to the mech
            Dim pilot = New Pilot(name, piloting, gunnery)

            rootUnitList.ElementAt(index).mechList.ElementAt(unitIndex).addPilot(pilot)

            ' now refresh the list box
            UnitDesigner.resetListBox()

            Me.Close()
        Else

            MessageBox.Show("Please ensure that you've entered complete data!", "ERROR")
        End If
    End Sub
End Class