Namespace Forms.FormsMatriculacion
    Public Class SImpp303
        Dim _op As Integer

        ''' <summary>
        ''' Initializes a new instance of the <see cref="SImpp303"/> class.
        ''' </summary>
        ''' <param name="opcion">Elige el comportamiento del formulario, opción 0 es para mostrar a todos los estudiantes en cada curso y poder editar.
        '''  Opción 1 es solo para ver los estudiantes de un curso determinado</param>
        Public Sub New(ByVal opcion As Integer)
            InitializeComponent()
            _op = opcion
            If _op = 1 Then
                btnEditar.Visible = False
            End If
        End Sub


        Private Sub SImpp303_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Try
                Database = New simpp_maarEntities()
                cmbCurso.DataSource = Database.cursos.Where(Function(o) o.Estado = "A").ToList()
                cmbCurso.ValueMember = "idCursos"
                cmbCurso.DisplayMember = "Detalle"
                cmbCurso.SelectedItem = "Detalle"
                cmbPeriodo.DataSource = Database.periodoes.Where(Function(o) o.Estado = "A").ToList()
                cmbPeriodo.ValueMember = "idPeriodo"
                cmbPeriodo.DisplayMember = "Detalle"
                If _op = 1 Then
                    dataGridEstudiantes.Visible = False
                Else
                    btnEditar.Visible = True
                    btnExit.Visible = False
                    gbPanel.Visible = False
                    gbPanel.Enabled = False
                    dgvMatriculasLista.Visible = False
                    dgvMatriculasLista.Enabled = False
                    FillAll()
                End If
                Database.Dispose()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
            Dim cm As CurrencyManager = CType(dataGridEstudiantes.BindingContext(dataGridEstudiantes.DataSource, dataGridEstudiantes.DataMember), CurrencyManager)
            If cm.Count = 0 Then
                Return
            End If
            Dim drw As DataRowView = CType(cm.Current, DataRowView)
            Dim id As Integer = Integer.Parse(drw.Row.Item("ID"))
            Database = New simpp_maarEntities()
            NuevaMatricula = New Simpp302(id)
            NuevaMatricula.ShowDialog()
            NuevaMatricula.Dispose()
            Database.Dispose()
        End Sub

        ''' <summary>
        ''' Metodo para llenar el DataGridView
        ''' </summary>
        ''' <param name="periodo">El periodo.</param>
        ''' <param name="curso">El curso.</param>
        ''' <param name="paralelo">El paralelo.</param>
        Public Sub FillDataGrid(ByVal periodo As Integer, ByVal curso As Integer, ByVal paralelo As Integer)
            Database = New simpp_maarEntities()
            dgvMatriculasLista.DataSource = Nothing
            dgvMatriculasLista.Rows.Clear()
            If _op = 1 Then
                cmbPeriodo.SelectedValue = periodo
                cmbCurso.SelectedValue = curso
                cmbParalelo.SelectedValue = paralelo
            End If
            Dim lista =
                    Database.matriculas.Where(
                        Function(o) _
                                                 o.idPeriodo = periodo And o.curso_paralelo.idcurso_paralelo = paralelo And o.Estado = "A").ToList()
            dgvMatriculasLista.ColumnCount = 6
            With dgvMatriculasLista
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "ID"
                .Columns(1).HeaderCell.Value = "Cédula"
                .Columns(2).HeaderCell.Value = "Nombre"
                .Columns(3).HeaderCell.Value = "Apellido"
                .Columns(4).HeaderCell.Value = "Teléfono"
                .Columns(5).HeaderCell.Value = "Dirección"
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            End With
            For Each matri In lista
                dgvMatriculasLista.Rows.Add(
                    {matri.idMatricula, matri.estudiante.persona.Cedula,
                     matri.estudiante.persona.Nombre, matri.estudiante.persona.Apellidos, matri.estudiante.persona.Telefono, matri.estudiante.persona.Direccion})
            Next
            dgvMatriculasLista.Refresh()
            Database.Dispose()
        End Sub

        Private Sub cmbParalelo_SelectionChangeCommitted(sender As Object, e As EventArgs) _
            Handles cmbParalelo.SelectionChangeCommitted
            FillDataGrid(cmbPeriodo.SelectedValue, cmbCurso.SelectedValue, cmbParalelo.SelectedValue)
        End Sub

        Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
            Close()
        End Sub


        Public Sub FillAll()
            Database = New simpp_maarEntities()
            Dim dtCurso As DataTable = New DataTable()
            dtCurso.TableName = "Cursos"
            dtCurso.Columns.Add("ID", GetType(Integer))
            dtCurso.Columns.Add("Curso", GetType(String))
            dtCurso.Columns.Add("Paralelo", GetType(String))
            dtCurso.Columns.Add("Estado", GetType(String))
            For Each curso In Database.curso_completo.Where(Function(o) o.Estado = "A").ToList()
                dtCurso.Rows.Add(curso.ID, curso.Curso, curso.Paralelo, curso.Estado)
            Next
            Dim dtEStudiantes As DataTable = New DataTable()
            dtEStudiantes.TableName = "Paralelos"
            dtEStudiantes.Columns.Add("IDrelacion", GetType(Integer))
            dtEStudiantes.Columns.Add("ID", GetType(Integer))
            dtEStudiantes.Columns.Add("Cédula", GetType(String))
            dtEStudiantes.Columns.Add("Nombre", GetType(String))
            dtEStudiantes.Columns.Add("Apellido", GetType(String))
            dtEStudiantes.Columns.Add("Dirección", GetType(String))
            dtEStudiantes.Columns.Add("Teléfono", GetType(String))
            dtEStudiantes.Columns.Add("Representante", GetType(String))
            For Each estudiante In Database.matriculas.Where(Function(o) o.curso_paralelo.Estado = "A" And o.periodo.Estado = "A" And o.Estado = "A").ToList()
                dtEStudiantes.Rows.Add(estudiante.idCurso_paralelo, estudiante.idMatricula, estudiante.estudiante.persona.Cedula,
                                       estudiante.estudiante.persona.Nombre, estudiante.estudiante.persona.Apellidos,
                                       estudiante.estudiante.persona.Direccion, estudiante.estudiante.persona.Telefono,
                                       String.Format("{0} {1}", estudiante.representante.persona.Nombre,
                                                     estudiante.representante.persona.Apellidos)
                                       )
            Next
            dtEStudiantes.Columns("IDrelacion").ColumnMapping = MappingType.Hidden
            Dim data As DataSet = New DataSet()
            data.Tables.Add(dtCurso)
            data.Tables.Add(dtEStudiantes)
            Dim relatio As DataRelation = New DataRelation("Estudiantes matriculados", data.Tables(0).Columns(0), data.Tables(1).Columns(0), True)
            relatio.Nested = True
            data.Relations.Add(relatio)
            dataGridEstudiantes.DataSource = Nothing
            dataGridEstudiantes.DataSource = data.Tables(0)
            SizeColumnsToContent(dataGridEstudiantes, -1)
        End Sub

        Private Sub dataGridEstudiantes_BackButtonClick(sender As Object, e As EventArgs) Handles dataGridEstudiantes.BackButtonClick
            btnEditar.Enabled = False
            dataGridEstudiantes.Collapse(-1)
        End Sub

        Private Sub dataGridEstudiantes_Navigate(sender As Object, ne As NavigateEventArgs) Handles dataGridEstudiantes.Navigate
            If btnEditar.Enabled = False Then
                btnEditar.Enabled = True
            End If
        End Sub

        Private Sub cmbCurso_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbCurso.SelectionChangeCommitted
            dgvMatriculasLista.DataSource = Nothing
            dgvMatriculasLista.Rows.Clear()
            Database = New simpp_maarEntities()
            Dim curso As String = cmbCurso.Text
            cmbParalelo.DataSource = Database.curso_completo.Where(Function(o) o.Curso = curso And o.Estado = "A").ToList()
            cmbParalelo.ValueMember = "ID"
            cmbParalelo.DisplayMember = "Paralelo"
            Database.Dispose()
            cmbParalelo.Enabled = True
        End Sub
    End Class
End Namespace