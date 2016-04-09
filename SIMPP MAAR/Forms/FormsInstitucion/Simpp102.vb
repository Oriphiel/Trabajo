Imports System.Data.Entity.Migrations
Imports SIMPP_MAAR.Clases
Imports SIMPP_MAAR.My.Resources

Namespace Forms.FormsInstitucion
    Public Class Simpp102

        Private Sub btnChangeImage_Click(sender As Object, e As EventArgs) Handles btnChangeImage.Click
            OpenFileDialogImage.Filter = filter_image
            If OpenFileDialogImage.ShowDialog() = DialogResult.OK Then
                picBoxEscudo.ImageLocation = OpenFileDialogImage.FileName
                Console.WriteLine(picBoxEscudo.ImageLocation)
                btnSaveImage.Enabled = True
            End If

        End Sub

        Private Sub Simpp102_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Database = New simpp_maarEntities()
            Dim hola = Database.establecimientoes.FirstOrDefault()
            If hola Is Nothing Then
                Console.WriteLine("Esta vacía")
            Else
                txtMision.Text = hola.Mision
                txtVision.Text = hola.Vision
                txtHimno.Text = hola.HImno
                picBoxEscudo.Image = ImagenDb.Bytes_Imagen(hola.Escudo)
            End If
            Database.Dispose()
        End Sub

        Private Sub btnEditMision_Click(sender As Object, e As EventArgs) Handles btnEditMision.Click
            btnSaveMision.Enabled = True
            txtMision.Enabled = True
        End Sub

        Private Sub btnEditVision_Click(sender As Object, e As EventArgs) Handles btnEditVision.Click
            btnSaveVision.Enabled = True
            txtVision.Enabled = True
        End Sub

        Private Sub btnEditHimno_Click(sender As Object, e As EventArgs) Handles btnEditHimno.Click
            btnSaveHimno.Enabled = True
            txtHimno.Enabled = True
        End Sub

        Private Sub btnSaveMision_Click(sender As Object, e As EventArgs) Handles btnSaveMision.Click
            Grabar(1)
        End Sub

        Private Sub btnSaveVision_Click(sender As Object, e As EventArgs) Handles btnSaveVision.Click
            Grabar(2)
        End Sub

        Private Sub btnSaveHimno_Click(sender As Object, e As EventArgs) Handles btnSaveHimno.Click
            Grabar(3)
        End Sub

        Private Sub btnSaveImage_Click(sender As Object, e As EventArgs) Handles btnSaveImage.Click
            Grabar(4)
        End Sub

        ''' <summary>
        ''' Graba de acuerdo a la opción escogida en la DB
        ''' </summary>
        ''' <param name="opcion">La opción. 1 es para Misión, 2 para Visión, 3 para Himno y 4 para Escudo</param>
        Public Sub Grabar(ByVal opcion As Integer)
            Try
                Database = New simpp_maarEntities()
                Dim hola = Database.establecimientoes.FirstOrDefault()
                Select Case opcion
                    Case 1
                        hola.Mision = txtMision.Text
                        btnSaveMision.Enabled = False
                        txtMision.Enabled = False

                    Case 2
                        hola.Vision = txtVision.Text
                        btnSaveVision.Enabled = False
                        txtVision.Enabled = False

                    Case 3
                        hola.HImno = txtHimno.Text
                        btnSaveHimno.Enabled = False
                        txtHimno.Enabled = False

                    Case 4
                        hola.Escudo = ImagenDb.Imagen_Bytes(picBoxEscudo.Image)
                        btnSaveImage.Enabled = False

                End Select
                Database.establecimientoes.AddOrUpdate(hola)
                Database.SaveChanges()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            Database.Dispose()
        End Sub



    End Class
End Namespace