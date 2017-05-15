Imports System.Xml.Serialization
Imports System.IO

<Serializable(), XmlInclude(GetType(Groupe))>
Public Class Groupe
    Inherits Element

    Public Sub New(ByVal pCode As String, ByVal pLib As String)
        Code = pCode
        Libelle = pLib
    End Sub
    Public Sub New()
        Libelle = ""
    End Sub

    Public Overrides Function GetReponsecomplete() As String
        If ActifInactifR Then
            Return ""
        Else
            Return "NON"
        End If
    End Function


End Class
