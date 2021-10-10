Public Class bdAutores
    Dim toggledGrid As Boolean = True
    Private Sub bdAutores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Objetivo: Actualiza la tabla revelante y deshabilita los botones.
        gridAutores()
        eventoFeedback(5)
    End Sub
    Public Sub gridAutores()
        'Objetivo: Llena la tabla relevante.
        Dim dsAutor As New DataSet
        Dim dtAutor As New DataTable
        Dim strsqlAutor As String = "SELECT id_autor, nombre_autor, apellido_autor FROM Autores"
        Dim adpAutor As New OleDb.OleDbDataAdapter(strsqlAutor, conn)

        dsAutor.Tables.Add("Autores")
        adpAutor.Fill(dsAutor.Tables("Autores"))

        Me.dgAutores.DataSource = dsAutor.Tables("Autores")

        'Cambia el texto de cabecera de las columnas.
        Me.dgAutores.Columns(0).HeaderText = "ID"
        Me.dgAutores.Columns(1).HeaderText = "Nombre"
        Me.dgAutores.Columns(2).HeaderText = "Apellido"
    End Sub
    Private Sub dgAutores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgAutores.CellClick
        'Objetivo: Completa los campos de texto según la celda clickeada.
        'Obtiene el indice de la fila a la que corresponde la celda.
        Dim indice As Integer
        indice = e.RowIndex
        'Evita errores al clickear la cabecera
        If (indice < 0) Then
            indice = 0
        End If

        Dim fila As DataGridViewRow
        fila = dgAutores.Rows(indice)

        'Llena los campos de texto con el valor de cada celda de la fila.
        id_autor.Text = fila.Cells(0).Value.ToString
        nombre_autor.Text = fila.Cells(1).Value.ToString
        apellido_autor.Text = fila.Cells(2).Value.ToString
    End Sub
    Private Sub dgAutores_Cell()
        'Objetivo: Llena los campos de texto con el valor de cada celda seleccionada.
        Dim counter As Integer = 0

        Dim cell As DataGridViewCell

        For Each cell In dgAutores.SelectedCells
            If counter = 0 Then
                id_autor.Text = cell.Value.ToString
            ElseIf counter = 1 Then
                nombre_autor.Text = cell.Value.ToString
            ElseIf counter = 2 Then
                apellido_autor.Text = cell.Value.ToString
            End If
            counter = counter + 1
        Next
    End Sub
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        'Objetivo: Inserta un registro en la tabla relevante.
        If (Me.id_autor.Text = "") Then
            fbSQL.Text = "El campo de ID no puede estar vacío"
            Me.id_autor.Select()

        End If

        Dim id As Integer
        Dim nombres As String = ""
        Dim apellidos As String = ""
        Dim dni As String = ""
        Dim direcciones As String = ""
        Dim telefono As String = ""

        id = Me.id_autor.Text
        nombres = Me.nombre_autor.Text
        apellidos = Me.apellido_autor.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = conn

        sql = "INSERT INTO Autores (id_autor, nombre_autor, apellido_autor) VALUES (" & id & ",'" & nombres & "', '" & apellidos & "')"
        'MsgBox(sql)

        cmd.CommandText = sql

        'Inserta el registro, actualiza la tabla relevante, vacía los campos y provee de retroalimentación.
        Try
            cmd.ExecuteNonQuery()
            gridAutores()
            eventoFeedback(2)
            vaciarCampos(1)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'Objetivo: Elimina un registro en la tabla relevante.
        If (Me.id_autor.Text = "") Then
            fbSQL.Text = "El campo de ID no puede estar vacío"
            Me.id_autor.Select()

        End If

        Dim id As Integer

        id = Me.id_autor.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = conn

        sql = "DELETE FROM Autores "
        sql += "WHERE id_autor = " & id & " "
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
                gridAutores()
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
        If (Me.id_autor.Text = "") Then
            fbSQL.Text = "El campo de ID no puede estar vacío"
            Me.id_autor.Select()

        End If

        Dim id As Integer
        Dim nombres As String = ""
        Dim apellidos As String = ""

        id = Me.id_autor.Text
        nombres = Me.nombre_autor.Text
        apellidos = Me.apellido_autor.Text


        cmd.CommandType = CommandType.Text
        cmd.Connection = conn

        sql = "UPDATE Autores SET  "
        sql += "nombre_autor = '" & nombres & "', "
        sql += "apellido_autor = '" & apellidos & "' "
        sql += "WHERE id_autor = " & id & " "
        'MsgBox(sql)

        cmd.CommandText = sql

        'Modifica el registro, actualiza la tabla relevante, vacía los campos y provee de retroalimentación.
        Try
            cmd.ExecuteNonQuery()
            gridAutores()
            vaciarCampos(1)
            eventoFeedback(4)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub id_cliente_TextChanged(sender As Object, e As EventArgs) Handles id_autor.TextChanged
        'Objetivo: Verificar si el id ingresado existe o no, habilitando su inserción
        'o eliminación y modificación respectivamente.
        If id_autor.Text <> "" Then

            Dim id As String
            id = id_autor.Text

            Dim existe As Boolean = False

            'Busca el id en cada fila de la tabla relevante, si existe llena los campos con sus datos y
            'llama a la subrutina que habilita su eliminación y modificación.
            For Each row In dgAutores.Rows
                If Convert.ToInt32(row.Cells(0).Value) = id_autor.Text Then
                    fbSQL.Text = ""
                    row.Selected = True
                    existe = True
                    eventoFeedback(1)
                    dgAutores.CurrentCell = row.Cells(0)
                    dgAutores_Cell()
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
            Me.id_autor.Text = ""
            Me.nombre_autor.Text = ""
            Me.apellido_autor.Text = ""
        Else
            Me.nombre_autor.Text = ""
            Me.apellido_autor.Text = ""
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
            dgAutores.Show()
            Me.Size = New Size(707, 291)
            toggledGrid = True
        Else
            dgAutores.Hide()
            Me.Size = New Size(351, 291)
            toggledGrid = False
        End If
    End Sub
    Private Sub btnLlenar_Click(sender As Object, e As EventArgs) Handles btnLlenar.Click
        'Objetivo: Prepara la inserción del siguiente registro.
        vaciarCampos(1)
        Dim counterSiguiente As Integer = 0
        For Each row In dgAutores.Rows
            counterSiguiente = counterSiguiente + 1
        Next
        id_autor.Text = counterSiguiente.ToString
    End Sub
End Class
