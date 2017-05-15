Imports System.Xml.Serialization
Imports System.IO
Public Class Questionnaire
    Inherits Element
    Private m_Version As String
    Private m_name As String
    Public Property Version As String
        Get
            Return m_Version
        End Get
        Set(ByVal value As String)
            m_Version = value
        End Set
    End Property
    Public Function getNewName() As String
        Dim rsClient As String
        Dim NomAgent As String
        Dim oQClient As QIdent = Find("QCLIENT")
        If oQClient IsNot Nothing Then
            rsClient = oQClient.RaisonSociale
        End If
        Dim oQAgent As QIdent = Find("QAGENT")
        If oQAgent IsNot Nothing Then
            NomAgent = oQAgent.Nom
        End If
        Return Now.ToString("yyyyMMdd") & "-" & rsClient & "-" & NomAgent
    End Function
    Public Function getClient() As QIdent
        Dim oReturn As QIdent
        oReturn = Nothing
        Dim oQClient As QIdent = Find("QCLIENT")
        If oQClient IsNot Nothing Then
            oReturn = oQClient
        End If
        Return oReturn
    End Function
    Public Function getAgent() As QIdent
        Dim oReturn As QIdent
        oReturn = Nothing
        Dim oQClient As QIdent = Find("QAGENT")
        If oQClient IsNot Nothing Then
            oReturn = oQClient
        End If
        Return oReturn
    End Function
    Public Function writeXml(ByVal strFileName As String) As Boolean
        Dim bReturn As Boolean
        Dim objStreamWriter As StreamWriter = Nothing
        Try

            objStreamWriter = New StreamWriter(strFileName)
            Dim x As New XmlSerializer(Me.GetType)
            x.Serialize(objStreamWriter, Me)
            objStreamWriter.Close()
            bReturn = True
        Catch ex As Exception
            CSDebug.dispError("Questionnaire.WriteXML: " & ex.Message)
            If ex.InnerException IsNot Nothing Then
                CSDebug.dispError("Questionnaire.WriteXML: " & ex.InnerException.Message)
            End If
            bReturn = False
            If objStreamWriter IsNot Nothing Then
                objStreamWriter.Close()
            End If


        End Try
        Return bReturn
    End Function
    Public Function readXML(ByVal strFileName As String) As Boolean
        Dim bReturn As Boolean
        Try
            Dim olst As New Questionnaire()
            Dim objStreamReader As New StreamReader(strFileName)
            Dim x As New XmlSerializer(Me.GetType)
            olst = x.Deserialize(objStreamReader)
            objStreamReader.Close()
            Me.Code = olst.Code
            Me.Libelle = olst.Libelle
            Me.Version = olst.Version
            lstElements.Clear()
            For Each oParam As Element In olst.lstElements
                lstElements.Add(oParam)
            Next
            bReturn = True
        Catch ex As Exception
            CSDebug.dispError("Questionnaire.readXML: " & ex.Message)
            If ex.InnerException IsNot Nothing Then
                CSDebug.dispError("Questionnaire.readXML: " & ex.InnerException.Message)
            End If
        End Try
        Return bReturn
    End Function

    Public Function GenerateDataSet() As DataSet1
        Dim oDS As New DataSet1()
        Try

            Dim oQRow As DataSet1.QuestionnaireRow
            Dim nN1 As Integer
            oQRow = oDS.Questionnaire.AddQuestionnaireRow("Q1", Libelle)
            Dim oClient As QIdent
            oClient = Me.getClient()
            oDS.Client.AddClientRow(oClient.RaisonSociale, oClient.Nom, oClient.Adresse, oClient.CodePostal, oClient.Commune, oClient.Tel, oClient.Mail)
            nN1 = 0
            For Each oElement As Element In Me.lstElements
                oElement.AddReponseRow(oDS, nN1)
            Next
        Catch ex As Exception
            CSDebug.dispInfo("Questionnaire.GenerateDataset ERR" & ex.Message)
            oDS = New DataSet1()
        End Try

        Return oDS
    End Function
End Class
