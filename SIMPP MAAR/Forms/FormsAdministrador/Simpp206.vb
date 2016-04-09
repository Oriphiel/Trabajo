Imports System.Data.Entity.Migrations

Namespace Forms.FormsAdministrador
    Public Class Simpp206
        ''' <summary>
        ''' Lista de periodos disponibles
        ''' </summary>
        Dim _listaPeriodo As List(Of periodo) = New List(Of periodo)

        Private Sub Simpp204_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Database = New simpp_maarEntities()
            _listaPeriodo = Database.periodoes.ToList()
            FillData(_listaPeriodo)
            Database.Dispose()
        End Sub

        Private Sub dgvRubros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRubros.CellClick
            If txtDetalle.Enabled = False Then
                Dim periodo As periodo = _listaPeriodo.Find(Function(o) o.idPeriodo = dgvRubros.CurrentRow.Cells(columnName:="ID").Value)
                lblIDPeriodo.Text = periodo.idPeriodo
                txtDetalle.Text = periodo.Detalle
                If periodo.Estado = "A" Then
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
                lblIDPeriodo.Text = _listaPeriodo.Count + 1
                cmbEstado.Enabled = True
            End If
        End Sub

        Private Sub btngrabar_Click(sender As Object, e As EventArgs) Handles btngrabar.Click
            Try
                Database = New simpp_maarEntities()
                Dim periodo = New periodo()
                If cmbEstado.SelectedIndex = 0 Then
                    periodo.Estado = "A"
                Else
                    periodo.Estado = "I"
                End If
                periodo.Detalle = txtDetalle.Text
                periodo.idUsuario = User
                Database.periodoes.AddOrUpdate(periodo)
                Database.SaveChanges()
                _listaPeriodo = Database.periodoes.ToList()
                FillData(_listaPeriodo)
                Database.Dispose()
                BorradoCajas(Panel1)
                ActivaDesactiva(Panel1)
                cmbEstado.Enabled = False
                lblIDPeriodo.Text = Nothing
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
            Try
                Database = New simpp_maarEntities()
                Dim periodo As periodo = Database.periodoes.Find(dgvRubros.CurrentRow.Cells(columnName:="ID").Value)
                If cmbEstado.SelectedIndex = 0 Then
                    periodo.Estado = "A"
                Else
                    periodo.Estado = "I"
                End If
                periodo.Detalle = txtDetalle.Text
                Database.periodoes.AddOrUpdate(periodo)
                Database.SaveChanges()
                _listaPeriodo = Database.periodoes.ToList()
                FillData(_listaPeriodo)
                Database.Dispose()
                BorradoCajas(Panel1)
                ActivaDesactiva(Panel1)
                btnActualizar.Visible = False
                cmbEstado.Enabled = False
                lblIDPeriodo.Text = Nothing
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
            BorradoCajas(Panel1)
            lblIDPeriodo.Text = Nothing
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
                Dim periodo As periodo = Database.periodoes.Find(dgvRubros.CurrentRow.Cells(columnName:="ID").Value)
                periodo.Estado = "I"
                Database.periodoes.AddOrUpdate(periodo)
                Database.SaveChanges()
                _listaPeriodo = Database.periodoes.ToList()
                FillData(_listaPeriodo)
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
        Public Sub FillData(ByRef lista As List(Of periodo))
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
            For Each periodo In lista
                dgvRubros.Rows.Add({periodo.idPeriodo, periodo.Detalle, periodo.Estado})
            Next
            dgvRubros.Refresh()
        End Sub
    End Class
End Namespace