<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bdLibrosRevised
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bdLibrosRevised))
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.dLibros = New System.Windows.Forms.Label()
        Me.edLibro = New System.Windows.Forms.Label()
        Me.pubLibro = New System.Windows.Forms.Label()
        Me.editLibro = New System.Windows.Forms.Label()
        Me.ttlLibro = New System.Windows.Forms.Label()
        Me.isbnLibro = New System.Windows.Forms.Label()
        Me.idLibro = New System.Windows.Forms.Label()
        Me.edicion_libro = New System.Windows.Forms.TextBox()
        Me.publicacion_libro = New System.Windows.Forms.TextBox()
        Me.editorial_libro = New System.Windows.Forms.TextBox()
        Me.titulo_libro = New System.Windows.Forms.TextBox()
        Me.isbn = New System.Windows.Forms.TextBox()
        Me.id_libro = New System.Windows.Forms.TextBox()
        Me.id_categoria = New System.Windows.Forms.TextBox()
        Me.idCategoriaLibro = New System.Windows.Forms.Label()
        Me.dgLibros = New System.Windows.Forms.DataGridView()
        Me.fbSQL = New System.Windows.Forms.Label()
        Me.dgISBN_Autores = New System.Windows.Forms.DataGridView()
        Me.dAutores = New System.Windows.Forms.Label()
        Me.isbnA = New System.Windows.Forms.TextBox()
        Me.btnEliminarA = New System.Windows.Forms.Button()
        Me.btnCrearA = New System.Windows.Forms.Button()
        Me.id_autorA = New System.Windows.Forms.TextBox()
        Me.idISBNA = New System.Windows.Forms.Label()
        Me.idLibroA = New System.Windows.Forms.Label()
        Me.btnLlenar = New System.Windows.Forms.Button()
        Me.btnListo = New System.Windows.Forms.Button()
        Me.toggleAutores = New System.Windows.Forms.Button()
        Me.toggleGrid = New System.Windows.Forms.Button()
        CType(Me.dgLibros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgISBN_Autores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.ForestGreen
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(235, 407)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 34
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.OrangeRed
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(130, 407)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 33
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnCrear
        '
        Me.btnCrear.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrear.ForeColor = System.Drawing.Color.White
        Me.btnCrear.Location = New System.Drawing.Point(25, 407)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(75, 23)
        Me.btnCrear.TabIndex = 32
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = False
        '
        'dLibros
        '
        Me.dLibros.AutoSize = True
        Me.dLibros.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dLibros.Location = New System.Drawing.Point(95, 30)
        Me.dLibros.Name = "dLibros"
        Me.dLibros.Size = New System.Drawing.Size(71, 25)
        Me.dLibros.TabIndex = 30
        Me.dLibros.Text = "Libros"
        '
        'edLibro
        '
        Me.edLibro.AutoSize = True
        Me.edLibro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edLibro.Location = New System.Drawing.Point(35, 281)
        Me.edLibro.Name = "edLibro"
        Me.edLibro.Size = New System.Drawing.Size(53, 16)
        Me.edLibro.TabIndex = 29
        Me.edLibro.Text = "Edición"
        '
        'pubLibro
        '
        Me.pubLibro.AutoSize = True
        Me.pubLibro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pubLibro.Location = New System.Drawing.Point(36, 243)
        Me.pubLibro.Name = "pubLibro"
        Me.pubLibro.Size = New System.Drawing.Size(78, 16)
        Me.pubLibro.TabIndex = 28
        Me.pubLibro.Text = "Publicación"
        '
        'editLibro
        '
        Me.editLibro.AutoSize = True
        Me.editLibro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editLibro.Location = New System.Drawing.Point(36, 205)
        Me.editLibro.Name = "editLibro"
        Me.editLibro.Size = New System.Drawing.Size(57, 16)
        Me.editLibro.TabIndex = 27
        Me.editLibro.Text = "Editorial"
        '
        'ttlLibro
        '
        Me.ttlLibro.AutoSize = True
        Me.ttlLibro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttlLibro.Location = New System.Drawing.Point(35, 166)
        Me.ttlLibro.Name = "ttlLibro"
        Me.ttlLibro.Size = New System.Drawing.Size(41, 16)
        Me.ttlLibro.TabIndex = 26
        Me.ttlLibro.Text = "Título"
        '
        'isbnLibro
        '
        Me.isbnLibro.AutoSize = True
        Me.isbnLibro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isbnLibro.Location = New System.Drawing.Point(35, 127)
        Me.isbnLibro.Name = "isbnLibro"
        Me.isbnLibro.Size = New System.Drawing.Size(39, 16)
        Me.isbnLibro.TabIndex = 25
        Me.isbnLibro.Text = "ISBN"
        '
        'idLibro
        '
        Me.idLibro.AutoSize = True
        Me.idLibro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idLibro.Location = New System.Drawing.Point(35, 89)
        Me.idLibro.Name = "idLibro"
        Me.idLibro.Size = New System.Drawing.Size(21, 16)
        Me.idLibro.TabIndex = 24
        Me.idLibro.Text = "ID"
        '
        'edicion_libro
        '
        Me.edicion_libro.BackColor = System.Drawing.Color.Gainsboro
        Me.edicion_libro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.edicion_libro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edicion_libro.Location = New System.Drawing.Point(117, 282)
        Me.edicion_libro.Name = "edicion_libro"
        Me.edicion_libro.Size = New System.Drawing.Size(110, 15)
        Me.edicion_libro.TabIndex = 23
        '
        'publicacion_libro
        '
        Me.publicacion_libro.BackColor = System.Drawing.Color.Gainsboro
        Me.publicacion_libro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.publicacion_libro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.publicacion_libro.Location = New System.Drawing.Point(117, 244)
        Me.publicacion_libro.Name = "publicacion_libro"
        Me.publicacion_libro.Size = New System.Drawing.Size(181, 15)
        Me.publicacion_libro.TabIndex = 22
        '
        'editorial_libro
        '
        Me.editorial_libro.BackColor = System.Drawing.Color.Gainsboro
        Me.editorial_libro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.editorial_libro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editorial_libro.Location = New System.Drawing.Point(117, 206)
        Me.editorial_libro.Name = "editorial_libro"
        Me.editorial_libro.Size = New System.Drawing.Size(71, 15)
        Me.editorial_libro.TabIndex = 21
        '
        'titulo_libro
        '
        Me.titulo_libro.BackColor = System.Drawing.Color.Gainsboro
        Me.titulo_libro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.titulo_libro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo_libro.Location = New System.Drawing.Point(117, 166)
        Me.titulo_libro.Name = "titulo_libro"
        Me.titulo_libro.Size = New System.Drawing.Size(147, 15)
        Me.titulo_libro.TabIndex = 20
        '
        'isbn
        '
        Me.isbn.BackColor = System.Drawing.Color.Gainsboro
        Me.isbn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.isbn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isbn.Location = New System.Drawing.Point(117, 127)
        Me.isbn.Name = "isbn"
        Me.isbn.Size = New System.Drawing.Size(147, 15)
        Me.isbn.TabIndex = 19
        '
        'id_libro
        '
        Me.id_libro.BackColor = System.Drawing.Color.Gainsboro
        Me.id_libro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.id_libro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_libro.Location = New System.Drawing.Point(117, 89)
        Me.id_libro.Name = "id_libro"
        Me.id_libro.Size = New System.Drawing.Size(37, 15)
        Me.id_libro.TabIndex = 18
        '
        'id_categoria
        '
        Me.id_categoria.BackColor = System.Drawing.Color.Gainsboro
        Me.id_categoria.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.id_categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_categoria.Location = New System.Drawing.Point(117, 318)
        Me.id_categoria.Name = "id_categoria"
        Me.id_categoria.Size = New System.Drawing.Size(147, 15)
        Me.id_categoria.TabIndex = 36
        '
        'idCategoriaLibro
        '
        Me.idCategoriaLibro.AutoSize = True
        Me.idCategoriaLibro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idCategoriaLibro.Location = New System.Drawing.Point(34, 318)
        Me.idCategoriaLibro.Name = "idCategoriaLibro"
        Me.idCategoriaLibro.Size = New System.Drawing.Size(83, 16)
        Me.idCategoriaLibro.TabIndex = 37
        Me.idCategoriaLibro.Text = "ID Categoria"
        '
        'dgLibros
        '
        Me.dgLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLibros.Location = New System.Drawing.Point(345, 0)
        Me.dgLibros.Name = "dgLibros"
        Me.dgLibros.Size = New System.Drawing.Size(605, 465)
        Me.dgLibros.TabIndex = 40
        '
        'fbSQL
        '
        Me.fbSQL.AutoSize = True
        Me.fbSQL.BackColor = System.Drawing.Color.White
        Me.fbSQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fbSQL.ForeColor = System.Drawing.Color.DodgerBlue
        Me.fbSQL.Location = New System.Drawing.Point(34, 69)
        Me.fbSQL.Name = "fbSQL"
        Me.fbSQL.Size = New System.Drawing.Size(0, 16)
        Me.fbSQL.TabIndex = 50
        '
        'dgISBN_Autores
        '
        Me.dgISBN_Autores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgISBN_Autores.Location = New System.Drawing.Point(578, 228)
        Me.dgISBN_Autores.Name = "dgISBN_Autores"
        Me.dgISBN_Autores.Size = New System.Drawing.Size(372, 237)
        Me.dgISBN_Autores.TabIndex = 52
        '
        'dAutores
        '
        Me.dAutores.AutoSize = True
        Me.dAutores.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dAutores.Location = New System.Drawing.Point(398, 30)
        Me.dAutores.Name = "dAutores"
        Me.dAutores.Size = New System.Drawing.Size(86, 25)
        Me.dAutores.TabIndex = 53
        Me.dAutores.Text = "Autores"
        '
        'isbnA
        '
        Me.isbnA.BackColor = System.Drawing.Color.Gainsboro
        Me.isbnA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.isbnA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isbnA.Location = New System.Drawing.Point(403, 89)
        Me.isbnA.Name = "isbnA"
        Me.isbnA.Size = New System.Drawing.Size(147, 15)
        Me.isbnA.TabIndex = 54
        '
        'btnEliminarA
        '
        Me.btnEliminarA.BackColor = System.Drawing.Color.OrangeRed
        Me.btnEliminarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarA.ForeColor = System.Drawing.Color.White
        Me.btnEliminarA.Location = New System.Drawing.Point(409, 236)
        Me.btnEliminarA.Name = "btnEliminarA"
        Me.btnEliminarA.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarA.TabIndex = 56
        Me.btnEliminarA.Text = "Eliminar"
        Me.btnEliminarA.UseVisualStyleBackColor = False
        '
        'btnCrearA
        '
        Me.btnCrearA.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCrearA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearA.ForeColor = System.Drawing.Color.White
        Me.btnCrearA.Location = New System.Drawing.Point(409, 198)
        Me.btnCrearA.Name = "btnCrearA"
        Me.btnCrearA.Size = New System.Drawing.Size(75, 23)
        Me.btnCrearA.TabIndex = 55
        Me.btnCrearA.Text = "Crear"
        Me.btnCrearA.UseVisualStyleBackColor = False
        '
        'id_autorA
        '
        Me.id_autorA.BackColor = System.Drawing.Color.Gainsboro
        Me.id_autorA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.id_autorA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_autorA.Location = New System.Drawing.Point(403, 127)
        Me.id_autorA.Name = "id_autorA"
        Me.id_autorA.Size = New System.Drawing.Size(37, 15)
        Me.id_autorA.TabIndex = 58
        '
        'idISBNA
        '
        Me.idISBNA.AutoSize = True
        Me.idISBNA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idISBNA.Location = New System.Drawing.Point(342, 89)
        Me.idISBNA.Name = "idISBNA"
        Me.idISBNA.Size = New System.Drawing.Size(39, 16)
        Me.idISBNA.TabIndex = 59
        Me.idISBNA.Text = "ISBN"
        '
        'idLibroA
        '
        Me.idLibroA.AutoSize = True
        Me.idLibroA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idLibroA.Location = New System.Drawing.Point(342, 126)
        Me.idLibroA.Name = "idLibroA"
        Me.idLibroA.Size = New System.Drawing.Size(21, 16)
        Me.idLibroA.TabIndex = 60
        Me.idLibroA.Text = "ID"
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
        Me.btnLlenar.TabIndex = 89
        Me.btnLlenar.Text = "Nuevo"
        Me.btnLlenar.UseVisualStyleBackColor = False
        '
        'btnListo
        '
        Me.btnListo.BackColor = System.Drawing.Color.DeepPink
        Me.btnListo.Enabled = False
        Me.btnListo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListo.ForeColor = System.Drawing.SystemColors.Window
        Me.btnListo.Location = New System.Drawing.Point(409, 272)
        Me.btnListo.Name = "btnListo"
        Me.btnListo.Size = New System.Drawing.Size(75, 25)
        Me.btnListo.TabIndex = 90
        Me.btnListo.Text = "Listo"
        Me.btnListo.UseVisualStyleBackColor = False
        '
        'toggleAutores
        '
        Me.toggleAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.toggleAutores.ForeColor = System.Drawing.Color.Transparent
        Me.toggleAutores.Image = Global.bdBiblioteca.My.Resources.Resources.icons8_add_file_50
        Me.toggleAutores.Location = New System.Drawing.Point(195, 5)
        Me.toggleAutores.Name = "toggleAutores"
        Me.toggleAutores.Size = New System.Drawing.Size(57, 67)
        Me.toggleAutores.TabIndex = 91
        Me.toggleAutores.UseVisualStyleBackColor = True
        '
        'toggleGrid
        '
        Me.toggleGrid.BackgroundImage = Global.bdBiblioteca.My.Resources.Resources.icons8_data_grid_50
        Me.toggleGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.toggleGrid.ForeColor = System.Drawing.Color.White
        Me.toggleGrid.Location = New System.Drawing.Point(258, 12)
        Me.toggleGrid.Name = "toggleGrid"
        Me.toggleGrid.Size = New System.Drawing.Size(52, 52)
        Me.toggleGrid.TabIndex = 51
        Me.toggleGrid.UseVisualStyleBackColor = True
        '
        'bdLibros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(952, 465)
        Me.Controls.Add(Me.toggleAutores)
        Me.Controls.Add(Me.btnListo)
        Me.Controls.Add(Me.btnLlenar)
        Me.Controls.Add(Me.idLibroA)
        Me.Controls.Add(Me.idISBNA)
        Me.Controls.Add(Me.id_autorA)
        Me.Controls.Add(Me.btnEliminarA)
        Me.Controls.Add(Me.btnCrearA)
        Me.Controls.Add(Me.isbnA)
        Me.Controls.Add(Me.dAutores)
        Me.Controls.Add(Me.dgISBN_Autores)
        Me.Controls.Add(Me.toggleGrid)
        Me.Controls.Add(Me.fbSQL)
        Me.Controls.Add(Me.dgLibros)
        Me.Controls.Add(Me.idCategoriaLibro)
        Me.Controls.Add(Me.id_categoria)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.dLibros)
        Me.Controls.Add(Me.edLibro)
        Me.Controls.Add(Me.pubLibro)
        Me.Controls.Add(Me.editLibro)
        Me.Controls.Add(Me.ttlLibro)
        Me.Controls.Add(Me.isbnLibro)
        Me.Controls.Add(Me.idLibro)
        Me.Controls.Add(Me.edicion_libro)
        Me.Controls.Add(Me.publicacion_libro)
        Me.Controls.Add(Me.editorial_libro)
        Me.Controls.Add(Me.titulo_libro)
        Me.Controls.Add(Me.isbn)
        Me.Controls.Add(Me.id_libro)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "bdLibros"
        Me.Text = "Libros"
        CType(Me.dgLibros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgISBN_Autores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnCrear As System.Windows.Forms.Button
    Friend WithEvents dLibros As System.Windows.Forms.Label
    Friend WithEvents edLibro As System.Windows.Forms.Label
    Friend WithEvents pubLibro As System.Windows.Forms.Label
    Friend WithEvents editLibro As System.Windows.Forms.Label
    Friend WithEvents ttlLibro As System.Windows.Forms.Label
    Friend WithEvents isbnLibro As System.Windows.Forms.Label
    Friend WithEvents idLibro As System.Windows.Forms.Label
    Friend WithEvents edicion_libro As System.Windows.Forms.TextBox
    Friend WithEvents publicacion_libro As System.Windows.Forms.TextBox
    Friend WithEvents editorial_libro As System.Windows.Forms.TextBox
    Friend WithEvents titulo_libro As System.Windows.Forms.TextBox
    Friend WithEvents isbn As System.Windows.Forms.TextBox
    Friend WithEvents id_libro As System.Windows.Forms.TextBox
    Friend WithEvents id_categoria As System.Windows.Forms.TextBox
    Friend WithEvents idCategoriaLibro As System.Windows.Forms.Label
    Friend WithEvents dgLibros As System.Windows.Forms.DataGridView
    Friend WithEvents fbSQL As System.Windows.Forms.Label
    Friend WithEvents toggleGrid As System.Windows.Forms.Button
    Friend WithEvents dgISBN_Autores As System.Windows.Forms.DataGridView
    Friend WithEvents dAutores As System.Windows.Forms.Label
    Friend WithEvents isbnA As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminarA As System.Windows.Forms.Button
    Friend WithEvents btnCrearA As System.Windows.Forms.Button
    Friend WithEvents id_autorA As System.Windows.Forms.TextBox
    Friend WithEvents idISBNA As System.Windows.Forms.Label
    Friend WithEvents idLibroA As System.Windows.Forms.Label
    Friend WithEvents btnLlenar As System.Windows.Forms.Button
    Friend WithEvents btnListo As System.Windows.Forms.Button
    Friend WithEvents toggleAutores As System.Windows.Forms.Button
End Class
