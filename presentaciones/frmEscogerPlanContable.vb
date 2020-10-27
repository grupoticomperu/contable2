Imports Negocios
Public Class frmEscogerPlanContable
    Dim obj As New nCrud
    Public cuentaInicio As String = ""
    Public cuenta As String = ""
    Public formInicio As String = ""
    Public input As String = ""
    Private Sub frmEscogerPlanContable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLista.RowTemplate.Height = 30
        cargarDatosCuentaContable()
        formatoGrilla()
    End Sub
    Public Sub cargarDatosCuentaContable()
        Dim cuentaInicio2digitos As String
        cuentaInicio2digitos = cuentaInicio
        dgvLista.DataSource = obj.nCrudListar("select * from vista_CuentaContableGrilla where id_ctacontable like '" & cuentaInicio2digitos & "%' order by id_ctacontable asc")
    End Sub
    Private Sub SeleccionarCodigoDeCuenta()
        For i As Integer = 0 To dgvLista.Rows.Count - 1
            For x As Integer = 0 To dgvLista.ColumnCount - 1
                If dgvLista.Rows(i).Cells("id").Value.ToString = cuenta Then
                    dgvLista.CurrentCell = dgvLista.Rows(i).Cells("id")
                End If
            Next
        Next
    End Sub
    Private Sub formatoGrilla()

    End Sub

    Private Sub dgvLista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvLista.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' cargarDatosAAdicionAsientoApertura()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnElegir_Click(sender As Object, e As EventArgs) Handles btnElegir.Click
        ' cargarDatosAAdicionAsientoApertura()
    End Sub
End Class