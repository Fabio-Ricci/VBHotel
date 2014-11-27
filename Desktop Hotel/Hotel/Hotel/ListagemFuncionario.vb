Imports System.Data.SqlClient

Public Class ListagemFuncionario


    Private Sub Listagem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DataGridView1.DataSource = Me.BindingSource1
        GetSetData("select username,niveldePrivilegio from hUsuario")
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

End Class