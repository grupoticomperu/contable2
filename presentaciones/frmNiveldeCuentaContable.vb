Imports Negocios
Public Class frmNiveldeCuentaContable
    Dim nobj As New nCrud
    Dim tipo As String = ""
    Dim tituloform As String = "Nivel de Cuenta Contable"
    Private Function codigoCeldaSeleccionada() As Integer
        Dim c As String
        Try
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            c = dgvLista.Rows(f).Cells("id_nivelctacontable").Value.ToString
        Catch ex As Exception
            c = 0
        End Try
        Return c
    End Function


    ' Private Sub cargaInicialEstados()
    ' Try
    'For Each row As DataGridViewRow In dgvLista.Rows
    'If row.Cells("estado_ctacontables").Value.ToString = "0" Then
    '               row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(255, 87, 87) '(245, 230, 108)
    'ElseIf row.Cells("estado_ctacontables").Value.ToString = "1" Then
    '               row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(255, 255, 255)
    'End If
    'Next
    'Catch ex As Exception
    '
    'End Try

    '  End Sub

    Private Sub frmNiveldeCuentaContable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarNiveldectacontables()
        cargardatosNiveldectacontables()
        desactivarbotonesgc()
        activarbotonesnmes()
        desactivarcajas()
    End Sub

    Private Sub listarNiveldectacontables()
        Dim data As New DataTable
        data = nobj.nCrudListar("select * from nivel_ctacontables where estado_nivelctacontable = 1 order by nom_nivelctacontable asc")
        'data = nobj.nCrudListar("select * from usuarios order by login_usuarios asc")

        dgvLista.DataSource = data
        data = Nothing
        ' cargaInicialEstados()
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
    Private Sub cargardatosNiveldectacontables()
        If tipo <> "new" Or tipo = "" Then
            Me.Enabled = False
            On Error Resume Next
            Dim sql As String
            sql = "select * from nivel_ctacontables where id_nivelctacontable=" & codigoCeldaSeleccionada()
            Dim data As New DataTable
            data = nobj.nCrudListar(sql)

            txtNivelcuenta.Text = data.Rows(0)("nom_nivelctacontable").ToString.Trim
            txtNivelcuenta.Focus()

            data = Nothing
            Me.Enabled = True
        ElseIf tipo = "new" Then
            txtNivelcuenta.Focus()
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
        txtNivelcuenta.Focus()

    End Sub

    Private Sub limpiarcajas()
        'txtIdUsuario.Text = ""
        txtNivelcuenta.Text = ""
    End Sub

    Private Sub dgvLista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLista.CellContentClick

    End Sub

    Private Sub dgvLista_SelectionChanged(sender As Object, e As EventArgs) Handles dgvLista.SelectionChanged
        cargardatosNiveldectacontables()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim existeNivelcuenta1 As New DataTable
        existeNivelcuenta1 = nobj.nCrudListar("select * from nivel_ctacontables where estado_nivelctacontable=1")
        If existeNivelcuenta1.Rows.Count > 0 Then
            desactivargrid()
            activarcajas()
            tipo = "modificar"
            desactivarbotonesnmes()
            activarbotonesgc()
            txtNivelcuenta.Focus()
        Else
            MsgBox("No existe datos para Modificar")
            Exit Sub
        End If



    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ' dgvLista.Refresh()
        desactivarbotonesgc()
        activarbotonesnmes()
        desactivarcajas()
        activargrid()
        ' listarUsuarios()
        txtDato.Focus()
        listarNiveldectacontables()
        cargardatosNiveldectacontables()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Está seguro que desea salir de " & tituloform & "?.", MsgBoxStyle.YesNo, "Cerrar Módulo") = MsgBoxResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim campos As String
        Dim valores As String
        Dim condicion As String
        Dim estado As String
        Dim rpta As String = ""
        Dim tabla As String = "nivel_ctacontables"


        If tipo = "modificar" Then
            ' txtLogin_usuario.Enabled = False
            If txtNivelcuenta.Text.ToString = "" Then
                MessageBox.Show("Por favor ingresar la descripción del Nivel de Cuenta.", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                estado = 1
                campos = "nom_nivelctacontable╚estado_nivelctacontable"
                valores = txtNivelcuenta.Text.ToString & "╚" & estado

                condicion = "id_nivelctacontable=" & codigoCeldaSeleccionada()
                rpta = nobj.nCrudActualizar("╚", tabla, campos, valores, condicion)
            End If
        ElseIf tipo = "nuevo" Then
            If txtNivelcuenta.Text.ToString = "" Then
                MessageBox.Show("Por favor ingresar la descripción del Nivel de Cuenta.", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Exit Sub
            Else
                'verificamos la existencia del nivel de cuenta
                Dim existeNivelcuenta As New DataTable
                existeNivelcuenta = nobj.nCrudListar("select * from nivel_ctacontables where nom_nivelctacontable ='" & txtNivelcuenta.Text & "'")
                If existeNivelcuenta.Rows.Count > 0 Then
                    MsgBox("El Nivel de Cuenta ya existe")
                    Exit Sub
                Else

                    estado = "1"
                    campos = "nom_nivelctacontable╚estado_nivelctacontable"
                    valores = txtNivelcuenta.Text.ToString & "╚" & estado
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

            listarNiveldectacontables()
            cargardatosNiveldectacontables()
        Else
            MessageBox.Show(rpta, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim campos As String
        Dim valores As String
        Dim condicion As String
        Dim estado As String
        Dim rpta As String = ""
        Dim tabla As String = "nivel_ctacontables"

        Dim existeNivelcuenta1 As New DataTable
        existeNivelcuenta1 = nobj.nCrudListar("select * from nivel_ctacontables where estado_nivelctacontable=1")
        If existeNivelcuenta1.Rows.Count > 0 Then

            If MessageBox.Show("¿Desea eliminar el Nivel de Cuenta?", "Módulo de Nivel de cuentas", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                estado = 0
                campos = "estado_nivelctacontable"
                valores = estado

                condicion = "id_nivelctacontable=" & codigoCeldaSeleccionada()
                rpta = nobj.nCrudActualizar("╚", tabla, campos, valores, condicion)
                If rpta = "ok" Then
                    MessageBox.Show("El proceso se ha realizado con éxito.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                    desactivarbotonesgc()
                    activarbotonesnmes()

                    desactivarcajas()
                    activargrid()

                    txtDato.Focus()

                    listarNiveldectacontables()
                    cargardatosNiveldectacontables()
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

    Private Sub txtDato_TextChanged(sender As Object, e As EventArgs) Handles txtDato.TextChanged
        dgvLista.DataSource = nobj.nCrudListar("select * from nivel_ctacontables where nom_nivelctacontable like '" & txtDato.Text.Trim & "%' order by id_nivelctacontable asc")
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        dgvLista.DataSource = nobj.nCrudListar("select * from nivel_ctacontables where nom_nivelctacontable like '" & txtDato.Text.Trim & "%' order by id_nivelctacontable asc")
    End Sub
End Class