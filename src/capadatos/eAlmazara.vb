Option Strict Off
Option Explicit On
Imports System.ComponentModel

Public Class eAlmazara


    Private _nombre As String 'copia local
    Private _direccion As String 'copia local
    Private _cp As Integer
    Private _localidad As String
    Private _provincia As String
    Private _telefono As String 'copia local
    Private _decanters As Integer
    Private _email As String
    Private _batidoras As Integer
    Private _centrifugas As Integer
    Private _cif As String
    Private _id As Integer
    Private _regAgrario As String
    Private _regSanitario As String
    Private _pesaje As Integer
    Private _delimitador As String
    Private _delimitadorRend As String
    Private _multibascula As Boolean
    Private _seltolva As Boolean


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Provincia As String
        Get
            Return _provincia
        End Get
        Set(ByVal value As String)
            _provincia = value
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CodPostal As Integer
        Get
            Return _cp
        End Get
        Set(ByVal value As Integer)
            _cp = value
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Localidad As String
        Get
            Return _localidad
        End Get
        Set(ByVal value As String)
            _localidad = value
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Batidoras() As Integer
        Get
            Return _batidoras
        End Get
        Set(ByVal value As Integer)
            _batidoras = value
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Centrifugas() As Integer
        Get
            Return _centrifugas
        End Get
        Set(ByVal value As Integer)
            _centrifugas = value
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
            Return _id
        End Get
        Set(ByVal Value As Integer)
            _id = Value
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Cif() As String
        Get
            Return _cif
        End Get
        Set(ByVal Value As String)
            _cif = Value
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(ByVal Value As String)
            _email = Value
        End Set
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Decanters() As Integer
        Get
            Return _decanters
        End Get
        Set(ByVal Value As Integer)
            _decanters = Value
        End Set
    End Property


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Telefono() As String
        Get

            Return _telefono
        End Get
        Set(ByVal Value As String)

            _telefono = Value
        End Set
    End Property




    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Direccion() As String
        Get

            Return _direccion
        End Get
        Set(ByVal Value As String)

            _direccion = Value
        End Set
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Nombre() As String
        Get

            Return _nombre
        End Get
        Set(ByVal Value As String)

            _nombre = Value
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Agrario() As String
        Get
            Return _regAgrario
        End Get
        Set(ByVal Value As String)
            _regAgrario = Value
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Sanitario() As String
        Get
            Return _regSanitario
        End Get
        Set(ByVal Value As String)
            _regSanitario = Value
        End Set
    End Property
    Public Property Pesaje As Integer
        Get
            Return Me._pesaje
        End Get
        Set(ByVal value As Integer)
            Me._pesaje = value
        End Set
    End Property
    Public Property Delimitador As String
        Get
            Return Me._delimitador
        End Get
        Set(ByVal value As String)
            Me._delimitador = value
        End Set
    End Property
    ''' <summary>
    ''' Indica si la almzara o agrupacion de almazaras tiene basculas de diferentes provedores
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Multibascula As Boolean
        Get
            Return Me._multibascula
        End Get
        Set(ByVal value As Boolean)
            Me._multibascula = value
        End Set
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property DelimitadorRend As String
        Get
            Return Me._delimitadorRend
        End Get
        Set(ByVal value As String)
            Me._delimitadorRend = value
        End Set
    End Property
    Public Property Seltolva As Boolean
        Get
            Return Me._seltolva
        End Get
        Set(ByVal value As Boolean)
            Me._seltolva = value
        End Set
    End Property
    Public Sub New()

        _nombre = vbNullString
        _direccion = vbNullString
        _cp = 0
        _localidad = vbNullString
        _provincia = vbNullString
        _telefono = vbNullString
        _decanters = 0
        _email = vbNullString
        _batidoras = 0
        _centrifugas = 0
        _cif = vbNullString
        _id = 0
        _regAgrario = vbNullString
        _regSanitario = vbNullString
        _delimitador = vbNullString
        _delimitadorRend = vbNullString
        _multibascula = False
        _seltolva = False
    End Sub
End Class