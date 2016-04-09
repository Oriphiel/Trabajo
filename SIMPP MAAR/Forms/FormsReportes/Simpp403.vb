Imports SIMPP_MAAR.Reports

Namespace Forms.FormsReportes
    Public Class Simpp403

        Private Sub chbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chbTodos.CheckedChanged
            If chbTodos.CheckState = CheckState.Checked Then
                cmbPeriodo.Enabled = False
                cmbCurso.Enabled = False
                cmbParalelo.Enabled = False
            Else
                cmbPeriodo.Enabled = True
                cmbCurso.Enabled = True
                cmbParalelo.Enabled = False
            End If
        End Sub

        Private Sub Simpp403_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Database = New simpp_maarEntities()
            cmbRubros.DataSource = Database.rubros_completo.ToList()
            cmbRubros.ValueMember = "Detalle"
            cmbRubros.DisplayMember = "Detalle"
            cmbCurso.DataSource = Database.cursos.Where(Function(o) o.Estado = "A").ToList()
            cmbCurso.ValueMember = "idCursos"
            cmbCurso.DisplayMember = "Detalle"
            cmbCurso.SelectedItem = "Detalle"
            cmbPeriodo.DataSource = Database.periodoes.Where(Function(o) o.Estado = "A").ToList()
            cmbPeriodo.ValueMember = "Detalle"
            cmbPeriodo.DisplayMember = "Detalle"
            Database.Dispose()
        End Sub

        Private Sub cmbCurso_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbCurso.SelectionChangeCommitted
            Database = New simpp_maarEntities()
            Dim curso As String = cmbCurso.Text
            cmbParalelo.DataSource = Database.curso_completo.Where(Function(o) o.Curso = curso And o.Estado = "A").ToList()
            cmbParalelo.ValueMember = "ID"
            cmbParalelo.DisplayMember = "Paralelo"
            Database.Dispose()
            cmbParalelo.Enabled = True
        End Sub

        Private Sub btnInforme_Click(sender As Object, e As EventArgs) Handles btnInforme.Click
            Dim periodo As String = cmbPeriodo.SelectedValue
            Dim idcurso As Integer = cmbParalelo.SelectedValue
            Dim detalle As String = cmbRubros.SelectedValue
            If chbRubros.CheckState = CheckState.Checked Then
                If chbTodos.CheckState = CheckState.Checked Then
                    Reporte = New Reporte(7, 0)
                    Reporte.Show()
                Else
                    If Comprobar() = False Then
                        Return
                    End If
                    Reporte = New Reporte(7, idcurso, periodo)
                    Reporte.Show()
                End If
            Else
                If chbTodos.CheckState = CheckState.Checked Then
                    Reporte = New Reporte(7, 0, Nothing, detalle)
                    Reporte.Show()
                Else
                    If Comprobar() = False Then
                        Return
                    End If
                    Reporte = New Reporte(7, idcurso, periodo, detalle)
                    Reporte.Show()
                End If
            End If
        End Sub

        Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
            Close()
        End Sub

        Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chbRubros.CheckedChanged
            If chbRubros.CheckState = CheckState.Checked Then
                cmbRubros.Enabled = False
            Else
                cmbRubros.Enabled = True
            End If
        End Sub

        Public Function Comprobar() As Boolean
            If cmbParalelo.Enabled = False Then
                MsgBox("Escoja un paralelo")
                Return False
            End If
            Return True
        End Function
    End Class
End Namespace