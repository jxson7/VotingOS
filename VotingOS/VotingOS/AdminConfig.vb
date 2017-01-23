Public Class AdminConfig
    Private Sub AuthorisedmembersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AuthorisedmembersBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.AuthorisedmembersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
            MsgBox("Update Successful")
            configchoice.Show()
        Catch ex As Exception
            MsgBox("Update Failed. Please try again later or contact administrator.")

        End Try

    End Sub

    Private Sub AdminConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.authorisedmembers' table. You can move, or remove it, as needed.
        Me.AuthorisedmembersTableAdapter.Fill(Me.DatabaseDataSet.authorisedmembers)

    End Sub

    Private Sub ToolStripContainer1_ContentPanel_Load(sender As Object, e As EventArgs) Handles ToolStripContainer1.ContentPanel.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Validate()
            Me.AuthorisedmembersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
            MsgBox("Update Successful")
            configchoice.Show()
        Catch ex As Exception
            MsgBox("Update Failed. Please try again later or contact administrator.")

        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        configchoice.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        closeform()
    End Sub
End Class