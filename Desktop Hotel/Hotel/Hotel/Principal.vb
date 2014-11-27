Imports System.Windows.Forms

Public Class Principal

    Private Sub menuApartamentosCadastro_Click(sender As Object, e As EventArgs) Handles menuApartamentosCadastro.Click
        CadastroApartamentos.Show()
    End Sub

    Private Sub menuApartamentosTipo_Click(sender As Object, e As EventArgs) Handles menuApartamentosTipo.Click
        tipoQuarto.Show()
    End Sub

    Private Sub menuClientesCadastro_Click(sender As Object, e As EventArgs) Handles menuClientesCadastro.Click
        CadastroCliente.Show()
    End Sub

    Private Sub menuClientesListagem_Click(sender As Object, e As EventArgs) Handles menuClientesListagem.Click
        ListagemCliente.Show()
    End Sub

    Private Sub menuItensCadastro_Click(sender As Object, e As EventArgs) Handles menuItensCadastro.Click
        CadastroItem.Show()
    End Sub

    Private Sub menuItensCadastroTipo_Click(sender As Object, e As EventArgs) Handles menuItensCadastroTipo.Click
        CadastroTipoItem.Show()
    End Sub

    Private Sub menuPergunta_Click(sender As Object, e As EventArgs) Handles menuPergunta.Click
        Pergunta.Show()
    End Sub

    Private Sub menuCheckout_Click(sender As Object, e As EventArgs) Handles menuCheckout.Click
        Checkout.Show()
    End Sub

    Private Sub menuFuncionariosCadastro_Click(sender As Object, e As EventArgs) Handles menuFuncionariosCadastro.Click
        CadastroUsuario.Show()
    End Sub

    Private Sub menuFuncionariosListagem_Click(sender As Object, e As EventArgs) Handles menuFuncionariosListagem.Click

    End Sub

    Private Sub menuItensConsumoItens_Click(sender As Object, e As EventArgs) Handles menuItensConsumoItens.Click
        ConsumoDeItem.Show()
    End Sub

    Private Sub Principal_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        CadastroApartamentos.Close()
        tipoQuarto.Close()
        CadastroCliente.Close()
        ListagemCliente.Close()
        CadastroItem.Close()
        CadastroTipoItem.Close()
        Pergunta.Close()
        Checkout.Close()
        CadastroUsuario.Close()
        ConsumoDeItem.Close()
        Me.Close()
    End Sub


    Private Sub Principal_FormClosing(sender As Object, e As FormClosingEventArgs) 'Handles Principal.FormClosing
        CadastroApartamentos.Close()
        tipoQuarto.Close()
        CadastroCliente.Close()
        ListagemCliente.Close()
        CadastroItem.Close()
        CadastroTipoItem.Close()
        Pergunta.Close()
        Checkout.Close()
        CadastroUsuario.Close()
        ConsumoDeItem.Close()
        Me.Close()
    End Sub

End Class