Imports System.Data.Entity.Migrations
Imports SIMPP_MAAR.Reports

Namespace Forms.FormsMatriculacion
    Public Class Simpp307

        Private Sub Simpp307_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            FillAll()
        End Sub

        ''' <summary>
        ''' Llenar el DataGrid
        ''' </summary>
        Public Sub FillAll()
            Database = New simpp_maarEntities()
            Dim dtCurso As DataTable = New DataTable()
            dtCurso.Columns.Add("IDCurso", GetType(Integer))
            dtCurso.Columns.Add("Curso", GetType(String))
            dtCurso.Columns.Add("Paralelo", GetType(String))
            dtCurso.Columns.Add("Estado", GetType(String))
            For Each curso In Database.curso_completo.Where(Function(o) o.Estado = "A").ToList()
                dtCurso.Rows.Add(curso.ID, curso.Curso, curso.Paralelo, curso.Estado)
            Next
            Dim dtEStudiantes As DataTable = New DataTable()
            dtEStudiantes.Columns.Add("IDrelacion", GetType(Integer))
            dtEStudiantes.Columns.Add("ID", GetType(Integer))
            dtEStudiantes.Columns.Add("Cédula", GetType(String))
            dtEStudiantes.Columns.Add("Nombre", GetType(String))
            dtEStudiantes.Columns.Add("Apellido", GetType(String))
            dtEStudiantes.Columns.Add("Representante", GetType(String))
            For Each estudiante In Database.matriculas.Where(Function(o) o.curso_paralelo.Estado = "A" And o.periodo.Estado = "A" And o.Estado = "A").ToList()
                dtEStudiantes.Rows.Add(estudiante.idCurso_paralelo, estudiante.idMatricula, estudiante.estudiante.persona.Cedula,
                                       estudiante.estudiante.persona.Nombre, estudiante.estudiante.persona.Apellidos,
                                       String.Format("{0} {1}", estudiante.representante.persona.Nombre,
                                                     estudiante.representante.persona.Apellidos)
                                       )
            Next
            Dim data As DataSet = New DataSet()
            dtEStudiantes.Columns("IDrelacion").ColumnMapping = MappingType.Hidden
            data.Tables.Add(dtCurso)
            data.Tables.Add(dtEStudiantes)
            Dim relatio As DataRelation = New DataRelation("Estudiantes matriculados", data.Tables(0).Columns(0), data.Tables(1).Columns(0), True)
            relatio.Nested = True
            data.Relations.Add(relatio)
            dataGridEstudiantes.DataSource = Nothing
            dataGridEstudiantes.DataSource = data.Tables(0)
            SizeColumnsToContent(dataGridEstudiantes, -1)
        End Sub

        Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
            Dim cm As CurrencyManager = CType(dataGridEstudiantes.BindingContext(dataGridEstudiantes.DataSource, dataGridEstudiantes.DataMember), CurrencyManager)
            Dim drw As DataRowView = CType(cm.Current, DataRowView)
            Dim id As Integer = Convert.ToInt32(If(TypeOf drw.Row.Item("ID") Is DBNull Or Nothing, 0, drw.Row.Item("ID")))
            If id = 0 Then
                Return
            End If
            FillData(id)
        End Sub

        Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
            ListaEstudiantesFac = New Simpp305B(3)
            ListaEstudiantesFac.ShowDialog()
            ListaEstudiantesFac.Dispose()
        End Sub

        Public Sub FillData(id As Integer)
            Dim matriculas As matricula = Database.matriculas.Find(id)
            lblMatricula.Text = FormatNumber(id)
            lblCedula.Text = matriculas.estudiante.persona.Cedula
            lblNombre.Text = matriculas.estudiante.persona.Nombre
            lblApellido.Text = matriculas.estudiante.persona.Apellidos
            lblRepresentante.Text = String.Format("{0} {1}", matriculas.representante.persona.Nombre, matriculas.representante.persona.Apellidos)
            Database.Dispose()
        End Sub

        Private Sub dataGridEstudiantes_BackButtonClick(sender As Object, e As EventArgs) Handles dataGridEstudiantes.BackButtonClick
            dataGridEstudiantes.Collapse(-1)
            btnSelect.Enabled = False
        End Sub

        Private Sub dataGridEstudiantes_Navigate(sender As Object, ne As NavigateEventArgs) Handles dataGridEstudiantes.Navigate
            If btnSelect.Enabled = False Then
                btnSelect.Enabled = True
            End If
        End Sub

        Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
            Reporte = New Reporte(2, Convert.ToInt32(lblMatricula.Text))
            Reporte.Show()
            If lblMatricula.Text.Length = 0 Then
                Return
            End If
            Database = New simpp_maarEntities()
            Dim retirado As matricula = Database.matriculas.Find(Convert.ToInt32(lblMatricula.Text))
            retirado.Estado = "I"
            For Each cuota In retirado.cuotas
                cuota.Estado = "I"
                Database.cuotas.AddOrUpdate(cuota)
            Next
            Database.matriculas.AddOrUpdate(retirado)
            Database.SaveChanges()
            Database.Dispose()
            FillAll()
        End Sub
    End Class
End Namespace