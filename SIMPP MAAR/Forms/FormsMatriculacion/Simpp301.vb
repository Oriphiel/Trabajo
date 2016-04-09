Imports System.Data.Entity.Migrations
Imports System.Data.Entity.Validation
Imports SIMPP_MAAR.My.Resources

Namespace Forms.FormsMatriculacion
    Public Class Simpp301
        Private ReadOnly _representante As List(Of representante) = New List(Of representante)()
        Private _op As Integer
        Private _estuddiante As estudiante

        Public Sub New(opcion As Integer)
            InitializeComponent()
            If opcion = 1 Then
                btnLimpiar.Visible = False
                btnExit.Visible = True
            End If
            _op = opcion
        End Sub

        Private Sub Simpp301_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Try
                '' Al momento de cargar el formulario lo cargamos con algunas cosas, tales como el actual ID que llevaría el estudiante
                '' las ciudades y nacionalidad en la base de datos, así como indicar la posición el los diferentes Combo-box
                Database = New simpp_maarEntities()
                cmbCiudad.DataSource = Database.ciudads.ToList()
                cmbCiudad.ValueMember = "idCiudad"
                cmbCiudad.DisplayMember = "Detalle"
                cmbNacionalidad.DataSource = Database.nacionalidads.ToList()
                cmbNacionalidad.ValueMember = "idNacionalidad"
                cmbNacionalidad.DisplayMember = "Detalle"
                cmbLugarDeNacimiento.DataSource = Database.ciudads.ToList()
                cmbLugarDeNacimiento.ValueMember = "Detalle"
                cmbLugarDeNacimiento.DisplayMember = "Detalle"
                cmbGenero.SelectedIndex = 0
                cmbEstadoCivil.SelectedIndex = 0
                cmbCiudad.Invalidate()
                cmbNacionalidad.Invalidate()
                If _op = 1 Then
                    lblIdEstudiante.Text = _estuddiante.idEstudiante
                    FillAll(_estuddiante)
                Else
                    lblIdEstudiante.Text = Database.estudiantes.Count() + 1
                    dtpFechaNacimiento.Value = Now
                End If
                Database.Dispose()
                dgvRepresentante.AutoGenerateColumns = True
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
            Try
                ' Verificamos que existan representantes, caso contrario no se realizara la acción de grabar en la DB
                If dgvRepresentante.Rows.Count = 0 Then
                    MessageBox.Show("Al menos debe haber un representante", adver, MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation)
                    Return
                End If
                ' Verificamos que la cédula tenga 10 dígitos, caso contrario no se realizara la acción de grabar en la DB
                If txtCedula.Text.Length < 10 Then
                    MessageBox.Show("La cédula debe tener 10 dígitos", adver, MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation)
                    Return
                End If
                ' Comprobamos los controles si están con datos
                If Comprobacion(Panel1) Then
                    If _op = 1 Then
                        Database = New simpp_maarEntities()
                        Dim id As Integer = Convert.ToInt32(lblIdEstudiante.Text)
                        _estuddiante = Database.estudiantes.Find(id)
                        _estuddiante.persona.Apellidos = txtApellidos.Text
                        _estuddiante.persona.Nombre = txtNombre.Text
                        _estuddiante.persona.Cedula = txtCedula.Text
                        _estuddiante.persona.Direccion = txtDireccion.Text
                        _estuddiante.persona.Estado_civil = cmbEstadoCivil.SelectedItem.ToString()
                        _estuddiante.persona.Genero = cmbGenero.SelectedItem.ToString()
                        _estuddiante.persona.idNacionalidad = cmbNacionalidad.SelectedValue
                        _estuddiante.persona.Correo = txtCorreo.Text
                        _estuddiante.persona.Fecha_nacimiento = Format(dtpFechaNacimiento.Value, "yyyy-MM-dd")
                        _estuddiante.persona.IDCiudad = cmbCiudad.SelectedValue
                        _estuddiante.persona.idUsuario = User
                        _estuddiante.persona.Telefono = txtTelefono.Text
                        _estuddiante.lugar_nacimiento = cmbLugarDeNacimiento.SelectedValue
                        _estuddiante.idUsuario = User
                        _estuddiante.observaciones = txtObservaciones.Text
                        Database.estudiantes.AddOrUpdate(_estuddiante)
                        For Each repre As representante In _representante
                            If _estuddiante.representante_estudiante.Where(Function(o) o.idEstudiante = _estuddiante.idEstudiante And o.idRepresentante = repre.idRepresentantes).Count = 0 Then
                                Dim tipo As New representante_estudiante1
                                tipo.idEstudiante = _estuddiante.idEstudiante
                                tipo.idRepresentante = repre.idRepresentantes
                                Database.representante_estudiante1.AddOrUpdate(tipo)
                            End If
                        Next
                        Database.SaveChanges()
                        Database.Dispose()
                        ListaGenerica.Reload()
                        dgvRepresentante.Rows.Clear()
                        _representante.Clear()
                        Close()
                    Else
                        '' Creamos una nueva entidad de la base y verificamos que la cédula no este repetida
                        '' caso contrario no se realizara la acción de grabar en la DB
                        Database = New simpp_maarEntities()
                        If Database.personas.Any(Function(o) o.Cedula = txtCedula.Text) Then
                            MessageBox.Show(stringCedula, adver, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Else
                            Dim estudiante = New estudiante
                            estudiante.persona = New persona()
                            estudiante.persona.Apellidos = txtApellidos.Text
                            estudiante.persona.Nombre = txtNombre.Text
                            estudiante.persona.Cedula = txtCedula.Text
                            estudiante.persona.Direccion = txtDireccion.Text
                            estudiante.persona.Estado_civil = cmbEstadoCivil.SelectedItem.ToString()
                            estudiante.persona.Genero = cmbGenero.SelectedItem.ToString()
                            estudiante.persona.idNacionalidad = cmbNacionalidad.SelectedValue
                            estudiante.persona.Correo = txtCorreo.Text
                            estudiante.persona.Fecha_nacimiento = Format(dtpFechaNacimiento.Value, "yyyy-MM-dd")
                            estudiante.persona.IDCiudad = cmbCiudad.SelectedValue
                            estudiante.persona.idUsuario = User
                            estudiante.persona.Telefono = txtTelefono.Text
                            estudiante.idUsuario = User
                            estudiante.observaciones = txtObservaciones.Text
                            estudiante.lugar_nacimiento = cmbLugarDeNacimiento.SelectedValue
                            Database.personas.AddOrUpdate(estudiante.persona)
                            estudiante.idpersona = estudiante.persona.idPersona
                            Database.estudiantes.AddOrUpdate(estudiante)
                            '' usamos la lista de representantes para ir agregando la referencia a estudiantes
                            For Each o As representante In _representante
                                Dim tipo As New representante_estudiante1
                                tipo.idEstudiante = estudiante.idEstudiante
                                tipo.idRepresentante = o.idRepresentantes
                                Database.representante_estudiante1.AddOrUpdate(tipo)
                            Next
                            ' Con esto se graba cada evento a la DB
                            Database.SaveChanges()
                            lblIdEstudiante.Text = Database.estudiantes.Count() + 1
                            dgvRepresentante.Rows.Clear()
                            Database.Dispose()
                            dtpFechaNacimiento.Value = Now
                            _representante.Clear()
                            BorradoCajas(Panel1)
                        End If
                    End If
                Else
                    MessageBox.Show(advertenciaCampoVacio, adver, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As DbEntityValidationException
                For Each eve In ex.EntityValidationErrors
                    Console.WriteLine("Entity of type ""{0}"" in state ""{1}"" has the following validation errors:", eve.Entry.Entity.ToString(), eve.Entry.State)
                    For Each ve In eve.ValidationErrors
                        Console.WriteLine("- Property: ""{0}"", Error: ""{1}""", ve.PropertyName, ve.ErrorMessage)
                    Next
                Next
            End Try
        End Sub

        Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
            OnlyLetters(e)
        End Sub

        Private Sub btnAgregarPadre_Click(sender As Object, e As EventArgs) Handles btnAgregarPadre.Click
            NuevoRepresentante = New Simpp301A(0)
            NuevoRepresentante.ShowDialog()
            NuevoRepresentante.Dispose()
        End Sub

        Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
            BorradoCajas(Panel1)
        End Sub

        Private Sub txtApellidos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellidos.KeyPress
            OnlyLetters(e)
        End Sub

        Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
            Dim seleccion = dgvRepresentante.CurrentRow.Index
            If _op = 1 Then
                Database = New simpp_maarEntities()
                Dim id As Integer = Convert.ToInt32(dgvRepresentante.CurrentRow.Cells(columnName:="ID").Value)
                Dim cambio = Database.representante_estudiante1.Where(Function(o) o.idEstudiante = _estuddiante.idEstudiante And o.idRepresentante = id).ToList()
                For Each tipo In cambio
                    Database.representante_estudiante1.Remove(tipo)
                Next
                Database.SaveChanges()
                Database.Dispose()
            End If
            dgvRepresentante.Rows.RemoveAt(seleccion)
            _representante.RemoveAt(seleccion)
        End Sub


        ''' <summary>
        ''' Agrega un ROW al DataGridView
        ''' </summary>
        ''' <param name="representante">Objeto representante.</param>
        Public Sub AddRow(ByRef representante As representante)
            Database = New simpp_maarEntities()
            _representante.Add(representante)
            dgvRepresentante.ColumnCount = 4
            With dgvRepresentante
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "ID"
                .Columns(0).Name = "ID"
                .Columns(1).HeaderCell.Value = "Cédula"
                .Columns(2).HeaderCell.Value = "Nombre"
                .Columns(3).HeaderCell.Value = "Apellido"
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
            dgvRepresentante.Rows.Add(
                {representante.idRepresentantes, representante.persona.Cedula,
                 representante.persona.Nombre, representante.persona.Apellidos})
            dgvRepresentante.Refresh()
            Database.Dispose()
        End Sub


        ''' <summary>
        ''' Llena con los datos del estudiante el formulario
        ''' </summary>
        ''' <param name="estudiante">The estudiante.</param>
        Public Sub FillAll(ByRef estudiante As estudiante)
            _estuddiante = estudiante
            txtCedula.Text = estudiante.persona.Cedula
            txtObservaciones.Text = estudiante.observaciones
            txtApellidos.Text = estudiante.persona.Apellidos
            txtCorreo.Text = estudiante.persona.Correo
            txtDireccion.Text = estudiante.persona.Direccion
            txtNombre.Text = estudiante.persona.Nombre
            txtTelefono.Text = estudiante.persona.Telefono
            cmbLugarDeNacimiento.SelectedValue = estudiante.lugar_nacimiento
            dtpFechaNacimiento.Text = estudiante.persona.Fecha_nacimiento.ToString()
            cmbEstadoCivil.SelectedIndex = cmbEstadoCivil.Items.IndexOf(estudiante.persona.Estado_civil)
            cmbGenero.SelectedItem = estudiante.persona.Genero
            cmbCiudad.SelectedValue = estudiante.persona.IDCiudad
            cmbNacionalidad.SelectedValue = estudiante.persona.idNacionalidad
            Database = New simpp_maarEntities()
            Dim id = estudiante.idEstudiante
            Dim representantes = Database.representante_estudiante1.Where(Function(o) o.idEstudiante = id And o.Estado = "A").ToList()
            For Each tipo As representante_estudiante1 In representantes
                AddRow(tipo.representante)
            Next
        End Sub

        Public Sub Ayuda(ByRef estudiante As estudiante)
            _estuddiante = estudiante
        End Sub

        Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
            Close()
        End Sub

        Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
            ListaGenerica = New Simpp302A4(2)
            ListaGenerica.ShowDialog()
            ListaGenerica.Dispose()
        End Sub

        Private Sub dtpFechaNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaNacimiento.ValueChanged
            Dim nuevo As DateTime = dtpFechaNacimiento.Value
            Dim age As Integer = Now.Year - dtpFechaNacimiento.Value.Year
            If (Now < nuevo.AddYears(age)) Then
                age -= 1
            End If
            If age <= 0 Then
                lblEdad.Text = ""
                Return
            End If
            lblEdad.Text = age
        End Sub

        Private Sub txtCedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCedula.KeyPress
            OnlyNumbers(e)
        End Sub
    End Class
End Namespace