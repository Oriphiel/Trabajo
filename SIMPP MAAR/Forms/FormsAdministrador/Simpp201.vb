Imports System.Data.Entity.Migrations

Namespace Forms.FormsAdministrador
    Public Class Simpp201
        Dim _listaUsuarios As List(Of usuario_completo) = New List(Of usuario_completo)
        Dim _persona As persona

        Private Sub Simpp201_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Try
                FillData()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
            If txtnombres.Enabled = False Then
                ActivaDesactiva(Panel1)
                BorradoCajas(Panel1)
                txtfiltro.Enabled = True
                dgvUsuarios.Enabled = True
                Database = New simpp_maarEntities()
                lblIDUsuario.Text = Database.usuarios.Count() + 1
                btnListaPersonas.Enabled = True
                cmbPerfil.Enabled = True
                cmbEstado.Enabled = True
                _persona = Nothing
            End If
        End Sub

        Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
            BorradoCajas(Panel1)
        End Sub

        Private Sub dgvUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
            Handles dgvUsuarios.CellClick
            Try
                If txtnombres.Enabled = True Then
                    Return
                End If
                Database = New simpp_maarEntities()
                Dim user As usuario = Database.usuarios.Find(dgvUsuarios.CurrentRow.Cells(columnName:="ID").Value)
                lblIDUsuario.Text = user.idUsuario
                txtnombres.Text = String.Format("{0} {1}", user.persona.Nombre, user.persona.Apellidos)
                txtclave.Text = user.Password
                txtusuario.Text = user.Username
                If user.Estado = "A" Then
                    cmbEstado.SelectedIndex = 0
                Else
                    cmbEstado.SelectedIndex = 1
                End If
                Dim perfil = Database.perfil_usuario.SingleOrDefault(Function(o) o.idUsuario = user.idUsuario And o.Estado = "A")
                cmbPerfil.SelectedValue = perfil.idPerfil
                Database.Dispose()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try

        End Sub


        ''' <summary>
        ''' Fills the data.
        ''' </summary>
        Public Sub FillData()
            Database = New simpp_maarEntities()
            dgvUsuarios.DataSource = Nothing
            _listaUsuarios = Database.usuario_completo.ToList()
            dgvUsuarios.DataSource = Database.usuario_completo.ToList()
            dgvUsuarios.Refresh()
            cmbPerfil.DataSource = Database.perfils.ToList()
            cmbPerfil.ValueMember = "idPerfil"
            cmbPerfil.DisplayMember = "Detalle"
            Database.Dispose()
        End Sub

        Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
            If txtnombres.Enabled = True Then
                BorradoCajas(Panel1)
                ActivaDesactiva(Panel1)
                lblIDUsuario.Text = Nothing
                btnListaPersonas.Enabled = False
                txtfiltro.Enabled = True
                cmbEstado.Enabled = False
                cmbPerfil.Enabled = False
                btnActualizar.Visible = False
            End If
        End Sub

        Private Sub txtfiltro_TextChanged(sender As Object, e As EventArgs) Handles txtfiltro.TextChanged
            dgvUsuarios.DataSource = _listaUsuarios.Where(Function(o) o.Nombre.Contains(txtfiltro.Text)).ToList()
        End Sub

        Private Sub txtfiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfiltro.KeyPress
            OnlyLetters(e)
        End Sub

        Private Sub btngrabar_Click(sender As Object, e As EventArgs) Handles btngrabar.Click
            If Comprobacion(Panel1) Or txtfiltro.Text.Length = 0 Then
                Try
                    If _persona Is Nothing Then
                        MessageBox.Show("Escoja una persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                    Database = New simpp_maarEntities()
                    Dim entities As usuario = New usuario()
                    entities.idPersona = _persona.idPersona
                    entities.Username = txtusuario.Text
                    entities.Password = txtclave.Text
                    If cmbEstado.SelectedIndex = 0 Then
                        entities.Estado = "A"
                    Else
                        entities.Estado = "I"
                    End If
                    Database.usuarios.AddOrUpdate(entities)
                    Dim perfil As perfil_usuario = New perfil_usuario()
                    perfil.idPerfil = Convert.ToString(cmbPerfil.SelectedValue)
                    perfil.idUsuario = entities.idUsuario
                    perfil.Estado = "A"
                    Database.perfil_usuario.AddOrUpdate(perfil)
                    Database.SaveChanges()
                    Database.Dispose()
                    BorradoCajas(Panel1)
                    FillData()
                    ActivaDesactiva(Panel1)
                    lblIDUsuario.Text = Nothing
                    btnListaPersonas.Enabled = False
                    txtfiltro.Enabled = True
                    cmbEstado.Enabled = False
                    cmbPerfil.Enabled = False
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End If
        End Sub

        Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
            If txtnombres.Enabled = False And txtnombres.Text.Length > 0 Then
                ActivaDesactiva(Panel1)
                btnActualizar.Visible = True
                cmbPerfil.Enabled = True
                cmbEstado.Enabled = True
                btnListaPersonas.Enabled = True
            End If
        End Sub

        Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
            If Comprobacion(Panel1) Or txtfiltro.Text.Length = 0 Then
                Try
                    Database = New simpp_maarEntities()
                    Dim user As usuario = Database.usuarios.Find(Convert.ToInt32(lblIDUsuario.Text))
                    user.Username = txtusuario.Text
                    user.Password = txtclave.Text
                    If cmbEstado.SelectedIndex = 0 Then
                        user.Estado = "A"
                    Else
                        user.Estado = "I"
                    End If
                    Database.usuarios.AddOrUpdate(user)
                    Dim perfil = Database.perfil_usuario.SingleOrDefault(Function(o) o.idUsuario = user.idUsuario And o.Estado = "A")
                    perfil.idPerfil = Convert.ToInt32(cmbPerfil.SelectedValue)
                    Database.SaveChanges()
                    Database.Dispose()
                    BorradoCajas(Panel1)
                    FillData()
                    ActivaDesactiva(Panel1)
                    lblIDUsuario.Text = Nothing
                    btnListaPersonas.Enabled = False
                    txtfiltro.Enabled = True
                    btnActualizar.Visible = False
                    cmbEstado.Enabled = False
                    cmbPerfil.Enabled = False
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End If
        End Sub

        ''' <summary>
        ''' Agregar una persona al formulario para poder relacionar con el usuario
        ''' </summary>
        ''' <param name="person">The person.</param>
        Public Sub AgregarPersona(ByRef person As persona)
            _persona = person
            txtnombres.Text = String.Format("{0} {1}", person.Nombre, person.Apellidos)
        End Sub

        Private Sub btnListaPersonas_Click(sender As Object, e As EventArgs) Handles btnListaPersonas.Click
            ListaPersonas = New Simpp201B()
            ListaPersonas.ShowDialog()
            ListaPersonas.Dispose()
        End Sub

        Private Sub btnDesactivar_Click(sender As Object, e As EventArgs) Handles btnDesactivar.Click
            Try
                Database = New simpp_maarEntities()
                Dim user As usuario = Database.usuarios.Find(dgvUsuarios.CurrentRow.Cells(columnName:="ID").Value)
                user.Estado = "I"
                Database.usuarios.AddOrUpdate(user)
                Database.SaveChanges()
                Database.Dispose()
                FillData()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace
