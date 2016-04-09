Imports System.Data.Entity.Migrations

Namespace Forms.FormsAdministrador

    Public Class Simpp204        
        ''' <summary>
        ''' Lista de ciudades disponibles
        ''' </summary>
        Dim _listaCiudad As List(Of ciudad) = New List(Of ciudad)

        Private Sub Simpp204_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Database = New simpp_maarEntities()
            _listaCiudad = Database.ciudads.ToList()
            FillData(_listaCiudad)
            Database.Dispose()
        End Sub

        Private Sub dgvRubros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRubros.CellClick
            If txtDetalle.Enabled = False Then
                Dim ciu As ciudad = _listaCiudad.Find(Function(o) o.idCiudad = dgvRubros.CurrentRow.Cells(columnName:="ID").Value)
                lblIDCiudad.Text = ciu.idCiudad
                txtDetalle.Text = ciu.Detalle
                If ciu.Estado = "A" Then
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
                lblIDCiudad.Text = _listaCiudad.Count + 1
                cmbEstado.Enabled = True
            End If
        End Sub

        Private Sub btngrabar_Click(sender As Object, e As EventArgs) Handles btngrabar.Click
            Try
                Database = New simpp_maarEntities()
                Dim ciudad As ciudad = New ciudad()
                If cmbEstado.SelectedIndex = 0 Then
                    ciudad.Estado = "A"
                Else
                    ciudad.Estado = "I"
                End If
                ciudad.Detalle = txtDetalle.Text
                ciudad.idUsuario = User
                Database.ciudads.AddOrUpdate(ciudad)
                Database.SaveChanges()
                _listaCiudad = Database.ciudads.ToList()
                FillData(_listaCiudad)
                Database.Dispose()
                BorradoCajas(Panel1)
                ActivaDesactiva(Panel1)
                cmbEstado.Enabled = False
                lblIDCiudad.Text = Nothing
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
            Try
                Database = New simpp_maarEntities()
                Dim ciudad As ciudad = Database.ciudads.Find(dgvRubros.CurrentRow.Cells(columnName:="ID").Value)
                If cmbEstado.SelectedIndex = 0 Then
                    ciudad.Estado = "A"
                Else
                    ciudad.Estado = "I"
                End If
                ciudad.Detalle = txtDetalle.Text
                Database.ciudads.AddOrUpdate(ciudad)
                Database.SaveChanges()
                _listaCiudad = Database.ciudads.ToList()
                FillData(_listaCiudad)
                Database.Dispose()
                BorradoCajas(Panel1)
                ActivaDesactiva(Panel1)
                btnActualizar.Visible = False
                cmbEstado.Enabled = False
                lblIDCiudad.Text = Nothing
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
            BorradoCajas(Panel1)
            lblIDCiudad.Text = Nothing
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
                Dim ciudad As ciudad = Database.ciudads.Find(dgvRubros.CurrentRow.Cells(columnName:="ID").Value)
                ciudad.Estado = "I"
                Database.ciudads.AddOrUpdate(ciudad)
                Database.SaveChanges()
                _listaCiudad = Database.ciudads.ToList()
                FillData(_listaCiudad)
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
        Public Sub FillData(ByRef lista As List(Of ciudad))
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
            For Each rub In lista
                dgvRubros.Rows.Add({rub.idCiudad, rub.Detalle, rub.Estado})
            Next
            dgvRubros.Refresh()
        End Sub

    End Class
End Namespace