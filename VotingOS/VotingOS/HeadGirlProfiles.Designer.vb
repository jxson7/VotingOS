<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HeadGirlProfiles
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Why_would_you_like_to_be_head_girl_Label As System.Windows.Forms.Label
        Dim What_changes_would_you_make_Label As System.Windows.Forms.Label
        Dim Number_of_GCSEsLabel As System.Windows.Forms.Label
        Dim Previously_Part_of_School_House_CouncilLabel As System.Windows.Forms.Label
        Dim Personal_SkillsLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HeadGirlProfiles))
        Me.DatabaseDataSet = New VotingOS.DatabaseDataSet()
        Me.CandidatesHeadGirlBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CandidatesHeadGirlTableAdapter = New VotingOS.DatabaseDataSetTableAdapters.CandidatesHeadGirlTableAdapter()
        Me.TableAdapterManager = New VotingOS.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.CandidatesHeadGirlBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Profile_ImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.First_NameLabel1 = New System.Windows.Forms.Label()
        Me.Last_NameLabel1 = New System.Windows.Forms.Label()
        Me.Why_would_you_like_to_be_head_girl_Label1 = New System.Windows.Forms.Label()
        Me.What_changes_would_you_make_Label1 = New System.Windows.Forms.Label()
        Me.Number_of_GCSEsLabel1 = New System.Windows.Forms.Label()
        Me.Previously_Part_of_School_House_CouncilCheckBox = New System.Windows.Forms.CheckBox()
        Me.Personal_SkillsLabel1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.IDLabel1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Why_would_you_like_to_be_head_girl_Label = New System.Windows.Forms.Label()
        What_changes_would_you_make_Label = New System.Windows.Forms.Label()
        Number_of_GCSEsLabel = New System.Windows.Forms.Label()
        Previously_Part_of_School_House_CouncilLabel = New System.Windows.Forms.Label()
        Personal_SkillsLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CandidatesHeadGirlBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CandidatesHeadGirlBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CandidatesHeadGirlBindingNavigator.SuspendLayout()
        CType(Me.Profile_ImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Why_would_you_like_to_be_head_girl_Label
        '
        Why_would_you_like_to_be_head_girl_Label.AutoSize = True
        Why_would_you_like_to_be_head_girl_Label.BackColor = System.Drawing.Color.Transparent
        Why_would_you_like_to_be_head_girl_Label.ForeColor = System.Drawing.Color.White
        Why_would_you_like_to_be_head_girl_Label.Location = New System.Drawing.Point(126, 303)
        Why_would_you_like_to_be_head_girl_Label.Name = "Why_would_you_like_to_be_head_girl_Label"
        Why_would_you_like_to_be_head_girl_Label.Size = New System.Drawing.Size(178, 13)
        Why_would_you_like_to_be_head_girl_Label.TabIndex = 4
        Why_would_you_like_to_be_head_girl_Label.Text = "Why would you like to be head girl?:"
        '
        'What_changes_would_you_make_Label
        '
        What_changes_would_you_make_Label.AutoSize = True
        What_changes_would_you_make_Label.BackColor = System.Drawing.Color.Transparent
        What_changes_would_you_make_Label.ForeColor = System.Drawing.Color.White
        What_changes_would_you_make_Label.Location = New System.Drawing.Point(140, 437)
        What_changes_would_you_make_Label.Name = "What_changes_would_you_make_Label"
        What_changes_would_you_make_Label.Size = New System.Drawing.Size(166, 13)
        What_changes_would_you_make_Label.TabIndex = 6
        What_changes_would_you_make_Label.Text = "What changes would you make?:"
        '
        'Number_of_GCSEsLabel
        '
        Number_of_GCSEsLabel.AutoSize = True
        Number_of_GCSEsLabel.BackColor = System.Drawing.Color.Transparent
        Number_of_GCSEsLabel.ForeColor = System.Drawing.Color.White
        Number_of_GCSEsLabel.Location = New System.Drawing.Point(208, 206)
        Number_of_GCSEsLabel.Name = "Number_of_GCSEsLabel"
        Number_of_GCSEsLabel.Size = New System.Drawing.Size(96, 13)
        Number_of_GCSEsLabel.TabIndex = 8
        Number_of_GCSEsLabel.Text = "Number of GCSEs:"
        '
        'Previously_Part_of_School_House_CouncilLabel
        '
        Previously_Part_of_School_House_CouncilLabel.AutoSize = True
        Previously_Part_of_School_House_CouncilLabel.BackColor = System.Drawing.Color.Transparent
        Previously_Part_of_School_House_CouncilLabel.ForeColor = System.Drawing.Color.White
        Previously_Part_of_School_House_CouncilLabel.Location = New System.Drawing.Point(161, 243)
        Previously_Part_of_School_House_CouncilLabel.Name = "Previously_Part_of_School_House_CouncilLabel"
        Previously_Part_of_School_House_CouncilLabel.Size = New System.Drawing.Size(176, 13)
        Previously_Part_of_School_House_CouncilLabel.TabIndex = 10
        Previously_Part_of_School_House_CouncilLabel.Text = "School/House Council Experience?"
        '
        'Personal_SkillsLabel
        '
        Personal_SkillsLabel.AutoSize = True
        Personal_SkillsLabel.BackColor = System.Drawing.Color.Transparent
        Personal_SkillsLabel.ForeColor = System.Drawing.Color.White
        Personal_SkillsLabel.Location = New System.Drawing.Point(226, 359)
        Personal_SkillsLabel.Name = "Personal_SkillsLabel"
        Personal_SkillsLabel.Size = New System.Drawing.Size(78, 13)
        Personal_SkillsLabel.TabIndex = 12
        Personal_SkillsLabel.Text = "Personal Skills:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.BackColor = System.Drawing.Color.Transparent
        IDLabel.ForeColor = System.Drawing.Color.White
        IDLabel.Location = New System.Drawing.Point(203, 175)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(98, 13)
        IDLabel.TabIndex = 16
        IDLabel.Text = "Candidate Number:"
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
        Me.CandidatesHeadGirlBindingNavigator.AddNewItem = Nothing
        Me.CandidatesHeadGirlBindingNavigator.BindingSource = Me.CandidatesHeadGirlBindingSource
        Me.CandidatesHeadGirlBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CandidatesHeadGirlBindingNavigator.DeleteItem = Nothing
        Me.CandidatesHeadGirlBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.CandidatesHeadGirlBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.CandidatesHeadGirlBindingNavigator.Location = New System.Drawing.Point(369, 132)
        Me.CandidatesHeadGirlBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CandidatesHeadGirlBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CandidatesHeadGirlBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CandidatesHeadGirlBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CandidatesHeadGirlBindingNavigator.Name = "CandidatesHeadGirlBindingNavigator"
        Me.CandidatesHeadGirlBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CandidatesHeadGirlBindingNavigator.Size = New System.Drawing.Size(209, 25)
        Me.CandidatesHeadGirlBindingNavigator.TabIndex = 0
        Me.CandidatesHeadGirlBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'Profile_ImagePictureBox
        '
        Me.Profile_ImagePictureBox.BackColor = System.Drawing.Color.Transparent
        Me.Profile_ImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.CandidatesHeadGirlBindingSource, "Profile Image", True))
        Me.Profile_ImagePictureBox.Location = New System.Drawing.Point(646, 170)
        Me.Profile_ImagePictureBox.Name = "Profile_ImagePictureBox"
        Me.Profile_ImagePictureBox.Size = New System.Drawing.Size(100, 138)
        Me.Profile_ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Profile_ImagePictureBox.TabIndex = 2
        Me.Profile_ImagePictureBox.TabStop = False
        '
        'First_NameLabel1
        '
        Me.First_NameLabel1.BackColor = System.Drawing.Color.White
        Me.First_NameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.First_NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "First Name", True))
        Me.First_NameLabel1.ForeColor = System.Drawing.Color.Black
        Me.First_NameLabel1.Location = New System.Drawing.Point(593, 314)
        Me.First_NameLabel1.Name = "First_NameLabel1"
        Me.First_NameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.First_NameLabel1.TabIndex = 3
        '
        'Last_NameLabel1
        '
        Me.Last_NameLabel1.BackColor = System.Drawing.Color.White
        Me.Last_NameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Last_NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "Last Name", True))
        Me.Last_NameLabel1.ForeColor = System.Drawing.Color.Black
        Me.Last_NameLabel1.Location = New System.Drawing.Point(699, 314)
        Me.Last_NameLabel1.Name = "Last_NameLabel1"
        Me.Last_NameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Last_NameLabel1.TabIndex = 4
        '
        'Why_would_you_like_to_be_head_girl_Label1
        '
        Me.Why_would_you_like_to_be_head_girl_Label1.BackColor = System.Drawing.Color.White
        Me.Why_would_you_like_to_be_head_girl_Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Why_would_you_like_to_be_head_girl_Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "Why would you like to be head girl?", True))
        Me.Why_would_you_like_to_be_head_girl_Label1.ForeColor = System.Drawing.Color.Black
        Me.Why_would_you_like_to_be_head_girl_Label1.Location = New System.Drawing.Point(310, 303)
        Me.Why_would_you_like_to_be_head_girl_Label1.Name = "Why_would_you_like_to_be_head_girl_Label1"
        Me.Why_would_you_like_to_be_head_girl_Label1.Size = New System.Drawing.Size(270, 45)
        Me.Why_would_you_like_to_be_head_girl_Label1.TabIndex = 5
        '
        'What_changes_would_you_make_Label1
        '
        Me.What_changes_would_you_make_Label1.BackColor = System.Drawing.Color.White
        Me.What_changes_would_you_make_Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.What_changes_would_you_make_Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "What changes would you make?", True))
        Me.What_changes_would_you_make_Label1.ForeColor = System.Drawing.Color.Black
        Me.What_changes_would_you_make_Label1.Location = New System.Drawing.Point(310, 430)
        Me.What_changes_would_you_make_Label1.Name = "What_changes_would_you_make_Label1"
        Me.What_changes_would_you_make_Label1.Size = New System.Drawing.Size(272, 48)
        Me.What_changes_would_you_make_Label1.TabIndex = 7
        '
        'Number_of_GCSEsLabel1
        '
        Me.Number_of_GCSEsLabel1.BackColor = System.Drawing.Color.White
        Me.Number_of_GCSEsLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Number_of_GCSEsLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "Number of GCSEs", True))
        Me.Number_of_GCSEsLabel1.ForeColor = System.Drawing.Color.Black
        Me.Number_of_GCSEsLabel1.Location = New System.Drawing.Point(310, 206)
        Me.Number_of_GCSEsLabel1.Name = "Number_of_GCSEsLabel1"
        Me.Number_of_GCSEsLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Number_of_GCSEsLabel1.TabIndex = 9
        '
        'Previously_Part_of_School_House_CouncilCheckBox
        '
        Me.Previously_Part_of_School_House_CouncilCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.Previously_Part_of_School_House_CouncilCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CandidatesHeadGirlBindingSource, "Previously Part of School/House Council", True))
        Me.Previously_Part_of_School_House_CouncilCheckBox.Enabled = False
        Me.Previously_Part_of_School_House_CouncilCheckBox.Location = New System.Drawing.Point(369, 238)
        Me.Previously_Part_of_School_House_CouncilCheckBox.Name = "Previously_Part_of_School_House_CouncilCheckBox"
        Me.Previously_Part_of_School_House_CouncilCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Previously_Part_of_School_House_CouncilCheckBox.TabIndex = 11
        Me.Previously_Part_of_School_House_CouncilCheckBox.UseVisualStyleBackColor = False
        '
        'Personal_SkillsLabel1
        '
        Me.Personal_SkillsLabel1.BackColor = System.Drawing.Color.White
        Me.Personal_SkillsLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Personal_SkillsLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "Personal Skills", True))
        Me.Personal_SkillsLabel1.ForeColor = System.Drawing.Color.Black
        Me.Personal_SkillsLabel1.Location = New System.Drawing.Point(310, 359)
        Me.Personal_SkillsLabel1.Name = "Personal_SkillsLabel1"
        Me.Personal_SkillsLabel1.Size = New System.Drawing.Size(271, 57)
        Me.Personal_SkillsLabel1.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(637, 451)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 30)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "View Head Boy Profiles"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(637, 484)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 31)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Cast Your Final Vote"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'IDLabel1
        '
        Me.IDLabel1.BackColor = System.Drawing.Color.White
        Me.IDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "ID", True))
        Me.IDLabel1.ForeColor = System.Drawing.Color.Black
        Me.IDLabel1.Location = New System.Drawing.Point(310, 170)
        Me.IDLabel1.Name = "IDLabel1"
        Me.IDLabel1.Size = New System.Drawing.Size(33, 23)
        Me.IDLabel1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(396, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 21)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Head Girl Candidates"
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
        Me.PictureBox1.TabIndex = 25
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
        Me.PictureBox3.TabIndex = 24
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
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'HeadGirlProfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(901, 567)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CandidatesHeadGirlBindingNavigator)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDLabel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Personal_SkillsLabel)
        Me.Controls.Add(Me.Personal_SkillsLabel1)
        Me.Controls.Add(Previously_Part_of_School_House_CouncilLabel)
        Me.Controls.Add(Me.Previously_Part_of_School_House_CouncilCheckBox)
        Me.Controls.Add(Number_of_GCSEsLabel)
        Me.Controls.Add(Me.Number_of_GCSEsLabel1)
        Me.Controls.Add(What_changes_would_you_make_Label)
        Me.Controls.Add(Me.What_changes_would_you_make_Label1)
        Me.Controls.Add(Why_would_you_like_to_be_head_girl_Label)
        Me.Controls.Add(Me.Why_would_you_like_to_be_head_girl_Label1)
        Me.Controls.Add(Me.Last_NameLabel1)
        Me.Controls.Add(Me.First_NameLabel1)
        Me.Controls.Add(Me.Profile_ImagePictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HeadGirlProfiles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HeadGirlProfiles"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CandidatesHeadGirlBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CandidatesHeadGirlBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CandidatesHeadGirlBindingNavigator.ResumeLayout(False)
        Me.CandidatesHeadGirlBindingNavigator.PerformLayout()
        CType(Me.Profile_ImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents CandidatesHeadGirlBindingSource As BindingSource
    Friend WithEvents CandidatesHeadGirlTableAdapter As DatabaseDataSetTableAdapters.CandidatesHeadGirlTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CandidatesHeadGirlBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Profile_ImagePictureBox As PictureBox
    Friend WithEvents First_NameLabel1 As Label
    Friend WithEvents Last_NameLabel1 As Label
    Friend WithEvents Why_would_you_like_to_be_head_girl_Label1 As Label
    Friend WithEvents What_changes_would_you_make_Label1 As Label
    Friend WithEvents Number_of_GCSEsLabel1 As Label
    Friend WithEvents Previously_Part_of_School_House_CouncilCheckBox As CheckBox
    Friend WithEvents Personal_SkillsLabel1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents IDLabel1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
