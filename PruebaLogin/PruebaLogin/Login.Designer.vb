<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBContraseña = New System.Windows.Forms.TextBox()
        Me.TBUsuario = New System.Windows.Forms.TextBox()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.BIngresar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TBContraseña)
        Me.GroupBox1.Controls.Add(Me.TBUsuario)
        Me.GroupBox1.Controls.Add(Me.BSalir)
        Me.GroupBox1.Controls.Add(Me.BIngresar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Location = New System.Drawing.Point(160, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(321, 222)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Iniciar Sesión"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Usuario"
        '
        'TBContraseña
        '
        Me.TBContraseña.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TBContraseña.Location = New System.Drawing.Point(61, 129)
        Me.TBContraseña.Name = "TBContraseña"
        Me.TBContraseña.Size = New System.Drawing.Size(202, 26)
        Me.TBContraseña.TabIndex = 3
        Me.TBContraseña.UseSystemPasswordChar = True
        '
        'TBUsuario
        '
        Me.TBUsuario.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TBUsuario.Location = New System.Drawing.Point(61, 57)
        Me.TBUsuario.Name = "TBUsuario"
        Me.TBUsuario.Size = New System.Drawing.Size(202, 26)
        Me.TBUsuario.TabIndex = 2
        '
        'BSalir
        '
        Me.BSalir.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BSalir.FlatAppearance.BorderSize = 0
        Me.BSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BSalir.Location = New System.Drawing.Point(196, 180)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(82, 33)
        Me.BSalir.TabIndex = 1
        Me.BSalir.Text = "Salir"
        Me.BSalir.UseVisualStyleBackColor = False
        '
        'BIngresar
        '
        Me.BIngresar.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BIngresar.FlatAppearance.BorderSize = 0
        Me.BIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BIngresar.Location = New System.Drawing.Point(46, 180)
        Me.BIngresar.Name = "BIngresar"
        Me.BIngresar.Size = New System.Drawing.Size(82, 33)
        Me.BIngresar.TabIndex = 0
        Me.BIngresar.Text = "Ingresar"
        Me.BIngresar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.PruebaLogin.My.Resources.Resources.Bosch
        Me.PictureBox1.Location = New System.Drawing.Point(1, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 156)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(492, 241)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BSalir As System.Windows.Forms.Button
    Friend WithEvents BIngresar As System.Windows.Forms.Button
    Friend WithEvents TBContraseña As System.Windows.Forms.TextBox
    Friend WithEvents TBUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
