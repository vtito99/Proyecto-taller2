Public Class C_Producto
    Private nombre As String
    Private descripcion As String
    Private precio As Double
    Private stock As Integer
    Private tipoP As String
    Private ruta As String


    Public Sub New(ByVal p_nombre As String, ByVal p_descrip As String, ByVal p_precio As Double, ByVal p_stock As Integer, ByVal p_tipoP As String, ByVal p_ruta As String)
        setNombre(p_nombre)
        setDescripcion(p_descrip)
        setPrecio(p_precio)
        setStock(p_stock)
        setTipoP(p_tipoP)
        setRuta(p_ruta)

    End Sub


#Region "get/set"

    Sub New()
        ' TODO: Complete member initialization 
    End Sub


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
    Public Function getRuta()
        Return ruta
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
    Private Sub setRuta(ByVal p_ruta As String)
        Me.ruta = p_ruta
    End Sub

#End Region

    'Metodo Mostrar Productos
    Public Sub mostrarProductos(ByVal grid As DataGridView)

        Using base As New dbPruebaBoschEntities

            Dim mostrar = (From q In base.Producto
                           Select Productos = q.nombre, Modelo = q.descripcion, Categoria = q.TipoProducto.descripcion,
                                  Stock = q.stock, Precio = q.precio, Ruta = q.ruta_img).ToList

            grid.DataSource = mostrar
        End Using
    End Sub

    Public Function TraerDatos()
        Try
            Using db As New dbPruebaBoschEntities
                Dim datos = (From q In db.Producto
                                        Select q).First()

                setNombre(datos.nombre)
                setDescripcion(datos.descripcion)
                setPrecio(datos.precio)
                setStock(datos.stock)
                setTipoP(datos.id_tipoProducto)
                setRuta(datos.ruta_img)

            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function VerificarP(ByVal ruta As String)
        Try
            Using db As New dbPruebaBoschEntities
                Dim verif = (From q In db.Producto
                                 Select q Where q.ruta_img = ruta).First()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
