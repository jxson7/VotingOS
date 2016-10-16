Public Class adminconfig
    Private Sub AuthorisedmembersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AuthorisedmembersBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
        Me.AuthorisedmembersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.AuthorisedmembersDataSet)
            MsgBox("Update Successful")
            Me.Hide()
            configchoice.Show()
        Catch ex As Exception
            MsgBox("Update Failed. Please try again later or contact your administrator.")

        End Try

    End Sub

    Private Sub adminconfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AuthorisedmembersDataSet.authorisedmembers' table. You can move, or remove it, as needed.
        Me.AuthorisedmembersTableAdapter.Fill(Me.AuthorisedmembersDataSet.authorisedmembers)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Me.Validate()
            Me.AuthorisedmembersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.AuthorisedmembersDataSet)
            MsgBox("Update Successful")
            Me.Hide()
            configchoice.Show()
        Catch ex As Exception
            MsgBox("Update Failed. Please try again later or contact your administrator.")
        End Try

    End Sub
End Class