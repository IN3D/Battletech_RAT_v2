Public Class UnitDesigner

    Dim lights As Integer
    Dim mediums As Integer
    Dim heavies As Integer
    Dim assaults As Integer

    ' Weight is used here because it holds a mech list
    Public rootUnitList As New LinkedList(Of Weight)

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click

        Integer.TryParse(TextBoxLights.Text, lights)
        Integer.TryParse(TextBoxMedium.Text, mediums)
        Integer.TryParse(TextBoxHeavy.Text, heavies)
        Integer.TryParse(TextBoxAssault.Text, assaults)
        Dim index As Integer = ComboBoxUnit.SelectedIndex

        Dim i As Integer

        If index <> -1 Then

            If lights > 0 Then
                i = 1
                MainForm.ComboBoxWeight.SelectedIndex = 0

                Do While i <= lights

                    MainForm.ButtonRoll.PerformClick()
                    rootUnitList(index).mechList.AddLast(New Mech(MainForm.ListBoxMechs.SelectedItem.ToString))

                    i = (i + 1)
                Loop
            End If

            If mediums > 0 Then
                i = 1
                MainForm.ComboBoxWeight.SelectedIndex = 1

                Do While i <= mediums

                    MainForm.ButtonRoll.PerformClick()
                    rootUnitList(index).mechList.AddLast(New Mech(MainForm.ListBoxMechs.SelectedItem.ToString))

                    i = (i + 1)
                Loop
            End If

            If heavies > 0 Then
                i = 1
                MainForm.ComboBoxWeight.SelectedIndex = 2

                Do While i <= heavies

                    MainForm.ButtonRoll.PerformClick()
                    rootUnitList(index).mechList.AddLast(New Mech(MainForm.ListBoxMechs.SelectedItem.ToString))

                    i = (i + 1)
                Loop
            End If

            If assaults > 0 Then
                i = 1
                MainForm.ComboBoxWeight.SelectedIndex = 3

                Do While i <= assaults

                    MainForm.ButtonRoll.PerformClick()
                    rootUnitList(index).mechList.AddLast(New Mech(MainForm.ListBoxMechs.SelectedItem.ToString))

                    i = (i + 1)
                Loop
            End If

            Me.ListBoxUnits.Items.Clear()

            For Each Mech In rootUnitList(index).mechList

                Me.ListBoxUnits.Items.Add(Mech.Name)
            Next

        Else

            MessageBox.Show("Please select the unit that you're adding to.", "Error!")
        End If
    End Sub

    Private Sub ButtonUnit_Click(sender As Object, e As EventArgs) Handles ButtonUnit.Click

        Dim prompt As String = "Please enter this units name"
        Dim title As String = "Unit Name"
        Dim defaultValue As String = "1st Somerset Strikers"
        Dim value As String

        value = InputBox(prompt, title, defaultValue)

        rootUnitList.AddLast(New Weight(value))

        ' update the combobox
        Dim i As Integer
        ComboBoxUnit.Items.Clear()

        For Each unit In rootUnitList

            ComboBoxUnit.Items.Add(rootUnitList(i).Name)
            i = (i + 1)
        Next
    End Sub

    Private Sub ComboBoxUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxUnit.SelectedIndexChanged

        Dim index As Integer = ComboBoxUnit.SelectedIndex

        Me.ListBoxUnits.Items.Clear()

        For Each Mech In rootUnitList(index).mechList

            Me.ListBoxUnits.Items.Add(Mech.Name)
        Next
    End Sub
End Class