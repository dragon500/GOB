Imports CapaReglasDeNegocio
Public Class frmDetallesDeLibro
    'Nivel de formulario
    Public elLibro As clsLibro
    'habilitar o desabilitar los controles del formulario
    Sub habilitaControles(ByVal valor As Boolean)
        cmbTitulo.Enabled = Not valor
        txtCodReferencia.Enabled = Not valor
        txtCodigoLibro.Enabled = Not valor
        txtCantFolios.Enabled = valor
        txtNivelDescripcion.Enabled = valor
        txtNomProductor.Enabled = valor
        txtFormaIngreso.Enabled = valor
        txtCaracFisicas.Enabled = valor
        txtNormas.Enabled = valor
        txtCorrelativoLibro.Enabled = valor
        txtCorrelativoFolio.Enabled = valor
        txtNumEstante.Enabled = valor
        txtNumNivel.Enabled = valor
        txtNormas.Enabled = valor
        dateFechaDescripcion.Enabled = valor
        btnGuardar.Enabled = valor

    End Sub
    Private Sub frmDetallesDeLibro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
        'Cargar las categorias en el combobox
        '&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
        cmbTitulo.Items.Clear()
        For Each item As clsTitulo In clsTitulo.listar
            cmbTitulo.Items.Add(item.pNombre)
            cmbTitulo.Items.Add(item.pNivelDescripcion)
        Next
        'Seleccionar la primera categoría del combo
        cmbTitulo.SelectedIndex = 0
        '&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
        'Cargando los datos del libro
        '&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
        txtCodReferencia.Text = elLibro.pcodReferencia
        txtCodigoLibro.Text = elLibro.pCodLibro
        txtCantFolios.Text = elLibro.pCantidadFolios
        txtNomProductor.Text = elLibro.pNombreProductor
        txtFormaIngreso.Text = elLibro.pFormaIngreso
        txtCaracFisicas.Text = elLibro.pCaracteristicasFisicas
        txtNormas.Text = elLibro.pNormas
        txtCorrelativoLibro.Text = elLibro.pNumCorrelativoLibro
        txtCorrelativoFolio.Text = elLibro.pNumCorrelativoFolio
        txtNumEstante.Text = elLibro.pNumEstante
        txtNumNivel.Text = elLibro.pNumNivel
        txtNotasArchivero.Text = elLibro.pNotas
        dateFechaDescripcion.MaxDate = elLibro.pFechaDescripcion


        'Estados del libro : EXCELENTE - BUENO - REGULAR - MALO
        'Seleccionar el estado del libro
        cmbTitulo.SelectedIndex = cmbTitulo.FindString(elLibro.pTitulo.pNombre)
        cmbTitulo.SelectedIndex = cmbTitulo.FindString(elLibro.pTitulo.pNivelDescripcion)

        'desahilitar los controles
        habilitaControles(False)
        btnGuardar.Enabled = False
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    'Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
    '    habilitaControles(True)
    '    btnEditar.Enabled = False
    '    btnGuardar.Enabled = True
    '    txtTitulo.Focus()
    'End Sub

    'Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
    '    '***************************************************
    '    'actualizando los datos del libro
    '    '***************************************************
    '    Dim elnuevolibro As New clsLibro(txtAutor.Text, New clsCategoria(cmbCategoria.SelectedItem), txtCodigo.Text, _
    '                                     txtEditorial.Text, nudEjemplares.Value, Now, txtTitulo.Text)

    '    'capturo el resumen xq no es incluido el en cosntructor por ser opcional
    '    elnuevolibro.pResumen = txtResumen.Text
    '    'actulizando el libro

    '    elLibro.actualizar(elnuevolibro)
    '    MsgBox("datos actualizados.", MsgBoxStyle.Information, "demo")
    '    habilitaControles(False)
    '    btnEditar.Enabled = True
    '    btnGuardar.Enabled = False
    'End Sub
End Class
