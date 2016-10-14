Imports System.Data.OleDb
Public Class authorisedlogin
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        'Change the following to your access database location
        dataFile = "N:\VotingOS\VotingOS\VotingOS\bin\Debug\authorisedmembers.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString

        myConnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [authorisedmembers] WHERE [password] = '" & TextBox1.Text & "'", myConnection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader

        ' the following variable is hold true if user is found, and false if user is not found
        Dim userFound As Boolean = False
        ' the following variables will hold the user first and last name if found.
        Dim FirstName As String = ""
        Dim LastName As String = ""

        'if found:
        While dr.Read
            userFound = True
            FirstName = dr("FirstName").ToString
            LastName = dr("LastName").ToString
        End While

        'checking the result
        If userFound = True Then
            Me.Hide()
            configchoice.Show()

        Else
            MsgBox("Sorry, your credentials are incorrect/have not been found. Please try again or contact your administrator. You will be taken back to the main login page.", MsgBoxStyle.OkOnly, "Invalid Login")
            Me.Hide()
            MainLogin.Show()
        End If

        myConnection.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub authorisedlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Clear()
    End Sub
End Class