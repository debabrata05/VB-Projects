Public Class formEquSolver

    Dim a, b, c, D, root1, root2 As Double


    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click

        txtRoot1.Text = ""
        txtRoot2.Text = ""
        txtValueOfa.Text = ""
        txtValueOfb.Text = ""
        txtValueOfc.Text = ""

    End Sub

    Private Sub btnSolution_Click(sender As System.Object, e As System.EventArgs) Handles btnSolution.Click

        a = Convert.ToDouble(txtValueOfa.Text)
        b = Convert.ToDouble(txtValueOfb.Text)
        c = Convert.ToDouble(txtValueOfc.Text)
        D = ((b * b) - (4 * a * c))
        If D > 0 Then

            root1 = (-b + Math.Sqrt(D)) / (2 * a)
            root2 = (-b - Math.Sqrt(D)) / (2 * a)
            txtRoot1.Text = root1.ToString()
            txtRoot2.Text = root2.ToString()

        ElseIf D = 0 Then

            root1 = -b / (2 * a)
            root2 = -b / (2 * a)
            txtRoot1.Text = root1.ToString()
            txtRoot2.Text = root2.ToString()

        ElseIf D < 0 Then
            root1 = (-b + Math.Sqrt(-1 * D)) / (2 * a)
            root2 = (-b - Math.Sqrt(-1 * D)) / (2 * a)
            txtRoot1.Text = root1.ToString() + "  i"
            txtRoot2.Text = root2.ToString() + "  i"

        End If

    End Sub
End Class
