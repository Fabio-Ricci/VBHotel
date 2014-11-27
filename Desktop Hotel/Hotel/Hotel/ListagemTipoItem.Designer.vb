<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListagemTipoItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListagemTipoItem))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.HosPDeirosDataSet4 = New Hotel.HosPDeirosDataSet4()
        Me.HTIPOITEMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HTIPOITEMTableAdapter = New Hotel.HosPDeirosDataSet4TableAdapters.HTIPOITEMTableAdapter()
        Me.NOMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTIPODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HosPDeirosDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HTIPOITEMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOMEDataGridViewTextBoxColumn, Me.IDTIPODataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HTIPOITEMBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(244, 179)
        Me.DataGridView1.TabIndex = 0
        '
        'HosPDeirosDataSet4
        '
        Me.HosPDeirosDataSet4.DataSetName = "HosPDeirosDataSet4"
        Me.HosPDeirosDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HTIPOITEMBindingSource
        '
        Me.HTIPOITEMBindingSource.DataMember = "HTIPOITEM"
        Me.HTIPOITEMBindingSource.DataSource = Me.HosPDeirosDataSet4
        '
        'HTIPOITEMTableAdapter
        '
        Me.HTIPOITEMTableAdapter.ClearBeforeFill = True
        '
        'NOMEDataGridViewTextBoxColumn
        '
        Me.NOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME"
        Me.NOMEDataGridViewTextBoxColumn.HeaderText = "NOME"
        Me.NOMEDataGridViewTextBoxColumn.Name = "NOMEDataGridViewTextBoxColumn"
        Me.NOMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDTIPODataGridViewTextBoxColumn
        '
        Me.IDTIPODataGridViewTextBoxColumn.DataPropertyName = "IDTIPO"
        Me.IDTIPODataGridViewTextBoxColumn.HeaderText = "IDTIPO"
        Me.IDTIPODataGridViewTextBoxColumn.Name = "IDTIPODataGridViewTextBoxColumn"
        Me.IDTIPODataGridViewTextBoxColumn.ReadOnly = True
        '
        'ListagemTipoItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(269, 204)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ListagemTipoItem"
        Me.Text = "ListagemTipoItem"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HosPDeirosDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HTIPOITEMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents HosPDeirosDataSet4 As Hotel.HosPDeirosDataSet4
    Friend WithEvents HTIPOITEMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HTIPOITEMTableAdapter As Hotel.HosPDeirosDataSet4TableAdapters.HTIPOITEMTableAdapter
    Friend WithEvents NOMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDTIPODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
