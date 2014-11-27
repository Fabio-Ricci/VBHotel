Imports Microsoft.Win32
Imports System.Globalization

Public Class CadastroCliente
    Dim bd As BD

    Private Function validarEmail(ByVal email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex("^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match = emailRegex.Match(email)
        Return emailMatch.Success
    End Function

    Private Function validarCampos() As Boolean
        Dim bool As Boolean
        bool = True
        If (txtNome.Text.Equals("")) Then
            txtNome.BackColor = Color.FromArgb(255, 200, 200)
            bool = False
        Else
            txtNome.BackColor = Color.FromArgb(255, 255, 255)
        End If

        If mtxtData.Text = "  /  /" Then
            mtxtData.BackColor = Color.FromArgb(255, 200, 200)
            bool = False
        Else
            mtxtData.BackColor = Color.FromArgb(255, 255, 255)
        End If

        If mtxtCPF.Text = "   .   .   -" Then
            mtxtCPF.BackColor = Color.FromArgb(255, 200, 200)
            bool = False
        Else
            mtxtCPF.BackColor = Color.FromArgb(255, 255, 255)
        End If
        Return bool
    End Function

    Private Sub btnCadastro_Click(sender As Object, e As EventArgs) Handles btnCadastro.Click
        If validarCampos() Then
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
                    Dim data As DateTime
                    data = CDate(mtxtData.Text)
                    If DateDiff(DateInterval.Year, data, Date.Now) < 18 Then
                        MsgBox("O cliente precisa ter mais de 18 anos para se cadastrar.")
                    ElseIf DateDiff(DateInterval.Year, data, Date.Now) < 0 Then
                        MsgBox("Data inválida")
                    Else
                        bd.adicionaCliente(nome, dataNascimento, sexo, eMail, telefone, celular, endereco, bairro, cidade, pais, uf, senha, cartaoNumero, cartaoCodigo, cartaoNome, cartaoDataValidade, cpf)
                        MsgBox("O cliente foi cadastrado com sucesso")
                    End If
                End If

            Catch Exc As System.Exception
                MsgBox(Exc.Message)
            End Try
        Else
            MsgBox("dados incorretos")
        End If
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
    End Sub

    Private Sub cbUF_DropDown(sender As Object, e As EventArgs) Handles cbUF.DropDown
        If cbPaises.SelectedItem = "BRA" Then
            cbUF.Items.Add("AC")
            cbUF.Items.Add("AL")
            cbUF.Items.Add("AP")
            cbUF.Items.Add("AM")
            cbUF.Items.Add("BA")
            cbUF.Items.Add("CE")
            cbUF.Items.Add("DF")
            cbUF.Items.Add("ES")
            cbUF.Items.Add("GO")
            cbUF.Items.Add("MA")
            cbUF.Items.Add("MT")
            cbUF.Items.Add("MS")
            cbUF.Items.Add("MG")
            cbUF.Items.Add("PA")
            cbUF.Items.Add("PB")
            cbUF.Items.Add("PR")
            cbUF.Items.Add("PE")
            cbUF.Items.Add("PI")
            cbUF.Items.Add("RJ")
            cbUF.Items.Add("RN")
            cbUF.Items.Add("RS")
            cbUF.Items.Add("RO")
            cbUF.Items.Add("RR")
            cbUF.Items.Add("SC")
            cbUF.Items.Add("SP")
            cbUF.Items.Add("SE")
            cbUF.Items.Add("TO")
        Else
            cbUF.DropDownHeight = 106
            cbUF.DropDownWidth = 51
            cbUF.Items.Clear()
        End If
    End Sub

End Class