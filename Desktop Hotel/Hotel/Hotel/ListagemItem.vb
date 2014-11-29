Public Class ListagemItem

    Private Sub ListagemItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load ' monta a listagem dos items
        Me.HItemTableAdapter.Fill(Me.HosPDeirosDataSet3.hItem)

    End Sub

    Private Sub dgListagemItem_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListagemItem.CellDoubleClick
        Dim idItem As Integer = dgListagemItem.Item(0, Me.dgListagemItem.CurrentRow.Index).Value
        CadastroItem.tcItem.SelectedIndex = 1
        CadastroItem.Show()
        CadastroItem.setTextCbEdicao(idItem.ToString)
    End Sub
End Class