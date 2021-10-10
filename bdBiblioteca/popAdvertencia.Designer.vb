<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class popAdvertencia
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.seguroSi = New System.Windows.Forms.Button()
        Me.seguroNo = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "¿Está seguro que desea eliminar el registro?"
        '
        'seguroSi
        '
        Me.seguroSi.BackColor = System.Drawing.Color.Lime
        Me.seguroSi.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen
        Me.seguroSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.seguroSi.Location = New System.Drawing.Point(43, 80)
        Me.seguroSi.Name = "seguroSi"
        Me.seguroSi.Size = New System.Drawing.Size(75, 23)
        Me.seguroSi.TabIndex = 1
        Me.seguroSi.Text = "Sí"
        Me.seguroSi.UseVisualStyleBackColor = False
        '
        'seguroNo
        '
        Me.seguroNo.BackColor = System.Drawing.Color.Red
        Me.seguroNo.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.seguroNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.seguroNo.Location = New System.Drawing.Point(174, 80)
        Me.seguroNo.Name = "seguroNo"
        Me.seguroNo.Size = New System.Drawing.Size(75, 23)
        Me.seguroNo.TabIndex = 2
        Me.seguroNo.Text = "No"
        Me.seguroNo.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = Global.bdBiblioteca.My.Resources.Resources.icons8_error_50
        Me.PictureBox1.Location = New System.Drawing.Point(119, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 50)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'popAdvertencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(292, 115)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.seguroNo)
        Me.Controls.Add(Me.seguroSi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "popAdvertencia"
        Me.Text = "Advertencia"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents seguroSi As System.Windows.Forms.Button
    Friend WithEvents seguroNo As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
