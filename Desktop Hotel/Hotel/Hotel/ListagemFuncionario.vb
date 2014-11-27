Public Class ListagemFuncionario

    Private Sub ListagemFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HosPDeirosDataSet8.hUsuario' table. You can move, or remove it, as needed.
        Me.HUsuarioTableAdapter.Fill(Me.HosPDeirosDataSet8.hUsuario)

    End Sub
End Class