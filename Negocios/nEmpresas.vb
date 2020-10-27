
Imports Datos

Public Class nEmpresas
    Inherits Conexion

    Dim dobj As New dEmpresas
    Dim objCrud As New dCrud

    Public Function nListaEmpresasActivasPorUsuario(idUsuario As Integer) As DataTable
        Return dobj.dlistaEmpresasActivasPorUsuario(idUsuario)
    End Function
    Public Function nListaPeriodosdeEmpresas(idEmpresa As Integer) As DataTable
        Return dobj.dListaPeriodosdeEmpresas(idEmpresa)
    End Function
    Public Function nCopiarPlanContable(cod_empresa, cod_empresaorigen) As String
        Return dobj.dCopiarPlanContable(cod_empresa, cod_empresaorigen)
    End Function
End Class
