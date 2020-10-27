Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades
Public Class nUsuarios
    Dim dobj As New dUsuarios
    Public Function nUsuarioIniciarSesion(user As UsuariosE) As DataTable
        Return dobj.dUsuarioIniciarSesion(user)
    End Function
    'Public Function nRepeticionUsuarios() As Integer
    '    Return dobj.dRepeticionUsuarios()
    'End Function

    Public Function nUsuarioEmpresa(CodigoUsuarioSession As String) As DataTable
        Return dobj.dUsuarioEmpresa(CodigoUsuarioSession)
    End Function


End Class
