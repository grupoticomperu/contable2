Imports Negocios

Public Class frmEmpresas
    Dim nobj As New nCrud
    Dim nobj2 As New nEmpresas
    Dim tipo As String = ""
    Dim tituloform As String = "Empresas"

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
        cargaInicialEstados()
    End Sub
    Private Sub cargaInicialEstados()
        Try
            For Each row As DataGridViewRow In dgvLista.Rows
                If row.Cells("estado_empresa").Value.ToString = "0" Then
                    row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(255, 87, 87) '(245, 230, 108)
                ElseIf row.Cells("estado_empresa").Value.ToString = "1" Then
                    row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(255, 255, 255)
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub
    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub
    Private Sub cargarPeriodos()
        Dim tbData As New DataTable
        tbData.Columns.Add("Codigo")
        tbData.Columns.Add("Nombre")
        tbData.Rows.Add(0, "Seleccione")
        Dim tbData2 As DataTable
        Try
            tbData2 = nobj.nCrudListar("select id_periodo,desc_periodo from periodos order by id_periodo asc")
            For Each row As DataRow In tbData2.Rows
                tbData.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboPeriodo
                .DataSource = tbData
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With
            tbData2.Dispose()
            tbData = Nothing
            tbData2 = Nothing
        Catch ex As Exception
            MsgBox("Error en la carga de Periodos")
            Exit Sub
        End Try
    End Sub
    Private Sub cargarEmpresas()
        Dim tbData As New DataTable
        tbData.Columns.Add("Codigo")
        tbData.Columns.Add("Nombre")
        tbData.Rows.Add(0, "Seleccione")
        Dim tbData2 As DataTable
        Try
            tbData2 = nobj.nCrudListar("select id_empresa,nom_comercial from empresas order by nom_comercial asc")
            For Each row As DataRow In tbData2.Rows
                tbData.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboPlancontable
                .DataSource = tbData
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With
            tbData2.Dispose()
            tbData = Nothing
            tbData2 = Nothing
        Catch ex As Exception
            MsgBox("Error en la carga de Empresas")
            Exit Sub
        End Try
    End Sub





    Private Sub cargarMeses()
        Dim tbData As New DataTable
        tbData.Columns.Add("Codigo")
        tbData.Columns.Add("Nombre")
        tbData.Rows.Add(0, "Seleccione")
        Dim tbData2 As DataTable
        Try
            tbData2 = nobj.nCrudListar("select id_mes,nom_mes from meses order by id_mes asc")
            For Each row As DataRow In tbData2.Rows
                tbData.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboMes
                .DataSource = tbData
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With
            tbData2.Dispose()
        Catch ex As Exception
            MsgBox("Error en la carga de Meses")
            Exit Sub
        End Try
    End Sub


    Private Sub frmEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'desactivarbotonesgc()
        'activarbotonesnmes()
        'desactivarcajas()
        desactivarbotonesgc()
        activarbotonesnmes()
        desactivarcajas()
        activargrid()

        listarEmpresas()
        cargardatosempresas()
        cargarEmpresas()
        desactivarperiodomes()
        desactivarplancontable()
        'cboPlancontable.Enabled = False
        rbt1.Checked = True
    End Sub

    Private Sub cargardatosempresas()
        If tipo = "modificar" Or tipo = "" Then
            Me.Enabled = False
            On Error Resume Next
            Dim sql As String
            sql = "select * from empresas where id_empresa=" & codigoCeldaSeleccionada()
            Dim data As New DataTable
            data = nobj.nCrudListar(sql)
            With data
                txtNomComercial.Text = .Rows(0)("nom_comercial")
                txtRazonSocial.Text = .Rows(0)("razon_social")
                txtRuc.Text = .Rows(0)("ruc")
                txtDireccion.Text = .Rows(0)("dir_empresa")
                txtUbigeo.Text = .Rows(0)("")
                txtUbigeo.Text = .Rows(0)("ubigeo")
                txtMoneda.Text = .Rows(0)("id_moneda")
                txtTelefono.Text = .Rows(0)("tel_empresa")
                txtEmail.Text = .Rows(0)("correo_empresa")
                txtCelular.Text = .Rows(0)("cel_empresa")
                If .Rows(0)("es_agente_retencion") = 1 Then
                    chbRetencion.Checked = True
                Else
                    chbRetencion.Checked = False
                End If
                If .Rows(0)("es_agente_percepcion") = 1 Then
                    chbPercepcion.Checked = True
                Else
                    chbPercepcion.Checked = False
                End If
                If .Rows(0)("estado_empresa") = 1 Then
                    chbEstado.Checked = True
                Else
                    chbEstado.Checked = False
                End If
            End With
            data = Nothing
            Me.Enabled = True
        ElseIf tipo = "nuevo" Then
            txtNomComercial.Focus()
        End If
        cargaInicialEstados()
    End Sub

    Private Sub txtLogin_usuario_TextChanged(sender As Object, e As EventArgs) Handles txtLogo.TextChanged

    End Sub

    Private Sub dgvLista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLista.CellContentClick

    End Sub

    Private Sub dgvLista_SelectionChanged(sender As Object, e As EventArgs) Handles dgvLista.SelectionChanged
        cargardatosempresas()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim campos As String
        Dim valores As String
        Dim condicion As String
        Dim estado As String
        Dim percepcion As String
        Dim retencion As String
        Dim rpta As String = ""
        Dim rpta2 As String = ""
        Dim rpta3 As String = ""
        Dim rpta4 As String = ""
        Dim tabla As String = "empresas"
        'desactivarbotonesgc()
        'activarbotonesnmes()
        'desactivarcajas()
        'txtNomComercial.Focus()
        'activargrid()
        'listarEmpresas()
        'cargardatosempresas()
        'desactivarperiodomes()
        'desactivarplancontable()
        'Try
        If tipo = "modificar" Then
            ' txtLogin_usuario.Enabled = False
            If txtNomComercial.ToString = "" Or txtRazonSocial.Text.ToString = "" Or txtRuc.Text.ToString = "" Or txtDireccion.Text.ToString = "" Or txtCelular.Text.ToString = "" Or _
   txtUbigeo.Text.ToString = "" Or txtMoneda.Text.ToString = "" Or txtTelefono.Text.ToString = "" Or txtEmail.Text.ToString = "" Then
                MessageBox.Show("Por favor ingresar los datos de la Empresa.", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                If chbPercepcion.Checked Then
                    percepcion = "1"
                Else
                    percepcion = "0"
                End If

                If chbRetencion.Checked Then
                    retencion = "1"
                Else
                    retencion = "0"
                End If

                If chbEstado.Checked Then
                    estado = "1"
                Else
                    estado = "0"
                End If

                campos = "nom_comercial╚razon_social╚ruc╚dir_empresa╚ubigeo╚id_moneda╚es_agente_retencion╚es_agente_percepcion╚tel_empresa╚correo_empresa╚logo_empresa╚cel_empresa╚estado_empresa"
                valores = txtNomComercial.Text.ToString & "╚" & txtRazonSocial.Text.ToString & "╚" & txtRuc.Text.ToString & "╚" & txtDireccion.Text.ToString & "╚" & txtUbigeo.Text.ToString & "╚" & _
                txtMoneda.Text.ToString & "╚" & retencion & "╚" & percepcion & "╚" & txtTelefono.Text.ToString & "╚" & txtEmail.Text.ToString & "╚" & txtLogo.Text.ToString & "╚" & txtCelular.Text.ToString & "╚" & estado

                condicion = "id_empresa=" & codigoCeldaSeleccionada()

                rpta = nobj.nCrudActualizar("╚", tabla, campos, valores, condicion)
            End If
        ElseIf tipo = "nuevo" Then
            If txtNomComercial.ToString = "" Or txtRazonSocial.Text.ToString = "" Or txtRuc.Text.ToString = "" Or txtDireccion.Text.ToString = "" Or txtCelular.Text.ToString = "" Or _
   txtUbigeo.Text.ToString = "" Or txtMoneda.Text.ToString = "" Or txtTelefono.Text.ToString = "" Or txtEmail.Text.ToString = "" Or cboPeriodo.DisplayMember = "Seleccione" Then
                MessageBox.Show("Por favor ingresar los datos para registrar la Empresa.", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                Dim existeruc As New DataTable
                existeruc = nobj.nCrudListar("select * from empresas where ruc='" & txtRuc.Text.Trim & "'")
                If existeruc.Rows.Count > 0 Then
                    MsgBox("El RUC de la empresa ya existe")
                    Exit Sub
                Else
                    If chbPercepcion.Checked = True Then
                        percepcion = "1"
                    Else
                        percepcion = "0"
                    End If

                    If chbRetencion.Checked = True Then
                        retencion = "1"
                    Else
                        retencion = "0"
                    End If

                    If chbEstado.Checked = True Then
                        estado = "1"
                    Else
                        estado = "0"
                    End If

                    campos = "nom_comercial╚razon_social╚ruc╚dir_empresa╚ubigeo╚id_moneda╚es_agente_retencion╚es_agente_percepcion╚tel_empresa╚correo_empresa╚logo_empresa╚cel_empresa╚estado_empresa"
                    valores = txtNomComercial.Text.ToString & "╚" & txtRazonSocial.Text.ToString & "╚" & txtRuc.Text.ToString & "╚" & txtDireccion.Text.ToString & "╚" & txtUbigeo.Text.ToString & "╚" & _
                    txtMoneda.Text.ToString & "╚" & retencion & "╚" & percepcion & "╚" & txtTelefono.Text.ToString & "╚" & txtEmail.Text.ToString & "╚" & txtLogo.Text.ToString & "╚" & txtCelular.Text.ToString & "╚" & estado
                    rpta = nobj.nCrudInsertar("╚", tabla, campos, valores)
                    'gravando empresa periodo
                    'obtenemos el codigo de la empresa grabada
                    Dim cod_empresa As String
                    Dim sql2 As String
                    sql2 = "SELECT TOP 1 id_empresa FROM empresas ORDER BY id_empresa DESC "
                    Dim data2 As New DataTable
                    data2 = nobj.nCrudListar(sql2)
                    cod_empresa = data2.Rows(0)("id_empresa")
                    'obtenemos el periodo
                    Dim periodo2 As String
                    periodo2 = cboPeriodo.SelectedValue
                    Dim campos2 As String
                    Dim valores2 As String
                    Dim estado2 As String = "1"
                    Dim tabla2 As String = "empresas_periodos"
                    campos2 = "id_empresa╚id_periodo╚estado"
                    valores2 = cod_empresa & "╚" & periodo2 & "╚" & estado2
                    rpta2 = nobj.nCrudInsertar("╚", tabla2, campos2, valores2)
                    'gravando empresa periodo mes
                    Dim mes As String
                    Dim campos3 As String
                    Dim valores3 As String
                    Dim estado3 As String = "1"
                    mes = cboMes.SelectedValue
                    Dim tabla3 As String = "empresas_periodos_meses"
                    campos3 = "id_empresa╚id_periodo╚id_mes╚estado"
                    valores3 = cod_empresa & "╚" & periodo2 & "╚" & mes & "╚" & estado3
                    rpta3 = nobj.nCrudInsertar("╚", tabla3, campos3, valores3)
                    'gravando la cuenta contable escogida
                    'cod_empresa , es la empresa nueva

                    If rbt1.Checked = True Then
                        Dim cod_empresaorigen As String
                        cod_empresaorigen = cboPlancontable.SelectedValue
                        rpta4 = nobj2.nCopiarPlanContable(cod_empresa, cod_empresaorigen)
                    End If


                End If

            End If
        End If

        If rpta = "ok" Then
            MessageBox.Show("El proceso se ha realizado con éxito.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            'gbGrupo.Enabled = False
            'limpiarEntradas()
            'cargarDatos()
            desactivarbotonesgc()
            activarbotonesnmes()
            ' dgvLista.Refresh()
            desactivarcajas()
            activargrid()
            ' listarUsuarios()
            txtDato.Focus()

            listarEmpresas()
            cargardatosempresas()
            tipo = ""
            cboPeriodo.Visible = False
            cboMes.Visible = False
        Else
            MessageBox.Show(rpta, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If


        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        desactivargrid()
        limpiarcajas()
        activarcajas()
        tipo = "nuevo"
        desactivarbotonesnmes()
        activarbotonesgc()
        activarperiodomes()
        activarplancontable()
        cargarMeses()
        cargarPeriodos()
        ' txtLogin_usuario.Enabled = True
    End Sub
    Private Sub desactivargrid()
        dgvLista.Enabled = False
        'gbUsuarios.Enabled = False
    End Sub
    Private Sub limpiarcajas()
        'txtIdUsuario.Text = ""
        txtNomComercial.Text = ""
        txtRazonSocial.Text = ""
        txtRuc.Text = ""
        txtDireccion.Text = ""
        txtUbigeo.Text = ""
        txtMoneda.Text = ""
        txtTelefono.Text = ""
        txtCelular.Text = ""
        txtEmail.Text = ""

    End Sub
    Private Sub activargrid()
        dgvLista.Enabled = True
        'gbUsuarios.Enabled = True
    End Sub
    Private Sub activarcajas()
        gbEmpresas.Enabled = True
    End Sub
    Private Sub desactivarcajas()
        gbEmpresas.Enabled = False
    End Sub
    Private Sub desactivarperiodomes()
        lblPeriodo.Visible = False
        lblMes.Visible = False
        cboPeriodo.Visible = False
        cboMes.Visible = False
    End Sub
    Private Sub activarperiodomes()
        lblPeriodo.Visible = True
        lblMes.Visible = True
        cboPeriodo.Visible = True
        cboMes.Visible = True
    End Sub
    Private Sub desactivarplancontable()
        gbPlancontable.Visible = False
    End Sub
    Private Sub activarplancontable()
        gbPlancontable.Visible = True
    End Sub

    Private Sub activarbotonesnmes()
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnSalir.Enabled = True
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
    Private Sub desactivarbotonesgc()
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        tipo = "modificar"
        desactivargrid()
        activarcajas()
        desactivarbotonesnmes()
        activarbotonesgc()

    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        tipo = ""
        cargardatosempresas()
        desactivarbotonesgc()
        ' codigoCeldaSeleccionada()
        activarbotonesnmes()
        ' txtNomComercial.Focus()
        desactivarcajas()
        activargrid()
        listarEmpresas()
        desactivarperiodomes()
        desactivarplancontable()
    End Sub

    Private Sub rbt2_CheckedChanged(sender As Object, e As EventArgs) Handles rbt2.CheckedChanged
        If rbt2.Checked = True Then
            cboPlancontable.Enabled = False
        Else
            cboPlancontable.Enabled = True
        End If
    End Sub

    Private Sub cboPlancontable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPlancontable.SelectedIndexChanged

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

    End Sub
End Class