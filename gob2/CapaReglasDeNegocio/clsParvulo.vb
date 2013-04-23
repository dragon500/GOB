Public Class clsParvulo
    Private cPersona As clsPersona
    Private cLugarNacimiento As String
    Private cFechaNacimiento As Date
    Private cFechaInscripcion As Date
    Private cAlMargen As String
    Sub New(ByVal persona As clsPersona, ByVal lugarNacimiento As String, ByVal fechaNacimiento As Date, ByVal fechaInscripcion As Date, ByVal alMargen As String)
        pPersona = persona
        pLugarNacimiento = lugarNacimiento
        pFechaNacimiento = fechaNacimiento
        pFechaInscripcion = fechaInscripcion
        pAlMargen = alMargen
    End Sub
    Public Property pPersona() As clsPersona
        Get
            Return cPersona
        End Get
        Set(ByVal value As clsPersona)
            cPersona = value
        End Set
    End Property
    Public Property pLugarNacimiento() As String
        Get
            Return cLugarNacimiento
        End Get
        Set(ByVal value As String)
            cLugarNacimiento = value
        End Set
    End Property
    Public Property pFechaNacimiento() As Date
        Get
            Return cFechaNacimiento
        End Get
        Set(ByVal value As Date)
            cFechaNacimiento = value
        End Set
    End Property
    Public Property pFechaInscripcion() As Date
        Get
            Return cFechaInscripcion
        End Get
        Set(ByVal value As Date)
            cFechaInscripcion = value
        End Set
    End Property

    Public Property pAlMargen() As String
        Get
            Return cAlMargen
        End Get
        Set(ByVal value As String)
            cAlMargen = value.Trim.ToUpper
        End Set
    End Property

End Class
