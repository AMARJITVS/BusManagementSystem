Public Class Splash

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 5
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            LOGIN.Show()
            Close()
        End If
    End Sub
End Class