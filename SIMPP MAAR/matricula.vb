'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class matricula
    Public Property idMatricula As Integer
    Public Property idEstudiante As Integer
    Public Property idPeriodo As Integer
    Public Property Estado As String = "A"
    Public Property idUsuario As Integer
    Public Property idRepresentante As Integer
    Public Property idCurso_paralelo As Integer

    Public Overridable Property cuotas As ICollection(Of cuota) = New HashSet(Of cuota)
    Public Overridable Property estudiante As estudiante
    Public Overridable Property fact_cab As ICollection(Of fact_cab) = New HashSet(Of fact_cab)
    Public Overridable Property periodo As periodo
    Public Overridable Property representante As representante
    Public Overridable Property curso_paralelo As curso_paralelo

End Class
