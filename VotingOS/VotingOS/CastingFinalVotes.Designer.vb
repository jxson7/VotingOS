<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CastingFinalVotes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CastingFinalVotes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New VotingOS.DatabaseDataSet()
        Me.HeadBoyCountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HeadBoyCountTableAdapter = New VotingOS.DatabaseDataSetTableAdapters.HeadBoyCountTableAdapter()
        Me.TableAdapterManager = New VotingOS.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.UsersTableAdapter = New VotingOS.DatabaseDataSetTableAdapters.usersTableAdapter()
        Me.VotedHeadGirlTextBox = New System.Windows.Forms.TextBox()
        Me.VotedHeadBoyTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CandidateHeadBoyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CandidateHeadBoyTableAdapter = New VotingOS.DatabaseDataSetTableAdapters.CandidateHeadBoyTableAdapter()
        Me.CandidateHeadBoyDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CandidatesHeadGirlBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CandidatesHeadGirlTableAdapter = New VotingOS.DatabaseDataSetTableAdapters.CandidatesHeadGirlTableAdapter()
        Me.CandidatesHeadGirlDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeadBoyCountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CandidateHeadBoyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CandidateHeadBoyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CandidatesHeadGirlBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CandidatesHeadGirlDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(327, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "VotingOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(312, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cast your final vote"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(182, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Head Boy"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(182, 343)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Head Girl"
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "users"
        Me.UsersBindingSource.DataSource = Me.DatabaseDataSet
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HeadBoyCountBindingSource
        '
        Me.HeadBoyCountBindingSource.DataMember = "HeadBoyCount"
        Me.HeadBoyCountBindingSource.DataSource = Me.DatabaseDataSet
        '
        'HeadBoyCountTableAdapter
        '
        Me.HeadBoyCountTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.authorisedmembersTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CandidateHeadBoyTableAdapter = Nothing
        Me.TableAdapterManager.CandidatesHeadGirlTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = VotingOS.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Me.UsersTableAdapter
        Me.TableAdapterManager.VotesTableAdapter = Nothing
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'VotedHeadGirlTextBox
        '
        Me.VotedHeadGirlTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "VotedHeadGirl", True))
        Me.VotedHeadGirlTextBox.Location = New System.Drawing.Point(334, 343)
        Me.VotedHeadGirlTextBox.Name = "VotedHeadGirlTextBox"
        Me.VotedHeadGirlTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VotedHeadGirlTextBox.TabIndex = 9
        '
        'VotedHeadBoyTextBox
        '
        Me.VotedHeadBoyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "VotedHeadBoy", True))
        Me.VotedHeadBoyTextBox.Location = New System.Drawing.Point(334, 254)
        Me.VotedHeadBoyTextBox.Name = "VotedHeadBoyTextBox"
        Me.VotedHeadBoyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VotedHeadBoyTextBox.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.AllowDrop = True
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(501, 279)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 35)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
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
        'CandidateHeadBoyDataGridView
        '
        Me.CandidateHeadBoyDataGridView.AllowUserToAddRows = False
        Me.CandidateHeadBoyDataGridView.AllowUserToDeleteRows = False
        Me.CandidateHeadBoyDataGridView.AutoGenerateColumns = False
        Me.CandidateHeadBoyDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CandidateHeadBoyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CandidateHeadBoyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.CandidateHeadBoyDataGridView.DataSource = Me.CandidateHeadBoyBindingSource
        Me.CandidateHeadBoyDataGridView.GridColor = System.Drawing.Color.White
        Me.CandidateHeadBoyDataGridView.Location = New System.Drawing.Point(67, 383)
        Me.CandidateHeadBoyDataGridView.Name = "CandidateHeadBoyDataGridView"
        Me.CandidateHeadBoyDataGridView.ReadOnly = True
        Me.CandidateHeadBoyDataGridView.Size = New System.Drawing.Size(343, 220)
        Me.CandidateHeadBoyDataGridView.TabIndex = 11
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
        'CandidatesHeadGirlTableAdapter
        '
        Me.CandidatesHeadGirlTableAdapter.ClearBeforeFill = True
        '
        'CandidatesHeadGirlDataGridView
        '
        Me.CandidatesHeadGirlDataGridView.AllowUserToAddRows = False
        Me.CandidatesHeadGirlDataGridView.AllowUserToDeleteRows = False
        Me.CandidatesHeadGirlDataGridView.AutoGenerateColumns = False
        Me.CandidatesHeadGirlDataGridView.BackgroundColor = System.Drawing.Color.Black
        Me.CandidatesHeadGirlDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CandidatesHeadGirlDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.CandidatesHeadGirlDataGridView.DataSource = Me.CandidatesHeadGirlBindingSource
        Me.CandidatesHeadGirlDataGridView.GridColor = System.Drawing.Color.White
        Me.CandidatesHeadGirlDataGridView.Location = New System.Drawing.Point(524, 383)
        Me.CandidatesHeadGirlDataGridView.Name = "CandidatesHeadGirlDataGridView"
        Me.CandidatesHeadGirlDataGridView.ReadOnly = True
        Me.CandidatesHeadGirlDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.CandidatesHeadGirlDataGridView.TabIndex = 11
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
        'CastingFinalVotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(965, 630)
        Me.Controls.Add(Me.CandidatesHeadGirlDataGridView)
        Me.Controls.Add(Me.CandidateHeadBoyDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.VotedHeadBoyTextBox)
        Me.Controls.Add(Me.VotedHeadGirlTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CastingFinalVotes"
        Me.Text = "CastingFinalVotes"
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeadBoyCountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CandidateHeadBoyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CandidateHeadBoyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CandidatesHeadGirlBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CandidatesHeadGirlDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents HeadBoyCountBindingSource As BindingSource
    Friend WithEvents HeadBoyCountTableAdapter As DatabaseDataSetTableAdapters.HeadBoyCountTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsersTableAdapter As DatabaseDataSetTableAdapters.usersTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents VotedHeadGirlTextBox As TextBox
    Friend WithEvents VotedHeadBoyTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CandidateHeadBoyBindingSource As BindingSource
    Friend WithEvents CandidateHeadBoyTableAdapter As DatabaseDataSetTableAdapters.CandidateHeadBoyTableAdapter
    Friend WithEvents CandidateHeadBoyDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents CandidatesHeadGirlBindingSource As BindingSource
    Friend WithEvents CandidatesHeadGirlTableAdapter As DatabaseDataSetTableAdapters.CandidatesHeadGirlTableAdapter
    Friend WithEvents CandidatesHeadGirlDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
