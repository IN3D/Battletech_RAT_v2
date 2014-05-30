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

            Me.ListBoxUnits.Items.Add(Mech.ToString)
        Next
    End Sub

    Private Sub ButtonMoveUp_Click(sender As Object, e As EventArgs) Handles ButtonMoveUp.Click

        Try
            Dim unitIndex As Integer = ComboBoxUnit.SelectedIndex
            Dim index As Integer = ListBoxUnits.SelectedIndex
            Dim tempName As String = rootUnitList.ElementAt(unitIndex).mechList.ElementAt(index).Name
            Dim tempMech As Mech = rootUnitList.ElementAt(unitIndex).mechList.ElementAt(index)
            Dim targetmech As Mech = rootUnitList.ElementAt(unitIndex).mechList.ElementAt(index - 1)
            Dim target As LinkedListNode(Of Mech) = rootUnitList.ElementAt(unitIndex).mechList.Find(targetmech)


            rootUnitList.ElementAt(unitIndex).mechList.Remove(tempMech)
            rootUnitList.ElementAt(unitIndex).mechList.AddBefore(target, New Mech(tempName))

            Me.resetListBox()

            ' set the index back on the previously selected mech
            ListBoxUnits.SelectedIndex = (index - 1)

        Catch ex As Exception

            ' maybe not show a message box, it's slightly annoying
            ' MessageBox.Show("Error, you can't move a mech out of the list!", "ERROR")
        End Try
    End Sub

    Private Sub ButtonMoveDown_Click(sender As Object, e As EventArgs) Handles ButtonMoveDown.Click

        Try
            Dim unitIndex As Integer = ComboBoxUnit.SelectedIndex
            Dim index As Integer = ListBoxUnits.SelectedIndex
            Dim tempName As String = rootUnitList.ElementAt(unitIndex).mechList.ElementAt(index).Name
            Dim tempMech As Mech = rootUnitList.ElementAt(unitIndex).mechList.ElementAt(index)
            Dim targetmech As Mech = rootUnitList.ElementAt(unitIndex).mechList.ElementAt(index + 1)
            Dim target As LinkedListNode(Of Mech) = rootUnitList.ElementAt(unitIndex).mechList.Find(targetmech)

            rootUnitList.ElementAt(unitIndex).mechList.Remove(tempMech)
            rootUnitList.ElementAt(unitIndex).mechList.AddAfter(target, New Mech(tempName))

            Me.resetListBox()

            ' set the index back to the previously selected mech
            ListBoxUnits.SelectedIndex = (index + 1)

        Catch ex As Exception

        End Try

    End Sub

    Protected Sub resetListBox()
        Dim index As Integer = ComboBoxUnit.SelectedIndex

        ListBoxUnits.Items.Clear()

        For Each Mech In rootUnitList(index).mechList

            Me.ListBoxUnits.Items.Add(Mech.Name)
        Next
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click

        Dim result = MessageBox.Show("Are you sure?", "Delete?", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then

            Dim unitIndex As Integer = ComboBoxUnit.SelectedIndex
            Dim index As Integer = ListBoxUnits.SelectedIndex
            Dim targetMech As Mech = rootUnitList.ElementAt(unitIndex).mechList.ElementAt(index)

            rootUnitList.ElementAt(unitIndex).mechList.Remove(targetMech)

            Me.resetListBox()
        End If
    End Sub

    Private Sub ButtonReRoll_Click(sender As Object, e As EventArgs) Handles ButtonReRoll.Click

        ' parse the textboxes
        Integer.TryParse(TextBoxLights.Text, lights)
        Integer.TryParse(TextBoxMedium.Text, mediums)
        Integer.TryParse(TextBoxHeavy.Text, heavies)
        Integer.TryParse(TextBoxAssault.Text, assaults)

        ' required variables
        Dim empty As Boolean = (lights = 0 And mediums = 0 And heavies = 0 And assaults = 0)
        Dim i As Integer
        Dim index As Integer = ComboBoxUnit.SelectedIndex
        Dim unitIndex As Integer = ListBoxUnits.SelectedIndex

        If unitIndex <> -1 Then

            If empty = False Then

                If (lights = 1 And mediums = 0 And heavies = 0 And assaults = 0) Then

                    i = 1
                    MainForm.ComboBoxWeight.SelectedIndex = 0

                    Do While i <= lights

                        MainForm.ButtonRoll.PerformClick()
                        Dim tempName As String = MainForm.ListBoxMechs.SelectedItem.ToString()
                        rootUnitList(index).mechList.ElementAt(unitIndex).Name = tempName

                        i = (i + 1)
                    Loop

                    Me.resetListBox()
                    ListBoxUnits.SelectedIndex = unitIndex

                ElseIf (mediums = 1 And lights = 0 And heavies = 0 And assaults = 0) Then

                    i = 1
                    MainForm.ComboBoxWeight.SelectedIndex = 1

                    Do While i <= mediums

                        MainForm.ButtonRoll.PerformClick()
                        Dim tempName As String = MainForm.ListBoxMechs.SelectedItem.ToString()
                        rootUnitList(index).mechList.ElementAt(unitIndex).Name = tempName

                        i = (i + 1)
                    Loop

                    Me.resetListBox()
                    ListBoxUnits.SelectedIndex = unitIndex

                ElseIf (heavies = 1 And lights = 0 And mediums = 0 And assaults = 0) Then

                    i = 1
                    MainForm.ComboBoxWeight.SelectedIndex = 2

                    Do While i <= heavies

                        MainForm.ButtonRoll.PerformClick()
                        Dim tempName As String = MainForm.ListBoxMechs.SelectedItem.ToString()
                        rootUnitList(index).mechList.ElementAt(unitIndex).Name = tempName

                        i = (i + 1)
                    Loop

                    Me.resetListBox()
                    ListBoxUnits.SelectedIndex = unitIndex

                ElseIf (assaults = 1 And lights = 0 And mediums = 0 And heavies = 0) Then

                    i = 1
                    MainForm.ComboBoxWeight.SelectedIndex = 3

                    Do While i <= assaults

                        MainForm.ButtonRoll.PerformClick()
                        Dim tempName As String = MainForm.ListBoxMechs.SelectedItem.ToString()
                        rootUnitList(index).mechList.ElementAt(unitIndex).Name = tempName

                        i = (i + 1)
                    Loop

                    Me.resetListBox()
                    ListBoxUnits.SelectedIndex = unitIndex
                Else
                    MessageBox.Show("Ensure that you are only rerolling 1 mech!", "ERROR")

                End If
            Else

                MessageBox.Show("Make sure you're rerolling at least one mech!", "ERROR")
            End If
        Else

            MessageBox.Show("Please select (or reselect) the mech you want re-rolled!", "ERROR")
        End If
    End Sub
End Class