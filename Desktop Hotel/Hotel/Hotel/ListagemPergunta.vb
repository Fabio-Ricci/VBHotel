Public Class ListagemPergunta

    Private Sub ListagemPergunta_Load(sender As Object, e As EventArgs) Handles MyBase.Load ' carrega a listagem de pergunta
        Me.HPerguntaTableAdapter.Fill(Me.HosPDeirosDataSet10.hPergunta)

    End Sub
End Class