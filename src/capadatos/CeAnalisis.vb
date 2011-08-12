Option Strict Off
Option Explicit On
Imports System.ComponentModel
Public Class CeAnalisis
    Inherits listaBase(Of eAnalisis)
    Protected Overrides Function AddNewCore() As Object
        Dim analisis As eAnalisis = eAnalisis.NuevoAnalisis(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, Now, 0)
        analisis.SetParent(Me)
        Add(analisis)
        Return analisis
    End Function


    Public Sub New()
        MyBase.New()

    End Sub

    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub
End Class