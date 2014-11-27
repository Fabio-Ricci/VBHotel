Imports System.Data.SqlClient

Public Class ListagemCliente

    Private Sub ListagemCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HosPDeirosDataSet7.hCliente' table. You can move, or remove it, as needed.
        Me.HClienteTableAdapter1.Fill(Me.HosPDeirosDataSet7.hCliente)
        'TODO: This line of code loads data into the 'HosPDeirosDataSet6.hCliente' table. You can move, or remove it, as needed.
        Me.HClienteTableAdapter.Fill(Me.HosPDeirosDataSet6.hCliente)

    End Sub
End Class