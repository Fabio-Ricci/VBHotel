Imports System.Data.SqlClient

Public Class Checkout
    Dim bd As New BD

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
    Dim descricaoTipoQuarto As String

    'Apartamento
    Dim idApartamento As Integer
    Dim numero As Integer
    Dim andar As Integer
    Dim camasCasal As Integer
    Dim camasSolteiro As Integer
    Dim frigobar As Char

    'Item
    Dim qtdItens As Integer
    Dim itens() As Item
    Dim qtdItensConsumidos As Integer
    'Dim custoUnitarioItem As Double
    'Dim descricaoItem As String

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        cpf = txtCPF.Text

        If (cpf <> "") Then
            Dim dr As SqlDataReader

            'dr = bd.getDadosCheckout(cpf)
            dr.read()

            nome = dr.Item(0)
            email = dr.Item(1)

            diariaTipoQuarto = dr.item(2)
            descricaoTipoQuarto = dr.item(3)

            tipoQuarto = dr.item(4)
            numero = dr.item(5)
            andar = dr.item(6)
            camasCasal = dr.item(7)
            camasSolteiro = dr.item(8)
            frigobar = dr.item(9)

            qtdItens = dr.Item(10)
            dr = Nothing
            ''''''''''''''''''''''''''''''''''''''''
            qtdItensConsumidos = bd.qtdItensConsumidos(idHospedagem) 'conta quantos itens diferentes aquele cliente consumidos
            '''''''''''''''''''''''''''''''''''''''
            Dim i As Integer = 0

            dr = bd.getItens(idHospedagem) 'retorna um data reader com todos os itens que tem esse idHospedagem
            While dr.hasRows
                dr.read()
                itens(i) = dr.item(0)
                i = i + 1
            End While

            txtNome.Text = nome
            txtEmail.Text = email

            txtConsumoTotal.Text = consumoTotal
            txtValorDiaria.Text = valorDiaria

            txtTipoQuarto.Text = tipoQuarto
            txtCustoUnitario.Text = diariaTipoQuarto
            txtDescricaoQuarto.Text = descricaoTipoQuarto

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
            MsgBox("Digite o CPF.")
        End If
    End Sub
End Class