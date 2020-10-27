Imports Negocios

Public Class frmEmpresasPeriodos
    Dim nobj As New nCrud
    Dim tipo As String = ""
    Dim tituloform As String = "Empresas Periodos"

    Private Function codigoCeldaSeleccionada() As Integer
        Dim c As String
        Try
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            c = dgvLista.Rows(f).Cells("id_empresa").Value.ToString
        Catch ex As Exception
            c = 0
        End Try
        Return c
    End Function
    Private Sub listarEmpresas()
        Dim data As New DataTable
        data = nobj.nCrudListar("select * from vista_listaempresas order by nom_comercial asc")
        'data = nobj.nCrudListar("select * from empresas where estado_empresa = '1' order by nom_comercial asc")

        'data = nobj.nCrudListar("select * from usuarios order by login_usuarios asc")

        dgvLista.DataSource = data
        data = Nothing
        ' cargaInicialEstados()
    End Sub
    Private Sub empresas_periodos()
        Dim data As New DataTable
   
        data = nobj.nCrudListar("select * from vista_empresasperiodos where id_empresa = " & CInt(codigoCeldaSeleccionada()) & " order by id_periodo asc")
        dgvPeriodos.DataSource = data
        ' data = Nothing
    End Sub
    Private Sub frmEmpresasPeriodos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarEmpresas()
        listadeperiodos()
        empresas_periodos()
        listadeempresas()
    End Sub
    Private Sub listadeempresas()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = nobj.nCrudListar("select id_empresa, razon_social from empresas where estado_empresa=1 order by razon_social asc")
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboEmpresas
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Bancos")
        End Try
    End Sub

    Private Sub listadeperiodos()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = nobj.nCrudListar("select id_periodo, desc_periodo from periodos order by id_periodo asc")
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboPeriodos
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Bancos")
        End Try
    End Sub

    Private Sub dgvLista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLista.CellContentClick

    End Sub
    Private Sub dgvLista_SelectionChanged(sender As Object, e As EventArgs) Handles dgvLista.SelectionChanged
        empresas_periodos()
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim campos As String
        Dim valores As String
        'Dim condicion As String
        Dim rpta As String = ""
        Dim tabla As String = "empresas_periodos"

        Dim empresa, periodo As Integer
        Dim desc, estado As String     
        empresa = CInt(cboEmpresas.SelectedValue.ToString)
        periodo = CInt(cboPeriodos.SelectedValue.ToString)
        desc = txtDescripcion.Text.ToString
        If chkEstado.Checked Then
            estado = 1
        Else
            estado = 0
        End If

        If empresa = 0 Or periodo = 0 Then
            MessageBox.Show("Por favor esgoger la empresa y el periodo", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            Dim existeEmpresaPeriodo As New DataTable
            existeEmpresaPeriodo = nobj.nCrudListar("select * from empresas_periodos where id_empresa='" & empresa & "' and id_periodo= '" & periodo & "'")
            If existeEmpresaPeriodo.Rows.Count > 0 Then
                MsgBox("La empresa y periodo ya existe")
                Exit Sub
            Else

                campos = "id_empresa@id_periodo@des_empresa_periodo@estado"
                valores = empresa & "@" & periodo & "@" & desc & "@" & estado
                rpta = nobj.nCrudInsertar("@", tabla, campos, valores)

                If rpta = "ok" Then
                    MessageBox.Show("El proceso se ha realizado con éxito.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Else
                    MessageBox.Show(rpta, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If

            End If
        End If
      
       
        
       
    End Sub
End Class