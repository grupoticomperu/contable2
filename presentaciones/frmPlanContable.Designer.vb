<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlanContable
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
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.id_plancontable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_ctacontable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subid_ctacontable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom_ctacontable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom_nivelctacontable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom_tipoctacontable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenta_debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenta_haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbCuenta10 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.txtCtacte = New System.Windows.Forms.TextBox()
        Me.cboBanco = New System.Windows.Forms.ComboBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbCtasContables = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboBalance = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboAnalisis = New System.Windows.Forms.ComboBox()
        Me.chkCentrodecostos = New System.Windows.Forms.CheckBox()
        Me.cboTipoCuenta = New System.Windows.Forms.ComboBox()
        Me.cboNivelCuenta = New System.Windows.Forms.ComboBox()
        Me.txtNombrectacontable = New System.Windows.Forms.TextBox()
        Me.txtEquivalente = New System.Windows.Forms.TextBox()
        Me.txtDebe = New System.Windows.Forms.TextBox()
        Me.txtHaber = New System.Windows.Forms.TextBox()
        Me.txtCtacontable = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCuenta10.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gbCtasContables.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(11, 13)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnNuevo.Size = New System.Drawing.Size(150, 27)
        Me.btnNuevo.TabIndex = 224
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(171, 13)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnModificar.Size = New System.Drawing.Size(150, 27)
        Me.btnModificar.TabIndex = 223
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(489, 13)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnCancelar.Size = New System.Drawing.Size(150, 27)
        Me.btnCancelar.TabIndex = 195
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(330, 13)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnGuardar.Size = New System.Drawing.Size(150, 27)
        Me.btnGuardar.TabIndex = 192
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnBuscarProducto.FlatAppearance.BorderSize = 0
        Me.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarProducto.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnBuscarProducto.ForeColor = System.Drawing.Color.White
        Me.btnBuscarProducto.Location = New System.Drawing.Point(458, 32)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnBuscarProducto.Size = New System.Drawing.Size(83, 30)
        Me.btnBuscarProducto.TabIndex = 219
        Me.btnBuscarProducto.Text = "Buscar"
        Me.btnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarProducto.UseVisualStyleBackColor = False
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.AllowUserToOrderColumns = True
        Me.dgvLista.BackgroundColor = System.Drawing.Color.White
        Me.dgvLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgvLista.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgvLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_plancontable, Me.id_ctacontable, Me.subid_ctacontable, Me.nom_ctacontable, Me.nom_nivelctacontable, Me.nom_tipoctacontable, Me.cuenta_debe, Me.cuenta_haber, Me.estado})
        Me.dgvLista.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgvLista.Location = New System.Drawing.Point(40, 94)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.ReadOnly = True
        Me.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLista.Size = New System.Drawing.Size(968, 261)
        Me.dgvLista.TabIndex = 217
        '
        'id_plancontable
        '
        Me.id_plancontable.DataPropertyName = "id_empresa"
        Me.id_plancontable.HeaderText = "Empresa"
        Me.id_plancontable.Name = "id_plancontable"
        Me.id_plancontable.ReadOnly = True
        Me.id_plancontable.Visible = False
        '
        'id_ctacontable
        '
        Me.id_ctacontable.DataPropertyName = "id_ctacontable"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.id_ctacontable.DefaultCellStyle = DataGridViewCellStyle1
        Me.id_ctacontable.HeaderText = "Cuenta Contable"
        Me.id_ctacontable.Name = "id_ctacontable"
        Me.id_ctacontable.ReadOnly = True
        '
        'subid_ctacontable
        '
        Me.subid_ctacontable.DataPropertyName = "subid_ctacontable"
        Me.subid_ctacontable.HeaderText = "sub_id"
        Me.subid_ctacontable.Name = "subid_ctacontable"
        Me.subid_ctacontable.ReadOnly = True
        Me.subid_ctacontable.Visible = False
        Me.subid_ctacontable.Width = 50
        '
        'nom_ctacontable
        '
        Me.nom_ctacontable.DataPropertyName = "nom_ctacontable"
        Me.nom_ctacontable.HeaderText = "Nombre de la cuenta Contable"
        Me.nom_ctacontable.Name = "nom_ctacontable"
        Me.nom_ctacontable.ReadOnly = True
        Me.nom_ctacontable.Width = 300
        '
        'nom_nivelctacontable
        '
        Me.nom_nivelctacontable.DataPropertyName = "nom_nivelctacontable"
        Me.nom_nivelctacontable.HeaderText = "Nivel Cuenta"
        Me.nom_nivelctacontable.Name = "nom_nivelctacontable"
        Me.nom_nivelctacontable.ReadOnly = True
        Me.nom_nivelctacontable.Width = 150
        '
        'nom_tipoctacontable
        '
        Me.nom_tipoctacontable.DataPropertyName = "nom_tipoctacontable"
        Me.nom_tipoctacontable.HeaderText = "Tipo Cuenta"
        Me.nom_tipoctacontable.Name = "nom_tipoctacontable"
        Me.nom_tipoctacontable.ReadOnly = True
        Me.nom_tipoctacontable.Width = 150
        '
        'cuenta_debe
        '
        Me.cuenta_debe.DataPropertyName = "cuenta_debe"
        Me.cuenta_debe.HeaderText = "Debe"
        Me.cuenta_debe.Name = "cuenta_debe"
        Me.cuenta_debe.ReadOnly = True
        Me.cuenta_debe.Width = 88
        '
        'cuenta_haber
        '
        Me.cuenta_haber.DataPropertyName = "cuenta_haber"
        Me.cuenta_haber.HeaderText = "Haber"
        Me.cuenta_haber.Name = "cuenta_haber"
        Me.cuenta_haber.ReadOnly = True
        Me.cuenta_haber.Width = 88
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        Me.estado.HeaderText = "estado"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        Me.estado.Visible = False
        '
        'gbCuenta10
        '
        Me.gbCuenta10.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.gbCuenta10.Controls.Add(Me.Label3)
        Me.gbCuenta10.Controls.Add(Me.Label2)
        Me.gbCuenta10.Controls.Add(Me.Label1)
        Me.gbCuenta10.Controls.Add(Me.cboMoneda)
        Me.gbCuenta10.Controls.Add(Me.txtCtacte)
        Me.gbCuenta10.Controls.Add(Me.cboBanco)
        Me.gbCuenta10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCuenta10.Location = New System.Drawing.Point(760, 378)
        Me.gbCuenta10.Name = "gbCuenta10"
        Me.gbCuenta10.Size = New System.Drawing.Size(248, 156)
        Me.gbCuenta10.TabIndex = 202
        Me.gbCuenta10.TabStop = False
        Me.gbCuenta10.Text = "Para La cuenta 10"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 234
        Me.Label3.Text = "Moneda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 233
        Me.Label2.Text = "Cuenta Corriente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 231
        Me.Label1.Text = "Banco"
        '
        'cboMoneda
        '
        Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(29, 121)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(191, 24)
        Me.cboMoneda.TabIndex = 13
        '
        'txtCtacte
        '
        Me.txtCtacte.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtacte.Location = New System.Drawing.Point(30, 80)
        Me.txtCtacte.Name = "txtCtacte"
        Me.txtCtacte.Size = New System.Drawing.Size(191, 23)
        Me.txtCtacte.TabIndex = 12
        '
        'cboBanco
        '
        Me.cboBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBanco.FormattingEnabled = True
        Me.cboBanco.Location = New System.Drawing.Point(29, 35)
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Size = New System.Drawing.Size(191, 24)
        Me.cboBanco.TabIndex = 11
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(47, 36)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(405, 23)
        Me.TextBox7.TabIndex = 228
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 229
        Me.Label5.Text = "Cuenta Contable"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(648, 13)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnEliminar.Size = New System.Drawing.Size(150, 27)
        Me.btnEliminar.TabIndex = 230
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(857, 17)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 45)
        Me.Button2.TabIndex = 231
        Me.Button2.Text = "Exportar Excel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(806, 13)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnSalir.Size = New System.Drawing.Size(150, 27)
        Me.btnSalir.TabIndex = 232
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(701, 17)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(150, 45)
        Me.Button4.TabIndex = 233
        Me.Button4.Text = "Importar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Location = New System.Drawing.Point(38, 540)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(969, 51)
        Me.Panel1.TabIndex = 234
        '
        'gbCtasContables
        '
        Me.gbCtasContables.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.gbCtasContables.Controls.Add(Me.Label4)
        Me.gbCtasContables.Controls.Add(Me.cboBalance)
        Me.gbCtasContables.Controls.Add(Me.Label21)
        Me.gbCtasContables.Controls.Add(Me.Label20)
        Me.gbCtasContables.Controls.Add(Me.Label19)
        Me.gbCtasContables.Controls.Add(Me.Label18)
        Me.gbCtasContables.Controls.Add(Me.Label15)
        Me.gbCtasContables.Controls.Add(Me.Label16)
        Me.gbCtasContables.Controls.Add(Me.Label14)
        Me.gbCtasContables.Controls.Add(Me.Label13)
        Me.gbCtasContables.Controls.Add(Me.cboAnalisis)
        Me.gbCtasContables.Controls.Add(Me.chkCentrodecostos)
        Me.gbCtasContables.Controls.Add(Me.cboTipoCuenta)
        Me.gbCtasContables.Controls.Add(Me.cboNivelCuenta)
        Me.gbCtasContables.Controls.Add(Me.txtNombrectacontable)
        Me.gbCtasContables.Controls.Add(Me.txtEquivalente)
        Me.gbCtasContables.Controls.Add(Me.txtDebe)
        Me.gbCtasContables.Controls.Add(Me.txtHaber)
        Me.gbCtasContables.Controls.Add(Me.txtCtacontable)
        Me.gbCtasContables.Location = New System.Drawing.Point(38, 378)
        Me.gbCtasContables.Name = "gbCtasContables"
        Me.gbCtasContables.Size = New System.Drawing.Size(716, 156)
        Me.gbCtasContables.TabIndex = 235
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(516, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 13)
        Me.Label4.TabIndex = 258
        Me.Label4.Text = "Balace de Comprobación"
        '
        'cboBalance
        '
        Me.cboBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBalance.FormattingEnabled = True
        Me.cboBalance.Items.AddRange(New Object() {"SI", "NO"})
        Me.cboBalance.Location = New System.Drawing.Point(519, 76)
        Me.cboBalance.Name = "cboBalance"
        Me.cboBalance.Size = New System.Drawing.Size(150, 24)
        Me.cboBalance.TabIndex = 6
        Me.cboBalance.Text = "Seleccione"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(522, 100)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(98, 13)
        Me.Label21.TabIndex = 256
        Me.Label21.Text = "Amarre al Haber"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(375, 100)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(94, 13)
        Me.Label20.TabIndex = 255
        Me.Label20.Text = "Amarre al Debe"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(203, 100)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(97, 13)
        Me.Label19.TabIndex = 254
        Me.Label19.Text = "Tipo de Analisis"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(193, 55)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(166, 13)
        Me.Label18.TabIndex = 253
        Me.Label18.Text = "Nivel de la Cuenta Contable"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(354, 55)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(148, 13)
        Me.Label15.TabIndex = 252
        Me.Label15.Text = "Tipo de Cuenta Contable"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(22, 55)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(163, 13)
        Me.Label16.TabIndex = 251
        Me.Label16.Text = "Cuenta equivalente SUNAT"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(193, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(204, 13)
        Me.Label14.TabIndex = 250
        Me.Label14.Text = "Descripción de la Cuenta Contable"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(20, 5)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(147, 13)
        Me.Label13.TabIndex = 249
        Me.Label13.Text = "Nro. de Cuenta Contable"
        '
        'cboAnalisis
        '
        Me.cboAnalisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAnalisis.FormattingEnabled = True
        Me.cboAnalisis.Location = New System.Drawing.Point(205, 117)
        Me.cboAnalisis.Name = "cboAnalisis"
        Me.cboAnalisis.Size = New System.Drawing.Size(159, 24)
        Me.cboAnalisis.TabIndex = 8
        '
        'chkCentrodecostos
        '
        Me.chkCentrodecostos.AutoSize = True
        Me.chkCentrodecostos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCentrodecostos.Location = New System.Drawing.Point(25, 121)
        Me.chkCentrodecostos.Name = "chkCentrodecostos"
        Me.chkCentrodecostos.Size = New System.Drawing.Size(159, 17)
        Me.chkCentrodecostos.TabIndex = 7
        Me.chkCentrodecostos.Text = "Tiene Centro de Costos"
        Me.chkCentrodecostos.UseVisualStyleBackColor = True
        '
        'cboTipoCuenta
        '
        Me.cboTipoCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoCuenta.FormattingEnabled = True
        Me.cboTipoCuenta.Location = New System.Drawing.Point(357, 75)
        Me.cboTipoCuenta.Name = "cboTipoCuenta"
        Me.cboTipoCuenta.Size = New System.Drawing.Size(152, 24)
        Me.cboTipoCuenta.TabIndex = 5
        '
        'cboNivelCuenta
        '
        Me.cboNivelCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNivelCuenta.FormattingEnabled = True
        Me.cboNivelCuenta.Location = New System.Drawing.Point(196, 75)
        Me.cboNivelCuenta.Name = "cboNivelCuenta"
        Me.cboNivelCuenta.Size = New System.Drawing.Size(151, 24)
        Me.cboNivelCuenta.TabIndex = 4
        '
        'txtNombrectacontable
        '
        Me.txtNombrectacontable.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombrectacontable.Location = New System.Drawing.Point(196, 26)
        Me.txtNombrectacontable.Name = "txtNombrectacontable"
        Me.txtNombrectacontable.Size = New System.Drawing.Size(473, 23)
        Me.txtNombrectacontable.TabIndex = 2
        '
        'txtEquivalente
        '
        Me.txtEquivalente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEquivalente.Location = New System.Drawing.Point(22, 76)
        Me.txtEquivalente.Name = "txtEquivalente"
        Me.txtEquivalente.Size = New System.Drawing.Size(158, 23)
        Me.txtEquivalente.TabIndex = 3
        '
        'txtDebe
        '
        Me.txtDebe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDebe.Location = New System.Drawing.Point(373, 118)
        Me.txtDebe.Name = "txtDebe"
        Me.txtDebe.Size = New System.Drawing.Size(136, 23)
        Me.txtDebe.TabIndex = 9
        '
        'txtHaber
        '
        Me.txtHaber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHaber.Location = New System.Drawing.Point(525, 118)
        Me.txtHaber.Name = "txtHaber"
        Me.txtHaber.Size = New System.Drawing.Size(144, 23)
        Me.txtHaber.TabIndex = 10
        '
        'txtCtacontable
        '
        Me.txtCtacontable.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtacontable.Location = New System.Drawing.Point(23, 26)
        Me.txtCtacontable.Name = "txtCtacontable"
        Me.txtCtacontable.Size = New System.Drawing.Size(157, 23)
        Me.txtCtacontable.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel2.Location = New System.Drawing.Point(40, 68)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(969, 5)
        Me.Panel2.TabIndex = 235
        '
        'frmPlanContable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 591)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.gbCtasContables)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.gbCuenta10)
        Me.Controls.Add(Me.btnBuscarProducto)
        Me.Controls.Add(Me.dgvLista)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPlanContable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PLAN CONTABLE - CUENTAS CONTABLES"
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCuenta10.ResumeLayout(False)
        Me.gbCuenta10.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.gbCtasContables.ResumeLayout(False)
        Me.gbCtasContables.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnBuscarProducto As System.Windows.Forms.Button
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents gbCuenta10 As System.Windows.Forms.GroupBox
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents txtCtacte As System.Windows.Forms.TextBox
    Friend WithEvents cboBanco As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents id_plancontable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_ctacontable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subid_ctacontable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nom_ctacontable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nom_nivelctacontable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nom_tipoctacontable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuenta_debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuenta_haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gbCtasContables As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboBalance As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboAnalisis As System.Windows.Forms.ComboBox
    Friend WithEvents chkCentrodecostos As System.Windows.Forms.CheckBox
    Friend WithEvents cboTipoCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents cboNivelCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents txtNombrectacontable As System.Windows.Forms.TextBox
    Friend WithEvents txtEquivalente As System.Windows.Forms.TextBox
    Friend WithEvents txtDebe As System.Windows.Forms.TextBox
    Friend WithEvents txtHaber As System.Windows.Forms.TextBox
    Friend WithEvents txtCtacontable As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
