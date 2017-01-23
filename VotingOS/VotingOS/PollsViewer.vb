Public Class PollsViewer
    Private Sub PollsViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.HeadGirlCount' table. You can move, or remove it, as needed.
        Me.HeadGirlCountTableAdapter.Fill(Me.DatabaseDataSet.HeadGirlCount)
        'TODO: This line of code loads data into the 'DatabaseDataSet.HeadBoyCount' table. You can move, or remove it, as needed.
        Me.HeadBoyCountTableAdapter.Fill(Me.DatabaseDataSet.HeadBoyCount)

    End Sub
End Class