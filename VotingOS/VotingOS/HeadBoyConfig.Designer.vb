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
        Dim Number_of_GCSELabel As System.Windows.Forms.Label
        Dim Previously_part_of_school_house_council_Label As System.Windows.Forms.Label
        Dim Personal_SkillsLabel As System.Windows.Forms.Label
        Dim ImageLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HeadBoyConfig))
        Me.DatabaseDataSet = New VotingOS.DatabaseDataSet()
        Me.CandidateHeadBoyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CandidateHeadBoyTableAdapter = New VotingOS.DatabaseDataSetTableAdapters.CandidateHeadBoyTableAdapter()
        Me.TableAdapterManager = New VotingOS.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.CandidateHeadBoyBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CandidateHeadBoyBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Why_would_you_like_to_be_head_boy_girl_TextBox = New System.Windows.Forms.TextBox()
        Me.Number_of_GCSENumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Previously_part_of_school_house_council_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Personal_SkillsTextBox = New System.Windows.Forms.TextBox()
        Me.ImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        Why_would_you_like_to_be_head_boy_girl_Label = New System.Windows.Forms.Label()
        Number_of_GCSELabel = New System.Windows.Forms.Label()
        Previously_part_of_school_house_council_Label = New System.Windows.Forms.Label()
        Personal_SkillsLabel = New System.Windows.Forms.Label()
        ImageLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CandidateHeadBoyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CandidateHeadBoyBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CandidateHeadBoyBindingNavigator.SuspendLayout()
        CType(Me.Number_of_GCSENumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.BackColor = System.Drawing.Color.Transparent
        First_NameLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.ForeColor = System.Drawing.Color.White
        First_NameLabel.Location = New System.Drawing.Point(572, 204)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(85, 17)
        First_NameLabel.TabIndex = 1
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.BackColor = System.Drawing.Color.Transparent
        Last_NameLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.ForeColor = System.Drawing.Color.White
        Last_NameLabel.Location = New System.Drawing.Point(571, 243)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(84, 17)
        Last_NameLabel.TabIndex = 3
        Last_NameLabel.Text = "Last Name:"
        '
        'Why_would_you_like_to_be_head_boy_girl_Label
        '
        Why_would_you_like_to_be_head_boy_girl_Label.AutoSize = True
        Why_would_you_like_to_be_head_boy_girl_Label.BackColor = System.Drawing.Color.Transparent
        Why_would_you_like_to_be_head_boy_girl_Label.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Why_would_you_like_to_be_head_boy_girl_Label.ForeColor = System.Drawing.Color.White
        Why_would_you_like_to_be_head_boy_girl_Label.Location = New System.Drawing.Point(190, 372)
        Why_would_you_like_to_be_head_boy_girl_Label.Name = "Why_would_you_like_to_be_head_boy_girl_Label"
        Why_would_you_like_to_be_head_boy_girl_Label.Size = New System.Drawing.Size(245, 17)
        Why_would_you_like_to_be_head_boy_girl_Label.TabIndex = 5
        Why_would_you_like_to_be_head_boy_girl_Label.Text = "Why would you like to be head boy?:"
        '
        'Number_of_GCSELabel
        '
        Number_of_GCSELabel.AutoSize = True
        Number_of_GCSELabel.BackColor = System.Drawing.Color.Transparent
        Number_of_GCSELabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Number_of_GCSELabel.ForeColor = System.Drawing.Color.White
        Number_of_GCSELabel.Location = New System.Drawing.Point(527, 317)
        Number_of_GCSELabel.Name = "Number_of_GCSELabel"
        Number_of_GCSELabel.Size = New System.Drawing.Size(128, 17)
        Number_of_GCSELabel.TabIndex = 7
        Number_of_GCSELabel.Text = "Number of GCSE:"
        '
        'Previously_part_of_school_house_council_Label
        '
        Previously_part_of_school_house_council_Label.AutoSize = True
        Previously_part_of_school_house_council_Label.BackColor = System.Drawing.Color.Transparent
        Previously_part_of_school_house_council_Label.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Previously_part_of_school_house_council_Label.ForeColor = System.Drawing.Color.White
        Previously_part_of_school_house_council_Label.Location = New System.Drawing.Point(414, 281)
        Previously_part_of_school_house_council_Label.Name = "Previously_part_of_school_house_council_Label"
        Previously_part_of_school_house_council_Label.Size = New System.Drawing.Size(239, 17)
        Previously_part_of_school_house_council_Label.TabIndex = 9
        Previously_part_of_school_house_council_Label.Text = "House/School Council Experience?"
        '
        'Personal_SkillsLabel
        '
        Personal_SkillsLabel.AutoSize = True
        Personal_SkillsLabel.BackColor = System.Drawing.Color.Transparent
        Personal_SkillsLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Personal_SkillsLabel.ForeColor = System.Drawing.Color.White
        Personal_SkillsLabel.Location = New System.Drawing.Point(326, 443)
        Personal_SkillsLabel.Name = "Personal_SkillsLabel"
        Personal_SkillsLabel.Size = New System.Drawing.Size(109, 17)
        Personal_SkillsLabel.TabIndex = 11
        Personal_SkillsLabel.Text = "Personal Skills:"
        '
        'ImageLabel
        '
        ImageLabel.AutoSize = True
        ImageLabel.BackColor = System.Drawing.Color.Transparent
        ImageLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ImageLabel.ForeColor = System.Drawing.Color.White
        ImageLabel.Location = New System.Drawing.Point(121, 158)
        ImageLabel.Name = "ImageLabel"
        ImageLabel.Size = New System.Drawing.Size(98, 17)
        ImageLabel.TabIndex = 13
        ImageLabel.Text = "Profile Image:"
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CandidateHeadBoyBindingSource
        '
        Me.CandidateHeadBoyBindingSource.DataMember = "CandidateHeadBoy"
        Me.CandidateHeadBoyBindingSource.DataSource = Me.DatabaseDataSet
        '
        'CandidateHeadBoyTableAdapter
        '
        Me.CandidateHeadBoyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.authorisedmembersTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CandidateHeadBoyTableAdapter = Me.CandidateHeadBoyTableAdapter
        Me.TableAdapterManager.CandidatesHeadGirlTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = VotingOS.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        Me.TableAdapterManager.VotesTableAdapter = Nothing
        '
        'CandidateHeadBoyBindingNavigator
        '
        Me.CandidateHeadBoyBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CandidateHeadBoyBindingNavigator.BindingSource = Me.CandidateHeadBoyBindingSource
        Me.CandidateHeadBoyBindingNavigator.CountItem = Nothing
        Me.CandidateHeadBoyBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CandidateHeadBoyBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.CandidateHeadBoyBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CandidateHeadBoyBindingNavigatorSaveItem})
        Me.CandidateHeadBoyBindingNavigator.Location = New System.Drawing.Point(371, 134)
        Me.CandidateHeadBoyBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CandidateHeadBoyBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CandidateHeadBoyBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CandidateHeadBoyBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CandidateHeadBoyBindingNavigator.Name = "CandidateHeadBoyBindingNavigator"
        Me.CandidateHeadBoyBindingNavigator.PositionItem = Nothing
        Me.CandidateHeadBoyBindingNavigator.Size = New System.Drawing.Size(191, 25)
        Me.CandidateHeadBoyBindingNavigator.TabIndex = 0
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
        'CandidateHeadBoyBindingNavigatorSaveItem
        '
        Me.CandidateHeadBoyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CandidateHeadBoyBindingNavigatorSaveItem.Image = CType(resources.GetObject("CandidateHeadBoyBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CandidateHeadBoyBindingNavigatorSaveItem.Name = "CandidateHeadBoyBindingNavigatorSaveItem"
        Me.CandidateHeadBoyBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CandidateHeadBoyBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.BackColor = System.Drawing.Color.White
        Me.Last_NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidateHeadBoyBindingSource, "Last Name", True))
        Me.Last_NameTextBox.ForeColor = System.Drawing.Color.Black
        Me.Last_NameTextBox.Location = New System.Drawing.Point(670, 243)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Last_NameTextBox.TabIndex = 4
        '
        'Why_would_you_like_to_be_head_boy_girl_TextBox
        '
        Me.Why_would_you_like_to_be_head_boy_girl_TextBox.BackColor = System.Drawing.Color.White
        Me.Why_would_you_like_to_be_head_boy_girl_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Why_would_you_like_to_be_head_boy_girl_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidateHeadBoyBindingSource, "Why would you like to be head boy/girl?", True))
        Me.Why_would_you_like_to_be_head_boy_girl_TextBox.ForeColor = System.Drawing.Color.Black
        Me.Why_would_you_like_to_be_head_boy_girl_TextBox.Location = New System.Drawing.Point(450, 372)
        Me.Why_would_you_like_to_be_head_boy_girl_TextBox.Multiline = True
        Me.Why_would_you_like_to_be_head_boy_girl_TextBox.Name = "Why_would_you_like_to_be_head_boy_girl_TextBox"
        Me.Why_would_you_like_to_be_head_boy_girl_TextBox.Size = New System.Drawing.Size(284, 48)
        Me.Why_would_you_like_to_be_head_boy_girl_TextBox.TabIndex = 6
        '
        'Number_of_GCSENumericUpDown
        '
        Me.Number_of_GCSENumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CandidateHeadBoyBindingSource, "Number of GCSE", True))
        Me.Number_of_GCSENumericUpDown.Location = New System.Drawing.Point(670, 318)
        Me.Number_of_GCSENumericUpDown.Name = "Number_of_GCSENumericUpDown"
        Me.Number_of_GCSENumericUpDown.Size = New System.Drawing.Size(37, 20)
        Me.Number_of_GCSENumericUpDown.TabIndex = 8
        '
        'Previously_part_of_school_house_council_CheckBox
        '
        Me.Previously_part_of_school_house_council_CheckBox.BackColor = System.Drawing.Color.Transparent
        Me.Previously_part_of_school_house_council_CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CandidateHeadBoyBindingSource, "Previously part of school/house council?", True))
        Me.Previously_part_of_school_house_council_CheckBox.Location = New System.Drawing.Point(700, 279)
        Me.Previously_part_of_school_house_council_CheckBox.Name = "Previously_part_of_school_house_council_CheckBox"
        Me.Previously_part_of_school_house_council_CheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Previously_part_of_school_house_council_CheckBox.TabIndex = 10
        Me.Previously_part_of_school_house_council_CheckBox.UseVisualStyleBackColor = False
        '
        'Personal_SkillsTextBox
        '
        Me.Personal_SkillsTextBox.BackColor = System.Drawing.Color.White
        Me.Personal_SkillsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Personal_SkillsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidateHeadBoyBindingSource, "Personal Skills", True))
        Me.Personal_SkillsTextBox.ForeColor = System.Drawing.Color.Black
        Me.Personal_SkillsTextBox.Location = New System.Drawing.Point(450, 443)
        Me.Personal_SkillsTextBox.Multiline = True
        Me.Personal_SkillsTextBox.Name = "Personal_SkillsTextBox"
        Me.Personal_SkillsTextBox.Size = New System.Drawing.Size(284, 54)
        Me.Personal_SkillsTextBox.TabIndex = 12
        '
        'ImagePictureBox
        '
        Me.ImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.CandidateHeadBoyBindingSource, "Image", True))
        Me.ImagePictureBox.Location = New System.Drawing.Point(222, 152)
        Me.ImagePictureBox.Name = "ImagePictureBox"
        Me.ImagePictureBox.Size = New System.Drawing.Size(117, 145)
        Me.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImagePictureBox.TabIndex = 14
        Me.ImagePictureBox.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(305, 303)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(124, 303)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(166, 20)
        Me.TextBox1.TabIndex = 16
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(312, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Configure Head Boy Candidate Details"
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.BackColor = System.Drawing.Color.White
        Me.First_NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidateHeadBoyBindingSource, "First Name", True))
        Me.First_NameTextBox.ForeColor = System.Drawing.Color.Black
        Me.First_NameTextBox.Location = New System.Drawing.Point(670, 201)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.First_NameTextBox.TabIndex = 18
        '
        'HeadBoyConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(901, 567)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CandidateHeadBoyBindingNavigator)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ImageLabel)
        Me.Controls.Add(Me.ImagePictureBox)
        Me.Controls.Add(Personal_SkillsLabel)
        Me.Controls.Add(Me.Personal_SkillsTextBox)
        Me.Controls.Add(Previously_part_of_school_house_council_Label)
        Me.Controls.Add(Me.Previously_part_of_school_house_council_CheckBox)
        Me.Controls.Add(Number_of_GCSELabel)
        Me.Controls.Add(Me.Number_of_GCSENumericUpDown)
        Me.Controls.Add(Why_would_you_like_to_be_head_boy_girl_Label)
        Me.Controls.Add(Me.Why_would_you_like_to_be_head_boy_girl_TextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HeadBoyConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HeadBoyConfig"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CandidateHeadBoyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CandidateHeadBoyBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CandidateHeadBoyBindingNavigator.ResumeLayout(False)
        Me.CandidateHeadBoyBindingNavigator.PerformLayout()
        CType(Me.Number_of_GCSENumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents CandidateHeadBoyBindingSource As BindingSource
    Friend WithEvents CandidateHeadBoyTableAdapter As DatabaseDataSetTableAdapters.CandidateHeadBoyTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CandidateHeadBoyBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CandidateHeadBoyBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents Why_would_you_like_to_be_head_boy_girl_TextBox As TextBox
    Friend WithEvents Number_of_GCSENumericUpDown As NumericUpDown
    Friend WithEvents Previously_part_of_school_house_council_CheckBox As CheckBox
    Friend WithEvents Personal_SkillsTextBox As TextBox
    Friend WithEvents ImagePictureBox As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents First_NameTextBox As TextBox
End Class
