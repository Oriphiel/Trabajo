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

Partial Public Class cuota
    Public Property idCuotas As Integer
    Public Property idMatricula As Integer
    Public Property idRubro As Integer
    Public Property creado As Date
    Public Property Fecha_pago_realizado As Nullable(Of Date)
    Public Property Estado As String = "A"
    Public Property idUsuario As Integer
    Public Property Pagar As Decimal
    Public Property Descuento As Nullable(Of Integer)
    Public Property DetalleDescuento As String

    Public Overridable Property matricula As matricula
    Public Overridable Property rubro As rubro

End Class
