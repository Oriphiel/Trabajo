Imports System.Data.Entity.Migrations

Namespace Forms.FormsInstitucion
    Public Class Simpp101

        Private Sub Simpp101_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Try
                Database = New simpp_maarEntities()
                Dim hola = Database.establecimientoes.FirstOrDefault()
                If hola Is Nothing Then
                    Console.WriteLine("Esta vacía")
                Else
                    FillData(hola)
                End If
                Database.Dispose()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        ''' <summary>
        ''' Llenamos los datos con los datos de la institución
        ''' </summary>
        ''' <param name="nuevo">Es el objeto del tipo establecimiento.</param>
        Public Sub FillData(ByRef nuevo As establecimiento)
            txtNombreInstitucion.Text = nuevo.Nombre
            txtNombreRector.Text = nuevo.Rector
            txtDireccion.Text = nuevo.Direccion
            txtResolucionMinisterial.Text = nuevo.Resoloucion
            txtTelefono.Text = nuevo.Telefono
            cmbSeccion.SelectedItem = nuevo.Seccion
            cmbTipo.SelectedItem = nuevo.Tipo
            txtDescripcion.Text = nuevo.Descripcion
            txtEmail.Text = nuevo.Correo
            txtWeb.Text = nuevo.Web
        End Sub


        Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
            ActivaDesactiva(Panel1)
            btnEditar.Enabled = False
            btnGuardar.Enabled = True
            cmbSeccion.Enabled = True
            cmbTipo.Enabled = True
        End Sub


        Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
            ActivaDesactiva(Panel1)
            btnEditar.Enabled = True
            btnGuardar.Enabled = False
            cmbSeccion.Enabled = False
            cmbTipo.Enabled = False
            Database = New simpp_maarEntities()
            Dim nuevo = Database.establecimientoes.FirstOrDefault()
            If nuevo Is Nothing Then
                nuevo = New establecimiento()
            End If
            Try
                nuevo.Nombre = txtNombreInstitucion.Text
                nuevo.Rector = txtNombreRector.Text
                nuevo.Descripcion = txtDescripcion.Text
                nuevo.Correo = txtEmail.Text
                nuevo.Web = txtWeb.Text
                nuevo.Direccion = txtDireccion.Text
                nuevo.Resoloucion = txtResolucionMinisterial.Text
                nuevo.Telefono = txtTelefono.Text
                nuevo.Seccion = cmbSeccion.SelectedItem.ToString()
                nuevo.Tipo = cmbTipo.SelectedItem.ToString()
                Database.establecimientoes.AddOrUpdate(nuevo)
                Database.SaveChanges()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            Database.Dispose()
        End Sub

    End Class
End Namespace