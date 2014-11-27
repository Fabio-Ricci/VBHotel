Public Class ListagemTipoItem

    Private Sub ListagemTipoItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HosPDeirosDataSet4.HTIPOITEM' table. You can move, or remove it, as needed.
        Me.HTIPOITEMTableAdapter.Fill(Me.HosPDeirosDataSet4.HTIPOITEM)

    End Sub
End Class