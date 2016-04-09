Namespace Forms.FormsReportes
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Simpp406
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Simpp406))
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.btnInforme = New System.Windows.Forms.Button()
            Me.gbPanel = New System.Windows.Forms.GroupBox()
            Me.cmbParalelo = New System.Windows.Forms.ComboBox()
            Me.cmbCurso = New System.Windows.Forms.ComboBox()
            Me.cmbPeriodo = New System.Windows.Forms.ComboBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Panel1.SuspendLayout()
            Me.gbPanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
            resources.ApplyResources(Me.Panel1, "Panel1")
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.btnSalir)
            Me.Panel1.Controls.Add(Me.btnInforme)
            Me.Panel1.Controls.Add(Me.gbPanel)
            Me.Panel1.Name = "Panel1"
            '
            'btnSalir
            '
            resources.ApplyResources(Me.btnSalir, "btnSalir")
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'btnInforme
            '
            resources.ApplyResources(Me.btnInforme, "btnInforme")
            Me.btnInforme.Name = "btnInforme"
            Me.btnInforme.UseVisualStyleBackColor = True
            '
            'gbPanel
            '
            Me.gbPanel.Controls.Add(Me.cmbParalelo)
            Me.gbPanel.Controls.Add(Me.cmbCurso)
            Me.gbPanel.Controls.Add(Me.cmbPeriodo)
            Me.gbPanel.Controls.Add(Me.Label3)
            Me.gbPanel.Controls.Add(Me.Label2)
            Me.gbPanel.Controls.Add(Me.Label1)
            resources.ApplyResources(Me.gbPanel, "gbPanel")
            Me.gbPanel.Name = "gbPanel"
            Me.gbPanel.TabStop = False
            '
            'cmbParalelo
            '
            Me.cmbParalelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            resources.ApplyResources(Me.cmbParalelo, "cmbParalelo")
            Me.cmbParalelo.FormattingEnabled = True
            Me.cmbParalelo.Name = "cmbParalelo"
            '
            'cmbCurso
            '
            Me.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbCurso.FormattingEnabled = True
            resources.ApplyResources(Me.cmbCurso, "cmbCurso")
            Me.cmbCurso.Name = "cmbCurso"
            '
            'cmbPeriodo
            '
            Me.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPeriodo.FormattingEnabled = True
            resources.ApplyResources(Me.cmbPeriodo, "cmbPeriodo")
            Me.cmbPeriodo.Name = "cmbPeriodo"
            '
            'Label3
            '
            resources.ApplyResources(Me.Label3, "Label3")
            Me.Label3.Name = "Label3"
            '
            'Label2
            '
            resources.ApplyResources(Me.Label2, "Label2")
            Me.Label2.Name = "Label2"
            '
            'Label1
            '
            resources.ApplyResources(Me.Label1, "Label1")
            Me.Label1.Name = "Label1"
            '
            'Simpp406
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me.Panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "Simpp406"
            Me.Panel1.ResumeLayout(False)
            Me.gbPanel.ResumeLayout(False)
            Me.gbPanel.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnInforme As System.Windows.Forms.Button
        Friend WithEvents gbPanel As System.Windows.Forms.GroupBox
        Friend WithEvents cmbParalelo As System.Windows.Forms.ComboBox
        Friend WithEvents cmbCurso As System.Windows.Forms.ComboBox
        Friend WithEvents cmbPeriodo As System.Windows.Forms.ComboBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
    End Class
End Namespace