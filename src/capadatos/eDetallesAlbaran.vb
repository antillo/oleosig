Option Strict Off
Option Explicit On
Public Class eDetallesAlbaran



    Private mvarId As UShort 'copia local
    Private mvarAlbaran As UShort 'copia local
    Private mvarPartida As UShort 'copia local
    Private mvarKilos As UInteger 'copia local
    Private mvarcampaña As Byte 'copia local
    Private _idalmazara As Integer

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Campaña() As Byte
        Get
            Return mvarcampaña
        End Get
        Set(ByVal Value As Byte)
            
            mvarcampaña = Value
        End Set
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Kilos() As UInteger
        Get

            Return mvarKilos
        End Get
        Set(ByVal Value As UInteger)
        
            mvarKilos = Value
        End Set
    End Property


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Partida() As UShort
        Get
        
            Return mvarPartida
        End Get
        Set(ByVal Value As UShort)
            
            mvarPartida = Value
        End Set
    End Property




    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Id() As Integer
        Get
            Return mvarId
        End Get
        Set(ByVal Value As Integer)
            
            mvarId = Value
        End Set
    End Property

    Public Property Idalmazara As Integer
        Get
            Return Me._idalmazara
        End Get
        Set(ByVal value As Integer)
            Me._idalmazara = value
        End Set
    End Property



    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Albaran() As UShort
        Get
        
            Return mvarAlbaran
        End Get
        Set(ByVal Value As UShort)

            mvarAlbaran = Value
        End Set
    End Property

    
    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub

    Public Sub New()

    End Sub
    Public Sub New(ByVal id As Integer, ByVal albaran As UShort, ByVal partida As UShort, ByVal kilos As UInteger, ByVal campagna As Byte, ByVal idalmazara As Integer)
        Me.Id = id
        Me.Albaran = albaran
        Me.Campaña = campagna
        Me.Kilos = kilos
        Me.Partida = partida
        Me._idalmazara = idalmazara
    End Sub
    Public Sub New(ByVal albaran As UShort, ByVal partida As UShort, ByVal kilos As UInteger, ByVal campagna As Byte, ByVal idalmazara As Integer)
        Me.Id = 0
        Me.Albaran = albaran
        Me.Campaña = campagna
        Me.Kilos = kilos
        Me.Partida = partida
        Me._idalmazara = idalmazara
    End Sub
    Public Sub New(ByVal partida As UShort, ByVal kilos As UInteger, ByVal campagna As Byte, ByVal idalmazara As Integer)
        Me.Id = 0
        Me.Albaran = 0
        Me.Campaña = campagna
        Me.Kilos = kilos
        Me.Partida = partida
        Me._idalmazara = idalmazara
    End Sub
End Class