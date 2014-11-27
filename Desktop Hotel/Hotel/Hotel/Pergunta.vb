Imports System.Data.SqlClient

Public Class Pergunta
    Dim bd As New BD

    Dim cpf As String
    Dim pergunta As String
    Dim resposta As String

    Private Sub btnSalvarResposta_Click(sender As Object, e As EventArgs) Handles btnSalvarResposta.Click
        resposta = txtResposta.Text
        If (resposta <> "") Then
            bd.salvarResposta(cpf, resposta)
            cbxPergunta.Items.Remove(cpf + " - " + pergunta)
            txtPergunta.Text = ""
            txtResposta.Text = ""
            pnlPergunta.Visible = False

            cpf = ""
            pergunta = ""
            resposta = ""
            MsgBox("Resposta registrada com sucesso.")
        End If
    End Sub

    Private Sub cbxPergunta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPergunta.SelectedIndexChanged
        cpf = cbxPergunta.Text.Substring(0, 14)
        cpf.Replace(",", ".")
        pergunta = cbxPergunta.Text.Substring(17)
        txtPergunta.Text = pergunta
        pnlPergunta.Visible = True
    End Sub

    Private Sub Pergunta_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim dr As SqlDataReader
        dr = bd.getPerguntas()

        cbxPergunta.Items.Clear()
        While dr.Read
            cbxPergunta.Items.Add(dr(0) + " - " + dr(1))
        End While
        bd.fecharConexao()
    End Sub
End Class