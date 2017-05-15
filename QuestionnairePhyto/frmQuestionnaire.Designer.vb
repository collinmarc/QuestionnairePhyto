<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestionnaire
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuestionnaire))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Client")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Agent")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Identification", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Q sur les Locaux", 2, 2)
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Q sur les fluides")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Q sur les evacuations")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Environnement", 0, 1, New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pratique")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Alternatif")
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnInit = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlGroup = New System.Windows.Forms.Panel()
        Me.rbNonGroup = New System.Windows.Forms.RadioButton()
        Me.m_bsGroup = New System.Windows.Forms.BindingSource(Me.components)
        Me.rbOuiGroup = New System.Windows.Forms.RadioButton()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.pnlIdentification = New System.Windows.Forms.Panel()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.m_bsQIdent = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlQuestion = New System.Windows.Forms.Panel()
        Me.PnlQuestionOui = New System.Windows.Forms.Panel()
        Me.lblLibelleActif = New System.Windows.Forms.Label()
        Me.m_bsQuestion = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlAssocie = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.m_bsChoix = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbReponse = New System.Windows.Forms.TextBox()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.pnlPrecisez = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.rbNon = New System.Windows.Forms.RadioButton()
        Me.rbOui = New System.Windows.Forms.RadioButton()
        Me.LaCommentaire = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbCommentaire = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PnIdentAgent = New System.Windows.Forms.Panel()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnMoveToNextFirst = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.BtnMoveToFirst = New System.Windows.Forms.Button()
        Me.m_SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.m_OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_help = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlGroup.SuspendLayout()
        CType(Me.m_bsGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlIdentification.SuspendLayout()
        CType(Me.m_bsQIdent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlQuestion.SuspendLayout()
        Me.PnlQuestionOui.SuspendLayout()
        CType(Me.m_bsQuestion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAssocie.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.m_bsChoix, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPrecisez.SuspendLayout()
        Me.PnIdentAgent.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Book_angleHS.png")
        Me.ImageList1.Images.SetKeyName(1, "Book_openHS.png")
        Me.ImageList1.Images.SetKeyName(2, "1565_QuestionMarkBlue.png")
        Me.ImageList1.Images.SetKeyName(3, "1508_QuestionMarkRed.png")
        Me.ImageList1.Images.SetKeyName(4, "Button-Play-icon.png")
        Me.ImageList1.Images.SetKeyName(5, "Button-Rewind-icon.png")
        Me.ImageList1.Images.SetKeyName(6, "nextChapter.png")
        Me.ImageList1.Images.SetKeyName(7, "Previous.png")
        Me.ImageList1.Images.SetKeyName(8, "Save-icon.png")
        Me.ImageList1.Images.SetKeyName(9, "load-upload-icon.png")
        '
        'btnLoad
        '
        Me.btnLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLoad.BackgroundImage = Global.QuestionnairePhyto.My.Resources.Resources.Import
        Me.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLoad.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnLoad.FlatAppearance.BorderSize = 0
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad.ImageIndex = 5
        Me.btnLoad.Location = New System.Drawing.Point(509, 591)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(51, 41)
        Me.btnLoad.TabIndex = 9
        Me.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.btnLoad, "Lecture d'un questionnaire")
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackgroundImage = Global.QuestionnairePhyto.My.Resources.Resources.Export
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ImageIndex = 5
        Me.btnSave.Location = New System.Drawing.Point(655, 594)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 41)
        Me.btnSave.TabIndex = 8
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.btnSave, "Sauvegarde du questionnaire")
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackgroundImage = Global.QuestionnairePhyto.My.Resources.Resources.print_icon
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrint.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.ImageIndex = 5
        Me.btnPrint.Location = New System.Drawing.Point(829, 594)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(51, 41)
        Me.btnPrint.TabIndex = 7
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.btnPrint, "Génération du rapport")
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnInit
        '
        Me.btnInit.Location = New System.Drawing.Point(12, 413)
        Me.btnInit.Name = "btnInit"
        Me.btnInit.Size = New System.Drawing.Size(37, 29)
        Me.btnInit.TabIndex = 10
        Me.btnInit.Text = "Init"
        Me.btnInit.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(5, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnPrev)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnMoveToNextFirst)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnNext)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnMoveToFirst)
        Me.SplitContainer1.Size = New System.Drawing.Size(874, 589)
        Me.SplitContainer1.SplitterDistance = 290
        Me.SplitContainer1.TabIndex = 11
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Nœud1"
        TreeNode1.Text = "Client"
        TreeNode2.Name = "Nœud2"
        TreeNode2.Text = "Agent"
        TreeNode3.Name = "Nœud5"
        TreeNode3.Text = "Identification"
        TreeNode4.ImageIndex = 2
        TreeNode4.Name = ""
        TreeNode4.SelectedImageIndex = 2
        TreeNode4.Text = "Q sur les Locaux"
        TreeNode5.ImageIndex = 3
        TreeNode5.Name = "Nœud4"
        TreeNode5.Text = "Q sur les fluides"
        TreeNode6.ImageIndex = 2
        TreeNode6.Name = "Nœud6"
        TreeNode6.Text = "Q sur les evacuations"
        TreeNode7.ImageIndex = 0
        TreeNode7.Name = "Nœud0"
        TreeNode7.SelectedImageIndex = 1
        TreeNode7.Text = "Environnement"
        TreeNode8.Name = "Nœud1"
        TreeNode8.Text = "Pratique"
        TreeNode9.Name = "Nœud2"
        TreeNode9.Text = "Alternatif"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode7, TreeNode8, TreeNode9})
        Me.TreeView1.SelectedImageIndex = 0
        Me.TreeView1.Size = New System.Drawing.Size(290, 589)
        Me.TreeView1.TabIndex = 2
        '
        'btnPrev
        '
        Me.btnPrev.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrev.BackgroundImage = Global.QuestionnairePhyto.My.Resources.Resources.Previous
        Me.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrev.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnPrev.FlatAppearance.BorderSize = 0
        Me.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrev.ImageIndex = 5
        Me.btnPrev.Location = New System.Drawing.Point(427, 551)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(30, 31)
        Me.btnPrev.TabIndex = 10
        Me.btnPrev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.pnlGroup)
        Me.Panel1.Controls.Add(Me.pnlIdentification)
        Me.Panel1.Controls.Add(Me.pnlQuestion)
        Me.Panel1.Controls.Add(Me.PnIdentAgent)
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(575, 545)
        Me.Panel1.TabIndex = 14
        '
        'pnlGroup
        '
        Me.pnlGroup.Controls.Add(Me.rbNonGroup)
        Me.pnlGroup.Controls.Add(Me.rbOuiGroup)
        Me.pnlGroup.Controls.Add(Me.Label17)
        Me.pnlGroup.Location = New System.Drawing.Point(354, 436)
        Me.pnlGroup.Name = "pnlGroup"
        Me.pnlGroup.Size = New System.Drawing.Size(204, 72)
        Me.pnlGroup.TabIndex = 14
        Me.pnlGroup.Visible = False
        '
        'rbNonGroup
        '
        Me.rbNonGroup.AutoSize = True
        Me.rbNonGroup.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.m_bsGroup, "isInactif", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.rbNonGroup.Location = New System.Drawing.Point(80, 39)
        Me.rbNonGroup.Name = "rbNonGroup"
        Me.rbNonGroup.Size = New System.Drawing.Size(45, 17)
        Me.rbNonGroup.TabIndex = 11
        Me.rbNonGroup.TabStop = True
        Me.rbNonGroup.Text = "Non"
        Me.rbNonGroup.UseVisualStyleBackColor = True
        '
        'm_bsGroup
        '
        Me.m_bsGroup.DataSource = GetType(QuestionnairePhyto.Groupe)
        '
        'rbOuiGroup
        '
        Me.rbOuiGroup.AutoSize = True
        Me.rbOuiGroup.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.m_bsGroup, "isActif", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.rbOuiGroup.Location = New System.Drawing.Point(33, 39)
        Me.rbOuiGroup.Name = "rbOuiGroup"
        Me.rbOuiGroup.Size = New System.Drawing.Size(41, 17)
        Me.rbOuiGroup.TabIndex = 10
        Me.rbOuiGroup.TabStop = True
        Me.rbOuiGroup.Text = "Oui"
        Me.rbOuiGroup.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsGroup, "Libelle", True))
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label17.Location = New System.Drawing.Point(29, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(163, 16)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Libellé long du groupe"
        '
        'pnlIdentification
        '
        Me.pnlIdentification.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlIdentification.Controls.Add(Me.TextBox7)
        Me.pnlIdentification.Controls.Add(Me.TextBox6)
        Me.pnlIdentification.Controls.Add(Me.TextBox5)
        Me.pnlIdentification.Controls.Add(Me.TextBox4)
        Me.pnlIdentification.Controls.Add(Me.TextBox3)
        Me.pnlIdentification.Controls.Add(Me.TextBox2)
        Me.pnlIdentification.Controls.Add(Me.TextBox1)
        Me.pnlIdentification.Controls.Add(Me.Label8)
        Me.pnlIdentification.Controls.Add(Me.Label7)
        Me.pnlIdentification.Controls.Add(Me.Label3)
        Me.pnlIdentification.Controls.Add(Me.Label6)
        Me.pnlIdentification.Controls.Add(Me.Label5)
        Me.pnlIdentification.Controls.Add(Me.Label2)
        Me.pnlIdentification.Controls.Add(Me.Label4)
        Me.pnlIdentification.Controls.Add(Me.Label1)
        Me.pnlIdentification.Location = New System.Drawing.Point(30, 512)
        Me.pnlIdentification.Name = "pnlIdentification"
        Me.pnlIdentification.Size = New System.Drawing.Size(240, 30)
        Me.pnlIdentification.TabIndex = 11
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsQIdent, "Mail", True))
        Me.TextBox7.Location = New System.Drawing.Point(127, 219)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(235, 20)
        Me.TextBox7.TabIndex = 19
        '
        'm_bsQIdent
        '
        Me.m_bsQIdent.DataSource = GetType(QuestionnairePhyto.QIdent)
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsQIdent, "Tel", True))
        Me.TextBox6.Location = New System.Drawing.Point(127, 193)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(0, 20)
        Me.TextBox6.TabIndex = 18
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsQIdent, "Commune", True))
        Me.TextBox5.Location = New System.Drawing.Point(127, 166)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(128, 20)
        Me.TextBox5.TabIndex = 17
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsQIdent, "CodePostal", True))
        Me.TextBox4.Location = New System.Drawing.Point(127, 140)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(0, 20)
        Me.TextBox4.TabIndex = 16
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsQIdent, "Adresse", True))
        Me.TextBox3.Location = New System.Drawing.Point(127, 90)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(128, 43)
        Me.TextBox3.TabIndex = 15
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsQIdent, "Nom", True))
        Me.TextBox2.Location = New System.Drawing.Point(127, 60)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(128, 20)
        Me.TextBox2.TabIndex = 14
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsQIdent, "RaisonSociale", True))
        Me.TextBox1.Location = New System.Drawing.Point(127, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 20)
        Me.TextBox1.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Location = New System.Drawing.Point(17, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Mail :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Location = New System.Drawing.Point(17, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Tel :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(17, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Commune :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Location = New System.Drawing.Point(17, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Code postal :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(17, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Adresse :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(17, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nom et prénom :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(17, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Raison Sociale :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsQIdent, "Libelle", True))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(27, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Identification du client"
        '
        'pnlQuestion
        '
        Me.pnlQuestion.Controls.Add(Me.PnlQuestionOui)
        Me.pnlQuestion.Controls.Add(Me.rbNon)
        Me.pnlQuestion.Controls.Add(Me.rbOui)
        Me.pnlQuestion.Controls.Add(Me.LaCommentaire)
        Me.pnlQuestion.Controls.Add(Me.Label11)
        Me.pnlQuestion.Controls.Add(Me.tbCommentaire)
        Me.pnlQuestion.Controls.Add(Me.Label12)
        Me.pnlQuestion.Location = New System.Drawing.Point(3, 9)
        Me.pnlQuestion.Name = "pnlQuestion"
        Me.pnlQuestion.Size = New System.Drawing.Size(402, 387)
        Me.pnlQuestion.TabIndex = 12
        '
        'PnlQuestionOui
        '
        Me.PnlQuestionOui.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlQuestionOui.Controls.Add(Me.lblLibelleActif)
        Me.PnlQuestionOui.Controls.Add(Me.pnlAssocie)
        Me.PnlQuestionOui.Controls.Add(Me.tbReponse)
        Me.PnlQuestionOui.Controls.Add(Me.CheckedListBox1)
        Me.PnlQuestionOui.Controls.Add(Me.pnlPrecisez)
        Me.PnlQuestionOui.Location = New System.Drawing.Point(32, 63)
        Me.PnlQuestionOui.Name = "PnlQuestionOui"
        Me.PnlQuestionOui.Size = New System.Drawing.Size(333, 236)
        Me.PnlQuestionOui.TabIndex = 12
        '
        'lblLibelleActif
        '
        Me.lblLibelleActif.AutoSize = True
        Me.lblLibelleActif.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsQuestion, "LibelleActif", True))
        Me.lblLibelleActif.Location = New System.Drawing.Point(-3, 0)
        Me.lblLibelleActif.Name = "lblLibelleActif"
        Me.lblLibelleActif.Size = New System.Drawing.Size(58, 13)
        Me.lblLibelleActif.TabIndex = 15
        Me.lblLibelleActif.Text = "LibelleActif"
        '
        'm_bsQuestion
        '
        Me.m_bsQuestion.DataSource = GetType(QuestionnairePhyto.Question)
        '
        'pnlAssocie
        '
        Me.pnlAssocie.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAssocie.Controls.Add(Me.Label10)
        Me.pnlAssocie.Controls.Add(Me.Label21)
        Me.pnlAssocie.Controls.Add(Me.TrackBar1)
        Me.pnlAssocie.Location = New System.Drawing.Point(6, 165)
        Me.pnlAssocie.Name = "pnlAssocie"
        Me.pnlAssocie.Size = New System.Drawing.Size(311, 59)
        Me.pnlAssocie.TabIndex = 14
        Me.pnlAssocie.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label10.Location = New System.Drawing.Point(125, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(196, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "0            25          50            75         100"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label21.Location = New System.Drawing.Point(16, 14)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(57, 13)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "Quel % ?"
        '
        'TrackBar1
        '
        Me.TrackBar1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.m_bsChoix, "pctAssocie2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TrackBar1.LargeChange = 1
        Me.TrackBar1.Location = New System.Drawing.Point(116, 3)
        Me.TrackBar1.Maximum = 4
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(207, 45)
        Me.TrackBar1.TabIndex = 12
        Me.TrackBar1.TickFrequency = 25
        '
        'm_bsChoix
        '
        Me.m_bsChoix.DataMember = "ListOfChoix"
        Me.m_bsChoix.DataSource = Me.m_bsQuestion
        '
        'tbReponse
        '
        Me.tbReponse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbReponse.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsQuestion, "Reponse", True))
        Me.tbReponse.Location = New System.Drawing.Point(3, 19)
        Me.tbReponse.Multiline = True
        Me.tbReponse.Name = "tbReponse"
        Me.tbReponse.Size = New System.Drawing.Size(314, 29)
        Me.tbReponse.TabIndex = 11
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.DataSource = Me.m_bsChoix
        Me.CheckedListBox1.DisplayMember = "LibelleComplet"
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(2, 19)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(315, 94)
        Me.CheckedListBox1.TabIndex = 10
        '
        'pnlPrecisez
        '
        Me.pnlPrecisez.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPrecisez.Controls.Add(Me.Label9)
        Me.pnlPrecisez.Controls.Add(Me.TextBox8)
        Me.pnlPrecisez.Location = New System.Drawing.Point(6, 123)
        Me.pnlPrecisez.Name = "pnlPrecisez"
        Me.pnlPrecisez.Size = New System.Drawing.Size(311, 36)
        Me.pnlPrecisez.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label9.Location = New System.Drawing.Point(12, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Précisez:"
        '
        'TextBox8
        '
        Me.TextBox8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsQuestion, "Precision", True))
        Me.TextBox8.Location = New System.Drawing.Point(77, 8)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(231, 20)
        Me.TextBox8.TabIndex = 7
        '
        'rbNon
        '
        Me.rbNon.AutoSize = True
        Me.rbNon.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.m_bsQuestion, "isInactif", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.rbNon.Location = New System.Drawing.Point(80, 39)
        Me.rbNon.Name = "rbNon"
        Me.rbNon.Size = New System.Drawing.Size(45, 17)
        Me.rbNon.TabIndex = 11
        Me.rbNon.TabStop = True
        Me.rbNon.Text = "Non"
        Me.rbNon.UseVisualStyleBackColor = True
        '
        'rbOui
        '
        Me.rbOui.AutoSize = True
        Me.rbOui.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.m_bsQuestion, "isActif", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.rbOui.Location = New System.Drawing.Point(33, 39)
        Me.rbOui.Name = "rbOui"
        Me.rbOui.Size = New System.Drawing.Size(41, 17)
        Me.rbOui.TabIndex = 10
        Me.rbOui.TabStop = True
        Me.rbOui.Text = "Oui"
        Me.rbOui.UseVisualStyleBackColor = True
        '
        'LaCommentaire
        '
        Me.LaCommentaire.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LaCommentaire.AutoSize = True
        Me.LaCommentaire.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaCommentaire.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LaCommentaire.Location = New System.Drawing.Point(35, 302)
        Me.LaCommentaire.Name = "LaCommentaire"
        Me.LaCommentaire.Size = New System.Drawing.Size(204, 16)
        Me.LaCommentaire.TabIndex = 3
        Me.LaCommentaire.Text = "Commentaire sur la question"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsQuestion, "Libelle", True))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label11.Location = New System.Drawing.Point(30, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(169, 16)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Libellé de la question ?"
        '
        'tbCommentaire
        '
        Me.tbCommentaire.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbCommentaire.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsQuestion, "Commentaire", True))
        Me.tbCommentaire.Location = New System.Drawing.Point(33, 321)
        Me.tbCommentaire.Multiline = True
        Me.tbCommentaire.Name = "tbCommentaire"
        Me.tbCommentaire.Size = New System.Drawing.Size(344, 63)
        Me.tbCommentaire.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsQuestion, "LibelleChapitre", True))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label12.Location = New System.Drawing.Point(30, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(142, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Libellé du Chapître "
        '
        'PnIdentAgent
        '
        Me.PnIdentAgent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnIdentAgent.Controls.Add(Me.TextBox15)
        Me.PnIdentAgent.Controls.Add(Me.TextBox16)
        Me.PnIdentAgent.Controls.Add(Me.Label18)
        Me.PnIdentAgent.Controls.Add(Me.Label19)
        Me.PnIdentAgent.Controls.Add(Me.Label20)
        Me.PnIdentAgent.Location = New System.Drawing.Point(278, 214)
        Me.PnIdentAgent.Name = "PnIdentAgent"
        Me.PnIdentAgent.Size = New System.Drawing.Size(280, 165)
        Me.PnIdentAgent.TabIndex = 13
        Me.PnIdentAgent.Visible = False
        '
        'TextBox15
        '
        Me.TextBox15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsQIdent, "Nom", True))
        Me.TextBox15.Location = New System.Drawing.Point(127, 60)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(156, 20)
        Me.TextBox15.TabIndex = 14
        '
        'TextBox16
        '
        Me.TextBox16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsQIdent, "RaisonSociale", True))
        Me.TextBox16.Location = New System.Drawing.Point(127, 34)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(156, 20)
        Me.TextBox16.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label18.Location = New System.Drawing.Point(17, 64)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(94, 13)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Nom - Prénom :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label19.Location = New System.Drawing.Point(17, 37)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(74, 13)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Organisme :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.m_bsQIdent, "Libelle", True))
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label20.Location = New System.Drawing.Point(29, 5)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(169, 16)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Identification de l'agent"
        '
        'btnMoveToNextFirst
        '
        Me.btnMoveToNextFirst.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMoveToNextFirst.BackgroundImage = Global.QuestionnairePhyto.My.Resources.Resources.nextChapter
        Me.btnMoveToNextFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMoveToNextFirst.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnMoveToNextFirst.FlatAppearance.BorderSize = 0
        Me.btnMoveToNextFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoveToNextFirst.ImageIndex = 5
        Me.btnMoveToNextFirst.Location = New System.Drawing.Point(547, 551)
        Me.btnMoveToNextFirst.Name = "btnMoveToNextFirst"
        Me.btnMoveToNextFirst.Size = New System.Drawing.Size(30, 31)
        Me.btnMoveToNextFirst.TabIndex = 8
        Me.btnMoveToNextFirst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnMoveToNextFirst.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext.BackgroundImage = Global.QuestionnairePhyto.My.Resources.Resources.Button_Play_icon
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.ImageIndex = 5
        Me.btnNext.Location = New System.Drawing.Point(484, 551)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(30, 31)
        Me.btnNext.TabIndex = 9
        Me.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'BtnMoveToFirst
        '
        Me.BtnMoveToFirst.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMoveToFirst.BackgroundImage = Global.QuestionnairePhyto.My.Resources.Resources.Button_Rewind_icon
        Me.BtnMoveToFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMoveToFirst.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.BtnMoveToFirst.FlatAppearance.BorderSize = 0
        Me.BtnMoveToFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMoveToFirst.ImageIndex = 5
        Me.BtnMoveToFirst.Location = New System.Drawing.Point(370, 551)
        Me.BtnMoveToFirst.Name = "BtnMoveToFirst"
        Me.BtnMoveToFirst.Size = New System.Drawing.Size(30, 31)
        Me.BtnMoveToFirst.TabIndex = 7
        Me.BtnMoveToFirst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnMoveToFirst.UseVisualStyleBackColor = True
        '
        'm_SaveFileDialog1
        '
        Me.m_SaveFileDialog1.Filter = "Fichier Xml|.xml"
        Me.m_SaveFileDialog1.InitialDirectory = "./"
        Me.m_SaveFileDialog1.Title = "Sauvegarde des réponses"
        '
        'm_OpenFileDialog1
        '
        Me.m_OpenFileDialog1.Filter = "Fichier XML|*.xml"
        '
        'btn_help
        '
        Me.btn_help.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_help.BackgroundImage = Global.QuestionnairePhyto.My.Resources.Resources.help
        Me.btn_help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_help.FlatAppearance.BorderSize = 0
        Me.btn_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_help.Location = New System.Drawing.Point(5, 598)
        Me.btn_help.Name = "btn_help"
        Me.btn_help.Size = New System.Drawing.Size(32, 32)
        Me.btn_help.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.btn_help, "A propos de ...")
        Me.btn_help.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 635)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(883, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Red
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(868, 17)
        Me.ToolStripStatusLabel1.Spring = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.QuestionnairePhyto.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(43, 594)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'frmQuestionnaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 657)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btn_help)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.btnInit)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnPrint)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQuestionnaire"
        Me.Text = "Questionnaire Phyto"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pnlGroup.ResumeLayout(False)
        Me.pnlGroup.PerformLayout()
        CType(Me.m_bsGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlIdentification.ResumeLayout(False)
        Me.pnlIdentification.PerformLayout()
        CType(Me.m_bsQIdent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlQuestion.ResumeLayout(False)
        Me.pnlQuestion.PerformLayout()
        Me.PnlQuestionOui.ResumeLayout(False)
        Me.PnlQuestionOui.PerformLayout()
        CType(Me.m_bsQuestion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAssocie.ResumeLayout(False)
        Me.pnlAssocie.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.m_bsChoix, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPrecisez.ResumeLayout(False)
        Me.pnlPrecisez.PerformLayout()
        Me.PnIdentAgent.ResumeLayout(False)
        Me.PnIdentAgent.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents m_bsQIdent As System.Windows.Forms.BindingSource
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnInit As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents pnlIdentification As System.Windows.Forms.Panel
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnMoveToNextFirst As System.Windows.Forms.Button
    Friend WithEvents BtnMoveToFirst As System.Windows.Forms.Button
    Friend WithEvents pnlQuestion As System.Windows.Forms.Panel
    Friend WithEvents LaCommentaire As System.Windows.Forms.Label
    Friend WithEvents tbCommentaire As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents m_bsQuestion As System.Windows.Forms.BindingSource
    Friend WithEvents m_bsChoix As System.Windows.Forms.BindingSource
    Friend WithEvents pnlPrecisez As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents m_SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PnIdentAgent As System.Windows.Forms.Panel
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents rbNon As System.Windows.Forms.RadioButton
    Friend WithEvents rbOui As System.Windows.Forms.RadioButton
    Friend WithEvents PnlQuestionOui As System.Windows.Forms.Panel
    Friend WithEvents tbReponse As System.Windows.Forms.TextBox
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents m_OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents pnlAssocie As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btn_help As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblLibelleActif As System.Windows.Forms.Label
    Friend WithEvents m_bsGroup As System.Windows.Forms.BindingSource
    Friend WithEvents pnlGroup As System.Windows.Forms.Panel
    Friend WithEvents rbNonGroup As System.Windows.Forms.RadioButton
    Friend WithEvents rbOuiGroup As System.Windows.Forms.RadioButton
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
