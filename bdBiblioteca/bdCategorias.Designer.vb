<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bdCategorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bdCategorias))
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.dCategorias = New System.Windows.Forms.Label()
        Me.cCategoria = New System.Windows.Forms.Label()
        Me.idCategoria = New System.Windows.Forms.Label()
        Me.categoria = New System.Windows.Forms.TextBox()
        Me.id_categoria = New System.Windows.Forms.TextBox()
        Me.dgCategorias = New System.Windows.Forms.DataGridView()
        Me.fbSQL = New System.Windows.Forms.Label()
        Me.toggleGrid = New System.Windows.Forms.Button()
        Me.btnLlenar = New System.Windows.Forms.Button()
        CType(Me.dgCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.ForestGreen
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(240, 250)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 45
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.OrangeRed
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(135, 250)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 44
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnCrear
        '
        Me.btnCrear.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrear.ForeColor = System.Drawing.Color.White
        Me.btnCrear.Location = New System.Drawing.Point(30, 250)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(75, 23)
        Me.btnCrear.TabIndex = 43
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = False
        '
        'dCategorias
        '
        Me.dCategorias.AutoSize = True
        Me.dCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dCategorias.Location = New System.Drawing.Point(95, 30)
        Me.dCategorias.Name = "dCategorias"
        Me.dCategorias.Size = New System.Drawing.Size(116, 25)
        Me.dCategorias.TabIndex = 41
        Me.dCategorias.Text = "Categorias"
        '
        'cCategoria
        '
        Me.cCategoria.AutoSize = True
        Me.cCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cCategoria.Location = New System.Drawing.Point(35, 127)
        Me.cCategoria.Name = "cCategoria"
        Me.cCategoria.Size = New System.Drawing.Size(57, 16)
        Me.cCategoria.TabIndex = 39
        Me.cCategoria.Text = "Nombre"
        '
        'idCategoria
        '
        Me.idCategoria.AutoSize = True
        Me.idCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idCategoria.Location = New System.Drawing.Point(35, 89)
        Me.idCategoria.Name = "idCategoria"
        Me.idCategoria.Size = New System.Drawing.Size(21, 16)
        Me.idCategoria.TabIndex = 38
        Me.idCategoria.Text = "ID"
        '
        'categoria
        '
        Me.categoria.BackColor = System.Drawing.Color.Gainsboro
        Me.categoria.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoria.Location = New System.Drawing.Point(117, 128)
        Me.categoria.Name = "categoria"
        Me.categoria.Size = New System.Drawing.Size(147, 15)
        Me.categoria.TabIndex = 36
        '
        'id_categoria
        '
        Me.id_categoria.BackColor = System.Drawing.Color.Gainsboro
        Me.id_categoria.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.id_categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_categoria.Location = New System.Drawing.Point(117, 89)
        Me.id_categoria.Name = "id_categoria"
        Me.id_categoria.Size = New System.Drawing.Size(37, 15)
        Me.id_categoria.TabIndex = 35
        '
        'dgCategorias
        '
        Me.dgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCategorias.Location = New System.Drawing.Point(341, 0)
        Me.dgCategorias.Name = "dgCategorias"
        Me.dgCategorias.Size = New System.Drawing.Size(260, 304)
        Me.dgCategorias.TabIndex = 48
        Me.dgCategorias.TabStop = False
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
        Me.fbSQL.TabIndex = 49
        '
        'toggleGrid
        '
        Me.toggleGrid.BackgroundImage = Global.bdBiblioteca.My.Resources.Resources.icons8_data_grid_50
        Me.toggleGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.toggleGrid.ForeColor = System.Drawing.Color.White
        Me.toggleGrid.Location = New System.Drawing.Point(263, 12)
        Me.toggleGrid.Name = "toggleGrid"
        Me.toggleGrid.Size = New System.Drawing.Size(52, 52)
        Me.toggleGrid.TabIndex = 52
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
        'bdCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(601, 304)
        Me.Controls.Add(Me.btnLlenar)
        Me.Controls.Add(Me.toggleGrid)
        Me.Controls.Add(Me.fbSQL)
        Me.Controls.Add(Me.dgCategorias)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.dCategorias)
        Me.Controls.Add(Me.cCategoria)
        Me.Controls.Add(Me.idCategoria)
        Me.Controls.Add(Me.categoria)
        Me.Controls.Add(Me.id_categoria)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "bdCategorias"
        Me.Text = "Categorias"
        CType(Me.dgCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnCrear As System.Windows.Forms.Button
    Friend WithEvents dCategorias As System.Windows.Forms.Label
    Friend WithEvents cCategoria As System.Windows.Forms.Label
    Friend WithEvents idCategoria As System.Windows.Forms.Label
    Friend WithEvents categoria As System.Windows.Forms.TextBox
    Friend WithEvents id_categoria As System.Windows.Forms.TextBox
    Friend WithEvents dgCategorias As System.Windows.Forms.DataGridView
    Friend WithEvents fbSQL As System.Windows.Forms.Label
    Friend WithEvents toggleGrid As System.Windows.Forms.Button
    Friend WithEvents btnLlenar As System.Windows.Forms.Button
End Class
