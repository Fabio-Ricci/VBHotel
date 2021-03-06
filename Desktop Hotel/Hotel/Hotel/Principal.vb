﻿Imports System.Windows.Forms

Public Class Principal
    Public Sub setnome(nome As String)
        PBfuncionario.SizeMode = PictureBoxSizeMode.StretchImage
        Me.LBLfuncionario.Text = nome
        Me.LBLfuncionario.BackColor = Color.Transparent
        Dim banco As New BD()
        banco.carregaFotoUsuario(PBfuncionario, nome)
    End Sub
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

    Private Sub menuCheckout_Click(sender As Object, e As EventArgs)
        Checkout.Show()
    End Sub

    Private Sub menuFuncionariosCadastro_Click(sender As Object, e As EventArgs) Handles menuFuncionariosCadastro.Click
        CadastroUsuario.Show()
    End Sub

    Private Sub menuFuncionariosListagem_Click(sender As Object, e As EventArgs) Handles menuFuncionariosListagem.Click
        ListagemFuncionario.Show()
    End Sub

    Private Sub menuItensConsumoItens_Click(sender As Object, e As EventArgs) Handles menuItensConsumoItens.Click
        ConsumoDeItem.Show()
    End Sub

    Private Sub ListagemDeApartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListagemDeApartamentosToolStripMenuItem.Click
        ListagemApartamento.Show()
    End Sub

    Private Sub ListagemDeItensToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListagemDeItensToolStripMenuItem.Click
        ListagemItem.Show()
    End Sub

    Private Sub ListagemDeTipoDeItensToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListagemDeTipoDeItensToolStripMenuItem.Click
        ListagemTipoItem.Show()
    End Sub

    Private Sub ListagemDeConsumoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListagemDeConsumoToolStripMenuItem.Click
        ListagemConsumo.Show()
    End Sub

    Private Sub ListagemDeTiposDeApartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListagemDeTiposDeApartamentosToolStripMenuItem.Click
        ListagemTipoApartamento.Show()
    End Sub

    Private Sub ListagemPerguntasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListagemPerguntasToolStripMenuItem.Click
        Pergunta.Show()
    End Sub

    Private Sub ListagemDePerguntasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListagemDePerguntasToolStripMenuItem.Click
        ListagemPergunta.Show()
    End Sub

    Private Sub menuAvaliacao_Click(sender As Object, e As EventArgs) Handles menuAvaliacao.Click
        Avaliacao.Show()
    End Sub

    Private Sub menuHospedagemEditar_Click(sender As Object, e As EventArgs) Handles menuHospedagemEditar.Click
        EditarHospedagem.Show()
    End Sub

    Private Sub menuHospedagemCheckIn_Click(sender As Object, e As EventArgs) Handles menuHospedagemCheckIn.Click
        hospedagemCheckIn.Show()
    End Sub

    Private Sub menuHospedagemCheckOut_Click(sender As Object, e As EventArgs) Handles menuHospedagemCheckOut.Click
        Checkout.Show()
    End Sub

    Private Sub menuHospedagemEditarReserva_Click(sender As Object, e As EventArgs) Handles menuHospedagemEditarReserva.Click
        EditarReserva.Show()
    End Sub

    Private Sub Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'fecha todos os demais formulários quando fecha o principal
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
        ListagemApartamento.Close()
        ListagemCliente.Close()
        ListagemFuncionario.Close()
        ListagemItem.Close()
        ListagemTipoItem.Close()
        ListagemConsumo.Close()
        ListagemTipoApartamento.Close()
        ListagemPergunta.Close()
        login.Close()
        Avaliacao.Close()
    End Sub

End Class