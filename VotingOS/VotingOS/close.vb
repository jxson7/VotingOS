Module close
    Public Sub closeform()
        Dim result As Integer = MsgBox("Are you sure you wish to quit VotingOS? Please do note that if you leave, your vote will not be saved.", MsgBoxStyle.YesNo)
        If result = DialogResult.Yes Then
            Application.Exit()
            End
        End If
    End Sub



End Module
