Namespace Forms.FormsMatriculacion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class SImpp303
        Inherits System.Windows.Forms.Form

        'Form reemplaza a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Requerido por el Diseñador de Windows Forms
        Private components As System.ComponentModel.IContainer

        'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        'Se puede modificar usando el Diseñador de Windows Forms.  
        'No lo modifique con el editor de código.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.dataGridEstudiantes = New System.Windows.Forms.DataGrid()
            Me.dgvMatriculasLista = New System.Windows.Forms.DataGridView()
            Me.btnEditar = New System.Windows.Forms.Button()
            Me.btnExit = New System.Windows.Forms.Button()
            Me.gbPanel = New System.Windows.Forms.GroupBox()
            Me.cmbParalelo = New System.Windows.Forms.ComboBox()
            Me.cmbCurso = New System.Windows.Forms.ComboBox()
            Me.cmbPeriodo = New System.Windows.Forms.ComboBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Panel1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.dataGridEstudiantes, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvMatriculasLista, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gbPanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.gbPanel)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1264, 533)
            Me.Panel1.TabIndex = 4
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.dataGridEstudiantes)
            Me.GroupBox2.Controls.Add(Me.dgvMatriculasLista)
            Me.GroupBox2.Controls.Add(Me.btnEditar)
            Me.GroupBox2.Controls.Add(Me.btnExit)
            Me.GroupBox2.ForeColor = System.Drawing.Color.Black
            Me.GroupBox2.Location = New System.Drawing.Point(11, 81)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(1240, 439)
            Me.GroupBox2.TabIndex = 2
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Lista de Matriculados"
            '
            'dataGridEstudiantes
            '
            Me.dataGridEstudiantes.AlternatingBackColor = System.Drawing.Color.Lavender
            Me.dataGridEstudiantes.BackColor = System.Drawing.Color.WhiteSmoke
            Me.dataGridEstudiantes.BackgroundColor = System.Drawing.Color.LightGray
            Me.dataGridEstudiantes.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dataGridEstudiantes.CaptionBackColor = System.Drawing.Color.LightSteelBlue
            Me.dataGridEstudiantes.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dataGridEstudiantes.CaptionForeColor = System.Drawing.Color.MidnightBlue
            Me.dataGridEstudiantes.DataMember = ""
            Me.dataGridEstudiantes.FlatMode = True
            Me.dataGridEstudiantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dataGridEstudiantes.ForeColor = System.Drawing.Color.MidnightBlue
            Me.dataGridEstudiantes.GridLineColor = System.Drawing.Color.Gainsboro
            Me.dataGridEstudiantes.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
            Me.dataGridEstudiantes.HeaderBackColor = System.Drawing.Color.MidnightBlue
            Me.dataGridEstudiantes.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dataGridEstudiantes.HeaderForeColor = System.Drawing.Color.WhiteSmoke
            Me.dataGridEstudiantes.LinkColor = System.Drawing.Color.Teal
            Me.dataGridEstudiantes.Location = New System.Drawing.Point(6, 25)
            Me.dataGridEstudiantes.Name = "dataGridEstudiantes"
            Me.dataGridEstudiantes.ParentRowsBackColor = System.Drawing.Color.Gainsboro
            Me.dataGridEstudiantes.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
            Me.dataGridEstudiantes.PreferredColumnWidth = 100
            Me.dataGridEstudiantes.ReadOnly = True
            Me.dataGridEstudiantes.SelectionBackColor = System.Drawing.Color.CadetBlue
            Me.dataGridEstudiantes.SelectionForeColor = System.Drawing.Color.WhiteSmoke
            Me.dataGridEstudiantes.Size = New System.Drawing.Size(1106, 408)
            Me.dataGridEstudiantes.TabIndex = 4
            '
            'dgvMatriculasLista
            '
            Me.dgvMatriculasLista.AllowUserToAddRows = False
            Me.dgvMatriculasLista.AllowUserToDeleteRows = False
            Me.dgvMatriculasLista.AllowUserToOrderColumns = True
            Me.dgvMatriculasLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvMatriculasLista.Location = New System.Drawing.Point(6, 25)
            Me.dgvMatriculasLista.Name = "dgvMatriculasLista"
            Me.dgvMatriculasLista.Size = New System.Drawing.Size(1106, 408)
            Me.dgvMatriculasLista.TabIndex = 3
            '
            'btnEditar
            '
            Me.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.btnEditar.Enabled = False
            Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditar.ForeColor = System.Drawing.Color.Black
            Me.btnEditar.Image = Global.SIMPP_MAAR.My.Resources.Resources.edit
            Me.btnEditar.Location = New System.Drawing.Point(1118, 25)
            Me.btnEditar.Name = "btnEditar"
            Me.btnEditar.Size = New System.Drawing.Size(116, 41)
            Me.btnEditar.TabIndex = 1
            Me.btnEditar.Text = "Editar"
            Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnEditar.UseVisualStyleBackColor = False
            Me.btnEditar.Visible = False
            '
            'btnExit
            '
            Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnExit.ForeColor = System.Drawing.Color.Black
            Me.btnExit.Location = New System.Drawing.Point(1118, 72)
            Me.btnExit.Name = "btnExit"
            Me.btnExit.Size = New System.Drawing.Size(116, 42)
            Me.btnExit.TabIndex = 2
            Me.btnExit.Text = "Salir"
            Me.btnExit.UseVisualStyleBackColor = True
            '
            'gbPanel
            '
            Me.gbPanel.Controls.Add(Me.cmbParalelo)
            Me.gbPanel.Controls.Add(Me.cmbCurso)
            Me.gbPanel.Controls.Add(Me.cmbPeriodo)
            Me.gbPanel.Controls.Add(Me.Label3)
            Me.gbPanel.Controls.Add(Me.Label2)
            Me.gbPanel.Controls.Add(Me.Label1)
            Me.gbPanel.Location = New System.Drawing.Point(11, 11)
            Me.gbPanel.Name = "gbPanel"
            Me.gbPanel.Size = New System.Drawing.Size(1240, 64)
            Me.gbPanel.TabIndex = 0
            Me.gbPanel.TabStop = False
            '
            'cmbParalelo
            '
            Me.cmbParalelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbParalelo.Enabled = False
            Me.cmbParalelo.FormattingEnabled = True
            Me.cmbParalelo.Location = New System.Drawing.Point(1035, 19)
            Me.cmbParalelo.Name = "cmbParalelo"
            Me.cmbParalelo.Size = New System.Drawing.Size(197, 28)
            Me.cmbParalelo.TabIndex = 19
            '
            'cmbCurso
            '
            Me.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCurso.FormattingEnabled = True
            Me.cmbCurso.Location = New System.Drawing.Point(456, 19)
            Me.cmbCurso.Name = "cmbCurso"
            Me.cmbCurso.Size = New System.Drawing.Size(464, 28)
            Me.cmbCurso.TabIndex = 18
            '
            'cmbPeriodo
            '
            Me.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPeriodo.FormattingEnabled = True
            Me.cmbPeriodo.Location = New System.Drawing.Point(87, 19)
            Me.cmbPeriodo.Name = "cmbPeriodo"
            Me.cmbPeriodo.Size = New System.Drawing.Size(257, 28)
            Me.cmbPeriodo.TabIndex = 17
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(950, 22)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(79, 20)
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "Paralelo:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(389, 22)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(61, 20)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "Curso:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(6, 22)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(75, 20)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Periodo:"
            '
            'SImpp303
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1264, 533)
            Me.Controls.Add(Me.Panel1)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Name = "SImpp303"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SImpp303"
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            CType(Me.dataGridEstudiantes, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvMatriculasLista, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gbPanel.ResumeLayout(False)
            Me.gbPanel.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents gbPanel As System.Windows.Forms.GroupBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents cmbParalelo As System.Windows.Forms.ComboBox
        Friend WithEvents cmbCurso As System.Windows.Forms.ComboBox
        Friend WithEvents cmbPeriodo As System.Windows.Forms.ComboBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents btnEditar As System.Windows.Forms.Button
        Friend WithEvents btnExit As System.Windows.Forms.Button
        Friend WithEvents dgvMatriculasLista As System.Windows.Forms.DataGridView
        Friend WithEvents dataGridEstudiantes As System.Windows.Forms.DataGrid
    End Class
End Namespace