Public Class MainForm

    Public bookList As New LinkedList(Of Book)
    Dim diceStyle As Integer = 6

    Public selectedBook As Integer
    Public selectedFaction As Integer
    Public selectedTech As Integer
    Public selectedWeight As Integer

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call LoadXML("..//..//xml//")
        Call PopulateBookList()
    End Sub

    Private Sub ComboBoxBook_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxBook.SelectedIndexChanged

        indexChange(0)

        ' If the other comboBoxes have been filled, clear them out on a book change
        If selectedFaction <> -1 And selectedTech <> -1 And selectedWeight <> -1 Then

            clearForm(0)
        End If
    End Sub

    Private Sub ComboBoxFaction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxFaction.SelectedIndexChanged

        indexChange(1)
    End Sub

    Private Sub ComboBoxTech_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTech.SelectedIndexChanged

        indexChange(2)
    End Sub

    Private Sub ComboBoxWeight_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxWeight.SelectedIndexChanged

        indexChange(3)

        ' FOR DEBUG: CAN BE REMOVED FOR RELEASE
        ToolStripStatusLabelDebugCounter.Text = ListBoxMechs.Items.Count.ToString()
    End Sub

    Private Sub ButtonRoll_Click(sender As Object, e As EventArgs) Handles ButtonRoll.Click

        Dim diceSet As New Dice(rollDice(diceStyle))

        Dim die1 As Integer = diceSet.dice1
        Dim die2 As Integer = diceSet.dice2
        Dim modifier As Integer
        Integer.TryParse(TextBoxModifier.Text, modifier)

        ' Ensure that there are even mechs to roll for
        If ListBoxMechs.Items.Count = 0 Then

            MessageBox.Show("Please populate the mech list first!", "Error!")
        Else

            Dim total As Integer = (die1 + die2) + modifier
            total = checkOutOfBounds(total, (ListBoxMechs.Items.Count - 1))

            ListBoxMechs.SelectedIndex = total
            ' added some formatting so that the dice aren't 0 based
            ToolStripStatusLabelDiceRoll.Text = "Roll: " & (total + 2) & " = " & _
                                                "(" & (die1 + 1) & " + " & (die2 + 1) & ") " & _
                                                "+ " & modifier
        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Close()
    End Sub

    Private Sub SetDiceTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetDiceTypeToolStripMenuItem.Click

        diceStyle = setDiceStyle(diceStyle)
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click

        ' clean out everything
        clearForm(0)
    End Sub

    Private Sub OpenUnitMakerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenUnitMakerToolStripMenuItem.Click

        UnitDesigner.Show()
    End Sub
End Class
