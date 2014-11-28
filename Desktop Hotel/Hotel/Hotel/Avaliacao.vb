Public Class Avaliacao

    Dim bd As New BD

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim total = bd.qtasRespostas()

        lblAtendimento.Text = bd.somaRespostaAtendimento() / total
        lblQuarto.Text = bd.somaRespostaQuarto() / total
        lblRegiao.Text = bd.somaRespostaRegiao() / total
        lblRestaurantes.Text = bd.somaRespostaRestaurantes() / total
        lblTotal.Text = total
    End Sub

    Private Sub Avaliacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnLoad_Click(sender, e)
    End Sub
End Class