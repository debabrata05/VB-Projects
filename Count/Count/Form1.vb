Public Class formCount

    Dim str As IO.StreamReader

    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click

        OpenFileDialog1.ShowDialog()
        txtAddressBar.Text = OpenFileDialog1.FileName

    End Sub

    Private Sub btnLoad_Click(sender As System.Object, e As System.EventArgs) Handles btnLoad.Click

        listParagraph.Items.Clear()
        str = IO.File.OpenText(txtAddressBar.Text)
        Dim lstr() As String = str.ReadToEnd.Split(vbNewLine)
        listParagraph.Items.AddRange(lstr)

    End Sub
    Private Sub btnCharacters_Click(sender As System.Object, e As System.EventArgs) Handles btnCharacters.Click

        Dim ch As Integer = 0
        For index = 0 To listParagraph.Items.Count - 1
            txtHelp.Text = listParagraph.Items.ToString()
            ch = txtHelp.Text.Count + ch
        Next
        MessageBox.Show(ch)


    End Sub
End Class
