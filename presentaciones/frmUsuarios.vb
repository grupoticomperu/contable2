Imports Negocios

Public Class frmUsuarios
    Dim nobj As New nCrud
    Dim tipo As String = ""
    Dim tituloform As String = "Usuarios"

    Private Function codigoCeldaSeleccionada() As Integer
        Dim c As String
        Try
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            c = dgvLista.Rows(f).Cells("id_usuario").Value.ToString
        Catch ex As Exception
            c = 0
        End Try
        Return c
    End Function
    Private Sub listarUsuarios()
        Dim data As New DataTable
        data = nobj.nCrudListar("select * from vista_Usuarios where estado_usuario = 'ACTIVO' order by login_usuario asc")
        'data = nobj.nCrudListar("select * from usuarios order by login_usuarios asc")

        dgvLista.DataSource = data
        data = Nothing
        cargaInicialEstados()
    End Sub
    Private Sub cargaInicialEstados()
        Try
            For Each row As DataGridViewRow In dgvLista.Rows
                If row.Cells("estado_usuario").Value.ToString = "0" Then
                    row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(255, 87, 87) '(245, 230, 108)
                ElseIf row.Cells("estado_usuario").Value.ToString = "1" Then
                    row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(255, 255, 255)
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarUsuarios()
        cargardatosusuarios()
        desactivarbotonesgc()
        activarbotonesnmes()
        desactivarcajas()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtDirUsuario.TextChanged

    End Sub

    Private Sub dgvLista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLista.CellContentClick

    End Sub

    Private Sub dgvLista_SelectionChanged(sender As Object, e As EventArgs) Handles dgvLista.SelectionChanged
        cargardatosusuarios()
    End Sub
    Private Sub cargardatosusuarios()
        If tipo <> "new" Or tipo = "" Then
            Me.Enabled = False
            On Error Resume Next
            Dim sql As String
            sql = "select * from usuarios where id_usuario=" & codigoCeldaSeleccionada()
            Dim data As New DataTable
            data = nobj.nCrudListar(sql)
            With data
                txtIdUsuario.Text = .Rows(0)("id_usuario")
                txtNom_ap_usuarios.Text = .Rows(0)("nom_ap_usuarios")
                txtDirUsuario.Text = .Rows(0)("dir_usuario")
                txtEmailUsuario.Text = .Rows(0)("email_usuario")
                txtTelefono.Text = .Rows(0)("tel_usuario")
                txtCelular.Text = .Rows(0)("cel_usuario")
                txtLogin_usuario.Text = .Rows(0)("login_usuario")
                txtClave_usuarios.text = .Rows(0)("clave_usuarios")
            End With
            data = Nothing
            Me.Enabled = True
        ElseIf tipo = "new" Then
            txtIdUsuario.Focus()
        End If
        cargaInicialEstados()
    End Sub
   

    Private Sub txtNom_ap_usuarios_TextChanged(sender As Object, e As EventArgs) Handles txtNom_ap_usuarios.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles gbUsuarios.Enter

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        desactivargrid()
        limpiarcajas()
        activarcajas()
        tipo = "nuevo"
        desactivarbotonesnmes()
        activarbotonesgc()
        txtLogin_usuario.Enabled = True
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        desactivargrid()
        activarcajas()
        tipo = "modificar"
        desactivarbotonesnmes()
        activarbotonesgc()
        txtLogin_usuario.Enabled = False
    End Sub
    Private Sub limpiarcajas()
        'txtIdUsuario.Text = ""
        txtNom_ap_usuarios.Text = ""
        txtDirUsuario.Text = ""
        txtEmailUsuario.Text = ""
        txtTelefono.Text = ""
        txtCelular.Text = ""
        txtLogin_usuario.Text = ""
        txtClave_usuarios.Text = ""

    End Sub
    Private Sub activarcajas()
        gbUsuarios.Enabled = True
    End Sub
    Private Sub desactivarcajas()
        gbUsuarios.Enabled = False
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
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim campos As String
        Dim valores As String
        Dim condicion As String
        Dim estado As String
        Dim rpta As String = ""
        Dim tabla As String = "usuarios"


        If tipo = "modificar" Then
            ' txtLogin_usuario.Enabled = False
            If txtNom_ap_usuarios.Text.ToString = "" Or txtDirUsuario.Text.ToString = "" Or txtEmailUsuario.Text.ToString = "" Or txtCelular.Text.ToString = "" Or _
   txtLogin_usuario.Text.ToString = "" Or txtClave_usuarios.Text.ToString = "" Then
                MessageBox.Show("Por favor ingresar los datos del Usuario.", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                If rbInactivo.Checked = True Then
                    estado = "0"
                Else
                    estado = "1"
                End If
                campos = "login_usuario╚clave_usuarios╚nom_ap_usuarios╚dir_usuario╚email_usuario╚tel_usuario╚cel_usuario╚estado_usuario"
                valores = txtLogin_usuario.Text.ToString & "╚" & txtClave_usuarios.Text.ToString & "╚" & txtNom_ap_usuarios.Text.ToString & "╚" & txtDirUsuario.Text.ToString & "╚" & txtEmailUsuario.Text.ToString & "╚" & _
                txtTelefono.Text.ToString & "╚" & txtCelular.Text.ToString & "╚" & estado

                condicion = "id_usuario=" & codigoCeldaSeleccionada()
                rpta = nobj.nCrudActualizar("╚", tabla, campos, valores, condicion)
            End If
        ElseIf tipo = "nuevo" Then
            If txtNom_ap_usuarios.Text.ToString = "" Or txtDirUsuario.Text.ToString = "" Or txtEmailUsuario.Text.ToString = "" Or txtCelular.Text.ToString = "" Or _
    txtLogin_usuario.Text.ToString = "" Or txtClave_usuarios.Text.ToString = "" Then
                MessageBox.Show("Por favor ingresar los datos del Usuario.", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Exit Sub
            Else
                Dim existeUsuario As New DataTable
                existeUsuario = nobj.nCrudListar("select * from usuarios where login_usuario='" & txtLogin_usuario.Text.Trim & "'")
                If existeUsuario.Rows.Count > 0 Then
                    MsgBox("El Login del usuario ya existe")
                    Exit Sub
                Else
                    If rbInactivo.Checked = True Then
                        estado = "0"
                    Else
                        estado = "1"
                    End If
                    campos = "login_usuario╚clave_usuarios╚nom_ap_usuarios╚dir_usuario╚email_usuario╚tel_usuario╚cel_usuario╚estado_usuario"
                    valores = txtLogin_usuario.Text.ToString & "╚" & txtClave_usuarios.Text.ToString & "╚" & txtNom_ap_usuarios.Text.ToString & "╚" & txtDirUsuario.Text.ToString & "╚" & txtEmailUsuario.Text.ToString & "╚" & _
                    txtTelefono.Text.ToString & "╚" & txtCelular.Text.ToString & "╚" & estado
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

            listarUsuarios()
            cargardatosusuarios()
        Else
            MessageBox.Show(rpta, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
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
        listarUsuarios()
        cargardatosusuarios()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Está seguro que desea salir de " & tituloform & "?.", MsgBoxStyle.YesNo, "Cerrar Módulo") = MsgBoxResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub lblTituloForm_Click(sender As Object, e As EventArgs) Handles lblTituloForm.Click

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        dgvLista.DataSource = nobj.nCrudListar("select * from vista_Usuarios where nom_ap_usuarios like '" & txtDato.Text.Trim & "%' or  login_usuario like '" & txtDato.Text.Trim & "%' order by id_usuario asc")
    End Sub

    Private Sub txtDato_TextChanged(sender As Object, e As EventArgs) Handles txtDato.TextChanged
        dgvLista.DataSource = nobj.nCrudListar("select * from vista_Usuarios where nom_ap_usuarios like '" & txtDato.Text.Trim & "%' or  login_usuario like '" & txtDato.Text.Trim & "%' order by id_usuario asc")
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

    End Sub
End Class