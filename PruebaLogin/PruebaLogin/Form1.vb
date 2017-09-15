Public Class Form1
    Dim db As New dbBoschEntities
    Dim cliente As New C_Cliente

#Region "Acceso a Paneles de Usuarios"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.HorizontalScroll.Visible = False
        Me.HorizontalScroll.Enabled = False
        Me.AutoScroll = True

        Dim usuario As New C_Usuario(Login.TBUsuario.Text, Login.TBContraseña.Text)

        If usuario.Verificar(usuario.getUsuario, usuario.getContraseña) Then

            Using db As New dbBoschEntities
                usuario.TraerDatos(usuario.getUsuario)

                If usuario.getTipoUsuario = "Vendedor" Then


                    LabelVendedor.Text = "Vendedor: " & usuario.getNombre & " " & usuario.getApellido
                    PanelVendedor.Visible = True
                    PanelProduc.Visible = True
                    PanelAgregar.Visible = False
                    PanelMostrar.Visible = False
                    PanelEliminar.Visible = False


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
        PanelEliminar.Visible = False
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
        PanelEliminar.Visible = False
        PanelProduc.Visible = False
    End Sub
#End Region

#Region "Productos"
    Private Sub TBEliDni_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBEliDni.KeyPress
        TBEliDni.MaxLength = 8

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

    Private Sub BEliVerificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEliVerificar.Click
        If Len(Trim(TBEliDni.Text)) = 0 Then
            MsgBox("Ingrese Dni del Cliente para su verificación", 0 + 0 + 16, "Error")

        Else

            Dim cliente As New C_Cliente(TBEliDni.Text)
            If cliente.Verificar(cliente.getDni) Then
                Try
                    Using db As New dbBoschEntities
                        cliente.TraerDatos(cliente.getDni)

                        GroupBox2.Enabled = True

                        TBEliNombre.Text = cliente.getNombre
                        TBEliApellido.Text = cliente.getApellido
                        TBEliDirec.Text = cliente.getDireccion
                        TBEliTelefono.Text = cliente.getTelefono
                        DTPEliFecha.Text = cliente.getNacimiento
                        TBEliCorreo.Text = cliente.getCorreo
                    End Using
                Catch ex As Exception
                    MsgBox("Error al cargar los datos", 0 + 0 + 16, "Error")
                End Try

            Else
                MsgBox("El Cliente no se encuentra registrado", 0 + 0 + 16, "Error")
                TBEliDni.Clear()
            End If
        End If
    End Sub

    Private Sub BEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEliminar.Click
        Dim repuesta As MsgBoxResult

        repuesta = MsgBox("¿Desea eliminar al Cliente?", 4 + 256 + 48, "Eliminar Cliente")

        If repuesta = 6 Then
            Dim cliente As New C_Cliente(TBEliDni.Text)

            cliente.Eliminar(cliente.getDni)

            MsgBox("El Cliente ha sido eliminado con éxito", 0 + 0 + 64, "Eliminar Cliente")

            GroupBox2.Enabled = False

            TBEliDni.Clear()
            TBEliNombre.Clear()
            TBEliApellido.Clear()
            TBEliDirec.Clear()
            TBEliTelefono.Clear()
            DTPEliFecha.Text = System.DateTime.Today
            TBEliCorreo.Clear()
        End If
    End Sub

    Private Sub BEliVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEliVolver.Click
        PanelEliminar.Visible = False
    End Sub

    Private Sub BPanelProduc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPanelProduc.Click
        PanelProduc.Visible = True
        PanelEliminar.Visible = False
        PanelMostrar.Visible = False
        PanelAgregar.Visible = False
    End Sub


#End Region
#End Region

   
End Class