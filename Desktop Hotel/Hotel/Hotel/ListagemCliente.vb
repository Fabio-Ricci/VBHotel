Imports System.Data.SqlClient

Public Class ListagemCliente

    Dim dr As SqlDataReader
    Dim bd As BD
    Dim nRegistro As Integer
    Dim mudou As Boolean

    Private Sub Listagem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DataGridView1.DataSource = Me.BindingSource1
        GetSetData("select idCliente,nome,dataNascimento,sexo,Email,Telefone,Celular," + _
                   "Endereco,Bairro,cidade,Pais,SiglaUF,CPF from hCliente")
        bd = New BD

        btnStart_Click(sender, e)
    End Sub

    Private Sub GetSetData(selectCommand As String)
        Try
            Dim con As New SqlConnection
            ' configura a conexao
            con.ConnectionString = "" & _
        "Data Source=regulus;Initial Catalog=hospdeiros;" & _
        "Persist Security Info=True;User ID=hospdeiros;Password=amostra"
            Dim dataAdapter = New SqlDataAdapter(selectCommand, con)

            Dim commandBuilder As New SqlCommandBuilder(dataAdapter)

            Dim table As New DataTable()

            dataAdapter.Fill(table)
            Me.BindingSource1.DataSource = table

            Me.DataGridView1.AutoResizeColumns( _
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader)
        Catch ex As SqlException
            MessageBox.Show("errrrrrrrou")
        End Try

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs)
        dr = bd.infoCliente()
        nRegistro = 0
        If dr.Read() Then
            txtNome.Text = dr.Item("nome")
            mtxtData.Text = dr.Item("dataNascimento")
            txtEmail.Text = dr.Item("Email")
            mtxtTelefone.Text = dr.Item("Telefone")
            mtxtCelular.Text = dr.Item("Celular")
            mtxtCPF.Text = dr.Item("CPF")
            txtEndereco.Text = dr.Item("Endereco")
            txtBairro.Text = dr.Item("Bairro")
            txtCidade.Text = dr.Item("cidade")
            cbPaises.Text = dr.Item("Pais")
            cbUF.Text = dr.Item("SiglaUF")
            If dr.Item("sexo") = "F" Then
                radFeminino.Checked = True
            Else
                radMasculino.Checked = True
            End If
        Else
            MsgBox("Não há clientes")
        End If
        bd.fecharConexao()

    End Sub

    Private Sub Listagem_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        Me.Close()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        dr = bd.infoCliente()
        nRegistro = nRegistro + 1
        Dim acabou As Boolean
        If dr.Read() Then
            acabou = False
            For I As Integer = 0 To nRegistro - 1
                If Not dr.Read() Then
                    acabou = True
                    nRegistro = nRegistro - 1
                End If
            Next

            If Not acabou Then
                txtNome.Text = dr.Item("nome")
                mtxtData.Text = dr.Item("dataNascimento")
                txtEmail.Text = dr.Item("Email")
                mtxtTelefone.Text = dr.Item("Telefone")
                mtxtCelular.Text = dr.Item("Celular")
                mtxtCPF.Text = dr.Item("CPF")
                txtEndereco.Text = dr.Item("Endereco")
                txtBairro.Text = dr.Item("Bairro")
                txtCidade.Text = dr.Item("cidade")
                cbPaises.Text = dr.Item("Pais")
                cbUF.Text = dr.Item("SiglaUF")
                If dr.Item("sexo") = "F" Then
                    radFeminino.Checked = True
                Else
                    radMasculino.Checked = True
                End If
            End If

        End If
        dr.Close()
        bd.fecharConexao()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        dr = bd.infoCliente()
        nRegistro = nRegistro - 1
        Dim acabou As Boolean
        If dr.Read() Then
            acabou = False
            For I As Integer = 0 To nRegistro - 1
                If Not dr.Read() Then
                    acabou = True
                End If
            Next
            If nRegistro = -1 Then
                nRegistro = 0
            End If

            If Not acabou Then
                txtNome.Text = dr.Item("nome")
                mtxtData.Text = dr.Item("dataNascimento")
                txtEmail.Text = dr.Item("Email")
                mtxtTelefone.Text = dr.Item("Telefone")
                mtxtCelular.Text = dr.Item("Celular")
                mtxtCPF.Text = dr.Item("CPF")
                txtEndereco.Text = dr.Item("Endereco")
                txtBairro.Text = dr.Item("Bairro")
                txtCidade.Text = dr.Item("cidade")
                cbPaises.Text = dr.Item("Pais")
                cbUF.Text = dr.Item("SiglaUF")
                If dr.Item("sexo") = "F" Then
                    radFeminino.Checked = True
                Else
                    radMasculino.Checked = True
                End If
            End If

        End If
        dr.Close()
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

        If mtxtTelefone.Text = "" Then
            isEmpty = True
        Else
            telefone = mtxtTelefone.Text
        End If

        If mtxtCelular.Text = "" Then
            isEmpty = True
        Else
            celular = mtxtCelular.Text
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
                    bd.updateCliente(nome, dataNascimento, sexo, eMail, telefone, celular, endereco, bairro, cidade, pais, uf, cpf)
                    MsgBox("O cliente foi alterado com sucesso")
                End If
            End If

        Catch Exc As System.Exception
            MsgBox(Exc.Message)
        End Try

    End Sub
End Class