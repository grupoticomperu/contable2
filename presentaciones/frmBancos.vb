Imports Negocios
Public Class frmBancos
    Dim nobj As New nCrud
    Dim tipo As String = ""
    Dim tituloform As String = "Bancos"

    Private Function codigoCeldaSeleccionada() As Integer
        Dim c As Integer
        Try
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            c = CInt(dgvLista.Rows(f).Cells("id_banco").Value.ToString)
        Catch ex As Exception
            c = 0
        End Try
        Return c
    End Function

    Private Sub frmBancos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarBancos()
        cargarDatosdeBancos()
        desactivarbotonesgc()
        activarbotonesnmes()
        desactivarcajas()
    End Sub
    Private Sub listarBancos()
        Dim data As New DataTable
        data = nobj.nCrudListar("select * from bancos where estado_banco = 1 order by nom_banco asc")
        'data = nobj.nCrudListar("select * from usuarios order by login_usuarios asc")

        dgvLista.DataSource = data
        data = Nothing
        ' cargaInicialEstados()
    End Sub

    Private Sub dgvLista_SelectionChanged(sender As Object, e As EventArgs) Handles dgvLista.SelectionChanged
        cargarDatosdeBancos()
    End Sub
    Private Sub cargarDatosdeBancos()
        If tipo <> "new" Or tipo = "" Then
            Me.Enabled = False
            On Error Resume Next
            Dim sql As String
            sql = "select * from bancos where id_banco=" & codigoCeldaSeleccionada()
            Dim data As New DataTable
            data = nobj.nCrudListar(sql)
            txtBanco.Text = data.Rows(0)("nom_banco").ToString.Trim
            txtNombreBanco.Text = data.Rows(0)("nom_comercial").ToString.Trim
            data = Nothing
            Me.Enabled = True
        ElseIf tipo = "new" Then
            txtBanco.Focus()
        End If
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

    Private Sub activarbotonesnmes()
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        btnSalir.Enabled = True
    End Sub
    Private Sub desactivarcajas()
        gbNivel.Enabled = False
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        tipo = "modificar"
        desactivargrid()
        activarcajas()
        desactivarbotonesnmes()
        activarbotonesgc()



    End Sub

    Private Sub dgvLista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLista.CellContentClick

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        desactivargrid()
        limpiarcajas()
        activarcajas()
        tipo = "nuevo"
        desactivarbotonesnmes()
        activarbotonesgc()
        txtBanco.Focus()
    End Sub
    Private Sub desactivargrid()
        dgvLista.Enabled = False
        'gbUsuarios.Enabled = False
    End Sub
    Private Sub limpiarcajas()
        txtBanco.Text = ""
        txtNombreBanco.Text = ""
    End Sub
    Private Sub activarcajas()
        gbNivel.Enabled = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        desactivarbotonesgc()
        activarbotonesnmes()
        desactivarcajas()
        activargrid()
        ' listarUsuarios()
        txtDato.Focus()
        listarBancos()
        cargarDatosdeBancos()
    End Sub
    Private Sub activargrid()
        dgvLista.Enabled = True
        'gbUsuarios.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtBanco.Text.ToString = "" Then
            MessageBox.Show("Ingresar el banco", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        'verificamos existencia del banco
        Dim existebanco As New DataTable

        existebanco = nobj.nCrudListar("select * from bancos where nom_banco='" & txtBanco.Text.ToString & "'")
        If existebanco.Rows.Count > 0 Then
            MsgBox("El banco ya existe")
            Exit Sub
        End If

        Dim campos As String
        Dim valores As String
        Dim condicion As String
        Dim estado As String
        Dim rpta As String = ""
        Dim tabla As String = "bancos"


        If tipo = "modificar" Then

            estado = 1
            campos = "nom_banco╚nom_comercial╚estado_banco"
            valores = txtBanco.Text.ToString & "╚" & txtNombreBanco.Text.ToString & "╚" & estado
            condicion = "id_banco=" & codigoCeldaSeleccionada()
            rpta = nobj.nCrudActualizar("╚", tabla, campos, valores, condicion)

        ElseIf tipo = "nuevo" Then

            estado = 1
            campos = "nom_banco╚nom_comercial╚estado_banco"
            valores = txtBanco.Text.ToString & "╚" & txtNombreBanco.Text.ToString & "╚" & estado
            rpta = nobj.nCrudInsertar("╚", tabla, campos, valores)


        End If

        If rpta = "ok" Then
            MessageBox.Show("El Banco Fue Grabado con ëxito", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            desactivarbotonesgc()
            activarbotonesnmes()

            desactivarcajas()
            activargrid()

            txtDato.Focus()
            listarBancos()
            cargarDatosdeBancos()

        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim campos As String
        Dim valores As String
        Dim condicion As String
        Dim estado As String
        Dim rpta As String = ""
        Dim tabla As String = "bancos"

        Dim existenBancos As New DataTable

        'para ver si existen dato, para no permitir eliminar de tabla vacia
        existenBancos = nobj.nCrudListar("select * from bancos where estado_banco=1")
        If existenBancos.Rows.Count > 0 Then

            If MessageBox.Show("¿Desea eliminar el Banco?", "TICOM CONTABLE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                estado = 0
                campos = "estado_banco"
                valores = estado

                condicion = "id_banco=" & codigoCeldaSeleccionada()
                rpta = nobj.nCrudActualizar("╚", tabla, campos, valores, condicion)
                If rpta = "ok" Then
                    MessageBox.Show("El proceso se ha realizado con éxito.", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                    desactivarbotonesgc()
                    activarbotonesnmes()

                    desactivarcajas()
                    activargrid()

                    txtDato.Focus()

                    listarBancos()
                    cargarDatosdeBancos()
                    
                Else
                    MessageBox.Show(rpta, "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If


            Else
                Exit Sub
            End If
        Else
            MsgBox("No existe datos para Eliminar ")
            Exit Sub
        End If
    End Sub
End Class