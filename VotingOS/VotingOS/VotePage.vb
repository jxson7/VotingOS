Imports VotingOS.MainLogin
Imports System.Data.OleDb

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
        Dim SQL As String = "SELECT * FROM Database"



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        'Dim result As Integer = MsgBox("Do you wish to vote this candidate as head boy: headboyvote.Text", MsgBoxStyle.YesNo)
        'If result = DialogResult.Yes Then
        'Dim result2 As Integer = MsgBox("Do you wish to vote this candidate as head girl:", headgirlvote.Text, MsgBoxStyle.YesNo)
        'If result = DialogResult.Yes Then
        Dim cmd As OleDb.OleDbCommand = myConnection.CreateCommand

                myConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Database.accdb"
                myConnection.Open()
                cmd.CommandText = "UPDATE users SET VotedHeadBoy = @update1, VotedHeadGirl = @update2, Voted = True WHERE user = @update3 "
                cmd.Parameters.AddWithValue("@update1", headboyvote.Text)
                cmd.Parameters.AddWithValue("@update2", headgirlvote.Text)
                cmd.Parameters.AddWithValue("@update3", Username)

                MsgBox("You have successfully casted your vote. You will now be signed out. Thank you and goodbye.")
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                myConnection.Close()
                Me.Close()

        'End If
        'End If


    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim query As String

        Dim command As OleDbCommand
        Dim reader As OleDbDataReader

        myConnection.Open()
        query = "select * from HeadBoyCandidates"
        command = New OleDbCommand(query, myConnection)
        reader = command.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()
                ComboBox1.Items.Add(reader("ID"))
            End While
        End If
    End Sub



    Private Sub headgirlvote_KeyPress(sender As Object, e As KeyPressEventArgs) Handles headgirlvote.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only. Make sure the value you have entered is a candidate running for this position else your vote will not be counted.")
            e.Handled = True
        End If

    End Sub


    Private Sub headboyvote_KeyPress(sender As Object, e As KeyPressEventArgs) Handles headboyvote.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only. Make sure the value you have entered is a candidate running for this position else your vote will not be counted.")
            e.Handled = True
        End If
    End Sub
End Class