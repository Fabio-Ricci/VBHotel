Imports System.Data.SqlClient

Public Class CadastroApartamentos
    Dim bd As New BD

    'tab 1 cadastramento
    Dim numero, andar, camaSolteiro, camaCasal As Integer
    Dim frigobar As Char

    'tab 2 edição
    Dim numeroSelecionado As Integer
    Dim edicaoCamaSolteiro, edicaoCamaCasal As Integer
    Dim edicaoFrigobar As Char
    Dim edicaoTipoApartamento As String
    Dim edicaoAndar As Integer
    Dim edicaoIdTipoApartamento As Integer

    'tab 3 remoção
    Dim remocaoNumeroSelecionado As Integer
    Dim remocaoCamaSolteiro, remocaoCamaCasal As Integer
    Dim remocaoFrigobar As Char
    Dim remocaoTipoApartamento As String
    Dim remocaoAndar As Integer

    'tab 1 cadastramento
    Private Sub CadastroApartamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HosPDeirosDataSet1.hApartamento' table. You can move, or remove it, as needed.
        Me.HApartamentoTableAdapter.Fill(Me.HosPDeirosDataSet1.hApartamento)
        'TODO: This line of code loads data into the 'HosPDeirosDataSet.hTipoApartamento' table. You can move, or remove it, as needed.
        Me.HTipoApartamentoTableAdapter.Fill(Me.HosPDeirosDataSet.hTipoApartamento)
        camaSolteiro = 0
        camaCasal = 0
        frigobar = ""
    End Sub

    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click
        numero = Convert.ToInt32(txtNumero.Text)
        andar = Convert.ToInt32(txtAndar.Text)
        camaCasal = Convert.ToInt32(txtCamaCasal.Text)
        camaSolteiro = Convert.ToInt32(txtCamaSolteiro.Text)

        Try
            If (IsNumeric(numero)) Then
                If (IsNumeric(andar)) Then
                    If (camaSolteiro <> 0 Or camaCasal <> 0) Then
                        If (frigobar <> "") Then
                            If (bd.numeroApartamentoExiste(numero)) Then
                                MsgBox("Número de apartamento já existente.")
                            Else
                                bd.adicionaApartamento(cbxTipoApartamento.SelectedValue, numero, andar, camaCasal, camaSolteiro, frigobar)
                                MsgBox("Apartamento incluído com sucesso.")
                                txtNumero.Text = ""
                                txtAndar.Text = ""
                                txtCamaCasal.Text = ""
                                txtCamaSolteiro.Text = ""
                                rbSim.Checked = False
                                rbNao.Checked = False

                                cbxEdicaoTipoApartamento.DataSource = Nothing

                                Dim dr As SqlDataReader
                                dr = bd.getNumerosApartamentos()
                                While dr.Read
                                    cbxEdicaoTipoApartamento.Refresh()
                                    cbxEdicaoTipoApartamento.Items.Add(dr("numero"))
                                End While
                                bd.fecharConexao()
                            End If
                        Else
                            MsgBox("Selecione uma opção para o frigobar.")
                        End If
                    Else
                        MsgBox("Escolha pelo menos um tipo de cama.")
                    End If
                Else
                    MsgBox("Informe o andar do apartamento.")
                End If
            Else
                MsgBox("Informe o número do apartamento.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        cbxTipoApartamento.Text = ""
    End Sub

    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress 'não permite letras
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtAndar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAndar.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub rbSim_CheckedChanged(sender As Object, e As EventArgs) Handles rbSim.CheckedChanged
        frigobar = "S"
    End Sub

    Private Sub rbNao_CheckedChanged(sender As Object, e As EventArgs) Handles rbNao.CheckedChanged
        frigobar = "N"
    End Sub

    Private Sub txtFatorCorrecaoPreco_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'tab 2 edição
    Private Sub cbTipoApartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEdicaoTipoApartamento.SelectedIndexChanged 'pega os dados do apartamento selecionado no combo box de edicao
        If (cbxEdicaoTipoApartamento.Text <> "") Then
            pnlEdicao.Visible = True
            txtEdicaoCamaSolteiro.Text = ""
            txtEdicaoCamaSolteiro.Text = ""
            rbEdicaoSim.Checked = False
            rbEdicaoNao.Checked = False
            numeroSelecionado = Convert.ToInt32(cbxEdicaoTipoApartamento.Text)

            Dim dr As SqlDataReader
            dr = bd.selecionaDadosEdicaoApartamento(numeroSelecionado)

            dr.Read()
            edicaoCamaCasal = Convert.ToInt32(dr.Item(0))
            edicaoCamaSolteiro = Convert.ToInt32(dr.Item(1))
            edicaoFrigobar = Convert.ToChar(dr.Item(2))
            edicaoTipoApartamento = Convert.ToString(dr.Item(3))
            edicaoAndar = Convert.ToInt32(dr.Item(4))
            bd.fecharConexao()

            If (edicaoFrigobar = "S") Then
                rbEdicaoSim.Checked = True
            Else
                rbEdicaoNao.Checked = True
            End If

            txtEdicaoAndar.Text = Convert.ToString(edicaoAndar)
            txtEdicaoCamaCasal.Text = edicaoCamaCasal
            txtEdicaoCamaSolteiro.Text = edicaoCamaSolteiro
            cbEdicaoTipoApartamento.SelectedIndex = cbEdicaoTipoApartamento.FindStringExact(edicaoTipoApartamento)
            dr = Nothing
        End If
    End Sub

    Private Sub txtEdicaoCorrecao_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub rbEdicaoSim_CheckedChanged(sender As Object, e As EventArgs) Handles rbEdicaoSim.CheckedChanged
        edicaoFrigobar = "S"
    End Sub

    Private Sub rbEdicaoNao_CheckedChanged(sender As Object, e As EventArgs) Handles rbEdicaoNao.CheckedChanged
        edicaoFrigobar = "N"
    End Sub

    Private Sub btnEdicaoSalvar_Click(sender As Object, e As EventArgs) Handles btnEdicaoSalvar.Click
        edicaoCamaCasal = Convert.ToInt32(txtEdicaoCamaCasal.Text)
        edicaoCamaSolteiro = Convert.ToInt32(txtEdicaoCamaSolteiro.Text)
        edicaoTipoApartamento = Convert.ToString(cbEdicaoTipoApartamento.Text)
        edicaoAndar = Convert.ToInt32(txtEdicaoAndar.Text)

        If (rbEdicaoSim.Checked) Then
            edicaoFrigobar = "S"
        Else
            edicaoFrigobar = "N"
        End If

        If (numeroSelecionado <> 0) Then
            If (edicaoCamaSolteiro <> 0 Or edicaoCamaCasal <> 0) Then
                If (edicaoFrigobar <> "") Then
                    If (edicaoTipoApartamento <> "") Then
                        edicaoIdTipoApartamento = bd.getIdTipoApartamento(edicaoTipoApartamento)

                        bd.updateApartamento(numeroSelecionado, edicaoIdTipoApartamento, edicaoAndar, edicaoCamaCasal, edicaoCamaSolteiro, edicaoFrigobar)

                        MsgBox("Apartamento atualizado com sucesso.")

                        Dim dr As SqlDataReader
                        dr = bd.selecionaDadosEdicaoApartamento(numeroSelecionado) 'preenche os dados do apartamento editado

                        dr.Read()
                        edicaoCamaCasal = Convert.ToInt32(dr.Item(0))
                        edicaoCamaSolteiro = Convert.ToInt32(dr.Item(1))
                        edicaoFrigobar = Convert.ToChar(dr.Item(2))
                        edicaoTipoApartamento = Convert.ToString(dr.Item(3))
                        edicaoAndar = Convert.ToInt32(dr.Item(4))
                        bd.fecharConexao()

                        If (edicaoFrigobar = "S") Then
                            rbEdicaoSim.Checked = True
                        Else
                            rbEdicaoNao.Checked = True
                        End If

                        txtEdicaoAndar.Text = Convert.ToString(edicaoAndar)
                        txtEdicaoCamaCasal.Text = edicaoCamaCasal
                        txtEdicaoCamaSolteiro.Text = edicaoCamaSolteiro
                        cbEdicaoTipoApartamento.SelectedIndex = cbEdicaoTipoApartamento.FindStringExact(edicaoTipoApartamento)
                    Else
                        MsgBox("Selecione um tipo de apartamento.")
                    End If
                Else
                    MsgBox("Selecione uma opção para o frigobar.")
                End If
            Else
                MsgBox("Escolha pelo menos um tipo de cama.")
            End If
        Else
            MsgBox("Slecione um número de apartamento.")
        End If

        cbxEdicaoTipoApartamento.Text = ""
    End Sub

    Private Sub tcApartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcApartamento.SelectedIndexChanged 'verifica em qual tab está e preenche os combo box ta tab
        If (tcApartamento.SelectedIndex = 2) Then
            txtRemocaoTipoApartamento.Text = ""
            txtRemocaoAndar.Text = ""
            txtRemocaoCamaCasal.Text = ""
            txtremocaoCamaSolteiro.Text = ""
            rbRemocaoSim.Checked = False
            rbRemocaoNao.Checked = False

            Dim dr As SqlDataReader
            dr = bd.getNumerosApartamentos()
            If dr.HasRows Then
                cbxRemocaoApartamento.DataSource = Nothing
                cbxRemocaoApartamento.Items.Clear()
                cbxRemocaoApartamento.Items.Add(dr("numero"))

                While dr.Read
                    cbxRemocaoApartamento.Items.Add(dr("numero"))
                End While
                bd.fecharConexao()
            End If
        End If

        If (tcApartamento.SelectedIndex = 1) Then
            txtEdicaoCamaCasal.Text = ""
            txtEdicaoCamaSolteiro.Text = ""
            rbEdicaoSim.Checked = False
            rbEdicaoNao.Checked = False
            pnlEdicao.Visible = False

            Dim dr As SqlDataReader
            dr = bd.getNumerosApartamentos()
            If dr.HasRows Then
                cbxEdicaoTipoApartamento.DataSource = Nothing
                cbxEdicaoTipoApartamento.Items.Clear()
                cbxEdicaoTipoApartamento.Items.Add(dr("numero"))

                While dr.Read
                    cbxEdicaoTipoApartamento.Items.Add(dr("numero"))
                End While
                bd.fecharConexao()
            End If
        End If

        If (tcApartamento.SelectedIndex = 0) Then
            txtNumero.Text = ""
            txtAndar.Text = ""
            txtCamaCasal.Text = ""
            txtCamaSolteiro.Text = ""
            rbSim.Checked = False
            rbNao.Checked = False
        End If
    End Sub

    Private Sub txtCamaCasal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCamaCasal.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtCamaSolteiro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCamaSolteiro.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtEdicaoCamaCasal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEdicaoCamaCasal.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtEdicaoCamaSolteiro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEdicaoCamaSolteiro.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CadastroApartamentos_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        cbxTipoApartamento.Text = ""
    End Sub

    Private Sub btnRemoverApartamento_Click(sender As Object, e As EventArgs) Handles btnRemoverApartamento.Click 'remove o apartamento e limpa os campos
        bd.removerApartamento(remocaoNumeroSelecionado)
        MsgBox("Apartamento removido com sucesso.")
        cbxRemocaoApartamento.SelectedIndex = -1
        txtRemocaoAndar.Text = ""
        txtRemocaoCamaCasal.Text = ""
        txtremocaoCamaSolteiro.Text = ""
        txtRemocaoTipoApartamento.Text = ""
        rbRemocaoNao.Checked = False
        rbRemocaoSim.Checked = False

        pnlRemocao.Visible = False

        remocaoAndar = 0
        remocaoCamaCasal = 0
        remocaoCamaSolteiro = 0
        remocaoTipoApartamento = 0
        frigobar = ""
        remocaoNumeroSelecionado = 0
    End Sub

    Private Sub cbxRemocaoApartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxRemocaoApartamento.SelectedIndexChanged 'preenche os dados do item selecionado do combo box, mostrando o item a ser deletedo
        If (cbxRemocaoApartamento.Text <> "") Then
            pnlRemocao.Visible = True
            remocaoNumeroSelecionado = Convert.ToInt32(cbxRemocaoApartamento.Text)

            Dim dr As SqlDataReader
            dr = bd.selecionaDadosEdicaoApartamento(remocaoNumeroSelecionado)

            dr.Read()
            remocaoCamaCasal = Convert.ToInt32(dr.Item(0))
            remocaoCamaSolteiro = Convert.ToInt32(dr.Item(1))
            remocaoFrigobar = Convert.ToChar(dr.Item(2))
            remocaoTipoApartamento = Convert.ToString(dr.Item(3))
            remocaoAndar = Convert.ToInt32(dr.Item(4))
            bd.fecharConexao()

            If (remocaoFrigobar = "S") Then
                rbRemocaoSim.Checked = True
            Else
                rbRemocaoNao.Checked = True
            End If

            txtRemocaoAndar.Text = Convert.ToString(remocaoAndar)
            txtRemocaoCamaCasal.Text = remocaoCamaCasal
            txtremocaoCamaSolteiro.Text = remocaoCamaSolteiro
            txtRemocaoTipoApartamento.Text = remocaoTipoApartamento
        End If
    End Sub
End Class