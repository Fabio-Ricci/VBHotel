Imports System.Data.SqlClient

Public Class Listagem

    Dim dr As SqlDataReader
    Dim bd As BD

    Private Sub Listagem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DataGridView1.DataSource = Me.BindingSource1
        GetSetData("select idCliente,nome,dataNascimento,sexo,Email,Telefone,Celular," + _
                   "Endereco,Bairro,cidade,Pais,SiglaUF,CPF from hCliente")

    End Sub

    Private Sub GetSetData(ByVal selectCommand As String)
        '    ' variáveis do SQL
        '    Dim con As New SqlConnection
        '    Dim myCommand As New SqlCommand
        '    Dim dr As SqlDataReader
        '    ' configura a conexao
        '    con.ConnectionString = "" & _
        '"Data Source=regulus;Initial Catalog=hospdeiros;" & _
        '"Persist Security Info=True;User ID=hospdeiros;Password=amostra"

        '    Try
        '        con.Open()

        '        myCommand = New SqlCommand("", con)

        '        dr = myCommand.ExecuteReader()
        '        If dr.Read() Then

        '            'existe
        '        Else
        '            'não existe
        '            MsgBox("Não existe nenhum dado sobre clientes")
        '        End If

        '        con.Close()
        '    Catch ex As Exception
        '        MsgBox(ex.ToString)
        '    End Try


        '---------------------------------------- ----'
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
        Try
            dr = bd.infoCliente()
            If dr.Read() Then

            Else
                dr.Close()
                MsgBox("Não há clientes")
            End If
            bd.fecharConexao()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Listagem_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        Me.Close()
    End Sub
End Class