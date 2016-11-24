Public Class FINALVOTES
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim recordIdx As Integer
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub CandidateHeadBoyBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CandidateHeadBoyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CandidatesHeadBoyDataSet)

    End Sub

    Private Sub FINALVOTES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CandidatesHeadGirlDataSet.CandidatesHeadGirl' table. You can move, or remove it, as needed.
        Me.CandidatesHeadGirlTableAdapter.Fill(Me.CandidatesHeadGirlDataSet.CandidatesHeadGirl)
        'TODO: This line of code loads data into the 'CandidatesHeadBoyDataSet.CandidateHeadBoy' table. You can move, or remove it, as needed.
        Me.CandidateHeadBoyTableAdapter.Fill(Me.CandidatesHeadBoyDataSet.CandidateHeadBoy)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastItem.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click
        Me.CandidateHeadBoyBindingSource.MoveNext()


    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click

    End Sub
End Class