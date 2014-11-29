Public Class ListagemTipoApartamento

    Private Sub ListagemTipoApartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HosPDeirosDataSet9.hTipoApartamento' table. You can move, or remove it, as needed.
        Me.HTipoApartamentoTableAdapter.Fill(Me.HosPDeirosDataSet9.hTipoApartamento)

    End Sub

    Private Sub dgListagemTipoApartamento_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListagemTipoApartamento.CellDoubleClick
        'abre o formulário de edição do tipo de apartamento ao clicar duas vezes em uma célula da listagem
        Dim tipoApartamento As String = dgListagemTipoApartamento.Item(3, Me.dgListagemTipoApartamento.CurrentRow.Index).Value
        tipoQuarto.tcTipoApto.SelectedIndex = 1
        tipoQuarto.Show()
        tipoQuarto.setSelectedTextCBEdicao(tipoApartamento)
    End Sub
End Class