<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CastingFinalVotes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CastingFinalVotes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.VotedHeadBoyComboBox = New System.Windows.Forms.ComboBox()
        Me.VotedHeadGirlComboBox = New System.Windows.Forms.ComboBox()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New VotingOS.DatabaseDataSet()
        Me.HeadBoyCountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HeadBoyCountTableAdapter = New VotingOS.DatabaseDataSetTableAdapters.HeadBoyCountTableAdapter()
        Me.TableAdapterManager = New VotingOS.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.UsersTableAdapter = New VotingOS.DatabaseDataSetTableAdapters.usersTableAdapter()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeadBoyCountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label3.Location = New System.Drawing.Point(124, 166)
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
        Me.Label4.Location = New System.Drawing.Point(127, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Head Girl"
        '
        'VotedHeadBoyComboBox
        '
        Me.VotedHeadBoyComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "VotedHeadBoy", True))
        Me.VotedHeadBoyComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.UsersBindingSource, "VotedHeadBoy", True))
        Me.VotedHeadBoyComboBox.DataSource = Me.DatabaseDataSet
        Me.VotedHeadBoyComboBox.DisplayMember = "CandidateHeadBoy.ID"
        Me.VotedHeadBoyComboBox.FormattingEnabled = True
        Me.VotedHeadBoyComboBox.Location = New System.Drawing.Point(246, 168)
        Me.VotedHeadBoyComboBox.Name = "VotedHeadBoyComboBox"
        Me.VotedHeadBoyComboBox.Size = New System.Drawing.Size(121, 21)
        Me.VotedHeadBoyComboBox.TabIndex = 8
        Me.VotedHeadBoyComboBox.ValueMember = "CandidateHeadBoy.ID"
        '
        'VotedHeadGirlComboBox
        '
        Me.VotedHeadGirlComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "VotedHeadGirl", True))
        Me.VotedHeadGirlComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.UsersBindingSource, "VotedHeadGirl", True))
        Me.VotedHeadGirlComboBox.DataSource = Me.DatabaseDataSet
        Me.VotedHeadGirlComboBox.DisplayMember = "CandidatesHeadGirl.ID"
        Me.VotedHeadGirlComboBox.FormattingEnabled = True
        Me.VotedHeadGirlComboBox.Location = New System.Drawing.Point(246, 242)
        Me.VotedHeadGirlComboBox.Name = "VotedHeadGirlComboBox"
        Me.VotedHeadGirlComboBox.Size = New System.Drawing.Size(121, 21)
        Me.VotedHeadGirlComboBox.TabIndex = 9
        Me.VotedHeadGirlComboBox.ValueMember = "CandidatesHeadGirl.ID"
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
        'CastingFinalVotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(815, 555)
        Me.Controls.Add(Me.VotedHeadGirlComboBox)
        Me.Controls.Add(Me.VotedHeadBoyComboBox)
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
    Friend WithEvents VotedHeadBoyComboBox As ComboBox
    Friend WithEvents VotedHeadGirlComboBox As ComboBox
End Class
