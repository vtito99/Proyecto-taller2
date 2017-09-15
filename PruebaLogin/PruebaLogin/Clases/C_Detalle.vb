Public Class C_Detalle
    Private cantidad As Integer
    Private precio As Double


    Public Sub New(ByVal p_cantidad As Integer, ByVal p_precio As Double)
        setCantidad(p_cantidad)
        setPrecio(p_precio)

    End Sub


#Region "get/set"


    Public Function getCantidad()
        Return cantidad
    End Function

    Public Function getPrecio()
        Return precio
    End Function


    Private Sub setCantidad(ByVal p_cantidad As Integer)
        Me.cantidad = p_cantidad
    End Sub

    Private Sub setPrecio(ByVal p_precio As String)
        Me.precio = p_precio
    End Sub


#End Region

End Class
