Public Class frmEjemploListas
    Dim misDatos As New List(Of String)
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'Agregando el los datos del TEXTBOX
        'a la lista
        misDatos.Add(txtNombre.Text)
        cargarDatos()
        'Preparando los controles
        txtNombre.Clear()
        txtNombre.Focus()
    End Sub
    Sub cargarDatos()
        'Cargar los datos en el listbox
        lstDatos.Items.Clear()
        'Recorrer los elementos de la LISTA
        For Each i As String In misDatos
            lstDatos.Items.Add(i)
        Next
    End Sub

End Class