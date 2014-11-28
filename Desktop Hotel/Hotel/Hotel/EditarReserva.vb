Imports System.Data.SqlClient
'nao pode retornar + QUE DUAS COLUNAS

Public Class EditarReserva
    Private banco As New BD()
    Private chamante As Form
    Public Sub setChamante(ByRef chamante As Form)
        Me.chamante = chamante
    End Sub

    Public Function gerarStringDeBusca() As String
        Dim retorno As String
        '
        retorno = " select idreserva,idCliente,nome,dataInicio,dataFim,numeroBoleto,situacao,tipo from"

        If (TXTIDreserva.Text <> "") Then
            retorno += "dbo.reservaEdicaoConsulta(" + TXTIDreserva.Text + ")" 'POSTAR VERSAO NOVA NO SQL
        Else

            If (TXTidCliente.Text <> "") Then
                retorno = " select idreserva,c.idCliente,nome,dataInicio,dataFim,numeroBoleto,situacao,tipo from hcliente c,hreserva r,hTipoApartamento ht where c.idCliente=" + TXTidCliente.Text + "and r.idCliente=c.idcliente and ht.idtipoApartamento in(select idTipoApartamento from hApartamento where idApartamento in(r.idApartamento) )"

            Else

                If (TXTdataInicio.Text <> "") Then
                    retorno = " select idreserva,c.idCliente,nome,dataInicio,dataFim,numeroBoleto,situacao,tipo from hcliente c,hreserva r,hTipoApartamento ht where r.dataInicio='" + TXTdataInicio.Text + "' and c.idCliente=r.idCliente and ht.idTipoApartamento in(select idtipoApartamento from hapartamento where idApartamento in(r.idApartamento))"
                Else
                    If (TXTdataFim.Text <> "") Then
                        retorno = " select idreserva,c.idCliente,nome,dataInicio,dataFim,numeroBoleto,situacao,tipo from hcliente c,hreserva r,hTipoApartamento ht where r.dataFim='" + TXTdataFim.Text + "' and c.idCliente=r.idCliente and ht.idTipoApartamento in(select idtipoApartamento from hapartamento where idApartamento in(r.idApartamento))"
                    Else
                        If (TXTnumeroBoleto.Text <> "") Then
                            retorno = " select idreserva,c.idCliente,nome,dataInicio,dataFim,numeroBoleto,situacao,tipo from hcliente c,hreserva r,hTipoApartamento ht where r.numeroBoleto=" + TXTnumeroBoleto.Text + " and c.idCliente=r.idCliente and ht.idTipoApartamento in(select idtipoApartamento from hapartamento where idApartamento in(r.idApartamento))"
                        Else
                            If (CBXtipoApartamento.Text <> "") Then
                                retorno = " select idreserva,c.idCliente,nome,dataInicio,dataFim,numeroBoleto,situacao,tipo from hcliente c,hreserva r,hTipoApartamento ht where ht.tipo='" + CBXtipoApartamento.Text + "' and r.idApartamento in(select idApartamento from hApartamento where tipo=ht.tipo) and c.idCliente =r.idCliente"
                            Else
                                If (TXTnomeCLiente.Text <> "") Then
                                    retorno = " select idreserva,c.idCliente,nome,dataInicio,dataFim,numeroBoleto,situacao,tipo from hcliente c,hreserva r,hTipoApartamento ht where c.nome='" + TXTnomeCLiente.Text + "' and r.idCliente=c.idcliente and ht.idtipoApartamento in(select idTipoApartamento from hApartamento where idApartamento in(r.idApartamento) )"
                                Else
                                    If (CBXsituacao.Text <> "") Then
                                        retorno = "select idreserva,c.idCliente,nome,dataInicio,dataFim,numeroBoleto,situacao,tipo from hcliente c,hreserva r,hTipoApartamento ht where r.situacao=" + CStr(CBXsituacao.SelectedIndex + 1) + " and c.idCliente=r.idCliente and ht.idTipoApartamento in(select idtipoApartamento from hapartamento where idApartamento in(r.idApartamento))"
                                    Else
                                        retorno = "select idreserva,c.idCliente,nome,dataInicio,dataFim,numeroBoleto,situacao,tipo from hcliente c,hreserva r,hTipoApartamento ht where r.idCliente=c.idCliente and ht.idTipoApartamento in(select idTIpoApartamento from htipoApartamento where idApartamento in(r.idApartamento))"

                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        Return retorno
    End Function


    Private Sub EditarReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tiposApto As SqlDataReader = banco.consultaGenerica("select tipo from htipoApartamento where idtipoApartamento in (select idTipoApartamento from hApartamento)")
        While (tiposApto.Read())
            CBXtipoApartamento.Items.Add(tiposApto.Item(0))
        End While
        banco.fecharConexao()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dr As SqlDataReader = banco.consultaGenerica(Me.gerarStringDeBusca())
        Dim cont As Integer = 0
        Dim banco2 As New BD()
        DGreserva.Rows.Clear()
        '0,1,17,2,3,4,5,6
        ', numero boleto, situacao, tipo apartamento'
        While (dr.Read)
            Dim linha As String() = New String() {CStr(dr.GetInt32(0)), CStr(dr.GetInt32(1)), dr.GetString(2), CStr(dr.GetDateTime(3)), CStr(dr.GetDateTime(4)), CStr(dr.GetInt32(5)), CBXsituacao.Text, dr.GetString(7)}
            DGreserva.Rows.Add(linha)
            cont += 1
        End While
        banco.fecharConexao()
    End Sub

    Private Sub DGreserva_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGreserva.CellClick
        If (e.RowIndex >= 0) Then
            Dim resposta As Integer = MessageBox.Show("Deseja seguir com o a alteração da hospedagem para o cliente:" +
              DGreserva.Rows(e.RowIndex).Cells(2).Value + ", do apartamento :" + DGreserva.Rows(e.RowIndex).Cells(7).Value + " no intervalo " + DGreserva.Rows(e.RowIndex).Cells(3).Value + " a " + DGreserva.Rows(e.RowIndex).Cells(4).Value + "?", "Check-in", MessageBoxButtons.YesNo)
            If resposta = DialogResult.Yes Then
                Dim Check As New Hospedagem_Reserva()
                Check.setChamante(Me)
                Check.Show()
                Check.InicializarEdicaoReserva(Convert.ToInt32(DGreserva.Rows(e.RowIndex).Cells(0).Value))
                Me.Hide()

            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        chamante.Show()
        Me.Dispose()

    End Sub

    Private Sub DGreserva_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGreserva.CellContentClick

    End Sub
End Class