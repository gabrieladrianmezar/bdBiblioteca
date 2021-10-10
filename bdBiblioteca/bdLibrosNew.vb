Public Class bdLibrosNew

    Dim toggledGrid As Boolean = True
    Dim toggleAu As Boolean = False
    Private Sub bdLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Objetivo: Actualiza la tabla revelante, colapsa el ABM de Autores del Libro y deshabilita los botones.
        gridLibros()
        eventoFeedback(5)
    End Sub
    Public Sub gridLibros()
        'Objetivo: Llena la tabla relevante.
        Dim dsLibro As New DataSet
        Dim dtLibro As New DataTable
        Dim strsqlLibro As String = "SELECT id_libro, isbn, titulo_libro, editorial_libro, publicacion_libro, edicion_libro, id_categoria FROM Libros"
        Dim adpLibro As New OleDb.OleDbDataAdapter(strsqlLibro, conn)

        dsLibro.Tables.Add("Libros")
        adpLibro.Fill(dsLibro.Tables("Libros"))

        Me.dgLibros.DataSource = dsLibro.Tables("Libros")

        'Cambia el texto de cabecera de las columnas.
        Me.dgLibros.Columns(0).HeaderText = "ID"
        Me.dgLibros.Columns(1).HeaderText = "ISBN"
        Me.dgLibros.Columns(2).HeaderText = "Titulo"
        Me.dgLibros.Columns(3).HeaderText = "Editorial"
        Me.dgLibros.Columns(4).HeaderText = "Publicacion"
        Me.dgLibros.Columns(5).HeaderText = "Edición"
        Me.dgLibros.Columns(6).HeaderText = "ID Categoria"
    End Sub
    Public Sub gridISBN_Autores()
        'Objetivo: Llena la tabla de Autores de Libro.
        Dim dsAutores As New DataSet
        Dim dtAutores As New DataTable
        'Si el campo de ISBN está vacio no llena la tabla.
        If isbn.Text = "" Then

        Else
            Dim strsqlAutores As String = "SELECT id_autor FROM ISBN_Autores WHERE isbn = '" & isbn.Text & "'"
            Dim adpAutores As New OleDb.OleDbDataAdapter(strsqlAutores, conn)

            dsAutores.Tables.Add("ISBNAutores")
            adpAutores.Fill(dsAutores.Tables("ISBNAutores"))

            Me.dgISBN_Autores.DataSource = dsAutores.Tables("ISBNAutores")

            Me.dgISBN_Autores.Columns(0).HeaderText = "ID Autor"
        End If
    End Sub
    Private Sub dgLibros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgLibros.CellClick
        'Objetivo: Completa los campos de texto según la celda clickeada.
        'Obtiene el indice de la fila a la que corresponde la celda.
        Dim indice As Integer
        indice = e.RowIndex
        'Evita errores al clickear la cabecera
        If (indice < 0) Then
            indice = 0
        End If

        Dim fila As DataGridViewRow
        fila = dgLibros.Rows(indice)

        'Llena los campos de texto con el valor de cada celda de la fila.
        id_libro.Text = fila.Cells(0).Value.ToString
        isbn.Text = fila.Cells(1).Value.ToString
        titulo_libro.Text = fila.Cells(2).Value.ToString
        editorial_libro.Text = fila.Cells(3).Value.ToString
        publicacion_libro.Text = fila.Cells(4).Value.ToString
        edicion_libro.Text = fila.Cells(5).Value.ToString
        id_categoria.Text = fila.Cells(6).Value.ToString
    End Sub
    Private Sub dgLibros_Cell()
        'Objetivo: Llena los campos de texto con el valor de cada celda seleccionada.
        Dim counter As Integer = 0

        Dim cell As DataGridViewCell

        For Each cell In dgLibros.SelectedCells
            If counter = 0 Then
                id_libro.Text = cell.Value.ToString
            ElseIf counter = 1 Then
                isbn.Text = cell.Value.ToString
            ElseIf counter = 2 Then
                titulo_libro.Text = cell.Value.ToString
            ElseIf counter = 3 Then
                editorial_libro.Text = cell.Value.ToString
            ElseIf counter = 4 Then
                publicacion_libro.Text = cell.Value.ToString
            ElseIf counter = 5 Then
                edicion_libro.Text = cell.Value.ToString
            ElseIf counter = 6 Then
                id_categoria.Text = cell.Value.ToString
            End If
            counter = counter + 1
        Next
    End Sub
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        'Objetivo: Inserta un registro en la tabla relevante.
        If (Me.id_libro.Text = "") Then
            fbSQL.Text = "El campo de ID no puede estar vacío"
            Me.id_libro.Select()
        End If

        Dim id As Integer
        Dim isb As String = ""
        Dim titulo As String = ""
        Dim editorial As String = ""
        Dim publicacion As String = ""
        Dim edicion As String = ""
        Dim idcategoria As String = ""

        id = Me.id_libro.Text
        isb = Me.isbn.Text
        titulo = Me.titulo_libro.Text
        editorial = Me.editorial_libro.Text
        publicacion = Me.publicacion_libro.Text
        edicion = Me.edicion_libro.Text
        idcategoria = Me.id_categoria.Text



        cmd.CommandType = CommandType.Text
        cmd.Connection = conn

        sql = "INSERT INTO Libros (id_libro, isbn, titulo_libro, editorial_libro, publicacion_libro, edicion_libro, id_categoria) VALUES (" & id & ",'" & isb & "', '" & titulo & "', '" & editorial & "', '" & publicacion & "', '" & edicion & "', '" & idcategoria & "')"
        'MsgBox(sql)

        cmd.CommandText = sql

        'Inserta el registro, actualiza la tabla relevante, y provee de retroalimentación.
        Try
            cmd.ExecuteNonQuery()
            gridLibros()
            eventoFeedback(2)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'Objetivo: Elimina un registro en la tabla relevante.
        If (Me.id_libro.Text = "") Then
            fbSQL.Text = "El campo de ID no puede estar vacío"
            Me.id_libro.Select()
        End If

        Dim id As Integer

        id = Me.id_libro.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = conn

        sql = "DELETE FROM Libros "
        sql += "WHERE id_libro = " & id & " "

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
                gridLibros()
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
        If (Me.id_libro.Text = "") Then
            fbSQL.Text = "El campo de ID no puede estar vacío"
            Me.id_libro.Select()
        End If

        Dim id As Integer
        Dim isbn As String = ""
        Dim titulo As String = ""
        Dim editorial As String = ""
        Dim publicacion As String = ""
        Dim edicion As String = ""
        Dim idcategoria As String = ""

        id = Me.id_libro.Text
        isbn = Me.isbn.Text
        titulo = Me.titulo_libro.Text
        editorial = Me.editorial_libro.Text
        publicacion = Me.publicacion_libro.Text
        edicion = Me.edicion_libro.Text
        idcategoria = Me.id_categoria.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = conn

        sql = "UPDATE Libros SET  "
        sql += "isbn = '" & isbn & "', "
        sql += "titulo_libro = '" & titulo & "', "
        sql += "editorial_libro = '" & editorial & "', "
        sql += "publicacion_libro = '" & publicacion & "', "
        sql += "edicion_libro = '" & edicion & "', "
        sql += "id_categoria = '" & idcategoria & "' "
        sql += "WHERE id_libro = " & id & " "
        'MsgBox(sql)


        cmd.CommandText = sql

        'Modifica el registro, actualiza la tabla relevante, vacía los campos y provee de retroalimentación.
        Try
            cmd.ExecuteNonQuery()
            gridLibros()
            vaciarCampos(1)
            eventoFeedback(4)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub id_cliente_TextChanged(sender As Object, e As EventArgs) Handles id_libro.TextChanged
        'Objetivo: Verificar si el id ingresado existe o no, habilitando su inserción
        'o eliminación y modificación respectivamente.
        If id_libro.Text <> "" Then

            Dim id As String
            id = id_libro.Text

            Dim existe As Boolean = False

            'Busca el id en cada fila de la tabla relevante, si existe llena los campos con sus datos y
            'llama a la subrutina que habilita su eliminación y modificación.
            For Each row In dgLibros.Rows
                If Convert.ToInt32(row.Cells(0).Value) = id_libro.Text Then
                    row.Selected = True
                    existe = True
                    eventoFeedback(1)
                    dgLibros.CurrentCell = row.Cells(0)
                    dgLibros_Cell()
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
            Me.id_libro.Text = ""
            Me.isbn.Text = ""
            Me.titulo_libro.Text = ""
            Me.editorial_libro.Text = ""
            Me.publicacion_libro.Text = ""
            Me.edicion_libro.Text = ""
            Me.id_categoria.Text = ""

            Me.id_autorA.Text = ""
            Me.isbnA.Text = ""
        Else
            Me.isbn.Text = ""
            Me.titulo_libro.Text = ""
            Me.editorial_libro.Text = ""
            Me.publicacion_libro.Text = ""
            Me.edicion_libro.Text = ""
            Me.id_categoria.Text = ""

            Me.id_autorA.Text = ""
            Me.isbnA.Text = ""
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
    Private Sub btnCrearA_Click(sender As Object, e As EventArgs) Handles btnCrearA.Click
        'Objetivo: Inserta un registro en la tabla de Autores de Libro.
        If (Me.id_libro.Text = "") Then
            fbSQL.Text = "El campo de ID no puede estar vacío"
            Me.id_libro.Select()
        End If

        Dim idAutores As Integer
        Dim isbnAutores As String = ""

        idAutores = Me.id_autorA.Text
        isbnAutores = Me.isbnA.Text


        cmd.CommandType = CommandType.Text
        cmd.Connection = conn

        sql = "INSERT INTO ISBN_Autores (isbn, id_autor) VALUES (" & isbnAutores & ", '" & idAutores & "')"
        'MsgBox(sql)

        cmd.CommandText = sql

        'Inserta el registro y actualiza la tabla relevante.
        Try
            cmd.ExecuteNonQuery()
            gridISBN_Autores()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btnLlenar_Click(sender As Object, e As EventArgs) Handles btnLlenar.Click
        'Objetivo: Prepara la inserción del siguiente registro.
        vaciarCampos(1)
        Dim counterSiguiente As Integer = 0
        For Each row In dgLibros.Rows
            counterSiguiente = counterSiguiente + 1
        Next
        id_libro.Text = counterSiguiente.ToString
    End Sub
    Private Sub isbn_TextChanged(sender As Object, e As EventArgs) Handles isbn.TextChanged
        'Objetivo: El campo de ISBN de Autores de Libro actualiza su contenido en relación al campo
        'ISBN de Libro.
        isbnA.Text = isbn.Text
        gridISBN_Autores()
    End Sub
    Private Sub btnEliminarA_Click(sender As Object, e As EventArgs) Handles btnEliminarA.Click
        'Objetivo: Elimina un registro de la tabla de Autores de Libro.
        If (Me.id_libro.Text = "") Then
            fbSQL.Text = "El campo de ID no puede estar vacío"
            Me.id_libro.Select()
        End If

        Dim isbnAutores As String = ""
        Dim idAutores As String = ""

        isbnAutores = Me.isbnA.Text
        idAutores = Me.id_autorA.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = conn

        sql = "DELETE FROM ISBN_Autores "
        sql += "WHERE isbn = '" & isbnAutores & "' AND id_autor = " & idAutores & " "

        'MsgBox(sql)

        cmd.CommandText = sql

        'Elimina el registro y actualiza la tabla relevante
        Try
            cmd.ExecuteNonQuery()
            gridISBN_Autores()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class