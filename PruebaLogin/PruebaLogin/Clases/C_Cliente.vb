Public Class C_Cliente
    Private dni As Integer
    Private nom As String
    Private ape As String
    Private direc As String
    Private tel As String
    Private nacimiento As String
    Private correo As String

    Public Sub New(ByVal dni As Integer, ByVal nombre As String, ByVal apellido As String, ByVal direccion As String,
                   ByVal telefono As String, ByVal fechaNacimiento As String, ByVal correo As String)

        setDni(dni)
        setNombre(nombre)
        setApellido(apellido)
        setDireccion(direccion)
        setTelefono(telefono)
        setNacimiento(fechaNacimiento)
        setCorreo(correo)

    End Sub

    Public Sub New(ByVal dni As Integer)
        setDni(dni)
        setNombre("")
        setApellido("")
        setDireccion("")
        setTelefono("")
        setNacimiento("")
        setCorreo("")
    End Sub

    Public Sub New()

    End Sub

#Region "SET"

    Sub setDni(ByVal dni As Integer)
        Me.dni = dni
    End Sub

    Sub setNombre(ByVal nombre As String)
        Me.nom = nombre
    End Sub

    Sub setApellido(ByVal apellido As String)
        Me.ape = apellido
    End Sub

    Sub setDireccion(ByVal direccion As String)
        Me.direc = direccion
    End Sub

    Sub setTelefono(ByVal telefono As String)
        Me.tel = telefono
    End Sub

    Sub setNacimiento(ByVal fechaNacimiento As String)
        Me.nacimiento = fechaNacimiento
    End Sub

    Sub setCorreo(ByVal correo As String)
        Me.correo = correo
    End Sub

#End Region

#Region "GET"
    Public Function getDni()
        Return Me.dni
    End Function

    Public Function getNombre()
        Return Me.nom
    End Function

    Public Function getApellido()
        Return Me.ape
    End Function

    Public Function getDireccion()
        Return Me.direc
    End Function

    Public Function getTelefono()
        Return Me.tel
    End Function

    Public Function getNacimiento()
        Return Me.nacimiento
    End Function

    Public Function getCorreo()
        Return Me.correo
    End Function

#End Region

    'Metodo Mostrar Clientes
    Public Sub mostrar(ByVal grid As DataGridView)
        Using base As New dbBoschEntities
            Dim mostrar = (From q In base.Cliente Select q).ToList
            grid.DataSource = mostrar
        End Using
    End Sub

    'Metodo Agregar Cliente
    Public Function AgregarCliente() As Boolean
        Try
            Using db As New dbBoschEntities
                Dim cliente As New C_Cliente

                With cliente
                    .dni_cliente = Me.getDni
                    .nombre = Me.getNombre
                    .apellido = Me.getApellido
                    .direccion = Me.getDireccion
                    .telefono = Me.getTelefono
                    .fechaNacimiento = Me.getNacimiento
                    .mail = Me.getCorreo
                End With

                db.Cliente.AddObject(cliente)
                db.SaveChanges()
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub Eliminar(ByVal dni As Integer)
        Try
            Using db As New dbBoschEntities
                Dim borrar = (From q In db.Cliente
                            Select q Where q.dni_cliente = dni).First()

                db.Cliente.DeleteObject(borrar)
                db.SaveChanges()

            End Using
        Catch ex As Exception
            MessageBox.Show("Error al eliminar")
        End Try
    End Sub

    Public Function TraerDatos(ByVal dni As Integer)
        Try
            Using db As New dbBoschEntities
                Dim datos = (From q In db.Cliente
                                        Select q Where dni = q.dni_cliente).First()

                setDni(datos.dni_cliente)
                setNombre(datos.nombre)
                setApellido(datos.apellido)
                setDireccion(datos.direccion)
                setTelefono(datos.telefono)
                setNacimiento(datos.fechaNacimiento)
                setCorreo(datos.mail)

            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Verificar(ByVal dni As Integer)
        Try
            Using db As New dbBoschEntities
                Dim verif = (From q In db.Cliente
                                 Select q Where q.dni_cliente = dni).First()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
