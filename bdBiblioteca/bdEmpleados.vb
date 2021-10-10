Public Class bdEmpleados
    Dim toggledGrid As Boolean = True
    Private Sub bdEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Objetivo: Actualiza la tabla revelante y deshabilita los botones.
        gridEmpleados()
        eventoFeedback(5)
    End Sub
    Public Sub gridEmpleados()
        'Objetivo: Llena la tabla relevante.
        Dim dsEmpleado As New DataSet
        Dim dtEmpleado As New DataTable
        Dim strsqlEmpleado As String = "SELECT id_empleado, nombre_empleado, apellido_empleado, dni_empleado, cuit_empleado, direccion_empleado, telefono_empleado FROM Empleados"
        Dim adpEmpleado As New OleDb.OleDbDataAdapter(strsqlEmpleado, conn)

        dsEmpleado.Tables.Add("Empleados")
        adpEmpleado.Fill(dsEmpleado.Tables("Empleados"))

        Me.dgEmpleados.DataSource = dsEmpleado.Tables("Empleados")

        'Cambia el texto de cabecera de las columnas.
        Me.dgEmpleados.Columns(0).HeaderText = "ID"
        Me.dgEmpleados.Columns(1).HeaderText = "Nombre"
        Me.dgEmpleados.Columns(2).HeaderText = "Apellido"
        Me.dgEmpleados.Columns(3).HeaderText = "DNI"
        Me.dgEmpleados.Columns(4).HeaderText = "CUIT"
        Me.dgEmpleados.Columns(5).HeaderText = "Dirección"
        Me.dgEmpleados.Columns(6).HeaderText = "Teléfono"
    End Sub
    Private Sub dgEmpleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEmpleados.CellClick
        'Objetivo: Completa los campos de texto según la celda clickeada.
        'Obtiene el indice de la fila a la que corresponde la celda.
        Dim indice As Integer
        indice = e.RowIndex
        'Evita errores al clickear la cabecera
        If (indice < 0) Then
            indice = 0
        End If

        Dim fila As DataGridViewRow
        fila = dgEmpleados.Rows(indice)

        'Llena los campos de texto con el valor de cada celda de la fila.
        id_empleado.Text = fila.Cells(0).Value.ToString
        nombre_empleado.Text = fila.Cells(1).Value.ToString
        apellido_empleado.Text = fila.Cells(2).Value.ToString
        dni_empleado.Text = fila.Cells(3).Value.ToString
        cuit_empleado.Text = fila.Cells(4).Value.ToString
        direccion_empleado.Text = fila.Cells(5).Value.ToString
        telefono_empleado.Text = fila.Cells(6).Value.ToString
    End Sub
    Private Sub dgEmpleados_Cell()
        'Objetivo: Llena los campos de texto con el valor de cada celda seleccionada.
        Dim counter As Integer = 0

        Dim cell As DataGridViewCell

        For Each cell In dgEmpleados.SelectedCells
            If counter = 0 Then
                id_empleado.Text = cell.Value.ToString
            ElseIf counter = 1 Then
                nombre_empleado.Text = cell.Value.ToString
            ElseIf counter = 2 Then
                apellido_empleado.Text = cell.Value.ToString
            ElseIf counter = 3 Then
                dni_empleado.Text = cell.Value.ToString
            ElseIf counter = 4 Then
                cuit_empleado.Text = cell.Value.ToString
            ElseIf counter = 5 Then
                direccion_empleado.Text = cell.Value.ToString
            ElseIf counter = 6 Then
                telefono_empleado.Text = cell.Value.ToString
            End If
            counter = counter + 1
        Next
    End Sub
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        'Objetivo: Inserta un registro en la tabla relevante.
        If (Me.id_empleado.Text = "") Then
            fbSQL.Text = "El campo de ID no puede estar vacío"
            Me.id_empleado.Select()
        End If

        Dim id As Integer
        Dim nombres As String = ""
        Dim apellidos As String = ""
        Dim dni As String = ""
        Dim cuit As String = ""
        Dim direcciones As String = ""
        Dim telefono As String = ""

        id = Me.id_empleado.Text
        nombres = Me.nombre_empleado.Text
        apellidos = Me.apellido_empleado.Text
        dni = Me.dni_empleado.Text
        cuit = Me.cuit_empleado.Text
        direcciones = Me.direccion_empleado.Text
        telefono = Me.telefono_empleado.Text



        cmd.CommandType = CommandType.Text
        cmd.Connection = conn

        sql = "INSERT INTO Empleados (id_empleado, nombre_empleado, apellido_empleado, dni_empleado, cuit_empleado, direccion_empleado, telefono_empleado) VALUES (" & id & ",'" & nombres & "', '" & apellidos & "', '" & dni & "', '" & cuit & "', '" & direcciones & "', '" & telefono & "')"
        'MsgBox(sql)

        cmd.CommandText = sql

        'Inserta el registro, actualiza la tabla relevante, vacía los campos y provee de retroalimentación.
        Try
            cmd.ExecuteNonQuery()
            gridEmpleados()
            eventoFeedback(2)
            vaciarCampos(1)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'Objetivo: Elimina un registro en la tabla relevante.
        If (Me.id_empleado.Text = "") Then
            fbSQL.Text = "El campo de ID no puede estar vacío"
            Me.id_empleado.Select()
        End If

        Dim id As Integer

        id = Me.id_empleado.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = conn

        sql = "DELETE FROM Empleados "
        sql += "WHERE id_empleado = " & id & " "
        'MsgBox(sql)

        'Llama a una ventana emergente que nos pide confirmar la eliminación.
        dialogAdvertencia()
    End Sub
    Public Sub dialogAdvertencia()
        'Objetivo: Eliminar o no el registro en relación a que botón seleccionemos.
        Dim dialogAdver As New popAdvertencia

        'Si: Elimina el registro, actualiza la tabla relevante, vacía los campos y provee de retroalimentación.
        'No: Cancela la eliminación del registro.
        If dialogAdver.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            cmd.CommandText = sql
            Try
                cmd.ExecuteNonQuery()
                gridEmpleados()
                vaciarCampos(1)
                eventoFeedback(3)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            fbSQL.Text = "Eliminación cancelada"
        End If
        dialogAdver.Dispose()
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        'Objetivo: Modifica un registro en la tabla relevante.
        If (Me.id_empleado.Text = "") Then
            fbSQL.Text = "El campo de ID no puede estar vacío"
            Me.id_empleado.Select()
        End If

        Dim id As Integer
        Dim nombres As String = ""
        Dim apellidos As String = ""
        Dim dni As String = ""
        Dim cuit As String = ""
        Dim direccion As String = ""
        Dim telefono As String = ""

        id = Me.id_empleado.Text
        nombres = Me.nombre_empleado.Text
        apellidos = Me.apellido_empleado.Text
        dni = Me.dni_empleado.Text
        cuit = Me.cuit_empleado.Text
        direccion = Me.direccion_empleado.Text
        telefono = Me.telefono_empleado.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = conn

        sql = "UPDATE Empleados SET  "
        sql += "nombre_empleado = '" & nombres & "', "
        sql += "apellido_empleado = '" & apellidos & "', "
        sql += "dni_empleado = '" & dni & "', "
        sql += "cuit_empleado = '" & cuit & "', "
        sql += "direccion_empleado = '" & direccion & "', "
        sql += "telefono_empleado = '" & telefono & "' "
        sql += "WHERE id_empleado = " & id & " "
        'MsgBox(sql)

        cmd.CommandText = sql

        'Modifica el registro, actualiza la tabla relevante, vacía los campos y provee de retroalimentación.
        Try
            cmd.ExecuteNonQuery()
            gridEmpleados()
            vaciarCampos(1)
            eventoFeedback(4)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub id_cliente_TextChanged(sender As Object, e As EventArgs) Handles id_empleado.TextChanged
        'Objetivo: Verificar si el id ingresado existe o no, habilitando su inserción
        'o eliminación y modificación respectivamente.
        If id_empleado.Text <> "" Then

            Dim id As String
            id = id_empleado.Text

            Dim existe As Boolean = False

            'Busca el id en cada fila de la tabla relevante, si existe llena los campos con sus datos y
            'llama a la subrutina que habilita su eliminación y modificación.
            For Each row In dgEmpleados.Rows
                If Convert.ToInt32(row.Cells(0).Value) = id_empleado.Text Then
                    row.Selected = True
                    existe = True
                    eventoFeedback(1)
                    dgEmpleados.CurrentCell = row.Cells(0)
                    dgEmpleados_Cell()
                    Exit For
                End If
            Next

            'Si no existe vacía el resto de los campos y llama a la subrutina que habilita la inserción.
            If existe = False Then
                eventoFeedback(0)
                vaciarCampos(0)
            End If

        Else
            eventoFeedback(5)
            vaciarCampos(1)
        End If
    End Sub
    Private Sub vaciarCampos(ByRef modo As Boolean)
        'Objetivo: Vacia los campos de texto de relevantes, contando o no el id principal.
        If modo Then
            Me.id_empleado.Text = ""
            Me.nombre_empleado.Text = ""
            Me.apellido_empleado.Text = ""
            Me.dni_empleado.Text = ""
            Me.cuit_empleado.Text = ""
            Me.direccion_empleado.Text = ""
            Me.telefono_empleado.Text = ""
        Else
            Me.nombre_empleado.Text = ""
            Me.apellido_empleado.Text = ""
            Me.dni_empleado.Text = ""
            Me.cuit_empleado.Text = ""
            Me.direccion_empleado.Text = ""
            Me.telefono_empleado.Text = ""
        End If
    End Sub
    Private Sub eventoFeedback(ByRef tipo As Short)
        'Objetivo: Provee de retroalimentación basado en la inexistencia o existencia de registros así 
        'como su inserción, eliminación y modificación
        If tipo = 0 Then
            fbSQL.Text = "Registro inexistente"
            btnCrear.Enabled = True
            btnEliminar.Enabled = False
            btnModificar.Enabled = False
        ElseIf tipo = 1 Then
            fbSQL.Text = "Registro existente"
            btnCrear.Enabled = False
            btnEliminar.Enabled = True
            btnModificar.Enabled = True
        ElseIf tipo = 2 Then
            fbSQL.Text = "Registro insertado"
            btnCrear.Enabled = False
            btnEliminar.Enabled = False
            btnModificar.Enabled = False
        ElseIf tipo = 3 Then
            fbSQL.Text = "Registro eliminado"
            btnCrear.Enabled = False
            btnEliminar.Enabled = False
            btnModificar.Enabled = False
        ElseIf tipo = 4 Then
            fbSQL.Text = "Registro actualizado"
            btnCrear.Enabled = False
            btnEliminar.Enabled = False
            btnModificar.Enabled = False
        Else
            fbSQL.Text = ""
            btnCrear.Enabled = False
            btnEliminar.Enabled = False
            btnModificar.Enabled = False
        End If
    End Sub
    Private Sub toggleGrid_Click(sender As Object, e As EventArgs) Handles toggleGrid.Click
        'Objetivo: Colapsa o muestra la tabla relevante.
        If toggledGrid = False Then
            dgEmpleados.Show()
            Me.Size = New Size(803, 475)
            toggledGrid = True
        Else
            dgEmpleados.Hide()
            Me.Size = New Size(339, 475)
            toggledGrid = False
        End If
    End Sub
    Private Sub btnLlenar_Click(sender As Object, e As EventArgs) Handles btnLlenar.Click
        'Objetivo: Prepara la inserción del siguiente registro.
        vaciarCampos(1)
        Dim counterSiguiente As Integer = 0
        For Each row In dgEmpleados.Rows
            counterSiguiente = counterSiguiente + 1
        Next
        id_empleado.Text = counterSiguiente.ToString
    End Sub
End Class