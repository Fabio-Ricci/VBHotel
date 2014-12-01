Public Class CadastroUsuario

    Private banco As New BD
    Private cam As New Camera
    Private fotoInserida As Boolean = False
    Private menuopcao As Form
 

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'carrega uma imagem de um dispositivo de armazenamento
        Try
            btnTirarFoto.PerformClick()
            If ofdFoto.ShowDialog = Windows.Forms.DialogResult.OK Then 'oepdialog abre
                PBfoto.Image = New Bitmap(ofdFoto.FileName) 'passa a foto pro picture boz
                PBfoto.SizeMode = PictureBoxSizeMode.StretchImage
                Me.fotoInserida = True
            End If
        Catch ex As Exception
            MsgBox("Erro ao abrir o Arquivo.")
        End Try
    End Sub


    Private Sub btnTirarFoto_Click(sender As Object, e As EventArgs) Handles btnTirarFoto.Click
        Dim dados As IDataObject
        Dim bmp As Image
        cam.enviarMensagem() 'Mensagem com as constantes
        dados = Clipboard.GetDataObject()
        If dados.GetDataPresent(GetType(System.Drawing.Bitmap)) Then 'metodos associados a utilização de webcam pelo sistema
            bmp = CType(dados.GetData(GetType(System.Drawing.Bitmap)), Image)
            PBfoto.Image = bmp
            PBfoto.SizeMode = PictureBoxSizeMode.StretchImage
            cam.enviarMensagemDriver() 'envia mensagem pro driver da webcam
            cam.destruirjanela() 'destoi a janela
            fotoInserida = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cam.CarregaDispositivos()
        If (cam.getQtdDispositivos > 0) Then 'numero de dispositivos
            btnTirarFoto.Enabled = True
            btnTirarFoto.Visible = True
            cam.abreVideo(PBfoto)
        Else
            MessageBox.Show("A camera nao foi encontrada", "Atenção",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'alera de camera nao encontrada
        End If
    End Sub



    Private Sub RBgerente_Click(sender As Object, e As EventArgs) Handles RBgerente.Click
        RBfuncionario.Checked = False
        RBgerente.Checked = True
    End Sub

    Private Sub RBfuncionario_Click(sender As Object, e As EventArgs) Handles RBfuncionario.Click
        RBgerente.Checked = False
        RBfuncionario.Checked = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Verificação geral de preenchimento dos camposs
        If (EDusuario.Text.Trim = "") Then
            MessageBox.Show("O campo Usuário nao pode estar em branco", "Atenção",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            EDusuario.Focus()
        Else
            If (EDsenha.Text.Trim = "") Then
                MessageBox.Show("O campo senha nao pode estar em branco", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                EDsenha.Focus()
            Else

                If (EDconfirmarsenha.Text.Trim = "") Then
                    MessageBox.Show("O campo de confirmacao da senha nao pode estar em branco", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    EDconfirmarsenha.Focus()
                Else
                    If (EDconfirmarsenha.Text <> EDsenha.Text) Then
                        MessageBox.Show("A senha informada nao confere com a senha da confirmacao", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        EDsenha.Text = ""
                        EDconfirmarsenha.Text = ""
                        EDsenha.Focus()

                    Else

                        If (Not fotoInserida) Then
                            MessageBox.Show("Por favor, Insira uma foto (clique no botao ativar camera e em seguida no tirar foto, ou clique no botao adicionar foto já existente e carregue uma foto)", "Atenção",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                        Else
                            Try
                                Dim foto() As Byte
                                Dim imgstr As System.IO.MemoryStream
                                imgstr = New System.IO.MemoryStream
                                PBfoto.Image.Save(imgstr, System.Drawing.Imaging.ImageFormat.Jpeg)
                                foto = imgstr.GetBuffer
                                If (RBgerente.Checked) Then
                                    banco.adicionaUsuario(EDusuario.Text, EDsenha.Text, 2, foto) 'insercao de gerente (diferiações pelo radio group)
                                    MessageBox.Show("Inclusao do Gerente efetuada com êxito", "Sucesso",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Else
                                    banco.adicionaUsuario(EDusuario.Text, EDsenha.Text, 1, foto) 'insercao de funcionario
                                    MessageBox.Show("Inclusao do funcionario efetuada com êxito", "Sucesso",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                                fotoInserida = False 'ressete das variáveis globais para a proxima inserção
                                EDsenha.Text = ""
                                EDusuario.Text = ""
                                EDconfirmarsenha.Text = ""
                                EDusuario.Focus()
                                btnTirarFoto.Enabled = False
                                btnTirarFoto.Visible = False
                                RBfuncionario_Click(Nothing, Nothing)

                            Catch ex As Exception
                                MessageBox.Show("Erro ao Inserir usuário do sistema. Erro:" + ex.ToString, "Erro",
                               MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try


                        End If
                    End If
                End If

            End If

        End If
    End Sub

    Private Sub PBfoto_Click(sender As Object, e As EventArgs) Handles PBfoto.Click

    End Sub

    Private Sub CadastroUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub setMenuOpcao(ByRef form As Form)
        Me.menuopcao = form
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.menuopcao.Show() ' mostra o que chamou esse formulario
        Me.Dispose() ' destroi o formulario atual
    End Sub
End Class