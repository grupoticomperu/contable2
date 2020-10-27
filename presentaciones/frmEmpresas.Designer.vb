<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpresas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.gbEmpresas = New System.Windows.Forms.GroupBox()
        Me.txtMoneda = New System.Windows.Forms.TextBox()
        Me.chbEstado = New System.Windows.Forms.CheckBox()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.chbPercepcion = New System.Windows.Forms.CheckBox()
        Me.chbRetencion = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUbigeo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtLogo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNomComercial = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.cboPlancontable = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNom_ap_usuarios = New System.Windows.Forms.TextBox()
        Me.lblTituloForm = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.id_empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom_comercial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.razon_social = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ruc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dir_empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado_empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbPlancontable = New System.Windows.Forms.GroupBox()
        Me.rbt1 = New System.Windows.Forms.RadioButton()
        Me.rbt2 = New System.Windows.Forms.RadioButton()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.gbEmpresas.SuspendLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPlancontable.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnImprimir.ForeColor = System.Drawing.Color.White
        Me.btnImprimir.Location = New System.Drawing.Point(650, 19)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(78, 30)
        Me.btnImprimir.TabIndex = 239
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'btnExportar
        '
        Me.btnExportar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnExportar.ForeColor = System.Drawing.Color.White
        Me.btnExportar.Location = New System.Drawing.Point(566, 19)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(78, 30)
        Me.btnExportar.TabIndex = 238
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = False
        '
        'gbEmpresas
        '
        Me.gbEmpresas.Controls.Add(Me.txtMoneda)
        Me.gbEmpresas.Controls.Add(Me.chbEstado)
        Me.gbEmpresas.Controls.Add(Me.cboMes)
        Me.gbEmpresas.Controls.Add(Me.lblMes)
        Me.gbEmpresas.Controls.Add(Me.cboPeriodo)
        Me.gbEmpresas.Controls.Add(Me.lblPeriodo)
        Me.gbEmpresas.Controls.Add(Me.Button1)
        Me.gbEmpresas.Controls.Add(Me.Label7)
        Me.gbEmpresas.Controls.Add(Me.txtCelular)
        Me.gbEmpresas.Controls.Add(Me.Label6)
        Me.gbEmpresas.Controls.Add(Me.txtEmail)
        Me.gbEmpresas.Controls.Add(Me.Label5)
        Me.gbEmpresas.Controls.Add(Me.txtTelefono)
        Me.gbEmpresas.Controls.Add(Me.chbPercepcion)
        Me.gbEmpresas.Controls.Add(Me.chbRetencion)
        Me.gbEmpresas.Controls.Add(Me.Label4)
        Me.gbEmpresas.Controls.Add(Me.Label3)
        Me.gbEmpresas.Controls.Add(Me.txtUbigeo)
        Me.gbEmpresas.Controls.Add(Me.Label2)
        Me.gbEmpresas.Controls.Add(Me.txtDireccion)
        Me.gbEmpresas.Controls.Add(Me.Label1)
        Me.gbEmpresas.Controls.Add(Me.txtRuc)
        Me.gbEmpresas.Controls.Add(Me.Label8)
        Me.gbEmpresas.Controls.Add(Me.txtLogo)
        Me.gbEmpresas.Controls.Add(Me.Label12)
        Me.gbEmpresas.Controls.Add(Me.txtNomComercial)
        Me.gbEmpresas.Controls.Add(Me.Label15)
        Me.gbEmpresas.Controls.Add(Me.txtRazonSocial)
        Me.gbEmpresas.Location = New System.Drawing.Point(45, 259)
        Me.gbEmpresas.Name = "gbEmpresas"
        Me.gbEmpresas.Size = New System.Drawing.Size(888, 188)
        Me.gbEmpresas.TabIndex = 237
        Me.gbEmpresas.TabStop = False
        Me.gbEmpresas.Text = "Datos del Usuario"
        '
        'txtMoneda
        '
        Me.txtMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtMoneda.Location = New System.Drawing.Point(280, 83)
        Me.txtMoneda.MaxLength = 11
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.Size = New System.Drawing.Size(125, 20)
        Me.txtMoneda.TabIndex = 262
        '
        'chbEstado
        '
        Me.chbEstado.AutoSize = True
        Me.chbEstado.Location = New System.Drawing.Point(447, 152)
        Me.chbEstado.Name = "chbEstado"
        Me.chbEstado.Size = New System.Drawing.Size(161, 17)
        Me.chbEstado.TabIndex = 261
        Me.chbEstado.Text = "Estado activo o desactivado"
        Me.chbEstado.UseVisualStyleBackColor = True
        '
        'cboMes
        '
        Me.cboMes.FormattingEnabled = True
        Me.cboMes.Location = New System.Drawing.Point(280, 147)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(135, 21)
        Me.cboMes.TabIndex = 259
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblMes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblMes.Location = New System.Drawing.Point(249, 152)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(27, 13)
        Me.lblMes.TabIndex = 258
        Me.lblMes.Text = "Mes"
        '
        'cboPeriodo
        '
        Me.cboPeriodo.FormattingEnabled = True
        Me.cboPeriodo.Location = New System.Drawing.Point(92, 147)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(125, 21)
        Me.cboPeriodo.TabIndex = 257
        '
        'lblPeriodo
        '
        Me.lblPeriodo.AutoSize = True
        Me.lblPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblPeriodo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPeriodo.Location = New System.Drawing.Point(46, 151)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(43, 13)
        Me.lblPeriodo.TabIndex = 256
        Me.lblPeriodo.Text = "Periodo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(799, 113)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 23)
        Me.Button1.TabIndex = 254
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(237, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 253
        Me.Label7.Text = "Celular"
        '
        'txtCelular
        '
        Me.txtCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCelular.Location = New System.Drawing.Point(280, 116)
        Me.txtCelular.MaxLength = 11
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(135, 20)
        Me.txtCelular.TabIndex = 252
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(423, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 251
        Me.Label6.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtEmail.Location = New System.Drawing.Point(458, 116)
        Me.txtEmail.MaxLength = 11
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(156, 20)
        Me.txtEmail.TabIndex = 250
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(40, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 249
        Me.Label5.Text = "Teléfono"
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTelefono.Location = New System.Drawing.Point(92, 115)
        Me.txtTelefono.MaxLength = 11
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(125, 20)
        Me.txtTelefono.TabIndex = 248
        '
        'chbPercepcion
        '
        Me.chbPercepcion.AutoSize = True
        Me.chbPercepcion.Location = New System.Drawing.Point(580, 86)
        Me.chbPercepcion.Name = "chbPercepcion"
        Me.chbPercepcion.Size = New System.Drawing.Size(131, 17)
        Me.chbPercepcion.TabIndex = 247
        Me.chbPercepcion.Text = "Agente de percepción"
        Me.chbPercepcion.UseVisualStyleBackColor = True
        '
        'chbRetencion
        '
        Me.chbRetencion.AutoSize = True
        Me.chbRetencion.Location = New System.Drawing.Point(447, 86)
        Me.chbRetencion.Name = "chbRetencion"
        Me.chbRetencion.Size = New System.Drawing.Size(127, 17)
        Me.chbRetencion.TabIndex = 246
        Me.chbRetencion.Text = "Agente de Retención"
        Me.chbRetencion.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(230, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 245
        Me.Label4.Text = "Moneda"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(48, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 243
        Me.Label3.Text = "Ubigeo"
        '
        'txtUbigeo
        '
        Me.txtUbigeo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtUbigeo.Location = New System.Drawing.Point(92, 84)
        Me.txtUbigeo.MaxLength = 11
        Me.txtUbigeo.Name = "txtUbigeo"
        Me.txtUbigeo.Size = New System.Drawing.Size(125, 20)
        Me.txtUbigeo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(59, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 241
        Me.Label2.Text = "RUC"
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtDireccion.Location = New System.Drawing.Point(381, 54)
        Me.txtDireccion.MaxLength = 100
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(425, 20)
        Me.txtDireccion.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(326, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 239
        Me.Label1.Text = "Dirección"
        '
        'txtRuc
        '
        Me.txtRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtRuc.Location = New System.Drawing.Point(92, 54)
        Me.txtRuc.MaxLength = 11
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(207, 20)
        Me.txtRuc.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(620, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 235
        Me.Label8.Text = "Logo"
        '
        'txtLogo
        '
        Me.txtLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtLogo.Location = New System.Drawing.Point(655, 116)
        Me.txtLogo.MaxLength = 11
        Me.txtLogo.Name = "txtLogo"
        Me.txtLogo.Size = New System.Drawing.Size(138, 20)
        Me.txtLogo.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(8, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 231
        Me.Label12.Text = "Nom. Comercial"
        '
        'txtNomComercial
        '
        Me.txtNomComercial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtNomComercial.Location = New System.Drawing.Point(92, 24)
        Me.txtNomComercial.MaxLength = 100
        Me.txtNomComercial.Name = "txtNomComercial"
        Me.txtNomComercial.Size = New System.Drawing.Size(204, 20)
        Me.txtNomComercial.TabIndex = 230
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(308, 27)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 13)
        Me.Label15.TabIndex = 224
        Me.Label15.Text = "Razón Social"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtRazonSocial.Location = New System.Drawing.Point(381, 24)
        Me.txtRazonSocial.MaxLength = 100
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(425, 20)
        Me.txtRazonSocial.TabIndex = 223
        '
        'cboPlancontable
        '
        Me.cboPlancontable.FormattingEnabled = True
        Me.cboPlancontable.Location = New System.Drawing.Point(177, 27)
        Me.cboPlancontable.Name = "cboPlancontable"
        Me.cboPlancontable.Size = New System.Drawing.Size(151, 21)
        Me.cboPlancontable.TabIndex = 256
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(663, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 13)
        Me.Label13.TabIndex = 227
        Me.Label13.Text = "Código Empresa"
        '
        'txtNom_ap_usuarios
        '
        Me.txtNom_ap_usuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtNom_ap_usuarios.Location = New System.Drawing.Point(753, 49)
        Me.txtNom_ap_usuarios.MaxLength = 1000
        Me.txtNom_ap_usuarios.Name = "txtNom_ap_usuarios"
        Me.txtNom_ap_usuarios.Size = New System.Drawing.Size(84, 20)
        Me.txtNom_ap_usuarios.TabIndex = 1
        '
        'lblTituloForm
        '
        Me.lblTituloForm.AutoSize = True
        Me.lblTituloForm.BackColor = System.Drawing.Color.Transparent
        Me.lblTituloForm.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.lblTituloForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblTituloForm.Location = New System.Drawing.Point(27, -12)
        Me.lblTituloForm.Name = "lblTituloForm"
        Me.lblTituloForm.Padding = New System.Windows.Forms.Padding(10)
        Me.lblTituloForm.Size = New System.Drawing.Size(157, 53)
        Me.lblTituloForm.TabIndex = 236
        Me.lblTituloForm.Text = "Empresas"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label10.Location = New System.Drawing.Point(42, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 16)
        Me.Label10.TabIndex = 235
        Me.Label10.Text = "Dato a buscar:"
        '
        'txtDato
        '
        Me.txtDato.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtDato.Location = New System.Drawing.Point(137, 41)
        Me.txtDato.MaxLength = 1000
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(227, 25)
        Me.txtDato.TabIndex = 234
        Me.txtDato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(370, 38)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(78, 30)
        Me.btnBuscar.TabIndex = 233
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.dgvLista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLista.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_empresa, Me.nom_comercial, Me.razon_social, Me.ruc, Me.dir_empresa, Me.estado_empresa})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvLista.Location = New System.Drawing.Point(45, 74)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.ReadOnly = True
        Me.dgvLista.Size = New System.Drawing.Size(842, 177)
        Me.dgvLista.TabIndex = 232
        '
        'id_empresa
        '
        Me.id_empresa.DataPropertyName = "id_empresa"
        Me.id_empresa.HeaderText = "id"
        Me.id_empresa.Name = "id_empresa"
        Me.id_empresa.ReadOnly = True
        Me.id_empresa.Width = 50
        '
        'nom_comercial
        '
        Me.nom_comercial.DataPropertyName = "nom_comercial"
        Me.nom_comercial.HeaderText = "Nom Comercial"
        Me.nom_comercial.Name = "nom_comercial"
        Me.nom_comercial.ReadOnly = True
        Me.nom_comercial.Width = 150
        '
        'razon_social
        '
        Me.razon_social.DataPropertyName = "razon_social"
        Me.razon_social.HeaderText = "Razón Social"
        Me.razon_social.Name = "razon_social"
        Me.razon_social.ReadOnly = True
        Me.razon_social.Width = 200
        '
        'ruc
        '
        Me.ruc.DataPropertyName = "ruc"
        Me.ruc.HeaderText = "RUC"
        Me.ruc.Name = "ruc"
        Me.ruc.ReadOnly = True
        Me.ruc.Width = 120
        '
        'dir_empresa
        '
        Me.dir_empresa.DataPropertyName = "dir_empresa"
        Me.dir_empresa.HeaderText = "Dirección"
        Me.dir_empresa.Name = "dir_empresa"
        Me.dir_empresa.ReadOnly = True
        Me.dir_empresa.Width = 230
        '
        'estado_empresa
        '
        Me.estado_empresa.DataPropertyName = "estado_empresa"
        Me.estado_empresa.HeaderText = "Estado"
        Me.estado_empresa.Name = "estado_empresa"
        Me.estado_empresa.ReadOnly = True
        Me.estado_empresa.Width = 60
        '
        'gbPlancontable
        '
        Me.gbPlancontable.Controls.Add(Me.rbt1)
        Me.gbPlancontable.Controls.Add(Me.rbt2)
        Me.gbPlancontable.Controls.Add(Me.cboPlancontable)
        Me.gbPlancontable.Location = New System.Drawing.Point(45, 453)
        Me.gbPlancontable.Name = "gbPlancontable"
        Me.gbPlancontable.Size = New System.Drawing.Size(842, 75)
        Me.gbPlancontable.TabIndex = 240
        Me.gbPlancontable.TabStop = False
        Me.gbPlancontable.Text = "Plan Contable"
        '
        'rbt1
        '
        Me.rbt1.AutoSize = True
        Me.rbt1.Location = New System.Drawing.Point(25, 29)
        Me.rbt1.Name = "rbt1"
        Me.rbt1.Size = New System.Drawing.Size(137, 17)
        Me.rbt1.TabIndex = 258
        Me.rbt1.TabStop = True
        Me.rbt1.Text = "Copiar plan contable de"
        Me.rbt1.UseVisualStyleBackColor = True
        '
        'rbt2
        '
        Me.rbt2.AutoSize = True
        Me.rbt2.Location = New System.Drawing.Point(434, 27)
        Me.rbt2.Name = "rbt2"
        Me.rbt2.Size = New System.Drawing.Size(334, 17)
        Me.rbt2.TabIndex = 257
        Me.rbt2.TabStop = True
        Me.rbt2.Text = "Crear plan contable nuevo, se creará el plan contable desde cero"
        Me.rbt2.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(123, 550)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(98, 30)
        Me.btnNuevo.TabIndex = 226
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(444, 550)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(106, 30)
        Me.btnCancelar.TabIndex = 229
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(328, 550)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(114, 30)
        Me.btnGuardar.TabIndex = 228
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(227, 550)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(95, 30)
        Me.btnModificar.TabIndex = 227
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(668, 550)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(106, 30)
        Me.btnSalir.TabIndex = 231
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(552, 550)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(114, 30)
        Me.btnEliminar.TabIndex = 230
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'frmEmpresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 652)
        Me.Controls.Add(Me.gbPlancontable)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.gbEmpresas)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblTituloForm)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDato)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dgvLista)
        Me.Controls.Add(Me.txtNom_ap_usuarios)
        Me.Controls.Add(Me.Label13)
        Me.Name = "frmEmpresas"
        Me.Text = "frmEmpresas"
        Me.gbEmpresas.ResumeLayout(False)
        Me.gbEmpresas.PerformLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPlancontable.ResumeLayout(False)
        Me.gbPlancontable.PerformLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents gbEmpresas As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUbigeo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRuc As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtLogo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNomComercial As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtNom_ap_usuarios As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents lblTituloForm As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDato As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents chbPercepcion As System.Windows.Forms.CheckBox
    Friend WithEvents chbRetencion As System.Windows.Forms.CheckBox
    Friend WithEvents cboPlancontable As System.Windows.Forms.ComboBox
    Friend WithEvents gbPlancontable As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents rbt1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbt2 As System.Windows.Forms.RadioButton
    Friend WithEvents cboMes As System.Windows.Forms.ComboBox
    Friend WithEvents lblMes As System.Windows.Forms.Label
    Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents id_empresa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nom_comercial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents razon_social As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ruc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dir_empresa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado_empresa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chbEstado As System.Windows.Forms.CheckBox
    Friend WithEvents txtMoneda As System.Windows.Forms.TextBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
End Class
