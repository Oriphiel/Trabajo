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

Partial Public Class persona
    Public Property idPersona As Integer
    Public Property Cedula As String
    Public Property Nombre As String
    Public Property Apellidos As String
    Public Property Telefono As String
    Public Property Direccion As String
    Public Property IDCiudad As Integer
    Public Property Correo As String
    Public Property Genero As String
    Public Property Fecha_nacimiento As Nullable(Of Date)
    Public Property Estado_civil As String
    Public Property idNacionalidad As Nullable(Of Integer)
    Public Property Estado As String = "A"
    Public Property idUsuario As Integer

    Public Overridable Property ciudad As ciudad
    Public Overridable Property estudiantes As ICollection(Of estudiante) = New HashSet(Of estudiante)
    Public Overridable Property nacionalidad As nacionalidad
    Public Overridable Property representantes As ICollection(Of representante) = New HashSet(Of representante)
    Public Overridable Property usuarios As ICollection(Of usuario) = New HashSet(Of usuario)

End Class
