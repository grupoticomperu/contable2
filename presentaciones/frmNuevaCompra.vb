Imports Negocios
Public Class frmNuevaCompra
    Dim objCrud As New nCrud
    Dim objCA As New nCuentaAsiento
    Dim objMon As New nMonedas
    Dim iCarga As String = 0
    'Dim tipomoneda As String
    'Dim itipomonedasoles As Integer = 0

    Dim dtPagos As New DataTable
    Dim objTDA As New nTipoDocumentoAsiento
    Dim idTipoOperacion As Integer = 2
    'Dim CodigoLocalSession As Integer = 1
    'Dim CodigoEmpresaSession As Integer = 1
    Dim dataAsientos As New DataTable
    Dim mIgv As Decimal = 0
    Dim mTotal As Decimal = 0
    Dim montoDetraccion As Decimal = 0
    Public idCentroCosto As String = 0

    Private Sub cargarTipoCompra()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add("CREDITO", "CRÉDITO")
        data.Rows.Add("CONTADO", "CONTADO")
        With cboTipoCompra
            .DataSource = data
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
        End With
    End Sub
    Private Sub cargarImpuestosSunatCredito()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "SIN AFECTO")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListar("select * from tipos_impuestos_sunat where id_tipo_operacion = 2 and estado=1")
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(2).ToString)
            Next
            With cboPercepcion
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Impuestos")
        End Try
    End Sub

    Private Sub cargarTipoDocumento()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Escoger")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListar("select * from tipos_documentos where estado_tipodocumento=1 order by id_tipodocumento asc")
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(2).ToString)
            Next
            With cboTipoDocumento
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Impuestos")
        End Try
    End Sub

    Private Sub cargarOperacionesgravadas()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Escoger")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListar("select * from operaciones_gravadas where estado_ope_gravada=1 order by id_ope_gravada asc")
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboOperacionGravada
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Impuestos")
        End Try
    End Sub
    Private Sub cargarMonedas()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Escoger")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListar("select id_moneda,nom_moneda,simbolo_moneda from monedas where estado_moneda=1 order by simbolo_moneda asc")
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(2).ToString)
            Next
            With cboMoneda
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
                .SelectedValue = 1
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Monedas")
        End Try
    End Sub
    Private Sub frmNuevaCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTipoCompra()
        cargarImpuestosSunatCredito()
        cargarTipoDocumento()
        cargarOperacionesgravadas()
        cargarMonedas()
        'tipomoneda = 1 ' 
        iCarga = 1
        cargarTipoDeCambio()
        'tipomoneda = 1
        ' cargarTipoDeCambio()
        'iCarga = 1
        '  cargarTipoDeCambio()

    End Sub
    Private Sub cargarTipoDeCambio()
        If iCarga = 1 Then
            Dim data As New DataTable
            data = objMon.nTipoDeCambioPorMoneda(cboMoneda.SelectedValue.ToString)
            'lblTipoDeCambio.Text = "Tipo de cambio: S/. " & data.Rows(0)("valor").ToString
            If data.Rows.Count > 0 Then
                txtTipoCambio.Visible = True
                lblTipoDeCambio.Visible = True
                txtTipoCambio.Text = data.Rows(0)("tipocambio_venta").ToString
            Else
                'txtTipoCambio.Text = "1.00"
                txtTipoCambio.Visible = False
                lblTipoDeCambio.Visible = False
            End If
        End If
    End Sub
    ' Private Sub cargarTipoDeCambio()
    'If iCarga = 1 Then
    '    Dim data As New DataTable
    '         data = objMon.nTipoDeCambioPorMoneda(cboMoneda.SelectedValue.ToString)
    'lblTipoDeCambio.Text = "Tipo de cambio: S/. " & data.Rows(0)("valor").ToString
    '  If data.Rows.Count > 0 Then
    '              txtTipoCambio.Text = data.Rows(0)("tipocambio_venta").ToString
    'Else
    '             txtTipoCambio.Text = "1.00"
    ' End If
    ' End If
    '  End Sub

    ' Private Sub cargarTipoDeCambio()
    ' If itipomonedasoles = 1 Then
    '         txtTipoCambio.Visible = False
    'Else
    'Dim data As New DataTable
    '  itipomonedasoles = CInt(cboMoneda.SelectedValue.ToString)
    '      txtTipoCambio.Visible = True
    '       data = objMon.nTipoDeCambioPorMoneda(cboMoneda.SelectedValue.ToString)
    'lblTipoDeCambio.Text = "Tipo de cambio: S/. " & data.Rows(0)("valor").ToString
    'If data.Rows.Count > 0 Then
    '           txtTipoCambio.Text = data.Rows(0)("tipocambio_venta").ToString
    '  Else
    ' txtTipoCambio.Text = "1.00"
    'End If
    'End If
    '  End Sub

    Private Sub cboMoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMoneda.SelectedIndexChanged
        cargarTipoDeCambio()



    End Sub

    Private Sub cboMoneda_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboMoneda.SelectedValueChanged
        ' tipomoneda = cboMoneda.SelectedValue.ToString
        ' MsgBox(tipomoneda)
    End Sub

    Private Sub btnAgregarCuenta_Click(sender As Object, e As EventArgs) Handles btnAgregarCuenta.Click
        agregarCuentaContable()
    End Sub

    Private Sub agregarCuentaContable()
        frmNuevaCompraAgregarCuentas.formIni = "NuevaCompra"
        frmNuevaCompraAgregarCuentas.tipoOperacion = cboOperacionGravada.SelectedValue.ToString
        frmNuevaCompraAgregarCuentas.ShowDialog()
        frmNuevaCompraAgregarCuentas.txtCuenta.Select()
    End Sub

    Public Sub adicionarCuentas(cuenta As String, monto As Decimal, orden As String)
        Dim dtData As New DataTable
        With dtData.Columns
            .Add("num_cuenta")
            .Add("desc_cuenta")
            .Add("debe")
            .Add("haber")
            .Add("descripcion")
            .Add("id_centro")
        End With
        If dgvOperaciones.RowCount = 0 Then
            If orden = "D" Then
                dtData.Rows.Add(cuenta, obtenerDatosCuenta(cuenta), monto, "0.00", txtGlosa.Text.Trim, txtCentro.Text.Trim)
            End If
            If orden = "H" Then
                dtData.Rows.Add(cuenta, obtenerDatosCuenta(cuenta), "0.00", monto, txtGlosa.Text.Trim, txtCentro.Text.Trim)
            End If
        Else
            Dim dtI As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
            Dim row As DataRow = dtI.NewRow()
            row.Item(0) = cuenta
            row.Item(1) = obtenerDatosCuenta(cuenta)
            row.Item(2) = IIf(orden = "D", monto, "0.00")
            row.Item(3) = IIf(orden = "H", monto, "0.00")
            row.Item(4) = txtGlosa.Text.Trim
            row.Item(5) = txtCentro.Text.Trim
            dtI.Rows.Add(row)
        End If

        dataAsientos.Merge(dtData)
        dgvOperaciones.DataSource = dataAsientos
        realizarSumasTotales()
        calcularTotalComprobante()
    End Sub
    Private Sub calcularTotalComprobante()
        If dgvOperaciones.RowCount > 0 Then
            Dim total As Decimal = 0
            For Each row As DataGridViewRow In dgvOperaciones.Rows
                If Not row.Cells("num_cuenta").Value.ToString.StartsWith("60") And Not row.Cells("num_cuenta").Value.ToString.StartsWith("40") And Not row.Cells("num_cuenta").Value.ToString.StartsWith("20") And Not row.Cells("num_cuenta").Value.ToString.StartsWith("61") And Not row.Cells("num_cuenta").Value.ToString.StartsWith("94") And Not row.Cells("num_cuenta").Value.ToString.StartsWith("79") Then
                    total = total + Decimal.Parse(row.Cells("haber").Value.ToString)
                End If
            Next
            txtTotal2.Text = total
        End If
    End Sub
    Private Sub realizarSumasTotales()
        Dim tDebe, tHaber, tDiferencia As Decimal
        For Each row As DataGridViewRow In dgvOperaciones.Rows
            tDebe += Decimal.Parse(row.Cells("debe").Value)
            tHaber += Decimal.Parse(row.Cells("haber").Value)
        Next
        tDiferencia = tDebe - tHaber

        txtTDebeS.Text = Format(tDebe, "#,##0.00")
        txtTHaberS.Text = Format(tHaber, "#,##0.00")
        txtDiferenciaS.Text = Format(tDiferencia, "#,##0.00")
    End Sub

    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = objCrud.nCrudListar("select * from cuentascontables where id_empresa='" & EmpresaSeleccionada & "'" And "id_ctacontable='" & cuenta & "'")
        Return dt.Rows(0)("nombre").ToString
    End Function
End Class