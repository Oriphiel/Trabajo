Imports System.IO

Namespace Clases

    Public Class ImagenDb
        ''' <summary>
        ''' Convierte bytes a una imagen
        ''' </summary>
        ''' <param name="imagen">La imagen en bytes.</param>
        ''' <returns></returns>
        Public Shared Function Bytes_Imagen(ByVal imagen As Byte()) As Image
            Try
                If Not Imagen Is Nothing Then
                    'capturar array con memorystream hacia Bin
                    Dim bin As New MemoryStream(Imagen)
                    'con el método FroStream de Image obtenemos imagen
                    Dim resultado As Image = Image.FromStream(bin)
                    'y la retornamos
                    Return resultado
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return Nothing
            End Try
        End Function

        ''' <summary>
        ''' Convierte una imagen a Bytes
        ''' </summary>
        ''' <param name="imagen">La imagen.</param>
        ''' <returns></returns>
        Public Shared Function Imagen_Bytes(ByVal imagen As Image) As Byte()
            'si hay imagen
            If Not Imagen Is Nothing Then
                'variable de datos binarios en stream(flujo)
                Dim bin As New MemoryStream
                'convertir a bytes
                Imagen.Save(bin, Imaging.ImageFormat.Jpeg)
                'retorna binario
                Return bin.GetBuffer
            Else
                Return Nothing
            End If
        End Function

    End Class

End Namespace