﻿Namespace Forms
    Public Class SimppAcercaDe

        Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
            ' Esto permite realizar procesos en el sistema, en este caso iniciamos el llamado de alguna aplicación para enviar correos, la que este por defecto en el sistema.
            Dim proc As New System.Diagnostics.Process()
            proc.StartInfo.FileName = "mailto:adriancoque14@gmail.com?subject=Contacto&body=Le contanto pará"
            proc.Start()
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Close()
        End Sub
    End Class
End Namespace