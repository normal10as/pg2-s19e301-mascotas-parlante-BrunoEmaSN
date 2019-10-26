Public Class Cotorra
    Inherits Loro
    Public _edadHumana As UShort
    Private siEscucha As Boolean = True

    Public ReadOnly Property EdadHumana As UShort
        Get
            Return Edad * 2
        End Get
    End Property

    Sub New()
        MyBase.New()
    End Sub

    Public Overrides Sub Escuchar(frase As String)

        If siEscucha Then
            MyBase.Escuchar(frase)
        End If
        siEscucha = Not siEscucha
    End Sub
End Class
