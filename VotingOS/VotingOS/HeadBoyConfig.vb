Public Class HeadBoyConfig
    Private Sub CandidateHeadBoyBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CandidateHeadBoyBindingNavigatorSaveItem.Click
        TextBox1.Clear()
        Try
            Me.Validate()
            Me.CandidateHeadBoyBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CandidatesHeadBoyDataSet)
            MsgBox("Update Successful")
            Me.Hide()
            configchoice.Show()
        Catch ex As Exception
            MsgBox("Update Failed. Please try again later or contact your administrator.")

        End Try

    End Sub

    Private Sub HeadBoyConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CandidatesHeadBoyDataSet.CandidateHeadBoy' table. You can move, or remove it, as needed.
        Me.CandidateHeadBoyTableAdapter.Fill(Me.CandidatesHeadBoyDataSet.CandidateHeadBoy)

    End Sub
    ' This aspect allows the form to activate the allowance of uploading an image to the profile. 
    'TODO: Set clearance of textbox name
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.ShowDialog()

        TextBox1.Text = OpenFileDialog1.FileName

        ImagePictureBox.Image = Image.FromFile(TextBox1.Text)
    End Sub
End Class