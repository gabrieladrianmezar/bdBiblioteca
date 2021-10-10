<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bdEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bdEmpleados))
        Me.dgEmpleados = New System.Windows.Forms.DataGridView()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.dClientes = New System.Windows.Forms.Label()
        Me.tlEmpleado = New System.Windows.Forms.Label()
        Me.dcEmpleado = New System.Windows.Forms.Label()
        Me.apEmpleado = New System.Windows.Forms.Label()
        Me.nmEmpleado = New System.Windows.Forms.Label()
        Me.idEmpleado = New System.Windows.Forms.Label()
        Me.telefono_empleado = New System.Windows.Forms.TextBox()
        Me.direccion_empleado = New System.Windows.Forms.TextBox()
        Me.apellido_empleado = New System.Windows.Forms.TextBox()
        Me.nombre_empleado = New System.Windows.Forms.TextBox()
        Me.id_empleado = New System.Windows.Forms.TextBox()
        Me.dni_empleado = New System.Windows.Forms.TextBox()
        Me.dniEmpleado = New System.Windows.Forms.Label()
        Me.cuitEmpleado = New System.Windows.Forms.Label()
        Me.cuit_empleado = New System.Windows.Forms.TextBox()
        Me.fbSQL = New System.Windows.Forms.Label()
        Me.toggleGrid = New System.Windows.Forms.Button()
        Me.btnLlenar = New System.Windows.Forms.Button()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgEmpleados
        '
        Me.dgEmpleados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEmpleados.Location = New System.Drawing.Point(331, 0)
        Me.dgEmpleados.Name = "dgEmpleados"
        Me.dgEmpleados.Size = New System.Drawing.Size(464, 448)
        Me.dgEmpleados.TabIndex = 37
        Me.dgEmpleados.TabStop = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.ForestGreen
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(235, 388)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 35
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.OrangeRed
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(130, 388)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 34
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnCrear
        '
        Me.btnCrear.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrear.ForeColor = System.Drawing.Color.White
        Me.btnCrear.Location = New System.Drawing.Point(25, 388)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(75, 23)
        Me.btnCrear.TabIndex = 33
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = False
        '
        'dClientes
        '
        Me.dClientes.AutoSize = True
        Me.dClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dClientes.Location = New System.Drawing.Point(95, 30)
        Me.dClientes.Name = "dClientes"
        Me.dClientes.Size = New System.Drawing.Size(119, 25)
        Me.dClientes.TabIndex = 31
        Me.dClientes.Text = "Empleados"
        '
        'tlEmpleado
        '
        Me.tlEmpleado.AutoSize = True
        Me.tlEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlEmpleado.Location = New System.Drawing.Point(35, 322)
        Me.tlEmpleado.Name = "tlEmpleado"
        Me.tlEmpleado.Size = New System.Drawing.Size(62, 16)
        Me.tlEmpleado.TabIndex = 30
        Me.tlEmpleado.Text = "Teléfono"
        '
        'dcEmpleado
        '
        Me.dcEmpleado.AutoSize = True
        Me.dcEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dcEmpleado.Location = New System.Drawing.Point(35, 284)
        Me.dcEmpleado.Name = "dcEmpleado"
        Me.dcEmpleado.Size = New System.Drawing.Size(65, 16)
        Me.dcEmpleado.TabIndex = 29
        Me.dcEmpleado.Text = "Dirección"
        '
        'apEmpleado
        '
        Me.apEmpleado.AutoSize = True
        Me.apEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apEmpleado.Location = New System.Drawing.Point(35, 166)
        Me.apEmpleado.Name = "apEmpleado"
        Me.apEmpleado.Size = New System.Drawing.Size(58, 16)
        Me.apEmpleado.TabIndex = 27
        Me.apEmpleado.Text = "Apellido"
        '
        'nmEmpleado
        '
        Me.nmEmpleado.AutoSize = True
        Me.nmEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nmEmpleado.Location = New System.Drawing.Point(35, 127)
        Me.nmEmpleado.Name = "nmEmpleado"
        Me.nmEmpleado.Size = New System.Drawing.Size(57, 16)
        Me.nmEmpleado.TabIndex = 26
        Me.nmEmpleado.Text = "Nombre"
        '
        'idEmpleado
        '
        Me.idEmpleado.AutoSize = True
        Me.idEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idEmpleado.Location = New System.Drawing.Point(35, 89)
        Me.idEmpleado.Name = "idEmpleado"
        Me.idEmpleado.Size = New System.Drawing.Size(21, 16)
        Me.idEmpleado.TabIndex = 25
        Me.idEmpleado.Text = "ID"
        '
        'telefono_empleado
        '
        Me.telefono_empleado.BackColor = System.Drawing.Color.Gainsboro
        Me.telefono_empleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.telefono_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefono_empleado.Location = New System.Drawing.Point(117, 323)
        Me.telefono_empleado.Name = "telefono_empleado"
        Me.telefono_empleado.Size = New System.Drawing.Size(110, 15)
        Me.telefono_empleado.TabIndex = 24
        '
        'direccion_empleado
        '
        Me.direccion_empleado.BackColor = System.Drawing.Color.Gainsboro
        Me.direccion_empleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.direccion_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.direccion_empleado.Location = New System.Drawing.Point(117, 285)
        Me.direccion_empleado.Name = "direccion_empleado"
        Me.direccion_empleado.Size = New System.Drawing.Size(181, 15)
        Me.direccion_empleado.TabIndex = 23
        '
        'apellido_empleado
        '
        Me.apellido_empleado.BackColor = System.Drawing.Color.Gainsboro
        Me.apellido_empleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.apellido_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apellido_empleado.Location = New System.Drawing.Point(117, 166)
        Me.apellido_empleado.Name = "apellido_empleado"
        Me.apellido_empleado.Size = New System.Drawing.Size(147, 15)
        Me.apellido_empleado.TabIndex = 21
        '
        'nombre_empleado
        '
        Me.nombre_empleado.BackColor = System.Drawing.Color.Gainsboro
        Me.nombre_empleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nombre_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre_empleado.Location = New System.Drawing.Point(117, 127)
        Me.nombre_empleado.Name = "nombre_empleado"
        Me.nombre_empleado.Size = New System.Drawing.Size(147, 15)
        Me.nombre_empleado.TabIndex = 20
        '
        'id_empleado
        '
        Me.id_empleado.BackColor = System.Drawing.Color.Gainsboro
        Me.id_empleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.id_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_empleado.Location = New System.Drawing.Point(117, 89)
        Me.id_empleado.Name = "id_empleado"
        Me.id_empleado.Size = New System.Drawing.Size(37, 15)
        Me.id_empleado.TabIndex = 19
        '
        'dni_empleado
        '
        Me.dni_empleado.BackColor = System.Drawing.Color.Gainsboro
        Me.dni_empleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dni_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dni_empleado.Location = New System.Drawing.Point(117, 206)
        Me.dni_empleado.Name = "dni_empleado"
        Me.dni_empleado.Size = New System.Drawing.Size(71, 15)
        Me.dni_empleado.TabIndex = 22
        '
        'dniEmpleado
        '
        Me.dniEmpleado.AutoSize = True
        Me.dniEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dniEmpleado.Location = New System.Drawing.Point(35, 205)
        Me.dniEmpleado.Name = "dniEmpleado"
        Me.dniEmpleado.Size = New System.Drawing.Size(31, 16)
        Me.dniEmpleado.TabIndex = 28
        Me.dniEmpleado.Text = "DNI"
        '
        'cuitEmpleado
        '
        Me.cuitEmpleado.AutoSize = True
        Me.cuitEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cuitEmpleado.Location = New System.Drawing.Point(35, 244)
        Me.cuitEmpleado.Name = "cuitEmpleado"
        Me.cuitEmpleado.Size = New System.Drawing.Size(39, 16)
        Me.cuitEmpleado.TabIndex = 39
        Me.cuitEmpleado.Text = "CUIT"
        '
        'cuit_empleado
        '
        Me.cuit_empleado.BackColor = System.Drawing.Color.Gainsboro
        Me.cuit_empleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cuit_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cuit_empleado.Location = New System.Drawing.Point(117, 245)
        Me.cuit_empleado.Name = "cuit_empleado"
        Me.cuit_empleado.Size = New System.Drawing.Size(110, 15)
        Me.cuit_empleado.TabIndex = 38
        '
        'fbSQL
        '
        Me.fbSQL.AutoSize = True
        Me.fbSQL.BackColor = System.Drawing.Color.White
        Me.fbSQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fbSQL.ForeColor = System.Drawing.Color.DodgerBlue
        Me.fbSQL.Location = New System.Drawing.Point(35, 57)
        Me.fbSQL.Name = "fbSQL"
        Me.fbSQL.Size = New System.Drawing.Size(0, 16)
        Me.fbSQL.TabIndex = 50
        '
        'toggleGrid
        '
        Me.toggleGrid.BackgroundImage = Global.bdBiblioteca.My.Resources.Resources.icons8_data_grid_50
        Me.toggleGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.toggleGrid.ForeColor = System.Drawing.Color.White
        Me.toggleGrid.Location = New System.Drawing.Point(258, 12)
        Me.toggleGrid.Name = "toggleGrid"
        Me.toggleGrid.Size = New System.Drawing.Size(52, 52)
        Me.toggleGrid.TabIndex = 54
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
        Me.btnLlenar.TabIndex = 91
        Me.btnLlenar.Text = "Nuevo"
        Me.btnLlenar.UseVisualStyleBackColor = False
        '
        'bdEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(795, 448)
        Me.Controls.Add(Me.btnLlenar)
        Me.Controls.Add(Me.toggleGrid)
        Me.Controls.Add(Me.fbSQL)
        Me.Controls.Add(Me.cuitEmpleado)
        Me.Controls.Add(Me.cuit_empleado)
        Me.Controls.Add(Me.dgEmpleados)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.dClientes)
        Me.Controls.Add(Me.tlEmpleado)
        Me.Controls.Add(Me.dcEmpleado)
        Me.Controls.Add(Me.dniEmpleado)
        Me.Controls.Add(Me.apEmpleado)
        Me.Controls.Add(Me.nmEmpleado)
        Me.Controls.Add(Me.idEmpleado)
        Me.Controls.Add(Me.telefono_empleado)
        Me.Controls.Add(Me.direccion_empleado)
        Me.Controls.Add(Me.dni_empleado)
        Me.Controls.Add(Me.apellido_empleado)
        Me.Controls.Add(Me.nombre_empleado)
        Me.Controls.Add(Me.id_empleado)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "bdEmpleados"
        Me.Text = "Empleados"
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnCrear As System.Windows.Forms.Button
    Friend WithEvents dClientes As System.Windows.Forms.Label
    Friend WithEvents tlEmpleado As System.Windows.Forms.Label
    Friend WithEvents dcEmpleado As System.Windows.Forms.Label
    Friend WithEvents apEmpleado As System.Windows.Forms.Label
    Friend WithEvents nmEmpleado As System.Windows.Forms.Label
    Friend WithEvents idEmpleado As System.Windows.Forms.Label
    Friend WithEvents telefono_empleado As System.Windows.Forms.TextBox
    Friend WithEvents direccion_empleado As System.Windows.Forms.TextBox
    Friend WithEvents apellido_empleado As System.Windows.Forms.TextBox
    Friend WithEvents nombre_empleado As System.Windows.Forms.TextBox
    Friend WithEvents id_empleado As System.Windows.Forms.TextBox
    Friend WithEvents dni_empleado As System.Windows.Forms.TextBox
    Friend WithEvents dniEmpleado As System.Windows.Forms.Label
    Friend WithEvents cuitEmpleado As System.Windows.Forms.Label
    Friend WithEvents cuit_empleado As System.Windows.Forms.TextBox
    Friend WithEvents fbSQL As System.Windows.Forms.Label
    Friend WithEvents toggleGrid As System.Windows.Forms.Button
    Friend WithEvents btnLlenar As System.Windows.Forms.Button
End Class
