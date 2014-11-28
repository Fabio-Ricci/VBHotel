Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO

Public Class BD
    Private conexao As SqlConnection
    Private comando As SqlCommand
    Private dataReader As SqlDataReader

    Sub New()
        Me.conexao = New SqlConnection("Data Source=REGULUS;Initial Catalog=hospdeiros;Persist Security Info=True;User ID=hospdeiros;Password=amostra")
        comando = New SqlCommand
    End Sub


    Public Function logar(username As String, senha As String) As Boolean
        Dim existe As Boolean
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try

        Me.comando = New SqlCommand("Select dbo.loginVB('" + username + "','" + hashOfString(senha + Convert.ToString(senha.Length) + username) + "')", Me.conexao)
        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro na autenticacao do usuario->Erro: " + ex.ToString)
        End Try
        Me.dataReader.Read()
        existe = dataReader.Item(0)
        Me.conexao.Close()
        Return existe
    End Function

    Private Function hashOfString(ByVal stringToHash As String) As String
        Dim uEncode As New UnicodeEncoding()
        Dim bytClearString() As Byte = uEncode.GetBytes(stringToHash)
        Dim sha As New  _
        System.Security.Cryptography.SHA256Managed()
        Dim hash() As Byte = sha.ComputeHash(bytClearString)
        Return Convert.ToBase64String(hash)
    End Function

    Private Function usuarioExistente(username As String) As Boolean
        Dim existe As Boolean
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("Select dbo.usuarioExistente('" + username + "')", Me.conexao)

        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao consultar existencia de usuario no banco de dados->Erro: " + ex.ToString)
        End Try

        Me.dataReader.Read()
        existe = Me.dataReader.Item(0)
        Me.conexao.Close()
        Return existe
    End Function

    Public Sub adicionaUsuario(username As String, senha As String, privilegio As Integer, foto As Byte())
        If (Not Me.usuarioExistente(username)) Then
            Try
                Me.conexao.Open()
            Catch ex As Exception
                Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
            End Try
            Me.comando = New SqlCommand("exec dbo.adiciona_hUsuario '" + username + "'," + "'" + hashOfString(senha + Convert.ToString(senha.Length) + username) + "'," + CStr(privilegio) + "," + "@img", Me.conexao)
            Me.comando.Parameters.Add(New SqlParameter("@img", foto))
            Try
                Me.comando.ExecuteNonQuery()
            Catch ex As Exception
                Me.conexao.Close()
                Throw New System.Exception("Erro ao ao efetuar a insercao do usuario no banco de dados->Erro: " + ex.ToString)
            End Try
        Else
            Me.conexao.Close()
            Throw New System.Exception("O Username ja existe, por favor escolha outro")
        End If
        Me.conexao.Close()
    End Sub

    Public Sub adicionaCliente(nome As String, dataNascimento As String, sexo As Char, email As String, telefone As String, celular As String, endereco As String,
     bairro As String, cidade As String, pais As String, siglaUF As String, senha As String, numeroCartao As String, codigoSeguranca As String, nomeTitular As String, dataValidade As String, cpf As String)
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("exec dbo.adiciona_hCliente '" + nome + "'," + "'" + dataNascimento + "'," + "'" + CStr(sexo) + "','" + email + "','" +
        telefone + "','" + celular + "','" + endereco + "','" + bairro + "','" + cidade + "','" + pais + "','" + siglaUF + "','" + hashOfString(senha) + "','" + hashOfString(numeroCartao) + "','" + hashOfString(codigoSeguranca) +
        "','" + hashOfString(nomeTitular) + "','" + hashOfString(dataValidade) + "','" + cpf + "'", Me.conexao)
        Try
            Me.comando.ExecuteNonQuery()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao efetuar a insercao do Cliente->Erro: " + ex.ToString)
        End Try
        Me.conexao.Close()
    End Sub

    '------Tipo Apartamento -------

    Public Function infoApartamento(numeroApartamento As Integer) As SqlDataReader
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("Select * from dbo.infoApartamento(@numeroApartamento)", Me.conexao)
        Me.comando.Parameters.Add(New SqlParameter("@numeroApartamento", numeroApartamento))
        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro na pesquisa das informações do apartamento->Erro: " + ex.ToString)
        End Try
        Return Me.dataReader
    End Function

    Public Function tiposApartamento() As SqlDataReader
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("select tipo from hTipoApartamento", Me.conexao)
        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro na pesquisa das informações do apartamento->Erro: " + ex.ToString)
        End Try
        Return Me.dataReader
    End Function

    Public Function infoTipoApartamento(tipoApartamento As String) As SqlDataReader
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("Select * from hTipoApartamento where tipo = '" + tipoApartamento + "'", Me.conexao)
        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro na busca de info tipo apartamento->Erro: " + ex.ToString)
        End Try
        Return Me.dataReader
    End Function

    Public Sub adicionaTipoApartamento(descricao As String, diaria As Double, tipo As String)
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("exec dbo.adiciona_hTipoApartamento @descricao,@diaria,@tipo", Me.conexao)
        Me.comando.Parameters.Add(New SqlParameter("@descricao", descricao))
        Me.comando.Parameters.Add(New SqlParameter("@diaria", diaria))
        Me.comando.Parameters.Add(New SqlParameter("@tipo", tipo))
        Try
            Me.comando.ExecuteNonQuery()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao efetuar a insercao do tipoApartamento->Erro: " + ex.ToString)
        End Try
        Me.conexao.Close()
    End Sub

    Public Function infoCliente() As SqlDataReader 'MUDADO'
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("select * from hCliente", Me.conexao)
        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro na pesquisa das informações do Cliente->Erro: " + ex.ToString)
        End Try

        ''Me.conexao.Close() // FECHAR DEPOIS DE USAR COM O MÉTODO FECHAR CONEXAO DA CLASSE BD  ".fecharConexao()"
        Return Me.dataReader
    End Function

    Public Sub editaTipoApartamento(descricao As String, diaria As Double, tipo As String, idTipo As Integer)
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("exec edita_hTipoApartamento @descricao,@tarifa,@tipo,@idTipo", Me.conexao)
        Me.comando.Parameters.Add(New SqlParameter("@descricao", descricao))
        Me.comando.Parameters.Add(New SqlParameter("@tarifa", diaria))
        Me.comando.Parameters.Add(New SqlParameter("@tipo", tipo))
        Me.comando.Parameters.Add(New SqlParameter("@idTipo", idTipo))
        Try
            Me.comando.ExecuteNonQuery()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao efetuar a edicao do tipoApartamento->Erro: " + ex.ToString)
        End Try
        Me.conexao.Close()
    End Sub

    Public Sub adicionaFotoApartamento(idTipoApartamento As Integer, foto As Byte())
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("exec dbo.adiciona_hfotoApartamento @idTipoApartamento,@img", Me.conexao)
        Me.comando.Parameters.Add(New SqlParameter("@img", foto))
        Me.comando.Parameters.Add(New SqlParameter("@idTipoApartamento", idTipoApartamento))
        Try
            Me.comando.ExecuteNonQuery()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao efetuar a insercao da fotoApartamento->Erro: " + ex.ToString)
        End Try
        Me.conexao.Close()
    End Sub

    Public Function fotosApartamento(idTipoApartamento As Integer) As SqlDataReader
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("Select * from dbo.fotosApartamento(@idApartamento)", Me.conexao)
        Me.comando.Parameters.Add(New SqlParameter("@idApartamento", idTipoApartamento))
        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro na pesquisa das fotos->Erro: " + ex.ToString)
        End Try
        Return Me.dataReader
    End Function

    '
    'Apartamento
    '
    Public Sub removerApartamento(numero As Integer)
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("exec dbo.removerApartamento @numero", Me.conexao)
        Me.comando.Parameters.AddWithValue("@numero", CStr(numero))
        Try
            Me.comando.ExecuteNonQuery()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao efetuar a remoção do apartamento->Erro: " + ex.ToString)
        End Try
        Me.conexao.Close()
    End Sub

    Public Sub adicionaApartamento(idTipoApartamento As Integer, numero As String, andar As Integer, camaCasal As Integer, camaSolteiro As Integer, frigobar As Char)
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("exec dbo.adiciona_hApartamento " + CStr(idTipoApartamento) + ", " + numero + ", " + CStr(andar) + ", " + CStr(camaCasal) + ", " + CStr(camaSolteiro) + ", '" + frigobar + "'", Me.conexao)
        Try
            Me.comando.ExecuteNonQuery()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao efetuar a insercao do apartamento->Erro: " + ex.ToString)
        End Try
        Me.conexao.Close()
    End Sub

    Public Sub updateApartamento(numero As Integer, idTipoApartamento As Integer, andar As Integer, camaCasal As Integer, camaSolteiro As Integer, frigobar As Char)
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("exec dbo.atualiza_hApartamento " + CStr(numero) + ", " + CStr(idTipoApartamento) + ", " + CStr(andar) + ", " + CStr(camaCasal) + ", " + CStr(camaSolteiro) + ", '" + CStr(frigobar) + "'", Me.conexao)
        Try
            Me.comando.ExecuteNonQuery()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao efetuar a insercao do apartamento->Erro: " + ex.ToString)
        End Try
        Me.conexao.Close()
    End Sub

    Public Function getIdTipoApartamento(tipo As String)
        Dim id As Integer
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try

        Me.comando = New SqlCommand("Select dbo.idTipoApartamento(@numero)", Me.conexao)
        Me.comando.Parameters.Add(New SqlParameter("@numero", tipo))

        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro na consulta do e-mail->Erro: " + ex.ToString)
        End Try
        Me.dataReader.Read()
        id = dataReader.Item(0)
        Me.conexao.Close()
        Return id
    End Function

    Public Function selecionaDadosEdicaoApartamento(numero As Integer)
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("Select * from dbo.infoApartamento(@numeroApartamento)", Me.conexao)
        Me.comando.Parameters.Add(New SqlParameter("@numeroApartamento", numero))
        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro na pesquisa das informações do apartamento->Erro: " + ex.ToString)
        End Try
        Return Me.dataReader
    End Function

    Public Function numeroApartamentoExiste(numero As Integer) As Boolean
        Dim existe As Boolean
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try

        Me.comando = New SqlCommand("Select dbo.numeroApartamentoExiste(@numero)", Me.conexao)
        Me.comando.Parameters.Add(New SqlParameter("@numero", numero))

        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro na consulta do e-mail->Erro: " + ex.ToString)
        End Try
        Me.dataReader.Read()
        existe = dataReader.Item(0)
        Me.conexao.Close()
        Return existe
    End Function

    Public Function getNumerosApartamentos()
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("select * from dbo.numeroApartamento()", Me.conexao)
        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao consultar os números dos apartamentos no banco de dados->Erro: " + ex.ToString)
        End Try
        Me.dataReader.Read()
        Return dataReader
    End Function
    '
    'Item
    '
    Public Function selecionaDadosEdicaoItem(id As Integer)
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("Select * from dbo.infoItem(@id)", Me.conexao)
        Me.comando.Parameters.Add(New SqlParameter("@id", id))
        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro na pesquisa das informações do item->Erro: " + ex.ToString)
        End Try
        Return Me.dataReader
    End Function

    Public Sub cadastrarItem(tipoItem As String, custoUnitario As Double, descricao As String)
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("exec dbo.adiciona_hItem  @tipoItem, @descricao, @custoUnitario", Me.conexao)
        Me.comando.Parameters.AddWithValue("@tipoItem", CStr(tipoItem))
        Me.comando.Parameters.AddWithValue("@descricao", CStr(descricao))
        Me.comando.Parameters.AddWithValue("@custoUnitario", CStr(custoUnitario))
        Try
            Me.comando.ExecuteNonQuery()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao efetuar a insercao do item->Erro: " + ex.ToString)
        End Try
        Me.conexao.Close()
    End Sub

    Public Sub removerItem(idItem As Integer)
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("exec dbo.removeItem @idItem", Me.conexao)
        Me.comando.Parameters.AddWithValue("@idItem", CStr(idItem))
        Try
            Me.comando.ExecuteNonQuery()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao efetuar a remoção do Item->Erro: " + ex.ToString)
        End Try
        Me.conexao.Close()
    End Sub

    Public Sub editarItem(idItem As Integer, tipoItem As String, custoUnitario As Double, descricao As String)
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("exec dbo.updateItem @idItem, @tipoItem, @descricao, @custoUnitario", Me.conexao)
        Me.comando.Parameters.AddWithValue("@idItem", CStr(idItem))
        Me.comando.Parameters.AddWithValue("@tipoItem", CStr(tipoItem))
        Me.comando.Parameters.AddWithValue("@descricao", CStr(descricao))
        Me.comando.Parameters.AddWithValue("@custoUnitario", CStr(custoUnitario))
        Try
            Me.comando.ExecuteNonQuery()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao efetuar a edição do item->Erro: " + ex.ToString)
        End Try
        Me.conexao.Close()
    End Sub

    Public Function getTiposItens()
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("select * from dbo.tipos()", Me.conexao)
        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao consultar os tipos dos itens no banco de dados->Erro: " + ex.ToString)
        End Try
        Me.dataReader.Read()
        Return dataReader
    End Function

    Public Function getIdItens()
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("select * from dbo.idItens()", Me.conexao)
        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao consultar os ids dos itens no banco de dados->Erro: " + ex.ToString)
        End Try
        Me.dataReader.Read()
        Return dataReader
    End Function
    '
    'TipoItem
    '
    Public Sub incluirTipoItem(descricao As String)
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("exec dbo.adicionaTipoItem @descricao", Me.conexao)
        Me.comando.Parameters.AddWithValue("@descricao", CStr(descricao))
        Try
            Me.comando.ExecuteNonQuery()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao efetuar a insercao do item->Erro: " + ex.ToString)
        End Try
        Me.conexao.Close()
    End Sub

    Public Sub editarTipoItem(idItem As Integer, descricao As String)
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("exec dbo.updateTipoItem @idItem, @descricao", Me.conexao)
        Me.comando.Parameters.AddWithValue("@idItem", CStr(idItem))
        Me.comando.Parameters.AddWithValue("@descricao", CStr(descricao))
        Try
            Me.comando.ExecuteNonQuery()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao efetuar a edição do item->Erro: " + ex.ToString)
        End Try
        Me.conexao.Close()
    End Sub

    Public Function getIdTipoItens()
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("select * from dbo.idTipoItens()", Me.conexao)
        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao consultar os ids dos itens no banco de dados->Erro: " + ex.ToString)
        End Try
        Me.dataReader.Read()
        Return dataReader
    End Function

    Public Function selecionaDadosTipoItem(id As Integer)
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("Select * from dbo.infoTipoItem(@id)", Me.conexao)
        Me.comando.Parameters.Add(New SqlParameter("@id", id))
        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro na pesquisa das informações do item->Erro: " + ex.ToString)
        End Try
        Return Me.dataReader
    End Function

    Public Sub removerTipoItem(idItem As Integer)
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("exec dbo.removeTipoItem @idItem", Me.conexao)
        Me.comando.Parameters.AddWithValue("@idItem", CStr(idItem))
        Try
            Me.comando.ExecuteNonQuery()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao efetuar a remoção do Item->Erro: " + ex.ToString)
        End Try
        Me.conexao.Close()
    End Sub
    '
    'Checkout
    '





    Public Sub checkout(cpf As String)
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("exec dbo.checkout @cpf", Me.conexao)
        Me.comando.Parameters.AddWithValue("@cpf", CStr(cpf))
        Try
            Me.comando.ExecuteNonQuery()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao efetuar o checkout->Erro: " + ex.ToString)
        End Try
        Me.conexao.Close()
    End Sub

    Public Function getDadosCheckout(cpf As String)
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("Select * from dbo.infoCheckout(@cpf)", Me.conexao)
        Me.comando.Parameters.Add(New SqlParameter("@cpf", cpf))
        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro na pesquisa das informações do Checkout->Erro: " + ex.ToString)
        End Try
        Return Me.dataReader
    End Function

    Public Function getItens(idHospedagem)
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("Select * from dbo.getItens(@idHospedagem)", Me.conexao)
        Me.comando.Parameters.Add(New SqlParameter("@idHospedagem", idHospedagem))
        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro na pesquisa das informações do Checkout->Erro: " + ex.ToString)
        End Try
        Return Me.dataReader
    End Function

    Public Function qtdItensConsumidos(idHospedagem As Integer)
        Dim qtd As Integer

        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("Select * from dbo.qtdItensConsumidos(@idHospedagem)", Me.conexao)
        Me.comando.Parameters.Add(New SqlParameter("@idHospedagem", idHospedagem))
        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro na pesquisa das informações do Checkout->Erro: " + ex.ToString)
        End Try
        dataReader.Read()
        qtd = dataReader.Item(0)
        Return qtd
    End Function
    '
    'Pergunta
    '
    Public Function getPerguntas()
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("Select * from dbo.getPerguntas()", Me.conexao)
        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro na pesquisa das informações do Checkout->Erro: " + ex.ToString)
        End Try
        Return Me.dataReader
    End Function

    Public Sub salvarResposta(idPergunta As String, resposta As String)
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("exec dbo.salvarResposta @idPergunta, @resposta", Me.conexao)
        Me.comando.Parameters.AddWithValue("@idPergunta", CStr(idPergunta))
        Me.comando.Parameters.AddWithValue("@resposta", CStr(resposta))
        Try
            Me.comando.ExecuteNonQuery()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao efetuar o update da resposta->Erro: " + ex.ToString)
        End Try
        Me.conexao.Close()
    End Sub
    '
    'Consumo
    '
    Public Function getDescricaoItens()
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("Select * from dbo.getDescricaoItens()", Me.conexao)
        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro na pesquisa das descrições dos itens->Erro: " + ex.ToString)
        End Try
        Return Me.dataReader
    End Function

    Public Sub inserirConsumo(item As Integer, idHospedagem As Integer, qtd As Integer, data As Date)
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("exec dbo.incluirItemConsumo @item, @idHospedagem, @qtd, @data", Me.conexao)
        Me.comando.Parameters.AddWithValue("@idHospedagem", CStr(idHospedagem))
        Me.comando.Parameters.AddWithValue("@item", CStr(item))
        Me.comando.Parameters.AddWithValue("@qtd", CStr(qtd))
        Me.comando.Parameters.AddWithValue("@data", CStr(data))
        Try
            Me.comando.ExecuteNonQuery()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao efetuar a inserção do consumo->Erro: " + ex.ToString)
        End Try
        Me.conexao.Close()
    End Sub

    Public Function getIdHospedagem(cpf As String)
        Dim id As Integer

        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("Select * from dbo.getIdHospedagem(@cpf)", Me.conexao)
        Me.comando.Parameters.Add(New SqlParameter("@cpf", cpf))
        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Return 0
        End Try
        dataReader.Read()
        id = dataReader.Item(0)
        Me.conexao.Close()
        Return id
    End Function

    Public Sub fecharConexao()
        Me.conexao.Close()
    End Sub

    Public Function disponibilidadeApartamento(idTipoApartamento As Integer, dataInicio As String, dataFim As String) As Boolean
        Dim disponivel As Boolean
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("select dbo.disponibilidadeApartamento(" + CStr(idTipoApartamento) + ",'" + dataInicio + "','" + dataFim + "')", Me.conexao)
        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao consultar Disponibilidade de apartamento no banco de dados->Erro: " + ex.ToString)
        End Try

        Me.dataReader.Read()
        disponivel = Me.dataReader.Item(0)
        Me.conexao.Close()
        Return disponivel
    End Function

    Public Sub atualizaReserva()
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("exec dbo.atualizaReserva_SP", Me.conexao)
        Try
            Me.comando.ExecuteNonQuery()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao efetuar a atualizacao das reservas" + ex.ToString)
        End Try
        Me.conexao.Close()
    End Sub

    Public Sub adicionaReserva(idTipoApartamento As Integer, idCliente As Integer, dataInicio As String, dataFim As String, numeroBoleto As Integer, dataPagamento As String, situacao As Integer)
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("exec dbo.adiciona_HReserva " + CStr(idTipoApartamento) + "," + CStr(idCliente) + ",'" + dataInicio + "','" + dataFim + "'," + CStr(numeroBoleto) + ",'" + dataPagamento + "'," + CStr(situacao), Me.conexao)
        Try
            Me.comando.ExecuteNonQuery()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao efetuar a insercao da reserva->Erro:" + ex.ToString)
        End Try
        Me.conexao.Close()

    End Sub
    Public Sub adicionaHospedagem(idApartamento As Integer, idReserva As Integer, origem As String, destino As String, tipoDoGrupo As Integer, motivoViagem As Integer, formaPagamento As Integer)
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("exec dbo.adiciona_hHospedagem " + CStr(idApartamento) + "," + CStr(idReserva) + ",'" + origem + "','" + destino + "'," + CStr(tipoDoGrupo) + "," + CStr(motivoViagem) + "," + CStr(formaPagamento), Me.conexao)

        Try
            Me.comando.ExecuteNonQuery()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao efetuar a insercao da Hospedagem ->Erro:" + ex.ToString)
        End Try
        Me.conexao.Close()
    End Sub

    Public Function gastoAtualHospedagem(idHospedagem As Integer) As Double

        Dim gasto As Double
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("select dbo.gastoAtual(" + CStr(idHospedagem) + ")", Me.conexao)
        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao consultar gasto da hospedagem no banco de dados->Erro: " + ex.ToString)
        End Try
        Me.dataReader.Read()
        gasto = Me.dataReader.Item(0)
        Me.conexao.Close()
        Return gasto
    End Function



    Public Function gastoDoCliente(idCliente As Integer) As Double
        Dim gasto As Double
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("select dbo.gastoCliente(" + CStr(idCliente) + ")", Me.conexao)
        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao consultar gasto do Cliente no banco de dados->Erro: " + ex.ToString)
        End Try
        Me.dataReader.Read()
        gasto = Me.dataReader.Item(0)
        Me.conexao.Close()
        Return gasto
    End Function

    Public Sub adicionaConsumo(idItem As Integer, idHospedagem As Integer, quantidade As Integer)
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("exec dbo.adiciona_hConsumo " + CStr(idItem) + "," + CStr(idHospedagem) + "," + CStr(quantidade), Me.conexao)
        Try
            Me.comando.ExecuteNonQuery()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao efetuar a insercao do Consumo ->Erro:" + ex.ToString)
        End Try
        Me.conexao.Close()
    End Sub


    Public Sub adicionaPergunta(pergunta As String, temAvaliacao As Boolean)
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("exec dbo.adiciona_hpergunta '" + pergunta + "'," + CStr(temAvaliacao), Me.conexao)
        Try
            Me.comando.ExecuteNonQuery()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao efetuar a insercao da Pergunta ->Erro:" + ex.ToString)
        End Try
        Me.conexao.Close()
    End Sub


    Public Sub adicionaResposta(idpergunta As Integer, idHospedagem As Integer, nota As Integer, comentario As String)
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("exec dbo.adiciona_hresposta " + CStr(idpergunta) + "," + CStr(idHospedagem) + "," + CStr(nota) + ",'" + comentario + "'", Me.conexao)
        Try
            Me.comando.ExecuteNonQuery()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao efetuar a insercao da Resposta ->Erro:" + ex.ToString)
        End Try
        Me.conexao.Close()
    End Sub
    Public Function mediaAvaliacoes() As Double
        Dim media As Double
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("select dbo.mediaAvaliacoes()", Me.conexao)
        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao consultar a media das avaliacoes do Cliente->Erro: " + ex.ToString)
        End Try
        Me.dataReader.Read()
        media = Me.dataReader.Item(0)
        Me.conexao.Close()
        Return media
    End Function

    Public Function arrecadacaoEntre(dataInicio As String, DataFim As String) As Double
        Dim arrecadacao As Double
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("select dbo.arrecadacaoEntre('" + dataInicio + "','" + DataFim + "')", Me.conexao)
        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao consultar a arrecadacao em determinado período no banco de dados->Erro: " + ex.ToString)
        End Try
        Me.dataReader.Read()
        arrecadacao = Me.dataReader.Item(0)
        Me.conexao.Close()
        Return arrecadacao
    End Function

    Public Function notaFiscal(idHospedagem As Integer) As String
        Dim nota As String
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("select dbo.ListaConsumo(" + CStr(idHospedagem) + ")", Me.conexao)
        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao gerar nota fiscal pelo  banco de dados->Erro: " + ex.ToString)
        End Try
        Me.dataReader.Read()
        nota = Me.dataReader.Item(0)
        Me.conexao.Close()
        Return nota
    End Function
    Public Sub fechaConta(idHospedagem As Integer)
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("exec dbo.fechaConta_sp " + CStr(idHospedagem), Me.conexao)
        Try
            Me.comando.ExecuteNonQuery()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao efetuar o fechamento da conta->Erro:" + ex.ToString)
        End Try
        Me.conexao.Close()
    End Sub

    Public Sub adicionaTempoHospedagem(idHospedagem As Integer, novaDataFim As String)
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("exec dbo.adicionaTempoHospedagem_sp " + CStr(idHospedagem) + ",'" + novaDataFim + "'", Me.conexao)
        Try
            Me.comando.ExecuteNonQuery()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao adicionar tempo a hospedagem->Erro:" + ex.ToString)
        End Try
        Me.conexao.Close()
    End Sub

    Public Function nivelPrivilegio(username As String) As Integer
        Dim privilegio As Integer
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("select dbo.nivelPrivilegio('" + username + "')", Me.conexao)
        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro ao consultar nivel de privilegio pelo  banco de dados->Erro: " + ex.ToString)
        End Try
        Me.dataReader.Read()
        privilegio = Me.dataReader.Item(0)
        Me.conexao.Close()
        Return privilegio
    End Function


    Public Function reservaClienteChekinDados(idCliente As Integer) As SqlDataReader
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("Select * from dbo.reservaClienteChekin(@idCliente)", Me.conexao)
        Me.comando.Parameters.Add(New SqlParameter("@idCliente", idCliente))
        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro na pesquisa das informações da reserva atual do cliente->Erro: " + ex.ToString)
        End Try
        Return Me.dataReader
    End Function


    Private Function Encrypt(clearText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, _
            &H65, &H64, &H76, &H65, &H64, &H65, _
            &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function

    Public Function reservaAtual(idCliente As Integer) As Boolean
        Dim atual As Boolean
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try

        Me.comando = New SqlCommand("select dbo.reservaAtualPraHospedagem(@idCliente)", Me.conexao)
        Me.comando.Parameters.Add(New SqlParameter("@idCliente", idCliente))

        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro na consulta da atualidade da reserva:Erro-> " + ex.ToString)
        End Try
        Me.dataReader.Read()
        atual = dataReader.Item(0)
        Me.conexao.Close()
        Return atual
    End Function



    Public Function tipoApartamentoExiste(tipo As String) As Boolean
        Dim existe As Boolean
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try

        Me.comando = New SqlCommand("select dbo.tipoApartamentoExiste(@tipo)", Me.conexao)
        Me.comando.Parameters.Add(New SqlParameter("@tipo", tipo))

        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro na consulta de existencia do tipo do apartamento->Erro: " + ex.ToString)
        End Try
        Me.dataReader.Read()
        existe = dataReader.Item(0)
        Me.conexao.Close()
        Return existe
    End Function

    Private Function Decrypt(cipherText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, _
            &H65, &H64, &H76, &H65, &H64, &H65, _
            &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(cipherBytes, 0, cipherBytes.Length)
                    cs.Close()
                End Using
                cipherText = Encoding.Unicode.GetString(ms.ToArray())
            End Using
        End Using
        Return cipherText
    End Function


    Public Sub carregaFotoUsuario(ByRef pb As PictureBox, username As String)
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand("select foto from hUsuario where username=@username", Me.conexao)
        Me.comando.Parameters.Add(New SqlParameter("@username", username))
        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro na consultar a foto do usuario->Erro: " + ex.ToString)
        End Try
        Me.dataReader.Read()
        Dim foto As Byte()
        foto = Me.dataReader.Item(0)
        Dim pictureBytes As New MemoryStream(foto)
        pb.Image = Image.FromStream(pictureBytes)
    End Sub

    Public Function emailExiste(email As String) As Boolean
        Dim existe As Boolean
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try

        Me.comando = New SqlCommand("Select dbo.emailExistente(@email)", Me.conexao)
        Me.comando.Parameters.Add(New SqlParameter("@email", email))

        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro na consulta do e-mail->Erro: " + ex.ToString)
        End Try
        Me.dataReader.Read()
        existe = dataReader.Item(0)
        Me.conexao.Close()
        Return existe
    End Function

    Public Function consultaGenerica(consulta As String) As SqlDataReader
        Try
            Me.conexao.Open()
        Catch ex As Exception
            Throw New System.Exception("Erro ao estabelecer conexao com o banco de dados->Erro: " + ex.ToString)
        End Try
        Me.comando = New SqlCommand(consulta, Me.conexao)
        Try
            Me.dataReader = comando.ExecuteReader()
        Catch ex As Exception
            Me.conexao.Close()
            Throw New System.Exception("Erro na pesquisa genérica ->Erro: " + ex.ToString)
        End Try
        ''Me.conexao.Close() // FECHAR DEPOIS DE USAR COM O MÉTODO FECHAR CONEXAO DA CLASSE BD
        Return Me.dataReader
    End Function
End Class





