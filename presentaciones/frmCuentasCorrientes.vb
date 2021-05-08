Imports Negocios
Imports System.IO
Public Class frmCuentasCorrientes
    Dim nobj As New nCrud
    Dim campos As String
    Dim valores As String
    Dim tabla As String = "cuentacorrientes"
    Dim rpta As String = ""

    Private Sub frmCuentasCorrientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarlistacuentascorrientes()
        cargarBancos()

    End Sub

    Private Sub cargarlistacuentascorrientes()
        dgvLista.Refresh()
        dgvLista.DataSource = nobj.nCrudListar("select * from vista_cuentascorrientes order by id asc")
    End Sub

    Private Sub cargarBancos()
        Dim tbData As New DataTable
        tbData.Columns.Add("Codigo")
        tbData.Columns.Add("Banco")
        tbData.Rows.Add(0, "Seleccione")
        Dim tbData2 As DataTable
        Try
            tbData2 = nobj.nCrudListar("select id_banco, nom_banco from bancos order by nom_banco asc")
            For Each row As DataRow In tbData2.Rows
                tbData.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboBancos
                .DataSource = tbData
                .ValueMember = "Codigo"
                .DisplayMember = "Banco"
            End With
            tbData2.Dispose()
        Catch ex As Exception
            MsgBox("Error en la carga de Bancos")
            Exit Sub
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBancos.SelectedIndexChanged

    End Sub
End Class