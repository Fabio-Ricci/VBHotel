
Imports System.Data.SqlClient
Imports System.IO

Public Class Hospedagem_Reserva
    Private IdCliente As Integer 'id do cliente da operação atual
    Private chamante As Form 'formulario que chamou este
    Private indiceFoto As Integer 'indice da foto atual na lista de exibições
    Private fotosApartamento As New List(Of Byte()) 'lista de fotos
    Private banco, bancoAuxiliar As New BD() 'objeto de vanco de dados
    Private Status As String 'CRIANDO HOSPEDAGEM POR RESERVA{CHPR},CRIANDO HOSPEDAGEM SEM RESERVA{CHSR},EDITANDO HOSPEDAGEM{EH},EDITANDO RESERVA {ER}
    Private reserva As Integer 'id da reserva atual em uso
    Private mudancaPermitida As Boolean 'mudança do componente por codigo, sem disparar o listener
    Private hospedagem As Integer '



    Public Sub setChamante(ByRef chamante As Form)
        Me.chamante = chamante
        RTXTdescricao.ReadOnly = True
    End Sub

    Public Sub setStatus(status As String)
        Me.Status = status

    End Sub




    Public Sub iniciarEdicaoHospedagem(idHospedagem As Integer)
        PBapartamento.SizeMode = PictureBoxSizeMode.StretchImage 'a foto carregada é redimensionada de acordo com o tamanho do picture box'
        LBLpagamento.Visible = False
        Me.hospedagem = idHospedagem
        Dim gasto As Double
        Dim consultan As SqlDataReader
        consultan = banco.consultaGenerica("Select dbo.gastoAtual(" + CStr(idHospedagem) + ")") 'Carrega o gasto atual da hospedagem em questao
        consultan.Read()
        gasto = consultan.GetDouble(0)
        banco.fecharConexao()
        LBLgastoHospedagem.Text = "O Gasto total atualmente para essa hospedagem é:" + CStr(gasto) 'passa o valor do gasto pro label



        LBLgastoHospedagem.Visible = True
        BTNincluir.Visible = False
        BTNConfirmar.Visible = False
        CBXpagamento.SelectedIndex = 1
        CBXpagamento.Visible = False
        setStatus("EH") ' Status editando reserva


        Me.mudancaPermitida = True ' nao dispara o listener de index change do combo box, pois informa que a mudançao de seu conteudo é permitida
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


        tiposApto = banco.consultaGenerica("select tipo from htipoApartamento where idtipoApartamento in (select idTipoApartamento from hApartamento)") 'seleciona todos os tipos de apartamento
        While (tiposApto.Read())
            CBXtipoApartamento.Items.Add(tiposApto.Item(0)) ' adiciona os tipos ao combobox
        End While

        banco.fecharConexao()
        dadosReserva = banco.consultaGenerica("select * from dbo.HospedagemEdicaoConsulta(" + CStr(idHospedagem) + ")") 'dados da hospedagem em questao
        dadosReserva.Read()
        Me.IdCliente = dadosReserva.GetInt32(1)
        Me.reserva = dadosReserva.GetInt32(0)
        'Bloco de inicialização de dados preexistentes da Hospedagem que será editada
        '////////////////////////////////////////////////////////////////////////////////////////////
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
        '//////////////////////////////////////////////////////////////////////////////////////////////////
        mudancaTipo() 'Inicialização das opções de variação dos outros combobox em relação aos dados que entraram para edição
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
        setStatus("ER") 'Status editando reserva

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
        'Inicialização de dados da reserva para edição
        '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        tiposApto = banco.consultaGenerica("select tipo from htipoApartamento where idtipoApartamento in (select idTipoApartamento from hApartamento)") 'consulta de tipos de apartamento
        While (tiposApto.Read())
            CBXtipoApartamento.Items.Add(tiposApto.Item(0)) 'Inicialização dos tipos de apartamento
        End While
        banco.fecharConexao()
        dadosReserva = banco.consultaGenerica("select * from dbo.reservaEdicaoConsulta(" + CStr(idReserva) + ")") 'Consulta dos dados da reserva em questao
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
        CBXAno.Items.Add(Date.Now.Year) 'Adiciona o ano atual e os proximos 3
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

        '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        mudancaTipo() 'População dos listbox de acordo com os dados atuais da reserva

    End Sub


    Public Sub InicializarSem(idCliente As Integer) 'Inicializa o cadastro de hospedagem serm serva prévia

        'inicia os dados apenas com as combinações possíveis, sem uma reserva ou hospedagem prévia
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

    End Sub



    Public Sub inicializar(idCliente As Integer) 'Inicializa o cadastro de uma hospedagem por uma reserva pre existente
        BTNalterarReserva.Visible = False
        btnExcluir.Visible = False
        PBapartamento.SizeMode = PictureBoxSizeMode.StretchImage
        LBLpagamento.Visible = False
        CBXpagamento.Visible = False
        BTNincluir.Visible = False

        setStatus("CHPR") 'Status Cadastrando hospedagem por reservas

        'Inicialização do cadastro da hospedagem por reserva, inicialização dos edits e combobox
        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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
        '//////////////////

        mudancaTipo() 'inicialização dos itens do combobox de acordo com os dados preexistentes da reserva


    End Sub

    Private Sub confirmaReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub atualizarFotos(tipoApartamento As Integer)
        banco.fecharConexao()
        Dim fotosConsulta As SqlDataReader = banco.fotosApartamento(tipoApartamento) 'retorna todas as fotos do apartamento daquele tipo
        fotosApartamento.Clear()
        indiceFoto = 0
        While (fotosConsulta.Read()) 'enquanto ainda há fotos
            fotosApartamento.Add(fotosConsulta.Item(0)) 'elas sao adicionadas ao
        End While
        If (fotosApartamento.Count > 0) Then 'se pelo menos há um registro na lista
            Dim foto As Byte()
            foto = fotosApartamento.Item(0) 'carregue os Bytes da foto da primeira posição
            Dim bytesDaFoto As New MemoryStream(foto)
            PBapartamento.Image = Image.FromStream(bytesDaFoto) 'coloca a foto no picture box
        End If
        banco.fecharConexao()
    End Sub

    Private Sub BTNproximaFoto_Click(sender As Object, e As EventArgs) Handles BTNproximaFoto.Click
        If (fotosApartamento.Count > 0) Then
            indiceFoto += 1 'indice da foto na lista de fotos, vai pra proxima foto
            If ((indiceFoto Mod fotosApartamento.Count) = 0) Then 'se o indice da foto é maior que o numero de fotos, o percurso nas fotos é retornado para a primeira
                indiceFoto = 0 ' torna o indice igual ao da primeira foto
            End If


            'a foto do determinado índice é carregada
            Dim foto As Byte() = fotosApartamento.Item(indiceFoto)
            Dim bytesDaFoto As New MemoryStream(foto)
            PBapartamento.Image = Image.FromStream(bytesDaFoto)
            banco.fecharConexao() ' 

        End If
    End Sub



    Private Sub mudarDiasPorMes(mes As Integer, ano As Integer) 'tem o objetivo de adicionar o numero de dias disponiveis para o respectivo mes de determinado ano no combo box
        CBXdia.Items.Clear()

        If mudancaPermitida Then 'se esse evento está sendo disparado por uma alteração feita seme estimulo do usuário
            Return 'retorne ao fluxo onde essa função foi chamada
        End If

        Dim dia As Integer
        If (CBXdia.Text <> "") Then
            dia = Convert.ToInt32(CBXdia.Text) 'pega o dia no combobox dia
        End If


        Dim cont As Integer
        Select Case mes 'troca o numero de dias selecionáveis, de acordo com o mes informado
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

        While (cont > 0) 'adiciona os dias
            d += 1
            CBXdia.Items.Add(d)
            If (CBXdia.Text <> "") Then
                If dia = d Then 'se o dia que estava selecionado antes da mudança é válido
                    mudancaPermitida = True
                    CBXdia.Text = CStr(dia) 'entao ele é mantido como item selecionado no combobox
                    mudancaPermitida = False
                End If
            End If
            cont -= 1
        End While


    End Sub
    Private Sub mudarDiasPorMesInicio(mes As Integer, ano As Integer) 'Análoga à função acima, só que funciona para os combobox referentes à data inicial

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


    Private Function disponibilidaDinamica() As Boolean 'verifica a disponibilidade de acordo com os estimulos gerados pelo usuário


        Dim dataFim As String = CBXdia.Text + "-" + CBXmes.Text + "-" + CBXAno.Text 'ORDEM ERRADA
        Dim dataInicio As String = CbxDiaInicio.Text + "-" + CbxMesInicio.Text + "-" + CbxAnoInicio.Text 'ORDEM ERRADA

        Dim strTipo As String = CBXtipoApartamento.Text


        If (CBXAno.Text <> "" And CBXdia.Text <> "" And CBXmes.Text <> "" And CbxAnoInicio.Text <> "" And CbxDiaInicio.Text <> "" And CbxMesInicio.Text <> "") Then
            Dim tiposApto As SqlDataReader
            tiposApto = banco.consultaGenerica("select tipo from htipoApartamento where ((select dbo.disponibilidadeApartamento(htipoApartamento.idTipoApartamento,'" + dataInicio.ToString + "','" + dataFim.ToString + "','N',0,0))=1) or ((select dbo.disponibilidadeApartamento(htipoApartamento.idTipoApartamento,'" + dataInicio.ToString + "','" + dataFim.ToString + "','S',0,0))=1)")
            If Not tiposApto.HasRows Then 'se nao há tipo disponivel para as condições especificadas de data
                'todos os campos sao limpos
                Me.mudancaPermitida = True
                CBXfrigobar.Text = ""
                CBXfrigobar.Enabled = False

                CBXcamaCasal.Text = ""
                CBXcamaCasal.Enabled = False

                CBXcamaSolteiro.Enabled = False
                CBXcamaSolteiro.Text = ""
                Me.mudancaPermitida = False

            Else
                'senao os campos sao habilitados para a entrada de dados
                CBXfrigobar.Enabled = True
                CBXcamaCasal.Enabled = True
                CBXcamaSolteiro.Enabled = True
            End If

            CBXtipoApartamento.Items.Clear()
            If (tiposApto.HasRows) Then
                While (tiposApto.Read()) 'enquanto há tipos, adicionem eles ao combobox
                    CBXtipoApartamento.Items.Add(tiposApto.Item(0))
                    If strTipo = tiposApto.Item(0) Then
                        Me.mudancaPermitida = True
                        CBXtipoApartamento.Text = tiposApto.Item(0) 'se o tipo que ja estava selecionado for válido, matenha ele no texto do textbox
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
            retorno = disponibilidade.GetBoolean(0) 'pega o valor boolean da função SQL server de disponibilidade do apartamento -> true disponivel, false nao disponivel
            banco.fecharConexao()
        Else
            retorno = Nothing 'siginifica que a validação nao pode ocorre pois os campos nao estavam preenchidos

        End If

        

        Return retorno
    End Function




    Private Sub BTNfotoAnterior_Click(sender As Object, e As EventArgs) Handles BTNfotoAnterior.Click


        'Volta pra foto anterior subtraindo o indice, se o indice ficar negativo
        'a foto atual se torna a última (semelhante a uma lista circular)
        If (fotosApartamento.Count > 0) Then
            indiceFoto -= 1
            If (indiceFoto = -1) Then
                indiceFoto = fotosApartamento.Count - 1
            End If

            Dim foto As Byte() = fotosApartamento.Item(indiceFoto) 'passa para um vetor de bytes o  valor do indice IndiceFoto na lista de bytes ListaFoto
            Dim bytesDaFoto As New MemoryStream(foto)
            PBapartamento.Image = Image.FromStream(bytesDaFoto) 'Carrega a imagem contida no vetor Foto no picture box
            banco.fecharConexao()

        End If
    End Sub

    Private Sub mudancaTipo()
        If mudancaPermitida Then
            Return
        End If



        If (CBXAno.Text <> "" And CBXdia.Text <> "" And CBXmes.Text <> "" And CbxAnoInicio.Text <> "" And CbxDiaInicio.Text <> "" And CbxMesInicio.Text <> "" And CBXtipoApartamento.Text <> "") Then


            CBXfrigobar.Enabled = True
            CBXcamaCasal.Enabled = True
            CBXcamaSolteiro.Enabled = True
            Dim dataFim As String = CBXdia.Text + "-" + CBXmes.Text + "-" + CBXAno.Text
            Dim dataInicio As String = CbxDiaInicio.Text + "-" + CbxMesInicio.Text + "-" + CbxAnoInicio.Text

            Dim TemC As SqlDataReader = banco.consultaGenerica("select dbo.disponibilidadeApartamento((select idtipoApartamento from htipoApartamento where tipo='" + CBXtipoApartamento.Text + "'),'" + dataInicio.ToString() + "','" + dataFim.ToString + "','S',0,0)")
            TemC.Read()
            Dim temCom As Boolean = TemC.GetBoolean(0)
            banco.fecharConexao() 'consulta de disponibilidade do apartamento no intervalo e do tipo especificado com frigobar
            Dim temS As SqlDataReader = banco.consultaGenerica("select dbo.disponibilidadeApartamento((select idtipoApartamento from htipoApartamento where tipo='" + CBXtipoApartamento.Text + "'),'" + dataInicio.ToString + "','" + dataFim.ToString() + "','N',0,0)")
            temS.Read() 'consulta de disponibilidade do apartamento no intervalo e do tipo especificado sem frigobar
            Dim temSem As Boolean = temS.GetBoolean(0)
            banco.fecharConexao()

            If (Not temSem And temCom) Then

                'se so tem com
                Me.mudancaPermitida = True
                CBXfrigobar.Text = ""
                CBXfrigobar.SelectedText = "S" 'o texto mostrado é com
                Me.mudancaPermitida = False

                CBXfrigobar.Enabled = False

            Else
                If (temSem And Not temCom) Then
                    'se so tem sem
                    Me.mudancaPermitida = True
                    CBXfrigobar.Text = ""
                    CBXfrigobar.SelectedText = "N" ' o texto N é mostrado
                    Me.mudancaPermitida = False

                    CBXfrigobar.Enabled = False

                Else
                    If (Not temSem And Not temCom) Then
                        MessageBox.Show("Esse apartamento reservado pelo cliente em questao, é o ultimo do exemplar. Se o seu tipo for locado, nao se deve alterar as especificações")
                        'se nao tem os dois, entao o apartamento nao está disponivel
                        Return

                    End If



                End If
            End If



            Dim nCas As SqlDataReader = banco.consultaGenerica("SELECT MAX(CAMACASAL) from hApartamento where ((select dbo.disponibilidadeApartamento((select idTipoApartamento from hTipoApartamento where tipo='" + CBXtipoApartamento.Text + "'),'" + dataInicio.ToString + "','" + dataFim.ToString + "','" + CBXfrigobar.Text + "',(hApartamento.camaCasal),0))=1)")
            nCas.Read()
            Dim nCasal As Integer 'pega o valor maximo de camaCasal com as condições especificadas


            If (nCas.IsDBNull(0)) Then
                nCasal = Nothing 'se é zero, null é atribuido à variável
            Else
                nCasal = nCas.GetValue(0) 'senao o valor maximo de camaCasal de acordo com as condições especificadas é armazenada
            End If
            banco.fecharConexao()


            Dim nsol As SqlDataReader = banco.consultaGenerica("SELECT MAX(CAMASOLTEIRO) from hApartamento where ((select dbo.disponibilidadeApartamento((select idTipoApartamento from hTipoApartamento where tipo='" + CBXtipoApartamento.Text + "'),'" + dataInicio + "','" + dataFim + "','" + CBXfrigobar.Text + "',0, (hApartamento.camaSolteiro)))=1)")
            nsol.Read() 'pega o numero maximo de camas de solteiro com as condições especificadas

            Dim nsolteiro As Integer

            If (nsol.IsDBNull(0)) Then 'se for 0 variáel que representa o numero de camas de solteiro recebe null
                nsolteiro = Nothing
            Else
                nsolteiro = nsol.GetValue(0) ' senao ele recebe o valor retornado
            End If
            banco.fecharConexao()



            Dim strCasal = CBXcamaCasal.Text 'o numero no momento da modificação é guardado
            Dim strSol = CBXcamaSolteiro.Text


            CBXcamaCasal.Items.Clear()
            CBXcamaSolteiro.Items.Clear()

            If (nCasal = Nothing) Then 'se ele representa nada
                Me.mudancaPermitida = True
                CBXcamaCasal.Text = "0" ' o texto atual é da cama casal passa a ser 0
                Me.mudancaPermitida = False ' como ele é zero, nao poderão ocorrer alterações
                CBXcamaCasal.Enabled = False ' entao ocorre o travamento

            Else
                Dim cont As Integer
                cont = 0

                While (cont <= nCasal) 'senao , todas as combinações possiveis sao adicionadas no combobox
                    CBXcamaCasal.Items.Add(cont) ' os itens representados em numero pelo contador de cama casal sao adicionados ao combobox
                    If (CStr(cont) = strCasal) Then ' se o numero a ser adicionado é referente ao numero que estava contido no texto do combobox no momento da mudança
                        Me.mudancaPermitida = True
                        CBXcamaCasal.Text = strCasal 'o numero é mantido
                        Me.mudancaPermitida = False
                    End If
                    cont += 1
                End While

            End If

            If (nsolteiro = Nothing) Then 'ANÁLOGO ÀS modificações acima, mas agr é referente ao numero de camas de solteiro
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
            lblDiaria.Text = CStr(diaria.GetDouble(0)) 'exibe a diária referente ao tipo selecionado no label da diária
            banco.fecharConexao()

            consultaidTIpo = banco.consultaGenerica("Select idTipoApartamento from htipoApartamento where tipo='" + CBXtipoApartamento.Text + "'")
            consultaidTIpo.Read()
            Me.atualizarFotos(consultaidTIpo.GetInt32(0)) 'atualiza as fotos que serao mostradas na pesquisa referente ao tipo selecionado




        End If




    End Sub
    Private Sub CBXtipoApartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBXtipoApartamento.SelectedIndexChanged
        If mudancaPermitida Then
            Return
        End If

        If (Status = "CHSR") Then 'se o tipo for o cadastro de hospedagem serm reserva , são destravados os campos gradualmente à media que outros sao preenchidos
            If (CBXtipoApartamento.Text <> "") Then
                CBXfrigobar.Enabled = True
                BTNproximaFoto.Enabled = True
                BTNfotoAnterior.Enabled = True

            End If
        End If

        Dim consulta As SqlDataReader = banco.consultaGenerica("select descricao from htipoApartamento where tipo='" + CBXtipoApartamento.Text + "'")
        'quando se altera o tipo, deve ser alterada a descrição para a descrição referente àquele tipo
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
                MessageBox.Show("opção inválida") ' alteração nao validada como válida, opção nao disponivel
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


        If (CBXfrigobar.Text <> "" And CBXcamaCasal.Text <> "" And CBXcamaSolteiro.Text <> "") Then 'análogo à verificação do listener superior
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

        If (CBXfrigobar.Text <> "" And CBXcamaCasal.Text <> "" And CBXcamaSolteiro.Text <> "") Then 'análogo à verificação do listener superior
            If disponibilidaDinamica() = False Then
                MessageBox.Show("opção inválida")
            End If
        End If
        mudancaTipo()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNoriginal.Click

        'reinicializa os valores do formulário principal de acordo com o tipo de utilização do formulário atual

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
            If da.CompareTo(dp) = 1 Then ' se data inicio for maior que a data fim
                MessageBox.Show("a data Início nao pode ser maior que a data fim ") 'informa usuário
            Else
                If (CBXcamaCasal.Text = "0" And CBXcamaSolteiro.Text = "0") Then
                    MessageBox.Show("Nao se pode alugar um quarto sem cama")
                End If

                Dim dadosOriginais As SqlDataReader = banco.reservaClienteChekinDados(Me.IdCliente)
                dadosOriginais.Read()
                If ((da.CompareTo(dadosOriginais.GetDateTime(2)) = 0) And (CBXfrigobar.Text = (dadosOriginais.GetString(7))) And (CBXcamaCasal.Text = CStr(dadosOriginais.GetInt32(8))) And (CBXcamaSolteiro.Text = CStr(dadosOriginais.GetInt32(9))) And (CBXtipoApartamento.Text = (dadosOriginais.GetString(10))) And (dp.CompareTo(dadosOriginais.GetDateTime(3)) = 0)) Then
                    ' se os dados nao foram alterados em relaçao aos inciais
                    bancoAuxiliar.adicionaHospedagem(dadosOriginais.GetInt32(13), dadosOriginais.GetInt32(0), TXTorigem.Text, TXTdestino.Text, CBXTipoGrupo.SelectedIndex + 1, CBXmotivoViagem.SelectedIndex + 1)

                    banco.fecharConexao()
                    MessageBox.Show("Hospedagem Cadastrada com sucesso")
                    'Fechar esse e abrir o anterior
                Else
                    banco.fecharConexao()
                    If Not disponibilidaDinamica() Then
                        MessageBox.Show("Nao há disponibilidade para as condições específicadas, por favor revise o numero de camas , a requisição do frigobar ")
                        ' as condições especificadas sao inválidas
                    Else

                        Dim dadosFinais As SqlDataReader
                        dadosFinais = banco.consultaGenerica("select dbo.idApartamentoDisponivel('" + CBXtipoApartamento.Text + "','" + CBXfrigobar.Text + "',' " + CBXcamaCasal.Text + " ','" + CBXcamaSolteiro.Text + "','" + da.ToString + "','" + dp.ToString + "')")
                        'pega o ID do apartamento que atende as condições especificadas
                        dadosFinais.Read()
                        Dim idApartamento As Integer = dadosFinais.GetInt32(0)
                        banco.fecharConexao()
                        dadosOriginais = banco.reservaClienteChekinDados(Me.IdCliente)
                        dadosOriginais.Read()
                        Dim idreserva As Integer = dadosOriginais.GetInt32(0)
                        'realiza o update da reserva de acordo com as novas condições fornecidas
                        bancoAuxiliar.consultaGenerica(" update hreserva set dataInicio='" + da.ToString + "', datafim='" + dp.ToString() + "', idApartamento=" + CStr(idApartamento) + " where idReserva=" + CStr(idreserva))
                        bancoAuxiliar.fecharConexao()
                        bancoAuxiliar.adicionaHospedagem(idApartamento, idreserva, TXTorigem.Text, TXTdestino.Text, CBXTipoGrupo.SelectedIndex + 1, CBXmotivoViagem.SelectedIndex + 1)
                        'adiciona uma hospedagem de acordo com as informações fornecidas
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
            If (CbxDiaInicio.Text <> "" And CbxAnoInicio.Text <> "" And CbxMesInicio.Text <> "") Then 'se o tipo é colocado e está sendo cadastrado sem reserva
                CBXdia.Enabled = True 'os proximos 3 campos estao liberados
                CBXAno.Enabled = True
                CBXmes.Enabled = True
            End If

        End If
        disponibilidaDinamica() ' disponibilidade segundo fatores alterados
        mudancaTipo() ' disponibilidade segundo mudança de tipo
    End Sub

    Private Sub CbxMesInicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxMesInicio.SelectedIndexChanged
        If (Status = "CHSR") Then
            If (CbxDiaInicio.Text <> "" And CbxAnoInicio.Text <> "" And CbxMesInicio.Text <> "") Then 'se os 3 campos da data inicial sao preenchidos
                CBXdia.Enabled = True ' os proximos de data sao destravados
                CBXAno.Enabled = True
                CBXmes.Enabled = True
            End If

        End If
        disponibilidaDinamica() ' disponibilidade de recursos do apartamento e populaçao dos combobox de acordo com a data
        mudancaTipo() 'disponibilidade de recursos do apartamento de acordo com o tipo atual


        If (CBXAno.Text <> "" And CBXmes.Text <> "") Then
            mudarDiasPorMes(Convert.ToInt32(CBXmes.Text), Convert.ToInt32(CBXAno.Text))
        End If
    End Sub

    Private Sub CbxAnoInicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxAnoInicio.SelectedIndexChanged
        If (Status = "CHSR") Then
            If (CbxDiaInicio.Text <> "" And CbxAnoInicio.Text <> "" And CbxMesInicio.Text <> "") Then
                CBXdia.Enabled = True 'se todos os campos da data inicio sao preenchidos
                CBXAno.Enabled = True 'os proximos campos a serem preenchidos serão destravados
                CBXmes.Enabled = True
            End If

        End If
        disponibilidaDinamica()
        mudancaTipo()
        If (CBXAno.Text <> "" And CBXmes.Text <> "") Then
            mudarDiasPorMes(Convert.ToInt32(CBXmes.Text), Convert.ToInt32(CBXAno.Text)) 'preenche os dias disponiveis de acordo com o mes e ano selecionados
        End If
    End Sub

    Private Sub CBXdia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBXdia.SelectedIndexChanged
        If (Status = "CHSR") Then
            If (CBXdia.Text <> "" And CBXAno.Text <> "" And CBXmes.Text <> "") Then
                CBXtipoApartamento.Enabled = True 'se as datas forem preenchidas o seletor de tipos é destravado
            End If
        End If


        disponibilidaDinamica()
        mudancaTipo()
    End Sub

    Private Sub CBXmes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBXmes.SelectedIndexChanged
        If (Status = "CHSR") Then
            If (CBXdia.Text <> "" And CBXAno.Text <> "" And CBXmes.Text <> "") Then 'se a data final é preenchoda
                CBXtipoApartamento.Enabled = True 'o seletor de tipos é destravado
            End If
        End If
        disponibilidaDinamica()
        mudancaTipo()
        If (CBXAno.Text <> "" And CBXmes.Text <> "") Then
            mudarDiasPorMes(Convert.ToInt32(CBXmes.Text), Convert.ToInt32(CBXAno.Text)) 'seleciona os dias validos de acordo com mes e ano
        End If

    End Sub

    Private Sub CBXAno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBXAno.SelectedIndexChanged
        If (Status = "CHSR") Then 'condição cadastrando hospedagem sem reserva
            If (CBXdia.Text <> "" And CBXAno.Text <> "" And CBXmes.Text <> "") Then
                CBXtipoApartamento.Enabled = True ' se as datas forem preenhcidas o seletor de tipó é destravado
            End If
        End If
        disponibilidaDinamica()
        mudancaTipo()
        If (CBXAno.Text <> "" And CBXmes.Text <> "") Then
            mudarDiasPorMes(Convert.ToInt32(CBXmes.Text), Convert.ToInt32(CBXAno.Text)) 'preenche a variação de dias de acordo com mes e ano atual
        End If
    End Sub

    Private Sub RTXTdescricao_TextChanged(sender As Object, e As EventArgs) Handles RTXTdescricao.TextChanged

    End Sub

    Private Sub BTNincluir_Click(sender As Object, e As EventArgs) Handles BTNincluir.Click
        If (CBXAno.Text <> "" And CBXdia.Text <> "" And CBXmes.Text <> "" And CbxAnoInicio.Text <> "" And CbxDiaInicio.Text <> "" And CbxMesInicio.Text <> "" And CBXtipoApartamento.Text <> "" And CBXfrigobar.Text <> "" And
            CBXcamaCasal.Text <> "" And CBXcamaSolteiro.Text <> "" And TXTorigem.Text <> "" And TXTdestino.Text <> "" And CBXTipoGrupo.Text <> "" And CBXmotivoViagem.Text <> "") Then
            Dim da As Date = New Date(Convert.ToInt32(CbxAnoInicio.Text), Convert.ToInt32(CbxMesInicio.Text), Convert.ToInt32(CbxDiaInicio.Text))
            Dim dp As Date = New Date(Convert.ToInt32(CBXAno.Text), Convert.ToInt32(CBXmes.Text), Convert.ToInt32(CBXdia.Text))
            If da.CompareTo(dp) = 1 Then ' compare to -> se data inicio maior que data fim
                MessageBox.Show("a data Início nao pode ser maior que a data fim ") 'alerta
            Else
                If (CBXcamaCasal.Text = "0" And CBXcamaSolteiro.Text = "0") Then 'se o numero das duas camas for zero
                    MessageBox.Show("Nao se pode alugar um quarto sem cama") 'alerta
                End If



                If Not disponibilidaDinamica() Then ' se nao há disponibilidade segundo às condições especificadas
                    MessageBox.Show("Nao há disponibilidade para as condições específicadas, por favor revise o numero de camas , a requisição do frigobar ") 'alerta
                Else
                    Dim dadosFinais As SqlDataReader
                    dadosFinais = banco.consultaGenerica(" select dbo.idApartamentoDisponivel('" + CBXtipoApartamento.Text + "','" + CBXfrigobar.Text + "', " + CBXcamaCasal.Text + " ," + CBXcamaSolteiro.Text + ",'" + da.ToString() + "','" + dp.ToString() + "')")
                    dadosFinais.Read() 'ID do apartamento das condições especificadas
                    Dim idApartamento As Integer = dadosFinais.GetInt32(0)
                    banco.fecharConexao()
                    bancoAuxiliar.adicionaReserva(idApartamento, Me.IdCliente, da, dp, 0, dp, 2) 'adiciona reserva com as condições editadas
                    dadosFinais = bancoAuxiliar.reservaClienteChekinDados(Me.IdCliente)
                    dadosFinais.Read()
                    banco.adicionaHospedagem(idApartamento, dadosFinais.GetInt32(0), TXTorigem.Text, TXTdestino.Text, CBXTipoGrupo.SelectedIndex + 1, CBXmotivoViagem.SelectedIndex + 1)
                    'adiciona a hospedagem com os valores especificadas
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
            banco.consultaGenerica("delete from hreserva where idreserva=" + CStr(reserva)) 'exclui a reserva
            MessageBox.Show("Exclusao efetuada com êxito")
            BTNvoltar.PerformClick()
        Catch ex As Exception
            MessageBox.Show("A exclusao falhou, nao deve haver nenhuma hospedagem vinculada à essa reserva para ocorrer a exclusão ")
        End Try

        If (Status = "EH") Then
            Try
                banco.consultaGenerica("delete from Hhospedagem where idReserva=" + CStr(reserva)) 'exclui da hospedagem depois
                MessageBox.Show("Exclusao efetuada com êxito")
                BTNvoltar.PerformClick()
            Catch ex As Exception
                MessageBox.Show("A exclusao falhou, nao deve haver nenhum cadastro que relacione a hospedagem para que essa seja excluida com êxito")
            End Try

        End If


    End Sub

    Private Sub BTNalterar_Click(sender As Object, e As EventArgs) Handles BTNalterarReserva.Click
        If (Convert.ToInt32(CBXcamaCasal.Text) = 0 And Convert.ToInt32(CBXcamaSolteiro.Text) = 0) Then
            MessageBox.Show("Nao se pode escolher quarto sem camas") 'verificação se os valores de camas sao 0
            Return
        End If

        Dim da As Date = New Date(Convert.ToInt32(CbxAnoInicio.Text), Convert.ToInt32(CbxMesInicio.Text), Convert.ToInt32(CbxDiaInicio.Text))
        Dim dp As Date = New Date(Convert.ToInt32(CBXAno.Text), Convert.ToInt32(CBXmes.Text), Convert.ToInt32(CBXdia.Text))

        If (dp.CompareTo(da) < 0) Then 'verifica se data inicio é maior que data fim
            MessageBox.Show("A data final deve ser maior que a inicial")
            Return
        End If

        If (disponibilidaDinamica()) Then

            Dim dadosFinais As SqlDataReader
            dadosFinais = banco.consultaGenerica("select dbo.idApartamentoDisponivel('" + CBXtipoApartamento.Text + "','" + CBXfrigobar.Text + "',' " + CBXcamaCasal.Text + " ','" + CBXcamaSolteiro.Text + "','" + da.ToString + "','" + dp.ToString + "')")
            dadosFinais.Read()
            Dim idApartamento As Integer = dadosFinais.GetInt32(0) 'pega o id do apartamento disponvel
            banco.fecharConexao()
            Try
                bancoAuxiliar.consultaGenerica("update hreserva set dataInicio='" + da.ToString + "', datafim='" + dp.ToString() + "', idApartamento=" + CStr(idApartamento) + ", situacao =" + CStr(CBXpagamento.SelectedIndex + 2) + " where idReserva=" + CStr(reserva))
                banco.fecharConexao()
                MsgBox("Alterações efetuadas com êxito")
                Me.Hide()
            Catch ex As Exception 'atualiza reserva
                MessageBox.Show("Erro na atualização da reserva:" + ex.Message)
                banco.fecharConexao()
                Return
            End Try

        Else
            MessageBox.Show("Nao hé disponibilidade para as condições especificadas")
            banco.fecharConexao() ' atualiza hospedagem
            banco.consultaGenerica("update hHospedagem set tipoDogrupo=" + CStr(CBXTipoGrupo.SelectedIndex + 1) + ",motivoViagem=" + CStr(CBXmotivoViagem.SelectedIndex + 1) + ",origem='" + TXTorigem.Text + "',destino='" + TXTdestino.Text + "' where idHospedagem=" + CStr(Me.hospedagem) + "")
        End If






    End Sub
End Class

'A edição é igual à inclusao, só que o botao da update. Na edição de só reserva os 3 campos da hospedagem somem e para incluir sem reserva os campos vao ter que destraar gradativamente

