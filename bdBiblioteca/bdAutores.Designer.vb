<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bdAutores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bdAutores))
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.dAutores = New System.Windows.Forms.Label()
        Me.apAutor = New System.Windows.Forms.Label()
        Me.nmAutor = New System.Windows.Forms.Label()
        Me.idAutor = New System.Windows.Forms.Label()
        Me.apellido_autor = New System.Windows.Forms.TextBox()
        Me.nombre_autor = New System.Windows.Forms.TextBox()
        Me.id_autor = New System.Windows.Forms.TextBox()
        Me.dgAutores = New System.Windows.Forms.DataGridView()
        Me.fbSQL = New System.Windows.Forms.Label()
        Me.toggleGrid = New System.Windows.Forms.Button()
        Me.btnLlenar = New System.Windows.Forms.Button()
        CType(Me.dgAutores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.ForestGreen
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(240, 217)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 33
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.OrangeRed
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(135, 214)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 32
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnCrear
        '
        Me.btnCrear.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrear.ForeColor = System.Drawing.Color.White
        Me.btnCrear.Location = New System.Drawing.Point(30, 214)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(75, 23)
        Me.btnCrear.TabIndex = 31
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = False
        '
        'dAutores
        '
        Me.dAutores.AutoSize = True
        Me.dAutores.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dAutores.Location = New System.Drawing.Point(95, 30)
        Me.dAutores.Name = "dAutores"
        Me.dAutores.Size = New System.Drawing.Size(86, 25)
        Me.dAutores.TabIndex = 29
        Me.dAutores.Text = "Autores"
        '
        'apAutor
        '
        Me.apAutor.AutoSize = True
        Me.apAutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apAutor.Location = New System.Drawing.Point(35, 166)
        Me.apAutor.Name = "apAutor"
        Me.apAutor.Size = New System.Drawing.Size(58, 16)
        Me.apAutor.TabIndex = 25
        Me.apAutor.Text = "Apellido"
        '
        'nmAutor
        '
        Me.nmAutor.AutoSize = True
        Me.nmAutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nmAutor.Location = New System.Drawing.Point(35, 127)
        Me.nmAutor.Name = "nmAutor"
        Me.nmAutor.Size = New System.Drawing.Size(57, 16)
        Me.nmAutor.TabIndex = 24
        Me.nmAutor.Text = "Nombre"
        '
        'idAutor
        '
        Me.idAutor.AutoSize = True
        Me.idAutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idAutor.Location = New System.Drawing.Point(35, 89)
        Me.idAutor.Name = "idAutor"
        Me.idAutor.Size = New System.Drawing.Size(21, 16)
        Me.idAutor.TabIndex = 23
        Me.idAutor.Text = "ID"
        '
        'apellido_autor
        '
        Me.apellido_autor.BackColor = System.Drawing.Color.Gainsboro
        Me.apellido_autor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.apellido_autor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apellido_autor.Location = New System.Drawing.Point(117, 169)
        Me.apellido_autor.Name = "apellido_autor"
        Me.apellido_autor.Size = New System.Drawing.Size(147, 15)
        Me.apellido_autor.TabIndex = 19
        '
        'nombre_autor
        '
        Me.nombre_autor.BackColor = System.Drawing.Color.Gainsboro
        Me.nombre_autor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nombre_autor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre_autor.Location = New System.Drawing.Point(117, 131)
        Me.nombre_autor.Name = "nombre_autor"
        Me.nombre_autor.Size = New System.Drawing.Size(147, 15)
        Me.nombre_autor.TabIndex = 18
        '
        'id_autor
        '
        Me.id_autor.BackColor = System.Drawing.Color.Gainsboro
        Me.id_autor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.id_autor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_autor.Location = New System.Drawing.Point(117, 89)
        Me.id_autor.Name = "id_autor"
        Me.id_autor.Size = New System.Drawing.Size(37, 15)
        Me.id_autor.TabIndex = 17
        '
        'dgAutores
        '
        Me.dgAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAutores.Location = New System.Drawing.Point(345, 0)
        Me.dgAutores.Name = "dgAutores"
        Me.dgAutores.Size = New System.Drawing.Size(353, 265)
        Me.dgAutores.TabIndex = 35
        Me.dgAutores.TabStop = False
        '
        'fbSQL
        '
        Me.fbSQL.AutoSize = True
        Me.fbSQL.BackColor = System.Drawing.Color.White
        Me.fbSQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fbSQL.ForeColor = System.Drawing.Color.DodgerBlue
        Me.fbSQL.Location = New System.Drawing.Point(35, 62)
        Me.fbSQL.Name = "fbSQL"
        Me.fbSQL.Size = New System.Drawing.Size(0, 16)
        Me.fbSQL.TabIndex = 36
        '
        'toggleGrid
        '
        Me.toggleGrid.BackgroundImage = Global.bdBiblioteca.My.Resources.Resources.icons8_data_grid_50
        Me.toggleGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.toggleGrid.ForeColor = System.Drawing.Color.White
        Me.toggleGrid.Location = New System.Drawing.Point(263, 12)
        Me.toggleGrid.Name = "toggleGrid"
        Me.toggleGrid.Size = New System.Drawing.Size(52, 52)
        Me.toggleGrid.TabIndex = 53
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
        Me.btnLlenar.TabIndex = 90
        Me.btnLlenar.Text = "Nuevo"
        Me.btnLlenar.UseVisualStyleBackColor = False
        '
        'bdAutores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(699, 264)
        Me.Controls.Add(Me.btnLlenar)
        Me.Controls.Add(Me.toggleGrid)
        Me.Controls.Add(Me.fbSQL)
        Me.Controls.Add(Me.dgAutores)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.dAutores)
        Me.Controls.Add(Me.apAutor)
        Me.Controls.Add(Me.nmAutor)
        Me.Controls.Add(Me.idAutor)
        Me.Controls.Add(Me.apellido_autor)
        Me.Controls.Add(Me.nombre_autor)
        Me.Controls.Add(Me.id_autor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "bdAutores"
        Me.Text = "Autores"
        CType(Me.dgAutores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnCrear As System.Windows.Forms.Button
    Friend WithEvents dAutores As System.Windows.Forms.Label
    Friend WithEvents apAutor As System.Windows.Forms.Label
    Friend WithEvents nmAutor As System.Windows.Forms.Label
    Friend WithEvents idAutor As System.Windows.Forms.Label
    Friend WithEvents apellido_autor As System.Windows.Forms.TextBox
    Friend WithEvents nombre_autor As System.Windows.Forms.TextBox
    Friend WithEvents id_autor As System.Windows.Forms.TextBox
    Friend WithEvents dgAutores As System.Windows.Forms.DataGridView
    Friend WithEvents fbSQL As System.Windows.Forms.Label
    Friend WithEvents toggleGrid As System.Windows.Forms.Button
    Friend WithEvents btnLlenar As System.Windows.Forms.Button
End Class
