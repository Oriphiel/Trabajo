﻿Namespace Forms.FormsAdministrador
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Simpp203
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
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnActualizar = New System.Windows.Forms.Button()
            Me.btnCancelar = New System.Windows.Forms.Button()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.dgvRubros = New System.Windows.Forms.DataGridView()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.dtpPago = New System.Windows.Forms.DateTimePicker()
            Me.cmbEstado = New System.Windows.Forms.ComboBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.lblIDRubros = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtCosto = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.btnLimpiar = New System.Windows.Forms.Button()
            Me.btnmodificar = New System.Windows.Forms.Button()
            Me.btnDesactivar = New System.Windows.Forms.Button()
            Me.btngrabar = New System.Windows.Forms.Button()
            Me.btnnuevo = New System.Windows.Forms.Button()
            Me.cmbRubros = New System.Windows.Forms.ComboBox()
            Me.Panel1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.dgvRubros, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.Panel1.TabIndex = 6
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
            Me.GroupBox2.Controls.Add(Me.dgvRubros)
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
            Me.Label6.Location = New System.Drawing.Point(235, -1)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(129, 20)
            Me.Label6.TabIndex = 147
            Me.Label6.Text = "Lista de rubros"
            '
            'dgvRubros
            '
            Me.dgvRubros.AllowUserToAddRows = False
            Me.dgvRubros.AllowUserToDeleteRows = False
            Me.dgvRubros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
            Me.dgvRubros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvRubros.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvRubros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvRubros.Location = New System.Drawing.Point(6, 22)
            Me.dgvRubros.Name = "dgvRubros"
            Me.dgvRubros.ReadOnly = True
            Me.dgvRubros.Size = New System.Drawing.Size(582, 472)
            Me.dgvRubros.TabIndex = 146
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.cmbRubros)
            Me.GroupBox1.Controls.Add(Me.dtpPago)
            Me.GroupBox1.Controls.Add(Me.cmbEstado)
            Me.GroupBox1.Controls.Add(Me.Label7)
            Me.GroupBox1.Controls.Add(Me.lblIDRubros)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.txtCosto)
            Me.GroupBox1.Controls.Add(Me.Label8)
            Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(463, 262)
            Me.GroupBox1.TabIndex = 147
            Me.GroupBox1.TabStop = False
            '
            'dtpPago
            '
            Me.dtpPago.Enabled = False
            Me.dtpPago.Location = New System.Drawing.Point(128, 158)
            Me.dtpPago.Name = "dtpPago"
            Me.dtpPago.Size = New System.Drawing.Size(289, 26)
            Me.dtpPago.TabIndex = 3
            Me.dtpPago.Value = New Date(2016, 2, 4, 0, 0, 0, 0)
            '
            'cmbEstado
            '
            Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbEstado.Enabled = False
            Me.cmbEstado.FormattingEnabled = True
            Me.cmbEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
            Me.cmbEstado.Location = New System.Drawing.Point(128, 207)
            Me.cmbEstado.Name = "cmbEstado"
            Me.cmbEstado.Size = New System.Drawing.Size(144, 28)
            Me.cmbEstado.TabIndex = 4
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(6, 212)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(66, 20)
            Me.Label7.TabIndex = 152
            Me.Label7.Text = "Estado"
            '
            'lblIDRubros
            '
            Me.lblIDRubros.AutoSize = True
            Me.lblIDRubros.Location = New System.Drawing.Point(124, 31)
            Me.lblIDRubros.Name = "lblIDRubros"
            Me.lblIDRubros.Size = New System.Drawing.Size(0, 20)
            Me.lblIDRubros.TabIndex = 147
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(170, -1)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(122, 20)
            Me.Label3.TabIndex = 146
            Me.Label3.Text = "Detalles rubro"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(6, 31)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(91, 20)
            Me.Label1.TabIndex = 129
            Me.Label1.Text = "ID Rubros"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(6, 71)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(75, 20)
            Me.Label2.TabIndex = 131
            Me.Label2.Text = "Detalles"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(6, 117)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(56, 20)
            Me.Label4.TabIndex = 133
            Me.Label4.Text = "Costo"
            '
            'txtCosto
            '
            Me.txtCosto.Enabled = False
            Me.txtCosto.Location = New System.Drawing.Point(128, 114)
            Me.txtCosto.MaxLength = 10
            Me.txtCosto.Name = "txtCosto"
            Me.txtCosto.Size = New System.Drawing.Size(289, 26)
            Me.txtCosto.TabIndex = 2
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(6, 163)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(104, 20)
            Me.Label8.TabIndex = 138
            Me.Label8.Text = "Fecha pago"
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
            'cmbRubros
            '
            Me.cmbRubros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbRubros.Enabled = False
            Me.cmbRubros.FormattingEnabled = True
            Me.cmbRubros.Location = New System.Drawing.Point(128, 63)
            Me.cmbRubros.Name = "cmbRubros"
            Me.cmbRubros.Size = New System.Drawing.Size(289, 28)
            Me.cmbRubros.TabIndex = 153
            '
            'Simpp203
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1264, 533)
            Me.Controls.Add(Me.Panel1)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Name = "Simpp203"
            Me.Text = "Simpp203"
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            CType(Me.dgvRubros, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnActualizar As System.Windows.Forms.Button
        Friend WithEvents btnCancelar As System.Windows.Forms.Button
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents dgvRubros As System.Windows.Forms.DataGridView
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents lblIDRubros As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtCosto As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents btnLimpiar As System.Windows.Forms.Button
        Friend WithEvents btnmodificar As System.Windows.Forms.Button
        Friend WithEvents btnDesactivar As System.Windows.Forms.Button
        Friend WithEvents btngrabar As System.Windows.Forms.Button
        Friend WithEvents btnnuevo As System.Windows.Forms.Button
        Friend WithEvents dtpPago As System.Windows.Forms.DateTimePicker
        Friend WithEvents cmbRubros As System.Windows.Forms.ComboBox
    End Class
End Namespace