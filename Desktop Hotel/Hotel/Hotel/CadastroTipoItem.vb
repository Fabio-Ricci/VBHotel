Imports System.Data.SqlClient

Public Class CadastroTipoItem
    Dim bd As New BD

    'Cadastro de Tipo de Item
    Dim descricaoTipoItem As String

    'Edição de Tipo de Item
    Dim edicaoIdTipoItem As Integer
    Dim edicaoDescricaoTipoItem As String

    'Remoção de Tipo de Item
    Dim remocaoIdTipoItem As Integer
    Dim remocaoDescricaoTipoItem As String

    Private Sub btnCadastarTipoItem_Click(sender As Object, e As EventArgs) Handles btnCadastarTipoItem.Click
        descricaoTipoItem = txtCadastroTipoItem.Text
        txtCadastroTipoItem.Text = ""

        If (descricaoTipoItem <> "") Then
            bd.incluirTipoItem(descricaoTipoItem)
            MsgBox("Tipo de item cadastrado com sucesso.")
        Else
            MsgBox("Digite uma descrição para o tipo de item")
        End If
    End Sub

    Private Sub btnSalvarEdicao_Click(sender As Object, e As EventArgs) Handles btnSalvarEdicao.Click
        edicaoDescricaoTipoItem = txtEdicaoDescricaoTipoItem.Text

        If (edicaoDescricaoTipoItem <> "") Then
            bd.editarTipoItem(edicaoIdTipoItem, edicaoDescricaoTipoItem)
            MsgBox("Tipo de item editado com sucesso.")
        Else
            MsgBox("Digite uma descrição para o tipo de item.")
        End If
    End Sub

    Private Sub cbxEdicaoIdTipoItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEdicaoIdTipoItem.SelectedIndexChanged
        edicaoIdTipoItem = cbxEdicaoIdTipoItem.Text

        Dim dr As SqlDataReader

        dr = bd.selecionaDadosTipoItem(edicaoIdTipoItem) 'Mudar

        dr.Read()
        edicaoDescricaoTipoItem = Convert.ToString(dr.Item(0))

        bd.fecharConexao()

        txtEdicaoDescricaoTipoItem.Text = edicaoDescricaoTipoItem

        pnlEdicaoTipoItem.Visible = True
    End Sub

    Private Sub btnRemovarTipoItem_Click(sender As Object, e As EventArgs) Handles btnRemovarTipoItem.Click
        bd.removerTipoItem(remocaoIdTipoItem)
        MsgBox("Tipo de item removido com sucesso.")

        cbxRemocaoIdTipoItem.Items.Remove(remocaoIdTipoItem)
        txtRemocaoDescricaoTipoItem.Text = ""
        pnlRemocaoTipoItem.Visible = False
    End Sub

    Private Sub cbxRemocaoIdTipoItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxRemocaoIdTipoItem.SelectedIndexChanged
        remocaoIdTipoItem = cbxRemocaoIdTipoItem.Text

        Dim dr As SqlDataReader

        dr = bd.selecionaDadosTipoItem(remocaoIdTipoItem) 'Mudar

        dr.Read()
        remocaoDescricaoTipoItem = Convert.ToString(dr.Item(0))

        bd.fecharConexao()

        txtRemocaoDescricaoTipoItem.Text = remocaoDescricaoTipoItem

        pnlRemocaoTipoItem.Visible = True
    End Sub

    Private Sub tcTipoItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcTipoItem.SelectedIndexChanged
        If tcTipoItem.SelectedIndex = 0 Then
            txtCadastroTipoItem.Text = ""

            pnlEdicaoTipoItem.Visible = False
            pnlRemocaoTipoItem.Visible = False
        End If

        If tcTipoItem.SelectedIndex = 1 Then
            cbxEdicaoIdTipoItem.Text = ""
            txtEdicaoDescricaoTipoItem.Text = ""

            pnlRemocaoTipoItem.Visible = False

            Dim dr As SqlDataReader
            dr = bd.getIdTipoItens()
            If dr.HasRows Then
                cbxEdicaoIdTipoItem.Items.Clear()
                cbxEdicaoIdTipoItem.Items.Add(dr(0))

                While dr.Read
                    cbxEdicaoIdTipoItem.Items.Add(dr(0))
                End While
            End If
            bd.fecharConexao()
        End If

        If tcTipoItem.SelectedIndex = 2 Then
            cbxRemocaoIdTipoItem.Text = ""
            txtRemocaoDescricaoTipoItem.Text = ""

            pnlEdicaoTipoItem.Visible = False

            Dim dr As SqlDataReader
            dr = bd.getIdTipoItens()
            If dr.HasRows Then
                cbxRemocaoIdTipoItem.Items.Clear()
                cbxRemocaoIdTipoItem.Items.Add(dr(0))

                While dr.Read
                    cbxRemocaoIdTipoItem.Items.Add(dr(0))
                End While
            End If
            bd.fecharConexao()
        End If
    End Sub
End Class