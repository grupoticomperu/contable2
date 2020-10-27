Imports System.Data
Imports System.Data.SqlClient
Imports Entidades
Public Class dPeriodos
    Inherits Conexion


    'Public Function dListaPeriodosdeEmpresas(user As UsuariosE) As DataTable
    '    If cn.State = ConnectionState.Closed Then conectar()
    '    Dim dt As New DataTable("datos")
    '    Try
    '        da = New SqlDataAdapter("usp_verificarsesionuser", cn)
    '        With da.SelectCommand
    '            .CommandType = CommandType.StoredProcedure
    '            .Parameters.Add("@usuario", SqlDbType.VarChar).Value = user.usuarios
    '            .Parameters.Add("@clave", SqlDbType.VarChar).Value = user.clave_usuarios
    '        End With
    '        da.Fill(dt)
    '    Catch ex As Exception
    '        Return New DataTable("datos")
    '    Finally
    '        desconectar()
    '    End Try
    '    Return dt
    'End Function
End Class
