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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        closeform()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim result As Integer = MsgBox("By clicking back here, you will be taken back to the sign in page and WILL be signed out. Do you wish to proceed", MsgBoxStyle.YesNo)
        If result = DialogResult.Yes Then
            Me.Hide()
            MainLogin.userinput.Clear()
            MainLogin.TextBox2.Clear()
            MainLogin.Show()
        End If
    End Sub
End Class