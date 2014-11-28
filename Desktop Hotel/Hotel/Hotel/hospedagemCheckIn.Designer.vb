<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hospedagemCheckIn
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CBXsexo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTdatanasc = New System.Windows.Forms.TextBox()
        Me.Celular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEXO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataNasc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DGcliente = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTCelular = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTcpf = New System.Windows.Forms.TextBox()
        Me.TXTtelefoneFixo = New System.Windows.Forms.TextBox()
        Me.TXTemail = New System.Windows.Forms.TextBox()
        Me.TXTnome = New System.Windows.Forms.TextBox()
        CType(Me.DGcliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(607, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "voltar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Green
        Me.Label11.ForeColor = System.Drawing.Color.Green
        Me.Label11.Location = New System.Drawing.Point(717, 559)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Label11"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(537, 559)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 17)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Não Possui Reserva"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Red
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(483, 561)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Label9"
        '
        'CBXsexo
        '
        Me.CBXsexo.FormattingEnabled = True
        Me.CBXsexo.Items.AddRange(New Object() {"", "F", "M"})
        Me.CBXsexo.Location = New System.Drawing.Point(168, 220)
        Me.CBXsexo.Name = "CBXsexo"
        Me.CBXsexo.Size = New System.Drawing.Size(158, 21)
        Me.CBXsexo.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(54, 402)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Data de nascimento:"
        '
        'TXTdatanasc
        '
        Me.TXTdatanasc.Location = New System.Drawing.Point(168, 399)
        Me.TXTdatanasc.Name = "TXTdatanasc"
        Me.TXTdatanasc.Size = New System.Drawing.Size(158, 20)
        Me.TXTdatanasc.TabIndex = 37
        '
        'Celular
        '
        Me.Celular.HeaderText = "Celular"
        Me.Celular.Name = "Celular"
        Me.Celular.ReadOnly = True
        '
        'Telefone
        '
        Me.Telefone.HeaderText = "Telefone"
        Me.Telefone.Name = "Telefone"
        Me.Telefone.ReadOnly = True
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        '
        'SEXO
        '
        Me.SEXO.HeaderText = "SEXO"
        Me.SEXO.Name = "SEXO"
        Me.SEXO.ReadOnly = True
        '
        'DataNasc
        '
        Me.DataNasc.HeaderText = "Data De Nascimento"
        Me.DataNasc.Name = "DataNasc"
        Me.DataNasc.ReadOnly = True
        '
        'CPF
        '
        Me.CPF.HeaderText = "CPF"
        Me.CPF.Name = "CPF"
        Me.CPF.ReadOnly = True
        '
        'Nome
        '
        Me.Nome.HeaderText = "Nome"
        Me.Nome.Name = "Nome"
        Me.Nome.ReadOnly = True
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(777, 557)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 17)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Possui Reserva"
        '
        'DGcliente
        '
        Me.DGcliente.AllowUserToAddRows = False
        Me.DGcliente.AllowUserToDeleteRows = False
        Me.DGcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGcliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nome, Me.CPF, Me.DataNasc, Me.SEXO, Me.Email, Me.Telefone, Me.Celular})
        Me.DGcliente.Location = New System.Drawing.Point(412, 57)
        Me.DGcliente.Name = "DGcliente"
        Me.DGcliente.ReadOnly = True
        Me.DGcliente.Size = New System.Drawing.Size(843, 481)
        Me.DGcliente.TabIndex = 36
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(132, 475)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 23)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(105, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(169, 19)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Pesquisa de Cliente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(54, 361)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Telefone celular:"
        '
        'TXTCelular
        '
        Me.TXTCelular.Location = New System.Drawing.Point(168, 358)
        Me.TXTCelular.Name = "TXTCelular"
        Me.TXTCelular.Size = New System.Drawing.Size(158, 20)
        Me.TXTCelular.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Nome:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "E-mail:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 310)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Telefone fixo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Sexo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "CPF:"
        '
        'TXTcpf
        '
        Me.TXTcpf.Location = New System.Drawing.Point(168, 174)
        Me.TXTcpf.Name = "TXTcpf"
        Me.TXTcpf.Size = New System.Drawing.Size(158, 20)
        Me.TXTcpf.TabIndex = 26
        '
        'TXTtelefoneFixo
        '
        Me.TXTtelefoneFixo.Location = New System.Drawing.Point(168, 310)
        Me.TXTtelefoneFixo.Name = "TXTtelefoneFixo"
        Me.TXTtelefoneFixo.Size = New System.Drawing.Size(158, 20)
        Me.TXTtelefoneFixo.TabIndex = 25
        '
        'TXTemail
        '
        Me.TXTemail.Location = New System.Drawing.Point(168, 265)
        Me.TXTemail.Name = "TXTemail"
        Me.TXTemail.Size = New System.Drawing.Size(158, 20)
        Me.TXTemail.TabIndex = 24
        '
        'TXTnome
        '
        Me.TXTnome.Location = New System.Drawing.Point(168, 124)
        Me.TXTnome.Name = "TXTnome"
        Me.TXTnome.Size = New System.Drawing.Size(158, 20)
        Me.TXTnome.TabIndex = 23
        '
        'hospedagemCheckIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1351, 643)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CBXsexo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TXTdatanasc)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DGcliente)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXTCelular)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTcpf)
        Me.Controls.Add(Me.TXTtelefoneFixo)
        Me.Controls.Add(Me.TXTemail)
        Me.Controls.Add(Me.TXTnome)
        Me.Name = "hospedagemCheckIn"
        Me.Text = "hospedagemCheckIn"
        CType(Me.DGcliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CBXsexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXTdatanasc As System.Windows.Forms.TextBox
    Friend WithEvents Celular As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEXO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataNasc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DGcliente As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXTCelular As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTcpf As System.Windows.Forms.TextBox
    Friend WithEvents TXTtelefoneFixo As System.Windows.Forms.TextBox
    Friend WithEvents TXTemail As System.Windows.Forms.TextBox
    Friend WithEvents TXTnome As System.Windows.Forms.TextBox
End Class
