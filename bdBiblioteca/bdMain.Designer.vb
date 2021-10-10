<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bdMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bdMain))
        Me.dgClientes = New System.Windows.Forms.DataGridView()
        Me.dgEmpleados = New System.Windows.Forms.DataGridView()
        Me.dgAutores = New System.Windows.Forms.DataGridView()
        Me.dgCategorias = New System.Windows.Forms.DataGridView()
        Me.dgVistaLibros = New System.Windows.Forms.DataGridView()
        Me.lbIniciarSesion = New System.Windows.Forms.Label()
        Me.lbEmpleados = New System.Windows.Forms.Label()
        Me.lbAutores = New System.Windows.Forms.Label()
        Me.lbCategorias = New System.Windows.Forms.Label()
        Me.lbLibros = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.panelMenu2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.markPrestamos = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.markLibros = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.markCategorias = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.markEmpleados = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.markAutores = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.markClientes = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.MenuVertical = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.colorPanel1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.dgPrestamos = New System.Windows.Forms.DataGridView()
        Me.lbPrestamos = New System.Windows.Forms.Label()
        Me.firma1 = New System.Windows.Forms.Label()
        Me.logoTexto = New System.Windows.Forms.Label()
        Me.relojLb = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.Label()
        Me.cantAutores = New System.Windows.Forms.Label()
        Me.cantLibros = New System.Windows.Forms.Label()
        Me.cantClientes = New System.Windows.Forms.Label()
        Me.cantCategorias = New System.Windows.Forms.Label()
        Me.cantEmpleados = New System.Windows.Forms.Label()
        Me.fechaTimer = New System.Windows.Forms.Timer(Me.components)
        Me.relojTimer = New System.Windows.Forms.Timer(Me.components)
        Me.usuario = New System.Windows.Forms.Label()
        Me.firmas = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMenu1 = New System.Windows.Forms.Button()
        Me.btnMenu2 = New System.Windows.Forms.Button()
        Me.hasta = New System.Windows.Forms.TextBox()
        Me.hasT = New System.Windows.Forms.Label()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.dPrestamos = New System.Windows.Forms.Label()
        Me.desD = New System.Windows.Forms.Label()
        Me.idEmpleado = New System.Windows.Forms.Label()
        Me.idCliente = New System.Windows.Forms.Label()
        Me.idPrestamo = New System.Windows.Forms.Label()
        Me.desde = New System.Windows.Forms.TextBox()
        Me.id_empleado = New System.Windows.Forms.TextBox()
        Me.id_cliente = New System.Windows.Forms.TextBox()
        Me.id_prestamo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLlenar = New System.Windows.Forms.Button()
        Me.btnCrearD = New System.Windows.Forms.Button()
        Me.dDetalle = New System.Windows.Forms.Label()
        Me.idLibroD = New System.Windows.Forms.Label()
        Me.idPrestamoD = New System.Windows.Forms.Label()
        Me.idDetalle = New System.Windows.Forms.Label()
        Me.id_libroD = New System.Windows.Forms.TextBox()
        Me.id_prestamoD = New System.Windows.Forms.TextBox()
        Me.id_detalleD = New System.Windows.Forms.TextBox()
        Me.btnDetener = New System.Windows.Forms.Button()
        Me.dgPrestamos_detalle = New System.Windows.Forms.DataGridView()
        Me.dgDetallePrestamo = New System.Windows.Forms.DataGridView()
        Me.dgVistaPrestamo = New System.Windows.Forms.DataGridView()
        Me.cantPrestamos = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.circlePrestamos = New System.Windows.Forms.PictureBox()
        Me.toggleMenu = New System.Windows.Forms.Button()
        Me.profileNonAdmin = New System.Windows.Forms.PictureBox()
        Me.profileAdmin = New System.Windows.Forms.PictureBox()
        Me.circleEmpleados = New System.Windows.Forms.PictureBox()
        Me.circleCategorias = New System.Windows.Forms.PictureBox()
        Me.circleClientes = New System.Windows.Forms.PictureBox()
        Me.circleLibros = New System.Windows.Forms.PictureBox()
        Me.circleAutores = New System.Windows.Forms.PictureBox()
        Me.logoImagen = New System.Windows.Forms.PictureBox()
        Me.logOut = New System.Windows.Forms.Button()
        Me.abmPrestamos = New System.Windows.Forms.Button()
        Me.abmLibros = New System.Windows.Forms.Button()
        Me.abmEmpleados = New System.Windows.Forms.Button()
        Me.abmCategorias = New System.Windows.Forms.Button()
        Me.abmAutores = New System.Windows.Forms.Button()
        Me.abmClientes = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgAutores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgVistaLibros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgPrestamos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgPrestamos_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDetallePrestamo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgVistaPrestamo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.circlePrestamos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.profileNonAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.profileAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.circleEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.circleCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.circleClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.circleLibros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.circleAutores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logoImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgClientes
        '
        Me.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgClientes.Location = New System.Drawing.Point(215, 132)
        Me.dgClientes.Name = "dgClientes"
        Me.dgClientes.Size = New System.Drawing.Size(358, 184)
        Me.dgClientes.TabIndex = 10
        Me.dgClientes.TabStop = False
        '
        'dgEmpleados
        '
        Me.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEmpleados.Location = New System.Drawing.Point(946, 432)
        Me.dgEmpleados.Name = "dgEmpleados"
        Me.dgEmpleados.Size = New System.Drawing.Size(358, 184)
        Me.dgEmpleados.TabIndex = 11
        Me.dgEmpleados.TabStop = False
        '
        'dgAutores
        '
        Me.dgAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAutores.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgAutores.Location = New System.Drawing.Point(215, 432)
        Me.dgAutores.Name = "dgAutores"
        Me.dgAutores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgAutores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgAutores.Size = New System.Drawing.Size(358, 184)
        Me.dgAutores.TabIndex = 12
        Me.dgAutores.TabStop = False
        '
        'dgCategorias
        '
        Me.dgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCategorias.Location = New System.Drawing.Point(946, 132)
        Me.dgCategorias.Name = "dgCategorias"
        Me.dgCategorias.Size = New System.Drawing.Size(358, 184)
        Me.dgCategorias.TabIndex = 13
        Me.dgCategorias.TabStop = False
        '
        'dgVistaLibros
        '
        Me.dgVistaLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVistaLibros.Location = New System.Drawing.Point(582, 132)
        Me.dgVistaLibros.Name = "dgVistaLibros"
        Me.dgVistaLibros.Size = New System.Drawing.Size(358, 184)
        Me.dgVistaLibros.TabIndex = 14
        Me.dgVistaLibros.TabStop = False
        '
        'lbIniciarSesion
        '
        Me.lbIniciarSesion.AutoSize = True
        Me.lbIniciarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIniciarSesion.ForeColor = System.Drawing.Color.Black
        Me.lbIniciarSesion.Location = New System.Drawing.Point(275, 65)
        Me.lbIniciarSesion.Name = "lbIniciarSesion"
        Me.lbIniciarSesion.Size = New System.Drawing.Size(114, 25)
        Me.lbIniciarSesion.TabIndex = 15
        Me.lbIniciarSesion.Text = "CLIENTES"
        '
        'lbEmpleados
        '
        Me.lbEmpleados.AutoSize = True
        Me.lbEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEmpleados.ForeColor = System.Drawing.Color.Black
        Me.lbEmpleados.Location = New System.Drawing.Point(1009, 367)
        Me.lbEmpleados.Name = "lbEmpleados"
        Me.lbEmpleados.Size = New System.Drawing.Size(143, 25)
        Me.lbEmpleados.TabIndex = 16
        Me.lbEmpleados.Text = "EMPLEADOS"
        '
        'lbAutores
        '
        Me.lbAutores.AutoSize = True
        Me.lbAutores.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAutores.ForeColor = System.Drawing.Color.Black
        Me.lbAutores.Location = New System.Drawing.Point(289, 367)
        Me.lbAutores.Name = "lbAutores"
        Me.lbAutores.Size = New System.Drawing.Size(113, 25)
        Me.lbAutores.TabIndex = 17
        Me.lbAutores.Text = "AUTORES"
        '
        'lbCategorias
        '
        Me.lbCategorias.AutoSize = True
        Me.lbCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCategorias.ForeColor = System.Drawing.Color.Black
        Me.lbCategorias.Location = New System.Drawing.Point(1008, 65)
        Me.lbCategorias.Name = "lbCategorias"
        Me.lbCategorias.Size = New System.Drawing.Size(148, 25)
        Me.lbCategorias.TabIndex = 18
        Me.lbCategorias.Text = "CATEGORIAS"
        '
        'lbLibros
        '
        Me.lbLibros.AutoSize = True
        Me.lbLibros.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLibros.ForeColor = System.Drawing.Color.Black
        Me.lbLibros.Location = New System.Drawing.Point(668, 65)
        Me.lbLibros.Name = "lbLibros"
        Me.lbLibros.Size = New System.Drawing.Size(88, 25)
        Me.lbLibros.TabIndex = 19
        Me.lbLibros.Text = "LIBROS"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.panelMenu2, Me.markPrestamos, Me.markLibros, Me.markCategorias, Me.markEmpleados, Me.markAutores, Me.markClientes, Me.MenuVertical, Me.RectangleShape1, Me.colorPanel1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1359, 749)
        Me.ShapeContainer1.TabIndex = 20
        Me.ShapeContainer1.TabStop = False
        '
        'panelMenu2
        '
        Me.panelMenu2.BackColor = System.Drawing.Color.Transparent
        Me.panelMenu2.BorderColor = System.Drawing.Color.Transparent
        Me.panelMenu2.FillColor = System.Drawing.Color.Silver
        Me.panelMenu2.FillGradientColor = System.Drawing.Color.Gainsboro
        Me.panelMenu2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.panelMenu2.Location = New System.Drawing.Point(212, 20)
        Me.panelMenu2.Name = "panelMenu2"
        Me.panelMenu2.SelectionColor = System.Drawing.Color.Transparent
        Me.panelMenu2.Size = New System.Drawing.Size(274, 734)
        '
        'markPrestamos
        '
        Me.markPrestamos.BackColor = System.Drawing.Color.Transparent
        Me.markPrestamos.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.markPrestamos.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.markPrestamos.FillGradientColor = System.Drawing.Color.DeepSkyBlue
        Me.markPrestamos.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.markPrestamos.Location = New System.Drawing.Point(-1, 369)
        Me.markPrestamos.Name = "markPrestamos"
        Me.markPrestamos.SelectionColor = System.Drawing.Color.Transparent
        Me.markPrestamos.Size = New System.Drawing.Size(14, 56)
        '
        'markLibros
        '
        Me.markLibros.BackColor = System.Drawing.Color.Transparent
        Me.markLibros.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.markLibros.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.markLibros.FillGradientColor = System.Drawing.Color.DeepSkyBlue
        Me.markLibros.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.markLibros.Location = New System.Drawing.Point(-1, 306)
        Me.markLibros.Name = "markLibros"
        Me.markLibros.SelectionColor = System.Drawing.Color.Transparent
        Me.markLibros.Size = New System.Drawing.Size(14, 56)
        '
        'markCategorias
        '
        Me.markCategorias.BackColor = System.Drawing.Color.Transparent
        Me.markCategorias.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.markCategorias.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.markCategorias.FillGradientColor = System.Drawing.Color.DeepSkyBlue
        Me.markCategorias.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.markCategorias.Location = New System.Drawing.Point(-2, 243)
        Me.markCategorias.Name = "markCategorias"
        Me.markCategorias.SelectionColor = System.Drawing.Color.Transparent
        Me.markCategorias.Size = New System.Drawing.Size(14, 56)
        '
        'markEmpleados
        '
        Me.markEmpleados.BackColor = System.Drawing.Color.Transparent
        Me.markEmpleados.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.markEmpleados.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.markEmpleados.FillGradientColor = System.Drawing.Color.DeepSkyBlue
        Me.markEmpleados.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.markEmpleados.Location = New System.Drawing.Point(-2, 432)
        Me.markEmpleados.Name = "markEmpleados"
        Me.markEmpleados.SelectionColor = System.Drawing.Color.Transparent
        Me.markEmpleados.Size = New System.Drawing.Size(14, 56)
        '
        'markAutores
        '
        Me.markAutores.BackColor = System.Drawing.Color.Transparent
        Me.markAutores.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.markAutores.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.markAutores.FillGradientColor = System.Drawing.Color.DeepSkyBlue
        Me.markAutores.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.markAutores.Location = New System.Drawing.Point(-2, 180)
        Me.markAutores.Name = "markAutores"
        Me.markAutores.SelectionColor = System.Drawing.Color.Transparent
        Me.markAutores.Size = New System.Drawing.Size(14, 56)
        '
        'markClientes
        '
        Me.markClientes.BackColor = System.Drawing.Color.Transparent
        Me.markClientes.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.markClientes.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.markClientes.FillGradientColor = System.Drawing.Color.DeepSkyBlue
        Me.markClientes.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.markClientes.Location = New System.Drawing.Point(-1, 117)
        Me.markClientes.Name = "markClientes"
        Me.markClientes.SelectionColor = System.Drawing.Color.Transparent
        Me.markClientes.Size = New System.Drawing.Size(14, 56)
        '
        'MenuVertical
        '
        Me.MenuVertical.BackColor = System.Drawing.Color.Transparent
        Me.MenuVertical.BorderColor = System.Drawing.Color.Transparent
        Me.MenuVertical.FillColor = System.Drawing.Color.Gainsboro
        Me.MenuVertical.FillGradientColor = System.Drawing.Color.Gainsboro
        Me.MenuVertical.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.MenuVertical.Location = New System.Drawing.Point(-3, 20)
        Me.MenuVertical.Name = "MenuVertical"
        Me.MenuVertical.SelectionColor = System.Drawing.Color.Transparent
        Me.MenuVertical.Size = New System.Drawing.Size(215, 731)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.RectangleShape1.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.DeepSkyBlue
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(0, 748)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(1359, 12)
        '
        'colorPanel1
        '
        Me.colorPanel1.BackColor = System.Drawing.Color.Transparent
        Me.colorPanel1.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.colorPanel1.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.colorPanel1.FillGradientColor = System.Drawing.Color.DeepSkyBlue
        Me.colorPanel1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.colorPanel1.Location = New System.Drawing.Point(-3, -2)
        Me.colorPanel1.Name = "colorPanel1"
        Me.colorPanel1.Size = New System.Drawing.Size(1363, 21)
        '
        'dgPrestamos
        '
        Me.dgPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPrestamos.Location = New System.Drawing.Point(477, 736)
        Me.dgPrestamos.Name = "dgPrestamos"
        Me.dgPrestamos.Size = New System.Drawing.Size(10, 10)
        Me.dgPrestamos.TabIndex = 28
        '
        'lbPrestamos
        '
        Me.lbPrestamos.AutoSize = True
        Me.lbPrestamos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPrestamos.ForeColor = System.Drawing.Color.Black
        Me.lbPrestamos.Location = New System.Drawing.Point(648, 369)
        Me.lbPrestamos.Name = "lbPrestamos"
        Me.lbPrestamos.Size = New System.Drawing.Size(144, 25)
        Me.lbPrestamos.TabIndex = 29
        Me.lbPrestamos.Text = "PRESTAMOS"
        '
        'firma1
        '
        Me.firma1.AutoSize = True
        Me.firma1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.firma1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firma1.ForeColor = System.Drawing.Color.White
        Me.firma1.Location = New System.Drawing.Point(72, 2)
        Me.firma1.Name = "firma1"
        Me.firma1.Size = New System.Drawing.Size(137, 16)
        Me.firma1.TabIndex = 33
        Me.firma1.Text = "Abel Gustavo Villalba"
        '
        'logoTexto
        '
        Me.logoTexto.AutoSize = True
        Me.logoTexto.BackColor = System.Drawing.Color.Gainsboro
        Me.logoTexto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logoTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoTexto.Location = New System.Drawing.Point(70, 32)
        Me.logoTexto.Name = "logoTexto"
        Me.logoTexto.Size = New System.Drawing.Size(134, 25)
        Me.logoTexto.TabIndex = 35
        Me.logoTexto.Text = "BIBLIOTECA"
        '
        'relojLb
        '
        Me.relojLb.AutoSize = True
        Me.relojLb.BackColor = System.Drawing.Color.White
        Me.relojLb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.relojLb.Location = New System.Drawing.Point(1216, 717)
        Me.relojLb.Name = "relojLb"
        Me.relojLb.Size = New System.Drawing.Size(40, 16)
        Me.relojLb.TabIndex = 42
        Me.relojLb.Text = "Reloj"
        '
        'fecha
        '
        Me.fecha.AutoSize = True
        Me.fecha.BackColor = System.Drawing.Color.White
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Location = New System.Drawing.Point(1216, 695)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(46, 16)
        Me.fecha.TabIndex = 43
        Me.fecha.Text = "Fecha"
        '
        'cantAutores
        '
        Me.cantAutores.AutoSize = True
        Me.cantAutores.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantAutores.Location = New System.Drawing.Point(502, 359)
        Me.cantAutores.Name = "cantAutores"
        Me.cantAutores.Size = New System.Drawing.Size(26, 25)
        Me.cantAutores.TabIndex = 51
        Me.cantAutores.Text = "A"
        Me.cantAutores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cantLibros
        '
        Me.cantLibros.AutoSize = True
        Me.cantLibros.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantLibros.Location = New System.Drawing.Point(866, 59)
        Me.cantLibros.Name = "cantLibros"
        Me.cantLibros.Size = New System.Drawing.Size(24, 25)
        Me.cantLibros.TabIndex = 53
        Me.cantLibros.Text = "L"
        '
        'cantClientes
        '
        Me.cantClientes.AutoSize = True
        Me.cantClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantClientes.Location = New System.Drawing.Point(507, 59)
        Me.cantClientes.Name = "cantClientes"
        Me.cantClientes.Size = New System.Drawing.Size(27, 25)
        Me.cantClientes.TabIndex = 55
        Me.cantClientes.Text = "C"
        '
        'cantCategorias
        '
        Me.cantCategorias.AutoSize = True
        Me.cantCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantCategorias.Location = New System.Drawing.Point(1238, 59)
        Me.cantCategorias.Name = "cantCategorias"
        Me.cantCategorias.Size = New System.Drawing.Size(41, 25)
        Me.cantCategorias.TabIndex = 57
        Me.cantCategorias.Text = "CA"
        '
        'cantEmpleados
        '
        Me.cantEmpleados.AutoSize = True
        Me.cantEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantEmpleados.Location = New System.Drawing.Point(1236, 359)
        Me.cantEmpleados.Name = "cantEmpleados"
        Me.cantEmpleados.Size = New System.Drawing.Size(26, 25)
        Me.cantEmpleados.TabIndex = 59
        Me.cantEmpleados.Text = "E"
        '
        'fechaTimer
        '
        '
        'relojTimer
        '
        '
        'usuario
        '
        Me.usuario.AutoSize = True
        Me.usuario.BackColor = System.Drawing.Color.Gainsboro
        Me.usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usuario.Location = New System.Drawing.Point(71, 551)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(64, 20)
        Me.usuario.TabIndex = 61
        Me.usuario.Text = "Usuario"
        '
        'firmas
        '
        Me.firmas.AutoSize = True
        Me.firmas.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.firmas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firmas.ForeColor = System.Drawing.Color.White
        Me.firmas.Location = New System.Drawing.Point(0, 1)
        Me.firmas.Name = "firmas"
        Me.firmas.Size = New System.Drawing.Size(74, 16)
        Me.firmas.TabIndex = 63
        Me.firmas.Text = "Hecho por:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(212, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 16)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Gabriel Adrian Meza Romero"
        '
        'btnMenu1
        '
        Me.btnMenu1.BackColor = System.Drawing.Color.DarkGray
        Me.btnMenu1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnMenu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu1.Location = New System.Drawing.Point(12, 88)
        Me.btnMenu1.Name = "btnMenu1"
        Me.btnMenu1.Size = New System.Drawing.Size(24, 23)
        Me.btnMenu1.TabIndex = 67
        Me.btnMenu1.Text = "1"
        Me.btnMenu1.UseVisualStyleBackColor = False
        '
        'btnMenu2
        '
        Me.btnMenu2.BackColor = System.Drawing.Color.DarkGray
        Me.btnMenu2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnMenu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu2.Location = New System.Drawing.Point(46, 88)
        Me.btnMenu2.Name = "btnMenu2"
        Me.btnMenu2.Size = New System.Drawing.Size(24, 23)
        Me.btnMenu2.TabIndex = 69
        Me.btnMenu2.Text = "2"
        Me.btnMenu2.UseVisualStyleBackColor = False
        '
        'hasta
        '
        Me.hasta.BackColor = System.Drawing.Color.Gainsboro
        Me.hasta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hasta.Location = New System.Drawing.Point(308, 275)
        Me.hasta.Name = "hasta"
        Me.hasta.Size = New System.Drawing.Size(71, 15)
        Me.hasta.TabIndex = 85
        '
        'hasT
        '
        Me.hasT.AutoSize = True
        Me.hasT.BackColor = System.Drawing.Color.Silver
        Me.hasT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hasT.Location = New System.Drawing.Point(215, 274)
        Me.hasT.Name = "hasT"
        Me.hasT.Size = New System.Drawing.Size(44, 16)
        Me.hasT.TabIndex = 84
        Me.hasT.Text = "Hasta"
        '
        'btnCrear
        '
        Me.btnCrear.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCrear.Enabled = False
        Me.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrear.ForeColor = System.Drawing.SystemColors.Window
        Me.btnCrear.Location = New System.Drawing.Point(218, 365)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(75, 25)
        Me.btnCrear.TabIndex = 80
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = False
        '
        'dPrestamos
        '
        Me.dPrestamos.AutoSize = True
        Me.dPrestamos.BackColor = System.Drawing.Color.Silver
        Me.dPrestamos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dPrestamos.Location = New System.Drawing.Point(275, 65)
        Me.dPrestamos.Name = "dPrestamos"
        Me.dPrestamos.Size = New System.Drawing.Size(114, 25)
        Me.dPrestamos.TabIndex = 78
        Me.dPrestamos.Text = "Prestamos"
        '
        'desD
        '
        Me.desD.AutoSize = True
        Me.desD.BackColor = System.Drawing.Color.Silver
        Me.desD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desD.Location = New System.Drawing.Point(215, 240)
        Me.desD.Name = "desD"
        Me.desD.Size = New System.Drawing.Size(49, 16)
        Me.desD.TabIndex = 77
        Me.desD.Text = "Desde"
        '
        'idEmpleado
        '
        Me.idEmpleado.AutoSize = True
        Me.idEmpleado.BackColor = System.Drawing.Color.Silver
        Me.idEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idEmpleado.Location = New System.Drawing.Point(215, 200)
        Me.idEmpleado.Name = "idEmpleado"
        Me.idEmpleado.Size = New System.Drawing.Size(87, 16)
        Me.idEmpleado.TabIndex = 76
        Me.idEmpleado.Text = "ID Empleado"
        '
        'idCliente
        '
        Me.idCliente.AutoSize = True
        Me.idCliente.BackColor = System.Drawing.Color.Silver
        Me.idCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idCliente.Location = New System.Drawing.Point(215, 162)
        Me.idCliente.Name = "idCliente"
        Me.idCliente.Size = New System.Drawing.Size(65, 16)
        Me.idCliente.TabIndex = 75
        Me.idCliente.Text = "ID Cliente"
        '
        'idPrestamo
        '
        Me.idPrestamo.AutoSize = True
        Me.idPrestamo.BackColor = System.Drawing.Color.Silver
        Me.idPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idPrestamo.Location = New System.Drawing.Point(215, 124)
        Me.idPrestamo.Name = "idPrestamo"
        Me.idPrestamo.Size = New System.Drawing.Size(21, 16)
        Me.idPrestamo.TabIndex = 74
        Me.idPrestamo.Text = "ID"
        '
        'desde
        '
        Me.desde.BackColor = System.Drawing.Color.Gainsboro
        Me.desde.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.desde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desde.Location = New System.Drawing.Point(308, 241)
        Me.desde.Name = "desde"
        Me.desde.Size = New System.Drawing.Size(71, 15)
        Me.desde.TabIndex = 73
        '
        'id_empleado
        '
        Me.id_empleado.BackColor = System.Drawing.Color.Gainsboro
        Me.id_empleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.id_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_empleado.Location = New System.Drawing.Point(308, 201)
        Me.id_empleado.Name = "id_empleado"
        Me.id_empleado.Size = New System.Drawing.Size(147, 15)
        Me.id_empleado.TabIndex = 72
        '
        'id_cliente
        '
        Me.id_cliente.BackColor = System.Drawing.Color.Gainsboro
        Me.id_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.id_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_cliente.Location = New System.Drawing.Point(308, 162)
        Me.id_cliente.Name = "id_cliente"
        Me.id_cliente.Size = New System.Drawing.Size(147, 15)
        Me.id_cliente.TabIndex = 71
        '
        'id_prestamo
        '
        Me.id_prestamo.BackColor = System.Drawing.Color.Gainsboro
        Me.id_prestamo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.id_prestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_prestamo.Location = New System.Drawing.Point(307, 124)
        Me.id_prestamo.Name = "id_prestamo"
        Me.id_prestamo.Size = New System.Drawing.Size(37, 15)
        Me.id_prestamo.TabIndex = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(215, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 16)
        Me.Label2.TabIndex = 87
        '
        'btnLlenar
        '
        Me.btnLlenar.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnLlenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLlenar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLlenar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnLlenar.Location = New System.Drawing.Point(368, 120)
        Me.btnLlenar.Name = "btnLlenar"
        Me.btnLlenar.Size = New System.Drawing.Size(75, 25)
        Me.btnLlenar.TabIndex = 88
        Me.btnLlenar.Text = "Llenar"
        Me.btnLlenar.UseVisualStyleBackColor = False
        '
        'btnCrearD
        '
        Me.btnCrearD.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCrearD.Enabled = False
        Me.btnCrearD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearD.ForeColor = System.Drawing.Color.White
        Me.btnCrearD.Location = New System.Drawing.Point(499, 365)
        Me.btnCrearD.Name = "btnCrearD"
        Me.btnCrearD.Size = New System.Drawing.Size(75, 25)
        Me.btnCrearD.TabIndex = 98
        Me.btnCrearD.Text = "Crear"
        Me.btnCrearD.UseVisualStyleBackColor = False
        '
        'dDetalle
        '
        Me.dDetalle.AutoSize = True
        Me.dDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dDetalle.Location = New System.Drawing.Point(569, 65)
        Me.dDetalle.Name = "dDetalle"
        Me.dDetalle.Size = New System.Drawing.Size(79, 25)
        Me.dDetalle.TabIndex = 97
        Me.dDetalle.Text = "Detalle"
        '
        'idLibroD
        '
        Me.idLibroD.AutoSize = True
        Me.idLibroD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idLibroD.Location = New System.Drawing.Point(509, 201)
        Me.idLibroD.Name = "idLibroD"
        Me.idLibroD.Size = New System.Drawing.Size(54, 16)
        Me.idLibroD.TabIndex = 95
        Me.idLibroD.Text = "ID Libro"
        '
        'idPrestamoD
        '
        Me.idPrestamoD.AutoSize = True
        Me.idPrestamoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idPrestamoD.Location = New System.Drawing.Point(509, 162)
        Me.idPrestamoD.Name = "idPrestamoD"
        Me.idPrestamoD.Size = New System.Drawing.Size(82, 16)
        Me.idPrestamoD.TabIndex = 94
        Me.idPrestamoD.Text = "ID Prestamo"
        '
        'idDetalle
        '
        Me.idDetalle.AutoSize = True
        Me.idDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idDetalle.Location = New System.Drawing.Point(509, 124)
        Me.idDetalle.Name = "idDetalle"
        Me.idDetalle.Size = New System.Drawing.Size(21, 16)
        Me.idDetalle.TabIndex = 93
        Me.idDetalle.Text = "ID"
        '
        'id_libroD
        '
        Me.id_libroD.BackColor = System.Drawing.Color.Gainsboro
        Me.id_libroD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.id_libroD.Enabled = False
        Me.id_libroD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_libroD.Location = New System.Drawing.Point(591, 201)
        Me.id_libroD.Name = "id_libroD"
        Me.id_libroD.Size = New System.Drawing.Size(147, 15)
        Me.id_libroD.TabIndex = 91
        '
        'id_prestamoD
        '
        Me.id_prestamoD.BackColor = System.Drawing.Color.Gainsboro
        Me.id_prestamoD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.id_prestamoD.Enabled = False
        Me.id_prestamoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_prestamoD.Location = New System.Drawing.Point(591, 162)
        Me.id_prestamoD.Name = "id_prestamoD"
        Me.id_prestamoD.Size = New System.Drawing.Size(147, 15)
        Me.id_prestamoD.TabIndex = 90
        '
        'id_detalleD
        '
        Me.id_detalleD.BackColor = System.Drawing.Color.Gainsboro
        Me.id_detalleD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.id_detalleD.Enabled = False
        Me.id_detalleD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_detalleD.Location = New System.Drawing.Point(591, 124)
        Me.id_detalleD.Name = "id_detalleD"
        Me.id_detalleD.Size = New System.Drawing.Size(37, 15)
        Me.id_detalleD.TabIndex = 89
        '
        'btnDetener
        '
        Me.btnDetener.BackColor = System.Drawing.Color.DeepPink
        Me.btnDetener.Enabled = False
        Me.btnDetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetener.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetener.ForeColor = System.Drawing.Color.White
        Me.btnDetener.Location = New System.Drawing.Point(582, 365)
        Me.btnDetener.Name = "btnDetener"
        Me.btnDetener.Size = New System.Drawing.Size(75, 25)
        Me.btnDetener.TabIndex = 101
        Me.btnDetener.Text = "Listo"
        Me.btnDetener.UseVisualStyleBackColor = False
        '
        'dgPrestamos_detalle
        '
        Me.dgPrestamos_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPrestamos_detalle.Location = New System.Drawing.Point(461, 736)
        Me.dgPrestamos_detalle.Name = "dgPrestamos_detalle"
        Me.dgPrestamos_detalle.Size = New System.Drawing.Size(10, 10)
        Me.dgPrestamos_detalle.TabIndex = 102
        '
        'dgDetallePrestamo
        '
        Me.dgDetallePrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetallePrestamo.Location = New System.Drawing.Point(837, 66)
        Me.dgDetallePrestamo.Name = "dgDetallePrestamo"
        Me.dgDetallePrestamo.Size = New System.Drawing.Size(467, 298)
        Me.dgDetallePrestamo.TabIndex = 103
        Me.dgDetallePrestamo.TabStop = False
        '
        'dgVistaPrestamo
        '
        Me.dgVistaPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVistaPrestamo.DataSource = Me.ShapeContainer1.Shapes
        Me.dgVistaPrestamo.Location = New System.Drawing.Point(582, 433)
        Me.dgVistaPrestamo.Name = "dgVistaPrestamo"
        Me.dgVistaPrestamo.Size = New System.Drawing.Size(358, 185)
        Me.dgVistaPrestamo.TabIndex = 104
        Me.dgVistaPrestamo.TabStop = False
        '
        'cantPrestamos
        '
        Me.cantPrestamos.AutoSize = True
        Me.cantPrestamos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantPrestamos.Location = New System.Drawing.Point(873, 360)
        Me.cantPrestamos.Name = "cantPrestamos"
        Me.cantPrestamos.Size = New System.Drawing.Size(26, 25)
        Me.cantPrestamos.TabIndex = 106
        Me.cantPrestamos.Text = "P"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "BackgroundImage"
        Me.DataGridViewImageColumn1.HeaderText = "BackgroundImage"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Tag"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tag"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'circlePrestamos
        '
        Me.circlePrestamos.BackColor = System.Drawing.Color.Transparent
        Me.circlePrestamos.BackgroundImage = Global.bdBiblioteca.My.Resources.Resources.icons8_circle_100
        Me.circlePrestamos.Enabled = False
        Me.circlePrestamos.Location = New System.Drawing.Point(836, 322)
        Me.circlePrestamos.Name = "circlePrestamos"
        Me.circlePrestamos.Size = New System.Drawing.Size(104, 104)
        Me.circlePrestamos.TabIndex = 105
        Me.circlePrestamos.TabStop = False
        '
        'toggleMenu
        '
        Me.toggleMenu.BackColor = System.Drawing.Color.LightGray
        Me.toggleMenu.BackgroundImage = Global.bdBiblioteca.My.Resources.Resources.icons8_menu_vertical_50
        Me.toggleMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.toggleMenu.ForeColor = System.Drawing.Color.LightGray
        Me.toggleMenu.Location = New System.Drawing.Point(215, 20)
        Me.toggleMenu.Name = "toggleMenu"
        Me.toggleMenu.Size = New System.Drawing.Size(54, 50)
        Me.toggleMenu.TabIndex = 1
        Me.toggleMenu.UseVisualStyleBackColor = False
        '
        'profileNonAdmin
        '
        Me.profileNonAdmin.BackColor = System.Drawing.Color.Gainsboro
        Me.profileNonAdmin.BackgroundImage = Global.bdBiblioteca.My.Resources.Resources.icons8_man_50
        Me.profileNonAdmin.Enabled = False
        Me.profileNonAdmin.Location = New System.Drawing.Point(19, 551)
        Me.profileNonAdmin.Name = "profileNonAdmin"
        Me.profileNonAdmin.Size = New System.Drawing.Size(50, 50)
        Me.profileNonAdmin.TabIndex = 62
        Me.profileNonAdmin.TabStop = False
        '
        'profileAdmin
        '
        Me.profileAdmin.BackColor = System.Drawing.Color.Gainsboro
        Me.profileAdmin.BackgroundImage = Global.bdBiblioteca.My.Resources.Resources.icons8_user_rights_50
        Me.profileAdmin.Location = New System.Drawing.Point(19, 551)
        Me.profileAdmin.Name = "profileAdmin"
        Me.profileAdmin.Size = New System.Drawing.Size(50, 50)
        Me.profileAdmin.TabIndex = 60
        Me.profileAdmin.TabStop = False
        '
        'circleEmpleados
        '
        Me.circleEmpleados.BackColor = System.Drawing.Color.Transparent
        Me.circleEmpleados.BackgroundImage = Global.bdBiblioteca.My.Resources.Resources.icons8_circle_100
        Me.circleEmpleados.Enabled = False
        Me.circleEmpleados.Location = New System.Drawing.Point(1200, 322)
        Me.circleEmpleados.Name = "circleEmpleados"
        Me.circleEmpleados.Size = New System.Drawing.Size(104, 104)
        Me.circleEmpleados.TabIndex = 58
        Me.circleEmpleados.TabStop = False
        '
        'circleCategorias
        '
        Me.circleCategorias.BackColor = System.Drawing.Color.Transparent
        Me.circleCategorias.BackgroundImage = Global.bdBiblioteca.My.Resources.Resources.icons8_circle_100
        Me.circleCategorias.Enabled = False
        Me.circleCategorias.Location = New System.Drawing.Point(1199, 22)
        Me.circleCategorias.Name = "circleCategorias"
        Me.circleCategorias.Size = New System.Drawing.Size(104, 104)
        Me.circleCategorias.TabIndex = 56
        Me.circleCategorias.TabStop = False
        '
        'circleClientes
        '
        Me.circleClientes.BackColor = System.Drawing.Color.Transparent
        Me.circleClientes.BackgroundImage = Global.bdBiblioteca.My.Resources.Resources.icons8_circle_100
        Me.circleClientes.Enabled = False
        Me.circleClientes.Location = New System.Drawing.Point(469, 22)
        Me.circleClientes.Name = "circleClientes"
        Me.circleClientes.Size = New System.Drawing.Size(104, 104)
        Me.circleClientes.TabIndex = 54
        Me.circleClientes.TabStop = False
        '
        'circleLibros
        '
        Me.circleLibros.BackColor = System.Drawing.Color.Transparent
        Me.circleLibros.BackgroundImage = Global.bdBiblioteca.My.Resources.Resources.icons8_circle_100
        Me.circleLibros.Enabled = False
        Me.circleLibros.Location = New System.Drawing.Point(836, 22)
        Me.circleLibros.Name = "circleLibros"
        Me.circleLibros.Size = New System.Drawing.Size(104, 104)
        Me.circleLibros.TabIndex = 52
        Me.circleLibros.TabStop = False
        '
        'circleAutores
        '
        Me.circleAutores.BackColor = System.Drawing.Color.Transparent
        Me.circleAutores.BackgroundImage = Global.bdBiblioteca.My.Resources.Resources.icons8_circle_100
        Me.circleAutores.Enabled = False
        Me.circleAutores.Location = New System.Drawing.Point(469, 322)
        Me.circleAutores.Name = "circleAutores"
        Me.circleAutores.Size = New System.Drawing.Size(104, 104)
        Me.circleAutores.TabIndex = 50
        Me.circleAutores.TabStop = False
        '
        'logoImagen
        '
        Me.logoImagen.BackColor = System.Drawing.Color.Gainsboro
        Me.logoImagen.BackgroundImage = Global.bdBiblioteca.My.Resources.Resources.icons8_library_50
        Me.logoImagen.Enabled = False
        Me.logoImagen.Location = New System.Drawing.Point(19, 26)
        Me.logoImagen.Name = "logoImagen"
        Me.logoImagen.Size = New System.Drawing.Size(51, 50)
        Me.logoImagen.TabIndex = 34
        Me.logoImagen.TabStop = False
        '
        'logOut
        '
        Me.logOut.BackColor = System.Drawing.Color.Gainsboro
        Me.logOut.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logOut.Image = Global.bdBiblioteca.My.Resources.Resources.icons8_logout_rounded_left_50
        Me.logOut.Location = New System.Drawing.Point(17, 676)
        Me.logOut.Name = "logOut"
        Me.logOut.Size = New System.Drawing.Size(53, 54)
        Me.logOut.TabIndex = 31
        Me.logOut.UseVisualStyleBackColor = False
        '
        'abmPrestamos
        '
        Me.abmPrestamos.BackColor = System.Drawing.Color.Gainsboro
        Me.abmPrestamos.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.abmPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.abmPrestamos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abmPrestamos.Image = Global.bdBiblioteca.My.Resources.Resources.icons8_borrow_book_50
        Me.abmPrestamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.abmPrestamos.Location = New System.Drawing.Point(12, 369)
        Me.abmPrestamos.Name = "abmPrestamos"
        Me.abmPrestamos.Size = New System.Drawing.Size(200, 57)
        Me.abmPrestamos.TabIndex = 5
        Me.abmPrestamos.Text = "Prestamos"
        Me.abmPrestamos.UseVisualStyleBackColor = False
        '
        'abmLibros
        '
        Me.abmLibros.BackColor = System.Drawing.Color.Gainsboro
        Me.abmLibros.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.abmLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.abmLibros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abmLibros.Image = Global.bdBiblioteca.My.Resources.Resources.icons8_book_50
        Me.abmLibros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.abmLibros.Location = New System.Drawing.Point(12, 180)
        Me.abmLibros.Name = "abmLibros"
        Me.abmLibros.Size = New System.Drawing.Size(200, 57)
        Me.abmLibros.TabIndex = 2
        Me.abmLibros.Text = "Libros"
        Me.abmLibros.UseVisualStyleBackColor = False
        '
        'abmEmpleados
        '
        Me.abmEmpleados.BackColor = System.Drawing.Color.Gainsboro
        Me.abmEmpleados.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.abmEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.abmEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abmEmpleados.Image = Global.bdBiblioteca.My.Resources.Resources.icons8_identification_documents_50
        Me.abmEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.abmEmpleados.Location = New System.Drawing.Point(12, 432)
        Me.abmEmpleados.Name = "abmEmpleados"
        Me.abmEmpleados.Size = New System.Drawing.Size(200, 57)
        Me.abmEmpleados.TabIndex = 6
        Me.abmEmpleados.Text = "Empleados"
        Me.abmEmpleados.UseVisualStyleBackColor = False
        '
        'abmCategorias
        '
        Me.abmCategorias.BackColor = System.Drawing.Color.Gainsboro
        Me.abmCategorias.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.abmCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.abmCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abmCategorias.Image = Global.bdBiblioteca.My.Resources.Resources.icons8_category_50
        Me.abmCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.abmCategorias.Location = New System.Drawing.Point(12, 243)
        Me.abmCategorias.Name = "abmCategorias"
        Me.abmCategorias.Size = New System.Drawing.Size(200, 57)
        Me.abmCategorias.TabIndex = 3
        Me.abmCategorias.Text = "Categorias"
        Me.abmCategorias.UseVisualStyleBackColor = False
        '
        'abmAutores
        '
        Me.abmAutores.BackColor = System.Drawing.Color.Gainsboro
        Me.abmAutores.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.abmAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.abmAutores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abmAutores.Image = Global.bdBiblioteca.My.Resources.Resources.icons8_quill_with_ink_50
        Me.abmAutores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.abmAutores.Location = New System.Drawing.Point(12, 306)
        Me.abmAutores.Name = "abmAutores"
        Me.abmAutores.Size = New System.Drawing.Size(200, 57)
        Me.abmAutores.TabIndex = 4
        Me.abmAutores.Text = "Autores"
        Me.abmAutores.UseVisualStyleBackColor = False
        '
        'abmClientes
        '
        Me.abmClientes.BackColor = System.Drawing.Color.Gainsboro
        Me.abmClientes.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.abmClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.abmClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abmClientes.ForeColor = System.Drawing.Color.Black
        Me.abmClientes.Image = Global.bdBiblioteca.My.Resources.Resources.icons8_customer_50
        Me.abmClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.abmClientes.Location = New System.Drawing.Point(12, 117)
        Me.abmClientes.Name = "abmClientes"
        Me.abmClientes.Size = New System.Drawing.Size(200, 57)
        Me.abmClientes.TabIndex = 1
        Me.abmClientes.Text = "Clientes"
        Me.abmClientes.UseVisualStyleBackColor = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Tag"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tag"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(143, 72)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 107
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'bdMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1359, 749)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.cantPrestamos)
        Me.Controls.Add(Me.circlePrestamos)
        Me.Controls.Add(Me.dgVistaPrestamo)
        Me.Controls.Add(Me.dgDetallePrestamo)
        Me.Controls.Add(Me.dgPrestamos_detalle)
        Me.Controls.Add(Me.btnDetener)
        Me.Controls.Add(Me.btnCrearD)
        Me.Controls.Add(Me.dDetalle)
        Me.Controls.Add(Me.idLibroD)
        Me.Controls.Add(Me.idPrestamoD)
        Me.Controls.Add(Me.idDetalle)
        Me.Controls.Add(Me.id_libroD)
        Me.Controls.Add(Me.id_prestamoD)
        Me.Controls.Add(Me.id_detalleD)
        Me.Controls.Add(Me.btnLlenar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.hasta)
        Me.Controls.Add(Me.hasT)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.dPrestamos)
        Me.Controls.Add(Me.desD)
        Me.Controls.Add(Me.idEmpleado)
        Me.Controls.Add(Me.idCliente)
        Me.Controls.Add(Me.idPrestamo)
        Me.Controls.Add(Me.desde)
        Me.Controls.Add(Me.id_empleado)
        Me.Controls.Add(Me.id_cliente)
        Me.Controls.Add(Me.id_prestamo)
        Me.Controls.Add(Me.btnMenu2)
        Me.Controls.Add(Me.btnMenu1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.toggleMenu)
        Me.Controls.Add(Me.firmas)
        Me.Controls.Add(Me.profileNonAdmin)
        Me.Controls.Add(Me.usuario)
        Me.Controls.Add(Me.profileAdmin)
        Me.Controls.Add(Me.cantEmpleados)
        Me.Controls.Add(Me.circleEmpleados)
        Me.Controls.Add(Me.cantCategorias)
        Me.Controls.Add(Me.circleCategorias)
        Me.Controls.Add(Me.cantClientes)
        Me.Controls.Add(Me.circleClientes)
        Me.Controls.Add(Me.cantLibros)
        Me.Controls.Add(Me.circleLibros)
        Me.Controls.Add(Me.cantAutores)
        Me.Controls.Add(Me.circleAutores)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.relojLb)
        Me.Controls.Add(Me.logoTexto)
        Me.Controls.Add(Me.logoImagen)
        Me.Controls.Add(Me.firma1)
        Me.Controls.Add(Me.logOut)
        Me.Controls.Add(Me.abmPrestamos)
        Me.Controls.Add(Me.lbPrestamos)
        Me.Controls.Add(Me.dgPrestamos)
        Me.Controls.Add(Me.abmLibros)
        Me.Controls.Add(Me.abmEmpleados)
        Me.Controls.Add(Me.abmCategorias)
        Me.Controls.Add(Me.abmAutores)
        Me.Controls.Add(Me.abmClientes)
        Me.Controls.Add(Me.lbLibros)
        Me.Controls.Add(Me.lbCategorias)
        Me.Controls.Add(Me.lbAutores)
        Me.Controls.Add(Me.lbEmpleados)
        Me.Controls.Add(Me.lbIniciarSesion)
        Me.Controls.Add(Me.dgVistaLibros)
        Me.Controls.Add(Me.dgCategorias)
        Me.Controls.Add(Me.dgAutores)
        Me.Controls.Add(Me.dgEmpleados)
        Me.Controls.Add(Me.dgClientes)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "bdMain"
        Me.Text = "BIBLIOTECA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgAutores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgVistaLibros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgPrestamos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgPrestamos_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDetallePrestamo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgVistaPrestamo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.circlePrestamos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.profileNonAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.profileAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.circleEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.circleCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.circleClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.circleLibros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.circleAutores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logoImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgClientes As System.Windows.Forms.DataGridView
    Friend WithEvents dgEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents dgAutores As System.Windows.Forms.DataGridView
    Friend WithEvents dgCategorias As System.Windows.Forms.DataGridView
    Friend WithEvents dgVistaLibros As System.Windows.Forms.DataGridView
    Friend WithEvents lbIniciarSesion As System.Windows.Forms.Label
    Friend WithEvents lbEmpleados As System.Windows.Forms.Label
    Friend WithEvents lbAutores As System.Windows.Forms.Label
    Friend WithEvents lbCategorias As System.Windows.Forms.Label
    Friend WithEvents lbLibros As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents colorPanel1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents abmClientes As System.Windows.Forms.Button
    Friend WithEvents abmAutores As System.Windows.Forms.Button
    Friend WithEvents abmCategorias As System.Windows.Forms.Button
    Friend WithEvents abmEmpleados As System.Windows.Forms.Button
    Friend WithEvents abmLibros As System.Windows.Forms.Button
    Friend WithEvents dgPrestamos As System.Windows.Forms.DataGridView
    Friend WithEvents lbPrestamos As System.Windows.Forms.Label
    Friend WithEvents abmPrestamos As System.Windows.Forms.Button
    Friend WithEvents MenuVertical As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents markClientes As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents markPrestamos As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents markLibros As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents markCategorias As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents markEmpleados As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents markAutores As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents logOut As System.Windows.Forms.Button
    Friend WithEvents firma1 As System.Windows.Forms.Label
    Friend WithEvents logoImagen As System.Windows.Forms.PictureBox
    Friend WithEvents logoTexto As System.Windows.Forms.Label
    Friend WithEvents relojLb As System.Windows.Forms.Label
    Friend WithEvents fecha As System.Windows.Forms.Label
    Friend WithEvents circleAutores As System.Windows.Forms.PictureBox
    Friend WithEvents cantAutores As System.Windows.Forms.Label
    Friend WithEvents circleLibros As System.Windows.Forms.PictureBox
    Friend WithEvents cantLibros As System.Windows.Forms.Label
    Friend WithEvents circleClientes As System.Windows.Forms.PictureBox
    Friend WithEvents cantClientes As System.Windows.Forms.Label
    Friend WithEvents circleCategorias As System.Windows.Forms.PictureBox
    Friend WithEvents cantCategorias As System.Windows.Forms.Label
    Friend WithEvents circleEmpleados As System.Windows.Forms.PictureBox
    Friend WithEvents cantEmpleados As System.Windows.Forms.Label
    Friend WithEvents fechaTimer As System.Windows.Forms.Timer
    Friend WithEvents relojTimer As System.Windows.Forms.Timer
    Friend WithEvents profileAdmin As System.Windows.Forms.PictureBox
    Friend WithEvents usuario As System.Windows.Forms.Label
    Friend WithEvents profileNonAdmin As System.Windows.Forms.PictureBox
    Friend WithEvents firmas As System.Windows.Forms.Label
    Friend WithEvents toggleMenu As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMenu1 As System.Windows.Forms.Button
    Friend WithEvents btnMenu2 As System.Windows.Forms.Button
    Friend WithEvents panelMenu2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents hasta As System.Windows.Forms.TextBox
    Friend WithEvents hasT As System.Windows.Forms.Label
    Friend WithEvents btnCrear As System.Windows.Forms.Button
    Friend WithEvents dPrestamos As System.Windows.Forms.Label
    Friend WithEvents desD As System.Windows.Forms.Label
    Friend WithEvents idEmpleado As System.Windows.Forms.Label
    Friend WithEvents idCliente As System.Windows.Forms.Label
    Friend WithEvents idPrestamo As System.Windows.Forms.Label
    Friend WithEvents desde As System.Windows.Forms.TextBox
    Friend WithEvents id_empleado As System.Windows.Forms.TextBox
    Friend WithEvents id_cliente As System.Windows.Forms.TextBox
    Friend WithEvents id_prestamo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnLlenar As System.Windows.Forms.Button
    Friend WithEvents btnCrearD As System.Windows.Forms.Button
    Friend WithEvents dDetalle As System.Windows.Forms.Label
    Friend WithEvents idLibroD As System.Windows.Forms.Label
    Friend WithEvents idPrestamoD As System.Windows.Forms.Label
    Friend WithEvents idDetalle As System.Windows.Forms.Label
    Friend WithEvents id_libroD As System.Windows.Forms.TextBox
    Friend WithEvents id_prestamoD As System.Windows.Forms.TextBox
    Friend WithEvents id_detalleD As System.Windows.Forms.TextBox
    Friend WithEvents btnDetener As System.Windows.Forms.Button
    Friend WithEvents dgPrestamos_detalle As System.Windows.Forms.DataGridView
    Friend WithEvents dgDetallePrestamo As System.Windows.Forms.DataGridView
    Friend WithEvents dgVistaPrestamo As System.Windows.Forms.DataGridView
    Friend WithEvents circlePrestamos As System.Windows.Forms.PictureBox
    Friend WithEvents cantPrestamos As System.Windows.Forms.Label
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
