Option Strict Off
Option Explicit On
Imports System.ComponentModel
Public Class CeOpFiltrado
    Inherits listaBase(Of eOpFiltrado)

    
    Public Sub New()
        MyBase.New()

    End Sub

    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub
End Class