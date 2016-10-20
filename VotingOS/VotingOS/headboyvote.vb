' This page including HeadBoy/HeadGirl will act as the profile page of each individual candidate in order for the user to have the ability to view the system. Following this, the voter will be able to click a cast final vote button to make their final decision.
Public Class headboyvote
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CandidateHeadBoyBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CandidateHeadBoyBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CandidateHeadBoyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CandidatesHeadBoyDataSet)

    End Sub

    Private Sub headboyvote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CandidatesHeadBoyDataSet.CandidateHeadBoy' table. You can move, or remove it, as needed.
        Me.CandidateHeadBoyTableAdapter.Fill(Me.CandidatesHeadBoyDataSet.CandidateHeadBoy)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        headgirlvote.Show()

    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastItem.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        FINALVOTES.Show()
    End Sub
End Class