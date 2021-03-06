﻿Public Class Form1
    Dim db As New dbPruebaBoschEntities
    Dim cliente As New C_Cliente
    Dim usuario As New C_Usuario



#Region "Acceso a Paneles de Usuarios"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        Me.AutoScroll = True

        Dim usuario As New C_Usuario(Login.TBUsuario.Text, Login.TBContraseña.Text)

        If usuario.Verificar(usuario.getUsuario, usuario.getContraseña) Then

            Using db As New dbPruebaBoschEntities
                usuario.TraerDatos(usuario.getUsuario)

                If usuario.getTipoUsuario = "Vendedor" Then


                    LabelVendedor.Text = "Vendedor: " & usuario.getNombre & " " & usuario.getApellido
                    PanelVendedor.Visible = True
                    PanelProduc.Visible = True
                    PanelAgregar.Visible = False
                    PanelMostrar.Visible = False


                    PanelAdmin.Visible = False
                    PanelSupervisor.Visible = False

                ElseIf usuario.getTipoUsuario = "Admin" Then

                    LabelAdmin.Text = "Administrador: " & usuario.getNombre & " " & usuario.getApellido
                    PanelAdmin.Visible = True
                    PanelVendedor.Visible = False
                    PanelSupervisor.Visible = False
                    PanelUsuarios.Visible = False
                    PanelCliente.Visible = False
                    PanelPro.Visible = False
                    PanelAdmBotones1.Visible = False
                    PanelAProducto.Visible = False
                    PanelAUsuarios.Visible = False
                    BAVolver.Visible = False
                    Label19.Visible = False

                Else

                    LabelSupervisor.Text = "Supervisor: " & usuario.getNombre & " " & usuario.getApellido
                    Label18.Visible = False
                    PanelSupervisor.Visible = True
                    PanelAdmin.Visible = False
                    PanelVendedor.Visible = False
                    DGVSupervisor.Visible = False
                    BSVolver.Visible = False
                    PanelBotones1.Visible = False
                    PanelBotones2.Visible = False
                    PanelSModifCliente.Visible = False


                End If
            End Using
        End If
    End Sub

    Private Sub BCerrarVendedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCerrarVendedor.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub BCerrarSuper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCerrarSuper.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub BCerrarAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCerrarAdmin.Click
        Login.Show()
        Me.Close()
    End Sub
#End Region

#Region "Panel Vendedor"

#Region "Lista de Clientes"

    Private Sub BListaC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BListaC.Click
        PanelMostrar.Visible = True
        PanelAgregar.Visible = False
        PanelProduc.Visible = False
    End Sub

    Private Sub BMostrar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BMostrar1.Click
        cliente.mostrar(DataGridView1)
    End Sub
#End Region

#Region "Agregar Cliente"
    Private Sub BVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BVolver.Click
        DataGridView1.DataSource = Nothing
        PanelMostrar.Visible = False
    End Sub

    Private Sub BVolver1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BVolver1.Click
        PanelAgregar.Visible = False
    End Sub

    Private Sub TBDni_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBDni.KeyPress
        TBDni.MaxLength = 8
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub BVerificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BVerificar.Click
        Dim repuesta As MsgBoxResult

        If Len(Trim(TBDni.Text)) = 0 Then
            MsgBox("Ingrese Dni del Cliente para su verificación", 0 + 0 + 16, "Error")
        Else

            Dim cliente As New C_Cliente(TBDni.Text)
            If cliente.Verificar(cliente.getDni) Then

                MsgBox("El Cliente ya se encuentra registrado", 0 + 0 + 16, "Error")
                TBDni.Clear()

            Else
                repuesta = MsgBox("El Cliente no se encuentra registrado. ¿Desea registrarlo?", 4 + 256 + 48, "Información")
                If repuesta = 6 Then
                    GroupBox1.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub BAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAgregar.Click
        Dim repuesta As MsgBoxResult

        repuesta = MsgBox("¿Desea registrar un nuevo cliente?", 4 + 256 + 48, "Registrar Cliente")

        If repuesta = 6 Then

            Dim cliente As New C_Cliente(TBDni.Text, TBNombre.Text, TBApellido.Text, TBDireccion.Text,
                                       TBTelefono.Text, DTPNacimiento.Text, TBCorreo.Text)

            cliente.AgregarCliente()
            MsgBox("El Cliente se Registro con éxito")

            GroupBox1.Enabled = False

            TBDni.Clear()
            TBNombre.Clear()
            TBApellido.Clear()
            TBDireccion.Clear()
            TBTelefono.Clear()
            DTPNacimiento.Text = System.DateTime.Today
            TBCorreo.Clear()

        End If
    End Sub

    Private Sub BRegistrarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BRegistrarC.Click
        PanelAgregar.Visible = True
        PanelMostrar.Visible = False
        PanelProduc.Visible = False
        TBDni.Clear()
        GroupBox1.Enabled = False
        BVerificar.Enabled = True
    End Sub
