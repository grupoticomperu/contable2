Imports Negocios
Public Class frmMonedas
    Dim nobj As New nCrud
    Dim tipo As String = ""
    Dim tituloform As String = "Monedas"

    Private Function codigoCeldaSeleccionada() As Integer
        Dim c As Integer
        Try
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            c = CInt(dgvLista.Rows(f).Cells("id_moneda").Value.ToString)
        Catch ex As Exception
            c = 0
        End Try
        Return c
    End Function

    Private Sub frmMonedas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarMonedas()
        cargarDatosdeMonedas()
        desactivarbotonesgc()
        activarbotonesnmes()
        desactivarcajas()
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
    Private Sub listarMonedas()
        Dim data As New DataTable
        data = nobj.nCrudListar("select * from monedas where estado_moneda = 1 order by nom_moneda asc")
        'data = nobj.nCrudListar("select * from usuarios order by login_usuarios asc")

        dgvLista.DataSource = data
        data = Nothing
        ' cargaInicialEstados()
    End Sub

    Private Sub dgvLista_SelectionChanged(sender As Object, e As EventArgs) Handles dgvLista.SelectionChanged
        cargarDatosdeMonedas()
    End Sub

    Private Sub cargarDatosdeMonedas()
        If tipo <> "new" Or tipo = "" Then
            Me.Enabled = False
            On Error Resume Next
            Dim sql As String
            sql = "select * from monedas where id_moneda=" & codigoCeldaSeleccionada()
            Dim data As New DataTable
            data = nobj.nCrudListar(sql)
            txtNombreMoneda.Text = data.Rows(0)("nom_moneda").ToString.Trim
            txtSimboloMoneda.Text = data.Rows(0)("simbolo_moneda").ToString.Trim
            txtPais.Text = data.Rows(0)("pais_moneda").ToString.Trim

            data = Nothing 'libera de memoria o limpiar el datatable
            Me.Enabled = True


        ElseIf tipo = "new" Then
            txtNombreMoneda.Focus()
        End If
    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        desactivargrid()
        limpiarcajas()
        activarcajas()
        tipo = "nuevo"
        desactivarbotonesnmes()
        activarbotonesgc()
        txtNombreMoneda.Focus()
    End Sub
    Private Sub desactivargrid()
        dgvLista.Enabled = False
        'gbUsuarios.Enabled = False
    End Sub

    Private Sub limpiarcajas()
        txtNombreMoneda.Text = ""
        txtSimboloMoneda.Text = ""
        txtPais.Text = ""
    End Sub
    Private Sub activarcajas()
        gbNivel.Enabled = True
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
  

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        desactivarbotonesgc()
        activarbotonesnmes()
        desactivarcajas()
        activargrid()
        ' listarUsuarios()
        txtDato.Focus()
        listarMonedas()
        cargarDatosdeMonedas()
    End Sub
    Private Sub activargrid()
        dgvLista.Enabled = True
        'gbUsuarios.Enabled = True
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        tipo = "modificar"
        desactivargrid()
        activarcajas()
        desactivarbotonesnmes()
        activarbotonesgc()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombreMoneda.Text.ToString = "" Then
            MessageBox.Show("Ingresar la Moneda", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        'verificamos existencia del banco
        Dim existemoneda As New DataTable

        existemoneda = nobj.nCrudListar("select * from monedas where nom_moneda='" & txtNombreMoneda.Text.ToString & "'")
        If existemoneda.Rows.Count > 0 Then
            MsgBox("La Moneda ya existe")
            Exit Sub
        End If

        Dim campos As String
        Dim valores As String
        Dim condicion As String
        Dim estado As String
        Dim rpta As String = ""
        Dim tabla As String = "Monedas"


        If tipo = "modificar" Then

            estado = 1
            campos = "nom_moneda╚simbolo_moneda╚pais_moneda╚estado_moneda"
            valores = txtNombreMoneda.Text.ToString & "╚" & txtSimboloMoneda.Text.ToString & "╚" & txtSimboloMoneda.Text.ToString & "╚" & estado
            condicion = "id_moneda=" & codigoCeldaSeleccionada()
            rpta = nobj.nCrudActualizar("╚", tabla, campos, valores, condicion)

        ElseIf tipo = "nuevo" Then

            estado = 1
            campos = "nom_banco╚nom_comercial╚estado_banco"
            valores = txtNombreMoneda.Text.ToString & "╚" & txtSimboloMoneda.Text.ToString & "╚" & txtSimboloMoneda.Text.ToString & "╚" & estado
            rpta = nobj.nCrudInsertar("╚", tabla, campos, valores)


        End If

        If rpta = "ok" Then
            MessageBox.Show("El Banco Fue Grabado con ëxito", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            desactivarbotonesgc()
            activarbotonesnmes()

            desactivarcajas()
            activargrid()

            txtDato.Focus()
            listarMonedas()
            cargarDatosdeMonedas()

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