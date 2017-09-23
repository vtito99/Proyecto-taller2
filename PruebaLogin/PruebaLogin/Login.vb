Public Class Login

    Private Sub BSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSalir.Click
        BarraCarga.Close()
        Me.Close()

        'End
        'Application.Exit()

    End Sub

    Private Sub TBUsuario_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBUsuario.KeyPress

        TBUsuario.MaxLength = 16

        If Char.IsLetterOrDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TBContraseña_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBContraseña.KeyPress

        'TBContraseña.UseSystemPasswordChar = True

        If Char.IsLetterOrDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub BIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BIngresar.Click
        Dim usuario As New C_Usuario(TBUsuario.Text, TBContraseña.Text)
        If usuario.Verificar(usuario.getUsuario, usuario.getContraseña) Then
            'Try
            Using db As New dbPruebaBoschEntities
                usuario.TraerDatos(usuario.getUsuario)

                If (usuario.getTipoUsuario = "Vendedor") Then

                    MsgBox("vendedor")
                    Form1.Show()
                    Me.Close()

                ElseIf (usuario.getTipoUsuario = "Admin") Then

                    MsgBox("admin")
                    Form1.Show()
                    Me.Close()

                Else

                    MsgBox("supervisor")
                    Form1.Show()
                    Me.Close()

                End If

            End Using
        Else
            MsgBox("Usuario no registrado", 0 + 0 + 16, "Error")
        End If
    End Sub
End Class
