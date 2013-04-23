Public Class frmExpedienteJudicial
    Private Sub frmExpedienteJudicial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupParvulo.Visible = False
        GroupContrayentes.Visible = False
        GroupOcciso.Visible = False
    End Sub
    Private Sub cmbTitulo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTitulo.SelectedIndexChanged
        Select Case cmbTitulo.SelectedIndex
            Case 0
                GroupParvulo.Visible = True
                GroupContrayentes.Visible = False
                GroupOcciso.Visible = False
            Case 1
                GroupParvulo.Visible = False
                GroupContrayentes.Visible = True
                GroupOcciso.Visible = False
            Case 2
                GroupParvulo.Visible = False
                GroupContrayentes.Visible = False
                GroupOcciso.Visible = True
        End Select
    End Sub
End Class