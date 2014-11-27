Public Class ListagemConsumo

    Private Sub ListagemConsumo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HosPDeirosDataSet5.hConsumo' table. You can move, or remove it, as needed.
        Me.HConsumoTableAdapter.Fill(Me.HosPDeirosDataSet5.hConsumo)

    End Sub
End Class