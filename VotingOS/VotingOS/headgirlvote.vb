Public Class headgirlvote
    Private Sub CandidatesHeadGirlBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CandidatesHeadGirlBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CandidatesHeadGirlBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CandidatesHeadGirlDataSet)

    End Sub

    Private Sub headgirlvote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CandidatesHeadGirlDataSet.CandidatesHeadGirl' table. You can move, or remove it, as needed.
        Me.CandidatesHeadGirlTableAdapter.Fill(Me.CandidatesHeadGirlDataSet.CandidatesHeadGirl)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        headboyvote.Show()
    End Sub
End Class