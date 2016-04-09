Namespace Reports
    Public Class Reporte
        Dim _idMatricula As Integer
        Dim _idCabecera As Integer
        Dim _idCurso As Integer
        Dim _idMultiple As String
        Dim _mes As String
        Dim _op As Integer

        Private Sub ReporteMatricula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Database = New simpp_maarEntities()
            Dim source As BindingSource = New BindingSource()
            If _op = 1 Then
                source.DataSource = Database.matricula_completa.Find(_idMatricula)
                Dim reporte As ReporteMatricula = New ReporteMatricula()
                reporte.SetDataSource(source)
                CrystalReportViewer1.ReportSource = reporte
                CrystalReportViewer1.RefreshReport()
            ElseIf _op = 2 Then
                source.DataSource = Database.matricula_completa.Find(_idMatricula)
                Dim reporte As ReporteRetiro = New ReporteRetiro()
                reporte.SetDataSource(source)
                CrystalReportViewer1.ReportSource = reporte
                CrystalReportViewer1.RefreshReport()
            ElseIf _op = 3 Then
                Dim matri = Database.matriculas.Find(_idMatricula)
                source.DataSource = Database.matricula_alumno.Find(_idMatricula)
                Dim reporte As FichaMatricula = New FichaMatricula()
                Dim source1 As BindingSource = New BindingSource()
                Dim source2 As BindingSource = New BindingSource()
                Dim source3 As BindingSource = New BindingSource()
                source1.DataSource = Database.estudiante_madre.Find(matri.idEstudiante)
                source2.DataSource = Database.estudiante_padre.Find(matri.idEstudiante)
                source3.DataSource = Database.matricula_representante1.Find(matri.idMatricula)
                reporte.SetDataSource(source)
                reporte.Subreports(0).DataSourceConnections.Clear()
                reporte.Subreports(0).SetDataSource(source1)
                reporte.Subreports(1).SetDataSource(source2)
                reporte.Subreports(2).SetDataSource(source3)
                CrystalReportViewer1.ReportSource = reporte
                CrystalReportViewer1.RefreshReport()
            ElseIf _op = 4 Then
                source.DataSource = Database.zcabeceras.Find(_idCabecera)
                Dim source1 As BindingSource = New BindingSource()
                Dim reporte As Factura = New Factura()
                source1.DataSource = Database.factura_detalles.AsNoTracking().Where(Function(o) o.idfact_cab = _idCabecera).ToList()
                reporte.SetDataSource(source)
                reporte.Subreports(0).DataSourceConnections.Clear()
                reporte.Subreports(0).SetDataSource(source1)
                CrystalReportViewer1.ReportSource = reporte
                CrystalReportViewer1.RefreshReport()
            ElseIf _op = 5 Then
                If _idCurso = 0 Then
                    source.DataSource = Database.zcuotas_matricula.ToList()
                Else
                    Dim cursito As curso_completo_nombres_unidos = Database.curso_completo_nombres_unidos.Find(_idCurso)
                    source.DataSource = Database.zcuotas_matricula.Where(Function(o) o.Curso = cursito.Curso And o.periodo = _idMultiple).ToList()
                End If
                Dim reporte As ReporteCuotasMatriculas = New ReporteCuotasMatriculas()
                reporte.SetDataSource(source)
                CrystalReportViewer1.ReportSource = reporte
                CrystalReportViewer1.RefreshReport()
            ElseIf _op = 6 Then
                If _idCurso = 0 Then
                    source.DataSource = Database.zcuotas_meses.ToList()
                Else
                    Dim cursito As curso_completo_nombres_unidos = Database.curso_completo_nombres_unidos.Find(_idCurso)
                    source.DataSource = Database.zcuotas_meses.Where(Function(o) o.Curso = cursito.Curso And o.periodo = _idMultiple).ToList()
                End If
                Dim reporte As ReporteCuotasMeses = New ReporteCuotasMeses()
                reporte.SetDataSource(source)
                CrystalReportViewer1.ReportSource = reporte
                CrystalReportViewer1.RefreshReport()
            ElseIf _op = 7 Then
                If _mes = Nothing And _idMultiple = Nothing Then
                    source.DataSource = Database.zpagosmensuales.ToList()
                ElseIf _mes = Nothing Then
                    Dim cursito As curso_completo_nombres_unidos = Database.curso_completo_nombres_unidos.Find(_idCurso)
                    source.DataSource = Database.zpagosmensuales.Where(Function(o) o.Curso = cursito.Curso And o.periodo = _idMultiple).ToList()
                ElseIf _idMultiple = Nothing Then
                    source.DataSource = Database.zpagosmensuales.Where(Function(o) o.detalle = _mes).ToList()
                Else
                    Dim cursito As curso_completo_nombres_unidos = Database.curso_completo_nombres_unidos.Find(_idCurso)
                    source.DataSource = Database.zpagosmensuales.Where(Function(o) o.Curso = cursito.Curso And o.periodo = _idMultiple And o.detalle = _mes).ToList()
                End If
                Dim reporte As ReportePagosMensual = New ReportePagosMensual()
                reporte.SetDataSource(source)
                CrystalReportViewer1.ReportSource = reporte
                CrystalReportViewer1.RefreshReport()
            ElseIf _op = 8 Then
                Dim reporte As ReporteAnual = New ReporteAnual()
                If _idMultiple = Nothing Then
                    source.DataSource = Database.zanual_pagos_matricula.ToList()
                    Dim source1 As BindingSource = New BindingSource()
                    source1.DataSource = Database.zanual_pagos_meses.ToList()
                    Reporte.Database.Tables(0).SetDataSource(source)
                    Reporte.Database.Tables(1).SetDataSource(source1)
                Else
                    Dim cursito As curso_completo_nombres_unidos = Database.curso_completo_nombres_unidos.Find(_idCurso)
                    source.DataSource = Database.zanual_pagos_matricula.Where(Function(o) o.Curso = cursito.Curso And o.periodo = _idMultiple).ToList()
                    If source.Count = 0 Then
                        MessageBox.Show(String.Format("Sin estudiantes matriculados en el Curso {0}", cursito.Curso))
                        Close()
                        Return
                    End If
                    Dim source1 As BindingSource = New BindingSource()
                    source1.DataSource = Database.zanual_pagos_meses.Where(Function(o) o.Curso = cursito.Curso And o.periodo = _idMultiple).ToList()
                    reporte.Database.Tables(0).SetDataSource(source)
                    reporte.Database.Tables(1).SetDataSource(source1)
                End If
                CrystalReportViewer1.ReportSource = Reporte
                CrystalReportViewer1.RefreshReport()
            ElseIf _op = 9 Then
                Dim reporte As ReporteListaDeAlumnosCompleta = New ReporteListaDeAlumnosCompleta()
                If _idMultiple = Nothing Then
                    source.DataSource = Database.matricula_representante1.ToList()
                Else
                    Dim cursito As curso_completo_nombres_unidos = Database.curso_completo_nombres_unidos.Find(_idCurso)
                    source.DataSource = Database.matricula_representante1.Where(Function(o) o.Curso2 = cursito.Curso And o.Periodo = _idMultiple).ToList()
                    If source.Count = 0 Then
                        MessageBox.Show(String.Format("Sin estudiantes matriculados en el Curso {0}", cursito.Curso))
                        Close()
                        Return
                    End If
                End If
                reporte.SetDataSource(source)
                CrystalReportViewer1.ReportSource = reporte
                CrystalReportViewer1.RefreshReport()
            ElseIf _op = 10 Then
                Dim reporte As ReporteListaAlumnosCurso = New ReporteListaAlumnosCurso()
                Dim cursito As curso_completo_nombres_unidos = Database.curso_completo_nombres_unidos.Find(_idCurso)
                source.DataSource = Database.matricula_representante1.Where(Function(o) o.Curso2 = cursito.Curso And o.Periodo = _idMultiple).ToList()
                If source.Count = 0 Then
                    MessageBox.Show(String.Format("Sin estudiantes matriculados en el Curso {0}", cursito.Curso))
                    Close()
                    Return
                End If
                reporte.SetDataSource(source)
                CrystalReportViewer1.ReportSource = Reporte
                CrystalReportViewer1.RefreshReport()
            End If
            Database.Dispose()
        End Sub


        Public Sub New(opcion As Integer, id As Integer, Optional idMultiple As String = Nothing, Optional mes As String = Nothing)
            ' Llamada necesaria para el diseñador.
            InitializeComponent()
            _op = opcion
            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            If opcion = 1 Then
                _idMatricula = id
            ElseIf opcion = 2 Then
                _idMatricula = id
            ElseIf opcion = 3 Then
                _idMatricula = id
            ElseIf opcion = 4 Then
                _idCabecera = id
            ElseIf opcion = 5 Or opcion = 6 Then
                _idCurso = id
                _idMultiple = idMultiple
            ElseIf opcion = 7 Then
                _idCurso = id
                _idMultiple = idMultiple
                _mes = mes
            ElseIf opcion = 8 Then
                _idCurso = id
                _idMultiple = idMultiple
            ElseIf opcion = 9 Then
                _idCurso = id
                _idMultiple = idMultiple
            ElseIf opcion = 10 Then
                _idCurso = id
                _idMultiple = idMultiple
            End If
        End Sub
    End Class
End Namespace