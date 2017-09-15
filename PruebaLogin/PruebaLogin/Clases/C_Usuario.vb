Public Class C_Usuario
    Private usuario As String
    Private contraseña As String
    Private nom As String
    Private ape As String
    Private tipoUser As String
    Private nacimiento As String
    Private correo As String

    Public Sub New(ByVal user As String, ByVal pass As String, ByVal nombre As String, ByVal apellido As String,
                   ByVal tipoUser As String, ByVal fechaNacimiento As String, ByVal correo As String)

        setUsuario(user)
        setContraseña(pass)
        setNombre(nombre)
        setApellido(apellido)
        setTipoUsuario(tipoUser)
        setNacimiento(fechaNacimiento)
        setCorreo(correo)

    End Sub

    Public Sub New(ByVal user As String, ByVal pass As String)

        setUsuario(user)
        setContraseña(pass)
        setNombre("")
        setApellido("")
        setTipoUsuario("")
        setNacimiento("")
        setCorreo("")

    End Sub

    Public Sub New()

    End Sub

    'SET

    Sub setUsuario(ByVal user As String)
        Me.usuario = user
    End Sub

    Sub setContraseña(ByVal pass As String)
        Me.contraseña = pass
    End Sub

    Sub setNombre(ByVal nombre As String)
        Me.nom = nombre
    End Sub

    Sub setApellido(ByVal apellido As String)
        Me.ape = apellido
    End Sub

    Sub setTipoUsuario(ByVal tipoUser As String)
        Me.tipoUser = tipoUser
    End Sub

    Sub setNacimiento(ByVal fechaNacimiento As String)
        Me.nacimiento = fechaNacimiento
    End Sub

    Sub setCorreo(ByVal correo As String)
        Me.correo = correo
    End Sub

    'GET

    Public Function getUsuario()
        Return Me.usuario
    End Function

    Public Function getContraseña()
        Return Me.contraseña
    End Function

    Public Function getNombre()
        Return Me.nom
    End Function

    Public Function getApellido()
        Return Me.ape
    End Function

    Public Function getTipoUsuario()
        Return Me.tipoUser
    End Function

    Public Function getNacimiento()
        Return Me.nacimiento
    End Function

    Public Function getCorreo()
        Return Me.correo
    End Function

    Public Function TraerDatos(ByVal user As String)
        Try
            Using db As New dbBoschEntities
                Dim datos = (From q In db.Usuario
                                        Select q Where user = q.id).First()

                setUsuario(datos.id)
                setContraseña(datos.pass)
                setNombre(datos.nombre)
                setApellido(datos.apellido)
                setTipoUsuario(datos.tipoUsuario)
                setNacimiento(datos.fechaNacimiento)
                setCorreo(datos.mail)

            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Verificar(ByVal user As String, ByVal pass As String)
        Try
            Using db As New dbBoschEntities
                Dim verif = (From q In db.Usuario
                                 Select q Where q.id = user And q.pass = pass).First()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
