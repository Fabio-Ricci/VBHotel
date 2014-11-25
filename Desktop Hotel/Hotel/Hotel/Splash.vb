Imports System.Threading

Public Class Splash

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label1.Show()
        Me.lblMensagem.Show()
        Me.PictureBox1.Show()
        Me.Show()
        Me.BackColor = Color.FromArgb(205, 220, 205)

    End Sub

    Private Sub Splash_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        lblMensagem.Text = "Carregando dados do sistema..."
        For i As Integer = 0 To pbProgresso.Maximum / 3
            pbProgresso.Value = i
            Thread.Sleep(100)
        Next

        lblMensagem.Text = "Carregando formulários..."
        For i = pbProgresso.Maximum / 3 To 2 * (pbProgresso.Maximum / 3)
            pbProgresso.Value = i
            Thread.Sleep(100)
        Next

        lblMensagem.Text = "Carregando banco de dados..."
        For i = 2 * (pbProgresso.Maximum / 3) To pbProgresso.Maximum
            pbProgresso.Value = i
            Thread.Sleep(100)
        Next

        Thread.Sleep(300)
    End Sub
End Class