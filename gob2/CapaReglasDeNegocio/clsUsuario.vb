Imports System.Data.SqlClient
Public Class clsUsuario
    'Campos
    Private cNombre As String
    Private cClave As String
    Private cDescripcion As String
    Private cTipo As Boolean
    'Constructor
    Sub New(nombre As String, clave As String, _
            tipo As Boolean)
        pNombre = nombre
        pClave = clave
        pTipo = tipo
    End Sub
    'Propiedades
    Public Property pNombre As String
        Get
            Return cNombre
        End Get
        Set(value As String)
            If value.Trim.Length = 0 Then
                Throw New Exception("El nombre de usuario no puede quedar vacío.")
            Else
                cNombre = value.Trim.ToUpper
            End If
        End Set
    End Property
    Public Property pClave As String
        Get
            Return cClave
        End Get
        Set(value As String)
            If value.Trim.Length = 0 Then
                Throw New Exception("La clave no puede quedar vacía.")
            Else
                cClave = value 'FORMA 1
            End If
        End Set
    End Property
    Public Property pTipo As Boolean
        Get
            Return cTipo
        End Get
        Set(value As Boolean)
            cTipo = value
        End Set
    End Property
    Public Property pDescripcion As String
        Get
            Return cDescripcion
        End Get
        Set(value As String)
            If value.Trim.Length = 0 Then
                cDescripcion = String.Empty
            Else
                cDescripcion = value.Trim.ToUpper
            End If
        End Set
    End Property
    'Métodos
    '3 Tipos de métodos
    ' SUB => No devuelven valores
    ' FUNCTION => Devuelven algún valor
    ' SHARED => Métodos estáticos y a su vez
    '           pueden ser de tipo SUB o de tipo
    '           FUNCTION
    'El metodo estatico no necesita ser INSTANCIADO -%%%%%%%%%%%%%%%%%
    Sub Insertar()
        'Acceder a la base de datos SQL SERVER
        'PASO 1: ----------------------------------------- 
        'Crear la CONEXIÓN
        Dim conexion As New SqlConnection
        'Indicar la cadena de conexión
        'CADENA DE CONEXION => 3 Partes (SERVIDOR,BD,AUTENTICACIÓN)
        conexion.ConnectionString = mdlVariables.cadenaDeConexion
        'PASO 2: ----------------------------------------- 
        'Crear el COMANDO (el QUÉ voy a hacer - INSERT,DELETE,UPDATE,SELECT)
        Dim comando As New SqlCommand
        'Indicar el Proc. Almacenado que incluirá el comando
        comando.CommandText = "USP_INSERTAR_USUARIO"
        'Indicar la conexión para el comando
        comando.Connection = conexion
        'Indicar que se está trabajando con un proc. almacenado
        comando.CommandType = CommandType.StoredProcedure
        'Pasando los parámetros
        comando.Parameters.AddWithValue("@nombre", pNombre)
        comando.Parameters.AddWithValue("@clave", pClave)
        comando.Parameters.AddWithValue("@tipo", pTipo)
        comando.Parameters.AddWithValue("@descripcion", pDescripcion)
        'PASO 3: ----------------------------------------- 
        'Ejecutar el comando
        'ExecuteReader => Cuando el comando retorna una grilla de datos
        'Ejm: SELECT campo1,campo2,etc...
        'ExecuteScalar => Cuando el comando retorna un valor
        'Ejm: Utilizas Funcionones matemáticas SUM, AVG, COUNT, MAX, MIN
        'ExecuteNonQuery => Cuando el comando NO retorna datos
        'Ejm: Utilizas INSERT, UPDATE, DELETE
        conexion.Open() 'Abrir la conexión
        comando.ExecuteNonQuery()
        conexion.Close() 'Cerrar la conexión
    End Sub
    'Si retorna TRUE => Validación fue exitosa (Usuario y clave correcto)
    'Si retorna FALSE => Validación fracasó (Usuario o la clave incorreto)
    Shared Function validacion(usuario As String, clave As String) As Boolean
        Dim conexion As New SqlConnection(mdlVariables.cadenaDeConexion)
        Dim comando As New SqlCommand
        comando.CommandText = "USP_VALIDACION_USUARIO"
        comando.CommandType = CommandType.StoredProcedure
        comando.Connection = conexion
        comando.Parameters.AddWithValue("@usuario", usuario)
        comando.Parameters.AddWithValue("@clave", clave)
        conexion.Open()
        'Porque estoy utilizando un COUNT
        Dim valorDevuelto As Byte = comando.ExecuteScalar()
        conexion.Close()
        If valorDevuelto = 0 Then
            Return False
        Else
            Return True
        End If




    End Function
  
End Class
