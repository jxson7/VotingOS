Public Class HeadBoyProfiles
    Private Sub CandidateHeadBoyBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CandidateHeadBoyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub HeadBoyProfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.CandidateHeadBoy' table. You can move, or remove it, as needed.
        Me.CandidateHeadBoyTableAdapter.Fill(Me.DatabaseDataSet.CandidateHeadBoy)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        HeadGirlProfiles.Show()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        HeadGirlProfiles.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FINALVOTEPAGE.Show()
    End Sub
End Class