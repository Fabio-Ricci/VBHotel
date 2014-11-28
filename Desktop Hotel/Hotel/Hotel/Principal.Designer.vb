<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.menu = New System.Windows.Forms.MenuStrip()
        Me.menuApartamentos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuApartamentosCadastro = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuApartamentosTipo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListagemDeApartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListagemDeTiposDeApartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuClientesCadastro = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuClientesListagem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItens = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItensCadastro = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItensCadastroTipo = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItensConsumoItens = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListagemDeItensToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListagemDeTipoDeItensToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListagemDeConsumoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPergunta = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListagemPerguntasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListagemDePerguntasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCheckout = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFuncionarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFuncionariosCadastro = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFuncionariosListagem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.menuAvaliacao = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menu
        '
        Me.menu.BackColor = System.Drawing.Color.Gainsboro
        Me.menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuApartamentos, Me.menuClientes, Me.menuItens, Me.menuPergunta, Me.menuCheckout, Me.menuFuncionarios, Me.menuAvaliacao})
        Me.menu.Location = New System.Drawing.Point(0, 0)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(517, 24)
        Me.menu.TabIndex = 0
        Me.menu.Text = "MenuStrip1"
        '
        'menuApartamentos
        '
        Me.menuApartamentos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuApartamentosCadastro, Me.menuApartamentosTipo, Me.ListagemDeApartamentosToolStripMenuItem, Me.ListagemDeTiposDeApartamentosToolStripMenuItem})
        Me.menuApartamentos.Name = "menuApartamentos"
        Me.menuApartamentos.Size = New System.Drawing.Size(94, 20)
        Me.menuApartamentos.Text = "Apartamentos"
        '
        'menuApartamentosCadastro
        '
        Me.menuApartamentosCadastro.Name = "menuApartamentosCadastro"
        Me.menuApartamentosCadastro.Size = New System.Drawing.Size(264, 22)
        Me.menuApartamentosCadastro.Text = "Apartamentos"
        '
        'menuApartamentosTipo
        '
        Me.menuApartamentosTipo.Name = "menuApartamentosTipo"
        Me.menuApartamentosTipo.Size = New System.Drawing.Size(264, 22)
        Me.menuApartamentosTipo.Text = "Tipos de Apartamento"
        '
        'ListagemDeApartamentosToolStripMenuItem
        '
        Me.ListagemDeApartamentosToolStripMenuItem.Name = "ListagemDeApartamentosToolStripMenuItem"
        Me.ListagemDeApartamentosToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.ListagemDeApartamentosToolStripMenuItem.Text = "Listagem de Apartamentos"
        '
        'ListagemDeTiposDeApartamentosToolStripMenuItem
        '
        Me.ListagemDeTiposDeApartamentosToolStripMenuItem.Name = "ListagemDeTiposDeApartamentosToolStripMenuItem"
        Me.ListagemDeTiposDeApartamentosToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.ListagemDeTiposDeApartamentosToolStripMenuItem.Text = "Listagem de Tipos de Apartamentos"
        '
        'menuClientes
        '
        Me.menuClientes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuClientesCadastro, Me.menuClientesListagem})
        Me.menuClientes.Name = "menuClientes"
        Me.menuClientes.Size = New System.Drawing.Size(61, 20)
        Me.menuClientes.Text = "Clientes"
        '
        'menuClientesCadastro
        '
        Me.menuClientesCadastro.Name = "menuClientesCadastro"
        Me.menuClientesCadastro.Size = New System.Drawing.Size(183, 22)
        Me.menuClientesCadastro.Text = "Clientes"
        '
        'menuClientesListagem
        '
        Me.menuClientesListagem.Name = "menuClientesListagem"
        Me.menuClientesListagem.Size = New System.Drawing.Size(183, 22)
        Me.menuClientesListagem.Text = "Listagem de Clientes"
        '
        'menuItens
        '
        Me.menuItens.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItensCadastro, Me.menuItensCadastroTipo, Me.menuItensConsumoItens, Me.ListagemDeItensToolStripMenuItem, Me.ListagemDeTipoDeItensToolStripMenuItem, Me.ListagemDeConsumoToolStripMenuItem})
        Me.menuItens.Name = "menuItens"
        Me.menuItens.Size = New System.Drawing.Size(44, 20)
        Me.menuItens.Text = "Itens"
        '
        'menuItensCadastro
        '
        Me.menuItensCadastro.Name = "menuItensCadastro"
        Me.menuItensCadastro.Size = New System.Drawing.Size(209, 22)
        Me.menuItensCadastro.Text = "Itens"
        '
        'menuItensCadastroTipo
        '
        Me.menuItensCadastroTipo.Name = "menuItensCadastroTipo"
        Me.menuItensCadastroTipo.Size = New System.Drawing.Size(209, 22)
        Me.menuItensCadastroTipo.Text = "Tipos de Item"
        '
        'menuItensConsumoItens
        '
        Me.menuItensConsumoItens.Name = "menuItensConsumoItens"
        Me.menuItensConsumoItens.Size = New System.Drawing.Size(209, 22)
        Me.menuItensConsumoItens.Text = "Consumo"
        '
        'ListagemDeItensToolStripMenuItem
        '
        Me.ListagemDeItensToolStripMenuItem.Name = "ListagemDeItensToolStripMenuItem"
        Me.ListagemDeItensToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ListagemDeItensToolStripMenuItem.Text = "Listagem de Itens"
        '
        'ListagemDeTipoDeItensToolStripMenuItem
        '
        Me.ListagemDeTipoDeItensToolStripMenuItem.Name = "ListagemDeTipoDeItensToolStripMenuItem"
        Me.ListagemDeTipoDeItensToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ListagemDeTipoDeItensToolStripMenuItem.Text = "Listagem de Tipo de Itens"
        '
        'ListagemDeConsumoToolStripMenuItem
        '
        Me.ListagemDeConsumoToolStripMenuItem.Name = "ListagemDeConsumoToolStripMenuItem"
        Me.ListagemDeConsumoToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ListagemDeConsumoToolStripMenuItem.Text = "Listagem de Consumo"
        '
        'menuPergunta
        '
        Me.menuPergunta.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListagemPerguntasToolStripMenuItem, Me.ListagemDePerguntasToolStripMenuItem})
        Me.menuPergunta.Name = "menuPergunta"
        Me.menuPergunta.Size = New System.Drawing.Size(67, 20)
        Me.menuPergunta.Text = "Pergunta"
        '
        'ListagemPerguntasToolStripMenuItem
        '
        Me.ListagemPerguntasToolStripMenuItem.Name = "ListagemPerguntasToolStripMenuItem"
        Me.ListagemPerguntasToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ListagemPerguntasToolStripMenuItem.Text = "Perguntas"
        '
        'ListagemDePerguntasToolStripMenuItem
        '
        Me.ListagemDePerguntasToolStripMenuItem.Name = "ListagemDePerguntasToolStripMenuItem"
        Me.ListagemDePerguntasToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ListagemDePerguntasToolStripMenuItem.Text = "Listagem de Perguntas"
        '
        'menuCheckout
        '
        Me.menuCheckout.Name = "menuCheckout"
        Me.menuCheckout.Size = New System.Drawing.Size(70, 20)
        Me.menuCheckout.Text = "Checkout"
        '
        'menuFuncionarios
        '
        Me.menuFuncionarios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFuncionariosCadastro, Me.menuFuncionariosListagem})
        Me.menuFuncionarios.Name = "menuFuncionarios"
        Me.menuFuncionarios.Size = New System.Drawing.Size(87, 20)
        Me.menuFuncionarios.Text = "Funcionários"
        '
        'menuFuncionariosCadastro
        '
        Me.menuFuncionariosCadastro.Name = "menuFuncionariosCadastro"
        Me.menuFuncionariosCadastro.Size = New System.Drawing.Size(209, 22)
        Me.menuFuncionariosCadastro.Text = "Funcionários"
        '
        'menuFuncionariosListagem
        '
        Me.menuFuncionariosListagem.Name = "menuFuncionariosListagem"
        Me.menuFuncionariosListagem.Size = New System.Drawing.Size(209, 22)
        Me.menuFuncionariosListagem.Text = "Listagem de Funcionários"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(98, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(336, 239)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'menuAvaliacao
        '
        Me.menuAvaliacao.Name = "menuAvaliacao"
        Me.menuAvaliacao.Size = New System.Drawing.Size(76, 20)
        Me.menuAvaliacao.Text = "Estatísticas"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(517, 320)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.menu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menu
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mountain Ville"
        Me.menu.ResumeLayout(False)
        Me.menu.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menu As System.Windows.Forms.MenuStrip
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents menuApartamentos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuApartamentosCadastro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuApartamentosTipo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuClientesCadastro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuClientesListagem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItens As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItensCadastro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItensCadastroTipo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuPergunta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCheckout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuFuncionarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuFuncionariosCadastro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuFuncionariosListagem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItensConsumoItens As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListagemDeApartamentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListagemDeItensToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListagemDeTipoDeItensToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListagemDeConsumoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListagemDeTiposDeApartamentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListagemPerguntasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
<<<<<<< HEAD
    Friend WithEvents ListagemDePerguntasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
=======
    Friend WithEvents ListegamDePerguntasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAvaliacao As System.Windows.Forms.ToolStripMenuItem
>>>>>>> origin/master
End Class
