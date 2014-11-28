
Imports System.Data.SqlClient
Imports System.IO
''NA HORA DE EDITAR RESERVA SELECIONAR PAGAMENTO
Public Class Hospedagem_Reserva
    'DESTRAVAR GRADUALMENTE'
    Private IdCliente As Integer
    Private chamante As Form
    Private indiceFoto As Integer
    Private fotosApartamento As New List(Of Byte())
    Private banco, bancoAuxiliar As New BD()
    Private Status As String 'CRIANDO HOSPEDAGEM POR RESERVA{CHPR},CRIANDO HOSPEDAGEM SEM RESERVA{CHSR},EDITANDO HOSPEDAGEM{EH},EDITANDO RESERVA {ER}
    Private reserva As Integer
    Private mudancaPermitida As Boolean
    Private hospedagem As Integer



    Public Sub setChamante(ByRef chamante As Form)
        Me.chamante = chamante
        RTXTdescricao.ReadOnly = True
    End Sub

    Public Sub setStatus(status As String)
        Me.Status = status

    End Sub




    Public Sub iniciarEdicaoHospedagem(idHospedagem As Integer)
        PBapartamento.SizeMode = PictureBoxSizeMode.StretchImage
        LBLpagamento.Visible = False
        Me.hospedagem = idHospedagem
        Dim gasto As Double
        Dim consultan As SqlDataReader
        consultan = banco.consultaGenerica("Select dbo.gastoAtual(" + CStr(idHospedagem) + ")")
        consultan.Read()
        gasto = consultan.GetDouble(0)
        banco.fecharConexao()
        LBLgastoHospedagem.Text = "O Gasto total atualmente para essa hospedagem é:" + CStr(gasto)



        LBLgastoHospedagem.Visible = True
        BTNincluir.Visible = False
        BTNConfirmar.Visible = False
        CBXpagamento.SelectedIndex = 1
        CBXpagamento.Visible = False
        setStatus("EH")


        Me.mudancaPermitida = True
        CbxDiaInicio.Text = ""
        CbxMesInicio.Text = ""
        CbxAnoInicio.Text = ""
        CBXmes.Text = ""
        CBXAno.Text = ""
        CBXdia.Text = ""
        CBXfrigobar.Text = ""
        CBXcamaCasal.Text = ""
        CBXcamaSolteiro.Text = ""
        CbxAnoInicio.Text = ""
        CbxDiaInicio.Text = ""
        CBXtipoApartamento.Text = ""

        CBXtipoApartamento.Items.Clear()
        Dim dadosReserva As SqlDataReader
        Dim tiposApto As SqlDataReader


        tiposApto = banco.consultaGenerica("select tipo from htipoApartamento where idtipoApartamento in (select idTipoApartamento from hApartamento)")
        While (tiposApto.Read())
            CBXtipoApartamento.Items.Add(tiposApto.Item(0))
        End While

        banco.fecharConexao()
        dadosReserva = banco.consultaGenerica("select * from dbo.HospedagemEdicaoConsulta(" + CStr(idHospedagem) + ")")
        dadosReserva.Read()
        Me.IdCliente = dadosReserva.GetInt32(1)
        Me.reserva = dadosReserva.GetInt32(0)

        lblDiaria.Text = CStr(dadosReserva.GetDouble(12))
        CBXfrigobar.Enabled = True
        CBXcamaCasal.Enabled = True
        CBXcamaSolteiro.Enabled = True

        CBXfrigobar.SelectedText = dadosReserva.GetString(8)
        CbxAnoInicio.Items.Clear()
        CbxDiaInicio.Items.Clear()
        CbxMesInicio.SelectedText = dadosReserva.GetDateTime(3).Month
        CbxAnoInicio.Items.Add(Date.Now.Year)
        CbxAnoInicio.Items.Add(Date.Now.Year + 1)
        CbxAnoInicio.Items.Add(Date.Now.Year + 2)
        CbxAnoInicio.SelectedText = dadosReserva.GetDateTime(3).Year
        mudarDiasPorMesInicio(dadosReserva.GetDateTime(4).Month, dadosReserva.GetDateTime(4).Year)
        CbxDiaInicio.SelectedText = dadosReserva.GetDateTime(3).Day
        CbxAnoInicio.Enabled = False
        CbxDiaInicio.Enabled = False
        CbxMesInicio.Enabled = False

        CBXdia.Items.Clear()
        CBXAno.Items.Clear()
        CBXmes.SelectedText = dadosReserva.GetDateTime(4).Month
        CBXAno.Items.Add(Date.Now.Year)
        CBXAno.Items.Add(Date.Now.Year + 1)
        CBXAno.Items.Add(Date.Now.Year + 2)
        CBXAno.SelectedText = dadosReserva.GetDateTime(4).Year
        mudarDiasPorMes(dadosReserva.GetDateTime(4).Month, dadosReserva.GetDateTime(4).Year)
        CBXdia.SelectedText = dadosReserva.GetDateTime(4).Day
        RTXTdescricao.Text = dadosReserva.GetValue(13)
        CBXtipoApartamento.SelectedText = dadosReserva.GetString(11)
        atualizarFotos(dadosReserva.GetInt32(2))

        dadosReserva = banco.consultaGenerica("select * from dbo.HospedagemEdicaoConsulta(" + CStr(idHospedagem) + ")")

        dadosReserva.Read()
        CBXcamaCasal.SelectedText = CStr(dadosReserva.GetInt32(9))
        CBXcamaSolteiro.SelectedText = CStr(dadosReserva.GetInt32(10))
        CBXTipoGrupo.SelectedIndex = CStr(dadosReserva.GetInt32(14) + 1)
        CBXmotivoViagem.SelectedIndex = CStr(dadosReserva.GetInt32(15) + 1)
        TXTorigem.Text = dadosReserva.GetString(16)
        TXTdestino.Text = dadosReserva.GetString(17)
        banco.fecharConexao()
        Me.mudancaPermitida = False

        mudancaTipo()
    End Sub





    Public Sub InicializarEdicaoReserva(idReserva As Integer)
        PBapartamento.SizeMode = PictureBoxSizeMode.StretchImage
        Me.reserva = idReserva
        BTNincluir.Visible = False
        BTNConfirmar.Visible = False
        LBLtipogrupo.Visible = False
        CBXTipoGrupo.Visible = False
        LBLviagem.Visible = False
        CBXmotivoViagem.Visible = False
        LBLdestino.Visible = False
        TXTdestino.Visible = False
        LBLorigem.Visible = False
        TXTorigem.Visible = False

        LBLpagamento.Visible = True
        CBXpagamento.Visible = True
        setStatus("ER")




        Me.mudancaPermitida = True
        CbxDiaInicio.Text = ""
        CbxMesInicio.Text = ""
        CbxAnoInicio.Text = ""
        CBXmes.Text = ""
        CBXAno.Text = ""
        CBXdia.Text = ""
        CBXfrigobar.Text = ""
        CBXcamaCasal.Text = ""
        CBXcamaSolteiro.Text = ""
        CbxAnoInicio.Text = ""
        CbxDiaInicio.Text = ""
        CBXtipoApartamento.Text = ""

        CBXtipoApartamento.Items.Clear()
        Dim dadosReserva As SqlDataReader
        Dim tiposApto As SqlDataReader
        Me.IdCliente = IdCliente

        tiposApto = banco.consultaGenerica("select tipo from htipoApartamento where idtipoApartamento in (select idTipoApartamento from hApartamento)")
        While (tiposApto.Read())
            CBXtipoApartamento.Items.Add(tiposApto.Item(0))
        End While
        banco.fecharConexao()
        dadosReserva = banco.consultaGenerica("select * from dbo.reservaEdicaoConsulta(" + CStr(idReserva) + ")")
        dadosReserva.Read()
        Me.IdCliente = dadosReserva.GetInt32(0)

        lblDiaria.Text = CStr(dadosReserva.GetDouble(11))
        CBXfrigobar.Enabled = True
        CBXcamaCasal.Enabled = True
        CBXcamaSolteiro.Enabled = True

        CBXfrigobar.SelectedText = dadosReserva.GetString(7)
        CbxAnoInicio.Items.Clear()
        CbxDiaInicio.Items.Clear()
        CbxMesInicio.SelectedText = dadosReserva.GetDateTime(2).Month
        CbxAnoInicio.Items.Add(Date.Now.Year)
        CbxAnoInicio.Items.Add(Date.Now.Year + 1)
        CbxAnoInicio.Items.Add(Date.Now.Year + 2)
        CbxAnoInicio.SelectedText = dadosReserva.GetDateTime(2).Year
        mudarDiasPorMesInicio(dadosReserva.GetDateTime(3).Month, dadosReserva.GetDateTime(3).Year)
        CbxDiaInicio.SelectedText = dadosReserva.GetDateTime(2).Day
        CbxAnoInicio.Enabled = False
        CbxDiaInicio.Enabled = False
        CbxMesInicio.Enabled = False

        CBXdia.Items.Clear()
        CBXAno.Items.Clear()
        CBXmes.SelectedText = dadosReserva.GetDateTime(3).Month
        CBXAno.Items.Add(Date.Now.Year)
        CBXAno.Items.Add(Date.Now.Year + 1)
        CBXAno.Items.Add(Date.Now.Year + 2)
        CBXAno.SelectedText = dadosReserva.GetDateTime(3).Year
        mudarDiasPorMes(dadosReserva.GetDateTime(3).Month, dadosReserva.GetDateTime(3).Year)
        CBXdia.SelectedText = dadosReserva.GetDateTime(3).Day
        RTXTdescricao.Text = dadosReserva.GetValue(12)
        CBXtipoApartamento.SelectedText = dadosReserva.GetString(10)
        atualizarFotos(dadosReserva.GetInt32(1))

        dadosReserva = banco.consultaGenerica("select * from dbo.reservaEdicaoConsulta(" + CStr(idReserva) + ")")

        dadosReserva.Read()
        CBXcamaCasal.SelectedText = CStr(dadosReserva.GetInt32(8))
        CBXcamaSolteiro.SelectedText = CStr(dadosReserva.GetInt32(9))
        banco.fecharConexao()
        Me.mudancaPermitida = False


        mudancaTipo()

    End Sub


    Public Sub InicializarSem(idCliente As Integer)
        PBapartamento.SizeMode = PictureBoxSizeMode.StretchImage
        BTNoriginal.Visible = False
        BTNalterarReserva.Visible = False
        LBLpagamento.Visible = False
        PBapartamento.SizeMode = PictureBoxSizeMode.StretchImage
        CBXpagamento.Visible = False
        CBXAno.Items.Add(Date.Now.Year)
        CBXAno.Items.Add(Date.Now.Year + 1)
        CBXAno.Items.Add(Date.Now.Year + 2)

        btnExcluir.Visible = False
        BTNproximaFoto.Enabled = False
        BTNfotoAnterior.Enabled = False
        CbxAnoInicio.Text = Date.Now.Year.ToString
        CbxDiaInicio.Text = Date.Now.Day.ToString
        CbxMesInicio.Text = Date.Now.Month.ToString

        CbxAnoInicio.Enabled = False
        CbxDiaInicio.Enabled = False
        CbxMesInicio.Enabled = False

        CBXtipoApartamento.Enabled = False
        CBXfrigobar.Enabled = False
        CBXcamaCasal.Enabled = False
        CBXcamaSolteiro.Enabled = False
        setStatus("CHSR")
        BTNConfirmar.Visible = False
        Me.IdCliente = idCliente
        'CBX()
    End Sub



    Public Sub inicializar(idCliente As Integer)
        BTNalterarReserva.Visible = False
        btnExcluir.Visible = False
        PBapartamento.SizeMode = PictureBoxSizeMode.StretchImage
        LBLpagamento.Visible = False
        CBXpagamento.Visible = False
        BTNincluir.Visible = False

        setStatus("CHPR")


        Me.mudancaPermitida = True
        CbxDiaInicio.Text = ""
        CbxMesInicio.Text = ""
        CbxAnoInicio.Text = ""
        CBXmes.Text = ""
        CBXAno.Text = ""
        CBXdia.Text = ""
        CBXfrigobar.Text = ""
        CBXcamaCasal.Text = ""
        CBXcamaSolteiro.Text = ""
        CbxAnoInicio.Text = ""
        CbxDiaInicio.Text = ""
        CBXtipoApartamento.Text = ""

        CBXtipoApartamento.Items.Clear()
        Dim dadosReserva As SqlDataReader
        Dim tiposApto As SqlDataReader
        Me.IdCliente = idCliente

        tiposApto = banco.consultaGenerica("select tipo from htipoApartamento where idtipoApartamento in (select idTipoApartamento from hApartamento)")
        While (tiposApto.Read())
            CBXtipoApartamento.Items.Add(tiposApto.Item(0))
        End While
        banco.fecharConexao()
        dadosReserva = banco.reservaClienteChekinDados(idCliente)
        dadosReserva.Read()


        lblDiaria.Text = CStr(dadosReserva.GetDouble(11))
        CBXfrigobar.Enabled = True
        CBXcamaCasal.Enabled = True
        CBXcamaSolteiro.Enabled = True

        CBXfrigobar.SelectedText = dadosReserva.GetString(7)
        CbxAnoInicio.Items.Clear()
        CbxDiaInicio.Items.Clear()
        CbxMesInicio.SelectedText = dadosReserva.GetDateTime(2).Month
        CbxAnoInicio.Items.Add(Date.Now.Year)
        CbxAnoInicio.Items.Add(Date.Now.Year + 1)
        CbxAnoInicio.Items.Add(Date.Now.Year + 2)
        CbxAnoInicio.SelectedText = dadosReserva.GetDateTime(2).Year
        mudarDiasPorMesInicio(dadosReserva.GetDateTime(3).Month, dadosReserva.GetDateTime(3).Year)
        CbxDiaInicio.SelectedText = dadosReserva.GetDateTime(2).Day
        CbxAnoInicio.Enabled = False
        CbxDiaInicio.Enabled = False
        CbxMesInicio.Enabled = False

        CBXdia.Items.Clear()
        CBXAno.Items.Clear()
        CBXmes.SelectedText = dadosReserva.GetDateTime(3).Month
        CBXAno.Items.Add(Date.Now.Year)
        CBXAno.Items.Add(Date.Now.Year + 1)
        CBXAno.Items.Add(Date.Now.Year + 2)
        CBXAno.SelectedText = dadosReserva.GetDateTime(3).Year
        mudarDiasPorMes(dadosReserva.GetDateTime(3).Month, dadosReserva.GetDateTime(3).Year)
        CBXdia.SelectedText = dadosReserva.GetDateTime(3).Day
        RTXTdescricao.Text = dadosReserva.GetValue(12)
        CBXtipoApartamento.SelectedText = dadosReserva.GetString(10)
        atualizarFotos(dadosReserva.GetInt32(1))

        dadosReserva = banco.reservaClienteChekinDados(idCliente)
        dadosReserva.Read()
        CBXcamaCasal.SelectedText = CStr(dadosReserva.GetInt32(8))
        CBXcamaSolteiro.SelectedText = CStr(dadosReserva.GetInt32(9))
        banco.fecharConexao()
        Me.mudancaPermitida = False


        mudancaTipo()


    End Sub

    Private Sub confirmaReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub atualizarFotos(tipoApartamento As Integer)
        banco.fecharConexao()
        Dim fotosConsulta As SqlDataReader = banco.fotosApartamento(tipoApartamento)
        fotosApartamento.Clear()
        indiceFoto = 0
        While (fotosConsulta.Read())
            fotosApartamento.Add(fotosConsulta.Item(0))
        End While
        If (fotosApartamento.Count > 0) Then
            Dim foto As Byte()
            foto = fotosApartamento.Item(0)
            Dim bytesDaFoto As New MemoryStream(foto)
            PBapartamento.Image = Image.FromStream(bytesDaFoto)
        End If
        banco.fecharConexao()
    End Sub

    Private Sub BTNproximaFoto_Click(sender As Object, e As EventArgs) Handles BTNproximaFoto.Click
        If (fotosApartamento.Count > 0) Then
            indiceFoto += 1
            If ((indiceFoto Mod fotosApartamento.Count) = 0) Then
                indiceFoto = 0
            End If

            Dim foto As Byte() = fotosApartamento.Item(indiceFoto)
            Dim bytesDaFoto As New MemoryStream(foto)
            PBapartamento.Image = Image.FromStream(bytesDaFoto)
            banco.fecharConexao()

        End If
    End Sub



    Private Sub mudarDiasPorMes(mes As Integer, ano As Integer)
        CBXdia.Items.Clear()

        If mudancaPermitida Then
            Return
        End If

        Dim dia As Integer
        If (CBXdia.Text <> "") Then
            dia = Convert.ToInt32(CBXdia.Text)
        End If


        Dim cont As Integer
        Select Case mes
            Case 1, 3, 5, 7, 8, 10, 12
                cont = 31
            Case 4, 6, 9, 11
                cont = 30
            Case 2
                If ((ano Mod 4) = 0) Then
                    cont = 29
                Else
                    cont = 28
                End If
        End Select

        Dim d As Integer = 0

        While (cont > 0)
            d += 1
            CBXdia.Items.Add(d)
            If (CBXdia.Text <> "") Then
                If dia = d Then
                    mudancaPermitida = True
                    CBXdia.Text = CStr(dia)
                    mudancaPermitida = False
                End If
            End If
            cont -= 1
        End While


    End Sub
    Private Sub mudarDiasPorMesInicio(mes As Integer, ano As Integer)

        If mudancaPermitida Then
            Return
        End If


        Dim dia As Integer
        If (CbxDiaInicio.Text <> "") Then
            dia = Convert.ToInt32(CbxDiaInicio.Text)
        End If


        Dim cont As Integer
        Select Case mes
            Case 1, 3, 5, 7, 8, 10, 12
                cont = 31
            Case 4, 6, 9, 11
                cont = 30
            Case 2
                If ((ano Mod 4) = 0) Then
                    cont = 29
                Else
                    cont = 28
                End If
        End Select

        Dim d As Integer = 0

        While (cont > 0)
            d += 1
            CbxDiaInicio.Items.Add(d)

            If (CbxDiaInicio.Text <> "") Then
                If dia = d Then
                    mudancaPermitida = True
                    CbxDiaInicio.Text = CStr(dia)
                    mudancaPermitida = False
                End If
            End If

            cont -= 1
        End While
    End Sub


    Private Function disponibilidaDinamica() As Boolean


        'If (Status = "CHPR") Then
        'consulta = banco.reservaClienteChekinDados(Me.IdCliente)
        'consulta.Read()
        'idReserva = consulta.GetInt32(0)
        'banco.fecharConexao()
        'consulta = banco.consultaGenerica("select*from hreserva where idReserva=" + CStr(idReserva))
        'consulta.Read()
        'inicial = consulta.GetDateTime(2)
        'final = consulta.GetDateTime(3)
        'numeroBoleto = consulta.GetInt32(4)
        'pagamento = consulta.GetDateTime(5)
        ' situacao = consulta.GetInt32(6)
        'idApartamento = consulta.GetInt32(7)
        'banco.fecharConexao()
        'banco.consultaGenerica("delete from hreserva where idReserva=" + CStr(idReserva))
        '        banco.fecharConexao()
        '       End If


        '        If (Status = "ER") Then
        'consulta = banco.consultaGenerica("select*from hreserva where idReserva=" + CStr(Me.reserva))
        'consulta.Read()
        'inicial = consulta.GetDateTime(3)
        'final = consulta.GetDateTime(4)
        'numeroBoleto = consulta.GetInt32(5)
        'pagamento = consulta.GetDateTime(6)
        'situacao = consulta.GetInt32(7)
        'idApartamento = consulta.GetInt32(8)
        'banco.fecharConexao()
        'banco.consultaGenerica("delete from hreserva where idReserva=" + CStr(Me.reserva))
        'banco.fecharConexao()
        'End If

        'If (Status = "EH") Then
        '        consulta = banco.consultaGenerica("select * from dbo.HospedagemEdicaoConsulta(" + CStr(hospedagem) + ")")
        'consulta.Read()
        'inicial = consulta.GetDateTime(3)
        'final = consulta.GetDateTime(4)
        'numeroBoleto = consulta.GetInt32(5)
        'pagamento = consulta.GetDateTime(6)
        'situacao = consulta.GetInt32(7)
        'motivoViagem = consulta.GetInt32(15)
        'tipoDogrupo = consulta.GetInt32(14)
        'origem = consulta.GetString(16)
        'destino = consulta.GetString(17)
        'banco.fecharConexao()
        'consulta = banco.consultaGenerica("select idApartamento from Hhospedagem where idHospedagem=" + CStr(hospedagem))
        'consulta.Read()
        'idApartamento = consulta.GetInt32(0)
        'banco.fecharConexao()
        'banco.consultaGenerica("delete from hHospedagem where idHospedagem=" + CStr(hospedagem))
        'banco.fecharConexao()
        'banco.consultaGenerica("delete from hreserva where idReserva=" + CStr(Me.reserva))
        'banco.fecharConexao()
        'End If



        Dim dataFim As String = CBXdia.Text + "-" + CBXmes.Text + "-" + CBXAno.Text 'ORDEM ERRADA
        Dim dataInicio As String = CbxDiaInicio.Text + "-" + CbxMesInicio.Text + "-" + CbxAnoInicio.Text 'ORDEM ERRADA

        Dim strTipo As String = CBXtipoApartamento.Text


        If (CBXAno.Text <> "" And CBXdia.Text <> "" And CBXmes.Text <> "" And CbxAnoInicio.Text <> "" And CbxDiaInicio.Text <> "" And CbxMesInicio.Text <> "") Then
            Dim tiposApto As SqlDataReader
            tiposApto = banco.consultaGenerica("select tipo from htipoApartamento where ((select dbo.disponibilidadeApartamento(htipoApartamento.idTipoApartamento,'" + dataInicio.ToString + "','" + dataFim.ToString + "','N',0,0))=1) or ((select dbo.disponibilidadeApartamento(htipoApartamento.idTipoApartamento,'" + dataInicio.ToString + "','" + dataFim.ToString + "','S',0,0))=1)")
            If Not tiposApto.HasRows Then

                Me.mudancaPermitida = True
                CBXfrigobar.Text = ""
                CBXfrigobar.Enabled = False

                CBXcamaCasal.Text = ""
                CBXcamaCasal.Enabled = False

                CBXcamaSolteiro.Enabled = False
                CBXcamaSolteiro.Text = ""
                Me.mudancaPermitida = False

            Else
                CBXfrigobar.Enabled = True
                CBXcamaCasal.Enabled = True
                CBXcamaSolteiro.Enabled = True
            End If

            CBXtipoApartamento.Items.Clear()
            If (tiposApto.HasRows) Then
                While (tiposApto.Read())
                    CBXtipoApartamento.Items.Add(tiposApto.Item(0))
                    If strTipo = tiposApto.Item(0) Then
                        Me.mudancaPermitida = True
                        CBXtipoApartamento.Text = tiposApto.Item(0)
                        Me.mudancaPermitida = False
                    End If

                End While
            End If
            banco.fecharConexao()
        End If
        Dim disponibilidade As SqlDataReader

        Dim retorno As Boolean

        If (CBXAno.Text <> "" And CBXdia.Text <> "" And CBXmes.Text <> "" And CBXtipoApartamento.Text <> "" And CBXfrigobar.Text <> "" And CBXcamaCasal.Text <> "" And CBXcamaSolteiro.Text <> "") Then
            disponibilidade = banco.consultaGenerica("select dbo.disponibilidadeApartamento((select idtipoApartamento from htipoApartamento where tipo='" + CBXtipoApartamento.Text + "'),'" + dataInicio.ToString + "','" + dataFim.ToString + "','" + CBXfrigobar.Text + "'," + CBXcamaCasal.Text + "," + CBXcamaSolteiro.Text + " )")
            disponibilidade.Read()
            retorno = disponibilidade.GetBoolean(0)
            banco.fecharConexao()
        Else
            retorno = Nothing

        End If

        'If (Status = "CHPR" Or Status = "ER" Or Status = "EH") Then
        'banco.adicionaReserva(idApartamento, Me.IdCliente, inicial, final, numeroBoleto, pagamento, situacao)
        'Dim consulan As SqlDataReader = banco.consultaGenerica("SELECT MAX(IDRESERVA) FROM HRESERVA")
        'consulan.Read()
        'Me.reserva = consulan.GetInt32(0)
        'banco.fecharConexao()
        'If (Status = "EH") Then
        '        banco.adicionaHospedagem(idApartamento, idReserva, origem, destino, tipoDogrupo, motivoViagem)
        'consulan = banco.consultaGenerica("SELECT MAX(IDHOSPEDAGEM) FROM hHOSPEDAGEM")
        'consulan.Read()
        'Me.hospedagem = consulan.GetInt32(0)
        'banco.fecharConexao()
        'End If
        'End If

        Return retorno
    End Function




    Private Sub BTNfotoAnterior_Click(sender As Object, e As EventArgs) Handles BTNfotoAnterior.Click



        If (fotosApartamento.Count > 0) Then
            indiceFoto -= 1
            If (indiceFoto = -1) Then
                indiceFoto = fotosApartamento.Count - 1
            End If

            Dim foto As Byte() = fotosApartamento.Item(indiceFoto)
            Dim bytesDaFoto As New MemoryStream(foto)
            PBapartamento.Image = Image.FromStream(bytesDaFoto)
            banco.fecharConexao()

        End If
    End Sub

    Private Sub mudancaTipo()
        If mudancaPermitida Then
            Return
        End If



        Dim inicial As Date
        Dim final As Date
        Dim numeroBoleto As Integer
        Dim pagamento As Date
        Dim situacao As Integer
        Dim idApartamento As Integer


        'If (Status = "CHPR") Then
        '        consulta = banco.reservaClienteChekinDados(Me.IdCliente)
        'consulta.Read()
        'idReserva = consulta.GetInt32(0)
        'banco.fecharConexao()
        'consulta = banco.consultaGenerica("select*from hreserva where idReserva=" + CStr(idReserva))
        'consulta.Read()
        'inicial = consulta.GetDateTime(2)
        'final = consulta.GetDateTime(3)
        'numeroBoleto = consulta.GetInt32(4)
        'pagamento = consulta.GetDateTime(5)
        'situacao = consulta.GetInt32(6)
        'idApartamento = consulta.GetInt32(7)
        'banco.fecharConexao()
        'banco.consultaGenerica("delete from hreserva where idReserva=" + CStr(idReserva))
        'banco.fecharConexao()
        'End If


        'If (Status = "ER") Then
        'consulta = banco.consultaGenerica("select*from hreserva where idReserva=" + CStr(Me.reserva))
        'consulta.Read()
        'inicial = consulta.GetDateTime(3)
        'final = consulta.GetDateTime(4)
        'numeroBoleto = consulta.GetInt32(5)
        'pagamento = consulta.GetDateTime(6)
        'situacao = consulta.GetInt32(7)
        'idApartamento = consulta.GetInt32(8)
        'banco.fecharConexao()

        '        banco.consultaGenerica("delete from hreserva where idReserva=" + CStr(Me.reserva))
        '       banco.fecharConexao()
        '      End If

        'If (Status = "EH") Then
        '    consulta = banco.consultaGenerica("select * from dbo.HospedagemEdicaoConsulta(" + CStr(hospedagem) + ")")
        '    consulta.Read()
        '    inicial = consulta.GetDateTime(3)
        '    final = consulta.GetDateTime(4)
        '    numeroBoleto = consulta.GetInt32(5)
        '    pagamento = consulta.GetDateTime(6)
        '    situacao = consulta.GetInt32(7)
        '    motivoViagem = consulta.GetInt32(15)
        '    tipoDogrupo = consulta.GetInt32(14)
        '    origem = consulta.GetString(16)
        '    destino = consulta.GetString(17)
        '    banco.fecharConexao()
        '    consulta = banco.consultaGenerica("select idApartamento from Hhospedagem where idHospedagem=" + CStr(hospedagem))
        '    consulta.Read()
        '    idApartamento = consulta.GetInt32(0)
        '    banco.fecharConexao()
        '    banco.consultaGenerica("delete from hreserva where idReserva=" + CStr(Me.reserva))
        '    banco.fecharConexao()
        '    banco.consultaGenerica("delete from hHospedagem where idHospedagem=" + CStr(hospedagem))
        '    banco.fecharConexao()

        'End If


        'O TIPO TBM TEM QUE ESTAR PREENCHIDO ALTERAAAAAAAACAAAAAAAAO

        If (CBXAno.Text <> "" And CBXdia.Text <> "" And CBXmes.Text <> "" And CbxAnoInicio.Text <> "" And CbxDiaInicio.Text <> "" And CbxMesInicio.Text <> "" And CBXtipoApartamento.Text <> "") Then

            'DADOS ORIGINAIS DEVEM SER MANTIDOS AQUi

            CBXfrigobar.Enabled = True
            CBXcamaCasal.Enabled = True
            CBXcamaSolteiro.Enabled = True
            Dim dataFim As String = CBXdia.Text + "-" + CBXmes.Text + "-" + CBXAno.Text 'ORDEM ERRADA
            Dim dataInicio As String = CbxDiaInicio.Text + "-" + CbxMesInicio.Text + "-" + CbxAnoInicio.Text 'ORDEM ERRADA

            Dim TemC As SqlDataReader = banco.consultaGenerica("select dbo.disponibilidadeApartamento((select idtipoApartamento from htipoApartamento where tipo='" + CBXtipoApartamento.Text + "'),'" + dataInicio.ToString() + "','" + dataFim.ToString + "','S',0,0)")
            TemC.Read()
            Dim temCom As Boolean = TemC.GetBoolean(0)
            banco.fecharConexao()
            Dim temS As SqlDataReader = banco.consultaGenerica("select dbo.disponibilidadeApartamento((select idtipoApartamento from htipoApartamento where tipo='" + CBXtipoApartamento.Text + "'),'" + dataInicio.ToString + "','" + dataFim.ToString() + "','N',0,0)")
            temS.Read()
            Dim temSem As Boolean = temS.GetBoolean(0)
            banco.fecharConexao()

            If (Not temSem And temCom) Then


                Me.mudancaPermitida = True
                CBXfrigobar.Text = ""
                CBXfrigobar.SelectedText = "S"
                Me.mudancaPermitida = False

                CBXfrigobar.Enabled = False

            Else
                If (temSem And Not temCom) Then
                    Me.mudancaPermitida = True
                    CBXfrigobar.Text = ""
                    CBXfrigobar.SelectedText = "N"
                    Me.mudancaPermitida = False

                    CBXfrigobar.Enabled = False

                Else
                    If (Not temSem And Not temCom) Then
                        MessageBox.Show("Esse apartamento reservado pelo cliente em questao, é o ultimo do exemplar. Se o seu tipo for locado, nao se deve alterar as especificações")
                        Return

                    End If



                End If
            End If



            Dim nCas As SqlDataReader = banco.consultaGenerica("SELECT MAX(CAMACASAL) from hApartamento where ((select dbo.disponibilidadeApartamento((select idTipoApartamento from hTipoApartamento where tipo='" + CBXtipoApartamento.Text + "'),'" + dataInicio.ToString + "','" + dataFim.ToString + "','" + CBXfrigobar.Text + "',(hApartamento.camaCasal),0))=1)")
            nCas.Read()
            Dim nCasal As Integer


            If (nCas.IsDBNull(0)) Then
                nCasal = Nothing
            Else
                nCasal = nCas.GetValue(0)
            End If
            banco.fecharConexao()


            Dim nsol As SqlDataReader = banco.consultaGenerica("SELECT MAX(CAMASOLTEIRO) from hApartamento where ((select dbo.disponibilidadeApartamento((select idTipoApartamento from hTipoApartamento where tipo='" + CBXtipoApartamento.Text + "'),'" + dataInicio + "','" + dataFim + "','" + CBXfrigobar.Text + "',0, (hApartamento.camaSolteiro)))=1)")
            nsol.Read()

            Dim nsolteiro As Integer

            If (nsol.IsDBNull(0)) Then
                nsolteiro = Nothing
            Else
                nsolteiro = nsol.GetValue(0)
            End If
            banco.fecharConexao()



            Dim strCasal = CBXcamaCasal.Text
            Dim strSol = CBXcamaSolteiro.Text


            CBXcamaCasal.Items.Clear()
            CBXcamaSolteiro.Items.Clear()

            If (nCasal = Nothing) Then
                Me.mudancaPermitida = True
                CBXcamaCasal.Text = "0"
                Me.mudancaPermitida = False
                CBXcamaCasal.Enabled = False

            Else
                Dim cont As Integer
                cont = 0

                While (cont <= nCasal)
                    CBXcamaCasal.Items.Add(cont)
                    If (CStr(cont) = strCasal) Then
                        Me.mudancaPermitida = True
                        CBXcamaCasal.Text = strCasal
                        Me.mudancaPermitida = False
                    End If
                    cont += 1
                End While

            End If

            If (nsolteiro = Nothing) Then
                Me.mudancaPermitida = True
                CBXcamaSolteiro.Text = "0"
                Me.mudancaPermitida = False
                CBXcamaSolteiro.Enabled = False

            Else
                Dim cont As Integer
                cont = 0


                While (cont <= nsolteiro)
                    CBXcamaSolteiro.Items.Add(cont)
                    If (CStr(cont) = strSol) Then
                        Me.mudancaPermitida = True
                        CBXcamaSolteiro.Text = strSol
                        Me.mudancaPermitida = False
                    End If
                    cont += 1
                End While

            End If

            Dim diaria As SqlDataReader
            Dim consultaidTIpo As SqlDataReader
            diaria = banco.consultaGenerica("select tarifaDiaria from htipoApartamento where tipo='" + CBXtipoApartamento.Text + "'")
            diaria.Read()
            lblDiaria.Text = CStr(diaria.GetDouble(0))
            banco.fecharConexao()

            consultaidTIpo = banco.consultaGenerica("Select idTipoApartamento from htipoApartamento where tipo='" + CBXtipoApartamento.Text + "'")
            consultaidTIpo.Read()
            Me.atualizarFotos(consultaidTIpo.GetInt32(0))


            'disponibilidaDinamica()

        End If

        'If (Status = "CHPR" Or Status = "ER" Or Status = "EH") Then
        'banco.adicionaReserva(idApartamento, Me.IdCliente, inicial, final, numeroBoleto, pagamento, situacao)
        'Dim consulan As SqlDataReader = banco.consultaGenerica("SELECT MAX(IDRESERVA) FROM HRESERVA")
        'consulan.Read()
        'Me.reserva = consulan.GetInt32(0)
        'banco.fecharConexao()
        'If (Status = "EH") Then
        '    banco.adicionaHospedagem(idApartamento, Me.reserva, origem, destino, tipoDogrupo, motivoViagem)
        '    consulan = banco.consultaGenerica("SELECT MAX(IDHOSPEDAGEM) FROM hHOSPEDAGEM")
        '    consulan.Read()
        '    Me.hospedagem = consulan.GetInt32(0)
        '    banco.fecharConexao()
        'End If

        'End If


    End Sub
    Private Sub CBXtipoApartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBXtipoApartamento.SelectedIndexChanged
        If mudancaPermitida Then
            Return
        End If

        If (Status = "CHSR") Then
            If (CBXtipoApartamento.Text <> "") Then
                CBXfrigobar.Enabled = True
                BTNproximaFoto.Enabled = True
                BTNfotoAnterior.Enabled = True

            End If
        End If

        Dim consulta As SqlDataReader = banco.consultaGenerica("select descricao from htipoApartamento where tipo='" + CBXtipoApartamento.Text + "'")
        consulta.Read()
        RTXTdescricao.Text = consulta.GetString(0)
        banco.fecharConexao()
        mudancaTipo()
    End Sub

    Private Sub CBXfrigobar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBXfrigobar.SelectedIndexChanged


        If mudancaPermitida Then
            Return
        End If


        If (Status = "CHSR") Then
            If (CBXfrigobar.Text <> "") Then
                CBXcamaCasal.Enabled = True
            End If
        End If

        If (CBXfrigobar.Text <> "" And CBXcamaCasal.Text <> "" And CBXcamaSolteiro.Text <> "") Then
            If disponibilidaDinamica() = False Then
                MessageBox.Show("opção inválida")
            End If
        End If

        mudancaTipo()
    End Sub

    Private Sub CBXcamaCasal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBXcamaCasal.SelectedIndexChanged
        If mudancaPermitida Then
            Return
        End If

        If (Status = "CHSR") Then
            If (CBXcamaCasal.Text <> "") Then
                CBXcamaSolteiro.Enabled = True
            End If
        End If


        If (CBXfrigobar.Text <> "" And CBXcamaCasal.Text <> "" And CBXcamaSolteiro.Text <> "") Then
            If disponibilidaDinamica() = False Then
                MessageBox.Show("opção inválida")
            End If
        End If


        If (CBXfrigobar.Text <> "" And CBXcamaCasal.Text <> "" And CBXcamaSolteiro.Text <> "") Then
            If disponibilidaDinamica() = False Then
                MessageBox.Show("opção inválida")
            End If
        End If
        mudancaTipo()
    End Sub

    Private Sub CBXcamaSolteiro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBXcamaSolteiro.SelectedIndexChanged
        If mudancaPermitida Then
            Return
        End If

        If (Status = "CHSR") Then
            If (CBXfrigobar.Text <> "") Then
                CBXcamaCasal.Enabled = True
            End If
        End If

        If (CBXfrigobar.Text <> "" And CBXcamaCasal.Text <> "" And CBXcamaSolteiro.Text <> "") Then
            If disponibilidaDinamica() = False Then
                MessageBox.Show("opção inválida")
            End If
        End If
        mudancaTipo()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNoriginal.Click
        If (Status = "CHPR") Then
            Me.inicializar(IdCliente)
        End If

        If (Status = "ER") Then
            Me.InicializarEdicaoReserva(reserva)
        End If

        If (Status = "EH") Then
            Me.iniciarEdicaoHospedagem(Me.hospedagem)

        End If




    End Sub

    Private Sub BTNConfirmar_Click(sender As Object, e As EventArgs) Handles BTNConfirmar.Click
        If (CBXAno.Text <> "" And CBXdia.Text <> "" And CBXmes.Text <> "" And CbxAnoInicio.Text <> "" And CbxDiaInicio.Text <> "" And CbxMesInicio.Text <> "" And CBXtipoApartamento.Text <> "" And CBXfrigobar.Text <> "" And
            CBXcamaCasal.Text <> "" And CBXcamaSolteiro.Text <> "" And TXTorigem.Text <> "" And TXTdestino.Text <> "" And CBXTipoGrupo.Text <> "" And CBXmotivoViagem.Text <> "") Then
            Dim da As Date = New Date(Convert.ToInt32(CbxAnoInicio.Text), Convert.ToInt32(CbxMesInicio.Text), Convert.ToInt32(CbxDiaInicio.Text))
            Dim dp As Date = New Date(Convert.ToInt32(CBXAno.Text), Convert.ToInt32(CBXmes.Text), Convert.ToInt32(CBXdia.Text))
            If da.CompareTo(dp) = 1 Then
                MessageBox.Show("a data Início nao pode ser maior que a data fim ")
            Else
                If (CBXcamaCasal.Text = "0" And CBXcamaSolteiro.Text = "0") Then
                    MessageBox.Show("Nao se pode alugar um quarto sem cama")
                End If

                Dim dadosOriginais As SqlDataReader = banco.reservaClienteChekinDados(Me.IdCliente)
                dadosOriginais.Read()
                If ((da.CompareTo(dadosOriginais.GetDateTime(2)) = 0) And (CBXfrigobar.Text = (dadosOriginais.GetString(7))) And (CBXcamaCasal.Text = CStr(dadosOriginais.GetInt32(8))) And (CBXcamaSolteiro.Text = CStr(dadosOriginais.GetInt32(9))) And (CBXtipoApartamento.Text = (dadosOriginais.GetString(10))) And (dp.CompareTo(dadosOriginais.GetDateTime(3)) = 0)) Then
                    bancoAuxiliar.adicionaHospedagem(dadosOriginais.GetInt32(13), dadosOriginais.GetInt32(0), TXTorigem.Text, TXTdestino.Text, CBXTipoGrupo.SelectedIndex + 1, CBXmotivoViagem.SelectedIndex + 1)
                    banco.fecharConexao()
                    MessageBox.Show("Hospedagem Cadastrada com sucesso")
                    'Fechar esse e abrir o anterior
                Else
                    banco.fecharConexao()
                    If Not disponibilidaDinamica() Then
                        MessageBox.Show("Nao há disponibilidade para as condições específicadas, por favor revise o numero de camas , a requisição do frigobar ")
                    Else

                        Dim dadosFinais As SqlDataReader
                        dadosFinais = banco.consultaGenerica("select dbo.idApartamentoDisponivel('" + CBXtipoApartamento.Text + "','" + CBXfrigobar.Text + "',' " + CBXcamaCasal.Text + " ','" + CBXcamaSolteiro.Text + "','" + da.ToString + "','" + dp.ToString + "')")
                        dadosFinais.Read()
                        Dim idApartamento As Integer = dadosFinais.GetInt32(0)
                        banco.fecharConexao()
                        dadosOriginais = banco.reservaClienteChekinDados(Me.IdCliente)
                        dadosOriginais.Read()
                        Dim idreserva As Integer = dadosOriginais.GetInt32(0)
                        bancoAuxiliar.consultaGenerica(" update hreserva set dataInicio='" + da.ToString + "', datafim='" + dp.ToString() + "', idApartamento=" + CStr(idApartamento) + " where idReserva=" + CStr(idreserva))
                        bancoAuxiliar.fecharConexao()
                        bancoAuxiliar.adicionaHospedagem(idApartamento, idreserva, TXTorigem.Text, TXTdestino.Text, CBXTipoGrupo.SelectedIndex + 1, CBXmotivoViagem.SelectedIndex + 1)
                        banco.fecharConexao()
                        MessageBox.Show("Hospedagem Cadastrada com sucesso")
                        BTNvoltar.PerformClick()
                    End If
                End If
            End If
        Else
            MessageBox.Show("Por favor Preencha todos os campos, se nao houver disponibilidade nas condições desejadas alguns campos nao poderao ser preenchidos")
        End If

    End Sub

    Private Sub CbxDiaInicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxDiaInicio.SelectedIndexChanged
        If (Status = "CHSR") Then
            If (CbxDiaInicio.Text <> "" And CbxAnoInicio.Text <> "" And CbxMesInicio.Text <> "") Then
                CBXdia.Enabled = True
                CBXAno.Enabled = True
                CBXmes.Enabled = True
            End If

        End If
        disponibilidaDinamica()
        mudancaTipo()
    End Sub

    Private Sub CbxMesInicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxMesInicio.SelectedIndexChanged
        If (Status = "CHSR") Then
            If (CbxDiaInicio.Text <> "" And CbxAnoInicio.Text <> "" And CbxMesInicio.Text <> "") Then
                CBXdia.Enabled = True
                CBXAno.Enabled = True
                CBXmes.Enabled = True
            End If

        End If
        disponibilidaDinamica()
        mudancaTipo()


        If (CBXAno.Text <> "" And CBXmes.Text <> "") Then
            mudarDiasPorMes(Convert.ToInt32(CBXmes.Text), Convert.ToInt32(CBXAno.Text))
        End If
    End Sub

    Private Sub CbxAnoInicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxAnoInicio.SelectedIndexChanged
        If (Status = "CHSR") Then
            If (CbxDiaInicio.Text <> "" And CbxAnoInicio.Text <> "" And CbxMesInicio.Text <> "") Then
                CBXdia.Enabled = True
                CBXAno.Enabled = True
                CBXmes.Enabled = True
            End If

        End If
        disponibilidaDinamica()
        mudancaTipo()
        If (CBXAno.Text <> "" And CBXmes.Text <> "") Then
            mudarDiasPorMes(Convert.ToInt32(CBXmes.Text), Convert.ToInt32(CBXAno.Text))
        End If
    End Sub

    Private Sub CBXdia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBXdia.SelectedIndexChanged
        If (Status = "CHSR") Then
            If (CBXdia.Text <> "" And CBXAno.Text <> "" And CBXmes.Text <> "") Then
                CBXtipoApartamento.Enabled = True
            End If
        End If


        disponibilidaDinamica()
        mudancaTipo()
    End Sub

    Private Sub CBXmes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBXmes.SelectedIndexChanged
        If (Status = "CHSR") Then
            If (CBXdia.Text <> "" And CBXAno.Text <> "" And CBXmes.Text <> "") Then
                CBXtipoApartamento.Enabled = True
            End If
        End If
        disponibilidaDinamica()
        mudancaTipo()
        If (CBXAno.Text <> "" And CBXmes.Text <> "") Then
            mudarDiasPorMes(Convert.ToInt32(CBXmes.Text), Convert.ToInt32(CBXAno.Text))
        End If

    End Sub

    Private Sub CBXAno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBXAno.SelectedIndexChanged
        If (Status = "CHSR") Then
            If (CBXdia.Text <> "" And CBXAno.Text <> "" And CBXmes.Text <> "") Then
                CBXtipoApartamento.Enabled = True
            End If
        End If
        disponibilidaDinamica()
        mudancaTipo()
        If (CBXAno.Text <> "" And CBXmes.Text <> "") Then
            mudarDiasPorMes(Convert.ToInt32(CBXmes.Text), Convert.ToInt32(CBXAno.Text))
        End If
    End Sub

    Private Sub RTXTdescricao_TextChanged(sender As Object, e As EventArgs) Handles RTXTdescricao.TextChanged

    End Sub

    Private Sub BTNincluir_Click(sender As Object, e As EventArgs) Handles BTNincluir.Click
        If (CBXAno.Text <> "" And CBXdia.Text <> "" And CBXmes.Text <> "" And CbxAnoInicio.Text <> "" And CbxDiaInicio.Text <> "" And CbxMesInicio.Text <> "" And CBXtipoApartamento.Text <> "" And CBXfrigobar.Text <> "" And
            CBXcamaCasal.Text <> "" And CBXcamaSolteiro.Text <> "" And TXTorigem.Text <> "" And TXTdestino.Text <> "" And CBXTipoGrupo.Text <> "" And CBXmotivoViagem.Text <> "") Then
            Dim da As Date = New Date(Convert.ToInt32(CbxAnoInicio.Text), Convert.ToInt32(CbxMesInicio.Text), Convert.ToInt32(CbxDiaInicio.Text))
            Dim dp As Date = New Date(Convert.ToInt32(CBXAno.Text), Convert.ToInt32(CBXmes.Text), Convert.ToInt32(CBXdia.Text))
            If da.CompareTo(dp) = 1 Then
                MessageBox.Show("a data Início nao pode ser maior que a data fim ")
            Else
                If (CBXcamaCasal.Text = "0" And CBXcamaSolteiro.Text = "0") Then
                    MessageBox.Show("Nao se pode alugar um quarto sem cama")
                End If



                If Not disponibilidaDinamica() Then
                    MessageBox.Show("Nao há disponibilidade para as condições específicadas, por favor revise o numero de camas , a requisição do frigobar ")
                Else
                    Dim dadosFinais As SqlDataReader
                    dadosFinais = banco.consultaGenerica(" select dbo.idApartamentoDisponivel('" + CBXtipoApartamento.Text + "','" + CBXfrigobar.Text + "', " + CBXcamaCasal.Text + " ," + CBXcamaSolteiro.Text + ",'" + da.ToString() + "','" + dp.ToString() + "')")
                    dadosFinais.Read()
                    Dim idApartamento As Integer = dadosFinais.GetInt32(0)
                    banco.fecharConexao()
                    bancoAuxiliar.adicionaReserva(idApartamento, Me.IdCliente, da, dp, 0, dp, 2)
                    dadosFinais = bancoAuxiliar.reservaClienteChekinDados(Me.IdCliente)
                    dadosFinais.Read()
                    banco.adicionaHospedagem(idApartamento, dadosFinais.GetInt32(0), TXTorigem.Text, TXTdestino.Text, CBXTipoGrupo.SelectedIndex + 1, CBXmotivoViagem.SelectedIndex + 1)
                    bancoAuxiliar.fecharConexao()
                    MessageBox.Show("Hospedagem Cadastrada com sucesso")
                    BTNvoltar.PerformClick()

                End If
            End If

        Else
            MessageBox.Show("Por favor Preencha todos os campos, se nao houver disponibilidade nas condições desejadas alguns campos nao poderao ser preenchidos")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTNvoltar.Click
        chamante.Show()
        Me.Dispose()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        Try
            banco.consultaGenerica("delete from hreserva where idreserva=" + CStr(reserva))
            MessageBox.Show("Exclusao efetuada com êxito")
            BTNvoltar.PerformClick()
        Catch ex As Exception
            MessageBox.Show("A exclusao falhou, nao deve haver nenhuma hospedagem vinculada à essa reserva para ocorrer a exclusão ")
        End Try

        If (Status = "EH") Then
            Try
                banco.consultaGenerica("delete from Hhospedagem where idReserva=" + CStr(reserva))
                MessageBox.Show("Exclusao efetuada com êxito")
                BTNvoltar.PerformClick()
            Catch ex As Exception
                MessageBox.Show("A exclusao falhou, nao deve haver nenhum cadastro que relacione a hospedagem para que essa seja excluida com êxito")
            End Try

        End If


    End Sub

    Private Sub BTNalterar_Click(sender As Object, e As EventArgs) Handles BTNalterarReserva.Click
        If (Convert.ToInt32(CBXcamaCasal.Text) = 0 And Convert.ToInt32(CBXcamaSolteiro.Text) = 0) Then
            MessageBox.Show("Nao se pode escolher quarto sem camas")
            Return
        End If

        Dim da As Date = New Date(Convert.ToInt32(CbxAnoInicio.Text), Convert.ToInt32(CbxMesInicio.Text), Convert.ToInt32(CbxDiaInicio.Text))
        Dim dp As Date = New Date(Convert.ToInt32(CBXAno.Text), Convert.ToInt32(CBXmes.Text), Convert.ToInt32(CBXdia.Text))

        If (dp.CompareTo(da) < 0) Then
            MessageBox.Show("A data final deve ser maior que a inicial")
            Return
        End If

        If (disponibilidaDinamica()) Then

            Dim dadosFinais As SqlDataReader
            dadosFinais = banco.consultaGenerica("select dbo.idApartamentoDisponivel('" + CBXtipoApartamento.Text + "','" + CBXfrigobar.Text + "',' " + CBXcamaCasal.Text + " ','" + CBXcamaSolteiro.Text + "','" + da.ToString + "','" + dp.ToString + "')")
            dadosFinais.Read()
            Dim idApartamento As Integer = dadosFinais.GetInt32(0)
            banco.fecharConexao()
            Try
                bancoAuxiliar.consultaGenerica("update hreserva set dataInicio='" + da.ToString + "', datafim='" + dp.ToString() + "', idApartamento=" + CStr(idApartamento) + ", situacao =" + CStr(CBXpagamento.SelectedIndex + 1) + " where idReserva=" + CStr(reserva))
            Catch ex As Exception
                MessageBox.Show("Erro na atualização da reserva:" + ex.Message)
                banco.fecharConexao()
                Return
            End Try

        Else
            MessageBox.Show("Nao hé disponibilidade para as condições especificadas")
            banco.fecharConexao()
            banco.consultaGenerica("update hHospedagem set tipoDogrupo=" + CStr(CBXTipoGrupo.SelectedIndex + 1) + ",motivoViagem=" + CStr(CBXmotivoViagem.SelectedIndex + 1) + ",origem='" + TXTorigem.Text + "',destino='" + TXTdestino.Text + "' where idHospedagem=" + CStr(Me.hospedagem) + "")
        End If






    End Sub
End Class

'A edição é igual à inclusao, só que o botao da update. Na edição de só reserva os 3 campos da hospedagem some e para incluir sem reserva os campos vao ter que destraar gradativamente

