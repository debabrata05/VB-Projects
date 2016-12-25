Public Class formTextFileIntoListBox

    Dim str As IO.StreamReader

    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click

        OpenFile.ShowDialog()
        txtAdress.Text = OpenFile.FileName

    End Sub

    Private Sub btnLoad_Click(sender As System.Object, e As System.EventArgs) Handles btnLoad.Click

        str = IO.File.OpenText(txtAdress.Text)
        Dim lstr() As String = str.ReadToEnd.Split(vbNewLine)
        lstTextFileContents.Items.AddRange(lstr)

    End Sub
End Class
