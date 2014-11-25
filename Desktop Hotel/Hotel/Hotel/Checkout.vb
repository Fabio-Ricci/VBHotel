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
    Dim diariaTipoQuarto As Double
    Dim descricaoTipoQuarto As String

    'Apartamento
    Dim tipoQuarto As String
    Dim numero As Integer
    Dim andar As Integer
    Dim camasCasal As Integer
    Dim camasSolteiro As Integer
    Dim frigobar As Char

    'Item
    Dim custoUnitarioItem As Double
    Dim descricaoItem As String

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        cpf = txtCPF.Text

        If (cpf <> "") Then
            Dim dr As SqlDataReader

            'dr = bd.getDadosCheckout(cpf)

            nome = dr.Item(0)
            email = dr.Item(1)



        Else
            MsgBox("Digite o CPF.")
        End If
    End Sub
End Class