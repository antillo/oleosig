Option Strict Off
Option Explicit On
Public Class eDetallesOpFiltrado

    Private mvarId As UShort
    Private mvarOpFiltrado As UShort
    Private mvarOpFabrica As UShort
    Private mvarKilos As UShort
    Private mvarCampagna As Byte
    Private _idalmazara As Integer

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Kilos() As UShort
        Get

            Return mvarKilos
        
        End Get
        Set(ByVal Value As UShort)

            mvarKilos = Value

        End Set
    End Property


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Campagna() As Byte
        Get

            Return mvarCampagna

        End Get
        Set(ByVal Value As Byte)
            mvarCampagna = Value

        End Set
    End Property




    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property OpFabrica() As UShort
        Get
            Return mvarOpFabrica
        End Get
        Set(ByVal Value As UShort)
            mvarOpFabrica = Value
        End Set
    End Property




    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property OpFiltrado() As UShort
        Get
            Return mvarOpFiltrado
        End Get
        Set(ByVal Value As UShort)
            mvarOpFiltrado = Value
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
            Return mvarId
            
        End Get
        Set(ByVal Value As UShort)
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
    Public Sub New()
        MyBase.New()

    End Sub
    Public Sub New(ByVal varOpFiltrado As UShort, ByVal varOpFabrica As UShort, ByVal varKilos As UShort, ByVal varCampagna As Byte, ByVal idalmazara As Integer)
        mvarId = 0
        mvarOpFiltrado = varOpFiltrado
        mvarOpFabrica = varOpFabrica
        mvarKilos = varKilos
        mvarCampagna = varCampagna
        _idalmazara = idalmazara
    End Sub
    Public Sub New(ByVal varId As UShort, ByVal varOpFiltrado As UShort, ByVal varOpFabrica As UShort, ByVal varKilos As UShort, ByVal varCampagna As Byte, ByVal idalmazara As Integer)
        mvarId = varId
        mvarOpFiltrado = varOpFiltrado
        mvarOpFabrica = varOpFabrica
        mvarKilos = varKilos
        mvarCampagna = varCampagna
        _idalmazara = idalmazara
    End Sub
    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub


End Class