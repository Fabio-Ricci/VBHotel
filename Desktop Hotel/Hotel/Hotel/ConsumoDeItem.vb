Imports System.Data.SqlClient

Public Class ConsumoDeItem
    Dim bd As New BD

    Dim cpf As String
    Dim item As String
    Dim qtd As Integer
    Dim data As Date
    Dim idHospedagem As Integer

    Private Sub ConsumoDeItem_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim dr As SqlDataReader
        dr = bd.getDescricaoItens()

        While dr.Read()
            If (dr(0) <= 9) Then
                item = "00" + Convert.ToString(dr(0))
            End If

            If (dr(0) >= 100) Then
                item = Convert.ToString(dr(0))
            Else
                item = "0" + Convert.ToString(dr(0))
            End If
            cbxItem.Items.Add(item + " - " + dr(1))

            item = ""
        End While
        bd.fecharConexao()

        data = DateTime.Now.Date

        txtDia.Text = Convert.ToString(data.Day)
        txtMes.Text = Convert.ToString(data.Month)
        txtAno.Text = Convert.ToString(data.Year)
    End Sub

    Private Sub txtQtd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQtd.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        cpf = txtCpf.Text
        cpf = cpf.Replace(",", ".")

        idHospedagem = bd.getIdHospedagem(cpf)

        item = cbxItem.Text.Substring(0, 3)
        qtd = Convert.ToInt32(txtQtd.Text)

        If (idHospedagem <> 0) Then
            If (item <> "") Then
                If (qtd <> 0) Then
                    bd.inserirConsumo(Convert.ToInt32(item), idHospedagem, qtd, data)
                    MsgBox("Consumo cadastrado com sucesso.")
                End If
            Else
                MsgBox("Escolha o item consumido.")
            End If
        Else
            MsgBox("Digite o CPF de um cliente já hospedado.")
        End If
    End Sub
End Class