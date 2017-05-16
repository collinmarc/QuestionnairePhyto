Imports System.Xml.Serialization
Imports System.IO
<Serializable(), XmlInclude(GetType(Element))>
<XmlInclude(GetType(Groupe))>
<XmlInclude(GetType(Question))>
<XmlInclude(GetType(QIdent))>
<XmlInclude(GetType(QuestionOuiNon))>
<XmlInclude(GetType(QuestionCommentaire))>
Public Class Element

    Protected m_lstElements As List(Of Element)
    Protected m_Code As String
    Protected m_LibCourt As String
    Protected m_Lib As String
    Protected m_Node As TreeNode
    Protected m_Visible As Boolean
    Private m_Commentaire As String
    Private m_ActifInactifQ As Boolean
    Private m_ActifInactifR As Boolean
    Private m_LibelleActif As String
    Private m_isDernierElement As Boolean
#Region "Evenements"
    Public Event ActivateChilds As EventHandler
    Public Event DesActivateChilds As EventHandler
    ''' <summary>
    ''' Méthode de déclenchement des événements
    ''' </summary>
    ''' <remarks></remarks>
    Protected Sub RaiseEventActivateChilds()
        RaiseEvent ActivateChilds(Me, New EventArgs())
    End Sub
    Protected Sub RaiseEventDesAcivateChilds()
        RaiseEvent DesActivateChilds(Me, New EventArgs())
    End Sub
#End Region

    Public Sub New()
        m_lstElements = New List(Of Element)
        m_ActifInactifQ = False
        m_ActifInactifR = True
        m_isDernierElement = False
    End Sub

    Public Property LibelleCourt As String
        Get
            If String.IsNullOrWhiteSpace(m_LibCourt) Then
                Return m_Lib
            Else
                Return m_LibCourt
            End If
        End Get
        Set(ByVal value As String)
            m_LibCourt = value
        End Set
    End Property
    Public Property Libelle As String
        Get
            Return m_Lib
        End Get
        Set(ByVal value As String)
            m_Lib = value
        End Set
    End Property
    Public Property Code As String
        Get
            Return m_Code
        End Get
        Set(ByVal value As String)
            m_Code = value
        End Set
    End Property

    Public Property lstElements As List(Of Element)
        Get
            Return m_lstElements
        End Get
        Set(ByVal value As List(Of Element))
            m_lstElements = value
        End Set
    End Property
    <XmlIgnore()>
    Public Property TvNode As TreeNode
        Get
            Return m_Node
        End Get
        Set(ByVal value As TreeNode)
            m_Node = value
        End Set
    End Property
    Public Sub Add(ByVal pElement As Element)
        m_lstElements.Add(pElement)
    End Sub

    Public Sub Display()
        CSDebug.dispInfo("Code=" & Code & ", Libelle=" & Libelle)
        For Each oElmt As Element In lstElements
            oElmt.Display()
        Next
    End Sub

    Public Property Commentaire As String
        Get
            Return m_Commentaire
        End Get
        Set(ByVal value As String)
            m_Commentaire = value
        End Set
    End Property
    Public Property ActifInactifQ As Boolean
        Get
            Return m_ActifInactifQ
        End Get
        Set(ByVal value As Boolean)
            m_ActifInactifQ = value
        End Set
    End Property
    Public Property ActifInactifR As Boolean
        Get
            Return m_ActifInactifR
        End Get
        Set(ByVal value As Boolean)
            m_ActifInactifR = value
        End Set
    End Property
    <XmlIgnore()>
    Public Property isActif As Boolean
        Get
            Return ActifInactifR
        End Get
        Set(ByVal value As Boolean)
            ActifInactifR = value
            If value Then
                RaiseEventActivateChilds()
            End If
        End Set
    End Property
    <XmlIgnore()>
    Public Property isInactif As Boolean
        Get
            Return Not ActifInactifR
        End Get
        Set(ByVal value As Boolean)
            ActifInactifR = Not value
            If value Then
                RaiseEventDesAcivateChilds()
            End If
        End Set
    End Property
    Public Property LibelleActif As String
        Get
            Return m_LibelleActif
        End Get
        Set(ByVal value As String)
            m_LibelleActif = value
        End Set
    End Property

    Public Property DernierElement As Boolean
        Get
            Return m_isDernierElement
        End Get
        Set(ByVal value As Boolean)
            m_isDernierElement = value
        End Set
    End Property
    Public Function Find(ByVal strCode As String) As Element
        Dim oReturn As Element
        Try
            Dim bFound As Boolean
            oReturn = Nothing
            bFound = False
            'Parcours des Fils pour trouver l'element
            For Each oElement As Element In lstElements
                If oElement.Code = strCode Then
                    oReturn = oElement
                    bFound = True
                    Exit For
                End If
            Next

            If Not bFound Then
                'Lélément n'est pas dans les fils, alors on scrute chaque fils
                For Each oElement As Element In lstElements
                    oReturn = oElement.Find(strCode)
                    If oReturn IsNot Nothing Then
                        bFound = True
                        Exit For
                    End If
                Next
            End If
        Catch ex As Exception
            CSDebug.dispError("Element.Find Err " & ex.Message)
            oReturn = Nothing
        End Try
        Return oReturn
    End Function

    Public Overridable Function ToCSV() As String
        Dim sReturn As String
        Try
            sReturn = ""
            For Each oElement As Element In lstElements
                sReturn = sReturn & oElement.getCSV()
                sReturn = sReturn & ";" & oElement.ToCSV() & vbCrLf
            Next
        Catch ex As Exception
            sReturn = ""
            CSDebug.dispInfo("Element.ToCSV ERR" & ex.Message)
        End Try
        Return sReturn
    End Function

    Public Overridable Function getCSV() As String
        'Protected m_Code As String
        'Protected m_LibCourt As String
        'Protected m_Lib As String
        'Protected m_Node As TreeNode
        'Protected m_Visible As Boolean
        'Private m_Commentaire As String
        'Private m_ActifInactifQ As Boolean
        'Private m_ActifInactifR As Boolean
        'Private m_LibelleActif As String
        Return Code & ";" & LibelleCourt & ";" & Libelle & ";" & ActifInactifR
    End Function

    Public Overridable Function AddReponseRow(ByVal pDS As DataSet1, ByVal pProfondeur As Integer) As Boolean
        Dim bReturn As Boolean
        Try
            If m_isDernierElement Then
                Libelle = LibelleCourt
            End If

            If m_isDernierElement And String.IsNullOrEmpty(GetReponsecomplete()) Then
                'Si c'est le dernier elément(Commentaire Général de l'agent) Et qu'il est vide
                '=> on ne l'ajoute pas
            Else
                pDS.Reponse.AddReponseRow(Libelle, GetReponsecomplete(), Code, "", "", 0, 0, pProfondeur)
            End If
            If isActif Then
                pProfondeur = pProfondeur + 1
                For Each oElement In lstElements
                    oElement.AddReponseRow(pDS, pProfondeur)
                Next
            End If
            bReturn = True
        Catch ex As Exception
            CSDebug.dispError("Element.AddReponseRow ERR" & ex.Message)
            bReturn = False
        End Try
        Return bReturn
    End Function

    Public Overridable Function GetReponsecomplete() As String
        If ActifInactifR Then
            Return "OUI"
        Else
            Return "NON"
        End If
    End Function


End Class
