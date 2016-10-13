Public Class VotersConfig
    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.UsersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.UsersDataSet)
            MsgBox("Update Successful")
            Me.Hide()
            configchoice.Show()
        Catch ex As Exception
            MsgBox("Update Failed. Please try again later or contact your administrator.")

        End Try


    End Sub

    Private Sub VotersConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UsersDataSet.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.UsersDataSet.users)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Me.Validate()
            Me.UsersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.UsersDataSet)
            MsgBox("Update Successful")
            Me.Hide()
            configchoice.Show()

        Catch ex As Exception
            MsgBox("Update Failed. Please try again later or contact your administrator.")

        End Try
    End Sub
End Class