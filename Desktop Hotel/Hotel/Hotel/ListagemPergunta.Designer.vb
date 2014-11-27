<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListagemPergunta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListagemPergunta))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.HosPDeirosDataSet10 = New Hotel.HosPDeirosDataSet10()
        Me.HPerguntaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HPerguntaTableAdapter = New Hotel.HosPDeirosDataSet10TableAdapters.hPerguntaTableAdapter()
        Me.IdPerguntaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PerguntaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RespostaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HosPDeirosDataSet10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HPerguntaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPerguntaDataGridViewTextBoxColumn, Me.PerguntaDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.RespostaDataGridViewTextBoxColumn, Me.IdClienteDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HPerguntaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(543, 139)
        Me.DataGridView1.TabIndex = 0
        '
        'HosPDeirosDataSet10
        '
        Me.HosPDeirosDataSet10.DataSetName = "HosPDeirosDataSet10"
        Me.HosPDeirosDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HPerguntaBindingSource
        '
        Me.HPerguntaBindingSource.DataMember = "hPergunta"
        Me.HPerguntaBindingSource.DataSource = Me.HosPDeirosDataSet10
        '
        'HPerguntaTableAdapter
        '
        Me.HPerguntaTableAdapter.ClearBeforeFill = True
        '
        'IdPerguntaDataGridViewTextBoxColumn
        '
        Me.IdPerguntaDataGridViewTextBoxColumn.DataPropertyName = "idPergunta"
        Me.IdPerguntaDataGridViewTextBoxColumn.HeaderText = "idPergunta"
        Me.IdPerguntaDataGridViewTextBoxColumn.Name = "IdPerguntaDataGridViewTextBoxColumn"
        Me.IdPerguntaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PerguntaDataGridViewTextBoxColumn
        '
        Me.PerguntaDataGridViewTextBoxColumn.DataPropertyName = "pergunta"
        Me.PerguntaDataGridViewTextBoxColumn.HeaderText = "pergunta"
        Me.PerguntaDataGridViewTextBoxColumn.Name = "PerguntaDataGridViewTextBoxColumn"
        Me.PerguntaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RespostaDataGridViewTextBoxColumn
        '
        Me.RespostaDataGridViewTextBoxColumn.DataPropertyName = "resposta"
        Me.RespostaDataGridViewTextBoxColumn.HeaderText = "resposta"
        Me.RespostaDataGridViewTextBoxColumn.Name = "RespostaDataGridViewTextBoxColumn"
        Me.RespostaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdClienteDataGridViewTextBoxColumn
        '
        Me.IdClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente"
        Me.IdClienteDataGridViewTextBoxColumn.HeaderText = "idCliente"
        Me.IdClienteDataGridViewTextBoxColumn.Name = "IdClienteDataGridViewTextBoxColumn"
        Me.IdClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ListagemPergunta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(568, 164)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ListagemPergunta"
        Me.Text = "ListagemPergunta"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HosPDeirosDataSet10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HPerguntaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents HosPDeirosDataSet10 As Hotel.HosPDeirosDataSet10
    Friend WithEvents HPerguntaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HPerguntaTableAdapter As Hotel.HosPDeirosDataSet10TableAdapters.hPerguntaTableAdapter
    Friend WithEvents IdPerguntaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PerguntaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RespostaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
