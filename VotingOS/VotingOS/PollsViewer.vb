Public Class PollsViewer
    Private Sub PollsViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.HeadGirlCount' table. You can move, or remove it, as needed.
        Me.HeadGirlCountTableAdapter.Fill(Me.DatabaseDataSet.HeadGirlCount)
        'TODO: This line of code loads data into the 'DatabaseDataSet.HeadBoyCount' table. You can move, or remove it, as needed.
        Me.HeadBoyCountTableAdapter.Fill(Me.DatabaseDataSet.HeadBoyCount)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        closeform()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        configchoice.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized

    End Sub
End Class