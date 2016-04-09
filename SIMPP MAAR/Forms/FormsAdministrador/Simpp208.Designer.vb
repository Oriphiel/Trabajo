Namespace Forms.FormsAdministrador
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Simpp208
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
            Me.btnCancelar = New System.Windows.Forms.Button()
            Me.btnAñadir = New System.Windows.Forms.Button()
            Me.cmbParalelos = New System.Windows.Forms.ComboBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.nupCantidad = New System.Windows.Forms.NumericUpDown()
            Me.btnActualizar = New System.Windows.Forms.Button()
            Me.Panel1.SuspendLayout()
            CType(Me.nupCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.btnActualizar)
            Me.Panel1.Controls.Add(Me.nupCantidad)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Controls.Add(Me.btnCancelar)
            Me.Panel1.Controls.Add(Me.btnAñadir)
            Me.Panel1.Controls.Add(Me.cmbParalelos)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(514, 162)
            Me.Panel1.TabIndex = 10
            '
            'btnCancelar
            '
            Me.btnCancelar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Location = New System.Drawing.Point(281, 97)
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(134, 41)
            Me.btnCancelar.TabIndex = 4
            Me.btnCancelar.Text = "Cancelar"
            Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnCancelar.UseVisualStyleBackColor = False
            '
            'btnAñadir
            '
            Me.btnAñadir.BackColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAñadir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAñadir.Image = Global.SIMPP_MAAR.My.Resources.Resources.add
            Me.btnAñadir.Location = New System.Drawing.Point(97, 97)
            Me.btnAñadir.Name = "btnAñadir"
            Me.btnAñadir.Size = New System.Drawing.Size(134, 41)
            Me.btnAñadir.TabIndex = 2
            Me.btnAñadir.Text = "Añadir"
            Me.btnAñadir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnAñadir.UseVisualStyleBackColor = False
            '
            'cmbParalelos
            '
            Me.cmbParalelos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbParalelos.FormattingEnabled = True
            Me.cmbParalelos.Location = New System.Drawing.Point(155, 11)
            Me.cmbParalelos.Name = "cmbParalelos"
            Me.cmbParalelos.Size = New System.Drawing.Size(211, 28)
            Me.cmbParalelos.TabIndex = 0
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(93, 54)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(180, 20)
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "Cantidad de Alumnos"
            '
            'nupCantidad
            '
            Me.nupCantidad.Location = New System.Drawing.Point(281, 52)
            Me.nupCantidad.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
            Me.nupCantidad.Name = "nupCantidad"
            Me.nupCantidad.Size = New System.Drawing.Size(134, 26)
            Me.nupCantidad.TabIndex = 1
            Me.nupCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'btnActualizar
            '
            Me.btnActualizar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.btnActualizar.Enabled = False
            Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnActualizar.Image = Global.SIMPP_MAAR.My.Resources.Resources.refresh
            Me.btnActualizar.Location = New System.Drawing.Point(97, 97)
            Me.btnActualizar.Name = "btnActualizar"
            Me.btnActualizar.Size = New System.Drawing.Size(134, 41)
            Me.btnActualizar.TabIndex = 3
            Me.btnActualizar.Text = "Actualizar"
            Me.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnActualizar.UseVisualStyleBackColor = False
            Me.btnActualizar.Visible = False
            '
            'Simpp208
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(514, 162)
            Me.Controls.Add(Me.Panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "Simpp208"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Simpp208"
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            CType(Me.nupCantidad, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents cmbParalelos As System.Windows.Forms.ComboBox
        Friend WithEvents btnAñadir As System.Windows.Forms.Button
        Friend WithEvents btnCancelar As System.Windows.Forms.Button
        Friend WithEvents nupCantidad As System.Windows.Forms.NumericUpDown
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents btnActualizar As System.Windows.Forms.Button
    End Class
End Namespace