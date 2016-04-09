Imports System.Data.Entity.Migrations

Namespace Forms.FormsMatriculacion
    Public Class Simpp308
        Private _listEstudiantes As List(Of matriculas_inactivas)

        Private Sub Simpp308_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            cmbSearch.SelectedIndex = 1
            AddRows()
        End Sub

        Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
            Filtro(cmbSearch.SelectedIndex)
        End Sub

        ''' <summary>
        ''' Agrega un ROW al DataGridView
        ''' </summary>
        Public Sub AddRows()
            dgvGenerico.DataSource = Nothing
            Database = New simpp_maarEntities()
            _listEstudiantes = Database.matriculas_inactivas.ToList()
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
                dgvGenerico.DataSource = _listEstudiantes.Where(Function(o) o.Estudiante.ToLower().Contains(txtBusqueda.Text.ToLower())).ToList()
            End If
            dgvGenerico.Refresh()
        End Sub

        Private Sub btnActivar_Click(sender As Object, e As EventArgs) Handles btnActivar.Click
            Try
                Database = New simpp_maarEntities()
                Dim id As Integer = Convert.ToInt32(dgvGenerico.CurrentRow.Cells(columnName:="ID").Value)
                Dim escogido As matricula = Database.matriculas.Find(id)
                escogido.Estado = "A"
                For Each o As cuota In escogido.cuotas
                    o.Estado = "A"
                    Database.cuotas.AddOrUpdate(o)
                Next
                Database.matriculas.AddOrUpdate(escogido)
                Database.SaveChanges()
                Database.Dispose()
                AddRows()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace