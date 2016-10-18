Public Class headgirlconfig
    Private Sub CandidatesHeadGirlBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CandidatesHeadGirlBindingNavigatorSaveItem.Click
        TextBox1.Clear()
        Try
            Me.Validate()
        Me.CandidatesHeadGirlBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CandidatesHeadGirlDataSet)
            MsgBox("Update Successful")
                Me.Hide()
                configchoice.Show()
            Catch ex As Exception
                MsgBox("Update Failed. Please try again later or contact your administrator.")

            End Try
    End Sub

    Private Sub headgirlconfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CandidatesHeadGirlDataSet.CandidatesHeadGirl' table. You can move, or remove it, as needed.
        Me.CandidatesHeadGirlTableAdapter.Fill(Me.CandidatesHeadGirlDataSet.CandidatesHeadGirl)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.ShowDialog()

        TextBox1.Text = OpenFileDialog1.FileName

        Profile_ImagePictureBox.Image = Image.FromFile(TextBox1.Text)
    End Sub
End Class