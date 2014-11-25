<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblid = New System.Windows.Forms.Label()
        Me.BTNcadastrousuario = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.Location = New System.Drawing.Point(48, 24)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(0, 25)
        Me.lblid.TabIndex = 0
        '
        'BTNcadastrousuario
        '
        Me.BTNcadastrousuario.Location = New System.Drawing.Point(226, 125)
        Me.BTNcadastrousuario.Name = "BTNcadastrousuario"
        Me.BTNcadastrousuario.Size = New System.Drawing.Size(191, 57)
        Me.BTNcadastrousuario.TabIndex = 1
        Me.BTNcadastrousuario.Text = "cadastro de usuários do sistema"
        Me.BTNcadastrousuario.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(226, 178)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(191, 49)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Deslogar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 528)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTNcadastrousuario)
        Me.Controls.Add(Me.lblid)
        Me.Name = "Menu"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents BTNcadastrousuario As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
