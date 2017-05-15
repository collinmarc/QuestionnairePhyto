Imports System.Xml.Serialization
Imports System.IO

<XmlInclude(GetType(ChoixAutre))>
Public Class Choix
    Private m_libelle As String
    Private m_bIsAutre As Boolean
    Private m_bIsSelected As Boolean
    Private m_pctAssocie As Integer

    Public Sub New()
        m_bIsAutre = False
        m_pctAssocie = 0
    End Sub
    Public Sub New(ByVal pLib As String)
        m_bIsAutre = False
        m_libelle = pLib
    End Sub

    Public Property Libelle As String
        Get
            Return m_libelle
        End Get
        Set(ByVal value As String)
            m_libelle = value
        End Set
    End Property
    ''' <summary>
    ''' Utilisée uniquement lors de l'affichage 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <XmlIgnore()>
    Public Property LibelleComplet As String
        Get
            If m_pctAssocie = 0 Then
                Return m_libelle
            Else
                Return m_libelle & " (" & m_pctAssocie & "% )"
            End If
        End Get
        Set(ByVal value As String)
            ' m_libelle = value
        End Set
    End Property
    Public Property EstSelectionne As Boolean
        Get
            Return m_bIsSelected
        End Get
        Set(ByVal value As Boolean)
            m_bIsSelected = value
        End Set
    End Property
    Public Property pctAssocie As Integer
        Get
            Return m_pctAssocie
        End Get
        Set(ByVal value As Integer)
            m_pctAssocie = value
        End Set
    End Property
    ''' <summary>
    ''' On utilise cette propriété pour convertir la valeur du trackball de (1-4) en (25-100)
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <XmlIgnore()>
    Public Property pctAssocie2 As Integer
        Get
            Return m_pctAssocie / 25
        End Get
        Set(ByVal value As Integer)
            m_pctAssocie = value * 25
        End Set
    End Property

    <XmlIgnore()>
    Public Property isAutre As Boolean
        Get
            Return m_bIsAutre
        End Get
        Set(ByVal value As Boolean)
            m_bIsAutre = True
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return m_libelle & "," & m_bIsAutre & "," & m_bIsSelected
    End Function
End Class
