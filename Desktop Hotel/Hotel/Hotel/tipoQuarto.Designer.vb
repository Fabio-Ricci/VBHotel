<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tipoQuarto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tipoQuarto))
        Me.timerSlide = New System.Windows.Forms.Timer(Me.components)
        Me.tcTipoApto = New System.Windows.Forms.TabControl()
        Me.tpCadastro = New System.Windows.Forms.TabPage()
        Me.txtDiaria = New System.Windows.Forms.TextBox()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tpEdicao = New System.Windows.Forms.TabPage()
        Me.cbTipoEdicao = New System.Windows.Forms.ComboBox()
        Me.txtTipoEdicao = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDiariaEdicao = New System.Windows.Forms.TextBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.txtDescricaoEdicao = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tpFotos = New System.Windows.Forms.TabPage()
        Me.pbAddFoto = New System.Windows.Forms.PictureBox()
        Me.btnInserir = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCarregar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.tpExibicao = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.cbTipoExibicao = New System.Windows.Forms.ComboBox()
        Me.pbFoto = New System.Windows.Forms.PictureBox()
        Me.ofdFoto = New System.Windows.Forms.OpenFileDialog()
        Me.tcTipoApto.SuspendLayout()
        Me.tpCadastro.SuspendLayout()
        Me.tpEdicao.SuspendLayout()
        Me.tpFotos.SuspendLayout()
        CType(Me.pbAddFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpExibicao.SuspendLayout()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timerSlide
        '
        Me.timerSlide.Interval = 3000
        '
        'tcTipoApto
        '
        Me.tcTipoApto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcTipoApto.Controls.Add(Me.tpCadastro)
        Me.tcTipoApto.Controls.Add(Me.tpEdicao)
        Me.tcTipoApto.Controls.Add(Me.tpFotos)
        Me.tcTipoApto.Controls.Add(Me.tpExibicao)
        Me.tcTipoApto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcTipoApto.Location = New System.Drawing.Point(12, 12)
        Me.tcTipoApto.Name = "tcTipoApto"
        Me.tcTipoApto.SelectedIndex = 0
        Me.tcTipoApto.Size = New System.Drawing.Size(437, 489)
        Me.tcTipoApto.TabIndex = 4
        '
        'tpCadastro
        '
        Me.tpCadastro.BackColor = System.Drawing.Color.White
        Me.tpCadastro.Controls.Add(Me.txtDiaria)
        Me.tpCadastro.Controls.Add(Me.btnCadastrar)
        Me.tpCadastro.Controls.Add(Me.txtDescricao)
        Me.tpCadastro.Controls.Add(Me.Label4)
        Me.tpCadastro.Controls.Add(Me.Label3)
        Me.tpCadastro.Controls.Add(Me.txtTipo)
        Me.tpCadastro.Controls.Add(Me.Label2)
        Me.tpCadastro.Location = New System.Drawing.Point(4, 29)
        Me.tpCadastro.Name = "tpCadastro"
        Me.tpCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCadastro.Size = New System.Drawing.Size(429, 456)
        Me.tpCadastro.TabIndex = 0
        Me.tpCadastro.Text = "Cadastro"
        '
        'txtDiaria
        '
        Me.txtDiaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaria.Location = New System.Drawing.Point(119, 81)
        Me.txtDiaria.MaxLength = 10
        Me.txtDiaria.Name = "txtDiaria"
        Me.txtDiaria.Size = New System.Drawing.Size(100, 26)
        Me.txtDiaria.TabIndex = 2
        '
        'btnCadastrar
        '
        Me.btnCadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastrar.Location = New System.Drawing.Point(119, 370)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(96, 30)
        Me.btnCadastrar.TabIndex = 4
        Me.btnCadastrar.Text = "Cadastrar"
        Me.btnCadastrar.UseVisualStyleBackColor = True
        '
        'txtDescricao
        '
        Me.txtDescricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricao.Location = New System.Drawing.Point(119, 129)
        Me.txtDescricao.MaxLength = 300
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(267, 214)
        Me.txtDescricao.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Descrição:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tarifa diária:"
        '
        'txtTipo
        '
        Me.txtTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo.Location = New System.Drawing.Point(119, 34)
        Me.txtTipo.MaxLength = 15
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(267, 26)
        Me.txtTipo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nome:"
        '
        'tpEdicao
        '
        Me.tpEdicao.Controls.Add(Me.cbTipoEdicao)
        Me.tpEdicao.Controls.Add(Me.txtTipoEdicao)
        Me.tpEdicao.Controls.Add(Me.Label10)
        Me.tpEdicao.Controls.Add(Me.txtDiariaEdicao)
        Me.tpEdicao.Controls.Add(Me.btnSalvar)
        Me.tpEdicao.Controls.Add(Me.txtDescricaoEdicao)
        Me.tpEdicao.Controls.Add(Me.Label8)
        Me.tpEdicao.Controls.Add(Me.Label9)
        Me.tpEdicao.Controls.Add(Me.Label7)
        Me.tpEdicao.Location = New System.Drawing.Point(4, 29)
        Me.tpEdicao.Name = "tpEdicao"
        Me.tpEdicao.Size = New System.Drawing.Size(429, 456)
        Me.tpEdicao.TabIndex = 3
        Me.tpEdicao.Text = "Edição"
        Me.tpEdicao.UseVisualStyleBackColor = True
        '
        'cbTipoEdicao
        '
        Me.cbTipoEdicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoEdicao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoEdicao.FormattingEnabled = True
        Me.cbTipoEdicao.Location = New System.Drawing.Point(191, 34)
        Me.cbTipoEdicao.Name = "cbTipoEdicao"
        Me.cbTipoEdicao.Size = New System.Drawing.Size(193, 28)
        Me.cbTipoEdicao.TabIndex = 1
        '
        'txtTipoEdicao
        '
        Me.txtTipoEdicao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoEdicao.Location = New System.Drawing.Point(117, 83)
        Me.txtTipoEdicao.MaxLength = 15
        Me.txtTipoEdicao.Name = "txtTipoEdicao"
        Me.txtTipoEdicao.Size = New System.Drawing.Size(267, 26)
        Me.txtTipoEdicao.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 20)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Nome:"
        '
        'txtDiariaEdicao
        '
        Me.txtDiariaEdicao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiariaEdicao.Location = New System.Drawing.Point(117, 128)
        Me.txtDiariaEdicao.MaxLength = 10
        Me.txtDiariaEdicao.Name = "txtDiariaEdicao"
        Me.txtDiariaEdicao.Size = New System.Drawing.Size(100, 26)
        Me.txtDiariaEdicao.TabIndex = 3
        '
        'btnSalvar
        '
        Me.btnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.Location = New System.Drawing.Point(117, 404)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(96, 30)
        Me.btnSalvar.TabIndex = 5
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'txtDescricaoEdicao
        '
        Me.txtDescricaoEdicao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricaoEdicao.Location = New System.Drawing.Point(117, 175)
        Me.txtDescricaoEdicao.MaxLength = 300
        Me.txtDescricaoEdicao.Multiline = True
        Me.txtDescricaoEdicao.Name = "txtDescricaoEdicao"
        Me.txtDescricaoEdicao.Size = New System.Drawing.Size(267, 214)
        Me.txtDescricaoEdicao.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Descrição:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 20)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Tarifa diária:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Tipo de Apartamento:"
        '
        'tpFotos
        '
        Me.tpFotos.Controls.Add(Me.pbAddFoto)
        Me.tpFotos.Controls.Add(Me.btnInserir)
        Me.tpFotos.Controls.Add(Me.Label6)
        Me.tpFotos.Controls.Add(Me.btnCarregar)
        Me.tpFotos.Controls.Add(Me.Label5)
        Me.tpFotos.Controls.Add(Me.cbTipo)
        Me.tpFotos.Location = New System.Drawing.Point(4, 29)
        Me.tpFotos.Name = "tpFotos"
        Me.tpFotos.Padding = New System.Windows.Forms.Padding(3)
        Me.tpFotos.Size = New System.Drawing.Size(429, 456)
        Me.tpFotos.TabIndex = 2
        Me.tpFotos.Text = "Adicionar Fotos"
        Me.tpFotos.UseVisualStyleBackColor = True
        '
        'pbAddFoto
        '
        Me.pbAddFoto.Location = New System.Drawing.Point(41, 138)
        Me.pbAddFoto.Name = "pbAddFoto"
        Me.pbAddFoto.Size = New System.Drawing.Size(320, 213)
        Me.pbAddFoto.TabIndex = 13
        Me.pbAddFoto.TabStop = False
        '
        'btnInserir
        '
        Me.btnInserir.Location = New System.Drawing.Point(153, 383)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Size = New System.Drawing.Size(79, 39)
        Me.btnInserir.TabIndex = 3
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Selecione uma Foto:"
        '
        'btnCarregar
        '
        Me.btnCarregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCarregar.Location = New System.Drawing.Point(218, 70)
        Me.btnCarregar.Name = "btnCarregar"
        Me.btnCarregar.Size = New System.Drawing.Size(146, 39)
        Me.btnCarregar.TabIndex = 2
        Me.btnCarregar.Text = "Carregar Foto"
        Me.btnCarregar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tipo de Apartamento:"
        '
        'cbTipo
        '
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Location = New System.Drawing.Point(205, 29)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(159, 28)
        Me.cbTipo.TabIndex = 1
        '
        'tpExibicao
        '
        Me.tpExibicao.Controls.Add(Me.Label1)
        Me.tpExibicao.Controls.Add(Me.lblDescricao)
        Me.tpExibicao.Controls.Add(Me.cbTipoExibicao)
        Me.tpExibicao.Controls.Add(Me.pbFoto)
        Me.tpExibicao.Location = New System.Drawing.Point(4, 29)
        Me.tpExibicao.Name = "tpExibicao"
        Me.tpExibicao.Padding = New System.Windows.Forms.Padding(3)
        Me.tpExibicao.Size = New System.Drawing.Size(429, 456)
        Me.tpExibicao.TabIndex = 1
        Me.tpExibicao.Text = "Exibição"
        Me.tpExibicao.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Tipo de Apartamento:"
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescricao.Location = New System.Drawing.Point(23, 329)
        Me.lblDescricao.MaximumSize = New System.Drawing.Size(360, 0)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(80, 20)
        Me.lblDescricao.TabIndex = 7
        Me.lblDescricao.Text = "Descrição"
        '
        'cbTipoExibicao
        '
        Me.cbTipoExibicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoExibicao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoExibicao.FormattingEnabled = True
        Me.cbTipoExibicao.Location = New System.Drawing.Point(191, 26)
        Me.cbTipoExibicao.Name = "cbTipoExibicao"
        Me.cbTipoExibicao.Size = New System.Drawing.Size(159, 28)
        Me.cbTipoExibicao.TabIndex = 4
        '
        'pbFoto
        '
        Me.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbFoto.ErrorImage = CType(resources.GetObject("pbFoto.ErrorImage"), System.Drawing.Image)
        Me.pbFoto.Location = New System.Drawing.Point(27, 76)
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.Size = New System.Drawing.Size(360, 240)
        Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFoto.TabIndex = 5
        Me.pbFoto.TabStop = False
        '
        'ofdFoto
        '
        Me.ofdFoto.FileName = "OpenFileDialog1"
        Me.ofdFoto.Filter = " JPG | *.jpg"
        Me.ofdFoto.Title = "Selecionar foto"
        '
        'tipoQuarto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(466, 521)
        Me.Controls.Add(Me.tcTipoApto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "tipoQuarto"
        Me.Text = "Mountain Ville - Tipos de Apartamento"
        Me.tcTipoApto.ResumeLayout(False)
        Me.tpCadastro.ResumeLayout(False)
        Me.tpCadastro.PerformLayout()
        Me.tpEdicao.ResumeLayout(False)
        Me.tpEdicao.PerformLayout()
        Me.tpFotos.ResumeLayout(False)
        Me.tpFotos.PerformLayout()
        CType(Me.pbAddFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpExibicao.ResumeLayout(False)
        Me.tpExibicao.PerformLayout()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents timerSlide As System.Windows.Forms.Timer
    Friend WithEvents tcTipoApto As System.Windows.Forms.TabControl
    Friend WithEvents tpCadastro As System.Windows.Forms.TabPage
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tpExibicao As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents cbTipoExibicao As System.Windows.Forms.ComboBox
    Friend WithEvents pbFoto As System.Windows.Forms.PictureBox
    Friend WithEvents btnCadastrar As System.Windows.Forms.Button
    Friend WithEvents tpFotos As System.Windows.Forms.TabPage
    Friend WithEvents txtDiaria As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents btnCarregar As System.Windows.Forms.Button
    Friend WithEvents ofdFoto As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnInserir As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pbAddFoto As System.Windows.Forms.PictureBox
    Friend WithEvents tpEdicao As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDiariaEdicao As System.Windows.Forms.TextBox
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents txtDescricaoEdicao As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTipoEdicao As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbTipoEdicao As System.Windows.Forms.ComboBox
End Class
