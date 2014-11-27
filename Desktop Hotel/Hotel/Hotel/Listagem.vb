Imports System.Data.SqlClient

Public Class Listagem

    Dim dr As SqlDataReader
    Dim bd As BD
    Dim nRegistro As Integer

    Private Sub Listagem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DataGridView1.DataSource = Me.BindingSource1
        GetSetData("select idCliente,nome,dataNascimento,sexo,Email,Telefone,Celular," + _
                   "Endereco,Bairro,cidade,Pais,SiglaUF,CPF from hCliente")
        bd = New BD
    End Sub

    Private Sub GetSetData(ByVal selectCommand As String)
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

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
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
        Else
            MsgBox("Não há clientes")
        End If
        bd.fecharConexao()

    End Sub

    Private Sub Listagem_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        bd.fecharConexao()
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
            End If

        End If
        dr.Close()
        bd.fecharConexao()
    End Sub
End Class