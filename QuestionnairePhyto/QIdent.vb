Public Class QIdent
    Inherits Question

    Private m_Type As String
    Private m_RaisonSociale As String
    Private m_Nom As String
    Private m_Adresse As String
    Private m_CP As String
    Private m_Commune As String
    Private m_Tel As String
    Private m_mail As String
    Private m_sau As Integer
    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal pCode As String, ByVal pLib As String)
        MyBase.New(pCode, pLib)
    End Sub
    ''' <summary>
    ''' Client ou Agent
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Type As String
        Get
            Return m_Type
        End Get
        Set(ByVal value As String)
            m_Type = value
        End Set
    End Property
    Public Property RaisonSociale As String
        Get
            Return m_RaisonSociale
        End Get
        Set(ByVal value As String)
            m_RaisonSociale = value
        End Set
    End Property

    Public Property Nom As String
        Get
            Return m_Nom
        End Get
        Set(ByVal value As String)
            m_Nom = value
        End Set
    End Property
    Public Property Adresse As String
        Get
            Return m_Adresse
        End Get
        Set(ByVal value As String)
            m_Adresse = value
        End Set
    End Property
    Public Property CodePostal As String
        Get
            Return m_CP
        End Get
        Set(ByVal value As String)
            m_CP = value
        End Set
    End Property
    Public Property Commune As String
        Get
            Return m_Commune
        End Get
        Set(ByVal value As String)
            m_Commune = value
        End Set
    End Property
    Public Property Tel As String
        Get
            Return m_Tel
        End Get
        Set(ByVal value As String)
            m_Tel = value
        End Set
    End Property
    Public Property Mail As String
        Get
            Return m_mail
        End Get
        Set(ByVal value As String)
            m_mail = value
        End Set
    End Property
    Public Property sau As Integer
        Get
            Return m_sau
        End Get
        Set(ByVal value As Integer)
            m_sau = value
        End Set
    End Property

    Public Overrides Property Reponse As String
        Get
            Return RaisonSociale & "|" & Nom & "|" & Adresse & "|" & CodePostal & "|" & Commune & "|" & Tel & "|" & Mail
        End Get
        Set(ByVal value As String)
            'm_Reponse(0) = value
        End Set
    End Property
    ''' <summary>
    ''' Controle si la réponse est Ok
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function isOk() As Boolean
        Dim bReturn As Boolean
        bReturn = False
        If isActif And Obligatoire Then
            If (RaisonSociale <> "" Or Nom <> "") Then
                bReturn = True
            End If
            If bReturn And Code <> "QAGENT" Then
                'Il faut le nom ou la raison Sociale ET un element de l'adresse
                If (Adresse <> "" Or m_CP <> "" Or Commune <> "") Then
                    bReturn = True
                End If
            Else
            End If
        End If
            Return bReturn
    End Function
    Public Overrides Function ToCSV() As String
        Dim sReturn As String
        Try
            Return RaisonSociale & ";" & Nom & ";" & Adresse & ";" & CodePostal & ";" & Commune & ";" & Tel & ";" & Mail & ";" & sau
        Catch ex As Exception
            CSDebug.dispInfo("Question.tocsv ERR" & ex.Message)
            sReturn = ""
        End Try
        Return sReturn
    End Function
    Public Overrides Function AddReponseRow(ByVal pDS As DataSet1, ByVal pProfondeur As Integer) As Boolean
        Dim bReturn As Boolean
        Try
            'pDS.Reponse.AddReponseRow(Libelle, GetReponsecomplete(), Code, "", "", 0, 0, pProfondeur)
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

End Class
