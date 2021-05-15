Public Class tema2vb
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter
        AxWindowsMediaPlayer1.URL = "imagenes/tema 2 interaccion humano com.mp4"
    End Sub
End Class