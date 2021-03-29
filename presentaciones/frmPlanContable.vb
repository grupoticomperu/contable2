Imports Negocios
Imports System.IO
Public Class frmPlanContable
    Dim nobj As New nCrud
    Dim lista As New DataTable
    Dim tipo As String
    Dim tipoAccion As String
    ' Dim EmpresaSeleccionada As Integer = 1
    Dim bandera As Boolean
    Dim cuentaPadre As String
    Dim banderacancelar As Boolean = False
    Dim numcuenta1 As String
    Dim numcuenta As String
   
    Private Function codigoCeldaSeleccionada() As Integer
        ' cargarlistadecuentas()
        Dim c As String
        Try
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            c = dgvLista.Rows(f).Cells("id_ctacontable").Value.ToString
        Catch ex As Exception
            c = 0
        End Try
        Return c
    End Function


    Private Sub cargarlistadecuentas()
        ' MsgBox(plancontable)
        dgvLista.Refresh()
        dgvLista.DataSource = nobj.nCrudListar("select * from vista_listadecuentascontables where id_empresa='" & EmpresaSeleccionada & "' order by id_ctacontable asc")
        'lista = obj.nCrudListar("select * from vista_CuentaContableGrilla where id_empresa='" & EmpresaSeleccionada & "' and nom_nivelctacontable<>'BALANCE' order by id_ctacontable asc")
    End Sub
    Private Sub cargarNivelCuenta()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = nobj.nCrudListar("select * from nivel_ctacontables where estado_nivelctacontable=1 order by nom_nivelctacontable asc")
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboNivelCuenta
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar Nivel Cuenta")
        End Try
    End Sub
    Private Sub cargarBalance()

    End Sub

    Private Sub cargarTipoCuenta()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable

        Try
            data2 = nobj.nCrudListar("select * from tipo_ctacontables where estado=1 order by nom_tipoctacontable asc")
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboTipoCuenta
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar Tipo Cuenta")
        End Try
    End Sub
    Private Sub cargarAnalisisCuenta()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = nobj.nCrudListar("select * from analisis_ctacontables where estado=1 order by nom_analisisctacontable asc")
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboAnalisis
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar Analisis Cuenta")
        End Try
    End Sub
    Private Sub cargarBancos()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = nobj.nCrudListar("select id_banco,nom_banco,nom_comercial from bancos where estado_banco=1 order by nom_banco asc")
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, "(" & row.Item(2).ToString & ") " & row.Item(1).ToString)
            Next
            With cboBanco
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Bancos")
        End Try
    End Sub
    Private Sub cargarMonedas()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = nobj.nCrudListar("select id_moneda,simbolo_moneda,nom_moneda from monedas where estado_moneda=1 order by simbolo_moneda asc")
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, "(" & row.Item(2).ToString & ") " & row.Item(1).ToString)
            Next
            With cboMoneda
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Bancos")
        End Try
    End Sub
   

    Private Sub frmPlanContable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarlistadecuentas()
        cargarNivelCuenta()
        cargarTipoCuenta()
        cargarAnalisisCuenta()
        cargarBancos()
        cargarMonedas()
        desactivarcajas()
        activargrid()
        cargardatoscuenta()
    End Sub
    Private Sub dgvLista_SelectionChanged(sender As Object, e As EventArgs) Handles dgvLista.SelectionChanged
        ' dgvLista.Refresh()
        cargardatoscuenta()
    End Sub
    Private Sub cargardatoscuenta()
        On Error Resume Next
        Dim sql As String
        sql = "select * from cuentascontables where id_ctacontable =" & codigoCeldaSeleccionada()
        Dim data As New DataTable
        data = nobj.nCrudListar(sql)
            With data
                txtCtacontable.Text = .Rows(0)("id_ctacontable")
                numcuenta1 = .Rows(0)("id_ctacontable")
                txtNombrectacontable.Text = .Rows(0)("nom_ctacontable")
                txtEquivalente.Text = .Rows(0)("equi_sunat")
                txtDebe.Text = .Rows(0)("cuenta_debe")
                txtHaber.Text = .Rows(0)("cuenta_haber")
                cboNivelCuenta.SelectedValue = IIf(.Rows(0)("id_nivel_cta_cont") Is DBNull.Value, "0", .Rows(0)("id_nivel_cta_cont"))
                cboTipoCuenta.SelectedValue = IIf(.Rows(0)("id_tipo_cta_cont") Is DBNull.Value, "0", .Rows(0)("id_tipo_cta_cont"))
                'cboBalance.SelectedValue = IIf(.Rows(0)("bal_comprobacion") Is DBNull.Value, "0", .Rows(0)("bal_comprobacion"))
                cboAnalisis.SelectedValue = IIf(.Rows(0)("id_analisis_cta_cont") Is DBNull.Value, "0", .Rows(0)("id_analisis_cta_cont"))
                'MsgBox(.Rows(0)("bal_comprobacion"))
                If .Rows(0)("bal_comprobacion") = "NO" Then
                    cboBalance.SelectedItem = "NO"
                ElseIf .Rows(0)("bal_comprobacion") = "SI" Then
                    cboBalance.SelectedItem = "SI"
                End If

                chkCentrodecostos.Checked = IIf(.Rows(0)("centrodecostos") = "1", True, False)
                ' If .Rows(0)("id_ctacontable").ToString.StartsWith("10") Then
                'gbCuenta10.Enabled = True
            cboBanco.SelectedValue = IIf(.Rows(0)("id_banco") Is DBNull.Value, "0", .Rows(0)("id_banco"))
            txtCtacte.Text = IIf(.Rows(0)("cta_cte") Is DBNull.Value, "", .Rows(0)("cta_cte"))
            cboMoneda.SelectedValue = IIf(.Rows(0)("id_moneda") Is DBNull.Value, "0", .Rows(0)("id_moneda"))
            End With
    End Sub
   
    Private Sub desactivargrid()
        dgvLista.Enabled = False
        'gbUsuarios.Enabled = False
    End Sub
    Private Sub activargrid()
        dgvLista.Enabled = True
        'gbUsuarios.Enabled = False
    End Sub
    Private Sub limpiarcajas()
        'txtIdUsuario.Text = ""
        txtCtacontable.Text = ""
        txtNombrectacontable.Text = ""
        txtEquivalente.Text = ""
        txtDebe.Text = ""
        txtHaber.Text = ""
        txtCtacte.Text = ""
        cargarNivelCuenta()
        cargarTipoCuenta()
        cargarBalance()
        cargarAnalisisCuenta()
        cargarBancos()
        cargarMonedas()
    End Sub
    Private Sub activarcajas()
        gbCtasContables.Enabled = True
        ' gbCuenta10.Enabled = True
    End Sub
    'Private Sub desactivarbotonesnmes()
    '    btnNuevo.Enabled = False
    '    btnModificar.Enabled = False
    '    btnEliminar.Enabled = False
    '    btnSalir.Enabled = False
    'End Sub
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
    Private Sub desactivarcajas()
        gbCtasContables.Enabled = False
        gbCuenta10.Enabled = False

    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ' banderacancelar = False
        desactivargrid()
        limpiarcajas()
        activarcajas()
        tipo = "nuevo"
        desactivarbotonesnmes()

        activarbotonesgc()

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
        ' banderacancelar = True
        ' cargardatoscuenta()
        desactivarbotonesgc()
        '' codigoCeldaSeleccionada()
        activarbotonesnmes()
        '' txtNomComercial.Focus()
        desactivarcajas()
        activargrid()
        cargardatoscuenta()
        'listarEmpresas()
        'desactivarperiodomes()
        'desactivarplancontable()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' banderacancelar = False
        realizarproceso(tipo)
    End Sub
    Private Sub realizarproceso(accion As String)
        'Dim numcuenta As String
        'numcuenta = txtCtacontable.Text
        Dim numcar As Integer
        Dim numcuenta2 As Integer
        gbCtasContables.Enabled = True
        Dim dato As String
        Dim campos, valores, condicion, numCuenta, nomCuenta, ctaEquiv, nivelCuenta, tipoCuenta, balance, tipoAnalisis, ctaDebe, ctaHaber, banco, ctaCorriente, moneda, estadoCC As String
        numCuenta = txtCtacontable.Text.Trim
        numcar = numCuenta.Length
        nomCuenta = txtNombrectacontable.Text.Trim
        ctaEquiv = txtEquivalente.Text.Trim
        ctaDebe = txtDebe.Text.Trim
        ctaHaber = txtHaber.Text.Trim
        ctaCorriente = txtCtacte.Text.Trim
        nivelCuenta = cboNivelCuenta.SelectedValue.ToString
        tipoCuenta = cboTipoCuenta.SelectedValue.ToString
        balance = cboBalance.SelectedItem.ToString
        tipoAnalisis = cboAnalisis.SelectedValue.ToString
        banco = cboBanco.SelectedValue.ToString
        moneda = cboMoneda.SelectedValue.ToString
        estadoCC = IIf(chkCentrodecostos.Checked = True, "1", "0")
        If numCuenta = "" Then
            MessageBox.Show("Ingrese la Cuenta Contable", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCtacontable.Focus()
            Exit Sub
        End If

        'si es nuevo
        If accion = "nuevo" Then
            'si la cuenta tiene 2 o más caracteres
            If numcar >= 2 Then
                numcuenta2 = CInt(numCuenta.Substring(0, 2))
                If numcuenta2 = 10 Then
                    gbCuenta10.Enabled = True
                End If
                'controlamos si la cuenta contable ya eexiste
                Dim existecuenta As New DataTable
                existecuenta = nobj.nCrudListar("select * from cuentascontables where id_ctacontable='" & numCuenta & "' and id_empresa='" & EmpresaSeleccionada & "'")
                If existecuenta.Rows.Count > 0 Then
                    MsgBox("La cuenta contable  " & numCuenta & "  ya existe")
                    txtCtacontable.Focus()
                    Exit Sub
                Else
                    'controlamos si la cuenta padre existe
                    cuentaPadre = numCuenta.Substring(0, (numCuenta.Length - 1))
                    Dim existeCuentaPadre As New DataTable
                    existeCuentaPadre = nobj.nCrudListar("select * from cuentascontables where id_ctacontable='" & cuentaPadre & "' and id_empresa='" & EmpresaSeleccionada & "'")
                    If existeCuentaPadre.Rows.Count > 0 Then
                        txtNombrectacontable.Focus()
                    Else
                        'si la cuenta padre no existe no se graba
                        MsgBox("No se ha encontrado un número de cuenta superior que de origen a la cuenta contable ingresada ")
                        txtCtacontable.Focus()
                        Exit Sub
                    End If

                End If

            Else
                'cuando la cuenta es de unsolo digito
                Dim existecuenta As New DataTable
                existecuenta = nobj.nCrudListar("select * from cuentascontables where id_ctacontable='" & numCuenta & "' and id_empresa='" & EmpresaSeleccionada & "'")
                If existecuenta.Rows.Count > 0 Then
                    MsgBox("La cuenta contable  " & numCuenta & "  ya existe")
                    txtCtacontable.Focus()
                    Exit Sub
                Else
                    txtNombrectacontable.Focus()
                    cuentaPadre = 0
                End If
            End If
        End If
        'cuando modificamos
        If accion = "modificar" Then
            'si la cuenta tiene 2 o más caracteres
            If numcar >= 2 Then
                numcuenta2 = CInt(numCuenta.Substring(0, 2))
                'activa la cuenta 10
                If numcuenta2 = 10 Then
                    gbCuenta10.Enabled = True
                End If
                'numcuenta es el nuevo valor
                'numcuenta1 es el antiguo valor
                If numCuenta <> numcuenta1 Then 'si son distintos indica que se va modificar el numero de cuenta
                    Dim existecuenta As New DataTable
                    'Dim existecuenta2 As New DataTable
                    'existecuenta2 = nobj.nCrudListar("select * from cuentascontables where id_ctacontable LIKE'" & numCuenta & "%'")
                    'If existecuenta.Rows.Count > 0 Then
                    '    MsgBox("La cuenta no se piede modificar or que tiene una cuenta asociada ")
                    '    txtCtacontable.Focus()
                    '    Exit Sub
                    'End If
                    existecuenta = nobj.nCrudListar("select * from cuentascontables where id_ctacontable='" & numCuenta & "'")
                    If existecuenta.Rows.Count > 0 Then
                        MsgBox("La cuenta contable  " & numCuenta & "  ya existe")
                        txtCtacontable.Focus()
                        Exit Sub
                    Else
                        'vemos si la nueva cuenta tiene cuenta padre
                        cuentaPadre = numCuenta.Substring(0, (numCuenta.Length - 1))
                        Dim existeCuentaPadre As New DataTable
                        existeCuentaPadre = nobj.nCrudListar("select * from cuentascontables where id_ctacontable='" & cuentaPadre & "'")
                        If existeCuentaPadre.Rows.Count > 0 Then
                            txtNombrectacontable.Focus()
                        Else
                            MsgBox("No se ha encontrado un número de cuenta superior que de origen a la cuenta contable ingresada ")
                            txtCtacontable.Focus()
                            Exit Sub
                        End If
                    End If

                Else
                    'cuando la cuenta es de unsolo digito
                    If numCuenta <> numcuenta1 Then
                        Dim existecuenta As New DataTable
                        'Dim existecuenta2 As New DataTable
                        'existecuenta2 = nobj.nCrudListar("select * from cuentascontables where id_ctacontable LIKE'" & numCuenta & "%'")
                        'If existecuenta2.Rows.Count > 0 Then
                        '    MsgBox("La cuenta no se piede modificar or que tiene una cuenta asociada ")
                        '    txtCtacontable.Focus()
                        '    Exit Sub
                        'End If
                        existecuenta = nobj.nCrudListar("select * from cuentascontables where id_ctacontable='" & numCuenta & "'")
                        If existecuenta.Rows.Count > 0 Then
                            MsgBox("La cuenta contable  " & numCuenta & "  ya existe")
                            txtCtacontable.Focus()
                            Exit Sub
                        Else
                            txtNombrectacontable.Focus()
                            cuentaPadre = 0
                        End If
                    End If
                End If
            End If
        End If


        If nomCuenta = "" Then
            MessageBox.Show("Ingrese el Nombre o Descripción de la Cuenta Contable", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf ctaEquiv = "" Then
            MessageBox.Show("Ingrese la Cuenta equivalente en SUNAT e la Cuenta Contable", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf nivelCuenta = 0 Then
            MessageBox.Show("Por favor escoja el nivel de la Cuenta Contable", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf tipoCuenta = 0 Then
            MessageBox.Show("Por favor escoja el Tipo de la Cuenta Contable", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf tipoAnalisis = 0 Then
            MessageBox.Show("Por favor escoja el Tipo de Analisis de la Cuenta Contable", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf accion = "nuevo" Then
            If banco = 0 And moneda = 0 And ctaCorriente = "" Then
                'cuando no escoges banco, ni moneda ni cuenta corriente 
                campos = "id_empresa@id_ctacontable@subid_ctacontable@nom_ctacontable@equi_sunat@bal_comprobacion@id_nivel_cta_cont@id_tipo_cta_cont@id_analisis_cta_cont@cuenta_debe@cuenta_haber@estado@centrodecostos"
                valores = EmpresaSeleccionada & "@" & numCuenta & "@" & cuentaPadre & "@" & nomCuenta & "@" & ctaEquiv & "@" & balance & "@" & nivelCuenta & "@" & tipoCuenta & "@" & tipoAnalisis & "@" & ctaDebe & "@" & ctaHaber & "@1@" & estadoCC
            Else
                campos = "id_empresa@id_ctacontable@subid_ctacontable@nom_ctacontable@id_banco@cta_cte@id_moneda@equi_sunat@bal_comprobacion@id_nivel_cta_cont@id_tipo_cta_cont@id_analisis_cta_cont@cuenta_debe@cuenta_haber@estado@centrodecostos"
                valores = EmpresaSeleccionada & "@" & numCuenta & "@" & cuentaPadre & "@" & nomCuenta & "@" & banco & "@" & ctaCorriente & "@" & moneda & "@" & ctaEquiv & "@" & balance & "@" & nivelCuenta & "@" & tipoCuenta & "@" & tipoAnalisis & "@" & ctaDebe & "@" & ctaHaber & "@1@" & estadoCC
            End If
            dato = nobj.nCrudInsertar("@", "cuentascontables", campos, valores)
            If dato = "ok" Then
                MessageBox.Show("La cuenta fue registrada correctamente", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'MsgBox("¡Cuenta registrada correctamente!")
                cargarlistadecuentas()
                desactivarbotonesgc()
                activarbotonesnmes()
                ' dgvLista.Refresh()
                desactivarcajas()
                activargrid()
                ' listarUsuarios()
                tipo = ""
                cargardatoscuenta()
            Else
                MsgBox("Error : " & dato)
            End If
        ElseIf accion = "modificar" Then
            If banco = 0 Or IsDBNull(banco) And moneda = 0 And ctaCorriente = "" Then
                'cuando no escoges banco, ni moneda ni cuenta corriente 
                campos = "id_ctacontable@subid_ctacontable@nom_ctacontable@equi_sunat@bal_comprobacion@id_nivel_cta_cont@id_tipo_cta_cont@id_analisis_cta_cont@cuenta_debe@cuenta_haber@estado@centrodecostos"
                valores = numCuenta & "@" & cuentaPadre & "@" & nomCuenta & "@" & ctaEquiv & "@" & balance & "@" & nivelCuenta & "@" & tipoCuenta & "@" & tipoAnalisis & "@" & ctaDebe & "@" & ctaHaber & "@1@" & estadoCC
            Else
                campos = "id_ctacontable@subid_ctacontable@nom_ctacontable@id_banco@cta_cte@id_moneda@equi_sunat@bal_comprobacion@id_nivel_cta_cont@id_tipo_cta_cont@id_analisis_cta_cont@cuenta_debe@cuenta_haber@estado@centrodecostos"
                valores = numCuenta & "@" & cuentaPadre & "@" & nomCuenta & "@" & banco & "@" & ctaCorriente & "@" & moneda & "@" & ctaEquiv & "@" & balance & "@" & nivelCuenta & "@" & tipoCuenta & "@" & tipoAnalisis & "@" & ctaDebe & "@" & ctaHaber & "@1@" & estadoCC
            End If
            'campos = "id_ctacontable@nom_ctacontable@id_banco@cta_cte@id_moneda@equi_sunat@bal_comprobacion@id_nivel_cta_cont@id_tipo_cta_cont@id_analisis_cta_cont@cuenta_debe@cuenta_haber@estado@id_empresa"
            'valores = numCuenta & "@" & nomCuenta & "@" & banco & "@" & ctaCorriente & "@" & moneda & "@" & ctaEquiv & "@" & balance & "@" & nivelCuenta & "@" & tipoCuenta & "@" & tipoAnalisis & "@" & ctaDebe & "@" & ctaHaber & "@1@" & EmpresaSeleccionada
            'MsgBox(banco)
            condicion = "id_ctacontable='" & numcuenta1 & "' And id_empresa='" & EmpresaSeleccionada & "'"
            'MsgBox(condicion)
            dato = nobj.nCrudActualizar("@", "cuentascontables", campos, valores, condicion)
            If dato = "ok" Then
                MsgBox("¡Cuenta actualizada correctamente!")

                ' cargarlistadecuentas()
                cargardatoscuenta()
                desactivarbotonesgc()
                activarbotonesnmes()
                ' dgvLista.Refresh()
                desactivarcajas()
                activargrid()
                ' listarUsuarios()
                tipo = ""
                numcuenta1 = ""
                cargarlistadecuentas()
                ' codigoCeldaSeleccionada()
                'cargardatoscuentamodificada()
                bandera = True
            Else
                MsgBox("Error: " & dato)

            End If
        End If


    End Sub

    Private Sub cboBanco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBanco.SelectedIndexChanged

    End Sub



    Private Sub txtCtacontable_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub gbCtasContables_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtCtacontable_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCtacontable.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("La cuenta Contable sólo Acepta Números", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'If Not IsNumeric(e.KeyChar) Then
        '    e.Handled = True
        'End If

    End Sub



    Private Sub txtEquivalente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEquivalente.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("La cuenta Contable sólo Acepta Números", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtEquivalente_TextChanged(sender As Object, e As EventArgs) Handles txtEquivalente.TextChanged

    End Sub

    Private Sub txtCtacontable_LostFocus(sender As Object, e As EventArgs) Handles txtCtacontable.LostFocus

        numcuenta = txtCtacontable.Text
        Dim numcar As Integer
        Dim numcuenta2 As Integer
        numcar = numcuenta.Length

        'If txtCtacontable.Text = "" Then
        '    txtNombrectacontable.Focus()
        'ElseIf banderacancelar = True Then
        '    dgvLista.Focus()
        'Else

        If numcar >= 2 Then
            numcuenta2 = CInt(numcuenta.Substring(0, 2))
            If numcuenta2 = 10 Then
                gbCuenta10.Enabled = True
            Else
                gbCuenta10.Enabled = False
            End If
        End If
    End Sub

    Private Sub txtCtacontable_TextChanged_1(sender As Object, e As EventArgs) Handles txtCtacontable.TextChanged

    End Sub

    Private Sub dgvLista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLista.CellContentClick

    End Sub
End Class