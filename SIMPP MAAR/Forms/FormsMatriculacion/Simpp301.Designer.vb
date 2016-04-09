Namespace Forms.FormsMatriculacion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Simpp301
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
            Me.components = New System.ComponentModel.Container()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnAsignar = New System.Windows.Forms.Button()
            Me.btnExit = New System.Windows.Forms.Button()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.btnAgregarPadre = New System.Windows.Forms.Button()
            Me.btnLimpiar = New System.Windows.Forms.Button()
            Me.label13 = New System.Windows.Forms.Label()
            Me.dgvRepresentante = New System.Windows.Forms.DataGridView()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.lblEdad = New System.Windows.Forms.Label()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.cmbLugarDeNacimiento = New System.Windows.Forms.ComboBox()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.txtObservaciones = New System.Windows.Forms.RichTextBox()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.cmbEstadoCivil = New System.Windows.Forms.ComboBox()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.cmbCiudad = New System.Windows.Forms.ComboBox()
            Me.cmbNacionalidad = New System.Windows.Forms.ComboBox()
            Me.cmbGenero = New System.Windows.Forms.ComboBox()
            Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtTelefono = New System.Windows.Forms.MaskedTextBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.txtCorreo = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtDireccion = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtApellidos = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtCedula = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.lblIdEstudiante = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.Panel1.SuspendLayout()
            CType(Me.dgvRepresentante, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.btnAsignar)
            Me.Panel1.Controls.Add(Me.btnExit)
            Me.Panel1.Controls.Add(Me.btnEliminar)
            Me.Panel1.Controls.Add(Me.btnAgregarPadre)
            Me.Panel1.Controls.Add(Me.btnLimpiar)
            Me.Panel1.Controls.Add(Me.label13)
            Me.Panel1.Controls.Add(Me.dgvRepresentante)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.btnGuardar)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1264, 533)
            Me.Panel1.TabIndex = 5
            '
            'btnAsignar
            '
            Me.btnAsignar.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAsignar.ForeColor = System.Drawing.Color.Black
            Me.btnAsignar.Image = Global.SIMPP_MAAR.My.Resources.Resources.search
            Me.btnAsignar.Location = New System.Drawing.Point(885, 486)
            Me.btnAsignar.Name = "btnAsignar"
            Me.btnAsignar.Size = New System.Drawing.Size(116, 42)
            Me.btnAsignar.TabIndex = 28
            Me.btnAsignar.Text = "Asignar"
            Me.btnAsignar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnAsignar.UseVisualStyleBackColor = False
            '
            'btnExit
            '
            Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnExit.ForeColor = System.Drawing.Color.Black
            Me.btnExit.Location = New System.Drawing.Point(1016, 486)
            Me.btnExit.Name = "btnExit"
            Me.btnExit.Size = New System.Drawing.Size(116, 42)
            Me.btnExit.TabIndex = 27
            Me.btnExit.Text = "Salir"
            Me.btnExit.UseVisualStyleBackColor = False
            Me.btnExit.Visible = False
            '
            'btnEliminar
            '
            Me.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEliminar.Image = Global.SIMPP_MAAR.My.Resources.Resources.Delete1
            Me.btnEliminar.Location = New System.Drawing.Point(761, 487)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(108, 41)
            Me.btnEliminar.TabIndex = 6
            Me.btnEliminar.Text = "Eliminar"
            Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnEliminar.UseVisualStyleBackColor = False
            '
            'btnAgregarPadre
            '
            Me.btnAgregarPadre.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.btnAgregarPadre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAgregarPadre.Image = Global.SIMPP_MAAR.My.Resources.Resources.add
            Me.btnAgregarPadre.Location = New System.Drawing.Point(629, 487)
            Me.btnAgregarPadre.Name = "btnAgregarPadre"
            Me.btnAgregarPadre.Size = New System.Drawing.Size(116, 41)
            Me.btnAgregarPadre.TabIndex = 5
            Me.btnAgregarPadre.Text = "Agregar"
            Me.btnAgregarPadre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnAgregarPadre.UseVisualStyleBackColor = False
            '
            'btnLimpiar
            '
            Me.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLimpiar.Image = Global.SIMPP_MAAR.My.Resources.Resources.refresh
            Me.btnLimpiar.Location = New System.Drawing.Point(330, 487)
            Me.btnLimpiar.Name = "btnLimpiar"
            Me.btnLimpiar.Size = New System.Drawing.Size(103, 41)
            Me.btnLimpiar.TabIndex = 4
            Me.btnLimpiar.Text = "Limpiar"
            Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnLimpiar.UseVisualStyleBackColor = False
            '
            'label13
            '
            Me.label13.AutoSize = True
            Me.label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label13.Location = New System.Drawing.Point(625, 33)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(143, 20)
            Me.label13.TabIndex = 3
            Me.label13.Text = "Representantes:"
            '
            'dgvRepresentante
            '
            Me.dgvRepresentante.AllowUserToAddRows = False
            Me.dgvRepresentante.AllowUserToDeleteRows = False
            Me.dgvRepresentante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvRepresentante.Location = New System.Drawing.Point(629, 69)
            Me.dgvRepresentante.Name = "dgvRepresentante"
            Me.dgvRepresentante.ReadOnly = True
            Me.dgvRepresentante.Size = New System.Drawing.Size(622, 380)
            Me.dgvRepresentante.TabIndex = 2
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.lblEdad)
            Me.GroupBox1.Controls.Add(Me.Label17)
            Me.GroupBox1.Controls.Add(Me.cmbLugarDeNacimiento)
            Me.GroupBox1.Controls.Add(Me.Label16)
            Me.GroupBox1.Controls.Add(Me.txtObservaciones)
            Me.GroupBox1.Controls.Add(Me.Label15)
            Me.GroupBox1.Controls.Add(Me.cmbEstadoCivil)
            Me.GroupBox1.Controls.Add(Me.Label14)
            Me.GroupBox1.Controls.Add(Me.cmbCiudad)
            Me.GroupBox1.Controls.Add(Me.cmbNacionalidad)
            Me.GroupBox1.Controls.Add(Me.cmbGenero)
            Me.GroupBox1.Controls.Add(Me.dtpFechaNacimiento)
            Me.GroupBox1.Controls.Add(Me.Label11)
            Me.GroupBox1.Controls.Add(Me.Label10)
            Me.GroupBox1.Controls.Add(Me.Label9)
            Me.GroupBox1.Controls.Add(Me.Label8)
            Me.GroupBox1.Controls.Add(Me.txtTelefono)
            Me.GroupBox1.Controls.Add(Me.Label12)
            Me.GroupBox1.Controls.Add(Me.txtCorreo)
            Me.GroupBox1.Controls.Add(Me.Label7)
            Me.GroupBox1.Controls.Add(Me.txtDireccion)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.txtApellidos)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.txtNombre)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.txtCedula)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.lblIdEstudiante)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(598, 470)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            '
            'lblEdad
            '
            Me.lblEdad.AutoSize = True
            Me.lblEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEdad.Location = New System.Drawing.Point(480, 177)
            Me.lblEdad.Name = "lblEdad"
            Me.lblEdad.Size = New System.Drawing.Size(0, 20)
            Me.lblEdad.TabIndex = 30
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Location = New System.Drawing.Point(389, 177)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(56, 20)
            Me.Label17.TabIndex = 29
            Me.Label17.Text = "Edad:"
            '
            'cmbLugarDeNacimiento
            '
            Me.cmbLugarDeNacimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbLugarDeNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbLugarDeNacimiento.FormattingEnabled = True
            Me.cmbLugarDeNacimiento.Location = New System.Drawing.Point(201, 209)
            Me.cmbLugarDeNacimiento.Name = "cmbLugarDeNacimiento"
            Me.cmbLugarDeNacimiento.Size = New System.Drawing.Size(182, 28)
            Me.cmbLugarDeNacimiento.TabIndex = 5
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Location = New System.Drawing.Point(6, 214)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(179, 20)
            Me.Label16.TabIndex = 27
            Me.Label16.Text = "Lugar de Nacimiento:"
            '
            'txtObservaciones
            '
            Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservaciones.Location = New System.Drawing.Point(393, 277)
            Me.txtObservaciones.MaxLength = 200
            Me.txtObservaciones.Name = "txtObservaciones"
            Me.txtObservaciones.Size = New System.Drawing.Size(193, 103)
            Me.txtObservaciones.TabIndex = 13
            Me.txtObservaciones.Text = ""
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Location = New System.Drawing.Point(389, 246)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(132, 20)
            Me.Label15.TabIndex = 26
            Me.Label15.Text = "Observaciones:"
            '
            'cmbEstadoCivil
            '
            Me.cmbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbEstadoCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbEstadoCivil.FormattingEnabled = True
            Me.cmbEstadoCivil.Items.AddRange(New Object() {"Soltero", "Casado", "DIvorciado", "Viudo", "Union Libre"})
            Me.cmbEstadoCivil.Location = New System.Drawing.Point(201, 243)
            Me.cmbEstadoCivil.Name = "cmbEstadoCivil"
            Me.cmbEstadoCivil.Size = New System.Drawing.Size(182, 28)
            Me.cmbEstadoCivil.TabIndex = 7
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(6, 246)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(108, 20)
            Me.Label14.TabIndex = 25
            Me.Label14.Text = "Estado Civil:"
            '
            'cmbCiudad
            '
            Me.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCiudad.FormattingEnabled = True
            Me.cmbCiudad.Location = New System.Drawing.Point(201, 351)
            Me.cmbCiudad.Name = "cmbCiudad"
            Me.cmbCiudad.Size = New System.Drawing.Size(182, 28)
            Me.cmbCiudad.TabIndex = 10
            '
            'cmbNacionalidad
            '
            Me.cmbNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbNacionalidad.FormattingEnabled = True
            Me.cmbNacionalidad.Location = New System.Drawing.Point(201, 315)
            Me.cmbNacionalidad.Name = "cmbNacionalidad"
            Me.cmbNacionalidad.Size = New System.Drawing.Size(182, 28)
            Me.cmbNacionalidad.TabIndex = 9
            '
            'cmbGenero
            '
            Me.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbGenero.FormattingEnabled = True
            Me.cmbGenero.Items.AddRange(New Object() {"Masculino", "Femenino"})
            Me.cmbGenero.Location = New System.Drawing.Point(201, 279)
            Me.cmbGenero.Name = "cmbGenero"
            Me.cmbGenero.Size = New System.Drawing.Size(182, 28)
            Me.cmbGenero.TabIndex = 8
            '
            'dtpFechaNacimiento
            '
            Me.dtpFechaNacimiento.CustomFormat = ""
            Me.dtpFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaNacimiento.Location = New System.Drawing.Point(201, 172)
            Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
            Me.dtpFechaNacimiento.Size = New System.Drawing.Size(119, 26)
            Me.dtpFechaNacimiento.TabIndex = 4
            Me.dtpFechaNacimiento.Value = New Date(2016, 1, 28, 0, 0, 0, 0)
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(6, 177)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(181, 20)
            Me.Label11.TabIndex = 21
            Me.Label11.Text = "Fecha de nacimiento:"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(6, 282)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(74, 20)
            Me.Label10.TabIndex = 20
            Me.Label10.Text = "Género:"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(6, 354)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(70, 20)
            Me.Label9.TabIndex = 19
            Me.Label9.Text = "Ciudad:"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(6, 318)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(117, 20)
            Me.Label8.TabIndex = 18
            Me.Label8.Text = "Nacionalidad:"
            '
            'txtTelefono
            '
            Me.txtTelefono.BeepOnError = True
            Me.txtTelefono.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
            Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTelefono.HidePromptOnLeave = True
            Me.txtTelefono.Location = New System.Drawing.Point(484, 211)
            Me.txtTelefono.Mask = "0000000000"
            Me.txtTelefono.Name = "txtTelefono"
            Me.txtTelefono.Size = New System.Drawing.Size(102, 26)
            Me.txtTelefono.TabIndex = 6
            Me.ToolTip1.SetToolTip(Me.txtTelefono, "Ingrese solo números")
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(389, 214)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(89, 20)
            Me.Label12.TabIndex = 17
            Me.Label12.Text = "Teléfono: "
            '
            'txtCorreo
            '
            Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCorreo.Location = New System.Drawing.Point(201, 432)
            Me.txtCorreo.MaxLength = 45
            Me.txtCorreo.Name = "txtCorreo"
            Me.txtCorreo.Size = New System.Drawing.Size(385, 26)
            Me.txtCorreo.TabIndex = 12
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(6, 435)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(73, 20)
            Me.Label7.TabIndex = 12
            Me.Label7.Text = "Correo: "
            '
            'txtDireccion
            '
            Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDireccion.Location = New System.Drawing.Point(201, 393)
            Me.txtDireccion.MaxLength = 45
            Me.txtDireccion.Name = "txtDireccion"
            Me.txtDireccion.Size = New System.Drawing.Size(385, 26)
            Me.txtDireccion.TabIndex = 11
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(6, 396)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(94, 20)
            Me.Label6.TabIndex = 10
            Me.Label6.Text = "Dirección: "
            '
            'txtApellidos
            '
            Me.txtApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtApellidos.Location = New System.Drawing.Point(201, 133)
            Me.txtApellidos.MaxLength = 45
            Me.txtApellidos.Name = "txtApellidos"
            Me.txtApellidos.ShortcutsEnabled = False
            Me.txtApellidos.Size = New System.Drawing.Size(385, 26)
            Me.txtApellidos.TabIndex = 3
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(6, 136)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(92, 20)
            Me.Label5.TabIndex = 8
            Me.Label5.Text = "Apellidos: "
            '
            'txtNombre
            '
            Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombre.Location = New System.Drawing.Point(201, 94)
            Me.txtNombre.MaxLength = 45
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.ShortcutsEnabled = False
            Me.txtNombre.Size = New System.Drawing.Size(385, 26)
            Me.txtNombre.TabIndex = 2
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(6, 97)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(90, 20)
            Me.Label4.TabIndex = 6
            Me.Label4.Text = "Nombres: "
            '
            'txtCedula
            '
            Me.txtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCedula.Location = New System.Drawing.Point(201, 55)
            Me.txtCedula.MaxLength = 10
            Me.txtCedula.Name = "txtCedula"
            Me.txtCedula.Size = New System.Drawing.Size(385, 26)
            Me.txtCedula.TabIndex = 1
            Me.ToolTip1.SetToolTip(Me.txtCedula, "Ingrese solo números")
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(6, 58)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(75, 20)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Cedula: "
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(6, 22)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(38, 20)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "ID: "
            '
            'lblIdEstudiante
            '
            Me.lblIdEstudiante.AutoSize = True
            Me.lblIdEstudiante.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdEstudiante.Location = New System.Drawing.Point(197, 22)
            Me.lblIdEstudiante.Name = "lblIdEstudiante"
            Me.lblIdEstudiante.Size = New System.Drawing.Size(57, 20)
            Me.lblIdEstudiante.TabIndex = 1
            Me.lblIdEstudiante.Text = "Label2"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(224, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(151, 20)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Datos Personales"
            '
            'btnGuardar
            '
            Me.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnGuardar.Image = Global.SIMPP_MAAR.My.Resources.Resources.save
            Me.btnGuardar.Location = New System.Drawing.Point(196, 487)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(111, 41)
            Me.btnGuardar.TabIndex = 3
            Me.btnGuardar.Text = "Guardar"
            Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnGuardar.UseVisualStyleBackColor = False
            '
            'Simpp301
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1264, 533)
            Me.ControlBox = False
            Me.Controls.Add(Me.Panel1)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Name = "Simpp301"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Simpp301"
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            CType(Me.dgvRepresentante, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents lblIdEstudiante As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtCedula As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtApellidos As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtNombre As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents cmbCiudad As System.Windows.Forms.ComboBox
        Friend WithEvents cmbNacionalidad As System.Windows.Forms.ComboBox
        Friend WithEvents cmbGenero As System.Windows.Forms.ComboBox
        Friend WithEvents dtpFechaNacimiento As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents txtTelefono As System.Windows.Forms.MaskedTextBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents btnGuardar As System.Windows.Forms.Button
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents btnLimpiar As System.Windows.Forms.Button
        Friend WithEvents label13 As System.Windows.Forms.Label
        Friend WithEvents dgvRepresentante As System.Windows.Forms.DataGridView
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents btnAgregarPadre As System.Windows.Forms.Button
        Friend WithEvents cmbEstadoCivil As System.Windows.Forms.ComboBox
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents txtObservaciones As System.Windows.Forms.RichTextBox
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents btnExit As System.Windows.Forms.Button
        Friend WithEvents btnAsignar As System.Windows.Forms.Button
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents cmbLugarDeNacimiento As System.Windows.Forms.ComboBox
        Friend WithEvents lblEdad As System.Windows.Forms.Label
        Friend WithEvents Label17 As System.Windows.Forms.Label
    End Class
End Namespace