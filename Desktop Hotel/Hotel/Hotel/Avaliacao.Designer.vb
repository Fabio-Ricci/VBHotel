<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Avaliacao
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
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.txtAtendimento = New System.Windows.Forms.TextBox()
        Me.txtQuarto = New System.Windows.Forms.TextBox()
        Me.txtRegiao = New System.Windows.Forms.TextBox()
        Me.txtRestaurantes = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblQtdeRespostas = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(12, 12)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(431, 25)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "LOAD"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'txtAtendimento
        '
        Me.txtAtendimento.Location = New System.Drawing.Point(95, 19)
        Me.txtAtendimento.Name = "txtAtendimento"
        Me.txtAtendimento.Size = New System.Drawing.Size(59, 20)
        Me.txtAtendimento.TabIndex = 1
        '
        'txtQuarto
        '
        Me.txtQuarto.Location = New System.Drawing.Point(95, 45)
        Me.txtQuarto.Name = "txtQuarto"
        Me.txtQuarto.Size = New System.Drawing.Size(59, 20)
        Me.txtQuarto.TabIndex = 2
        '
        'txtRegiao
        '
        Me.txtRegiao.Location = New System.Drawing.Point(95, 71)
        Me.txtRegiao.Name = "txtRegiao"
        Me.txtRegiao.Size = New System.Drawing.Size(59, 20)
        Me.txtRegiao.TabIndex = 3
        '
        'txtRestaurantes
        '
        Me.txtRestaurantes.Location = New System.Drawing.Point(95, 97)
        Me.txtRestaurantes.Name = "txtRestaurantes"
        Me.txtRestaurantes.Size = New System.Drawing.Size(59, 20)
        Me.txtRestaurantes.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Atendimento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Quarto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Região:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Restaurantes:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblQtdeRespostas)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtAtendimento)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtQuarto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtRegiao)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtRestaurantes)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 168)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Média das avaliações"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Total de Respostas:"
        '
        'lblQtdeRespostas
        '
        Me.lblQtdeRespostas.AutoSize = True
        Me.lblQtdeRespostas.Location = New System.Drawing.Point(124, 136)
        Me.lblQtdeRespostas.Name = "lblQtdeRespostas"
        Me.lblQtdeRespostas.Size = New System.Drawing.Size(13, 13)
        Me.lblQtdeRespostas.TabIndex = 10
        Me.lblQtdeRespostas.Text = "0"
        '
        'Avaliacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 372)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLoad)
        Me.Name = "Avaliacao"
        Me.Text = "Avaliação"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents txtAtendimento As System.Windows.Forms.TextBox
    Friend WithEvents txtQuarto As System.Windows.Forms.TextBox
    Friend WithEvents txtRegiao As System.Windows.Forms.TextBox
    Friend WithEvents txtRestaurantes As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblQtdeRespostas As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
