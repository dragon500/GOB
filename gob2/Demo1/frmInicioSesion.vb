Imports CapaReglasDeNegocio
Public Class frmInicioSesion
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        'Realizar la validación del usuario y 
        'la clave ingresada
        If clsUsuario.validacion(txtNombreUsuario.Text, txtClave.Text) = True Then
            frmPrincipal.Show() 'Invoca al formulario principal
            Close() 'Cierra el formulario inicio de sesión
        Else
            MsgBox("Usuario y/o clave incorrectos", _
                   MsgBoxStyle.Critical,
                   "Demo")
            txtClave.Clear()
            txtNombreUsuario.Focus()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        'Cerrando el formulario
        Close()
    End Sub
End Class