Imports System.Data
Imports System.Data.SqlClient
Imports Entidades
Public Class dUsuarios
    Inherits Conexion

    Public Function dUsuarioIniciarSesion(user As UsuariosE) As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_verificarsesionuser", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@usuario", SqlDbType.VarChar).Value = user.usuarios
                .Parameters.Add("@clave", SqlDbType.VarChar).Value = user.clave_usuarios
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectar()
        End Try
        Return dt
    End Function

    Public Function dUsuarioEmpresa(CodigoUsuarioSession As String) As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_verificarempresauser", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@usuario", SqlDbType.VarChar).Value = CodigoUsuarioSession
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectar()
        End Try
        Return dt
    End Function


    'Public Function dRepeticionUsuarios() As Integer
    '    If cn.State = ConnectionState.Closed Then conectar()
    '    Dim dt As New DataTable("datos")

    'End Function
End Class
