Public Class login

    Public banco As New BD()

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

                    If (banco.logar(EDusuario.Text, EDsenha.Text)) Then 'se há o login no banco de dados
                        'Se necessário, colocar as atualizações de reserva aqui

                        'nivel de privilégio 1 - funcionários no geral: abre o Principal sem o item Funcionários do menu 
                        If banco.nivelPrivilegio(EDusuario.Text) = 1 Then
                            Dim Principal As New Principal
                            Principal.menuFuncionarios.Visible = False
                            Principal.Show()
                        Else
                            'nivel de privilégio 2 - gerente: abre o Principal com o item Funcionários do menu 
                            Dim Principal As New Principal
                            Principal.Show()

                        End If
                        Principal.setnome(EDusuario.Text)
                        Me.Hide()

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
        'limpa os campos
        EDusuario.Text = ""
        EDsenha.Text = ""
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class