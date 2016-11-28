Public Class CastingFinalVotes
    Private Sub CastingFinalVotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.CandidatesHeadGirl' table. You can move, or remove it, as needed.
        Me.CandidatesHeadGirlTableAdapter.Fill(Me.DatabaseDataSet.CandidatesHeadGirl)
        'TODO: This line of code loads data into the 'DatabaseDataSet.CandidateHeadBoy' table. You can move, or remove it, as needed.
        Me.CandidateHeadBoyTableAdapter.Fill(Me.DatabaseDataSet.CandidateHeadBoy)
        'TODO: This line of code loads data into the 'DatabaseDataSet.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.DatabaseDataSet.users)
        'TODO: This line of code loads data into the 'DatabaseDataSet.HeadBoyCount' table. You can move, or remove it, as needed.
        Me.HeadBoyCountTableAdapter.Fill(Me.DatabaseDataSet.HeadBoyCount)

    End Sub

    Private Sub VotedHeadBoyTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VotedHeadBoyTextBox.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If

    End Sub

    Private Sub VotedHeadBoyTextBox_TextChanged(sender As Object, e As EventArgs) Handles VotedHeadBoyTextBox.TextChanged

    End Sub

    Private Sub VotedHeadGirlTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VotedHeadGirlTextBox.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub VotedHeadGirlTextBox_TextChanged(sender As Object, e As EventArgs) Handles VotedHeadGirlTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Validate()
            Me.UsersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
            MsgBox("Update Successful")
        Catch ex As Exception
            MsgBox("Update Failed. Please try again later or conbtact your administrator.")
        End Try
    End Sub
End Class