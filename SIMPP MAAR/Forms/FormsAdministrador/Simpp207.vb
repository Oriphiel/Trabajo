Imports System.Data.Entity.Migrations

Namespace Forms.FormsAdministrador
    Public Class Simpp207
        ''' <summary>
        ''' Lista de cursos disponibles
        ''' </summary>
        Dim _listaCursos As List(Of curso) = New List(Of curso)        
        ''' <summary>
        ''' Lista de paralelos de cada curso
        ''' </summary>
        Dim _listaCursosParalelos As List(Of curso_paralelo) = New List(Of curso_paralelo)()

        Private Sub Simpp207_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Database = New simpp_maarEntities()
            _listaCursos = Database.cursos.ToList()
            FillData(_listaCursos)
            Database.Dispose()
        End Sub

        Private Sub dgvRubros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRubros.CellClick
            If txtDetalle.Enabled = False Then
                Dim curso As curso = _listaCursos.Find(Function(o) o.idCursos = dgvRubros.CurrentRow.Cells(columnName:="ID").Value)
                lblIDCurso.Text = curso.idCursos
                txtDetalle.Text = curso.Detalle.ToUpper()
                If curso.Estado = "A" Then
                    cmbEstado.SelectedIndex = 0
                Else
                    cmbEstado.SelectedIndex = 1
                End If
                Database = New simpp_maarEntities()
                dgvParalelo.Rows.Clear()
                _listaCursosParalelos.Clear()
                For Each entidad In Database.curso_paralelo.Where(Function(o) o.idCurso = curso.idCursos).ToList()
                    FillDataParalelo(entidad, 0)
                Next
                Database.Dispose()
            End If
        End Sub

        Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
            If txtDetalle.Enabled = False Then
                ActivaDesactiva(Panel1)
                BorradoCajas(Panel1)
                Database = New simpp_maarEntities()
                Dim nuevo = Database.cursos.FirstOrDefault()
                If (nuevo IsNot Nothing) Then
                    lblIDCurso.Text = Database.cursos.Max(Function(curs) curs.idCursos) + 1
                Else
                    lblIDCurso.Text = 1
                End If
                cmbEstado.Enabled = True
                btnPAñadir.Enabled = True
                dgvParalelo.Rows.Clear()
                txtDetalle.Focus()
                Database.Dispose()
            End If
        End Sub

        Private Sub btngrabar_Click(sender As Object, e As EventArgs) Handles btngrabar.Click
            Try
                If txtDetalle.Enabled = False Then Return
                Database = New simpp_maarEntities()
                Dim curso = New curso()
                If cmbEstado.SelectedIndex = 0 Then
                    curso.Estado = "A"
                Else
                    curso.Estado = "I"
                End If
                curso.Detalle = txtDetalle.Text.ToUpper()
                curso.idUsuario = User
                Database.cursos.AddOrUpdate(curso)
                For Each cp In _listaCursosParalelos
                    If Database.curso_paralelo.Where(Function(o) o.idCurso = curso.idCursos And o.idParalelo = cp.idParalelo).Count = 0 Then
                        Dim nuevo As curso_paralelo = New curso_paralelo()
                        nuevo.idCurso = curso.idCursos
                        nuevo.idParalelo = cp.idParalelo
                        nuevo.idUsuario = User
                        nuevo.capacidad = cp.capacidad
                        Database.curso_paralelo.Add(nuevo)
                    End If
                Next
                Database.SaveChanges()
                _listaCursosParalelos.Clear()
                _listaCursos = Database.cursos.ToList()
                FillData(_listaCursos)
                Database.Dispose()
                BorradoCajas(Panel1)
                ActivaDesactiva(Panel1)
                cmbEstado.Enabled = False
                lblIDCurso.Text = Nothing
                btnPActualizar.Enabled = False
                btnPAñadir.Enabled = False
                btnPDesactivar.Enabled = False
                dgvParalelo.Rows.Clear()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
            Try
                Database = New simpp_maarEntities()
                Dim curso As curso = Database.cursos.Find(Integer.Parse(lblIDCurso.Text))
                If cmbEstado.SelectedIndex = 0 Then
                    curso.Estado = "A"
                Else
                    curso.Estado = "I"
                End If
                curso.Detalle = txtDetalle.Text
                Database.cursos.AddOrUpdate(curso)
                For Each cp In _listaCursosParalelos
                    If Database.curso_paralelo.Where(Function(o) o.idCurso = curso.idCursos And o.idParalelo = cp.idParalelo).Count = 0 Then
                        Dim nuevo As curso_paralelo = New curso_paralelo()
                        nuevo.idCurso = curso.idCursos
                        nuevo.idParalelo = cp.idParalelo
                        nuevo.idUsuario = User
                        nuevo.capacidad = cp.capacidad
                        Database.curso_paralelo.Add(nuevo)
                    End If
                Next
                Database.SaveChanges()
                _listaCursosParalelos.Clear()
                _listaCursos = Database.cursos.ToList()
                FillData(_listaCursos)
                Database.Dispose()
                BorradoCajas(Panel1)
                ActivaDesactiva(Panel1)
                btnActualizar.Visible = False
                cmbEstado.Enabled = False
                lblIDCurso.Text = Nothing
                btnPActualizar.Enabled = False
                btnPAñadir.Enabled = False
                btnPDesactivar.Enabled = False
                dgvParalelo.Rows.Clear()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
            BorradoCajas(Panel1)
            lblIDCurso.Text = Nothing
        End Sub

        Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
            If txtDetalle.Enabled = False And txtDetalle.Text.Length > 0 Then
                ActivaDesactiva(Panel1)
                btnActualizar.Visible = True
                cmbEstado.Enabled = True
                btnPActualizar.Enabled = True
                btnPAñadir.Enabled = True
                btnPDesactivar.Enabled = True
                txtDetalle.Focus()
            End If
        End Sub

        Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
            If txtDetalle.Enabled = True Then
                ActivaDesactiva(Panel1)
                If btnActualizar.Visible = True Then
                    btnActualizar.Visible = False
                End If
                cmbEstado.Enabled = False
                btnPActualizar.Enabled = False
                btnPAñadir.Enabled = False
                btnPDesactivar.Enabled = False
            End If
        End Sub

        Private Sub btnDesactivar_Click(sender As Object, e As EventArgs) Handles btnDesactivar.Click
            Try
                Database = New simpp_maarEntities()
                Dim curso As curso = Database.cursos.Find(dgvRubros.CurrentRow.Cells(columnName:="ID").Value)
                curso.Estado = "I"
                For Each cp In _listaCursosParalelos
                    Dim nuevo As curso_paralelo = Database.curso_paralelo.Find(cp.idcurso_paralelo)
                    nuevo.Estado = "I"
                    Database.curso_paralelo.AddOrUpdate(nuevo)
                Next
                Database.cursos.AddOrUpdate(curso)
                Database.SaveChanges()
                _listaCursos = Database.cursos.ToList()
                FillData(_listaCursos)
                Database.Dispose()
                BorradoCajas(Panel1)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        ''' <summary>
        ''' Llenar los datos del DataGridView
        ''' </summary>
        ''' <param name="lista">De lista.</param>
        Public Sub FillData(ByRef lista As List(Of curso))
            dgvRubros.DataSource = Nothing
            dgvRubros.Rows.Clear()
            dgvRubros.ColumnCount = 3
            With dgvRubros
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "ID"
                .Columns(0).Name = "ID"
                .Columns(1).HeaderCell.Value = "Detalle"
                .Columns(2).HeaderCell.Value = "Estado"
            End With
            For Each curso In lista
                dgvRubros.Rows.Add({curso.idCursos, curso.Detalle, curso.Estado})
            Next
            dgvRubros.Refresh()
        End Sub

        ''' <summary>
        ''' Llenar los datos del DataGridView de paralelos
        ''' </summary>
        ''' <param name="curso"></param>
        Public Sub FillDataParalelo(ByVal curso As curso_paralelo, ByVal opcion As Integer)
            With dgvParalelo
                .ColumnCount = 4
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "ID"
                .Columns(0).Name = "ID"
                .Columns(0).Visible = False
                .Columns(1).HeaderCell.Value = "Detalle"
                .Columns(2).HeaderCell.Value = "Cantidad"
                .Columns(3).HeaderCell.Value = "Estado"
            End With
            _listaCursosParalelos.Add(curso)
            If opcion = 1 Then
                Database = New simpp_maarEntities()
                Dim id = Database.curso_paralelo.Count() + 1
                Dim para As paralelo = Database.paralelos.Find(curso.idParalelo)
                dgvParalelo.Rows.Add(id, para.Detalle, curso.capacidad, curso.Estado)
            Else
                dgvParalelo.Rows.Add(curso.idcurso_paralelo, curso.paralelo.Detalle, curso.capacidad, curso.Estado)
            End If
        End Sub

        Public Sub AddList(ByVal lParalelo As curso_paralelo)
            FillDataParalelo(lParalelo, 1)
        End Sub

        Private Sub btnPAñadir_Click(sender As Object, e As EventArgs) Handles btnPAñadir.Click
            ListaCursosParalelos = New Simpp208(0, Integer.Parse(lblIDCurso.Text), Nothing)
            ListaCursosParalelos.ShowDialog()
            ListaCursosParalelos.Dispose()
        End Sub

        Private Sub btnPActualizar_Click(sender As Object, e As EventArgs) Handles btnPActualizar.Click
            Try
                Database = New simpp_maarEntities()
                Dim cursoParalelo As curso_paralelo = Database.curso_paralelo.Find(dgvParalelo.CurrentRow.Cells(columnName:="ID").Value)
                ListaCursosParalelos = New Simpp208(1, Integer.Parse(lblIDCurso.Text), cursoParalelo)
                ListaCursosParalelos.ShowDialog()
                ListaCursosParalelos.Dispose()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        Private Sub btnPDesactivar_Click(sender As Object, e As EventArgs) Handles btnPDesactivar.Click
            Try
                Database = New simpp_maarEntities()
                Dim cursoParalelo As curso_paralelo = Database.curso_paralelo.Find(dgvParalelo.CurrentRow.Cells(columnName:="ID").Value)
                If cursoParalelo.Estado = "A" Then
                    cursoParalelo.Estado = "I"
                Else

                    cursoParalelo.Estado = "A"
                End If
                Database.curso_paralelo.AddOrUpdate(cursoParalelo)
                Database.SaveChanges()
                _listaCursosParalelos.Clear()
                dgvParalelo.Rows.Clear()
                Dim id As Integer = Integer.Parse(lblIDCurso.Text)
                For Each entidad In Database.curso_paralelo.Where(Function(o) o.idCurso = id).ToList()
                    FillDataParalelo(entidad, 0)
                Next
                Database.Dispose()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        Public Sub Refrescar()
            dgvParalelo.Rows.Clear()
            _listaCursosParalelos.Clear()
            Database = New simpp_maarEntities()
            Dim id As Integer = Integer.Parse(lblIDCurso.Text)
            For Each entidad In Database.curso_paralelo.Where(Function(o) o.idCurso = id).ToList()
                FillDataParalelo(entidad, 0)
            Next
            Database.Dispose()
        End Sub
    End Class
End Namespace