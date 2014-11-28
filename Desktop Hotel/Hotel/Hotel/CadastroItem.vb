Imports System.Data.SqlClient

Public Class CadastroItem
    Dim bd As New BD

    'Cadastro de Item
    Dim tipoItem As String
    Dim custoUnitario As Double
    Dim descricao As String

    'Edição de Item
    Dim edicaoTipoItem As String
    Dim edicaoCustoUnitario As Double
    Dim edicaoDescricao As String
    Dim edicaoIdItem As Integer

    'Remoção de Item
    Dim remocaoTipoItem As String
    Dim remocaoCustoUnitario As Double
    Dim remocaoDescricao As String
    Dim remocaoIdItem As Integer

    Private Sub tcItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcItem.SelectedIndexChanged
        If tcItem.SelectedIndex = 0 Then
            cbxTipoItem.Text = ""
            txtCustoUnitario.Text = ""
            txtDescricao.Text = ""

            pnlEdicaoItem.Visible = False
            pnlRemocaoItem.Visible = False

            Dim dr As SqlDataReader
            dr = bd.getTiposItens()
            If dr.HasRows Then
                cbxTipoItem.Items.Clear()
                cbxTipoItem.Items.Add(dr(0))

                While dr.Read
                    cbxTipoItem.Items.Add(dr(0))
                End While
            End If
            bd.fecharConexao()
            dr = Nothing
        End If

        If tcItem.SelectedIndex = 1 Then
            cbxEdicaoIdItem.Text = ""
            cbxEdicaoTipoItem.Text = ""
            txtEdicaoCustoUnitario.Text = ""
            txtEdicaoDescricao.Text = ""

            pnlRemocaoItem.Visible = False

            Dim dr As SqlDataReader
            dr = bd.getIdItens()
            If dr.HasRows Then
                cbxEdicaoIdItem.Items.Clear()
                cbxEdicaoIdItem.Items.Add(dr(0))

                While dr.Read
                    cbxEdicaoIdItem.Items.Add(dr(0))
                End While
            End If
            bd.fecharConexao()
            dr = Nothing

            dr = bd.getTiposItens()
            If dr.HasRows Then
                cbxEdicaoTipoItem.Items.Clear()
                cbxEdicaoTipoItem.Items.Add(dr(0))

                While dr.Read
                    cbxEdicaoTipoItem.Items.Add(dr(0))
                End While
                bd.fecharConexao()
            End If
        End If

        If tcItem.SelectedIndex = 2 Then
            cbxRemocaoIdItem.Text = ""
            cbxRemocaoTipoItem.Text = ""
            txtRemocaoCustoUnitario.Text = ""
            txtRemocaoDescricao.Text = ""

            pnlEdicaoItem.Visible = False

            Dim dr As SqlDataReader
            dr = bd.getIdItens()
            If dr.HasRows Then
                cbxRemocaoIdItem.Items.Clear()
                cbxRemocaoIdItem.Items.Add(dr(0))

                While dr.Read
                    cbxRemocaoIdItem.Items.Add(dr(0))
                End While
            End If
            bd.fecharConexao()
            dr = Nothing

            dr = bd.getTiposItens()
            If dr.HasRows Then
                cbxRemocaoTipoItem.Items.Clear()
                cbxRemocaoTipoItem.Items.Add(dr(0))

                While dr.Read
                    cbxRemocaoTipoItem.Items.Add(dr(0))
                End While
            End If
            bd.fecharConexao()
        End If
    End Sub

    Private Sub cbxEdicaoTipoItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEdicaoTipoItem.SelectedIndexChanged
        edicaoTipoItem = cbxEdicaoTipoItem.Text
    End Sub

    Private Sub cbxRemocaoTipoItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxRemocaoTipoItem.SelectedIndexChanged
        remocaoTipoItem = cbxRemocaoTipoItem.Text
    End Sub

    Private Sub txtTipoItem_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        Try
            custoUnitario = Convert.ToDouble(txtCustoUnitario.Text)
        Catch ex As Exception
            MsgBox("Digite um custo unitário válido.")
        End Try

        descricao = txtDescricao.Text

        If (tipoItem <> "") Then ' faz todas a verificações e insere um item novo
            If (custoUnitario <> 0) Then
                If (descricao <> "") Then
                    bd.cadastrarItem(tipoItem, custoUnitario, descricao)
                    cbxTipoItem.Text = ""
                    cbxTipoItem.SelectedIndex = -1
                    txtCustoUnitario.Text = ""
                    txtDescricao.Text = ""

                    tipoItem = ""
                    custoUnitario = 0
                    descricao = ""
                    MsgBox("Item incluído com sucesso.")
                Else
                    MsgBox("Digite uma descrição.")
                End If
            Else
                MsgBox("Digite um custo unitário maior que zero.")
            End If
        Else
            MsgBox("Slecione o tipo do item.")
        End If
    End Sub

    Private Sub btnSalvarEdicao_Click(sender As Object, e As EventArgs) Handles btnSalvarEdicao.Click
        Try
            edicaoCustoUnitario = Convert.ToDouble(txtEdicaoCustoUnitario.Text)
        Catch ex As Exception
            MsgBox("Digite um custo unitário válido.")
        End Try

        edicaoDescricao = txtEdicaoDescricao.Text

        If (edicaoIdItem <> 0) Then 'salva as alterações feitas em determinado item selecionado
            If (edicaoTipoItem <> "") Then
                If (edicaoCustoUnitario <> 0) Then
                    If (edicaoDescricao <> "") Then
                        bd.editarItem(edicaoIdItem, edicaoTipoItem, edicaoCustoUnitario, edicaoDescricao)
                        MsgBox("Item atualizado com sucesso.")
                    Else
                        MsgBox("Digite uma descrição.")
                    End If
                Else
                    MsgBox("Digite um custo unitário maior que zero.")
                End If
            Else
                MsgBox("Seleciono o tipo de item.")
            End If
        Else
            MsgBox("Selecione o Id do item.")
        End If
    End Sub

    Private Sub btnRemocaoItem_Click(sender As Object, e As EventArgs) Handles btnRemocaoItem.Click 'remove o item selecionado do combo boxs
        If (remocaoIdItem <> 0) Then
            bd.removerItem(remocaoIdItem) 'Mudar no BD
        Else
            MsgBox("Selecione o Id do item.")
        End If

        cbxRemocaoIdItem.Items.Remove(remocaoIdItem)
        cbxEdicaoIdItem.Items.Remove(remocaoIdItem)

        remocaoIdItem = 0
        remocaoTipoItem = 0
        remocaoCustoUnitario = 0
        remocaoDescricao = 0

        cbxRemocaoIdItem.Text = ""
        cbxRemocaoTipoItem.Text = ""
        txtRemocaoCustoUnitario.Text = ""
        txtRemocaoDescricao.Text = ""
        pnlRemocaoItem.Visible = False
        MsgBox("Item removido com sucesso.")
    End Sub

    Private Sub txtEdicaoCustoUnitario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEdicaoCustoUnitario.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cbxTipoItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTipoItem.SelectedIndexChanged
        tipoItem = cbxTipoItem.Text
    End Sub

    Private Sub cbxEdicaoIdItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEdicaoIdItem.SelectedIndexChanged ' preenche os dados referentes ao id selecionado
        edicaoIdItem = cbxEdicaoIdItem.Text

        Dim dr As SqlDataReader

        dr = bd.selecionaDadosEdicaoItem(edicaoIdItem)

        dr.Read()
        edicaoTipoItem = Convert.ToString(dr.Item(0))
        edicaoDescricao = Convert.ToString(dr.Item(1))
        edicaoCustoUnitario = Convert.ToDouble(dr.Item(2))

        bd.fecharConexao()

        cbxEdicaoTipoItem.Text = edicaoTipoItem
        txtEdicaoCustoUnitario.Text = Convert.ToString(edicaoCustoUnitario)
        txtEdicaoDescricao.Text = edicaoDescricao

        pnlEdicaoItem.Visible = True
    End Sub

    Private Sub cbxRemocaoIdItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxRemocaoIdItem.SelectedIndexChanged ' preenche os dados referentes ao id selecionado
        remocaoIdItem = cbxRemocaoIdItem.Text

        Dim dr As SqlDataReader

        dr = bd.selecionaDadosEdicaoItem(remocaoIdItem) 'mudar

        dr.Read()
        remocaoTipoItem = Convert.ToString(dr.Item(0))
        remocaoDescricao = Convert.ToString(dr.Item(1))
        remocaoCustoUnitario = Convert.ToDouble(dr.Item(2))

        bd.fecharConexao()

        cbxRemocaoTipoItem.Text = remocaoTipoItem
        txtRemocaoCustoUnitario.Text = Convert.ToString(remocaoCustoUnitario)
        txtRemocaoDescricao.Text = remocaoDescricao

        pnlRemocaoItem.Visible = True
    End Sub

    Private Sub CadastroItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'preenche o combo box de cadastro
        Dim dr As SqlDataReader
        dr = bd.getTiposItens()
        If dr.HasRows Then
            cbxTipoItem.Items.Clear()
            cbxTipoItem.Items.Add(dr(0))

            While dr.Read
                cbxTipoItem.Items.Add(dr(0))
            End While
            bd.fecharConexao()
        End If
        dr = Nothing
    End Sub

    Private Sub txtRemocaoCustoUnitario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRemocaoCustoUnitario.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtCustoUnitario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCustoUnitario.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Public Sub setTextCbEdicao(txt As String)
        cbxEdicaoIdItem.Text = txt
    End Sub

    Private Sub tbEdicaoItem_Enter(sender As Object, e As EventArgs) Handles tbEdicaoItem.Enter
        cbxEdicaoIdItem.Text = ""
        cbxEdicaoTipoItem.Text = ""
        txtEdicaoCustoUnitario.Text = ""
        txtEdicaoDescricao.Text = ""

        pnlRemocaoItem.Visible = False

        Dim dr As SqlDataReader
        dr = bd.getIdItens()
        If dr.HasRows Then
            cbxEdicaoIdItem.Items.Clear()
            cbxEdicaoIdItem.Items.Add(dr(0))

            While dr.Read
                cbxEdicaoIdItem.Items.Add(dr(0))
            End While
        End If
        bd.fecharConexao()
        dr = Nothing

        dr = bd.getTiposItens()
        If dr.HasRows Then
            cbxEdicaoTipoItem.Items.Clear()
            cbxEdicaoTipoItem.Items.Add(dr(0))

            While dr.Read
                cbxEdicaoTipoItem.Items.Add(dr(0))
            End While
            bd.fecharConexao()
        End If
    End Sub
End Class