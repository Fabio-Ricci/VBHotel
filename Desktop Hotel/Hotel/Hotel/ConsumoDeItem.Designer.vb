<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsumoDeItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsumoDeItem))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxItem = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtQtd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDia = New System.Windows.Forms.TextBox()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CPF: "
        '
        'txtCpf
        '
        Me.txtCpf.Location = New System.Drawing.Point(118, 15)
        Me.txtCpf.Mask = "000.000.000-00"
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(88, 20)
        Me.txtCpf.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Item: "
        '
        'cbxItem
        '
        Me.cbxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxItem.FormattingEnabled = True
        Me.cbxItem.Location = New System.Drawing.Point(118, 41)
        Me.cbxItem.Name = "cbxItem"
        Me.cbxItem.Size = New System.Drawing.Size(121, 21)
        Me.cbxItem.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Quantidade: "
        '
        'txtQtd
        '
        Me.txtQtd.Location = New System.Drawing.Point(118, 70)
        Me.txtQtd.MaxLength = 3
        Me.txtQtd.Name = "txtQtd"
        Me.txtQtd.Size = New System.Drawing.Size(100, 20)
        Me.txtQtd.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Data Atual: "
        '
        'txtDia
        '
        Me.txtDia.Enabled = False
        Me.txtDia.Location = New System.Drawing.Point(118, 98)
        Me.txtDia.MaxLength = 2
        Me.txtDia.Name = "txtDia"
        Me.txtDia.Size = New System.Drawing.Size(22, 20)
        Me.txtDia.TabIndex = 7
        '
        'txtMes
        '
        Me.txtMes.Enabled = False
        Me.txtMes.Location = New System.Drawing.Point(165, 98)
        Me.txtMes.MaxLength = 2
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(22, 20)
        Me.txtMes.TabIndex = 8
        '
        'txtAno
        '
        Me.txtAno.Enabled = False
        Me.txtAno.Location = New System.Drawing.Point(212, 98)
        Me.txtAno.MaxLength = 4
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(46, 20)
        Me.txtAno.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(146, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "/"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(193, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "/"
        '
        'btnSalvar
        '
        Me.btnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.Location = New System.Drawing.Point(118, 135)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(66, 27)
        Me.btnSalvar.TabIndex = 13
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'ConsumoDeItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(284, 174)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAno)
        Me.Controls.Add(Me.txtMes)
        Me.Controls.Add(Me.txtDia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtQtd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbxItem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCpf)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConsumoDeItem"
        Me.Text = "Consumo De Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbxItem As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtQtd As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDia As System.Windows.Forms.TextBox
    Friend WithEvents txtMes As System.Windows.Forms.TextBox
    Friend WithEvents txtAno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
End Class
