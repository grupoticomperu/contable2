Imports System.Data
Imports System.Data.SqlClient
Imports Datos
Imports Entidades
Public Class nCrud
    Dim dobj As New dCrud

    Public Function nCrudListar(query As String) As DataTable
        Return dobj.dEjecutarQueryLista(query)
    End Function
    Public Function nCrudInsertar(delimitador As String, tabla As String, aCampos As String, aValores As String) As String
        Dim campos, valores As String()
        campos = Split(aCampos, delimitador)
        valores = Split(aValores, delimitador)

        Dim sql As String
        sql = "insert " & tabla & " ("
        For i As Integer = 0 To campos.Count
            If i < (campos.Count - 1) Then
                sql += campos(i) & ","
            End If
            If i = (campos.Count - 1) Then
                sql += campos(i) & ") values ("
            End If
        Next
        For j As Integer = 0 To valores.Count
            If j < (valores.Count - 1) Then
                sql += "'" & valores(j) & "',"
            End If
            If j = (valores.Count - 1) Then
                sql += "'" & valores(j) & "');"
            End If
        Next
        Return dobj.dEjecutarQuery(sql)
    End Function

    Public Function nCrudActualizar(delimitador As String, tabla As String, aCampos As String, aValores As String, condicion As String) As String
        Dim campos, valores As String()
        campos = Split(aCampos, delimitador)
        valores = Split(aValores, delimitador)
        Dim sql As String

        sql = "update " & tabla & " set "
        For i As Integer = 0 To campos.Count
            If i < (campos.Count - 1) Then
                sql += campos(i) & "='" & valores(i) & "', "
            End If
            If i = (campos.Count - 1) Then
                sql += campos(i) & "='" & valores(i) & "' where "
            End If
        Next
        sql += condicion & ";"
        Return dobj.dEjecutarQuery(sql)
    End Function



End Class
