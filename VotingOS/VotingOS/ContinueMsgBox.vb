Public Class ContinueMsgBox

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ContinueMsgBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ("Hi " & MainLogin.MyName)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        votingchoice.Show()
    End Sub
End Class