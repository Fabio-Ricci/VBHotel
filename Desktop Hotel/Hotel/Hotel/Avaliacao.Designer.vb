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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Avaliacao))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.lblRestaurantes = New System.Windows.Forms.Label()
        Me.lblRegiao = New System.Windows.Forms.Label()
        Me.lblQuarto = New System.Windows.Forms.Label()
        Me.lblAtendimento = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnAtendimento = New System.Windows.Forms.Panel()
        Me.pnRestaurantes = New System.Windows.Forms.Panel()
        Me.pnRegiao = New System.Windows.Forms.Panel()
        Me.pnQuarto = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btnLoad)
        Me.GroupBox1.Controls.Add(Me.lblRestaurantes)
        Me.GroupBox1.Controls.Add(Me.lblRegiao)
        Me.GroupBox1.Controls.Add(Me.lblQuarto)
        Me.GroupBox1.Controls.Add(Me.lblAtendimento)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.pnAtendimento)
        Me.GroupBox1.Controls.Add(Me.pnRestaurantes)
        Me.GroupBox1.Controls.Add(Me.pnRegiao)
        Me.GroupBox1.Controls.Add(Me.pnQuarto)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 175)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Média das avaliações"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(136, 140)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(13, 13)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Total de avaliações:"
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(219, 19)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 8
        Me.btnLoad.Text = "Recarregar"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'lblRestaurantes
        '
        Me.lblRestaurantes.AutoSize = True
        Me.lblRestaurantes.Location = New System.Drawing.Point(136, 98)
        Me.lblRestaurantes.Name = "lblRestaurantes"
        Me.lblRestaurantes.Size = New System.Drawing.Size(13, 13)
        Me.lblRestaurantes.TabIndex = 7
        Me.lblRestaurantes.Text = "0"
        '
        'lblRegiao
        '
        Me.lblRegiao.AutoSize = True
        Me.lblRegiao.Location = New System.Drawing.Point(136, 75)
        Me.lblRegiao.Name = "lblRegiao"
        Me.lblRegiao.Size = New System.Drawing.Size(13, 13)
        Me.lblRegiao.TabIndex = 6
        Me.lblRegiao.Text = "0"
        '
        'lblQuarto
        '
        Me.lblQuarto.AutoSize = True
        Me.lblQuarto.Location = New System.Drawing.Point(136, 53)
        Me.lblQuarto.Name = "lblQuarto"
        Me.lblQuarto.Size = New System.Drawing.Size(13, 13)
        Me.lblQuarto.TabIndex = 5
        Me.lblQuarto.Text = "0"
        '
        'lblAtendimento
        '
        Me.lblAtendimento.AutoSize = True
        Me.lblAtendimento.BackColor = System.Drawing.SystemColors.Control
        Me.lblAtendimento.ForeColor = System.Drawing.Color.Black
        Me.lblAtendimento.Location = New System.Drawing.Point(136, 29)
        Me.lblAtendimento.Name = "lblAtendimento"
        Me.lblAtendimento.Size = New System.Drawing.Size(13, 13)
        Me.lblAtendimento.TabIndex = 4
        Me.lblAtendimento.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Restaurantes:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Região:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Quarto:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Atendimento:"
        '
        'pnAtendimento
        '
        Me.pnAtendimento.Location = New System.Drawing.Point(25, 25)
        Me.pnAtendimento.Name = "pnAtendimento"
        Me.pnAtendimento.Size = New System.Drawing.Size(174, 19)
        Me.pnAtendimento.TabIndex = 11
        '
        'pnRestaurantes
        '
        Me.pnRestaurantes.Location = New System.Drawing.Point(25, 94)
        Me.pnRestaurantes.Name = "pnRestaurantes"
        Me.pnRestaurantes.Size = New System.Drawing.Size(174, 19)
        Me.pnRestaurantes.TabIndex = 12
        '
        'pnRegiao
        '
        Me.pnRegiao.Location = New System.Drawing.Point(25, 71)
        Me.pnRegiao.Name = "pnRegiao"
        Me.pnRegiao.Size = New System.Drawing.Size(174, 19)
        Me.pnRegiao.TabIndex = 13
        '
        'pnQuarto
        '
        Me.pnQuarto.Location = New System.Drawing.Point(25, 48)
        Me.pnQuarto.Name = "pnQuarto"
        Me.pnQuarto.Size = New System.Drawing.Size(174, 19)
        Me.pnQuarto.TabIndex = 12
        '
        'Avaliacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 195)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Avaliacao"
        Me.Text = "Avaliação"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents lblRestaurantes As System.Windows.Forms.Label
    Friend WithEvents lblRegiao As System.Windows.Forms.Label
    Friend WithEvents lblQuarto As System.Windows.Forms.Label
    Friend WithEvents lblAtendimento As System.Windows.Forms.Label
    Friend WithEvents pnAtendimento As System.Windows.Forms.Panel
    Friend WithEvents pnRestaurantes As System.Windows.Forms.Panel
    Friend WithEvents pnRegiao As System.Windows.Forms.Panel
    Friend WithEvents pnQuarto As System.Windows.Forms.Panel
End Class
