Public Class C_Producto
    Private nombre As String
    Private descripcion As String
    Private precio As Double
    Private stock As Integer
    Private tipoP As String


    Public Sub New(ByVal p_nombre As String, ByVal p_descrip As String, ByVal p_precio As Double, ByVal p_stock As Integer, ByVal p_tipoP As String)
        setNombre(p_nombre)
        setDescripcion(p_descrip)
        setPrecio(p_precio)
        setStock(p_stock)
        setTipoP(p_tipoP)

    End Sub


#Region "get/set"


    Public Function getNombre()
        Return nombre
    End Function

    Public Function getDescripcion()
        Return descripcion
    End Function

    Public Function getPrecio()
        Return precio
    End Function
    Public Function getStock()
        Return stock
    End Function
    Public Function getTipoP()
        Return tipoP
    End Function


    Private Sub setNombre(ByVal p_nombre As String)
        Me.nombre = p_nombre
    End Sub
    Private Sub setDescripcion(ByVal p_desc As String)
        Me.descripcion = p_desc
    End Sub
    Private Sub setPrecio(ByVal p_precio As String)
        Me.precio = p_precio
    End Sub
    Private Sub setStock(ByVal p_stock As String)
        Me.stock = p_stock
    End Sub
    Private Sub setTipoP(ByVal p_tipo As String)
        Me.tipoP = p_tipo
    End Sub

#End Region
End Class
