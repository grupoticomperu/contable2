Imports Negocios
Imports Entidades
Public Class LoginForm1
    Private nobj As New nUsuarios
    Private userE As New UsuariosE

    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtUser.Text.Trim.Length = 0 Then
            MessageBox.Show("Ingrese el usuario", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtPassword.Text.Trim.Length = 0 Then
            MessageBox.Show("Ingrese el Password", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            userE.usuarios = txtUser.Text.Trim
            userE.clave_usuarios = txtPassword.Text.Trim
            Dim tbUser As DataTable = nobj.nUsuarioIniciarSesion(userE)
            If tbUser.Rows.Count > 0 Then
                

                'guarda usuario que inicia sesion
                CodigoUsuarioSession = Integer.Parse(tbUser.Rows(0)("id_usuario").ToString)
                NombreUsuarioSession = tbUser.Rows(0)("login_usuario").ToString
                TipoUsuarioSession = tbUser.Rows(0)("tipo_usuario").ToString

                'comprobar si tiene asignado una empresa de lo contrario no permitirle entrar
                Dim tbUserEmpresa As DataTable = nobj.nUsuarioEmpresa(CodigoUsuarioSession)
                If tbUserEmpresa.Rows.Count <= 0 Then
                    MessageBox.Show("El Usuario No tienen asignado ninguna empresa" & vbCrLf & "Intente como administrador...", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    txtUser.Focus()
                    txtUser.SelectAll()
                    Exit Sub
                Else
                    Me.Hide()
                    frmEleccionEmpresa.Show()
                    'MDIPrincipal.Show()
                    ' Me.Close()
                    'Me.Dispose()
                    'Timer1.Enabled = True
                End If
                


               
            Else
                'Timer1.Enabled = False
                MessageBox.Show("El Usuario y/o la clave ingresado no son correctos" & vbCrLf & "Intente nuevamente...", "TICOM CONTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                txtUser.Focus()
                txtUser.SelectAll()
            End If
        End If
        
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MDIPrincipal.Show()
        ' Me.Dispose()
    End Sub
End Class
