Imports VotingOS.MainLogin

Class VotePage


    Private Sub CandidateHeadBoyBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CandidateHeadBoyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub VotePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.DatabaseDataSet.users)
        'TODO: This line of code loads data into the 'DatabaseDataSet.CandidatesHeadGirl' table. You can move, or remove it, as needed.
        Me.CandidatesHeadGirlTableAdapter.Fill(Me.DatabaseDataSet.CandidatesHeadGirl)
        'TODO: This line of code loads data into the 'DatabaseDataSet.CandidateHeadBoy' table. You can move, or remove it, as needed.
        Me.CandidateHeadBoyTableAdapter.Fill(Me.DatabaseDataSet.CandidateHeadBoy)
        TextBox1.Text = ("Name: " & MainLogin.MyName & " " & MainLogin.MySurname)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Try
        'Me.Validate()
        'Me.UsersBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
        'MsgBox("Update Successful")
        'Catch ex As Exception
        'MsgBox("Update Failed. Please try again later or conbtact your administrator.")
        'End Try

        'Dim provider As String
        'Dim dataFile As String
        'Dim connString As String



        Dim cmd As OleDb.OleDbCommand = myConnection.CreateCommand
        'provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        'Change the following to your access database location
        'dataFile = "N:\VOTER_OS\VotingOS\VotingOS\bin\debug\Database.accdb"
        'connString = provider & dataFile
        myConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Database.accdb"
        myConnection.Open()
        cmd.CommandText = "UPDATE users SET VotedHeadBoy = @update1, VotedHeadGirl = @update2 WHERE user = @update3 "
        cmd.Parameters.AddWithValue("@update1", headboyvote.Text)
        cmd.Parameters.AddWithValue("@update2", headgirlvote.Text)
        cmd.Parameters.AddWithValue("@update3", Username)
        MsgBox(Username)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        myConnection.Close()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class