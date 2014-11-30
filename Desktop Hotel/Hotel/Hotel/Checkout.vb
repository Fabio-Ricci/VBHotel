Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class Checkout
    Dim bd As New BD
    Dim indice As Integer = 0

    'Cliente
    Dim cpf As String
    Dim nome As String
    Dim email As String

    'Hospedagem
    Dim idHospedagem As Integer
    Dim consumoTotal As Double
    Dim valorDiaria As Double

    'Tipo Apartamento
    Dim idTipoApartamento As Integer
    Dim tipoQuarto As String
    Dim diariaTipoQuarto As Double

    'Apartamento
    Dim idApartamento As Integer
    Dim numero As Integer
    Dim andar As Integer
    Dim camasCasal As Integer
    Dim camasSolteiro As Integer
    Dim frigobar As Char

    'Item
    Dim qtdItens As Integer
    Dim itens As List(Of Item)
    Dim qtdItensConsumidos As Integer

    Dim notaFiscal As String

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click 'carrega todos os dados do cpf selecionado
        cpf = txtCpf.Text
        cpf = cpf.Replace(",", ".")

        If (cpf <> "") Then
            Dim dr As SqlDataReader

            dr = bd.getDadosCheckout(cpf)
            If (dr.HasRows) Then
                dr.Read()
                nome = dr.Item(0)
                email = dr.Item(1)

                idTipoApartamento = dr.Item(2)
                diariaTipoQuarto = dr.Item(3)
                tipoQuarto = dr.Item(4)

                andar = dr.Item(5)
                numero = dr.Item(6)
                camasCasal = dr.Item(7)
                camasSolteiro = dr.Item(8)
                frigobar = dr.Item(9)

                idHospedagem = dr.Item(10)
                bd.fecharConexao()

                dr = Nothing
                ''''''''''''''''''''''''''''''''''''''''
                qtdItensConsumidos = bd.qtdItensConsumidos(idHospedagem) 'conta quantos itens diferentes aquele cliente consumidos
                '''''''''''''''''''''''''''''''''''''''
                bd.fecharConexao()

                txtNome.Text = nome
                txtEmail.Text = email

                txtTipoQuarto.Text = tipoQuarto
                txtDiaria.Text = diariaTipoQuarto

                txtNumero.Text = numero
                txtAndar.Text = andar
                txtCamasCasal.Text = camasCasal
                txtCamasSolteiro.Text = camasSolteiro
                If frigobar = "S" Then
                    rbSim.Checked = True
                Else
                    RbNao.Checked = True
                End If
                pnlCheckout.Visible = True

                txtConsumoTotal.Text = Convert.ToString(bd.gastoAtualHospedagem(idHospedagem))

                notaFiscal = bd.notaFiscal(idHospedagem)

                txtNotaFiscal.Text = notaFiscal.Replace(",", vbNewLine)
            Else
                MsgBox("Esse cliente não está hospedado.")
            End If
        Else
            MsgBox("Digite o CPF.")
        End If
        bd.fecharConexao()
    End Sub
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click 'realiza o checkout do cpf selecionado
        Dim escolha As MsgBoxResult = MsgBox("Deseja realmente realizar o checkout desse cliente?", MsgBoxStyle.YesNoCancel)

        If (escolha = MsgBoxResult.Yes) Then
            bd.checkout(cpf)
            MsgBox("Checkout realizado com sucesso. Por favor faça a avaliação da hospedagem no site através do link enviado em seu e-mail")
            txtNome.Text = ""
            txtEmail.Text = ""
            txtTipoQuarto.Text = ""
            txtDiaria.Text = ""
            txtNumero.Text = ""
            txtAndar.Text = ""
            txtCamasCasal.Text = ""
            txtCamasSolteiro.Text = ""
            rbSim.Checked = False
            RbNao.Checked = False
            txtConsumoTotal.Text = ""
            txtCpf.Text = ""
            pnlCheckout.Visible = False


            Dim mensagemDeEmail As New MailMessage()
            Try
                mensagemDeEmail.From = New MailAddress("MountainVilleHotel@gmail.com")
                mensagemDeEmail.To.Add(Me.email)
                mensagemDeEmail.Subject = "Hotel Mountain Ville-Avalie a Sua Hospedagem !"
                mensagemDeEmail.Body = "Visite a página de avaliação e avalie sua hospedagem:" 'URL aqui
                Dim SMTP As New SmtpClient("smtp.gmail.com")
                SMTP.Port = 587
                SMTP.EnableSsl = True
                SMTP.Credentials = New System.Net.NetworkCredential("MountainVilleHotel@gmail.com", "mountainvillehotelehlegal")
                SMTP.Send(mensagemDeEmail)
            Catch ex As Exception
                MessageBox.Show("Erro ao enviar o questionario para o cliente:" + ex.ToString)
            End Try
        End If
    End Sub

    Private Sub pnlCheckout_Paint(sender As Object, e As PaintEventArgs) Handles pnlCheckout.Paint

    End Sub

    Private Sub gbFrigobar_Enter(sender As Object, e As EventArgs) Handles gbFrigobar.Enter

    End Sub
End Class