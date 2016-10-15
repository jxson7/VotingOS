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
        Me.Hide()
        headgirlconfig.Show()
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
End Class