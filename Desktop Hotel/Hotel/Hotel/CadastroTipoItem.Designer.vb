<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroTipoItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadastroTipoItem))
        Me.tcTipoItem = New System.Windows.Forms.TabControl()
        Me.tbCadastroTipoItem = New System.Windows.Forms.TabPage()
        Me.btnCadastarTipoItem = New System.Windows.Forms.Button()
        Me.txtCadastroTipoItem = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbEdicaoTipoItem = New System.Windows.Forms.TabPage()
        Me.pnlEdicaoTipoItem = New System.Windows.Forms.Panel()
        Me.btnSalvarEdicao = New System.Windows.Forms.Button()
        Me.txtEdicaoDescricaoTipoItem = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxEdicaoIdTipoItem = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbRemocaoTipoItem = New System.Windows.Forms.TabPage()
        Me.pnlRemocaoTipoItem = New System.Windows.Forms.Panel()
        Me.btnRemovarTipoItem = New System.Windows.Forms.Button()
        Me.txtRemocaoDescricaoTipoItem = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxRemocaoIdTipoItem = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbListagemTipoItem = New System.Windows.Forms.TabPage()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tcTipoItem.SuspendLayout()
        Me.tbCadastroTipoItem.SuspendLayout()
        Me.tbEdicaoTipoItem.SuspendLayout()
        Me.pnlEdicaoTipoItem.SuspendLayout()
        Me.tbRemocaoTipoItem.SuspendLayout()
        Me.pnlRemocaoTipoItem.SuspendLayout()
        Me.tbListagemTipoItem.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcTipoItem
        '
        Me.tcTipoItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcTipoItem.Controls.Add(Me.tbCadastroTipoItem)
        Me.tcTipoItem.Controls.Add(Me.tbEdicaoTipoItem)
        Me.tcTipoItem.Controls.Add(Me.tbRemocaoTipoItem)
        Me.tcTipoItem.Controls.Add(Me.tbListagemTipoItem)
        Me.tcTipoItem.Location = New System.Drawing.Point(13, 13)
        Me.tcTipoItem.Name = "tcTipoItem"
        Me.tcTipoItem.SelectedIndex = 0
        Me.tcTipoItem.Size = New System.Drawing.Size(349, 285)
        Me.tcTipoItem.TabIndex = 0
        '
        'tbCadastroTipoItem
        '
        Me.tbCadastroTipoItem.Controls.Add(Me.btnCadastarTipoItem)
        Me.tbCadastroTipoItem.Controls.Add(Me.txtCadastroTipoItem)
        Me.tbCadastroTipoItem.Controls.Add(Me.Label1)
        Me.tbCadastroTipoItem.Location = New System.Drawing.Point(4, 22)
        Me.tbCadastroTipoItem.Name = "tbCadastroTipoItem"
        Me.tbCadastroTipoItem.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCadastroTipoItem.Size = New System.Drawing.Size(321, 130)
        Me.tbCadastroTipoItem.TabIndex = 0
        Me.tbCadastroTipoItem.Text = "Cadastro de Tipo de Item"
        Me.tbCadastroTipoItem.UseVisualStyleBackColor = True
        '
        'btnCadastarTipoItem
        '
        Me.btnCadastarTipoItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastarTipoItem.Location = New System.Drawing.Point(114, 45)
        Me.btnCadastarTipoItem.Name = "btnCadastarTipoItem"
        Me.btnCadastarTipoItem.Size = New System.Drawing.Size(100, 26)
        Me.btnCadastarTipoItem.TabIndex = 2
        Me.btnCadastarTipoItem.Text = "Cadastrar"
        Me.btnCadastarTipoItem.UseVisualStyleBackColor = True
        '
        'txtCadastroTipoItem
        '
        Me.txtCadastroTipoItem.Location = New System.Drawing.Point(114, 19)
        Me.txtCadastroTipoItem.MaxLength = 10
        Me.txtCadastroTipoItem.Name = "txtCadastroTipoItem"
        Me.txtCadastroTipoItem.Size = New System.Drawing.Size(100, 20)
        Me.txtCadastroTipoItem.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descrição: "
        '
        'tbEdicaoTipoItem
        '
        Me.tbEdicaoTipoItem.Controls.Add(Me.pnlEdicaoTipoItem)
        Me.tbEdicaoTipoItem.Controls.Add(Me.cbxEdicaoIdTipoItem)
        Me.tbEdicaoTipoItem.Controls.Add(Me.Label2)
        Me.tbEdicaoTipoItem.Location = New System.Drawing.Point(4, 22)
        Me.tbEdicaoTipoItem.Name = "tbEdicaoTipoItem"
        Me.tbEdicaoTipoItem.Padding = New System.Windows.Forms.Padding(3)
        Me.tbEdicaoTipoItem.Size = New System.Drawing.Size(321, 130)
        Me.tbEdicaoTipoItem.TabIndex = 1
        Me.tbEdicaoTipoItem.Text = "Edição de Tipo de Item"
        Me.tbEdicaoTipoItem.UseVisualStyleBackColor = True
        '
        'pnlEdicaoTipoItem
        '
        Me.pnlEdicaoTipoItem.Controls.Add(Me.btnSalvarEdicao)
        Me.pnlEdicaoTipoItem.Controls.Add(Me.txtEdicaoDescricaoTipoItem)
        Me.pnlEdicaoTipoItem.Controls.Add(Me.Label3)
        Me.pnlEdicaoTipoItem.Location = New System.Drawing.Point(7, 41)
        Me.pnlEdicaoTipoItem.Name = "pnlEdicaoTipoItem"
        Me.pnlEdicaoTipoItem.Size = New System.Drawing.Size(299, 62)
        Me.pnlEdicaoTipoItem.TabIndex = 2
        Me.pnlEdicaoTipoItem.Visible = False
        '
        'btnSalvarEdicao
        '
        Me.btnSalvarEdicao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvarEdicao.Location = New System.Drawing.Point(125, 31)
        Me.btnSalvarEdicao.Name = "btnSalvarEdicao"
        Me.btnSalvarEdicao.Size = New System.Drawing.Size(141, 28)
        Me.btnSalvarEdicao.TabIndex = 2
        Me.btnSalvarEdicao.Text = "Salvar Alterações"
        Me.btnSalvarEdicao.UseVisualStyleBackColor = True
        '
        'txtEdicaoDescricaoTipoItem
        '
        Me.txtEdicaoDescricaoTipoItem.Location = New System.Drawing.Point(166, 5)
        Me.txtEdicaoDescricaoTipoItem.MaxLength = 10
        Me.txtEdicaoDescricaoTipoItem.Name = "txtEdicaoDescricaoTipoItem"
        Me.txtEdicaoDescricaoTipoItem.Size = New System.Drawing.Size(100, 20)
        Me.txtEdicaoDescricaoTipoItem.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Descrição:"
        '
        'cbxEdicaoIdTipoItem
        '
        Me.cbxEdicaoIdTipoItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEdicaoIdTipoItem.FormattingEnabled = True
        Me.cbxEdicaoIdTipoItem.Location = New System.Drawing.Point(173, 19)
        Me.cbxEdicaoIdTipoItem.Name = "cbxEdicaoIdTipoItem"
        Me.cbxEdicaoIdTipoItem.Size = New System.Drawing.Size(121, 21)
        Me.cbxEdicaoIdTipoItem.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID do Tipo do Item: "
        '
        'tbRemocaoTipoItem
        '
        Me.tbRemocaoTipoItem.Controls.Add(Me.pnlRemocaoTipoItem)
        Me.tbRemocaoTipoItem.Controls.Add(Me.cbxRemocaoIdTipoItem)
        Me.tbRemocaoTipoItem.Controls.Add(Me.Label4)
        Me.tbRemocaoTipoItem.Location = New System.Drawing.Point(4, 22)
        Me.tbRemocaoTipoItem.Name = "tbRemocaoTipoItem"
        Me.tbRemocaoTipoItem.Padding = New System.Windows.Forms.Padding(3)
        Me.tbRemocaoTipoItem.Size = New System.Drawing.Size(321, 130)
        Me.tbRemocaoTipoItem.TabIndex = 2
        Me.tbRemocaoTipoItem.Text = "Remoção de Tipo de Item"
        Me.tbRemocaoTipoItem.UseVisualStyleBackColor = True
        '
        'pnlRemocaoTipoItem
        '
        Me.pnlRemocaoTipoItem.Controls.Add(Me.btnRemovarTipoItem)
        Me.pnlRemocaoTipoItem.Controls.Add(Me.txtRemocaoDescricaoTipoItem)
        Me.pnlRemocaoTipoItem.Controls.Add(Me.Label5)
        Me.pnlRemocaoTipoItem.Location = New System.Drawing.Point(6, 40)
        Me.pnlRemocaoTipoItem.Name = "pnlRemocaoTipoItem"
        Me.pnlRemocaoTipoItem.Size = New System.Drawing.Size(303, 76)
        Me.pnlRemocaoTipoItem.TabIndex = 2
        Me.pnlRemocaoTipoItem.Visible = False
        '
        'btnRemovarTipoItem
        '
        Me.btnRemovarTipoItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemovarTipoItem.Location = New System.Drawing.Point(167, 34)
        Me.btnRemovarTipoItem.Name = "btnRemovarTipoItem"
        Me.btnRemovarTipoItem.Size = New System.Drawing.Size(100, 29)
        Me.btnRemovarTipoItem.TabIndex = 2
        Me.btnRemovarTipoItem.Text = "Remover"
        Me.btnRemovarTipoItem.UseVisualStyleBackColor = True
        '
        'txtRemocaoDescricaoTipoItem
        '
        Me.txtRemocaoDescricaoTipoItem.Enabled = False
        Me.txtRemocaoDescricaoTipoItem.Location = New System.Drawing.Point(167, 7)
        Me.txtRemocaoDescricaoTipoItem.MaxLength = 10
        Me.txtRemocaoDescricaoTipoItem.Name = "txtRemocaoDescricaoTipoItem"
        Me.txtRemocaoDescricaoTipoItem.Size = New System.Drawing.Size(100, 20)
        Me.txtRemocaoDescricaoTipoItem.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Descrição: "
        '
        'cbxRemocaoIdTipoItem
        '
        Me.cbxRemocaoIdTipoItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRemocaoIdTipoItem.FormattingEnabled = True
        Me.cbxRemocaoIdTipoItem.Location = New System.Drawing.Point(173, 19)
        Me.cbxRemocaoIdTipoItem.Name = "cbxRemocaoIdTipoItem"
        Me.cbxRemocaoIdTipoItem.Size = New System.Drawing.Size(121, 21)
        Me.cbxRemocaoIdTipoItem.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ID do Tipo do Item: "
        '
        'tbListagemTipoItem
        '
        Me.tbListagemTipoItem.Controls.Add(Me.DataGridView1)
        Me.tbListagemTipoItem.Location = New System.Drawing.Point(4, 22)
        Me.tbListagemTipoItem.Name = "tbListagemTipoItem"
        Me.tbListagemTipoItem.Padding = New System.Windows.Forms.Padding(3)
        Me.tbListagemTipoItem.Size = New System.Drawing.Size(341, 259)
        Me.tbListagemTipoItem.TabIndex = 3
        Me.tbListagemTipoItem.Text = "Listagem de Tipo de Item"
        Me.tbListagemTipoItem.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(329, 206)
        Me.DataGridView1.TabIndex = 0
        '
        'CadastroTipoItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(374, 310)
        Me.Controls.Add(Me.tcTipoItem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CadastroTipoItem"
        Me.Text = "Mountain Ville - Cadastro Tipo Item"
        Me.tcTipoItem.ResumeLayout(False)
        Me.tbCadastroTipoItem.ResumeLayout(False)
        Me.tbCadastroTipoItem.PerformLayout()
        Me.tbEdicaoTipoItem.ResumeLayout(False)
        Me.tbEdicaoTipoItem.PerformLayout()
        Me.pnlEdicaoTipoItem.ResumeLayout(False)
        Me.pnlEdicaoTipoItem.PerformLayout()
        Me.tbRemocaoTipoItem.ResumeLayout(False)
        Me.tbRemocaoTipoItem.PerformLayout()
        Me.pnlRemocaoTipoItem.ResumeLayout(False)
        Me.pnlRemocaoTipoItem.PerformLayout()
        Me.tbListagemTipoItem.ResumeLayout(False)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcTipoItem As System.Windows.Forms.TabControl
    Friend WithEvents tbCadastroTipoItem As System.Windows.Forms.TabPage
    Friend WithEvents tbEdicaoTipoItem As System.Windows.Forms.TabPage
    Friend WithEvents txtCadastroTipoItem As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlEdicaoTipoItem As System.Windows.Forms.Panel
    Friend WithEvents txtEdicaoDescricaoTipoItem As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbxEdicaoIdTipoItem As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbRemocaoTipoItem As System.Windows.Forms.TabPage
    Friend WithEvents pnlRemocaoTipoItem As System.Windows.Forms.Panel
    Friend WithEvents txtRemocaoDescricaoTipoItem As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbxRemocaoIdTipoItem As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbListagemTipoItem As System.Windows.Forms.TabPage
    Friend WithEvents btnSalvarEdicao As System.Windows.Forms.Button
    Friend WithEvents btnRemovarTipoItem As System.Windows.Forms.Button
    Friend WithEvents btnCadastarTipoItem As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
End Class
