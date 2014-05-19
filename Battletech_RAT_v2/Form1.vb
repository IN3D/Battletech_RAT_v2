Public Class MainForm

    Public bookList As New LinkedList(Of Book)
    Dim selectedFaction As Integer
    Dim selectedTech As Integer
    Dim selectedWeight As Integer

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call LoadXML("..//..//xml//Total Warfare.xml")
        Call PopulateFactionList()
    End Sub

    Private Sub ComboBoxFaction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxFaction.SelectedIndexChanged

        ComboBoxTech.Items.Clear()
        selectedFaction = ComboBoxFaction.SelectedIndex

        For i As Integer = 0 To ((bookList(0).factionList(selectedFaction).techList.Count) - 1)

            Dim tempName As String = bookList(0).factionList(selectedFaction).techList(i).Name

            ComboBoxTech.Items.Add(tempName)
        Next
    End Sub

    Private Sub ComboBoxTech_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTech.SelectedIndexChanged

        ComboBoxWeight.Items.Clear()
        selectedTech = ComboBoxTech.SelectedIndex

        For i As Integer = 0 To ((bookList(0).factionList(selectedFaction).techList(selectedTech).WeightList.Count) - 1)

            Dim tempName As String = bookList(0).factionList(selectedFaction).techList(selectedTech).WeightList(i).Name

            ComboBoxWeight.Items.Add(tempName)
        Next
    End Sub

    Private Sub ComboBoxWeight_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxWeight.SelectedIndexChanged

        ListBoxMechs.Items.Clear()
        selectedWeight = ComboBoxWeight.SelectedIndex

        For i As Integer = 0 To ((bookList(0).factionList(selectedFaction).techList(selectedTech).WeightList(selectedWeight).mechList.Count) - 1)

            Dim tempName As String = bookList(0).factionList(selectedFaction).techList(selectedTech).WeightList(selectedWeight).mechList(i).Name

            ListBoxMechs.Items.Add(tempName)
        Next

        ToolStripStatusLabelDebugCounter.Text = ListBoxMechs.Items.Count.ToString()
    End Sub
End Class
