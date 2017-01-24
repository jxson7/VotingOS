<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HeadGirlConfig
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
        Dim ImageLabel As System.Windows.Forms.Label
        Dim Personal_SkillsLabel As System.Windows.Forms.Label
        Dim Previously_part_of_school_house_council_Label As System.Windows.Forms.Label
        Dim Number_of_GCSELabel As System.Windows.Forms.Label
        Dim Why_would_you_like_to_be_head_boy_girl_Label As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HeadGirlConfig))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DatabaseDataSet = New VotingOS.DatabaseDataSet()
        Me.CandidatesHeadGirlBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CandidatesHeadGirlTableAdapter = New VotingOS.DatabaseDataSetTableAdapters.CandidatesHeadGirlTableAdapter()
        Me.TableAdapterManager = New VotingOS.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.CandidatesHeadGirlBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CandidatesHeadGirlBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Previously_Part_of_School_House_CouncilCheckBox = New System.Windows.Forms.CheckBox()
        Me.Number_of_GCSEsNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Why_would_you_like_to_be_head_girl_TextBox = New System.Windows.Forms.TextBox()
        Me.Personal_SkillsTextBox = New System.Windows.Forms.TextBox()
        Me.ImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        ImageLabel = New System.Windows.Forms.Label()
        Personal_SkillsLabel = New System.Windows.Forms.Label()
        Previously_part_of_school_house_council_Label = New System.Windows.Forms.Label()
        Number_of_GCSELabel = New System.Windows.Forms.Label()
        Why_would_you_like_to_be_head_boy_girl_Label = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CandidatesHeadGirlBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CandidatesHeadGirlBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CandidatesHeadGirlBindingNavigator.SuspendLayout()
        CType(Me.Number_of_GCSEsNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageLabel
        '
        ImageLabel.AutoSize = True
        ImageLabel.BackColor = System.Drawing.Color.Transparent
        ImageLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ImageLabel.ForeColor = System.Drawing.Color.White
        ImageLabel.Location = New System.Drawing.Point(123, 166)
        ImageLabel.Name = "ImageLabel"
        ImageLabel.Size = New System.Drawing.Size(98, 17)
        ImageLabel.TabIndex = 23
        ImageLabel.Text = "Profile Image:"
        '
        'Personal_SkillsLabel
        '
        Personal_SkillsLabel.AutoSize = True
        Personal_SkillsLabel.BackColor = System.Drawing.Color.Transparent
        Personal_SkillsLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Personal_SkillsLabel.ForeColor = System.Drawing.Color.White
        Personal_SkillsLabel.Location = New System.Drawing.Point(347, 457)
        Personal_SkillsLabel.Name = "Personal_SkillsLabel"
        Personal_SkillsLabel.Size = New System.Drawing.Size(109, 17)
        Personal_SkillsLabel.TabIndex = 22
        Personal_SkillsLabel.Text = "Personal Skills:"
        '
        'Previously_part_of_school_house_council_Label
        '
        Previously_part_of_school_house_council_Label.AutoSize = True
        Previously_part_of_school_house_council_Label.BackColor = System.Drawing.Color.Transparent
        Previously_part_of_school_house_council_Label.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Previously_part_of_school_house_council_Label.ForeColor = System.Drawing.Color.White
        Previously_part_of_school_house_council_Label.Location = New System.Drawing.Point(424, 233)
        Previously_part_of_school_house_council_Label.Name = "Previously_part_of_school_house_council_Label"
        Previously_part_of_school_house_council_Label.Size = New System.Drawing.Size(239, 17)
        Previously_part_of_school_house_council_Label.TabIndex = 21
        Previously_part_of_school_house_council_Label.Text = "School/House Council Experience?"
        '
        'Number_of_GCSELabel
        '
        Number_of_GCSELabel.AutoSize = True
        Number_of_GCSELabel.BackColor = System.Drawing.Color.Transparent
        Number_of_GCSELabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Number_of_GCSELabel.ForeColor = System.Drawing.Color.White
        Number_of_GCSELabel.Location = New System.Drawing.Point(532, 265)
        Number_of_GCSELabel.Name = "Number_of_GCSELabel"
        Number_of_GCSELabel.Size = New System.Drawing.Size(128, 17)
        Number_of_GCSELabel.TabIndex = 20
        Number_of_GCSELabel.Text = "Number of GCSE:"
        '
        'Why_would_you_like_to_be_head_boy_girl_Label
        '
        Why_would_you_like_to_be_head_boy_girl_Label.AutoSize = True
        Why_would_you_like_to_be_head_boy_girl_Label.BackColor = System.Drawing.Color.Transparent
        Why_would_you_like_to_be_head_boy_girl_Label.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Why_would_you_like_to_be_head_boy_girl_Label.ForeColor = System.Drawing.Color.White
        Why_would_you_like_to_be_head_boy_girl_Label.Location = New System.Drawing.Point(216, 373)
        Why_would_you_like_to_be_head_boy_girl_Label.Name = "Why_would_you_like_to_be_head_boy_girl_Label"
        Why_would_you_like_to_be_head_boy_girl_Label.Size = New System.Drawing.Size(240, 17)
        Why_would_you_like_to_be_head_boy_girl_Label.TabIndex = 19
        Why_would_you_like_to_be_head_boy_girl_Label.Text = "Why would you like to be head girl?:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.BackColor = System.Drawing.Color.Transparent
        Last_NameLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.ForeColor = System.Drawing.Color.White
        Last_NameLabel.Location = New System.Drawing.Point(583, 198)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(84, 17)
        Last_NameLabel.TabIndex = 18
        Last_NameLabel.Text = "Last Name:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.BackColor = System.Drawing.Color.Transparent
        First_NameLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.ForeColor = System.Drawing.Color.White
        First_NameLabel.Location = New System.Drawing.Point(583, 163)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(85, 17)
        First_NameLabel.TabIndex = 17
        First_NameLabel.Text = "First Name:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.VotingOS.My.Resources.Resources.STARTUPPAGE2
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(237, 310)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CandidatesHeadGirlBindingSource
        '
        Me.CandidatesHeadGirlBindingSource.DataMember = "CandidatesHeadGirl"
        Me.CandidatesHeadGirlBindingSource.DataSource = Me.DatabaseDataSet
        '
        'CandidatesHeadGirlTableAdapter
        '
        Me.CandidatesHeadGirlTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.authorisedmembersTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CandidateHeadBoyTableAdapter = Nothing
        Me.TableAdapterManager.CandidatesHeadGirlTableAdapter = Me.CandidatesHeadGirlTableAdapter
        Me.TableAdapterManager.UpdateOrder = VotingOS.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        Me.TableAdapterManager.VotesTableAdapter = Nothing
        '
        'CandidatesHeadGirlBindingNavigator
        '
        Me.CandidatesHeadGirlBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CandidatesHeadGirlBindingNavigator.BindingSource = Me.CandidatesHeadGirlBindingSource
        Me.CandidatesHeadGirlBindingNavigator.CountItem = Nothing
        Me.CandidatesHeadGirlBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CandidatesHeadGirlBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.CandidatesHeadGirlBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CandidatesHeadGirlBindingNavigatorSaveItem})
        Me.CandidatesHeadGirlBindingNavigator.Location = New System.Drawing.Point(350, 137)
        Me.CandidatesHeadGirlBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CandidatesHeadGirlBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CandidatesHeadGirlBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CandidatesHeadGirlBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CandidatesHeadGirlBindingNavigator.Name = "CandidatesHeadGirlBindingNavigator"
        Me.CandidatesHeadGirlBindingNavigator.PositionItem = Nothing
        Me.CandidatesHeadGirlBindingNavigator.Size = New System.Drawing.Size(191, 25)
        Me.CandidatesHeadGirlBindingNavigator.TabIndex = 26
        Me.CandidatesHeadGirlBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CandidatesHeadGirlBindingNavigatorSaveItem
        '
        Me.CandidatesHeadGirlBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CandidatesHeadGirlBindingNavigatorSaveItem.Image = CType(resources.GetObject("CandidatesHeadGirlBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CandidatesHeadGirlBindingNavigatorSaveItem.Name = "CandidatesHeadGirlBindingNavigatorSaveItem"
        Me.CandidatesHeadGirlBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CandidatesHeadGirlBindingNavigatorSaveItem.Text = "Save Data"
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "First Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(686, 159)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.First_NameTextBox.TabIndex = 27
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "Last Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(686, 198)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Last_NameTextBox.TabIndex = 28
        '
        'Previously_Part_of_School_House_CouncilCheckBox
        '
        Me.Previously_Part_of_School_House_CouncilCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.Previously_Part_of_School_House_CouncilCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CandidatesHeadGirlBindingSource, "Previously Part of School/House Council", True))
        Me.Previously_Part_of_School_House_CouncilCheckBox.Location = New System.Drawing.Point(692, 233)
        Me.Previously_Part_of_School_House_CouncilCheckBox.Name = "Previously_Part_of_School_House_CouncilCheckBox"
        Me.Previously_Part_of_School_House_CouncilCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Previously_Part_of_School_House_CouncilCheckBox.TabIndex = 29
        Me.Previously_Part_of_School_House_CouncilCheckBox.UseVisualStyleBackColor = False
        '
        'Number_of_GCSEsNumericUpDown
        '
        Me.Number_of_GCSEsNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CandidatesHeadGirlBindingSource, "Number of GCSEs", True))
        Me.Number_of_GCSEsNumericUpDown.Location = New System.Drawing.Point(686, 262)
        Me.Number_of_GCSEsNumericUpDown.Name = "Number_of_GCSEsNumericUpDown"
        Me.Number_of_GCSEsNumericUpDown.Size = New System.Drawing.Size(43, 20)
        Me.Number_of_GCSEsNumericUpDown.TabIndex = 30
        '
        'Why_would_you_like_to_be_head_girl_TextBox
        '
        Me.Why_would_you_like_to_be_head_girl_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "Why would you like to be head girl?", True))
        Me.Why_would_you_like_to_be_head_girl_TextBox.Location = New System.Drawing.Point(475, 347)
        Me.Why_would_you_like_to_be_head_girl_TextBox.Multiline = True
        Me.Why_would_you_like_to_be_head_girl_TextBox.Name = "Why_would_you_like_to_be_head_girl_TextBox"
        Me.Why_would_you_like_to_be_head_girl_TextBox.Size = New System.Drawing.Size(233, 68)
        Me.Why_would_you_like_to_be_head_girl_TextBox.TabIndex = 31
        '
        'Personal_SkillsTextBox
        '
        Me.Personal_SkillsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "Personal Skills", True))
        Me.Personal_SkillsTextBox.Location = New System.Drawing.Point(475, 433)
        Me.Personal_SkillsTextBox.Multiline = True
        Me.Personal_SkillsTextBox.Name = "Personal_SkillsTextBox"
        Me.Personal_SkillsTextBox.Size = New System.Drawing.Size(233, 67)
        Me.Personal_SkillsTextBox.TabIndex = 32
        '
        'ImagePictureBox
        '
        Me.ImagePictureBox.BackColor = System.Drawing.Color.Transparent
        Me.ImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.CandidatesHeadGirlBindingSource, "Profile Image", True))
        Me.ImagePictureBox.Location = New System.Drawing.Point(223, 163)
        Me.ImagePictureBox.Name = "ImagePictureBox"
        Me.ImagePictureBox.Size = New System.Drawing.Size(100, 141)
        Me.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImagePictureBox.TabIndex = 33
        Me.ImagePictureBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(313, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 20)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Configure Head Girl Candidate Details"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.VotingOS.My.Resources.Resources.left_arrow1
        Me.PictureBox1.Location = New System.Drawing.Point(26, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.VotingOS.My.Resources.Resources.line
        Me.PictureBox3.Location = New System.Drawing.Point(835, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 37
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(865, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'HeadGirlConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(901, 567)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.CandidatesHeadGirlBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ImagePictureBox)
        Me.Controls.Add(Me.Personal_SkillsTextBox)
        Me.Controls.Add(Me.Why_would_you_like_to_be_head_girl_TextBox)
        Me.Controls.Add(Me.Number_of_GCSEsNumericUpDown)
        Me.Controls.Add(Me.Previously_Part_of_School_House_CouncilCheckBox)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ImageLabel)
        Me.Controls.Add(Personal_SkillsLabel)
        Me.Controls.Add(Previously_part_of_school_house_council_Label)
        Me.Controls.Add(Number_of_GCSELabel)
        Me.Controls.Add(Why_would_you_like_to_be_head_boy_girl_Label)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(First_NameLabel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HeadGirlConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HeadGirlConfig"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CandidatesHeadGirlBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CandidatesHeadGirlBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CandidatesHeadGirlBindingNavigator.ResumeLayout(False)
        Me.CandidatesHeadGirlBindingNavigator.PerformLayout()
        CType(Me.Number_of_GCSEsNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents CandidatesHeadGirlBindingSource As BindingSource
    Friend WithEvents CandidatesHeadGirlTableAdapter As DatabaseDataSetTableAdapters.CandidatesHeadGirlTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CandidatesHeadGirlBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CandidatesHeadGirlBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents Previously_Part_of_School_House_CouncilCheckBox As CheckBox
    Friend WithEvents Number_of_GCSEsNumericUpDown As NumericUpDown
    Friend WithEvents Why_would_you_like_to_be_head_girl_TextBox As TextBox
    Friend WithEvents Personal_SkillsTextBox As TextBox
    Friend WithEvents ImagePictureBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
