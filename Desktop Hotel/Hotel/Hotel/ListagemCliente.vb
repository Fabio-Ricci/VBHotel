Imports System.Data.SqlClient

Public Class ListagemCliente

    Private Sub ListagemCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HosPDeirosDataSet7.hCliente' table. You can move, or remove it, as needed.
        Me.HClienteTableAdapter1.Fill(Me.HosPDeirosDataSet7.hCliente)
        'TODO: This line of code loads data into the 'HosPDeirosDataSet6.hCliente' table. You can move, or remove it, as needed.
        Me.HClienteTableAdapter.Fill(Me.HosPDeirosDataSet6.hCliente)

    End Sub

    Private Sub dgListagemCliente_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListagemCliente.CellDoubleClick
        'abre o formulário de edição do cliente ao clicar duas vezes em uma célula da listagem
        Dim idCliente As Integer = dgListagemCliente.Item(0, Me.dgListagemCliente.CurrentRow.Index).Value
        CadastroCliente.tbcCadastro.SelectedIndex = 1
        CadastroCliente.Show()
        CadastroCliente.setSelectedTextCBEdicao(idCliente.ToString)
    End Sub
End Class