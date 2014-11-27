Public Class ListagemApartamento

    Private Sub ListagemApartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HosPDeirosDataSet2.hApartamento' table. You can move, or remove it, as needed.
        Me.HApartamentoTableAdapter.Fill(Me.HosPDeirosDataSet2.hApartamento)

    End Sub
End Class