'ADICIONAR A LEGENDA COM AS CORES'

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient
Public Class hospedagemCheckIn

    Private banco As New BD

    Private chamante As Form
    Public Sub setChamante(ByRef chamante As Form)
        Me.chamante = chamante
    End Sub

    Private Function gerarStringDeBusca() As String
        Dim retorno As String = "select*from hCliente where idCliente not in(select idcliente from hreserva where idReserva in(select idreserva from HHospedagem)) "
        Dim jatemparametro As Boolean = False

        If (TXTcpf.Text.Trim <> "") Then
            retorno += "and cpf='" + TXTcpf.Text + "'"
        Else
            If (TXTemail.Text.Trim <> "") Then
                retorno += " and email='" + TXTcpf.Text + "'"
            Else
                If (TXTnome.Text.Trim <> "") Then
                    jatemparametro = True
                    retorno += " and nome='" + TXTnome.Text + "'"
                End If

                If (CBXsexo.Text.Trim <> "") Then
                    If (jatemparametro) Then
                        retorno += " and sexo='" + CBXsexo.Text + "'"
                    Else
                        retorno += " and sexo='" + CBXsexo.Text + "'"
                        jatemparametro = True
                    End If
                End If

                If (TXTtelefoneFixo.Text.Trim <> "") Then
                    If (jatemparametro) Then
                        retorno += " and telefone='" + TXTtelefoneFixo.Text + "'"
                    Else
                        retorno += " and telefone='" + TXTtelefoneFixo.Text + "'"
                        jatemparametro = True
                    End If
                End If

                If (TXTCelular.Text.Trim <> "") Then
                    If (jatemparametro) Then
                        retorno += " and celular='" + TXTCelular.Text + "'"
                    Else
                        retorno += " and celular='" + TXTCelular.Text + "'"
                        jatemparametro = True
                    End If
                End If


                If (TXTdatanasc.Text.Trim <> "") Then
                    If (jatemparametro) Then
                        retorno += " and datanascimento='" + TXTdatanasc.Text.Trim + "'"
                    Else
                        retorno += " and datanascimento='" + TXTdatanasc.Text.Trim + "'"
                    End If
                End If

            End If
        End If

        Return retorno
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dr As SqlDataReader = banco.consultaGenerica(Me.gerarStringDeBusca())
        Dim cont As Integer = 0
        Dim banco2 As New BD()
        DGcliente.Rows.Clear()
        '0,1,17,2,3,4,5,6
        While (dr.Read())
            Dim linha As String() = New String() {CStr(dr.GetInt32(0)), dr.GetString(1), CStr(dr.GetDateTime(2)), CStr(dr.GetString(3)), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7)}
            DGcliente.Rows.Add(linha)
            If (banco2.reservaAtual(dr.GetInt32(0))) Then
                DGcliente.Rows(cont).DefaultCellStyle.BackColor = System.Drawing.Color.Green

            Else
                DGcliente.Rows(cont).DefaultCellStyle.BackColor = System.Drawing.Color.Red

            End If
            cont += 1
        End While
        banco.fecharConexao()
    End Sub

    Private Sub hospedagem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DGcliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGcliente.CellClick
        If (e.RowIndex >= 0) Then
            Dim resposta As Integer = MessageBox.Show("Deseja seguir com o cadastro da hospedagem para o cliente:" +
            DGcliente.Rows(e.RowIndex).Cells(1).Value + ", Portador do CPF:" + DGcliente.Rows(e.RowIndex).Cells(2).Value + "?",
            "Check-in", MessageBoxButtons.YesNo)

            If resposta = DialogResult.Yes Then
                Dim Check As New Hospedagem_Reserva()
                Check.setChamante(Me)
                Check.Show()
                If (banco.reservaAtual(Convert.ToInt32(DGcliente.Rows(e.RowIndex).Cells(0).Value))) Then
                    Check.inicializar(Convert.ToInt32(DGcliente.Rows(e.RowIndex).Cells(0).Value))
                Else
                    Check.InicializarSem(Convert.ToInt32(DGcliente.Rows(e.RowIndex).Cells(0).Value))
                End If
                Me.Hide()
            End If
        End If

    End Sub

    Private Sub DGcliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGcliente.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        chamante.Show()
        Me.Dispose()
    End Sub

    Private Sub TXTtelefoneFixo_TextChanged(sender As Object, e As EventArgs) Handles TXTtelefoneFixo.TextChanged

    End Sub
End Class