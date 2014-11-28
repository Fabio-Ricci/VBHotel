Imports System.Data.SqlClient

Public Class EditarHospedagem
    Private banco As New BD
    Private chamante As Form
    Public Sub setChamante(ByRef chamante As Form)
        Me.chamante = chamante
    End Sub

    Private Sub EditarHospedagem_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub


    Public Function gerarStrindDebusca() As String
        Dim retorno As String = "select idHospedagem,idapartamento,idreserva,origem,destino,tipoGrupo,motivoviagem from "
        If (TXTidHospedagem.Text <> "") Then
            retorno += "  dbo.HospedagemEdicaoConsulta(" + TXTidHospedagem.Text + ")"

        Else

            If (TXTidApartamento.Text <> "") Then
                retorno += " dbo.HospedagemEdicaoConsulta((select idHospedagem from Hhospedagem where idApartamento=" + TXTidApartamento.Text + " ) )"

            Else

                If (TXTIDreserva.Text <> "") Then
                    retorno += "dbo.HospedagemEdicaoConsulta((select idHospedagem from Hhospedagem where idreserva=" + TXTIDreserva.Text + " ) )"
                Else
                    If (TXTorigem.Text <> "") Then
                        retorno = "select idHospedagem,r.idapartamento,r.idreserva,origem,destino,tipoDoGrupo,motivoviagem from  Hreserva r,Hhospedagem h where h.origem='" + TXTorigem.Text + "' and r.idreserva = h.idreserva"
                    Else
                        If (TXTdestino.Text <> "") Then
                            retorno = "select idHospedagem,r.idapartamento,r.idreserva,origem,destino,tipoDoGrupo,motivoviagem from  Hreserva r,Hhospedagem h where h.destino='" + TXTdestino.Text + "' and r.idreserva = h.idreserva"
                        Else
                            If (CBXtipogrupo.Text <> "") Then
                                retorno = "select idHospedagem,r.idapartamento,r.idreserva,origem,destino,tipoDoGrupo,motivoviagem from  Hreserva r,Hhospedagem h where h.tipoDoGrupo=" + CStr(CBXtipogrupo.SelectedIndex + 1) + " and r.idreserva = h.idreserva"
                            Else
                                If (CBXmotivoViagem.Text <> "") Then
                                    retorno = "select idHospedagem,r.idapartamento,r.idreserva,origem,destino,tipoDoGrupo,motivoviagem from  Hreserva r,Hhospedagem h where h.MotivoViagem=" + CStr(CBXmotivoViagem.SelectedIndex + 1) + " and r.idreserva = h.idreserva"
                                Else
                                    retorno = "select idHospedagem,r.idapartamento,r.idreserva,origem,destino,tipoDoGrupo,motivoviagem from  Hreserva r,Hhospedagem h where r.idreserva = h.idreserva"
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If


        Return retorno

    End Function



    Private Sub DGHospedagem_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGHospedagem.CellClick
        If (e.RowIndex >= 0) Then
            Dim resposta As Integer = MessageBox.Show("Deseja seguir com a alteração desta Hospedagem ?", "alteração Hospedagem", MessageBoxButtons.YesNo)
            If resposta = DialogResult.Yes Then
                Dim Check As New Hospedagem_Reserva()
                Check.setChamante(Me)
                Check.Show()
                Check.iniciarEdicaoHospedagem(Convert.ToInt32(DGHospedagem.Rows(e.RowIndex).Cells(0).Value))
                Me.Hide()
            End If
        End If
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dr As SqlDataReader = banco.consultaGenerica(Me.gerarStrindDebusca)
        Dim cont As Integer = 0
        Dim banco2 As New BD()
        DGHospedagem.Rows.Clear()
        '0,1,17,2,3,4,5,6
        While (dr.Read)
            Dim linha As String() = New String() {CStr(dr.GetInt32(0)), CStr(dr.GetInt32(1)), CStr(dr.GetInt32(2)), dr.GetString(3), dr.GetString(4), CBXtipogrupo.Items(dr.GetInt32(5)).ToString, CBXmotivoViagem.Items(dr.GetInt32(6)).ToString}
            DGHospedagem.Rows.Add(linha)
            cont += 1
        End While
        banco.fecharConexao()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        chamante.Show()
        Me.Dispose()
    End Sub
End Class