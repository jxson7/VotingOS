Public Class configchoice
    ' This aspect has been specifically created in order for the admin to gain access to configure the voters that wish to vote for those running for a position.
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        VotersConfig.Show()
    End Sub
    'Configuring head boy profiles ONLY
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        HeadBoyConfig.Show()

    End Sub
    ' If wanting to config head girl profiles
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        HeadGirlConfig.Show()
        Me.Hide()
    End Sub
    ' If wanting to exit the entire system. 
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo)
        If vbYes Then
            Close()
        ElseIf vbNo Then
            Me.Close()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Me.Hide()
        PollsViewer.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseMove

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        PollsViewer.Show()
    End Sub
End Class