Public Class Form1
    'Main Start-Up menu only. 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MainLogin.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("VotingOS is a brand new software. This software will allow you place a vote for a candidate running for the post your school has set up.")

    End Sub
End Class
