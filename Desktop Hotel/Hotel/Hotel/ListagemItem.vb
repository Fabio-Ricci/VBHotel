Public Class ListagemItem

    Private Sub ListagemItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load ' monta a listagem dos items
        Me.HItemTableAdapter.Fill(Me.HosPDeirosDataSet3.hItem)

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim idApartamento As Integer = DataGridView1.Item(0, Me.DataGridView1.CurrentRow.Index).Value
        CadastroItem.tcItem.SelectedIndex = 1
        CadastroItem.Show()
        CadastroItem.setTextCbEdicao(idApartamento.ToString)
    End Sub
End Class