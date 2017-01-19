<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FINALVOTEPAGE
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
        Dim VotedHeadBoyLabel As System.Windows.Forms.Label
        Dim VotedHeadGirlLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FINALVOTEPAGE))
        Me.DatabaseDataSet = New VotingOS.DatabaseDataSet()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New VotingOS.DatabaseDataSetTableAdapters.usersTableAdapter()
        Me.TableAdapterManager = New VotingOS.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.CandidateHeadBoyTableAdapter = New VotingOS.DatabaseDataSetTableAdapters.CandidateHeadBoyTableAdapter()
        Me.CandidatesHeadGirlTableAdapter = New VotingOS.DatabaseDataSetTableAdapters.CandidatesHeadGirlTableAdapter()
        Me.CandidateHeadBoyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CandidateHeadBoyDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CandidatesHeadGirlBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CandidatesHeadGirlDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.VotedHeadBoyTextBox = New System.Windows.Forms.TextBox()
        Me.VotedHeadGirlTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
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
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        VotedHeadBoyLabel = New System.Windows.Forms.Label()
        VotedHeadGirlLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CandidateHeadBoyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CandidateHeadBoyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CandidatesHeadGirlBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CandidatesHeadGirlDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "users"
        Me.UsersBindingSource.DataSource = Me.DatabaseDataSet
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.authorisedmembersTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CandidateHeadBoyTableAdapter = Me.CandidateHeadBoyTableAdapter
        Me.TableAdapterManager.CandidatesHeadGirlTableAdapter = Me.CandidatesHeadGirlTableAdapter
        Me.TableAdapterManager.UpdateOrder = VotingOS.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Me.UsersTableAdapter
        Me.TableAdapterManager.VotesTableAdapter = Nothing
        '
        'CandidateHeadBoyTableAdapter
        '
        Me.CandidateHeadBoyTableAdapter.ClearBeforeFill = True
        '
        'CandidatesHeadGirlTableAdapter
        '
        Me.CandidatesHeadGirlTableAdapter.ClearBeforeFill = True
        '
        'CandidateHeadBoyBindingSource
        '
        Me.CandidateHeadBoyBindingSource.DataMember = "CandidateHeadBoy"
        Me.CandidateHeadBoyBindingSource.DataSource = Me.DatabaseDataSet
        '
        'CandidateHeadBoyDataGridView
        '
        Me.CandidateHeadBoyDataGridView.AllowUserToAddRows = False
        Me.CandidateHeadBoyDataGridView.AllowUserToDeleteRows = False
        Me.CandidateHeadBoyDataGridView.AutoGenerateColumns = False
        Me.CandidateHeadBoyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CandidateHeadBoyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.CandidateHeadBoyDataGridView.DataSource = Me.CandidateHeadBoyBindingSource
        Me.CandidateHeadBoyDataGridView.Location = New System.Drawing.Point(502, 80)
        Me.CandidateHeadBoyDataGridView.Name = "CandidateHeadBoyDataGridView"
        Me.CandidateHeadBoyDataGridView.ReadOnly = True
        Me.CandidateHeadBoyDataGridView.Size = New System.Drawing.Size(347, 138)
        Me.CandidateHeadBoyDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "First Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Last Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'CandidatesHeadGirlBindingSource
        '
        Me.CandidatesHeadGirlBindingSource.DataMember = "CandidatesHeadGirl"
        Me.CandidatesHeadGirlBindingSource.DataSource = Me.DatabaseDataSet
        '
        'CandidatesHeadGirlDataGridView
        '
        Me.CandidatesHeadGirlDataGridView.AllowUserToAddRows = False
        Me.CandidatesHeadGirlDataGridView.AllowUserToDeleteRows = False
        Me.CandidatesHeadGirlDataGridView.AutoGenerateColumns = False
        Me.CandidatesHeadGirlDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CandidatesHeadGirlDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.CandidatesHeadGirlDataGridView.DataSource = Me.CandidatesHeadGirlBindingSource
        Me.CandidatesHeadGirlDataGridView.Location = New System.Drawing.Point(502, 284)
        Me.CandidatesHeadGirlDataGridView.Name = "CandidatesHeadGirlDataGridView"
        Me.CandidatesHeadGirlDataGridView.ReadOnly = True
        Me.CandidatesHeadGirlDataGridView.Size = New System.Drawing.Size(347, 168)
        Me.CandidatesHeadGirlDataGridView.TabIndex = 18
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "First Name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Last Name"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.AllowDrop = True
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(178, 435)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 35)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(181, 62)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 20
        '
        'Button2
        '
        Me.Button2.AllowDrop = True
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(300, 54)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 35)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Load"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(94, 141)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 21
        FirstNameLabel.Text = "First Name:"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(160, 138)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox.TabIndex = 22
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(79, 167)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 22
        LastNameLabel.Text = "Last Name:"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(146, 164)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTextBox.TabIndex = 23
        '
        'VotedHeadBoyLabel
        '
        VotedHeadBoyLabel.AutoSize = True
        VotedHeadBoyLabel.Location = New System.Drawing.Point(52, 287)
        VotedHeadBoyLabel.Name = "VotedHeadBoyLabel"
        VotedHeadBoyLabel.Size = New System.Drawing.Size(88, 13)
        VotedHeadBoyLabel.TabIndex = 23
        VotedHeadBoyLabel.Text = "Voted Head Boy:"
        '
        'VotedHeadBoyTextBox
        '
        Me.VotedHeadBoyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "VotedHeadBoy", True))
        Me.VotedHeadBoyTextBox.Location = New System.Drawing.Point(146, 284)
        Me.VotedHeadBoyTextBox.Name = "VotedHeadBoyTextBox"
        Me.VotedHeadBoyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VotedHeadBoyTextBox.TabIndex = 24
        '
        'VotedHeadGirlLabel
        '
        VotedHeadGirlLabel.AutoSize = True
        VotedHeadGirlLabel.Location = New System.Drawing.Point(55, 323)
        VotedHeadGirlLabel.Name = "VotedHeadGirlLabel"
        VotedHeadGirlLabel.Size = New System.Drawing.Size(85, 13)
        VotedHeadGirlLabel.TabIndex = 24
        VotedHeadGirlLabel.Text = "Voted Head Girl:"
        '
        'VotedHeadGirlTextBox
        '
        Me.VotedHeadGirlTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "VotedHeadGirl", True))
        Me.VotedHeadGirlTextBox.Location = New System.Drawing.Point(146, 320)
        Me.VotedHeadGirlTextBox.Name = "VotedHeadGirlTextBox"
        Me.VotedHeadGirlTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VotedHeadGirlTextBox.TabIndex = 25
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(907, 25)
        Me.BindingNavigator1.TabIndex = 26
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'FINALVOTEPAGE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(907, 596)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(VotedHeadGirlLabel)
        Me.Controls.Add(Me.VotedHeadGirlTextBox)
        Me.Controls.Add(VotedHeadBoyLabel)
        Me.Controls.Add(Me.VotedHeadBoyTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CandidatesHeadGirlDataGridView)
        Me.Controls.Add(Me.CandidateHeadBoyDataGridView)
        Me.Name = "FINALVOTEPAGE"
        Me.Text = "FINALVOTEPAGE"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CandidateHeadBoyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CandidateHeadBoyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CandidatesHeadGirlBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CandidatesHeadGirlDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As DatabaseDataSetTableAdapters.usersTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CandidateHeadBoyTableAdapter As DatabaseDataSetTableAdapters.CandidateHeadBoyTableAdapter
    Friend WithEvents CandidateHeadBoyBindingSource As BindingSource
    Friend WithEvents CandidatesHeadGirlTableAdapter As DatabaseDataSetTableAdapters.CandidatesHeadGirlTableAdapter
    Friend WithEvents CandidateHeadBoyDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents CandidatesHeadGirlBindingSource As BindingSource
    Friend WithEvents CandidatesHeadGirlDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents VotedHeadBoyTextBox As TextBox
    Friend WithEvents VotedHeadGirlTextBox As TextBox
    Friend WithEvents BindingNavigator1 As BindingNavigator
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
End Class
