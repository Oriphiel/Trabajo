Namespace Forms.FormsAdministrador
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Simpp201
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnActualizar = New System.Windows.Forms.Button()
            Me.btnCancelar = New System.Windows.Forms.Button()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.txtfiltro = New System.Windows.Forms.TextBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.cmbEstado = New System.Windows.Forms.ComboBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.btnListaPersonas = New System.Windows.Forms.Button()
            Me.lblIDUsuario = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.cmbPerfil = New System.Windows.Forms.ComboBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.lblarea = New System.Windows.Forms.Label()
            Me.txtnombres = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtusuario = New System.Windows.Forms.TextBox()
            Me.txtclave = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.btnLimpiar = New System.Windows.Forms.Button()
            Me.btnmodificar = New System.Windows.Forms.Button()
            Me.btnDesactivar = New System.Windows.Forms.Button()
            Me.btngrabar = New System.Windows.Forms.Button()
            Me.btnnuevo = New System.Windows.Forms.Button()
            Me.Panel1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.btnActualizar)
            Me.Panel1.Controls.Add(Me.btnCancelar)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.Label5)
            Me.Panel1.Controls.Add(Me.btnLimpiar)
            Me.Panel1.Controls.Add(Me.btnmodificar)
            Me.Panel1.Controls.Add(Me.btnDesactivar)
            Me.Panel1.Controls.Add(Me.btngrabar)
            Me.Panel1.Controls.Add(Me.btnnuevo)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1264, 533)
            Me.Panel1.TabIndex = 5
            '
            'btnActualizar
            '
            Me.btnActualizar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnActualizar.Image = Global.SIMPP_MAAR.My.Resources.Resources.save
            Me.btnActualizar.Location = New System.Drawing.Point(1107, 81)
            Me.btnActualizar.Name = "btnActualizar"
            Me.btnActualizar.Size = New System.Drawing.Size(134, 41)
            Me.btnActualizar.TabIndex = 126
            Me.btnActualizar.Text = "j"
            Me.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnActualizar.UseVisualStyleBackColor = False
            Me.btnActualizar.Visible = False
            '
            'btnCancelar
            '
            Me.btnCancelar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Location = New System.Drawing.Point(1107, 249)
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(134, 41)
            Me.btnCancelar.TabIndex = 129
            Me.btnCancelar.Text = "Cancelar"
            Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnCancelar.UseVisualStyleBackColor = False
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.Label6)
            Me.GroupBox2.Controls.Add(Me.dgvUsuarios)
            Me.GroupBox2.Controls.Add(Me.Label9)
            Me.GroupBox2.Controls.Add(Me.txtfiltro)
            Me.GroupBox2.Location = New System.Drawing.Point(480, 11)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(598, 509)
            Me.GroupBox2.TabIndex = 148
            Me.GroupBox2.TabStop = False
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(226, -1)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(146, 20)
            Me.Label6.TabIndex = 147
            Me.Label6.Text = "Lista de usuarios"
            '
            'dgvUsuarios
            '
            Me.dgvUsuarios.AllowUserToAddRows = False
            Me.dgvUsuarios.AllowUserToDeleteRows = False
            Me.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
            Me.dgvUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvUsuarios.Location = New System.Drawing.Point(6, 54)
            Me.dgvUsuarios.Name = "dgvUsuarios"
            Me.dgvUsuarios.ReadOnly = True
            Me.dgvUsuarios.Size = New System.Drawing.Size(582, 440)
            Me.dgvUsuarios.TabIndex = 146
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(6, 25)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(138, 20)
            Me.Label9.TabIndex = 141
            Me.Label9.Text = "Filtrar por nombre:"
            '
            'txtfiltro
            '
            Me.txtfiltro.Location = New System.Drawing.Point(150, 22)
            Me.txtfiltro.Name = "txtfiltro"
            Me.txtfiltro.Size = New System.Drawing.Size(336, 26)
            Me.txtfiltro.TabIndex = 139
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.cmbEstado)
            Me.GroupBox1.Controls.Add(Me.Label7)
            Me.GroupBox1.Controls.Add(Me.btnListaPersonas)
            Me.GroupBox1.Controls.Add(Me.lblIDUsuario)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.cmbPerfil)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.lblarea)
            Me.GroupBox1.Controls.Add(Me.txtnombres)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.txtusuario)
            Me.GroupBox1.Controls.Add(Me.txtclave)
            Me.GroupBox1.Controls.Add(Me.Label8)
            Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(463, 293)
            Me.GroupBox1.TabIndex = 147
            Me.GroupBox1.TabStop = False
            '
            'cmbEstado
            '
            Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbEstado.Enabled = False
            Me.cmbEstado.FormattingEnabled = True
            Me.cmbEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
            Me.cmbEstado.Location = New System.Drawing.Point(128, 251)
            Me.cmbEstado.Name = "cmbEstado"
            Me.cmbEstado.Size = New System.Drawing.Size(144, 28)
            Me.cmbEstado.TabIndex = 6
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(6, 256)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(66, 20)
            Me.Label7.TabIndex = 152
            Me.Label7.Text = "Estado"
            '
            'btnListaPersonas
            '
            Me.btnListaPersonas.Enabled = False
            Me.btnListaPersonas.FlatAppearance.BorderSize = 0
            Me.btnListaPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnListaPersonas.Image = Global.SIMPP_MAAR.My.Resources.Resources.search
            Me.btnListaPersonas.Location = New System.Drawing.Point(423, 68)
            Me.btnListaPersonas.Name = "btnListaPersonas"
            Me.btnListaPersonas.Size = New System.Drawing.Size(29, 26)
            Me.btnListaPersonas.TabIndex = 2
            Me.btnListaPersonas.UseVisualStyleBackColor = True
            '
            'lblIDUsuario
            '
            Me.lblIDUsuario.AutoSize = True
            Me.lblIDUsuario.Location = New System.Drawing.Point(124, 31)
            Me.lblIDUsuario.Name = "lblIDUsuario"
            Me.lblIDUsuario.Size = New System.Drawing.Size(0, 20)
            Me.lblIDUsuario.TabIndex = 147
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(171, -1)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(121, 20)
            Me.Label3.TabIndex = 146
            Me.Label3.Text = "Datos usuario"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(6, 31)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(95, 20)
            Me.Label1.TabIndex = 129
            Me.Label1.Text = "ID Usuario"
            '
            'cmbPerfil
            '
            Me.cmbPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPerfil.Enabled = False
            Me.cmbPerfil.FormattingEnabled = True
            Me.cmbPerfil.Items.AddRange(New Object() {"Secretaria", "Colecturia", "Administrador"})
            Me.cmbPerfil.Location = New System.Drawing.Point(128, 206)
            Me.cmbPerfil.Name = "cmbPerfil"
            Me.cmbPerfil.Size = New System.Drawing.Size(144, 28)
            Me.cmbPerfil.TabIndex = 5
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(6, 71)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(80, 20)
            Me.Label2.TabIndex = 131
            Me.Label2.Text = "Nombres"
            '
            'lblarea
            '
            Me.lblarea.AutoSize = True
            Me.lblarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblarea.Location = New System.Drawing.Point(6, 211)
            Me.lblarea.Name = "lblarea"
            Me.lblarea.Size = New System.Drawing.Size(50, 20)
            Me.lblarea.TabIndex = 144
            Me.lblarea.Text = "Perfil"
            '
            'txtnombres
            '
            Me.txtnombres.Enabled = False
            Me.txtnombres.Location = New System.Drawing.Point(128, 68)
            Me.txtnombres.Name = "txtnombres"
            Me.txtnombres.Size = New System.Drawing.Size(289, 26)
            Me.txtnombres.TabIndex = 1
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(6, 117)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(71, 20)
            Me.Label4.TabIndex = 133
            Me.Label4.Text = "Usuario"
            '
            'txtusuario
            '
            Me.txtusuario.Enabled = False
            Me.txtusuario.Location = New System.Drawing.Point(128, 114)
            Me.txtusuario.Name = "txtusuario"
            Me.txtusuario.Size = New System.Drawing.Size(289, 26)
            Me.txtusuario.TabIndex = 3
            '
            'txtclave
            '
            Me.txtclave.Enabled = False
            Me.txtclave.Location = New System.Drawing.Point(128, 160)
            Me.txtclave.Name = "txtclave"
            Me.txtclave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtclave.Size = New System.Drawing.Size(289, 26)
            Me.txtclave.TabIndex = 4
            Me.txtclave.UseSystemPasswordChar = True
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(6, 163)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(53, 20)
            Me.Label8.TabIndex = 138
            Me.Label8.Text = "Clave"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(780, 397)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(0, 20)
            Me.Label5.TabIndex = 135
            '
            'btnLimpiar
            '
            Me.btnLimpiar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnLimpiar.Image = Global.SIMPP_MAAR.My.Resources.Resources.refresh
            Me.btnLimpiar.Location = New System.Drawing.Point(1107, 136)
            Me.btnLimpiar.Name = "btnLimpiar"
            Me.btnLimpiar.Size = New System.Drawing.Size(134, 41)
            Me.btnLimpiar.TabIndex = 127
            Me.btnLimpiar.Text = "Limpiar"
            Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnLimpiar.UseVisualStyleBackColor = False
            '
            'btnmodificar
            '
            Me.btnmodificar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnmodificar.Image = Global.SIMPP_MAAR.My.Resources.Resources.edit
            Me.btnmodificar.Location = New System.Drawing.Point(1107, 191)
            Me.btnmodificar.Name = "btnmodificar"
            Me.btnmodificar.Size = New System.Drawing.Size(134, 41)
            Me.btnmodificar.TabIndex = 128
            Me.btnmodificar.Text = "Modificar"
            Me.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnmodificar.UseVisualStyleBackColor = False
            '
            'btnDesactivar
            '
            Me.btnDesactivar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.btnDesactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDesactivar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnDesactivar.Location = New System.Drawing.Point(1107, 309)
            Me.btnDesactivar.Name = "btnDesactivar"
            Me.btnDesactivar.Size = New System.Drawing.Size(134, 41)
            Me.btnDesactivar.TabIndex = 130
            Me.btnDesactivar.Text = "Desactivar"
            Me.btnDesactivar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnDesactivar.UseVisualStyleBackColor = False
            '
            'btngrabar
            '
            Me.btngrabar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.btngrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btngrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btngrabar.Image = Global.SIMPP_MAAR.My.Resources.Resources.save
            Me.btngrabar.Location = New System.Drawing.Point(1107, 81)
            Me.btngrabar.Name = "btngrabar"
            Me.btngrabar.Size = New System.Drawing.Size(134, 41)
            Me.btngrabar.TabIndex = 125
            Me.btngrabar.Text = "Grabar"
            Me.btngrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btngrabar.UseVisualStyleBackColor = False
            '
            'btnnuevo
            '
            Me.btnnuevo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnnuevo.Image = Global.SIMPP_MAAR.My.Resources.Resources.add
            Me.btnnuevo.Location = New System.Drawing.Point(1107, 26)
            Me.btnnuevo.Name = "btnnuevo"
            Me.btnnuevo.Size = New System.Drawing.Size(134, 41)
            Me.btnnuevo.TabIndex = 124
            Me.btnnuevo.Text = "Nuevo"
            Me.btnnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnnuevo.UseVisualStyleBackColor = False
            '
            'Simpp201
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1264, 533)
            Me.Controls.Add(Me.Panel1)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Name = "Simpp201"
            Me.Text = "Simpp201"
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents dgvUsuarios As System.Windows.Forms.DataGridView
        Friend WithEvents cmbPerfil As System.Windows.Forms.ComboBox
        Friend WithEvents lblarea As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents txtfiltro As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents txtclave As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtusuario As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtnombres As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents btnLimpiar As System.Windows.Forms.Button
        Friend WithEvents btnmodificar As System.Windows.Forms.Button
        Friend WithEvents btnDesactivar As System.Windows.Forms.Button
        Friend WithEvents btngrabar As System.Windows.Forms.Button
        Friend WithEvents btnnuevo As System.Windows.Forms.Button
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents lblIDUsuario As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents btnCancelar As System.Windows.Forms.Button
        Friend WithEvents btnActualizar As System.Windows.Forms.Button
        Friend WithEvents btnListaPersonas As System.Windows.Forms.Button
        Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
    End Class
End Namespace