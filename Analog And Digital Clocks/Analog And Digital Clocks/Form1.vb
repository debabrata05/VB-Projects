Public Class formAnalogAndDigitalClock

    Private Sub formAnalogAndDigitalClock_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        rdbtnDigital.Checked = True

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        lblDigital.Text = TimeOfDay

    End Sub

    Private Sub rdbtnDigital_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbtnDigital.CheckedChanged

        If rdbtnDigital.Checked = True Then
            lblDigital.Show()
            Analog.Hide()
        Else
            lblDigital.Hide()
            Analog.Show()

        End If

    End Sub
End Class
