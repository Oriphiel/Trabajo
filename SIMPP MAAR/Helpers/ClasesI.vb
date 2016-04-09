Imports SIMPP_MAAR.Forms.FormsAdministrador
Imports SIMPP_MAAR.Forms.FormsInstitucion
Imports SIMPP_MAAR.Forms.FormsMatriculacion
Imports SIMPP_MAAR.Forms.FormsReportes
Imports SIMPP_MAAR.Reports

Public Module ClasesI
    Public Establecimientos As Simpp101
    Public Informacion As Simpp102

    Public ListaUsuarios As Simpp201
    Public ListaPersonas As Simpp201B
    Public ListaDePersonas As Simpp202
    Public ListaRubros As Simpp203
    Public ListaCiudad As Simpp204
    Public ListaNacionalidad As Simpp205
    Public ListaPeriodo As Simpp206
    Public ListaCursos As Simpp207
    Public ListaCursosParalelos As Simpp208
    Public ListaParalelos As Simpp209

    Public NuevoEstudiante As Simpp301
    Public NuevoRepresentante As Simpp301A
    Public NuevaMatricula As Simpp302
    Public ListaGenerica As Simpp302A4
    Public ListaMatriculas As SImpp303
    Public Facturacion As Simpp305
    Public ListaEstudiantesFac As Simpp305B
    Public CertificadoMatricula As Simpp306
    Public RetiroMatricula As Simpp307
    Public AnularRetiro As Simpp308

    Public ReporteDeudasMeses As Simpp401
    Public ReportePagoMeses As Simpp403
    Public ReporteAnual1 As Simpp404
    Public ReporteListaAlumnos As Simpp405
    Public ReporteListaCursoAlumnos As Simpp406

    Public Database As New simpp_maarEntities
    Public Reporte As Reporte

    Public User As Integer
End Module