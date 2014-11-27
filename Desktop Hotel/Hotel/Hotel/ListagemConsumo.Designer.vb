<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListagemConsumo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListagemConsumo))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.HosPDeirosDataSet5 = New Hotel.HosPDeirosDataSet5()
        Me.HConsumoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HConsumoTableAdapter = New Hotel.HosPDeirosDataSet5TableAdapters.hConsumoTableAdapter()
        Me.IdConsumoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdItemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdHospedagemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantidadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HosPDeirosDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HConsumoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdConsumoDataGridViewTextBoxColumn, Me.IdItemDataGridViewTextBoxColumn, Me.IdHospedagemDataGridViewTextBoxColumn, Me.QuantidadeDataGridViewTextBoxColumn, Me.DataDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HConsumoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(543, 175)
        Me.DataGridView1.TabIndex = 0
        '
        'HosPDeirosDataSet5
        '
        Me.HosPDeirosDataSet5.DataSetName = "HosPDeirosDataSet5"
        Me.HosPDeirosDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HConsumoBindingSource
        '
        Me.HConsumoBindingSource.DataMember = "hConsumo"
        Me.HConsumoBindingSource.DataSource = Me.HosPDeirosDataSet5
        '
        'HConsumoTableAdapter
        '
        Me.HConsumoTableAdapter.ClearBeforeFill = True
        '
        'IdConsumoDataGridViewTextBoxColumn
        '
        Me.IdConsumoDataGridViewTextBoxColumn.DataPropertyName = "idConsumo"
        Me.IdConsumoDataGridViewTextBoxColumn.HeaderText = "idConsumo"
        Me.IdConsumoDataGridViewTextBoxColumn.Name = "IdConsumoDataGridViewTextBoxColumn"
        Me.IdConsumoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdItemDataGridViewTextBoxColumn
        '
        Me.IdItemDataGridViewTextBoxColumn.DataPropertyName = "idItem"
        Me.IdItemDataGridViewTextBoxColumn.HeaderText = "idItem"
        Me.IdItemDataGridViewTextBoxColumn.Name = "IdItemDataGridViewTextBoxColumn"
        Me.IdItemDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdHospedagemDataGridViewTextBoxColumn
        '
        Me.IdHospedagemDataGridViewTextBoxColumn.DataPropertyName = "idHospedagem"
        Me.IdHospedagemDataGridViewTextBoxColumn.HeaderText = "idHospedagem"
        Me.IdHospedagemDataGridViewTextBoxColumn.Name = "IdHospedagemDataGridViewTextBoxColumn"
        Me.IdHospedagemDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantidadeDataGridViewTextBoxColumn
        '
        Me.QuantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade"
        Me.QuantidadeDataGridViewTextBoxColumn.HeaderText = "quantidade"
        Me.QuantidadeDataGridViewTextBoxColumn.Name = "QuantidadeDataGridViewTextBoxColumn"
        Me.QuantidadeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataDataGridViewTextBoxColumn
        '
        Me.DataDataGridViewTextBoxColumn.DataPropertyName = "data"
        Me.DataDataGridViewTextBoxColumn.HeaderText = "data"
        Me.DataDataGridViewTextBoxColumn.Name = "DataDataGridViewTextBoxColumn"
        Me.DataDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ListagemConsumo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(567, 199)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ListagemConsumo"
        Me.Text = "ListagemConsumo"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HosPDeirosDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HConsumoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents HosPDeirosDataSet5 As Hotel.HosPDeirosDataSet5
    Friend WithEvents HConsumoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HConsumoTableAdapter As Hotel.HosPDeirosDataSet5TableAdapters.hConsumoTableAdapter
    Friend WithEvents IdConsumoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdItemDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdHospedagemDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantidadeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
