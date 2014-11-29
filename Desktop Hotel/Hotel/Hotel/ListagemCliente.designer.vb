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
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.HosPDeirosDataSet6 = New Hotel.HosPDeirosDataSet6()
        Me.HClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HClienteTableAdapter = New Hotel.HosPDeirosDataSet6TableAdapters.hClienteTableAdapter()
        Me.dgListagemCliente = New System.Windows.Forms.DataGridView()
        Me.IdClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataNascimentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CelularDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnderecoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BairroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CidadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SiglaUFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HClienteBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.HosPDeirosDataSet7 = New Hotel.HosPDeirosDataSet7()
        Me.HClienteTableAdapter1 = New Hotel.HosPDeirosDataSet7TableAdapters.hClienteTableAdapter()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HosPDeirosDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgListagemCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HClienteBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HosPDeirosDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HosPDeirosDataSet6
        '
        Me.HosPDeirosDataSet6.DataSetName = "HosPDeirosDataSet6"
        Me.HosPDeirosDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HClienteBindingSource
        '
        Me.HClienteBindingSource.DataMember = "hCliente"
        Me.HClienteBindingSource.DataSource = Me.HosPDeirosDataSet6
        '
        'HClienteTableAdapter
        '
        Me.HClienteTableAdapter.ClearBeforeFill = True
        '
        'dgListagemCliente
        '
        Me.dgListagemCliente.AllowUserToAddRows = False
        Me.dgListagemCliente.AllowUserToDeleteRows = False
        Me.dgListagemCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgListagemCliente.AutoGenerateColumns = False
        Me.dgListagemCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListagemCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdClienteDataGridViewTextBoxColumn, Me.NomeDataGridViewTextBoxColumn, Me.DataNascimentoDataGridViewTextBoxColumn, Me.SexoDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.TelefoneDataGridViewTextBoxColumn, Me.CelularDataGridViewTextBoxColumn, Me.EnderecoDataGridViewTextBoxColumn, Me.BairroDataGridViewTextBoxColumn, Me.CidadeDataGridViewTextBoxColumn, Me.PaisDataGridViewTextBoxColumn, Me.SiglaUFDataGridViewTextBoxColumn, Me.CPFDataGridViewTextBoxColumn})
        Me.dgListagemCliente.DataSource = Me.HClienteBindingSource1
        Me.dgListagemCliente.Location = New System.Drawing.Point(12, 12)
        Me.dgListagemCliente.Name = "dgListagemCliente"
        Me.dgListagemCliente.ReadOnly = True
        Me.dgListagemCliente.Size = New System.Drawing.Size(1343, 195)
        Me.dgListagemCliente.TabIndex = 0
        '
        'IdClienteDataGridViewTextBoxColumn
        '
        Me.IdClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente"
        Me.IdClienteDataGridViewTextBoxColumn.HeaderText = "idCliente"
        Me.IdClienteDataGridViewTextBoxColumn.Name = "IdClienteDataGridViewTextBoxColumn"
        Me.IdClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomeDataGridViewTextBoxColumn
        '
        Me.NomeDataGridViewTextBoxColumn.DataPropertyName = "nome"
        Me.NomeDataGridViewTextBoxColumn.HeaderText = "nome"
        Me.NomeDataGridViewTextBoxColumn.Name = "NomeDataGridViewTextBoxColumn"
        Me.NomeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataNascimentoDataGridViewTextBoxColumn
        '
        Me.DataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "dataNascimento"
        Me.DataNascimentoDataGridViewTextBoxColumn.HeaderText = "dataNascimento"
        Me.DataNascimentoDataGridViewTextBoxColumn.Name = "DataNascimentoDataGridViewTextBoxColumn"
        Me.DataNascimentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SexoDataGridViewTextBoxColumn
        '
        Me.SexoDataGridViewTextBoxColumn.DataPropertyName = "sexo"
        Me.SexoDataGridViewTextBoxColumn.HeaderText = "sexo"
        Me.SexoDataGridViewTextBoxColumn.Name = "SexoDataGridViewTextBoxColumn"
        Me.SexoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefoneDataGridViewTextBoxColumn
        '
        Me.TelefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone"
        Me.TelefoneDataGridViewTextBoxColumn.HeaderText = "Telefone"
        Me.TelefoneDataGridViewTextBoxColumn.Name = "TelefoneDataGridViewTextBoxColumn"
        Me.TelefoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CelularDataGridViewTextBoxColumn
        '
        Me.CelularDataGridViewTextBoxColumn.DataPropertyName = "Celular"
        Me.CelularDataGridViewTextBoxColumn.HeaderText = "Celular"
        Me.CelularDataGridViewTextBoxColumn.Name = "CelularDataGridViewTextBoxColumn"
        Me.CelularDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EnderecoDataGridViewTextBoxColumn
        '
        Me.EnderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco"
        Me.EnderecoDataGridViewTextBoxColumn.HeaderText = "Endereco"
        Me.EnderecoDataGridViewTextBoxColumn.Name = "EnderecoDataGridViewTextBoxColumn"
        Me.EnderecoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BairroDataGridViewTextBoxColumn
        '
        Me.BairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro"
        Me.BairroDataGridViewTextBoxColumn.HeaderText = "Bairro"
        Me.BairroDataGridViewTextBoxColumn.Name = "BairroDataGridViewTextBoxColumn"
        Me.BairroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CidadeDataGridViewTextBoxColumn
        '
        Me.CidadeDataGridViewTextBoxColumn.DataPropertyName = "cidade"
        Me.CidadeDataGridViewTextBoxColumn.HeaderText = "cidade"
        Me.CidadeDataGridViewTextBoxColumn.Name = "CidadeDataGridViewTextBoxColumn"
        Me.CidadeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PaisDataGridViewTextBoxColumn
        '
        Me.PaisDataGridViewTextBoxColumn.DataPropertyName = "Pais"
        Me.PaisDataGridViewTextBoxColumn.HeaderText = "Pais"
        Me.PaisDataGridViewTextBoxColumn.Name = "PaisDataGridViewTextBoxColumn"
        Me.PaisDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SiglaUFDataGridViewTextBoxColumn
        '
        Me.SiglaUFDataGridViewTextBoxColumn.DataPropertyName = "SiglaUF"
        Me.SiglaUFDataGridViewTextBoxColumn.HeaderText = "SiglaUF"
        Me.SiglaUFDataGridViewTextBoxColumn.Name = "SiglaUFDataGridViewTextBoxColumn"
        Me.SiglaUFDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CPFDataGridViewTextBoxColumn
        '
        Me.CPFDataGridViewTextBoxColumn.DataPropertyName = "CPF"
        Me.CPFDataGridViewTextBoxColumn.HeaderText = "CPF"
        Me.CPFDataGridViewTextBoxColumn.Name = "CPFDataGridViewTextBoxColumn"
        Me.CPFDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HClienteBindingSource1
        '
        Me.HClienteBindingSource1.DataMember = "hCliente"
        Me.HClienteBindingSource1.DataSource = Me.HosPDeirosDataSet7
        '
        'HosPDeirosDataSet7
        '
        Me.HosPDeirosDataSet7.DataSetName = "HosPDeirosDataSet7"
        Me.HosPDeirosDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HClienteTableAdapter1
        '
        Me.HClienteTableAdapter1.ClearBeforeFill = True
        '
        'ListagemCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1367, 219)
        Me.Controls.Add(Me.dgListagemCliente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ListagemCliente"
        Me.Text = "Listagem"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HosPDeirosDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgListagemCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HClienteBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HosPDeirosDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents HosPDeirosDataSet6 As Hotel.HosPDeirosDataSet6
    Friend WithEvents HClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HClienteTableAdapter As Hotel.HosPDeirosDataSet6TableAdapters.hClienteTableAdapter
    Friend WithEvents dgListagemCliente As System.Windows.Forms.DataGridView
    Friend WithEvents HosPDeirosDataSet7 As Hotel.HosPDeirosDataSet7
    Friend WithEvents HClienteBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents HClienteTableAdapter1 As Hotel.HosPDeirosDataSet7TableAdapters.hClienteTableAdapter
    Friend WithEvents IdClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataNascimentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CelularDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EnderecoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BairroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CidadeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SiglaUFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
