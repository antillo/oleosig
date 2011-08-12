Option Strict Off
Option Explicit On
Imports System.ComponentModel

Public Class eAlbaran


    Private mvarId As Integer 'copia local
    Private _idalmazara As Integer
    Private mvarNumero As String 'copia local
    Private mvarFecha As DateTime 'copia local
    Private mvarCliente As String 'copia local
    Private mvarPartidas As CeDetallesAlbaran 'copia local
    Private mvarVehiculo As String 'copia local
    Private mvarConductor As Integer 'copia local
    Private mvarTipo As Integer 'copia local
    Private mvarTara As Integer
    Private mvarBruto As Integer
    Private mvarNeto As Integer
    Private mvarCampaña As Byte

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
    Public Property Campaña() As Byte
        Get
            Return mvarCampaña
        End Get
        Set(ByVal Value As Byte)
            mvarCampaña = Value
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Neto() As Integer
        Get
            Return mvarNeto
        End Get
        Set(ByVal Value As Integer)
            mvarNeto = Value
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Bruto() As Integer
        Get
            Return mvarBruto
        End Get
        Set(ByVal Value As Integer)
            mvarBruto = Value
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Tara() As Integer
        Get
            Return mvarTara
        End Get
        Set(ByVal Value As Integer)
            mvarTara = Value
        End Set
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Partidas() As CeDetallesAlbaran
        Get
            If mvarPartidas Is Nothing Then
                mvarPartidas = New CeDetallesAlbaran
            End If

            Return mvarPartidas
        End Get
        Set(ByVal Value As CeDetallesAlbaran)
            mvarPartidas = Value
        End Set
    End Property


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Tipo() As Integer
        Get
            Return mvarTipo
        End Get
        Set(ByVal Value As Integer)
            
            mvarTipo = Value
        End Set
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Conductor() As Integer
        Get
            Return mvarConductor
        End Get
        Set(ByVal Value As Integer)
            
            mvarConductor = Value
        End Set
    End Property




    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Vehiculo() As Integer
        Get
            Return mvarVehiculo
        End Get
        Set(ByVal Value As Integer)
            
            mvarVehiculo = Value
        End Set
    End Property


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Cliente() As String
        Get
            Return mvarCliente
        End Get
        Set(ByVal Value As String)
            
            mvarCliente = Value
        End Set
    End Property




    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Fecha() As DateTime
        Get
            Return mvarFecha
        End Get
        Set(ByVal Value As DateTime)
            
            mvarFecha = Value
        End Set
    End Property


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Numero() As Integer
        Get
            Return mvarNumero
        End Get
        Set(ByVal Value As Integer)
            
            mvarNumero = Value
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

    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub

    Public Sub New()
        MyBase.New()
    End Sub
   

End Class