Public Class Avaliacao

    Dim bd As New BD

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim total = bd.qtasRespostas()
        Dim mediaAtendimento As Double = bd.somaRespostaAtendimento() / total
        Dim mediaQuarto As Double = bd.somaRespostaQuarto() / total
        Dim mediaRegiao As Double = bd.somaRespostaRegiao() / total
        Dim mediaRestaurantes As Double = bd.somaRespostaRestaurantes() / total

        lblAtendimento.Text = mediaAtendimento
        lblQuarto.Text = mediaQuarto
        lblRegiao.Text = mediaRegiao
        lblRestaurantes.Text = mediaRestaurantes
        lblTotal.Text = total

        lblAtendimento.BackColor = qualCor(mediaAtendimento)
        lblQuarto.BackColor = qualCor(mediaQuarto)
        lblRegiao.BackColor = qualCor(mediaRegiao)
        lblRestaurantes.BackColor = qualCor(mediaRestaurantes)

        pnAtendimento.BackColor = qualCor(mediaAtendimento)
        pnQuarto.BackColor = qualCor(mediaQuarto)
        pnRegiao.BackColor = qualCor(mediaRegiao)
        pnRestaurantes.BackColor = qualCor(mediaRestaurantes)

        Label1.BackColor = qualCor(mediaAtendimento)
        Label2.BackColor = qualCor(mediaQuarto)
        Label3.BackColor = qualCor(mediaRegiao)
        Label4.BackColor = qualCor(mediaRestaurantes)

    End Sub

    Private Function qualCor(media As Double) As Color
        If media > 4 Or media < 0 Then
            Return Color.Black
        ElseIf media <= 4 And media > 3.75 Then
            Return Color.FromArgb(34, 177, 76)
        ElseIf media <= 3.75 And media > 3.5 Then
            Return Color.FromArgb(20, 190, 24)
        ElseIf media <= 3.5 And media > 3.25 Then
            Return Color.FromArgb(73, 196, 15)
        ElseIf media <= 3.25 And media > 3.0 Then
            Return Color.FromArgb(158, 201, 10)
        ElseIf media <= 3.0 And media > 2.75 Then
            Return Color.FromArgb(179, 203, 7)
        ElseIf media <= 2.75 And media > 2.5 Then
            Return Color.FromArgb(209, 199, 1)
        ElseIf media <= 2.5 And media > 2.25 Then
            Return Color.FromArgb(226, 232, 0)
        ElseIf media <= 2.25 And media > 2.0 Then
            Return Color.FromArgb(255, 242, 0)
        ElseIf media <= 2.0 And media > 1.75 Then
            Return Color.FromArgb(255, 223, 0)
        ElseIf media <= 1.75 And media > 1.5 Then
            Return Color.FromArgb(255, 204, 0)
        ElseIf media <= 1.5 And media > 1.25 Then
            Return Color.FromArgb(255, 172, 0)
        ElseIf media <= 1.25 And media > 1.0 Then
            Return Color.FromArgb(255, 147, 0)
        ElseIf media <= 1.0 And media > 0.75 Then
            Return Color.FromArgb(255, 134, 0)
        ElseIf media <= 0.75 And media > 0.5 Then
            Return Color.FromArgb(255, 96, 0)
        ElseIf media <= 0.5 And media > 0.25 Then
            Return Color.FromArgb(255, 50, 0)
        ElseIf media <= 0.25 And media >= 0.0 Then
            Return Color.FromArgb(255, 0, 0)
        End If
    End Function

    Private Sub Avaliacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnLoad_Click(sender, e)
    End Sub
End Class