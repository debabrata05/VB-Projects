
Public Class Form1
    Dim r1 As Boolean = False
    Dim r2 As Boolean = False
    Dim r3 As Boolean = False
    Dim but As String
    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        r1 = True
        but = "r1"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        r2 = True
        but = "r2"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged
        r3 = True
        but = "r3"
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label1.Text = but
    End Sub
End Class
