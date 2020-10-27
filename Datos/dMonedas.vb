Imports System.Data
Imports System.Data.SqlClient
Imports Entidades
Public Class dMonedas
    Inherits Conexion

    Public Function tipoDeCambioPorMoneda(idMoneda As Integer) As DataTable
        If cn.State = ConnectionState.Closed Then conectar()
        Dim dt As New DataTable("datos")
        Try
            da = New SqlDataAdapter("usp_tipoDeCambioPorMoneda", cn)
            With da.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idMoneda", SqlDbType.Int).Value = idMoneda
            End With
            da.Fill(dt)
        Catch ex As Exception
            Return New DataTable("datos")
        Finally
            desconectar()
        End Try
        Return dt
    End Function
End Class
