Public Class C_Factura

    Private fecha As String
    Private numeroFactura As Integer
    Private dni_cliente As Integer


    Public Sub New(ByVal p_fecha As String, ByVal p_numeroF As Integer, ByVal p_dniCliente As Integer)
        setFecha(p_fecha)
        setNumeroFactura(p_numeroF)
        setDniCliente(p_dniCliente)

    End Sub


#Region "get/set"


    Public Function getFecha()
        Return fecha
    End Function

    Public Function getNumeroFactura()
        Return numerofactura
    End Function

    Public Function getDniCliente()
        Return dni_cliente
    End Function


    Private Sub setFecha(ByVal p_fecha As String)
        Me.fecha = p_fecha
    End Sub
    Private Sub setNumeroFactura(ByVal p_numeroF As Integer)
        Me.numerofactura = p_numeroF
    End Sub
    Private Sub setDniCliente(ByVal p_dni As Integer)
        Me.dni_cliente = p_dni
    End Sub

#End Region
End Class
