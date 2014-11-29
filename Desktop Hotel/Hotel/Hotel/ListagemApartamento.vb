Public Class ListagemApartamento

    Private Sub ListagemApartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HosPDeirosDataSet2.hApartamento' table. You can move, or remove it, as needed.
        Me.HApartamentoTableAdapter.Fill(Me.HosPDeirosDataSet2.hApartamento)

    End Sub

    Private Sub dgListagemApartamento_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListagemApartamento.CellDoubleClick
        'abre o formulário de edição do apartamento ao clicar duas vezes em uma célula da listagem
        Dim numApartamento As Integer = dgListagemApartamento.Item(2, Me.dgListagemApartamento.CurrentRow.Index).Value
        CadastroApartamentos.tcApartamento.SelectedIndex = 1
        CadastroApartamentos.Show()
        CadastroApartamentos.setSelectedTextCBEdicao(numApartamento)
    End Sub
End Class