<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewpolls
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
        Dim ChartArea7 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend7 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea8 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend8 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.DatabaseDataSet = New VotingOS.DatabaseDataSet()
        Me.HeadBoyCountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HeadBoyCountTableAdapter = New VotingOS.DatabaseDataSetTableAdapters.HeadBoyCountTableAdapter()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.HeadGirlCountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HeadGirlCountTableAdapter = New VotingOS.DatabaseDataSetTableAdapters.HeadGirlCountTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeadBoyCountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeadGirlCountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        ChartArea7.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea7)
        Me.Chart1.DataSource = Me.HeadBoyCountBindingSource
        Legend7.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend7)
        Me.Chart1.Location = New System.Drawing.Point(141, 186)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series7.ChartArea = "ChartArea1"
        Series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series7.Legend = "Legend1"
        Series7.Name = "Series1"
        Series7.XValueMember = "First Name"
        Series7.YValueMembers = "CountOfLast Name1"
        Me.Chart1.Series.Add(Series7)
        Me.Chart1.Size = New System.Drawing.Size(311, 300)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Chart2
        '
        ChartArea8.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea8)
        Me.Chart2.DataSource = Me.HeadGirlCountBindingSource
        Legend8.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend8)
        Me.Chart2.Location = New System.Drawing.Point(504, 186)
        Me.Chart2.Name = "Chart2"
        Me.Chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series8.ChartArea = "ChartArea1"
        Series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series8.Legend = "Legend1"
        Series8.Name = "Series1"
        Series8.XValueMember = "First Name"
        Series8.YValueMembers = "CountOfLast Name1"
        Me.Chart2.Series.Add(Series8)
        Me.Chart2.Size = New System.Drawing.Size(300, 300)
        Me.Chart2.TabIndex = 1
        Me.Chart2.Text = "Chart2"
        '
        'HeadGirlCountBindingSource
        '
        Me.HeadGirlCountBindingSource.DataMember = "HeadGirlCount"
        Me.HeadGirlCountBindingSource.DataSource = Me.DatabaseDataSet
        '
        'HeadGirlCountTableAdapter
        '
        Me.HeadGirlCountTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(218, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 17)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Head Boy Polls"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(431, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 24)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "POLLS "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(605, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Head Girl Polls"
        '
        'viewpolls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.VotingOS.My.Resources.Resources.pollsviewer
        Me.ClientSize = New System.Drawing.Size(901, 567)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Chart1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "viewpolls"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "viewpolls"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeadBoyCountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeadGirlCountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents HeadBoyCountBindingSource As BindingSource
    Friend WithEvents HeadBoyCountTableAdapter As DatabaseDataSetTableAdapters.HeadBoyCountTableAdapter
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents HeadGirlCountBindingSource As BindingSource
    Friend WithEvents HeadGirlCountTableAdapter As DatabaseDataSetTableAdapters.HeadGirlCountTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
