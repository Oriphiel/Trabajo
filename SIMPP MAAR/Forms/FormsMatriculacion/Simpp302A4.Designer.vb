Namespace Forms.FormsMatriculacion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Simpp302A4
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
            Me.btnEditar = New System.Windows.Forms.Button()
            Me.btnExit = New System.Windows.Forms.Button()
            Me.btnAgregar = New System.Windows.Forms.Button()
            Me.dgvGenerico = New System.Windows.Forms.DataGridView()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtBusqueda = New System.Windows.Forms.TextBox()
            Me.cmbSearch = New System.Windows.Forms.ComboBox()
            Me.btnEditar2 = New System.Windows.Forms.Button()
            Me.Panel1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.dgvGenerico, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1264, 533)
            Me.Panel1.TabIndex = 4
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.btnEditar2)
            Me.GroupBox2.Controls.Add(Me.btnEditar)
            Me.GroupBox2.Controls.Add(Me.btnExit)
            Me.GroupBox2.Controls.Add(Me.btnAgregar)
            Me.GroupBox2.Controls.Add(Me.dgvGenerico)
            Me.GroupBox2.ForeColor = System.Drawing.Color.Black
            Me.GroupBox2.Location = New System.Drawing.Point(11, 69)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(1240, 451)
            Me.GroupBox2.TabIndex = 1
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Lista de estudiantes"
            '
            'btnEditar
            '
            Me.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption
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
            'btnAgregar
            '
            Me.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAgregar.ForeColor = System.Drawing.Color.Black
            Me.btnAgregar.Image = Global.SIMPP_MAAR.My.Resources.Resources.add
            Me.btnAgregar.Location = New System.Drawing.Point(1118, 25)
            Me.btnAgregar.Name = "btnAgregar"
            Me.btnAgregar.Size = New System.Drawing.Size(116, 41)
            Me.btnAgregar.TabIndex = 5
            Me.btnAgregar.Text = "Agregar"
            Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnAgregar.UseVisualStyleBackColor = False
            '
            'dgvGenerico
            '
            Me.dgvGenerico.AllowUserToAddRows = False
            Me.dgvGenerico.AllowUserToDeleteRows = False
            Me.dgvGenerico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvGenerico.Location = New System.Drawing.Point(6, 25)
            Me.dgvGenerico.Name = "dgvGenerico"
            Me.dgvGenerico.Size = New System.Drawing.Size(1106, 420)
            Me.dgvGenerico.TabIndex = 0
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.txtBusqueda)
            Me.GroupBox1.Controls.Add(Me.cmbSearch)
            Me.GroupBox1.ForeColor = System.Drawing.Color.Black
            Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1240, 58)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Busqueda"
            '
            'txtBusqueda
            '
            Me.txtBusqueda.Location = New System.Drawing.Point(223, 24)
            Me.txtBusqueda.Name = "txtBusqueda"
            Me.txtBusqueda.Size = New System.Drawing.Size(1011, 26)
            Me.txtBusqueda.TabIndex = 1
            '
            'cmbSearch
            '
            Me.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbSearch.FormattingEnabled = True
            Me.cmbSearch.Items.AddRange(New Object() {"Cedula", "Apellidos"})
            Me.cmbSearch.Location = New System.Drawing.Point(6, 24)
            Me.cmbSearch.Name = "cmbSearch"
            Me.cmbSearch.Size = New System.Drawing.Size(211, 28)
            Me.cmbSearch.TabIndex = 0
            '
            'btnEditar2
            '
            Me.btnEditar2.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.btnEditar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditar2.ForeColor = System.Drawing.Color.Black
            Me.btnEditar2.Image = Global.SIMPP_MAAR.My.Resources.Resources.edit
            Me.btnEditar2.Location = New System.Drawing.Point(1118, 120)
            Me.btnEditar2.Name = "btnEditar2"
            Me.btnEditar2.Size = New System.Drawing.Size(116, 41)
            Me.btnEditar2.TabIndex = 6
            Me.btnEditar2.Text = "Editar"
            Me.btnEditar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnEditar2.UseVisualStyleBackColor = False
            Me.btnEditar2.Visible = False
            '
            'Simpp302A4
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1264, 533)
            Me.Controls.Add(Me.Panel1)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Name = "Simpp302A4"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Simpp302A_4"
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            CType(Me.dgvGenerico, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
        Friend WithEvents cmbSearch As System.Windows.Forms.ComboBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents dgvGenerico As System.Windows.Forms.DataGridView
        Friend WithEvents btnExit As System.Windows.Forms.Button
        Friend WithEvents btnAgregar As System.Windows.Forms.Button
        Friend WithEvents btnEditar As System.Windows.Forms.Button
        Friend WithEvents btnEditar2 As System.Windows.Forms.Button
    End Class
End Namespace