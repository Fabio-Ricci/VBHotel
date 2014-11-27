Public Class ListagemItem

    Private Sub ListagemItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HosPDeirosDataSet3.hItem' table. You can move, or remove it, as needed.
        Me.HItemTableAdapter.Fill(Me.HosPDeirosDataSet3.hItem)

    End Sub
End Class