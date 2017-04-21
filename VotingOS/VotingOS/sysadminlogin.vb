Imports System.Data.OleDb
Public Class sysadminlogin
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As OleDb.OleDbCommand = myConnection.CreateCommand

        myConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Database.accdb"
        myConnection.Open()

        'myConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Database.accdb"
        'myConnection.Open()
        cmd = New OleDbCommand("SELECT * FROM [authorisedmembers] WHERE [password] = '" & TextBox1.Text & "'", myConnection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader


        ' the following variable is hold true if user is found, and false if user is not found
        Dim userFound As Boolean = False
        ' the following variables will hold the user first and last name if found.
        Dim FirstName As String = ""
        Dim LastName As String = ""
        Dim Level As String = ""

        'if found:
        While dr.Read
            userFound = True
            FirstName = dr("FirstName").ToString
            LastName = dr("LastName").ToString
            Level = dr("Level").ToString
        End While

        'checking the result
        If String.IsNullOrEmpty(TextBox1.Text) Then
            MsgBox("Please enter your credentials")

        ElseIf userFound = True And Level = "System Admin" Then
            Me.Close()
            sysadminconfig.Show()


        Else
            'This is a validation confirmation to review whether the piece has been applied in order to verify whether the user credidentials are within the database. If not found, a msgbox is preseneted. 
            MsgBox("Sorry, your credentials may be incorrect or you have not been granted the level of access. Please try again or contact your administrator. ", MsgBoxStyle.OkOnly, "Invalid Login")
            Me.Hide()
            configchoice.Show()
        End If

        myConnection.Close()

    End Sub

    Private Sub sysadminlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Clear()
    End Sub
End Class