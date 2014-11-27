<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroApartamentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadastroApartamentos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxTipoApartamento = New System.Windows.Forms.ComboBox()
        Me.HTipoApartamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HosPDeirosDataSet = New Hotel.HosPDeirosDataSet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.HTipoApartamentoTableAdapter = New Hotel.HosPDeirosDataSetTableAdapters.hTipoApartamentoTableAdapter()
        Me.btnIncluir = New System.Windows.Forms.Button()
        Me.gbFrigobar = New System.Windows.Forms.GroupBox()
        Me.rbSim = New System.Windows.Forms.RadioButton()
        Me.rbNao = New System.Windows.Forms.RadioButton()
        Me.tcApartamento = New System.Windows.Forms.TabControl()
        Me.tbCadastro = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCamaSolteiro = New System.Windows.Forms.TextBox()
        Me.txtCamaCasal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAndar = New System.Windows.Forms.TextBox()
        Me.tbEdicao = New System.Windows.Forms.TabPage()
        Me.pnlEdicao = New System.Windows.Forms.Panel()
        Me.txtEdicaoAndar = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtEdicaoCamaSolteiro = New System.Windows.Forms.TextBox()
        Me.txtEdicaoCamaCasal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnEdicaoSalvar = New System.Windows.Forms.Button()
        Me.gbEdicaoFrigobar = New System.Windows.Forms.GroupBox()
        Me.rbEdicaoNao = New System.Windows.Forms.RadioButton()
        Me.rbEdicaoSim = New System.Windows.Forms.RadioButton()
        Me.cbEdicaoTipoApartamento = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxEdicaoTipoApartamento = New System.Windows.Forms.ComboBox()
        Me.HApartamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HosPDeirosDataSet1 = New Hotel.HosPDeirosDataSet1()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbRemoçãoApartamento = New System.Windows.Forms.TabPage()
        Me.cbxRemocaoApartamento = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.pnlRemocao = New System.Windows.Forms.Panel()
        Me.txtRemocaoAndar = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtRemocaoTipoApartamento = New System.Windows.Forms.TextBox()
        Me.txtremocaoCamaSolteiro = New System.Windows.Forms.TextBox()
        Me.txtRemocaoCamaCasal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnRemoverApartamento = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.gbRemocaoFrigobar = New System.Windows.Forms.GroupBox()
        Me.rbRemocaoNao = New System.Windows.Forms.RadioButton()
        Me.rbRemocaoSim = New System.Windows.Forms.RadioButton()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tbListagem = New System.Windows.Forms.TabPage()
        Me.HApartamentoTableAdapter = New Hotel.HosPDeirosDataSet1TableAdapters.hApartamentoTableAdapter()
        CType(Me.HTipoApartamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HosPDeirosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFrigobar.SuspendLayout()
        Me.tcApartamento.SuspendLayout()
        Me.tbCadastro.SuspendLayout()
        Me.tbEdicao.SuspendLayout()
        Me.pnlEdicao.SuspendLayout()
        Me.gbEdicaoFrigobar.SuspendLayout()
        CType(Me.HApartamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HosPDeirosDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbRemoçãoApartamento.SuspendLayout()
        Me.pnlRemocao.SuspendLayout()
        Me.gbRemocaoFrigobar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Número: "
        '
        'cbxTipoApartamento
        '
        Me.cbxTipoApartamento.DataSource = Me.HTipoApartamentoBindingSource
        Me.cbxTipoApartamento.DisplayMember = "tipo"
        Me.cbxTipoApartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoApartamento.FormattingEnabled = True
        Me.cbxTipoApartamento.Location = New System.Drawing.Point(192, 11)
        Me.cbxTipoApartamento.Name = "cbxTipoApartamento"
        Me.cbxTipoApartamento.Size = New System.Drawing.Size(121, 21)
        Me.cbxTipoApartamento.TabIndex = 6
        Me.cbxTipoApartamento.ValueMember = "idTipoApartamento"
        '
        'HTipoApartamentoBindingSource
        '
        Me.HTipoApartamentoBindingSource.DataMember = "hTipoApartamento"
        Me.HTipoApartamentoBindingSource.DataSource = Me.HosPDeirosDataSet
        '
        'HosPDeirosDataSet
        '
        Me.HosPDeirosDataSet.DataSetName = "HosPDeirosDataSet"
        Me.HosPDeirosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tipo do Apartamento: "
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(192, 41)
        Me.txtNumero.MaxLength = 3
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero.TabIndex = 3
        '
        'HTipoApartamentoTableAdapter
        '
        Me.HTipoApartamentoTableAdapter.ClearBeforeFill = True
        '
        'btnIncluir
        '
        Me.btnIncluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncluir.Location = New System.Drawing.Point(171, 226)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(161, 30)
        Me.btnIncluir.TabIndex = 9
        Me.btnIncluir.Text = "Incluir Apartamento"
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'gbFrigobar
        '
        Me.gbFrigobar.Controls.Add(Me.rbSim)
        Me.gbFrigobar.Controls.Add(Me.rbNao)
        Me.gbFrigobar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFrigobar.Location = New System.Drawing.Point(9, 149)
        Me.gbFrigobar.Name = "gbFrigobar"
        Me.gbFrigobar.Size = New System.Drawing.Size(323, 71)
        Me.gbFrigobar.TabIndex = 10
        Me.gbFrigobar.TabStop = False
        Me.gbFrigobar.Text = "Frigobar"
        '
        'rbSim
        '
        Me.rbSim.AutoSize = True
        Me.rbSim.Location = New System.Drawing.Point(79, 25)
        Me.rbSim.Name = "rbSim"
        Me.rbSim.Size = New System.Drawing.Size(54, 24)
        Me.rbSim.TabIndex = 1
        Me.rbSim.TabStop = True
        Me.rbSim.Text = "Sim"
        Me.rbSim.UseVisualStyleBackColor = True
        '
        'rbNao
        '
        Me.rbNao.AutoSize = True
        Me.rbNao.Location = New System.Drawing.Point(183, 25)
        Me.rbNao.Name = "rbNao"
        Me.rbNao.Size = New System.Drawing.Size(56, 24)
        Me.rbNao.TabIndex = 0
        Me.rbNao.TabStop = True
        Me.rbNao.Text = "Não"
        Me.rbNao.UseVisualStyleBackColor = True
        '
        'tcApartamento
        '
        Me.tcApartamento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcApartamento.Controls.Add(Me.tbCadastro)
        Me.tcApartamento.Controls.Add(Me.tbEdicao)
        Me.tcApartamento.Controls.Add(Me.tbRemoçãoApartamento)
        Me.tcApartamento.Controls.Add(Me.tbListagem)
        Me.tcApartamento.Location = New System.Drawing.Point(12, 12)
        Me.tcApartamento.Name = "tcApartamento"
        Me.tcApartamento.SelectedIndex = 0
        Me.tcApartamento.Size = New System.Drawing.Size(354, 318)
        Me.tcApartamento.TabIndex = 0
        '
        'tbCadastro
        '
        Me.tbCadastro.Controls.Add(Me.Label9)
        Me.tbCadastro.Controls.Add(Me.txtCamaSolteiro)
        Me.tbCadastro.Controls.Add(Me.txtCamaCasal)
        Me.tbCadastro.Controls.Add(Me.Label8)
        Me.tbCadastro.Controls.Add(Me.Label4)
        Me.tbCadastro.Controls.Add(Me.cbxTipoApartamento)
        Me.tbCadastro.Controls.Add(Me.Label2)
        Me.tbCadastro.Controls.Add(Me.Label1)
        Me.tbCadastro.Controls.Add(Me.btnIncluir)
        Me.tbCadastro.Controls.Add(Me.txtAndar)
        Me.tbCadastro.Controls.Add(Me.txtNumero)
        Me.tbCadastro.Controls.Add(Me.gbFrigobar)
        Me.tbCadastro.Location = New System.Drawing.Point(4, 22)
        Me.tbCadastro.Name = "tbCadastro"
        Me.tbCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCadastro.Size = New System.Drawing.Size(346, 292)
        Me.tbCadastro.TabIndex = 0
        Me.tbCadastro.Text = "Cadastro de Apartamento"
        Me.tbCadastro.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(25, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 20)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Camas de Solteiro: "
        '
        'txtCamaSolteiro
        '
        Me.txtCamaSolteiro.Location = New System.Drawing.Point(192, 123)
        Me.txtCamaSolteiro.MaxLength = 1
        Me.txtCamaSolteiro.Name = "txtCamaSolteiro"
        Me.txtCamaSolteiro.Size = New System.Drawing.Size(100, 20)
        Me.txtCamaSolteiro.TabIndex = 16
        '
        'txtCamaCasal
        '
        Me.txtCamaCasal.Location = New System.Drawing.Point(192, 97)
        Me.txtCamaCasal.MaxLength = 1
        Me.txtCamaCasal.Name = "txtCamaCasal"
        Me.txtCamaCasal.Size = New System.Drawing.Size(100, 20)
        Me.txtCamaCasal.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Camas de Casal: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Andar: "
        '
        'txtAndar
        '
        Me.txtAndar.Location = New System.Drawing.Point(192, 71)
        Me.txtAndar.MaxLength = 2
        Me.txtAndar.Name = "txtAndar"
        Me.txtAndar.Size = New System.Drawing.Size(100, 20)
        Me.txtAndar.TabIndex = 4
        '
        'tbEdicao
        '
        Me.tbEdicao.Controls.Add(Me.pnlEdicao)
        Me.tbEdicao.Controls.Add(Me.cbxEdicaoTipoApartamento)
        Me.tbEdicao.Controls.Add(Me.Label5)
        Me.tbEdicao.Location = New System.Drawing.Point(4, 22)
        Me.tbEdicao.Name = "tbEdicao"
        Me.tbEdicao.Padding = New System.Windows.Forms.Padding(3)
        Me.tbEdicao.Size = New System.Drawing.Size(346, 292)
        Me.tbEdicao.TabIndex = 1
        Me.tbEdicao.Text = "Edição de Apartamento"
        Me.tbEdicao.UseVisualStyleBackColor = True
        '
        'pnlEdicao
        '
        Me.pnlEdicao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlEdicao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlEdicao.Controls.Add(Me.txtEdicaoAndar)
        Me.pnlEdicao.Controls.Add(Me.Label17)
        Me.pnlEdicao.Controls.Add(Me.txtEdicaoCamaSolteiro)
        Me.pnlEdicao.Controls.Add(Me.txtEdicaoCamaCasal)
        Me.pnlEdicao.Controls.Add(Me.Label11)
        Me.pnlEdicao.Controls.Add(Me.Label10)
        Me.pnlEdicao.Controls.Add(Me.btnEdicaoSalvar)
        Me.pnlEdicao.Controls.Add(Me.gbEdicaoFrigobar)
        Me.pnlEdicao.Controls.Add(Me.cbEdicaoTipoApartamento)
        Me.pnlEdicao.Controls.Add(Me.Label6)
        Me.pnlEdicao.Location = New System.Drawing.Point(19, 41)
        Me.pnlEdicao.Name = "pnlEdicao"
        Me.pnlEdicao.Size = New System.Drawing.Size(311, 235)
        Me.pnlEdicao.TabIndex = 2
        Me.pnlEdicao.Visible = False
        '
        'txtEdicaoAndar
        '
        Me.txtEdicaoAndar.Location = New System.Drawing.Point(172, 35)
        Me.txtEdicaoAndar.Name = "txtEdicaoAndar"
        Me.txtEdicaoAndar.Size = New System.Drawing.Size(100, 20)
        Me.txtEdicaoAndar.TabIndex = 12
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(5, 33)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 20)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "Andar: "
        '
        'txtEdicaoCamaSolteiro
        '
        Me.txtEdicaoCamaSolteiro.Location = New System.Drawing.Point(172, 87)
        Me.txtEdicaoCamaSolteiro.MaxLength = 1
        Me.txtEdicaoCamaSolteiro.Name = "txtEdicaoCamaSolteiro"
        Me.txtEdicaoCamaSolteiro.Size = New System.Drawing.Size(100, 20)
        Me.txtEdicaoCamaSolteiro.TabIndex = 10
        '
        'txtEdicaoCamaCasal
        '
        Me.txtEdicaoCamaCasal.Location = New System.Drawing.Point(172, 61)
        Me.txtEdicaoCamaCasal.MaxLength = 1
        Me.txtEdicaoCamaCasal.Name = "txtEdicaoCamaCasal"
        Me.txtEdicaoCamaCasal.Size = New System.Drawing.Size(100, 20)
        Me.txtEdicaoCamaCasal.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(5, 85)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(147, 20)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Camas de Solteiro: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 20)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Camas De Casal:"
        '
        'btnEdicaoSalvar
        '
        Me.btnEdicaoSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdicaoSalvar.Location = New System.Drawing.Point(151, 191)
        Me.btnEdicaoSalvar.Name = "btnEdicaoSalvar"
        Me.btnEdicaoSalvar.Size = New System.Drawing.Size(142, 28)
        Me.btnEdicaoSalvar.TabIndex = 6
        Me.btnEdicaoSalvar.Text = "Salvar Alterações"
        Me.btnEdicaoSalvar.UseVisualStyleBackColor = True
        '
        'gbEdicaoFrigobar
        '
        Me.gbEdicaoFrigobar.Controls.Add(Me.rbEdicaoNao)
        Me.gbEdicaoFrigobar.Controls.Add(Me.rbEdicaoSim)
        Me.gbEdicaoFrigobar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEdicaoFrigobar.Location = New System.Drawing.Point(9, 113)
        Me.gbEdicaoFrigobar.Name = "gbEdicaoFrigobar"
        Me.gbEdicaoFrigobar.Size = New System.Drawing.Size(284, 72)
        Me.gbEdicaoFrigobar.TabIndex = 5
        Me.gbEdicaoFrigobar.TabStop = False
        Me.gbEdicaoFrigobar.Text = "Frigobar"
        '
        'rbEdicaoNao
        '
        Me.rbEdicaoNao.AutoSize = True
        Me.rbEdicaoNao.Location = New System.Drawing.Point(163, 25)
        Me.rbEdicaoNao.Name = "rbEdicaoNao"
        Me.rbEdicaoNao.Size = New System.Drawing.Size(56, 24)
        Me.rbEdicaoNao.TabIndex = 1
        Me.rbEdicaoNao.TabStop = True
        Me.rbEdicaoNao.Text = "Não"
        Me.rbEdicaoNao.UseVisualStyleBackColor = True
        '
        'rbEdicaoSim
        '
        Me.rbEdicaoSim.AutoSize = True
        Me.rbEdicaoSim.Location = New System.Drawing.Point(57, 25)
        Me.rbEdicaoSim.Name = "rbEdicaoSim"
        Me.rbEdicaoSim.Size = New System.Drawing.Size(54, 24)
        Me.rbEdicaoSim.TabIndex = 0
        Me.rbEdicaoSim.TabStop = True
        Me.rbEdicaoSim.Text = "Sim"
        Me.rbEdicaoSim.UseVisualStyleBackColor = True
        '
        'cbEdicaoTipoApartamento
        '
        Me.cbEdicaoTipoApartamento.DataSource = Me.HTipoApartamentoBindingSource
        Me.cbEdicaoTipoApartamento.DisplayMember = "tipo"
        Me.cbEdicaoTipoApartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEdicaoTipoApartamento.FormattingEnabled = True
        Me.cbEdicaoTipoApartamento.Location = New System.Drawing.Point(172, 8)
        Me.cbEdicaoTipoApartamento.Name = "cbEdicaoTipoApartamento"
        Me.cbEdicaoTipoApartamento.Size = New System.Drawing.Size(121, 21)
        Me.cbEdicaoTipoApartamento.TabIndex = 1
        Me.cbEdicaoTipoApartamento.ValueMember = "idTipoApartamento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Tipo do Apartamento:"
        '
        'cbxEdicaoTipoApartamento
        '
        Me.cbxEdicaoTipoApartamento.DataSource = Me.HApartamentoBindingSource
        Me.cbxEdicaoTipoApartamento.DisplayMember = "numero"
        Me.cbxEdicaoTipoApartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEdicaoTipoApartamento.FormattingEnabled = True
        Me.cbxEdicaoTipoApartamento.Location = New System.Drawing.Point(209, 14)
        Me.cbxEdicaoTipoApartamento.Name = "cbxEdicaoTipoApartamento"
        Me.cbxEdicaoTipoApartamento.Size = New System.Drawing.Size(121, 21)
        Me.cbxEdicaoTipoApartamento.TabIndex = 0
        Me.cbxEdicaoTipoApartamento.ValueMember = "idApartamento"
        '
        'HApartamentoBindingSource
        '
        Me.HApartamentoBindingSource.DataMember = "hApartamento"
        Me.HApartamentoBindingSource.DataSource = Me.HosPDeirosDataSet1
        '
        'HosPDeirosDataSet1
        '
        Me.HosPDeirosDataSet1.DataSetName = "HosPDeirosDataSet1"
        Me.HosPDeirosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Número do Apartamento:"
        '
        'tbRemoçãoApartamento
        '
        Me.tbRemoçãoApartamento.Controls.Add(Me.cbxRemocaoApartamento)
        Me.tbRemoçãoApartamento.Controls.Add(Me.Label12)
        Me.tbRemoçãoApartamento.Controls.Add(Me.pnlRemocao)
        Me.tbRemoçãoApartamento.Location = New System.Drawing.Point(4, 22)
        Me.tbRemoçãoApartamento.Name = "tbRemoçãoApartamento"
        Me.tbRemoçãoApartamento.Padding = New System.Windows.Forms.Padding(3)
        Me.tbRemoçãoApartamento.Size = New System.Drawing.Size(346, 292)
        Me.tbRemoçãoApartamento.TabIndex = 2
        Me.tbRemoçãoApartamento.Text = "Remoção de Apartamento"
        Me.tbRemoçãoApartamento.UseVisualStyleBackColor = True
        '
        'cbxRemocaoApartamento
        '
        Me.cbxRemocaoApartamento.DataSource = Me.HApartamentoBindingSource
        Me.cbxRemocaoApartamento.DisplayMember = "numero"
        Me.cbxRemocaoApartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRemocaoApartamento.FormattingEnabled = True
        Me.cbxRemocaoApartamento.Location = New System.Drawing.Point(210, 14)
        Me.cbxRemocaoApartamento.Name = "cbxRemocaoApartamento"
        Me.cbxRemocaoApartamento.Size = New System.Drawing.Size(121, 21)
        Me.cbxRemocaoApartamento.TabIndex = 3
        Me.cbxRemocaoApartamento.ValueMember = "idApartamento"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(188, 20)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Número do Apartamento:"
        '
        'pnlRemocao
        '
        Me.pnlRemocao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlRemocao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlRemocao.Controls.Add(Me.txtRemocaoAndar)
        Me.pnlRemocao.Controls.Add(Me.Label18)
        Me.pnlRemocao.Controls.Add(Me.txtRemocaoTipoApartamento)
        Me.pnlRemocao.Controls.Add(Me.txtremocaoCamaSolteiro)
        Me.pnlRemocao.Controls.Add(Me.txtRemocaoCamaCasal)
        Me.pnlRemocao.Controls.Add(Me.Label13)
        Me.pnlRemocao.Controls.Add(Me.btnRemoverApartamento)
        Me.pnlRemocao.Controls.Add(Me.Label14)
        Me.pnlRemocao.Controls.Add(Me.gbRemocaoFrigobar)
        Me.pnlRemocao.Controls.Add(Me.Label16)
        Me.pnlRemocao.Location = New System.Drawing.Point(20, 41)
        Me.pnlRemocao.Name = "pnlRemocao"
        Me.pnlRemocao.Size = New System.Drawing.Size(311, 234)
        Me.pnlRemocao.TabIndex = 5
        Me.pnlRemocao.Visible = False
        '
        'txtRemocaoAndar
        '
        Me.txtRemocaoAndar.Enabled = False
        Me.txtRemocaoAndar.Location = New System.Drawing.Point(172, 34)
        Me.txtRemocaoAndar.Name = "txtRemocaoAndar"
        Me.txtRemocaoAndar.Size = New System.Drawing.Size(100, 20)
        Me.txtRemocaoAndar.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(7, 34)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 20)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "Andar: "
        '
        'txtRemocaoTipoApartamento
        '
        Me.txtRemocaoTipoApartamento.Enabled = False
        Me.txtRemocaoTipoApartamento.Location = New System.Drawing.Point(172, 8)
        Me.txtRemocaoTipoApartamento.Name = "txtRemocaoTipoApartamento"
        Me.txtRemocaoTipoApartamento.Size = New System.Drawing.Size(100, 20)
        Me.txtRemocaoTipoApartamento.TabIndex = 11
        '
        'txtremocaoCamaSolteiro
        '
        Me.txtremocaoCamaSolteiro.Enabled = False
        Me.txtremocaoCamaSolteiro.Location = New System.Drawing.Point(172, 86)
        Me.txtremocaoCamaSolteiro.Name = "txtremocaoCamaSolteiro"
        Me.txtremocaoCamaSolteiro.Size = New System.Drawing.Size(100, 20)
        Me.txtremocaoCamaSolteiro.TabIndex = 10
        '
        'txtRemocaoCamaCasal
        '
        Me.txtRemocaoCamaCasal.Enabled = False
        Me.txtRemocaoCamaCasal.Location = New System.Drawing.Point(172, 60)
        Me.txtRemocaoCamaCasal.Name = "txtRemocaoCamaCasal"
        Me.txtRemocaoCamaCasal.Size = New System.Drawing.Size(100, 20)
        Me.txtRemocaoCamaCasal.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(7, 84)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(147, 20)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Camas de Solteiro: "
        '
        'btnRemoverApartamento
        '
        Me.btnRemoverApartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoverApartamento.Location = New System.Drawing.Point(109, 190)
        Me.btnRemoverApartamento.Name = "btnRemoverApartamento"
        Me.btnRemoverApartamento.Size = New System.Drawing.Size(182, 27)
        Me.btnRemoverApartamento.TabIndex = 2
        Me.btnRemoverApartamento.Text = "Remover Apartamento"
        Me.btnRemoverApartamento.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(7, 58)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(132, 20)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Camas De Casal:"
        '
        'gbRemocaoFrigobar
        '
        Me.gbRemocaoFrigobar.Controls.Add(Me.rbRemocaoNao)
        Me.gbRemocaoFrigobar.Controls.Add(Me.rbRemocaoSim)
        Me.gbRemocaoFrigobar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRemocaoFrigobar.Location = New System.Drawing.Point(7, 112)
        Me.gbRemocaoFrigobar.Name = "gbRemocaoFrigobar"
        Me.gbRemocaoFrigobar.Size = New System.Drawing.Size(284, 72)
        Me.gbRemocaoFrigobar.TabIndex = 5
        Me.gbRemocaoFrigobar.TabStop = False
        Me.gbRemocaoFrigobar.Text = "Frigobar"
        '
        'rbRemocaoNao
        '
        Me.rbRemocaoNao.AutoSize = True
        Me.rbRemocaoNao.Enabled = False
        Me.rbRemocaoNao.Location = New System.Drawing.Point(163, 25)
        Me.rbRemocaoNao.Name = "rbRemocaoNao"
        Me.rbRemocaoNao.Size = New System.Drawing.Size(56, 24)
        Me.rbRemocaoNao.TabIndex = 1
        Me.rbRemocaoNao.TabStop = True
        Me.rbRemocaoNao.Text = "Não"
        Me.rbRemocaoNao.UseVisualStyleBackColor = True
        '
        'rbRemocaoSim
        '
        Me.rbRemocaoSim.AutoSize = True
        Me.rbRemocaoSim.Enabled = False
        Me.rbRemocaoSim.Location = New System.Drawing.Point(57, 25)
        Me.rbRemocaoSim.Name = "rbRemocaoSim"
        Me.rbRemocaoSim.Size = New System.Drawing.Size(54, 24)
        Me.rbRemocaoSim.TabIndex = 0
        Me.rbRemocaoSim.TabStop = True
        Me.rbRemocaoSim.Text = "Sim"
        Me.rbRemocaoSim.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(7, 6)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(162, 20)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Tipo do Apartamento:"
        '
        'tbListagem
        '
        Me.tbListagem.Location = New System.Drawing.Point(4, 22)
        Me.tbListagem.Name = "tbListagem"
        Me.tbListagem.Padding = New System.Windows.Forms.Padding(3)
        Me.tbListagem.Size = New System.Drawing.Size(346, 292)
        Me.tbListagem.TabIndex = 3
        Me.tbListagem.Text = "Listagem de Apartamentos"
        Me.tbListagem.UseVisualStyleBackColor = True
        '
        'HApartamentoTableAdapter
        '
        Me.HApartamentoTableAdapter.ClearBeforeFill = True
        '
        'CadastroApartamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(376, 338)
        Me.Controls.Add(Me.tcApartamento)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CadastroApartamentos"
        Me.Text = "Mountain Ville - Cadastro de Apartamentos"
        CType(Me.HTipoApartamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HosPDeirosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFrigobar.ResumeLayout(False)
        Me.gbFrigobar.PerformLayout()
        Me.tcApartamento.ResumeLayout(False)
        Me.tbCadastro.ResumeLayout(False)
        Me.tbCadastro.PerformLayout()
        Me.tbEdicao.ResumeLayout(False)
        Me.tbEdicao.PerformLayout()
        Me.pnlEdicao.ResumeLayout(False)
        Me.pnlEdicao.PerformLayout()
        Me.gbEdicaoFrigobar.ResumeLayout(False)
        Me.gbEdicaoFrigobar.PerformLayout()
        CType(Me.HApartamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HosPDeirosDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbRemoçãoApartamento.ResumeLayout(False)
        Me.tbRemoçãoApartamento.PerformLayout()
        Me.pnlRemocao.ResumeLayout(False)
        Me.pnlRemocao.PerformLayout()
        Me.gbRemocaoFrigobar.ResumeLayout(False)
        Me.gbRemocaoFrigobar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxTipoApartamento As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents HosPDeirosDataSet As Hotel.HosPDeirosDataSet
    Friend WithEvents HTipoApartamentoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HTipoApartamentoTableAdapter As Hotel.HosPDeirosDataSetTableAdapters.hTipoApartamentoTableAdapter
    Friend WithEvents btnIncluir As System.Windows.Forms.Button
    Friend WithEvents gbFrigobar As System.Windows.Forms.GroupBox
    Friend WithEvents rbSim As System.Windows.Forms.RadioButton
    Friend WithEvents rbNao As System.Windows.Forms.RadioButton
    Friend WithEvents tcApartamento As System.Windows.Forms.TabControl
    Friend WithEvents tbCadastro As System.Windows.Forms.TabPage
    Friend WithEvents tbEdicao As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbxEdicaoTipoApartamento As System.Windows.Forms.ComboBox
    Friend WithEvents HosPDeirosDataSet1 As Hotel.HosPDeirosDataSet1
    Friend WithEvents HApartamentoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HApartamentoTableAdapter As Hotel.HosPDeirosDataSet1TableAdapters.hApartamentoTableAdapter
    Friend WithEvents pnlEdicao As System.Windows.Forms.Panel
    Friend WithEvents cbEdicaoTipoApartamento As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents gbEdicaoFrigobar As System.Windows.Forms.GroupBox
    Friend WithEvents rbEdicaoNao As System.Windows.Forms.RadioButton
    Friend WithEvents rbEdicaoSim As System.Windows.Forms.RadioButton
    Friend WithEvents btnEdicaoSalvar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCamaSolteiro As System.Windows.Forms.TextBox
    Friend WithEvents txtCamaCasal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtEdicaoCamaSolteiro As System.Windows.Forms.TextBox
    Friend WithEvents txtEdicaoCamaCasal As System.Windows.Forms.TextBox
    Friend WithEvents tbRemoçãoApartamento As System.Windows.Forms.TabPage
    Friend WithEvents btnRemoverApartamento As System.Windows.Forms.Button
    Friend WithEvents cbxRemocaoApartamento As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents pnlRemocao As System.Windows.Forms.Panel
    Friend WithEvents txtRemocaoTipoApartamento As System.Windows.Forms.TextBox
    Friend WithEvents txtremocaoCamaSolteiro As System.Windows.Forms.TextBox
    Friend WithEvents txtRemocaoCamaCasal As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents gbRemocaoFrigobar As System.Windows.Forms.GroupBox
    Friend WithEvents rbRemocaoNao As System.Windows.Forms.RadioButton
    Friend WithEvents rbRemocaoSim As System.Windows.Forms.RadioButton
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAndar As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtEdicaoAndar As System.Windows.Forms.TextBox
    Friend WithEvents txtRemocaoAndar As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tbListagem As System.Windows.Forms.TabPage
End Class
