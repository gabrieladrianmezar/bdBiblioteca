<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bdPrestamos
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
        Me.dgPrestamos_detalle = New System.Windows.Forms.DataGridView()
        Me.clClose = New System.Windows.Forms.Label()
        Me.btnModificarD = New System.Windows.Forms.Button()
        Me.btnEliminarD = New System.Windows.Forms.Button()
        Me.btnCrearD = New System.Windows.Forms.Button()
        Me.dPrestamos = New System.Windows.Forms.Label()
        Me.idLibroD = New System.Windows.Forms.Label()
        Me.idPrestamoD = New System.Windows.Forms.Label()
        Me.idDetalle = New System.Windows.Forms.Label()
        Me.id_libroD = New System.Windows.Forms.TextBox()
        Me.id_prestamoD = New System.Windows.Forms.TextBox()
        Me.id_detalleD = New System.Windows.Forms.TextBox()
        CType(Me.dgPrestamos_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgPrestamos_detalle
        '
        Me.dgPrestamos_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPrestamos_detalle.Location = New System.Drawing.Point(341, 12)
        Me.dgPrestamos_detalle.Name = "dgPrestamos_detalle"
        Me.dgPrestamos_detalle.Size = New System.Drawing.Size(477, 350)
        Me.dgPrestamos_detalle.TabIndex = 29
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
        Me.clClose.TabIndex = 47
        Me.clClose.Text = "X"
        '
        'btnModificarD
        '
        Me.btnModificarD.BackColor = System.Drawing.Color.ForestGreen
        Me.btnModificarD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarD.ForeColor = System.Drawing.Color.White
        Me.btnModificarD.Location = New System.Drawing.Point(235, 330)
        Me.btnModificarD.Name = "btnModificarD"
        Me.btnModificarD.Size = New System.Drawing.Size(75, 25)
        Me.btnModificarD.TabIndex = 46
        Me.btnModificarD.Text = "Modificar"
        Me.btnModificarD.UseVisualStyleBackColor = False
        '
        'btnEliminarD
        '
        Me.btnEliminarD.BackColor = System.Drawing.Color.OrangeRed
        Me.btnEliminarD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarD.ForeColor = System.Drawing.Color.White
        Me.btnEliminarD.Location = New System.Drawing.Point(130, 330)
        Me.btnEliminarD.Name = "btnEliminarD"
        Me.btnEliminarD.Size = New System.Drawing.Size(75, 25)
        Me.btnEliminarD.TabIndex = 45
        Me.btnEliminarD.Text = "Eliminar"
        Me.btnEliminarD.UseVisualStyleBackColor = False
        '
        'btnCrearD
        '
        Me.btnCrearD.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCrearD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearD.ForeColor = System.Drawing.Color.White
        Me.btnCrearD.Location = New System.Drawing.Point(25, 330)
        Me.btnCrearD.Name = "btnCrearD"
        Me.btnCrearD.Size = New System.Drawing.Size(75, 25)
        Me.btnCrearD.TabIndex = 44
        Me.btnCrearD.Text = "Crear"
        Me.btnCrearD.UseVisualStyleBackColor = False
        '
        'dPrestamos
        '
        Me.dPrestamos.AutoSize = True
        Me.dPrestamos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dPrestamos.Location = New System.Drawing.Point(95, 30)
        Me.dPrestamos.Name = "dPrestamos"
        Me.dPrestamos.Size = New System.Drawing.Size(187, 25)
        Me.dPrestamos.TabIndex = 42
        Me.dPrestamos.Text = "Prestamos Detalle"
        '
        'idLibroD
        '
        Me.idLibroD.AutoSize = True
        Me.idLibroD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idLibroD.Location = New System.Drawing.Point(35, 166)
        Me.idLibroD.Name = "idLibroD"
        Me.idLibroD.Size = New System.Drawing.Size(54, 16)
        Me.idLibroD.TabIndex = 38
        Me.idLibroD.Text = "ID Libro"
        '
        'idPrestamoD
        '
        Me.idPrestamoD.AutoSize = True
        Me.idPrestamoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idPrestamoD.Location = New System.Drawing.Point(35, 127)
        Me.idPrestamoD.Name = "idPrestamoD"
        Me.idPrestamoD.Size = New System.Drawing.Size(82, 16)
        Me.idPrestamoD.TabIndex = 37
        Me.idPrestamoD.Text = "ID Prestamo"
        '
        'idDetalle
        '
        Me.idDetalle.AutoSize = True
        Me.idDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idDetalle.Location = New System.Drawing.Point(35, 89)
        Me.idDetalle.Name = "idDetalle"
        Me.idDetalle.Size = New System.Drawing.Size(21, 16)
        Me.idDetalle.TabIndex = 36
        Me.idDetalle.Text = "ID"
        '
        'id_libroD
        '
        Me.id_libroD.BackColor = System.Drawing.Color.Gainsboro
        Me.id_libroD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.id_libroD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_libroD.Location = New System.Drawing.Point(117, 166)
        Me.id_libroD.Name = "id_libroD"
        Me.id_libroD.Size = New System.Drawing.Size(147, 15)
        Me.id_libroD.TabIndex = 32
        '
        'id_prestamoD
        '
        Me.id_prestamoD.BackColor = System.Drawing.Color.Gainsboro
        Me.id_prestamoD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.id_prestamoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_prestamoD.Location = New System.Drawing.Point(117, 127)
        Me.id_prestamoD.Name = "id_prestamoD"
        Me.id_prestamoD.Size = New System.Drawing.Size(147, 15)
        Me.id_prestamoD.TabIndex = 31
        '
        'id_detalleD
        '
        Me.id_detalleD.BackColor = System.Drawing.Color.Gainsboro
        Me.id_detalleD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.id_detalleD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_detalleD.Location = New System.Drawing.Point(117, 89)
        Me.id_detalleD.Name = "id_detalleD"
        Me.id_detalleD.Size = New System.Drawing.Size(37, 15)
        Me.id_detalleD.TabIndex = 30
        '
        'bdPrestamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(830, 389)
        Me.Controls.Add(Me.clClose)
        Me.Controls.Add(Me.btnModificarD)
        Me.Controls.Add(Me.btnEliminarD)
        Me.Controls.Add(Me.btnCrearD)
        Me.Controls.Add(Me.dPrestamos)
        Me.Controls.Add(Me.idLibroD)
        Me.Controls.Add(Me.idPrestamoD)
        Me.Controls.Add(Me.idDetalle)
        Me.Controls.Add(Me.id_libroD)
        Me.Controls.Add(Me.id_prestamoD)
        Me.Controls.Add(Me.id_detalleD)
        Me.Controls.Add(Me.dgPrestamos_detalle)
        Me.Name = "bdPrestamos"
        Me.Text = "bdPrestamos"
        CType(Me.dgPrestamos_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgPrestamos_detalle As System.Windows.Forms.DataGridView
    Friend WithEvents clClose As System.Windows.Forms.Label
    Friend WithEvents btnModificarD As System.Windows.Forms.Button
    Friend WithEvents btnEliminarD As System.Windows.Forms.Button
    Friend WithEvents btnCrearD As System.Windows.Forms.Button
    Friend WithEvents dPrestamos As System.Windows.Forms.Label
    Friend WithEvents idLibroD As System.Windows.Forms.Label
    Friend WithEvents idPrestamoD As System.Windows.Forms.Label
    Friend WithEvents idDetalle As System.Windows.Forms.Label
    Friend WithEvents id_libroD As System.Windows.Forms.TextBox
    Friend WithEvents id_prestamoD As System.Windows.Forms.TextBox
    Friend WithEvents id_detalleD As System.Windows.Forms.TextBox
End Class
