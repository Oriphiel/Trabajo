Namespace Forms.FormsMatriculacion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Simpp305
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
            Me.lblRepresentante = New System.Windows.Forms.Label()
            Me.lblApellido = New System.Windows.Forms.Label()
            Me.lblNombre = New System.Windows.Forms.Label()
            Me.lblCedula = New System.Windows.Forms.Label()
            Me.lbl4 = New System.Windows.Forms.Label()
            Me.lbl3 = New System.Windows.Forms.Label()
            Me.lbl2 = New System.Windows.Forms.Label()
            Me.lbl1 = New System.Windows.Forms.Label()
            Me.Detalles = New System.Windows.Forms.GroupBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.lblMatricula = New System.Windows.Forms.Label()
            Me.lblFactura = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.btnCalcular = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.Cuotas = New System.Windows.Forms.GroupBox()
            Me.btnPagar = New System.Windows.Forms.Button()
            Me.dgvMatriculasLista = New System.Windows.Forms.DataGridView()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.btnSelect = New System.Windows.Forms.Button()
            Me.dataGridEstudiantes = New System.Windows.Forms.DataGrid()
            Me.Panel1.SuspendLayout()
            Me.Detalles.SuspendLayout()
            Me.Cuotas.SuspendLayout()
            CType(Me.dgvMatriculasLista, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            CType(Me.dataGridEstudiantes, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.lblRepresentante)
            Me.Panel1.Controls.Add(Me.lblApellido)
            Me.Panel1.Controls.Add(Me.lblNombre)
            Me.Panel1.Controls.Add(Me.lblCedula)
            Me.Panel1.Controls.Add(Me.lbl4)
            Me.Panel1.Controls.Add(Me.lbl3)
            Me.Panel1.Controls.Add(Me.lbl2)
            Me.Panel1.Controls.Add(Me.lbl1)
            Me.Panel1.Controls.Add(Me.Detalles)
            Me.Panel1.Controls.Add(Me.Cuotas)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1264, 533)
            Me.Panel1.TabIndex = 5
            '
            'lblRepresentante
            '
            Me.lblRepresentante.AutoSize = True
            Me.lblRepresentante.Location = New System.Drawing.Point(931, 270)
            Me.lblRepresentante.Name = "lblRepresentante"
            Me.lblRepresentante.Size = New System.Drawing.Size(0, 20)
            Me.lblRepresentante.TabIndex = 14
            '
            'lblApellido
            '
            Me.lblApellido.AutoSize = True
            Me.lblApellido.Location = New System.Drawing.Point(931, 230)
            Me.lblApellido.Name = "lblApellido"
            Me.lblApellido.Size = New System.Drawing.Size(0, 20)
            Me.lblApellido.TabIndex = 13
            '
            'lblNombre
            '
            Me.lblNombre.AutoSize = True
            Me.lblNombre.Location = New System.Drawing.Point(931, 190)
            Me.lblNombre.Name = "lblNombre"
            Me.lblNombre.Size = New System.Drawing.Size(0, 20)
            Me.lblNombre.TabIndex = 12
            '
            'lblCedula
            '
            Me.lblCedula.AutoSize = True
            Me.lblCedula.Location = New System.Drawing.Point(931, 150)
            Me.lblCedula.Name = "lblCedula"
            Me.lblCedula.Size = New System.Drawing.Size(0, 20)
            Me.lblCedula.TabIndex = 11
            '
            'lbl4
            '
            Me.lbl4.AutoSize = True
            Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl4.Location = New System.Drawing.Point(785, 270)
            Me.lbl4.Name = "lbl4"
            Me.lbl4.Size = New System.Drawing.Size(129, 20)
            Me.lbl4.TabIndex = 10
            Me.lbl4.Text = "Representante"
            '
            'lbl3
            '
            Me.lbl3.AutoSize = True
            Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl3.Location = New System.Drawing.Point(785, 230)
            Me.lbl3.Name = "lbl3"
            Me.lbl3.Size = New System.Drawing.Size(73, 20)
            Me.lbl3.TabIndex = 9
            Me.lbl3.Text = "Apellido"
            '
            'lbl2
            '
            Me.lbl2.AutoSize = True
            Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl2.Location = New System.Drawing.Point(785, 190)
            Me.lbl2.Name = "lbl2"
            Me.lbl2.Size = New System.Drawing.Size(71, 20)
            Me.lbl2.TabIndex = 8
            Me.lbl2.Text = "Nombre"
            '
            'lbl1
            '
            Me.lbl1.AutoSize = True
            Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl1.Location = New System.Drawing.Point(785, 150)
            Me.lbl1.Name = "lbl1"
            Me.lbl1.Size = New System.Drawing.Size(65, 20)
            Me.lbl1.TabIndex = 7
            Me.lbl1.Text = "Cedula"
            '
            'Detalles
            '
            Me.Detalles.Controls.Add(Me.Label3)
            Me.Detalles.Controls.Add(Me.lblMatricula)
            Me.Detalles.Controls.Add(Me.lblFactura)
            Me.Detalles.Controls.Add(Me.Label2)
            Me.Detalles.Controls.Add(Me.btnCalcular)
            Me.Detalles.Controls.Add(Me.Label1)
            Me.Detalles.Controls.Add(Me.lblTotal)
            Me.Detalles.Location = New System.Drawing.Point(779, 11)
            Me.Detalles.Name = "Detalles"
            Me.Detalles.Size = New System.Drawing.Size(472, 125)
            Me.Detalles.TabIndex = 4
            Me.Detalles.TabStop = False
            Me.Detalles.Text = "Detalles"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(267, 85)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(115, 20)
            Me.Label3.TabIndex = 6
            Me.Label3.Text = "Total a pagar"
            '
            'lblMatricula
            '
            Me.lblMatricula.AutoSize = True
            Me.lblMatricula.Location = New System.Drawing.Point(152, 56)
            Me.lblMatricula.Name = "lblMatricula"
            Me.lblMatricula.Size = New System.Drawing.Size(0, 20)
            Me.lblMatricula.TabIndex = 5
            '
            'lblFactura
            '
            Me.lblFactura.AutoSize = True
            Me.lblFactura.Location = New System.Drawing.Point(152, 25)
            Me.lblFactura.Name = "lblFactura"
            Me.lblFactura.Size = New System.Drawing.Size(57, 20)
            Me.lblFactura.TabIndex = 4
            Me.lblFactura.Text = "Label1"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(6, 56)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(106, 20)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "ID Matricula"
            '
            'btnCalcular
            '
            Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnCalcular.Location = New System.Drawing.Point(6, 79)
            Me.btnCalcular.Name = "btnCalcular"
            Me.btnCalcular.Size = New System.Drawing.Size(113, 33)
            Me.btnCalcular.TabIndex = 1
            Me.btnCalcular.Text = "Calcular total"
            Me.btnCalcular.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(6, 25)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(95, 20)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "ID Factura"
            '
            'lblTotal
            '
            Me.lblTotal.AutoSize = True
            Me.lblTotal.Location = New System.Drawing.Point(410, 85)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(0, 20)
            Me.lblTotal.TabIndex = 0
            '
            'Cuotas
            '
            Me.Cuotas.Controls.Add(Me.btnPagar)
            Me.Cuotas.Controls.Add(Me.dgvMatriculasLista)
            Me.Cuotas.Location = New System.Drawing.Point(11, 293)
            Me.Cuotas.Name = "Cuotas"
            Me.Cuotas.Size = New System.Drawing.Size(1240, 227)
            Me.Cuotas.TabIndex = 3
            Me.Cuotas.TabStop = False
            Me.Cuotas.Text = "Cuotas"
            '
            'btnPagar
            '
            Me.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnPagar.Location = New System.Drawing.Point(1156, 25)
            Me.btnPagar.Name = "btnPagar"
            Me.btnPagar.Size = New System.Drawing.Size(75, 41)
            Me.btnPagar.TabIndex = 1
            Me.btnPagar.Text = "Pagar"
            Me.btnPagar.UseVisualStyleBackColor = True
            '
            'dgvMatriculasLista
            '
            Me.dgvMatriculasLista.AllowUserToAddRows = False
            Me.dgvMatriculasLista.AllowUserToDeleteRows = False
            Me.dgvMatriculasLista.Location = New System.Drawing.Point(6, 25)
            Me.dgvMatriculasLista.Name = "dgvMatriculasLista"
            Me.dgvMatriculasLista.Size = New System.Drawing.Size(1144, 196)
            Me.dgvMatriculasLista.TabIndex = 0
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.btnBuscar)
            Me.GroupBox2.Controls.Add(Me.btnSelect)
            Me.GroupBox2.Controls.Add(Me.dataGridEstudiantes)
            Me.GroupBox2.ForeColor = System.Drawing.Color.Black
            Me.GroupBox2.Location = New System.Drawing.Point(11, 11)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(762, 276)
            Me.GroupBox2.TabIndex = 2
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Lista de Matriculados"
            '
            'btnBuscar
            '
            Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Default
            Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnBuscar.Image = Global.SIMPP_MAAR.My.Resources.Resources.search
            Me.btnBuscar.Location = New System.Drawing.Point(654, 70)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(102, 39)
            Me.btnBuscar.TabIndex = 5
            Me.btnBuscar.Text = "Buscar"
            Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnBuscar.UseVisualStyleBackColor = True
            '
            'btnSelect
            '
            Me.btnSelect.Cursor = System.Windows.Forms.Cursors.Default
            Me.btnSelect.Enabled = False
            Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnSelect.Location = New System.Drawing.Point(654, 25)
            Me.btnSelect.Name = "btnSelect"
            Me.btnSelect.Size = New System.Drawing.Size(102, 39)
            Me.btnSelect.TabIndex = 4
            Me.btnSelect.Text = "Escoger"
            Me.btnSelect.UseVisualStyleBackColor = True
            '
            'dataGridEstudiantes
            '
            Me.dataGridEstudiantes.AlternatingBackColor = System.Drawing.Color.Lavender
            Me.dataGridEstudiantes.BackColor = System.Drawing.Color.WhiteSmoke
            Me.dataGridEstudiantes.BackgroundColor = System.Drawing.Color.LightGray
            Me.dataGridEstudiantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
            Me.dataGridEstudiantes.Size = New System.Drawing.Size(642, 245)
            Me.dataGridEstudiantes.TabIndex = 4
            '
            'Simpp305
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1264, 533)
            Me.Controls.Add(Me.Panel1)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Name = "Simpp305"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Simpp302B"
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.Detalles.ResumeLayout(False)
            Me.Detalles.PerformLayout()
            Me.Cuotas.ResumeLayout(False)
            CType(Me.dgvMatriculasLista, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            CType(Me.dataGridEstudiantes, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents dataGridEstudiantes As System.Windows.Forms.DataGrid
        Friend WithEvents Cuotas As System.Windows.Forms.GroupBox
        Friend WithEvents dgvMatriculasLista As System.Windows.Forms.DataGridView
        Friend WithEvents btnSelect As System.Windows.Forms.Button
        Friend WithEvents Detalles As System.Windows.Forms.GroupBox
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents btnCalcular As System.Windows.Forms.Button
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblMatricula As System.Windows.Forms.Label
        Friend WithEvents lblFactura As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents lblRepresentante As System.Windows.Forms.Label
        Friend WithEvents lblApellido As System.Windows.Forms.Label
        Friend WithEvents lblNombre As System.Windows.Forms.Label
        Friend WithEvents lblCedula As System.Windows.Forms.Label
        Friend WithEvents lbl4 As System.Windows.Forms.Label
        Friend WithEvents lbl3 As System.Windows.Forms.Label
        Friend WithEvents lbl2 As System.Windows.Forms.Label
        Friend WithEvents lbl1 As System.Windows.Forms.Label
        Friend WithEvents btnPagar As System.Windows.Forms.Button
    End Class
End Namespace