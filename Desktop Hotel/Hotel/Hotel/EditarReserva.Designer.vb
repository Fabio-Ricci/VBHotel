<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarReserva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditarReserva))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tipoApartamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Situacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroBoleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataFim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idReserva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DGreserva = New System.Windows.Forms.DataGridView()
        Me.CBXsituacao = New System.Windows.Forms.ComboBox()
        Me.CBXtipoApartamento = New System.Windows.Forms.ComboBox()
        Me.TXTnumeroBoleto = New System.Windows.Forms.TextBox()
        Me.TXTdataFim = New System.Windows.Forms.TextBox()
        Me.TXTdataInicio = New System.Windows.Forms.TextBox()
        Me.TXTnomeCLiente = New System.Windows.Forms.TextBox()
        Me.TXTidCliente = New System.Windows.Forms.TextBox()
        Me.TXTIDreserva = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGreserva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(606, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "Voltar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(173, 463)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = " Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tipoApartamento
        '
        Me.tipoApartamento.HeaderText = "tipo Apartamento"
        Me.tipoApartamento.Name = "tipoApartamento"
        Me.tipoApartamento.ReadOnly = True
        '
        'Situacao
        '
        Me.Situacao.HeaderText = "Situação"
        Me.Situacao.Name = "Situacao"
        Me.Situacao.ReadOnly = True
        '
        'NumeroBoleto
        '
        Me.NumeroBoleto.HeaderText = "Numero Boleto"
        Me.NumeroBoleto.Name = "NumeroBoleto"
        Me.NumeroBoleto.ReadOnly = True
        '
        'DataFim
        '
        Me.DataFim.HeaderText = "Data fim"
        Me.DataFim.Name = "DataFim"
        Me.DataFim.ReadOnly = True
        '
        'DataInicio
        '
        Me.DataInicio.HeaderText = "Data Inicio"
        Me.DataInicio.Name = "DataInicio"
        Me.DataInicio.ReadOnly = True
        '
        'NomeCliente
        '
        Me.NomeCliente.HeaderText = "Nome Cliente"
        Me.NomeCliente.Name = "NomeCliente"
        Me.NomeCliente.ReadOnly = True
        '
        'idCliente
        '
        Me.idCliente.HeaderText = "ID Cliente"
        Me.idCliente.Name = "idCliente"
        Me.idCliente.ReadOnly = True
        '
        'idReserva
        '
        Me.idReserva.HeaderText = "ID Reserva"
        Me.idReserva.Name = "idReserva"
        Me.idReserva.ReadOnly = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(77, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(166, 26)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Edição Reserva"
        '
        'DGreserva
        '
        Me.DGreserva.AllowUserToAddRows = False
        Me.DGreserva.AllowUserToDeleteRows = False
        Me.DGreserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGreserva.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idReserva, Me.idCliente, Me.NomeCliente, Me.DataInicio, Me.DataFim, Me.NumeroBoleto, Me.Situacao, Me.tipoApartamento})
        Me.DGreserva.Location = New System.Drawing.Point(335, 85)
        Me.DGreserva.Name = "DGreserva"
        Me.DGreserva.ReadOnly = True
        Me.DGreserva.Size = New System.Drawing.Size(848, 477)
        Me.DGreserva.TabIndex = 36
        '
        'CBXsituacao
        '
        Me.CBXsituacao.FormattingEnabled = True
        Me.CBXsituacao.Items.AddRange(New Object() {"Pendente", "confirmada", "finalizada", "cancelada"})
        Me.CBXsituacao.Location = New System.Drawing.Point(173, 364)
        Me.CBXsituacao.Name = "CBXsituacao"
        Me.CBXsituacao.Size = New System.Drawing.Size(121, 21)
        Me.CBXsituacao.TabIndex = 35
        '
        'CBXtipoApartamento
        '
        Me.CBXtipoApartamento.FormattingEnabled = True
        Me.CBXtipoApartamento.Location = New System.Drawing.Point(173, 399)
        Me.CBXtipoApartamento.Name = "CBXtipoApartamento"
        Me.CBXtipoApartamento.Size = New System.Drawing.Size(121, 21)
        Me.CBXtipoApartamento.TabIndex = 34
        '
        'TXTnumeroBoleto
        '
        Me.TXTnumeroBoleto.Location = New System.Drawing.Point(173, 324)
        Me.TXTnumeroBoleto.Name = "TXTnumeroBoleto"
        Me.TXTnumeroBoleto.Size = New System.Drawing.Size(121, 20)
        Me.TXTnumeroBoleto.TabIndex = 33
        '
        'TXTdataFim
        '
        Me.TXTdataFim.Location = New System.Drawing.Point(173, 285)
        Me.TXTdataFim.Name = "TXTdataFim"
        Me.TXTdataFim.Size = New System.Drawing.Size(121, 20)
        Me.TXTdataFim.TabIndex = 32
        '
        'TXTdataInicio
        '
        Me.TXTdataInicio.Location = New System.Drawing.Point(173, 245)
        Me.TXTdataInicio.Name = "TXTdataInicio"
        Me.TXTdataInicio.Size = New System.Drawing.Size(121, 20)
        Me.TXTdataInicio.TabIndex = 31
        '
        'TXTnomeCLiente
        '
        Me.TXTnomeCLiente.Location = New System.Drawing.Point(173, 202)
        Me.TXTnomeCLiente.Name = "TXTnomeCLiente"
        Me.TXTnomeCLiente.Size = New System.Drawing.Size(121, 20)
        Me.TXTnomeCLiente.TabIndex = 30
        '
        'TXTidCliente
        '
        Me.TXTidCliente.Location = New System.Drawing.Point(173, 160)
        Me.TXTidCliente.Name = "TXTidCliente"
        Me.TXTidCliente.Size = New System.Drawing.Size(121, 20)
        Me.TXTidCliente.TabIndex = 29
        '
        'TXTIDreserva
        '
        Me.TXTIDreserva.Location = New System.Drawing.Point(173, 118)
        Me.TXTIDreserva.Name = "TXTIDreserva"
        Me.TXTIDreserva.Size = New System.Drawing.Size(121, 20)
        Me.TXTIDreserva.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(62, 402)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Tipo Apartamento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(62, 367)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Situação"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(62, 327)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Numero Boleto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(62, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Data Fim"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(62, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Data Início"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(62, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Nome Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(62, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "ID Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(62, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "ID Reserva"
        '
        'EditarReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1244, 586)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DGreserva)
        Me.Controls.Add(Me.CBXsituacao)
        Me.Controls.Add(Me.CBXtipoApartamento)
        Me.Controls.Add(Me.TXTnumeroBoleto)
        Me.Controls.Add(Me.TXTdataFim)
        Me.Controls.Add(Me.TXTdataInicio)
        Me.Controls.Add(Me.TXTnomeCLiente)
        Me.Controls.Add(Me.TXTidCliente)
        Me.Controls.Add(Me.TXTIDreserva)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditarReserva"
        Me.Text = "Mountain Ville - Editar Reserva"
        CType(Me.DGreserva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tipoApartamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Situacao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroBoleto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataFim As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idReserva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DGreserva As System.Windows.Forms.DataGridView
    Friend WithEvents CBXsituacao As System.Windows.Forms.ComboBox
    Friend WithEvents CBXtipoApartamento As System.Windows.Forms.ComboBox
    Friend WithEvents TXTnumeroBoleto As System.Windows.Forms.TextBox
    Friend WithEvents TXTdataFim As System.Windows.Forms.TextBox
    Friend WithEvents TXTdataInicio As System.Windows.Forms.TextBox
    Friend WithEvents TXTnomeCLiente As System.Windows.Forms.TextBox
    Friend WithEvents TXTidCliente As System.Windows.Forms.TextBox
    Friend WithEvents TXTIDreserva As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
