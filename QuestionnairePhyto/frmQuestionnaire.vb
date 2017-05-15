Public Class frmQuestionnaire
    Private m_Questionnaire As New Questionnaire()
    Protected WithEvents m_oElement As Element
    Private Sub btnInit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInit.Click
        init()
        FillTreeview()
    End Sub
    Private Sub VerifConFig()
        Dim oCR As crQuestionnaire

        Try
            oCR = New crQuestionnaire()
        Catch ex As Exception
            If Environment.Is64BitOperatingSystem Then
                Shell("msiexec /i CRRuntime_64bit_13_0_2.msi /passive", AppWinStyle.NormalFocus, True, -1)
            Else
                Shell("msiexec /i CRRuntime_32bit_13_0_2.msi /passive", AppWinStyle.NormalFocus, True, -1)
            End If
            Me.Close()

        End Try
    End Sub
    Private Sub init()

        m_Questionnaire.readXML("Questionnaire.xml")
        m_Questionnaire.Libelle = "Questionnaire"

        FillTreeview()

    End Sub
    Private Sub FillTreeview()
        TreeView1.Nodes.Clear()
        FillTreeview(TreeView1.Nodes, m_Questionnaire)
        pnlIdentification.Visible = False
        pnlQuestion.Visible = False
    End Sub

    Private Function FillTreeView(ByVal pNodes As TreeNodeCollection, ByVal pElement As Element) As Boolean
        Dim bReturn As Boolean
        Try
            Dim oNode As TreeNode
            oNode = pNodes.Add(pElement.LibelleCourt)
            oNode.Tag = pElement
            pElement.TvNode = oNode
            setImages(oNode, pElement)
            For Each oElement In pElement.lstElements
                FillTreeview(oNode.Nodes, oElement)
            Next
            bReturn = True
        Catch ex As Exception
            CSDebug.dispError("Element.FillTreeView ERR" & ex.Message)
            bReturn = False
        End Try
        Return bReturn

    End Function
    Private Sub SetImages(ByVal pNode As TreeNode, ByVal pElement As Element)
        pNode.SelectedImageIndex = 1
        pNode.ImageIndex = 0

        If TypeOf (pElement) Is Question Then
            pNode.SelectedImageIndex = 3
            pNode.ImageIndex = 2
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oProtect As New Protection()
        If oProtect.Check(Date.Now()) Then
            Verifconfig()
            init()
            FillTreeview()
        Else
            MessageBox.Show("Date Limite atteinte , contactez le CRODIP pour obtenir une extension")
            Me.Close()
        End If
    End Sub

    Private Sub TreeView1_AfterExpand(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterExpand
        'TreeView1.SelectedNode = e.Node
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        If TreeView1.SelectedNode IsNot Nothing Then
            TreeView1.SelectedNode.Expand()
            Dim oElement As Element
            Dim oQuestion As Question
            If TreeView1.SelectedNode IsNot Nothing Then
                oElement = TreeView1.SelectedNode.Tag
                If TypeOf (oElement) Is Question Then
                    oQuestion = oElement
                    If Not oElement.DernierElement Then
                        'Récupération du nom du groupe (Parent)
                        Dim onodeParent As TreeNode
                        onodeParent = TreeView1.SelectedNode.Parent()
                        Dim oElementParent As Element
                        oElementParent = onodeParent.Tag
                        oQuestion.LibelleChapitre = oElementParent.Libelle
                    Else
                        oQuestion.LibelleChapitre = oQuestion.LibelleCourt
                    End If
                    DisplayQuestion(oQuestion)
                End If
                If TypeOf (oElement) Is Groupe Then
                    If oElement.ActifInactifQ Then
                        DisplayGroupe(oElement)
                    Else
                        TreeView1.SelectedNode = TreeView1.SelectedNode.FirstNode

                    End If
                End If
            End If
        End If
    End Sub

    Private Sub TreeView1_AfterCollapse(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterCollapse
        TreeView1.SelectedNode = Nothing
    End Sub
    Private Sub DesActivateChilds(ByVal Sender As Object, ByVal e As EventArgs) Handles m_oElement.DesActivateChilds
        m_oElement.TvNode.Nodes.Clear()
    End Sub
    Private Sub ActivateChilds(ByVal Sender As Object, ByVal e As EventArgs) Handles m_oElement.ActivateChilds
        m_oElement.TvNode.Nodes.Clear()
        For Each oElmt As Element In m_oElement.lstElements
            FillTreeview(m_oElement.TvNode.Nodes, oElmt)
        Next
    End Sub
    Private Sub DisplayQuestion(ByVal pQuestion As Question)

        m_oElement = pQuestion
        If TypeOf (pQuestion) Is QIdent Then
            Dim oQI As QIdent
            oQI = pQuestion
            m_bsQIdent.Clear()
            m_bsQIdent.Add(oQI)
            pnlQuestion.Visible = False
            If oQI.Code = "QAGENT" Then
                pnlQuestion.Visible = False
                pnlIdentification.Visible = False
                pnlGroup.Visible = False
                PnIdentAgent.Visible = True

                PnIdentAgent.Dock = DockStyle.Fill
                PnIdentAgent.Top = 0
                PnIdentAgent.Left = 0
            Else
                pnlQuestion.Visible = False
                pnlIdentification.Visible = True
                pnlGroup.Visible = False
                PnIdentAgent.Visible = False

                pnlIdentification.Dock = DockStyle.Fill
                pnlIdentification.Top = 0
                pnlIdentification.Left = 0
            End If
        Else

            If TypeOf (pQuestion) Is Question Then
                ' Stockage de la question dans le binding Source
                m_bsQuestion.Add(pQuestion)
                m_bsQuestion.MoveLast()
                'Activation des controles par defaut
                pnlQuestion.Visible = True
                pnlIdentification.Visible = False
                pnlGroup.Visible = False
                PnIdentAgent.Visible = False

                pnlQuestion.Top = 0
                pnlQuestion.Left = 0
                pnlQuestion.Dock = DockStyle.Fill
                pnlPrecisez.Visible = False
                pnlAssocie.Visible = False
                'Question prealable (Oui/Non)
                If pQuestion.ActifInactifQ Then
                    rbOui.Visible = True
                    rbNon.Visible = True
                Else
                    rbOui.Visible = False
                    rbNon.Visible = False
                    ' Si pas de Préalable Oui/ non => Affichage des choix
                    pQuestion.ActifInactifR = True
                End If
                'liste de choix ou reponse
                If pQuestion.ListOfChoix.Count = 0 Then
                    CheckedListBox1.Visible = False
                    'Si c'est une question OuiNon => pas de zone de réponse
                    If TypeOf (pQuestion) Is QuestionOuiNon Then
                        tbReponse.Visible = False
                    Else
                        tbReponse.Visible = True
                    End If
                Else
                    CheckedListBox1.Visible = True
                    tbReponse.Visible = False
                    Dim indice As Integer
                    Dim oChoix As Choix
                    Dim PremierChoix As Integer = 0
                    Dim bItemSelected As Boolean = False
                    For indice = 0 To pQuestion.ListOfChoix.Count - 1
                        oChoix = pQuestion.ListOfChoix(indice)
                        CheckedListBox1.SetItemChecked(indice, oChoix.EstSelectionne)
                        If oChoix.EstSelectionne And Not bItemSelected Then
                            PremierChoix = indice
                            bItemSelected = True
                        End If
                    Next
                    'Sélection par défaut du Premier choix selectionné ou premier choix tout court
                    CheckedListBox1.SelectedIndex = PremierChoix
                End If
                'Affichage d'une Question commentaire 
                If pQuestion.isCommentaire Then
                    'Désactivation du bloc Commentaire sur la Question
                    tbCommentaire.Visible = False
                    LaCommentaire.Visible = False
                    tbReponse.Height = 29 * 10
                Else
                    tbCommentaire.Visible = True
                    LaCommentaire.Visible = True
                    tbReponse.Height = 29 * 1
                End If
            End If
        End If


    End Sub

    Private Sub DisplayGroupe(ByVal pGroupe As Groupe)

        m_oElement = pGroupe

        ' Stockage de la question dans le binding Source
        m_bsGroup.Add(pGroupe)
        m_bsGroup.MoveLast()
        'Activation des controles par defaut
        pnlQuestion.Visible = False
        pnlIdentification.Visible = False
        pnlGroup.Visible = True
        PnIdentAgent.Visible = False
        pnlGroup.Top = 0
        pnlGroup.Left = 0
        pnlGroup.Dock = DockStyle.Fill
        'Question prealable (Oui/Non)
        If pGroupe.ActifInactifQ Then
            rbOui.Visible = True
            rbNon.Visible = True
        Else
            rbOui.Visible = False
            rbNon.Visible = False
            ' Si pas de Préalable Oui/ non => Affichage des choix
            pGroupe.ActifInactifR = True
        End If
 

    End Sub


#Region "Navigation"
#Region "Evenements"
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        QuestionSuivante()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        questionPrecedente()
    End Sub
    Private Sub BtnMoveToFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMoveToFirst.Click
        ChapitrePrecedent()
    End Sub
    Private Sub btnMoveToNextFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveToNextFirst.Click
        ChapitreSuivant()
    End Sub
    Private Sub QuestionSuivante()
        If TreeView1.SelectedNode IsNot Nothing Then
            If checkQuestionObligatoire() Then
                TreeView1.SelectedNode = GetQuestionSuivante(TreeView1.SelectedNode)
            End If
        End If

    End Sub

    Private Sub questionPrecedente()
        If TreeView1.SelectedNode IsNot Nothing Then
            'Il y a bien un noeud selectionné
            TreeView1.SelectedNode = getQuestionPrecedente(TreeView1.SelectedNode, True)
        End If
    End Sub
    Private Sub ChapitrePrecedent()
        If TreeView1.SelectedNode IsNot Nothing Then
            'Il y a bien un noeud selectionné
            TreeView1.SelectedNode = getChapitrePrecedent(TreeView1.SelectedNode)
        End If
    End Sub
    Private Sub ChapitreSuivant()
        If TreeView1.SelectedNode IsNot Nothing Then
            'Il y a bien un noeud selectionné
            TreeView1.SelectedNode = getChapitreSuivant(TreeView1.SelectedNode)
        End If
    End Sub

#End Region

#Region "Méthodes"
    ''' <summary>
    ''' Rend la Question Suivante , ou la première question du groupe suivant
    ''' </summary>
    ''' <param name="pNode">Noeud en cours</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetQuestionSuivante(ByVal pNode As TreeNode) As TreeNode
        Dim oReturn As TreeNode
        If pNode.Nodes.Count > 0 Then
            'on passe au premier Fils
            oReturn = pNode.Nodes(0)
        Else
            If pNode.NextNode Is Nothing Then
                'Pas noeud suivant, on passe au niveau au dessus
                If pNode.Parent.NextNode IsNot Nothing Then
                    oReturn = pNode.Parent.NextNode
                Else
                    If pNode.Parent.Parent IsNot Nothing Then
                        If pNode.Parent.Parent.NextNode IsNot Nothing Then
                            oReturn = pNode.Parent.Parent.NextNode
                            '                            oReturn = GetQuestionSuivante(pNode.Parent.Parent)
                        Else
                            oReturn = pNode
                        End If
                    Else
                        oReturn = pNode
                    End If
                    End If
            Else
                    'Noued du même niveau
                    oReturn = pNode.NextNode
            End If
        End If
        Return oReturn
    End Function
    ''' <summary>
    ''' Rend la Question precedente, ou la première ou dernièe question du noeud précédent
    ''' </summary>
    ''' <param name="pNode">Noueud courant</param>
    ''' <param name="bGetLastChild"> Vrai = Rend la première question du noeud , Faux = rend la dernière question du noeud</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function getQuestionPrecedente(ByVal pNode As TreeNode, ByVal bGetLastChild As Boolean) As TreeNode
        Dim oReturn As TreeNode = Nothing
        If pNode.PrevNode Is Nothing Then
            'On vérifie sur le noeud parent est un groupe et qu'il est Actif/inactif

            'Pas noeud Précédent, on passe au niveau au dessus
            If pNode.Parent IsNot Nothing Then
                If TypeOf (pNode.Parent.Tag) Is Groupe Then
                    If pNode.Parent.Tag.ActifInactifQ Then
                        oReturn = pNode.Parent
                    Else

                        oReturn = getQuestionPrecedente(pNode.Parent, bGetLastChild)
                    End If
                End If
            Else
                oReturn = Nothing
            End If
        Else
            If pNode.PrevNode.Nodes.Count > 0 Then
                If bGetLastChild Then
                    oReturn = getLastChild(pNode.PrevNode)
                Else
                    oReturn = getFirstChild(pNode.PrevNode)
                End If

            Else
                oReturn = pNode.PrevNode
            End If
        End If
        Return oReturn
    End Function
    ''' <summary>
    ''' Rend la tête de chapitre précédent, la première question du noeud ou la première question du noeud précédent
    ''' </summary>
    ''' <param name="pNode"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function getChapitrePrecedent(ByVal pNode As TreeNode) As TreeNode
        Dim oReturn As TreeNode = Nothing
        If pNode.Parent IsNot Nothing Then
            If pNode.Parent.FirstNode IsNot Nothing Then
                If pNode.Parent.FirstNode.Equals(pNode) Then
                    oReturn = getQuestionPrecedente(pNode, False)
                Else
                    oReturn = pNode.Parent.FirstNode
                End If

            End If
        End If

        Return oReturn
    End Function

    ''' <summary>
    ''' Rend la fin du chapitre ou la Premère question du chapitre suivant
    ''' </summary>
    ''' <param name="pNode"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function getChapitreSuivant(ByVal pNode As TreeNode) As TreeNode
        Dim oReturn As TreeNode = Nothing

        If pNode.Parent IsNot Nothing Then
            If pNode.Parent.LastNode IsNot Nothing Then
                If pNode.Parent.LastNode.Equals(pNode) Then
                    'On est positionné sur la dernière questiondu chapitre, on passe à la première du chapitre suivant
                    oReturn = GetQuestionSuivante(pNode)
                Else
                    oReturn = pNode.Parent.LastNode
                End If

            End If
        End If

        Return oReturn
    End Function
    ''' <summary>
    ''' Rend le dernier noeud du dernier Fils
    ''' </summary>
    ''' <param name="pNode"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function getLastChild(ByVal pNode As TreeNode) As TreeNode
        Dim oReturn As TreeNode
        If pNode.LastNode.Nodes.Count > 0 Then
            oReturn = getLastChild(pNode.LastNode)
        Else
            oReturn = pNode.LastNode
        End If
        Return oReturn
    End Function
    ''' <summary>
    ''' Rend le Premier Noeud du premier Fils
    ''' </summary>
    ''' <param name="pNode"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function getFirstChild(ByVal pNode As TreeNode) As TreeNode
        Dim oReturn As TreeNode
        If pNode.FirstNode.Nodes.Count > 0 Then
            oReturn = getFirstChild(pNode.FirstNode)
        Else
            oReturn = pNode.FirstNode
        End If
        Return oReturn
    End Function


#End Region

#End Region


    Private Sub CheckedListBox1_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles CheckedListBox1.ItemCheck
        ItemCheck(e)
    End Sub
    Private Sub ItemCheck(ByVal e As ItemCheckEventArgs)
        Dim oQuestion As Question
        Dim oChoix As Choix
        oQuestion = m_bsQuestion.Current
        oChoix = oQuestion.ListOfChoix(e.Index)
        'Vérification du choix multiple
        If Not oQuestion.ChoixMultiples Then
            'Pas de choix multiples
            If e.NewValue Then
                'on déselectionne tous les autres items
                If CheckedListBox1.CheckedItems.Count > 0 Then
                    For i As Integer = 0 To CheckedListBox1.Items.Count - 1
                        CheckedListBox1.SetItemChecked(i, False)
                    Next i
                End If
            End If
        End If
        'Sélection /Déselection d'une option
        oQuestion.SelectChoix(e.Index, e.NewValue)

        oChoix.EstSelectionne = e.NewValue
        'S'il y a une réponse associée et que l'item sélectionné est checké
        If oQuestion.pctAssocie And oChoix.EstSelectionne Then
            pnlAssocie.Visible = True
        Else
            pnlAssocie.Visible = False
        End If

        'Cas particulier du Autre
        pnlPrecisez.Visible = False
        For Each oChoix2 In oQuestion.ListOfChoix
            If TypeOf (oChoix2) Is ChoixAutre And oChoix2.EstSelectionne Then
                pnlPrecisez.Visible = True
            End If

        Next
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        m_SaveFileDialog1.FileName = m_Questionnaire.getNewName()
        m_SaveFileDialog1.InitialDirectory = System.Environment.CurrentDirectory
        m_SaveFileDialog1.Filter = "Fichier XML|*.xml"
        If m_SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            m_Questionnaire.Libelle = System.IO.Path.GetFileNameWithoutExtension(m_SaveFileDialog1.FileName)
            m_Questionnaire.writeXml(m_SaveFileDialog1.FileName)
        End If

    End Sub

    Private Sub rbOui_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbOui.CheckedChanged
        PnlQuestionOui.Visible = rbOui.Checked
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        m_OpenFileDialog1.InitialDirectory = System.Environment.CurrentDirectory
        If m_OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            m_Questionnaire = New Questionnaire()
            m_Questionnaire.readXML(m_OpenFileDialog1.FileName)
            FillTreeview()
        End If

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Me.Cursor = Cursors.WaitCursor
        Generate()
        Me.Cursor = Me.DefaultCursor
    End Sub

    Private Function Generate() As Boolean
        Dim bReturn As Boolean
        Try
            Dim strName As String
            bReturn = False
            If String.IsNullOrEmpty(m_Questionnaire.getAgent().RaisonSociale) Or String.IsNullOrEmpty(m_Questionnaire.getAgent().Nom) Or String.IsNullOrEmpty(m_Questionnaire.getClient().RaisonSociale) Then
                ToolStripStatusLabel1.Text = "Vous devez renseigner la partie identification avant la génération du rapport"
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                Return False
            Else
                ToolStripStatusLabel1.Text = ""
            End If
            'Récupération du nom du fichier (Sans Extension)
            m_SaveFileDialog1.FileName = m_Questionnaire.getNewName()
            m_SaveFileDialog1.InitialDirectory = System.Environment.CurrentDirectory
            m_SaveFileDialog1.Filter = "Fichier PDF|*.pdf"
            If m_SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                strName = System.IO.Path.GetDirectoryName(m_SaveFileDialog1.FileName) & "/" & System.IO.Path.GetFileNameWithoutExtension(m_SaveFileDialog1.FileName)
                'Génération du PDF
                CSDebug.dispInfo("frmQuestionnaire.Generate : Step 1")
                Dim MonEtat As crQuestionnaire
                Dim MyDataSet As DataSet1
                MyDataSet = m_Questionnaire.GenerateDataSet()
                CSDebug.dispInfo("frmQuestionnaire.Generate : Step 2")
                MonEtat = New crQuestionnaire
                MonEtat.SetDataSource(MyDataSet)
                MonEtat.SetParameterValue("Organisme", m_Questionnaire.getAgent().RaisonSociale)
                MonEtat.SetParameterValue("NomAgent", m_Questionnaire.getAgent().Nom)
                CSDebug.dispInfo("frmQuestionnaire.Generate : Step 3")
                Try
                    Dim CrExportOptions As CrystalDecisions.Shared.ExportOptions
                    Dim CrDiskFileDestinationOptions As New CrystalDecisions.Shared.DiskFileDestinationOptions
                    Dim CrFormatTypeOptions As New CrystalDecisions.Shared.PdfRtfWordFormatOptions
                    CrDiskFileDestinationOptions.DiskFileName = strName & ".pdf"
                    CrExportOptions = MonEtat.ExportOptions
                    With CrExportOptions
                        .ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
                        .ExportFormatType = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat
                        .DestinationOptions = CrDiskFileDestinationOptions
                        .FormatOptions = CrFormatTypeOptions
                    End With
                    MonEtat.Export()
                    CSDebug.dispInfo("frmQuestionnaire.Generate : Step 4")
                    CSFile.open(strName & ".pdf")
                Catch ex As Exception
                    CSDebug.dispError("Generate : " & ex.Message)
                End Try
                'myDataset.Clear()
                CSDebug.dispInfo("frmQuestionnaire.Generate : Step 5")
                MonEtat.Close()
                MyDataSet.Dispose()

                'Génération du fichier CSV
                Dim strCSV As String
                CSDebug.dispInfo("frmQuestionnaire.Generate : Step 5")
                strCSV = m_Questionnaire.ToCSV()
                'CSDebug.dispInfo("frmQuestionnaire.Generate : Step 5" & strCSV)
                System.IO.File.WriteAllText(strName & ".csv", strCSV)
            End If

            bReturn = True
        Catch ex As Exception
            CSDebug.dispInfo("frmQuestionnaire.Generate ERR" & ex.Message)
            bReturn = False
        End Try
        Return bReturn
    End Function

    'Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
    '    PctAssocieChange()
    'End Sub

    'Private Sub PctAssocieChange()
    '    Dim oQuestion As Question
    '    Dim oChoix As Choix
    '    oQuestion = m_bsQuestion.Current

    '    'récupération du choix sélectionné
    '    If (CheckedListBox1.SelectedItem IsNot Nothing) Then
    '        oChoix = oQuestion.ListOfChoix(CheckedListBox1.SelectedIndex)
    '        If oChoix.EstSelectionne Then
    '            oChoix.pctAssocie = TrackBar1.Value
    '            CheckedListBox1.SelectedItem = oChoix.getLibelle()
    '            CheckedListBox1.Items(CheckedListBox1.SelectedIndex) = oChoix.getLibelle()
    '        End If
    '    End If
    'End Sub

    Private Sub btn_help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_help.Click
        frmAboutBox.ShowDialog()

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub rbOuiGroup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbOuiGroup.CheckedChanged

    End Sub

    Private Sub rbNonGroup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNonGroup.CheckedChanged

    End Sub

    ''' <summary>
    ''' Vérification du caractère obligatoire de la question
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function checkQuestionObligatoire() As Boolean

        Dim bReturn As Boolean = True
        If TypeOf m_oElement Is Question Then
            Dim oQuestion As Question
            oQuestion = m_oElement
            bReturn = oQuestion.isOk()
        End If
        If bReturn Then
            ToolStripStatusLabel1.Text = ""
        Else
            ToolStripStatusLabel1.Text = "Vous devez indiquer une réponse valide"
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
        End If
        Return bReturn
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmAboutBox.ShowDialog()
    End Sub
End Class
