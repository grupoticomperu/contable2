Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades
Public Class nMonedas
    Inherits Conexion
    Dim obj As New dMonedas

    Public Function nTipoDeCambioPorMoneda(idMoneda As Integer) As DataTable
        Return obj.tipoDeCambioPorMoneda(idMoneda)
    End Function
End Class
