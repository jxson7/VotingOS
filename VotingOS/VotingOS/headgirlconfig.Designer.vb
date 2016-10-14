<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class headgirlconfig
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
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim Number_of_GCSEsLabel As System.Windows.Forms.Label
        Dim Previously_Part_of_School_House_CouncilLabel As System.Windows.Forms.Label
        Dim Profile_ImageLabel As System.Windows.Forms.Label
        Dim Why_would_you_like_to_be_head_girl_Label As System.Windows.Forms.Label
        Dim Why_would_you_like_to_be_head_girl_Label1 As System.Windows.Forms.Label
        Dim Personal_SkillsLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(headgirlconfig))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CandidatesHeadGirlDataSet = New VotingOS.CandidatesHeadGirlDataSet()
        Me.CandidatesHeadGirlBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CandidatesHeadGirlTableAdapter = New VotingOS.CandidatesHeadGirlDataSetTableAdapters.CandidatesHeadGirlTableAdapter()
        Me.TableAdapterManager = New VotingOS.CandidatesHeadGirlDataSetTableAdapters.TableAdapterManager()
        Me.CandidatesHeadGirlBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CandidatesHeadGirlBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Number_of_GCSEsTextBox = New System.Windows.Forms.TextBox()
        Me.Previously_Part_of_School_House_CouncilCheckBox = New System.Windows.Forms.CheckBox()
        Me.Profile_ImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Why_would_you_like_to_be_head_girl_TextBox = New System.Windows.Forms.TextBox()
        Me.Why_would_you_like_to_be_head_girl_TextBox1 = New System.Windows.Forms.TextBox()
        Me.Personal_SkillsTextBox = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        Number_of_GCSEsLabel = New System.Windows.Forms.Label()
        Previously_Part_of_School_House_CouncilLabel = New System.Windows.Forms.Label()
        Profile_ImageLabel = New System.Windows.Forms.Label()
        Why_would_you_like_to_be_head_girl_Label = New System.Windows.Forms.Label()
        Why_would_you_like_to_be_head_girl_Label1 = New System.Windows.Forms.Label()
        Personal_SkillsLabel = New System.Windows.Forms.Label()
        CType(Me.CandidatesHeadGirlDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CandidatesHeadGirlBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CandidatesHeadGirlBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CandidatesHeadGirlBindingNavigator.SuspendLayout()
        CType(Me.Profile_ImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.BackColor = System.Drawing.Color.Transparent
        FirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstNameLabel.ForeColor = System.Drawing.Color.White
        FirstNameLabel.Location = New System.Drawing.Point(77, 161)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 20
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.BackColor = System.Drawing.Color.Transparent
        LastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastNameLabel.ForeColor = System.Drawing.Color.White
        LastNameLabel.Location = New System.Drawing.Point(76, 187)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 21
        LastNameLabel.Text = "Last Name:"
        '
        'Number_of_GCSEsLabel
        '
        Number_of_GCSEsLabel.AutoSize = True
        Number_of_GCSEsLabel.BackColor = System.Drawing.Color.Transparent
        Number_of_GCSEsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Number_of_GCSEsLabel.ForeColor = System.Drawing.Color.White
        Number_of_GCSEsLabel.Location = New System.Drawing.Point(41, 213)
        Number_of_GCSEsLabel.Name = "Number_of_GCSEsLabel"
        Number_of_GCSEsLabel.Size = New System.Drawing.Size(96, 13)
        Number_of_GCSEsLabel.TabIndex = 22
        Number_of_GCSEsLabel.Text = "Number of GCSEs:"
        '
        'Previously_Part_of_School_House_CouncilLabel
        '
        Previously_Part_of_School_House_CouncilLabel.AutoSize = True
        Previously_Part_of_School_House_CouncilLabel.BackColor = System.Drawing.Color.Transparent
        Previously_Part_of_School_House_CouncilLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Previously_Part_of_School_House_CouncilLabel.ForeColor = System.Drawing.Color.White
        Previously_Part_of_School_House_CouncilLabel.Location = New System.Drawing.Point(8, 241)
        Previously_Part_of_School_House_CouncilLabel.Name = "Previously_Part_of_School_House_CouncilLabel"
        Previously_Part_of_School_House_CouncilLabel.Size = New System.Drawing.Size(202, 13)
        Previously_Part_of_School_House_CouncilLabel.TabIndex = 23
        Previously_Part_of_School_House_CouncilLabel.Text = "Previously Part of School/House Council:"
        '
        'Profile_ImageLabel
        '
        Profile_ImageLabel.AutoSize = True
        Profile_ImageLabel.BackColor = System.Drawing.Color.Transparent
        Profile_ImageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Profile_ImageLabel.ForeColor = System.Drawing.Color.White
        Profile_ImageLabel.Location = New System.Drawing.Point(404, 60)
        Profile_ImageLabel.Name = "Profile_ImageLabel"
        Profile_ImageLabel.Size = New System.Drawing.Size(71, 13)
        Profile_ImageLabel.TabIndex = 24
        Profile_ImageLabel.Text = "Profile Image:"
        '
        'Why_would_you_like_to_be_head_girl_Label
        '
        Why_would_you_like_to_be_head_girl_Label.AutoSize = True
        Why_would_you_like_to_be_head_girl_Label.BackColor = System.Drawing.Color.Transparent
        Why_would_you_like_to_be_head_girl_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Why_would_you_like_to_be_head_girl_Label.ForeColor = System.Drawing.Color.White
        Why_would_you_like_to_be_head_girl_Label.Location = New System.Drawing.Point(36, 304)
        Why_would_you_like_to_be_head_girl_Label.Name = "Why_would_you_like_to_be_head_girl_Label"
        Why_would_you_like_to_be_head_girl_Label.Size = New System.Drawing.Size(179, 13)
        Why_would_you_like_to_be_head_girl_Label.TabIndex = 30
        Why_would_you_like_to_be_head_girl_Label.Text = "Why would you like to be Head Girl?"
        '
        'Why_would_you_like_to_be_head_girl_Label1
        '
        Why_would_you_like_to_be_head_girl_Label1.AutoSize = True
        Why_would_you_like_to_be_head_girl_Label1.BackColor = System.Drawing.Color.Transparent
        Why_would_you_like_to_be_head_girl_Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Why_would_you_like_to_be_head_girl_Label1.ForeColor = System.Drawing.Color.White
        Why_would_you_like_to_be_head_girl_Label1.Location = New System.Drawing.Point(36, 408)
        Why_would_you_like_to_be_head_girl_Label1.Name = "Why_would_you_like_to_be_head_girl_Label1"
        Why_would_you_like_to_be_head_girl_Label1.Size = New System.Drawing.Size(175, 13)
        Why_would_you_like_to_be_head_girl_Label1.TabIndex = 31
        Why_would_you_like_to_be_head_girl_Label1.Text = "Why would you like to be head girl?"
        '
        'Personal_SkillsLabel
        '
        Personal_SkillsLabel.AutoSize = True
        Personal_SkillsLabel.BackColor = System.Drawing.Color.Transparent
        Personal_SkillsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Personal_SkillsLabel.ForeColor = System.Drawing.Color.White
        Personal_SkillsLabel.Location = New System.Drawing.Point(136, 504)
        Personal_SkillsLabel.Name = "Personal_SkillsLabel"
        Personal_SkillsLabel.Size = New System.Drawing.Size(78, 13)
        Personal_SkillsLabel.TabIndex = 32
        Personal_SkillsLabel.Text = "Personal Skills:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(35, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 38)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "VotingOS"
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
        Me.CandidatesHeadGirlBindingNavigator.Size = New System.Drawing.Size(817, 25)
        Me.CandidatesHeadGirlBindingNavigator.TabIndex = 20
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
        'CandidatesHeadGirlBindingNavigatorSaveItem
        '
        Me.CandidatesHeadGirlBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CandidatesHeadGirlBindingNavigatorSaveItem.Image = CType(resources.GetObject("CandidatesHeadGirlBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CandidatesHeadGirlBindingNavigatorSaveItem.Name = "CandidatesHeadGirlBindingNavigatorSaveItem"
        Me.CandidatesHeadGirlBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CandidatesHeadGirlBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(143, 158)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox.TabIndex = 21
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(143, 184)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTextBox.TabIndex = 22
        '
        'Number_of_GCSEsTextBox
        '
        Me.Number_of_GCSEsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "Number of GCSEs", True))
        Me.Number_of_GCSEsTextBox.Location = New System.Drawing.Point(143, 210)
        Me.Number_of_GCSEsTextBox.Name = "Number_of_GCSEsTextBox"
        Me.Number_of_GCSEsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Number_of_GCSEsTextBox.TabIndex = 23
        '
        'Previously_Part_of_School_House_CouncilCheckBox
        '
        Me.Previously_Part_of_School_House_CouncilCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.Previously_Part_of_School_House_CouncilCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CandidatesHeadGirlBindingSource, "Previously Part of School/House Council", True))
        Me.Previously_Part_of_School_House_CouncilCheckBox.Location = New System.Drawing.Point(216, 236)
        Me.Previously_Part_of_School_House_CouncilCheckBox.Name = "Previously_Part_of_School_House_CouncilCheckBox"
        Me.Previously_Part_of_School_House_CouncilCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Previously_Part_of_School_House_CouncilCheckBox.TabIndex = 24
        Me.Previously_Part_of_School_House_CouncilCheckBox.UseVisualStyleBackColor = False
        '
        'Profile_ImagePictureBox
        '
        Me.Profile_ImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.CandidatesHeadGirlBindingSource, "Profile Image", True))
        Me.Profile_ImagePictureBox.Location = New System.Drawing.Point(481, 60)
        Me.Profile_ImagePictureBox.Name = "Profile_ImagePictureBox"
        Me.Profile_ImagePictureBox.Size = New System.Drawing.Size(119, 140)
        Me.Profile_ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Profile_ImagePictureBox.TabIndex = 25
        Me.Profile_ImagePictureBox.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(549, 210)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 32)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "Browse"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(352, 217)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(182, 20)
        Me.TextBox1.TabIndex = 29
        Me.TextBox1.Visible = False
        '
        'Why_would_you_like_to_be_head_girl_TextBox
        '
        Me.Why_would_you_like_to_be_head_girl_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "Why would you like to be head girl?", True))
        Me.Why_would_you_like_to_be_head_girl_TextBox.Location = New System.Drawing.Point(220, 301)
        Me.Why_would_you_like_to_be_head_girl_TextBox.Multiline = True
        Me.Why_would_you_like_to_be_head_girl_TextBox.Name = "Why_would_you_like_to_be_head_girl_TextBox"
        Me.Why_would_you_like_to_be_head_girl_TextBox.Size = New System.Drawing.Size(446, 88)
        Me.Why_would_you_like_to_be_head_girl_TextBox.TabIndex = 31
        '
        'Why_would_you_like_to_be_head_girl_TextBox1
        '
        Me.Why_would_you_like_to_be_head_girl_TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "Why would you like to be head girl?", True))
        Me.Why_would_you_like_to_be_head_girl_TextBox1.Location = New System.Drawing.Point(220, 405)
        Me.Why_would_you_like_to_be_head_girl_TextBox1.Multiline = True
        Me.Why_would_you_like_to_be_head_girl_TextBox1.Name = "Why_would_you_like_to_be_head_girl_TextBox1"
        Me.Why_would_you_like_to_be_head_girl_TextBox1.Size = New System.Drawing.Size(446, 74)
        Me.Why_would_you_like_to_be_head_girl_TextBox1.TabIndex = 32
        '
        'Personal_SkillsTextBox
        '
        Me.Personal_SkillsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "Personal Skills", True))
        Me.Personal_SkillsTextBox.Location = New System.Drawing.Point(220, 501)
        Me.Personal_SkillsTextBox.Multiline = True
        Me.Personal_SkillsTextBox.Name = "Personal_SkillsTextBox"
        Me.Personal_SkillsTextBox.Size = New System.Drawing.Size(446, 62)
        Me.Personal_SkillsTextBox.TabIndex = 33
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'headgirlconfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(817, 575)
        Me.Controls.Add(Personal_SkillsLabel)
        Me.Controls.Add(Me.Personal_SkillsTextBox)
        Me.Controls.Add(Why_would_you_like_to_be_head_girl_Label1)
        Me.Controls.Add(Me.Why_would_you_like_to_be_head_girl_TextBox1)
        Me.Controls.Add(Why_would_you_like_to_be_head_girl_Label)
        Me.Controls.Add(Me.Why_would_you_like_to_be_head_girl_TextBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Profile_ImageLabel)
        Me.Controls.Add(Me.Profile_ImagePictureBox)
        Me.Controls.Add(Previously_Part_of_School_House_CouncilLabel)
        Me.Controls.Add(Me.Previously_Part_of_School_House_CouncilCheckBox)
        Me.Controls.Add(Number_of_GCSEsLabel)
        Me.Controls.Add(Me.Number_of_GCSEsTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.CandidatesHeadGirlBindingNavigator)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "headgirlconfig"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Head Girl Configurations"
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
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents Number_of_GCSEsTextBox As TextBox
    Friend WithEvents Previously_Part_of_School_House_CouncilCheckBox As CheckBox
    Friend WithEvents Profile_ImagePictureBox As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Why_would_you_like_to_be_head_girl_TextBox As TextBox
    Friend WithEvents Why_would_you_like_to_be_head_girl_TextBox1 As TextBox
    Friend WithEvents Personal_SkillsTextBox As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
