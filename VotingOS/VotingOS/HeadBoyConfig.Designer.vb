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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HeadBoyConfig))
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim Why_would_you_like_to_be_head_boy_girl_Label As System.Windows.Forms.Label
        Dim Number_of_GCSELabel As System.Windows.Forms.Label
        Dim Previously_part_of_school_house_council_Label As System.Windows.Forms.Label
        Dim Personal_SkillsLabel As System.Windows.Forms.Label
        Dim ImageLabel As System.Windows.Forms.Label
        Me.DatabaseDataSet = New VotingOS.DatabaseDataSet()
        Me.CandidateHeadBoyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CandidateHeadBoyTableAdapter = New VotingOS.DatabaseDataSetTableAdapters.CandidateHeadBoyTableAdapter()
        Me.TableAdapterManager = New VotingOS.DatabaseDataSetTableAdapters.TableAdapterManager()
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
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Why_would_you_like_to_be_head_boy_girl_TextBox = New System.Windows.Forms.TextBox()
        Me.Number_of_GCSENumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Previously_part_of_school_house_council_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Personal_SkillsTextBox = New System.Windows.Forms.TextBox()
        Me.ImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
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
        Me.CandidateHeadBoyBindingNavigator.Size = New System.Drawing.Size(883, 25)
        Me.CandidateHeadBoyBindingNavigator.TabIndex = 0
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
        'CandidateHeadBoyBindingNavigatorSaveItem
        '
        Me.CandidateHeadBoyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CandidateHeadBoyBindingNavigatorSaveItem.Image = CType(resources.GetObject("CandidateHeadBoyBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CandidateHeadBoyBindingNavigatorSaveItem.Name = "CandidateHeadBoyBindingNavigatorSaveItem"
        Me.CandidateHeadBoyBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CandidateHeadBoyBindingNavigatorSaveItem.Text = "Save Data"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.BackColor = System.Drawing.Color.Transparent
        First_NameLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.ForeColor = System.Drawing.Color.White
        First_NameLabel.Location = New System.Drawing.Point(201, 117)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(85, 17)
        First_NameLabel.TabIndex = 1
        First_NameLabel.Text = "First Name:"
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidateHeadBoyBindingSource, "Last Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(299, 117)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.First_NameTextBox.TabIndex = 2
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.BackColor = System.Drawing.Color.Transparent
        Last_NameLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.ForeColor = System.Drawing.Color.White
        Last_NameLabel.Location = New System.Drawing.Point(200, 156)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(84, 17)
        Last_NameLabel.TabIndex = 3
        Last_NameLabel.Text = "Last Name:"
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidateHeadBoyBindingSource, "Last Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(299, 156)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Last_NameTextBox.TabIndex = 4
        '
        'Why_would_you_like_to_be_head_boy_girl_Label
        '
        Why_would_you_like_to_be_head_boy_girl_Label.AutoSize = True
        Why_would_you_like_to_be_head_boy_girl_Label.BackColor = System.Drawing.Color.Transparent
        Why_would_you_like_to_be_head_boy_girl_Label.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Why_would_you_like_to_be_head_boy_girl_Label.ForeColor = System.Drawing.Color.White
        Why_would_you_like_to_be_head_boy_girl_Label.Location = New System.Drawing.Point(39, 261)
        Why_would_you_like_to_be_head_boy_girl_Label.Name = "Why_would_you_like_to_be_head_boy_girl_Label"
        Why_would_you_like_to_be_head_boy_girl_Label.Size = New System.Drawing.Size(245, 17)
        Why_would_you_like_to_be_head_boy_girl_Label.TabIndex = 5
        Why_would_you_like_to_be_head_boy_girl_Label.Text = "Why would you like to be head boy?:"
        '
        'Why_would_you_like_to_be_head_boy_girl_TextBox
        '
        Me.Why_would_you_like_to_be_head_boy_girl_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidateHeadBoyBindingSource, "Why would you like to be head boy/girl?", True))
        Me.Why_would_you_like_to_be_head_boy_girl_TextBox.Location = New System.Drawing.Point(299, 261)
        Me.Why_would_you_like_to_be_head_boy_girl_TextBox.Multiline = True
        Me.Why_would_you_like_to_be_head_boy_girl_TextBox.Name = "Why_would_you_like_to_be_head_boy_girl_TextBox"
        Me.Why_would_you_like_to_be_head_boy_girl_TextBox.Size = New System.Drawing.Size(557, 85)
        Me.Why_would_you_like_to_be_head_boy_girl_TextBox.TabIndex = 6
        '
        'Number_of_GCSELabel
        '
        Number_of_GCSELabel.AutoSize = True
        Number_of_GCSELabel.BackColor = System.Drawing.Color.Transparent
        Number_of_GCSELabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Number_of_GCSELabel.ForeColor = System.Drawing.Color.White
        Number_of_GCSELabel.Location = New System.Drawing.Point(156, 223)
        Number_of_GCSELabel.Name = "Number_of_GCSELabel"
        Number_of_GCSELabel.Size = New System.Drawing.Size(128, 17)
        Number_of_GCSELabel.TabIndex = 7
        Number_of_GCSELabel.Text = "Number of GCSE:"
        '
        'Number_of_GCSENumericUpDown
        '
        Me.Number_of_GCSENumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CandidateHeadBoyBindingSource, "Number of GCSE", True))
        Me.Number_of_GCSENumericUpDown.Location = New System.Drawing.Point(299, 224)
        Me.Number_of_GCSENumericUpDown.Name = "Number_of_GCSENumericUpDown"
        Me.Number_of_GCSENumericUpDown.Size = New System.Drawing.Size(37, 20)
        Me.Number_of_GCSENumericUpDown.TabIndex = 8
        '
        'Previously_part_of_school_house_council_Label
        '
        Previously_part_of_school_house_council_Label.AutoSize = True
        Previously_part_of_school_house_council_Label.BackColor = System.Drawing.Color.Transparent
        Previously_part_of_school_house_council_Label.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Previously_part_of_school_house_council_Label.ForeColor = System.Drawing.Color.White
        Previously_part_of_school_house_council_Label.Location = New System.Drawing.Point(9, 191)
        Previously_part_of_school_house_council_Label.Name = "Previously_part_of_school_house_council_Label"
        Previously_part_of_school_house_council_Label.Size = New System.Drawing.Size(275, 17)
        Previously_part_of_school_house_council_Label.TabIndex = 9
        Previously_part_of_school_house_council_Label.Text = "Previously part of school/house council?:"
        '
        'Previously_part_of_school_house_council_CheckBox
        '
        Me.Previously_part_of_school_house_council_CheckBox.BackColor = System.Drawing.Color.Transparent
        Me.Previously_part_of_school_house_council_CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CandidateHeadBoyBindingSource, "Previously part of school/house council?", True))
        Me.Previously_part_of_school_house_council_CheckBox.Location = New System.Drawing.Point(299, 189)
        Me.Previously_part_of_school_house_council_CheckBox.Name = "Previously_part_of_school_house_council_CheckBox"
        Me.Previously_part_of_school_house_council_CheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Previously_part_of_school_house_council_CheckBox.TabIndex = 10
        Me.Previously_part_of_school_house_council_CheckBox.UseVisualStyleBackColor = False
        '
        'Personal_SkillsLabel
        '
        Personal_SkillsLabel.AutoSize = True
        Personal_SkillsLabel.BackColor = System.Drawing.Color.Transparent
        Personal_SkillsLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Personal_SkillsLabel.ForeColor = System.Drawing.Color.White
        Personal_SkillsLabel.Location = New System.Drawing.Point(175, 365)
        Personal_SkillsLabel.Name = "Personal_SkillsLabel"
        Personal_SkillsLabel.Size = New System.Drawing.Size(109, 17)
        Personal_SkillsLabel.TabIndex = 11
        Personal_SkillsLabel.Text = "Personal Skills:"
        '
        'Personal_SkillsTextBox
        '
        Me.Personal_SkillsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidateHeadBoyBindingSource, "Personal Skills", True))
        Me.Personal_SkillsTextBox.Location = New System.Drawing.Point(299, 365)
        Me.Personal_SkillsTextBox.Multiline = True
        Me.Personal_SkillsTextBox.Name = "Personal_SkillsTextBox"
        Me.Personal_SkillsTextBox.Size = New System.Drawing.Size(557, 86)
        Me.Personal_SkillsTextBox.TabIndex = 12
        '
        'ImageLabel
        '
        ImageLabel.AutoSize = True
        ImageLabel.BackColor = System.Drawing.Color.Transparent
        ImageLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ImageLabel.ForeColor = System.Drawing.Color.White
        ImageLabel.Location = New System.Drawing.Point(485, 43)
        ImageLabel.Name = "ImageLabel"
        ImageLabel.Size = New System.Drawing.Size(98, 17)
        ImageLabel.TabIndex = 13
        ImageLabel.Text = "Profile Image:"
        '
        'ImagePictureBox
        '
        Me.ImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.CandidateHeadBoyBindingSource, "Image", True))
        Me.ImagePictureBox.Location = New System.Drawing.Point(589, 43)
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
        Me.Button1.Location = New System.Drawing.Point(725, 202)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(528, 203)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(177, 20)
        Me.TextBox1.TabIndex = 16
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'HeadBoyConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(883, 553)
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
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Me.CandidateHeadBoyBindingNavigator)
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
    Friend WithEvents Number_of_GCSENumericUpDown As NumericUpDown
    Friend WithEvents Previously_part_of_school_house_council_CheckBox As CheckBox
    Friend WithEvents Personal_SkillsTextBox As TextBox
    Friend WithEvents ImagePictureBox As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
