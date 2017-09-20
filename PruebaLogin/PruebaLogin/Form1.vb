Public Class Form1
    Dim db As New dbPruebaBoschEntities
    Dim cliente As New C_Cliente

#Region "Acceso a Paneles de Usuarios"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.HorizontalScroll.Visible = False
        Me.HorizontalScroll.Enabled = False
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

                Else

                    LabelSupervisor.Text = "Supervisor: " & usuario.getNombre & " " & usuario.getApellido
                    PanelSupervisor.Visible = True
                    PanelAdmin.Visible = False
                    PanelVendedor.Visible = False

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
                TBPDni.Clear()

            Else
                repuesta = MsgBox("El Cliente no se encuentra registrado. ¿Desea registrarlo?", 4 + 256 + 48, "Información")
                If repuesta = 6 Then
                    PanelProduc.Visible = False
                    PanelAgregar.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub BVerTodoProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BVerTodoProd.Click

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
        'Dim respuesta As MsgBoxResult
        Dim cell As DataGridViewButtonCell = TryCast(DGVProd.CurrentCell, DataGridViewButtonCell)

        If cell IsNot Nothing Then
            Dim bc As DataGridViewButtonColumn = TryCast(DGVProd.Columns(e.ColumnIndex), DataGridViewButtonColumn)
            If bc IsNot Nothing Then
                Dim s As String = Convert.ToString(cell.Value)
                Select Case bc.Name
                    Case "Agregar"
                        'DataGrid.Rows.RemoveAt(e.RowIndex)
                        'respuesta = MsgBox("¿Desea Eliminar este registro?", 4 + 256 + 48, "Confirmar Eliminación")
                        'Valor de retorno 6 = vbYes
                        'If respuesta = 6 Then

                        'Dim i As Integer
                        'i = DataGrid.CurrentRow.Index
                        'DataGrid.Rows.RemoveAt(i)
                        Dim Producto, Modelo, Categoria, Stock, Precio As String
                        Dim imag As Image

                        imag = DGVProd(1, DGVProd.CurrentRow.Index).Value
                        Producto = DGVProd(2, DGVProd.CurrentRow.Index).Value
                        Modelo = DGVProd(3, DGVProd.CurrentRow.Index).Value
                        Categoria = DGVProd(4, DGVProd.CurrentRow.Index).Value
                        Stock = DGVProd(5, DGVProd.CurrentRow.Index).Value
                        Precio = DGVProd(6, DGVProd.CurrentRow.Index).Value



                        DGVProdAgre.Rows.Add("", imag, Producto, Modelo, Categoria, Stock, Precio)
                        'MsgBox("El registro se eliminó correctamente", 0 + 0 + 64, "Eliminar")

                        'End If
                        Exit Select
                End Select

            End If
        End If




    End Sub

#End Region
#End Region



#Region "Administrador"

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AdminDGVUsuario.CellContentClick





    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerUsuarios.Click
        AdminDGVUsuario.ColumnHeadersVisible = True
        AdminDGVUsuario.Columns("Imag").Visible = False
        Dim usuario As New C_Usuario

        usuario.mostrarUsuarios(AdminDGVUsuario)

    End Sub

    Private Sub ver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ver.Click
        AdminDGVUsuario.ColumnHeadersVisible = True
        AdminDGVUsuario.Columns("Imag").Visible = False
        Dim cliente As New C_Cliente

        cliente.mostrarClientes(AdminDGVUsuario)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        AdminDGVUsuario.Columns("Imag").Visible = True
        Dim producto As New C_Producto
        producto.TraerDatos()

        Dim img As Image


        producto.mostrarProductos(AdminDGVUsuario)
        For Each fila As DataGridViewRow In AdminDGVUsuario.Rows
            AdminDGVUsuario.ColumnHeadersVisible = True
            AdminDGVUsuario.Columns("Ruta").Visible = False

            If producto.VerificarP(fila.Cells("Ruta").Value) Then

                img = Image.FromFile(fila.Cells("Ruta").Value)
                fila.Cells("Imag").Value = img

            End If

        Next
    End Sub





















#End Region





    
    
End Class