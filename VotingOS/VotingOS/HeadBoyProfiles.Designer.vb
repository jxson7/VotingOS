<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HeadBoyProfiles
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
        Dim Why_would_you_like_to_be_head_boy_girl_Label As System.Windows.Forms.Label
        Dim What_changes_would_you_make_Label As System.Windows.Forms.Label
        Dim Number_of_GCSELabel As System.Windows.Forms.Label
        Dim Previously_part_of_school_house_council_Label As System.Windows.Forms.Label
        Dim Personal_SkillsLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HeadBoyProfiles))
        Me.DatabaseDataSet = New VotingOS.DatabaseDataSet()
        Me.CandidateHeadBoyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CandidateHeadBoyTableAdapter = New VotingOS.DatabaseDataSetTableAdapters.CandidateHeadBoyTableAdapter()
        Me.TableAdapterManager = New VotingOS.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.CandidateHeadBoyBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.First_NameLabel1 = New System.Windows.Forms.Label()
        Me.Last_NameLabel1 = New System.Windows.Forms.Label()
        Me.Why_would_you_like_to_be_head_boy_girl_Label1 = New System.Windows.Forms.Label()
        Me.What_changes_would_you_make_Label1 = New System.Windows.Forms.Label()
        Me.Number_of_GCSELabel1 = New System.Windows.Forms.Label()
        Me.Previously_part_of_school_house_council_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Personal_SkillsLabel1 = New System.Windows.Forms.Label()
        Me.ImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Why_would_you_like_to_be_head_boy_girl_Label = New System.Windows.Forms.Label()
        What_changes_would_you_make_Label = New System.Windows.Forms.Label()
        Number_of_GCSELabel = New System.Windows.Forms.Label()
        Previously_part_of_school_house_council_Label = New System.Windows.Forms.Label()
        Personal_SkillsLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CandidateHeadBoyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CandidateHeadBoyBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CandidateHeadBoyBindingNavigator.SuspendLayout()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Why_would_you_like_to_be_head_boy_girl_Label
        '
        Why_would_you_like_to_be_head_boy_girl_Label.AutoSize = True
        Why_would_you_like_to_be_head_boy_girl_Label.ForeColor = System.Drawing.Color.White
        Why_would_you_like_to_be_head_boy_girl_Label.Location = New System.Drawing.Point(273, 46)
        Why_would_you_like_to_be_head_boy_girl_Label.Name = "Why_would_you_like_to_be_head_boy_girl_Label"
        Why_would_you_like_to_be_head_boy_girl_Label.Size = New System.Drawing.Size(182, 13)
        Why_would_you_like_to_be_head_boy_girl_Label.TabIndex = 5
        Why_would_you_like_to_be_head_boy_girl_Label.Text = "Why would you like to be head boy?:"
        '
        'What_changes_would_you_make_Label
        '
        What_changes_would_you_make_Label.AutoSize = True
        What_changes_would_you_make_Label.ForeColor = System.Drawing.Color.White
        What_changes_would_you_make_Label.Location = New System.Drawing.Point(289, 140)
        What_changes_would_you_make_Label.Name = "What_changes_would_you_make_Label"
        What_changes_would_you_make_Label.Size = New System.Drawing.Size(166, 13)
        What_changes_would_you_make_Label.TabIndex = 7
        What_changes_would_you_make_Label.Text = "What changes would you make?:"
        '
        'Number_of_GCSELabel
        '
        Number_of_GCSELabel.AutoSize = True
        Number_of_GCSELabel.ForeColor = System.Drawing.Color.White
        Number_of_GCSELabel.Location = New System.Drawing.Point(21, 236)
        Number_of_GCSELabel.Name = "Number_of_GCSELabel"
        Number_of_GCSELabel.Size = New System.Drawing.Size(91, 13)
        Number_of_GCSELabel.TabIndex = 9
        Number_of_GCSELabel.Text = "Number of GCSE:"
        '
        'Previously_part_of_school_house_council_Label
        '
        Previously_part_of_school_house_council_Label.AutoSize = True
        Previously_part_of_school_house_council_Label.ForeColor = System.Drawing.Color.White
        Previously_part_of_school_house_council_Label.Location = New System.Drawing.Point(253, 241)
        Previously_part_of_school_house_council_Label.Name = "Previously_part_of_school_house_council_Label"
        Previously_part_of_school_house_council_Label.Size = New System.Drawing.Size(202, 13)
        Previously_part_of_school_house_council_Label.TabIndex = 11
        Previously_part_of_school_house_council_Label.Text = "Previously part of school/house council?:"
        '
        'Personal_SkillsLabel
        '
        Personal_SkillsLabel.AutoSize = True
        Personal_SkillsLabel.ForeColor = System.Drawing.Color.White
        Personal_SkillsLabel.Location = New System.Drawing.Point(34, 293)
        Personal_SkillsLabel.Name = "Personal_SkillsLabel"
        Personal_SkillsLabel.Size = New System.Drawing.Size(78, 13)
        Personal_SkillsLabel.TabIndex = 13
        Personal_SkillsLabel.Text = "Personal Skills:"
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
        Me.CandidateHeadBoyBindingNavigator.AddNewItem = Nothing
        Me.CandidateHeadBoyBindingNavigator.BindingSource = Me.CandidateHeadBoyBindingSource
        Me.CandidateHeadBoyBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CandidateHeadBoyBindingNavigator.DeleteItem = Nothing
        Me.CandidateHeadBoyBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.CandidateHeadBoyBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CandidateHeadBoyBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CandidateHeadBoyBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CandidateHeadBoyBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CandidateHeadBoyBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CandidateHeadBoyBindingNavigator.Name = "CandidateHeadBoyBindingNavigator"
        Me.CandidateHeadBoyBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CandidateHeadBoyBindingNavigator.Size = New System.Drawing.Size(866, 25)
        Me.CandidateHeadBoyBindingNavigator.TabIndex = 0
        Me.CandidateHeadBoyBindingNavigator.Text = "BindingNavigator1"
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
        'First_NameLabel1
        '
        Me.First_NameLabel1.BackColor = System.Drawing.Color.Transparent
        Me.First_NameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.First_NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidateHeadBoyBindingSource, "First Name", True))
        Me.First_NameLabel1.ForeColor = System.Drawing.Color.White
        Me.First_NameLabel1.Location = New System.Drawing.Point(12, 190)
        Me.First_NameLabel1.Name = "First_NameLabel1"
        Me.First_NameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.First_NameLabel1.TabIndex = 2
        '
        'Last_NameLabel1
        '
        Me.Last_NameLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Last_NameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Last_NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidateHeadBoyBindingSource, "Last Name", True))
        Me.Last_NameLabel1.ForeColor = System.Drawing.Color.White
        Me.Last_NameLabel1.Location = New System.Drawing.Point(118, 190)
        Me.Last_NameLabel1.Name = "Last_NameLabel1"
        Me.Last_NameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Last_NameLabel1.TabIndex = 4
        '
        'Why_would_you_like_to_be_head_boy_girl_Label1
        '
        Me.Why_would_you_like_to_be_head_boy_girl_Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Why_would_you_like_to_be_head_boy_girl_Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Why_would_you_like_to_be_head_boy_girl_Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidateHeadBoyBindingSource, "Why would you like to be head boy/girl?", True))
        Me.Why_would_you_like_to_be_head_boy_girl_Label1.ForeColor = System.Drawing.Color.White
        Me.Why_would_you_like_to_be_head_boy_girl_Label1.Location = New System.Drawing.Point(461, 46)
        Me.Why_would_you_like_to_be_head_boy_girl_Label1.Name = "Why_would_you_like_to_be_head_boy_girl_Label1"
        Me.Why_would_you_like_to_be_head_boy_girl_Label1.Size = New System.Drawing.Size(238, 75)
        Me.Why_would_you_like_to_be_head_boy_girl_Label1.TabIndex = 6
        '
        'What_changes_would_you_make_Label1
        '
        Me.What_changes_would_you_make_Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.What_changes_would_you_make_Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.What_changes_would_you_make_Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidateHeadBoyBindingSource, "What changes would you make?", True))
        Me.What_changes_would_you_make_Label1.ForeColor = System.Drawing.Color.White
        Me.What_changes_would_you_make_Label1.Location = New System.Drawing.Point(461, 140)
        Me.What_changes_would_you_make_Label1.Name = "What_changes_would_you_make_Label1"
        Me.What_changes_would_you_make_Label1.Size = New System.Drawing.Size(238, 79)
        Me.What_changes_would_you_make_Label1.TabIndex = 8
        '
        'Number_of_GCSELabel1
        '
        Me.Number_of_GCSELabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Number_of_GCSELabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidateHeadBoyBindingSource, "Number of GCSE", True))
        Me.Number_of_GCSELabel1.ForeColor = System.Drawing.Color.White
        Me.Number_of_GCSELabel1.Location = New System.Drawing.Point(118, 236)
        Me.Number_of_GCSELabel1.Name = "Number_of_GCSELabel1"
        Me.Number_of_GCSELabel1.Size = New System.Drawing.Size(100, 23)
        Me.Number_of_GCSELabel1.TabIndex = 10
        '
        'Previously_part_of_school_house_council_CheckBox
        '
        Me.Previously_part_of_school_house_council_CheckBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Previously_part_of_school_house_council_CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CandidateHeadBoyBindingSource, "Previously part of school/house council?", True))
        Me.Previously_part_of_school_house_council_CheckBox.Enabled = False
        Me.Previously_part_of_school_house_council_CheckBox.ForeColor = System.Drawing.Color.White
        Me.Previously_part_of_school_house_council_CheckBox.Location = New System.Drawing.Point(461, 236)
        Me.Previously_part_of_school_house_council_CheckBox.Name = "Previously_part_of_school_house_council_CheckBox"
        Me.Previously_part_of_school_house_council_CheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Previously_part_of_school_house_council_CheckBox.TabIndex = 12
        Me.Previously_part_of_school_house_council_CheckBox.UseVisualStyleBackColor = True
        '
        'Personal_SkillsLabel1
        '
        Me.Personal_SkillsLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Personal_SkillsLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Personal_SkillsLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CandidateHeadBoyBindingSource, "Personal Skills", True))
        Me.Personal_SkillsLabel1.ForeColor = System.Drawing.Color.White
        Me.Personal_SkillsLabel1.Location = New System.Drawing.Point(118, 293)
        Me.Personal_SkillsLabel1.Name = "Personal_SkillsLabel1"
        Me.Personal_SkillsLabel1.Size = New System.Drawing.Size(581, 70)
        Me.Personal_SkillsLabel1.TabIndex = 14
        '
        'ImagePictureBox
        '
        Me.ImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.CandidateHeadBoyBindingSource, "Image", True))
        Me.ImagePictureBox.Location = New System.Drawing.Point(48, 46)
        Me.ImagePictureBox.Name = "ImagePictureBox"
        Me.ImagePictureBox.Size = New System.Drawing.Size(100, 131)
        Me.ImagePictureBox.TabIndex = 16
        Me.ImagePictureBox.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(706, 339)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 31)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Cast Your Final Vote"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(706, 286)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 26)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "View Head Girl Profiles"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HeadBoyProfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(866, 433)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ImagePictureBox)
        Me.Controls.Add(Personal_SkillsLabel)
        Me.Controls.Add(Me.Personal_SkillsLabel1)
        Me.Controls.Add(Previously_part_of_school_house_council_Label)
        Me.Controls.Add(Me.Previously_part_of_school_house_council_CheckBox)
        Me.Controls.Add(Number_of_GCSELabel)
        Me.Controls.Add(Me.Number_of_GCSELabel1)
        Me.Controls.Add(What_changes_would_you_make_Label)
        Me.Controls.Add(Me.What_changes_would_you_make_Label1)
        Me.Controls.Add(Why_would_you_like_to_be_head_boy_girl_Label)
        Me.Controls.Add(Me.Why_would_you_like_to_be_head_boy_girl_Label1)
        Me.Controls.Add(Me.Last_NameLabel1)
        Me.Controls.Add(Me.First_NameLabel1)
        Me.Controls.Add(Me.CandidateHeadBoyBindingNavigator)
        Me.Name = "HeadBoyProfiles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HeadBoyProfiles"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CandidateHeadBoyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CandidateHeadBoyBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CandidateHeadBoyBindingNavigator.ResumeLayout(False)
        Me.CandidateHeadBoyBindingNavigator.PerformLayout()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents CandidateHeadBoyBindingSource As BindingSource
    Friend WithEvents CandidateHeadBoyTableAdapter As DatabaseDataSetTableAdapters.CandidateHeadBoyTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CandidateHeadBoyBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents First_NameLabel1 As Label
    Friend WithEvents Last_NameLabel1 As Label
    Friend WithEvents Why_would_you_like_to_be_head_boy_girl_Label1 As Label
    Friend WithEvents What_changes_would_you_make_Label1 As Label
    Friend WithEvents Number_of_GCSELabel1 As Label
    Friend WithEvents Previously_part_of_school_house_council_CheckBox As CheckBox
    Friend WithEvents Personal_SkillsLabel1 As Label
    Friend WithEvents ImagePictureBox As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
