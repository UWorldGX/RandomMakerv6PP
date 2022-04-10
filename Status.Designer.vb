<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Status
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Status))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.RoundDisplay = New Sunny.UI.UILedDisplay()
        Me.TimesDisplay = New Sunny.UI.UILedDisplay()
        Me.RangeDisplay = New Sunny.UI.UILedDisplay()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.UiLedDisplay1 = New Sunny.UI.UILedDisplay()
        Me.UiLedDisplay2 = New Sunny.UI.UILedDisplay()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(403, 296)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 49)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(63, 31)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(403, 209)
        Me.Chart1.TabIndex = 1
        Me.Chart1.Text = "Chart1"
        Title1.Name = "统计信息"
        Me.Chart1.Titles.Add(Title1)
        '
        'RoundDisplay
        '
        Me.RoundDisplay.BackColor = System.Drawing.Color.Black
        Me.RoundDisplay.CharCount = 5
        Me.RoundDisplay.Font = New System.Drawing.Font("微软雅黑", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RoundDisplay.ForeColor = System.Drawing.Color.Lime
        Me.RoundDisplay.IntervalOn = 1
        Me.RoundDisplay.Location = New System.Drawing.Point(369, 8)
        Me.RoundDisplay.Name = "RoundDisplay"
        Me.RoundDisplay.Size = New System.Drawing.Size(69, 27)
        Me.RoundDisplay.TabIndex = 40
        Me.RoundDisplay.Text = "90002"
        '
        'TimesDisplay
        '
        Me.TimesDisplay.BackColor = System.Drawing.Color.Black
        Me.TimesDisplay.CharCount = 3
        Me.TimesDisplay.Font = New System.Drawing.Font("微软雅黑", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TimesDisplay.ForeColor = System.Drawing.Color.Lime
        Me.TimesDisplay.IntervalOn = 1
        Me.TimesDisplay.Location = New System.Drawing.Point(243, 8)
        Me.TimesDisplay.Name = "TimesDisplay"
        Me.TimesDisplay.Size = New System.Drawing.Size(45, 27)
        Me.TimesDisplay.TabIndex = 39
        Me.TimesDisplay.Text = "90002"
        '
        'RangeDisplay
        '
        Me.RangeDisplay.BackColor = System.Drawing.Color.Black
        Me.RangeDisplay.CharCount = 3
        Me.RangeDisplay.Font = New System.Drawing.Font("微软雅黑", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RangeDisplay.ForeColor = System.Drawing.Color.Lime
        Me.RangeDisplay.IntervalOn = 1
        Me.RangeDisplay.Location = New System.Drawing.Point(113, 8)
        Me.RangeDisplay.Name = "RangeDisplay"
        Me.RangeDisplay.Size = New System.Drawing.Size(45, 27)
        Me.RangeDisplay.TabIndex = 38
        Me.RangeDisplay.Text = "90002"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(164, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 19)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "抽取次数:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(294, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 19)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "抽取回数:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(34, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 19)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "抽取范围:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(366, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 17)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "抽取次数最多的是:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.IndianRed
        Me.Label5.Location = New System.Drawing.Point(416, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 21)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Label5"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.UiLedDisplay2)
        Me.GroupBox1.Controls.Add(Me.UiLedDisplay1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(63, 246)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 99)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查询"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(83, 22)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(141, 25)
        Me.ComboBox1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 17)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "抽取次数:"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(154, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 17)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "抽取概率:"
        Me.Label7.Visible = False
        '
        'UiLedDisplay1
        '
        Me.UiLedDisplay1.BackColor = System.Drawing.Color.Black
        Me.UiLedDisplay1.CharCount = 3
        Me.UiLedDisplay1.Font = New System.Drawing.Font("微软雅黑", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UiLedDisplay1.ForeColor = System.Drawing.Color.Lime
        Me.UiLedDisplay1.IntervalOn = 1
        Me.UiLedDisplay1.Location = New System.Drawing.Point(87, 63)
        Me.UiLedDisplay1.Name = "UiLedDisplay1"
        Me.UiLedDisplay1.Size = New System.Drawing.Size(45, 27)
        Me.UiLedDisplay1.TabIndex = 45
        Me.UiLedDisplay1.Text = "90002"
        Me.UiLedDisplay1.Visible = False
        '
        'UiLedDisplay2
        '
        Me.UiLedDisplay2.BackColor = System.Drawing.Color.Black
        Me.UiLedDisplay2.CharCount = 6
        Me.UiLedDisplay2.Font = New System.Drawing.Font("微软雅黑", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UiLedDisplay2.ForeColor = System.Drawing.Color.Lime
        Me.UiLedDisplay2.IntervalOn = 1
        Me.UiLedDisplay2.Location = New System.Drawing.Point(219, 63)
        Me.UiLedDisplay2.Name = "UiLedDisplay2"
        Me.UiLedDisplay2.Size = New System.Drawing.Size(81, 27)
        Me.UiLedDisplay2.TabIndex = 46
        Me.UiLedDisplay2.Text = "90002"
        Me.UiLedDisplay2.Visible = False
        '
        'Status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RandomMakerv6PP.My.Resources.Resources.桥梁邮件Ｗ
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(520, 358)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RoundDisplay)
        Me.Controls.Add(Me.TimesDisplay)
        Me.Controls.Add(Me.RangeDisplay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Status"
        Me.Text = "Status"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents RoundDisplay As Sunny.UI.UILedDisplay
    Friend WithEvents TimesDisplay As Sunny.UI.UILedDisplay
    Friend WithEvents RangeDisplay As Sunny.UI.UILedDisplay
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents UiLedDisplay2 As Sunny.UI.UILedDisplay
    Friend WithEvents UiLedDisplay1 As Sunny.UI.UILedDisplay
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class
