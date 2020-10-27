<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Me.lblTituloForm = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.id_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clave_usuarios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom_ap_usuarios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dir_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.login_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.gbUsuarios = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmailUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDirUsuario = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtLogin_usuario = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtClave_usuarios = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtIdUsuario = New System.Windows.Forms.TextBox()
        Me.rbInactivo = New System.Windows.Forms.RadioButton()
        Me.rbActivo = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNom_ap_usuarios = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTipousuario = New System.Windows.Forms.TextBox()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbUsuarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTituloForm
        '
        Me.lblTituloForm.AutoSize = True
        Me.lblTituloForm.BackColor = System.Drawing.Color.Transparent
        Me.lblTituloForm.Font = New System.Drawing.Font("Century Gothic", 20.25!)
        Me.lblTituloForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblTituloForm.Location = New System.Drawing.Point(17, -4)
        Me.lblTituloForm.Name = "lblTituloForm"
        Me.lblTituloForm.Padding = New System.Windows.Forms.Padding(10)
        Me.lblTituloForm.Size = New System.Drawing.Size(138, 53)
        Me.lblTituloForm.TabIndex = 220
        Me.lblTituloForm.Text = "Usuarios"
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(142, 550)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(95, 30)
        Me.btnModificar.TabIndex = 11
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(38, 550)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(98, 30)
        Me.btnNuevo.TabIndex = 10
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(359, 550)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(106, 30)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(243, 550)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(114, 30)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label10.Location = New System.Drawing.Point(31, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 16)
        Me.Label10.TabIndex = 216
        Me.Label10.Text = "Dato a buscar:"
        '
        'txtDato
        '
        Me.txtDato.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtDato.Location = New System.Drawing.Point(126, 49)
        Me.txtDato.MaxLength = 1000
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(227, 25)
        Me.txtDato.TabIndex = 215
        Me.txtDato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(359, 46)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(78, 30)
        Me.btnBuscar.TabIndex = 214
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
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_usuario, Me.clave_usuarios, Me.nom_ap_usuarios, Me.dir_usuario, Me.email_usuario, Me.login_usuario, Me.tipo_usuario, Me.estado_usuario})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvLista.Location = New System.Drawing.Point(34, 87)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.ReadOnly = True
        Me.dgvLista.Size = New System.Drawing.Size(672, 177)
        Me.dgvLista.TabIndex = 213
        '
        'id_usuario
        '
        Me.id_usuario.DataPropertyName = "id_usuario"
        Me.id_usuario.HeaderText = "id"
        Me.id_usuario.Name = "id_usuario"
        Me.id_usuario.ReadOnly = True
        Me.id_usuario.Visible = False
        '
        'clave_usuarios
        '
        Me.clave_usuarios.DataPropertyName = "clave_usuarios"
        Me.clave_usuarios.HeaderText = "claveusuario"
        Me.clave_usuarios.Name = "clave_usuarios"
        Me.clave_usuarios.ReadOnly = True
        Me.clave_usuarios.Visible = False
        '
        'nom_ap_usuarios
        '
        Me.nom_ap_usuarios.DataPropertyName = "nom_ap_usuarios"
        Me.nom_ap_usuarios.HeaderText = "Nombres y Apellidos"
        Me.nom_ap_usuarios.Name = "nom_ap_usuarios"
        Me.nom_ap_usuarios.ReadOnly = True
        Me.nom_ap_usuarios.Width = 200
        '
        'dir_usuario
        '
        Me.dir_usuario.DataPropertyName = "dir_usuario"
        Me.dir_usuario.HeaderText = "dir_usuario"
        Me.dir_usuario.Name = "dir_usuario"
        Me.dir_usuario.ReadOnly = True
        Me.dir_usuario.Width = 230
        '
        'email_usuario
        '
        Me.email_usuario.DataPropertyName = "email_usuario"
        Me.email_usuario.HeaderText = "email_usuario"
        Me.email_usuario.Name = "email_usuario"
        Me.email_usuario.ReadOnly = True
        Me.email_usuario.Visible = False
        '
        'login_usuario
        '
        Me.login_usuario.DataPropertyName = "login_usuario"
        Me.login_usuario.HeaderText = "Login"
        Me.login_usuario.Name = "login_usuario"
        Me.login_usuario.ReadOnly = True
        Me.login_usuario.Width = 85
        '
        'tipo_usuario
        '
        Me.tipo_usuario.DataPropertyName = "tipo_usuario"
        Me.tipo_usuario.HeaderText = "Tipo usuario"
        Me.tipo_usuario.Name = "tipo_usuario"
        Me.tipo_usuario.ReadOnly = True
        Me.tipo_usuario.Visible = False
        Me.tipo_usuario.Width = 210
        '
        'estado_usuario
        '
        Me.estado_usuario.DataPropertyName = "estado_usuario"
        Me.estado_usuario.HeaderText = "estado"
        Me.estado_usuario.Name = "estado_usuario"
        Me.estado_usuario.ReadOnly = True
        Me.estado_usuario.Width = 90
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(583, 550)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(106, 30)
        Me.btnSalir.TabIndex = 15
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(467, 550)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(114, 30)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'gbUsuarios
        '
        Me.gbUsuarios.Controls.Add(Me.Label4)
        Me.gbUsuarios.Controls.Add(Me.txtCelular)
        Me.gbUsuarios.Controls.Add(Me.Label3)
        Me.gbUsuarios.Controls.Add(Me.txtTelefono)
        Me.gbUsuarios.Controls.Add(Me.Label2)
        Me.gbUsuarios.Controls.Add(Me.txtEmailUsuario)
        Me.gbUsuarios.Controls.Add(Me.Label1)
        Me.gbUsuarios.Controls.Add(Me.txtDirUsuario)
        Me.gbUsuarios.Controls.Add(Me.Label8)
        Me.gbUsuarios.Controls.Add(Me.txtLogin_usuario)
        Me.gbUsuarios.Controls.Add(Me.Label9)
        Me.gbUsuarios.Controls.Add(Me.txtClave_usuarios)
        Me.gbUsuarios.Controls.Add(Me.Label12)
        Me.gbUsuarios.Controls.Add(Me.txtIdUsuario)
        Me.gbUsuarios.Controls.Add(Me.rbInactivo)
        Me.gbUsuarios.Controls.Add(Me.rbActivo)
        Me.gbUsuarios.Controls.Add(Me.Label13)
        Me.gbUsuarios.Controls.Add(Me.txtNom_ap_usuarios)
        Me.gbUsuarios.Controls.Add(Me.Label14)
        Me.gbUsuarios.Controls.Add(Me.Label15)
        Me.gbUsuarios.Controls.Add(Me.txtTipousuario)
        Me.gbUsuarios.Location = New System.Drawing.Point(34, 270)
        Me.gbUsuarios.Name = "gbUsuarios"
        Me.gbUsuarios.Size = New System.Drawing.Size(672, 263)
        Me.gbUsuarios.TabIndex = 223
        Me.gbUsuarios.TabStop = False
        Me.gbUsuarios.Text = "Datos del Usuario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(194, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 245
        Me.Label4.Text = "Celular"
        '
        'txtCelular
        '
        Me.txtCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCelular.Location = New System.Drawing.Point(197, 162)
        Me.txtCelular.MaxLength = 11
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(160, 20)
        Me.txtCelular.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(14, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 243
        Me.Label3.Text = "Teléfono"
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTelefono.Location = New System.Drawing.Point(17, 162)
        Me.txtTelefono.MaxLength = 11
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(160, 20)
        Me.txtTelefono.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(322, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 241
        Me.Label2.Text = "Correo"
        '
        'txtEmailUsuario
        '
        Me.txtEmailUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtEmailUsuario.Location = New System.Drawing.Point(322, 108)
        Me.txtEmailUsuario.MaxLength = 1000
        Me.txtEmailUsuario.Name = "txtEmailUsuario"
        Me.txtEmailUsuario.Size = New System.Drawing.Size(324, 20)
        Me.txtEmailUsuario.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 239
        Me.Label1.Text = "Dirección"
        '
        'txtDirUsuario
        '
        Me.txtDirUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtDirUsuario.Location = New System.Drawing.Point(11, 108)
        Me.txtDirUsuario.MaxLength = 1000
        Me.txtDirUsuario.Name = "txtDirUsuario"
        Me.txtDirUsuario.Size = New System.Drawing.Size(300, 20)
        Me.txtDirUsuario.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(170, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 235
        Me.Label8.Text = "Login"
        '
        'txtLogin_usuario
        '
        Me.txtLogin_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtLogin_usuario.Location = New System.Drawing.Point(173, 222)
        Me.txtLogin_usuario.MaxLength = 11
        Me.txtLogin_usuario.Name = "txtLogin_usuario"
        Me.txtLogin_usuario.Size = New System.Drawing.Size(160, 20)
        Me.txtLogin_usuario.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(336, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 233
        Me.Label9.Text = "Password"
        '
        'txtClave_usuarios
        '
        Me.txtClave_usuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtClave_usuarios.Location = New System.Drawing.Point(339, 222)
        Me.txtClave_usuarios.MaxLength = 11
        Me.txtClave_usuarios.Name = "txtClave_usuarios"
        Me.txtClave_usuarios.Size = New System.Drawing.Size(150, 20)
        Me.txtClave_usuarios.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(459, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 13)
        Me.Label12.TabIndex = 231
        Me.Label12.Text = "Cod. Usuario"
        Me.Label12.Visible = False
        '
        'txtIdUsuario
        '
        Me.txtIdUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtIdUsuario.Location = New System.Drawing.Point(462, 54)
        Me.txtIdUsuario.MaxLength = 11
        Me.txtIdUsuario.Name = "txtIdUsuario"
        Me.txtIdUsuario.Size = New System.Drawing.Size(76, 20)
        Me.txtIdUsuario.TabIndex = 230
        Me.txtIdUsuario.Visible = False
        '
        'rbInactivo
        '
        Me.rbInactivo.AutoSize = True
        Me.rbInactivo.ForeColor = System.Drawing.Color.Black
        Me.rbInactivo.Location = New System.Drawing.Point(88, 222)
        Me.rbInactivo.Name = "rbInactivo"
        Me.rbInactivo.Size = New System.Drawing.Size(63, 17)
        Me.rbInactivo.TabIndex = 7
        Me.rbInactivo.Text = "Inactivo"
        Me.rbInactivo.UseVisualStyleBackColor = True
        '
        'rbActivo
        '
        Me.rbActivo.AutoSize = True
        Me.rbActivo.Checked = True
        Me.rbActivo.ForeColor = System.Drawing.Color.Black
        Me.rbActivo.Location = New System.Drawing.Point(16, 222)
        Me.rbActivo.Name = "rbActivo"
        Me.rbActivo.Size = New System.Drawing.Size(55, 17)
        Me.rbActivo.TabIndex = 6
        Me.rbActivo.TabStop = True
        Me.rbActivo.Text = "Activo"
        Me.rbActivo.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(11, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 13)
        Me.Label13.TabIndex = 227
        Me.Label13.Text = "Nombres y Apellidos"
        '
        'txtNom_ap_usuarios
        '
        Me.txtNom_ap_usuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtNom_ap_usuarios.Location = New System.Drawing.Point(11, 54)
        Me.txtNom_ap_usuarios.MaxLength = 1000
        Me.txtNom_ap_usuarios.Name = "txtNom_ap_usuarios"
        Me.txtNom_ap_usuarios.Size = New System.Drawing.Size(429, 20)
        Me.txtNom_ap_usuarios.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(13, 202)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 13)
        Me.Label14.TabIndex = 225
        Me.Label14.Text = "Estado del usuario:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(550, 34)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 13)
        Me.Label15.TabIndex = 224
        Me.Label15.Text = "Tipo Usuario"
        Me.Label15.Visible = False
        '
        'txtTipousuario
        '
        Me.txtTipousuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTipousuario.Location = New System.Drawing.Point(553, 54)
        Me.txtTipousuario.MaxLength = 11
        Me.txtTipousuario.Name = "txtTipousuario"
        Me.txtTipousuario.Size = New System.Drawing.Size(96, 20)
        Me.txtTipousuario.TabIndex = 223
        Me.txtTipousuario.Visible = False
        '
        'btnExportar
        '
        Me.btnExportar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnExportar.ForeColor = System.Drawing.Color.White
        Me.btnExportar.Location = New System.Drawing.Point(555, 12)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(78, 30)
        Me.btnExportar.TabIndex = 224
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = False
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnImprimir.ForeColor = System.Drawing.Color.White
        Me.btnImprimir.Location = New System.Drawing.Point(639, 12)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(78, 30)
        Me.btnImprimir.TabIndex = 225
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 596)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.gbUsuarios)
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
        Me.Name = "frmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USUARIOS"
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbUsuarios.ResumeLayout(False)
        Me.gbUsuarios.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTituloForm As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDato As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents gbUsuarios As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtLogin_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtClave_usuarios As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtIdUsuario As System.Windows.Forms.TextBox
    Friend WithEvents rbInactivo As System.Windows.Forms.RadioButton
    Friend WithEvents rbActivo As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtNom_ap_usuarios As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTipousuario As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEmailUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDirUsuario As System.Windows.Forms.TextBox
    Friend WithEvents id_usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clave_usuarios As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nom_ap_usuarios As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dir_usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents email_usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents login_usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado_usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
End Class
