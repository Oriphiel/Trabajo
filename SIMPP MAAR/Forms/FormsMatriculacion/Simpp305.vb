Imports System.Data.Entity.Migrations
Imports SIMPP_MAAR.Reports

Namespace Forms.FormsMatriculacion
    Public Class Simpp305
        Dim _idMatricula As Integer

        Private Sub Simpp305_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            FillAll()
            Database = New simpp_maarEntities()
            lblFactura.Text = Database.fact_cab.Count + 1
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

        Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
            Dim cm As CurrencyManager = CType(dataGridEstudiantes.BindingContext(dataGridEstudiantes.DataSource, dataGridEstudiantes.DataMember), CurrencyManager)
            If cm.Count = 0 Then
                Return
            End If
            Dim drw As DataRowView = CType(cm.Current, DataRowView)
            Dim id As Integer = Convert.ToInt32(If(TypeOf drw.Row.Item("ID") Is DBNull Or Nothing, 0, drw.Row.Item("ID")))
            If id = 0 Then
                Return
            End If
            lblMatricula.Text = FormatNumber(id)
            FillDataGrid(id)
        End Sub

        Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
            Dim total As Decimal = 0
            If dgvMatriculasLista.Rows.Count = 0 Then
                Return
            End If
            For Each row As DataGridViewRow In dgvMatriculasLista.Rows
                If row.Cells("Pagos").ReadOnly = False And row.Cells("Pagos").Value = True Then
                    total += Convert.ToDecimal(row.Cells("Costo").Value)
                End If
            Next
            lblTotal.Text = String.Format("$ {0}", total)
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

        ''' <summary>
        ''' Llenar el DataGridView
        ''' </summary>
        ''' <param name="idMatriculas">El id de matricula.</param>
        Public Sub FillDataGrid(idMatriculas As Integer)
            _idMatricula = idMatriculas
            lblMatricula.Text = FormatNumber(idMatriculas)
            Database = New simpp_maarEntities()
            dgvMatriculasLista.DataSource = Nothing
            dgvMatriculasLista.Rows.Clear()
            Dim lista As List(Of cuotas_completa) = Database.cuotas_completa.Where(Function(o) o.idmatricula = idMatriculas).ToList()
            dgvMatriculasLista.ColumnCount = 7
            With dgvMatriculasLista
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "ID"
                .Columns(0).Name = "ID"
                .Columns(1).HeaderCell.Value = "Tipo"
                .Columns(1).Name = "Tipo"
                .Columns(2).HeaderCell.Value = "Fecha de pago"
                .Columns(3).HeaderCell.Value = "Costo"
                .Columns(3).Name = "Costo"
                .Columns(4).HeaderCell.Value = "Descuento"
                .Columns(5).HeaderCell.Value = "Detalle"
                .Columns(6).HeaderCell.Value = "Fecha de pago realizado"
                .Columns(6).Name = "Pago"
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End With
            For Each matri In lista
                dgvMatriculasLista.Rows.Add(matri.ID, matri.Tipo, matri.Fecha_de_pago.ToShortDateString(), matri.Costo, matri.Descuento, matri.Detalle, Format(matri.Fecha_de_Pago_Realizado, "yyyy-MM-dd"))
            Next
            Dim checkBoxColumn As New DataGridViewCheckBoxColumn()
            checkBoxColumn.HeaderText = "A Pagar"
            checkBoxColumn.Width = 30
            checkBoxColumn.Name = "Pagos"
            dgvMatriculasLista.Columns.Add(checkBoxColumn)
            dgvMatriculasLista.Refresh()
            For Each row As DataGridViewRow In dgvMatriculasLista.Rows
                If Convert.ToString(row.Cells("Pago").Value).Length > 0 Then
                    row.Cells("Pagos").Value = True
                    row.Cells("Pagos").ReadOnly = True
                    row.DefaultCellStyle.BackColor = Color.Aqua
                End If
            Next
            Dim matriculas As matricula = Database.matriculas.Find(idMatriculas)
            lblCedula.Text = matriculas.estudiante.persona.Cedula
            lblNombre.Text = matriculas.estudiante.persona.Nombre
            lblApellido.Text = matriculas.estudiante.persona.Apellidos
            lblRepresentante.Text = String.Format("{0} {1}", matriculas.representante.persona.Nombre, matriculas.representante.persona.Apellidos)
            Database.Dispose()
        End Sub

        Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
            ListaEstudiantesFac = New Simpp305B(1)
            ListaEstudiantesFac.ShowDialog()
            ListaEstudiantesFac.Dispose()
        End Sub

        Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
            If dgvMatriculasLista.Rows.Count = 0 Then
                Return
            End If
            Dim result As Integer = MessageBox.Show("¿Desea proceder con la factura?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = DialogResult.No Then
                Return
            ElseIf result = DialogResult.Yes Then
                MessageBox.Show("Procediendo facturación")
            End If
            Dim total As Decimal = 0
            For Each row As DataGridViewRow In dgvMatriculasLista.Rows
                If row.Cells("Pagos").ReadOnly = False And row.Cells("Pagos").Value = True Then
                    total += Convert.ToDecimal(row.Cells("Costo").Value)
                End If
            Next
            Database = New simpp_maarEntities()
            Dim facturaCabezera As fact_cab = New fact_cab()
            facturaCabezera.idmatricula = _idMatricula
            facturaCabezera.total = total
            facturaCabezera.idUsuario = User
            facturaCabezera.fecha = Format(Now, "yyyy-MM-dd HH:mm:ss")
            facturaCabezera.fpago = "Efectivo"
            Database.fact_cab.AddOrUpdate(facturaCabezera)
            For Each row As DataGridViewRow In dgvMatriculasLista.Rows
                If row.Cells("Pagos").ReadOnly = False And row.Cells("Pagos").Value = True Then
                    Dim id As Integer = Convert.ToInt32(row.Cells("ID").Value)
                    Dim facturaDetalle As fact_det = New fact_det()
                    Dim cuota As cuota = Database.cuotas.Find(id)
                    facturaDetalle.Cantidad = Convert.ToDecimal(row.Cells("Costo").Value)
                    facturaDetalle.Detalle = Convert.ToString(row.Cells("Tipo").Value)
                    facturaDetalle.idfact_cab = facturaCabezera.idfact_cab
                    facturaDetalle.idUsuario = User
                    facturaDetalle.idRubros = cuota.idRubro
                    cuota.Fecha_pago_realizado = Format(Now, "yyyy-MM-dd HH:mm:ss")
                    Database.cuotas.AddOrUpdate(cuota)
                    Database.fact_det.AddOrUpdate(facturaDetalle)
                End If
            Next
            Database.SaveChanges()
            Dim repor As Reporte = New Reporte(4, facturaCabezera.idfact_cab)
            repor.Show()
            lblFactura.Text = facturaCabezera.idfact_cab + 1
            lblMatricula.Text = ""
            lblNombre.Text = ""
            lblApellido.Text = ""
            lblCedula.Text = ""
            lblRepresentante.Text = ""
            lblTotal.Text = ""
            dgvMatriculasLista.DataSource = Nothing
            dgvMatriculasLista.Rows.Clear()
            Database.Dispose()
        End Sub
    End Class
End Namespace