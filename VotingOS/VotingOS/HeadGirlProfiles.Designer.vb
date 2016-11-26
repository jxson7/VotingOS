<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HeadGirlProfiles
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
        Me.SuspendLayout()
        '
        'Why_would_you_like_to_be_head_girl_Label
        '
        Why_would_you_like_to_be_head_girl_Label.AutoSize = True
        Why_would_you_like_to_be_head_girl_Label.ForeColor = System.Drawing.Color.White
        Why_would_you_like_to_be_head_girl_Label.Location = New System.Drawing.Point(217, 53)
        Why_would_you_like_to_be_head_girl_Label.Name = "Why_would_you_like_to_be_head_girl_Label"
        Why_would_you_like_to_be_head_girl_Label.Size = New System.Drawing.Size(178, 13)
        Why_would_you_like_to_be_head_girl_Label.TabIndex = 4
        Why_would_you_like_to_be_head_girl_Label.Text = "Why would you like to be head girl?:"
        '
        'What_changes_would_you_make_Label
        '
        What_changes_would_you_make_Label.AutoSize = True
        What_changes_would_you_make_Label.ForeColor = System.Drawing.Color.White
        What_changes_would_you_make_Label.Location = New System.Drawing.Point(226, 153)
        What_changes_would_you_make_Label.Name = "What_changes_would_you_make_Label"
        What_changes_would_you_make_Label.Size = New System.Drawing.Size(166, 13)
        What_changes_would_you_make_Label.TabIndex = 6
        What_changes_would_you_make_Label.Text = "What changes would you make?:"
        '
        'Number_of_GCSEsLabel
        '
        Number_of_GCSEsLabel.AutoSize = True
        Number_of_GCSEsLabel.ForeColor = System.Drawing.Color.White
        Number_of_GCSEsLabel.Location = New System.Drawing.Point(16, 257)
        Number_of_GCSEsLabel.Name = "Number_of_GCSEsLabel"
        Number_of_GCSEsLabel.Size = New System.Drawing.Size(96, 13)
        Number_of_GCSEsLabel.TabIndex = 8
        Number_of_GCSEsLabel.Text = "Number of GCSEs:"
        '
        'Previously_Part_of_School_House_CouncilLabel
        '
        Previously_Part_of_School_House_CouncilLabel.AutoSize = True
        Previously_Part_of_School_House_CouncilLabel.ForeColor = System.Drawing.Color.White
        Previously_Part_of_School_House_CouncilLabel.Location = New System.Drawing.Point(265, 262)
        Previously_Part_of_School_House_CouncilLabel.Name = "Previously_Part_of_School_House_CouncilLabel"
        Previously_Part_of_School_House_CouncilLabel.Size = New System.Drawing.Size(202, 13)
        Previously_Part_of_School_House_CouncilLabel.TabIndex = 10
        Previously_Part_of_School_House_CouncilLabel.Text = "Previously Part of School/House Council:"
        '
        'Personal_SkillsLabel
        '
        Personal_SkillsLabel.AutoSize = True
        Personal_SkillsLabel.ForeColor = System.Drawing.Color.White
        Personal_SkillsLabel.Location = New System.Drawing.Point(133, 311)
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
        IDLabel.Location = New System.Drawing.Point(29, 37)
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
        Me.CandidatesHeadGirlBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.CandidatesHeadGirlBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CandidatesHeadGirlBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CandidatesHeadGirlBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CandidatesHeadGirlBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CandidatesHeadGirlBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CandidatesHeadGirlBindingNavigator.Name = "CandidatesHeadGirlBindingNavigator"
        Me.CandidatesHeadGirlBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CandidatesHeadGirlBindingNavigator.Size = New System.Drawing.Size(847, 25)
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
        Me.Profile_ImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.CandidatesHeadGirlBindingSource, "Profile Image", True))
        Me.Profile_ImagePictureBox.Location = New System.Drawing.Point(65, 61)
        Me.Profile_ImagePictureBox.Name = "Profile_ImagePictureBox"
        Me.Profile_ImagePictureBox.Size = New System.Drawing.Size(100, 138)
        Me.Profile_ImagePictureBox.TabIndex = 2
        Me.Profile_ImagePictureBox.TabStop = False
        '
        'First_NameLabel1
        '
        Me.First_NameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.First_NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "First Name", True))
        Me.First_NameLabel1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.First_NameLabel1.Location = New System.Drawing.Point(12, 205)
        Me.First_NameLabel1.Name = "First_NameLabel1"
        Me.First_NameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.First_NameLabel1.TabIndex = 3
        '
        'Last_NameLabel1
        '
        Me.Last_NameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Last_NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "Last Name", True))
        Me.Last_NameLabel1.Location = New System.Drawing.Point(118, 205)
        Me.Last_NameLabel1.Name = "Last_NameLabel1"
        Me.Last_NameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Last_NameLabel1.TabIndex = 4
        '
        'Why_would_you_like_to_be_head_girl_Label1
        '
        Me.Why_would_you_like_to_be_head_girl_Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Why_would_you_like_to_be_head_girl_Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "Why would you like to be head girl?", True))
        Me.Why_would_you_like_to_be_head_girl_Label1.Location = New System.Drawing.Point(401, 53)
        Me.Why_would_you_like_to_be_head_girl_Label1.Name = "Why_would_you_like_to_be_head_girl_Label1"
        Me.Why_would_you_like_to_be_head_girl_Label1.Size = New System.Drawing.Size(267, 79)
        Me.Why_would_you_like_to_be_head_girl_Label1.TabIndex = 5
        '
        'What_changes_would_you_make_Label1
        '
        Me.What_changes_would_you_make_Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.What_changes_would_you_make_Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "What changes would you make?", True))
        Me.What_changes_would_you_make_Label1.Location = New System.Drawing.Point(398, 153)
        Me.What_changes_would_you_make_Label1.Name = "What_changes_would_you_make_Label1"
        Me.What_changes_would_you_make_Label1.Size = New System.Drawing.Size(270, 75)
        Me.What_changes_would_you_make_Label1.TabIndex = 7
        '
        'Number_of_GCSEsLabel1
        '
        Me.Number_of_GCSEsLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Number_of_GCSEsLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "Number of GCSEs", True))
        Me.Number_of_GCSEsLabel1.Location = New System.Drawing.Point(118, 257)
        Me.Number_of_GCSEsLabel1.Name = "Number_of_GCSEsLabel1"
        Me.Number_of_GCSEsLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Number_of_GCSEsLabel1.TabIndex = 9
        '
        'Previously_Part_of_School_House_CouncilCheckBox
        '
        Me.Previously_Part_of_School_House_CouncilCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CandidatesHeadGirlBindingSource, "Previously Part of School/House Council", True))
        Me.Previously_Part_of_School_House_CouncilCheckBox.Enabled = False
        Me.Previously_Part_of_School_House_CouncilCheckBox.Location = New System.Drawing.Point(473, 257)
        Me.Previously_Part_of_School_House_CouncilCheckBox.Name = "Previously_Part_of_School_House_CouncilCheckBox"
        Me.Previously_Part_of_School_House_CouncilCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Previously_Part_of_School_House_CouncilCheckBox.TabIndex = 11
        Me.Previously_Part_of_School_House_CouncilCheckBox.UseVisualStyleBackColor = True
        '
        'Personal_SkillsLabel1
        '
        Me.Personal_SkillsLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Personal_SkillsLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "Personal Skills", True))
        Me.Personal_SkillsLabel1.Location = New System.Drawing.Point(217, 311)
        Me.Personal_SkillsLabel1.Name = "Personal_SkillsLabel1"
        Me.Personal_SkillsLabel1.Size = New System.Drawing.Size(451, 97)
        Me.Personal_SkillsLabel1.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(679, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 26)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "View Head Boy Profiles"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(679, 364)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 31)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Cast Your Final Vote"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'IDLabel1
        '
        Me.IDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidatesHeadGirlBindingSource, "ID", True))
        Me.IDLabel1.Location = New System.Drawing.Point(136, 32)
        Me.IDLabel1.Name = "IDLabel1"
        Me.IDLabel1.Size = New System.Drawing.Size(33, 23)
        Me.IDLabel1.TabIndex = 17
        '
        'HeadGirlProfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(847, 433)
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
        Me.Controls.Add(Me.CandidatesHeadGirlBindingNavigator)
        Me.Name = "HeadGirlProfiles"
        Me.Text = "HeadGirlProfiles"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CandidatesHeadGirlBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CandidatesHeadGirlBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CandidatesHeadGirlBindingNavigator.ResumeLayout(False)
        Me.CandidatesHeadGirlBindingNavigator.PerformLayout()
        CType(Me.Profile_ImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
