Imports System.Drawing.Imaging
Public Class Start
    Dim r As Integer = 0
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
        'Timer2.Start()
        Me.Icon = New Icon("C:\Users\Owner\Desktop\VotingOS.ico")
        Timer1.Start()

        Dim ofd As New OpenFileDialog()
        ofd.Filter = "bild offnen {*.png) | *.png | ALL Files |*.*"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Increment(10)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            PictureBox1.Hide()
            Label1.Visible = True




        End If
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        closeform()


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized


    End Sub

    Private Sub PictureBox1_Click_2(sender As Object, e As EventArgs)

    End Sub
End Class

