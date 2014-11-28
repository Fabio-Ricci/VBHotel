Public Class ListagemItem

    Private Sub ListagemItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load ' monta a listagem dos items
        Me.HItemTableAdapter.Fill(Me.HosPDeirosDataSet3.hItem)

    End Sub
End Class