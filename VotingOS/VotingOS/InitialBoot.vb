Public Class InitialBoot
    Private Sub InitialBoot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FadeInBoot()
        Timer1.Start()

        Dim ofd As New OpenFileDialog()
        ofd.Filter = "bild offnen {*.png) | *.png | ALL Files |*.*"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Start.Show()
        End If
    End Sub
End Class