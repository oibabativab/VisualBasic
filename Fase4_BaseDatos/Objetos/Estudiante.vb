Public Class Estudiante
    Private _Identificacion As String
    Public Property Identificacion() As String
        Get
            Return _Identificacion
        End Get
        Set(ByVal value As String)
            _Identificacion = value
        End Set
    End Property

    Private _Nombre As String
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
    Private _Apellido As String
    Public Property Apellido() As String
        Get
            Return _Apellido
        End Get
        Set(ByVal value As String)
            _Apellido = value
        End Set
    End Property

    Private _Correo As String
    Public Property Correo() As String
        Get
            Return _Correo
        End Get
        Set(ByVal value As String)
            _Correo = value
        End Set
    End Property

    Private _Telefono As String
    Public Property Telefono() As String
        Get
            Return _Telefono
        End Get
        Set(ByVal value As String)
            _Telefono = value
        End Set
    End Property

    Private _Escuela As Integer
    Public Property Escuela() As Integer
        Get
            Return _Escuela
        End Get
        Set(ByVal value As Integer)
            _Escuela = value
        End Set
    End Property

    Private _Contrasena As String
    Public Property Contrasena() As String
        Get
            Return _Contrasena
        End Get
        Set(ByVal value As String)
            _Contrasena = value
        End Set
    End Property

End Class
