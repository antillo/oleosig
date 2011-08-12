Option Strict Off
Option Explicit On

Imports System.ComponentModel

''' <summary>
''' Esta clase representa un análisis de aceite
''' </summary>
''' <remarks></remarks>
Public Class eAnalisis
    Implements INotifyPropertyChanged
    Implements IEditableObject


    Public Event PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs) Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

    Private _Id As Integer
    Private _idalmazara As Integer
    Private _Lote As Integer
    Private _numTanque As Integer
    Private _acidez As Single
    Private _peroxidos As Single
    Private _k270 As Single
    Private _k232 As Single
    Private _ceras As Single
    Private _esteroles_tot As Single
    Private _colesteroles As Single
    Private _brasicasterol As Single
    Private _campesterol As Single
    Private _estigmasterol As Single
    Private _beta_sitosterol As Single
    Private _d_7_estigmasterol As Single
    Private _eritrodiol As Single
    Private _trilinoleinas As Single
    Private _Organoleptico As UShort
    Private _alcohol_alifatico As Single
    Private _Fecha As Date
    Private _campaña As Byte


    Private _oldId As Integer
    Private _oldidalmazara As Integer
    Private _oldLote As Integer
    Private _oldnumTanque As Integer
    Private _oldacidez As Single
    Private _oldperoxidos As Single
    Private _oldk270 As Single
    Private _oldk232 As Single
    Private _oldceras As Single
    Private _oldesteroles_tot As Single
    Private _oldcolesteroles As Single
    Private _oldbrasicasterol As Single
    Private _oldcampesterol As Single
    Private _oldestigmasterol As Single
    Private _oldbeta_sitosterol As Single
    Private _oldd_7_estigmasterol As Single
    Private _olderitrodiol As Single
    Private _oldtrilinoleinas As Single
    Private _oldOrganoleptico As UShort
    Private _oldalcohol_alifatico As Single
    Private _oldFecha As Date
    Private _oldcampaña As Byte

    Private _nuevo As Boolean
    Private _editando As Boolean
    Private _parent As CeAnalisis



    Public Property Idalmazara As Integer
        Get
            Return Me._idalmazara
        End Get
        Set(ByVal value As Integer)
            Me._idalmazara = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Idalmazara"))
        End Set
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Fecha() As Date
        Get
            Return _Fecha
        End Get
        Set(ByVal Value As Date)

            _Fecha = Value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Fecha"))
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

            Return _Id
        End Get
        Set(ByVal Value As Integer)

            _Id = Value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Id"))
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
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Campaña"))
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Lote() As Integer
        Get
            Return _Lote
        End Get
        Set(ByVal Value As Integer)

            _Lote = Value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Lote"))
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property numTanque() As Integer
        Get

            Return _numTanque
        End Get
        Set(ByVal Value As Integer)

            _numTanque = Value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("numTanque"))
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Acidez() As Single
        Get

            Return _acidez
        End Get
        Set(ByVal Value As Single)

            _acidez = Value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Acidez"))
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Peroxidos() As Single
        Get

            Return _peroxidos
        End Get
        Set(ByVal Value As Single)

            _peroxidos = Value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Peroxidos"))
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property K270() As Single
        Get

            Return _k270
        End Get
        Set(ByVal Value As Single)

            _k270 = Value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("K270"))
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property K232() As Single
        Get

            Return _k232
        End Get
        Set(ByVal Value As Single)

            _k232 = Value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("K232"))
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Ceras() As Single
        Get

            Return _ceras
        End Get
        Set(ByVal Value As Single)

            _ceras = Value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Ceras"))
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Esteroles_tot() As Single
        Get

            Return _esteroles_tot
        End Get
        Set(ByVal Value As Single)

            _esteroles_tot = Value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Esteroles_tot"))
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Colesteroles() As Single
        Get

            Return _colesteroles
        End Get
        Set(ByVal Value As Single)

            _colesteroles = Value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Colesteroles"))
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Brasicasterol() As Single
        Get

            Return _brasicasterol
        End Get
        Set(ByVal Value As Single)

            _brasicasterol = Value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Brasicasterol"))
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Campesterol() As Single
        Get

            Return _campesterol
        End Get
        Set(ByVal Value As Single)

            _campesterol = Value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Campesterol"))
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Estigmasterol() As Single
        Get

            Return _estigmasterol
        End Get
        Set(ByVal Value As Single)

            _estigmasterol = Value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Estigmasterol"))
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Beta_sitosterol() As Single
        Get

            Return _beta_sitosterol
        End Get
        Set(ByVal Value As Single)

            _beta_sitosterol = Value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Beta_sitosterol"))
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property D_7_estigmasterol() As Single
        Get

            Return _d_7_estigmasterol
        End Get
        Set(ByVal Value As Single)

            _d_7_estigmasterol = Value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("D_7_estigmasterol"))
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Eritrodiol() As Single
        Get

            Return _eritrodiol
        End Get
        Set(ByVal Value As Single)

            _eritrodiol = Value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Eritrodiol"))
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Trilinoleinas() As Single
        Get

            Return _trilinoleinas
        End Get
        Set(ByVal Value As Single)

            _trilinoleinas = Value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Trilinoleinas"))
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Organoleptico() As UShort
        Get

            Return _Organoleptico
        End Get
        Set(ByVal Value As UShort)

            _Organoleptico = Value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Organoleptico"))
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Alcohol_alifatico() As Single
        Get

            Return _alcohol_alifatico
        End Get
        Set(ByVal Value As Single)

            _alcohol_alifatico = Value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Alcohol_alifatico"))
        End Set
    End Property

    Friend Sub SetParent(ByVal parent As CeAnalisis)
        Me._parent = parent
    End Sub
    Public Shared Function NuevoAnalisis(ByVal id As Integer, ByVal idalmazara As Integer, ByVal lote As Integer,
        ByVal numTanque As Integer, ByVal acidez As Single, ByVal peroxidos As Single, ByVal k270 As Single,
        ByVal k232 As Single, ByVal ceras As Single, ByVal esteroles_tot As Single, ByVal colesteroles As Single,
        ByVal brasicasterol As Single, ByVal campesterol As Single, ByVal estigmasterol As Single,
        ByVal beta_sitosterol As Single, ByVal d_7_estigmasterol As Single, ByVal eritrodiol As Single, ByVal trilinoleinas As Single,
        ByVal Organoleptico As UShort, ByVal alcohol_alifatico As Single, ByVal Fecha As Date, ByVal campaña As Byte)

        Dim analisis As New eAnalisis

        analisis.ID = id
        analisis.Idalmazara = idalmazara
        analisis.Lote = lote
        analisis.Numtanque = numTanque
        analisis.Acidez = acidez
        analisis.Peroxidos = peroxidos
        analisis.K270 = k270
        analisis.K232 = k232
        analisis.Ceras = ceras
        analisis.Esteroles_tot = esteroles_tot
        analisis.Colesteroles = colesteroles
        analisis.Brasicasterol = brasicasterol
        analisis.Campesterol = campesterol
        analisis.Estigmasterol = estigmasterol
        analisis.Beta_sitosterol = beta_sitosterol
        analisis.D_7_estigmasterol = d_7_estigmasterol
        analisis.Eritrodiol = eritrodiol
        analisis.Trilinoleinas = trilinoleinas
        analisis.Organoleptico = Organoleptico
        analisis.Alcohol_alifatico = alcohol_alifatico
        analisis.Fecha = Fecha
        analisis.Campaña = campaña


        Return analisis

    End Function

    Public Sub BeginEdit() Implements System.ComponentModel.IEditableObject.BeginEdit
        If Not _editando Then

            _oldId = _Id
            _oldidalmazara = _idalmazara
            _oldLote = _Lote
            _oldnumTanque = _numTanque
            _oldacidez = _acidez
            _oldperoxidos = _peroxidos
            _oldk270 = _k270
            _oldk232 = _k232
            _oldceras = _ceras
            _oldesteroles_tot = _esteroles_tot
            _oldcolesteroles = _colesteroles
            _oldbrasicasterol = _brasicasterol
            _oldcampesterol = _campesterol
            _oldestigmasterol = _estigmasterol
            _oldbeta_sitosterol = _beta_sitosterol
            _oldd_7_estigmasterol = _d_7_estigmasterol
            _olderitrodiol = _eritrodiol
            _oldtrilinoleinas = _trilinoleinas
            _oldOrganoleptico = _Organoleptico
            _oldalcohol_alifatico = _alcohol_alifatico
            _oldFecha = _Fecha
            _oldcampaña = _campaña


            _editando = True
        End If
    End Sub

    Public Sub CancelEdit() Implements System.ComponentModel.IEditableObject.CancelEdit
        If _nuevo Then
            Me._parent.Remove(Me)
        Else
            _Id = _oldId
            _idalmazara = _oldidalmazara
            _Lote = _oldLote
            _numTanque = _oldnumTanque
            _acidez = _oldacidez
            _peroxidos = _oldperoxidos
            _k270 = _oldk270
            _k232 = _oldk232
            _ceras = _oldceras
            _esteroles_tot = _oldesteroles_tot
            _colesteroles = _oldcolesteroles
            _brasicasterol = _oldbrasicasterol
            _campesterol = _oldcampesterol
            _estigmasterol = _oldestigmasterol
            _beta_sitosterol = _oldbeta_sitosterol
            _d_7_estigmasterol = _oldd_7_estigmasterol
            _eritrodiol = _olderitrodiol
            _trilinoleinas = _oldtrilinoleinas
            _Organoleptico = _oldOrganoleptico
            _alcohol_alifatico = _oldalcohol_alifatico
            _Fecha = _oldFecha
            _campaña = _oldcampaña
        End If
        _editando = False
    End Sub

    Public Sub EndEdit() Implements System.ComponentModel.IEditableObject.EndEdit
        _editando = False
        _nuevo = False
    End Sub


    Public Sub New()

    End Sub
End Class