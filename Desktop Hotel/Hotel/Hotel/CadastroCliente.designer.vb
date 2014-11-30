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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadastroCliente))
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
        Me.tbcCadastro = New System.Windows.Forms.TabControl()
        Me.pageCadastro = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbxEdicaoIdCliente = New System.Windows.Forms.ComboBox()
        Me.txtEdicaoNome = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtEdicaoData = New System.Windows.Forms.MaskedTextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtEdicaoCPF = New System.Windows.Forms.MaskedTextBox()
        Me.rbFeminino = New System.Windows.Forms.RadioButton()
        Me.txtEdicaoCelular = New System.Windows.Forms.MaskedTextBox()
        Me.rbMasculino = New System.Windows.Forms.RadioButton()
        Me.txtEdicaoTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtEdicaoEmail = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtEdicaoPais = New System.Windows.Forms.TextBox()
        Me.cbEdicaoUF = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtEdicaoCidade = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtEdicaoBairro = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtEdicaoEndereco = New System.Windows.Forms.TextBox()
        Me.pageDelete = New System.Windows.Forms.TabPage()
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtRemocaoNome = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbxRemocaoIdCliente = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtRemocaoData = New System.Windows.Forms.MaskedTextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtRemocaoCPF = New System.Windows.Forms.MaskedTextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.txtRemocaoCelular = New System.Windows.Forms.MaskedTextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.txtRemocaoTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtRemocaoEmail = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtRemocaoUF = New System.Windows.Forms.TextBox()
        Me.txtRemocaoPais = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtRemocaoCidade = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtRemocaoBairro = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.txtRemocaoEndereco = New System.Windows.Forms.TextBox()
        Me.gbLocalizacao.SuspendLayout()
        Me.gbPagamento.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tbcCadastro.SuspendLayout()
        Me.pageCadastro.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.pageDelete.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
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
        Me.gbLocalizacao.BackColor = System.Drawing.Color.Transparent
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
        Me.gbLocalizacao.Location = New System.Drawing.Point(316, 5)
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
        Me.cbPaises.MaxLength = 3
        Me.cbPaises.Name = "cbPaises"
        Me.cbPaises.Size = New System.Drawing.Size(189, 21)
        Me.cbPaises.TabIndex = 34
        '
        'cbUF
        '
        Me.cbUF.FormattingEnabled = True
        Me.cbUF.Location = New System.Drawing.Point(103, 128)
        Me.cbUF.MaxLength = 2
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
        Me.gbPagamento.BackColor = System.Drawing.Color.Transparent
        Me.gbPagamento.Controls.Add(Me.mtxtCodigoCartao)
        Me.gbPagamento.Controls.Add(Me.mtxtDataCartao)
        Me.gbPagamento.Controls.Add(Me.mtxtNumeroCartao)
        Me.gbPagamento.Controls.Add(Me.Label13)
        Me.gbPagamento.Controls.Add(Me.Label14)
        Me.gbPagamento.Controls.Add(Me.txtNomeCartao)
        Me.gbPagamento.Controls.Add(Me.Label15)
        Me.gbPagamento.Controls.Add(Me.Label16)
        Me.gbPagamento.Location = New System.Drawing.Point(316, 208)
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
        Me.btnCadastro.Location = New System.Drawing.Point(130, 311)
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
        Me.CheckBox1.Location = New System.Drawing.Point(325, 181)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(107, 17)
        Me.CheckBox1.TabIndex = 35
        Me.CheckBox1.Text = "Cartão de crédito"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
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
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 296)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados básicos"
        '
        'tbcCadastro
        '
        Me.tbcCadastro.Controls.Add(Me.pageCadastro)
        Me.tbcCadastro.Controls.Add(Me.TabPage2)
        Me.tbcCadastro.Controls.Add(Me.pageDelete)
        Me.tbcCadastro.Location = New System.Drawing.Point(12, 12)
        Me.tbcCadastro.Name = "tbcCadastro"
        Me.tbcCadastro.SelectedIndex = 0
        Me.tbcCadastro.Size = New System.Drawing.Size(714, 369)
        Me.tbcCadastro.TabIndex = 37
        '
        'pageCadastro
        '
        Me.pageCadastro.Controls.Add(Me.GroupBox1)
        Me.pageCadastro.Controls.Add(Me.gbLocalizacao)
        Me.pageCadastro.Controls.Add(Me.CheckBox1)
        Me.pageCadastro.Controls.Add(Me.gbPagamento)
        Me.pageCadastro.Controls.Add(Me.btnCadastro)
        Me.pageCadastro.Location = New System.Drawing.Point(4, 22)
        Me.pageCadastro.Name = "pageCadastro"
        Me.pageCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.pageCadastro.Size = New System.Drawing.Size(706, 343)
        Me.pageCadastro.TabIndex = 0
        Me.pageCadastro.Text = "Cadastro de Cliente"
        Me.pageCadastro.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnSave)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(706, 343)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Edição de Cliente"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(316, 230)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 41
        Me.btnSave.Text = "Salvar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.cbxEdicaoIdCliente)
        Me.GroupBox2.Controls.Add(Me.txtEdicaoNome)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.txtEdicaoData)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.txtEdicaoCPF)
        Me.GroupBox2.Controls.Add(Me.rbFeminino)
        Me.GroupBox2.Controls.Add(Me.txtEdicaoCelular)
        Me.GroupBox2.Controls.Add(Me.rbMasculino)
        Me.GroupBox2.Controls.Add(Me.txtEdicaoTelefone)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.txtEdicaoEmail)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(304, 247)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dados básicos"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(41, 21)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 13)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "ID do cliente:"
        '
        'cbxEdicaoIdCliente
        '
        Me.cbxEdicaoIdCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEdicaoIdCliente.FormattingEnabled = True
        Me.cbxEdicaoIdCliente.Location = New System.Drawing.Point(117, 18)
        Me.cbxEdicaoIdCliente.Name = "cbxEdicaoIdCliente"
        Me.cbxEdicaoIdCliente.Size = New System.Drawing.Size(73, 21)
        Me.cbxEdicaoIdCliente.TabIndex = 35
        '
        'txtEdicaoNome
        '
        Me.txtEdicaoNome.BackColor = System.Drawing.SystemColors.Window
        Me.txtEdicaoNome.Location = New System.Drawing.Point(117, 48)
        Me.txtEdicaoNome.MaxLength = 50
        Me.txtEdicaoNome.Name = "txtEdicaoNome"
        Me.txtEdicaoNome.Size = New System.Drawing.Size(162, 20)
        Me.txtEdicaoNome.TabIndex = 0
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(27, 51)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(84, 13)
        Me.Label24.TabIndex = 1
        Me.Label24.Text = "Nome completo:"
        '
        'txtEdicaoData
        '
        Me.txtEdicaoData.Location = New System.Drawing.Point(117, 74)
        Me.txtEdicaoData.Mask = "00/00/0000"
        Me.txtEdicaoData.Name = "txtEdicaoData"
        Me.txtEdicaoData.Size = New System.Drawing.Size(84, 20)
        Me.txtEdicaoData.TabIndex = 34
        Me.txtEdicaoData.ValidatingType = GetType(Date)
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(4, 77)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(107, 13)
        Me.Label25.TabIndex = 3
        Me.Label25.Text = "Data de Nascimento:"
        '
        'txtEdicaoCPF
        '
        Me.txtEdicaoCPF.Location = New System.Drawing.Point(117, 201)
        Me.txtEdicaoCPF.Mask = "000,000,000-00"
        Me.txtEdicaoCPF.Name = "txtEdicaoCPF"
        Me.txtEdicaoCPF.Size = New System.Drawing.Size(84, 20)
        Me.txtEdicaoCPF.TabIndex = 33
        '
        'rbFeminino
        '
        Me.rbFeminino.AutoSize = True
        Me.rbFeminino.Location = New System.Drawing.Point(212, 100)
        Me.rbFeminino.Name = "rbFeminino"
        Me.rbFeminino.Size = New System.Drawing.Size(67, 17)
        Me.rbFeminino.TabIndex = 4
        Me.rbFeminino.Text = "Feminino"
        Me.rbFeminino.UseVisualStyleBackColor = True
        '
        'txtEdicaoCelular
        '
        Me.txtEdicaoCelular.Location = New System.Drawing.Point(117, 175)
        Me.txtEdicaoCelular.Mask = "(99) 90000-0000"
        Me.txtEdicaoCelular.Name = "txtEdicaoCelular"
        Me.txtEdicaoCelular.Size = New System.Drawing.Size(92, 20)
        Me.txtEdicaoCelular.TabIndex = 32
        '
        'rbMasculino
        '
        Me.rbMasculino.AutoSize = True
        Me.rbMasculino.Checked = True
        Me.rbMasculino.Location = New System.Drawing.Point(117, 100)
        Me.rbMasculino.Name = "rbMasculino"
        Me.rbMasculino.Size = New System.Drawing.Size(73, 17)
        Me.rbMasculino.TabIndex = 5
        Me.rbMasculino.TabStop = True
        Me.rbMasculino.Text = "Masculino"
        Me.rbMasculino.UseVisualStyleBackColor = True
        '
        'txtEdicaoTelefone
        '
        Me.txtEdicaoTelefone.Location = New System.Drawing.Point(117, 149)
        Me.txtEdicaoTelefone.Mask = "(99) 0000-0000"
        Me.txtEdicaoTelefone.Name = "txtEdicaoTelefone"
        Me.txtEdicaoTelefone.Size = New System.Drawing.Size(84, 20)
        Me.txtEdicaoTelefone.TabIndex = 31
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(77, 102)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(34, 13)
        Me.Label26.TabIndex = 6
        Me.Label26.Text = "Sexo:"
        '
        'txtEdicaoEmail
        '
        Me.txtEdicaoEmail.Location = New System.Drawing.Point(117, 123)
        Me.txtEdicaoEmail.MaxLength = 60
        Me.txtEdicaoEmail.Name = "txtEdicaoEmail"
        Me.txtEdicaoEmail.Size = New System.Drawing.Size(162, 20)
        Me.txtEdicaoEmail.TabIndex = 7
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(70, 204)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(30, 13)
        Me.Label27.TabIndex = 29
        Me.Label27.Text = "CPF:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(73, 126)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(38, 13)
        Me.Label28.TabIndex = 8
        Me.Label28.Text = "E-mail:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(59, 152)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(52, 13)
        Me.Label29.TabIndex = 10
        Me.Label29.Text = "Telefone:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(69, 178)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(42, 13)
        Me.Label31.TabIndex = 12
        Me.Label31.Text = "Celular:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txtEdicaoPais)
        Me.GroupBox3.Controls.Add(Me.cbEdicaoUF)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.Label34)
        Me.GroupBox3.Controls.Add(Me.txtEdicaoCidade)
        Me.GroupBox3.Controls.Add(Me.Label35)
        Me.GroupBox3.Controls.Add(Me.txtEdicaoBairro)
        Me.GroupBox3.Controls.Add(Me.Label36)
        Me.GroupBox3.Controls.Add(Me.txtEdicaoEndereco)
        Me.GroupBox3.Location = New System.Drawing.Point(316, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(380, 158)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Localização"
        '
        'txtEdicaoPais
        '
        Me.txtEdicaoPais.Location = New System.Drawing.Point(103, 101)
        Me.txtEdicaoPais.Name = "txtEdicaoPais"
        Me.txtEdicaoPais.Size = New System.Drawing.Size(100, 20)
        Me.txtEdicaoPais.TabIndex = 34
        '
        'cbEdicaoUF
        '
        Me.cbEdicaoUF.FormattingEnabled = True
        Me.cbEdicaoUF.Location = New System.Drawing.Point(103, 128)
        Me.cbEdicaoUF.Name = "cbEdicaoUF"
        Me.cbEdicaoUF.Size = New System.Drawing.Size(51, 21)
        Me.cbEdicaoUF.TabIndex = 33
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(73, 131)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(24, 13)
        Me.Label32.TabIndex = 32
        Me.Label32.Text = "UF:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(65, 105)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(32, 13)
        Me.Label33.TabIndex = 31
        Me.Label33.Text = "País:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(54, 79)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(43, 13)
        Me.Label34.TabIndex = 29
        Me.Label34.Text = "Cidade:"
        '
        'txtEdicaoCidade
        '
        Me.txtEdicaoCidade.Location = New System.Drawing.Point(103, 76)
        Me.txtEdicaoCidade.Name = "txtEdicaoCidade"
        Me.txtEdicaoCidade.Size = New System.Drawing.Size(189, 20)
        Me.txtEdicaoCidade.TabIndex = 28
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(60, 53)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(37, 13)
        Me.Label35.TabIndex = 27
        Me.Label35.Text = "Bairro:"
        '
        'txtEdicaoBairro
        '
        Me.txtEdicaoBairro.Location = New System.Drawing.Point(103, 50)
        Me.txtEdicaoBairro.Name = "txtEdicaoBairro"
        Me.txtEdicaoBairro.Size = New System.Drawing.Size(189, 20)
        Me.txtEdicaoBairro.TabIndex = 26
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(41, 27)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(56, 13)
        Me.Label36.TabIndex = 25
        Me.Label36.Text = "Endereço:"
        '
        'txtEdicaoEndereco
        '
        Me.txtEdicaoEndereco.Location = New System.Drawing.Point(103, 24)
        Me.txtEdicaoEndereco.Name = "txtEdicaoEndereco"
        Me.txtEdicaoEndereco.Size = New System.Drawing.Size(262, 20)
        Me.txtEdicaoEndereco.TabIndex = 24
        '
        'pageDelete
        '
        Me.pageDelete.Controls.Add(Me.btnRemover)
        Me.pageDelete.Controls.Add(Me.GroupBox4)
        Me.pageDelete.Controls.Add(Me.GroupBox5)
        Me.pageDelete.Location = New System.Drawing.Point(4, 22)
        Me.pageDelete.Name = "pageDelete"
        Me.pageDelete.Padding = New System.Windows.Forms.Padding(3)
        Me.pageDelete.Size = New System.Drawing.Size(706, 343)
        Me.pageDelete.TabIndex = 2
        Me.pageDelete.Text = "Remoção de Cliente"
        Me.pageDelete.UseVisualStyleBackColor = True
        '
        'btnRemover
        '
        Me.btnRemover.Location = New System.Drawing.Point(316, 230)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(75, 23)
        Me.btnRemover.TabIndex = 44
        Me.btnRemover.Text = "Remover"
        Me.btnRemover.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.txtRemocaoNome)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.cbxRemocaoIdCliente)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.txtRemocaoData)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.txtRemocaoCPF)
        Me.GroupBox4.Controls.Add(Me.RadioButton1)
        Me.GroupBox4.Controls.Add(Me.txtRemocaoCelular)
        Me.GroupBox4.Controls.Add(Me.RadioButton2)
        Me.GroupBox4.Controls.Add(Me.txtRemocaoTelefone)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.txtRemocaoEmail)
        Me.GroupBox4.Controls.Add(Me.Label30)
        Me.GroupBox4.Controls.Add(Me.Label37)
        Me.GroupBox4.Controls.Add(Me.Label38)
        Me.GroupBox4.Controls.Add(Me.Label39)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(304, 247)
        Me.GroupBox4.TabIndex = 43
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dados básicos"
        '
        'txtRemocaoNome
        '
        Me.txtRemocaoNome.Location = New System.Drawing.Point(117, 49)
        Me.txtRemocaoNome.Name = "txtRemocaoNome"
        Me.txtRemocaoNome.ReadOnly = True
        Me.txtRemocaoNome.Size = New System.Drawing.Size(162, 20)
        Me.txtRemocaoNome.TabIndex = 37
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(41, 21)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 13)
        Me.Label20.TabIndex = 36
        Me.Label20.Text = "ID do cliente:"
        '
        'cbxRemocaoIdCliente
        '
        Me.cbxRemocaoIdCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRemocaoIdCliente.FormattingEnabled = True
        Me.cbxRemocaoIdCliente.Location = New System.Drawing.Point(117, 18)
        Me.cbxRemocaoIdCliente.Name = "cbxRemocaoIdCliente"
        Me.cbxRemocaoIdCliente.Size = New System.Drawing.Size(73, 21)
        Me.cbxRemocaoIdCliente.TabIndex = 35
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(27, 51)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(84, 13)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Nome completo:"
        '
        'txtRemocaoData
        '
        Me.txtRemocaoData.Location = New System.Drawing.Point(117, 74)
        Me.txtRemocaoData.Mask = "00/00/0000"
        Me.txtRemocaoData.Name = "txtRemocaoData"
        Me.txtRemocaoData.ReadOnly = True
        Me.txtRemocaoData.Size = New System.Drawing.Size(84, 20)
        Me.txtRemocaoData.TabIndex = 34
        Me.txtRemocaoData.ValidatingType = GetType(Date)
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(4, 77)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(107, 13)
        Me.Label22.TabIndex = 3
        Me.Label22.Text = "Data de Nascimento:"
        '
        'txtRemocaoCPF
        '
        Me.txtRemocaoCPF.Location = New System.Drawing.Point(117, 201)
        Me.txtRemocaoCPF.Mask = "000,000,000-00"
        Me.txtRemocaoCPF.Name = "txtRemocaoCPF"
        Me.txtRemocaoCPF.ReadOnly = True
        Me.txtRemocaoCPF.Size = New System.Drawing.Size(84, 20)
        Me.txtRemocaoCPF.TabIndex = 33
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Enabled = False
        Me.RadioButton1.Location = New System.Drawing.Point(212, 100)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(67, 17)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.Text = "Feminino"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'txtRemocaoCelular
        '
        Me.txtRemocaoCelular.Location = New System.Drawing.Point(117, 175)
        Me.txtRemocaoCelular.Mask = "(99) 90000-0000"
        Me.txtRemocaoCelular.Name = "txtRemocaoCelular"
        Me.txtRemocaoCelular.ReadOnly = True
        Me.txtRemocaoCelular.Size = New System.Drawing.Size(92, 20)
        Me.txtRemocaoCelular.TabIndex = 32
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Enabled = False
        Me.RadioButton2.Location = New System.Drawing.Point(117, 100)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(73, 17)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Masculino"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'txtRemocaoTelefone
        '
        Me.txtRemocaoTelefone.Location = New System.Drawing.Point(117, 149)
        Me.txtRemocaoTelefone.Mask = "(99) 0000-0000"
        Me.txtRemocaoTelefone.Name = "txtRemocaoTelefone"
        Me.txtRemocaoTelefone.ReadOnly = True
        Me.txtRemocaoTelefone.Size = New System.Drawing.Size(84, 20)
        Me.txtRemocaoTelefone.TabIndex = 31
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(77, 102)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(34, 13)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "Sexo:"
        '
        'txtRemocaoEmail
        '
        Me.txtRemocaoEmail.Location = New System.Drawing.Point(117, 123)
        Me.txtRemocaoEmail.MaxLength = 60
        Me.txtRemocaoEmail.Name = "txtRemocaoEmail"
        Me.txtRemocaoEmail.ReadOnly = True
        Me.txtRemocaoEmail.Size = New System.Drawing.Size(162, 20)
        Me.txtRemocaoEmail.TabIndex = 7
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(70, 204)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(30, 13)
        Me.Label30.TabIndex = 29
        Me.Label30.Text = "CPF:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(73, 126)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(38, 13)
        Me.Label37.TabIndex = 8
        Me.Label37.Text = "E-mail:"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(59, 152)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(52, 13)
        Me.Label38.TabIndex = 10
        Me.Label38.Text = "Telefone:"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(69, 178)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(42, 13)
        Me.Label39.TabIndex = 12
        Me.Label39.Text = "Celular:"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.txtRemocaoUF)
        Me.GroupBox5.Controls.Add(Me.txtRemocaoPais)
        Me.GroupBox5.Controls.Add(Me.Label40)
        Me.GroupBox5.Controls.Add(Me.Label41)
        Me.GroupBox5.Controls.Add(Me.Label42)
        Me.GroupBox5.Controls.Add(Me.txtRemocaoCidade)
        Me.GroupBox5.Controls.Add(Me.Label43)
        Me.GroupBox5.Controls.Add(Me.txtRemocaoBairro)
        Me.GroupBox5.Controls.Add(Me.Label44)
        Me.GroupBox5.Controls.Add(Me.txtRemocaoEndereco)
        Me.GroupBox5.Location = New System.Drawing.Point(316, 5)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(380, 158)
        Me.GroupBox5.TabIndex = 42
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Localização"
        '
        'txtRemocaoUF
        '
        Me.txtRemocaoUF.Location = New System.Drawing.Point(103, 127)
        Me.txtRemocaoUF.Name = "txtRemocaoUF"
        Me.txtRemocaoUF.ReadOnly = True
        Me.txtRemocaoUF.Size = New System.Drawing.Size(47, 20)
        Me.txtRemocaoUF.TabIndex = 35
        '
        'txtRemocaoPais
        '
        Me.txtRemocaoPais.Location = New System.Drawing.Point(103, 101)
        Me.txtRemocaoPais.Name = "txtRemocaoPais"
        Me.txtRemocaoPais.ReadOnly = True
        Me.txtRemocaoPais.Size = New System.Drawing.Size(100, 20)
        Me.txtRemocaoPais.TabIndex = 34
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(73, 131)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(24, 13)
        Me.Label40.TabIndex = 32
        Me.Label40.Text = "UF:"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(65, 105)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(32, 13)
        Me.Label41.TabIndex = 31
        Me.Label41.Text = "País:"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(54, 79)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(43, 13)
        Me.Label42.TabIndex = 29
        Me.Label42.Text = "Cidade:"
        '
        'txtRemocaoCidade
        '
        Me.txtRemocaoCidade.Location = New System.Drawing.Point(103, 76)
        Me.txtRemocaoCidade.Name = "txtRemocaoCidade"
        Me.txtRemocaoCidade.ReadOnly = True
        Me.txtRemocaoCidade.Size = New System.Drawing.Size(189, 20)
        Me.txtRemocaoCidade.TabIndex = 28
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(60, 53)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(37, 13)
        Me.Label43.TabIndex = 27
        Me.Label43.Text = "Bairro:"
        '
        'txtRemocaoBairro
        '
        Me.txtRemocaoBairro.Location = New System.Drawing.Point(103, 50)
        Me.txtRemocaoBairro.Name = "txtRemocaoBairro"
        Me.txtRemocaoBairro.ReadOnly = True
        Me.txtRemocaoBairro.Size = New System.Drawing.Size(189, 20)
        Me.txtRemocaoBairro.TabIndex = 26
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(41, 27)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(56, 13)
        Me.Label44.TabIndex = 25
        Me.Label44.Text = "Endereço:"
        '
        'txtRemocaoEndereco
        '
        Me.txtRemocaoEndereco.Location = New System.Drawing.Point(103, 24)
        Me.txtRemocaoEndereco.Name = "txtRemocaoEndereco"
        Me.txtRemocaoEndereco.ReadOnly = True
        Me.txtRemocaoEndereco.Size = New System.Drawing.Size(262, 20)
        Me.txtRemocaoEndereco.TabIndex = 24
        '
        'CadastroCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(732, 390)
        Me.Controls.Add(Me.tbcCadastro)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CadastroCliente"
        Me.Text = "Mountain Ville - Cliente"
        Me.gbLocalizacao.ResumeLayout(False)
        Me.gbLocalizacao.PerformLayout()
        Me.gbPagamento.ResumeLayout(False)
        Me.gbPagamento.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tbcCadastro.ResumeLayout(False)
        Me.pageCadastro.ResumeLayout(False)
        Me.pageCadastro.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.pageDelete.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents tbcCadastro As System.Windows.Forms.TabControl
    Friend WithEvents pageCadastro As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEdicaoNome As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtEdicaoData As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtEdicaoCPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents rbFeminino As System.Windows.Forms.RadioButton
    Friend WithEvents txtEdicaoCelular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents rbMasculino As System.Windows.Forms.RadioButton
    Friend WithEvents txtEdicaoTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtEdicaoEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbEdicaoUF As System.Windows.Forms.ComboBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtEdicaoCidade As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtEdicaoBairro As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtEdicaoEndereco As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cbxEdicaoIdCliente As System.Windows.Forms.ComboBox
    Friend WithEvents txtEdicaoPais As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents pageDelete As System.Windows.Forms.TabPage
    Friend WithEvents btnRemover As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cbxRemocaoIdCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtRemocaoData As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtRemocaoCPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents txtRemocaoCelular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents txtRemocaoTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtRemocaoEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRemocaoPais As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents txtRemocaoCidade As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents txtRemocaoBairro As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents txtRemocaoEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtRemocaoNome As System.Windows.Forms.TextBox
    Friend WithEvents txtRemocaoUF As System.Windows.Forms.TextBox
End Class
