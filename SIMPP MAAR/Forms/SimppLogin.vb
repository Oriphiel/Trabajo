Imports SIMPP_MAAR
Namespace Forms

    Public Class SimppLogin

        Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
            Close()
        End Sub

        Private Sub btnAcept_Click(sender As Object, e As EventArgs) Handles btnAcept.Click
            Dim username = txtUsuario.Text
            Dim password = txtPassword.Text
            ' Se crea un objeto con el que se conecta directamente a la DB por medio del framework llamado Entity Framework
            Database = New simpp_maarEntities()
            Dim nuevo = Database.usuarios.SingleOrDefault(Function(o) o.Username = username And o.Password = password And o.Estado = "A")
            ' Si el existe un usuario con el mismo nombre y el mismo password devuelve verdadero
            If (nuevo IsNot Nothing) Then
                ' Realizamos un mensaje de bienvenida al usuario y mostramos el formulario principal
                MessageBox.Show(String.Format("Bienvenido {0} {1}", nuevo.persona.Nombre, nuevo.persona.Apellidos), "Login correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                User = nuevo.idUsuario
                Dim perfilito = Database.perfil_usuario.SingleOrDefault(Function(o) o.idUsuario = User And o.Estado = "A")
                Dim principlal = New Simpp000(perfilito.idPerfil)
                Database.Dispose()
                principlal.Show()
                Close()
            Else
                MessageBox.Show("Usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUsuario.Text = ""
                txtPassword.Text = ""
            End If
            Database.Dispose()
        End Sub

        Private Sub SimppLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Name = My.Resources.Titulo
        End Sub

        Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
            ' Permite que al realizar Enter en el teclado en el textBox de la contraseña realice la acción del botón aceptar
            If e.KeyChar = Chr(13) Then
                btnAcept.PerformClick()
            End If
        End Sub
    End Class

End Namespace