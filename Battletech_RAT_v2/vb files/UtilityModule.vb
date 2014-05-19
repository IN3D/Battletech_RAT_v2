Imports System.Xml
Imports System.IO

Module UtilityModule

    Public Sub LoadXML(ByVal fileName As String)

        Try
            Dim xmlDoc As XmlDocument
            Dim nodeList As XmlNodeList
            Dim node As XmlNode

            xmlDoc = New XmlDocument()

            xmlDoc.Load(fileName)

            nodeList = xmlDoc.SelectNodes("/book/faction")

            MainForm.bookList.AddLast(New Book("Total Warfare"))

            Dim i As Integer = 0
            For Each node In nodeList

                MainForm.bookList(0).factionList.AddLast _
                    (New Faction(node.Attributes.GetNamedItem("name").Value))

                For j As Integer = 0 To ((node.ChildNodes.Count) - 1)

                    MainForm.bookList(0).factionList(i).techList.AddLast _
                        (New Tech(node.ChildNodes.Item(j).Attributes.GetNamedItem("name").Value))

                    For x As Integer = 0 To ((node.ChildNodes.Item(j).ChildNodes.Count) - 1)

                        MainForm.bookList(0).factionList(i).techList(j).WeightList.AddLast _
                            (New Weight(node.ChildNodes.Item(j).ChildNodes(x).Attributes.GetNamedItem("name").Value))

                        For y As Integer = 0 To ((node.ChildNodes.Item(j).ChildNodes.Item(x).ChildNodes.Count) - 1)

                            MainForm.bookList(0).factionList(i).techList(j).WeightList(x).mechList.AddLast _
                                (New Mech(node.ChildNodes.Item(j).ChildNodes.Item(x).ChildNodes.Item(y).InnerText))
                        Next
                    Next
                Next
                i = (i + 1)

            Next
        Catch ex As Exception

            MessageBox.Show("An error has occurred", "ERROR")
        End Try
    End Sub

    Public Sub PopulateFactionList()

        Dim factionCount As Integer = MainForm.bookList(0).factionList.Count

        For i As Integer = 0 To (factionCount - 1)

            Dim tempName As String = MainForm.bookList(0).factionList(i).Name
            MainForm.ComboBoxFaction.Items.Add(tempName)
        Next
    End Sub
End Module
