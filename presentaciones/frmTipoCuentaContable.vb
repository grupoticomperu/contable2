Imports Negocios
Public Class frmTipoCuentaContable
    Dim nobj As New nCrud
    Dim tipo As String = ""
    Dim tituloform As String = "Tipo de Cuenta Contable"
    Private Function codigoCeldaSeleccionada() As Integer
        Dim c As String
        Try
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            c = dgvLista.Rows(f).Cells("id_tipoctacontable").Value.ToString
        Catch ex As Exception
            c = 0
        End Try
        Return c
    End Function
    Private Sub frmTipoCuentaContable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarTipodectacontables()
        cargardatosTipodectacontables()
        desactivarbotonesgc()
        activarbotonesnmes()
        desactivarcajas()
    End Sub
    Private Sub limpiarcajas()
        txtTipocuenta.Text = ""
    End Sub


    Private Sub activarcajas()
        gbNivel.Enabled = True
    End Sub
    Private Sub desactivarcajas()
        gbNivel.Enabled = False
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
    Private Sub activargrid()
        dgvLista.Enabled = True
        'gbUsuarios.Enabled = True
    End Sub
    Private Sub desactivargrid()
        dgvLista.Enabled = False
        'gbUsuarios.Enabled = False
    End Sub

    Private Sub listarTipodectacontables()
        Dim data As New DataTable
        data = nobj.nCrudListar("select * from tipo_ctacontables where estado = 1 order by nom_tipoctacontable asc")
        'data = nobj.nCrudListar("select * from usuarios order by login_usuarios asc")

        dgvLista.DataSource = data
        data = Nothing
        ' cargaInicialEstados()
    End Sub

    Private Sub cargardatosTipodectacontables()
        If tipo <> "new" Or tipo = "" Then
            Me.Enabled = False
            On Error Resume Next
            Dim sql As String
            sql = "select * from tipo_ctacontables where id_tipoctacontable=" & codigoCeldaSeleccionada()
            Dim data As New DataTable
            data = nobj.nCrudListar(sql)

            txtTipocuenta.Text = data.Rows(0)("nom_tipoctacontable").ToString.Trim

            data = Nothing
            Me.Enabled = True
        ElseIf tipo = "new" Then
            txtTipocuenta.Focus()
        End If
        'cargaInicialEstados()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        desactivargrid()
        limpiarcajas()
        activarcajas()
        tipo = "nuevo"
        desactivarbotonesnmes()
        activarbotonesgc()
        txtTipocuenta.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ' dgvLista.Refresh()
        desactivarbotonesgc()
        activarbotonesnmes()
        desactivarcajas()
        activargrid()
        ' listarUsuarios()
        txtDato.Focus()
        listarTipodectacontables()
        cargardatosTipodectacontables()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim existeTipocuenta1 As New DataTable
        existeTipocuenta1 = nobj.nCrudListar("select * from tipo_ctacontables where estado=1")
        If existeTipocuenta1.Rows.Count > 0 Then
            desactivargrid()
            activarcajas()
            tipo = "modificar"
            desactivarbotonesnmes()
            activarbotonesgc()
            txtTipocuenta.Focus()
        Else
            MsgBox("No existe datos para Modificar")
            Exit Sub
        End If
    End Sub

    Private Sub dgvLista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLista.CellContentClick

    End Sub

    Private Sub dgvLista_SelectionChanged(sender As Object, e As EventArgs) Handles dgvLista.SelectionChanged
        cargardatosTipodectacontables()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim campos As String
        Dim valores As String
        Dim condicion As String
        Dim estado As String
        Dim rpta As String = ""
        Dim tabla As String = "tipo_ctacontables"


        If tipo = "modificar" Then
            ' txtLogin_usuario.Enabled = False
            If txtTipocuenta.Text.ToString = "" Then
                MessageBox.Show("Por favor ingresar la descripción del Tipo de Cuenta.", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                estado = 1
                campos = "nom_tipoctacontable╚estado"
                valores = txtTipocuenta.Text.ToString & "╚" & estado

                condicion = "id_tipoctacontable=" & codigoCeldaSeleccionada()
                rpta = nobj.nCrudActualizar("╚", tabla, campos, valores, condicion)
            End If
        ElseIf tipo = "nuevo" Then
            If txtTipocuenta.Text.ToString = "" Then
                MessageBox.Show("Por favor ingresar la descripción del Nivel de Cuenta.", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Exit Sub
            Else
                'verificamos la existencia del nivel de cuenta
                Dim existeTipocuenta As New DataTable
                existeTipocuenta = nobj.nCrudListar("select * from tipo_ctacontables where nom_tipoctacontable ='" & txtTipocuenta.Text & "'")
                If existeTipocuenta.Rows.Count > 0 Then
                    MsgBox("El Nivel de Cuenta ya existe")
                    Exit Sub
                Else

                    estado = "1"
                    campos = "nom_tipoctacontable╚estado"
                    valores = txtTipocuenta.Text.ToString & "╚" & estado
                    rpta = nobj.nCrudInsertar("╚", tabla, campos, valores)
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

            listarTipodectacontables()
            cargardatosTipodectacontables()
        Else
            MessageBox.Show(rpta, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub txtDato_TextChanged(sender As Object, e As EventArgs) Handles txtDato.TextChanged
        dgvLista.DataSource = nobj.nCrudListar("select * from tipo_ctacontables where nom_tipoctacontable like '" & txtDato.Text.Trim & "%' order by id_nivelctacontable asc")
        'falta restringir por estado 1
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim campos As String
        Dim valores As String
        Dim condicion As String
        Dim estado As String
        Dim rpta As String = ""
        Dim tabla As String = "tipo_ctacontables"

        Dim existeTipocuenta1 As New DataTable
        'para ver si existe datos
        existeTipocuenta1 = nobj.nCrudListar("select * from tipo_ctacontables where estado=1")
        If existeTipocuenta1.Rows.Count > 0 Then

            If MessageBox.Show("¿Desea eliminar el Tipo de Cuenta?", "Módulo de Tipo de cuentas", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                estado = 0
                campos = "estado"
                valores = estado

                condicion = "id_tipoctacontable=" & codigoCeldaSeleccionada()
                rpta = nobj.nCrudActualizar("╚", tabla, campos, valores, condicion)
                If rpta = "ok" Then
                    MessageBox.Show("El proceso se ha realizado con éxito.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                    desactivarbotonesgc()
                    activarbotonesnmes()

                    desactivarcajas()
                    activargrid()

                    txtDato.Focus()

                    listarTipodectacontables()
                    cargardatosTipodectacontables()
                Else
                    MessageBox.Show(rpta, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If


            Else
                Exit Sub
            End If
        Else
            MsgBox("No existe datos para Eliminar ")
            Exit Sub
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Está seguro que desea salir de " & tituloform & "?.", MsgBoxStyle.YesNo, "Cerrar Módulo") = MsgBoxResult.Yes Then
            Me.Dispose()
        End If
    End Sub
End Class