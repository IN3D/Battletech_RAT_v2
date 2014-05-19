﻿Imports System.Xml
Imports System.IO

Module UtilityModule

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
End Module