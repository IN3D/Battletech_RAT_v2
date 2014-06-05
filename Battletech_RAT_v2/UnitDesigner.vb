Imports System.IO
Imports System.Xml

Public Class UnitDesigner

    Dim lights As Integer
    Dim mediums As Integer
    Dim heavies As Integer
    Dim assaults As Integer

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click

        Integer.TryParse(TextBoxLights.Text, lights)
        Integer.TryParse(TextBoxMedium.Text, mediums)
        Integer.TryParse(TextBoxHeavy.Text, heavies)
        Integer.TryParse(TextBoxAssault.Text, assaults)
        Dim index As Integer = ComboBoxUnit.SelectedIndex

        Dim i As Integer

        If index <> -1 Then

            Try

                If RadioButtonHtoL.Checked = True Then

                    If assaults > 0 Then
                        i = 1
                        MainForm.ComboBoxWeight.SelectedIndex = 3

                        Do While i <= assaults

                            MainForm.ButtonRoll.PerformClick()
                            Model.rootUnitList(index).mechList.AddLast(New Mech(MainForm.ListBoxMechs.SelectedItem.ToString))

                            i = (i + 1)
                        Loop
                    End If

                    If heavies > 0 Then
                        i = 1
                        MainForm.ComboBoxWeight.SelectedIndex = 2

                        Do While i <= heavies

                            MainForm.ButtonRoll.PerformClick()
                            Model.rootUnitList(index).mechList.AddLast(New Mech(MainForm.ListBoxMechs.SelectedItem.ToString))

                            i = (i + 1)
                        Loop
                    End If

                    If mediums > 0 Then
                        i = 1
                        MainForm.ComboBoxWeight.SelectedIndex = 1

                        Do While i <= mediums

                            MainForm.ButtonRoll.PerformClick()
                            Model.rootUnitList(index).mechList.AddLast(New Mech(MainForm.ListBoxMechs.SelectedItem.ToString))

                            i = (i + 1)
                        Loop
                    End If

                    If lights > 0 Then
                        i = 1
                        MainForm.ComboBoxWeight.SelectedIndex = 0

                        Do While i <= lights

                            MainForm.ButtonRoll.PerformClick()
                            Model.rootUnitList(index).mechList.AddLast(New Mech(MainForm.ListBoxMechs.SelectedItem.ToString))

                            i = (i + 1)
                        Loop
                    End If

                ElseIf RadioButtonLtoH.Checked = True Then

                    If lights > 0 Then
                        i = 1
                        MainForm.ComboBoxWeight.SelectedIndex = 0

                        Do While i <= lights

                            MainForm.ButtonRoll.PerformClick()
                            Model.rootUnitList(index).mechList.AddLast(New Mech(MainForm.ListBoxMechs.SelectedItem.ToString))

                            i = (i + 1)
                        Loop
                    End If

                    If mediums > 0 Then
                        i = 1
                        MainForm.ComboBoxWeight.SelectedIndex = 1

                        Do While i <= mediums

                            MainForm.ButtonRoll.PerformClick()
                            Model.rootUnitList(index).mechList.AddLast(New Mech(MainForm.ListBoxMechs.SelectedItem.ToString))

                            i = (i + 1)
                        Loop
                    End If

                    If heavies > 0 Then
                        i = 1
                        MainForm.ComboBoxWeight.SelectedIndex = 2

                        Do While i <= heavies

                            MainForm.ButtonRoll.PerformClick()
                            Model.rootUnitList(index).mechList.AddLast(New Mech(MainForm.ListBoxMechs.SelectedItem.ToString))

                            i = (i + 1)
                        Loop
                    End If

                    If assaults > 0 Then
                        i = 1
                        MainForm.ComboBoxWeight.SelectedIndex = 3

                        Do While i <= assaults

                            MainForm.ButtonRoll.PerformClick()
                            Model.rootUnitList(index).mechList.AddLast(New Mech(MainForm.ListBoxMechs.SelectedItem.ToString))

                            i = (i + 1)
                        Loop
                    End If
                End If



                Me.ListBoxUnits.Items.Clear()

                For Each Mech In Model.rootUnitList(index).mechList

                    Me.ListBoxUnits.Items.Add(Mech.Name)
                Next
            Catch ex As Exception

                MessageBox.Show("An error occurred trying to add units, please try again.")
            End Try

        Else

            MessageBox.Show("Please select the unit that you're adding to.", "Error!")
        End If
    End Sub

    Private Sub ButtonUnit_Click(sender As Object, e As EventArgs) Handles ButtonUnit.Click

        Dim prompt As String = "Please enter this divisions name"
        Dim title As String = "Division Name"
        Dim defaultValue As String = "1st Lance"
        Dim value As String

        value = InputBox(prompt, title, defaultValue)

        Model.rootUnitList.AddLast(New Weight(value))

        ' update the combobox
        Dim i As Integer
        ComboBoxUnit.Items.Clear()

        For Each unit In Model.rootUnitList

            ComboBoxUnit.Items.Add(Model.rootUnitList(i).Name)
            i = (i + 1)
        Next
    End Sub

    Private Sub ComboBoxUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxUnit.SelectedIndexChanged

        Dim index As Integer = ComboBoxUnit.SelectedIndex
        Model.selectedUnit = index

        Me.ListBoxUnits.Items.Clear()

        For Each Mech In Model.rootUnitList(index).mechList

            Me.ListBoxUnits.Items.Add(Mech.ToString)
        Next
    End Sub

    Private Sub ButtonMoveUp_Click(sender As Object, e As EventArgs) Handles ButtonMoveUp.Click

        Try
            Dim unitIndex As Integer = ComboBoxUnit.SelectedIndex
            Dim index As Integer = ListBoxUnits.SelectedIndex
            Dim tempName As String = Model.rootUnitList.ElementAt(unitIndex).mechList.ElementAt(index).Name
            Dim tempMech As Mech = Model.rootUnitList.ElementAt(unitIndex).mechList.ElementAt(index)
            Dim targetmech As Mech = Model.rootUnitList.ElementAt(unitIndex).mechList.ElementAt(index - 1)
            Dim target As LinkedListNode(Of Mech) = Model.rootUnitList.ElementAt(unitIndex).mechList.Find(targetmech)


            Model.rootUnitList.ElementAt(unitIndex).mechList.Remove(tempMech)
            Model.rootUnitList.ElementAt(unitIndex).mechList.AddBefore(target, New Mech(tempMech))

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
            Dim tempName As String = Model.rootUnitList.ElementAt(unitIndex).mechList.ElementAt(index).Name
            Dim tempMech As Mech = Model.rootUnitList.ElementAt(unitIndex).mechList.ElementAt(index)
            Dim targetmech As Mech = Model.rootUnitList.ElementAt(unitIndex).mechList.ElementAt(index + 1)
            Dim target As LinkedListNode(Of Mech) = Model.rootUnitList.ElementAt(unitIndex).mechList.Find(targetmech)

            Model.rootUnitList.ElementAt(unitIndex).mechList.Remove(tempMech)
            Model.rootUnitList.ElementAt(unitIndex).mechList.AddAfter(target, New Mech(tempMech))

            Me.resetListBox()

            ' set the index back to the previously selected mech
            ListBoxUnits.SelectedIndex = (index + 1)

        Catch ex As Exception

        End Try

    End Sub

    Public Sub resetListBox()
        Dim index As Integer = ComboBoxUnit.SelectedIndex

        ListBoxUnits.Items.Clear()

        For Each Mech In Model.rootUnitList(index).mechList

            Me.ListBoxUnits.Items.Add(Mech.ToString())
        Next
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click

        Dim result = MessageBox.Show("Are you sure?", "Delete?", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then

            Try

                Dim unitIndex As Integer = ComboBoxUnit.SelectedIndex
                Dim index As Integer = ListBoxUnits.SelectedIndex
                Dim targetMech As Mech = Model.rootUnitList.ElementAt(unitIndex).mechList.ElementAt(index)

                Model.rootUnitList.ElementAt(unitIndex).mechList.Remove(targetMech)

                Me.resetListBox()
            Catch ex As Exception
                MessageBox.Show("Could not delete the selected unit")
            End Try
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
                        Model.rootUnitList(index).mechList.ElementAt(unitIndex).Name = tempName

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
                        Model.rootUnitList(index).mechList.ElementAt(unitIndex).Name = tempName

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
                        Model.rootUnitList(index).mechList.ElementAt(unitIndex).Name = tempName

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
                        Model.rootUnitList(index).mechList.ElementAt(unitIndex).Name = tempName

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

    Private Sub ButtonDeleteUnit_Click(sender As Object, e As EventArgs) Handles ButtonDeleteUnit.Click

        Dim result = MessageBox.Show("Are you sure, this will remove the unit and all the mechs in it?", "Delete?", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes And ComboBoxUnit.Items.Count <> 0 Then

            Try

                Dim index As Integer = ComboBoxUnit.SelectedIndex
                Dim unitToRemove As Weight = Model.rootUnitList.ElementAt(index)

                ' clear out all mechs in the unit
                Model.rootUnitList.ElementAt(index).mechList.Clear()

                Model.rootUnitList.Remove(unitToRemove)

                ' set text back to nothing to avoid confusion
                ComboBoxUnit.Text = ""

                ' repopulate the combobox
                ComboBoxUnit.Items.Clear()
                Dim i As Integer = 0
                For Each unit In Model.rootUnitList

                    ComboBoxUnit.Items.Add(Model.rootUnitList(i).Name)
                    i = (i + 1)
                Next
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub ButtonAddPilot_Click(sender As Object, e As EventArgs) Handles ButtonAddPilot.Click

        PilotAdditionForm.Show()


    End Sub

    Private Sub UnitDesigner_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' update the combobox
        Dim i As Integer
        ComboBoxUnit.Items.Clear()

        For Each unit In Model.rootUnitList

            ComboBoxUnit.Items.Add(Model.rootUnitList(i).Name)
            i = (i + 1)
        Next
    End Sub

    Private Sub OverallUnitNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OverallUnitNameToolStripMenuItem.Click

        Dim prompt As String = "Please enter this units overall name"
        Dim title As String = "Unit Name"
        Dim defaultValue As String = Model.OverallUnitName
        Dim value As String

        value = InputBox(prompt, title, defaultValue)
        Model.OverallUnitName = value
    End Sub

    Private Sub SaveToHTMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToHTMLToolStripMenuItem.Click

        Dim sheetToUse As String

        Select Case Model.Style
            Case 0
                sheetToUse = "default"
            Case 1
                sheetToUse = "davion"
            Case 2
                sheetToUse = "kurita"
            Case 3
                sheetToUse = "liao"
            Case 4
                sheetToUse = "marik"
            Case 5
                sheetToUse = "steiner"
            Case Else
                sheetToUse = "default"
        End Select

        Try

            Using writer As StreamWriter = New StreamWriter("../../savedUnits/" + Model.OverallUnitName + ".html")
                writer.WriteLine("<!DOCTYPE html>")
                writer.WriteLine("<html>")
                writer.WriteLine("<head lang=""en"">")
                writer.WriteLine("<meta charset=""UTF-8"">")
                writer.WriteLine("<title>" + Model.OverallUnitName + "</title>")
                writer.WriteLine("<link rel=""stylesheet"" type=""text/css"" href=""../css/" + sheetToUse + ".css"">")
                writer.WriteLine("</head>")
                writer.WriteLine("<body>")
                writer.WriteLine("<h1>" + Model.OverallUnitName + "</h1>")

                Dim i As Integer = 0
                For Each unit In Model.rootUnitList

                    writer.WriteLine("<h2>" + Model.rootUnitList(i).Name + "</h2>")
                    writer.WriteLine("<table>")

                    Dim x As Integer = 0
                    For Each Mech In Model.rootUnitList(i).mechList

                        writer.WriteLine("<tr><td>" + Model.rootUnitList(i).mechList(x).ToString + "</td></tr>")

                        x = (x + 1)
                    Next
                    i = (i + 1)
                    writer.WriteLine("</table>")
                Next

                writer.WriteLine("</body>")
                writer.WriteLine("</html>")
            End Using

            MessageBox.Show("saved successfully")
        Catch ex As Exception

            MessageBox.Show("ERROR: File was not saved!")
        End Try
    End Sub

    Private Sub SetHTMLStyleToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SetHTMLStyleToolStripMenuItem.Click

        CssSelector.Show()
    End Sub

    Private Sub SaveTotxtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveTotxtToolStripMenuItem.Click

        Try

            Using writer As StreamWriter = New StreamWriter("../../savedUnits/" + Model.OverallUnitName + ".txt")
                writer.WriteLine(Model.OverallUnitName)
                writer.WriteLine()

                Dim i As Integer = 0
                For Each unit In Model.rootUnitList

                    writer.WriteLine(Model.rootUnitList(i).Name)

                    Dim x As Integer = 0
                    For Each Mech In Model.rootUnitList(i).mechList

                        writer.WriteLine(" - " + Model.rootUnitList(i).mechList(x).Name)

                        x = (x + 1)
                    Next
                    i = (i + 1)
                    writer.WriteLine()
                Next
            End Using

            MessageBox.Show("saved successfully")
        Catch ex As Exception

            MessageBox.Show("ERROR: File was not saved!")
        End Try
    End Sub

    Private Sub SaveToXMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToXMLToolStripMenuItem.Click


        Try
            Dim contact As XDocument =
            <?xml version="1.0" encoding="UTF-8"?>
            <root name=<%= Model.OverallUnitName %>>
                <%= From units In Model.rootUnitList
                    Select <unit name=<%= units.Name %>>
                               <%= From mechs In units.mechList
                       Select <mech pilot=<%= mechs.getPilotName %> gunnery=<%= mechs.getPilotGunnery %> piloting=<%= mechs.getPilotPiloting %>><%= mechs.Name %></mech>
                               %>
                           </unit>
                %>
            </root>

            Try

                Using writer As StreamWriter = New StreamWriter("../../savedUnits/" + Model.OverallUnitName + ".xml")
                    writer.Write(contact)
                End Using
            Catch ex As Exception

                MessageBox.Show("ERROR: Failed to write XML Document")
            End Try
        Catch ex As Exception

            MessageBox.Show("ERROR: Failed to create XML Document")
        End Try


    End Sub

    Private Sub LoadXMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadXMLToolStripMenuItem.Click

        Dim stream As Stream = Nothing
        Dim openFileDialog As New OpenFileDialog()
        Dim xmlDoc As XmlDocument
        xmlDoc = New XmlDocument()

        Dim nodeList As XmlNodeList
        Dim node As XmlNode

        openFileDialog.InitialDirectory = "../../savedUnits"
        openFileDialog.Filter = "xml files (*.xml)|*.xml"
        openFileDialog.FilterIndex = 0
        openFileDialog.RestoreDirectory = True

        If openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            Try
                ' stream = openFileDialog.OpenFile()
                Dim fileLoc = openFileDialog.FileName()
                If (fileLoc IsNot Nothing) Then

                    xmlDoc.Load(fileLoc)

                    nodeList = xmlDoc.SelectNodes("/root")

                    Model.OverallUnitName = nodeList.Item(0).Attributes.GetNamedItem("name").Value

                    For Each node In nodeList

                        For i As Integer = 0 To ((node.ChildNodes.Count) - 1)

                            Model.rootUnitList.AddLast(New Weight(node.ChildNodes(i).Attributes.GetNamedItem("name").Value))

                            For j As Integer = 0 To ((node.ChildNodes(i).ChildNodes.Count) - 1)

                                Dim pilotName As String = Nothing
                                Dim pilotGunnery As Integer = Nothing
                                Dim pilotPiloting As Integer = Nothing
                                Dim mechName As String = ""

                                Try

                                    pilotName = node.ChildNodes(i).ChildNodes(j).Attributes.GetNamedItem("pilot").Value
                                Catch ex As Exception

                                    pilotName = Nothing
                                End Try

                                Try

                                    pilotGunnery = node.ChildNodes(i).ChildNodes(j).Attributes.GetNamedItem("gunnery").Value
                                Catch ex As Exception

                                    pilotGunnery = Nothing
                                End Try

                                Try

                                    pilotPiloting = node.ChildNodes(i).ChildNodes(j).Attributes.GetNamedItem("piloting").Value
                                Catch ex As Exception

                                    pilotPiloting = Nothing
                                End Try


                                mechName = node.ChildNodes(i).ChildNodes(j).InnerText

                                Model.rootUnitList(i).mechList.AddLast(New Mech(mechName))

                                If pilotName <> Nothing And pilotGunnery <> Nothing And pilotPiloting <> Nothing Then

                                    Dim pilot As New Pilot(pilotName, pilotPiloting, pilotGunnery)

                                    rootUnitList(i).mechList(j).addPilot(pilot)
                                End If
                            Next
                        Next
                    Next

                    ' update the combobox
                    Dim x As Integer = 0
                    ComboBoxUnit.Items.Clear()

                    For Each unit In Model.rootUnitList

                        ComboBoxUnit.Items.Add(Model.rootUnitList(x).Name)
                        x = (x + 1)
                    Next

                End If
            Catch ex As Exception

                MessageBox.Show("An error occurred reading in your XML file.")
            End Try
        End If

    End Sub

    Private Sub ListBoxUnits_DoubleClick(sender As Object, e As EventArgs) Handles ListBoxUnits.DoubleClick

        SetMech.Show()

        ' reset the ListBox to show the changes to the mech
        ' resetListBox()
    End Sub

    Private Sub ListBoxUnits_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxUnits.SelectedIndexChanged

        Model.selectedMech = ListBoxUnits.SelectedIndex
    End Sub
End Class