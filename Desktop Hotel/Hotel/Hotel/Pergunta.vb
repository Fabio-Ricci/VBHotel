Imports System.Data.SqlClient

Public Class Pergunta
    Dim bd As New BD

    Dim idPergunta As Integer
    Dim pergunta As String
    Dim resposta As String
    Dim nome As String

    Private Sub btnSalvarResposta_Click(sender As Object, e As EventArgs) Handles btnSalvarResposta.Click ' salva a resposta para uma pergunta de um cliente
        resposta = txtResposta.Text
        If (resposta <> "") Then
            bd.salvarResposta(idPergunta, resposta)
            cbxPergunta.Items.Remove(Convert.ToString(idPergunta) + ") " + nome + " - " + pergunta)
            txtPergunta.Text = ""
            txtResposta.Text = ""
            pnlPergunta.Visible = False

            nome = ""
            pergunta = ""
            resposta = ""
            MsgBox("Resposta registrada com sucesso.")
        End If
    End Sub

    Private Sub cbxPergunta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPergunta.SelectedIndexChanged ' atualiza as variáveis na mudança do combo box
        idPergunta = Convert.ToInt32(cbxPergunta.Text.Substring(0, cbxPergunta.Text.IndexOf(")")))
        pergunta = cbxPergunta.Text.Substring(cbxPergunta.Text.IndexOf("-") + 2)
        nome = cbxPergunta.Text.Substring(cbxPergunta.Text.IndexOf(")") + 2, (cbxPergunta.Text.IndexOf("-") - 4))
        txtPergunta.Text = pergunta
        pnlPergunta.Visible = True
    End Sub

    Private Sub Pergunta_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown ' mostra a pergunta de um cliente
        Dim dr As SqlDataReader
        dr = bd.getPerguntas()

        cbxPergunta.Items.Clear()
        While dr.Read
            cbxPergunta.Items.Add(Convert.ToString(dr(0)) + ") " + Convert.ToString(dr(2)) + " - " + Convert.ToString(dr(1)))
        End While
        bd.fecharConexao()
    End Sub
End Class