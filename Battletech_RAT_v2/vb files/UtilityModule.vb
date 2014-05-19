Imports System.Xml
Imports System.IO

Module UtilityModule

    Public Sub LoadXML(ByVal fileDirectory As String)

        Try

            For Each xmlFile As String In My.Computer.FileSystem.GetFiles(fileDirectory)

                'MainForm.bookList.AddLast(New Book(xmlFile))

                Dim xmlDoc As XmlDocument
                'Dim rootNodeList As XmlNodeList
                Dim nodeList As XmlNodeList
                Dim node As XmlNode

                xmlDoc = New XmlDocument()
                xmlDoc.Load(xmlFile)

                'rootNodeList = xmlDoc.SelectNodes("/book")
                nodeList = xmlDoc.SelectNodes("/book")

                Dim a As Integer = 0

                For Each node In nodeList

                    MainForm.bookList.AddLast(New Book(node.Attributes.GetNamedItem("name").Value))

                    For i As Integer = 0 To ((node.ChildNodes.Count) - 1)

                        MainForm.bookList(a).factionList.AddLast _
                            (New Faction(node.ChildNodes.Item(i).Attributes.GetNamedItem("name").Value))

                        For j As Integer = 0 To ((node.ChildNodes.Item(i).ChildNodes.Count) - 1)

                            MainForm.bookList(a).factionList(i).techList.AddLast _
                                (New Tech(node.ChildNodes.Item(i).ChildNodes(j).Attributes.GetNamedItem("name").Value))

                            For x As Integer = 0 To ((node.ChildNodes.Item(i).ChildNodes.Item(j).ChildNodes.Count) - 1)

                                MainForm.bookList(a).factionList(i).techList(j).WeightList.AddLast _
                                    (New Weight(node.ChildNodes.Item(i).ChildNodes.Item(j).ChildNodes(x).Attributes. _
                                                GetNamedItem("name").Value))

                                For y As Integer = 0 To ((node.ChildNodes.Item(i).ChildNodes.Item(j).ChildNodes.Item(x).ChildNodes.Count) - 1)

                                    MainForm.bookList(a).factionList(i).techList(j).WeightList(x).mechList.AddLast _
                                        (New Mech(node.ChildNodes.Item(i).ChildNodes.Item(j).ChildNodes.Item(x) _
                                                  .ChildNodes.Item(y).InnerText))
                                Next
                            Next
                        Next
                    Next
                    a = (a + 1)
                Next

            Next

        Catch ex As Exception

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
