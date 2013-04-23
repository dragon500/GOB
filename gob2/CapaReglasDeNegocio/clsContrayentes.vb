Public Class clsContrayentes
    Private cPersona As clsPersona
    Private cLugarMatrimonio As String
    Private cFechaMatrimonio As Date
    Private cAlMargen As String
    Sub New(ByVal persona As clsPersona, ByVal lugarMatrimonio As String, ByVal fechaMatrimonio As Date, ByVal alMargen As String)
        pPersona = persona
        pLugarMatrimonio = lugarMatrimonio
        pFechaMatrimonio = fechaMatrimonio
    End Sub
    Public Property pPersona() As clsPersona
        Get
            Return cPersona
        End Get
        Set(ByVal value As clsPersona)
            cPersona = value
        End Set
    End Property
    Public Property pLugarMatrimonio() As String
        Get
            Return cLugarMatrimonio
        End Get
        Set(ByVal value As String)
            cLugarMatrimonio = value
        End Set
    End Property
    Public Property pFechaMatrimonio() As Date
        Get
            Return cFechaMatrimonio
        End Get
        Set(ByVal value As Date)
            cFechaMatrimonio = value
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
