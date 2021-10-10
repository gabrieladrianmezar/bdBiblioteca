<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bdIniciarSesion
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
        Me.lbIniciarSesion = New System.Windows.Forms.Label()
        Me.isUsuario = New System.Windows.Forms.TextBox()
        Me.isClave = New System.Windows.Forms.TextBox()
        Me.isSoporte = New System.Windows.Forms.Label()
        Me.lbClaveError = New System.Windows.Forms.Label()
        Me.lbUsuarioError = New System.Windows.Forms.Label()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbIniciarSesion
        '
        Me.lbIniciarSesion.AutoSize = True
        Me.lbIniciarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIniciarSesion.ForeColor = System.Drawing.Color.Black
        Me.lbIniciarSesion.Location = New System.Drawing.Point(30, 19)
        Me.lbIniciarSesion.Name = "lbIniciarSesion"
        Me.lbIniciarSesion.Size = New System.Drawing.Size(170, 25)
        Me.lbIniciarSesion.TabIndex = 0
        Me.lbIniciarSesion.Text = "INICIAR SESIÓN"
        '
        'isUsuario
        '
        Me.isUsuario.BackColor = System.Drawing.Color.Gainsboro
        Me.isUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.isUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isUsuario.ForeColor = System.Drawing.Color.DimGray
        Me.isUsuario.Location = New System.Drawing.Point(42, 81)
        Me.isUsuario.Name = "isUsuario"
        Me.isUsuario.Size = New System.Drawing.Size(146, 15)
        Me.isUsuario.TabIndex = 2
        Me.isUsuario.Text = "Usuario"
        '
        'isClave
        '
        Me.isClave.BackColor = System.Drawing.Color.Gainsboro
        Me.isClave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.isClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isClave.ForeColor = System.Drawing.Color.DimGray
        Me.isClave.Location = New System.Drawing.Point(42, 111)
        Me.isClave.Name = "isClave"
        Me.isClave.Size = New System.Drawing.Size(146, 15)
        Me.isClave.TabIndex = 8
        Me.isClave.Text = "Contraseña"
        '
        'isSoporte
        '
        Me.isSoporte.AutoSize = True
        Me.isSoporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isSoporte.ForeColor = System.Drawing.Color.RoyalBlue
        Me.isSoporte.Location = New System.Drawing.Point(22, 175)
        Me.isSoporte.Name = "isSoporte"
        Me.isSoporte.Size = New System.Drawing.Size(130, 16)
        Me.isSoporte.TabIndex = 4
        Me.isSoporte.Text = "Olvidaste los datos?"
        '
        'lbClaveError
        '
        Me.lbClaveError.AutoSize = True
        Me.lbClaveError.BackColor = System.Drawing.Color.White
        Me.lbClaveError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbClaveError.ForeColor = System.Drawing.Color.Brown
        Me.lbClaveError.Location = New System.Drawing.Point(42, 54)
        Me.lbClaveError.Name = "lbClaveError"
        Me.lbClaveError.Size = New System.Drawing.Size(139, 16)
        Me.lbClaveError.TabIndex = 9
        Me.lbClaveError.Text = "Contraseña incorrecta"
        '
        'lbUsuarioError
        '
        Me.lbUsuarioError.AutoSize = True
        Me.lbUsuarioError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUsuarioError.ForeColor = System.Drawing.Color.Brown
        Me.lbUsuarioError.Location = New System.Drawing.Point(22, 54)
        Me.lbUsuarioError.Name = "lbUsuarioError"
        Me.lbUsuarioError.Size = New System.Drawing.Size(187, 16)
        Me.lbUsuarioError.TabIndex = 10
        Me.lbUsuarioError.Text = "El usuario ingresado no existe"
        '
        'btnEntrar
        '
        Me.btnEntrar.BackColor = System.Drawing.Color.Transparent
        Me.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrar.ForeColor = System.Drawing.Color.Black
        Me.btnEntrar.Location = New System.Drawing.Point(42, 139)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(146, 23)
        Me.btnEntrar.TabIndex = 11
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'bdIniciarSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(225, 209)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.lbUsuarioError)
        Me.Controls.Add(Me.lbClaveError)
        Me.Controls.Add(Me.isUsuario)
        Me.Controls.Add(Me.isSoporte)
        Me.Controls.Add(Me.isClave)
        Me.Controls.Add(Me.lbIniciarSesion)
        Me.Name = "bdIniciarSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IniciarSesion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbIniciarSesion As System.Windows.Forms.Label
    Friend WithEvents isUsuario As System.Windows.Forms.TextBox
    Friend WithEvents isClave As System.Windows.Forms.TextBox
    Friend WithEvents isSoporte As System.Windows.Forms.Label
    Friend WithEvents lbClaveError As System.Windows.Forms.Label
    Friend WithEvents lbUsuarioError As System.Windows.Forms.Label
    Friend WithEvents btnEntrar As System.Windows.Forms.Button

End Class