#End Region

#Region "Productos"

    Private Sub BPanelProduc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPanelProduc.Click
        PanelProduc.Visible = True
        PanelMostrar.Visible = False
        PanelAgregar.Visible = False
    End Sub

    Private Sub TBPDni_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBPDni.KeyPress
        TBPDni.MaxLength = 8

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub BPVerificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPVerificar.Click
        Dim repuesta As MsgBoxResult

        If Len(Trim(TBPDni.Text)) = 0 Then
            MsgBox("Ingrese Dni del Cliente para su verificación", 0 + 0 + 16, "Error")
        Else

            Dim cliente As New C_Cliente(TBPDni.Text)
            If cliente.Verificar(cliente.getDni) Then

                MsgBox("El Cliente ya se encuentra registrado", 0 + 0 + 16, "Error")
                'TBPDni.Clear()

            Else
                repuesta = MsgBox("El Cliente no se encuentra registrado. ¿Desea registrarlo?", 4 + 256 + 48, "Información")
                If repuesta = 6 Then
                    PanelProduc.Visible = False
                    PanelAgregar.Visible = True
                    BVerificar.Enabled = False
                    TBDni.Text = TBPDni.Text
                    GroupBox1.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub BVerTodoProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BVerTodoProd.Click
        mostrar()
        'Dim producto As New C_Producto
        'producto.TraerDatos()

        'Dim img As Image


        'producto.mostrarProductos(DGVProd)
        'For Each fila As DataGridViewRow In DGVProd.Rows
        'DGVProd.ColumnHeadersVisible = True
        'DGVProd.Columns("Ruta").Visible = False

        'If Producto.VerificarP(fila.Cells("Ruta").Value) Then

        'Img = Image.FromFile(fila.Cells("Ruta").Value)
        'fila.Cells("Imagen").Value = Img

        'End If

        'Next

    End Sub

    Public Sub mostrar()
        Dim producto As New C_Producto
        producto.TraerDatos()

        Dim img As Image


        producto.mostrarProductos(DGVProd)
        For Each fila As DataGridViewRow In DGVProd.Rows
            DGVProd.ColumnHeadersVisible = True
            DGVProd.Columns("Ruta").Visible = False

            If producto.VerificarP(fila.Cells("Ruta").Value) Then

                img = Image.FromFile(fila.Cells("Ruta").Value)
                fila.Cells("Imagen").Value = img

            End If

        Next
    End Sub

    Private Sub DataGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVProd.CellContentClick

        Dim cell As DataGridViewButtonCell = TryCast(DGVProd.CurrentCell, DataGridViewButtonCell)

        If cell IsNot Nothing Then
            Dim bc As DataGridViewButtonColumn = TryCast(DGVProd.Columns(e.ColumnIndex), DataGridViewButtonColumn)
            If bc IsNot Nothing Then
                Dim s As String = Convert.ToString(cell.Value)
                Select Case bc.Name
                    Case "Agregar"
                        Dim prod As New C_Producto
                        Dim Producto, Modelo, Categoria As String
                        Dim imag As Image
                        Dim cantidad As Integer = 0
                        Dim resta As Integer = 0
                        Dim Precio As Integer
                        Dim stock As Integer = 0


                        imag = DGVProd(1, DGVProd.CurrentRow.Index).Value
                        Producto = DGVProd(2, DGVProd.CurrentRow.Index).Value
                        Modelo = DGVProd(3, DGVProd.CurrentRow.Index).Value
                        Categoria = DGVProd(4, DGVProd.CurrentRow.Index).Value
                        cantidad = 1
                        Precio = DGVProd(6, DGVProd.CurrentRow.Index).Value
                        resta = DGVProd(6, DGVProd.CurrentRow.Index).Value


                        Using base As New dbPruebaBoschEntities
                            Dim consul = (From q In base.Producto
                                          Where q.descripcion = Modelo
                                          Select q).First
                            consul.stock = (consul.stock - 1)
                            base.SaveChanges()
                        End Using

                        mostrar()

                        Dim existe As Boolean = Me.DGVProdAgre.Rows.Cast(Of DataGridViewRow).Any(Function(x) CStr(x.Cells("Modelo").Value) = Modelo)

                        If Not existe Then

                            DGVProdAgre.Rows.Add("", imag, Producto, Modelo, Categoria, cantidad, Precio, resta)

                        Else

                            For Each fila As DataGridViewRow In DGVProdAgre.Rows

                                If fila.Cells("Modelo").Value = Modelo Then

                                    cantidad = Convert.ToInt64(fila.Cells("Cantidad").Value) + 1
                                    fila.Cells("Cantidad").Value = cantidad

                                    fila.Cells("Precio").Value = Precio * cantidad

                                End If
                            Next
                        End If
                        Exit Select
                End Select

            End If
        End If
    End Sub

    Private Sub BBuscarProduc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBuscarProduc.Click
        Dim producto As New C_Producto
        producto.TraerDatos()

        Dim img As Image

        producto.mProductos(DGVProd, CBProductos.Text, CBTipoProd.Text)


        For Each fila As DataGridViewRow In DGVProd.Rows
            DGVProd.ColumnHeadersVisible = True
            DGVProd.Columns("Ruta").Visible = False

            If producto.VerificarP(fila.Cells("Ruta").Value) Then

                img = Image.FromFile(fila.Cells("Ruta").Value)
                fila.Cells("Imagen").Value = img

            End If
        Next
    End Sub

    Private Sub DataGrid_CellContentClick1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVProdAgre.CellContentClick

        Dim cell As DataGridViewButtonCell = TryCast(DGVProdAgre.CurrentCell, DataGridViewButtonCell)

        If cell IsNot Nothing Then
            Dim bc As DataGridViewButtonColumn = TryCast(DGVProdAgre.Columns(e.ColumnIndex), DataGridViewButtonColumn)
            If bc IsNot Nothing Then
                Dim s As String = Convert.ToString(cell.Value)
                Select Case bc.Name
                    Case "Quitar"

                        Dim cantidad As Integer = 0
                        Dim precio As Integer = 0
                        Dim restaPrecio As Integer = 0

                        Dim Modelo As String = DGVProdAgre(3, DGVProdAgre.CurrentRow.Index).Value

                        cantidad = DGVProdAgre(5, DGVProdAgre.CurrentRow.Index).Value - 1
                        DGVProdAgre(5, DGVProdAgre.CurrentRow.Index).Value = cantidad

                        precio = DGVProdAgre(7, DGVProdAgre.CurrentRow.Index).Value
                        restaPrecio = DGVProdAgre(6, DGVProdAgre.CurrentRow.Index).Value

                        DGVProdAgre(6, DGVProdAgre.CurrentRow.Index).Value = restaPrecio - precio


                        If DGVProdAgre(5, DGVProdAgre.CurrentRow.Index).Value = 0 Then
                            DGVProdAgre.Rows.RemoveAt(e.RowIndex)

                        End If

                        Using base As New dbPruebaBoschEntities
                            Dim consul = (From q In base.Producto
                                          Where q.descripcion = Modelo
                                          Select q).First
                            consul.stock = (consul.stock + 1)
                            base.SaveChanges()
                        End Using

                        mostrar()

                        Exit Select
                End Select

            End If
        End If
    End Sub
