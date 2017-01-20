Public Class HeadGirlConfig
    Private Sub CandidatesHeadGirlBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CandidatesHeadGirlBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.CandidatesHeadGirlBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
            MsgBox("Update Successful")
        Catch ex As Exception
            MsgBox("Update Failed. Please try again later or contact administrator.")
            TextBox1.Clear()
        End Try
    End Sub

    Private Sub HeadGirlConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.CandidatesHeadGirl' table. You can move, or remove it, as needed.
        Me.CandidatesHeadGirlTableAdapter.Fill(Me.DatabaseDataSet.CandidatesHeadGirl)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class