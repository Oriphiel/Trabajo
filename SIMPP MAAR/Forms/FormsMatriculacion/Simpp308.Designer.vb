Namespace Forms.FormsMatriculacion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Simpp308
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
            Me.btnActivar = New System.Windows.Forms.Button()
            Me.dgvGenerico = New System.Windows.Forms.DataGridView()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtBusqueda = New System.Windows.Forms.TextBox()
            Me.cmbSearch = New System.Windows.Forms.ComboBox()
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
            Me.Panel1.Size = New System.Drawing.Size(766, 528)
            Me.Panel1.TabIndex = 6
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.btnActivar)
            Me.GroupBox2.Controls.Add(Me.dgvGenerico)
            Me.GroupBox2.ForeColor = System.Drawing.Color.Black
            Me.GroupBox2.Location = New System.Drawing.Point(11, 69)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(745, 451)
            Me.GroupBox2.TabIndex = 1
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Lista de estudiantes"
            '
            'btnActivar
            '
            Me.btnActivar.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.btnActivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnActivar.ForeColor = System.Drawing.Color.Black
            Me.btnActivar.Image = Global.SIMPP_MAAR.My.Resources.Resources.edit
            Me.btnActivar.Location = New System.Drawing.Point(618, 25)
            Me.btnActivar.Name = "btnActivar"
            Me.btnActivar.Size = New System.Drawing.Size(116, 41)
            Me.btnActivar.TabIndex = 5
            Me.btnActivar.Text = "Activar"
            Me.btnActivar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnActivar.UseVisualStyleBackColor = False
            '
            'dgvGenerico
            '
            Me.dgvGenerico.AllowUserToAddRows = False
            Me.dgvGenerico.AllowUserToDeleteRows = False
            Me.dgvGenerico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvGenerico.Location = New System.Drawing.Point(6, 25)
            Me.dgvGenerico.Name = "dgvGenerico"
            Me.dgvGenerico.Size = New System.Drawing.Size(606, 420)
            Me.dgvGenerico.TabIndex = 0
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.txtBusqueda)
            Me.GroupBox1.Controls.Add(Me.cmbSearch)
            Me.GroupBox1.ForeColor = System.Drawing.Color.Black
            Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(745, 58)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Busqueda"
            '
            'txtBusqueda
            '
            Me.txtBusqueda.Location = New System.Drawing.Point(223, 24)
            Me.txtBusqueda.Name = "txtBusqueda"
            Me.txtBusqueda.Size = New System.Drawing.Size(511, 26)
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
            'Simpp308
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(766, 528)
            Me.Controls.Add(Me.Panel1)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Name = "Simpp308"
            Me.Text = "Simpp308"
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            CType(Me.dgvGenerico, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents btnActivar As System.Windows.Forms.Button
        Friend WithEvents dgvGenerico As System.Windows.Forms.DataGridView
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
        Friend WithEvents cmbSearch As System.Windows.Forms.ComboBox
    End Class
End Namespace