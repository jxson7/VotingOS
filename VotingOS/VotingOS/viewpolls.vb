Public Class viewpolls
    Private Sub viewpolls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.HeadGirlCount' table. You can move, or remove it, as needed.
        Me.HeadGirlCountTableAdapter.Fill(Me.DatabaseDataSet.HeadGirlCount)
        'TODO: This line of code loads data into the 'DatabaseDataSet.HeadBoyCount' table. You can move, or remove it, as needed.
        Me.HeadBoyCountTableAdapter.Fill(Me.DatabaseDataSet.HeadBoyCount)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class