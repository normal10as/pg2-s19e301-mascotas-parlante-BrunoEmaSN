Imports System.DateTime
Public Class Loro
    Private _memoria As New Queue(Of String)
    Private _memoria2 As String
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
        Nombre = ""
        FechaNacimiento = #07/20/2017#
    End Sub

    Private Function CalcularEdad(fechaNacimiento As Date) As Short
        Dim diasFechaNacimiento As Short = (fechaNacimiento.DayOfYear)
        Dim diasActules As Short = (Date.Today.DayOfYear)
        Dim anio As Short = (Date.Today.Year) - (fechaNacimiento.Year)
        Dim dias As Short = diasActules - diasFechaNacimiento

        If ((fechaNacimiento.Year Mod 4 = 0 And fechaNacimiento.Year Mod 100 <> 0 Or fechaNacimiento.Year Mod 400 = 0) And diasFechaNacimiento >= 60) Then
            dias += 1
        End If
        If ((Date.Today.Year Mod 4 = 0 And Date.Today.Year Mod 100 <> 0 Or Date.Today.Year Mod 400 = 0) And diasActules >= 60) Then
            dias -= 1
        End If

        If dias < 0 Then
            Return anio - 1
        Else
            Return anio
        End If
    End Function

    Public Sub Escuchar(frase As String)
        _memoria.Enqueue(frase)
    End Sub

    Public Function Hablar() As String
        _memoria2 &= _memoria.Dequeue()
        Return _memoria2
    End Function
End Class
