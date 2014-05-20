Public Class MainForm

    Public bookList As New LinkedList(Of Book)
    Dim selectedBook As Integer
    Dim selectedFaction As Integer
    Dim selectedTech As Integer
    Dim selectedWeight As Integer

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call LoadXML("..//..//xml//")
        Call PopulateBookList()
    End Sub

    Private Sub ComboBoxBook_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxBook.SelectedIndexChanged

        ComboBoxFaction.Items.Clear()
        selectedBook = ComboBoxBook.SelectedIndex

        For i As Integer = 0 To ((bookList(selectedBook).factionList.Count) - 1)

            Dim tempName As String = bookList(selectedBook).factionList(i).Name
            ComboBoxFaction.Items.Add(tempName)
        Next

        ' If the other comboBoxes have been filled, clear them out on a book change
        If selectedFaction <> -1 And selectedTech <> -1 And selectedWeight <> -1 Then

            ComboBoxFaction.Text = ""
            ComboBoxTech.Text = ""
            ComboBoxWeight.Text = ""

            ' Clean out the list of mechs
            ListBoxMechs.Items.Clear()
        End If
    End Sub

    Private Sub ComboBoxFaction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxFaction.SelectedIndexChanged

        ComboBoxTech.Items.Clear()
        selectedFaction = ComboBoxFaction.SelectedIndex

        For i As Integer = 0 To ((bookList(selectedBook).factionList(selectedFaction).techList.Count) - 1)

            Dim tempName As String = bookList(selectedBook).factionList(selectedFaction).techList(i).Name
            ComboBoxTech.Items.Add(tempName)
        Next
    End Sub

    Private Sub ComboBoxTech_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTech.SelectedIndexChanged

        ComboBoxWeight.Items.Clear()
        selectedTech = ComboBoxTech.SelectedIndex

        For i As Integer = 0 To ((bookList(selectedBook).factionList(selectedFaction).techList(selectedTech) _
                                  .WeightList.Count) - 1)

            Dim tempName As String = bookList(selectedBook).factionList(selectedFaction).techList(selectedTech) _
                                     .WeightList(i).Name
            ComboBoxWeight.Items.Add(tempName)
        Next
    End Sub

    Private Sub ComboBoxWeight_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxWeight.SelectedIndexChanged

        ListBoxMechs.Items.Clear()
        selectedWeight = ComboBoxWeight.SelectedIndex

        For i As Integer = 0 To ((bookList(selectedBook).factionList(selectedFaction).techList(selectedTech) _
                                  .WeightList(selectedWeight).mechList.Count) - 1)

            Dim tempName As String = bookList(selectedBook).factionList(selectedFaction).techList(selectedTech) _
                                     .WeightList(selectedWeight).mechList(i).Name
            ListBoxMechs.Items.Add(tempName)
        Next

        ' FOR DEBUG: CAN BE REMOVED FOR RELEASE
        ToolStripStatusLabelDebugCounter.Text = ListBoxMechs.Items.Count.ToString()
    End Sub

    Private Sub ButtonRoll_Click(sender As Object, e As EventArgs) Handles ButtonRoll.Click

        Dim diceTotal As Integer = rollDice()

        Dim jokes = {"DISHONORABLE", "DEZGRA", "STRAVAG CHEATER"}

        ' MechWarrior 3 Joke ;)
        If ((LabelJoke.Text <> "") And (diceTotal <= (ListBoxMechs.Items.Count))) Then

            LabelJoke.Text = ""
        ElseIf diceTotal >= (ListBoxMechs.Items.Count) Then

            LabelJoke.Text = jokes((Int(Rnd() * 3)))
        End If

        If diceTotal > ListBoxMechs.Items.Count Then

            diceTotal = ((ListBoxMechs.Items.Count) - 1)
        End If

        ListBoxMechs.SelectedIndex = diceTotal

    End Sub
End Class
