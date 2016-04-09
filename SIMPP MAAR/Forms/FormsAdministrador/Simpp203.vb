Imports System.Data.Entity.Migrations
Imports System.Globalization

Namespace Forms.FormsAdministrador

    Public Class Simpp203
        ''' <summary>
        ''' Lista de objetos del tipo rubro, es creada para mantener en memoria información y no estar descargando a la base de datos
        ''' </summary>
        Dim _listaRubros As List(Of rubros_completo) = New List(Of rubros_completo)

        Private Sub txtCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCosto.KeyPress
            OnlyNumbers(e)
            If e.KeyChar = "." AndAlso txtCosto.Text.Contains(".") Then
                e.Handled = True
            End If
        End Sub

        Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
            If txtCosto.Enabled = False Then
                ActivaDesactiva(Panel1)
                BorradoCajas(Panel1)
                lblIDRubros.Text = _listaRubros.Count + 1
                cmbEstado.Enabled = True
                cmbRubros.Enabled = True
                dtpPago.Enabled = True
            End If
        End Sub

        Private Sub Simpp203_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Application.CurrentCulture = New CultureInfo("EN-US")
            dtpPago.Value = DateTime.Now
            Try
                Database = New simpp_maarEntities()
                cmbRubros.DataSource = Database.rubros_det.ToList()
                cmbRubros.ValueMember = "idrubros_det"
                cmbRubros.DisplayMember = "Detalle"
                _listaRubros = Database.rubros_completo.ToList()
                FillData(_listaRubros)
                Database.Dispose()
                dtpPago.Value = DateTime.Now
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try

        End Sub

        Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
            BorradoCajas(Panel1)
            lblIDRubros.Text = Nothing
        End Sub

        Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
            If txtCosto.Enabled = False Then
                ActivaDesactiva(Panel1)
                btnActualizar.Visible = True
                cmbEstado.Enabled = True
                cmbRubros.Enabled = True
                dtpPago.Enabled = True
            End If
        End Sub

        Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
            If txtCosto.Enabled = True Then
                ActivaDesactiva(Panel1)
                If btnActualizar.Visible = True Then
                    btnActualizar.Visible = False
                End If
                cmbEstado.Enabled = False
                cmbRubros.Enabled = False
                dtpPago.Enabled = False
            End If
        End Sub

        Private Sub btnDesactivar_Click(sender As Object, e As EventArgs) Handles btnDesactivar.Click
            Try
                Database = New simpp_maarEntities()
                Dim rub As rubro = Database.rubros.Find(dgvRubros.CurrentRow.Cells(columnName:="ID").Value)
                rub.Estado = "I"
                Database.rubros.AddOrUpdate(rub)
                Database.SaveChanges()
                _listaRubros = Database.rubros_completo.ToList()
                FillData(_listaRubros)
                Database.Dispose()
                BorradoCajas(Panel1)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
            Try
                Database = New simpp_maarEntities()
                Dim rub As rubro = Database.rubros.Find(dgvRubros.CurrentRow.Cells(columnName:="ID").Value)
                If cmbEstado.SelectedIndex = 0 Then
                    rub.Estado = "A"
                Else
                    rub.Estado = "I"
                End If
                rub.Costo = Decimal.Parse(txtCosto.Text)
                rub.Detalle = cmbRubros.SelectedValue
                rub.Fecha_de_pago = Format(dtpPago.Value, "yyyy-MM-dd")
                Database.rubros.AddOrUpdate(rub)
                Database.SaveChanges()
                _listaRubros = Database.rubros_completo.ToList()
                FillData(_listaRubros)
                Database.Dispose()
                BorradoCajas(Panel1)
                btnActualizar.Visible = False
                ActivaDesactiva(Panel1)
                cmbEstado.Enabled = False
                cmbRubros.Enabled = False
                dtpPago.Enabled = False
                lblIDRubros.Text = Nothing
                dtpPago.Value = DateTime.Now
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        Private Sub btngrabar_Click(sender As Object, e As EventArgs) Handles btngrabar.Click
            Try
                Database = New simpp_maarEntities()
                Dim rub As rubro = New rubro()
                If cmbEstado.SelectedIndex = 0 Then
                    rub.Estado = "A"
                Else
                    rub.Estado = "I"
                End If
                rub.Costo = Decimal.Parse(txtCosto.Text)
                rub.Detalle = cmbRubros.SelectedValue
                rub.Fecha_de_pago = Format(dtpPago.Value, "yyyy-MM-dd")
                rub.idUsuario = User
                Database.rubros.AddOrUpdate(rub)
                Database.SaveChanges()
                _listaRubros = Database.rubros_completo.ToList()
                FillData(_listaRubros)
                Database.Dispose()
                BorradoCajas(Panel1)
                ActivaDesactiva(Panel1)
                cmbEstado.Enabled = False
                cmbRubros.Enabled = False
                dtpPago.Enabled = False
                lblIDRubros.Text = Nothing
                dtpPago.Value = DateTime.Now
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        Private Sub dgvRubros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRubros.CellClick
            If txtCosto.Enabled = False Then
                Database = New simpp_maarEntities()
                Dim rub As rubro = Database.rubros.Find(dgvRubros.CurrentRow.Cells(columnName:="ID").Value)
                lblIDRubros.Text = rub.idRubros
                cmbRubros.SelectedValue = rub.rubros_det.idrubros_det
                txtCosto.Text = rub.Costo
                If rub.Estado = "A" Then
                    cmbEstado.SelectedIndex = 0
                Else
                    cmbEstado.SelectedIndex = 1
                End If
                dgvRubros.Text = rub.Fecha_de_pago.ToString()
                Database.Dispose()
            End If
        End Sub

        ''' <summary>
        ''' Llenar los datos del DataGridView
        ''' </summary>
        ''' <param name="lista">De lista.</param>
        Public Sub FillData(ByRef lista As List(Of rubros_completo))
            dgvRubros.DataSource = Nothing
            dgvRubros.Rows.Clear()
            dgvRubros.ColumnCount = 5
            With dgvRubros
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "ID"
                .Columns(0).Name = "ID"
                .Columns(1).HeaderCell.Value = "Detalle"
                .Columns(2).HeaderCell.Value = "Costo"
                .Columns(3).HeaderCell.Value = "Fecha de pago"
                .Columns(4).HeaderCell.Value = "Estado"
            End With
            For Each rub In lista
                dgvRubros.Rows.Add({rub.ID, rub.DETALLE, rub.Costo, rub.Fecha_de_pago.ToShortDateString(), rub.ESTADO})
            Next
            dgvRubros.Refresh()
        End Sub

    End Class
End Namespace