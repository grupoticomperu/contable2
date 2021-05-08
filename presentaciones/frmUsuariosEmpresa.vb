Imports Negocios
Imports System.IO
Public Class frmUsuariosEmpresa
    Dim nobj As New nCrud
    Dim campos As String
    Dim valores As String
    Dim tabla As String = "usuarios_empresas"
    Dim rpta As String = ""

    Private Sub frmUsuariosEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarlistaempresausuarios()
        cargarEmpresas()
        cargarUsuarios()
    End Sub

    Private Sub cargarlistaempresausuarios()
        ' MsgBox(plancontable)
        dgvLista.Refresh()

        'dgvLista.DataSource = nobj.nCrudListar("select * from usuarios_empresas order by razon_social asc")
        dgvLista.DataSource = nobj.nCrudListar("select * from vista_usuariosempresa order by razon_social asc")

        'lista = obj.nCrudListar("select * from vista_CuentaContableGrilla where id_empresa='" & EmpresaSeleccionada & "' and nom_nivelctacontable<>'BALANCE' order by id_ctacontable asc")
    End Sub

    Private Sub cargarEmpresas()
        Dim tbData As New DataTable
        tbData.Columns.Add("Codigo")
        tbData.Columns.Add("Nombre")
        tbData.Rows.Add(0, "Seleccione")
        Dim tbData2 As DataTable
        Try
            tbData2 = nobj.nCrudListar("select id_empresa,razon_social from empresas order by razon_social asc")
            For Each row As DataRow In tbData2.Rows
                tbData.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboEmpresas
                .DataSource = tbData
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With
            tbData2.Dispose()
        Catch ex As Exception
            MsgBox("Error en la carga de Empresas")
            Exit Sub
        End Try
    End Sub

    Private Sub cargarUsuarios()
        Dim tbData As New DataTable
        tbData.Columns.Add("Codigo")
        tbData.Columns.Add("Nombre")
        tbData.Rows.Add(0, "Seleccione")
        Dim tbData2 As DataTable
        Try
            tbData2 = nobj.nCrudListar("select id_usuario,nom_ap_usuarios from usuarios order by nom_ap_usuarios asc")
            For Each row As DataRow In tbData2.Rows
                tbData.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboUsuarios
                .DataSource = tbData
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With
            tbData2.Dispose()
        Catch ex As Exception
            MsgBox("Error en la carga de Usuarios")
            Exit Sub
        End Try
    End Sub

    
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        campos = "id_empresa@id_usuario"
        valores = cboEmpresas.SelectedValue.ToString & "@" & cboUsuarios.SelectedValue.ToString
        rpta = nobj.nCrudInsertar("@", tabla, campos, valores)

        Dim existeUsuario As New DataTable

        existeUsuario = nobj.nCrudListar("select * from usuarios_empresas where id_usuario='" & cboEmpresas.SelectedValue.ToString & "' and id_empresa= '" & cboUsuarios.SelectedValue.ToString & "'")
        If existeUsuario.Rows.Count > 0 Then
            MsgBox("El usuario ya esta asignado a la empresa")
            Exit Sub
        ElseIf rpta = "ok" Then
            MessageBox.Show("El proceso se ha realizado con éxito okidoki.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            cargarlistaempresausuarios()

        Else
            MessageBox.Show("El proceso no se ha realizado.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If


    End Sub

    Private Sub dgvLista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLista.CellContentClick

    End Sub

    Private Sub cboUsuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUsuarios.SelectedIndexChanged

    End Sub

    Private Sub gbCtasContables_Paint(sender As Object, e As PaintEventArgs) Handles gbCtasContables.Paint

    End Sub
End Class