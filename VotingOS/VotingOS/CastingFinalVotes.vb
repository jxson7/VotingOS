Imports System.Data.OleDb
Imports VotingOS.MainLogin
Public Class CastingFinalVotes
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Private Sub CastingFinalVotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = MainLogin.Username
        VotedHeadBoyTextBox.Clear()
        VotedHeadGirlTextBox.Clear()
        'TODO: This line of code loads data into the 'DatabaseDataSet.CandidatesHeadGirl' table. You can move, or remove it, as needed.
        Me.CandidatesHeadGirlTableAdapter.Fill(Me.DatabaseDataSet.CandidatesHeadGirl)
        'TODO: This line of code loads data into the 'DatabaseDataSet.CandidateHeadBoy' table. You can move, or remove it, as needed.
        Me.CandidateHeadBoyTableAdapter.Fill(Me.DatabaseDataSet.CandidateHeadBoy)
        'TODO: This line of code loads data into the 'DatabaseDataSet.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.DatabaseDataSet.users)
        'TODO: This line of code loads data into the 'DatabaseDataSet.HeadBoyCount' table. You can move, or remove it, as needed.
        Me.HeadBoyCountTableAdapter.Fill(Me.DatabaseDataSet.HeadBoyCount)

    End Sub

    Private Sub VotedHeadBoyTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VotedHeadBoyTextBox.KeyPress
        'This section will allow a trigger notice as a method of validation to confirm that if the value entered in the textbox is not entered, then notify the user that only numbers are accepted
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If

    End Sub

    Private Sub VotedHeadGirlTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VotedHeadGirlTextBox.KeyPress
        'Same as above, he line will simply replicate the fact that only numerical values can be entered into this system. 
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub


    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'This part will allow saving the data, when the save button is clicked'
        Try
            provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
            'Change the following to your access database location
            dataFile = "N:\VOTER_OS\VotingOS\VotingOS\Database.accdb"
            connString = provider & dataFile
            myConnection.ConnectionString = connString

            myConnection.Open()
            Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [users] WHERE [user] = '" & MainLogin.Username, myConnection)
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            ' the following variable is hold true if user is found, and false if user is not found
            Dim userFound As Boolean = False
            Dim Username As String = ""

            'if found:CONFIRMATION IS REQUIRED IF IT IS NEEDED. 
            While dr.Read
                userFound = True
                Username = dr("user").ToString
            End While

            Me.Validate()
            Me.UsersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
            MsgBox("Update Successful")


            Select Case MsgBox("You have casted your vote, do you now wish to sign out?", MsgBoxStyle.YesNo)
                Case MsgBoxResult.Yes
                    Application.Exit()
                Case MsgBoxResult.No
                    HeadBoyProfiles.Show()
            End Select
        Catch ex As Exception
            MsgBox("Update Failed. Please try again later or conbtact your administrator.")
        End Try
        VotedHeadBoyTextBox.Clear()
        VotedHeadGirlTextBox.Clear()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class