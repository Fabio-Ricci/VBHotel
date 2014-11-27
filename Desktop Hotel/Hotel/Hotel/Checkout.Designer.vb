<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Checkout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Checkout))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlCheckout = New System.Windows.Forms.Panel()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.gbQuarto = New System.Windows.Forms.GroupBox()
        Me.txtDiaria = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTipoQuarto = New System.Windows.Forms.TextBox()
        Me.gbItensConsumidos = New System.Windows.Forms.GroupBox()
        Me.btnAnt = New System.Windows.Forms.Button()
        Me.btnProx = New System.Windows.Forms.Button()
        Me.lblItens = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCustoUnitario = New System.Windows.Forms.TextBox()
        Me.txtDescricaoItem = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.gbFrigobar = New System.Windows.Forms.GroupBox()
        Me.RbNao = New System.Windows.Forms.RadioButton()
        Me.rbSim = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCamasSolteiro = New System.Windows.Forms.TextBox()
        Me.txtCamasCasal = New System.Windows.Forms.TextBox()
        Me.txtAndar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtValorDiaria = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtConsumoTotal = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.pnlCheckout.SuspendLayout()
        Me.gbQuarto.SuspendLayout()
        Me.gbItensConsumidos.SuspendLayout()
        Me.gbFrigobar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CPF:"
        '
        'pnlCheckout
        '
        Me.pnlCheckout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCheckout.BackColor = System.Drawing.Color.Transparent
        Me.pnlCheckout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlCheckout.Controls.Add(Me.btnCheckout)
        Me.pnlCheckout.Controls.Add(Me.gbQuarto)
        Me.pnlCheckout.Controls.Add(Me.gbItensConsumidos)
        Me.pnlCheckout.Controls.Add(Me.gbFrigobar)
        Me.pnlCheckout.Controls.Add(Me.Label10)
        Me.pnlCheckout.Controls.Add(Me.Label9)
        Me.pnlCheckout.Controls.Add(Me.txtCamasSolteiro)
        Me.pnlCheckout.Controls.Add(Me.txtCamasCasal)
        Me.pnlCheckout.Controls.Add(Me.txtAndar)
        Me.pnlCheckout.Controls.Add(Me.Label8)
        Me.pnlCheckout.Controls.Add(Me.txtNumero)
        Me.pnlCheckout.Controls.Add(Me.Label7)
        Me.pnlCheckout.Controls.Add(Me.txtValorDiaria)
        Me.pnlCheckout.Controls.Add(Me.Label5)
        Me.pnlCheckout.Controls.Add(Me.Label4)
        Me.pnlCheckout.Controls.Add(Me.txtConsumoTotal)
        Me.pnlCheckout.Controls.Add(Me.txtEmail)
        Me.pnlCheckout.Controls.Add(Me.txtNome)
        Me.pnlCheckout.Controls.Add(Me.Label3)
        Me.pnlCheckout.Controls.Add(Me.Label2)
        Me.pnlCheckout.Location = New System.Drawing.Point(12, 41)
        Me.pnlCheckout.Name = "pnlCheckout"
        Me.pnlCheckout.Size = New System.Drawing.Size(686, 349)
        Me.pnlCheckout.TabIndex = 2
        Me.pnlCheckout.Visible = False
        '
        'btnCheckout
        '
        Me.btnCheckout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckout.Location = New System.Drawing.Point(442, 291)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(93, 28)
        Me.btnCheckout.TabIndex = 26
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'gbQuarto
        '
        Me.gbQuarto.Controls.Add(Me.txtDiaria)
        Me.gbQuarto.Controls.Add(Me.Label14)
        Me.gbQuarto.Controls.Add(Me.Label6)
        Me.gbQuarto.Controls.Add(Me.txtTipoQuarto)
        Me.gbQuarto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbQuarto.Location = New System.Drawing.Point(20, 66)
        Me.gbQuarto.Name = "gbQuarto"
        Me.gbQuarto.Size = New System.Drawing.Size(249, 92)
        Me.gbQuarto.TabIndex = 25
        Me.gbQuarto.TabStop = False
        Me.gbQuarto.Text = "Quarto"
        '
        'txtDiaria
        '
        Me.txtDiaria.Enabled = False
        Me.txtDiaria.Location = New System.Drawing.Point(137, 56)
        Me.txtDiaria.Name = "txtDiaria"
        Me.txtDiaria.Size = New System.Drawing.Size(100, 26)
        Me.txtDiaria.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 59)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 20)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Diária: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Tipo do quarto: "
        '
        'txtTipoQuarto
        '
        Me.txtTipoQuarto.Enabled = False
        Me.txtTipoQuarto.Location = New System.Drawing.Point(137, 24)
        Me.txtTipoQuarto.Name = "txtTipoQuarto"
        Me.txtTipoQuarto.Size = New System.Drawing.Size(100, 26)
        Me.txtTipoQuarto.TabIndex = 8
        '
        'gbItensConsumidos
        '
        Me.gbItensConsumidos.Controls.Add(Me.btnAnt)
        Me.gbItensConsumidos.Controls.Add(Me.btnProx)
        Me.gbItensConsumidos.Controls.Add(Me.lblItens)
        Me.gbItensConsumidos.Controls.Add(Me.Label11)
        Me.gbItensConsumidos.Controls.Add(Me.txtCustoUnitario)
        Me.gbItensConsumidos.Controls.Add(Me.txtDescricaoItem)
        Me.gbItensConsumidos.Controls.Add(Me.Label12)
        Me.gbItensConsumidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbItensConsumidos.Location = New System.Drawing.Point(301, 66)
        Me.gbItensConsumidos.Name = "gbItensConsumidos"
        Me.gbItensConsumidos.Size = New System.Drawing.Size(369, 199)
        Me.gbItensConsumidos.TabIndex = 24
        Me.gbItensConsumidos.TabStop = False
        Me.gbItensConsumidos.Text = "Itens Consumidos"
        Me.gbItensConsumidos.Visible = False
        '
        'btnAnt
        '
        Me.btnAnt.Location = New System.Drawing.Point(17, 61)
        Me.btnAnt.Name = "btnAnt"
        Me.btnAnt.Size = New System.Drawing.Size(32, 28)
        Me.btnAnt.TabIndex = 26
        Me.btnAnt.Text = "<"
        Me.btnAnt.UseVisualStyleBackColor = True
        '
        'btnProx
        '
        Me.btnProx.Location = New System.Drawing.Point(322, 61)
        Me.btnProx.Name = "btnProx"
        Me.btnProx.Size = New System.Drawing.Size(32, 28)
        Me.btnProx.TabIndex = 25
        Me.btnProx.Text = ">"
        Me.btnProx.UseVisualStyleBackColor = True
        '
        'lblItens
        '
        Me.lblItens.AutoSize = True
        Me.lblItens.Location = New System.Drawing.Point(143, 22)
        Me.lblItens.Name = "lblItens"
        Me.lblItens.Size = New System.Drawing.Size(0, 20)
        Me.lblItens.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(55, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 20)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Descrição: "
        '
        'txtCustoUnitario
        '
        Me.txtCustoUnitario.Enabled = False
        Me.txtCustoUnitario.Location = New System.Drawing.Point(179, 47)
        Me.txtCustoUnitario.Name = "txtCustoUnitario"
        Me.txtCustoUnitario.Size = New System.Drawing.Size(100, 26)
        Me.txtCustoUnitario.TabIndex = 23
        '
        'txtDescricaoItem
        '
        Me.txtDescricaoItem.Enabled = False
        Me.txtDescricaoItem.Location = New System.Drawing.Point(179, 79)
        Me.txtDescricaoItem.Multiline = True
        Me.txtDescricaoItem.Name = "txtDescricaoItem"
        Me.txtDescricaoItem.Size = New System.Drawing.Size(137, 107)
        Me.txtDescricaoItem.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(55, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 20)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Custo Unitário: "
        '
        'gbFrigobar
        '
        Me.gbFrigobar.Controls.Add(Me.RbNao)
        Me.gbFrigobar.Controls.Add(Me.rbSim)
        Me.gbFrigobar.Controls.Add(Me.TextBox1)
        Me.gbFrigobar.Controls.Add(Me.TextBox2)
        Me.gbFrigobar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFrigobar.Location = New System.Drawing.Point(20, 262)
        Me.gbFrigobar.Name = "gbFrigobar"
        Me.gbFrigobar.Size = New System.Drawing.Size(250, 71)
        Me.gbFrigobar.TabIndex = 19
        Me.gbFrigobar.TabStop = False
        Me.gbFrigobar.Text = "Frigobar"
        '
        'RbNao
        '
        Me.RbNao.AutoSize = True
        Me.RbNao.Enabled = False
        Me.RbNao.Location = New System.Drawing.Point(145, 29)
        Me.RbNao.Name = "RbNao"
        Me.RbNao.Size = New System.Drawing.Size(56, 24)
        Me.RbNao.TabIndex = 1
        Me.RbNao.TabStop = True
        Me.RbNao.Text = "Não"
        Me.RbNao.UseVisualStyleBackColor = True
        '
        'rbSim
        '
        Me.rbSim.AutoSize = True
        Me.rbSim.Enabled = False
        Me.rbSim.Location = New System.Drawing.Point(50, 29)
        Me.rbSim.Name = "rbSim"
        Me.rbSim.Size = New System.Drawing.Size(54, 24)
        Me.rbSim.TabIndex = 0
        Me.rbSim.TabStop = True
        Me.rbSim.Text = "Sim"
        Me.rbSim.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 239)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(147, 20)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Camas de Solteiro: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 20)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Camas de Casal: "
        '
        'txtCamasSolteiro
        '
        Me.txtCamasSolteiro.Enabled = False
        Me.txtCamasSolteiro.Location = New System.Drawing.Point(173, 241)
        Me.txtCamasSolteiro.Name = "txtCamasSolteiro"
        Me.txtCamasSolteiro.Size = New System.Drawing.Size(100, 20)
        Me.txtCamasSolteiro.TabIndex = 15
        '
        'txtCamasCasal
        '
        Me.txtCamasCasal.Enabled = False
        Me.txtCamasCasal.Location = New System.Drawing.Point(173, 215)
        Me.txtCamasCasal.Name = "txtCamasCasal"
        Me.txtCamasCasal.Size = New System.Drawing.Size(100, 20)
        Me.txtCamasCasal.TabIndex = 14
        '
        'txtAndar
        '
        Me.txtAndar.Enabled = False
        Me.txtAndar.Location = New System.Drawing.Point(173, 189)
        Me.txtAndar.Name = "txtAndar"
        Me.txtAndar.Size = New System.Drawing.Size(100, 20)
        Me.txtAndar.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Andar: "
        '
        'txtNumero
        '
        Me.txtNumero.Enabled = False
        Me.txtNumero.Location = New System.Drawing.Point(172, 163)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Número:"
        '
        'txtValorDiaria
        '
        Me.txtValorDiaria.Enabled = False
        Me.txtValorDiaria.Location = New System.Drawing.Point(423, 45)
        Me.txtValorDiaria.Name = "txtValorDiaria"
        Me.txtValorDiaria.Size = New System.Drawing.Size(100, 20)
        Me.txtValorDiaria.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(297, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Valor da diária: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(297, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Consumo Total:"
        '
        'txtConsumoTotal
        '
        Me.txtConsumoTotal.Enabled = False
        Me.txtConsumoTotal.Location = New System.Drawing.Point(423, 19)
        Me.txtConsumoTotal.Name = "txtConsumoTotal"
        Me.txtConsumoTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtConsumoTotal.TabIndex = 4
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(81, 45)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 3
        '
        'txtNome
        '
        Me.txtNome.Enabled = False
        Me.txtNome.Location = New System.Drawing.Point(81, 19)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(100, 20)
        Me.txtNome.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "E-Mail: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nome: "
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(323, 9)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(180, 28)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Carregar Hospedagem"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(449, -118)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(137, 107)
        Me.TextBox1.TabIndex = 21
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(449, -150)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 26)
        Me.TextBox2.TabIndex = 23
        '
        'txtCpf
        '
        Me.txtCpf.Location = New System.Drawing.Point(88, 15)
        Me.txtCpf.Mask = "000.000.000-00"
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(155, 20)
        Me.txtCpf.TabIndex = 4
        '
        'Checkout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(710, 402)
        Me.Controls.Add(Me.txtCpf)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.pnlCheckout)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Checkout"
        Me.Text = "Checkout"
        Me.pnlCheckout.ResumeLayout(False)
        Me.pnlCheckout.PerformLayout()
        Me.gbQuarto.ResumeLayout(False)
        Me.gbQuarto.PerformLayout()
        Me.gbItensConsumidos.ResumeLayout(False)
        Me.gbItensConsumidos.PerformLayout()
        Me.gbFrigobar.ResumeLayout(False)
        Me.gbFrigobar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlCheckout As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCamasSolteiro As System.Windows.Forms.TextBox
    Friend WithEvents txtCamasCasal As System.Windows.Forms.TextBox
    Friend WithEvents txtAndar As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTipoQuarto As System.Windows.Forms.TextBox
    Friend WithEvents txtValorDiaria As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtConsumoTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents gbFrigobar As System.Windows.Forms.GroupBox
    Friend WithEvents RbNao As System.Windows.Forms.RadioButton
    Friend WithEvents rbSim As System.Windows.Forms.RadioButton
    Friend WithEvents txtCustoUnitario As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoItem As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents gbItensConsumidos As System.Windows.Forms.GroupBox
    Friend WithEvents lblItens As System.Windows.Forms.Label
    Friend WithEvents btnAnt As System.Windows.Forms.Button
    Friend WithEvents btnProx As System.Windows.Forms.Button
    Friend WithEvents gbQuarto As System.Windows.Forms.GroupBox
    Friend WithEvents txtDiaria As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnCheckout As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCpf As System.Windows.Forms.MaskedTextBox
End Class
