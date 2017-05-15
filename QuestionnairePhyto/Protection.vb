Public Class Protection

    Public Function encode(ByVal pstr As String) As String
        Dim encText As New System.Text.UTF8Encoding()
        Dim btText() As Byte
        btText = encText.GetBytes(pstr)
        Dim str As String = ""
        For Each b As Byte In btText
            str = str & b.ToString() & "|"
        Next
        str = Left(str, str.Length - 1)
        Return str

    End Function

    Public Function decode(ByVal pstr As String) As String
        Dim decText As New System.Text.UTF8Encoding()

        Dim lstByte As New List(Of Byte)
        Dim tabstr() As String
        Dim sReturn As String

        tabstr = pstr.Split("|")
        For Each str2 As String In tabstr
            If str2 <> "" Then
                Dim b As Byte = str2
                lstByte.Add(b)
            End If
        Next

        sReturn = decText.GetString(lstByte.ToArray())
        Return sReturn
    End Function

    Public Function Check(ByVal pDate As Date) As Boolean
        Dim bReturn As Boolean
        Try

            Dim dDateLimite As Date

            dDateLimite = decode(My.Settings.check)

            CSDebug.dispInfo(dDateLimite)
            If pDate > dDateLimite Then
                bReturn = False
            Else
                bReturn = True
            End If
        Catch ex As Exception
            CSDebug.dispInfo("Protection.Check ERR : " & ex.Message)
            bReturn = False
        End Try
        Return bReturn
    End Function
End Class
