<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListagemItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListagemItem))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdItemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoItemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescricaoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustoUnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HosPDeirosDataSet3 = New Hotel.HosPDeirosDataSet3()
        Me.HItemTableAdapter = New Hotel.HosPDeirosDataSet3TableAdapters.hItemTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HosPDeirosDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdItemDataGridViewTextBoxColumn, Me.TipoItemDataGridViewTextBoxColumn, Me.DescricaoDataGridViewTextBoxColumn, Me.CustoUnitarioDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HItemBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(443, 178)
        Me.DataGridView1.TabIndex = 0
        '
        'IdItemDataGridViewTextBoxColumn
        '
        Me.IdItemDataGridViewTextBoxColumn.DataPropertyName = "idItem"
        Me.IdItemDataGridViewTextBoxColumn.HeaderText = "idItem"
        Me.IdItemDataGridViewTextBoxColumn.Name = "IdItemDataGridViewTextBoxColumn"
        Me.IdItemDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoItemDataGridViewTextBoxColumn
        '
        Me.TipoItemDataGridViewTextBoxColumn.DataPropertyName = "tipoItem"
        Me.TipoItemDataGridViewTextBoxColumn.HeaderText = "tipoItem"
        Me.TipoItemDataGridViewTextBoxColumn.Name = "TipoItemDataGridViewTextBoxColumn"
        Me.TipoItemDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescricaoDataGridViewTextBoxColumn
        '
        Me.DescricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao"
        Me.DescricaoDataGridViewTextBoxColumn.HeaderText = "descricao"
        Me.DescricaoDataGridViewTextBoxColumn.Name = "DescricaoDataGridViewTextBoxColumn"
        Me.DescricaoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustoUnitarioDataGridViewTextBoxColumn
        '
        Me.CustoUnitarioDataGridViewTextBoxColumn.DataPropertyName = "custoUnitario"
        Me.CustoUnitarioDataGridViewTextBoxColumn.HeaderText = "custoUnitario"
        Me.CustoUnitarioDataGridViewTextBoxColumn.Name = "CustoUnitarioDataGridViewTextBoxColumn"
        Me.CustoUnitarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HItemBindingSource
        '
        Me.HItemBindingSource.DataMember = "hItem"
        Me.HItemBindingSource.DataSource = Me.HosPDeirosDataSet3
        '
        'HosPDeirosDataSet3
        '
        Me.HosPDeirosDataSet3.DataSetName = "HosPDeirosDataSet3"
        Me.HosPDeirosDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HItemTableAdapter
        '
        Me.HItemTableAdapter.ClearBeforeFill = True
        '
        'ListagemItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(468, 203)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ListagemItem"
        Me.Text = "ListagemItem"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HosPDeirosDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents HosPDeirosDataSet3 As Hotel.HosPDeirosDataSet3
    Friend WithEvents HItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HItemTableAdapter As Hotel.HosPDeirosDataSet3TableAdapters.hItemTableAdapter
    Friend WithEvents IdItemDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoItemDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescricaoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustoUnitarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
