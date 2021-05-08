<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuariosEmpresa
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.gbCtasContables = New System.Windows.Forms.Panel()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboEmpresas = New System.Windows.Forms.ComboBox()
        Me.cboUsuarios = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.id_plancontable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_ctacontable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subid_ctacontable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.gbCtasContables.SuspendLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(24, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(843, 1)
        Me.Panel2.TabIndex = 244
        '
        'gbCtasContables
        '
        Me.gbCtasContables.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gbCtasContables.Controls.Add(Me.btnGuardar)
        Me.gbCtasContables.Controls.Add(Me.Label18)
        Me.gbCtasContables.Controls.Add(Me.Label15)
        Me.gbCtasContables.Controls.Add(Me.cboEmpresas)
        Me.gbCtasContables.Controls.Add(Me.cboUsuarios)
        Me.gbCtasContables.Location = New System.Drawing.Point(22, 372)
        Me.gbCtasContables.Name = "gbCtasContables"
        Me.gbCtasContables.Size = New System.Drawing.Size(844, 112)
        Me.gbCtasContables.TabIndex = 245
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(663, 32)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnGuardar.Size = New System.Drawing.Size(150, 45)
        Me.btnGuardar.TabIndex = 192
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(23, 23)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 13)
        Me.Label18.TabIndex = 253
        Me.Label18.Text = "Usuarios"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(358, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 13)
        Me.Label15.TabIndex = 252
        Me.Label15.Text = "Empresas"
        '
        'cboEmpresas
        '
        Me.cboEmpresas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmpresas.FormattingEnabled = True
        Me.cboEmpresas.Location = New System.Drawing.Point(359, 43)
        Me.cboEmpresas.Name = "cboEmpresas"
        Me.cboEmpresas.Size = New System.Drawing.Size(276, 24)
        Me.cboEmpresas.TabIndex = 5
        '
        'cboUsuarios
        '
        Me.cboUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUsuarios.FormattingEnabled = True
        Me.cboUsuarios.Location = New System.Drawing.Point(25, 43)
        Me.cboUsuarios.Name = "cboUsuarios"
        Me.cboUsuarios.Size = New System.Drawing.Size(296, 24)
        Me.cboUsuarios.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 240
        Me.Label5.Text = "Usuario / Empresa"
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(31, 35)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(405, 23)
        Me.TextBox7.TabIndex = 239
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnBuscarProducto.FlatAppearance.BorderSize = 0
        Me.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarProducto.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnBuscarProducto.ForeColor = System.Drawing.Color.White
        Me.btnBuscarProducto.Location = New System.Drawing.Point(442, 31)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnBuscarProducto.Size = New System.Drawing.Size(83, 30)
        Me.btnBuscarProducto.TabIndex = 238
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
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_plancontable, Me.id_ctacontable, Me.subid_ctacontable})
        Me.dgvLista.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgvLista.Location = New System.Drawing.Point(24, 93)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.ReadOnly = True
        Me.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLista.Size = New System.Drawing.Size(842, 260)
        Me.dgvLista.TabIndex = 237
        '
        'id_plancontable
        '
        Me.id_plancontable.DataPropertyName = "login_usuario"
        Me.id_plancontable.HeaderText = "Usuario"
        Me.id_plancontable.Name = "id_plancontable"
        Me.id_plancontable.ReadOnly = True
        Me.id_plancontable.Width = 400
        '
        'id_ctacontable
        '
        Me.id_ctacontable.DataPropertyName = "nom_ap_usuarios"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        Me.id_ctacontable.DefaultCellStyle = DataGridViewCellStyle2
        Me.id_ctacontable.HeaderText = "Login"
        Me.id_ctacontable.Name = "id_ctacontable"
        Me.id_ctacontable.ReadOnly = True
        Me.id_ctacontable.Width = 200
        '
        'subid_ctacontable
        '
        Me.subid_ctacontable.DataPropertyName = "razon_social"
        Me.subid_ctacontable.HeaderText = "Empresa"
        Me.subid_ctacontable.Name = "subid_ctacontable"
        Me.subid_ctacontable.ReadOnly = True
        Me.subid_ctacontable.Width = 200
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(716, 13)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnEliminar.Size = New System.Drawing.Size(150, 45)
        Me.btnEliminar.TabIndex = 225
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'frmUsuariosEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 505)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.gbCtasContables)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.btnBuscarProducto)
        Me.Controls.Add(Me.dgvLista)
        Me.Name = "frmUsuariosEmpresa"
        Me.Text = "Usuarios Empresas"
        Me.gbCtasContables.ResumeLayout(False)
        Me.gbCtasContables.PerformLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents gbCtasContables As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cboEmpresas As System.Windows.Forms.ComboBox
    Friend WithEvents cboUsuarios As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarProducto As System.Windows.Forms.Button
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents id_plancontable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_ctacontable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subid_ctacontable As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
