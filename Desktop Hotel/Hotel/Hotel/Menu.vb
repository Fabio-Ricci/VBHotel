Public Class Menu

    Private login As Form

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblid.Click

    End Sub


    Public Sub setlblid(texto As String)
        lblid.Text = texto
    End Sub
    Public Sub setLogin(ByRef form As Form)
        Me.login = form
    End Sub

    Public Sub destroiBotaoCadastro()
        BTNcadastrousuario.Dispose()
    End Sub


    Private Sub BTNcadastrousuario_Click(sender As Object, e As EventArgs) Handles BTNcadastrousuario.Click
        Dim cadastro As New CadastroUsuario()
        Me.Hide()
        cadastro.Show()
        cadastro.setMenuOpcao(Me)
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.login.Show()
        Me.Dispose()
    End Sub
End Class