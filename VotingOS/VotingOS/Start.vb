Public Class Start
    'Main Start-Up menu only. 



    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
        MainLogin.Show()
    End Sub

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        Dim ofd As New OpenFileDialog()
        ofd.Filter = "bild offnen {*.png) | *.png | ALL Files |*.*"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Increment(5)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            PictureBox1.Hide()
            fade()
            fadeout()

        End If
    End Sub
    Public Sub fade()

        Dim FadeIn As Double
        Label1.Visible = True
        For FadeIn = 0.0 To 1.1 Step 0.1
            Label1.Text = FadeIn
            Label1.Refresh()
            Threading.Thread.Sleep(100)
        Next


    End Sub

    Public Sub fadeout()

        Dim fadeout As Double
        For fadeout = 90 To 10 Step -10
            Label1.Text = fadeout / 100
            Me.Refresh()
            Threading.Thread.Sleep(50)
            Label1.Visible = False
        Next

    End Sub

End Class
