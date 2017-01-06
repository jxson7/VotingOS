Imports System.Data.OleDb
Public Class authorisedlogin
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        'Applies the confirmation of where exactly the file is for the database. Applicable version that has been applied is recorded as a ACCDB (Access Only)
        dataFile = "N:\VOTER_OS\VotingOS\VotingOS\Database.accdb"
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
            'This is a validation confirmation to review whether the piece has been applied in order to verify whether the user credidentials are within the database. If not found, a msgbox is preseneted. 
            MsgBox("Sorry, your credentials are incorrect/have not been found. Please try again or contact your administrator. You will be taken back to the main login page.", MsgBoxStyle.OkOnly, "Invalid Login")
            Me.Hide()
            MainLogin.Show()
        End If

        myConnection.Close()

    End Sub


    ' This is just to make sure that the credentials entered in the textbox1 is deleted if someone else wishes to enter their details without closing the entire form. 
    Private Sub authorisedlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Clear()

    End Sub

    Private Sub Textbox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        'This section allows the acceptance of the enter key to trigger the next module instead of pressing the sign in button; a feature used by the majority of the program
        If (e.KeyCode = Keys.Enter) Then
            e.SuppressKeyPress = True

            provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
            'Applies the confirmation of where exactly the file is for the databse. Applicable version that has been applied is recorded as a ACCDB (Access Only)
            dataFile = "C:\Users\Owner\Voting System\VotingOS\VotingOS\bin\Debug\Database.accdb"
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
                'This is a validation confirmation to review whether the piece has been applied in order to verify whether the user credidentials are within the database. If not found, a msgbox is preseneted. 
                MsgBox("Sorry, your credentials are incorrect/have not been found. Please try again or contact your administrator. You will be taken back to the main login page.", MsgBoxStyle.OkOnly, "Invalid Login")
                Me.Hide()
                MainLogin.Show()
            End If

            myConnection.Close()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class