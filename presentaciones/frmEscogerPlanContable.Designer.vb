<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEscogerPlanContable
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
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnElegir = New System.Windows.Forms.Button()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.id_ctacontable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom_ctacontable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom_nivelctacontable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom_tipoctacontable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.centrodecostos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Black
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Location = New System.Drawing.Point(21, 364)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(144, 35)
        Me.btnEditar.TabIndex = 207
        Me.btnEditar.Text = "Modificar Cuenta"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnElegir
        '
        Me.btnElegir.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnElegir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnElegir.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnElegir.ForeColor = System.Drawing.Color.White
        Me.btnElegir.Location = New System.Drawing.Point(511, 364)
        Me.btnElegir.Name = "btnElegir"
        Me.btnElegir.Size = New System.Drawing.Size(135, 35)
        Me.btnElegir.TabIndex = 206
        Me.btnElegir.Text = "Elegir cuenta"
        Me.btnElegir.UseVisualStyleBackColor = False
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.AllowUserToOrderColumns = True
        Me.dgvLista.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_ctacontable, Me.nom_ctacontable, Me.nom_nivelctacontable, Me.nom_tipoctacontable, Me.centrodecostos})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLista.Location = New System.Drawing.Point(21, 12)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.ReadOnly = True
        Me.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLista.Size = New System.Drawing.Size(625, 346)
        Me.dgvLista.TabIndex = 205
        '
        'id_ctacontable
        '
        Me.id_ctacontable.DataPropertyName = "id_ctacontable"
        Me.id_ctacontable.HeaderText = "Número"
        Me.id_ctacontable.Name = "id_ctacontable"
        Me.id_ctacontable.ReadOnly = True
        Me.id_ctacontable.Width = 55
        '
        'nom_ctacontable
        '
        Me.nom_ctacontable.DataPropertyName = "nom_ctacontable"
        Me.nom_ctacontable.HeaderText = "Nombre Cuenta contable"
        Me.nom_ctacontable.Name = "nom_ctacontable"
        Me.nom_ctacontable.ReadOnly = True
        Me.nom_ctacontable.Width = 200
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
        '
        'centrodecostos
        '
        Me.centrodecostos.DataPropertyName = "centrodecostos"
        Me.centrodecostos.HeaderText = "Centro de Costo"
        Me.centrodecostos.Name = "centrodecostos"
        Me.centrodecostos.ReadOnly = True
        Me.centrodecostos.Width = 72
        '
        'frmEscogerPlanContable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 442)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnElegir)
        Me.Controls.Add(Me.dgvLista)
        Me.Name = "frmEscogerPlanContable"
        Me.Text = "frmEscogerPlanContable"
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEditar As Button
    Friend WithEvents btnElegir As Button
    Friend WithEvents dgvLista As DataGridView
    Friend WithEvents id_ctacontable As DataGridViewTextBoxColumn
    Friend WithEvents nom_ctacontable As DataGridViewTextBoxColumn
    Friend WithEvents nom_nivelctacontable As DataGridViewTextBoxColumn
    Friend WithEvents nom_tipoctacontable As DataGridViewTextBoxColumn
    Friend WithEvents centrodecostos As DataGridViewTextBoxColumn
End Class
