<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadastroItem))
        Me.tcItem = New System.Windows.Forms.TabControl()
        Me.tbCadastroItem = New System.Windows.Forms.TabPage()
        Me.cbxTipoItem = New System.Windows.Forms.ComboBox()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.txtCustoUnitario = New System.Windows.Forms.TextBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbEdicaoItem = New System.Windows.Forms.TabPage()
        Me.cbxEdicaoIdItem = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnlEdicaoItem = New System.Windows.Forms.Panel()
        Me.btnSalvarEdicao = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxEdicaoTipoItem = New System.Windows.Forms.ComboBox()
        Me.txtEdicaoDescricao = New System.Windows.Forms.TextBox()
        Me.txtEdicaoCustoUnitario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbRemocaoItem = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbxRemocaoIdItem = New System.Windows.Forms.ComboBox()
        Me.pnlRemocaoItem = New System.Windows.Forms.Panel()
        Me.btnRemocaoItem = New System.Windows.Forms.Button()
        Me.cbxRemocaoTipoItem = New System.Windows.Forms.ComboBox()
        Me.txtRemocaoDescricao = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRemocaoCustoUnitario = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbListagemItem = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.tcItem.SuspendLayout()
        Me.tbCadastroItem.SuspendLayout()
        Me.tbEdicaoItem.SuspendLayout()
        Me.pnlEdicaoItem.SuspendLayout()
        Me.tbRemocaoItem.SuspendLayout()
        Me.pnlRemocaoItem.SuspendLayout()
        Me.tbListagemItem.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcItem
        '
        Me.tcItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcItem.Controls.Add(Me.tbCadastroItem)
        Me.tcItem.Controls.Add(Me.tbEdicaoItem)
        Me.tcItem.Controls.Add(Me.tbRemocaoItem)
        Me.tcItem.Controls.Add(Me.tbListagemItem)
        Me.tcItem.Location = New System.Drawing.Point(12, 12)
        Me.tcItem.Name = "tcItem"
        Me.tcItem.SelectedIndex = 0
        Me.tcItem.Size = New System.Drawing.Size(452, 387)
        Me.tcItem.TabIndex = 0
        '
        'tbCadastroItem
        '
        Me.tbCadastroItem.Controls.Add(Me.cbxTipoItem)
        Me.tbCadastroItem.Controls.Add(Me.btnCadastrar)
        Me.tbCadastroItem.Controls.Add(Me.txtCustoUnitario)
        Me.tbCadastroItem.Controls.Add(Me.txtDescricao)
        Me.tbCadastroItem.Controls.Add(Me.Label3)
        Me.tbCadastroItem.Controls.Add(Me.Label2)
        Me.tbCadastroItem.Controls.Add(Me.Label1)
        Me.tbCadastroItem.Location = New System.Drawing.Point(4, 22)
        Me.tbCadastroItem.Name = "tbCadastroItem"
        Me.tbCadastroItem.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCadastroItem.Size = New System.Drawing.Size(339, 279)
        Me.tbCadastroItem.TabIndex = 0
        Me.tbCadastroItem.Text = "Cadastro de Itens"
        Me.tbCadastroItem.UseVisualStyleBackColor = True
        '
        'cbxTipoItem
        '
        Me.cbxTipoItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoItem.FormattingEnabled = True
        Me.cbxTipoItem.Location = New System.Drawing.Point(167, 14)
        Me.cbxTipoItem.Name = "cbxTipoItem"
        Me.cbxTipoItem.Size = New System.Drawing.Size(121, 21)
        Me.cbxTipoItem.TabIndex = 7
        '
        'btnCadastrar
        '
        Me.btnCadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastrar.Location = New System.Drawing.Point(167, 180)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(126, 28)
        Me.btnCadastrar.TabIndex = 6
        Me.btnCadastrar.Text = "Cadastrar Item"
        Me.btnCadastrar.UseVisualStyleBackColor = True
        '
        'txtCustoUnitario
        '
        Me.txtCustoUnitario.Location = New System.Drawing.Point(167, 42)
        Me.txtCustoUnitario.MaxLength = 10
        Me.txtCustoUnitario.Name = "txtCustoUnitario"
        Me.txtCustoUnitario.Size = New System.Drawing.Size(100, 20)
        Me.txtCustoUnitario.TabIndex = 5
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(167, 68)
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(156, 106)
        Me.txtDescricao.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Custo Unitário: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descrição do Item: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo do Item: "
        '
        'tbEdicaoItem
        '
        Me.tbEdicaoItem.Controls.Add(Me.cbxEdicaoIdItem)
        Me.tbEdicaoItem.Controls.Add(Me.Label10)
        Me.tbEdicaoItem.Controls.Add(Me.pnlEdicaoItem)
        Me.tbEdicaoItem.Location = New System.Drawing.Point(4, 22)
        Me.tbEdicaoItem.Name = "tbEdicaoItem"
        Me.tbEdicaoItem.Padding = New System.Windows.Forms.Padding(3)
        Me.tbEdicaoItem.Size = New System.Drawing.Size(339, 279)
        Me.tbEdicaoItem.TabIndex = 1
        Me.tbEdicaoItem.Text = "Edição de Itens"
        Me.tbEdicaoItem.UseVisualStyleBackColor = True
        '
        'cbxEdicaoIdItem
        '
        Me.cbxEdicaoIdItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEdicaoIdItem.FormattingEnabled = True
        Me.cbxEdicaoIdItem.Location = New System.Drawing.Point(122, 12)
        Me.cbxEdicaoIdItem.Name = "cbxEdicaoIdItem"
        Me.cbxEdicaoIdItem.Size = New System.Drawing.Size(121, 21)
        Me.cbxEdicaoIdItem.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(31, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 20)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Id do Item:"
        '
        'pnlEdicaoItem
        '
        Me.pnlEdicaoItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlEdicaoItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlEdicaoItem.Controls.Add(Me.btnSalvarEdicao)
        Me.pnlEdicaoItem.Controls.Add(Me.Label4)
        Me.pnlEdicaoItem.Controls.Add(Me.cbxEdicaoTipoItem)
        Me.pnlEdicaoItem.Controls.Add(Me.txtEdicaoDescricao)
        Me.pnlEdicaoItem.Controls.Add(Me.txtEdicaoCustoUnitario)
        Me.pnlEdicaoItem.Controls.Add(Me.Label6)
        Me.pnlEdicaoItem.Controls.Add(Me.Label5)
        Me.pnlEdicaoItem.Location = New System.Drawing.Point(19, 41)
        Me.pnlEdicaoItem.Name = "pnlEdicaoItem"
        Me.pnlEdicaoItem.Size = New System.Drawing.Size(301, 223)
        Me.pnlEdicaoItem.TabIndex = 2
        Me.pnlEdicaoItem.Visible = False
        '
        'btnSalvarEdicao
        '
        Me.btnSalvarEdicao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvarEdicao.Location = New System.Drawing.Point(132, 181)
        Me.btnSalvarEdicao.Name = "btnSalvarEdicao"
        Me.btnSalvarEdicao.Size = New System.Drawing.Size(139, 29)
        Me.btnSalvarEdicao.TabIndex = 4
        Me.btnSalvarEdicao.Text = "Salvar alterações"
        Me.btnSalvarEdicao.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Tipo do Item: "
        '
        'cbxEdicaoTipoItem
        '
        Me.cbxEdicaoTipoItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEdicaoTipoItem.FormattingEnabled = True
        Me.cbxEdicaoTipoItem.Location = New System.Drawing.Point(132, 15)
        Me.cbxEdicaoTipoItem.Name = "cbxEdicaoTipoItem"
        Me.cbxEdicaoTipoItem.Size = New System.Drawing.Size(121, 21)
        Me.cbxEdicaoTipoItem.TabIndex = 0
        '
        'txtEdicaoDescricao
        '
        Me.txtEdicaoDescricao.Location = New System.Drawing.Point(132, 67)
        Me.txtEdicaoDescricao.Multiline = True
        Me.txtEdicaoDescricao.Name = "txtEdicaoDescricao"
        Me.txtEdicaoDescricao.Size = New System.Drawing.Size(157, 108)
        Me.txtEdicaoDescricao.TabIndex = 3
        '
        'txtEdicaoCustoUnitario
        '
        Me.txtEdicaoCustoUnitario.Location = New System.Drawing.Point(132, 41)
        Me.txtEdicaoCustoUnitario.MaxLength = 10
        Me.txtEdicaoCustoUnitario.Name = "txtEdicaoCustoUnitario"
        Me.txtEdicaoCustoUnitario.Size = New System.Drawing.Size(100, 20)
        Me.txtEdicaoCustoUnitario.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Descrição: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Custo Unitário:"
        '
        'tbRemocaoItem
        '
        Me.tbRemocaoItem.Controls.Add(Me.Label11)
        Me.tbRemocaoItem.Controls.Add(Me.cbxRemocaoIdItem)
        Me.tbRemocaoItem.Controls.Add(Me.pnlRemocaoItem)
        Me.tbRemocaoItem.Location = New System.Drawing.Point(4, 22)
        Me.tbRemocaoItem.Name = "tbRemocaoItem"
        Me.tbRemocaoItem.Padding = New System.Windows.Forms.Padding(3)
        Me.tbRemocaoItem.Size = New System.Drawing.Size(339, 279)
        Me.tbRemocaoItem.TabIndex = 2
        Me.tbRemocaoItem.Text = "Remoção de Itens"
        Me.tbRemocaoItem.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(32, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 20)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Id do Item:"
        '
        'cbxRemocaoIdItem
        '
        Me.cbxRemocaoIdItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRemocaoIdItem.FormattingEnabled = True
        Me.cbxRemocaoIdItem.Location = New System.Drawing.Point(123, 13)
        Me.cbxRemocaoIdItem.Name = "cbxRemocaoIdItem"
        Me.cbxRemocaoIdItem.Size = New System.Drawing.Size(121, 21)
        Me.cbxRemocaoIdItem.TabIndex = 3
        '
        'pnlRemocaoItem
        '
        Me.pnlRemocaoItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlRemocaoItem.Controls.Add(Me.btnRemocaoItem)
        Me.pnlRemocaoItem.Controls.Add(Me.cbxRemocaoTipoItem)
        Me.pnlRemocaoItem.Controls.Add(Me.txtRemocaoDescricao)
        Me.pnlRemocaoItem.Controls.Add(Me.Label7)
        Me.pnlRemocaoItem.Controls.Add(Me.txtRemocaoCustoUnitario)
        Me.pnlRemocaoItem.Controls.Add(Me.Label9)
        Me.pnlRemocaoItem.Controls.Add(Me.Label8)
        Me.pnlRemocaoItem.Location = New System.Drawing.Point(19, 41)
        Me.pnlRemocaoItem.Name = "pnlRemocaoItem"
        Me.pnlRemocaoItem.Size = New System.Drawing.Size(304, 222)
        Me.pnlRemocaoItem.TabIndex = 2
        Me.pnlRemocaoItem.Visible = False
        '
        'btnRemocaoItem
        '
        Me.btnRemocaoItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemocaoItem.Location = New System.Drawing.Point(133, 180)
        Me.btnRemocaoItem.Name = "btnRemocaoItem"
        Me.btnRemocaoItem.Size = New System.Drawing.Size(122, 27)
        Me.btnRemocaoItem.TabIndex = 4
        Me.btnRemocaoItem.Text = "Remover Item"
        Me.btnRemocaoItem.UseVisualStyleBackColor = True
        '
        'cbxRemocaoTipoItem
        '
        Me.cbxRemocaoTipoItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRemocaoTipoItem.FormattingEnabled = True
        Me.cbxRemocaoTipoItem.Location = New System.Drawing.Point(133, 16)
        Me.cbxRemocaoTipoItem.Name = "cbxRemocaoTipoItem"
        Me.cbxRemocaoTipoItem.Size = New System.Drawing.Size(121, 21)
        Me.cbxRemocaoTipoItem.TabIndex = 1
        '
        'txtRemocaoDescricao
        '
        Me.txtRemocaoDescricao.Enabled = False
        Me.txtRemocaoDescricao.Location = New System.Drawing.Point(133, 68)
        Me.txtRemocaoDescricao.Multiline = True
        Me.txtRemocaoDescricao.Name = "txtRemocaoDescricao"
        Me.txtRemocaoDescricao.Size = New System.Drawing.Size(157, 106)
        Me.txtRemocaoDescricao.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Tipo do Item: "
        '
        'txtRemocaoCustoUnitario
        '
        Me.txtRemocaoCustoUnitario.Enabled = False
        Me.txtRemocaoCustoUnitario.Location = New System.Drawing.Point(133, 42)
        Me.txtRemocaoCustoUnitario.Name = "txtRemocaoCustoUnitario"
        Me.txtRemocaoCustoUnitario.Size = New System.Drawing.Size(100, 20)
        Me.txtRemocaoCustoUnitario.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 20)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Descrição: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Custo Unitário:"
        '
        'tbListagemItem
        '
        Me.tbListagemItem.Controls.Add(Me.DataGridView1)
        Me.tbListagemItem.Location = New System.Drawing.Point(4, 22)
        Me.tbListagemItem.Name = "tbListagemItem"
        Me.tbListagemItem.Padding = New System.Windows.Forms.Padding(3)
        Me.tbListagemItem.Size = New System.Drawing.Size(444, 361)
        Me.tbListagemItem.TabIndex = 3
        Me.tbListagemItem.Text = "Listagem de Itens"
        Me.tbListagemItem.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(432, 273)
        Me.DataGridView1.TabIndex = 0
        '
        'BindingSource1
        '
        '
        'CadastroItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(476, 411)
        Me.Controls.Add(Me.tcItem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CadastroItem"
        Me.Text = "Mountain Ville - Cadastro Item"
        Me.tcItem.ResumeLayout(False)
        Me.tbCadastroItem.ResumeLayout(False)
        Me.tbCadastroItem.PerformLayout()
        Me.tbEdicaoItem.ResumeLayout(False)
        Me.tbEdicaoItem.PerformLayout()
        Me.pnlEdicaoItem.ResumeLayout(False)
        Me.pnlEdicaoItem.PerformLayout()
        Me.tbRemocaoItem.ResumeLayout(False)
        Me.tbRemocaoItem.PerformLayout()
        Me.pnlRemocaoItem.ResumeLayout(False)
        Me.pnlRemocaoItem.PerformLayout()
        Me.tbListagemItem.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcItem As System.Windows.Forms.TabControl
    Friend WithEvents tbCadastroItem As System.Windows.Forms.TabPage
    Friend WithEvents tbEdicaoItem As System.Windows.Forms.TabPage
    Friend WithEvents btnCadastrar As System.Windows.Forms.Button
    Friend WithEvents txtCustoUnitario As System.Windows.Forms.TextBox
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbRemocaoItem As System.Windows.Forms.TabPage
    Friend WithEvents tbListagemItem As System.Windows.Forms.TabPage
    Friend WithEvents pnlEdicaoItem As System.Windows.Forms.Panel
    Friend WithEvents btnSalvarEdicao As System.Windows.Forms.Button
    Friend WithEvents txtEdicaoDescricao As System.Windows.Forms.TextBox
    Friend WithEvents txtEdicaoCustoUnitario As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pnlRemocaoItem As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnRemocaoItem As System.Windows.Forms.Button
    Friend WithEvents txtRemocaoDescricao As System.Windows.Forms.TextBox
    Friend WithEvents txtRemocaoCustoUnitario As System.Windows.Forms.TextBox
    Friend WithEvents cbxEdicaoIdItem As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbxRemocaoIdItem As System.Windows.Forms.ComboBox
    Friend WithEvents cbxTipoItem As System.Windows.Forms.ComboBox
    Friend WithEvents cbxEdicaoTipoItem As System.Windows.Forms.ComboBox
    Friend WithEvents cbxRemocaoTipoItem As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
End Class
