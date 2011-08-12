Option Strict Off
Option Explicit On
Public Class eOpFiltrado
    'variables locales para almacenar los valores de las propiedades
    Private _id As UShort 'copia local
    Private _idalmazara As Integer
    Private _numOp As UShort 'copia local
    Private _fechaInicial As DateTime 'copia local
    Private _fechaFinal As DateTime 'copia local
    Private _detalles As CeDetallesOpFiltrado 'copia local
    Private _filtro As UShort 'copia local
    Private _campaña As Byte
    Private _abierta As Boolean

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
    Public Property Abierta() As Boolean
        Get
            Return _abierta
        End Get
        Set(ByVal Value As Boolean)
            _abierta = Value
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
            Return _campaña
        End Get
        Set(ByVal Value As Byte)
            _campaña = Value
        End Set
    End Property


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Filtro() As UShort
        Get
            Return _filtro
        End Get
        Set(ByVal Value As UShort)

            _filtro = Value
        End Set
    End Property




    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Detalles() As CeDetallesOpFiltrado
        Get

            Return _detalles
        End Get
        Set(ByVal Value As CeDetallesOpFiltrado)

            _detalles = Value
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FechaFinal() As DateTime
        Get
            Return _fechaFinal
        End Get
        Set(ByVal Value As DateTime)

            _fechaFinal = Value
        End Set
    End Property




    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FechaInicial() As DateTime
        Get

            Return _fechaInicial
        End Get
        Set(ByVal Value As DateTime)

            _fechaInicial = Value
        End Set
    End Property




    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Operacion() As UShort
        Get

            Return _numOp
        End Get
        Set(ByVal Value As UShort)

            _numOp = Value
        End Set
    End Property




    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Id() As UShort
        Get

            Return _id
        End Get
        Set(ByVal Value As UShort)

            _id = Value
        End Set
    End Property
End Class