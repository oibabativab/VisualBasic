Public Class TransaccionBD
    Public Sub New()
        _resultado = True
        _errores = New List(Of String)
    End Sub

    Public Sub New(resultado As Boolean)
        _resultado = resultado
        _errores = New List(Of String)
    End Sub

    Public Sub New(resultado As Boolean, errores As List(Of String))
        _resultado = resultado
        _errores = errores
    End Sub

    Private _resultado As Boolean
    Public Property Resultado() As Boolean
        Get
            Return _resultado
        End Get
        Set(ByVal value As Boolean)
            _resultado = value
        End Set
    End Property

    Private _errores As List(Of String)

    Public Property Errores() As List(Of String)
        Get
            Return _errores
        End Get
        Set(ByVal value As List(Of String))
            _errores = value
        End Set
    End Property
End Class
