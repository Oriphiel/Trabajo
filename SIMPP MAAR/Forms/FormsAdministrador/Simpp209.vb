Imports System.Data.Entity.Migrations

Namespace Forms.FormsAdministrador
    Public Class Simpp209
        ''' <summary>
        ''' Lista de ciudades disponibles
        ''' </summary>
        Dim _listaParalelos As List(Of paralelo) = New List(Of paralelo)

        Private Sub Simpp209_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Database = New simpp_maarEntities()
            _listaParalelos = Database.paralelos.ToList()
            FillData(_listaParalelos)
            Database.Dispose()
        End Sub

        Private Sub dgvParalelos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvParalelos.CellClick
            If txtDetalle.Enabled = False Then
                Dim paralelo As paralelo = _listaParalelos.Find(Function(o) o.idParalelos = dgvParalelos.CurrentRow.Cells(columnName:="ID").Value)
                lblIDParalelo.Text = paralelo.idParalelos
                txtDetalle.Text = paralelo.Detalle
                If paralelo.Estado = "A" Then
                    cmbEstado.SelectedIndex = 0
                Else
                    cmbEstado.SelectedIndex = 1
                End If
            End If
        End Sub

        Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
            If txtDetalle.Enabled = False Then
                ActivaDesactiva(Panel1)
                BorradoCajas(Panel1)
                lblIDParalelo.Text = _listaParalelos.Count + 1
                cmbEstado.Enabled = True
            End If
        End Sub

        Private Sub btngrabar_Click(sender As Object, e As EventArgs) Handles btngrabar.Click
            Try
                Database = New simpp_maarEntities()
                Dim paralelo As paralelo = New paralelo()
                If cmbEstado.SelectedIndex = 0 Then
                    paralelo.Estado = "A"
                Else
                    paralelo.Estado = "I"
                End If
                paralelo.Detalle = txtDetalle.Text
                paralelo.idUsuario = User
                Database.paralelos.AddOrUpdate(paralelo)
                Database.SaveChanges()
                _listaParalelos = Database.paralelos.ToList()
                FillData(_listaParalelos)
                Database.Dispose()
                BorradoCajas(Panel1)
                ActivaDesactiva(Panel1)
                cmbEstado.Enabled = False
                lblIDParalelo.Text = Nothing
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
            Try
                Database = New simpp_maarEntities()
                Dim paralelo As paralelo = Database.paralelos.Find(dgvParalelos.CurrentRow.Cells(columnName:="ID").Value)
                If cmbEstado.SelectedIndex = 0 Then
                    paralelo.Estado = "A"
                Else
                    paralelo.Estado = "I"
                End If
                paralelo.Detalle = txtDetalle.Text
                Database.paralelos.AddOrUpdate(paralelo)
                Database.SaveChanges()
                _listaParalelos = Database.paralelos.ToList()
                FillData(_listaParalelos)
                Database.Dispose()
                BorradoCajas(Panel1)
                ActivaDesactiva(Panel1)
                btnActualizar.Visible = False
                cmbEstado.Enabled = False
                lblIDParalelo.Text = Nothing
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
            BorradoCajas(Panel1)
            lblIDParalelo.Text = Nothing
        End Sub

        Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
            If txtDetalle.Enabled = False Then
                ActivaDesactiva(Panel1)
                btnActualizar.Visible = True
                cmbEstado.Enabled = True
            End If
        End Sub

        Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
            If txtDetalle.Enabled = True Then
                ActivaDesactiva(Panel1)
                If btnActualizar.Visible = True Then
                    btnActualizar.Visible = False
                End If
                cmbEstado.Enabled = False
            End If
        End Sub

        Private Sub btnDesactivar_Click(sender As Object, e As EventArgs) Handles btnDesactivar.Click
            Try
                Database = New simpp_maarEntities()
                Dim paralelo As paralelo = Database.paralelos.Find(dgvParalelos.CurrentRow.Cells(columnName:="ID").Value)
                paralelo.Estado = "I"
                Database.paralelos.AddOrUpdate(paralelo)
                Database.SaveChanges()
                _listaParalelos = Database.paralelos.ToList()
                FillData(_listaParalelos)
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
        Public Sub FillData(ByRef lista As List(Of paralelo))
            dgvParalelos.DataSource = Nothing
            dgvParalelos.Rows.Clear()
            dgvParalelos.ColumnCount = 3
            With dgvParalelos
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "ID"
                .Columns(0).Name = "ID"
                .Columns(1).HeaderCell.Value = "Detalle"
                .Columns(2).HeaderCell.Value = "Estado"
            End With
            For Each rub In lista
                dgvParalelos.Rows.Add({rub.idParalelos, rub.Detalle, rub.Estado})
            Next
            dgvParalelos.Refresh()
        End Sub
    End Class
End Namespace