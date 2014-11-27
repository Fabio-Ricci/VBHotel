Imports System.Data.SqlClient

Public Class Checkout
    Dim bd As New BD
    Dim indice As Integer = 0

    'Cliente
    Dim cpf As String
    Dim nome As String
    Dim email As String

    'Hospedagem
    Dim idHospedagem As Integer
    Dim consumoTotal As Double
    Dim valorDiaria As Double

    'Tipo Apartamento
    Dim idTipoApartamento As Integer
    Dim tipoQuarto As String
    Dim diariaTipoQuarto As Double

    'Apartamento
    Dim idApartamento As Integer
    Dim numero As Integer
    Dim andar As Integer
    Dim camasCasal As Integer
    Dim camasSolteiro As Integer
    Dim frigobar As Char

    'Item
    Dim qtdItens As Integer
    Dim itens As List(Of Item)
    Dim qtdItensConsumidos As Integer
    'Dim custoUnitarioItem As Double
    'Dim descricaoItem As String

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        cpf = txtCpf.Text
        cpf.Replace(",", ".")

        If (cpf <> "") Then
            Dim dr As SqlDataReader

            dr = bd.getDadosCheckout(cpf)
            If (dr.HasRows) Then
                dr.Read()

                nome = dr.Item(0)
                email = dr.Item(1)

                idTipoApartamento = dr.Item(2)
                diariaTipoQuarto = dr.Item(3)
                tipoQuarto = dr.Item(4)

                andar = dr.Item(5)
                numero = dr.Item(6)
                camasCasal = dr.Item(7)
                camasSolteiro = dr.Item(8)
                frigobar = dr.Item(9)

                idHospedagem = dr.Item(10)


                dr = Nothing
                ''''''''''''''''''''''''''''''''''''''''
                qtdItensConsumidos = bd.qtdItensConsumidos(idHospedagem) 'conta quantos itens diferentes aquele cliente consumidos
                '''''''''''''''''''''''''''''''''''''''
                Dim i As Integer = 0

                dr = bd.getItens(idHospedagem) 'retorna um data reader com todos os itens que tem essa idHospedagem (fazer)
                If dr.HasRows Then
                    While dr.HasRows
                        dr.Read()
                        itens.Add(New Item(dr.Item(0), dr.Item(1)))
                        i = i + 1
                    End While

                    btnAnt.Enabled = True
                    btnProx.Enabled = True
                    txtCustoUnitario.Text = itens(0).getPrecoUnitario()
                    txtDescricaoItem.Text = itens(0).getDescricao()
                    qtdItens = itens.Count
                Else
                    btnAnt.Enabled = False
                    btnProx.Enabled = False
                    lblItens.Text = "0/0"
                End If
                bd.fecharConexao()

                txtNome.Text = nome
                txtEmail.Text = email

                txtTipoQuarto.Text = tipoQuarto
                txtCustoUnitario.Text = diariaTipoQuarto

                txtNumero.Text = numero
                txtAndar.Text = andar
                txtCamasCasal.Text = camasCasal
                txtCamasSolteiro.Text = camasSolteiro
                If frigobar = "S" Then
                    rbSim.Checked = True
                Else
                    RbNao.Checked = True
                End If
            Else
                MsgBox("Esse cliente não está hospedado.")
            End If
        Else
            MsgBox("Digite o CPF.")
        End If
    End Sub

    Private Sub btnAnt_Click(sender As Object, e As EventArgs) Handles btnAnt.Click
        If (qtdItens > indice) Then
            indice += 1
            txtCustoUnitario.Text = itens(indice).getPrecoUnitario()
            txtDescricaoItem.Text = itens(indice).getDescricao()
            lblItens.Text = Convert.ToString(indice) + "/" + Convert.ToString(qtdItens)
            btnAnt.Enabled = True

            If (indice + 1 = qtdItens) Then
                btnProx.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnProx_Click(sender As Object, e As EventArgs) Handles btnProx.Click
        If (indice > 0) Then
            indice -= 1
            txtCustoUnitario.Text = itens(indice).getPrecoUnitario()
            txtDescricaoItem.Text = itens(indice).getDescricao()
            lblItens.Text = Convert.ToString(indice) + "/" + Convert.ToString(qtdItens)
            btnProx.Enabled = True

            If (indice = 0) Then
                btnAnt.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Dim escolha As MsgBoxResult = MsgBox("Deseja realmente realizar o checkout desse cliente?", "Checkout", MsgBoxStyle.YesNoCancel)

        If (escolha = MsgBoxResult.Yes) Then
            bd.checkout(cpf)
        End If
    End Sub
End Class