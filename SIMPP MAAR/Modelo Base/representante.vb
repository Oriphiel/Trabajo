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

Partial Public Class representante
    Public Property idRepresentantes As Integer
    Public Property idpersona As Nullable(Of Integer)
    Public Property trabaja As String
    Public Property direcciont As String
    Public Property telefonot As String
    Public Property correot As String
    Public Property Estado As String = "A"
    Public Property idUsuario As Integer
    Public Property viveEstudiante As String
    Public Property relacion As String
    Public Property nivelEdu As String
    Public Property titulo As String
    Public Property empresa As String

    Public Overridable Property persona As persona
    Public Overridable Property matriculas As ICollection(Of matricula) = New HashSet(Of matricula)
    Public Overridable Property representante_estudiante As ICollection(Of representante_estudiante1) = New HashSet(Of representante_estudiante1)

End Class