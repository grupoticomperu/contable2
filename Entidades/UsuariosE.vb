Public Class UsuariosE
    Private _id_usuario As Integer
    Private _cod_usuario As String
    Private _usuarios As String
    Private _nom_ap_usuarios As String
    Private _clave_usuarios As String
    Private _tipo_usuario As String
    Private _estado_usuario As String
    Private _c1_usuario As String
    Private _c2_usuario As String
    Private _c3_usuario As String

    Public Property id_usuario() As Integer
        Get
            Return _id_usuario
        End Get
        Set(value As Integer)
            _id_usuario = value
        End Set
    End Property

    Public Property cod_usuario As String
        Get
            Return _cod_usuario
        End Get
        Set(value As String)
            _cod_usuario = value
        End Set
    End Property

    Public Property usuarios As String
        Get
            Return _usuarios
        End Get
        Set(value As String)
            _usuarios = value
        End Set
    End Property

    Public Property nom_ap_usuarios As String
        Get
            Return _nom_ap_usuarios
        End Get
        Set(value As String)
            _nom_ap_usuarios = value
        End Set
    End Property

    Public Property clave_usuarios As String
        Get
            Return _clave_usuarios
        End Get
        Set(value As String)
            _clave_usuarios = value
        End Set
    End Property

    Public Property tipo_usuario As String
        Get
            Return _tipo_usuario
        End Get
        Set(value As String)
            _tipo_usuario = value
        End Set
    End Property

    Public Property estado_usuario As String
        Get
            Return _estado_usuario
        End Get
        Set(value As String)
            _estado_usuario = value
        End Set
    End Property

    Public Property c1_usuario As String
        Get
            Return _c1_usuario
        End Get
        Set(value As String)
            _c1_usuario = value
        End Set
    End Property
    Public Property c2_usuario As String
        Get
            Return _c2_usuario
        End Get
        Set(value As String)
            _c2_usuario = value
        End Set
    End Property

    Public Property c3_usuario As String
        Get
            Return _c3_usuario
        End Get
        Set(value As String)
            _c3_usuario = value
        End Set
    End Property
End Class

