Public Class CssSelector

    Private Sub CssSelector_Load(sender As Object, e As EventArgs) Handles Me.Load

        Select Case Model.Style
            Case 0
                RadioButtonDefault.Checked = True
            Case 1
                RadioButtonDavion.Checked = True
            Case 2
                RadioButtonKurita.Checked = True
            Case 3
                RadioButtonLiao.Checked = True
            Case 4
                RadioButtonMarik.Checked = True
            Case 5
                RadioButtonSteiner.Checked = True
            Case Else
                RadioButtonDefault.Checked = True
        End Select
    End Sub

    Private Sub RadioButtonDefault_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDefault.CheckedChanged

        Model.Style = 0
    End Sub

    Private Sub RadioButtonDavion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDavion.CheckedChanged

        Model.Style = 1
    End Sub

    Private Sub RadioButtonKurita_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonKurita.CheckedChanged

        Model.Style = 2
    End Sub

    Private Sub RadioButtonLiao_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonLiao.CheckedChanged

        Model.Style = 3
    End Sub

    Private Sub RadioButtonMarik_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonMarik.CheckedChanged

        Model.Style = 4
    End Sub

    Private Sub RadioButtonSteiner_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSteiner.CheckedChanged

        Model.Style = 5
    End Sub

    Private Sub ButtonSet_Click(sender As Object, e As EventArgs) Handles ButtonSet.Click

        ' After I finished working on this, I made it so changing the
        ' radiobuttons sets the style, so the set button actually just
        ' closes the form.
        Me.Close()
    End Sub
End Class