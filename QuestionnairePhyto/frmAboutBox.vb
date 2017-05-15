Public NotInheritable Class frmAboutBox

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Définissez le titre du formulaire.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("À propos de {0}", ApplicationTitle)
        ' Initialisez tout le texte affiché dans la boîte de dialogue À propos de.
        ' TODO: personnalisez les informations d'assembly de l'application dans le volet "Application" de la 
        '    boîte de dialogue Propriétés du projet (sous le menu "Projet").
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Me.TextBoxDescription.Text = My.Application.Info.Description

        Dim oQuestionnaire As Questionnaire
        oQuestionnaire = New Questionnaire()
        oQuestionnaire.readXML("Questionnaire.xml")
        Me.TextBoxDescription.Text = Me.TextBoxDescription.Text & vbCrLf & "Questionnaire Version : " & oQuestionnaire.Version
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub ContextMenuStrip1_Click(sender As Object, e As EventArgs) Handles ContextMenuStrip1.Click

    End Sub

    Private Sub EncodeDecodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncodeDecodeToolStripMenuItem.Click
        frmProtect.ShowDialog()
    End Sub
End Class
