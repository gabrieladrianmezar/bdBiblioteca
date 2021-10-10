<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bdClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bdClientes))
        Me.id_cliente = New System.Windows.Forms.TextBox()
        Me.nombre_cliente = New System.Windows.Forms.TextBox()
        Me.apellido_cliente = New System.Windows.Forms.TextBox()
        Me.dni_cliente = New System.Windows.Forms.TextBox()
        Me.direccion_cliente = New System.Windows.Forms.TextBox()
        Me.telefono_cliente = New System.Windows.Forms.TextBox()
        Me.idCliente = New System.Windows.Forms.Label()
        Me.nmCliente = New System.Windows.Forms.Label()
        Me.apCliente = New System.Windows.Forms.Label()
        Me.dniCliente = New System.Windows.Forms.Label()
        Me.dcCliente = New System.Windows.Forms.Label()
        Me.tlCliente = New System.Windows.Forms.Label()
        Me.dClientes = New System.Windows.Forms.Label()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.dgClientes = New System.Windows.Forms.DataGridView()
        Me.fbSQL = New System.Windows.Forms.Label()
        Me.toggleGrid = New System.Windows.Forms.Button()
        Me.btnLlenar = New System.Windows.Forms.Button()
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'id_cliente
        '
        Me.id_cliente.BackColor = System.Drawing.Color.Gainsboro
        Me.id_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.id_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_cliente.Location = New System.Drawing.Point(117, 89)
        Me.id_cliente.Name = "id_cliente"
        Me.id_cliente.Size = New System.Drawing.Size(37, 15)
        Me.id_cliente.TabIndex = 0
        '
        'nombre_cliente
        '
        Me.nombre_cliente.BackColor = System.Drawing.Color.Gainsboro
        Me.nombre_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nombre_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre_cliente.Location = New System.Drawing.Point(119, 127)
        Me.nombre_cliente.Name = "nombre_cliente"
        Me.nombre_cliente.Size = New System.Drawing.Size(147, 15)
        Me.nombre_cliente.TabIndex = 1
        '
        'apellido_cliente
        '
        Me.apellido_cliente.BackColor = System.Drawing.Color.Gainsboro
        Me.apellido_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.apellido_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apellido_cliente.Location = New System.Drawing.Point(117, 166)
        Me.apellido_cliente.Name = "apellido_cliente"
        Me.apellido_cliente.Size = New System.Drawing.Size(147, 15)
        Me.apellido_cliente.TabIndex = 2
        '
        'dni_cliente
        '
        Me.dni_cliente.BackColor = System.Drawing.Color.Gainsboro
        Me.dni_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dni_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dni_cliente.Location = New System.Drawing.Point(117, 206)
        Me.dni_cliente.Name = "dni_cliente"
        Me.dni_cliente.Size = New System.Drawing.Size(71, 15)
        Me.dni_cliente.TabIndex = 3
        '
        'direccion_cliente
        '
        Me.direccion_cliente.BackColor = System.Drawing.Color.Gainsboro
        Me.direccion_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.direccion_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.direccion_cliente.Location = New System.Drawing.Point(117, 244)
        Me.direccion_cliente.Name = "direccion_cliente"
        Me.direccion_cliente.Size = New System.Drawing.Size(181, 15)
        Me.direccion_cliente.TabIndex = 4
        '
        'telefono_cliente
        '
        Me.telefono_cliente.BackColor = System.Drawing.Color.Gainsboro
        Me.telefono_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.telefono_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefono_cliente.Location = New System.Drawing.Point(117, 282)
        Me.telefono_cliente.Name = "telefono_cliente"
        Me.telefono_cliente.Size = New System.Drawing.Size(110, 15)
        Me.telefono_cliente.TabIndex = 5
        '
        'idCliente
        '
        Me.idCliente.AutoSize = True
        Me.idCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idCliente.Location = New System.Drawing.Point(35, 89)
        Me.idCliente.Name = "idCliente"
        Me.idCliente.Size = New System.Drawing.Size(21, 16)
        Me.idCliente.TabIndex = 6
        Me.idCliente.Text = "ID"
        '
        'nmCliente
        '
        Me.nmCliente.AutoSize = True
        Me.nmCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nmCliente.Location = New System.Drawing.Point(35, 127)
        Me.nmCliente.Name = "nmCliente"
        Me.nmCliente.Size = New System.Drawing.Size(57, 16)
        Me.nmCliente.TabIndex = 7
        Me.nmCliente.Text = "Nombre"
        '
        'apCliente
        '
        Me.apCliente.AutoSize = True
        Me.apCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apCliente.Location = New System.Drawing.Point(35, 166)
        Me.apCliente.Name = "apCliente"
        Me.apCliente.Size = New System.Drawing.Size(58, 16)
        Me.apCliente.TabIndex = 8
        Me.apCliente.Text = "Apellido"
        '
        'dniCliente
        '
        Me.dniCliente.AutoSize = True
        Me.dniCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dniCliente.Location = New System.Drawing.Point(35, 205)
        Me.dniCliente.Name = "dniCliente"
        Me.dniCliente.Size = New System.Drawing.Size(31, 16)
        Me.dniCliente.TabIndex = 9
        Me.dniCliente.Text = "DNI"
        '
        'dcCliente
        '
        Me.dcCliente.AutoSize = True
        Me.dcCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dcCliente.Location = New System.Drawing.Point(35, 243)
        Me.dcCliente.Name = "dcCliente"
        Me.dcCliente.Size = New System.Drawing.Size(65, 16)
        Me.dcCliente.TabIndex = 10
        Me.dcCliente.Text = "Dirección"
        '
        'tlCliente
        '
        Me.tlCliente.AutoSize = True
        Me.tlCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlCliente.Location = New System.Drawing.Point(35, 281)
        Me.tlCliente.Name = "tlCliente"
        Me.tlCliente.Size = New System.Drawing.Size(62, 16)
        Me.tlCliente.TabIndex = 11
        Me.tlCliente.Text = "Teléfono"
        '
        'dClientes
        '
        Me.dClientes.AutoSize = True
        Me.dClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dClientes.Location = New System.Drawing.Point(95, 30)
        Me.dClientes.Name = "dClientes"
        Me.dClientes.Size = New System.Drawing.Size(90, 25)
        Me.dClientes.TabIndex = 12
        Me.dClientes.Text = "Clientes"
        '
        'btnCrear
        '
        Me.btnCrear.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrear.ForeColor = System.Drawing.Color.White
        Me.btnCrear.Location = New System.Drawing.Point(25, 330)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(75, 23)
        Me.btnCrear.TabIndex = 6
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.OrangeRed
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(130, 330)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 7
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.ForestGreen
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(235, 330)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 8
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'dgClientes
        '
        Me.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgClientes.Location = New System.Drawing.Point(331, 1)
        Me.dgClientes.Name = "dgClientes"
        Me.dgClientes.Size = New System.Drawing.Size(467, 378)
        Me.dgClientes.TabIndex = 18
        Me.dgClientes.TabStop = False
        '
        'fbSQL
        '
        Me.fbSQL.AutoSize = True
        Me.fbSQL.BackColor = System.Drawing.Color.White
        Me.fbSQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fbSQL.ForeColor = System.Drawing.Color.DodgerBlue
        Me.fbSQL.Location = New System.Drawing.Point(35, 59)
        Me.fbSQL.Name = "fbSQL"
        Me.fbSQL.Size = New System.Drawing.Size(0, 16)
        Me.fbSQL.TabIndex = 19
        '
        'toggleGrid
        '
        Me.toggleGrid.BackgroundImage = Global.bdBiblioteca.My.Resources.Resources.icons8_data_grid_50
        Me.toggleGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.toggleGrid.ForeColor = System.Drawing.Color.White
        Me.toggleGrid.Location = New System.Drawing.Point(258, 12)
        Me.toggleGrid.Name = "toggleGrid"
        Me.toggleGrid.Size = New System.Drawing.Size(52, 52)
        Me.toggleGrid.TabIndex = 10
        Me.toggleGrid.UseVisualStyleBackColor = True
        '
        'btnLlenar
        '
        Me.btnLlenar.BackColor = System.Drawing.Color.DarkRed
        Me.btnLlenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLlenar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLlenar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnLlenar.Location = New System.Drawing.Point(189, 85)
        Me.btnLlenar.Name = "btnLlenar"
        Me.btnLlenar.Size = New System.Drawing.Size(75, 25)
        Me.btnLlenar.TabIndex = 9
        Me.btnLlenar.Text = "Nuevo"
        Me.btnLlenar.UseVisualStyleBackColor = False
        '
        'bdClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(798, 380)
        Me.Controls.Add(Me.btnLlenar)
        Me.Controls.Add(Me.toggleGrid)
        Me.Controls.Add(Me.fbSQL)
        Me.Controls.Add(Me.dgClientes)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.dClientes)
        Me.Controls.Add(Me.tlCliente)
        Me.Controls.Add(Me.dcCliente)
        Me.Controls.Add(Me.dniCliente)
        Me.Controls.Add(Me.apCliente)
        Me.Controls.Add(Me.nmCliente)
        Me.Controls.Add(Me.idCliente)
        Me.Controls.Add(Me.telefono_cliente)
        Me.Controls.Add(Me.direccion_cliente)
        Me.Controls.Add(Me.dni_cliente)
        Me.Controls.Add(Me.apellido_cliente)
        Me.Controls.Add(Me.nombre_cliente)
        Me.Controls.Add(Me.id_cliente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "bdClientes"
        Me.Text = "Clientes"
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents id_cliente As System.Windows.Forms.TextBox
    Friend WithEvents nombre_cliente As System.Windows.Forms.TextBox
    Friend WithEvents apellido_cliente As System.Windows.Forms.TextBox
    Friend WithEvents dni_cliente As System.Windows.Forms.TextBox
    Friend WithEvents direccion_cliente As System.Windows.Forms.TextBox
    Friend WithEvents telefono_cliente As System.Windows.Forms.TextBox
    Friend WithEvents idCliente As System.Windows.Forms.Label
    Friend WithEvents nmCliente As System.Windows.Forms.Label
    Friend WithEvents apCliente As System.Windows.Forms.Label
    Friend WithEvents dniCliente As System.Windows.Forms.Label
    Friend WithEvents dcCliente As System.Windows.Forms.Label
    Friend WithEvents tlCliente As System.Windows.Forms.Label
    Friend WithEvents dClientes As System.Windows.Forms.Label
    Friend WithEvents btnCrear As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents dgClientes As System.Windows.Forms.DataGridView
    Friend WithEvents fbSQL As System.Windows.Forms.Label
    Friend WithEvents toggleGrid As System.Windows.Forms.Button
    Friend WithEvents btnLlenar As System.Windows.Forms.Button
End Class
