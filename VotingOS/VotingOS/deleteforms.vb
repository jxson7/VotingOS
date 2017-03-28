Imports System.Data.OleDb
Public Class deleteforms
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cmd As OleDb.OleDbCommand = myConnection.CreateCommand

        myConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Database.accdb"
        myConnection.Open()
        cmd.CommandText = "DELETE * FROM CandidateHeadBoy"

        cmd.ExecuteNonQuery()
        cmd.Dispose()
        MsgBox("HEAD BOY DETAILS HAVE BEEN DELETED")
        myConnection.Close()
        Me.Close()
        configchoice.Show()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        closeform()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        configchoice.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As OleDb.OleDbCommand = myConnection.CreateCommand

        myConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Database.accdb"
        myConnection.Open()
        cmd.CommandText = "DELETE * FROM CandidatesHeadGirl"

        cmd.ExecuteNonQuery()
        cmd.Dispose()
        MsgBox("HEAD GIRL DETAILS HAVE BEEN DELETED")
        myConnection.Close()
        Me.Close()
        configchoice.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cmd As OleDb.OleDbCommand = myConnection.CreateCommand

        myConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Database.accdb"
        myConnection.Open()
        cmd.CommandText = "DELETE * FROM users"

        cmd.ExecuteNonQuery()
        cmd.Dispose()
        MsgBox("ALL VOTER DETAILS HAVE BEEN DELETED")
        myConnection.Close()
        Me.Close()
        configchoice.Show()
    End Sub
End Class