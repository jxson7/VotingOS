<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class headboyvote
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(headboyvote))
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim Why_would_you_like_to_be_head_boy_girl_Label As System.Windows.Forms.Label
        Dim What_changes_would_you_make_Label As System.Windows.Forms.Label
        Dim Number_of_GCSELabel As System.Windows.Forms.Label
        Dim Previously_part_of_school_house_council_Label As System.Windows.Forms.Label
        Dim Personal_SkillsLabel As System.Windows.Forms.Label
        Dim ImageLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CandidatesHeadBoyDataSet = New VotingOS.CandidatesHeadBoyDataSet()
        Me.CandidateHeadBoyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CandidateHeadBoyTableAdapter = New VotingOS.CandidatesHeadBoyDataSetTableAdapters.CandidateHeadBoyTableAdapter()
        Me.TableAdapterManager = New VotingOS.CandidatesHeadBoyDataSetTableAdapters.TableAdapterManager()
        Me.CandidateHeadBoyBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CandidateHeadBoyBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.First_NameLabel1 = New System.Windows.Forms.Label()
        Me.Last_NameLabel1 = New System.Windows.Forms.Label()
        Me.Why_would_you_like_to_be_head_boy_girl_Label1 = New System.Windows.Forms.Label()
        Me.What_changes_would_you_make_Label1 = New System.Windows.Forms.Label()
        Me.Number_of_GCSELabel1 = New System.Windows.Forms.Label()
        Me.Previously_part_of_school_house_council_Label1 = New System.Windows.Forms.Label()
        Me.Personal_SkillsLabel1 = New System.Windows.Forms.Label()
        Me.ImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        Why_would_you_like_to_be_head_boy_girl_Label = New System.Windows.Forms.Label()
        What_changes_would_you_make_Label = New System.Windows.Forms.Label()
        Number_of_GCSELabel = New System.Windows.Forms.Label()
        Previously_part_of_school_house_council_Label = New System.Windows.Forms.Label()
        Personal_SkillsLabel = New System.Windows.Forms.Label()
        ImageLabel = New System.Windows.Forms.Label()
        CType(Me.CandidatesHeadBoyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CandidateHeadBoyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CandidateHeadBoyBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CandidateHeadBoyBindingNavigator.SuspendLayout()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(78, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 38)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "VotingOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(48, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Vote For Your Head Boy"
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
        Me.CandidateHeadBoyBindingNavigator.Size = New System.Drawing.Size(752, 25)
        Me.CandidateHeadBoyBindingNavigator.TabIndex = 4
        Me.CandidateHeadBoyBindingNavigator.Text = "BindingNavigator1"
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
        'CandidateHeadBoyBindingNavigatorSaveItem
        '
        Me.CandidateHeadBoyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CandidateHeadBoyBindingNavigatorSaveItem.Enabled = False
        Me.CandidateHeadBoyBindingNavigatorSaveItem.Image = CType(resources.GetObject("CandidateHeadBoyBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CandidateHeadBoyBindingNavigatorSaveItem.Name = "CandidateHeadBoyBindingNavigatorSaveItem"
        Me.CandidateHeadBoyBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CandidateHeadBoyBindingNavigatorSaveItem.Text = "Save Data"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.BackColor = System.Drawing.Color.Transparent
        First_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.ForeColor = System.Drawing.Color.White
        First_NameLabel.Location = New System.Drawing.Point(18, 186)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(76, 16)
        First_NameLabel.TabIndex = 4
        First_NameLabel.Text = "First Name:"
        '
        'First_NameLabel1
        '
        Me.First_NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidateHeadBoyBindingSource, "First Name", True))
        Me.First_NameLabel1.Location = New System.Drawing.Point(106, 185)
        Me.First_NameLabel1.Name = "First_NameLabel1"
        Me.First_NameLabel1.Size = New System.Drawing.Size(189, 23)
        Me.First_NameLabel1.TabIndex = 5
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.BackColor = System.Drawing.Color.Transparent
        Last_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.ForeColor = System.Drawing.Color.White
        Last_NameLabel.Location = New System.Drawing.Point(17, 224)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(76, 16)
        Last_NameLabel.TabIndex = 5
        Last_NameLabel.Text = "Last Name:"
        '
        'Last_NameLabel1
        '
        Me.Last_NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidateHeadBoyBindingSource, "Last Name", True))
        Me.Last_NameLabel1.Location = New System.Drawing.Point(106, 223)
        Me.Last_NameLabel1.Name = "Last_NameLabel1"
        Me.Last_NameLabel1.Size = New System.Drawing.Size(189, 23)
        Me.Last_NameLabel1.TabIndex = 6
        '
        'Why_would_you_like_to_be_head_boy_girl_Label
        '
        Why_would_you_like_to_be_head_boy_girl_Label.AutoSize = True
        Why_would_you_like_to_be_head_boy_girl_Label.BackColor = System.Drawing.Color.Transparent
        Why_would_you_like_to_be_head_boy_girl_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Why_would_you_like_to_be_head_boy_girl_Label.ForeColor = System.Drawing.Color.White
        Why_would_you_like_to_be_head_boy_girl_Label.Location = New System.Drawing.Point(17, 291)
        Why_would_you_like_to_be_head_boy_girl_Label.Name = "Why_would_you_like_to_be_head_boy_girl_Label"
        Why_would_you_like_to_be_head_boy_girl_Label.Size = New System.Drawing.Size(247, 16)
        Why_would_you_like_to_be_head_boy_girl_Label.TabIndex = 7
        Why_would_you_like_to_be_head_boy_girl_Label.Text = "Why would you like to be head boy/girl?:"
        '
        'Why_would_you_like_to_be_head_boy_girl_Label1
        '
        Me.Why_would_you_like_to_be_head_boy_girl_Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidateHeadBoyBindingSource, "Why would you like to be head boy/girl?", True))
        Me.Why_would_you_like_to_be_head_boy_girl_Label1.Location = New System.Drawing.Point(270, 291)
        Me.Why_would_you_like_to_be_head_boy_girl_Label1.Name = "Why_would_you_like_to_be_head_boy_girl_Label1"
        Me.Why_would_you_like_to_be_head_boy_girl_Label1.Size = New System.Drawing.Size(443, 79)
        Me.Why_would_you_like_to_be_head_boy_girl_Label1.TabIndex = 8
        '
        'What_changes_would_you_make_Label
        '
        What_changes_would_you_make_Label.AutoSize = True
        What_changes_would_you_make_Label.BackColor = System.Drawing.Color.Transparent
        What_changes_would_you_make_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        What_changes_would_you_make_Label.ForeColor = System.Drawing.Color.White
        What_changes_would_you_make_Label.Location = New System.Drawing.Point(51, 390)
        What_changes_would_you_make_Label.Name = "What_changes_would_you_make_Label"
        What_changes_would_you_make_Label.Size = New System.Drawing.Size(204, 16)
        What_changes_would_you_make_Label.TabIndex = 9
        What_changes_would_you_make_Label.Text = "What changes would you make?:"
        '
        'What_changes_would_you_make_Label1
        '
        Me.What_changes_would_you_make_Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidateHeadBoyBindingSource, "What changes would you make?", True))
        Me.What_changes_would_you_make_Label1.Location = New System.Drawing.Point(270, 390)
        Me.What_changes_would_you_make_Label1.Name = "What_changes_would_you_make_Label1"
        Me.What_changes_would_you_make_Label1.Size = New System.Drawing.Size(443, 71)
        Me.What_changes_would_you_make_Label1.TabIndex = 10
        '
        'Number_of_GCSELabel
        '
        Number_of_GCSELabel.AutoSize = True
        Number_of_GCSELabel.BackColor = System.Drawing.Color.Transparent
        Number_of_GCSELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Number_of_GCSELabel.ForeColor = System.Drawing.Color.White
        Number_of_GCSELabel.Location = New System.Drawing.Point(430, 196)
        Number_of_GCSELabel.Name = "Number_of_GCSELabel"
        Number_of_GCSELabel.Size = New System.Drawing.Size(113, 16)
        Number_of_GCSELabel.TabIndex = 11
        Number_of_GCSELabel.Text = "Number of GCSE:"
        '
        'Number_of_GCSELabel1
        '
        Me.Number_of_GCSELabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidateHeadBoyBindingSource, "Number of GCSE", True))
        Me.Number_of_GCSELabel1.Location = New System.Drawing.Point(549, 193)
        Me.Number_of_GCSELabel1.Name = "Number_of_GCSELabel1"
        Me.Number_of_GCSELabel1.Size = New System.Drawing.Size(100, 23)
        Me.Number_of_GCSELabel1.TabIndex = 12
        '
        'Previously_part_of_school_house_council_Label
        '
        Previously_part_of_school_house_council_Label.AutoSize = True
        Previously_part_of_school_house_council_Label.BackColor = System.Drawing.Color.Transparent
        Previously_part_of_school_house_council_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Previously_part_of_school_house_council_Label.ForeColor = System.Drawing.Color.White
        Previously_part_of_school_house_council_Label.Location = New System.Drawing.Point(301, 235)
        Previously_part_of_school_house_council_Label.Name = "Previously_part_of_school_house_council_Label"
        Previously_part_of_school_house_council_Label.Size = New System.Drawing.Size(250, 16)
        Previously_part_of_school_house_council_Label.TabIndex = 13
        Previously_part_of_school_house_council_Label.Text = "Previously part of school/house council?:"
        '
        'Previously_part_of_school_house_council_Label1
        '
        Me.Previously_part_of_school_house_council_Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidateHeadBoyBindingSource, "Previously part of school/house council?", True))
        Me.Previously_part_of_school_house_council_Label1.Location = New System.Drawing.Point(555, 235)
        Me.Previously_part_of_school_house_council_Label1.Name = "Previously_part_of_school_house_council_Label1"
        Me.Previously_part_of_school_house_council_Label1.Size = New System.Drawing.Size(100, 23)
        Me.Previously_part_of_school_house_council_Label1.TabIndex = 14
        '
        'Personal_SkillsLabel
        '
        Personal_SkillsLabel.AutoSize = True
        Personal_SkillsLabel.BackColor = System.Drawing.Color.Transparent
        Personal_SkillsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Personal_SkillsLabel.ForeColor = System.Drawing.Color.White
        Personal_SkillsLabel.Location = New System.Drawing.Point(139, 474)
        Personal_SkillsLabel.Name = "Personal_SkillsLabel"
        Personal_SkillsLabel.Size = New System.Drawing.Size(100, 16)
        Personal_SkillsLabel.TabIndex = 15
        Personal_SkillsLabel.Text = "Personal Skills:"
        '
        'Personal_SkillsLabel1
        '
        Me.Personal_SkillsLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidateHeadBoyBindingSource, "Personal Skills", True))
        Me.Personal_SkillsLabel1.Location = New System.Drawing.Point(270, 474)
        Me.Personal_SkillsLabel1.Name = "Personal_SkillsLabel1"
        Me.Personal_SkillsLabel1.Size = New System.Drawing.Size(443, 91)
        Me.Personal_SkillsLabel1.TabIndex = 16
        '
        'ImageLabel
        '
        ImageLabel.AutoSize = True
        ImageLabel.BackColor = System.Drawing.Color.Transparent
        ImageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ImageLabel.ForeColor = System.Drawing.Color.White
        ImageLabel.Location = New System.Drawing.Point(457, 45)
        ImageLabel.Name = "ImageLabel"
        ImageLabel.Size = New System.Drawing.Size(49, 16)
        ImageLabel.TabIndex = 17
        ImageLabel.Text = "Image:"
        '
        'ImagePictureBox
        '
        Me.ImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.CandidateHeadBoyBindingSource, "Image", True))
        Me.ImagePictureBox.Location = New System.Drawing.Point(524, 44)
        Me.ImagePictureBox.Name = "ImagePictureBox"
        Me.ImagePictureBox.Size = New System.Drawing.Size(100, 135)
        Me.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ImagePictureBox.TabIndex = 18
        Me.ImagePictureBox.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(-15, -15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(85, 531)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Final Vote"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'headboyvote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(752, 584)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ImageLabel)
        Me.Controls.Add(Me.ImagePictureBox)
        Me.Controls.Add(Personal_SkillsLabel)
        Me.Controls.Add(Me.Personal_SkillsLabel1)
        Me.Controls.Add(Previously_part_of_school_house_council_Label)
        Me.Controls.Add(Me.Previously_part_of_school_house_council_Label1)
        Me.Controls.Add(Number_of_GCSELabel)
        Me.Controls.Add(Me.Number_of_GCSELabel1)
        Me.Controls.Add(What_changes_would_you_make_Label)
        Me.Controls.Add(Me.What_changes_would_you_make_Label1)
        Me.Controls.Add(Why_would_you_like_to_be_head_boy_girl_Label)
        Me.Controls.Add(Me.Why_would_you_like_to_be_head_boy_girl_Label1)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameLabel1)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameLabel1)
        Me.Controls.Add(Me.CandidateHeadBoyBindingNavigator)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "headboyvote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "headboyvote"
        CType(Me.CandidatesHeadBoyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CandidateHeadBoyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CandidateHeadBoyBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CandidateHeadBoyBindingNavigator.ResumeLayout(False)
        Me.CandidateHeadBoyBindingNavigator.PerformLayout()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
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
    Friend WithEvents First_NameLabel1 As Label
    Friend WithEvents Last_NameLabel1 As Label
    Friend WithEvents Why_would_you_like_to_be_head_boy_girl_Label1 As Label
    Friend WithEvents What_changes_would_you_make_Label1 As Label
    Friend WithEvents Number_of_GCSELabel1 As Label
    Friend WithEvents Previously_part_of_school_house_council_Label1 As Label
    Friend WithEvents Personal_SkillsLabel1 As Label
    Friend WithEvents ImagePictureBox As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
