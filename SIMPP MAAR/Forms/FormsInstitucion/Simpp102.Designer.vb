Namespace Forms.FormsInstitucion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Simpp102
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
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.btnSaveImage = New System.Windows.Forms.Button()
            Me.btnChangeImage = New System.Windows.Forms.Button()
            Me.picBoxEscudo = New System.Windows.Forms.PictureBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.btnEditHimno = New System.Windows.Forms.Button()
            Me.btnSaveHimno = New System.Windows.Forms.Button()
            Me.txtHimno = New System.Windows.Forms.RichTextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.btnEditVision = New System.Windows.Forms.Button()
            Me.txtVision = New System.Windows.Forms.RichTextBox()
            Me.btnSaveVision = New System.Windows.Forms.Button()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.btnEditMision = New System.Windows.Forms.Button()
            Me.btnSaveMision = New System.Windows.Forms.Button()
            Me.txtMision = New System.Windows.Forms.RichTextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.OpenFileDialogImage = New System.Windows.Forms.OpenFileDialog()
            Me.Panel1.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            CType(Me.picBoxEscudo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.GroupBox4)
            Me.Panel1.Controls.Add(Me.GroupBox3)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1264, 533)
            Me.Panel1.TabIndex = 4
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.btnSaveImage)
            Me.GroupBox4.Controls.Add(Me.btnChangeImage)
            Me.GroupBox4.Controls.Add(Me.picBoxEscudo)
            Me.GroupBox4.Controls.Add(Me.Label4)
            Me.GroupBox4.Location = New System.Drawing.Point(870, 11)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(381, 509)
            Me.GroupBox4.TabIndex = 3
            Me.GroupBox4.TabStop = False
            '
            'btnSaveImage
            '
            Me.btnSaveImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.btnSaveImage.Enabled = False
            Me.btnSaveImage.FlatAppearance.BorderSize = 0
            Me.btnSaveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSaveImage.Image = Global.SIMPP_MAAR.My.Resources.Resources.ok
            Me.btnSaveImage.Location = New System.Drawing.Point(233, 467)
            Me.btnSaveImage.Name = "btnSaveImage"
            Me.btnSaveImage.Size = New System.Drawing.Size(41, 36)
            Me.btnSaveImage.TabIndex = 6
            Me.ToolTip1.SetToolTip(Me.btnSaveImage, "Grabar")
            Me.btnSaveImage.UseVisualStyleBackColor = True
            '
            'btnChangeImage
            '
            Me.btnChangeImage.BackColor = System.Drawing.SystemColors.ActiveCaption
            Me.btnChangeImage.Location = New System.Drawing.Point(280, 467)
            Me.btnChangeImage.Name = "btnChangeImage"
            Me.btnChangeImage.Size = New System.Drawing.Size(95, 36)
            Me.btnChangeImage.TabIndex = 2
            Me.btnChangeImage.Text = "Cambiar..."
            Me.btnChangeImage.UseVisualStyleBackColor = False
            '
            'picBoxEscudo
            '
            Me.picBoxEscudo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.picBoxEscudo.Location = New System.Drawing.Point(6, 25)
            Me.picBoxEscudo.Name = "picBoxEscudo"
            Me.picBoxEscudo.Size = New System.Drawing.Size(369, 436)
            Me.picBoxEscudo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.picBoxEscudo.TabIndex = 1
            Me.picBoxEscudo.TabStop = False
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.BackColor = System.Drawing.SystemColors.Control
            Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label4.Location = New System.Drawing.Point(158, 0)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(65, 22)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Escudo"
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.btnEditHimno)
            Me.GroupBox3.Controls.Add(Me.btnSaveHimno)
            Me.GroupBox3.Controls.Add(Me.txtHimno)
            Me.GroupBox3.Controls.Add(Me.Label3)
            Me.GroupBox3.Location = New System.Drawing.Point(517, 11)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(347, 509)
            Me.GroupBox3.TabIndex = 2
            Me.GroupBox3.TabStop = False
            '
            'btnEditHimno
            '
            Me.btnEditHimno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.btnEditHimno.FlatAppearance.BorderSize = 0
            Me.btnEditHimno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditHimno.Image = Global.SIMPP_MAAR.My.Resources.Resources.edit
            Me.btnEditHimno.Location = New System.Drawing.Point(176, 467)
            Me.btnEditHimno.Name = "btnEditHimno"
            Me.btnEditHimno.Size = New System.Drawing.Size(41, 36)
            Me.btnEditHimno.TabIndex = 5
            Me.ToolTip1.SetToolTip(Me.btnEditHimno, "Editar")
            Me.btnEditHimno.UseVisualStyleBackColor = True
            '
            'btnSaveHimno
            '
            Me.btnSaveHimno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.btnSaveHimno.Enabled = False
            Me.btnSaveHimno.FlatAppearance.BorderSize = 0
            Me.btnSaveHimno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSaveHimno.Image = Global.SIMPP_MAAR.My.Resources.Resources.ok
            Me.btnSaveHimno.Location = New System.Drawing.Point(129, 467)
            Me.btnSaveHimno.Name = "btnSaveHimno"
            Me.btnSaveHimno.Size = New System.Drawing.Size(41, 36)
            Me.btnSaveHimno.TabIndex = 4
            Me.ToolTip1.SetToolTip(Me.btnSaveHimno, "Grabar")
            Me.btnSaveHimno.UseVisualStyleBackColor = True
            '
            'txtHimno
            '
            Me.txtHimno.Enabled = False
            Me.txtHimno.Location = New System.Drawing.Point(6, 25)
            Me.txtHimno.Name = "txtHimno"
            Me.txtHimno.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
            Me.txtHimno.Size = New System.Drawing.Size(335, 436)
            Me.txtHimno.TabIndex = 1
            Me.txtHimno.Text = ""
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.BackColor = System.Drawing.SystemColors.Control
            Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label3.Location = New System.Drawing.Point(145, 0)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(57, 22)
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Himno"
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.btnEditVision)
            Me.GroupBox2.Controls.Add(Me.txtVision)
            Me.GroupBox2.Controls.Add(Me.btnSaveVision)
            Me.GroupBox2.Controls.Add(Me.Label2)
            Me.GroupBox2.Location = New System.Drawing.Point(11, 270)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(500, 250)
            Me.GroupBox2.TabIndex = 1
            Me.GroupBox2.TabStop = False
            '
            'btnEditVision
            '
            Me.btnEditVision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.btnEditVision.FlatAppearance.BorderSize = 0
            Me.btnEditVision.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditVision.Image = Global.SIMPP_MAAR.My.Resources.Resources.edit
            Me.btnEditVision.Location = New System.Drawing.Point(253, 208)
            Me.btnEditVision.Name = "btnEditVision"
            Me.btnEditVision.Size = New System.Drawing.Size(41, 36)
            Me.btnEditVision.TabIndex = 5
            Me.ToolTip1.SetToolTip(Me.btnEditVision, "Editar")
            Me.btnEditVision.UseVisualStyleBackColor = True
            '
            'txtVision
            '
            Me.txtVision.Enabled = False
            Me.txtVision.Location = New System.Drawing.Point(6, 25)
            Me.txtVision.Name = "txtVision"
            Me.txtVision.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
            Me.txtVision.Size = New System.Drawing.Size(488, 177)
            Me.txtVision.TabIndex = 2
            Me.txtVision.Text = ""
            '
            'btnSaveVision
            '
            Me.btnSaveVision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.btnSaveVision.Enabled = False
            Me.btnSaveVision.FlatAppearance.BorderSize = 0
            Me.btnSaveVision.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSaveVision.Image = Global.SIMPP_MAAR.My.Resources.Resources.ok
            Me.btnSaveVision.Location = New System.Drawing.Point(206, 208)
            Me.btnSaveVision.Name = "btnSaveVision"
            Me.btnSaveVision.Size = New System.Drawing.Size(41, 36)
            Me.btnSaveVision.TabIndex = 4
            Me.ToolTip1.SetToolTip(Me.btnSaveVision, "Grabar")
            Me.btnSaveVision.UseVisualStyleBackColor = True
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = System.Drawing.SystemColors.Control
            Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label2.Location = New System.Drawing.Point(224, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(54, 22)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Visión"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.btnEditMision)
            Me.GroupBox1.Controls.Add(Me.btnSaveMision)
            Me.GroupBox1.Controls.Add(Me.txtMision)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(500, 250)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            '
            'btnEditMision
            '
            Me.btnEditMision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.btnEditMision.FlatAppearance.BorderSize = 0
            Me.btnEditMision.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditMision.Image = Global.SIMPP_MAAR.My.Resources.Resources.edit
            Me.btnEditMision.Location = New System.Drawing.Point(253, 208)
            Me.btnEditMision.Name = "btnEditMision"
            Me.btnEditMision.Size = New System.Drawing.Size(41, 36)
            Me.btnEditMision.TabIndex = 3
            Me.ToolTip1.SetToolTip(Me.btnEditMision, "Editar")
            Me.btnEditMision.UseVisualStyleBackColor = True
            '
            'btnSaveMision
            '
            Me.btnSaveMision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.btnSaveMision.Enabled = False
            Me.btnSaveMision.FlatAppearance.BorderSize = 0
            Me.btnSaveMision.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSaveMision.Image = Global.SIMPP_MAAR.My.Resources.Resources.ok
            Me.btnSaveMision.Location = New System.Drawing.Point(206, 208)
            Me.btnSaveMision.Name = "btnSaveMision"
            Me.btnSaveMision.Size = New System.Drawing.Size(41, 36)
            Me.btnSaveMision.TabIndex = 2
            Me.ToolTip1.SetToolTip(Me.btnSaveMision, "Grabar")
            Me.btnSaveMision.UseVisualStyleBackColor = True
            '
            'txtMision
            '
            Me.txtMision.Enabled = False
            Me.txtMision.Location = New System.Drawing.Point(6, 25)
            Me.txtMision.Name = "txtMision"
            Me.txtMision.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
            Me.txtMision.Size = New System.Drawing.Size(488, 177)
            Me.txtMision.TabIndex = 1
            Me.txtMision.Text = ""
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.SystemColors.Control
            Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label1.Location = New System.Drawing.Point(222, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(56, 22)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Misión"
            '
            'ToolTip1
            '
            Me.ToolTip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
            '
            'OpenFileDialogImage
            '
            Me.OpenFileDialogImage.FileName = "OpenFileDialog1"
            '
            'Simpp102
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1264, 533)
            Me.Controls.Add(Me.Panel1)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Name = "Simpp102"
            Me.Text = "Simpp102"
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            CType(Me.picBoxEscudo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents picBoxEscudo As System.Windows.Forms.PictureBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents txtHimno As System.Windows.Forms.RichTextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents txtVision As System.Windows.Forms.RichTextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtMision As System.Windows.Forms.RichTextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents btnSaveMision As System.Windows.Forms.Button
        Friend WithEvents btnEditMision As System.Windows.Forms.Button
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents btnEditVision As System.Windows.Forms.Button
        Friend WithEvents btnSaveVision As System.Windows.Forms.Button
        Friend WithEvents btnEditHimno As System.Windows.Forms.Button
        Friend WithEvents btnSaveHimno As System.Windows.Forms.Button
        Friend WithEvents btnChangeImage As System.Windows.Forms.Button
        Friend WithEvents OpenFileDialogImage As System.Windows.Forms.OpenFileDialog
        Friend WithEvents btnSaveImage As System.Windows.Forms.Button
    End Class
End Namespace