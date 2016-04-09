Namespace Forms.FormsMatriculacion
    Public Class Simpp305B
        Dim _listEstudiantes As List(Of estudiantepersona) = New List(Of estudiantepersona)
        Dim _op As Integer

        Public Sub New(opcion As Integer)
            ' Llamada necesaria para el diseñador.
            InitializeComponent()
            _op = opcion
            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        End Sub

        Private Sub Simpp305B_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            cmbSearch.SelectedIndex = 1
            AddRows()
        End Sub

        Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
            Filtro(cmbSearch.SelectedIndex)
        End Sub

        Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
            Database = New simpp_maarEntities()
            Dim id As Integer = Convert.ToInt32(dgvGenerico.CurrentRow.Cells(columnName:="ID").Value)
            Dim escogido As matricula = Database.matriculas.SingleOrDefault(Function(o) o.idEstudiante = id And o.Estado = "A" And o.periodo.Estado = "A")
            If (escogido IsNot Nothing) Then
                If _op = 1 Then
                    Facturacion.FillDataGrid(escogido.idMatricula)
                ElseIf _op = 2 Then
                    CertificadoMatricula.FillData(escogido.idMatricula)
                ElseIf _op = 3 Then
                    RetiroMatricula.FillData(escogido.idMatricula)
                End If
            Else
                MessageBox.Show("Este alumno no esta matriculado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Database.Dispose()
            Close()
        End Sub

        ''' <summary>
        ''' Agrega un ROW al DataGridView
        ''' </summary>
        Public Sub AddRows()
            dgvGenerico.DataSource = Nothing
            Database = New simpp_maarEntities()
            _listEstudiantes = Database.estudiantepersonas.ToList()
            dgvGenerico.DataSource = _listEstudiantes.ToList()
            With dgvGenerico
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Refresh()
            End With
            Database.Dispose()
        End Sub

        Private Sub Filtro(ByVal opcion As Integer)
            If opcion = 0 Then
                dgvGenerico.DataSource = _listEstudiantes.Where(Function(o) o.Cedula.Contains(txtBusqueda.Text)).ToList()
            ElseIf opcion = 1 Then
                dgvGenerico.DataSource = _listEstudiantes.Where(Function(o) o.Apellidos.ToLower().Contains(txtBusqueda.Text.ToLower())).ToList()
            End If
            dgvGenerico.Refresh()
        End Sub

        Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
            Close()
        End Sub
    End Class
End Namespace