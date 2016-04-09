Namespace Forms.FormsMatriculacion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Simpp302
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
            Me.btnActualizar = New System.Windows.Forms.Button()
            Me.btnExit = New System.Windows.Forms.Button()
            Me.btnLimpiar = New System.Windows.Forms.Button()
            Me.btnGuardar = New System.Windows.Forms.Button()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.lblRestantes = New System.Windows.Forms.Label()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.lblMasculinos = New System.Windows.Forms.Label()
            Me.lblFemeninos = New System.Windows.Forms.Label()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.btnListaEstudiantes = New System.Windows.Forms.Button()
            Me.txtDetalle = New System.Windows.Forms.TextBox()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.txtDescuento = New System.Windows.Forms.TextBox()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.cmbParalelo = New System.Windows.Forms.ComboBox()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.cmbCurso = New System.Windows.Forms.ComboBox()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.cmbPeriodo = New System.Windows.Forms.ComboBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.lblMatricula = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.txtApellidoR = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtNombreR = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtCedulaR = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.cmbRepresentante = New System.Windows.Forms.ComboBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.txtApellidos = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtCedula = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.lblIdEstudiante = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.btnSearch = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.cmbEstado = New System.Windows.Forms.ComboBox()
            Me.Panel1.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.btnActualizar)
            Me.Panel1.Controls.Add(Me.btnExit)
            Me.Panel1.Controls.Add(Me.btnLimpiar)
            Me.Panel1.Controls.Add(Me.btnGuardar)
            Me.Panel1.Controls.Add(Me.GroupBox4)
            Me.Panel1.Controls.Add(Me.GroupBox3)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.btnSearch)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1264, 533)
            Me.Panel1.TabIndex = 4
            '
            'btnActualizar
            '
            Me.btnActualizar.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnActualizar.Image = Global.SIMPP_MAAR.My.Resources.Resources.save
            Me.btnActualizar.Location = New System.Drawing.Point(421, 479)
            Me.btnActualizar.Name = "btnActualizar"
            Me.btnActualizar.Size = New System.Drawing.Size(134, 41)
            Me.btnActualizar.TabIndex = 127
            Me.btnActualizar.Text = "Actualizar"
            Me.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnActualizar.UseVisualStyleBackColor = False
            Me.btnActualizar.Visible = False
            '
            'btnExit
            '
            Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnExit.ForeColor = System.Drawing.Color.Black
            Me.btnExit.Location = New System.Drawing.Point(704, 479)
            Me.btnExit.Name = "btnExit"
            Me.btnExit.Size = New System.Drawing.Size(116, 42)
            Me.btnExit.TabIndex = 28
            Me.btnExit.Text = "Salir"
            Me.btnExit.UseVisualStyleBackColor = False
            Me.btnExit.Visible = False
            '
            'btnLimpiar
            '
            Me.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLimpiar.Image = Global.SIMPP_MAAR.My.Resources.Resources.refresh
            Me.btnLimpiar.Location = New System.Drawing.Point(578, 479)
            Me.btnLimpiar.Name = "btnLimpiar"
            Me.btnLimpiar.Size = New System.Drawing.Size(103, 41)
            Me.btnLimpiar.TabIndex = 7
            Me.btnLimpiar.Text = "Limpiar"
            Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnLimpiar.UseVisualStyleBackColor = False
            '
            'btnGuardar
            '
            Me.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnGuardar.Image = Global.SIMPP_MAAR.My.Resources.Resources.save
            Me.btnGuardar.Location = New System.Drawing.Point(444, 479)
            Me.btnGuardar.Name = "btnGuardar"
            Me.btnGuardar.Size = New System.Drawing.Size(111, 41)
            Me.btnGuardar.TabIndex = 6
            Me.btnGuardar.Text = "Guardar"
            Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnGuardar.UseVisualStyleBackColor = False
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.lblRestantes)
            Me.GroupBox4.Controls.Add(Me.Label23)
            Me.GroupBox4.Controls.Add(Me.lblMasculinos)
            Me.GroupBox4.Controls.Add(Me.lblFemeninos)
            Me.GroupBox4.Controls.Add(Me.lblTotal)
            Me.GroupBox4.Controls.Add(Me.Label20)
            Me.GroupBox4.Controls.Add(Me.Label19)
            Me.GroupBox4.Controls.Add(Me.Label18)
            Me.GroupBox4.Controls.Add(Me.Label17)
            Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox4.Location = New System.Drawing.Point(639, 288)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(612, 173)
            Me.GroupBox4.TabIndex = 5
            Me.GroupBox4.TabStop = False
            '
            'lblRestantes
            '
            Me.lblRestantes.AutoSize = True
            Me.lblRestantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRestantes.Location = New System.Drawing.Point(351, 142)
            Me.lblRestantes.Name = "lblRestantes"
            Me.lblRestantes.Size = New System.Drawing.Size(0, 20)
            Me.lblRestantes.TabIndex = 8
            '
            'Label23
            '
            Me.Label23.AutoSize = True
            Me.Label23.Location = New System.Drawing.Point(17, 142)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(191, 20)
            Me.Label23.TabIndex = 7
            Me.Label23.Text = "Estudiantes restantes:"
            '
            'lblMasculinos
            '
            Me.lblMasculinos.AutoSize = True
            Me.lblMasculinos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMasculinos.Location = New System.Drawing.Point(351, 106)
            Me.lblMasculinos.Name = "lblMasculinos"
            Me.lblMasculinos.Size = New System.Drawing.Size(0, 20)
            Me.lblMasculinos.TabIndex = 6
            '
            'lblFemeninos
            '
            Me.lblFemeninos.AutoSize = True
            Me.lblFemeninos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFemeninos.Location = New System.Drawing.Point(351, 67)
            Me.lblFemeninos.Name = "lblFemeninos"
            Me.lblFemeninos.Size = New System.Drawing.Size(0, 20)
            Me.lblFemeninos.TabIndex = 5
            '
            'lblTotal
            '
            Me.lblTotal.AutoSize = True
            Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotal.Location = New System.Drawing.Point(351, 28)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(0, 20)
            Me.lblTotal.TabIndex = 4
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Location = New System.Drawing.Point(17, 106)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(204, 20)
            Me.Label20.TabIndex = 3
            Me.Label20.Text = "Estudiantes masculinos:"
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Location = New System.Drawing.Point(17, 67)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(198, 20)
            Me.Label19.TabIndex = 2
            Me.Label19.Text = "Estudiantes femeninos:"
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Location = New System.Drawing.Point(17, 28)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(260, 20)
            Me.Label18.TabIndex = 1
            Me.Label18.Text = "Numero de estudiantes totales:"
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.Location = New System.Drawing.Point(252, 0)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(109, 20)
            Me.Label17.TabIndex = 0
            Me.Label17.Text = "Datos Curso"
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.cmbEstado)
            Me.GroupBox3.Controls.Add(Me.Label24)
            Me.GroupBox3.Controls.Add(Me.btnListaEstudiantes)
            Me.GroupBox3.Controls.Add(Me.txtDetalle)
            Me.GroupBox3.Controls.Add(Me.Label22)
            Me.GroupBox3.Controls.Add(Me.txtDescuento)
            Me.GroupBox3.Controls.Add(Me.Label21)
            Me.GroupBox3.Controls.Add(Me.Label16)
            Me.GroupBox3.Controls.Add(Me.cmbParalelo)
            Me.GroupBox3.Controls.Add(Me.Label15)
            Me.GroupBox3.Controls.Add(Me.cmbCurso)
            Me.GroupBox3.Controls.Add(Me.Label14)
            Me.GroupBox3.Controls.Add(Me.cmbPeriodo)
            Me.GroupBox3.Controls.Add(Me.Label12)
            Me.GroupBox3.Controls.Add(Me.lblMatricula)
            Me.GroupBox3.Controls.Add(Me.Label11)
            Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox3.Location = New System.Drawing.Point(639, 31)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(612, 251)
            Me.GroupBox3.TabIndex = 3
            Me.GroupBox3.TabStop = False
            '
            'Label24
            '
            Me.Label24.AutoSize = True
            Me.Label24.Location = New System.Drawing.Point(17, 213)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(71, 20)
            Me.Label24.TabIndex = 21
            Me.Label24.Text = "Estado:"
            '
            'btnListaEstudiantes
            '
            Me.btnListaEstudiantes.Enabled = False
            Me.btnListaEstudiantes.FlatAppearance.BorderSize = 0
            Me.btnListaEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnListaEstudiantes.Image = Global.SIMPP_MAAR.My.Resources.Resources.search
            Me.btnListaEstudiantes.Location = New System.Drawing.Point(351, 134)
            Me.btnListaEstudiantes.Name = "btnListaEstudiantes"
            Me.btnListaEstudiantes.Size = New System.Drawing.Size(29, 25)
            Me.btnListaEstudiantes.TabIndex = 15
            Me.btnListaEstudiantes.UseVisualStyleBackColor = True
            '
            'txtDetalle
            '
            Me.txtDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDetalle.Location = New System.Drawing.Point(339, 174)
            Me.txtDetalle.MaxLength = 100
            Me.txtDetalle.Name = "txtDetalle"
            Me.txtDetalle.Size = New System.Drawing.Size(258, 26)
            Me.txtDetalle.TabIndex = 18
            Me.txtDetalle.Text = "Sin descuento"
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Location = New System.Drawing.Point(252, 177)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(71, 20)
            Me.Label22.TabIndex = 20
            Me.Label22.Text = "Detalle:"
            '
            'txtDescuento
            '
            Me.txtDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDescuento.Location = New System.Drawing.Point(133, 174)
            Me.txtDescuento.MaxLength = 2
            Me.txtDescuento.Name = "txtDescuento"
            Me.txtDescuento.Size = New System.Drawing.Size(80, 26)
            Me.txtDescuento.TabIndex = 17
            Me.txtDescuento.Text = "0"
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.Location = New System.Drawing.Point(17, 177)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(101, 20)
            Me.Label21.TabIndex = 18
            Me.Label21.Text = "Descuento:"
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Location = New System.Drawing.Point(265, 0)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(82, 20)
            Me.Label16.TabIndex = 17
            Me.Label16.Text = "Matrícula"
            '
            'cmbParalelo
            '
            Me.cmbParalelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbParalelo.Enabled = False
            Me.cmbParalelo.FormattingEnabled = True
            Me.cmbParalelo.Location = New System.Drawing.Point(133, 133)
            Me.cmbParalelo.Name = "cmbParalelo"
            Me.cmbParalelo.Size = New System.Drawing.Size(197, 28)
            Me.cmbParalelo.TabIndex = 16
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Location = New System.Drawing.Point(17, 136)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(79, 20)
            Me.Label15.TabIndex = 15
            Me.Label15.Text = "Paralelo:"
            '
            'cmbCurso
            '
            Me.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCurso.FormattingEnabled = True
            Me.cmbCurso.Location = New System.Drawing.Point(133, 94)
            Me.cmbCurso.Name = "cmbCurso"
            Me.cmbCurso.Size = New System.Drawing.Size(464, 28)
            Me.cmbCurso.TabIndex = 14
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(17, 97)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(61, 20)
            Me.Label14.TabIndex = 13
            Me.Label14.Text = "Curso:"
            '
            'cmbPeriodo
            '
            Me.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPeriodo.FormattingEnabled = True
            Me.cmbPeriodo.Location = New System.Drawing.Point(133, 55)
            Me.cmbPeriodo.Name = "cmbPeriodo"
            Me.cmbPeriodo.Size = New System.Drawing.Size(464, 28)
            Me.cmbPeriodo.TabIndex = 12
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(17, 58)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(75, 20)
            Me.Label12.TabIndex = 11
            Me.Label12.Text = "Periodo:"
            '
            'lblMatricula
            '
            Me.lblMatricula.AutoSize = True
            Me.lblMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMatricula.Location = New System.Drawing.Point(129, 22)
            Me.lblMatricula.Name = "lblMatricula"
            Me.lblMatricula.Size = New System.Drawing.Size(66, 20)
            Me.lblMatricula.TabIndex = 1
            Me.lblMatricula.Text = "Label12"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(17, 22)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(33, 20)
            Me.Label11.TabIndex = 0
            Me.Label11.Text = "ID:"
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.txtApellidoR)
            Me.GroupBox2.Controls.Add(Me.Label7)
            Me.GroupBox2.Controls.Add(Me.txtNombreR)
            Me.GroupBox2.Controls.Add(Me.Label8)
            Me.GroupBox2.Controls.Add(Me.txtCedulaR)
            Me.GroupBox2.Controls.Add(Me.Label9)
            Me.GroupBox2.Controls.Add(Me.Label6)
            Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(11, 288)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(598, 173)
            Me.GroupBox2.TabIndex = 4
            Me.GroupBox2.TabStop = False
            '
            'txtApellidoR
            '
            Me.txtApellidoR.Enabled = False
            Me.txtApellidoR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtApellidoR.Location = New System.Drawing.Point(201, 120)
            Me.txtApellidoR.MaxLength = 45
            Me.txtApellidoR.Name = "txtApellidoR"
            Me.txtApellidoR.ShortcutsEnabled = False
            Me.txtApellidoR.Size = New System.Drawing.Size(385, 26)
            Me.txtApellidoR.TabIndex = 13
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(11, 123)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(92, 20)
            Me.Label7.TabIndex = 16
            Me.Label7.Text = "Apellidos: "
            '
            'txtNombreR
            '
            Me.txtNombreR.Enabled = False
            Me.txtNombreR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNombreR.Location = New System.Drawing.Point(201, 74)
            Me.txtNombreR.MaxLength = 45
            Me.txtNombreR.Name = "txtNombreR"
            Me.txtNombreR.ShortcutsEnabled = False
            Me.txtNombreR.Size = New System.Drawing.Size(385, 26)
            Me.txtNombreR.TabIndex = 11
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(11, 77)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(90, 20)
            Me.Label8.TabIndex = 15
            Me.Label8.Text = "Nombres: "
            '
            'txtCedulaR
            '
            Me.txtCedulaR.Enabled = False
            Me.txtCedulaR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCedulaR.Location = New System.Drawing.Point(201, 28)
            Me.txtCedulaR.MaxLength = 10
            Me.txtCedulaR.Name = "txtCedulaR"
            Me.txtCedulaR.Size = New System.Drawing.Size(182, 26)
            Me.txtCedulaR.TabIndex = 9
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(11, 28)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(75, 20)
            Me.Label9.TabIndex = 14
            Me.Label9.Text = "Cedula: "
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(208, 0)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(182, 20)
            Me.Label6.TabIndex = 0
            Me.Label6.Text = "Datos Representante"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.cmbRepresentante)
            Me.GroupBox1.Controls.Add(Me.Label10)
            Me.GroupBox1.Controls.Add(Me.txtApellidos)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.txtNombre)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.txtCedula)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.lblIdEstudiante)
            Me.GroupBox1.Controls.Add(Me.Label13)
            Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(11, 31)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(598, 215)
            Me.GroupBox1.TabIndex = 2
            Me.GroupBox1.TabStop = False
            '
            'cmbRepresentante
            '
            Me.cmbRepresentante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbRepresentante.FormattingEnabled = True
            Me.cmbRepresentante.Location = New System.Drawing.Point(201, 174)
            Me.cmbRepresentante.Name = "cmbRepresentante"
            Me.cmbRepresentante.Size = New System.Drawing.Size(385, 28)
            Me.cmbRepresentante.TabIndex = 10
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(6, 177)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(134, 20)
            Me.Label10.TabIndex = 9
            Me.Label10.Text = "Representante:"
            '
            'txtApellidos
            '
            Me.txtApellidos.Enabled = False
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
            Me.txtNombre.Enabled = False
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
            Me.txtCedula.Enabled = False
            Me.txtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCedula.Location = New System.Drawing.Point(201, 55)
            Me.txtCedula.MaxLength = 10
            Me.txtCedula.Name = "txtCedula"
            Me.txtCedula.Size = New System.Drawing.Size(182, 26)
            Me.txtCedula.TabIndex = 1
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
            Me.lblIdEstudiante.Size = New System.Drawing.Size(0, 20)
            Me.lblIdEstudiante.TabIndex = 1
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(225, 0)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(149, 20)
            Me.Label13.TabIndex = 0
            Me.Label13.Text = "Datos Estudiante"
            '
            'btnSearch
            '
            Me.btnSearch.FlatAppearance.BorderSize = 0
            Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSearch.Image = Global.SIMPP_MAAR.My.Resources.Resources.search
            Me.btnSearch.Location = New System.Drawing.Point(107, 6)
            Me.btnSearch.Name = "btnSearch"
            Me.btnSearch.Size = New System.Drawing.Size(29, 25)
            Me.btnSearch.TabIndex = 1
            Me.btnSearch.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(11, 8)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(90, 20)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Estudiante:"
            '
            'cmbEstado
            '
            Me.cmbEstado.FormattingEnabled = True
            Me.cmbEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
            Me.cmbEstado.Location = New System.Drawing.Point(133, 210)
            Me.cmbEstado.Name = "cmbEstado"
            Me.cmbEstado.Size = New System.Drawing.Size(144, 28)
            Me.cmbEstado.TabIndex = 22
            '
            'Simpp302
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1264, 533)
            Me.Controls.Add(Me.Panel1)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Name = "Simpp302"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Simpp302"
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents btnSearch As System.Windows.Forms.Button
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtApellidos As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtNombre As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtCedula As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents lblIdEstudiante As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtApellidoR As System.Windows.Forms.TextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txtNombreR As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents txtCedulaR As System.Windows.Forms.TextBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents cmbRepresentante As System.Windows.Forms.ComboBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents cmbParalelo As System.Windows.Forms.ComboBox
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents cmbCurso As System.Windows.Forms.ComboBox
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents cmbPeriodo As System.Windows.Forms.ComboBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents lblMatricula As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents lblMasculinos As System.Windows.Forms.Label
        Friend WithEvents lblFemeninos As System.Windows.Forms.Label
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents btnLimpiar As System.Windows.Forms.Button
        Friend WithEvents btnGuardar As System.Windows.Forms.Button
        Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents txtDetalle As System.Windows.Forms.TextBox
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents btnExit As System.Windows.Forms.Button
        Friend WithEvents btnListaEstudiantes As System.Windows.Forms.Button
        Friend WithEvents btnActualizar As System.Windows.Forms.Button
        Friend WithEvents lblRestantes As System.Windows.Forms.Label
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    End Class
End Namespace