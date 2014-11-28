Public Class ListagemApartamento

    Private Sub ListagemApartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HosPDeirosDataSet2.hApartamento' table. You can move, or remove it, as needed.
        Me.HApartamentoTableAdapter.Fill(Me.HosPDeirosDataSet2.hApartamento)

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim idApartamento As Integer = DataGridView1.Item(2, Me.DataGridView1.CurrentRow.Index).Value
        CadastroApartamentos.tcApartamento.SelectedIndex = 1
        CadastroApartamentos.Show()
        CadastroApartamentos.setSelectedTextCBEdicao(idApartamento)

    End Sub
End Class