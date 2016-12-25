Public Class formStopwatch

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click

        Timer.Enabled = True

    End Sub

    Private Sub btnStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStop.Click

        Timer.Enabled = False

    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click

        Timer.Enabled = False
        lblClock.Text = "0.0"

    End Sub

    Private Sub Timer_Tick(sender As System.Object, e As System.EventArgs) Handles Timer.Tick

        lblClock.Text = lblClock.Text + 0.01

    End Sub
End Class
