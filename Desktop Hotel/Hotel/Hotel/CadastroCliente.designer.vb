<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroCliente
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
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radFeminino = New System.Windows.Forms.RadioButton()
        Me.radMasculino = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.gbLocalizacao = New System.Windows.Forms.GroupBox()
        Me.cbPaises = New System.Windows.Forms.ComboBox()
        Me.cbUF = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.gbPagamento = New System.Windows.Forms.GroupBox()
        Me.mtxtCodigoCartao = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtDataCartao = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtNumeroCartao = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNomeCartao = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnCadastro = New System.Windows.Forms.Button()
        Me.mtxtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtCelular = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtCPF = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtData = New System.Windows.Forms.MaskedTextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.gbLocalizacao.SuspendLayout()
        Me.gbPagamento.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.SystemColors.Window
        Me.txtNome.Location = New System.Drawing.Point(117, 48)
        Me.txtNome.MaxLength = 50
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(162, 20)
        Me.txtNome.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome completo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data de Nascimento:"
        '
        'radFeminino
        '
        Me.radFeminino.AutoSize = True
        Me.radFeminino.Location = New System.Drawing.Point(212, 100)
        Me.radFeminino.Name = "radFeminino"
        Me.radFeminino.Size = New System.Drawing.Size(67, 17)
        Me.radFeminino.TabIndex = 4
        Me.radFeminino.Text = "Feminino"
        Me.radFeminino.UseVisualStyleBackColor = True
        '
        'radMasculino
        '
        Me.radMasculino.AutoSize = True
        Me.radMasculino.Checked = True
        Me.radMasculino.Location = New System.Drawing.Point(117, 100)
        Me.radMasculino.Name = "radMasculino"
        Me.radMasculino.Size = New System.Drawing.Size(73, 17)
        Me.radMasculino.TabIndex = 5
        Me.radMasculino.TabStop = True
        Me.radMasculino.Text = "Masculino"
        Me.radMasculino.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Sexo:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(117, 123)
        Me.txtEmail.MaxLength = 60
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(162, 20)
        Me.txtEmail.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "E-mail:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Telefone:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(69, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Celular:"
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(118, 202)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtSenha.Size = New System.Drawing.Size(136, 20)
        Me.txtSenha.TabIndex = 24
        '
        'gbLocalizacao
        '
        Me.gbLocalizacao.Controls.Add(Me.cbPaises)
        Me.gbLocalizacao.Controls.Add(Me.cbUF)
        Me.gbLocalizacao.Controls.Add(Me.Label11)
        Me.gbLocalizacao.Controls.Add(Me.Label10)
        Me.gbLocalizacao.Controls.Add(Me.Label9)
        Me.gbLocalizacao.Controls.Add(Me.txtCidade)
        Me.gbLocalizacao.Controls.Add(Me.Label8)
        Me.gbLocalizacao.Controls.Add(Me.txtBairro)
        Me.gbLocalizacao.Controls.Add(Me.Label7)
        Me.gbLocalizacao.Controls.Add(Me.txtEndereco)
        Me.gbLocalizacao.Location = New System.Drawing.Point(322, 11)
        Me.gbLocalizacao.Name = "gbLocalizacao"
        Me.gbLocalizacao.Size = New System.Drawing.Size(380, 158)
        Me.gbLocalizacao.TabIndex = 25
        Me.gbLocalizacao.TabStop = False
        Me.gbLocalizacao.Text = "Localização"
        '
        'cbPaises
        '
        Me.cbPaises.FormattingEnabled = True
        Me.cbPaises.Location = New System.Drawing.Point(103, 102)
        Me.cbPaises.Name = "cbPaises"
        Me.cbPaises.Size = New System.Drawing.Size(189, 21)
        Me.cbPaises.TabIndex = 34
        '
        'cbUF
        '
        Me.cbUF.FormattingEnabled = True
        Me.cbUF.Location = New System.Drawing.Point(103, 128)
        Me.cbUF.Name = "cbUF"
        Me.cbUF.Size = New System.Drawing.Size(51, 21)
        Me.cbUF.TabIndex = 33
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(73, 131)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "UF:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(65, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "País:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(54, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Cidade:"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(103, 76)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(189, 20)
        Me.txtCidade.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(60, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Bairro:"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(103, 50)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(189, 20)
        Me.txtBairro.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Endereço:"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(103, 24)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(262, 20)
        Me.txtEndereco.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(70, 204)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Senha:"
        '
        'gbPagamento
        '
        Me.gbPagamento.Controls.Add(Me.mtxtCodigoCartao)
        Me.gbPagamento.Controls.Add(Me.mtxtDataCartao)
        Me.gbPagamento.Controls.Add(Me.mtxtNumeroCartao)
        Me.gbPagamento.Controls.Add(Me.Label13)
        Me.gbPagamento.Controls.Add(Me.Label14)
        Me.gbPagamento.Controls.Add(Me.txtNomeCartao)
        Me.gbPagamento.Controls.Add(Me.Label15)
        Me.gbPagamento.Controls.Add(Me.Label16)
        Me.gbPagamento.Location = New System.Drawing.Point(322, 214)
        Me.gbPagamento.Name = "gbPagamento"
        Me.gbPagamento.Size = New System.Drawing.Size(347, 131)
        Me.gbPagamento.TabIndex = 27
        Me.gbPagamento.TabStop = False
        Me.gbPagamento.Text = "Pagamento - Cartão de Crédito"
        '
        'mtxtCodigoCartao
        '
        Me.mtxtCodigoCartao.Location = New System.Drawing.Point(170, 48)
        Me.mtxtCodigoCartao.Mask = "000"
        Me.mtxtCodigoCartao.Name = "mtxtCodigoCartao"
        Me.mtxtCodigoCartao.Size = New System.Drawing.Size(136, 20)
        Me.mtxtCodigoCartao.TabIndex = 37
        '
        'mtxtDataCartao
        '
        Me.mtxtDataCartao.Location = New System.Drawing.Point(170, 100)
        Me.mtxtDataCartao.Mask = "00/0099"
        Me.mtxtDataCartao.Name = "mtxtDataCartao"
        Me.mtxtDataCartao.Size = New System.Drawing.Size(136, 20)
        Me.mtxtDataCartao.TabIndex = 36
        '
        'mtxtNumeroCartao
        '
        Me.mtxtNumeroCartao.Location = New System.Drawing.Point(170, 22)
        Me.mtxtNumeroCartao.Mask = "0000 0000 0000 0000"
        Me.mtxtNumeroCartao.Name = "mtxtNumeroCartao"
        Me.mtxtNumeroCartao.Size = New System.Drawing.Size(136, 20)
        Me.mtxtNumeroCartao.TabIndex = 35
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(83, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 13)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Nome do Titular:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(77, 103)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Data de validade:"
        '
        'txtNomeCartao
        '
        Me.txtNomeCartao.Location = New System.Drawing.Point(170, 74)
        Me.txtNomeCartao.Name = "txtNomeCartao"
        Me.txtNomeCartao.Size = New System.Drawing.Size(136, 20)
        Me.txtNomeCartao.TabIndex = 31
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(57, 51)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 13)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Código de segurança:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(23, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(145, 13)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Número do cartão de crédito:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(81, 230)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(30, 13)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "CPF:"
        '
        'btnCadastro
        '
        Me.btnCadastro.Location = New System.Drawing.Point(127, 317)
        Me.btnCadastro.Name = "btnCadastro"
        Me.btnCadastro.Size = New System.Drawing.Size(75, 23)
        Me.btnCadastro.TabIndex = 30
        Me.btnCadastro.Text = "Cadastrar"
        Me.btnCadastro.UseVisualStyleBackColor = True
        '
        'mtxtTelefone
        '
        Me.mtxtTelefone.Location = New System.Drawing.Point(117, 149)
        Me.mtxtTelefone.Mask = "(99) 0000-0000"
        Me.mtxtTelefone.Name = "mtxtTelefone"
        Me.mtxtTelefone.Size = New System.Drawing.Size(84, 20)
        Me.mtxtTelefone.TabIndex = 31
        '
        'mtxtCelular
        '
        Me.mtxtCelular.Location = New System.Drawing.Point(117, 175)
        Me.mtxtCelular.Mask = "(99) 90000-0000"
        Me.mtxtCelular.Name = "mtxtCelular"
        Me.mtxtCelular.Size = New System.Drawing.Size(92, 20)
        Me.mtxtCelular.TabIndex = 32
        '
        'mtxtCPF
        '
        Me.mtxtCPF.Location = New System.Drawing.Point(117, 227)
        Me.mtxtCPF.Mask = "000,000,000-00"
        Me.mtxtCPF.Name = "mtxtCPF"
        Me.mtxtCPF.Size = New System.Drawing.Size(84, 20)
        Me.mtxtCPF.TabIndex = 33
        '
        'mtxtData
        '
        Me.mtxtData.Location = New System.Drawing.Point(117, 74)
        Me.mtxtData.Mask = "00/00/0000"
        Me.mtxtData.Name = "mtxtData"
        Me.mtxtData.Size = New System.Drawing.Size(84, 20)
        Me.mtxtData.TabIndex = 34
        Me.mtxtData.ValidatingType = GetType(Date)
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(322, 187)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(107, 17)
        Me.CheckBox1.TabIndex = 35
        Me.CheckBox1.Text = "Cartão de crédito"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.mtxtData)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.mtxtCPF)
        Me.GroupBox1.Controls.Add(Me.radFeminino)
        Me.GroupBox1.Controls.Add(Me.mtxtCelular)
        Me.GroupBox1.Controls.Add(Me.radMasculino)
        Me.GroupBox1.Controls.Add(Me.mtxtTelefone)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtSenha)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 296)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados básicos"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(201, 77)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(11, 13)
        Me.Label20.TabIndex = 37
        Me.Label20.Text = "*"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(198, 230)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(11, 13)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "*"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(277, 51)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(11, 13)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "*"
        '
        'CadastroCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 361)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnCadastro)
        Me.Controls.Add(Me.gbPagamento)
        Me.Controls.Add(Me.gbLocalizacao)
        Me.Name = "CadastroCliente"
        Me.Text = "CadastroCliente"
        Me.gbLocalizacao.ResumeLayout(False)
        Me.gbLocalizacao.PerformLayout()
        Me.gbPagamento.ResumeLayout(False)
        Me.gbPagamento.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents radFeminino As System.Windows.Forms.RadioButton
    Friend WithEvents radMasculino As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents gbLocalizacao As System.Windows.Forms.GroupBox
    Friend WithEvents cbUF As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents gbPagamento As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNomeCartao As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnCadastro As System.Windows.Forms.Button
    Friend WithEvents mtxtTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxtCelular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxtCPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxtData As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cbPaises As System.Windows.Forms.ComboBox
    Friend WithEvents mtxtCodigoCartao As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxtDataCartao As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxtNumeroCartao As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
End Class
