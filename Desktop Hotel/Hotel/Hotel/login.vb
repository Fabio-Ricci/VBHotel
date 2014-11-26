Public Class login

    Public banco As New BD()
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim retan As Rectangle = Screen.PrimaryScreen.WorkingArea
        Me.Top = (retan.Height / 2) - (Me.Height / 2)
        Me.Left = (retan.Width / 2) - (Me.Width / 2)
    End Sub

    Private Sub BTNlogar_Click(sender As Object, e As EventArgs) Handles BTNlogar.Click
        If (EDusuario.Text.Trim() = "") Then
            MessageBox.Show("O campo do usuário não pode ficar em branco", "Atenção",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            EDusuario.Focus()
        Else
            If (EDsenha.Text.Trim() = "") Then
                MessageBox.Show("O campo da senha não pode ficar em branco", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                EDsenha.Focus()
            Else
                Try

                    If (banco.logar(EDusuario.Text, EDsenha.Text)) Then
                        Dim ca As New CadastroApartamentos()
                        ca.Show()

                        Dim checkout As New Checkout()
                        checkout.show()

                        Dim tipoItem As New CadastroTipoItem()
                        tipoItem.Show()

                        Dim item As New CadastroItem()
                        item.Show()

                        Dim listagem As New Listagem()
                        listagem.Show()

                        Dim cadastroCliente As New CadastroCliente()
                        cadastroCliente.Show()
                    Else
                        MessageBox.Show("Usuário inexistente, confira seu username e senha", "Atenção",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.ToString, "Erro No Banco de dados",
                   MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End If
        End If
    End Sub

    Private Sub login_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        EDusuario.Text = ""
        EDsenha.Text = ""
    End Sub
End Class