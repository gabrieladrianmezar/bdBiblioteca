<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bdPrestamosMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bdPrestamosMain))
        Me.clClose = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
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
        Me.dgPrestamos = New System.Windows.Forms.DataGridView()
        Me.hasT = New System.Windows.Forms.Label()
        Me.hasta = New System.Windows.Forms.TextBox()
        Me.fbSQL = New System.Windows.Forms.Label()
        CType(Me.dgPrestamos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'clClose
        '
        Me.clClose.AutoSize = True
        Me.clClose.BackColor = System.Drawing.Color.White
        Me.clClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clClose.ForeColor = System.Drawing.Color.Black
        Me.clClose.Location = New System.Drawing.Point(305, 9)
        Me.clClose.Name = "clClose"
        Me.clClose.Size = New System.Drawing.Size(20, 20)
        Me.clClose.TabIndex = 61
        Me.clClose.Text = "X"
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.ForestGreen
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(235, 434)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 25)
        Me.btnModificar.TabIndex = 60
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.OrangeRed
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(130, 434)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 25)
        Me.btnEliminar.TabIndex = 59
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnCrear
        '
        Me.btnCrear.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrear.ForeColor = System.Drawing.Color.White
        Me.btnCrear.Location = New System.Drawing.Point(25, 434)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(75, 25)
        Me.btnCrear.TabIndex = 58
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = False
        '
        'dPrestamos
        '
        Me.dPrestamos.AutoSize = True
        Me.dPrestamos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dPrestamos.Location = New System.Drawing.Point(95, 30)
        Me.dPrestamos.Name = "dPrestamos"
        Me.dPrestamos.Size = New System.Drawing.Size(114, 25)
        Me.dPrestamos.TabIndex = 56
        Me.dPrestamos.Text = "Prestamos"
        '
        'desD
        '
        Me.desD.AutoSize = True
        Me.desD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desD.Location = New System.Drawing.Point(35, 205)
        Me.desD.Name = "desD"
        Me.desD.Size = New System.Drawing.Size(49, 16)
        Me.desD.TabIndex = 55
        Me.desD.Text = "Desde"
        '
        'idEmpleado
        '
        Me.idEmpleado.AutoSize = True
        Me.idEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idEmpleado.Location = New System.Drawing.Point(35, 165)
        Me.idEmpleado.Name = "idEmpleado"
        Me.idEmpleado.Size = New System.Drawing.Size(87, 16)
        Me.idEmpleado.TabIndex = 54
        Me.idEmpleado.Text = "ID Empleado"
        '
        'idCliente
        '
        Me.idCliente.AutoSize = True
        Me.idCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idCliente.Location = New System.Drawing.Point(35, 127)
        Me.idCliente.Name = "idCliente"
        Me.idCliente.Size = New System.Drawing.Size(65, 16)
        Me.idCliente.TabIndex = 53
        Me.idCliente.Text = "ID Cliente"
        '
        'idPrestamo
        '
        Me.idPrestamo.AutoSize = True
        Me.idPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idPrestamo.Location = New System.Drawing.Point(35, 89)
        Me.idPrestamo.Name = "idPrestamo"
        Me.idPrestamo.Size = New System.Drawing.Size(21, 16)
        Me.idPrestamo.TabIndex = 52
        Me.idPrestamo.Text = "ID"
        '
        'desde
        '
        Me.desde.BackColor = System.Drawing.Color.Gainsboro
        Me.desde.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.desde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desde.Location = New System.Drawing.Point(117, 206)
        Me.desde.Name = "desde"
        Me.desde.Size = New System.Drawing.Size(71, 15)
        Me.desde.TabIndex = 51
        '
        'id_empleado
        '
        Me.id_empleado.BackColor = System.Drawing.Color.Gainsboro
        Me.id_empleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.id_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_empleado.Location = New System.Drawing.Point(128, 166)
        Me.id_empleado.Name = "id_empleado"
        Me.id_empleado.Size = New System.Drawing.Size(147, 15)
        Me.id_empleado.TabIndex = 50
        '
        'id_cliente
        '
        Me.id_cliente.BackColor = System.Drawing.Color.Gainsboro
        Me.id_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.id_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_cliente.Location = New System.Drawing.Point(117, 127)
        Me.id_cliente.Name = "id_cliente"
        Me.id_cliente.Size = New System.Drawing.Size(147, 15)
        Me.id_cliente.TabIndex = 49
        '
        'id_prestamo
        '
        Me.id_prestamo.BackColor = System.Drawing.Color.Gainsboro
        Me.id_prestamo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.id_prestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_prestamo.Location = New System.Drawing.Point(117, 89)
        Me.id_prestamo.Name = "id_prestamo"
        Me.id_prestamo.Size = New System.Drawing.Size(37, 15)
        Me.id_prestamo.TabIndex = 48
        '
        'dgPrestamos
        '
        Me.dgPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPrestamos.Location = New System.Drawing.Point(331, 12)
        Me.dgPrestamos.Name = "dgPrestamos"
        Me.dgPrestamos.Size = New System.Drawing.Size(477, 447)
        Me.dgPrestamos.TabIndex = 62
        '
        'hasT
        '
        Me.hasT.AutoSize = True
        Me.hasT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hasT.Location = New System.Drawing.Point(35, 239)
        Me.hasT.Name = "hasT"
        Me.hasT.Size = New System.Drawing.Size(44, 16)
        Me.hasT.TabIndex = 63
        Me.hasT.Text = "Hasta"
        '
        'hasta
        '
        Me.hasta.BackColor = System.Drawing.Color.Gainsboro
        Me.hasta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hasta.Location = New System.Drawing.Point(117, 240)
        Me.hasta.Name = "hasta"
        Me.hasta.Size = New System.Drawing.Size(71, 15)
        Me.hasta.TabIndex = 64
        '
        'fbSQL
        '
        Me.fbSQL.AutoSize = True
        Me.fbSQL.BackColor = System.Drawing.Color.White
        Me.fbSQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fbSQL.ForeColor = System.Drawing.Color.DodgerBlue
        Me.fbSQL.Location = New System.Drawing.Point(35, 60)
        Me.fbSQL.Name = "fbSQL"
        Me.fbSQL.Size = New System.Drawing.Size(0, 16)
        Me.fbSQL.TabIndex = 65
        '
        'bdPrestamosMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(812, 486)
        Me.Controls.Add(Me.fbSQL)
        Me.Controls.Add(Me.hasta)
        Me.Controls.Add(Me.hasT)
        Me.Controls.Add(Me.dgPrestamos)
        Me.Controls.Add(Me.clClose)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "bdPrestamosMain"
        Me.Text = "Prestamos"
        CType(Me.dgPrestamos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents clClose As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
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
    Friend WithEvents dgPrestamos As System.Windows.Forms.DataGridView
    Friend WithEvents hasT As System.Windows.Forms.Label
    Friend WithEvents hasta As System.Windows.Forms.TextBox
    Friend WithEvents fbSQL As System.Windows.Forms.Label
End Class
