Public Class Form1
    'Main Start-Up menu only. 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MainLogin.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("VotingOS is a brand new software. This software will allow you place a vote for a candidate running for the post your school has set up. 
This program now allows: 
                        - Adding New Voters and Admins
                        - Adding Profile Pictures for Candidates
                        - Confirming the Votes
                        - Add/Remove and Or Change Candidate Credentials
")

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
