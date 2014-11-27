Public Class Principal

    Private Sub menuApartamentosCadastro_Click(sender As Object, e As EventArgs) Handles menuApartamentosCadastro.Click
        Dim CadastroApartamentos As New CadastroApartamentos
        CadastroApartamentos.Show()
    End Sub

    Private Sub menuApartamentosTipo_Click(sender As Object, e As EventArgs) Handles menuApartamentosTipo.Click
        Dim tipoApartamentos As New tipoQuarto
        tipoApartamentos.Show()
    End Sub

    Private Sub menuClientesCadastro_Click(sender As Object, e As EventArgs) Handles menuClientesCadastro.Click
        Dim cadastroCliente As New CadastroCliente
        cadastroCliente.Show()
    End Sub

    Private Sub menuClientesListagem_Click(sender As Object, e As EventArgs) Handles menuClientesListagem.Click
        Dim listagemCliente As New ListagemCliente
        listagemCliente.Show()
    End Sub

    Private Sub menuItensCadastro_Click(sender As Object, e As EventArgs) Handles menuItensCadastro.Click
        Dim cadastroItem As New CadastroItem
        cadastroItem.Show()
    End Sub

    Private Sub menuItensCadastroTipo_Click(sender As Object, e As EventArgs) Handles menuItensCadastroTipo.Click
        Dim cadastroTipoItem As New CadastroTipoItem
        cadastroTipoItem.Show()
    End Sub

    Private Sub menuPergunta_Click(sender As Object, e As EventArgs) Handles menuPergunta.Click
        Dim pergunta As New Pergunta
        pergunta.Show()
    End Sub

    Private Sub menuCheckout_Click(sender As Object, e As EventArgs) Handles menuCheckout.Click
        Dim Checkout As New Checkout
        Checkout.Show()
    End Sub

    Private Sub menuFuncionariosCadastro_Click(sender As Object, e As EventArgs) Handles menuFuncionariosCadastro.Click
        Dim cadastroFuncionario As New CadastroUsuario
        cadastroFuncionario.Show()
    End Sub

    Private Sub menuFuncionariosListagem_Click(sender As Object, e As EventArgs) Handles menuFuncionariosListagem.Click

    End Sub

    Private Sub menuItensConsumoItens_Click(sender As Object, e As EventArgs) Handles menuItensConsumoItens.Click
        Dim ConsumoDeItem As New ConsumoDeItem
        ConsumoDeItem.Show()
    End Sub
End Class