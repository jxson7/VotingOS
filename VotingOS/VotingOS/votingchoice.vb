Public Class votingchoice
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'By addding the availability to view profiles once again, the user will be able to view any profiles at any given time when on this page.
        Me.Hide()
        HeadBoyProfiles.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'By addding the availability to view profiles once again, the user will be able to view any profiles at any given time when on this page.
        Me.Hide()
        HeadGirlProfiles.Show()
    End Sub
End Class