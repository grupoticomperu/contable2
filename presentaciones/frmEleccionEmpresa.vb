Imports Negocios
Public Class frmEleccionEmpresa
    Dim nobj As New nEmpresas
    Dim objCrud As New nCrud
    Dim iCarga As Integer = 0
    Private Sub cargar_empresas()
        Dim data As New DataTable
        data = nobj.nListaEmpresasActivasPorUsuario(CodigoUsuarioSession)
        'data = nobj.nListaEmpresasActivasPorUsuario(CodigoUsuarioSession)
        dgvEmpresas.DataSource = data
    End Sub
    Private Function codigoCeldaGrid() As Integer
        Dim c As String

        Try
            Dim f As Integer
            f = dgvEmpresas.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            c = dgvEmpresas.Rows(f).Cells("id_empresa").Value.ToString
            'plancontable = dgvEmpresas.Rows(f).Cells("id_plancontable").Value.ToString
            EmpresaSeleccionada = dgvEmpresas.Rows(f).Cells("id_empresa").Value.ToString
            NombreEmpresaSeleccionada = dgvEmpresas.Rows(f).Cells("razon_social").Value.ToString
        Catch ex As Exception
            c = 0
        End Try
        Return c
        ' EmpresaSeleccionada = c
        'MsgBox(EmpresaSeleccionada)
    End Function
    'Private Sub guardarplancontable()
    '    ' Dim plan
    '    Try
    '        Dim f As Integer
    '        f = dgvEmpresas.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
    '        plancontable = dgvEmpresas.Rows(f).Cells("id_plancontable").Value.ToString
    '        'plancontable = dgvEmpresas.Rows(f).Cells("id_plancontable").Value.ToString
    '        EmpresaSeleccionada = dgvEmpresas.Rows(f).Cells("id_empresa").Value.ToString
    '        NombreEmpresaSeleccionada = dgvEmpresas.Rows(f).Cells("razon_social").Value.ToString
    '    Catch ex As Exception
    '        MsgBox("No se pudo guardar el plan contable")
    '    End Try

    'End Sub
    Private Sub cargarPeriodos()
        Dim data2 As New DataTable
        data2 = nobj.nListaPeriodosdeEmpresas(codigoCeldaGrid())
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")

        Try
            If data2.Rows.Count >= 0 Then
                For Each row As DataRow In data2.Rows
                    data.Rows.Add(row.Item(0).ToString, row.Item(0).ToString)
                Next
            End If
            With cboPeriodo
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
                '.SelectedItem = 1
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar los periodos")
        End Try
    End Sub

    Private Sub frmEleccionEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_empresas()
        ' guardarplancontable()
        cargarPeriodos()
    End Sub

    Private Sub dgvEmpresas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpresas.CellContentClick

    End Sub

    Private Sub dgvEmpresas_SelectionChanged(sender As Object, e As EventArgs) Handles dgvEmpresas.SelectionChanged
        'codigoCeldaGrid()
        'guardarplancontable()
        cargarPeriodos()

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        'Try
        '    Dim f As Integer
        '    f = dgvEmpresas.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        '    plancontable = dgvEmpresas.Rows(f).Cells("id_plancontable").Value.ToString
        '    'MsgBox(plancontable)
        '    'plancontable = dgvEmpresas.Rows(f).Cells("id_plancontable").Value.ToString
        '    EmpresaSeleccionada = dgvEmpresas.Rows(f).Cells("id_empresa").Value.ToString
        '    'MsgBox(EmpresaSeleccionada)
        '    NombreEmpresaSeleccionada = dgvEmpresas.Rows(f).Cells("razon_social").Value.ToString
        '    'MsgBox(NombreEmpresaSeleccionada)
        'Catch ex As Exception
        '    MsgBox("No se pudo guardar el plan contable")
        'End Try
        PeriodoElegido = cboPeriodo.SelectedValue
        'EmpresaSeleccionada = 1
        'EmpresaSeleccionada = codigoCeldaGrid()

        ' plancontable = 1
        ' LoginForm1.Dispose()
        Me.Dispose()
        MDIPrincipal.Show()
    End Sub

    Private Sub cboPeriodo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPeriodo.SelectedIndexChanged

    End Sub
End Class