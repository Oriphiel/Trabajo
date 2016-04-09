Imports System.Data.Entity.Migrations
Imports SIMPP_MAAR.My.Resources

Namespace Forms.FormsAdministrador

    Public Class Simpp208
        Dim _idCurso As Integer
        Dim _op As Integer
        Dim _cursoParalelo As curso_paralelo

        Public Sub New(op As Integer, id As Integer, cursoParalelo As curso_paralelo)
            ' Llamada necesaria para el diseñador.
            InitializeComponent()
            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            _idCurso = id
            _op = op
            If op = 1 Then
                _cursoParalelo = cursoParalelo
            End If
        End Sub

        Private Sub Simpp208_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Database = New simpp_maarEntities()
            cmbParalelos.DataSource = Database.paralelos.ToList()
            cmbParalelos.ValueMember = "idParalelos"
            cmbParalelos.DisplayMember = "Detalle"
            If _op = 1 Then
                btnActualizar.Visible = True
                btnActualizar.Enabled = True
                btnAñadir.Enabled = False
                cmbParalelos.SelectedValue = _cursoParalelo.idParalelo
                cmbParalelos.Enabled = False
                nupCantidad.Value = _cursoParalelo.capacidad
            End If
            Database.Dispose()
        End Sub

        Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
            Try
                Database = New simpp_maarEntities()
                Dim idParalelo As Integer = cmbParalelos.SelectedValue
                Dim op = Database.curso_paralelo.Where(Function(o) o.idParalelo = idParalelo And o.idCurso = _idCurso).Count
                If op = 0 Then
                    Dim cp = New curso_paralelo
                    cp.idCurso = _idCurso
                    cp.idParalelo = cmbParalelos.SelectedValue
                    cp.idUsuario = User
                    cp.Estado = "A"
                    cp.capacidad = Convert.ToInt32(nupCantidad.Value.ToString())
                    Console.WriteLine(cp.capacidad)
                    ListaCursos.AddList(cp)
                    Close()
                Else
                    MessageBox.Show("El paralelo ya se encuentra en el curso", adver, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
            Close()
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
            Try
                Database = New simpp_maarEntities()
                Dim cp = Database.curso_paralelo.Find(_cursoParalelo.idcurso_paralelo)
                cp.idCurso = _idCurso
                cp.idParalelo = cmbParalelos.SelectedValue
                cp.idUsuario = User
                cp.Estado = "A"
                cp.capacidad = Convert.ToInt32(nupCantidad.Value)
                Database.curso_paralelo.AddOrUpdate(cp)
                Database.SaveChanges()
                Database.Dispose()
                ListaCursos.Refrescar()
                Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Namespace