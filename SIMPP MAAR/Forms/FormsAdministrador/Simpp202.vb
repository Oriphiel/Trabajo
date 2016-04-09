Imports System.Data.Entity.Migrations
Imports SIMPP_MAAR.My.Resources

Namespace Forms.FormsAdministrador
    Public Class Simpp202
        Public _listaPersonas As List(Of staff)

        Private Sub Simpp202_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Try
                AddRows()
                Database = New simpp_maarEntities()
                cmbCiudad.DataSource = Database.ciudads.ToList()
                cmbCiudad.ValueMember = "idCiudad"
                cmbCiudad.DisplayMember = "Detalle"
                cmbNacionalidad.DataSource = Database.nacionalidads.ToList()
                cmbNacionalidad.ValueMember = "idNacionalidad"
                cmbNacionalidad.DisplayMember = "Detalle"
                cmbGenero.SelectedIndex = 0
                cmbEstadoCivil.SelectedIndex = 0
                dtpFechaNacimiento.Value = Now
                Database.Dispose()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
            If txtCedula.Enabled = False Then
                ActivaDesactiva(Panel1)
                BorradoCajas(Panel1)
                txtfiltro.Enabled = True
                cmbCiudad.Enabled = True
                cmbEstadoCivil.Enabled = True
                cmbGenero.Enabled = True
                cmbNacionalidad.Enabled = True
                dtpFechaNacimiento.Enabled = True
                Try
                    Database = New simpp_maarEntities()
                    lblIdPersona.Text = Database.personas.Max(Function(o) o.idPersona) + 1
                    Database.Dispose()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End If
        End Sub

        Private Sub btngrabar_Click(sender As Object, e As EventArgs) Handles btngrabar.Click
            If txtCedula.Enabled = True Then
                ' Comprobamos los controles si están con datos
                txtfiltro.Text = "1"
                If Comprobacion(Panel1) Then
                    Database = New simpp_maarEntities()
                    ' Verificamos que la cédula tenga 10 dígitos, caso contrario no se realizara la acción de grabar en la DB
                    If txtCedula.Text.Length < 10 Then
                        txtfiltro.Text = ""
                        MessageBox.Show("La cédula debe tener 10 dígitos", adver, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Return
                    End If
                    '' Creamos una nueva entidad de la base y verificamos que la cédula no este repetida
                    '' caso contrario no se realizara la acción de grabar en la DB
                    If Database.personas.Any(Function(o) o.Cedula = txtCedula.Text) Then
                        txtfiltro.Text = ""
                        MessageBox.Show(stringCedula, adver, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        Dim persona = New persona()
                        persona.Apellidos = txtApellidos.Text
                        persona.Nombre = txtNombre.Text
                        persona.Cedula = txtCedula.Text
                        persona.IDCiudad = cmbCiudad.SelectedValue
                        persona.Telefono = txtTelefono.Text
                        persona.idUsuario = User
                        persona.Fecha_nacimiento = Format(dtpFechaNacimiento.Value, "yyyy-MM-dd")
                        persona.Correo = txtCorreo.Text
                        persona.Genero = cmbGenero.SelectedItem.ToString()
                        persona.idNacionalidad = cmbNacionalidad.SelectedValue
                        persona.Direccion = txtDireccion.Text
                        persona.Estado_civil = cmbEstadoCivil.SelectedItem.ToString()
                        Database.personas.AddOrUpdate(persona)
                        ActivaDesactiva(Panel1)
                        BorradoCajas(Panel1)
                        txtfiltro.Enabled = True
                        txtfiltro.Text = ""
                        cmbCiudad.Enabled = False
                        cmbEstadoCivil.Enabled = False
                        cmbGenero.Enabled = False
                        cmbNacionalidad.Enabled = False
                        dtpFechaNacimiento.Enabled = False
                        lblIdPersona.Text = ""
                        _listaPersonas.Clear()
                        Database.SaveChanges()
                        AddRows()
                    End If
                Else
                    txtfiltro.Text = ""
                    MessageBox.Show(advertenciaCampoVacio, adver, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End Sub

        Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
            If txtCedula.Enabled = True Then
                ' Comprobamos los controles si están con datos
                txtfiltro.Text = "1"
                If Comprobacion(Panel1) Then
                    Database = New simpp_maarEntities()
                    ' Verificamos que la cédula tenga 10 dígitos, caso contrario no se realizara la acción de grabar en la DB
                    If txtCedula.Text.Length < 10 Then
                        txtfiltro.Text = ""
                        MessageBox.Show("La cédula debe tener 10 dígitos", adver, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Return
                    End If
                    Dim id As Integer = Convert.ToInt32(lblIdPersona.Text)
                    Dim persona = Database.personas.SingleOrDefault(Function(o) o.idPersona = id)
                    persona.Apellidos = txtApellidos.Text
                    persona.Nombre = txtNombre.Text
                    persona.Cedula = txtCedula.Text
                    persona.IDCiudad = cmbCiudad.SelectedValue
                    persona.Telefono = txtTelefono.Text
                    persona.idUsuario = User
                    persona.Fecha_nacimiento = Format(dtpFechaNacimiento.Value, "yyyy-MM-dd")
                    persona.Correo = txtCorreo.Text
                    persona.Genero = cmbGenero.SelectedItem.ToString()
                    persona.idNacionalidad = cmbNacionalidad.SelectedValue
                    persona.Direccion = txtDireccion.Text
                    persona.Estado_civil = cmbEstadoCivil.SelectedItem.ToString()
                    Database.personas.AddOrUpdate(persona)
                    ActivaDesactiva(Panel1)
                    BorradoCajas(Panel1)
                    txtfiltro.Enabled = True
                    txtfiltro.Text = ""
                    cmbCiudad.Enabled = False
                    cmbEstadoCivil.Enabled = False
                    cmbGenero.Enabled = False
                    cmbNacionalidad.Enabled = False
                    dtpFechaNacimiento.Enabled = False
                    lblIdPersona.Text = ""
                    _listaPersonas.Clear()
                    Database.SaveChanges()
                    AddRows()
                    btnActualizar.Visible = False
                Else
                    txtfiltro.Text = ""
                    MessageBox.Show(advertenciaCampoVacio, adver, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End Sub

        Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
            BorradoCajas(Panel1)
        End Sub

        Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
            If txtCedula.Enabled = False And txtNombre.Text.Length > 0 Then
                ActivaDesactiva(Panel1)
                btnActualizar.Visible = True
                txtfiltro.Enabled = True
                cmbCiudad.Enabled = True
                cmbEstadoCivil.Enabled = True
                cmbGenero.Enabled = True
                cmbNacionalidad.Enabled = True
                dtpFechaNacimiento.Enabled = True
            End If
        End Sub

        Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
            If txtCedula.Enabled = True Then
                ActivaDesactiva(Panel1)
                BorradoCajas(Panel1)
                txtfiltro.Enabled = True
                cmbCiudad.Enabled = False
                cmbEstadoCivil.Enabled = False
                cmbGenero.Enabled = False
                cmbNacionalidad.Enabled = False
                dtpFechaNacimiento.Enabled = False
                lblIdPersona.Text = ""
                btnActualizar.Visible = False
            End If
        End Sub

        Private Sub txtfiltro_TextChanged(sender As Object, e As EventArgs) Handles txtfiltro.TextChanged
            Filtro(cmbSearch.SelectedIndex)
        End Sub

        Private Sub dgvPersonas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPersonas.CellClick
            If txtCedula.Enabled = False Then
                Try
                    Database = New simpp_maarEntities()
                    Dim persona As persona = Database.personas.Find(dgvPersonas.CurrentRow.Cells(columnName:="ID").Value)
                    txtCedula.Text = persona.Cedula
                    txtApellidos.Text = persona.Apellidos
                    txtCorreo.Text = persona.Correo
                    txtDireccion.Text = persona.Direccion
                    txtNombre.Text = persona.Nombre
                    txtTelefono.Text = persona.Telefono
                    dtpFechaNacimiento.Text = persona.Fecha_nacimiento.ToString()
                    cmbEstadoCivil.SelectedIndex = cmbEstadoCivil.Items.IndexOf(persona.Estado_civil)
                    cmbGenero.SelectedItem = persona.Genero
                    cmbCiudad.SelectedValue = persona.IDCiudad
                    cmbNacionalidad.SelectedValue = persona.idNacionalidad
                    lblIdPersona.Text = persona.idPersona
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End If
        End Sub

        Private Sub txtCedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCedula.KeyPress
            OnlyNumbers(e)
        End Sub

        ''' <summary>
        ''' Agrega un ROW al DataGridView
        ''' </summary>
        Public Sub AddRows()
            dgvPersonas.DataSource = Nothing
            Database = New simpp_maarEntities()
            _listaPersonas = Database.staffs.ToList()
            dgvPersonas.DataSource = _listaPersonas.ToList()
            With dgvPersonas
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Refresh()
            End With
            Database.Dispose()
        End Sub

        Private Sub Filtro(ByVal opcion As Integer)
            If opcion = 0 Then
                dgvPersonas.DataSource = _listaPersonas.Where(Function(o) o.cedula.Contains(txtfiltro.Text)).ToList()
            ElseIf opcion = 1 Then
                dgvPersonas.DataSource = _listaPersonas.Where(Function(o) o.Nombre.ToLower().Contains(txtfiltro.Text.ToLower())).ToList()
            End If
            dgvPersonas.Refresh()
        End Sub
    End Class
End Namespace