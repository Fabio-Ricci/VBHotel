<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListagemFuncionario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListagemFuncionario))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.HosPDeirosDataSet8 = New Hotel.HosPDeirosDataSet8()
        Me.HUsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HUsuarioTableAdapter = New Hotel.HosPDeirosDataSet8TableAdapters.hUsuarioTableAdapter()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NivelDePrivilegioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HosPDeirosDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HUsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsernameDataGridViewTextBoxColumn, Me.NivelDePrivilegioDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HUsuarioBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(243, 115)
        Me.DataGridView1.TabIndex = 0
        '
        'HosPDeirosDataSet8
        '
        Me.HosPDeirosDataSet8.DataSetName = "HosPDeirosDataSet8"
        Me.HosPDeirosDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HUsuarioBindingSource
        '
        Me.HUsuarioBindingSource.DataMember = "hUsuario"
        Me.HUsuarioBindingSource.DataSource = Me.HosPDeirosDataSet8
        '
        'HUsuarioTableAdapter
        '
        Me.HUsuarioTableAdapter.ClearBeforeFill = True
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NivelDePrivilegioDataGridViewTextBoxColumn
        '
        Me.NivelDePrivilegioDataGridViewTextBoxColumn.DataPropertyName = "NivelDePrivilegio"
        Me.NivelDePrivilegioDataGridViewTextBoxColumn.HeaderText = "NivelDePrivilegio"
        Me.NivelDePrivilegioDataGridViewTextBoxColumn.Name = "NivelDePrivilegioDataGridViewTextBoxColumn"
        Me.NivelDePrivilegioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ListagemFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(268, 140)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ListagemFuncionario"
        Me.Text = "ListagemFuncionario"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HosPDeirosDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HUsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents HosPDeirosDataSet8 As Hotel.HosPDeirosDataSet8
    Friend WithEvents HUsuarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HUsuarioTableAdapter As Hotel.HosPDeirosDataSet8TableAdapters.hUsuarioTableAdapter
    Friend WithEvents UsernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NivelDePrivilegioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
