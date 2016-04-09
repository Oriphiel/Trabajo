Imports System.Data.Entity

Partial Public Class simpp_maarEntities
    Inherits DbContext
    Public Sub New(connString As [String])
        MyBase.New(connString)
    End Sub
End Class
