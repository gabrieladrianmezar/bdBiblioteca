Public Class popAdvertencia
    'Objetivo: 
    Private Sub seguroNo_Click(sender As Object, e As EventArgs) Handles seguroNo.Click
        'Objetivo: Cierra el formulario al tomar la decisión.
        'popDelete = True
        Me.Close()
    End Sub
    Private Sub seguroSi_Click(sender As Object, e As EventArgs) Handles seguroSi.Click
        'Objetivo: Cierra el formulario al tomar la decisión.
        'popDelete = False
        Me.Close()
    End Sub
    Private Sub popAdvertencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Objetivo: Define los resultados de cada botón y decisión.
        seguroSi.DialogResult = DialogResult.OK
        seguroNo.DialogResult = DialogResult.Cancel

        'Objetivo: Apretar Enter es igual que aceptar, apretar ESC es igual que cancelar
        Me.AcceptButton = seguroSi
        Me.CancelButton = seguroNo
    End Sub
End Class