Public Class bdClientes
    Dim toggledGrid As Boolean = True
    Private Sub bdClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Objetivo: Actualiza la tabla revelante y deshabilita los botones.
        gridClientes()
        eventoFeedback(5)
    End Sub
    Public Sub gridClientes()
        'Objetivo: Llena la tabla relevante.
        Dim dsCliente As New DataSet
        Dim dtCliente As New DataTable
        Dim strsqlCliente As String = "SELECT id_cliente, nombre_cliente, apellido_cliente, dni_cliente, direccion_cliente, telefono_cliente FROM Clientes"
        Dim adpCliente As New OleDb.OleDbDataAdapter(strsqlCliente, conn)

        dsCliente.Tables.Add("Clientes")
        adpCliente.Fill(dsCliente.Tables("Clientes"))

        Me.dgClientes.DataSource = dsCliente.Tables("Clientes")

        'Cambia el texto de cabecera de las columnas.
        Me.dgClientes.Columns(0).HeaderText = "ID"
        Me.dgClientes.Columns(1).HeaderText = "Nombre"
        Me.dgClientes.Columns(2).HeaderText = "Apellido"
        Me.dgClientes.Columns(3).HeaderText = "DNI"
        Me.dgClientes.Columns(4).HeaderText = "Dirección"
        Me.dgClientes.Columns(5).HeaderText = "Teléfono"
    End Sub
    Private Sub dgClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgClientes.CellClick
        'Objetivo: Completa los campos de texto según la celda clickeada.
        'Obtiene el indice de la fila a la que corresponde la celda.
        Dim indice As Integer
        indice = e.RowIndex
        'Evita errores al clickear la cabecera
        If (indice < 0) Then
            indice = 0
        End If

        Dim fila As DataGridViewRow
        fila = dgClientes.Rows(indice)

        'Llena los campos de texto con el valor de cada celda de la fila.
        id_cliente.Text = fila.Cells(0).Value.ToString
        nombre_cliente.Text = fila.Cells(1).Value.ToString
        apellido_cliente.Text = fila.Cells(2).Value.ToString
        dni_cliente.Text = fila.Cells(3).Value.ToString
        direccion_cliente.Text = fila.Cells(4).Value.ToString
        telefono_cliente.Text = fila.Cells(5).Value.ToString
    End Sub
    Private Sub dgClientes_Cell()
        'Objetivo: Llena los campos de texto con el valor de cada celda seleccionada.
        Dim counter As Integer = 0

        Dim cell As DataGridViewCell

        For Each cell In dgClientes.SelectedCells
            If counter = 0 Then
                id_cliente.Text = cell.Value.ToString
            ElseIf counter = 1 Then
                nombre_cliente.Text = cell.Value.ToString
            ElseIf counter = 2 Then
                apellido_cliente.Text = cell.Value.ToString
            ElseIf counter = 3 Then
                dni_cliente.Text = cell.Value.ToString
            ElseIf counter = 4 Then
                direccion_cliente.Text = cell.Value.ToString
            ElseIf counter = 5 Then
                telefono_cliente.Text = cell.Value.ToString
            End If
            counter = counter + 1
        Next
    End Sub
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        'Objetivo: Inserta un registro en la tabla relevante.
        If (Me.id_cliente.Text = "") Then
            fbSQL.Text = "El campo de ID no puede estar vacío"
            Me.id_cliente.Select()
        End If

        Dim id As Integer
        Dim nombres As String = ""
        Dim apellidos As String = ""
        Dim dni As String = ""
        Dim direcciones As String = ""
        Dim telefono As String = ""

        id = Me.id_cliente.Text
        nombres = Me.nombre_cliente.Text
        apellidos = Me.apellido_cliente.Text
        dni = Me.dni_cliente.Text
        direcciones = Me.direccion_cliente.Text
        telefono = Me.telefono_cliente.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = conn

        sql = "INSERT INTO Clientes (id_cliente, nombre_cliente, apellido_cliente, dni_cliente, direccion_cliente, telefono_cliente) VALUES (" & id & ",'" & nombres & "', '" & apellidos & "', '" & dni & "', '" & direcciones & "', '" & telefono & "')"
        'MsgBox(sql)

        cmd.CommandText = sql

        'Inserta el registro, actualiza la tabla relevante, vacía los campos y provee de retroalimentación.
        Try
            cmd.ExecuteNonQuery()
            gridClientes()
            eventoFeedback(2)
            vaciarCampos(1)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'Objetivo: Elimina un registro en la tabla relevante.
        If (Me.id_cliente.Text = "") Then
            fbSQL.Text = "El campo de ID no puede estar vacío"
            Me.id_cliente.Select()

        End If

        Dim id As Integer

        id = Me.id_cliente.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = conn

        sql = "DELETE FROM Clientes "
        sql += "WHERE id_cliente = " & id & " "
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
                gridClientes()
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
        If (Me.id_cliente.Text = "") Then
            fbSQL.Text = "El campo de ID no puede estar vacío"
            Me.id_cliente.Select()
        End If

        Dim id As Integer
        Dim nombres As String = ""
        Dim apellidos As String = ""
        Dim dni As String = ""
        Dim direccion As String = ""
        Dim telefono As String = ""

        id = Me.id_cliente.Text
        nombres = Me.nombre_cliente.Text
        apellidos = Me.apellido_cliente.Text
        dni = Me.dni_cliente.Text
        direccion = Me.direccion_cliente.Text
        telefono = Me.telefono_cliente.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = conn

        sql = "UPDATE Clientes SET  "
        sql += "nombre_cliente = '" & nombres & "', "
        sql += "apellido_cliente = '" & apellidos & "', "
        sql += "dni_cliente = '" & dni & "', "
        sql += "direccion_cliente = '" & direccion & "', "
        sql += "telefono_cliente = '" & telefono & "' "
        sql += "WHERE id_cliente = " & id & " "
        'MsgBox(sql)

        cmd.CommandText = sql

        'Modifica el registro, actualiza la tabla relevante, vacía los campos y provee de retroalimentación.
        Try
            cmd.ExecuteNonQuery()
            gridClientes()
            vaciarCampos(1)
            eventoFeedback(4)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub id_cliente_TextChanged(sender As Object, e As EventArgs) Handles id_cliente.TextChanged
        'Objetivo: Verificar si el id ingresado existe o no, habilitando su inserción
        'o eliminación y modificación respectivamente.
        If id_cliente.Text <> "" Then

            Dim id As String
            id = id_cliente.Text

            Dim existe As Boolean = False

            'Busca el id en cada fila de la tabla relevante, si existe llena los campos con sus datos y
            'llama a la subrutina que habilita su eliminación y modificación.
            For Each row In dgClientes.Rows
                If Convert.ToInt32(row.Cells(0).Value) = id_cliente.Text Then
                    fbSQL.Text = ""
                    row.Selected = True
                    existe = True
                    eventoFeedback(1)
                    dgClientes.CurrentCell = row.Cells(0)
                    dgClientes_Cell()
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
            Me.id_cliente.Text = ""
            Me.nombre_cliente.Text = ""
            Me.apellido_cliente.Text = ""
            Me.dni_cliente.Text = ""
            Me.direccion_cliente.Text = ""
            Me.telefono_cliente.Text = ""
        Else
            Me.nombre_cliente.Text = ""
            Me.apellido_cliente.Text = ""
            Me.dni_cliente.Text = ""
            Me.direccion_cliente.Text = ""
            Me.telefono_cliente.Text = ""
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
            dgClientes.Show()
            Me.Size = New Size(806, 407)
            toggledGrid = True
        Else
            dgClientes.Hide()
            Me.Size = New Size(339, 407)
            toggledGrid = False
        End If
    End Sub
    Private Sub btnLlenar_Click(sender As Object, e As EventArgs) Handles btnLlenar.Click
        'Objetivo: Prepara la inserción del siguiente registro.
        vaciarCampos(1)
        Dim counterSiguiente As Integer = 0
        For Each row In dgClientes.Rows
            counterSiguiente = counterSiguiente + 1
        Next
        id_cliente.Text = counterSiguiente.ToString
    End Sub
End Class