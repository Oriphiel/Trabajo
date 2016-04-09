Namespace Forms.FormsInstitucion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Simpp101
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
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.txtTelefono = New System.Windows.Forms.MaskedTextBox()
            Me.txtWeb = New System.Windows.Forms.TextBox()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.txtEmail = New System.Windows.Forms.TextBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.txtDireccion = New System.Windows.Forms.TextBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtDescripcion = New System.Windows.Forms.RichTextBox()
            Me.cmbTipo = New System.Windows.Forms.ComboBox()
            Me.cmbSeccion = New System.Windows.Forms.ComboBox()
            Me.txtResolucionMinisterial = New System.Windows.Forms.TextBox()
            Me.txtNombreRector = New System.Windows.Forms.TextBox()
            Me.txtNombreInstitucion = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.btnEditar = New System.Windows.Forms.Button()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.txtTelefono)
            Me.GroupBox2.Controls.Add(Me.txtWeb)
            Me.GroupBox2.Controls.Add(Me.Label14)
            Me.GroupBox2.Controls.Add(Me.txtEmail)
            Me.GroupBox2.Controls.Add(Me.Label12)
            Me.GroupBox2.Controls.Add(Me.Label13)
            Me.GroupBox2.Controls.Add(Me.txtDireccion)
            Me.GroupBox2.Controls.Add(Me.Label11)
            Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(641, 81)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(610, 385)
            Me.GroupBox2.TabIndex = 2
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Ubicación/Contactos"
            '
            'txtTelefono
            '
            Me.txtTelefono.BeepOnError = True
            Me.txtTelefono.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
            Me.txtTelefono.Enabled = False
            Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTelefono.HidePromptOnLeave = True
            Me.txtTelefono.Location = New System.Drawing.Point(218, 74)
            Me.txtTelefono.Mask = "0000000000"
            Me.txtTelefono.Name = "txtTelefono"
            Me.txtTelefono.Size = New System.Drawing.Size(372, 26)
            Me.txtTelefono.TabIndex = 5
            '
            'txtWeb
            '
            Me.txtWeb.Enabled = False
            Me.txtWeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtWeb.Location = New System.Drawing.Point(218, 166)
            Me.txtWeb.MaxLength = 100
            Me.txtWeb.Name = "txtWeb"
            Me.txtWeb.Size = New System.Drawing.Size(372, 26)
            Me.txtWeb.TabIndex = 7
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(20, 169)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(115, 20)
            Me.Label14.TabIndex = 19
            Me.Label14.Text = "Página Web: "
            '
            'txtEmail
            '
            Me.txtEmail.Enabled = False
            Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEmail.Location = New System.Drawing.Point(218, 120)
            Me.txtEmail.MaxLength = 45
            Me.txtEmail.Name = "txtEmail"
            Me.txtEmail.Size = New System.Drawing.Size(372, 26)
            Me.txtEmail.TabIndex = 6
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(20, 77)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(89, 20)
            Me.Label12.TabIndex = 15
            Me.Label12.Text = "Teléfono: "
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(20, 123)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(69, 20)
            Me.Label13.TabIndex = 17
            Me.Label13.Text = "E-mail: "
            '
            'txtDireccion
            '
            Me.txtDireccion.Enabled = False
            Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDireccion.Location = New System.Drawing.Point(218, 28)
            Me.txtDireccion.MaxLength = 45
            Me.txtDireccion.Name = "txtDireccion"
            Me.txtDireccion.Size = New System.Drawing.Size(372, 26)
            Me.txtDireccion.TabIndex = 4
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(20, 31)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(94, 20)
            Me.Label11.TabIndex = 13
            Me.Label11.Text = "Dirección: "
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.txtDescripcion)
            Me.GroupBox1.Controls.Add(Me.cmbTipo)
            Me.GroupBox1.Controls.Add(Me.cmbSeccion)
            Me.GroupBox1.Controls.Add(Me.txtResolucionMinisterial)
            Me.GroupBox1.Controls.Add(Me.txtNombreRector)
            Me.GroupBox1.Controls.Add(Me.txtNombreInstitucion)
            Me.GroupBox1.Controls.Add(Me.Label8)
            Me.GroupBox1.Controls.Add(Me.Label7)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(11, 81)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(610, 385)
            Me.GroupBox1.TabIndex = 1
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Datos"
            '
            'txtDescripcion
            '
            Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDescripcion.Enabled = False
            Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDescripcion.Location = New System.Drawing.Point(204, 223)
            Me.txtDescripcion.MaxLength = 200
            Me.txtDescripcion.Name = "txtDescripcion"
            Me.txtDescripcion.Size = New System.Drawing.Size(385, 131)
            Me.txtDescripcion.TabIndex = 5
            Me.txtDescripcion.Text = ""
            '
            'cmbTipo
            '
            Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTipo.Enabled = False
            Me.cmbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbTipo.FormattingEnabled = True
            Me.cmbTipo.Items.AddRange(New Object() {"Fiscal", "Fisco-Misional", "Particular"})
            Me.cmbTipo.Location = New System.Drawing.Point(204, 145)
            Me.cmbTipo.Name = "cmbTipo"
            Me.cmbTipo.Size = New System.Drawing.Size(204, 28)
            Me.cmbTipo.Sorted = True
            Me.cmbTipo.TabIndex = 3
            '
            'cmbSeccion
            '
            Me.cmbSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbSeccion.Enabled = False
            Me.cmbSeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbSeccion.FormattingEnabled = True
            Me.cmbSeccion.Items.AddRange(New Object() {"Matutina", "Vespertina"})
            Me.cmbSeccion.Location = New System.Drawing.Point(204, 106)
            Me.cmbSeccion.Name = "cmbSeccion"
            Me.cmbSeccion.Size = New System.Drawing.Size(204, 28)
            Me.cmbSeccion.Sorted = True
            Me.cmbSeccion.TabIndex = 2
            '
            'txtResolucionMinisterial
            '
            Me.txtResolucionMinisterial.Enabled = False
            Me.txtResolucionMinisterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtResolucionMinisterial.Location = New System.Drawing.Point(204, 184)
            Me.txtResolucionMinisterial.MaxLength = 45
            Me.txtResolucionMinisterial.Name = "txtResolucionMinisterial"
            Me.txtResolucionMinisterial.Size = New System.Drawing.Size(385, 26)
            Me.txtResolucionMinisterial.TabIndex = 4
            '
            'txtNombreRector
            '
            Me.txtNombreRector.Enabled = False
            Me.txtNombreRector.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreRector.Location = New System.Drawing.Point(204, 67)
            Me.txtNombreRector.MaxLength = 80
            Me.txtNombreRector.Name = "txtNombreRector"
            Me.txtNombreRector.Size = New System.Drawing.Size(385, 26)
            Me.txtNombreRector.TabIndex = 1
            '
            'txtNombreInstitucion
            '
            Me.txtNombreInstitucion.Enabled = False
            Me.txtNombreInstitucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreInstitucion.Location = New System.Drawing.Point(204, 28)
            Me.txtNombreInstitucion.MaxLength = 100
            Me.txtNombreInstitucion.Name = "txtNombreInstitucion"
            Me.txtNombreInstitucion.Size = New System.Drawing.Size(385, 26)
            Me.txtNombreInstitucion.TabIndex = 0
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(6, 226)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(178, 20)
            Me.Label8.TabIndex = 5
            Me.Label8.Text = "Otras descripciones: "
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(6, 187)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(150, 20)
            Me.Label7.TabIndex = 4
            Me.Label7.Text = "Resolución Mins: "
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(6, 148)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(53, 20)
            Me.Label6.TabIndex = 3
            Me.Label6.Text = "Tipo: "
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(6, 109)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(83, 20)
            Me.Label5.TabIndex = 2
            Me.Label5.Text = "Sección: "
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(6, 70)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(73, 20)
            Me.Label4.TabIndex = 1
            Me.Label4.Text = "Rector: "
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(6, 31)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(81, 20)
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Nombre: "
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(261, 12)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(725, 57)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Establecimiento Educativo"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.btnGuardar)
            Me.Panel1.Controls.Add(Me.btnEditar)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1264, 533)
            Me.Panel1.TabIndex = 4
            '
            'btnGuardar
            '
            Me.btnGuardar.BackColor = System.Drawing.Color.White
            Me.btnGuardar.BackgroundImage = Global.SIMPP_MAAR.My.Resources.Resources.glossy_button_blank_aqua_rectangle
            Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnGuardar.Enabled = False
            Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Green
            Me.btnGuardar.FlatAppearance.BorderSize = 2
            Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
            Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
            Me.btnGuardar.Image = Global.SIMPP_MAAR.My.Resources.Resources.save
            Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnGuardar.Location = New System.Drawing.Point(661, 472)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(112, 48)
            Me.btnGuardar.TabIndex = 4
            Me.btnGuardar.Text = "Guardar"
            Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnGuardar.UseVisualStyleBackColor = False
            '
            'btnEditar
            '
            Me.btnEditar.BackColor = System.Drawing.Color.White
            Me.btnEditar.BackgroundImage = Global.SIMPP_MAAR.My.Resources.Resources.glossy_button_blank_blue_rectangle
            Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Blue
            Me.btnEditar.FlatAppearance.BorderSize = 2
            Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
            Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
            Me.btnEditar.Image = Global.SIMPP_MAAR.My.Resources.Resources.edit
            Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEditar.Location = New System.Drawing.Point(490, 472)
            Me.btnEditar.Name = "btnEditar"
            Me.btnEditar.Size = New System.Drawing.Size(112, 48)
            Me.btnEditar.TabIndex = 3
            Me.btnEditar.Text = "Editar"
            Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnEditar.UseVisualStyleBackColor = False
            '
            'Simpp101
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1264, 533)
            Me.Controls.Add(Me.Panel1)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Simpp101"
            Me.ShowIcon = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Simpp101"
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtDescripcion As System.Windows.Forms.RichTextBox
        Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
        Friend WithEvents cmbSeccion As System.Windows.Forms.ComboBox
        Friend WithEvents txtResolucionMinisterial As System.Windows.Forms.TextBox
        Friend WithEvents txtNombreRector As System.Windows.Forms.TextBox
        Friend WithEvents txtNombreInstitucion As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents txtTelefono As System.Windows.Forms.MaskedTextBox
        Friend WithEvents txtWeb As System.Windows.Forms.TextBox
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents txtEmail As System.Windows.Forms.TextBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents btnEditar As System.Windows.Forms.Button
        Friend WithEvents btnGuardar As System.Windows.Forms.Button
    End Class
End Namespace