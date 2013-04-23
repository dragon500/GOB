Imports CapaReglasDeNegocio
Public Class frmBusquedaExpediente
    Sub cargarLibros()
        lstvLibros.Items.Clear()
        'Mostrar los libros de una determinada categoria
        Dim aux As UShort = 0
        For Each i As clsLibro In clsLibro.listarLibros(cmbTitulo.SelectedItem)
            lstvLibros.Items.Add(i.pTitulo.pNombre) 'ITEMS => PRIMERA COLUMNA
            lstvLibros.Items(aux).SubItems.Add(i.pcodReferencia)
            lstvLibros.Items(aux).SubItems.Add(i.pCodLibro)
            lstvLibros.Items(aux).SubItems.Add(i.pCantidadFolios)
            lstvLibros.Items(aux).SubItems.Add(i.pNivelDescripcion.pNivelDescripcion)
            lstvLibros.Items(aux).SubItems.Add(i.pNombreProductor)
            lstvLibros.Items(aux).SubItems.Add(i.pFormaIngreso)
            lstvLibros.Items(aux).SubItems.Add(i.pCaracteristicasFisicas)
            lstvLibros.Items(aux).SubItems.Add(i.pNumCorrelativoLibro)
            lstvLibros.Items(aux).SubItems.Add(i.pNumCorrelativoFolio)
            lstvLibros.Items(aux).SubItems.Add(i.pNumEstante)
            lstvLibros.Items(aux).SubItems.Add(i.pNumNivel)
            lstvLibros.Items(aux).SubItems.Add(i.pNotas)
            lstvLibros.Items(aux).SubItems.Add(i.pFechaDescripcion)
            aux += 1
        Next
        'Mostrando la cantidad de libros que devuelve el
        'resultado
        lblTotal.Text = lstvLibros.Items.Count
    End Sub
    Private Sub frmBusquedaDeLibros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cargando las categorías de la base de datos
        For Each i As clsTitulo In clsTitulo.listar
            cmbTitulo.Items.Add(i.pNombre)
        Next
        'Seleccione el primer elemento del ComboBox
        cmbTitulo.SelectedIndex = 0
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        'Botón BUSCAR
        cargarLibros()
    End Sub

    Private Sub btnEliminarLibro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarLibro.Click
        'OPCION 1
        ''Validar que se seleccione un libro de la lista
        'If lstvLibros.SelectedItems.Count = 0 Then
        '    MsgBox("Seleccione un libro de la lista.", MsgBoxStyle.Critical, "Demo")
        'Else
        '    'Eliminando de acuerdo al elemento que selecciona el usuario en el listview
        '    clsLibro.listarLibros(cmbCategorias.SelectedItem)(lstvLibros.SelectedItems(0).Index).eliminar()
        '    'Cargar los libros en el listview
        '    cargarLibros()
        '    'Mensaje de confirmación
        '    MsgBox("Libro eliminado.", MsgBoxStyle.Information, "Demo")
        'End If

        'OPCION 2
        'Validar que se seleccione un libro de la lista
        If lstvLibros.SelectedItems.Count = 0 Then
            MsgBox("Seleccione un libro de la lista.", MsgBoxStyle.Critical, "Sistema")
            Exit Sub
        End If
        'Eliminando de acuerdo al elemento que selecciona el usuario en el listview
        'clsLibro.listarLibros(cmbTitulo.SelectedItem)(lstvLibros.SelectedItems(0).Index).eliminar()
        'Cargar los libros en el listview
        cargarLibros()
        'Mensaje de confirmación
        MsgBox("Libro eliminado.", MsgBoxStyle.Information, "Sistema")

    End Sub
    Private Sub btnEliminarLibro2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarLibro2.Click
        'Eliminando en base al código del libro
        'a través de un método estático

        'Validar que se seleccione un libro de la lista
        If lstvLibros.SelectedItems.Count = 0 Then
            MsgBox("Seleccione un libro de la lista.", MsgBoxStyle.Critical, "Sistema")
            Exit Sub
        End If

        'Eliminando
        'clsLibro.eliminar2(lstvLibros.SelectedItems(0).Text)

        'Cargar los libros en el listview
        cargarLibros()
        'Mensaje de confirmación
        MsgBox("Libro eliminado.", MsgBoxStyle.Information, "Sistema")

    End Sub

    Private Sub btnDetalles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalles.Click
        'Validar que se seleccione un libro de la lista
        If lstvLibros.SelectedItems.Count = 0 Then
            MsgBox("Seleccione un libro de la lista.", MsgBoxStyle.Critical, "Sistema")
            Exit Sub 'Termina el procedimiento ACTUAL
        End If
        'Mostrar detalles
        frmDetallesDeLibro.MdiParent = frmPrincipal
        Dim aux As clsLibro
        For Each item As clsLibro In clsLibro.listarLibros(cmbTitulo.SelectedItem)
            If lstvLibros.SelectedItems(0).Text = item.pTitulo.pNombre Then
                aux = item
                'Si ya encontramos la coincidencia NO existe la necesidad de
                'seguir buscando entonces terminamos el FOR
                Exit For
            End If

        Next
        frmDetallesDeLibro.elLibro = aux
        frmDetallesDeLibro.Show()
    End Sub

End Class
