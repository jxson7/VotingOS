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
        'This section will allow a trigger notice as a method of validation to confirm that if the value entered in the textbox is not entered, then notify the user that only numbers are accepted
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If

    End Sub

    Private Sub VotedHeadBoyTextBox_TextChanged(sender As Object, e As EventArgs) Handles VotedHeadBoyTextBox.TextChanged

    End Sub

    Private Sub VotedHeadGirlTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VotedHeadGirlTextBox.KeyPress
        'Same as above, he line will simply replicate the fact that only numerical values can be entered into this system. 
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub VotedHeadGirlTextBox_TextChanged(sender As Object, e As EventArgs) Handles VotedHeadGirlTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'This part will allow saving the data, when the save button is clicked.
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