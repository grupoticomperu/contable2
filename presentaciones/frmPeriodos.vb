Imports Negocios
Public Class frmPeriodos
    Dim nobj As New nCrud
    Dim tipo As String = ""
    Dim tituloform As String = "Periodos"

    Private Function codigoCeldaSeleccionada() As Integer
        Dim c As Integer
        Try
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            c = CInt(dgvLista.Rows(f).Cells("id_periodo").Value.ToString)
        Catch ex As Exception
            c = 0
        End Try
        Return c
    End Function


    Private Sub frmPeriodos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarPeriodos()
        cargarDatosdePeriodos()
        desactivarbotonesgc()
        activarbotonesnmes()
        desactivarcajas()
    End Sub
    Private Sub desactivarcajas()
        gbPeriodos.Enabled = False
    End Sub

    Private Sub desactivarbotonesgc()
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
    End Sub
    Private Sub activarbotonesnmes()
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnSalir.Enabled = True
    End Sub

    Private Sub listarPeriodos()
        Dim data As New DataTable
        data = nobj.nCrudListar("select * from periodos order by id_periodo asc")
        'data = nobj.nCrudListar("select * from usuarios order by login_usuarios asc")

        dgvLista.DataSource = data
        data = Nothing
        ' cargaInicialEstados()
    End Sub

    Private Sub cargarDatosdePeriodos()
        '  If tipo <> "new" Or tipo = "" Then
        Me.Enabled = False
        On Error Resume Next
        Dim sql As String
        sql = "select * from periodos where id_periodo=" & codigoCeldaSeleccionada()
        Dim data As New DataTable
        data = nobj.nCrudListar(sql)
        txtPeriodo.Text = data.Rows(0)("id_periodo").ToString.Trim
        txtDescripcion.Text = data.Rows(0)("desc_periodo").ToString.Trim

        data = Nothing 'libera de memoria o limpiar el datatable
        Me.Enabled = True


        ' ElseIf tipo = "new" Then
        ' txtPeriodo.Focus()
        'End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        desactivargrid()
        limpiarcajas()
        activarcajas()
        tipo = "nuevo"
        desactivarbotonesnmes()
        activarbotonesgc()
        txtPeriodo.Focus()
    End Sub

    Private Sub desactivargrid()
        dgvLista.Enabled = False
    End Sub
    Private Sub limpiarcajas()
        txtPeriodo.Text = ""
        txtDescripcion.Text = ""
    End Sub
    Private Sub activarcajas()
        gbPeriodos.Enabled = True
    End Sub
    Private Sub desactivarbotonesnmes()
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnSalir.Enabled = False
    End Sub

    Private Sub activarbotonesgc()
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtPeriodo.Text.ToString = "" Then
            MessageBox.Show("Ingresar el Periodo", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        'verificamos existencia del banco
        Dim existeperiodo As New DataTable

        'existeperiodo = nobj.nCrudListar("select * from periodos where id_periodo='" & txtPeriodo.Text.ToString & "'")
        'If existeperiodo.Rows.Count > 0 Then
        'MsgBox("El periodo ya existe")
        ' Exit Sub
        'End If

        Dim campos As String
        Dim valores As String
        Dim valores0, valores1, valores2, valores3, valores4, valores5, valores6, valores7, valores8, valores9 As String
        Dim valores10, valores11, valores12, valores13 As String
        Dim condicion As String
        'Dim estado As String
        Dim rpta As String = ""
        Dim tabla As String = "periodos"


        If tipo = "modificar" Then

            existeperiodo = nobj.nCrudListar("select * from periodos where desc_periodo='" & txtDescripcion.Text.ToString & "'")
            If existeperiodo.Rows.Count > 0 Then
                MsgBox("El periodo ya existe")
                Exit Sub
            End If


            campos = "desc_periodo"
            valores = txtDescripcion.Text.ToString
            condicion = "id_periodo=" & codigoCeldaSeleccionada()
            rpta = nobj.nCrudActualizar("╚", tabla, campos, valores, condicion)

        ElseIf tipo = "nuevo" Then


            existeperiodo = nobj.nCrudListar("select * from periodos where id_periodo='" & txtPeriodo.Text.ToString & "'")
            If existeperiodo.Rows.Count > 0 Then
                MsgBox("El periodo ya existe")
                Exit Sub
            End If


            campos = "id_periodo╚desc_periodo"
            valores = txtPeriodo.Text.ToString & "╚" & txtDescripcion.Text.ToString
            rpta = nobj.nCrudInsertar("╚", tabla, campos, valores)
            'luego debemos insertar los meses
            valores0 = txtPeriodo.Text.ToString & "╚" & "0" & "╚" & "apertura"
            rpta = nobj.nCrudInsertar("╚", "meses_periodos", "id_periodo╚id_mes╚nom_mes", valores0)

            valores1 = txtPeriodo.Text.ToString & "╚" & "1" & "╚" & "enero"
            rpta = nobj.nCrudInsertar("╚", "meses_periodos", "id_periodo╚id_mes╚nom_mes", valores1)

            valores2 = txtPeriodo.Text.ToString & "╚" & "2" & "╚" & "febrero"
            rpta = nobj.nCrudInsertar("╚", "meses_periodos", "id_periodo╚id_mes╚nom_mes", valores2)

            valores3 = txtPeriodo.Text.ToString & "╚" & "3" & "╚" & "marzo"
            rpta = nobj.nCrudInsertar("╚", "meses_periodos", "id_periodo╚id_mes╚nom_mes", valores3)

            valores4 = txtPeriodo.Text.ToString & "╚" & "4" & "╚" & "abril"
            rpta = nobj.nCrudInsertar("╚", "meses_periodos", "id_periodo╚id_mes╚nom_mes", valores4)

            valores5 = txtPeriodo.Text.ToString & "╚" & "5" & "╚" & "mayo"
            rpta = nobj.nCrudInsertar("╚", "meses_periodos", "id_periodo╚id_mes╚nom_mes", valores5)

            valores6 = txtPeriodo.Text.ToString & "╚" & "6" & "╚" & "junio"
            rpta = nobj.nCrudInsertar("╚", "meses_periodos", "id_periodo╚id_mes╚nom_mes", valores6)

            valores7 = txtPeriodo.Text.ToString & "╚" & "7" & "╚" & "julio"
            rpta = nobj.nCrudInsertar("╚", "meses_periodos", "id_periodo╚id_mes╚nom_mes", valores7)

            valores8 = txtPeriodo.Text.ToString & "╚" & "8" & "╚" & "agosto"
            rpta = nobj.nCrudInsertar("╚", "meses_periodos", "id_periodo╚id_mes╚nom_mes", valores8)

            valores9 = txtPeriodo.Text.ToString & "╚" & "9" & "╚" & "setiembre"
            rpta = nobj.nCrudInsertar("╚", "meses_periodos", "id_periodo╚id_mes╚nom_mes", valores9)

            valores10 = txtPeriodo.Text.ToString & "╚" & "10" & "╚" & "octubre"
            rpta = nobj.nCrudInsertar("╚", "meses_periodos", "id_periodo╚id_mes╚nom_mes", valores10)

            valores11 = txtPeriodo.Text.ToString & "╚" & "11" & "╚" & "noviembre"
            rpta = nobj.nCrudInsertar("╚", "meses_periodos", "id_periodo╚id_mes╚nom_mes", valores11)

            valores12 = txtPeriodo.Text.ToString & "╚" & "12" & "╚" & "diciembre"
            rpta = nobj.nCrudInsertar("╚", "meses_periodos", "id_periodo╚id_mes╚nom_mes", valores12)

            valores13 = txtPeriodo.Text.ToString & "╚" & "13" & "╚" & "cierre"
            rpta = nobj.nCrudInsertar("╚", "meses_periodos", "id_periodo╚id_mes╚nom_mes", valores13)

        End If

        If rpta = "ok" Then
            MessageBox.Show("El Periodo Fue Grabado con éxito", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            desactivarbotonesgc()
            activarbotonesnmes()

            desactivarcajas()
            activargrid()

            txtPeriodo.Focus()
            listarPeriodos()
            cargarDatosdePeriodos()

        End If
    End Sub
    Private Sub activargrid()
        dgvLista.Enabled = True
    End Sub

    Private Sub dgvLista_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLista.CellClick
        cargarDatosdePeriodos()
    End Sub

    Private Sub dgvLista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLista.CellContentClick
        cargarDatosdePeriodos()
    End Sub

    Private Sub dgvLista_ChangeUICues(sender As Object, e As UICuesEventArgs) Handles dgvLista.ChangeUICues
        cargarDatosdePeriodos()
    End Sub

    Private Sub dgvLista_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvLista.KeyDown
        cargarDatosdePeriodos()
    End Sub

    Private Sub dgvLista_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgvLista.KeyPress
        cargarDatosdePeriodos()
    End Sub

    Private Sub dgvLista_KeyUp(sender As Object, e As KeyEventArgs) Handles dgvLista.KeyUp
        cargarDatosdePeriodos()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        tipo = "modificar"
        'desactivargrid()
        activarcajas()
        desactivarbotonesnmes()
        activarbotonesgc()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        desactivarbotonesgc()
        activarbotonesnmes()
        desactivarcajas()
        activargrid()
        ' listarUsuarios()
        txtPeriodo.Focus()
        listarPeriodos()
        cargarDatosdePeriodos()
    End Sub
End Class