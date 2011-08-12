Public Class eRendTicket

    Private _numticket As Int32
    Private _rendimiento As Double

    
    Public Property NumTicket As Int32
        Get
            Return Me._numticket
        End Get
        Set(ByVal value As Int32)
            Me._numticket = value
        End Set
    End Property
    Public Property Rendimiento As Double
        Get
            Return Me._rendimiento
        End Get
        Set(ByVal value As Double)
            Me._rendimiento = value
        End Set
    End Property
End Class
