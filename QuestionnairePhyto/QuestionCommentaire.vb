Imports System.Xml.Serialization
Imports System.IO

<XmlInclude(GetType(QuestionCommentaire))>
Public Class QuestionCommentaire
    Inherits Question

    Public Sub New()
        MyBase.New()
        m_isCommentaire = True
    End Sub
    Public Overrides Function isOk() As Boolean
        Return True
    End Function
End Class
