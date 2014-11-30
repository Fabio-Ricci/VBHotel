<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hospedagem_Reserva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hospedagem_Reserva))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBLgastoHospedagem = New System.Windows.Forms.Label()
        Me.BTNalterarReserva = New System.Windows.Forms.Button()
        Me.BTNincluir = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.CBXpagamento = New System.Windows.Forms.ComboBox()
        Me.LBLpagamento = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbxDiaInicio = New System.Windows.Forms.ComboBox()
        Me.CbxMesInicio = New System.Windows.Forms.ComboBox()
        Me.CbxAnoInicio = New System.Windows.Forms.ComboBox()
        Me.CBXcamaSolteiro = New System.Windows.Forms.ComboBox()
        Me.CBXcamaCasal = New System.Windows.Forms.ComboBox()
        Me.CBXfrigobar = New System.Windows.Forms.ComboBox()
        Me.lblDataInicio = New System.Windows.Forms.Label()
        Me.BTNvoltar = New System.Windows.Forms.Button()
        Me.RTXTdescricao = New System.Windows.Forms.RichTextBox()
        Me.BTNoriginal = New System.Windows.Forms.Button()
        Me.lblDiaria = New System.Windows.Forms.Label()
        Me.CBXTipoGrupo = New System.Windows.Forms.ComboBox()
        Me.LBLtipogrupo = New System.Windows.Forms.Label()
        Me.LBLviagem = New System.Windows.Forms.Label()
        Me.CBXmotivoViagem = New System.Windows.Forms.ComboBox()
        Me.LBLdestino = New System.Windows.Forms.Label()
        Me.TXTdestino = New System.Windows.Forms.TextBox()
        Me.TXTorigem = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BTNfotoAnterior = New System.Windows.Forms.Button()
        Me.BTNproximaFoto = New System.Windows.Forms.Button()
        Me.BTNConfirmar = New System.Windows.Forms.Button()
        Me.CBXdia = New System.Windows.Forms.ComboBox()
        Me.CBXmes = New System.Windows.Forms.ComboBox()
        Me.LBLorigem = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBXAno = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblx = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBXtipoApartamento = New System.Windows.Forms.ComboBox()
        Me.PBapartamento = New System.Windows.Forms.PictureBox()
        CType(Me.PBapartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(707, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Descricao"
        '
        'LBLgastoHospedagem
        '
        Me.LBLgastoHospedagem.AutoSize = True
        Me.LBLgastoHospedagem.Location = New System.Drawing.Point(153, 585)
        Me.LBLgastoHospedagem.Name = "LBLgastoHospedagem"
        Me.LBLgastoHospedagem.Size = New System.Drawing.Size(45, 13)
        Me.LBLgastoHospedagem.TabIndex = 86
        Me.LBLgastoHospedagem.Text = "Label11"
        Me.LBLgastoHospedagem.Visible = False
        '
        'BTNalterarReserva
        '
        Me.BTNalterarReserva.Location = New System.Drawing.Point(688, 537)
        Me.BTNalterarReserva.Name = "BTNalterarReserva"
        Me.BTNalterarReserva.Size = New System.Drawing.Size(129, 23)
        Me.BTNalterarReserva.TabIndex = 85
        Me.BTNalterarReserva.Text = "Confirmar Alteração"
        Me.BTNalterarReserva.UseVisualStyleBackColor = True
        '
        'BTNincluir
        '
        Me.BTNincluir.Location = New System.Drawing.Point(796, 488)
        Me.BTNincluir.Name = "BTNincluir"
        Me.BTNincluir.Size = New System.Drawing.Size(75, 23)
        Me.BTNincluir.TabIndex = 84
        Me.BTNincluir.Text = "Incluir"
        Me.BTNincluir.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(992, 450)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 83
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'CBXpagamento
        '
        Me.CBXpagamento.FormattingEnabled = True
        Me.CBXpagamento.Items.AddRange(New Object() {"S", "N"})
        Me.CBXpagamento.Location = New System.Drawing.Point(1041, 222)
        Me.CBXpagamento.Name = "CBXpagamento"
        Me.CBXpagamento.Size = New System.Drawing.Size(121, 21)
        Me.CBXpagamento.TabIndex = 82
        '
        'LBLpagamento
        '
        Me.LBLpagamento.AutoSize = True
        Me.LBLpagamento.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LBLpagamento.Location = New System.Drawing.Point(928, 225)
        Me.LBLpagamento.Name = "LBLpagamento"
        Me.LBLpagamento.Size = New System.Drawing.Size(107, 13)
        Me.LBLpagamento.TabIndex = 81
        Me.LBLpagamento.Text = "Pagamento Efetuado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(153, 460)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Frigobar"
        '
        'CbxDiaInicio
        '
        Me.CbxDiaInicio.FormattingEnabled = True
        Me.CbxDiaInicio.Location = New System.Drawing.Point(190, 4)
        Me.CbxDiaInicio.Name = "CbxDiaInicio"
        Me.CbxDiaInicio.Size = New System.Drawing.Size(42, 21)
        Me.CbxDiaInicio.TabIndex = 79
        '
        'CbxMesInicio
        '
        Me.CbxMesInicio.FormattingEnabled = True
        Me.CbxMesInicio.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.CbxMesInicio.Location = New System.Drawing.Point(266, 4)
        Me.CbxMesInicio.Name = "CbxMesInicio"
        Me.CbxMesInicio.Size = New System.Drawing.Size(37, 21)
        Me.CbxMesInicio.TabIndex = 78
        '
        'CbxAnoInicio
        '
        Me.CbxAnoInicio.FormattingEnabled = True
        Me.CbxAnoInicio.Location = New System.Drawing.Point(333, 4)
        Me.CbxAnoInicio.Name = "CbxAnoInicio"
        Me.CbxAnoInicio.Size = New System.Drawing.Size(84, 21)
        Me.CbxAnoInicio.TabIndex = 77
        '
        'CBXcamaSolteiro
        '
        Me.CBXcamaSolteiro.FormattingEnabled = True
        Me.CBXcamaSolteiro.Location = New System.Drawing.Point(333, 537)
        Me.CBXcamaSolteiro.Name = "CBXcamaSolteiro"
        Me.CBXcamaSolteiro.Size = New System.Drawing.Size(121, 21)
        Me.CBXcamaSolteiro.TabIndex = 76
        '
        'CBXcamaCasal
        '
        Me.CBXcamaCasal.FormattingEnabled = True
        Me.CBXcamaCasal.Location = New System.Drawing.Point(333, 498)
        Me.CBXcamaCasal.Name = "CBXcamaCasal"
        Me.CBXcamaCasal.Size = New System.Drawing.Size(121, 21)
        Me.CBXcamaCasal.TabIndex = 75
        '
        'CBXfrigobar
        '
        Me.CBXfrigobar.FormattingEnabled = True
        Me.CBXfrigobar.Items.AddRange(New Object() {"S", "N"})
        Me.CBXfrigobar.Location = New System.Drawing.Point(333, 460)
        Me.CBXfrigobar.Name = "CBXfrigobar"
        Me.CBXfrigobar.Size = New System.Drawing.Size(121, 21)
        Me.CBXfrigobar.TabIndex = 74
        '
        'lblDataInicio
        '
        Me.lblDataInicio.AutoSize = True
        Me.lblDataInicio.Location = New System.Drawing.Point(176, 100)
        Me.lblDataInicio.Name = "lblDataInicio"
        Me.lblDataInicio.Size = New System.Drawing.Size(0, 13)
        Me.lblDataInicio.TabIndex = 73
        '
        'BTNvoltar
        '
        Me.BTNvoltar.Location = New System.Drawing.Point(560, 4)
        Me.BTNvoltar.Name = "BTNvoltar"
        Me.BTNvoltar.Size = New System.Drawing.Size(75, 23)
        Me.BTNvoltar.TabIndex = 72
        Me.BTNvoltar.Text = "Voltar"
        Me.BTNvoltar.UseVisualStyleBackColor = True
        '
        'RTXTdescricao
        '
        Me.RTXTdescricao.Location = New System.Drawing.Point(601, 142)
        Me.RTXTdescricao.Name = "RTXTdescricao"
        Me.RTXTdescricao.Size = New System.Drawing.Size(270, 318)
        Me.RTXTdescricao.TabIndex = 71
        Me.RTXTdescricao.Text = ""
        '
        'BTNoriginal
        '
        Me.BTNoriginal.Location = New System.Drawing.Point(498, 49)
        Me.BTNoriginal.Name = "BTNoriginal"
        Me.BTNoriginal.Size = New System.Drawing.Size(218, 25)
        Me.BTNoriginal.TabIndex = 70
        Me.BTNoriginal.Text = "dados originais "
        Me.BTNoriginal.UseVisualStyleBackColor = True
        '
        'lblDiaria
        '
        Me.lblDiaria.AutoSize = True
        Me.lblDiaria.Location = New System.Drawing.Point(187, 139)
        Me.lblDiaria.Name = "lblDiaria"
        Me.lblDiaria.Size = New System.Drawing.Size(0, 13)
        Me.lblDiaria.TabIndex = 69
        '
        'CBXTipoGrupo
        '
        Me.CBXTipoGrupo.FormattingEnabled = True
        Me.CBXTipoGrupo.Items.AddRange(New Object() {"individual", "família", "casal", "amigos", "excursao", "outros"})
        Me.CBXTipoGrupo.Location = New System.Drawing.Point(1041, 184)
        Me.CBXTipoGrupo.Name = "CBXTipoGrupo"
        Me.CBXTipoGrupo.Size = New System.Drawing.Size(121, 21)
        Me.CBXTipoGrupo.TabIndex = 68
        '
        'LBLtipogrupo
        '
        Me.LBLtipogrupo.AutoSize = True
        Me.LBLtipogrupo.Location = New System.Drawing.Point(939, 184)
        Me.LBLtipogrupo.Name = "LBLtipogrupo"
        Me.LBLtipogrupo.Size = New System.Drawing.Size(73, 13)
        Me.LBLtipogrupo.TabIndex = 67
        Me.LBLtipogrupo.Text = "Tipo do grupo"
        '
        'LBLviagem
        '
        Me.LBLviagem.AutoSize = True
        Me.LBLviagem.Location = New System.Drawing.Point(939, 141)
        Me.LBLviagem.Name = "LBLviagem"
        Me.LBLviagem.Size = New System.Drawing.Size(76, 13)
        Me.LBLviagem.TabIndex = 66
        Me.LBLviagem.Text = "Motivo viagem"
        '
        'CBXmotivoViagem
        '
        Me.CBXmotivoViagem.FormattingEnabled = True
        Me.CBXmotivoViagem.Items.AddRange(New Object() {"turismo", "congresso ou eventos", "trabalho", "motivo de saúde", "lua de mel", "visita a terceiros", "outros"})
        Me.CBXmotivoViagem.Location = New System.Drawing.Point(1041, 138)
        Me.CBXmotivoViagem.Name = "CBXmotivoViagem"
        Me.CBXmotivoViagem.Size = New System.Drawing.Size(121, 21)
        Me.CBXmotivoViagem.TabIndex = 65
        '
        'LBLdestino
        '
        Me.LBLdestino.AutoSize = True
        Me.LBLdestino.Location = New System.Drawing.Point(939, 91)
        Me.LBLdestino.Name = "LBLdestino"
        Me.LBLdestino.Size = New System.Drawing.Size(43, 13)
        Me.LBLdestino.TabIndex = 64
        Me.LBLdestino.Text = "Destino"
        '
        'TXTdestino
        '
        Me.TXTdestino.Location = New System.Drawing.Point(1041, 88)
        Me.TXTdestino.Name = "TXTdestino"
        Me.TXTdestino.Size = New System.Drawing.Size(100, 20)
        Me.TXTdestino.TabIndex = 63
        '
        'TXTorigem
        '
        Me.TXTorigem.Location = New System.Drawing.Point(1041, 48)
        Me.TXTorigem.Name = "TXTorigem"
        Me.TXTorigem.Size = New System.Drawing.Size(100, 20)
        Me.TXTorigem.TabIndex = 62
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(153, 537)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 13)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Numero de camas de Solteiro"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(153, 498)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 13)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Numero de camas de casal"
        '
        'BTNfotoAnterior
        '
        Me.BTNfotoAnterior.Location = New System.Drawing.Point(3, 281)
        Me.BTNfotoAnterior.Name = "BTNfotoAnterior"
        Me.BTNfotoAnterior.Size = New System.Drawing.Size(75, 23)
        Me.BTNfotoAnterior.TabIndex = 59
        Me.BTNfotoAnterior.Text = "<"
        Me.BTNfotoAnterior.UseVisualStyleBackColor = True
        '
        'BTNproximaFoto
        '
        Me.BTNproximaFoto.Location = New System.Drawing.Point(476, 254)
        Me.BTNproximaFoto.Name = "BTNproximaFoto"
        Me.BTNproximaFoto.Size = New System.Drawing.Size(75, 23)
        Me.BTNproximaFoto.TabIndex = 58
        Me.BTNproximaFoto.Text = ">"
        Me.BTNproximaFoto.UseVisualStyleBackColor = True
        '
        'BTNConfirmar
        '
        Me.BTNConfirmar.Location = New System.Drawing.Point(653, 493)
        Me.BTNConfirmar.Name = "BTNConfirmar"
        Me.BTNConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.BTNConfirmar.TabIndex = 57
        Me.BTNConfirmar.Text = "Confirmar"
        Me.BTNConfirmar.UseVisualStyleBackColor = True
        '
        'CBXdia
        '
        Me.CBXdia.FormattingEnabled = True
        Me.CBXdia.Location = New System.Drawing.Point(190, 44)
        Me.CBXdia.Name = "CBXdia"
        Me.CBXdia.Size = New System.Drawing.Size(42, 21)
        Me.CBXdia.TabIndex = 56
        '
        'CBXmes
        '
        Me.CBXmes.FormattingEnabled = True
        Me.CBXmes.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.CBXmes.Location = New System.Drawing.Point(267, 44)
        Me.CBXmes.Name = "CBXmes"
        Me.CBXmes.Size = New System.Drawing.Size(36, 21)
        Me.CBXmes.TabIndex = 55
        '
        'LBLorigem
        '
        Me.LBLorigem.AutoSize = True
        Me.LBLorigem.Location = New System.Drawing.Point(939, 51)
        Me.LBLorigem.Name = "LBLorigem"
        Me.LBLorigem.Size = New System.Drawing.Size(40, 13)
        Me.LBLorigem.TabIndex = 54
        Me.LBLorigem.Text = "Origem"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(107, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Tarifa Diaria"
        '
        'CBXAno
        '
        Me.CBXAno.FormattingEnabled = True
        Me.CBXAno.Location = New System.Drawing.Point(333, 44)
        Me.CBXAno.Name = "CBXAno"
        Me.CBXAno.Size = New System.Drawing.Size(84, 21)
        Me.CBXAno.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(114, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Data fim:"
        '
        'lblx
        '
        Me.lblx.AutoSize = True
        Me.lblx.Location = New System.Drawing.Point(107, 9)
        Me.lblx.Name = "lblx"
        Me.lblx.Size = New System.Drawing.Size(66, 13)
        Me.lblx.TabIndex = 50
        Me.lblx.Text = "Data Início :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Tipo Apartamento:"
        '
        'CBXtipoApartamento
        '
        Me.CBXtipoApartamento.FormattingEnabled = True
        Me.CBXtipoApartamento.Location = New System.Drawing.Point(239, 100)
        Me.CBXtipoApartamento.Name = "CBXtipoApartamento"
        Me.CBXtipoApartamento.Size = New System.Drawing.Size(121, 21)
        Me.CBXtipoApartamento.TabIndex = 48
        '
        'PBapartamento
        '
        Me.PBapartamento.Location = New System.Drawing.Point(96, 169)
        Me.PBapartamento.Name = "PBapartamento"
        Me.PBapartamento.Size = New System.Drawing.Size(337, 253)
        Me.PBapartamento.TabIndex = 47
        Me.PBapartamento.TabStop = False
        '
        'Hospedagem_Reserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1241, 636)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LBLgastoHospedagem)
        Me.Controls.Add(Me.BTNalterarReserva)
        Me.Controls.Add(Me.BTNincluir)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.CBXpagamento)
        Me.Controls.Add(Me.LBLpagamento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbxDiaInicio)
        Me.Controls.Add(Me.CbxMesInicio)
        Me.Controls.Add(Me.CbxAnoInicio)
        Me.Controls.Add(Me.CBXcamaSolteiro)
        Me.Controls.Add(Me.CBXcamaCasal)
        Me.Controls.Add(Me.CBXfrigobar)
        Me.Controls.Add(Me.lblDataInicio)
        Me.Controls.Add(Me.BTNvoltar)
        Me.Controls.Add(Me.RTXTdescricao)
        Me.Controls.Add(Me.BTNoriginal)
        Me.Controls.Add(Me.lblDiaria)
        Me.Controls.Add(Me.CBXTipoGrupo)
        Me.Controls.Add(Me.LBLtipogrupo)
        Me.Controls.Add(Me.LBLviagem)
        Me.Controls.Add(Me.CBXmotivoViagem)
        Me.Controls.Add(Me.LBLdestino)
        Me.Controls.Add(Me.TXTdestino)
        Me.Controls.Add(Me.TXTorigem)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BTNfotoAnterior)
        Me.Controls.Add(Me.BTNproximaFoto)
        Me.Controls.Add(Me.BTNConfirmar)
        Me.Controls.Add(Me.CBXdia)
        Me.Controls.Add(Me.CBXmes)
        Me.Controls.Add(Me.LBLorigem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBXAno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblx)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBXtipoApartamento)
        Me.Controls.Add(Me.PBapartamento)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Hospedagem_Reserva"
        Me.Text = "Hospedagem_Reserva"
        CType(Me.PBapartamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LBLgastoHospedagem As System.Windows.Forms.Label
    Friend WithEvents BTNalterarReserva As System.Windows.Forms.Button
    Friend WithEvents BTNincluir As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents CBXpagamento As System.Windows.Forms.ComboBox
    Friend WithEvents LBLpagamento As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbxDiaInicio As System.Windows.Forms.ComboBox
    Friend WithEvents CbxMesInicio As System.Windows.Forms.ComboBox
    Friend WithEvents CbxAnoInicio As System.Windows.Forms.ComboBox
    Friend WithEvents CBXcamaSolteiro As System.Windows.Forms.ComboBox
    Friend WithEvents CBXcamaCasal As System.Windows.Forms.ComboBox
    Friend WithEvents CBXfrigobar As System.Windows.Forms.ComboBox
    Friend WithEvents lblDataInicio As System.Windows.Forms.Label
    Friend WithEvents BTNvoltar As System.Windows.Forms.Button
    Friend WithEvents RTXTdescricao As System.Windows.Forms.RichTextBox
    Friend WithEvents BTNoriginal As System.Windows.Forms.Button
    Friend WithEvents lblDiaria As System.Windows.Forms.Label
    Friend WithEvents CBXTipoGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents LBLtipogrupo As System.Windows.Forms.Label
    Friend WithEvents LBLviagem As System.Windows.Forms.Label
    Friend WithEvents CBXmotivoViagem As System.Windows.Forms.ComboBox
    Friend WithEvents LBLdestino As System.Windows.Forms.Label
    Friend WithEvents TXTdestino As System.Windows.Forms.TextBox
    Friend WithEvents TXTorigem As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BTNfotoAnterior As System.Windows.Forms.Button
    Friend WithEvents BTNproximaFoto As System.Windows.Forms.Button
    Friend WithEvents BTNConfirmar As System.Windows.Forms.Button
    Friend WithEvents CBXdia As System.Windows.Forms.ComboBox
    Friend WithEvents CBXmes As System.Windows.Forms.ComboBox
    Friend WithEvents LBLorigem As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CBXAno As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblx As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBXtipoApartamento As System.Windows.Forms.ComboBox
    Friend WithEvents PBapartamento As System.Windows.Forms.PictureBox
End Class
