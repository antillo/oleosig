Option Strict Off
Option Explicit On
Public Class CeDetallesAlbaran
    Inherits listaBase(Of eDetallesAlbaran)

    Public Sub New()
        MyBase.New()

    End Sub
    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub
End Class