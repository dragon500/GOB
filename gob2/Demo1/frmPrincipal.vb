Public Class frmPrincipal
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        'Terminar la aplicación
        'CLOSE => Cerrar el formulario actual
        If MsgBox("¿Desea salir?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sistema") = _
            MsgBoxResult.Yes Then
            Application.Exit() 'Termina el programa
        End If
    End Sub
    Private Sub RegistroDeUsuariosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegistroDeUsuariosToolStripMenuItem.Click
        'Estructura MDI => Interfaz de Documento Múltiple
        '1)En el FORM padre establecer la prop. ISMDICONTAINER = true
        '2)Indicar el padre de un FORM hijo en el momento de
        'invocarlo
        'Llamar al formulario de registro
        'ME HACE REFERENCIA A LA CLASE ACTUAL
        frmRegistroDeUsuarios.MdiParent = Me
        frmRegistroDeUsuarios.Show()
    End Sub
    Private Sub ExploradorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExploradorToolStripMenuItem.Click
        frmBusquedaExpediente.MdiParent = Me
        frmBusquedaExpediente.Show()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click

        frmInicioSesion.Show()
        Close() 'cerrar el formulario principal
    End Sub

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExpedienteJudicialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpedienteJudicialToolStripMenuItem.Click
        frmExpedienteJudicial.MdiParent = Me
        frmExpedienteJudicial.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmRegistroDeUsuarios.MdiParent = Me
        frmRegistroDeUsuarios.Show()
    End Sub
End Class