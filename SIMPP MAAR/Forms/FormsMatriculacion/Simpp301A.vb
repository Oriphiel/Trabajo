Imports System.Data.Entity.Migrations
Imports SIMPP_MAAR.My.Resources

Namespace Forms.FormsMatriculacion
    Public Class Simpp301A
        Public _op As Integer
        Public Sub New(opcion As Integer)
            ' Llamada necesaria para el diseñador.
            InitializeComponent()
            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            _op = opcion
        End Sub
        Private Sub Simpp301A_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Try
                '' Al momento de cargar el formulario lo cargamos con algunas cosas, tales como el actual ID que llevaría el representante
                '' las ciudades y nacionalidad en la base de datos, así como indicar la posición el los diferentes Combo-box
                Database = New simpp_maarEntities()
                lblIdRepresentante.Text = Database.representantes.Count() + 1
                cmbCiudad.DataSource = Database.ciudads.ToList()
                cmbCiudad.ValueMember = "idCiudad"
                cmbCiudad.DisplayMember = "Detalle"
                cmbNacionalidad.DataSource = Database.nacionalidads.ToList()
                cmbNacionalidad.ValueMember = "idNacionalidad"
                cmbNacionalidad.DisplayMember = "Detalle"
                cmbGenero.SelectedIndex = 0
                cmbEstadoCivil.SelectedIndex = 0
                cmbCiudad.Invalidate()
                cmbNacionalidad.Invalidate()
                Database.Dispose()
                dtpFechaNacimiento.Value = Now
                cmbRelacion.SelectedIndex = 0
                cmbVive.SelectedIndex = 0
                If _op > 0 Then
                    Llenar(_op)
                    btnGuardar.Visible = True
                    btnGuardar.Enabled = True
                End If
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        Private Sub btnAgregarPadre_Click(sender As Object, e As EventArgs) Handles btnAgregarPadre.Click
            ' Comprobamos los controles si están con datos
            If Comprobacion(Panel1) Then
                Database = New simpp_maarEntities()
                ' Verificamos que la cédula tenga 10 dígitos, caso contrario no se realizara la acción de grabar en la DB
                If txtCedula.Text.Length < 10 Then
                    MessageBox.Show("La cédula debe tener 10 dígitos", adver, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If
                '' Creamos una nueva entidad de la base y verificamos que la cédula no este repetida
                '' caso contrario no se realizara la acción de grabar en la DB
                If Database.personas.Any(Function(o) o.Cedula = txtCedula.Text) Then
                    MessageBox.Show(stringCedula, adver, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Dim representate = New representante()
                    representate.direcciont = txtDireccionT.Text
                    representate.telefonot = txtTelefonoT.Text
                    representate.trabaja = txtTrabajoT.Text
                    representate.correot = txtCorreoT.Text
                    representate.idUsuario = User
                    representate.Estado = "A"
                    representate.nivelEdu = cmbNivel.SelectedItem.ToString()
                    representate.relacion = cmbRelacion.SelectedItem.ToString()
                    representate.titulo = txtTitulo.Text
                    representate.empresa = txtEmpresa.Text
                    representate.viveEstudiante = cmbVive.SelectedItem.ToString()
                    representate.persona = New persona()
                    representate.persona.Apellidos = txtApellidos.Text
                    representate.persona.Nombre = txtNombre.Text
                    representate.persona.Cedula = txtCedula.Text
                    representate.persona.IDCiudad = cmbCiudad.SelectedValue
                    representate.persona.Telefono = txtTelefono.Text
                    representate.persona.idUsuario = User
                    representate.persona.Fecha_nacimiento = Format(dtpFechaNacimiento.Value, "yyyy-MM-dd")
                    representate.persona.Correo = txtCorreo.Text
                    representate.persona.Genero = cmbGenero.SelectedItem.ToString()
                    representate.persona.idNacionalidad = cmbNacionalidad.SelectedValue
                    representate.persona.Direccion = txtDireccion.Text
                    representate.persona.Estado_civil = cmbEstadoCivil.SelectedItem.ToString()
                    representate.persona.representantes.Add(representate)
                    representate.idpersona = representate.persona.idPersona
                    Database.personas.AddOrUpdate(representate.persona)
                    Database.representantes.AddOrUpdate(representate)
                    Database.SaveChanges()
                    NuevoEstudiante.AddRow(representate)
                    Close()
                End If
            Else
                MessageBox.Show(advertenciaCampoVacio, adver, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End Sub

        Private Sub txtCedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCedula.KeyPress
            OnlyNumbers(e)
        End Sub

        Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
            BorradoCajas(Panel1)
        End Sub

        Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
            OnlyLetters(e)
        End Sub

        Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
            Close()
        End Sub

        Private Sub txtApellidos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellidos.KeyPress
            OnlyLetters(e)
        End Sub

        Private Sub btnNoTrabaja_Click(sender As Object, e As EventArgs) Handles btnNoTrabaja.Click
            txtTrabajoT.Text = ST
            txtDireccionT.Text = ST
            txtCorreoT.Text = ST
            txtEmpresa.Text = ST
            txtTelefonoT.Text = "0000000000"
            btnTrabaja.Visible = True
            txtTrabajoT.Enabled = False
            txtCorreoT.Enabled = False
            txtDireccionT.Enabled = False
            txtTelefonoT.Enabled = False
            txtEmpresa.Enabled = False
        End Sub

        Private Sub btnTrabaja_Click(sender As Object, e As EventArgs) Handles btnTrabaja.Click
            txtTrabajoT.Text = "Sin datos"
            txtDireccionT.Text = "Sin datos"
            txtCorreoT.Text = "Sin datos"
            txtTelefonoT.Text = "0000000000"
            txtEmpresa.Text = "Sin datos"
            btnTrabaja.Visible = False
            txtTrabajoT.Enabled = True
            txtCorreoT.Enabled = True
            txtDireccionT.Enabled = True
            txtTelefonoT.Enabled = True
            txtEmpresa.Enabled = True
        End Sub

        Private Sub cmbNivel_DropDownClosed(sender As Object, e As EventArgs) Handles cmbNivel.DropDownClosed
            If cmbNivel.SelectedIndex = 4 Then
                lblTitulo.Visible = True
                txtTitulo.Visible = True
                txtTitulo.Text = ""
            Else
                lblTitulo.Visible = False
                txtTitulo.Visible = False
                txtTitulo.Text = "Sin titulo"
            End If
        End Sub

        Public Sub Llenar(id As Integer)
            Database = New simpp_maarEntities()
            Dim representante As representante = Database.representantes.Find(id)
            lblIdRepresentante.Text = representante.idRepresentantes
            txtNombre.Text = representante.persona.Nombre
            txtApellidos.Text = representante.persona.Apellidos
            txtCedula.Text = representante.persona.Cedula
            txtCorreo.Text = representante.persona.Correo
            txtCorreoT.Text = representante.correot
            txtDireccion.Text = representante.persona.Direccion
            txtDireccionT.Text = representante.direcciont
            txtEmpresa.Text = representante.empresa
            txtTelefono.Text = representante.persona.Telefono
            txtTelefonoT.Text = representante.telefonot
            txtTrabajoT.Text = representante.trabaja
            dtpFechaNacimiento.Text = representante.persona.Fecha_nacimiento.ToString()
            cmbEstadoCivil.SelectedIndex = cmbEstadoCivil.Items.IndexOf(representante.persona.Estado_civil)
            cmbGenero.SelectedItem = representante.persona.Genero
            cmbCiudad.SelectedValue = representante.persona.IDCiudad
            cmbNacionalidad.SelectedValue = representante.persona.idNacionalidad
            If representante.titulo.Length > 0 Then
                cmbNivel.SelectedItem = representante.nivelEdu
                txtTitulo.Text = representante.titulo
                lblTitulo.Visible = True
                txtTitulo.Visible = True
            End If
            cmbNivel.SelectedItem = representante.nivelEdu
            Database.Dispose()
        End Sub

        Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
            Database = New simpp_maarEntities()
            ' Verificamos que la cédula tenga 10 dígitos, caso contrario no se realizara la acción de grabar en la DB
            If txtCedula.Text.Length < 10 Then
                MessageBox.Show("La cédula debe tener 10 dígitos", adver, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
            Dim representate As representante = Database.representantes.Find(_op)
            representate.direcciont = txtDireccionT.Text
            representate.telefonot = txtTelefonoT.Text
            representate.trabaja = txtTrabajoT.Text
            representate.correot = txtCorreoT.Text
            representate.idUsuario = User
            representate.Estado = "A"
            representate.nivelEdu = cmbNivel.SelectedItem.ToString()
            representate.relacion = cmbRelacion.SelectedItem.ToString()
            representate.titulo = txtTitulo.Text
            representate.empresa = txtEmpresa.Text
            representate.viveEstudiante = cmbVive.SelectedItem.ToString()
            representate.persona.Apellidos = txtApellidos.Text
            representate.persona.Nombre = txtNombre.Text
            representate.persona.Cedula = txtCedula.Text
            representate.persona.IDCiudad = cmbCiudad.SelectedValue
            representate.persona.Telefono = txtTelefono.Text
            representate.persona.idUsuario = User
            representate.persona.Fecha_nacimiento = Format(dtpFechaNacimiento.Value, "yyyy-MM-dd")
            representate.persona.Correo = txtCorreo.Text
            representate.persona.Genero = cmbGenero.SelectedItem.ToString()
            representate.persona.idNacionalidad = cmbNacionalidad.SelectedValue
            representate.persona.Direccion = txtDireccion.Text
            representate.persona.Estado_civil = cmbEstadoCivil.SelectedItem.ToString()
            representate.persona.representantes.Add(representate)
            Database.representantes.AddOrUpdate(representate)
            Database.SaveChanges()
            Database.Dispose()
            Close()
        End Sub
    End Class
End Namespace