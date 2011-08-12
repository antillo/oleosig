Option Strict Off
Option Explicit On
Public Class eProcedencias

    'variables locales para almacenar los valores de las propiedades
    Private mvarCosechero As UShort 'copia local
    Private mvarTermino As UShort 'copia local
    Private mvarPoligono As UShort 'copia local
    Private mvarParcela As UShort 'copia local
    Private mvarFinca As String 'copia local
    Private mvarParaje As String 'copia local

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Paraje() As String
        Get
            Return mvarParaje
        End Get
        Set(ByVal Value As String)
            
            mvarParaje = Value
        End Set
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Finca() As String
        Get
            Return mvarFinca
        End Get
        Set(ByVal Value As String)
            
            mvarFinca = Value
        End Set
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Parcela() As UShort
        Get
            Return mvarParcela
        End Get
        Set(ByVal Value As UShort)
            
            mvarParcela = Value
        End Set
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Poligono() As UShort
        Get
        
            Return mvarPoligono
        End Get
        Set(ByVal Value As UShort)
            mvarPoligono = Value
        End Set
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Termino() As UShort
        Get
            Return mvarTermino
        End Get
        Set(ByVal Value As UShort)
            
            mvarTermino = Value
        End Set
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Cosechero() As UShort
        Get

            Return mvarCosechero
        End Get
        Set(ByVal Value As UShort)
            mvarCosechero = Value
        End Set
    End Property
End Class