Public Class ListagemPergunta

    Private Sub ListagemPergunta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HosPDeirosDataSet10.hPergunta' table. You can move, or remove it, as needed.
        Me.HPerguntaTableAdapter.Fill(Me.HosPDeirosDataSet10.hPergunta)

    End Sub
End Class