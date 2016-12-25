Public Class Form1
    Dim fn As IO.StreamWriter
    Private Sub btnAddItems_Click(sender As System.Object, e As System.EventArgs) Handles btnAddItems.Click

        lbItems.Items.Add(txtItems.Text)
        lbItems.SelectedIndex = lbItems.SelectedIndex + 1
    End Sub

    Private Sub btnSaveItems_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveItems.Click

        Dim index As Integer
        fn = New IO.StreamWriter("E:\" & txtFileName.Text & ".txt")

        For index = 0 To lbItems.Items.Count - 1
            fn.WriteLine(lbItems.Items.Item(index))
        Next

        fn.Close()

    End Sub
End Class
