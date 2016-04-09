Namespace Forms.FormsAdministrador
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Simpp202
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
            Me.Label9 = New System.Windows.Forms.Label()
            Me.cmbSearch = New System.Windows.Forms.ComboBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.dgvPersonas = New System.Windows.Forms.DataGridView()
            Me.txtfiltro = New System.Windows.Forms.TextBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.cmbEstadoCivil = New System.Windows.Forms.ComboBox()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.cmbCiudad = New System.Windows.Forms.ComboBox()
            Me.cmbNacionalidad = New System.Windows.Forms.ComboBox()
            Me.cmbGenero = New System.Windows.Forms.ComboBox()
            Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtTelefono = New System.Windows.Forms.MaskedTextBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.txtCorreo = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtDireccion = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtApellidos = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.txtCedula = New System.Windows.Forms.TextBox()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.lblIdPersona = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.btnLimpiar = New System.Windows.Forms.Button()
            Me.btnmodificar = New System.Windows.Forms.Button()
            Me.btngrabar = New System.Windows.Forms.Button()
            Me.btnnuevo = New System.Windows.Forms.Button()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.Panel1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.dgvPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.Panel1.Controls.Add(Me.btngrabar)
            Me.Panel1.Controls.Add(Me.btnnuevo)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1264, 533)
            Me.Panel1.TabIndex = 6
            '
            'btnActualizar
            '
            Me.btnActualizar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnActualizar.Image = Global.SIMPP_MAAR.My.Resources.Resources.save
            Me.btnActualizar.Location = New System.Drawing.Point(1117, 81)
            Me.btnActualizar.Name = "btnActualizar"
            Me.btnActualizar.Size = New System.Drawing.Size(134, 41)
            Me.btnActualizar.TabIndex = 126
            Me.btnActualizar.Text = "Actualizar"
            Me.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnActualizar.UseVisualStyleBackColor = False
            Me.btnActualizar.Visible = False
            '
            'btnCancelar
            '
            Me.btnCancelar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Location = New System.Drawing.Point(1117, 249)
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(134, 41)
            Me.btnCancelar.TabIndex = 129
            Me.btnCancelar.Text = "Cancelar"
            Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnCancelar.UseVisualStyleBackColor = False
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.Label9)
            Me.GroupBox2.Controls.Add(Me.cmbSearch)
            Me.GroupBox2.Controls.Add(Me.Label6)
            Me.GroupBox2.Controls.Add(Me.dgvPersonas)
            Me.GroupBox2.Controls.Add(Me.txtfiltro)
            Me.GroupBox2.Location = New System.Drawing.Point(514, 11)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(587, 509)
            Me.GroupBox2.TabIndex = 148
            Me.GroupBox2.TabStop = False
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(6, 23)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(90, 20)
            Me.Label9.TabIndex = 149
            Me.Label9.Text = "Busqueda"
            '
            'cmbSearch
            '
            Me.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbSearch.FormattingEnabled = True
            Me.cmbSearch.Items.AddRange(New Object() {"Cedula", "Nombre"})
            Me.cmbSearch.Location = New System.Drawing.Point(102, 20)
            Me.cmbSearch.Name = "cmbSearch"
            Me.cmbSearch.Size = New System.Drawing.Size(123, 28)
            Me.cmbSearch.TabIndex = 148
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(223, -1)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(152, 20)
            Me.Label6.TabIndex = 147
            Me.Label6.Text = "Lista de personas"
            '
            'dgvPersonas
            '
            Me.dgvPersonas.AllowUserToAddRows = False
            Me.dgvPersonas.AllowUserToDeleteRows = False
            Me.dgvPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
            Me.dgvPersonas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvPersonas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvPersonas.Location = New System.Drawing.Point(6, 54)
            Me.dgvPersonas.Name = "dgvPersonas"
            Me.dgvPersonas.ReadOnly = True
            Me.dgvPersonas.Size = New System.Drawing.Size(575, 440)
            Me.dgvPersonas.TabIndex = 146
            '
            'txtfiltro
            '
            Me.txtfiltro.Location = New System.Drawing.Point(231, 22)
            Me.txtfiltro.Name = "txtfiltro"
            Me.txtfiltro.Size = New System.Drawing.Size(350, 26)
            Me.txtfiltro.TabIndex = 139
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.Label16)
            Me.GroupBox1.Controls.Add(Me.cmbEstadoCivil)
            Me.GroupBox1.Controls.Add(Me.Label14)
            Me.GroupBox1.Controls.Add(Me.cmbCiudad)
            Me.GroupBox1.Controls.Add(Me.cmbNacionalidad)
            Me.GroupBox1.Controls.Add(Me.cmbGenero)
            Me.GroupBox1.Controls.Add(Me.dtpFechaNacimiento)
            Me.GroupBox1.Controls.Add(Me.Label11)
            Me.GroupBox1.Controls.Add(Me.Label10)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.Label8)
            Me.GroupBox1.Controls.Add(Me.txtTelefono)
            Me.GroupBox1.Controls.Add(Me.Label12)
            Me.GroupBox1.Controls.Add(Me.txtCorreo)
            Me.GroupBox1.Controls.Add(Me.Label7)
            Me.GroupBox1.Controls.Add(Me.txtDireccion)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.txtApellidos)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.txtNombre)
            Me.GroupBox1.Controls.Add(Me.Label13)
            Me.GroupBox1.Controls.Add(Me.txtCedula)
            Me.GroupBox1.Controls.Add(Me.Label15)
            Me.GroupBox1.Controls.Add(Me.lblIdPersona)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(497, 509)
            Me.GroupBox1.TabIndex = 147
            Me.GroupBox1.TabStop = False
            '
            'cmbEstadoCivil
            '
            Me.cmbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbEstadoCivil.Enabled = False
            Me.cmbEstadoCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbEstadoCivil.FormattingEnabled = True
            Me.cmbEstadoCivil.Items.AddRange(New Object() {"Soltero", "Casado", "DIvorciado", "Viudo", "Union Libre"})
            Me.cmbEstadoCivil.Location = New System.Drawing.Point(201, 298)
            Me.cmbEstadoCivil.Name = "cmbEstadoCivil"
            Me.cmbEstadoCivil.Size = New System.Drawing.Size(182, 28)
            Me.cmbEstadoCivil.TabIndex = 157
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.Location = New System.Drawing.Point(6, 301)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(108, 20)
            Me.Label14.TabIndex = 172
            Me.Label14.Text = "Estado Civil:"
            '
            'cmbCiudad
            '
            Me.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCiudad.Enabled = False
            Me.cmbCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCiudad.FormattingEnabled = True
            Me.cmbCiudad.Location = New System.Drawing.Point(201, 370)
            Me.cmbCiudad.Name = "cmbCiudad"
            Me.cmbCiudad.Size = New System.Drawing.Size(182, 28)
            Me.cmbCiudad.TabIndex = 160
            '
            'cmbNacionalidad
            '
            Me.cmbNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbNacionalidad.Enabled = False
            Me.cmbNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbNacionalidad.FormattingEnabled = True
            Me.cmbNacionalidad.Location = New System.Drawing.Point(201, 334)
            Me.cmbNacionalidad.Name = "cmbNacionalidad"
            Me.cmbNacionalidad.Size = New System.Drawing.Size(182, 28)
            Me.cmbNacionalidad.TabIndex = 158
            '
            'cmbGenero
            '
            Me.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbGenero.Enabled = False
            Me.cmbGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbGenero.FormattingEnabled = True
            Me.cmbGenero.Items.AddRange(New Object() {"Masculino" & Global.Microsoft.VisualBasic.ChrW(9), "Femenino"})
            Me.cmbGenero.Location = New System.Drawing.Point(201, 262)
            Me.cmbGenero.Name = "cmbGenero"
            Me.cmbGenero.Size = New System.Drawing.Size(182, 28)
            Me.cmbGenero.TabIndex = 156
            '
            'dtpFechaNacimiento
            '
            Me.dtpFechaNacimiento.CustomFormat = ""
            Me.dtpFechaNacimiento.Enabled = False
            Me.dtpFechaNacimiento.Location = New System.Drawing.Point(201, 184)
            Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
            Me.dtpFechaNacimiento.Size = New System.Drawing.Size(281, 26)
            Me.dtpFechaNacimiento.TabIndex = 153
            Me.dtpFechaNacimiento.Value = New Date(2016, 1, 28, 13, 38, 8, 0)
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.Location = New System.Drawing.Point(6, 189)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(181, 20)
            Me.Label11.TabIndex = 171
            Me.Label11.Text = "Fecha de nacimiento:"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.Location = New System.Drawing.Point(7, 265)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(74, 20)
            Me.Label10.TabIndex = 170
            Me.Label10.Text = "Género:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(6, 373)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(70, 20)
            Me.Label1.TabIndex = 169
            Me.Label1.Text = "Ciudad:"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(6, 337)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(117, 20)
            Me.Label8.TabIndex = 168
            Me.Label8.Text = "Nacionalidad:"
            '
            'txtTelefono
            '
            Me.txtTelefono.BeepOnError = True
            Me.txtTelefono.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
            Me.txtTelefono.Enabled = False
            Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTelefono.HidePromptOnLeave = True
            Me.txtTelefono.Location = New System.Drawing.Point(201, 223)
            Me.txtTelefono.Mask = "0000000000"
            Me.txtTelefono.Name = "txtTelefono"
            Me.txtTelefono.Size = New System.Drawing.Size(281, 26)
            Me.txtTelefono.TabIndex = 154
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.Location = New System.Drawing.Point(6, 226)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(89, 20)
            Me.Label12.TabIndex = 167
            Me.Label12.Text = "Teléfono: "
            '
            'txtCorreo
            '
            Me.txtCorreo.Enabled = False
            Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCorreo.Location = New System.Drawing.Point(201, 451)
            Me.txtCorreo.MaxLength = 45
            Me.txtCorreo.Name = "txtCorreo"
            Me.txtCorreo.Size = New System.Drawing.Size(281, 26)
            Me.txtCorreo.TabIndex = 166
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(6, 454)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(73, 20)
            Me.Label7.TabIndex = 164
            Me.Label7.Text = "Correo: "
            '
            'txtDireccion
            '
            Me.txtDireccion.Enabled = False
            Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDireccion.Location = New System.Drawing.Point(201, 412)
            Me.txtDireccion.MaxLength = 45
            Me.txtDireccion.Name = "txtDireccion"
            Me.txtDireccion.Size = New System.Drawing.Size(281, 26)
            Me.txtDireccion.TabIndex = 165
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(6, 415)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(94, 20)
            Me.Label2.TabIndex = 162
            Me.Label2.Text = "Dirección: "
            '
            'txtApellidos
            '
            Me.txtApellidos.Enabled = False
            Me.txtApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtApellidos.Location = New System.Drawing.Point(201, 145)
            Me.txtApellidos.MaxLength = 45
            Me.txtApellidos.Name = "txtApellidos"
            Me.txtApellidos.ShortcutsEnabled = False
            Me.txtApellidos.Size = New System.Drawing.Size(281, 26)
            Me.txtApellidos.TabIndex = 151
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(6, 148)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(92, 20)
            Me.Label4.TabIndex = 159
            Me.Label4.Text = "Apellidos: "
            '
            'txtNombre
            '
            Me.txtNombre.Enabled = False
            Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombre.Location = New System.Drawing.Point(201, 106)
            Me.txtNombre.MaxLength = 45
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.ShortcutsEnabled = False
            Me.txtNombre.Size = New System.Drawing.Size(281, 26)
            Me.txtNombre.TabIndex = 149
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.Location = New System.Drawing.Point(6, 109)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(90, 20)
            Me.Label13.TabIndex = 155
            Me.Label13.Text = "Nombres: "
            '
            'txtCedula
            '
            Me.txtCedula.Enabled = False
            Me.txtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCedula.Location = New System.Drawing.Point(201, 67)
            Me.txtCedula.MaxLength = 10
            Me.txtCedula.Name = "txtCedula"
            Me.txtCedula.Size = New System.Drawing.Size(281, 26)
            Me.txtCedula.TabIndex = 148
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label15.Location = New System.Drawing.Point(6, 70)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(75, 20)
            Me.Label15.TabIndex = 152
            Me.Label15.Text = "Cedula: "
            '
            'lblIdPersona
            '
            Me.lblIdPersona.AutoSize = True
            Me.lblIdPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdPersona.Location = New System.Drawing.Point(197, 34)
            Me.lblIdPersona.Name = "lblIdPersona"
            Me.lblIdPersona.Size = New System.Drawing.Size(57, 20)
            Me.lblIdPersona.TabIndex = 147
            Me.lblIdPersona.Text = "Label2"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(168, -1)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(127, 20)
            Me.Label3.TabIndex = 146
            Me.Label3.Text = "Datos persona"
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
            Me.btnLimpiar.Location = New System.Drawing.Point(1117, 136)
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
            Me.btnmodificar.Location = New System.Drawing.Point(1117, 191)
            Me.btnmodificar.Name = "btnmodificar"
            Me.btnmodificar.Size = New System.Drawing.Size(134, 41)
            Me.btnmodificar.TabIndex = 128
            Me.btnmodificar.Text = "Modificar"
            Me.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnmodificar.UseVisualStyleBackColor = False
            '
            'btngrabar
            '
            Me.btngrabar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.btngrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btngrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btngrabar.Image = Global.SIMPP_MAAR.My.Resources.Resources.save
            Me.btngrabar.Location = New System.Drawing.Point(1117, 81)
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
            Me.btnnuevo.Location = New System.Drawing.Point(1117, 26)
            Me.btnnuevo.Name = "btnnuevo"
            Me.btnnuevo.Size = New System.Drawing.Size(134, 41)
            Me.btnnuevo.TabIndex = 124
            Me.btnnuevo.Text = "Nuevo"
            Me.btnnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnnuevo.UseVisualStyleBackColor = False
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label16.Location = New System.Drawing.Point(7, 34)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(33, 20)
            Me.Label16.TabIndex = 173
            Me.Label16.Text = "ID:"
            '
            'Simpp202
            '
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
            Me.ClientSize = New System.Drawing.Size(1264, 533)
            Me.Controls.Add(Me.Panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "Simpp202"
            Me.Text = "Simpp202"
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            CType(Me.dgvPersonas, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnActualizar As System.Windows.Forms.Button
        Friend WithEvents btnCancelar As System.Windows.Forms.Button
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents dgvPersonas As System.Windows.Forms.DataGridView
        Friend WithEvents txtfiltro As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents btnLimpiar As System.Windows.Forms.Button
        Friend WithEvents btnmodificar As System.Windows.Forms.Button
        Friend WithEvents btngrabar As System.Windows.Forms.Button
        Friend WithEvents btnnuevo As System.Windows.Forms.Button
        Friend WithEvents cmbEstadoCivil As System.Windows.Forms.ComboBox
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents cmbCiudad As System.Windows.Forms.ComboBox
        Friend WithEvents cmbNacionalidad As System.Windows.Forms.ComboBox
        Friend WithEvents cmbGenero As System.Windows.Forms.ComboBox
        Friend WithEvents dtpFechaNacimiento As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents txtTelefono As System.Windows.Forms.MaskedTextBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtApellidos As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtNombre As System.Windows.Forms.TextBox
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents txtCedula As System.Windows.Forms.TextBox
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents lblIdPersona As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents cmbSearch As System.Windows.Forms.ComboBox
        Friend WithEvents Label16 As System.Windows.Forms.Label
    End Class
End Namespace