#End Region
#End Region



#Region "Administrador"

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AdminDGV.CellContentClick





    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerUsuarios.Click
        Label19.Visible = True
        Label19.Text = "GESTION USUARIOS"
        PanelAdmBotones1.Visible = False
        PanelAProducto.Visible = False
        PanelAUsuarios.Visible = True
        BAVolver.Visible = True
        PanelPro.Visible = False
        PanelCliente.Visible = False
        PanelUsuarios.Visible = True
        AdminDGV.ColumnHeadersVisible = True
        AdminDGV.Columns("Imag").Visible = False
        Dim usuario As New C_Usuario

        ComboBox1.SelectedIndex = 0
        usuario.mostrarUsuarios(AdminDGV)

    End Sub

    Private Sub ver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ver.Click
        Label19.Visible = True
        Label19.Text = "GESTION CLIENTE"
        PanelAdmBotones1.Visible = True
        PanelAProducto.Visible = False
        PanelAUsuarios.Visible = False
        BAVolver.Visible = True
        PanelCliente.Visible = True
        PanelUsuarios.Visible = False
        PanelPro.Visible = False
        AdminDGV.ColumnHeadersVisible = True
        AdminDGV.Columns("Imag").Visible = False
        Dim cliente As New C_Cliente

        cliente.mostrarClientes(AdminDGV)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label19.Visible = True
        Label19.Text = "GESTION PRODUCTOS"
        PanelAdmBotones1.Visible = False
        PanelAProducto.Visible = True
        PanelAUsuarios.Visible = False
        BAVolver.Visible = True
        PanelCliente.Visible = False
        PanelUsuarios.Visible = False
        PanelPro.Visible = True
        AdminDGV.Columns("Imag").Visible = True
        Dim producto As New C_Producto
        producto.TraerDatos()

        Dim img As Image


        producto.mostrarProductos(AdminDGV)
        For Each fila As DataGridViewRow In AdminDGV.Rows
            AdminDGV.ColumnHeadersVisible = True
            AdminDGV.Columns("Ruta").Visible = False

            If producto.VerificarP(fila.Cells("Ruta").Value) Then

                img = Image.FromFile(fila.Cells("Ruta").Value)
                fila.Cells("Imag").Value = img

            End If

        Next
    End Sub





















