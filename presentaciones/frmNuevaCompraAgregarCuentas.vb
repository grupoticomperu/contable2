Imports Negocios
Public Class frmNuevaCompraAgregarCuentas
    Public formIni As String
    Dim objCrud As New nCrud
    Public tipoOperacion As String = "1"
    Dim objMon As New nMonedas
    Dim iCarga As Integer = 0

    Private Sub movimientoDH()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add("D", "DEBE")
        data.Rows.Add("H", "HABER")
        With cboDH
            .DataSource = data
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
        End With
    End Sub

    Private Sub frmNuevaCompraAgregarCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiarEntradas()
        movimientoDH()
        txtCuenta.Select()
        If formIni = "apertura" Or formIni = "MODapertura" Then
            lblGlosa.Visible = True
            txtGlosa.Visible = True
            txtGlosa.Text = "REGISTRO " & lblCuenta.Text.Trim.ToUpper
        Else
            lblGlosa.Visible = False
            txtGlosa.Visible = False
            txtGlosa.Text = ""
        End If


    End Sub

    Private Sub limpiarEntradas()
        txtCuenta.Text = ""
        lblCuenta.Text = "[Cuenta]"
        txtMonto.Text = "0.00"
        cboDH.SelectedValue = "D"
        txtIdCentro.Text = "0"
        txtCentro.Text = "-"
        ' txtGlosa.Text = ""
    End Sub
    Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cargarCuentaContable()
            ' habilitarCentroCostoCompra()
            txtMonto.Focus()
        End If
    End Sub
    Private Sub btnCuenta_Click(sender As Object, e As EventArgs) Handles btnCuenta.Click
        cargarCuentaContable()
    End Sub
    Private Sub cargarCuentaContable()
        If txtCuenta.Text.Trim.Length >= 2 Then
            With frmEscogerPlanContable
                .formInicio = "NuevaCompraAgregarCuentas"
                .cuentainicio = txtCuenta.Text.Trim
                .ShowDialog()
            End With
        End If
    End Sub

    Public Sub verificarTipoOperacion(cuenta As String)
        Dim data As New DataTable
        data = objCrud.nCrudListar("select * from igv where estado=1")
        If tipoOperacion = "3" Or tipoOperacion = "4" Then
            If cuenta = data.Rows(0)("cuenta").ToString Then
                MessageBox.Show("No se puede agregar esta cuenta contable cuando el tipo de operación es ''NO GRAVADA''", "Asignación de Cuenta Contable", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                btnAgregarCuenta.Enabled = False
            Else
                btnAgregarCuenta.Enabled = True
            End If
        End If
    End Sub

    Public Sub habilitarCentroCostoCompra()
        Dim cuentaCC As New DataTable
        cuentaCC = objCrud.nCrudListar("select * from cuentascontables where id_ctacontable='" & txtCuenta.Text.Trim & "'" And "id_empresa ='" & EmpresaSeleccionada & "'")
        If cuentaCC.Rows.Count > 0 Then
            If Integer.Parse(cuentaCC.Rows(0)("centrodecostos").ToString) > 0 Then
                btnCentro.Enabled = True
                txtCentro.Enabled = True
                MessageBox.Show("Elija un Centro de Costo para esta cuenta.", "Registro de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                frmListadeCentrodeCostos.formInicio = "NuevaCompraAgregarCuentas"
                frmListadeCentrodeCostos.ShowDialog()
            Else
                btnCentro.Enabled = False
                txtCentro.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnAgregarCuenta_Click(sender As Object, e As EventArgs) Handles btnAgregarCuenta.Click
        If formIni = "NuevaCompra" Then
            If frmNuevaCompra.idCentroCosto = "0" Then
                frmNuevaCompra.idCentroCosto = IIf(txtIdCentro.Text.Trim = "", "0", txtIdCentro.Text.Trim)
                frmNuevaCompra.txtCentro.Text = IIf(txtIdCentro.Text.Trim = "", "0", txtIdCentro.Text.Trim)
            End If
            frmNuevaCompra.adicionarCuentas(txtCuenta.Text.Trim, txtMonto.Text.Trim, cboDH.SelectedValue.ToString)
        End If
        Me.Close()
    End Sub



    Private Sub txtMonto_TextChanged(sender As Object, e As EventArgs) Handles txtMonto.TextChanged

    End Sub

    Private Sub txtMonto_Leave(sender As Object, e As EventArgs) Handles txtMonto.Leave
        txtCuenta.Text = Format(CType(txtCuenta.Text, Decimal), "###0.00")
    End Sub

    Private Sub txtCuenta_TextChanged(sender As Object, e As EventArgs) Handles txtCuenta.TextChanged

    End Sub
End Class