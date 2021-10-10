Public Class bdPrestamos
    'WIP para posibles builds futuras, FORMULARIO NO UTILIZADO, Se aplicarían los mismos comentarios que la mayoría de los formularios
    'abm.
    Private Sub bdPrestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gridPrestamos()
    End Sub
    Public Sub gridPrestamos()
        Dim dsPrestamos As New DataSet
        Dim dtPrestamos As New DataTable
        Dim strsqlPrestamos As String = "SELECT id_detalle, id_prestamo, id_libro FROM Prestamos_detalle"
        Dim adpPrestamos As New OleDb.OleDbDataAdapter(strsqlPrestamos, conn)

        dsPrestamos.Tables.Add("Prestamos_detalle")
        adpPrestamos.Fill(dsPrestamos.Tables("Prestamos_detalle"))

        Me.dgPrestamos_detalle.DataSource = dsPrestamos.Tables("Prestamos_detalle")

        Me.dgPrestamos_detalle.Columns(0).HeaderText = "ID Prestamo"
        Me.dgPrestamos_detalle.Columns(1).HeaderText = "ID Detalle"
        Me.dgPrestamos_detalle.Columns(2).HeaderText = "ID Libro"
    End Sub
    Private Sub dgPrestamos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPrestamos_detalle.CellClick
        Dim indice As Integer
        indice = e.RowIndex

        Dim fila As DataGridViewRow
        fila = dgPrestamos_detalle.Rows(indice)

        id_detalleD.Text = fila.Cells(0).Value.ToString
        id_prestamoD.Text = fila.Cells(1).Value.ToString
        id_libroD.Text = fila.Cells(2).Value.ToString

    End Sub

    Private Sub dgPrestamos_Cell()
        Dim counter As Integer = 0

        'Dim fila As DataGridViewRow
        'fila = dgClientes.Rows(indice)

        Dim cell As DataGridViewCell

        For Each cell In dgPrestamos_detalle.SelectedCells
            If counter = 0 Then
                id_detalleD.Text = cell.Value.ToString
            ElseIf counter = 1 Then
                id_prestamoD.Text = cell.Value.ToString
            ElseIf counter = 2 Then
                id_libroD.Text = cell.Value.ToString
            End If
            counter = counter + 1
        Next
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrearD.Click
        If (Me.id_detalleD.Text = "") Then
            MsgBox("El campo identificacion no puede estar vacío", MsgBoxStyle.Critical)
            Me.id_detalleD.Select()

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

        Try
            cmd.ExecuteNonQuery()

            MsgBox("Registro insertado")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        gridPrestamos()

        Me.id_detalleD.Text = ""
        Me.id_prestamoD.Text = ""
        Me.id_libroD.Text = ""

        'If ex.tostring.contains("valores duplicados") Then
        'MsgBox("el registro ya existe")

        'Else
        ' MsgBox(ex.tostring)
        ' End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminarD.Click
        If (Me.id_detalleD.Text = "") Then
            MsgBox("El campo identificacion no puede estar vacío", MsgBoxStyle.Critical)
            Me.id_detalleD.Select()

        End If

        Dim id As Integer

        id = Me.id_detalleD.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = conn

        sql = "DELETE FROM Prestamos_detalle "
        sql += "WHERE id_detalle = " & id & " "

        'MsgBox(sql)

        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
            Me.id_detalleD.Text = ""
            Me.id_prestamoD.Text = ""
            Me.id_libroD.Text = ""
            MsgBox("Registro eliminado")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        gridPrestamos()

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificarD.Click
        If (Me.id_detalleD.Text = "") Then
            MsgBox("El campo identificacion no puede estar vacío", MsgBoxStyle.Critical)
            Me.id_detalleD.Select()

        End If

        Dim prestamo As Integer
        Dim id As String = ""
        Dim libro As String = ""


        id = Me.id_detalleD.Text
        prestamo = Me.id_prestamoD.Text
        libro = Me.id_libroD.Text


        cmd.CommandType = CommandType.Text
        cmd.Connection = conn

        sql = "UPDATE Prestamos_detalle SET  "
        sql += "id_prestamo = '" & prestamo & "', "
        sql += "id_libro = '" & libro & "' "

        sql += "WHERE id_detalle = " & id & " "

        'MsgBox(sql)

        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()

            MsgBox("Registro actualizado")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        gridPrestamos()

        Me.id_detalleD.Text = ""
        Me.id_prestamoD.Text = ""
        Me.id_libroD.Text = ""

    End Sub
End Class