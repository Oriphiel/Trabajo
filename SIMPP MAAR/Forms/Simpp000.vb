Imports MySql.Data.MySqlClient
Imports SIMPP_MAAR.Forms.FormsAdministrador
Imports SIMPP_MAAR.Forms.FormsInstitucion
Imports SIMPP_MAAR.Forms.FormsMatriculacion
Imports SIMPP_MAAR.Forms.FormsReportes
Imports SIMPP_MAAR.My.Resources

Namespace Forms
    Public Class Simpp000
        ''' <summary>
        '''     Variable para saber si alguna ventana ya se encuentra abierta
        ''' </summary>
        Private _flagOpen As Boolean = False
        Private _op As Integer

        Private Sub simpp_000_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Text = Titulo
            Icon = computer_edit
            Acceso()
        End Sub

        Private Sub btnEstablecimiento_Click(sender As Object, e As EventArgs) Handles btnEstablecimiento.Click
            Establecimientos = New Simpp101()
            OpenForm(Establecimientos)
        End Sub

        Private Sub Simpp000_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
            Application.Exit()
        End Sub


        Private Sub RibbonButton2_Click(sender As Object, e As EventArgs) Handles RibbonButton2.Click
            Informacion = New Simpp102()
            OpenForm(Informacion)
        End Sub

        Private Sub btnNuevoEstudiante_Click(sender As Object, e As EventArgs) Handles btnNuevoEstudiante.Click
            NuevoEstudiante = New Simpp301(0)
            OpenForm(NuevoEstudiante)
        End Sub

        Private Sub btnNuevaMatricula_Click(sender As Object, e As EventArgs) Handles btnNuevaMatricula.Click
            NuevaMatricula = New Simpp302(0)
            OpenForm(NuevaMatricula)
        End Sub

        ''' <summary>
        ''' Metodo para abrir formularios de acuerdo al click que den
        ''' </summary>
        ''' <param name="formulario">El formulario a abrir.</param>
        Private Sub OpenForm(formulario As Form)
            ' Verificamos que no haya ventanas en pantalla y si los hay proceder a "cerrarlas"
            If _flagOpen = False Then
                formulario.TopLevel = False
                formulario.Parent = Panel1
                formulario.Show()
                _flagOpen = True
            Else
                ' Muestra un mensaje en pantalla dando a elegir al usuario si desea cerrar el actual formulario y dependiendo de la opción devuelve un numero
                ' 1 es para OK y 2 es para Cancel
                Dim opcion As Integer = MessageBox.Show(ActualClose, adver, MessageBoxButtons.OKCancel,
                                                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                If opcion.Equals(1) Then
                    _flagOpen = False
                    While (Panel1.Controls.Count > 0)
                        Panel1.Controls.RemoveAt(0)
                    End While
                    OpenForm(formulario)
                End If
            End If
        End Sub

        Private Sub btnConsultaEstudiante_Click(sender As Object, e As EventArgs) Handles btnConsultaEstudiante.Click
            ListaGenerica = New Simpp302A4(1)
            OpenForm(ListaGenerica)
        End Sub

        Private Sub btnConsultaMatriculas_Click(sender As Object, e As EventArgs) Handles btnConsultaMatriculas.Click
            ListaMatriculas = New SImpp303(0)
            OpenForm(ListaMatriculas)
        End Sub

        Private Sub btnUsuario_Click(sender As Object, e As EventArgs) Handles btnUsuario.Click
            ListaUsuarios = New Simpp201()
            OpenForm(ListaUsuarios)
        End Sub

        Private Sub btnRubros_Click(sender As Object, e As EventArgs) Handles btnRubros.Click
            ListaRubros = New Simpp203()
            OpenForm(ListaRubros)
        End Sub

        Private Sub btnCiudad_Click(sender As Object, e As EventArgs) Handles btnCiudad.Click
            ListaCiudad = New Simpp204()
            OpenForm(ListaCiudad)
        End Sub

        Private Sub btnNacionalidad_Click(sender As Object, e As EventArgs) Handles btnNacionalidad.Click
            ListaNacionalidad = New Simpp205()
            OpenForm(ListaNacionalidad)
        End Sub

        Private Sub btnPeriodo_Click(sender As Object, e As EventArgs) Handles btnPeriodo.Click
            ListaPeriodo = New Simpp206()
            OpenForm(ListaPeriodo)
        End Sub

        Private Sub btnCurso_Click(sender As Object, e As EventArgs) Handles btnCurso.Click
            ListaCursos = New Simpp207()
            OpenForm(ListaCursos)
        End Sub

        Private Sub btnParale_Click(sender As Object, e As EventArgs) Handles btnParale.Click
            ListaParalelos = New Simpp209()
            OpenForm(ListaParalelos)
        End Sub

        Private Sub btnCobroMatricula_Click(sender As Object, e As EventArgs) Handles btnCobroMatricula.Click
            Facturacion = New Simpp305()
            OpenForm(Facturacion)
        End Sub

        Private Sub btnMatricula_Click_1(sender As Object, e As EventArgs) Handles btnMatricula.Click
            CertificadoMatricula = New Simpp306()
            OpenForm(CertificadoMatricula)
        End Sub

        Private Sub btnRetiro_Click(sender As Object, e As EventArgs) Handles btnRetiro.Click
            RetiroMatricula = New Simpp307()
            OpenForm(RetiroMatricula)
        End Sub

        Private Sub RibbonTab1_ActiveChanged(sender As Object, e As EventArgs) Handles RibbonTab1.ActiveChanged
            Application.Exit()
        End Sub

        Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
            Try
                Dim constring = "server=localhost;user=root;pwd=TeAmoMelisa_1;database=simpp_maar;"
                Dim backupFile As String
                Dim fileSaver As SaveFileDialog = New SaveFileDialog()
                fileSaver.Filter = "SQL files | *.sql"

                If fileSaver.ShowDialog() = DialogResult.OK Then
                    backupFile = fileSaver.FileName
                    Using sConnection As New MySqlConnection(constring)
                        Using sqlCommand As New MySqlCommand()
                            Using sqlBackup As New MySqlBackup(sqlCommand)
                                sqlCommand.Connection = sConnection
                                sConnection.Open()
                                sqlBackup.ExportInfo.AddCreateDatabase = True
                                sqlBackup.ExportInfo.ExportTableStructure = True
                                sqlBackup.ExportInfo.ExportRows = True
                                sqlBackup.ExportToFile(backupFile)
                                MessageBox.Show("MySQL database backup has been created.", "MySQL Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                sConnection.Close()
                            End Using
                        End Using
                    End Using
                Else
                    MessageBox.Show("No backup file was created.", "MySQL Restore", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
            Try
                Dim constring = "server=localhost;user=root;pwd=TeAmoMelisa_1;"
                Dim restoreFile As String
                Dim fileOpener As OpenFileDialog = New OpenFileDialog()
                fileOpener.Filter = "SQL files | *.sql"
                If fileOpener.ShowDialog() = DialogResult.OK Then
                    restoreFile = fileOpener.FileName
                    Using sConnection As New MySqlConnection(constring)
                        Using sqlCommand As New MySqlCommand()
                            Using sqlBackup As New MySqlBackup(sqlCommand)
                                sqlCommand.Connection = sConnection
                                sConnection.Open()
                                sqlBackup.ImportFromFile(restoreFile)
                                MessageBox.Show("MySQL database ha sido restaurada.", "MySQL Restore", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                sConnection.Close()
                            End Using
                        End Using
                    End Using
                Else
                    MessageBox.Show("Ningún archivo de recuperación ha sido escogido.", "MySQL Restore", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
            Dim nuevo = New SimppAcercaDe
            nuevo.Show()
        End Sub

        Private Sub btnMeses_Click(sender As Object, e As EventArgs) Handles btnMeses.Click
            ReporteDeudasMeses = New Simpp401(0)
            ReporteDeudasMeses.ShowDialog()
            ReporteDeudasMeses.Dispose()
        End Sub

        Private Sub btnMatriculaDeuda_Click(sender As Object, e As EventArgs) Handles btnMatriculaDeuda.Click
            ReporteDeudasMeses = New Simpp401(1)
            ReporteDeudasMeses.ShowDialog()
            ReporteDeudasMeses.Dispose()
        End Sub

        Private Sub btnPagados_Click(sender As Object, e As EventArgs) Handles btnPagados.Click
            ReportePagoMeses = New Simpp403()
            ReportePagoMeses.ShowDialog()
            ReportePagoMeses.Dispose()
        End Sub

        Private Sub btnAnual_Click(sender As Object, e As EventArgs) Handles btnAnual.Click
            ReporteAnual1 = New Simpp404()
            ReporteAnual1.ShowDialog()
            ReporteAnual1.Dispose()
        End Sub

        Private Sub btnListaAlumnos_Click(sender As Object, e As EventArgs) Handles btnListaAlumnos.Click
            ReporteListaAlumnos = New Simpp405()
            ReporteListaAlumnos.ShowDialog()
            ReporteListaAlumnos.Dispose()
        End Sub

        Private Sub btnListaCurso_Click(sender As Object, e As EventArgs) Handles btnListaCurso.Click
            ReporteListaCursoAlumnos = New Simpp406()
            ReporteListaCursoAlumnos.ShowDialog()
            ReporteListaCursoAlumnos.Dispose()
        End Sub

        Public Sub Acceso()
            Database = New simpp_maarEntities()
            Dim perfil As perfil = Database.perfils.Find(_op)
            If perfil.Detalle.Equals("Administrador") Then
                'smpp300.Visible = False
                'smpp400.Visible = False
            ElseIf perfil.Detalle.Equals("Secretaria") Then
                smpp200.Visible = False
                btnCobroMatricula.Enabled = False
                btnAnual.Enabled = False
                btnPagados.Enabled = False
            ElseIf perfil.Detalle.Equals("Colecturia") Then
                smpp200.Visible = False
                btnNuevaMatricula.Enabled = False
                btnNuevoEstudiante.Enabled = False
            End If
            Database.Dispose()
        End Sub

        Public Sub New(opcion As Integer)
            ' Llamada necesaria para el diseñador.
            InitializeComponent()
            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            _op = opcion
        End Sub

        Private Sub btnPersonas_Click(sender As Object, e As EventArgs) Handles btnPersonas.Click
            ListaDePersonas = New Simpp202()
            OpenForm(ListaDePersonas)
        End Sub


        Private Sub btnAnularRetiro_Click(sender As Object, e As EventArgs) Handles btnAnularRetiro.Click
            AnularRetiro = New Simpp308()
            OpenForm(AnularRetiro)
        End Sub
    End Class
End Namespace