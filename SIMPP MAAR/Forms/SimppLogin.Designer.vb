Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class SimppLogin
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SimppLogin))
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnAcept = New System.Windows.Forms.Button()
            Me.btnExit = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtUsuario = New System.Windows.Forms.TextBox()
            Me.txtPassword = New System.Windows.Forms.TextBox()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.BackgroundImage = Global.SIMPP_MAAR.My.Resources.Resources.register1
            Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel1.Location = New System.Drawing.Point(13, 14)
            Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(238, 237)
            Me.Panel1.TabIndex = 0
            '
            'btnAcept
            '
            Me.btnAcept.Location = New System.Drawing.Point(299, 220)
            Me.btnAcept.Name = "btnAcept"
            Me.btnAcept.Size = New System.Drawing.Size(100, 31)
            Me.btnAcept.TabIndex = 2
            Me.btnAcept.Text = "Aceptar"
            Me.btnAcept.UseVisualStyleBackColor = True
            '
            'btnExit
            '
            Me.btnExit.Location = New System.Drawing.Point(447, 220)
            Me.btnExit.Name = "btnExit"
            Me.btnExit.Size = New System.Drawing.Size(100, 31)
            Me.btnExit.TabIndex = 3
            Me.btnExit.Text = "Salir"
            Me.btnExit.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Image = Global.SIMPP_MAAR.My.Resources.Resources.user
            Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Label1.Location = New System.Drawing.Point(295, 63)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(116, 20)
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "         idUsuario:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Image = Global.SIMPP_MAAR.My.Resources.Resources.key
            Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Label2.Location = New System.Drawing.Point(295, 131)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(128, 20)
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "        Contraseña:"
            '
            'txtUsuario
            '
            Me.txtUsuario.Location = New System.Drawing.Point(295, 86)
            Me.txtUsuario.Name = "txtUsuario"
            Me.txtUsuario.Size = New System.Drawing.Size(251, 26)
            Me.txtUsuario.TabIndex = 0
            '
            'txtPassword
            '
            Me.txtPassword.Location = New System.Drawing.Point(295, 154)
            Me.txtPassword.Name = "txtPassword"
            Me.txtPassword.Size = New System.Drawing.Size(251, 26)
            Me.txtPassword.TabIndex = 1
            Me.txtPassword.UseSystemPasswordChar = True
            '
            'SimppLogin
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(562, 262)
            Me.Controls.Add(Me.txtPassword)
            Me.Controls.Add(Me.txtUsuario)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.btnExit)
            Me.Controls.Add(Me.btnAcept)
            Me.Controls.Add(Me.Panel1)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "SimppLogin"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SimppLogin"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnAcept As System.Windows.Forms.Button
        Friend WithEvents btnExit As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
        Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    End Class
End Namespace