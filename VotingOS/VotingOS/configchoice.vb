Public Class configchoice
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        VotersConfig.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        HeadBoyConfig.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        headgirlconfig.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo)
        If vbYes Then
            Close()
        ElseIf vbNo Then
            Me.Close()
        End If
    End Sub
End Class