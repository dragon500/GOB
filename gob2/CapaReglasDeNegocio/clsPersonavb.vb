Public Class clsPersona
    Private cNombre As String
    Private cApePaterno As String
    Private cApeMaterno As String
    Private cNomPadre As String
    Private cNomMadre As String
    Sub New(ByVal nombre As String, ByVal apellidoPaterno As String, ByVal apellidoMaterno As String, ByVal nombrePadre As String, ByVal nombreMadre As String)
        pNombre = nombre
        pApePaterno = apellidoPaterno
        pApeMaterno = apellidoMaterno
        pNomPadre = nombrePadre
        pNomMadre = nombreMadre
    End Sub
    Public Property pNombre() As String
        Get
            Return cNombre
        End Get
        Set(ByVal value As String)
            cNombre = value
        End Set
    End Property
    Public Property pApePaterno() As String
        Get
            Return cApePaterno
        End Get
        Set(ByVal value As String)
            cApePaterno = value
        End Set
    End Property
    Public Property pApeMaterno() As String
        Get
            Return cApeMaterno
        End Get
        Set(ByVal value As String)
            cApeMaterno = value
        End Set
    End Property
    Public Property pNomPadre() As String
        Get
            Return cNomPadre
        End Get
        Set(ByVal value As String)
            cNomPadre = value
        End Set
    End Property
    Public Property pNomMadre() As String
        Get
            Return cNomMadre
        End Get
        Set(ByVal value As String)
            cNomMadre = value
        End Set
    End Property
End Class
