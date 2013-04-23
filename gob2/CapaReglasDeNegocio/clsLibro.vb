Imports System.Data.SqlClient
Public Class clsLibro
    Private cTipoPatida As clsTipoPartida
    Private cCodigoReferencia As String
    Private cCodigoLibro As String
    Private cCantidadFolios As Byte
    Sub New(ByVal tipoPatida As clsTipoPartida, ByVal codigoReferencia As String, ByVal codigoLibro As String, ByVal cantidadFolios As Byte)
        pTipoPartida = tipoPatida
        pcodigoReferencia = codigoReferencia
        pCodigoLibro = codigoLibro
        pCantidadFolios = cantidadFolios
    End Sub


    Public Property pTipoPartida As clsTipoPartida
        Get
            Return cTipoPatida
        End Get
        Set(ByVal value As clsTipoPartida)
            If value Is Nothing Then 'Está vacío
                Throw New Exception("La categoría es obligatoria.")
            Else
                cTipoPatida = value
            End If
        End Set
    End Property
    Public Property pcodigoReferencia As String
        Get
            Return cCodigoReferencia
        End Get
        Set(ByVal value As String)
            If value.Trim.Length = 0 Then 'Está vacío
                Throw New Exception("El codigo Referencia es obligatorio.")
            Else
                cCodigoReferencia = value.Trim.ToUpper
            End If
        End Set
    End Property
    Public Property pCodigoLibro As String
        Get
            Return cCodigoLibro
        End Get
        Set(ByVal value As String)
            If value.Trim.Length = 0 Then 'Está vacío
                Throw New Exception("El codigo Libro es obligatorio.")
            Else
                cCodigoLibro = value.Trim.ToUpper
            End If
        End Set
    End Property
    Public Property pCantidadFolios As Byte
        Get
            Return cCantidadFolios
        End Get
        Set(ByVal value As Byte)
            cCantidadFolios = value
        End Set
    End Property
    Public Property pNormas As String
        Get
            Return cNormas
        End Get
        Set(ByVal value As String)
            cNormas = value
        End Set
    End Property
    Public Property pNumCorrelativoLibro As Byte
        Get
            Return cNumCorrelativoLibro
        End Get
        Set(ByVal value As Byte)
            cNumCorrelativoLibro = value
        End Set
    End Property
    Public Property pNumCorrelativoFolio As Byte
        Get
            Return cNumCorrelativoFolio
        End Get
        Set(ByVal value As Byte)
            cNumCorrelativoFolio = value
        End Set
    End Property
    Public Property pNumEstante As Byte
        Get
            Return cNumEstante
        End Get
        Set(ByVal value As Byte)
            cNumEstante = value
        End Set
    End Property
    Public Property pNumNivel As Byte
        Get
            Return cNumNivel
        End Get
        Set(ByVal value As Byte)
            cNumNivel = value
        End Set
    End Property
    Public Property pNotas As String
        Get
            Return cNotas
        End Get
        Set(ByVal value As String)
            cNotas = value
        End Set
    End Property
    Public Property pFechaDescripcion As Date
        Get
            Return cFechaDescripcion
        End Get
        Set(ByVal value As Date)
                cFechaDescripcion = value
        End Set
    End Property

    'Método para mostrar los libros de una categoria
    'Public Shared Function listarLibros(ByVal Titulo As String) As List(Of clsLibro)
    '    Dim conexion As New SqlConnection(mdlVariables.cadenaDeConexion)
    '    Dim comando As New SqlCommand("USP_LIBROS_POR_TITULO", conexion)
    '    comando.CommandType = CommandType.StoredProcedure
    '    comando.Parameters.AddWithValue("@nombreTitulo", Titulo)
    '    conexion.Open()
    '    'El PA devuelve una grilla de datos, entonces utilizamos ExecuteReader
    '    'Cuando se usa EXECUTEREADER vamos a hacer uso de un CONTENEDOR
    '    'denominado SQLDATAREADER
    '    Dim contenedor As SqlDataReader
    '    contenedor = comando.ExecuteReader()
    '    'Variable auxiliar para retornar los libros de la base de datos
    '    Dim miLista As New List(Of clsLibro)
    '    While contenedor.Read = True
    '        Dim fila As New clsLibro(contenedor.Item("CodReferencia"), _
    '                  New clsTitulo(contenedor.Item("NivelDescripcion")), _
    '                                contenedor.Item("CodLibro"), _
    '                                contenedor.Item("CantFolios"), _
    '                                contenedor.Item("NivelDescripcion"), _
    '                                contenedor.Item("NombreProductor"), _
    '                                contenedor.Item("FormaIngreso"), _
    '                                contenedor.Item("CaracFisicas"), _
    '                                contenedor.Item("Normas"), _
    '                                contenedor.Item("NumCorrelativoLibro"), _
    '                                contenedor.Item("NumCorrelativoFolio"), _
    '                                contenedor.Item("NumEstante"), _
    '                                contenedor.Item("NumNivel"), _
    '                                contenedor.Item("FechaDescripcion"))
    '        'las notas del archivero es opcional, por lo tanto tengo que evaluar si el resumen
    '        'está vacío o no
    '        'DBNULL.Value => Representa al valor NULL de Base de Datos
    '        If Not contenedor("NotasArchivero") Is DBNull.Value Then
    '            fila.pTitulo = contenedor.Item("NotasArchivero")
    '        End If
    '        miLista.Add(fila)
    '    End While
    '    conexion.Close()
    '    Return miLista
    'End Function
    'Sub eliminar()
    '    Dim cn As New SqlConnection(mdlVariables.cadenaDeConexion)
    '    Dim cmd As New SqlCommand("USP_ELIMINAR_LIBRO", cn)
    '    cmd.CommandType = CommandType.StoredProcedure
    '    cmd.Parameters.AddWithValue("codigo", pCodigo)
    '    cn.Open()
    '    cmd.ExecuteNonQuery()
    '    'ExecuteNonQuery => INSERT, UPDATE, DELETE
    '    cn.Close()
    'End Sub
    'Sub actualizar(ByVal nuevoLibro As clsLibro)
    '    Dim cn As New SqlConnection(mdlVariables.cadenaDeConexion)
    '    Dim cmd As New SqlCommand("USP_ACTUALIZAR_LIBRO", cn)
    '    cmd.CommandType = CommandType.StoredProcedure
    '    cmd.Parameters.AddWithValue("codigoLibroActual", pCodigo)
    '    cmd.Parameters.AddWithValue("nuevotitulo", nuevoLibro.pTitulo)
    '    cmd.Parameters.AddWithValue("nuevoautor", nuevoLibro.pAutor)
    '    cmd.Parameters.AddWithValue("nuevocantidadEjemplares", nuevoLibro.pEjemplares)
    '    cmd.Parameters.AddWithValue("nuevoestado", nuevoLibro.)
    '    cmd.Parameters.AddWithValue("nuevoresumen", nuevoLibro.pResumen)
    '    cmd.Parameters.AddWithValue("nuevoeditorial", nuevoLibro.pEditorial)
    '    cmd.Parameters.AddWithValue("nuevocategoria", nuevoLibro.pTitulo.pNombre) 'OJO
    '    cn.Open()
    '    cmd.ExecuteNonQuery()
    '    'ExecuteNonQuery => INSERT, UPDATE, DELETE
    '    cn.Close()
    'End Sub
    'Shared Sub eliminar2(ByVal codigo As String)
    '    'SHARED no depende del objeto SINO depende de la clase
    '    Dim cn As New SqlConnection(mdlVariables.cadenaDeConexion)
    '    Dim cmd As New SqlCommand("USP_ELIMINAR_LIBRO", cn)
    '    cmd.CommandType = CommandType.StoredProcedure
    '    cmd.Parameters.AddWithValue("codigo", codigo)
    '    cn.Open()
    '    cmd.ExecuteNonQuery()
    '    'ExecuteNonQuery => INSERT, UPDATE, DELETE
    '    cn.Close()
    'End Sub


End Class
