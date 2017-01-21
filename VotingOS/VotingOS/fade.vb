Module fade


    Public Sub FadeInBoot()
        Dim Fade As Double
        For Fade = 0.1 To 1.1 Step 0.1
            InitialBoot.Opacity = Fade
            InitialBoot.Refresh()
            Threading.Thread.Sleep(100)
        Next

    End Sub

End Module
