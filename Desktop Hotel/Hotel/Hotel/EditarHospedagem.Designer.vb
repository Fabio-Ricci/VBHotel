<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarHospedagem
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditarHospedagem))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTidHospedagem = New System.Windows.Forms.TextBox()
        Me.TXTidApartamento = New System.Windows.Forms.TextBox()
        Me.TXTIDreserva = New System.Windows.Forms.TextBox()
        Me.TXTorigem = New System.Windows.Forms.TextBox()
        Me.TXTdestino = New System.Windows.Forms.TextBox()
        Me.CBXtipogrupo = New System.Windows.Forms.ComboBox()
        Me.CBXmotivoViagem = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MotivoViagem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDoGrupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Destino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Origem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDreserva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDAPARTAMENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDhospedagem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGHospedagem = New System.Windows.Forms.DataGridView()
        CType(Me.DGHospedagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(578, 54)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Voltar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(128, 447)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(62, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(194, 25)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Edição Hospedagem"
        '
        'TXTidHospedagem
        '
        Me.TXTidHospedagem.Location = New System.Drawing.Point(186, 170)
        Me.TXTidHospedagem.Name = "TXTidHospedagem"
        Me.TXTidHospedagem.Size = New System.Drawing.Size(121, 20)
        Me.TXTidHospedagem.TabIndex = 32
        '
        'TXTidApartamento
        '
        Me.TXTidApartamento.Location = New System.Drawing.Point(186, 206)
        Me.TXTidApartamento.Name = "TXTidApartamento"
        Me.TXTidApartamento.Size = New System.Drawing.Size(121, 20)
        Me.TXTidApartamento.TabIndex = 31
        '
        'TXTIDreserva
        '
        Me.TXTIDreserva.Location = New System.Drawing.Point(186, 235)
        Me.TXTIDreserva.Name = "TXTIDreserva"
        Me.TXTIDreserva.Size = New System.Drawing.Size(121, 20)
        Me.TXTIDreserva.TabIndex = 30
        '
        'TXTorigem
        '
        Me.TXTorigem.Location = New System.Drawing.Point(186, 270)
        Me.TXTorigem.Name = "TXTorigem"
        Me.TXTorigem.Size = New System.Drawing.Size(121, 20)
        Me.TXTorigem.TabIndex = 29
        '
        'TXTdestino
        '
        Me.TXTdestino.Location = New System.Drawing.Point(186, 304)
        Me.TXTdestino.Name = "TXTdestino"
        Me.TXTdestino.Size = New System.Drawing.Size(121, 20)
        Me.TXTdestino.TabIndex = 28
        '
        'CBXtipogrupo
        '
        Me.CBXtipogrupo.FormattingEnabled = True
        Me.CBXtipogrupo.Items.AddRange(New Object() {"individual", "família", "casal", "amigos", "excursao", "outros"})
        Me.CBXtipogrupo.Location = New System.Drawing.Point(186, 331)
        Me.CBXtipogrupo.Name = "CBXtipogrupo"
        Me.CBXtipogrupo.Size = New System.Drawing.Size(121, 21)
        Me.CBXtipogrupo.TabIndex = 27
        '
        'CBXmotivoViagem
        '
        Me.CBXmotivoViagem.FormattingEnabled = True
        Me.CBXmotivoViagem.Items.AddRange(New Object() {"turismo", "congresso ou eventos", "trabalho", "motivo de saúde", "lua de mel", "visita a terceiros", "outros"})
        Me.CBXmotivoViagem.Location = New System.Drawing.Point(186, 368)
        Me.CBXmotivoViagem.Name = "CBXmotivoViagem"
        Me.CBXmotivoViagem.Size = New System.Drawing.Size(121, 21)
        Me.CBXmotivoViagem.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(64, 368)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Motivo viagem"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(64, 334)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Tipo do grupo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 304)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = " Destino"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "ID reserva"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "ID apartamento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "ID Hospedagem"
        '
        'MotivoViagem
        '
        Me.MotivoViagem.HeaderText = "Motivo Viagem"
        Me.MotivoViagem.Name = "MotivoViagem"
        Me.MotivoViagem.ReadOnly = True
        '
        'TipoDoGrupo
        '
        Me.TipoDoGrupo.HeaderText = "Tipo Do Grupo"
        Me.TipoDoGrupo.Name = "TipoDoGrupo"
        Me.TipoDoGrupo.ReadOnly = True
        '
        'Destino
        '
        Me.Destino.HeaderText = "Destino"
        Me.Destino.Name = "Destino"
        Me.Destino.ReadOnly = True
        '
        'Origem
        '
        Me.Origem.HeaderText = "Origem"
        Me.Origem.Name = "Origem"
        Me.Origem.ReadOnly = True
        '
        'IDreserva
        '
        Me.IDreserva.HeaderText = "ID Reserva"
        Me.IDreserva.Name = "IDreserva"
        Me.IDreserva.ReadOnly = True
        '
        'IDAPARTAMENTO
        '
        Me.IDAPARTAMENTO.HeaderText = "ID APartamento"
        Me.IDAPARTAMENTO.Name = "IDAPARTAMENTO"
        Me.IDAPARTAMENTO.ReadOnly = True
        '
        'IDhospedagem
        '
        Me.IDhospedagem.HeaderText = "ID Hospedagem"
        Me.IDhospedagem.Name = "IDhospedagem"
        Me.IDhospedagem.ReadOnly = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Origem"
        '
        'DGHospedagem
        '
        Me.DGHospedagem.AllowUserToAddRows = False
        Me.DGHospedagem.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGHospedagem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGHospedagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGHospedagem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDhospedagem, Me.IDAPARTAMENTO, Me.IDreserva, Me.Origem, Me.Destino, Me.TipoDoGrupo, Me.MotivoViagem})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGHospedagem.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGHospedagem.Location = New System.Drawing.Point(419, 118)
        Me.DGHospedagem.Name = "DGHospedagem"
        Me.DGHospedagem.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGHospedagem.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGHospedagem.Size = New System.Drawing.Size(742, 459)
        Me.DGHospedagem.TabIndex = 18
        '
        'EditarHospedagem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1222, 631)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TXTidHospedagem)
        Me.Controls.Add(Me.TXTidApartamento)
        Me.Controls.Add(Me.TXTIDreserva)
        Me.Controls.Add(Me.TXTorigem)
        Me.Controls.Add(Me.TXTdestino)
        Me.Controls.Add(Me.CBXtipogrupo)
        Me.Controls.Add(Me.CBXmotivoViagem)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DGHospedagem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditarHospedagem"
        Me.Text = "EditarHospedagem"
        CType(Me.DGHospedagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXTidHospedagem As System.Windows.Forms.TextBox
    Friend WithEvents TXTidApartamento As System.Windows.Forms.TextBox
    Friend WithEvents TXTIDreserva As System.Windows.Forms.TextBox
    Friend WithEvents TXTorigem As System.Windows.Forms.TextBox
    Friend WithEvents TXTdestino As System.Windows.Forms.TextBox
    Friend WithEvents CBXtipogrupo As System.Windows.Forms.ComboBox
    Friend WithEvents CBXmotivoViagem As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MotivoViagem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDoGrupo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Destino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Origem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDreserva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDAPARTAMENTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDhospedagem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DGHospedagem As System.Windows.Forms.DataGridView
End Class
