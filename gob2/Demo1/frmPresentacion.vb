Public Class frmPresentacion
    Dim contador As Byte
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If contador = 2 Then
            frmInicioSesion.Show()
            Close()
        Else
            contador += 1
        End If

    End Sub
End Class