Public Class bdIniciarSesion
    'ABM/CRUD Software hecho por Gabriel Adrian Meza Romero y Abel Gustavo Villalba
    'VARIABLES------------------------------------------------------------------------------------------------
    Dim Usuario1 As String = "admin"
    Dim Clave1 As String = "admin"
    Dim Usuario2 As String = "demo"
    Dim Clave2 As String = "demo"
    'EVENTOS--------------------------------------------------------------------------------------------------
    Private Sub formulario(sender As Object, e As EventArgs) Handles MyBase.Load
        'Objetivo: Oculta las etiquetas que señalan errores, deshabilita el botón de ingreso y
        'selecciona la etiqueta de nombre para que no seleccione un campo de texto.
        lbIniciarSesion.Select()
        lbClaveError.Hide()
        lbUsuarioError.Hide()
        btnEntrar.Enabled = False
    End Sub
    Private Sub ingresarClave(sender As Object, e As EventArgs) Handles isClave.GotFocus
        'Objetivo: Eliminar el texto predeterminado y llama a la subrutina que 
        'cambia el color del campo de texto
        If isClave.Text = "Contraseña" Then
            isClave.UseSystemPasswordChar = True
            isClave.Text = ""
        End If
        colorTextbox(2, 1)
    End Sub
    Private Sub ingresarUsuario(sender As Object, e As EventArgs) Handles isUsuario.GotFocus
        'Objetivo: Eliminar el texto predeterminado y llama a la subrutina que 
        'cambia el color del campo de texto
        If isUsuario.Text = "Usuario" Then
            isUsuario.Text = ""
        End If
        colorTextbox(1, 1)
    End Sub
    Private Sub claveOlvidada(sender As Object, e As EventArgs) Handles isSoporte.Click
        'Objetivo: Da una pista de las credenciales sin permisos de administrador
        isSoporte.Text = "Pista: demo"
    End Sub
    Private Sub DEMO_AccesoRapido(sender As Object, e As EventArgs) Handles lbIniciarSesion.Click
        'Objetivo: Da un acceso rápido al formulario principal en la DEMO.
        'Demo Version
        accesoPermitido(1)
    End Sub
    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        'Objetivo: Llama a la subrutina que verifica las credenciales y da acceso al 
        'formulario principal o muestra errores en ellas (credenciales).
        logIn()
    End Sub
    Private Sub isUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles isUsuario.KeyDown
        'Objetivo: Llama a la subrutina que verifica las credenciales y da acceso al 
        'formulario principal o muestra errores en ellas (credenciales).
        If e.KeyData = Keys.Enter And isUsuario.Text <> "" And isUsuario.Text <> "Usuario" And isClave.Text <> "" And isClave.Text <> "Contraseña" Then
            logIn()
        End If
    End Sub
    Private Sub isClave_KeyDown(sender As Object, e As KeyEventArgs) Handles isClave.KeyDown
        'Objetivo: Llama a la subrutina que verifica las credenciales y da acceso al 
        'formulario principal o muestra errores en ellas (credenciales).
        If e.KeyData = Keys.Enter And isUsuario.Text <> "" And isUsuario.Text <> "Usuario" And isClave.Text <> "" And isClave.Text <> "Contraseña" Then
            logIn()
        End If
    End Sub
    Private Sub isUsuario_Leave(sender As Object, e As EventArgs) Handles isUsuario.Leave
        'Objetivo: Llama a la subrutina que cambia el color del campo de texto
        colorTextbox(1, 0)
    End Sub
    Private Sub ActivarIntentoIngreso(sender As Object, e As EventArgs) Handles isUsuario.TextChanged
        'Objetivo: Llama a la subrutina que habilita el boton de ingreso cuando ambos campos tienen contenido.
        activarBoton()
    End Sub
    Private Sub isClave_Leave(sender As Object, e As EventArgs) Handles isClave.Leave
        'Objetivo: Cambiar el color del campo de texto.
        colorTextbox(2, 0)
    End Sub
    Private Sub activar_IntentoIngreso(sender As Object, e As EventArgs) Handles isClave.TextChanged
        'Objetivo: Llama a la subrutina que habilita el boton de ingreso cuando ambos campos tienen contenido.
        activarBoton()
    End Sub
    Private Sub accesoPermitido(ByRef admin As Boolean)
        'Objetivo: Crea el formulario principal, recuerda que usuario ingresó y 
        'define si el usuario tiene o no permisos de administrador.
        adminPermisos = admin
        cuenta = isUsuario.Text.ToString
        Dim bdMainSesion As New bdMain
        bdMainSesion.Show()
        Me.Hide()
    End Sub
    'FUNCIONES FUNCIONALES------------------------------------------------------------------------------------
    Private Sub logIn()
        'Objetivo: Verifica las credenciales y llama a la subrutina que crea el formulario principal, 
        'señala errores en las credenciales y actualiza las señales de errores.
        lbClaveError.Hide()
        lbUsuarioError.Hide()

        Dim Usuario As String = isUsuario.Text
        Dim Clave As String = isClave.Text

        If Usuario = Usuario1 And Clave = Clave1 Then
            accesoPermitido(1)
        ElseIf Usuario = Usuario2 And Clave = Clave2 Then
            accesoPermitido(0)
        End If
        'Error
        If Usuario <> Usuario1 And Usuario <> Usuario2 Then
            lbUsuarioError.Show()
        End If
        'Error
        If Usuario = Usuario1 And Clave <> Clave1 Or Usuario = Usuario2 And Clave <> Clave2 Then
            lbClaveError.Show()
        End If
    End Sub
    'FUNCIONES GRÁFICAS---------------------------------------------------------------------------------------
    Private Sub colorTextbox(ByRef control As Short, ByRef evento As Boolean)
        'Objetivo: Cambia el color de los campos de texto, según si obtienen o pierden el foco.
        If control = 1 Then
            If evento = True Then
                isUsuario.ForeColor = Color.Black
                isUsuario.BackColor = Color.WhiteSmoke
            Else
                isUsuario.ForeColor = Color.DimGray
                isUsuario.BackColor = Color.Gainsboro
            End If
        Else
            If evento = True Then
                isClave.ForeColor = Color.Black
                isClave.BackColor = Color.WhiteSmoke
            Else
                isClave.ForeColor = Color.DimGray
                isClave.BackColor = Color.Gainsboro
            End If
        End If
    End Sub
    Private Sub activarBoton()
        'Objetivo: Habilita si los campos de texto tienen contenido o, en caso contrario, 
        'deshabilita el botón de ingreso y cambia su color según su estado. 
        If isUsuario.Text <> "" And isUsuario.Text <> "Usuario" And isClave.Text <> "" And isClave.Text <> "Contraseña" Then
            btnEntrar.BackColor = Color.DeepSkyBlue
            btnEntrar.ForeColor = Color.White
            btnEntrar.Enabled = True
        Else
            btnEntrar.BackColor = Color.White
            btnEntrar.ForeColor = Color.Black
            btnEntrar.Enabled = False
        End If
    End Sub
End Class
