Public Class Simpp201B
    Dim _listaStaff As New List(Of staff)

    Private Sub Simpp201B_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Database = New simpp_maarEntities()
            _listaStaff = Database.staffs.ToList()
            dgvGenerico.DataSource = Database.staffs.ToList()
            With dgvGenerico
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Refresh()
            End With
            Database.Dispose()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Database = New simpp_maarEntities()
        ListaUsuarios.AgregarPersona(Database.personas.Find(dgvGenerico.CurrentRow.Cells(columnName:="ID").Value))
        Database.Dispose()
        Close()
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        Filtro(cmbSearch.SelectedIndex)
    End Sub

    Private Sub Filtro(ByVal opcion As Integer)
        If opcion = 0 Then
            dgvGenerico.DataSource = _listaStaff.Where(Function(o) o.cedula.Contains(txtBusqueda.Text)).ToList()
        ElseIf opcion = 1 Then
            dgvGenerico.DataSource = _listaStaff.Where(Function(o) o.Nombre.ToLower().Contains(txtBusqueda.Text.ToLower())).ToList()
        End If
        dgvGenerico.Refresh()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class