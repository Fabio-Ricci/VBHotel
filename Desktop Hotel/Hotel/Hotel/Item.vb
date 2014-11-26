Public Class Item
    Private precoUnitario As Double
    Private descricao As String

    Sub New(preco As Double, desc As String)
        Me.precoUnitario = preco
        Me.descricao = desc
    End Sub

    Public Function getPrecoUnitario()
        Return Me.precoUnitario
    End Function

    Public Function getDescricao()
        Return Me.descricao
    End Function
End Class
