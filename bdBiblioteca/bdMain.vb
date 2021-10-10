Public Class bdMain
    Dim switch As Boolean = True
    Dim toggled As Boolean = False

    'ABM/CRUD Software hecho por Gabriel Adrian Meza Romero y Abel Gustavo Villalba
    Private Sub bdMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        bdIniciarSesion.Close()
    End Sub
    Private Sub bdMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Objetivo: Carga los recursos diferenciando si el usuario tiene permisos de administrador o no.
        If (adminPermisos = True) Then
            conectarse()
            gridClientes()
            gridEmpleados()
            gridAutores()
            gridCategorias()
            gridLibros()
            gridPrestamos()
            gridDetalle()
            gridVistaPrestamos()
            profileNonAdmin.Hide()
            usuario.Text = cuenta
            MenuSwitch(0)
        ElseIf (adminPermisos = False) Then 'Si no posee permisos de administrador no puede acceder a los datos de los empleados.
            conectarse()
            gridClientes()
            gridAutores()
            gridCategorias()
            gridLibros()
            gridPrestamos()
            gridVistaPrestamos()
            gridDetalle()
            dgEmpleados.Hide()
            lbEmpleados.Hide()
            profileAdmin.Hide()
            markEmpleados.Hide()
            abmEmpleados.Hide()
            abmEmpleados.Enabled = False
            circleEmpleados.Hide()
            cantEmpleados.Hide()
            MenuSwitch(0)
        End If
        actualizarResumen()
        'Se actualiza constantemente una subrutina que muestra la fecha y la hora.
        fechaTimer.Enabled = True
        relojTimer.Enabled = True
        'Se ocultan controles que serán utilizados en subrutinas. 
        dgPrestamos_detalle.Hide()
        dgPrestamos.Hide()
    End Sub
    Public Sub gridClientes()
        'Objetivo: Llena la tabla de Clientes.
        Dim dsCliente As New DataSet
        Dim dtCliente As New DataTable
        Dim strsqlCliente As String = "SELECT id_cliente, nombre_cliente, apellido_cliente, dni_cliente, direccion_cliente, telefono_cliente FROM Clientes"
        Dim adpCliente As New OleDb.OleDbDataAdapter(strsqlCliente, conn)

        dsCliente.Tables.Add("Clientes")
        adpCliente.Fill(dsCliente.Tables("Clientes"))

        Me.dgClientes.DataSource = dsCliente.Tables("Clientes")

        'Cambia el texto de la cabecera de las columnas.
        Me.dgClientes.Columns(0).HeaderText = "ID"
        Me.dgClientes.Columns(1).HeaderText = "Nombre"
        Me.dgClientes.Columns(2).HeaderText = "Apellido"
        Me.dgClientes.Columns(3).HeaderText = "DNI"
        Me.dgClientes.Columns(4).HeaderText = "Dirección"
        Me.dgClientes.Columns(5).HeaderText = "Teléfono"
    End Sub
    Public Sub gridEmpleados()
        'Objetivo: Llena la tabla de Empleados.
        Dim dsEmpleado As New DataSet
        Dim dtEmpleado As New DataTable
        Dim strsqlEmpleado As String = "SELECT id_empleado, nombre_empleado, apellido_empleado, dni_empleado, cuit_empleado, direccion_empleado, telefono_empleado FROM Empleados"
        Dim adpEmpleado As New OleDb.OleDbDataAdapter(strsqlEmpleado, conn)

        dsEmpleado.Tables.Add("Empleados")
        adpEmpleado.Fill(dsEmpleado.Tables("Empleados"))

        Me.dgEmpleados.DataSource = dsEmpleado.Tables("Empleados")

        'Cambia el texto de la cabecera de las columnas.
        Me.dgEmpleados.Columns(0).HeaderText = "ID"
        Me.dgEmpleados.Columns(1).HeaderText = "Nombre"
        Me.dgEmpleados.Columns(2).HeaderText = "Apellido"
        Me.dgEmpleados.Columns(3).HeaderText = "DNI"
        Me.dgEmpleados.Columns(4).HeaderText = "CUIT"
        Me.dgEmpleados.Columns(5).HeaderText = "Dirección"
        Me.dgEmpleados.Columns(6).HeaderText = "Teléfono"
    End Sub
    Public Sub gridAutores()
        'Objetivo: Llena la tabla de Autores.
        Dim dsAutor As New DataSet
        Dim dtAutor As New DataTable
        Dim strsqlAutor As String = "SELECT id_autor, nombre_autor, apellido_autor FROM Autores"
        Dim adpAutor As New OleDb.OleDbDataAdapter(strsqlAutor, conn)

        dsAutor.Tables.Add("Autores")
        adpAutor.Fill(dsAutor.Tables("Autores"))

        Me.dgAutores.DataSource = dsAutor.Tables("Autores")

        'Cambia el texto de la cabecera de las columnas.
        Me.dgAutores.Columns(0).HeaderText = "ID"
        Me.dgAutores.Columns(1).HeaderText = "Nombre"
        Me.dgAutores.Columns(2).HeaderText = "Apellido"
    End Sub
    Public Sub gridCategorias()
        'Objetivo: Llena la tabla de Categorias.
        Dim dsCategoria As New DataSet
        Dim dtCategoria As New DataTable
        Dim strsqlCategoria As String = "SELECT id_categoria, categoria FROM Categorias"
        Dim adpCategoria As New OleDb.OleDbDataAdapter(strsqlCategoria, conn)

        dsCategoria.Tables.Add("Categorias")
        adpCategoria.Fill(dsCategoria.Tables("Categorias"))

        Me.dgCategorias.DataSource = dsCategoria.Tables("Categorias")

        'Cambia el texto de la cabecera de las columnas
        Me.dgCategorias.Columns(0).HeaderText = "ID"
        Me.dgCategorias.Columns(1).HeaderText = "Categoría"
    End Sub
    Public Sub gridLibros()
        'Objetivo: Llena la tabla de Libros con una Consulta diseñada para el resumen.
        Dim dsLibro As New DataSet
        Dim dtLibro As New DataTable
        Dim strsqlLibro As String = "SELECT * FROM VISTALIB"
        Dim adpLibro As New OleDb.OleDbDataAdapter(strsqlLibro, conn)

        dsLibro.Tables.Add("VISTALIB")
        adpLibro.Fill(dsLibro.Tables("VISTALIB"))

        Me.dgVistaLibros.DataSource = dsLibro.Tables("VISTALIB")

        'Cambia el texto de la cabecera de las columnas
        Me.dgVistaLibros.Columns(0).HeaderText = "ID"
        Me.dgVistaLibros.Columns(1).HeaderText = "ISBN"
        Me.dgVistaLibros.Columns(2).HeaderText = "Titulo"
        Me.dgVistaLibros.Columns(3).HeaderText = "Editorial"
        Me.dgVistaLibros.Columns(4).HeaderText = "Publicacion"
        Me.dgVistaLibros.Columns(5).HeaderText = "Edición"
        Me.dgVistaLibros.Columns(6).HeaderText = "Categoria"
    End Sub
    Public Sub gridPrestamos()
        'Objetivo: Llena la tabla de Prestamos, se usará para conseguir el número del siguiente id de prestamo.
        Dim dsPrestamos As New DataSet
        Dim dtPrestamos As New DataTable
        Dim strsqlPrestamos As String = "SELECT id_prestamo, id_cliente, id_empleado, desde, hasta FROM Prestamos"
        Dim adpPrestamos As New OleDb.OleDbDataAdapter(strsqlPrestamos, conn)

        dsPrestamos.Tables.Add("Prestamos")
        adpPrestamos.Fill(dsPrestamos.Tables("Prestamos"))

        Me.dgPrestamos.DataSource = dsPrestamos.Tables("Prestamos")
    End Sub
    Public Sub gridVistaPrestamos()
        'Objetivo: Llena la tabla de Prestamos con una Consulta diseñada para el resumen.
        dgVistaPrestamo.DataSource = 0
        Dim dsPrestamosvista As New DataSet
        Dim dtPrestamosvista As New DataTable
        Dim strsqlPrestamosvista As String = "SELECT * FROM VISTAPRES"
        Dim adpPrestamosvista As New OleDb.OleDbDataAdapter(strsqlPrestamosvista, conn)

        dsPrestamosvista.Tables.Add("VISTAPRES")
        adpPrestamosvista.Fill(dsPrestamosvista.Tables("VISTAPRES"))

        Me.dgVistaPrestamo.DataSource = dsPrestamosvista.Tables("VISTAPRES")

        'Cambia el texto de la cabecera de las columnas
        Me.dgVistaPrestamo.Columns(0).HeaderText = "ID Prestamo"
        Me.dgVistaPrestamo.Columns(1).HeaderText = "Nombre Cliente"
        Me.dgVistaPrestamo.Columns(2).HeaderText = "Apellido Cliente"
        Me.dgVistaPrestamo.Columns(3).HeaderText = "Nombre Empleado"
        Me.dgVistaPrestamo.Columns(4).HeaderText = "Apellido Empleado"
    End Sub
    Public Sub gridDetalle()
        'Objetivo: Llena la tabla de Detalle, se usará para conseguir el número del siguiente id de detalle.
        Dim dsPrestamos As New DataSet
        Dim dtPrestamos As New DataTable
        Dim strsqlPrestamos As String = "SELECT id_detalle, id_prestamo, id_libro FROM Prestamos_detalle"
        Dim adpPrestamos As New OleDb.OleDbDataAdapter(strsqlPrestamos, conn)

        dsPrestamos.Tables.Add("Prestamos_detalle")
        adpPrestamos.Fill(dsPrestamos.Tables("Prestamos_detalle"))

        Me.dgPrestamos_detalle.DataSource = dsPrestamos.Tables("Prestamos_detalle")
    End Sub
    Public Sub gridDetallePrestamo()
        'Objetivo: Llena la tabla de Detalle, muestra el detalle del Prestamo que esta siendo creado.
        Dim dsDetallePrestamos As New DataSet
        Dim dtDetallePrestamos As New DataTable
        Dim strsqlDetallePrestamos As String = "SELECT id_libro, titulo_libro FROM VISTADET WHERE id_prestamo = " & id_prestamoD.Text & " "
        Dim adpDetallePrestamos As New OleDb.OleDbDataAdapter(strsqlDetallePrestamos, conn)

        dsDetallePrestamos.Tables.Add("VISTADET")
        adpDetallePrestamos.Fill(dsDetallePrestamos.Tables("VISTADET"))

        Me.dgDetallePrestamo.DataSource = dsDetallePrestamos.Tables("VISTADET")

        'Cambia el texto de la cabecera de las columnas
        Me.dgDetallePrestamo.Columns(0).HeaderText = "ID Libro"
        Me.dgDetallePrestamo.Columns(1).HeaderText = "Título"
    End Sub
    Private Sub abmClientes_Click(sender As Object, e As EventArgs) Handles abmClientes.Click
        'Objetivo: Crea el formulario ABM de Clientes
        Dim bdClientes1 As New bdClientes
        bdClientes1.Show()
    End Sub
    Private Sub abmAutores_Click(sender As Object, e As EventArgs) Handles abmAutores.Click
        'Objetivo: Crea el formulario ABM de Autores
        Dim bdAutores1 As New bdAutores
        bdAutores1.Show()
    End Sub
    Private Sub abmCategorias_Click(sender As Object, e As EventArgs) Handles abmCategorias.Click
        'Objetivo: Crea el formulario ABM de Categorias
        Dim bdCategorias1 As New bdCategorias
        bdCategorias1.Show()
    End Sub
    Private Sub abmEmpleados_Click(sender As Object, e As EventArgs) Handles abmEmpleados.Click
        'Objetivo: Crea el formulario ABM de Empleados
        Dim bdEmpleados1 As New bdEmpleados
        bdEmpleados1.Show()
    End Sub
    Private Sub abmLibros_Click(sender As Object, e As EventArgs) Handles abmLibros.Click
        'Objetivo: Crea el formulario ABM de Libros
        Dim bdLibros1 As New bdLibrosNew
        bdLibros1.Show()
    End Sub
    Private Sub abmPrestamos_Click(sender As Object, e As EventArgs) Handles abmPrestamos.Click
        'Objetivo: Muestra el formulario ABM de Prestamos
        If switch = True Then
            MenuSwitch(1)
            switch = False
        Else
            MenuSwitch(0)
            switch = True
        End If


        'Dim bdPrestamos1 As New bdPrestamos
        'bdPrestamos1.Show()
    End Sub
    Private Sub actualizarResumen()
        'Objetivo: Actualiza el número (cantidad de elementos en cada tabla) que es mostrado en los círculos del resumen
        Dim clientes As Integer
        Dim autores As Integer
        Dim categorias As Integer
        Dim libros As Integer
        Dim empleados As Integer
        Dim prestamos As Integer

        'Se cuenta cada fila en las tablas, se resta la cabecera (-1 al total), y se actualiza el número
        For Each row In dgClientes.Rows
            clientes += 1
        Next
        cantClientes.Text = clientes - 1.ToString
        For Each row In dgAutores.Rows
            autores += 1
        Next
        cantAutores.Text = autores - 1.ToString
        For Each row In dgCategorias.Rows
            categorias += 1
        Next
        cantCategorias.Text = categorias - 1.ToString
        For Each row In dgVistaLibros.Rows
            libros += 1
        Next
        cantLibros.Text = libros - 1.ToString
        For Each row In dgEmpleados.Rows
            empleados += 1
        Next
        cantEmpleados.Text = empleados - 1.ToString
        For Each row In dgPrestamos.Rows
            prestamos += 1
        Next
        cantPrestamos.Text = prestamos - 1.ToString
    End Sub
    Private Sub fechaTimer_Tick(sender As Object, e As EventArgs) Handles fechaTimer.Tick
        'Objetivo: Muestra la fecha en formato Día/Mes/Año.
        fecha.Text = Date.Now.ToString("dd/MM/yyyy")
    End Sub
    Private Sub relojTimer_Tick(sender As Object, e As EventArgs) Handles relojTimer.Tick
        'Objetivo: Muestra la hora en formato Hora/Minuto/Segundo.
        relojLb.Text = Date.Now.ToString("hh:mm:ss")
    End Sub
    Private Sub logOut_Click(sender As Object, e As EventArgs) Handles logOut.Click
        'Objetivo: Se oculta el formulario y se vuelve a mostrar el formulario de inicio de sesión
        'para iniciar sesión con una cuenta diferente. 
        Me.Hide()
        bdIniciarSesion.Show()
    End Sub
    Private Sub toggleMenu_Click(sender As Object, e As EventArgs) Handles toggleMenu.Click
        'Objetivo: Colapsa o expande el menú lateral, ajustando el tamaño y contenido de los controles.
        If toggled = False Then
            logoTexto.Text = ""
            usuario.Hide()
            abmAutores.Text = ""
            abmAutores.Size = New Size(62, 57)
            abmClientes.Text = ""
            abmClientes.Size = New Size(62, 57)
            abmEmpleados.Text = ""
            abmEmpleados.Size = New Size(62, 57)
            abmLibros.Text = ""
            abmLibros.Size = New Size(62, 57)
            abmCategorias.Text = ""
            abmCategorias.Size = New Size(62, 57)
            abmPrestamos.Text = ""
            abmPrestamos.Size = New Size(62, 57)
            MenuVertical.Size = New Size(77, 718)
            toggleMenu.Location = New Size(81, 20)
            toggled = True
        Else
            usuario.Show()
            logoTexto.Text = "BIBLIOTECA"
            abmAutores.Text = "Autores"
            abmAutores.Size = New Size(200, 57)
            abmClientes.Text = "Clientes"
            abmClientes.Size = New Size(200, 57)
            abmEmpleados.Text = "Empleados"
            abmEmpleados.Size = New Size(200, 57)
            abmLibros.Text = "Libros"
            abmLibros.Size = New Size(200, 57)
            abmCategorias.Text = "Categorias"
            abmCategorias.Size = New Size(200, 57)
            abmPrestamos.Text = "Prestamos"
            abmPrestamos.Size = New Size(200, 57)
            MenuVertical.Size = New Size(215, 718)
            toggleMenu.Location = New Size(215, 20)
            toggled = False
        End If
    End Sub
    Private Sub btnMenu1_Click(sender As Object, e As EventArgs) Handles btnMenu1.Click
        'Objetivo: Llama a la subrutina que muestra el resumen de las tablas.
        MenuSwitch(0)
        switch = True
    End Sub
    Private Sub btnMenu2_Click(sender As Object, e As EventArgs) Handles btnMenu2.Click
        'Objetivo: Llama a la subrutina que muestra el ABM de Prestamos.
        MenuSwitch(1)
        switch = False
        'eventoFeedback(5)
    End Sub
    Public Sub MenuSwitch(ByRef switch As Boolean)
        'Objetivo: Muestra el resumen de las tablas o el ABM de Prestamos, diferencia si es admin o no para no
        'cargar los datos de empleados en caso de que el usuario no tenga permisos de admin.
        If switch = False And adminPermisos = True Then
            dgVistaPrestamo.Show()
            dgDetallePrestamo.Hide()
            panelMenu2.Hide()
            lbIniciarSesion.Show()
            lbAutores.Show()
            lbLibros.Show()
            lbCategorias.Show()
            lbEmpleados.Show()
            lbPrestamos.Show()
            circleClientes.Show()
            circleLibros.Show()
            circleAutores.Show()
            circleCategorias.Show()
            circleEmpleados.Show()
            circlePrestamos.Show()
            cantClientes.Show()
            cantLibros.Show()
            cantAutores.Show()
            cantCategorias.Show()
            cantEmpleados.Show()
            cantPrestamos.Show()
            dgClientes.Show()
            dgVistaLibros.Show()
            dgAutores.Show()
            dgCategorias.Show()
            dgEmpleados.Show()
            dgPrestamos.Show()
            dPrestamos.Hide()
            idPrestamo.Hide()
            idCliente.Hide()
            idEmpleado.Hide()
            desD.Hide()
            hasT.Hide()
            id_prestamo.Hide()
            id_cliente.Hide()
            id_empleado.Hide()
            desde.Hide()
            hasta.Hide()
            btnLlenar.Hide()
            btnCrear.Hide()
            dDetalle.Hide()
            idDetalle.Hide()
            idPrestamoD.Hide()
            idLibroD.Hide()
            id_detalleD.Hide()
            id_prestamoD.Hide()
            id_libroD.Hide()
            btnDetener.Hide()
            btnCrearD.Hide()
        ElseIf switch = True And adminPermisos = True Then
            dgVistaPrestamo.Hide()
            dgDetallePrestamo.Show()
            panelMenu2.Show()
            lbIniciarSesion.Hide()
            lbAutores.Hide()
            lbLibros.Hide()
            lbCategorias.Hide()
            lbEmpleados.Hide()
            lbPrestamos.Hide()
            circleClientes.Hide()
            circleLibros.Hide()
            circleAutores.Hide()
            circleCategorias.Hide()
            circleEmpleados.Hide()
            circlePrestamos.Hide()
            cantClientes.Hide()
            cantLibros.Hide()
            cantAutores.Hide()
            cantCategorias.Hide()
            cantEmpleados.Hide()
            cantPrestamos.Hide()
            dgClientes.Hide()
            dgVistaLibros.Hide()
            dgAutores.Hide()
            dgCategorias.Hide()
            dgEmpleados.Hide()
            dgPrestamos.Hide()
            dPrestamos.Show()
            idPrestamo.Show()
            idCliente.Show()
            idEmpleado.Show()
            desD.Show()
            hasT.Show()
            id_prestamo.Show()
            id_cliente.Show()
            id_empleado.Show()
            desde.Show()
            hasta.Show()
            btnLlenar.Show()
            btnCrear.Show()
            dDetalle.Show()
            idDetalle.Show()
            idPrestamoD.Show()
            idLibroD.Show()
            id_detalleD.Show()
            id_prestamoD.Show()
            id_libroD.Show()
            btnDetener.Show()
            btnCrearD.Show()
        ElseIf switch = False And adminPermisos = False Then
            dgVistaPrestamo.Show()
            dgDetallePrestamo.Hide()
            panelMenu2.Hide()
            lbIniciarSesion.Show()
            lbAutores.Show()
            lbLibros.Show()
            lbCategorias.Show()
            lbPrestamos.Show()
            circleClientes.Show()
            circleLibros.Show()
            circleAutores.Show()
            circleCategorias.Show()
            circlePrestamos.Show()
            cantClientes.Show()
            cantLibros.Show()
            cantAutores.Show()
            cantCategorias.Show()
            cantPrestamos.Show()
            dgClientes.Show()
            dgVistaLibros.Show()
            dgAutores.Show()
            dgCategorias.Show()
            dgPrestamos.Show()
            dPrestamos.Hide()
            idPrestamo.Hide()
            idCliente.Hide()
            idEmpleado.Hide()
            desD.Hide()
            hasT.Hide()
            id_prestamo.Hide()
            id_cliente.Hide()
            id_empleado.Hide()
            desde.Hide()
            hasta.Hide()
            btnLlenar.Hide()
            btnCrear.Hide()
            dDetalle.Hide()
            idDetalle.Hide()
            idPrestamoD.Hide()
            idLibroD.Hide()
            id_detalleD.Hide()
            id_prestamoD.Hide()
            id_libroD.Hide()
            btnDetener.Hide()
            btnCrearD.Hide()
        ElseIf switch = True And adminPermisos = False Then
            dgVistaPrestamo.Hide()
            dgDetallePrestamo.Show()
            panelMenu2.Show()
            lbIniciarSesion.Hide()
            lbAutores.Hide()
            lbLibros.Hide()
            lbCategorias.Hide()
            lbPrestamos.Hide()
            circleClientes.Hide()
            circleLibros.Hide()
            circleAutores.Hide()
            circleCategorias.Hide()
            circlePrestamos.Hide()
            cantClientes.Hide()
            cantLibros.Hide()
            cantAutores.Hide()
            cantCategorias.Hide()
            cantPrestamos.Hide()
            dgClientes.Hide()
            dgVistaLibros.Hide()
            dgAutores.Hide()
            dgCategorias.Hide()
            dgPrestamos.Hide()
            dPrestamos.Show()
            idPrestamo.Show()
            idCliente.Show()
            idEmpleado.Show()
            desD.Show()
            hasT.Show()
            id_prestamo.Show()
            id_cliente.Show()
            id_empleado.Show()
            desde.Show()
            hasta.Show()
            btnLlenar.Show()
            btnCrear.Show()
            dDetalle.Show()
            idDetalle.Show()
            idPrestamoD.Show()
            idLibroD.Show()
            id_detalleD.Show()
            id_prestamoD.Show()
            id_libroD.Show()
            btnDetener.Show()
            btnCrearD.Show()
        End If
    End Sub
    Private Sub eventoFeedback(ByRef tipo As Short)
        'Objetivo: Da retroalimentación.
        If tipo = 0 Then
            btnCrear.Enabled = True
        ElseIf tipo = 1 Then
            btnCrear.Enabled = False
        ElseIf tipo = 2 Then
            btnCrear.Enabled = False
        ElseIf tipo = 5 Then
            btnCrear.Enabled = False
        End If
    End Sub
    Private Sub vaciarCampos(ByRef modo As Boolean)
        'Objetivo: Vacia los campos de texto de prestamo, contando o no el id principal.
        If modo Then
            Me.id_prestamo.Text = ""
            Me.id_cliente.Text = ""
            Me.id_empleado.Text = ""
            Me.desde.Text = ""
            Me.hasta.Text = ""
        Else
            Me.id_cliente.Text = ""
            Me.id_empleado.Text = ""
            Me.desde.Text = ""
            Me.hasta.Text = ""
        End If
    End Sub
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        'Objetivo: Insertan un nuevo registro a la tabla de Prestamos
        If (Me.id_prestamo.Text = "") Then
            Me.id_prestamo.Select()
        End If

        Dim id As Integer
        Dim cliente As String = ""
        Dim empleado As String = ""
        Dim desded As String = ""
        Dim hastat As String = ""

        id = Me.id_prestamo.Text
        cliente = Me.id_cliente.Text
        empleado = Me.id_empleado.Text
        desded = Me.desde.Text
        hastat = Me.hasta.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = conn

        sql = "INSERT INTO Prestamos (id_prestamo, id_cliente, id_empleado, desde, hasta) VALUES (" & id & ",'" & cliente & "', '" & empleado & "', '" & desded & "', '" & hastat & "')"
        'MsgBox(sql)

        cmd.CommandText = sql

        'Inserta el registro, provee de retroalimentación, deshabilita la modificación del prestamo actual
        'y prepara la inserción de detalles del prestamo con el siguiente id de detalle disponible.
        Try
            cmd.ExecuteNonQuery()
            eventoFeedback(2)
            gridPrestamos()

            Dim counterDetalle As Integer = 0
            For Each row In dgPrestamos_detalle.Rows
                counterDetalle = counterDetalle + 1
            Next
            id_detalleD.Text = counterDetalle.ToString
            id_prestamoD.Text = id_prestamo.Text

            btnCrear.Enabled = False
            btnDetener.Enabled = True
            btnCrearD.Enabled = True
            id_prestamo.Enabled = False
            id_cliente.Enabled = False
            id_empleado.Enabled = False
            desde.Enabled = False
            hasta.Enabled = False
            btnLlenar.Enabled = False
            id_detalleD.Enabled = True
            id_prestamoD.Enabled = True
            id_libroD.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btnLlenar_Click(sender As Object, e As EventArgs) Handles btnLlenar.Click
        'Objetivo: Completa los campos de id, desde y hasta del prestamo.
        'Vacía los campos de texto para preparar un nuevo prestamo.
        vaciarCampos(1)
        'Completa el campo de id con la siguiente id de prestmao disponible.
        Dim counterPrestamo As Integer = 0
        For Each row In dgPrestamos.Rows
            counterPrestamo = counterPrestamo + 1
        Next

        id_prestamo.Text = counterPrestamo.ToString

        'Completa el campo de desde con la fecha actual.
        Dim fecha As Date = Date.Today()
        desde.Text = fecha.ToString("dd/MM/yyyy")
        Dim dia As DayOfWeek = Now.DayOfWeek
        'Llama a una función que obtiene que fecha será dentro de 7 días y completa el campo de hasta con el 
        'resultado.
        Dim semana As Date = semanaSiguiente(dia)
        hasta.Text = semana.ToString("dd/MM/yyyy")

        btnCrear.Enabled = True
    End Sub
    Private Function semanaSiguiente(dia As DayOfWeek) As DateTime
        'Objetivo: Obtiene que fecha será dentro de 7 días
        Dim ahora As DateTime = DateTime.Today
        Dim hoy As Integer = CInt(Now.DayOfWeek)
        Dim buscar As Integer = CInt(dia)

        'Agrega 7 días a la fecha actual y retorna el resultado
        Dim delta As Integer = buscar - hoy
        If delta > 0 Then
            Return Now.AddDays(delta)
        Else
            Return Now.AddDays(7 - delta)
        End If
    End Function
    Private Sub btnCrearD_Click(sender As Object, e As EventArgs) Handles btnCrearD.Click
        'Objetivo: Inserta un nuevo registro a la tabla de Prestamos detalle
        If (Me.id_prestamo.Text = "") Then
            Me.id_prestamo.Select()
        End If

        Dim id As Integer
        Dim prestamo As String = ""
        Dim libro As String = ""

        id = Me.id_detalleD.Text
        prestamo = Me.id_prestamoD.Text
        libro = Me.id_libroD.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = conn

        sql = "INSERT INTO Prestamos_detalle (id_detalle, id_prestamo, id_libro) VALUES (" & id & ",'" & prestamo & "', '" & libro & "')"
        'MsgBox(sql)

        cmd.CommandText = sql

        'Inserta el registro, actualiza las tablas relevantes y prepara la inserción de detalles del prestamo 
        'con el siguiente id de detalle disponible.
        Try
            cmd.ExecuteNonQuery()
            gridDetalle()
            gridPrestamos()
            Dim counterDetalleD As Integer = 0
            For Each row In dgPrestamos_detalle.Rows
                counterDetalleD = counterDetalleD + 1
            Next
            id_detalleD.Text = counterDetalleD.ToString
            gridDetallePrestamo()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btnDetener_Click(sender As Object, e As EventArgs) Handles btnDetener.Click
        'Objetivo: Detener la inserción de detalles de prestamo, y preparar la inserción de nuevos prestamos.
        btnCrear.Enabled = True
        btnCrearD.Enabled = False
        btnDetener.Enabled = False
        id_prestamo.Enabled = True
        id_cliente.Enabled = True
        id_empleado.Enabled = True
        desde.Enabled = True
        hasta.Enabled = True
        btnLlenar.Enabled = True
        id_detalleD.Enabled = False
        id_prestamoD.Enabled = False
        id_libroD.Enabled = False

        id_prestamo.Text = ""
        id_cliente.Text = ""
        id_empleado.Text = ""
        desde.Text = ""
        hasta.Text = ""
        id_detalleD.Text = ""
        id_prestamoD.Text = ""
        id_libroD.Text = ""

        'Vacía la tabla de Detalles 
        dgDetallePrestamo.DataSource = 0
    End Sub
End Class