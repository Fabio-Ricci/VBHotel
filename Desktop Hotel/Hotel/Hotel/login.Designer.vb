<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.EDusuario = New System.Windows.Forms.TextBox()
        Me.EDsenha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.senha = New System.Windows.Forms.Label()
        Me.BTNlogar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'EDusuario
        '
        Me.EDusuario.Location = New System.Drawing.Point(177, 169)
        Me.EDusuario.MaxLength = 20
        Me.EDusuario.Name = "EDusuario"
        Me.EDusuario.Size = New System.Drawing.Size(230, 20)
        Me.EDusuario.TabIndex = 0
        '
        'EDsenha
        '
        Me.EDsenha.Location = New System.Drawing.Point(177, 231)
        Me.EDsenha.MaxLength = 20
        Me.EDsenha.Name = "EDsenha"
        Me.EDsenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.EDsenha.Size = New System.Drawing.Size(230, 20)
        Me.EDsenha.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(125, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usuário:"
        '
        'senha
        '
        Me.senha.AutoSize = True
        Me.senha.Location = New System.Drawing.Point(125, 238)
        Me.senha.Name = "senha"
        Me.senha.Size = New System.Drawing.Size(38, 13)
        Me.senha.TabIndex = 3
        Me.senha.Text = "Senha"
        '
        'BTNlogar
        '
        Me.BTNlogar.Location = New System.Drawing.Point(223, 318)
        Me.BTNlogar.Name = "BTNlogar"
        Me.BTNlogar.Size = New System.Drawing.Size(120, 25)
        Me.BTNlogar.TabIndex = 4
        Me.BTNlogar.Text = "Logar"
        Me.BTNlogar.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(602, 509)
        Me.Controls.Add(Me.BTNlogar)
        Me.Controls.Add(Me.senha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EDsenha)
        Me.Controls.Add(Me.EDusuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mountain Ville - Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EDusuario As System.Windows.Forms.TextBox
    Friend WithEvents EDsenha As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents senha As System.Windows.Forms.Label
    Friend WithEvents BTNlogar As System.Windows.Forms.Button
End Class
