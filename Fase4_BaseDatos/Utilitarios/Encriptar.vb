Public Class Encriptar
    ' Esta implementación se realizó utilizando la siguiente documentación
    ' https://docs.microsoft.com/es-es/dotnet/visual-basic/programming-guide/language-features/strings/walkthrough-encrypting-and-decrypting-strings

    Public Shared Function Encriptar(ByVal Text As String) As String
        Dim wrapper As New Simple3Des("unad") 'Se registra un identificador
        Dim cipherText As String = wrapper.EncryptData(Text)
        Return cipherText
    End Function

End Class
