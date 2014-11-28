<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListagemApartamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListagemApartamento))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdApartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTipoApartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AndarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CamaCasalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CamaSolteiroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FrigobarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HApartamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HosPDeirosDataSet2 = New Hotel.HosPDeirosDataSet2()
        Me.HApartamentoTableAdapter = New Hotel.HosPDeirosDataSet2TableAdapters.hApartamentoTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HApartamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HosPDeirosDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdApartamentoDataGridViewTextBoxColumn, Me.IdTipoApartamentoDataGridViewTextBoxColumn, Me.NumeroDataGridViewTextBoxColumn, Me.AndarDataGridViewTextBoxColumn, Me.CamaCasalDataGridViewTextBoxColumn, Me.CamaSolteiroDataGridViewTextBoxColumn, Me.FrigobarDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HApartamentoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(744, 243)
        Me.DataGridView1.TabIndex = 0
        '
        'IdApartamentoDataGridViewTextBoxColumn
        '
        Me.IdApartamentoDataGridViewTextBoxColumn.DataPropertyName = "idApartamento"
        Me.IdApartamentoDataGridViewTextBoxColumn.HeaderText = "idApartamento"
        Me.IdApartamentoDataGridViewTextBoxColumn.Name = "IdApartamentoDataGridViewTextBoxColumn"
        Me.IdApartamentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdTipoApartamentoDataGridViewTextBoxColumn
        '
        Me.IdTipoApartamentoDataGridViewTextBoxColumn.DataPropertyName = "idTipoApartamento"
        Me.IdTipoApartamentoDataGridViewTextBoxColumn.HeaderText = "idTipoApartamento"
        Me.IdTipoApartamentoDataGridViewTextBoxColumn.Name = "IdTipoApartamentoDataGridViewTextBoxColumn"
        Me.IdTipoApartamentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumeroDataGridViewTextBoxColumn
        '
        Me.NumeroDataGridViewTextBoxColumn.DataPropertyName = "numero"
        Me.NumeroDataGridViewTextBoxColumn.HeaderText = "numero"
        Me.NumeroDataGridViewTextBoxColumn.Name = "NumeroDataGridViewTextBoxColumn"
        Me.NumeroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AndarDataGridViewTextBoxColumn
        '
        Me.AndarDataGridViewTextBoxColumn.DataPropertyName = "andar"
        Me.AndarDataGridViewTextBoxColumn.HeaderText = "andar"
        Me.AndarDataGridViewTextBoxColumn.Name = "AndarDataGridViewTextBoxColumn"
        Me.AndarDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CamaCasalDataGridViewTextBoxColumn
        '
        Me.CamaCasalDataGridViewTextBoxColumn.DataPropertyName = "camaCasal"
        Me.CamaCasalDataGridViewTextBoxColumn.HeaderText = "camaCasal"
        Me.CamaCasalDataGridViewTextBoxColumn.Name = "CamaCasalDataGridViewTextBoxColumn"
        Me.CamaCasalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CamaSolteiroDataGridViewTextBoxColumn
        '
        Me.CamaSolteiroDataGridViewTextBoxColumn.DataPropertyName = "camaSolteiro"
        Me.CamaSolteiroDataGridViewTextBoxColumn.HeaderText = "camaSolteiro"
        Me.CamaSolteiroDataGridViewTextBoxColumn.Name = "CamaSolteiroDataGridViewTextBoxColumn"
        Me.CamaSolteiroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FrigobarDataGridViewTextBoxColumn
        '
        Me.FrigobarDataGridViewTextBoxColumn.DataPropertyName = "frigobar"
        Me.FrigobarDataGridViewTextBoxColumn.HeaderText = "frigobar"
        Me.FrigobarDataGridViewTextBoxColumn.Name = "FrigobarDataGridViewTextBoxColumn"
        Me.FrigobarDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HApartamentoBindingSource
        '
        Me.HApartamentoBindingSource.DataMember = "hApartamento"
        Me.HApartamentoBindingSource.DataSource = Me.HosPDeirosDataSet2
        '
        'HosPDeirosDataSet2
        '
        Me.HosPDeirosDataSet2.DataSetName = "HosPDeirosDataSet2"
        Me.HosPDeirosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HApartamentoTableAdapter
        '
        Me.HApartamentoTableAdapter.ClearBeforeFill = True
        '
        'ListagemApartamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(769, 268)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ListagemApartamento"
        Me.Text = "ListagemApartamento"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HApartamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HosPDeirosDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents HosPDeirosDataSet2 As Hotel.HosPDeirosDataSet2
    Friend WithEvents HApartamentoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HApartamentoTableAdapter As Hotel.HosPDeirosDataSet2TableAdapters.hApartamentoTableAdapter
    Friend WithEvents IdApartamentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdTipoApartamentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AndarDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CamaCasalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CamaSolteiroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FrigobarDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
