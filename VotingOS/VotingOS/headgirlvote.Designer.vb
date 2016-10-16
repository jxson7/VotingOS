<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class headgirlvote
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(headgirlvote))
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim Why_would_you_like_to_be_head_girl_Label As System.Windows.Forms.Label
        Dim What_changes_would_you_make_Label As System.Windows.Forms.Label
        Dim Number_of_GCSEsLabel As System.Windows.Forms.Label
        Dim Previously_Part_of_School_House_CouncilLabel As System.Windows.Forms.Label
        Dim Personal_SkillsLabel As System.Windows.Forms.Label
        Dim Profile_ImageLabel As System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CandidatesHeadGirlDataSet = New VotingOS.CandidatesHeadGirlDataSet()
        Me.CandidatesHeadGirlBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CandidatesHeadGirlTableAdapter = New VotingOS.CandidatesHeadGirlDataSetTableAdapters.CandidatesHeadGirlTableAdapter()
        Me.TableAdapterManager = New VotingOS.CandidatesHeadGirlDataSetTableAdapters.TableAdapterManager()
        Me.CandidatesHeadGirlBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CandidatesHeadGirlBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FirstNameLabel1 = New System.Windows.Forms.Label()
        Me.LastNameLabel1 = New System.Windows.Forms.Label()
        Me.Why_would_you_like_to_be_head_girl_Label1 = New System.Windows.Forms.Label()
        Me.What_changes_would_you_make_Label1 = New System.Windows.Forms.Label()
        Me.Number_of_GCSEsLabel1 = New System.Windows.Forms.Label()
        Me.Previously_Part_of_School_House_CouncilLabel1 = New System.Windows.Forms.Label()
        Me.Personal_SkillsLabel1 = New System.Windows.Forms.Label()
        Me.Profile_ImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        Why_would_you_like_to_be_head_girl_Label = New System.Windows.Forms.Label()
        What_changes_would_you_make_Label = New System.Windows.Forms.Label()
        Number_of_GCSEsLabel = New System.Windows.Forms.Label()
        Previously_Part_of_School_House_CouncilLabel = New System.Windows.Forms.Label()
        Personal_SkillsLabel = New System.Windows.Forms.Label()
        Profile_ImageLabel = New System.Windows.Forms.Label()
        CType(Me.CandidatesHeadGirlDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CandidatesHeadGirlBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CandidatesHeadGirlBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CandidatesHeadGirlBindingNavigator.SuspendLayout()
        CType(Me.Profile_ImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(35, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Vote For Your Head Girl"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(65, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 38)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "VotingOS"
        '
        'CandidatesHeadGirlDataSet
        '
        Me.CandidatesHeadGirlDataSet.DataSetName = "CandidatesHeadGirlDataSet"
        Me.CandidatesHeadGirlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CandidatesHeadGirlBindingSource
        '
        Me.CandidatesHeadGirlBindingSource.DataMember = "CandidatesHeadGirl"
        Me.CandidatesHeadGirlBindingSource.DataSource = Me.CandidatesHeadGirlDataSet
        '
        'CandidatesHeadGirlTableAdapter
        '
        Me.CandidatesHeadGirlTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CandidatesHeadGirlTableAdapter = Me.CandidatesHeadGirlTableAdapter
        Me.TableAdapterManager.UpdateOrder = VotingOS.CandidatesHeadGirlDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CandidatesHeadGirlBindingNavigator
        '
        Me.CandidatesHeadGirlBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CandidatesHeadGirlBindingNavigator.BindingSource = Me.CandidatesHeadGirlBindingSource
        Me.CandidatesHeadGirlBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CandidatesHeadGirlBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CandidatesHeadGirlBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CandidatesHeadGirlBindingNavigatorSaveItem})
        Me.CandidatesHeadGirlBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CandidatesHeadGirlBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CandidatesHeadGirlBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CandidatesHeadGirlBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CandidatesHeadGirlBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CandidatesHeadGirlBindingNavigator.Name = "CandidatesHeadGirlBindingNavigator"
        Me.CandidatesHeadGirlBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CandidatesHeadGirlBindingNavigator.Size = New System.Drawing.Size(858, 25)
        Me.CandidatesHeadGirlBindingNavigator.TabIndex = 6
        Me.CandidatesHeadGirlBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Enabled = False
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Enabled = False
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'CandidatesHeadGirlBindingNavigatorSaveItem
        '
        Me.CandidatesHeadGirlBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CandidatesHeadGirlBindingNavigatorSaveItem.Enabled = False
        Me.CandidatesHeadGirlBindingNavigatorSaveItem.Image = CType(resources.GetObject("CandidatesHeadGirlBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CandidatesHeadGirlBindingNavigatorSaveItem.Name = "CandidatesHeadGirlBindingNavigatorSaveItem"
        Me.CandidatesHeadGirlBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CandidatesHeadGirlBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstNameLabel.ForeColor = System.Drawing.Color.White
        FirstNameLabel.Location = New System.Drawing.Point(72, 165)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(76, 16)
        FirstNameLabel.TabIndex = 6
        FirstNameLabel.Text = "First Name:"
        '
        'FirstNameLabel1
        '
        Me.FirstNameLabel1.BackColor = System.Drawing.Color.White
        Me.FirstNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "FirstName", True))
        Me.FirstNameLabel1.Location = New System.Drawing.Point(159, 165)
        Me.FirstNameLabel1.Name = "FirstNameLabel1"
        Me.FirstNameLabel1.Size = New System.Drawing.Size(141, 23)
        Me.FirstNameLabel1.TabIndex = 7
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastNameLabel.ForeColor = System.Drawing.Color.White
        LastNameLabel.Location = New System.Drawing.Point(71, 199)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(76, 16)
        LastNameLabel.TabIndex = 7
        LastNameLabel.Text = "Last Name:"
        '
        'LastNameLabel1
        '
        Me.LastNameLabel1.BackColor = System.Drawing.Color.White
        Me.LastNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "LastName", True))
        Me.LastNameLabel1.Location = New System.Drawing.Point(159, 199)
        Me.LastNameLabel1.Name = "LastNameLabel1"
        Me.LastNameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.LastNameLabel1.TabIndex = 8
        '
        'Why_would_you_like_to_be_head_girl_Label
        '
        Why_would_you_like_to_be_head_girl_Label.AutoSize = True
        Why_would_you_like_to_be_head_girl_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Why_would_you_like_to_be_head_girl_Label.ForeColor = System.Drawing.Color.White
        Why_would_you_like_to_be_head_girl_Label.Location = New System.Drawing.Point(10, 249)
        Why_would_you_like_to_be_head_girl_Label.Name = "Why_would_you_like_to_be_head_girl_Label"
        Why_would_you_like_to_be_head_girl_Label.Size = New System.Drawing.Size(220, 16)
        Why_would_you_like_to_be_head_girl_Label.TabIndex = 8
        Why_would_you_like_to_be_head_girl_Label.Text = "Why would you like to be head girl?:"
        '
        'Why_would_you_like_to_be_head_girl_Label1
        '
        Me.Why_would_you_like_to_be_head_girl_Label1.BackColor = System.Drawing.Color.White
        Me.Why_would_you_like_to_be_head_girl_Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "Why would you like to be head girl?", True))
        Me.Why_would_you_like_to_be_head_girl_Label1.Location = New System.Drawing.Point(236, 249)
        Me.Why_would_you_like_to_be_head_girl_Label1.Name = "Why_would_you_like_to_be_head_girl_Label1"
        Me.Why_would_you_like_to_be_head_girl_Label1.Size = New System.Drawing.Size(544, 56)
        Me.Why_would_you_like_to_be_head_girl_Label1.TabIndex = 9
        '
        'What_changes_would_you_make_Label
        '
        What_changes_would_you_make_Label.AutoSize = True
        What_changes_would_you_make_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        What_changes_would_you_make_Label.ForeColor = System.Drawing.Color.White
        What_changes_would_you_make_Label.Location = New System.Drawing.Point(22, 321)
        What_changes_would_you_make_Label.Name = "What_changes_would_you_make_Label"
        What_changes_would_you_make_Label.Size = New System.Drawing.Size(204, 16)
        What_changes_would_you_make_Label.TabIndex = 9
        What_changes_would_you_make_Label.Text = "What changes would you make?:"
        '
        'What_changes_would_you_make_Label1
        '
        Me.What_changes_would_you_make_Label1.BackColor = System.Drawing.Color.White
        Me.What_changes_would_you_make_Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "What changes would you make?", True))
        Me.What_changes_would_you_make_Label1.Location = New System.Drawing.Point(236, 323)
        Me.What_changes_would_you_make_Label1.Name = "What_changes_would_you_make_Label1"
        Me.What_changes_would_you_make_Label1.Size = New System.Drawing.Size(544, 70)
        Me.What_changes_would_you_make_Label1.TabIndex = 10
        '
        'Number_of_GCSEsLabel
        '
        Number_of_GCSEsLabel.AutoSize = True
        Number_of_GCSEsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Number_of_GCSEsLabel.ForeColor = System.Drawing.Color.White
        Number_of_GCSEsLabel.Location = New System.Drawing.Point(316, 165)
        Number_of_GCSEsLabel.Name = "Number_of_GCSEsLabel"
        Number_of_GCSEsLabel.Size = New System.Drawing.Size(120, 16)
        Number_of_GCSEsLabel.TabIndex = 11
        Number_of_GCSEsLabel.Text = "Number of GCSEs:"
        '
        'Number_of_GCSEsLabel1
        '
        Me.Number_of_GCSEsLabel1.BackColor = System.Drawing.Color.White
        Me.Number_of_GCSEsLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "Number of GCSEs", True))
        Me.Number_of_GCSEsLabel1.Location = New System.Drawing.Point(453, 165)
        Me.Number_of_GCSEsLabel1.Name = "Number_of_GCSEsLabel1"
        Me.Number_of_GCSEsLabel1.Size = New System.Drawing.Size(144, 23)
        Me.Number_of_GCSEsLabel1.TabIndex = 12
        '
        'Previously_Part_of_School_House_CouncilLabel
        '
        Previously_Part_of_School_House_CouncilLabel.AutoSize = True
        Previously_Part_of_School_House_CouncilLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Previously_Part_of_School_House_CouncilLabel.ForeColor = System.Drawing.Color.White
        Previously_Part_of_School_House_CouncilLabel.Location = New System.Drawing.Point(306, 199)
        Previously_Part_of_School_House_CouncilLabel.Name = "Previously_Part_of_School_House_CouncilLabel"
        Previously_Part_of_School_House_CouncilLabel.Size = New System.Drawing.Size(251, 16)
        Previously_Part_of_School_House_CouncilLabel.TabIndex = 13
        Previously_Part_of_School_House_CouncilLabel.Text = "Previously Part of School/House Council:"
        '
        'Previously_Part_of_School_House_CouncilLabel1
        '
        Me.Previously_Part_of_School_House_CouncilLabel1.BackColor = System.Drawing.Color.White
        Me.Previously_Part_of_School_House_CouncilLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "Previously Part of School/House Council", True))
        Me.Previously_Part_of_School_House_CouncilLabel1.Location = New System.Drawing.Point(561, 199)
        Me.Previously_Part_of_School_House_CouncilLabel1.Name = "Previously_Part_of_School_House_CouncilLabel1"
        Me.Previously_Part_of_School_House_CouncilLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Previously_Part_of_School_House_CouncilLabel1.TabIndex = 14
        '
        'Personal_SkillsLabel
        '
        Personal_SkillsLabel.AutoSize = True
        Personal_SkillsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Personal_SkillsLabel.ForeColor = System.Drawing.Color.White
        Personal_SkillsLabel.Location = New System.Drawing.Point(110, 411)
        Personal_SkillsLabel.Name = "Personal_SkillsLabel"
        Personal_SkillsLabel.Size = New System.Drawing.Size(100, 16)
        Personal_SkillsLabel.TabIndex = 15
        Personal_SkillsLabel.Text = "Personal Skills:"
        '
        'Personal_SkillsLabel1
        '
        Me.Personal_SkillsLabel1.BackColor = System.Drawing.Color.White
        Me.Personal_SkillsLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "Personal Skills", True))
        Me.Personal_SkillsLabel1.Location = New System.Drawing.Point(236, 411)
        Me.Personal_SkillsLabel1.Name = "Personal_SkillsLabel1"
        Me.Personal_SkillsLabel1.Size = New System.Drawing.Size(544, 71)
        Me.Personal_SkillsLabel1.TabIndex = 16
        '
        'Profile_ImageLabel
        '
        Profile_ImageLabel.AutoSize = True
        Profile_ImageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Profile_ImageLabel.Location = New System.Drawing.Point(561, 45)
        Profile_ImageLabel.Name = "Profile_ImageLabel"
        Profile_ImageLabel.Size = New System.Drawing.Size(90, 16)
        Profile_ImageLabel.TabIndex = 17
        Profile_ImageLabel.Text = "Profile Image:"
        '
        'Profile_ImagePictureBox
        '
        Me.Profile_ImagePictureBox.BackColor = System.Drawing.Color.White
        Me.Profile_ImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.CandidatesHeadGirlBindingSource, "Profile Image", True))
        Me.Profile_ImagePictureBox.Location = New System.Drawing.Point(659, 45)
        Me.Profile_ImagePictureBox.Name = "Profile_ImagePictureBox"
        Me.Profile_ImagePictureBox.Size = New System.Drawing.Size(100, 143)
        Me.Profile_ImagePictureBox.TabIndex = 18
        Me.Profile_ImagePictureBox.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(34, 510)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 34)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Cast Final Votes"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(34, 470)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 34)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "View Head Boy Profiles"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'headgirlvote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(858, 563)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Profile_ImageLabel)
        Me.Controls.Add(Me.Profile_ImagePictureBox)
        Me.Controls.Add(Personal_SkillsLabel)
        Me.Controls.Add(Me.Personal_SkillsLabel1)
        Me.Controls.Add(Previously_Part_of_School_House_CouncilLabel)
        Me.Controls.Add(Me.Previously_Part_of_School_House_CouncilLabel1)
        Me.Controls.Add(Number_of_GCSEsLabel)
        Me.Controls.Add(Me.Number_of_GCSEsLabel1)
        Me.Controls.Add(What_changes_would_you_make_Label)
        Me.Controls.Add(Me.What_changes_would_you_make_Label1)
        Me.Controls.Add(Why_would_you_like_to_be_head_girl_Label)
        Me.Controls.Add(Me.Why_would_you_like_to_be_head_girl_Label1)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameLabel1)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameLabel1)
        Me.Controls.Add(Me.CandidatesHeadGirlBindingNavigator)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "headgirlvote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "headgirlvote"
        CType(Me.CandidatesHeadGirlDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CandidatesHeadGirlBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CandidatesHeadGirlBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CandidatesHeadGirlBindingNavigator.ResumeLayout(False)
        Me.CandidatesHeadGirlBindingNavigator.PerformLayout()
        CType(Me.Profile_ImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CandidatesHeadGirlDataSet As CandidatesHeadGirlDataSet
    Friend WithEvents CandidatesHeadGirlBindingSource As BindingSource
    Friend WithEvents CandidatesHeadGirlTableAdapter As CandidatesHeadGirlDataSetTableAdapters.CandidatesHeadGirlTableAdapter
    Friend WithEvents TableAdapterManager As CandidatesHeadGirlDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CandidatesHeadGirlBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CandidatesHeadGirlBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FirstNameLabel1 As Label
    Friend WithEvents LastNameLabel1 As Label
    Friend WithEvents Why_would_you_like_to_be_head_girl_Label1 As Label
    Friend WithEvents What_changes_would_you_make_Label1 As Label
    Friend WithEvents Number_of_GCSEsLabel1 As Label
    Friend WithEvents Previously_Part_of_School_House_CouncilLabel1 As Label
    Friend WithEvents Personal_SkillsLabel1 As Label
    Friend WithEvents Profile_ImagePictureBox As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
