Public Class clsOcciso
    Private cPersona As clsPersona
    Private cEdad As Byte
    Private cLugarFallecimiento As String
    Private cFechaMuerte As Date
    Private cFechaInscripcion As Date
    Private cCausaFallecimiento As String
    Private cAlMargen As String
    Sub New(ByVal persona As clsPersona, ByVal edad As Byte, ByVal lugarFallecimiento As String, ByVal fechaMuerte As Date, ByVal fechaInscripcion As Date, ByVal causaFallecimiento As String, ByVal alMargen As String)
        pPersona = persona
        pEdad = edad
        pLugarFallecimiento = lugarFallecimiento
        pFechaMuerte = fechaMuerte
        pFechaInscripcion = fechaInscripcion
        pCausaFallecimiento = causaFallecimiento
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
    Public Property pEdad As Byte
        Get
            Return cEdad
        End Get
        Set(ByVal value As Byte)
            cEdad = value
        End Set
    End Property
    Public Property pLugarFallecimiento() As String
        Get
            Return cLugarFallecimiento
        End Get
        Set(ByVal value As String)
            If value.Trim.Length = 0 Then
                Throw New Exception("El lugar de fallecimiento no puede quedar vacio")
            Else
                cLugarFallecimiento = value.Trim.ToUpper
            End If
        End Set
    End Property
    Public Property pFechaMuerte() As Date
        Get
            Return cFechaMuerte
        End Get
        Set(ByVal value As Date)
            cFechaMuerte = value
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
    Public Property pCausaFallecimiento() As String
        Get
            Return cCausaFallecimiento
        End Get
        Set(ByVal value As String)
            If value.Trim.Length = 0 Then
                Throw New Exception("La causa de Fallecimiento es obligatorio")
            Else
                cCausaFallecimiento = value.Trim.ToUpper
            End If
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
