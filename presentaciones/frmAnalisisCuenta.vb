Imports Negocios
Public Class frmAnalisisCuenta
    Dim nobj As New nCrud
    Dim tipo As String = ""
    Dim tituloform As String = "Análisis de Cuenta Contable"

    Private Function codigoCeldaSeleccionada() As Integer
        Dim c As Integer
        Try
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            c = CInt(dgvLista.Rows(f).Cells("id_analisisctacontable").Value.ToString)
        Catch ex As Exception
            c = 0
        End Try
        Return c
    End Function
    Private Sub frmAnalisisCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarAnalisisdectacontables()
        cargardatosAnalisisdectacontables()
        desactivarbotonesgc()
        activarbotonesnmes()
        desactivarcajas()
    End Sub
    Private Sub limpiarcajas()
        txtAnalisis.Text = ""
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
    Private Sub listarAnalisisdectacontables()
        Dim data As New DataTable
        data = nobj.nCrudListar("select * from analisis_ctacontables where estado = 1 order by nom_analisisctacontable asc")
        'data = nobj.nCrudListar("select * from usuarios order by login_usuarios asc")

        dgvLista.DataSource = data
        data = Nothing
        ' cargaInicialEstados()
    End Sub

    Private Sub cargardatosAnalisisdectacontables()
        If tipo <> "new" Or tipo = "" Then
            Me.Enabled = False
            On Error Resume Next
            Dim sql As String
            sql = "select * from analisis_ctacontables where id_analisisctacontable=" & codigoCeldaSeleccionada()
            Dim data As New DataTable
            data = nobj.nCrudListar(sql)

            txtAnalisis.Text = data.Rows(0)("nom_analisisctacontable").ToString.Trim

            data = Nothing
            Me.Enabled = True
        ElseIf tipo = "new" Then
            txtAnalisis.Focus()
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
        txtAnalisis.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ' dgvLista.Refresh()
        desactivarbotonesgc()
        activarbotonesnmes()
        desactivarcajas()
        activargrid()
        ' listarUsuarios()
        txtDato.Focus()
        listarAnalisisdectacontables()
        cargardatosAnalisisdectacontables()
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
            txtAnalisis.Focus()
        Else
            MsgBox("No existe datos para Modificar")
            Exit Sub
        End If
    End Sub

    Private Sub dgvLista_SelectionChanged(sender As Object, e As EventArgs) Handles dgvLista.SelectionChanged
        cargardatosAnalisisdectacontables()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim campos As String
        Dim valores As String
        Dim condicion As String
        Dim estado As String
        Dim rpta As String = ""
        Dim tabla As String = "analisis_ctacontables"


        If tipo = "modificar" Then
            ' txtLogin_usuario.Enabled = False
            If txtAnalisis.Text.ToString = "" Then
                MessageBox.Show("Por favor ingresar la descripción del Tipo Análisis de Cuenta.", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                estado = 1
                campos = "nom_analisisctacontable╚estado"
                valores = txtAnalisis.Text.ToString & "╚" & estado

                condicion = "id_analisisctacontable=" & codigoCeldaSeleccionada()
                rpta = nobj.nCrudActualizar("╚", tabla, campos, valores, condicion)
            End If
        ElseIf tipo = "nuevo" Then
            If txtAnalisis.Text.ToString = "" Then
                MessageBox.Show("Por favor ingresar la descripción del Tipo de Análisis de la Cuenta.", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Exit Sub
            Else
                'verificamos la existencia del nivel de cuenta
                Dim existeAnalisiscuenta As New DataTable
                existeAnalisiscuenta = nobj.nCrudListar("select * from analisis_ctacontables where nom_analisisctacontable ='" & txtAnalisis.Text & "'")
                If existeAnalisiscuenta.Rows.Count > 0 Then
                    MsgBox("El Tipo de analisis de Cuenta ya existe")
                    Exit Sub
                Else

                    estado = "1"
                    campos = "nom_analisisctacontable╚estado"
                    valores = txtAnalisis.Text.ToString & "╚" & estado
                    rpta = nobj.nCrudInsertar("╚", tabla, campos, valores)
                End If
            End If
        End If

        If rpta = "ok" Then
            MessageBox.Show("El proceso se ha realizado con éxito.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            desactivarbotonesgc()
            activarbotonesnmes()

            desactivarcajas()
            activargrid()

            txtDato.Focus()

            listarAnalisisdectacontables()
            cargardatosAnalisisdectacontables()
        Else
            MessageBox.Show(rpta, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub txtDato_TextChanged(sender As Object, e As EventArgs) Handles txtDato.TextChanged
        dgvLista.DataSource = nobj.nCrudListar("select * from analisis_ctacontables where nom_analisisctacontable like '" & txtDato.Text.Trim & "%' order by id_analisisctacontable asc")
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim campos As String
        Dim valores As String
        Dim condicion As String
        Dim estado As String
        Dim rpta As String = ""
        Dim tabla As String = "analisis_ctacontables"

        Dim existeAnalisiscuenta1 As New DataTable
        'para ver si existe datos
        existeAnalisiscuenta1 = nobj.nCrudListar("select * from analisis_ctacontables where estado=1")
        If existeAnalisiscuenta1.Rows.Count > 0 Then

            If MessageBox.Show("¿Desea eliminar el Tipo de Analisis de Cuenta?", "Módulo de Analisis de Tipo de cuentas", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                estado = 0
                campos = "estado"
                valores = estado

                condicion = "id_analisisctacontable=" & codigoCeldaSeleccionada()
                rpta = nobj.nCrudActualizar("╚", tabla, campos, valores, condicion)
                If rpta = "ok" Then
                    MessageBox.Show("El proceso se ha realizado con éxito.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                    desactivarbotonesgc()
                    activarbotonesnmes()

                    desactivarcajas()
                    activargrid()

                    txtDato.Focus()

                    listarAnalisisdectacontables()
                    cargardatosAnalisisdectacontables()
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

    Private Sub dgvLista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLista.CellContentClick

    End Sub
End Class