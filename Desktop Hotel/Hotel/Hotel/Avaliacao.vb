Public Class Avaliacao
    Dim bd As BD

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim qtdeRespostas As Integer
        Dim mediaAtendimento As Double
        Dim mediaQuarto As Double
        Dim mediaRegiao As Double
        Dim mediaRestaurantes As Double
        qtdeRespostas = bd.getQtasRespostas()
        lblQtdeRespostas.Text = qtdeRespostas
        mediaAtendimento = bd.getSomaNotaAtendimento / qtdeRespostas
        mediaQuarto = bd.getSomaNotaQuarto / qtdeRespostas
        mediaRegiao = bd.getSomaNotaRegiao / qtdeRespostas
        mediaRestaurantes = bd.getSomaNotaRestaurantes / qtdeRespostas

        txtAtendimento.BackColor = qualCor(mediaAtendimento)
        txtQuarto.BackColor = qualCor(mediaQuarto)
        txtRegiao.BackColor = qualCor(mediaRegiao)
        txtRestaurantes.BackColor = qualCor(mediaRestaurantes)

        txtAtendimento.Text = Convert.ToString(mediaAtendimento)
        txtQuarto.Text = Convert.ToString(mediaQuarto)
        txtRegiao.Text = Convert.ToString(mediaRegiao)
        txtRestaurantes.Text = Convert.ToString(mediaRestaurantes)

        bd.fecharConexao()
    End Sub

    Private Sub Avaliacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bd = New BD
    End Sub

    Private Sub txtAtendimento_TextChanged(sender As Object, e As EventArgs) Handles txtRestaurantes.TextChanged, txtRegiao.TextChanged, txtQuarto.TextChanged, txtAtendimento.TextChanged

    End Sub

    Private Function qualCor(numero As Double) As Color
        If numero > 4 Or numero < 0 Then
            Return Color.Black
        End If
        numero = numero + 1.0
        If numero <= 5.0 And numero > 4.75 Then
            Return Color.FromArgb(34, 177, 76)
        ElseIf numero <= 4.75 And numero > 4.5 Then
            Return Color.FromArgb(54, 177, 33)
        ElseIf numero <= 4.5 And numero > 4.25 Then
            Return Color.FromArgb(130, 186, 24)
        ElseIf numero <= 4.25 And numero > 4.0 Then
            Return Color.FromArgb(154, 193, 17)
        ElseIf numero <= 4.0 And numero > 3.75 Then
            Return Color.FromArgb(187, 197, 14)
        ElseIf numero <= 3.75 And numero > 3.5 Then
            Return Color.FromArgb(204, 199, 6)
        ElseIf numero <= 3.5 And numero > 3.25 Then
            Return Color.FromArgb(214, 219, 4)
        ElseIf numero <= 3.25 And numero > 3.0 Then
            Return Color.FromArgb(234, 240, 4)
        ElseIf numero <= 3.0 And numero > 2.75 Then
            Return Color.FromArgb(255, 217, 0)
        ElseIf numero <= 2.75 And numero > 2.5 Then
            Return Color.FromArgb(255, 205, 0)
        ElseIf numero <= 2.5 And numero > 2.25 Then
            Return Color.FromArgb(255, 190, 0)
        ElseIf numero <= 2.25 And numero > 2.0 Then
            Return Color.FromArgb(255, 180, 0)
        ElseIf numero <= 2.0 And numero > 1.75 Then
            Return Color.FromArgb(255, 160, 0)
        ElseIf numero <= 1.75 And numero > 1.5 Then
            Return Color.FromArgb(255, 140, 0)
        ElseIf numero <= 1.5 And numero > 1.25 Then
            Return Color.FromArgb(255, 120, 0)
        ElseIf numero <= 1.0 And numero > 0.75 Then
            Return Color.FromArgb(255, 0, 0)
        End If
    End Function

End Class