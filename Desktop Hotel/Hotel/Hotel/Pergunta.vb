Imports System.Data.SqlClient

Public Class Pergunta
    Dim bd As New BD

    Dim cpf As String
    Dim pergunta As String
    Dim resposta As String

    Private Sub Pergunta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dr As SqlDataReader
        dr = bd.getPerguntas()

        While dr.Read
            cbxPergunta.Items.Add(dr(0) + " - " + dr(1))
        End While
    End Sub

    Private Sub btnSalvarResposta_Click(sender As Object, e As EventArgs) Handles btnSalvarResposta.Click
        resposta = txtResposta.Text
        If (resposta <> "") Then
            bd.salvarResposta(cpf, resposta)
            MsgBox("Resposta registrada com sucesso.")
        End If
    End Sub

    Private Sub cbxPergunta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPergunta.SelectedIndexChanged
        cpf = cbxPergunta.Text.Substring(0, 16)
        pergunta = cbxPergunta.Text.Substring(17)
        txtPergunta.Text = pergunta
        pnlPergunta.Visible = True
    End Sub
End Class