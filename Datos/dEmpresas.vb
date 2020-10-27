Imports System.Data
Imports System.Data.SqlClient
Imports Entidades
Public Class dEmpresas
    Inherits Conexion
    Public Function dlistaEmpresasActivasPorUsuario(idUsuario As Integer) As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_listaEmpresasActivasPorUsuario", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectar()
        End Try
        Return dt
    End Function

    Public Function dListaPeriodosdeEmpresas(idEmpresa As Integer) As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_listaPeriodosdeEmpresas", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idEmpresa", SqlDbType.Int).Value = idEmpresa
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectar()
        End Try
        Return dt
    End Function
    Public Function dCopiarPlanContable(cod_empresa, cod_empresaorigen) As String
        If cn.State = ConnectionState.Closed Then conectar()
        Dim mitrans As SqlTransaction = cn.BeginTransaction
        cmd = New SqlCommand
        Try
            With cmd
                .Connection = cn
                .Transaction = mitrans
                .CommandType = CommandType.StoredProcedure
                .CommandText = "usp_crearcuentacontablemasiva"
                .Parameters.Add("@idempresa", SqlDbType.VarChar).Value = cod_empresa
                .Parameters.Add("@idempresax", SqlDbType.VarChar).Value = cod_empresaorigen
                .ExecuteNonQuery()
            End With
            mitrans.Commit()
            Return "ok"
        Catch ex As Exception
            mitrans.Rollback()
            Return "2"
        Finally
            desconectar()
        End Try
    End Function
End Class
