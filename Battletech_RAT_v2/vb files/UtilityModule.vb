Imports System.Xml
Imports System.IO

Module UtilityModule

    Dim diceRandom As New System.Random(CType(System.DateTime.Now.Ticks Mod System.Int32.MaxValue, Integer))

    Public Sub LoadXML(ByVal fileDirectory As String)

        Try

            Dim a As Integer = 0
            For Each xmlFile As String In My.Computer.FileSystem.GetFiles(fileDirectory)

                Dim xmlDoc As XmlDocument
                Dim nodeList As XmlNodeList
                Dim node As XmlNode

                xmlDoc = New XmlDocument()
                xmlDoc.Load(xmlFile)

                nodeList = xmlDoc.SelectNodes("/book")

                ' Begin looping
                For Each node In nodeList

                    ' Add in the book
                    MainForm.bookList.AddLast(New Book(node.Attributes.GetNamedItem("name").Value))

                    For i As Integer = 0 To ((node.ChildNodes.Count) - 1)

                        ' Add the factions covered by the book to it
                        MainForm.bookList(a).factionList.AddLast _
                            (New Faction(node.ChildNodes.Item(i).Attributes.GetNamedItem("name").Value))

                        For j As Integer = 0 To ((node.ChildNodes.Item(i).ChildNodes.Count) - 1)

                            ' Add the tech levels the faction has to it
                            MainForm.bookList(a).factionList(i).techList.AddLast _
                                (New Tech(node.ChildNodes.Item(i).ChildNodes(j).Attributes.GetNamedItem("name").Value))

                            For x As Integer = 0 To ((node.ChildNodes.Item(i).ChildNodes.Item(j).ChildNodes.Count) - 1)

                                ' Add the weight lists to the tech level
                                MainForm.bookList(a).factionList(i).techList(j).WeightList.AddLast _
                                    (New Weight(node.ChildNodes.Item(i).ChildNodes.Item(j).ChildNodes(x).Attributes. _
                                                GetNamedItem("name").Value))

                                For y As Integer = 0 To ((node.ChildNodes.Item(i).ChildNodes.Item(j).ChildNodes.Item(x).ChildNodes.Count) - 1)

                                    ' Add the mechs to their weight catagory
                                    MainForm.bookList(a).factionList(i).techList(j).WeightList(x).mechList.AddLast _
                                        (New Mech(node.ChildNodes.Item(i).ChildNodes.Item(j).ChildNodes.Item(x) _
                                                  .ChildNodes.Item(y).InnerText))
                                Next
                            Next
                        Next
                    Next
                Next
                a = (a + 1)

            Next

        Catch ex As Exception

            MessageBox.Show("An error has occured while parsing an xml file.", "ERROR")
        End Try

    End Sub

    Public Sub PopulateBookList()

        Dim bookCount As Integer = MainForm.bookList.Count

        For i As Integer = 0 To (bookCount - 1)

            Dim tempName As String = MainForm.bookList(i).Name
            MainForm.ComboBoxBook.Items.Add(tempName)
        Next
    End Sub

    Private Function getRandomNumber(ByVal low As Integer, ByVal high As Integer) As Integer

        Return diceRandom.Next(low, high + 1)
    End Function

    Public Function rollDice(ByVal diceStyle As Integer) As Dice

        'Dim die1 As Integer = (Int(Rnd() * diceStyle))
        'Dim die2 As Integer = (Int(Rnd() * diceStyle))
        Dim die1 As Integer = getRandomNumber(0, diceStyle - 1)
        Dim die2 As Integer = getRandomNumber(0, diceStyle - 1)

        Dim diceSet As New Dice(die1, die2)

        Return diceSet

    End Function

    Public Function setDiceStyle(ByVal diceType As Integer) As Integer

        Dim prompt As String = "Please enter the dice style you want"
        Dim title As String = "Dice style"
        Dim defaultValue As String = diceType.ToString()
        Dim value As Object

        value = InputBox(prompt, title, defaultValue)
        Dim usersVal As Integer
        Integer.TryParse(value, usersVal)

        ' If the value is greater than 0, set the new number
        If usersVal > 0 Then

            Return usersVal
        Else

            ' Else, set it to the default dice style (a d6)
            Return 6
        End If
    End Function

    Public Function checkOutOfBounds(ByVal total As Integer, ByVal mechCount As Integer) As Integer

        ' if the player is no longer cheating
        If (total <= mechCount) And (MainForm.LabelJoke.Text <> "") Then

            MainForm.LabelJoke.Text = ""
        End If

        ' if the count of roll total has gone beyond the total number of mechs
        If (total > mechCount) Then

            MainForm.LabelJoke.Text = "dishonorable".ToUpper

            total = mechCount
        End If

        Return total
    End Function

    Public Sub clearForm(ByVal i As Integer)

        ' this was made into a switch case, as I wasn't sure if I would
        ' want to clear out less information under particular situations
        ' so I set it up so that it could be expanded if needed.

        Select Case i
            Case 0
                MainForm.ComboBoxBook.Text = ""
                MainForm.ComboBoxFaction.Text = ""
                MainForm.ComboBoxTech.Text = ""
                MainForm.ComboBoxWeight.Text = ""
                MainForm.ListBoxMechs.Items.Clear()

                MainForm.ToolStripStatusLabelDebugCounter.Text = ""
                MainForm.ToolStripStatusLabelDiceRoll.Text = "Roll: "
                MainForm.TextBoxModifier.Text = ""
            Case Else
                MessageBox.Show("Internal Error, clearForm case passed incorrect value.", "ERROR")
        End Select
    End Sub

    Public Sub indexChange(ByVal x As Integer)

        Select Case x
            ' Book Change
            Case 0

                MainForm.ComboBoxFaction.Items.Clear()
                MainForm.selectedBook = MainForm.ComboBoxBook.SelectedIndex

                For i As Integer = 0 To ((MainForm.bookList(MainForm.selectedBook).factionList.Count) - 1)

                    Dim tempName As String = MainForm.bookList(MainForm.selectedBook).factionList(i).Name
                    MainForm.ComboBoxFaction.Items.Add(tempName)
                Next

                ' Faction Change
            Case 1

                MainForm.ComboBoxTech.Items.Clear()
                MainForm.selectedFaction = MainForm.ComboBoxFaction.SelectedIndex

                For i As Integer = 0 To ((MainForm.bookList(MainForm.selectedBook).factionList(MainForm.selectedFaction).techList.Count) - 1)

                    Dim tempName As String = MainForm.bookList(MainForm.selectedBook).factionList(MainForm.selectedFaction).techList(i).Name
                    MainForm.ComboBoxTech.Items.Add(tempName)
                Next

                ' Tech Change
            Case 2

                MainForm.ComboBoxWeight.Items.Clear()
                MainForm.selectedTech = MainForm.ComboBoxTech.SelectedIndex

                For i As Integer = 0 To ((MainForm.bookList(MainForm.selectedBook).factionList(MainForm.selectedFaction).techList(MainForm.selectedTech) _
                                          .WeightList.Count) - 1)

                    Dim tempName As String = MainForm.bookList(MainForm.selectedBook).factionList(MainForm.selectedFaction).techList(MainForm.selectedTech) _
                                             .WeightList(i).Name
                    MainForm.ComboBoxWeight.Items.Add(tempName)
                Next

                ' Weight Change
            Case 3

                MainForm.ListBoxMechs.Items.Clear()
                MainForm.selectedWeight = MainForm.ComboBoxWeight.SelectedIndex

                For i As Integer = 0 To ((MainForm.bookList(MainForm.selectedBook).factionList(MainForm.selectedFaction).techList(MainForm.selectedTech) _
                                          .WeightList(MainForm.selectedWeight).mechList.Count) - 1)

                    Dim tempName As String = MainForm.bookList(MainForm.selectedBook).factionList(MainForm.selectedFaction).techList(MainForm.selectedTech) _
                                             .WeightList(MainForm.selectedWeight).mechList(i).Name
                    MainForm.ListBoxMechs.Items.Add(tempName)
                Next

            Case Else

                MessageBox.Show("INTERNAL ERROR: indexChange was passed incorrect value.", "ERROR")
        End Select
    End Sub
End Module
