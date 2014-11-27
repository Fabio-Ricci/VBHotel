<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListagemTipoApartamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListagemTipoApartamento))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.HosPDeirosDataSet9 = New Hotel.HosPDeirosDataSet9()
        Me.HTipoApartamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HTipoApartamentoTableAdapter = New Hotel.HosPDeirosDataSet9TableAdapters.hTipoApartamentoTableAdapter()
        Me.IdTipoApartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescricaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarifaDiariaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HosPDeirosDataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HTipoApartamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdTipoApartamentoDataGridViewTextBoxColumn, Me.DescricaoDataGridViewTextBoxColumn, Me.TarifaDiariaDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HTipoApartamentoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(443, 141)
        Me.DataGridView1.TabIndex = 0
        '
        'HosPDeirosDataSet9
        '
        Me.HosPDeirosDataSet9.DataSetName = "HosPDeirosDataSet9"
        Me.HosPDeirosDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HTipoApartamentoBindingSource
        '
        Me.HTipoApartamentoBindingSource.DataMember = "hTipoApartamento"
        Me.HTipoApartamentoBindingSource.DataSource = Me.HosPDeirosDataSet9
        '
        'HTipoApartamentoTableAdapter
        '
        Me.HTipoApartamentoTableAdapter.ClearBeforeFill = True
        '
        'IdTipoApartamentoDataGridViewTextBoxColumn
        '
        Me.IdTipoApartamentoDataGridViewTextBoxColumn.DataPropertyName = "idTipoApartamento"
        Me.IdTipoApartamentoDataGridViewTextBoxColumn.HeaderText = "idTipoApartamento"
        Me.IdTipoApartamentoDataGridViewTextBoxColumn.Name = "IdTipoApartamentoDataGridViewTextBoxColumn"
        Me.IdTipoApartamentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescricaoDataGridViewTextBoxColumn
        '
        Me.DescricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao"
        Me.DescricaoDataGridViewTextBoxColumn.HeaderText = "descricao"
        Me.DescricaoDataGridViewTextBoxColumn.Name = "DescricaoDataGridViewTextBoxColumn"
        Me.DescricaoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TarifaDiariaDataGridViewTextBoxColumn
        '
        Me.TarifaDiariaDataGridViewTextBoxColumn.DataPropertyName = "tarifaDiaria"
        Me.TarifaDiariaDataGridViewTextBoxColumn.HeaderText = "tarifaDiaria"
        Me.TarifaDiariaDataGridViewTextBoxColumn.Name = "TarifaDiariaDataGridViewTextBoxColumn"
        Me.TarifaDiariaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ListagemTipoApartamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(468, 166)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ListagemTipoApartamento"
        Me.Text = "ListagemTipoApartamento"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HosPDeirosDataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HTipoApartamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents HosPDeirosDataSet9 As Hotel.HosPDeirosDataSet9
    Friend WithEvents HTipoApartamentoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HTipoApartamentoTableAdapter As Hotel.HosPDeirosDataSet9TableAdapters.hTipoApartamentoTableAdapter
    Friend WithEvents IdTipoApartamentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescricaoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TarifaDiariaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
