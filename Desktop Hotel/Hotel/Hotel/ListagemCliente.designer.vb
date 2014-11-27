<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListagemCliente
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListagemCliente))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpListagem = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tpEdicao = New System.Windows.Forms.TabPage()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtxtData = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mtxtCPF = New System.Windows.Forms.MaskedTextBox()
        Me.radFeminino = New System.Windows.Forms.RadioButton()
        Me.mtxtCelular = New System.Windows.Forms.MaskedTextBox()
        Me.radMasculino = New System.Windows.Forms.RadioButton()
        Me.mtxtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.btnNext = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.tpListagem.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpEdicao.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbLocalizacao.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tpListagem)
        Me.TabControl1.Controls.Add(Me.tpEdicao)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1348, 500)
        Me.TabControl1.TabIndex = 2
        '
        'tpListagem
        '
        Me.tpListagem.Controls.Add(Me.DataGridView1)
        Me.tpListagem.Location = New System.Drawing.Point(4, 22)
        Me.tpListagem.Name = "tpListagem"
        Me.tpListagem.Padding = New System.Windows.Forms.Padding(3)
        Me.tpListagem.Size = New System.Drawing.Size(1340, 474)
        Me.tpListagem.TabIndex = 0
        Me.tpListagem.Text = "Listagem"
        Me.tpListagem.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1330, 462)
        Me.DataGridView1.TabIndex = 0
        '
        'tpEdicao
        '
        Me.tpEdicao.Controls.Add(Me.btnSave)
        Me.tpEdicao.Controls.Add(Me.btnBack)
        Me.tpEdicao.Controls.Add(Me.GroupBox1)
        Me.tpEdicao.Controls.Add(Me.gbLocalizacao)
        Me.tpEdicao.Controls.Add(Me.btnNext)
        Me.tpEdicao.Location = New System.Drawing.Point(4, 22)
        Me.tpEdicao.Name = "tpEdicao"
        Me.tpEdicao.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEdicao.Size = New System.Drawing.Size(1340, 474)
        Me.tpEdicao.TabIndex = 1
        Me.tpEdicao.Text = "Edição"
        Me.tpEdicao.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(358, 227)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(69, 21)
        Me.btnSave.TabIndex = 41
        Me.btnSave.Text = "Salvar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(272, 227)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(37, 21)
        Me.btnBack.TabIndex = 40
        Me.btnBack.Text = "<"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 215)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados básicos"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(117, 26)
        Me.txtNome.MaxLength = 50
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(162, 20)
        Me.txtNome.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome completo:"
        '
        'mtxtData
        '
        Me.mtxtData.Location = New System.Drawing.Point(117, 52)
        Me.mtxtData.Mask = "00/00/0000"
        Me.mtxtData.Name = "mtxtData"
        Me.mtxtData.Size = New System.Drawing.Size(84, 20)
        Me.mtxtData.TabIndex = 34
        Me.mtxtData.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data de Nascimento:"
        '
        'mtxtCPF
        '
        Me.mtxtCPF.Location = New System.Drawing.Point(117, 179)
        Me.mtxtCPF.Mask = "000,000,000-00"
        Me.mtxtCPF.Name = "mtxtCPF"
        Me.mtxtCPF.ReadOnly = True
        Me.mtxtCPF.Size = New System.Drawing.Size(84, 20)
        Me.mtxtCPF.TabIndex = 33
        '
        'radFeminino
        '
        Me.radFeminino.AutoSize = True
        Me.radFeminino.Location = New System.Drawing.Point(212, 78)
        Me.radFeminino.Name = "radFeminino"
        Me.radFeminino.Size = New System.Drawing.Size(67, 17)
        Me.radFeminino.TabIndex = 4
        Me.radFeminino.Text = "Feminino"
        Me.radFeminino.UseVisualStyleBackColor = True
        '
        'mtxtCelular
        '
        Me.mtxtCelular.Location = New System.Drawing.Point(117, 153)
        Me.mtxtCelular.Mask = "(99) 90000-0000"
        Me.mtxtCelular.Name = "mtxtCelular"
        Me.mtxtCelular.Size = New System.Drawing.Size(92, 20)
        Me.mtxtCelular.TabIndex = 32
        '
        'radMasculino
        '
        Me.radMasculino.AutoSize = True
        Me.radMasculino.Checked = True
        Me.radMasculino.Location = New System.Drawing.Point(117, 78)
        Me.radMasculino.Name = "radMasculino"
        Me.radMasculino.Size = New System.Drawing.Size(73, 17)
        Me.radMasculino.TabIndex = 5
        Me.radMasculino.TabStop = True
        Me.radMasculino.Text = "Masculino"
        Me.radMasculino.UseVisualStyleBackColor = True
        '
        'mtxtTelefone
        '
        Me.mtxtTelefone.Location = New System.Drawing.Point(117, 127)
        Me.mtxtTelefone.Mask = "(99) 0000-0000"
        Me.mtxtTelefone.Name = "mtxtTelefone"
        Me.mtxtTelefone.Size = New System.Drawing.Size(84, 20)
        Me.mtxtTelefone.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Sexo:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(117, 101)
        Me.txtEmail.MaxLength = 60
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(162, 20)
        Me.txtEmail.TabIndex = 7
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(81, 182)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(30, 13)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "CPF:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "E-mail:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Telefone:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(69, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Celular:"
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
        Me.gbLocalizacao.Location = New System.Drawing.Point(318, 5)
        Me.gbLocalizacao.Name = "gbLocalizacao"
        Me.gbLocalizacao.Size = New System.Drawing.Size(380, 158)
        Me.gbLocalizacao.TabIndex = 37
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
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(315, 227)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(37, 21)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'ListagemCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 504)
        Me.Controls.Add(Me.TabControl1)
<<<<<<< HEAD
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ListagemCliente"
        Me.Text = "Listagem"
=======
        Me.Name = "ListagemCliente"
        Me.Text = "Listagem de Cliente"
>>>>>>> origin/master
        Me.TabControl1.ResumeLayout(False)
        Me.tpListagem.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpEdicao.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbLocalizacao.ResumeLayout(False)
        Me.gbLocalizacao.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpListagem As System.Windows.Forms.TabPage
    Friend WithEvents tpEdicao As System.Windows.Forms.TabPage
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mtxtData As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mtxtCPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents radFeminino As System.Windows.Forms.RadioButton
    Friend WithEvents mtxtCelular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents radMasculino As System.Windows.Forms.RadioButton
    Friend WithEvents mtxtTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents gbLocalizacao As System.Windows.Forms.GroupBox
    Friend WithEvents cbPaises As System.Windows.Forms.ComboBox
    Friend WithEvents cbUF As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
