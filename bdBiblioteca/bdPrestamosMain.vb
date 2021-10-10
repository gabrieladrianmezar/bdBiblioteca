Public Class bdPrestamosMain
    'WIP para posibles builds futuras, FORMULARIO NO UTILIZADO, Se aplicarían los mismos comentarios que la mayoría de los formularios
    'abm.
    Private Sub bdPrestamosMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gridPrestamos()
    End Sub
    Private Sub bdPrestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gridPrestamos()
    End Sub
    Public Sub gridPrestamos()
        Dim dsPrestamos As New DataSet
        Dim dtPrestamos As New DataTable
        Dim strsqlPrestamos As String = "SELECT id_prestamo, id_cliente, id_empleado, desde, hasta FROM Prestamos"
        Dim adpPrestamos As New OleDb.OleDbDataAdapter(strsqlPrestamos, conn)

        dsPrestamos.Tables.Add("Prestamos")
        adpPrestamos.Fill(dsPrestamos.Tables("Prestamos"))

        Me.dgPrestamos.DataSource = dsPrestamos.Tables("Prestamos")

        Me.dgPrestamos.Columns(0).HeaderText = "ID"
        Me.dgPrestamos.Columns(1).HeaderText = "ID Cliente"
        Me.dgPrestamos.Columns(2).HeaderText = "ID Empleado"
        Me.dgPrestamos.Columns(3).HeaderText = "Desde"
        Me.dgPrestamos.Columns(4).HeaderText = "Hasta"
    End Sub
    Private Sub dgPrestamos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPrestamos.CellClick
        Dim indice As Integer
        indice = e.RowIndex

        Dim fila As DataGridViewRow
        fila = dgPrestamos.Rows(indice)

        id_prestamo.Text = fila.Cells(0).Value.ToString
        id_cliente.Text = fila.Cells(1).Value.ToString
        id_empleado.Text = fila.Cells(2).Value.ToString
        desde.Text = fila.Cells(3).Value.ToString
    End Sub
    Private Sub dgPrestamos_Cell()
        Dim counter As Integer = 0

        Dim cell As DataGridViewCell

        For Each cell In dgPrestamos.SelectedCells
            If counter = 0 Then
                id_prestamo.Text = cell.Value.ToString
            ElseIf counter = 1 Then
                id_cliente.Text = cell.Value.ToString
            ElseIf counter = 2 Then
                id_empleado.Text = cell.Value.ToString
            ElseIf counter = 3 Then
                desde.Text = cell.Value.ToString
            End If
            counter = counter + 1
        Next
    End Sub
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        If (Me.id_prestamo.Text = "") Then
            fbSQL.Text = "El campo de ID no puede estar vacío"
            Me.id_prestamo.Select()
        End If

        Dim id As Integer
        Dim prestamo As String = ""
        Dim libro As String = ""
        Dim isbn As String = ""

        id = Me.id_prestamo.Text
        prestamo = Me.id_cliente.Text
        libro = Me.id_empleado.Text
        isbn = Me.desde.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = conn

        sql = "INSERT INTO Prestamos_detalle (id_detalle, id_prestamo, id_libro, isbn_libro) VALUES (" & id & ",'" & prestamo & "', '" & libro & "', '" & isbn & "')"
        'MsgBox(sql)

        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
            gridPrestamos()
            eventoFeedback(2)
            vaciarCampos(1)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (Me.id_prestamo.Text = "") Then
            fbSQL.Text = ("El campo de ID no puede estar vacío")
            Me.id_prestamo.Select()
        End If

        Dim id As Integer

        id = Me.id_prestamo.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = conn

        sql = "DELETE FROM Prestamos_detalle "
        sql += "WHERE id_detalle = " & id & " "
        'MsgBox(sql)

        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
            gridPrestamos()
            vaciarCampos(1)
            eventoFeedback(3)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If (Me.id_prestamo.Text = "") Then
            fbSQL.Text = "El campo de ID no puede estar vacío"
            Me.id_prestamo.Select()
        End If

        Dim prestamo As Integer
        Dim id As String = ""
        Dim libro As String = ""
        Dim isbn As String = ""


        id = Me.id_prestamo.Text
        prestamo = Me.id_cliente.Text
        libro = Me.id_empleado.Text
        isbn = Me.desde.Text


        cmd.CommandType = CommandType.Text
        cmd.Connection = conn

        sql = "UPDATE Prestamos_detalle SET  "
        sql += "id_prestamo = '" & prestamo & "', "
        sql += "id_libro = '" & libro & "', "
        sql += "isbn_libro = '" & isbn & "' "
        sql += "WHERE id_detalle = " & id & " "
        'MsgBox(sql)

        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
            gridPrestamos()
            vaciarCampos(1)
            eventoFeedback(4)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub id_prestamo_TextChanged(sender As Object, e As EventArgs) Handles id_prestamo.TextChanged
        If id_prestamo.Text <> "" Then

            Dim id As String
            id = id_prestamo.Text

            Dim existe As Boolean = False

            For Each row In dgPrestamos.Rows
                If Convert.ToInt32(row.Cells(0).Value) = id_prestamo.Text Then
                    fbSQL.Text = ""
                    row.Selected = True
                    existe = True
                    eventoFeedback(1)
                    dgPrestamos.CurrentCell = row.Cells(0)
                    dgPrestamos_Cell()
                    Exit For
                End If
            Next

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
    Private Sub eventoFeedback(ByRef tipo As Short)
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
End Class