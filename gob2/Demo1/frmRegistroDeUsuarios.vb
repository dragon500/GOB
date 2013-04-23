Imports CapaReglasDeNegocio
Public Class frmRegistroDeUsuarios
    Private Sub frmRegistroDeUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
        'Cuando carga el formulario
        '&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
        'Seleccionar el tipo registrador por
        'defecto
        cmbTipo.SelectedIndex = 1

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Cerrar el formulario
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Guardando el usuario
        Dim nuevoUsuario As clsUsuario 'Declarando
        Try
            If cmbTipo.SelectedIndex = 0 Then
                'Si esta seleccionado ADMINISTRADOR
                nuevoUsuario = New clsUsuario(txtNombreUsuario.Text, _
                                              txtClave.Text, True)
            Else
                'Si esta seleccionado REGISTRADOR
                nuevoUsuario = New clsUsuario(txtNombreUsuario.Text, _
                                              txtClave.Text, False)
            End If
            nuevoUsuario.pDescripcion = txtDescripcion.Text
            nuevoUsuario.Insertar()
            MsgBox("Usuario registrado", MsgBoxStyle.Information, "Aplicación")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Aplicación")
            txtNombreUsuario.Focus()
        End Try



    End Sub
End Class
