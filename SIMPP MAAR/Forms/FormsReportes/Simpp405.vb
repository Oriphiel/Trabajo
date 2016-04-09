Imports SIMPP_MAAR.Reports

Namespace Forms.FormsReportes
    Public Class Simpp405
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

        Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
            Close()
        End Sub

        Private Sub btnInforme_Click(sender As Object, e As EventArgs) Handles btnInforme.Click
            If chbTodos.CheckState = CheckState.Checked Then
                Reporte = New Reporte(9, 0)
                Reporte.Show()
            Else
                If Comprobar() = False Then
                    Return
                End If
                Dim periodo As String = cmbPeriodo.SelectedValue
                Dim idcurso As Integer = cmbParalelo.SelectedValue
                Reporte = New Reporte(9, idcurso, periodo)
                Reporte.Show()
            End If
        End Sub

        Private Sub Simpp405_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Database = New simpp_maarEntities()
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

        Public Function Comprobar() As Boolean
            If cmbParalelo.Enabled = False Then
                MsgBox("Escoja un paralelo")
                Return False
            End If
            Return True
        End Function
    End Class
End Namespace