Imports System.Data.OleDb
Public Class FINALVOTEPAGE
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Try
            Me.Validate()
            Me.CandidatesHeadGirlBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
            MsgBox("Update Successful")
        Catch ex As Exception
            MsgBox("Update Failed. Please try again later or contact administrator.")
        End Try
    End Sub

    Private Sub FINALVOTEPAGE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.CandidatesHeadGirl' table. You can move, or remove it, as needed.
        Me.CandidatesHeadGirlTableAdapter.Fill(Me.DatabaseDataSet.CandidatesHeadGirl)
        'TODO: This line of code loads data into the 'DatabaseDataSet.CandidateHeadBoy' table. You can move, or remove it, as needed.
        Me.CandidateHeadBoyTableAdapter.Fill(Me.DatabaseDataSet.CandidateHeadBoy)
        'TODO: This line of code loads data into the 'DatabaseDataSet.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.DatabaseDataSet.users)
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        'Change the following to your access database location
        dataFile = "N:\VOTER_OS\VotingOS\VotingOS\bin\debug\Database.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString


        ''if found:CONFIRMATION IS REQUIRED IF IT IS NEEDED. 


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandType = "UPDATE VotedHeadBoy SET [users] WHERE [user] = mainlogin.username"


            Me.Validate()
                Me.CandidatesHeadGirlBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
                MsgBox("Update Successful")
        Catch ex As Exception
            MsgBox("Update Failed. Please try again later or contact administrator.")
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        myConnection.Open()
        FirstNameTextBox.Clear()
        LastNameTextBox.Clear()
        VotedHeadBoyTextBox.Clear()
        VotedHeadGirlTextBox.Clear()
        Dim str As String
        str = "SELECT * FROM users WHERE (user = '" & TextBox1.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        While dr.Read()
            VotedHeadBoyTextBox.Text = dr("VotedHeadBoy").ToString
            VotedHeadGirlTextBox.Text = dr("VotedHeadGirl").ToString
            FirstNameTextBox.Text = dr("FirstName").ToString
            LastNameTextBox.Text = dr("LastName").ToString


        End While

        myConnection.Close()

    End Sub


    Private Sub VotedHeadBoyTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FirstNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles FirstNameTextBox.TextChanged

    End Sub
End Class