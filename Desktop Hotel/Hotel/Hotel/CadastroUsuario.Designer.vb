﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadastroUsuario))
        Me.RBfuncionario = New System.Windows.Forms.RadioButton()
        Me.RBgerente = New System.Windows.Forms.RadioButton()
        Me.EDsenha = New System.Windows.Forms.TextBox()
        Me.EDusuario = New System.Windows.Forms.TextBox()
        Me.EDconfirmarsenha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTirarFoto = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ofdFoto = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PBfoto = New System.Windows.Forms.PictureBox()
        CType(Me.PBfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RBfuncionario
        '
        Me.RBfuncionario.AutoSize = True
        Me.RBfuncionario.BackColor = System.Drawing.Color.Transparent
        Me.RBfuncionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBfuncionario.Location = New System.Drawing.Point(327, 196)
        Me.RBfuncionario.Name = "RBfuncionario"
        Me.RBfuncionario.Size = New System.Drawing.Size(110, 24)
        Me.RBfuncionario.TabIndex = 1
        Me.RBfuncionario.TabStop = True
        Me.RBfuncionario.Text = "Funcionário"
        Me.RBfuncionario.UseVisualStyleBackColor = False
        '
        'RBgerente
        '
        Me.RBgerente.AutoSize = True
        Me.RBgerente.BackColor = System.Drawing.Color.Transparent
        Me.RBgerente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBgerente.Location = New System.Drawing.Point(460, 196)
        Me.RBgerente.Name = "RBgerente"
        Me.RBgerente.Size = New System.Drawing.Size(86, 24)
        Me.RBgerente.TabIndex = 2
        Me.RBgerente.TabStop = True
        Me.RBgerente.Text = "Gerente"
        Me.RBgerente.UseVisualStyleBackColor = False
        '
        'EDsenha
        '
        Me.EDsenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EDsenha.Location = New System.Drawing.Point(406, 98)
        Me.EDsenha.MaxLength = 20
        Me.EDsenha.Name = "EDsenha"
        Me.EDsenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.EDsenha.Size = New System.Drawing.Size(168, 26)
        Me.EDsenha.TabIndex = 3
        '
        'EDusuario
        '
        Me.EDusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EDusuario.Location = New System.Drawing.Point(406, 50)
        Me.EDusuario.MaxLength = 20
        Me.EDusuario.Name = "EDusuario"
        Me.EDusuario.Size = New System.Drawing.Size(168, 26)
        Me.EDusuario.TabIndex = 4
        '
        'EDconfirmarsenha
        '
        Me.EDconfirmarsenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EDconfirmarsenha.Location = New System.Drawing.Point(406, 145)
        Me.EDconfirmarsenha.MaxLength = 20
        Me.EDconfirmarsenha.Name = "EDconfirmarsenha"
        Me.EDconfirmarsenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.EDconfirmarsenha.Size = New System.Drawing.Size(168, 26)
        Me.EDconfirmarsenha.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(336, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Usuário"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(344, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Senha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(271, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Confirmar Senha"
        '
        'btnTirarFoto
        '
        Me.btnTirarFoto.Enabled = False
        Me.btnTirarFoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTirarFoto.Location = New System.Drawing.Point(327, 251)
        Me.btnTirarFoto.Name = "btnTirarFoto"
        Me.btnTirarFoto.Size = New System.Drawing.Size(168, 30)
        Me.btnTirarFoto.TabIndex = 9
        Me.btnTirarFoto.Text = "Tirar Foto"
        Me.btnTirarFoto.UseVisualStyleBackColor = True
        Me.btnTirarFoto.Visible = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(327, 298)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(168, 30)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Inserir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(54, 317)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(162, 30)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Adicionar foto existente"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ofdFoto
        '
        Me.ofdFoto.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(30, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(220, 30)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Ativar câmera"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(84, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Sua foto Aqui"
        '
        'PBfoto
        '
        Me.PBfoto.Image = CType(resources.GetObject("PBfoto.Image"), System.Drawing.Image)
        Me.PBfoto.InitialImage = Nothing
        Me.PBfoto.Location = New System.Drawing.Point(54, 105)
        Me.PBfoto.Name = "PBfoto"
        Me.PBfoto.Size = New System.Drawing.Size(165, 195)
        Me.PBfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBfoto.TabIndex = 15
        Me.PBfoto.TabStop = False
        '
        'CadastroUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(624, 380)
        Me.Controls.Add(Me.PBfoto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnTirarFoto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EDconfirmarsenha)
        Me.Controls.Add(Me.EDusuario)
        Me.Controls.Add(Me.EDsenha)
        Me.Controls.Add(Me.RBgerente)
        Me.Controls.Add(Me.RBfuncionario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CadastroUsuario"
        Me.Text = "Mountain Ville - Cadastro Usuário"
        CType(Me.PBfoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RBfuncionario As System.Windows.Forms.RadioButton
    Friend WithEvents RBgerente As System.Windows.Forms.RadioButton
    Friend WithEvents EDsenha As System.Windows.Forms.TextBox
    Friend WithEvents EDusuario As System.Windows.Forms.TextBox
    Friend WithEvents EDconfirmarsenha As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnTirarFoto As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ofdFoto As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PBfoto As System.Windows.Forms.PictureBox
End Class
