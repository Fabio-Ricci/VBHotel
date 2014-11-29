Imports System.Data
Imports System.Data.SqlClient
Imports System.Threading
Imports Hotel.BD

Public Class tipoQuarto

    'variáveis de banco de dados
    Dim conn As SqlConnection
    Dim bd As New BD

    'id do tipo de apartamento sendo editado/consultado
    Dim idTipo As Integer = 0

    'variáveis para as inclusões e exibições de fotos
    Dim ListImage As New List(Of Byte())
    Dim indexFoto As Integer = 0
    Dim temFoto As Boolean = False
    Dim qtdFotos As Integer = 0

    Private Sub tipoQuarto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.conn = New SqlConnection("Data Source=REGULUS;Initial Catalog=hospdeiros;Persist Security Info=True;User ID=hospdeiros;Password=amostra")
        conn.Open()

    End Sub

    Private Sub tipoQuarto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        conn.Close()
    End Sub

    '--------------------CADASTRO ---------------------------

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        If (txtTipo.Text = "") Then
            MsgBox("Insira a descrição do Tipo de Apartamento")
        Else
            If (txtDiaria.Text = "") Then
                MsgBox("Insira o nome do Tipo de Apartamento")
            Else
                If (txtDescricao.Text = "") Then
                    MsgBox("Insira o valor da tarifa diária")
                Else
                    Try
                        bd.adicionaTipoApartamento(txtDescricao.Text, CStr(txtDiaria.Text), txtTipo.Text)
                        txtTipo.Clear()
                        txtDiaria.Clear()
                        txtDescricao.Clear()
                    Catch ex As Exception
                        MsgBox("Falha ao cadastrar apartamento.")
                        Exit Sub
                    End Try
                    MsgBox("Tipo de apartamento cadastrado com sucesso!")
                End If
            End If
        End If
    End Sub

    Private Sub txtDiaria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiaria.KeyPress

        'se caracter for diferente de ponto e backspace
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 44 Then

            'não permite aspas ou apóstrofo
            If Asc(e.KeyChar) = 34 Or Asc(e.KeyChar) = 39 Then
                e.Handled = True
            End If

            'permite apenas números
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If

            'permite apenas dois algarismos após a vírgula
            If txtDiaria.Text.IndexOf(",") > -1 And txtDiaria.Text.IndexOf(",") < txtDiaria.Text.Length - 2 Then
                e.Handled = True
            End If
        End If

        'permite apenas uma vírgula
        If e.KeyChar = "," And txtDiaria.Text.IndexOf(",") > -1 Then
            e.Handled = True
        End If

        txtDiaria.SelectionStart = txtDiaria.Text.Length

    End Sub

    Private Sub txtTipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipo.KeyPress
        'não permite aspas ou apóstrofo
        If Asc(e.KeyChar) = 34 Or Asc(e.KeyChar) = 39 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDescricao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescricao.KeyPress
        'não permite aspas ou apóstrofo
        If Asc(e.KeyChar) = 34 Or Asc(e.KeyChar) = 39 Then
            e.Handled = True
        End If
    End Sub

    '--------------------EDIÇÃO ----------------------

    Private Sub tpEdicao_Enter(sender As Object, e As EventArgs) Handles tpEdicao.Enter
        atualizaComboBox()
        atualizaTabEdicao()
        cbTipoEdicao.SelectedIndex = 0
    End Sub

    Private Sub cbTipoEdicao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoEdicao.SelectedIndexChanged
        atualizaTabEdicao()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If (txtTipoEdicao.Text = "") Then
            MsgBox("Insira a descrição do Tipo de Apartamento")
        Else
            If (txtDiariaEdicao.Text = "") Then
                MsgBox("Insira o nome do Tipo de Apartamento")
            Else
                If (txtDescricaoEdicao.Text = "") Then
                    MsgBox("Insira o valor da tarifa diária")
                Else
                    Try
                        bd.editaTipoApartamento(txtDescricaoEdicao.Text, CStr(txtDiariaEdicao.Text), txtTipoEdicao.Text, idTipo)
                        atualizaComboBox()
                        atualizaTabEdicao()
                    Catch ex As Exception
                        MsgBox("Falha ao editar apartamento: erro->" + ex.ToString)
                        Exit Sub
                    End Try
                    MsgBox("Tipo de apartamento editado com sucesso!")
                End If
            End If
        End If
    End Sub

    Private Sub atualizaTabEdicao()

        'seleciona os dados do tipo de apartamento e exibe nos campos para possível edição

        Dim dr As SqlDataReader

        If Not cbTipoEdicao.Text.Equals("") Then

            txtTipoEdicao.Text = cbTipoEdicao.Text

            dr = bd.infoTipoApartamento(cbTipoEdicao.Text)

            If dr.HasRows Then
                dr.Read()
                idTipo = dr("idTipoApartamento")
                txtDiariaEdicao.Text = CType(dr("tarifaDiaria"), String)
                txtDescricaoEdicao.Text = CType(dr("descricao"), String)
            End If

            bd.fecharConexao()

        End If

    End Sub

    Private Sub atualizaComboBox()

        'recarrega os itens do combobox de tipos de apartamento

        Dim index As Integer
        Dim drCombobox As SqlDataReader

        index = cbTipoEdicao.SelectedIndex

        cbTipoEdicao.Items.Clear()

        drCombobox = bd.tiposApartamento

        If (drCombobox.HasRows) Then
            While drCombobox.Read()
                cbTipoEdicao.Items.Add(drCombobox("tipo"))
            End While
        Else
            MsgBox("Não há tipos cadastrados")
        End If

        drCombobox.Close()
        bd.fecharConexao()

        cbTipoEdicao.SelectedIndex = index
    End Sub

    Private Sub txtDiariaEdicao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiariaEdicao.KeyPress
        'se caracter for diferente de ponto e backspace
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 44 Then

            'não permite aspas ou apóstrofo
            If Asc(e.KeyChar) = 34 Or Asc(e.KeyChar) = 39 Then
                e.Handled = True
            End If

            'permite apenas números
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If

            'permite apenas dois algarismos após a vírgula
            If txtDiariaEdicao.Text.IndexOf(",") > -1 And txtDiariaEdicao.Text.IndexOf(",") < txtDiariaEdicao.Text.Length - 2 Then
                e.Handled = True
            End If
        End If

        'permite apenas uma vírgula
        If e.KeyChar = "," And txtDiariaEdicao.Text.IndexOf(",") > -1 Then
            e.Handled = True
        End If

        txtDiariaEdicao.SelectionStart = txtDiariaEdicao.Text.Length
    End Sub

    Private Sub txtTipoEdicao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipoEdicao.KeyPress
        'não permite aspas ou apóstrofo
        If Asc(e.KeyChar) = 34 Or Asc(e.KeyChar) = 39 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDescricaoEdicao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescricaoEdicao.KeyPress
        'não permite aspas ou apóstrofo
        If Asc(e.KeyChar) = 34 Or Asc(e.KeyChar) = 39 Then
            e.Handled = True
        End If
    End Sub

    '--------------------ADICIONAR FOTOS ----------------------

    Private Sub tpFotos_Enter(sender As Object, e As EventArgs) Handles tpFotos.Enter

        'carrega o combobox de tipos

        Dim drCombobox As SqlDataReader

        cbTipo.Items.Clear()

        drCombobox = bd.tiposApartamento

        If (drCombobox.HasRows) Then
            While drCombobox.Read()
                If IsDBNull(drCombobox("tipo")) Then
                    MessageBox.Show("Null")
                Else
                    cbTipo.Items.Add(drCombobox("tipo"))
                End If
            End While
        Else
            MsgBox("Não há tipos cadastrados")
        End If

        drCombobox.Close()
        bd.fecharConexao()

        cbTipo.SelectedIndex = 0

    End Sub

    Private Sub cbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipo.SelectedIndexChanged

        idTipo = bd.getIdTipoApartamento(cbTipo.Text)

    End Sub

    Private Sub btnAddFoto_Click(sender As Object, e As EventArgs) Handles btnCarregar.Click

        'carrega a foto no picturebox
        Try
            If ofdFoto.ShowDialog = Windows.Forms.DialogResult.OK Then
                pbAddFoto.Image = Image.FromFile(ofdFoto.FileName)
                pbAddFoto.SizeMode = PictureBoxSizeMode.StretchImage
                temFoto = True
            Else
                temFoto = False
            End If
        Catch ex As Exception
            MsgBox("Erro ao abrir o Arquivo.")
        End Try
    End Sub

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click

        'insere a foto no BD
        Dim imgMemoryStream As System.IO.MemoryStream
        Dim imgByteArray() As Byte = New Byte() {}

        If temFoto Then
            imgMemoryStream = New System.IO.MemoryStream
            pbAddFoto.Image.Save(imgMemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)
            pbAddFoto.SizeMode = PictureBoxSizeMode.StretchImage
            imgByteArray = imgMemoryStream.GetBuffer()

            bd.adicionaFotoApartamento(idTipo, imgByteArray)

            MsgBox("Foto adicionada no BD")
        Else
            MsgBox("Selecione uma foto")
        End If
    End Sub

    '-------------------- EXIBIÇÃO -----------------------

    Private Sub cbTipoExibicao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoExibicao.SelectedIndexChanged

        Dim drDesc As SqlDataReader
        Dim cmd As SqlCommand

        '--- seleciona o id ------
        idTipo = bd.getIdTipoApartamento(cbTipoExibicao.Text)

        '--- exibe a descrição ---
        cmd = New SqlCommand("select dbo.descricaoTipoApartamento(" + CStr(idTipo) + ")", Me.conn)
        drDesc = cmd.ExecuteReader()
        drDesc.Read()
        lblDescricao.Text = CType(drDesc(0), String)

        drDesc.Close()

        bd.fecharConexao()

        carregaFotos()
        If Not ListImage.Equals(Nothing) Then
            timerSlide.Start()
        End If

    End Sub


    Private Sub carregaFotos() 'carrega as fotos do tipo de apto selecionado em um List

        Dim dr As SqlClient.SqlDataReader
        Dim arrayImage() As Byte = New Byte() {}

        ListImage.Clear()
        indexFoto = 0
        qtdFotos = 0

        If cbTipoExibicao.Items.Count <> 0 Then
            Try
                dr = bd.fotosApartamento(idTipo)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            'dr.Read()
            If (dr.HasRows) Then
                While dr.Read()
                    If IsDBNull(dr("foto")) Then
                        MessageBox.Show("Null")
                    Else
                        arrayImage = CType(dr("foto"), Byte())
                        If arrayImage.GetUpperBound(0) > 0 Then
                            ListImage.Add(arrayImage)
                            qtdFotos += 1
                        End If
                    End If
                End While
            Else
                pbFoto.Image = pbFoto.ErrorImage
            End If

            dr.Close()
            bd.fecharConexao()

        End If

        Exit Sub
    End Sub

    Private Sub timerSlide_Tick(sender As Object, e As EventArgs) Handles timerSlide.Tick
        'exibe as fotos no slideshow
        Dim stream As System.IO.MemoryStream

        If ListImage.Count > 0 Then
            If indexFoto >= qtdFotos Then
                indexFoto = 0
            End If

            stream = New System.IO.MemoryStream(ListImage(indexFoto))
            pbFoto.Image = Image.FromStream(stream)
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage

            indexFoto += 1

        End If
    End Sub

    Private Sub tpExibicao_Enter(sender As Object, e As EventArgs) Handles tpExibicao.Enter

        Dim drCombobox As SqlDataReader

        '--- carrega o combobox ---
        cbTipoExibicao.Items.Clear()

        drCombobox = bd.tiposApartamento

        If (drCombobox.HasRows) Then
            While drCombobox.Read()
                If IsDBNull(drCombobox("tipo")) Then
                    MessageBox.Show("Null")
                Else
                    cbTipoExibicao.Items.Add(drCombobox("tipo"))
                End If
            End While
        Else
            MsgBox("Não há tipos cadastrados")
        End If

        drCombobox.Close()
        bd.fecharConexao()

        cbTipoExibicao.SelectedIndex = 0

        'inicia o slideshow
        If Not ListImage.Equals(Nothing) Then
            timerSlide.Enabled = False
            timerSlide.Start()
        End If

    End Sub

    Public Sub setSelectedTextCBEdicao(text As String)
        cbTipoEdicao.Text = text
    End Sub

End Class

