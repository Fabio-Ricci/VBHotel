Imports System.Data.SqlClient

Public Class Checkout
    Dim bd As New BD

    'Cliente
    Dim cpf As String
    Dim nome As String
    Dim email As String

    'Hospedagem
    Dim consumoTotal As Double
    Dim valorDiaria As Double

    'Tipo Apartamento
    Dim idTipoApartamento As Integer
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
    Dim itens As Item()
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
            'custoUnitarioItem = dr.item(11)
            'descricaoItem = dr.item(12)
        Else
            MsgBox("Digite o CPF.")
        End If
    End Sub
End Class