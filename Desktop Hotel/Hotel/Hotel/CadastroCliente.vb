Imports Microsoft.Win32
Imports System.Globalization
Imports System.Data.SqlClient

Public Class CadastroCliente
    Dim bd As BD
    Dim edicaoIdCliente As Integer
    Dim remocaoIdCliente As Integer

    Private Function validarEmail(ByVal email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex("^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match = emailRegex.Match(email)
        Return emailMatch.Success
    End Function

    Private Sub btnCadastro_Click(sender As Object, e As EventArgs) Handles btnCadastro.Click
            Dim sexo As Char
            If radFeminino.Checked Then
                sexo = "F"
            Else
                sexo = "M"
            End If
            Dim nome As String
            Dim dataNascimento As String
            Dim eMail As String
            Dim telefone As String
            Dim celular As String
            Dim senha As String
            Dim cpf As String
            Dim endereco As String
            Dim bairro As String
            Dim cidade As String
            Dim pais As String
            Dim uf As String
            Dim cartaoNumero As String
            Dim cartaoCodigo As String
            Dim cartaoNome As String
            Dim cartaoDataValidade As String

            Dim isEmpty As Boolean = False
            If txtNome.Text = "" Then
                isEmpty = True
            Else
                nome = txtNome.Text
            End If

            If mtxtData.Text = "  /  /" Then
                isEmpty = True
            Else
                dataNascimento = mtxtData.Text
            End If

            If txtEmail.Text = "" Then
                isEmpty = True
            Else
                eMail = txtEmail.Text
            End If

            If mtxtTelefone.Text = "(  )     -" Then
                isEmpty = True
            Else
                telefone = mtxtTelefone.Text
            End If

            If mtxtCelular.Text = "(  )      -" Then
                isEmpty = True
            Else
                celular = mtxtCelular.Text
            End If
            If txtSenha.Text = "" Then
                isEmpty = True
            Else
                senha = txtSenha.Text
            End If

            If mtxtCPF.Text = "   .   .   -" Then
                isEmpty = True
            Else
                cpf = mtxtCPF.Text
            End If

            If txtEndereco.Text = "" Then
                isEmpty = True
            Else
                endereco = txtEndereco.Text
            End If

            If txtBairro.Text = "" Then
                isEmpty = True
            Else
                bairro = txtBairro.Text
            End If

            If txtCidade.Text = "" Then
                isEmpty = True
            Else
                cidade = txtCidade.Text
            End If

            If cbPaises.Text = "" Then
                isEmpty = True
            Else
                pais = cbPaises.Text
            End If

            If cbUF.Text = "" Then
                isEmpty = True
            Else
                uf = cbUF.Text
            End If

            If mtxtNumeroCartao.Text = "               " Then
                isEmpty = True
            Else
                cartaoNumero = mtxtNumeroCartao.Text
            End If

            If mtxtCodigoCartao.Text = "" Then
                isEmpty = True
            Else
                cartaoCodigo = mtxtCodigoCartao.Text
            End If

            If txtNomeCartao.Text = "" Then
                isEmpty = True
            Else
                cartaoNome = txtNomeCartao.Text
            End If

            If mtxtDataCartao.Text = "  /" Then
                isEmpty = True
            Else
                cartaoDataValidade = mtxtDataCartao.Text
            End If
        Try
            If (isEmpty) Then
                MsgBox("Preencha todos os campos")
            Else
                If Not bd.ehUF(cbUF.Text) Then
                    MsgBox("Apenas UF brasileiros. Use dois hífens (--) para pessoas não brasileiras")
                Else
                    Dim data As DateTime
                    data = CDate(mtxtData.Text)
                    If DateDiff(DateInterval.Year, data, Date.Now) < 18 Then
                        MsgBox("O cliente precisa ter mais de 18 anos para se cadastrar.")
                    ElseIf DateDiff(DateInterval.Year, data, Date.Now) < 0 Then
                        MsgBox("Data inválida")
                    Else
                        bd.adicionaCliente(nome, dataNascimento, sexo, eMail, telefone, celular, endereco, bairro, cidade, pais, uf, senha, cartaoNumero, cartaoCodigo, cartaoNome, cartaoDataValidade, cpf)
                        MsgBox("O cliente foi cadastrado com sucesso")
                        btnLoad_Click(sender, e)

                    End If
                End If
            End If
        Catch Exc As System.Exception
            MsgBox(Exc.Message)
        End Try

        'nome As String, cpf As String, dataNascimento As Date, sexo As Char, email As String, telefone As String, celular As String, endereco As String,
        'bairro As String, cidade As String, pais As String, siglaUF As String, senha As String, numeroCartaoCredito As String, codigoSeguranca As String, nomeTitular As String, dataValidade As Date)
    End Sub

    Public Shared Function GetCountryList() As List(Of String)
        Dim cultureList As New List(Of String)
        Dim cultures() As CultureInfo = CultureInfo.GetCultures(CultureTypes.AllCultures)

        For Each culture As CultureInfo In cultures
            Try
                Dim region As RegionInfo = New RegionInfo(culture.LCID)
                If Not cultureList.Contains(region.ThreeLetterWindowsRegionName) Then
                    cultureList.Add(region.ThreeLetterWindowsRegionName)
                End If
            Catch ex As Exception

            End Try
        Next
        Return cultureList
    End Function

    Private Sub carregarPaises(ByVal lbx As ComboBox)
        For Each country As String In GetCountryList()
            cbPaises.Items.Add(country)
        Next
    End Sub

    Private Sub CadastroCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bd = New BD()
        carregarPaises(cbPaises)

        btnLoad_Click(sender, e)
        Dim dr As SqlDataReader
        dr = bd.getUFs()
        If dr.Read Then
            cbUF.Items.Clear()
            'cbUF.Items.Add(dr.Item(0))

            While dr.Read
                cbUF.Items.Add(dr.Item(0))
            End While
        End If
        bd.fecharConexao()
    End Sub

    Private Sub cbUF_DropDown(sender As Object, e As EventArgs) Handles cbUF.DropDown
        If cbPaises.SelectedItem = "BRA" Then
            Dim dr As SqlDataReader
            dr = bd.getUFs()
            If dr.Read Then
                cbUF.Items.Clear()
                'cbUF.Items.Add(dr.Item(0))

                While dr.Read
                    cbUF.Items.Add(dr.Item(0))
                End While
            End If
            bd.fecharConexao()
        Else
            cbUF.DropDownHeight = 106
            cbUF.DropDownWidth = 51
            cbUF.Items.Clear()
            cbUF.Items.Add("--")
        End If
    End Sub

    Private Sub cbxEdicaoIdCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEdicaoIdCliente.SelectedIndexChanged
        edicaoIdCliente = cbxEdicaoIdCliente.Text

        Dim dr As SqlDataReader

        dr = bd.infoCliente(edicaoIdCliente)

        dr.Read()
        txtEdicaoNome.Text = Convert.ToString(dr.Item(1))
        txtEdicaoCPF.Text = Convert.ToString(dr.Item(2))
        txtEdicaoData.Text = Convert.ToString(dr.Item(3))
        If Convert.ToString(dr.Item(4)) = "F" Then
            rbFeminino.Checked = True
            rbMasculino.Checked = False
        Else
            rbMasculino.Checked = True
            rbFeminino.Checked = False
        End If
        txtEdicaoEmail.Text = Convert.ToString(dr.Item(5))
        txtEdicaoTelefone.Text = Convert.ToString(dr.Item(6))
        txtEdicaoCelular.Text = Convert.ToString(dr.Item(7))
        txtEdicaoEndereco.Text = Convert.ToString(dr.Item(8))
        txtEdicaoBairro.Text = Convert.ToString(dr.Item(9))
        txtEdicaoCidade.Text = Convert.ToString(dr.Item(10))
        txtEdicaoPais.Text = Convert.ToString(dr.Item(11))
        cbEdicaoUF.Text = Convert.ToString(dr.Item(12))

        bd.fecharConexao()

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs)
        Dim dr As SqlDataReader
        dr = bd.idsCliente()
        If dr.Read Then
            cbxEdicaoIdCliente.Items.Clear()
            cbxEdicaoIdCliente.Items.Add(dr.Item(0))

            While dr.Read
                cbxEdicaoIdCliente.Items.Add(dr.Item(0))
            End While
        End If
        bd.fecharConexao()
        Dim dr2 As SqlDataReader
        dr2 = bd.idsCliente()
        If dr2.Read Then
            cbxRemocaoIdCliente.Items.Clear()
            cbxRemocaoIdCliente.Items.Add(dr2.Item(0))

            While dr2.Read
                cbxRemocaoIdCliente.Items.Add(dr2.Item(0))
            End While
        End If
        bd.fecharConexao()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim sexo As Char
        If radFeminino.Checked Then
            sexo = "F"
        Else
            sexo = "M"
        End If
        Dim nome As String
        Dim dataNascimento As String
        Dim eMail As String
        Dim telefone As String
        Dim celular As String
        Dim cpf As String
        Dim endereco As String
        Dim bairro As String
        Dim cidade As String
        Dim pais As String
        Dim uf As String

        Dim isEmpty As Boolean = False
        If txtEdicaoNome.Text = "" Then
            isEmpty = True
        Else
            nome = txtEdicaoNome.Text
        End If

        If txtEdicaoData.Text = "  /  /" Then
            isEmpty = True
        Else
            dataNascimento = txtEdicaoData.Text
        End If

        If txtEdicaoEmail.Text = "" Then
            isEmpty = True
        Else
            eMail = txtEdicaoEmail.Text
        End If

        If txtEdicaoTelefone.Text = "(  )     -" Then
            isEmpty = True
        Else
            telefone = txtEdicaoTelefone.Text
        End If

        If txtEdicaoCelular.Text = "(  )      -" Then
            isEmpty = True
        Else
            celular = txtEdicaoCelular.Text
        End If

        If txtEdicaoCPF.Text = "   .   .   -" Then
            isEmpty = True
        Else
            cpf = txtEdicaoCPF.Text
        End If

        If txtEdicaoEndereco.Text = "" Then
            isEmpty = True
        Else
            endereco = txtEdicaoEndereco.Text
        End If

        If txtEdicaoBairro.Text = "" Then
            isEmpty = True
        Else
            bairro = txtEdicaoBairro.Text
        End If

        If txtEdicaoCidade.Text = "" Then
            isEmpty = True
        Else
            cidade = txtEdicaoCidade.Text
        End If

        If txtEdicaoPais.Text = "" Then
            isEmpty = True
        Else
            pais = txtEdicaoPais.Text
        End If

        If cbEdicaoUF.Text = "" Then
            isEmpty = True
        Else
            uf = cbEdicaoUF.Text
        End If
        Try
            If (isEmpty) Then
                MsgBox("Preencha todos os campos")
            Else
                If Not bd.ehUF(cbEdicaoUF.Text) Then
                    MsgBox("Apenas UF brasileiros. Use dois hífens (--) para pessoas não brasileiras")
                Else
                    bd.fecharConexao()
                    Dim data As DateTime
                    data = CDate(txtEdicaoData.Text)
                    If DateDiff(DateInterval.Year, data, Date.Now) < 18 Then
                        MsgBox("O cliente precisa ter mais de 18 anos para se cadastrar.")
                    ElseIf DateDiff(DateInterval.Year, data, Date.Now) < 0 Then
                        MsgBox("Data inválida")
                    Else
                        bd.updateCliente(cbxEdicaoIdCliente.Text, nome, dataNascimento, sexo, eMail, telefone, celular, endereco, bairro, cidade, pais, uf, cpf)
                        MsgBox("O cliente foi alterado com sucesso")
                        bd.fecharConexao()
                    End If
                End If

            End If
        Catch Exc As System.Exception
            MsgBox(Exc.Message)
        End Try
    End Sub

    Private Sub cbxRemocaoIdCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxRemocaoIdCliente.SelectedIndexChanged
        remocaoIdCliente = cbxRemocaoIdCliente.Text

        Dim dr As SqlDataReader

        dr = bd.infoCliente(remocaoIdCliente)

        dr.Read()
        txtRemocaoNome.Text = Convert.ToString(dr.Item(1))
        txtRemocaoCPF.Text = Convert.ToString(dr.Item(2))
        txtRemocaoData.Text = Convert.ToString(dr.Item(3))
        If Convert.ToString(dr.Item(4)) = "F" Then
            rbFeminino.Checked = True
            rbMasculino.Checked = False
        Else
            rbMasculino.Checked = True
            rbFeminino.Checked = False
        End If
        txtRemocaoEmail.Text = Convert.ToString(dr.Item(5))
        txtRemocaoTelefone.Text = Convert.ToString(dr.Item(6))
        txtRemocaoCelular.Text = Convert.ToString(dr.Item(7))
        txtRemocaoEndereco.Text = Convert.ToString(dr.Item(8))
        txtRemocaoBairro.Text = Convert.ToString(dr.Item(9))
        txtRemocaoCidade.Text = Convert.ToString(dr.Item(10))
        txtRemocaoPais.Text = Convert.ToString(dr.Item(11))
        txtRemocaoUF.Text = Convert.ToString(dr.Item(12))

        bd.fecharConexao()

    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        Try
            bd.deleteCliente(cbxEdicaoIdCliente.Text)
            MsgBox("O cliente foi removido com sucesso")
            btnLoad_Click(sender, e)
        Catch Exc As System.Exception
            MsgBox(Exc.Message)
        End Try
    End Sub

    Public Sub setSelectedTextCBEdicao(text As String)
        cbxEdicaoIdCliente.Text = text
    End Sub

    Private Sub TabPage2_Enter(sender As Object, e As EventArgs) Handles TabPage2.Enter
        Dim dr As SqlDataReader
        dr = bd.getUFs()
        If dr.Read Then
            cbEdicaoUF.Items.Clear()
            While dr.Read
                cbEdicaoUF.Items.Add(dr.Item(0))
            End While
        End If
        bd.fecharConexao()
    End Sub
End Class