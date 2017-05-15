Imports System.Xml.Serialization
Imports System.IO

Public Class Question
    Inherits Element
    Protected m_LibelleChapitre As String
    Protected m_LstChoix As List(Of Choix)
    Protected m_Reponse As String
    Protected m_Precision As String
    Protected m_ChoixMultiples As Boolean
    Protected m_PctAssocie As Boolean
    Protected m_Obligatoire As Boolean
    Protected m_isCommentaire As Boolean

    Public Sub New()
        m_LstChoix = New List(Of Choix)
        m_Reponse = ""
        m_ChoixMultiples = True
        m_PctAssocie = False
        m_Visible = True
        m_Obligatoire = True
        m_isCommentaire = False
    End Sub

    Public Sub New(ByVal pCode As String, ByVal pLib As String)
        Me.New()
        Code = pCode
        Libelle = pLib
    End Sub


    Public Property ListOfChoix As List(Of Choix)
        Get
            Return m_LstChoix
        End Get
        Set(ByVal value As List(Of Choix))
            m_LstChoix = value
        End Set
    End Property
    <XmlIgnore()>
    Public Property LibelleChapitre As String
        Get
            Return m_LibelleChapitre
        End Get
        Set(ByVal value As String)
            m_LibelleChapitre = value
        End Set
    End Property
    Public Overridable Property Reponse As String
        Get
            Return m_Reponse
        End Get
        Set(ByVal value As String)
            m_Reponse = value
        End Set
    End Property
    Public Overrides Function GetReponsecomplete() As String
        Dim strReponse As String = ""
        'Construction de la Réponse"
        If Me.ActifInactifQ Then
            If ActifInactifR = False Then
                strReponse = "NON"
            End If
        End If
        If strReponse <> "NON" Then
            If ListOfChoix.Count = 0 Then
                strReponse = m_Reponse
            Else
                For Each oChoix As Choix In ListOfChoix
                    If oChoix.EstSelectionne Then
                        strReponse = strReponse + oChoix.LibelleComplet + " , "
                        If oChoix.isAutre Then
                            strReponse = Left(strReponse, strReponse.Length - 3)
                            strReponse = strReponse + "(" & Precision & ") , "
                        End If
                    End If
                Next
                If strReponse.Length > 3 Then
                    strReponse = Left(strReponse, strReponse.Length - 3)
                End If
            End If


        End If
        Return strReponse
    End Function
    Public Property Precision As String
        Get
            Return m_Precision
        End Get
        Set(ByVal value As String)
            m_Precision = value
        End Set
    End Property
    Public Property ChoixMultiples As Boolean
        Get
            Return m_ChoixMultiples
        End Get
        Set(ByVal value As Boolean)
            m_ChoixMultiples = value
        End Set
    End Property
    Public Property pctAssocie As Boolean
        Get
            Return m_PctAssocie
        End Get
        Set(ByVal value As Boolean)
            m_PctAssocie = value
        End Set
    End Property
    Public Property Obligatoire As Boolean
        Get
            Return m_Obligatoire
        End Get
        Set(ByVal value As Boolean)
            m_Obligatoire = value
        End Set
    End Property
    ''' <summary>
    ''' Controle si la réponse est Ok
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overridable Function isOk() As Boolean
        Dim bReturn As Boolean
        bReturn = True
        If isActif And Obligatoire Then
            bReturn = False
            'Vérification qu'au moins un choix est sélectionné
            If ListOfChoix.Count > 0 Then
                For Each oChoix As Choix In m_LstChoix
                    If oChoix.EstSelectionne Then
                        bReturn = True
                    End If
                Next
                'Vérification que siAutre est sélectionné => précision est renseigné
                If bReturn Then
                    For Each oChoix As Choix In m_LstChoix
                        If oChoix.EstSelectionne And oChoix.isAutre Then
                            If String.IsNullOrEmpty(Precision) Then
                                bReturn = False
                            End If
                        End If
                    Next
                End If
                'Vérification que un pourcentage est demandé => il est renseigné (<>0)
                If bReturn Then
                    For Each oChoix As Choix In m_LstChoix
                        If oChoix.EstSelectionne And pctAssocie Then
                            If oChoix.pctAssocie = 0 Then
                                bReturn = False
                            End If
                        End If
                    Next
                End If
            Else
                If Reponse.Length > 0 Then
                    bReturn = True
                End If
            End If
        End If
        Return bReturn
    End Function
    ''' <summary>
    ''' Selectionne ou Deselectionne un choix 
    ''' </summary>
    ''' <param name="index">numéro du choix </param>
    ''' <param name="bValue">Valeur EstSelectionné</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overridable Function SelectChoix(ByVal index As Integer, ByVal bValue As Boolean) As Boolean
        Dim bReturn As Boolean

        Try
            bReturn = False
            Dim oChoix As Choix
            If index < ListOfChoix.Count Then
                oChoix = ListOfChoix(index)
                oChoix.EstSelectionne = bValue
                bReturn = True
            End If

        Catch ex As Exception
            CSDebug.dispError("Question.SelectChoix ERR" & ex.Message)
            bReturn = False
        End Try
        Return bReturn
    End Function
    Public Overrides Function getCSV() As String
        Dim sReturn As String
        Try
            sReturn = ""
            sReturn = MyBase.getCSV() & ";" & Reponse
            For Each oChoix In ListOfChoix
                sReturn = sReturn & ";" & oChoix.Libelle & ";" & oChoix.EstSelectionne & ";" & pctAssocie & ";" & oChoix.isAutre
            Next
            sReturn = sReturn & ";" & Me.Precision & ";" & Me.Commentaire
        Catch ex As Exception
            CSDebug.dispInfo("Question.getcsv ERR" & ex.Message)
            sReturn = ""
        End Try
        Return sReturn
    End Function

    Public Function isCommentaire() As Boolean
        Return m_isCommentaire
    End Function

End Class
