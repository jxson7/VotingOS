﻿
Public Class MainLogin
    Public Shared myConnection As OleDb.OleDbConnection = New OleDb.OleDbConnection

    Public Shared Username As String
    Public Shared MyName As String
    Public Shared MySurname As String
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim provider As String
        Dim dataFile As String
        Dim connString As String

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        'Change the following to your access database location
        dataFile = "N:\VOTER_OS\VotingOS\VotingOS\bin\debug\Database.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString

        myConnection.Open()
        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT * FROM [users] WHERE [user] = '" & userinput.Text & "' AND [password] = '" & TextBox2.Text & "'", myConnection)
        Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader
        ' the following variable is hold true if user is found, and false if user is not found
        Dim userFound As Boolean = False
        ' the following variables will hold the user first and last name if found.
        Dim FirstName As String = ""
        Dim LastName As String = ""
        Dim Username As String = ""

        'if found:CONFIRMATION IS REQUIRED IF IT IS NEEDED. 
        While dr.Read
            userFound = True
            FirstName = dr("FirstName").ToString
            LastName = dr("LastName").ToString
            Username = dr("user").ToString
        End While

        'checking the result: IF FOUND, THE PIECE IS DIRECTED FOR THE STUDENTS DIRECTLY TO THE VOTING PAGE OS (STUDENTS ONLY)
        If userFound = True Then
            MainLogin.Username = userinput.Text
            MainLogin.MyName = FirstName
            MainLogin.MySurname = LastName
            Me.Hide()
            ContinueMsgBox.Show()

        Else
            MsgBox("Sorry, your credentials are incorrect/have not been found. Please try again or contact your administrator", MsgBoxStyle.OkOnly, "Invalid Login")
        End If

        myConnection.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        authorisedlogin.Show()
    End Sub

End Class