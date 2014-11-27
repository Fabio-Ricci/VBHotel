Public Class ListagemTipoApartamento

    Private Sub ListagemTipoApartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HosPDeirosDataSet9.hTipoApartamento' table. You can move, or remove it, as needed.
        Me.HTipoApartamentoTableAdapter.Fill(Me.HosPDeirosDataSet9.hTipoApartamento)

    End Sub
End Class