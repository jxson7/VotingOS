Imports System.Data.OleDb
Imports System.Data.SqlClient


Public Class allusers
    

    Private Sub allusers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.DatabaseDataSet.users)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.ShowDialog()
        'PrintDialog1.Document = PrintDocument1
        If PrintPreviewDialog1.ShowDialog = DialogResult.Yes Then
            PrintDocument1.DefaultPageSettings.Landscape = True
            PrintDocument1.Print()


        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        PrintDocument1.DefaultPageSettings.Landscape = True
        Dim bm As New Bitmap(Me.UsersDataGridView.Width, Me.UsersDataGridView.Height)
        UsersDataGridView.DrawToBitmap(bm, New Rectangle(0, 0, Me.UsersDataGridView.Width, Me.UsersDataGridView.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim sCommand As SqlCommand
        'Dim sAdapter As SqlDataAdapter
        'Dim sBuilder As SqlCommandBuilder
        'Dim sDs As DataSet
        'Dim sTable As DataTable

        'Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Database.accdb"

        'Dim sql As String = "SELECT * FROM users"
        'Dim connection As New SqlConnection(connectionString)
        'connection.Open()
        'sCommand = New SqlCommand(sql, connection)
        'sAdapter = New SqlDataAdapter(sCommand)
        'sBuilder = New SqlCommandBuilder(sAdapter)
        'sDs = New DataSet()
        'sAdapter.Fill(sDs, "users")
        'sTable = sDs.Tables("users")
        'connection.Close()
        'DataGridView1.DataSource = sDs.Tables("users")
        'DataGridView1.ReadOnly = True
        'DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub
End Class