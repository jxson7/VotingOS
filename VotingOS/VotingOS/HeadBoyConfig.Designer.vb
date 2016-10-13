<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HeadBoyConfig
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
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim Why_would_you_like_to_be_head_boy_girl_Label As System.Windows.Forms.Label
        Dim What_changes_would_you_make_Label As System.Windows.Forms.Label
        Dim Number_of_GCSELabel As System.Windows.Forms.Label
        Dim ImageLabel As System.Windows.Forms.Label
        Dim Personal_SkillsLabel As System.Windows.Forms.Label
        Dim Previously_part_of_school_house_council_Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HeadBoyConfig))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CandidatesHeadBoyDataSet = New VotingOS.CandidatesHeadBoyDataSet()
        Me.CandidateHeadBoyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CandidateHeadBoyTableAdapter = New VotingOS.CandidatesHeadBoyDataSetTableAdapters.CandidateHeadBoyTableAdapter()
        Me.TableAdapterManager = New VotingOS.CandidatesHeadBoyDataSetTableAdapters.TableAdapterManager()
        Me.CandidateHeadBoyBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CandidateHeadBoyBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Why_would_you_like_to_be_head_boy_girl_TextBox = New System.Windows.Forms.TextBox()
        Me.What_changes_would_you_make_TextBox = New System.Windows.Forms.TextBox()
        Me.Number_of_GCSETextBox = New System.Windows.Forms.TextBox()
        Me.ImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.Personal_SkillsTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Previously_part_of_school_house_council_CheckBox = New System.Windows.Forms.CheckBox()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        Why_would_you_like_to_be_head_boy_girl_Label = New System.Windows.Forms.Label()
        What_changes_would_you_make_Label = New System.Windows.Forms.Label()
        Number_of_GCSELabel = New System.Windows.Forms.Label()
        ImageLabel = New System.Windows.Forms.Label()
        Personal_SkillsLabel = New System.Windows.Forms.Label()
        Previously_part_of_school_house_council_Label = New System.Windows.Forms.Label()
        CType(Me.CandidatesHeadBoyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CandidateHeadBoyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CandidateHeadBoyBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CandidateHeadBoyBindingNavigator.SuspendLayout()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.BackColor = System.Drawing.Color.Transparent
        First_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.ForeColor = System.Drawing.Color.White
        First_NameLabel.Location = New System.Drawing.Point(38, 130)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(60, 13)
        First_NameLabel.TabIndex = 19
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.BackColor = System.Drawing.Color.Transparent
        Last_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.ForeColor = System.Drawing.Color.White
        Last_NameLabel.Location = New System.Drawing.Point(37, 165)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel.TabIndex = 20
        Last_NameLabel.Text = "Last Name:"
        '
        'Why_would_you_like_to_be_head_boy_girl_Label
        '
        Why_would_you_like_to_be_head_boy_girl_Label.AutoSize = True
        Why_would_you_like_to_be_head_boy_girl_Label.BackColor = System.Drawing.Color.Transparent
        Why_would_you_like_to_be_head_boy_girl_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Why_would_you_like_to_be_head_boy_girl_Label.ForeColor = System.Drawing.Color.White
        Why_would_you_like_to_be_head_boy_girl_Label.Location = New System.Drawing.Point(11, 289)
        Why_would_you_like_to_be_head_boy_girl_Label.Name = "Why_would_you_like_to_be_head_boy_girl_Label"
        Why_would_you_like_to_be_head_boy_girl_Label.Size = New System.Drawing.Size(197, 13)
        Why_would_you_like_to_be_head_boy_girl_Label.TabIndex = 21
        Why_would_you_like_to_be_head_boy_girl_Label.Text = "Why would you like to be head boy/girl?"
        '
        'What_changes_would_you_make_Label
        '
        What_changes_would_you_make_Label.AutoSize = True
        What_changes_would_you_make_Label.BackColor = System.Drawing.Color.Transparent
        What_changes_would_you_make_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        What_changes_would_you_make_Label.Location = New System.Drawing.Point(45, 367)
        What_changes_would_you_make_Label.Name = "What_changes_would_you_make_Label"
        What_changes_would_you_make_Label.Size = New System.Drawing.Size(163, 13)
        What_changes_would_you_make_Label.TabIndex = 22
        What_changes_would_you_make_Label.Text = "What changes would you make?"
        '
        'Number_of_GCSELabel
        '
        Number_of_GCSELabel.AutoSize = True
        Number_of_GCSELabel.BackColor = System.Drawing.Color.Transparent
        Number_of_GCSELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Number_of_GCSELabel.ForeColor = System.Drawing.Color.White
        Number_of_GCSELabel.Location = New System.Drawing.Point(7, 203)
        Number_of_GCSELabel.Name = "Number_of_GCSELabel"
        Number_of_GCSELabel.Size = New System.Drawing.Size(91, 13)
        Number_of_GCSELabel.TabIndex = 23
        Number_of_GCSELabel.Text = "Number of GCSE:"
        '
        'ImageLabel
        '
        ImageLabel.AutoSize = True
        ImageLabel.BackColor = System.Drawing.Color.Transparent
        ImageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ImageLabel.ForeColor = System.Drawing.Color.White
        ImageLabel.Location = New System.Drawing.Point(403, 61)
        ImageLabel.Name = "ImageLabel"
        ImageLabel.Size = New System.Drawing.Size(71, 13)
        ImageLabel.TabIndex = 24
        ImageLabel.Text = "Profile Image:"
        '
        'Personal_SkillsLabel
        '
        Personal_SkillsLabel.AutoSize = True
        Personal_SkillsLabel.BackColor = System.Drawing.Color.Transparent
        Personal_SkillsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Personal_SkillsLabel.Location = New System.Drawing.Point(133, 462)
        Personal_SkillsLabel.Name = "Personal_SkillsLabel"
        Personal_SkillsLabel.Size = New System.Drawing.Size(404, 13)
        Personal_SkillsLabel.TabIndex = 25
        Personal_SkillsLabel.Text = "Personal Skills (including whether you were previously part of house/school counc" &
    "il):"
        '
        'Previously_part_of_school_house_council_Label
        '
        Previously_part_of_school_house_council_Label.AutoSize = True
        Previously_part_of_school_house_council_Label.BackColor = System.Drawing.Color.Transparent
        Previously_part_of_school_house_council_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Previously_part_of_school_house_council_Label.ForeColor = System.Drawing.Color.White
        Previously_part_of_school_house_council_Label.Location = New System.Drawing.Point(7, 234)
        Previously_part_of_school_house_council_Label.Name = "Previously_part_of_school_house_council_Label"
        Previously_part_of_school_house_council_Label.Size = New System.Drawing.Size(202, 13)
        Previously_part_of_school_house_council_Label.TabIndex = 28
        Previously_part_of_school_house_council_Label.Text = "Previously part of school/house council?:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(33, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 38)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "VotingOS"
        '
        'CandidatesHeadBoyDataSet
        '
        Me.CandidatesHeadBoyDataSet.DataSetName = "CandidatesHeadBoyDataSet"
        Me.CandidatesHeadBoyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CandidateHeadBoyBindingSource
        '
        Me.CandidateHeadBoyBindingSource.DataMember = "CandidateHeadBoy"
        Me.CandidateHeadBoyBindingSource.DataSource = Me.CandidatesHeadBoyDataSet
        '
        'CandidateHeadBoyTableAdapter
        '
        Me.CandidateHeadBoyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CandidateHeadBoyTableAdapter = Me.CandidateHeadBoyTableAdapter
        Me.TableAdapterManager.UpdateOrder = VotingOS.CandidatesHeadBoyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CandidateHeadBoyBindingNavigator
        '
        Me.CandidateHeadBoyBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CandidateHeadBoyBindingNavigator.BindingSource = Me.CandidateHeadBoyBindingSource
        Me.CandidateHeadBoyBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CandidateHeadBoyBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CandidateHeadBoyBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CandidateHeadBoyBindingNavigatorSaveItem})
        Me.CandidateHeadBoyBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CandidateHeadBoyBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CandidateHeadBoyBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CandidateHeadBoyBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CandidateHeadBoyBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CandidateHeadBoyBindingNavigator.Name = "CandidateHeadBoyBindingNavigator"
        Me.CandidateHeadBoyBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CandidateHeadBoyBindingNavigator.Size = New System.Drawing.Size(701, 25)
        Me.CandidateHeadBoyBindingNavigator.TabIndex = 19
        Me.CandidateHeadBoyBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
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
        'CandidateHeadBoyBindingNavigatorSaveItem
        '
        Me.CandidateHeadBoyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CandidateHeadBoyBindingNavigatorSaveItem.Image = CType(resources.GetObject("CandidateHeadBoyBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CandidateHeadBoyBindingNavigatorSaveItem.Name = "CandidateHeadBoyBindingNavigatorSaveItem"
        Me.CandidateHeadBoyBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CandidateHeadBoyBindingNavigatorSaveItem.Text = "Save Data"
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidateHeadBoyBindingSource, "First Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(104, 127)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.First_NameTextBox.TabIndex = 20
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidateHeadBoyBindingSource, "Last Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(104, 162)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Last_NameTextBox.TabIndex = 21
        '
        'Why_would_you_like_to_be_head_boy_girl_TextBox
        '
        Me.Why_would_you_like_to_be_head_boy_girl_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidateHeadBoyBindingSource, "Why would you like to be head boy/girl?", True))
        Me.Why_would_you_like_to_be_head_boy_girl_TextBox.Location = New System.Drawing.Point(217, 286)
        Me.Why_would_you_like_to_be_head_boy_girl_TextBox.Multiline = True
        Me.Why_would_you_like_to_be_head_boy_girl_TextBox.Name = "Why_would_you_like_to_be_head_boy_girl_TextBox"
        Me.Why_would_you_like_to_be_head_boy_girl_TextBox.Size = New System.Drawing.Size(390, 72)
        Me.Why_would_you_like_to_be_head_boy_girl_TextBox.TabIndex = 22
        '
        'What_changes_would_you_make_TextBox
        '
        Me.What_changes_would_you_make_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidateHeadBoyBindingSource, "What changes would you make?", True))
        Me.What_changes_would_you_make_TextBox.Location = New System.Drawing.Point(217, 364)
        Me.What_changes_would_you_make_TextBox.Multiline = True
        Me.What_changes_would_you_make_TextBox.Name = "What_changes_would_you_make_TextBox"
        Me.What_changes_would_you_make_TextBox.Size = New System.Drawing.Size(390, 89)
        Me.What_changes_would_you_make_TextBox.TabIndex = 23
        '
        'Number_of_GCSETextBox
        '
        Me.Number_of_GCSETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidateHeadBoyBindingSource, "Number of GCSE", True))
        Me.Number_of_GCSETextBox.Location = New System.Drawing.Point(104, 200)
        Me.Number_of_GCSETextBox.Name = "Number_of_GCSETextBox"
        Me.Number_of_GCSETextBox.Size = New System.Drawing.Size(100, 20)
        Me.Number_of_GCSETextBox.TabIndex = 24
        '
        'ImagePictureBox
        '
        Me.ImagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.CandidateHeadBoyBindingSource, "Image", True))
        Me.ImagePictureBox.Location = New System.Drawing.Point(480, 52)
        Me.ImagePictureBox.Name = "ImagePictureBox"
        Me.ImagePictureBox.Size = New System.Drawing.Size(123, 164)
        Me.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ImagePictureBox.TabIndex = 25
        Me.ImagePictureBox.TabStop = False
        '
        'Personal_SkillsTextBox
        '
        Me.Personal_SkillsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidateHeadBoyBindingSource, "Personal Skills", True))
        Me.Personal_SkillsTextBox.Location = New System.Drawing.Point(48, 478)
        Me.Personal_SkillsTextBox.Multiline = True
        Me.Personal_SkillsTextBox.Name = "Personal_SkillsTextBox"
        Me.Personal_SkillsTextBox.Size = New System.Drawing.Size(559, 71)
        Me.Personal_SkillsTextBox.TabIndex = 26
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(292, 233)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(182, 20)
        Me.TextBox1.TabIndex = 27
        Me.TextBox1.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(489, 226)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 32)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "Browse"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Previously_part_of_school_house_council_CheckBox
        '
        Me.Previously_part_of_school_house_council_CheckBox.BackColor = System.Drawing.Color.Transparent
        Me.Previously_part_of_school_house_council_CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CandidateHeadBoyBindingSource, "Previously part of school/house council?", True))
        Me.Previously_part_of_school_house_council_CheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Previously_part_of_school_house_council_CheckBox.Location = New System.Drawing.Point(215, 229)
        Me.Previously_part_of_school_house_council_CheckBox.Name = "Previously_part_of_school_house_council_CheckBox"
        Me.Previously_part_of_school_house_council_CheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Previously_part_of_school_house_council_CheckBox.TabIndex = 29
        Me.Previously_part_of_school_house_council_CheckBox.UseVisualStyleBackColor = False
        '
        'HeadBoyConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(701, 575)
        Me.Controls.Add(Previously_part_of_school_house_council_Label)
        Me.Controls.Add(Me.Previously_part_of_school_house_council_CheckBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Personal_SkillsLabel)
        Me.Controls.Add(Me.Personal_SkillsTextBox)
        Me.Controls.Add(ImageLabel)
        Me.Controls.Add(Me.ImagePictureBox)
        Me.Controls.Add(Number_of_GCSELabel)
        Me.Controls.Add(Me.Number_of_GCSETextBox)
        Me.Controls.Add(What_changes_would_you_make_Label)
        Me.Controls.Add(Me.What_changes_would_you_make_TextBox)
        Me.Controls.Add(Why_would_you_like_to_be_head_boy_girl_Label)
        Me.Controls.Add(Me.Why_would_you_like_to_be_head_boy_girl_TextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Me.CandidateHeadBoyBindingNavigator)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HeadBoyConfig"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Head Boy Configuration"
        CType(Me.CandidatesHeadBoyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CandidateHeadBoyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CandidateHeadBoyBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CandidateHeadBoyBindingNavigator.ResumeLayout(False)
        Me.CandidateHeadBoyBindingNavigator.PerformLayout()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents CandidatesHeadBoyDataSet As CandidatesHeadBoyDataSet
    Friend WithEvents CandidateHeadBoyBindingSource As BindingSource
    Friend WithEvents CandidateHeadBoyTableAdapter As CandidatesHeadBoyDataSetTableAdapters.CandidateHeadBoyTableAdapter
    Friend WithEvents TableAdapterManager As CandidatesHeadBoyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CandidateHeadBoyBindingNavigator As BindingNavigator
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
    Friend WithEvents CandidateHeadBoyBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents Why_would_you_like_to_be_head_boy_girl_TextBox As TextBox
    Friend WithEvents What_changes_would_you_make_TextBox As TextBox
    Friend WithEvents Number_of_GCSETextBox As TextBox
    Friend WithEvents ImagePictureBox As PictureBox
    Friend WithEvents Personal_SkillsTextBox As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Previously_part_of_school_house_council_CheckBox As CheckBox
End Class
