Option Strict Off
Option Explicit On
Public Class CeDetallesOpFiltrado
    Inherits listaBase(Of eDetallesOpFiltrado)


    Public ReadOnly Property Total() As Integer
        Get
            Dim i As Integer
            Dim suma As Integer

            For i = 0 To Me.Count - 1
                'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mCol().Kilos. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                suma = suma + Me.Item(i).Kilos
            Next i
            'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Total. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Total = suma
        End Get
    End Property

    Public Sub New()
        MyBase.New()

    End Sub
    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub
End Class