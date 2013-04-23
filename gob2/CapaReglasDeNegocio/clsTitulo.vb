Imports System.Data.SqlClient
Public Class clsTipoPartida
    Private cNombre As String
    Private cNivelDescripcion As String
    Private _p1 As Object

    Sub New(ByVal Nombre As String, ByVal NivelDescripcion As String)
        pNombre = Nombre
        pNivelDescripcion = NivelDescripcion
    End Sub

    Sub New(ByVal p1 As Object)
        ' TODO: Complete member initialization 
        _p1 = p1
    End Sub

    Public Property pNombre As String
        Get
            Return cNombre
        End Get
        Set(ByVal value As String)
            If value.Trim.Length = 0 Then
                Throw New Exception("El nombre de la categoría es obligatorio.")
            Else
                cNombre = value.Trim.ToUpper
            End If
        End Set
    End Property
    Public Property pNivelDescripcion As String
        Get
            Return cNivelDescripcion
        End Get
        Set(ByVal value As String)
            If value.Trim.Length = 0 Then
                Throw New Exception("El nivel de descripcion es obligatorio.")
            Else
                cNivelDescripcion = value.Trim.ToUpper
            End If
        End Set
    End Property
    Shared Function listar() As List(Of clsTipoPartida)
        Dim conexion As New SqlConnection(mdlVariables.cadenaDeConexion)
        'Forma 1
        Dim comando As New SqlCommand("USP_LISTAR_TIPO_PARTIDA", conexion)
        'Forma 2
        'Dim comando As New SqlCommand
        'comando.CommandText = "USP_LISTAR_lISTA"
        'comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        conexion.Open()
        'CUANDO UTILIZAMOS EXECUTEREADER, debemos crear un contenedor
        'llamado SQLDATAREADER
        Dim contenedor As SqlDataReader
        contenedor = comando.ExecuteReader()
        Dim miLista As New List(Of clsTipoPartida)
        While contenedor.Read = True 'Mientras hayan datos
            Dim registro As New clsTipoPartida(contenedor.Item("Nombre"), contenedor.Item("NivelDescripcion"))
            miLista.Add(registro)
        End While
        conexion.Close()
        Return miLista

    End Function
End Class
