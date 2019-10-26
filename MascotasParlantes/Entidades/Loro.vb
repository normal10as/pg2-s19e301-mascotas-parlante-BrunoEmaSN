Public Class Loro
    Private memoria As New Queue(Of String)
    Private memoria2 As String
    Public _nombre As String
    Public _edad As Short
    Public _fechaNacimiento As Date

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public ReadOnly Property Edad As Short
        Get
            Return CalcularEdad(_fechaNacimiento)
        End Get
    End Property
    Public Property FechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
        End Set
    End Property

    Public Sub New()
        memoria = New Queue(Of String)
        Nombre = ""
        FechaNacimiento = #07/20/2017#
    End Sub

    Private Function CalcularEdad(fechaNacimiento As Date) As UShort
        Dim hoy As Date = Date.Today()
        Dim edad As UShort = ((hoy.Year) - (fechaNacimiento.Year))

        If (hoy.Month < fechaNacimiento.Month) Then
            Return edad - 1
        ElseIf (hoy.Month = fechaNacimiento.Month And hoy.Day < fechaNacimiento.Day) Then
            Return edad - 1
        Else
            Return edad
        End If
    End Function

    Public Overridable Sub Escuchar(frase As String)
        memoria.Enqueue(frase)
    End Sub

    Public Function Hablar() As String
        If memoria.Count > 0 Then
            memoria2 &= memoria.Dequeue()
        End If
        Return memoria2
    End Function

    Public Overrides Function ToString() As String
        Return Nombre
    End Function
End Class
