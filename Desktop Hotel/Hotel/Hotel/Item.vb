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

    Public Function setPrecoUnitario(preco As Double)
        Return Me.precoUnitario = preco
    End Function

    Public Function setDescricao(desc As String)
        Return Me.descricao = desc
    End Function
End Class
