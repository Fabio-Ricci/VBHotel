Public Class ListagemTipoItem

    Private Sub ListagemTipoItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HosPDeirosDataSet4.HTIPOITEM' table. You can move, or remove it, as needed.
        Me.HTIPOITEMTableAdapter.Fill(Me.HosPDeirosDataSet4.HTIPOITEM)

    End Sub

    Private Sub dgListagemTipoItem_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListagemTipoItem.CellDoubleClick
        'abre o formulário de edição do tipo de item ao clicar duas vezes em uma célula da listagem
        Dim idTipoItem As Integer = dgListagemTipoItem.Item(1, Me.dgListagemTipoItem.CurrentRow.Index).Value
        CadastroTipoItem.tcTipoItem.SelectedIndex = 1
        CadastroTipoItem.Show()
        CadastroTipoItem.setSelectedTextCBEdicao(idTipoItem.ToString)
    End Sub
End Class