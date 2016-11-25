Public Class HeadBoyConfig
    Private Sub CandidateHeadBoyBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CandidateHeadBoyBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.CandidateHeadBoyBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
            MsgBox("Update Successful")
            Me.Hide()
        Catch ex As Exception
            MsgBox("Update Failed. Please try again later or contact administrator.")
            TextBox1.Clear()
        End Try

    End Sub

    Private Sub HeadBoyConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.CandidateHeadBoy' table. You can move, or remove it, as needed.
        Me.CandidateHeadBoyTableAdapter.Fill(Me.DatabaseDataSet.CandidateHeadBoy)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "image file (*.jpg, *.bmp,* .png| *.jpg; *.bmp; *.png| all files (*.*)"
        TextBox1.Text = OpenFileDialog1.SafeFileName

        ImagePictureBox.Image = Image.FromFile(TextBox1.Text)


    End Sub
End Class