Public Class Tema5Video

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim html As String = "<html><head>"
        html &= "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>"
        html &= "<iframe id='video' src= 'https://www.youtube.com/embed/KET4Rp5RXGI' width='460' height='215' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>"
        html &= "</body></html>"
        If Me.WebBrowser1 IsNot Nothing Then
            Me.WebBrowser1.DocumentText = html
        End If
        Timer1.Enabled = False
    End Sub
End Class
