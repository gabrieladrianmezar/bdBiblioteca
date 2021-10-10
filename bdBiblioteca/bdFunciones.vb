Module bdFunciones
    'VARIABLES GLOBALES
    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=bdBiblioteca.accdb;Persist Security Info=False")
    Public cmd As New OleDb.OleDbCommand
    Public dr As OleDb.OleDbDataReader
    Public sql As String
    Public adminPermisos As Boolean
    Public cuenta As String
    Public popDelete As Boolean = False
    Public Sub conectarse()
        If conn.State = ConnectionState.Closed Then
            Try
                conn.Open()
            Catch ex As Exception
                MsgBox(ex.ToString & "AYAYAYAYA")
            End Try
        ElseIf conn.State = ConnectionState.Open Then

        End If
    End Sub
    Public Sub consultarCliente(ByRef id As String)
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        If id <> "" Then
            cmd.CommandText = "SELECT nombre_cliente, apellido_cliente, dni_cliente, direccion_cliente, telefono_cliente FROM Clientes WHERE id_cliente=" + id
        Else
            cmd.CommandText = "SELECT nombre_cliente, apellido_cliente, dni_cliente, direccion_cliente, telefono_cliente FROM Clientes"
        End If

        Try
            dr = cmd.ExecuteReader()
            dr.Read()
            If dr.HasRows Then
                While dr.Read()
                    MsgBox(dr("nombre_cliente").ToString + " " + dr("apellido_cliente").ToString + " " + dr("dni_cliente").ToString + " " + dr("direccion_cliente").ToString + " " + dr("telefono_cliente"))
                End While
            Else
                MsgBox("No existen registros para la consulta")
            End If
            dr.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub comentarios()
        'Rellenar campos cuando se aprieta Enter

        'Private Sub id_cliente_KeyDown(sender As Object, e As KeyEventArgs) Handles id_cliente.KeyDown
        'If e.KeyData = Keys.Enter Then
        'Dim id As String
        'id = id_cliente.Text
        'Dim existe As Boolean = False

        'For Each row In dgClientes.Rows
        'If Convert.ToInt32(row.Cells(0).Value) = id_cliente.Text Then
        'row.Selected = True
        'existe = True
        'eventoFeedback(1)
        'dgClientes.CurrentCell = row.Cells(0)
        'dgClientes_Cell()
        'Exit For
        'End If
        'Next

        'If existe = False Then
        'eventoFeedback(0)
        'vaciarCampos(0)
        'End If
        'End If
        'End Sub
    End Sub
End Module
