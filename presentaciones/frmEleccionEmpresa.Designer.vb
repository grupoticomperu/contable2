<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEleccionEmpresa
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
        Me.dgvEmpresas = New System.Windows.Forms.DataGridView()
        Me.id_empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_plancontable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.razon_social = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ruc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dir_empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.dgvEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEmpresas
        '
        Me.dgvEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpresas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_empresa, Me.id_plancontable, Me.razon_social, Me.ruc, Me.dir_empresa})
        Me.dgvEmpresas.Location = New System.Drawing.Point(43, 40)
        Me.dgvEmpresas.Name = "dgvEmpresas"
        Me.dgvEmpresas.Size = New System.Drawing.Size(644, 150)
        Me.dgvEmpresas.TabIndex = 0
        '
        'id_empresa
        '
        Me.id_empresa.DataPropertyName = "id_empresa"
        Me.id_empresa.HeaderText = "id_empresa"
        Me.id_empresa.Name = "id_empresa"
        Me.id_empresa.Visible = False
        '
        'id_plancontable
        '
        Me.id_plancontable.DataPropertyName = "id_plancontable"
        Me.id_plancontable.HeaderText = "plancontable"
        Me.id_plancontable.Name = "id_plancontable"
        Me.id_plancontable.Visible = False
        '
        'razon_social
        '
        Me.razon_social.DataPropertyName = "razon_social"
        Me.razon_social.HeaderText = "Empresa"
        Me.razon_social.Name = "razon_social"
        Me.razon_social.Width = 250
        '
        'ruc
        '
        Me.ruc.DataPropertyName = "ruc"
        Me.ruc.HeaderText = "RUC"
        Me.ruc.Name = "ruc"
        '
        'dir_empresa
        '
        Me.dir_empresa.DataPropertyName = "dir_empresa"
        Me.dir_empresa.HeaderText = "Dirección"
        Me.dir_empresa.Name = "dir_empresa"
        Me.dir_empresa.Width = 250
        '
        'cboPeriodo
        '
        Me.cboPeriodo.FormattingEnabled = True
        Me.cboPeriodo.Location = New System.Drawing.Point(109, 207)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(109, 21)
        Me.cboPeriodo.TabIndex = 1
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(234, 205)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(88, 23)
        Me.btnIngresar.TabIndex = 2
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Periodo"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(328, 205)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(81, 23)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmEleccionEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 269)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.cboPeriodo)
        Me.Controls.Add(Me.dgvEmpresas)
        Me.Name = "frmEleccionEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEleccionEmpresa"
        CType(Me.dgvEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvEmpresas As System.Windows.Forms.DataGridView
    Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents id_empresa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_plancontable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents razon_social As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ruc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dir_empresa As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
