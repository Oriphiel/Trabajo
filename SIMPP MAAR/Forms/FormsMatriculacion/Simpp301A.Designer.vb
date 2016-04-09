Namespace Forms.FormsMatriculacion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Simpp301A
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
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.cmbRelacion = New System.Windows.Forms.ComboBox()
            Me.cmbVive = New System.Windows.Forms.ComboBox()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.btnExit = New System.Windows.Forms.Button()
            Me.btnLimpiar = New System.Windows.Forms.Button()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.txtEmpresa = New System.Windows.Forms.TextBox()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.btnNoTrabaja = New System.Windows.Forms.Button()
            Me.txtTelefonoT = New System.Windows.Forms.MaskedTextBox()
            Me.btnTrabaja = New System.Windows.Forms.Button()
            Me.txtCorreoT = New System.Windows.Forms.TextBox()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.txtDireccionT = New System.Windows.Forms.TextBox()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.txtTrabajoT = New System.Windows.Forms.TextBox()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.label40 = New System.Windows.Forms.Label()
            Me.btnAgregarPadre = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtTitulo = New System.Windows.Forms.TextBox()
            Me.lblTitulo = New System.Windows.Forms.Label()
            Me.cmbNivel = New System.Windows.Forms.ComboBox()
            Me.Label18 = New System.Windows.Forms.Label()
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
            Me.lblIdRepresentante = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.Panel1.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.btnGuardar)
            Me.Panel1.Controls.Add(Me.GroupBox3)
            Me.Panel1.Controls.Add(Me.btnExit)
            Me.Panel1.Controls.Add(Me.btnLimpiar)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.btnAgregarPadre)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1121, 533)
            Me.Panel1.TabIndex = 6
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.cmbRelacion)
            Me.GroupBox3.Controls.Add(Me.cmbVive)
            Me.GroupBox3.Controls.Add(Me.Label20)
            Me.GroupBox3.Controls.Add(Me.Label22)
            Me.GroupBox3.Controls.Add(Me.Label23)
            Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox3.Location = New System.Drawing.Point(642, 276)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(448, 158)
            Me.GroupBox3.TabIndex = 30
            Me.GroupBox3.TabStop = False
            '
            'cmbRelacion
            '
            Me.cmbRelacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbRelacion.FormattingEnabled = True
            Me.cmbRelacion.Items.AddRange(New Object() {"Padre", "Madre", "Hermano(a)", "Tío(a)", "Otros"})
            Me.cmbRelacion.Location = New System.Drawing.Point(203, 94)
            Me.cmbRelacion.Name = "cmbRelacion"
            Me.cmbRelacion.Size = New System.Drawing.Size(216, 28)
            Me.cmbRelacion.TabIndex = 29
            '
            'cmbVive
            '
            Me.cmbVive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbVive.FormattingEnabled = True
            Me.cmbVive.Items.AddRange(New Object() {"Si", "No"})
            Me.cmbVive.Location = New System.Drawing.Point(203, 55)
            Me.cmbVive.Name = "cmbVive"
            Me.cmbVive.Size = New System.Drawing.Size(216, 28)
            Me.cmbVive.TabIndex = 28
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Location = New System.Drawing.Point(6, 97)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(141, 20)
            Me.Label20.TabIndex = 27
            Me.Label20.Text = "Tipo de relacion:"
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Location = New System.Drawing.Point(157, 0)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(111, 20)
            Me.Label22.TabIndex = 0
            Me.Label22.Text = "Otros Datos:"
            '
            'Label23
            '
            Me.Label23.AutoSize = True
            Me.Label23.Location = New System.Drawing.Point(6, 58)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(191, 20)
            Me.Label23.TabIndex = 23
            Me.Label23.Text = "Vive con el estudiante:"
            '
            'btnExit
            '
            Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnExit.Location = New System.Drawing.Point(945, 460)
            Me.btnExit.Name = "btnExit"
            Me.btnExit.Size = New System.Drawing.Size(116, 42)
            Me.btnExit.TabIndex = 4
            Me.btnExit.Text = "Salir"
            Me.btnExit.UseVisualStyleBackColor = True
            '
            'btnLimpiar
            '
            Me.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLimpiar.Image = Global.SIMPP_MAAR.My.Resources.Resources.refresh
            Me.btnLimpiar.Location = New System.Drawing.Point(797, 461)
            Me.btnLimpiar.Name = "btnLimpiar"
            Me.btnLimpiar.Size = New System.Drawing.Size(103, 41)
            Me.btnLimpiar.TabIndex = 3
            Me.btnLimpiar.Text = "Limpiar"
            Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnLimpiar.UseVisualStyleBackColor = False
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.txtEmpresa)
            Me.GroupBox2.Controls.Add(Me.Label19)
            Me.GroupBox2.Controls.Add(Me.btnNoTrabaja)
            Me.GroupBox2.Controls.Add(Me.txtTelefonoT)
            Me.GroupBox2.Controls.Add(Me.btnTrabaja)
            Me.GroupBox2.Controls.Add(Me.txtCorreoT)
            Me.GroupBox2.Controls.Add(Me.Label17)
            Me.GroupBox2.Controls.Add(Me.txtDireccionT)
            Me.GroupBox2.Controls.Add(Me.Label16)
            Me.GroupBox2.Controls.Add(Me.Label15)
            Me.GroupBox2.Controls.Add(Me.txtTrabajoT)
            Me.GroupBox2.Controls.Add(Me.Label13)
            Me.GroupBox2.Controls.Add(Me.label40)
            Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(642, 11)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(448, 259)
            Me.GroupBox2.TabIndex = 1
            Me.GroupBox2.TabStop = False
            '
            'txtEmpresa
            '
            Me.txtEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEmpresa.Location = New System.Drawing.Point(120, 58)
            Me.txtEmpresa.MaxLength = 45
            Me.txtEmpresa.Name = "txtEmpresa"
            Me.txtEmpresa.Size = New System.Drawing.Size(299, 26)
            Me.txtEmpresa.TabIndex = 30
            Me.txtEmpresa.Text = "SIn datos"
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Location = New System.Drawing.Point(6, 61)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(90, 20)
            Me.Label19.TabIndex = 31
            Me.Label19.Text = "Empresa: "
            '
            'btnNoTrabaja
            '
            Me.btnNoTrabaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNoTrabaja.Location = New System.Drawing.Point(313, 211)
            Me.btnNoTrabaja.Name = "btnNoTrabaja"
            Me.btnNoTrabaja.Size = New System.Drawing.Size(106, 42)
            Me.btnNoTrabaja.TabIndex = 6
            Me.btnNoTrabaja.Text = "No Trabaja"
            Me.btnNoTrabaja.UseVisualStyleBackColor = True
            '
            'txtTelefonoT
            '
            Me.txtTelefonoT.BeepOnError = True
            Me.txtTelefonoT.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
            Me.txtTelefonoT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTelefonoT.HidePromptOnLeave = True
            Me.txtTelefonoT.Location = New System.Drawing.Point(120, 139)
            Me.txtTelefonoT.Mask = "0000000000"
            Me.txtTelefonoT.Name = "txtTelefonoT"
            Me.txtTelefonoT.Size = New System.Drawing.Size(299, 26)
            Me.txtTelefonoT.TabIndex = 3
            Me.txtTelefonoT.Text = "0000000000"
            '
            'btnTrabaja
            '
            Me.btnTrabaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnTrabaja.Location = New System.Drawing.Point(228, 211)
            Me.btnTrabaja.Name = "btnTrabaja"
            Me.btnTrabaja.Size = New System.Drawing.Size(79, 42)
            Me.btnTrabaja.TabIndex = 5
            Me.btnTrabaja.Text = "Trabaja"
            Me.btnTrabaja.UseVisualStyleBackColor = True
            Me.btnTrabaja.Visible = False
            '
            'txtCorreoT
            '
            Me.txtCorreoT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCorreoT.Location = New System.Drawing.Point(120, 180)
            Me.txtCorreoT.MaxLength = 45
            Me.txtCorreoT.Name = "txtCorreoT"
            Me.txtCorreoT.Size = New System.Drawing.Size(299, 26)
            Me.txtCorreoT.TabIndex = 4
            Me.txtCorreoT.Text = "Sin datos"
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Location = New System.Drawing.Point(6, 183)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(73, 20)
            Me.Label17.TabIndex = 29
            Me.Label17.Text = "Correo: "
            '
            'txtDireccionT
            '
            Me.txtDireccionT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDireccionT.Location = New System.Drawing.Point(120, 100)
            Me.txtDireccionT.MaxLength = 45
            Me.txtDireccionT.Name = "txtDireccionT"
            Me.txtDireccionT.Size = New System.Drawing.Size(299, 26)
            Me.txtDireccionT.TabIndex = 2
            Me.txtDireccionT.Text = "Sin datos"
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Location = New System.Drawing.Point(6, 103)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(94, 20)
            Me.Label16.TabIndex = 27
            Me.Label16.Text = "Direccion: "
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Location = New System.Drawing.Point(6, 142)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(89, 20)
            Me.Label15.TabIndex = 25
            Me.Label15.Text = "Telefono: "
            '
            'txtTrabajoT
            '
            Me.txtTrabajoT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTrabajoT.Location = New System.Drawing.Point(120, 19)
            Me.txtTrabajoT.MaxLength = 45
            Me.txtTrabajoT.Name = "txtTrabajoT"
            Me.txtTrabajoT.Size = New System.Drawing.Size(299, 26)
            Me.txtTrabajoT.TabIndex = 1
            Me.txtTrabajoT.Text = "SIn datos"
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(151, 0)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(122, 20)
            Me.Label13.TabIndex = 0
            Me.Label13.Text = "Datos Trabajo"
            '
            'label40
            '
            Me.label40.AutoSize = True
            Me.label40.Location = New System.Drawing.Point(6, 22)
            Me.label40.Name = "label40"
            Me.label40.Size = New System.Drawing.Size(67, 20)
            Me.label40.TabIndex = 23
            Me.label40.Text = "Cargo: "
            '
            'btnAgregarPadre
            '
            Me.btnAgregarPadre.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.btnAgregarPadre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAgregarPadre.Image = Global.SIMPP_MAAR.My.Resources.Resources.add
            Me.btnAgregarPadre.Location = New System.Drawing.Point(642, 461)
            Me.btnAgregarPadre.Name = "btnAgregarPadre"
            Me.btnAgregarPadre.Size = New System.Drawing.Size(116, 41)
            Me.btnAgregarPadre.TabIndex = 2
            Me.btnAgregarPadre.Text = "Agregar"
            Me.btnAgregarPadre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnAgregarPadre.UseVisualStyleBackColor = False
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.txtTitulo)
            Me.GroupBox1.Controls.Add(Me.lblTitulo)
            Me.GroupBox1.Controls.Add(Me.cmbNivel)
            Me.GroupBox1.Controls.Add(Me.Label18)
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
            Me.GroupBox1.Controls.Add(Me.lblIdRepresentante)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(598, 491)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            '
            'txtTitulo
            '
            Me.txtTitulo.Location = New System.Drawing.Point(414, 358)
            Me.txtTitulo.Name = "txtTitulo"
            Me.txtTitulo.Size = New System.Drawing.Size(172, 26)
            Me.txtTitulo.TabIndex = 11
            Me.txtTitulo.Text = "Sin título"
            Me.txtTitulo.Visible = False
            '
            'lblTitulo
            '
            Me.lblTitulo.AutoSize = True
            Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitulo.Location = New System.Drawing.Point(410, 325)
            Me.lblTitulo.Name = "lblTitulo"
            Me.lblTitulo.Size = New System.Drawing.Size(58, 20)
            Me.lblTitulo.TabIndex = 26
            Me.lblTitulo.Text = "Titulo:"
            Me.lblTitulo.Visible = False
            '
            'cmbNivel
            '
            Me.cmbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbNivel.FormattingEnabled = True
            Me.cmbNivel.Items.AddRange(New Object() {"Sin Estudios", "Primaria ", "Secundaria ", "Bachillerato", "Universitario "})
            Me.cmbNivel.Location = New System.Drawing.Point(414, 286)
            Me.cmbNivel.Name = "cmbNivel"
            Me.cmbNivel.Size = New System.Drawing.Size(172, 28)
            Me.cmbNivel.TabIndex = 10
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label18.Location = New System.Drawing.Point(410, 253)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(166, 20)
            Me.Label18.TabIndex = 24
            Me.Label18.Text = "Nivel de Educación:"
            '
            'cmbEstadoCivil
            '
            Me.cmbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbEstadoCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbEstadoCivil.FormattingEnabled = True
            Me.cmbEstadoCivil.Items.AddRange(New Object() {"Soltero", "Casado", "DIvorciado", "Viudo", "Union Libre"})
            Me.cmbEstadoCivil.Location = New System.Drawing.Point(201, 286)
            Me.cmbEstadoCivil.Name = "cmbEstadoCivil"
            Me.cmbEstadoCivil.Size = New System.Drawing.Size(182, 28)
            Me.cmbEstadoCivil.TabIndex = 7
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.Location = New System.Drawing.Point(6, 289)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(108, 20)
            Me.Label14.TabIndex = 23
            Me.Label14.Text = "Estado Civil:"
            '
            'cmbCiudad
            '
            Me.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbCiudad.FormattingEnabled = True
            Me.cmbCiudad.Location = New System.Drawing.Point(201, 358)
            Me.cmbCiudad.Name = "cmbCiudad"
            Me.cmbCiudad.Size = New System.Drawing.Size(182, 28)
            Me.cmbCiudad.TabIndex = 9
            '
            'cmbNacionalidad
            '
            Me.cmbNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbNacionalidad.FormattingEnabled = True
            Me.cmbNacionalidad.Location = New System.Drawing.Point(201, 322)
            Me.cmbNacionalidad.Name = "cmbNacionalidad"
            Me.cmbNacionalidad.Size = New System.Drawing.Size(182, 28)
            Me.cmbNacionalidad.TabIndex = 8
            '
            'cmbGenero
            '
            Me.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbGenero.FormattingEnabled = True
            Me.cmbGenero.Items.AddRange(New Object() {"Masculino" & Global.Microsoft.VisualBasic.ChrW(9), "Femenino"})
            Me.cmbGenero.Location = New System.Drawing.Point(201, 250)
            Me.cmbGenero.Name = "cmbGenero"
            Me.cmbGenero.Size = New System.Drawing.Size(182, 28)
            Me.cmbGenero.TabIndex = 6
            '
            'dtpFechaNacimiento
            '
            Me.dtpFechaNacimiento.CustomFormat = ""
            Me.dtpFechaNacimiento.Location = New System.Drawing.Point(201, 172)
            Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
            Me.dtpFechaNacimiento.Size = New System.Drawing.Size(385, 26)
            Me.dtpFechaNacimiento.TabIndex = 4
            Me.dtpFechaNacimiento.Value = New Date(2016, 1, 28, 13, 38, 8, 0)
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.Location = New System.Drawing.Point(6, 177)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(181, 20)
            Me.Label11.TabIndex = 21
            Me.Label11.Text = "Fecha de nacimiento:"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.Location = New System.Drawing.Point(7, 253)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(74, 20)
            Me.Label10.TabIndex = 20
            Me.Label10.Text = "Género:"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(6, 361)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(70, 20)
            Me.Label9.TabIndex = 19
            Me.Label9.Text = "Ciudad:"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(6, 325)
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
            Me.txtTelefono.Location = New System.Drawing.Point(201, 211)
            Me.txtTelefono.Mask = "0000000000"
            Me.txtTelefono.Name = "txtTelefono"
            Me.txtTelefono.Size = New System.Drawing.Size(385, 26)
            Me.txtTelefono.TabIndex = 5
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.Location = New System.Drawing.Point(6, 214)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(89, 20)
            Me.Label12.TabIndex = 17
            Me.Label12.Text = "Teléfono: "
            '
            'txtCorreo
            '
            Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCorreo.Location = New System.Drawing.Point(201, 439)
            Me.txtCorreo.MaxLength = 45
            Me.txtCorreo.Name = "txtCorreo"
            Me.txtCorreo.Size = New System.Drawing.Size(385, 26)
            Me.txtCorreo.TabIndex = 13
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(6, 442)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(73, 20)
            Me.Label7.TabIndex = 12
            Me.Label7.Text = "Correo: "
            '
            'txtDireccion
            '
            Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDireccion.Location = New System.Drawing.Point(201, 400)
            Me.txtDireccion.MaxLength = 45
            Me.txtDireccion.Name = "txtDireccion"
            Me.txtDireccion.Size = New System.Drawing.Size(385, 26)
            Me.txtDireccion.TabIndex = 12
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(6, 403)
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
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(6, 58)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(75, 20)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Cedula: "
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(6, 22)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(38, 20)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "ID: "
            '
            'lblIdRepresentante
            '
            Me.lblIdRepresentante.AutoSize = True
            Me.lblIdRepresentante.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblIdRepresentante.Location = New System.Drawing.Point(197, 22)
            Me.lblIdRepresentante.Name = "lblIdRepresentante"
            Me.lblIdRepresentante.Size = New System.Drawing.Size(57, 20)
            Me.lblIdRepresentante.TabIndex = 1
            Me.lblIdRepresentante.Text = "Label2"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(224, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(135, 20)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Datos Personales"
            '
            'btnGuardar
            '
            Me.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.btnGuardar.Enabled = False
            Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnGuardar.Image = Global.SIMPP_MAAR.My.Resources.Resources.save
            Me.btnGuardar.Location = New System.Drawing.Point(642, 461)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(116, 41)
            Me.btnGuardar.TabIndex = 31
            Me.btnGuardar.Text = "Guardar"
            Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnGuardar.UseVisualStyleBackColor = False
            Me.btnGuardar.Visible = False
            '
            'Simpp301A
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1121, 533)
            Me.Controls.Add(Me.Panel1)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Name = "Simpp301A"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Simpp301A"
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnAgregarPadre As System.Windows.Forms.Button
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
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
        Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtApellidos As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtNombre As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtCedula As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents lblIdRepresentante As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents txtTelefonoT As System.Windows.Forms.MaskedTextBox
        Friend WithEvents txtCorreoT As System.Windows.Forms.TextBox
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents txtDireccionT As System.Windows.Forms.TextBox
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents txtTrabajoT As System.Windows.Forms.TextBox
        Friend WithEvents label40 As System.Windows.Forms.Label
        Friend WithEvents btnLimpiar As System.Windows.Forms.Button
        Friend WithEvents btnExit As System.Windows.Forms.Button
        Friend WithEvents cmbEstadoCivil As System.Windows.Forms.ComboBox
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents btnNoTrabaja As System.Windows.Forms.Button
        Friend WithEvents btnTrabaja As System.Windows.Forms.Button
        Friend WithEvents cmbNivel As System.Windows.Forms.ComboBox
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents lblTitulo As System.Windows.Forms.Label
        Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents cmbRelacion As System.Windows.Forms.ComboBox
        Friend WithEvents cmbVive As System.Windows.Forms.ComboBox
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents txtEmpresa As System.Windows.Forms.TextBox
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents btnGuardar As System.Windows.Forms.Button
    End Class
End Namespace