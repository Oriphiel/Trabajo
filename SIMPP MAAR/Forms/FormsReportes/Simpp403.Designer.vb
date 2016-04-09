Namespace Forms.FormsReportes
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Simpp403
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
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.btnInforme = New System.Windows.Forms.Button()
            Me.gbPanel = New System.Windows.Forms.GroupBox()
            Me.chbRubros = New System.Windows.Forms.CheckBox()
            Me.cmbRubros = New System.Windows.Forms.ComboBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.chbTodos = New System.Windows.Forms.CheckBox()
            Me.cmbParalelo = New System.Windows.Forms.ComboBox()
            Me.cmbCurso = New System.Windows.Forms.ComboBox()
            Me.cmbPeriodo = New System.Windows.Forms.ComboBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Panel1.SuspendLayout()
            Me.gbPanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.btnSalir)
            Me.Panel1.Controls.Add(Me.btnInforme)
            Me.Panel1.Controls.Add(Me.gbPanel)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(599, 249)
            Me.Panel1.TabIndex = 5
            '
            'btnSalir
            '
            Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSalir.Location = New System.Drawing.Point(325, 200)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(149, 44)
            Me.btnSalir.TabIndex = 7
            Me.btnSalir.Text = "Salir"
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'btnInforme
            '
            Me.btnInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnInforme.Location = New System.Drawing.Point(122, 200)
            Me.btnInforme.Name = "btnInforme"
            Me.btnInforme.Size = New System.Drawing.Size(149, 44)
            Me.btnInforme.TabIndex = 6
            Me.btnInforme.Text = "Informe"
            Me.btnInforme.UseVisualStyleBackColor = True
            '
            'gbPanel
            '
            Me.gbPanel.Controls.Add(Me.chbRubros)
            Me.gbPanel.Controls.Add(Me.cmbRubros)
            Me.gbPanel.Controls.Add(Me.Label4)
            Me.gbPanel.Controls.Add(Me.chbTodos)
            Me.gbPanel.Controls.Add(Me.cmbParalelo)
            Me.gbPanel.Controls.Add(Me.cmbCurso)
            Me.gbPanel.Controls.Add(Me.cmbPeriodo)
            Me.gbPanel.Controls.Add(Me.Label3)
            Me.gbPanel.Controls.Add(Me.Label2)
            Me.gbPanel.Controls.Add(Me.Label1)
            Me.gbPanel.Location = New System.Drawing.Point(11, 3)
            Me.gbPanel.Name = "gbPanel"
            Me.gbPanel.Size = New System.Drawing.Size(564, 191)
            Me.gbPanel.TabIndex = 5
            Me.gbPanel.TabStop = False
            '
            'chbRubros
            '
            Me.chbRubros.AutoSize = True
            Me.chbRubros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chbRubros.Location = New System.Drawing.Point(181, 155)
            Me.chbRubros.Name = "chbRubros"
            Me.chbRubros.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.chbRubros.Size = New System.Drawing.Size(161, 24)
            Me.chbRubros.TabIndex = 23
            Me.chbRubros.Text = "Todos los rubros"
            Me.chbRubros.UseVisualStyleBackColor = True
            '
            'cmbRubros
            '
            Me.cmbRubros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbRubros.FormattingEnabled = True
            Me.cmbRubros.Location = New System.Drawing.Point(385, 109)
            Me.cmbRubros.Name = "cmbRubros"
            Me.cmbRubros.Size = New System.Drawing.Size(173, 28)
            Me.cmbRubros.TabIndex = 22
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(266, 112)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(120, 20)
            Me.Label4.TabIndex = 21
            Me.Label4.Text = "Tipo de rubro:"
            '
            'chbTodos
            '
            Me.chbTodos.AutoSize = True
            Me.chbTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chbTodos.Location = New System.Drawing.Point(6, 155)
            Me.chbTodos.Name = "chbTodos"
            Me.chbTodos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.chbTodos.Size = New System.Drawing.Size(163, 24)
            Me.chbTodos.TabIndex = 20
            Me.chbTodos.Text = "Todos los cursos"
            Me.chbTodos.UseVisualStyleBackColor = True
            '
            'cmbParalelo
            '
            Me.cmbParalelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbParalelo.Enabled = False
            Me.cmbParalelo.FormattingEnabled = True
            Me.cmbParalelo.Location = New System.Drawing.Point(87, 109)
            Me.cmbParalelo.Name = "cmbParalelo"
            Me.cmbParalelo.Size = New System.Drawing.Size(173, 28)
            Me.cmbParalelo.TabIndex = 19
            '
            'cmbCurso
            '
            Me.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCurso.FormattingEnabled = True
            Me.cmbCurso.Location = New System.Drawing.Point(87, 64)
            Me.cmbCurso.Name = "cmbCurso"
            Me.cmbCurso.Size = New System.Drawing.Size(471, 28)
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
            Me.Label3.Location = New System.Drawing.Point(6, 112)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(79, 20)
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "Paralelo:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(6, 67)
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
            'Simpp403
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(599, 249)
            Me.Controls.Add(Me.Panel1)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Name = "Simpp403"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Simpp403"
            Me.Panel1.ResumeLayout(False)
            Me.gbPanel.ResumeLayout(False)
            Me.gbPanel.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnInforme As System.Windows.Forms.Button
        Friend WithEvents gbPanel As System.Windows.Forms.GroupBox
        Friend WithEvents cmbRubros As System.Windows.Forms.ComboBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents chbTodos As System.Windows.Forms.CheckBox
        Friend WithEvents cmbParalelo As System.Windows.Forms.ComboBox
        Friend WithEvents cmbCurso As System.Windows.Forms.ComboBox
        Friend WithEvents cmbPeriodo As System.Windows.Forms.ComboBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents chbRubros As System.Windows.Forms.CheckBox
    End Class
End Namespace