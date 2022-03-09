Public Class MW3Tool
    Dim a As New WriterClass
    Private Sub MW3Tool_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        a.Process_Handle("iw5sp")

        If FOV.Checked = True Then
            a.WriteFloat(a.ReadInteger(&H99AD98) + &HC, (FOV1.Value))
            FOV1Label.Text = FOV1.Value
        Else
            a.WriteFloat(a.ReadInteger(&H99AD98) + &HC, (65))
        End If

        If FPS.Checked = True Then
            a.WriteFloat(a.ReadInteger(&H1C58160) + &HC, (FPS1.Value))
            FPS1Label.Text = FPS1.Value
        End If

    End Sub

End Class
