Imports System.Data.Entity.Migrations
Imports System.IO
Imports SIMPP_MAAR.Reports

Namespace Forms.FormsMatriculacion
    Public Class Simpp302
        Dim _op As Integer
        Dim _flag As Boolean = False

        Public Sub New(ByVal opcion As Integer)
            InitializeComponent()
            _op = opcion
            If _op > 0 Then
                btnExit.Visible = True
                btnListaEstudiantes.Enabled = False
                btnGuardar.Enabled = False
                btnActualizar.Visible = True
            End If
        End Sub

        Private Sub Simpp302_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Try
                Database = New simpp_maarEntities()
                cmbCurso.DataSource = Database.cursos.Where(Function(o) o.Estado = "A").ToList()
                cmbCurso.ValueMember = "idCursos"
                cmbCurso.DisplayMember = "Detalle"
                cmbCurso.SelectedItem = "Detalle"
                cmbPeriodo.DataSource = Database.periodoes.Where(Function(o) o.Estado = "A").ToList()
                cmbPeriodo.ValueMember = "idPeriodo"
                cmbPeriodo.DisplayMember = "Detalle"
                If _op > 0 Then
                    Editar(_op)
                Else
                    lblMatricula.Text = FormatNumber(Database.matriculas.Count() + 1)
                End If
                Database.Dispose()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
            ListaGenerica = New Simpp302A4(0)
            ListaGenerica.ShowDialog()
            ListaGenerica.Dispose()
        End Sub

        Public Sub FillTexts(ByRef estudiante As estudiante)
            lblIdEstudiante.Text = estudiante.idEstudiante
            txtCedula.Text = estudiante.persona.Cedula
            txtNombre.Text = estudiante.persona.Nombre
            txtApellidos.Text = estudiante.persona.Apellidos
            Database = New simpp_maarEntities()
            Dim id As Integer = Convert.ToInt32(lblIdEstudiante.Text)
            cmbRepresentante.DataSource = Database.representante_persona.Where(Function(o) o.IDestudiante = id).ToList()
            cmbRepresentante.ValueMember = "ID"
            cmbRepresentante.DisplayMember = "Nombre"
            Database.Dispose()
        End Sub

        Private Sub cmbRepresentante_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbRepresentante.SelectionChangeCommitted
            Try
                Database = New simpp_maarEntities()
                Dim representante As representante = Database.representantes.Find(cmbRepresentante.SelectedValue)
                txtNombreR.Text = representante.persona.Nombre
                txtApellidoR.Text = representante.persona.Apellidos
                txtCedulaR.Text = representante.persona.Cedula
                Database.Dispose()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        Private Sub cmbParalelo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbParalelo.SelectionChangeCommitted
            Try
                Database = New simpp_maarEntities()
                Dim paralelo As Integer = cmbParalelo.SelectedValue
                Dim periodo As Integer = cmbPeriodo.SelectedValue
                Dim lista As List(Of matricula) = Database.matriculas.Where(Function(o) o.idCurso_paralelo = paralelo And o.idPeriodo = periodo And o.Estado = "A").ToList()
                Dim masculino = 0
                Dim femenino = 0
                For Each matri As matricula In lista
                    If matri.estudiante.persona.Genero = "Masculino" Then
                        masculino += 1
                    Else
                        femenino += 1
                    End If
                Next
                Dim curso = Database.curso_paralelo.Find(paralelo)
                lblTotal.Text = lista.Count
                lblFemeninos.Text = femenino
                lblMasculinos.Text = masculino
                lblRestantes.Text = curso.capacidad - lista.Count
                If Convert.ToInt32(lblRestantes.Text) = 0 Then
                    MessageBox.Show("Este curso ha llegado al limite de estudiantes, no se permitirá añadir más", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Database.Dispose()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
            BorradoCajas(Panel1)
            cmbRepresentante.DataSource = Nothing
            lblTotal.Text = ""
            lblFemeninos.Text = ""
            lblMasculinos.Text = ""
            lblIdEstudiante.Text = ""
            lblRestantes.Text = ""
            txtDescuento.Text = 0
            txtDetalle.Text = "Sin descuento"
        End Sub

        Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescuento.KeyPress
            OnlyNumbers(e)
        End Sub

        Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
            Try
                If Comprobacion(Panel1) Then
                    If Convert.ToInt32(lblRestantes.Text) = 0 Then
                        MessageBox.Show("Estudiantes máximos alcanzados en este curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                    Database = New simpp_maarEntities()
                    Dim listaRubros As List(Of rubro) = Database.rubros.Where(Function(o) o.Estado = "A").ToList()
                    Dim idEstudiante As Integer = Integer.Parse(lblIdEstudiante.Text)
                    Dim idRepresentante As Integer = Integer.Parse(cmbRepresentante.SelectedValue)
                    Dim idCursoParalelo As Integer = Integer.Parse(cmbParalelo.SelectedValue)
                    Dim idPeriodo As Integer = Integer.Parse(cmbPeriodo.SelectedValue)
                    Dim descuento As Integer = Integer.Parse(txtDescuento.Text)
                    If Database.matriculas.Any(Function(o) o.idEstudiante = idEstudiante And o.idPeriodo = idPeriodo) Then
                        MessageBox.Show("Este alumno ya esta matriculado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                    Dim nuevo As matricula = New matricula()
                    nuevo.idEstudiante = idEstudiante
                    nuevo.idRepresentante = idRepresentante
                    nuevo.idCurso_paralelo = idCursoParalelo
                    nuevo.idPeriodo = idPeriodo
                    nuevo.idUsuario = User
                    If cmbEstado.SelectedIndex = 0 Then
                        nuevo.Estado = "A"
                    Else
                        nuevo.Estado = "I"
                    End If
                    Database.matriculas.AddOrUpdate(nuevo)
                    For Each rub As rubro In listaRubros
                        Dim cuota As cuota = New cuota()
                        cuota.idRubro = rub.idRubros
                        cuota.idUsuario = User
                        cuota.idMatricula = nuevo.idMatricula
                        cuota.Descuento = descuento
                        cuota.DetalleDescuento = txtDetalle.Text
                        cuota.Pagar = rub.Costo / (1 + (descuento / 100))
                        cuota.Estado = nuevo.Estado
                        Database.cuotas.AddOrUpdate(cuota)
                    Next
                    Database.SaveChanges()
                    btnLimpiar.PerformClick()
                    lblMatricula.Text = FormatNumber(Database.matriculas.Count() + 1)
                    Reporte = New Reporte(3, nuevo.idMatricula)
                    Reporte.Show()
                End If
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        Private Sub btnListaEstudiantes_Click(sender As Object, e As EventArgs) Handles btnListaEstudiantes.Click
            ListaMatriculas = New SImpp303(1)
            ListaMatriculas.FillDataGrid(cmbPeriodo.SelectedValue, cmbCurso.SelectedValue, cmbParalelo.SelectedValue)
            ListaMatriculas.ShowDialog()
            ListaMatriculas.Dispose()
        End Sub

        Private Sub cmbCurso_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbCurso.SelectionChangeCommitted
            Database = New simpp_maarEntities()
            Dim curso As String = cmbCurso.Text
            cmbParalelo.DataSource = Database.curso_completo.Where(Function(o) o.Curso = curso And o.Estado = "A").ToList()
            cmbParalelo.ValueMember = "ID"
            cmbParalelo.DisplayMember = "Paralelo"
            Database.Dispose()
            cmbParalelo.Enabled = True
            lblTotal.Text = ""
            lblFemeninos.Text = ""
            lblMasculinos.Text = ""
            lblRestantes.Text = ""
            btnListaEstudiantes.Enabled = True
        End Sub

        Public Sub Editar(id As Integer)
            Try
                Database = New simpp_maarEntities()
                Dim actual As matricula = Database.matriculas.Find(id)
                txtCedula.Text = actual.estudiante.persona.Cedula
                txtNombre.Text = actual.estudiante.persona.Nombre
                txtApellidos.Text = actual.estudiante.persona.Apellidos
                cmbRepresentante.DataSource = Database.representante_persona.Where(Function(o) o.IDestudiante = actual.estudiante.idEstudiante).ToList()
                cmbRepresentante.ValueMember = "ID"
                cmbRepresentante.DisplayMember = "Nombre"
                cmbRepresentante.SelectedValue = actual.representante.idRepresentantes
                txtNombreR.Text = actual.representante.persona.Nombre
                txtApellidoR.Text = actual.representante.persona.Apellidos
                txtCedulaR.Text = actual.representante.persona.Cedula
                If actual.Estado = "A" Then
                    cmbEstado.SelectedIndex = 0
                Else
                    cmbEstado.SelectedIndex = 1
                End If
                lblMatricula.Text = FormatNumber(actual.idMatricula)
                lblIdEstudiante.Text = actual.idEstudiante
                cmbPeriodo.SelectedItem = actual.periodo
                cmbCurso.SelectedValue = 0
                _flag = True
                cmbCurso.SelectedValue = actual.curso_paralelo.curso.idCursos
                cmbParalelo.SelectedValue = 0
                _flag = True
                cmbParalelo.SelectedValue = actual.curso_paralelo.idcurso_paralelo
                txtDescuento.Text = actual.cuotas.First(Function(o) o.Estado = "A" And o.matricula.periodo.Estado = "A").Descuento
                txtDetalle.Text = actual.cuotas.First(Function(o) o.Estado = "A" And o.matricula.periodo.Estado = "A").DetalleDescuento
                Database.Dispose()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
            Close()
        End Sub

        Private Sub cmbCurso_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbCurso.SelectedValueChanged
            If _flag = True Then
                Dim curso As String = cmbCurso.Text
                _flag = False
                cmbParalelo.DataSource = Database.curso_completo.Where(Function(o) o.Curso = curso And o.Estado = "A").ToList()
                cmbParalelo.ValueMember = "ID"
                cmbParalelo.DisplayMember = "Paralelo"
                cmbParalelo.Enabled = True
            End If
        End Sub

        Private Sub cmbParalelo_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbParalelo.SelectedValueChanged
            If _flag = True Then
                Dim paralelo As Integer = cmbParalelo.SelectedValue
                Dim periodo As Integer = cmbPeriodo.SelectedValue
                Dim lista As List(Of matricula) =
                        Database.matriculas.Where(
                            Function(o) o.idCurso_paralelo = paralelo And o.idPeriodo = periodo And o.Estado = "A").ToList()
                Dim masculino = 0
                Dim femenino = 0
                For Each matri As matricula In lista
                    If matri.estudiante.persona.Genero = "Masculino" Then
                        masculino += 1
                    Else
                        femenino += 1
                    End If
                Next
                lblTotal.Text = lista.Count
                lblFemeninos.Text = femenino
                lblMasculinos.Text = masculino
                _flag = False
            End If
        End Sub

        Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
            Try
                If Comprobacion(Panel1) Then
                    Database = New simpp_maarEntities()
                    Dim idEstudiante As Integer = Integer.Parse(lblIdEstudiante.Text)
                    Dim idRepresentante As Integer = Integer.Parse(cmbRepresentante.SelectedValue)
                    Dim idCursoParalelo As Integer = Integer.Parse(cmbParalelo.SelectedValue)
                    Dim idPeriodo As Integer = Integer.Parse(cmbPeriodo.SelectedValue)
                    Dim descuento As Integer = Integer.Parse(txtDescuento.Text)
                    Dim nuevo As matricula = Database.matriculas.Find(Integer.Parse(lblMatricula.Text))
                    Dim listaRubros As List(Of rubro) = Database.rubros.Where(Function(o) o.Estado = "A").ToList()
                    nuevo.idEstudiante = idEstudiante
                    nuevo.idRepresentante = idRepresentante
                    nuevo.idCurso_paralelo = idCursoParalelo
                    nuevo.idPeriodo = idPeriodo
                    If cmbEstado.SelectedIndex = 0 Then
                        nuevo.Estado = "A"
                    Else
                        nuevo.Estado = "I"
                    End If
                    Database.matriculas.AddOrUpdate(nuevo)
                    For Each rub As rubro In listaRubros
                        Dim cuota As cuota = Database.cuotas.First(Function(o) o.idRubro = rub.idRubros And o.idMatricula = nuevo.idMatricula)
                        cuota.idRubro = rub.idRubros
                        cuota.idUsuario = User
                        cuota.idMatricula = nuevo.idMatricula
                        cuota.Descuento = descuento
                        cuota.DetalleDescuento = txtDetalle.Text
                        cuota.Pagar = rub.Costo / (1 + (descuento / 100))
                        cuota.Estado = nuevo.Estado
                        Database.cuotas.AddOrUpdate(cuota)
                    Next
                    Database.SaveChanges()
                    Database.Dispose()
                    Reporte = New Reporte(3, nuevo.idMatricula)
                    Reporte.Show()
                    ListaMatriculas.FillAll()
                    Close()
                End If
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

    End Class
End Namespace