Option Strict Off
Option Explicit On
Imports System.ComponentModel
Public Class CeAlbaran
    Inherits listaBase(Of eAlbaran)

    Public Sub New()
        MyBase.New()

    End Sub



    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub
End Class