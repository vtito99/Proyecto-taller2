<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PanelVendedor = New System.Windows.Forms.Panel()
        Me.PanelProduc = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DGVProdAgre = New System.Windows.Forms.DataGridView()
        Me.Quitar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Img = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Productos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BVerTodoProd = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BPVerificar = New System.Windows.Forms.Button()
        Me.TBPDni = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BPContinuar = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BBuscarProduc = New System.Windows.Forms.Button()
        Me.TBBProd = New System.Windows.Forms.TextBox()
        Me.DGVProd = New System.Windows.Forms.DataGridView()
        Me.Agregar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Imagen = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PanelAgregar = New System.Windows.Forms.Panel()
        Me.BVolver1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DTPNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.TBCorreo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBTelefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBDireccion = New System.Windows.Forms.TextBox()
        Me.TBApellido = New System.Windows.Forms.TextBox()
        Me.BVerificar = New System.Windows.Forms.Button()
        Me.TBDni = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.BPanelProduc = New System.Windows.Forms.Button()
        Me.BRegistrarC = New System.Windows.Forms.Button()
        Me.PanelMostrar = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.BMostrar1 = New System.Windows.Forms.Button()
        Me.BListaC = New System.Windows.Forms.Button()
        Me.BCerrarVendedor = New System.Windows.Forms.Button()
        Me.LabelVendedor = New System.Windows.Forms.Label()
        Me.PanelAdmin = New System.Windows.Forms.Panel()
        Me.LabelAdmin = New System.Windows.Forms.Label()
        Me.BCerrarAdmin = New System.Windows.Forms.Button()
        Me.PanelSupervisor = New System.Windows.Forms.Panel()
        Me.BCerrarSuper = New System.Windows.Forms.Button()
        Me.LabelSupervisor = New System.Windows.Forms.Label()
        Me.PanelVendedor.SuspendLayout()
        Me.PanelProduc.SuspendLayout()
        CType(Me.DGVProdAgre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGVProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAgregar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PanelMostrar.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAdmin.SuspendLayout()
        Me.PanelSupervisor.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelVendedor
        '
        Me.PanelVendedor.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PanelVendedor.Controls.Add(Me.PanelProduc)
        Me.PanelVendedor.Controls.Add(Me.PanelAgregar)
        Me.PanelVendedor.Controls.Add(Me.BPanelProduc)
        Me.PanelVendedor.Controls.Add(Me.BRegistrarC)
        Me.PanelVendedor.Controls.Add(Me.PanelMostrar)
        Me.PanelVendedor.Controls.Add(Me.BListaC)
        Me.PanelVendedor.Controls.Add(Me.BCerrarVendedor)
        Me.PanelVendedor.Controls.Add(Me.LabelVendedor)
        Me.PanelVendedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelVendedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelVendedor.Name = "PanelVendedor"
        Me.PanelVendedor.Size = New System.Drawing.Size(974, 582)
        Me.PanelVendedor.TabIndex = 0
        '
        'PanelProduc
        '
        Me.PanelProduc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelProduc.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelProduc.Controls.Add(Me.Label17)
        Me.PanelProduc.Controls.Add(Me.DGVProdAgre)
        Me.PanelProduc.Controls.Add(Me.BVerTodoProd)
        Me.PanelProduc.Controls.Add(Me.ComboBox1)
        Me.PanelProduc.Controls.Add(Me.GroupBox3)
        Me.PanelProduc.Controls.Add(Me.BPContinuar)
        Me.PanelProduc.Controls.Add(Me.Label16)
        Me.PanelProduc.Controls.Add(Me.BBuscarProduc)
        Me.PanelProduc.Controls.Add(Me.TBBProd)
        Me.PanelProduc.Controls.Add(Me.DGVProd)
        Me.PanelProduc.Location = New System.Drawing.Point(117, 17)
        Me.PanelProduc.Name = "PanelProduc"
        Me.PanelProduc.Size = New System.Drawing.Size(698, 750)
        Me.PanelProduc.TabIndex = 10
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(15, 415)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(109, 13)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Productos Agregados"
        '
        'DGVProdAgre
        '
        Me.DGVProdAgre.AllowUserToAddRows = False
        Me.DGVProdAgre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVProdAgre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVProdAgre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProdAgre.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Quitar, Me.Img, Me.Productos, Me.Modelo, Me.Categoria, Me.Stock, Me.Precio})
        Me.DGVProdAgre.Location = New System.Drawing.Point(16, 437)
        Me.DGVProdAgre.Name = "DGVProdAgre"
        Me.DGVProdAgre.Size = New System.Drawing.Size(666, 243)
        Me.DGVProdAgre.TabIndex = 28
        '
        'Quitar
        '
        Me.Quitar.DataPropertyName = "Quitar"
        Me.Quitar.HeaderText = "Quitar"
        Me.Quitar.Name = "Quitar"
        Me.Quitar.Text = "Quitar"
        Me.Quitar.ToolTipText = "Quitar"
        Me.Quitar.UseColumnTextForButtonValue = True
        '
        'Img
        '
        Me.Img.HeaderText = "Img"
        Me.Img.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Img.Name = "Img"
        Me.Img.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Img.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Productos
        '
        Me.Productos.HeaderText = "Productos"
        Me.Productos.Name = "Productos"
        '
        'Modelo
        '
        Me.Modelo.HeaderText = "Modelo"
        Me.Modelo.Name = "Modelo"
        '
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        '
        'Stock
        '
        Me.Stock.HeaderText = "Stock"
        Me.Stock.Name = "Stock"
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        '
        'BVerTodoProd
        '
        Me.BVerTodoProd.Location = New System.Drawing.Point(413, 125)
        Me.BVerTodoProd.Name = "BVerTodoProd"
        Me.BVerTodoProd.Size = New System.Drawing.Size(79, 40)
        Me.BVerTodoProd.TabIndex = 27
        Me.BVerTodoProd.Text = "Ver Todos"
        Me.BVerTodoProd.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(231, 137)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 26
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.BPVerificar)
        Me.GroupBox3.Controls.Add(Me.TBPDni)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Location = New System.Drawing.Point(100, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(443, 89)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Verificar Cliente"
        '
        'BPVerificar
        '
        Me.BPVerificar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BPVerificar.Location = New System.Drawing.Point(286, 26)
        Me.BPVerificar.Name = "BPVerificar"
        Me.BPVerificar.Size = New System.Drawing.Size(93, 34)
        Me.BPVerificar.TabIndex = 19
        Me.BPVerificar.Text = "Verificar Cliente"
        Me.BPVerificar.UseVisualStyleBackColor = True
        '
        'TBPDni
        '
        Me.TBPDni.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TBPDni.Location = New System.Drawing.Point(98, 33)
        Me.TBPDni.Name = "TBPDni"
        Me.TBPDni.Size = New System.Drawing.Size(154, 20)
        Me.TBPDni.TabIndex = 17
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(63, 36)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 13)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "DNI"
        '
        'BPContinuar
        '
        Me.BPContinuar.Location = New System.Drawing.Point(280, 700)
        Me.BPContinuar.Name = "BPContinuar"
        Me.BPContinuar.Size = New System.Drawing.Size(93, 34)
        Me.BPContinuar.TabIndex = 24
        Me.BPContinuar.Text = "Continuar"
        Me.BPContinuar.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 140)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 13)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Productos"
        '
        'BBuscarProduc
        '
        Me.BBuscarProduc.BackColor = System.Drawing.Color.Transparent
        Me.BBuscarProduc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BBuscarProduc.Image = Global.PruebaLogin.My.Resources.Resources.lupa2
        Me.BBuscarProduc.Location = New System.Drawing.Point(362, 125)
        Me.BBuscarProduc.Name = "BBuscarProduc"
        Me.BBuscarProduc.Size = New System.Drawing.Size(45, 40)
        Me.BBuscarProduc.TabIndex = 23
        Me.BBuscarProduc.UseVisualStyleBackColor = False
        '
        'TBBProd
        '
        Me.TBBProd.Location = New System.Drawing.Point(71, 137)
        Me.TBBProd.Name = "TBBProd"
        Me.TBBProd.Size = New System.Drawing.Size(154, 20)
        Me.TBBProd.TabIndex = 21
        '
        'DGVProd
        '
        Me.DGVProd.AllowUserToAddRows = False
        Me.DGVProd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVProd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DGVProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProd.ColumnHeadersVisible = False
        Me.DGVProd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Agregar, Me.Imagen})
        Me.DGVProd.Location = New System.Drawing.Point(16, 167)
        Me.DGVProd.MinimumSize = New System.Drawing.Size(0, 200)
        Me.DGVProd.Name = "DGVProd"
        Me.DGVProd.RowTemplate.Height = 50
        Me.DGVProd.Size = New System.Drawing.Size(666, 243)
        Me.DGVProd.TabIndex = 20
        '
        'Agregar
        '
        Me.Agregar.DataPropertyName = "Agregar"
        Me.Agregar.HeaderText = "Agregar"
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Text = "Agregar"
        Me.Agregar.ToolTipText = "Agregar"
        Me.Agregar.UseColumnTextForButtonValue = True
        '
        'Imagen
        '
        Me.Imagen.HeaderText = "Imagen"
        Me.Imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Imagen.Name = "Imagen"
        Me.Imagen.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Imagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'PanelAgregar
        '
        Me.PanelAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelAgregar.Controls.Add(Me.BVolver1)
        Me.PanelAgregar.Controls.Add(Me.Label1)
        Me.PanelAgregar.Controls.Add(Me.GroupBox1)
        Me.PanelAgregar.Controls.Add(Me.BVerificar)
        Me.PanelAgregar.Controls.Add(Me.TBDni)
        Me.PanelAgregar.Controls.Add(Me.ShapeContainer1)
        Me.PanelAgregar.Location = New System.Drawing.Point(138, 18)
        Me.PanelAgregar.Name = "PanelAgregar"
        Me.PanelAgregar.Size = New System.Drawing.Size(596, 374)
        Me.PanelAgregar.TabIndex = 5
        '
        'BVolver1
        '
        Me.BVolver1.Location = New System.Drawing.Point(464, 332)
        Me.BVolver1.Name = "BVolver1"
        Me.BVolver1.Size = New System.Drawing.Size(93, 33)
        Me.BVolver1.TabIndex = 14
        Me.BVolver1.Text = "Volver"
        Me.BVolver1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "DNI"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DTPNacimiento)
        Me.GroupBox1.Controls.Add(Me.TBNombre)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.BAgregar)
        Me.GroupBox1.Controls.Add(Me.TBCorreo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TBTelefono)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TBDireccion)
        Me.GroupBox1.Controls.Add(Me.TBApellido)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(42, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 235)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo Cliente"
        '
        'DTPNacimiento
        '
        Me.DTPNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPNacimiento.Location = New System.Drawing.Point(129, 75)
        Me.DTPNacimiento.Name = "DTPNacimiento"
        Me.DTPNacimiento.Size = New System.Drawing.Size(127, 20)
        Me.DTPNacimiento.TabIndex = 13
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(64, 30)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(183, 20)
        Me.TBNombre.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Correo"
        '
        'BAgregar
        '
        Me.BAgregar.Location = New System.Drawing.Point(193, 189)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(93, 34)
        Me.BAgregar.TabIndex = 0
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.UseVisualStyleBackColor = True
        '
        'TBCorreo
        '
        Me.TBCorreo.Location = New System.Drawing.Point(75, 155)
        Me.TBCorreo.Name = "TBCorreo"
        Me.TBCorreo.Size = New System.Drawing.Size(197, 20)
        Me.TBCorreo.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'TBTelefono
        '
        Me.TBTelefono.Location = New System.Drawing.Point(326, 75)
        Me.TBTelefono.Name = "TBTelefono"
        Me.TBTelefono.Size = New System.Drawing.Size(134, 20)
        Me.TBTelefono.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(260, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Fecha de Nacimiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Dirección"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(271, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Teléfono"
        '
        'TBDireccion
        '
        Me.TBDireccion.Location = New System.Drawing.Point(75, 115)
        Me.TBDireccion.Name = "TBDireccion"
        Me.TBDireccion.Size = New System.Drawing.Size(307, 20)
        Me.TBDireccion.TabIndex = 6
        '
        'TBApellido
        '
        Me.TBApellido.Location = New System.Drawing.Point(310, 30)
        Me.TBApellido.Name = "TBApellido"
        Me.TBApellido.Size = New System.Drawing.Size(183, 20)
        Me.TBApellido.TabIndex = 3
        '
        'BVerificar
        '
        Me.BVerificar.Location = New System.Drawing.Point(400, 16)
        Me.BVerificar.Name = "BVerificar"
        Me.BVerificar.Size = New System.Drawing.Size(93, 34)
        Me.BVerificar.TabIndex = 16
        Me.BVerificar.Text = "Verificar"
        Me.BVerificar.UseVisualStyleBackColor = True
        '
        'TBDni
        '
        Me.TBDni.Location = New System.Drawing.Point(154, 24)
        Me.TBDni.Name = "TBDni"
        Me.TBDni.Size = New System.Drawing.Size(154, 20)
        Me.TBDni.TabIndex = 14
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(596, 374)
        Me.ShapeContainer1.TabIndex = 18
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 50
        Me.LineShape1.X2 = 549
        Me.LineShape1.Y1 = 67
        Me.LineShape1.Y2 = 67
        '
        'BPanelProduc
        '
        Me.BPanelProduc.Location = New System.Drawing.Point(13, 129)
        Me.BPanelProduc.Name = "BPanelProduc"
        Me.BPanelProduc.Size = New System.Drawing.Size(95, 33)
        Me.BPanelProduc.TabIndex = 9
        Me.BPanelProduc.Text = "Ver Productos"
        Me.BPanelProduc.UseVisualStyleBackColor = True
        '
        'BRegistrarC
        '
        Me.BRegistrarC.Location = New System.Drawing.Point(12, 90)
        Me.BRegistrarC.Name = "BRegistrarC"
        Me.BRegistrarC.Size = New System.Drawing.Size(96, 33)
        Me.BRegistrarC.TabIndex = 7
        Me.BRegistrarC.Text = "Registrar"
        Me.BRegistrarC.UseVisualStyleBackColor = True
        '
        'PanelMostrar
        '
        Me.PanelMostrar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelMostrar.Controls.Add(Me.DataGridView1)
        Me.PanelMostrar.Controls.Add(Me.BVolver)
        Me.PanelMostrar.Controls.Add(Me.BMostrar1)
        Me.PanelMostrar.Location = New System.Drawing.Point(138, 17)
        Me.PanelMostrar.Name = "PanelMostrar"
        Me.PanelMostrar.Size = New System.Drawing.Size(596, 375)
        Me.PanelMostrar.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 14)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(563, 303)
        Me.DataGridView1.TabIndex = 0
        '
        'BVolver
        '
        Me.BVolver.Location = New System.Drawing.Point(298, 334)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(103, 34)
        Me.BVolver.TabIndex = 4
        Me.BVolver.Text = "Volver"
        Me.BVolver.UseVisualStyleBackColor = True
        '
        'BMostrar1
        '
        Me.BMostrar1.Location = New System.Drawing.Point(173, 334)
        Me.BMostrar1.Name = "BMostrar1"
        Me.BMostrar1.Size = New System.Drawing.Size(103, 35)
        Me.BMostrar1.TabIndex = 1
        Me.BMostrar1.Text = "Mostrar"
        Me.BMostrar1.UseVisualStyleBackColor = True
        '
        'BListaC
        '
        Me.BListaC.Location = New System.Drawing.Point(13, 51)
        Me.BListaC.Name = "BListaC"
        Me.BListaC.Size = New System.Drawing.Size(95, 33)
        Me.BListaC.TabIndex = 2
        Me.BListaC.Text = "Lista de Clientes"
        Me.BListaC.UseVisualStyleBackColor = True
        '
        'BCerrarVendedor
        '
        Me.BCerrarVendedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BCerrarVendedor.Location = New System.Drawing.Point(878, 50)
        Me.BCerrarVendedor.Name = "BCerrarVendedor"
        Me.BCerrarVendedor.Size = New System.Drawing.Size(63, 35)
        Me.BCerrarVendedor.TabIndex = 1
        Me.BCerrarVendedor.Text = "Cerrar Sesión"
        Me.BCerrarVendedor.UseVisualStyleBackColor = True
        '
        'LabelVendedor
        '
        Me.LabelVendedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelVendedor.AutoSize = True
        Me.LabelVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVendedor.Location = New System.Drawing.Point(818, 17)
        Me.LabelVendedor.Name = "LabelVendedor"
        Me.LabelVendedor.Size = New System.Drawing.Size(39, 13)
        Me.LabelVendedor.TabIndex = 0
        Me.LabelVendedor.Text = "Label1"
        '
        'PanelAdmin
        '
        Me.PanelAdmin.BackColor = System.Drawing.Color.Cyan
        Me.PanelAdmin.Controls.Add(Me.LabelAdmin)
        Me.PanelAdmin.Controls.Add(Me.BCerrarAdmin)
        Me.PanelAdmin.Location = New System.Drawing.Point(0, 0)
        Me.PanelAdmin.Name = "PanelAdmin"
        Me.PanelAdmin.Size = New System.Drawing.Size(914, 478)
        Me.PanelAdmin.TabIndex = 0
        '
        'LabelAdmin
        '
        Me.LabelAdmin.AutoSize = True
        Me.LabelAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAdmin.Location = New System.Drawing.Point(730, 18)
        Me.LabelAdmin.Name = "LabelAdmin"
        Me.LabelAdmin.Size = New System.Drawing.Size(49, 16)
        Me.LabelAdmin.TabIndex = 1
        Me.LabelAdmin.Text = "Label1"
        '
        'BCerrarAdmin
        '
        Me.BCerrarAdmin.Location = New System.Drawing.Point(762, 51)
        Me.BCerrarAdmin.Name = "BCerrarAdmin"
        Me.BCerrarAdmin.Size = New System.Drawing.Size(107, 33)
        Me.BCerrarAdmin.TabIndex = 0
        Me.BCerrarAdmin.Text = "Cerrar Sesión"
        Me.BCerrarAdmin.UseVisualStyleBackColor = True
        '
        'PanelSupervisor
        '
        Me.PanelSupervisor.BackColor = System.Drawing.Color.OrangeRed
        Me.PanelSupervisor.Controls.Add(Me.BCerrarSuper)
        Me.PanelSupervisor.Controls.Add(Me.LabelSupervisor)
        Me.PanelSupervisor.Location = New System.Drawing.Point(0, 0)
        Me.PanelSupervisor.Name = "PanelSupervisor"
        Me.PanelSupervisor.Size = New System.Drawing.Size(914, 475)
        Me.PanelSupervisor.TabIndex = 0
        '
        'BCerrarSuper
        '
        Me.BCerrarSuper.Location = New System.Drawing.Point(762, 51)
        Me.BCerrarSuper.Name = "BCerrarSuper"
        Me.BCerrarSuper.Size = New System.Drawing.Size(107, 33)
        Me.BCerrarSuper.TabIndex = 1
        Me.BCerrarSuper.Text = "Cerrar Sesión"
        Me.BCerrarSuper.UseVisualStyleBackColor = True
        '
        'LabelSupervisor
        '
        Me.LabelSupervisor.AutoSize = True
        Me.LabelSupervisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSupervisor.Location = New System.Drawing.Point(730, 18)
        Me.LabelSupervisor.Name = "LabelSupervisor"
        Me.LabelSupervisor.Size = New System.Drawing.Size(49, 16)
        Me.LabelSupervisor.TabIndex = 0
        Me.LabelSupervisor.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 582)
        Me.Controls.Add(Me.PanelVendedor)
        Me.Controls.Add(Me.PanelSupervisor)
        Me.Controls.Add(Me.PanelAdmin)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        Me.PanelVendedor.ResumeLayout(False)
        Me.PanelVendedor.PerformLayout()
        Me.PanelProduc.ResumeLayout(False)
        Me.PanelProduc.PerformLayout()
        CType(Me.DGVProdAgre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGVProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAgregar.ResumeLayout(False)
        Me.PanelAgregar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelMostrar.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAdmin.ResumeLayout(False)
        Me.PanelAdmin.PerformLayout()
        Me.PanelSupervisor.ResumeLayout(False)
        Me.PanelSupervisor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelVendedor As System.Windows.Forms.Panel
    Friend WithEvents BListaC As System.Windows.Forms.Button
    Friend WithEvents BCerrarVendedor As System.Windows.Forms.Button
    Friend WithEvents LabelVendedor As System.Windows.Forms.Label
    Friend WithEvents PanelAdmin As System.Windows.Forms.Panel
    Friend WithEvents PanelSupervisor As System.Windows.Forms.Panel
    Friend WithEvents BCerrarSuper As System.Windows.Forms.Button
    Friend WithEvents LabelSupervisor As System.Windows.Forms.Label
    Friend WithEvents LabelAdmin As System.Windows.Forms.Label
    Friend WithEvents BCerrarAdmin As System.Windows.Forms.Button
    Friend WithEvents PanelMostrar As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BVolver As System.Windows.Forms.Button
    Friend WithEvents BMostrar1 As System.Windows.Forms.Button
    Friend WithEvents PanelAgregar As System.Windows.Forms.Panel
    Friend WithEvents BVolver1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DTPNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents TBNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BAgregar As System.Windows.Forms.Button
    Friend WithEvents TBCorreo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TBDireccion As System.Windows.Forms.TextBox
    Friend WithEvents TBApellido As System.Windows.Forms.TextBox
    Friend WithEvents BVerificar As System.Windows.Forms.Button
    Friend WithEvents TBDni As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents BRegistrarC As System.Windows.Forms.Button
    Friend WithEvents BPanelProduc As System.Windows.Forms.Button
    Friend WithEvents PanelProduc As System.Windows.Forms.Panel
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BPVerificar As System.Windows.Forms.Button
    Friend WithEvents TBPDni As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents BPContinuar As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents BBuscarProduc As System.Windows.Forms.Button
    Friend WithEvents TBBProd As System.Windows.Forms.TextBox
    Friend WithEvents DGVProd As System.Windows.Forms.DataGridView
    Friend WithEvents BVerTodoProd As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents DGVProdAgre As System.Windows.Forms.DataGridView
    Friend WithEvents Agregar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Imagen As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Quitar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Img As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Productos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Categoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
