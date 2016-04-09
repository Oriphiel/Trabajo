Imports System.Collections.Generic
Imports System.Data.Entity.Core.EntityClient
Imports System.Linq

Namespace Forms.FormsMatriculacion

    Public Class Simpp302A4
        Dim _listEstudiantes As List(Of estudiantepersona) = New List(Of estudiantepersona)
        Dim _listaRepresentantes As List(Of representantecompleto) = New List(Of representantecompleto)
        Dim _op As Integer
        ''' <summary>
        ''' Initializes a new instance of the <see cref="Simpp302A4"/> class.
        ''' </summary>
        ''' <param name="opcion">Elige el tipo de comportamiento que tendrá el formulario. El 1 es para Lista de estudiante, el 2 para lista de Representantes y 0
        ''' para lista de estudiantes</param>
        Public Sub New(opcion As Integer)
            InitializeComponent()
            If opcion = 1 Then
                btnEditar.Visible = True
                btnAgregar.Visible = False
                btnExit.Visible = False
            ElseIf opcion = 2 Then
                btnEditar.Visible = False
                btnEditar2.Visible = True
            Else
                btnEditar.Visible = False
                btnAgregar.Visible = True
            End If
            _op = opcion
        End Sub

        Private Sub Simpp302A_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Funciona pero se necesita reiniciar la aplicación, tenerlo presente, y modificar para que se acepte  usuario y contraseña ajajajaj
            'Dim config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            'Dim connectionStringsSection = DirectCast(config.GetSection("connectionStrings"), ConnectionStringsSection)
            'connectionStringsSection.ConnectionStrings("simpp_maarEntities").ConnectionString = BuildConnectionString("localhost", "prueba")
            'config.Save()
            'ConfigurationManager.RefreshSection("connectionStrings")
            AddRows()
            cmbSearch.SelectedIndex = 0
        End Sub

        Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
            Database = New simpp_maarEntities()
            If _op = 2 Then
                NuevoEstudiante.AddRow(Database.representantes.Find(dgvGenerico.CurrentRow.Cells(columnName:="ID").Value))
            Else
                NuevaMatricula.FillTexts(Database.estudiantes.Find(dgvGenerico.CurrentRow.Cells(columnName:="ID").Value))
            End If
            Database.Dispose()
            Close()
        End Sub

        Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
            Close()
        End Sub

        Private Sub Filtro(ByVal opcion As Integer)
            If _op = 2 Then
                If opcion = 0 Then
                    dgvGenerico.DataSource = _listaRepresentantes.Where(Function(o) o.Cedula.Contains(txtBusqueda.Text)).ToList()
                ElseIf opcion = 1 Then
                    dgvGenerico.DataSource = _listaRepresentantes.Where(Function(o) o.Nombre.ToLower().Contains(txtBusqueda.Text.ToLower())).ToList()
                End If
            Else
                If opcion = 0 Then
                    dgvGenerico.DataSource = _listEstudiantes.Where(Function(o) o.Cedula.Contains(txtBusqueda.Text)).ToList()
                ElseIf opcion = 1 Then
                    dgvGenerico.DataSource = _listEstudiantes.Where(Function(o) o.Apellidos.ToLower().Contains(txtBusqueda.Text.ToLower())).ToList()
                End If
            End If
            dgvGenerico.Refresh()
        End Sub

        ''' <summary>
        ''' Agrega un ROW al DataGridView
        ''' </summary>
        Public Sub AddRows()
            dgvGenerico.DataSource = Nothing
            Database = New simpp_maarEntities()
            If _op = 2 Then
                _listaRepresentantes = Database.representantecompletoes.ToList()
                dgvGenerico.DataSource = _listaRepresentantes.ToList()
                GroupBox2.Text = "Lista de representantes"
            Else
                _listEstudiantes = Database.estudiantepersonas.ToList()
                dgvGenerico.DataSource = _listEstudiantes.ToList()
            End If
            With dgvGenerico
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Refresh()
            End With
            Database.Dispose()
        End Sub



        Private Function BuildConnectionString(DataSource As [String], Database As [String]) As [String]
            ' Build the connection string from the provided datasource and database
            Dim connString As [String] = "server=" + DataSource + ";user id=root;password=TeAmoMelisa_1;persistsecurityinfo=True;database=" + Database + ";"

            ' Build the MetaData... feel free to copy/paste it from the connection string in the config file.
            Dim esb As New EntityConnectionStringBuilder()
            esb.Metadata = "res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl"
            esb.Provider = "MySql.Data.MySqlClient"
            esb.ProviderConnectionString = connString

            ' Generate the full string and return it
            Return esb.ToString()
        End Function

        Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
            Filtro(cmbSearch.SelectedIndex)
        End Sub

        Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
            Database = New simpp_maarEntities()
            NuevoEstudiante = New Simpp301(1)
            NuevoEstudiante.Ayuda(Database.estudiantes.Find(dgvGenerico.CurrentRow.Cells(columnName:="ID").Value))
            NuevoEstudiante.ShowDialog()
            NuevoEstudiante.Dispose()
            Database.Dispose()
        End Sub

        Public Sub Reload()
            AddRows()
        End Sub

        Public Sub Representantes()
            dgvGenerico.DataSource = Nothing
            Database = New simpp_maarEntities()
            _listEstudiantes = Database.estudiantepersonas.ToList()
            dgvGenerico.DataSource = _listEstudiantes.ToList()
            With dgvGenerico
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Refresh()
            End With
            Database.Dispose()
        End Sub

        Private Sub btnEditar2_Click(sender As Object, e As EventArgs) Handles btnEditar2.Click
            Dim id As Integer = dgvGenerico.CurrentRow.Cells(columnName:="ID").Value
            NuevoRepresentante = New Simpp301A(id)
            NuevoRepresentante.ShowDialog()
            NuevoRepresentante.Dispose()
            Reload()
        End Sub
    End Class
End Namespace