#End Region

#Region "Supervisor"

    Private Sub BSGestionCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSGestionCliente.Click
        Label18.Visible = True
        Label18.Text = "GESTION CLIENTE"
        DGVSupervisor.ColumnHeadersVisible = False
        DGVSupervisor.DataSource = Nothing
        DGVSupervisor.Visible = True
        BSVolver.Visible = True
        PanelBotones1.Visible = True
        PanelBotones2.Visible = False
    End Sub

    Private Sub BSVerCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSVerCliente.Click
        Label18.Text = "LISTA DE CLIENTES"
        PanelSModifCliente.Visible = False
        DGVSupervisor.ColumnHeadersVisible = Visible
        DGVSupervisor.Columns("Imagenes").Visible = False
        cliente.mostrarClientes(DGVSupervisor)
    End Sub

    Private Sub BSVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSVolver.Click
        Label18.Visible = False
        DGVSupervisor.Visible = False
        PanelBotones1.Visible = False
        PanelBotones2.Visible = False
        PanelSModifCliente.Visible = False
        BSVolver.Visible = False
    End Sub

    Private Sub BSVerProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSVerProd.Click
        Label18.Visible = True
        Label18.Text = "LISTA DE PRODUCTOS"
        Dim producto As New C_Producto
        producto.TraerDatos()

        Dim img As Image
        DGVSupervisor.Columns("Imagenes").Visible = True

        producto.mostrarProductos(DGVSupervisor)
        For Each fila As DataGridViewRow In DGVSupervisor.Rows
            DGVSupervisor.ColumnHeadersVisible = True
            DGVSupervisor.Columns("Ruta").Visible = False

            If producto.VerificarP(fila.Cells("Ruta").Value) Then

                img = Image.FromFile(fila.Cells("Ruta").Value)
                fila.Cells("Imagenes").Value = img

            End If

        Next
    End Sub

    Private Sub BSGestionProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSGestionProd.Click
        Label18.Visible = True
        Label18.Text = "GESTION PRODUCTOS"
        DGVSupervisor.ColumnHeadersVisible = False
        DGVSupervisor.DataSource = Nothing
        DGVSupervisor.Visible = True
        PanelBotones2.Visible = True
        PanelBotones1.Visible = False
        PanelSModifCliente.Visible = False
        BSVolver.Visible = True
    End Sub

    Private Sub TBSDni_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBSDni.KeyPress
        TBSDni.MaxLength = 8
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub BSModifCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSModifCliente.Click
        Label18.Text = "MODIFICAR CLIENTE"
        PanelSModifCliente.Visible = True
    End Sub

    Private Sub BSCancelarAltaCli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSCancelarAltaCli.Click
        GroupBox2.Enabled = False

        TBSDni.Clear()
        TBSNomCliente.Clear()
        TBSApeCliente.Clear()
        TBSDirCliente.Clear()
        TBSTelCliente.Clear()
        DTPSNacCliente.Text = System.DateTime.Today
        TBSCorreoCliente.Clear()
    End Sub

    Private Sub BSVerificarClente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSVerificarClente.Click
        If Len(Trim(TBSDni.Text)) = 0 Then
            MsgBox("Ingrese Dni del Cliente para su verificación", 0 + 0 + 16, "Error")

        Else

            Dim cliente As New C_Cliente(TBSDni.Text)
            If cliente.Verificar(cliente.getDni) Then
                Try
                    Using db As New dbPruebaBoschEntities
                        cliente.TraerDatos(cliente.getDni)

                        GroupBox2.Enabled = True

                        TBSNomCliente.Text = cliente.getNombre
                        TBSApeCliente.Text = cliente.getApellido
                        TBSDirCliente.Text = cliente.getDireccion
                        TBSTelCliente.Text = cliente.getTelefono
                        DTPSNacCliente.Text = cliente.getNacimiento
                        TBSCorreoCliente.Text = cliente.getCorreo
                    End Using
                Catch ex As Exception
                    MsgBox("Error al cargar los datos", 0 + 0 + 16, "Error")
                End Try

            Else
                MsgBox("El Cliente no se encuentra registrado", 0 + 0 + 16, "Error")
                TBSDni.Clear()
            End If
        End If
    End Sub
#End Region

    Private Sub TBNombreCliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBDniCliente.KeyPress
        If e.KeyChar = Chr(13) Then

            Dim dni As Integer
            dni = TBDniCliente.Text
            cliente.mostrarPorDni(AdminDGV, dni)

        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged


        Dim item = ComboBox1.SelectedItem.ToString

        usuario.mostrarPorTipo(AdminDGV, item)


    End Sub

    Private Sub BAVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAVolver.Click
        Label19.Visible = False
        'AdminDGV.Visible = False
        PanelAdmBotones1.Visible = False
        PanelAProducto.Visible = False
        PanelAUsuarios.Visible = False
        BAVolver.Visible = False
        PanelUsuarios.Visible = False
        PanelCliente.Visible = False
        AdminDGV.DataSource = Nothing
    End Sub
End Class