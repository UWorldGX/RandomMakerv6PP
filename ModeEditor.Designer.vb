<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModeEditor
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModeEditor))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RepeatSwitch = New System.Windows.Forms.CheckBox()
        Me.ExtremeSwitch = New System.Windows.Forms.CheckBox()
        Me.ItemSwitch = New System.Windows.Forms.RadioButton()
        Me.NumberSwitch = New System.Windows.Forms.RadioButton()
        Me.pool = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.timepool = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pool, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.timepool, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.RepeatSwitch)
        Me.GroupBox1.Controls.Add(Me.ExtremeSwitch)
        Me.GroupBox1.Controls.Add(Me.ItemSwitch)
        Me.GroupBox1.Controls.Add(Me.NumberSwitch)
        Me.GroupBox1.Controls.Add(Me.pool)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.timepool)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(260, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 246)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "选项"
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(69, 201)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 31)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "删除该模式"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(78, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(152, 29)
        Me.TextBox1.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "模式名称:"
        '
        'RepeatSwitch
        '
        Me.RepeatSwitch.AutoSize = True
        Me.RepeatSwitch.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RepeatSwitch.ForeColor = System.Drawing.Color.Black
        Me.RepeatSwitch.Location = New System.Drawing.Point(121, 147)
        Me.RepeatSwitch.Name = "RepeatSwitch"
        Me.RepeatSwitch.Size = New System.Drawing.Size(75, 21)
        Me.RepeatSwitch.TabIndex = 37
        Me.RepeatSwitch.Text = "允许重复"
        Me.RepeatSwitch.UseVisualStyleBackColor = True
        '
        'ExtremeSwitch
        '
        Me.ExtremeSwitch.AutoSize = True
        Me.ExtremeSwitch.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ExtremeSwitch.ForeColor = System.Drawing.Color.Black
        Me.ExtremeSwitch.Location = New System.Drawing.Point(31, 147)
        Me.ExtremeSwitch.Name = "ExtremeSwitch"
        Me.ExtremeSwitch.Size = New System.Drawing.Size(75, 21)
        Me.ExtremeSwitch.TabIndex = 36
        Me.ExtremeSwitch.Text = "极限模式"
        Me.ExtremeSwitch.UseVisualStyleBackColor = True
        '
        'ItemSwitch
        '
        Me.ItemSwitch.AutoSize = True
        Me.ItemSwitch.Font = New System.Drawing.Font("微软雅黑", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ItemSwitch.ForeColor = System.Drawing.Color.Black
        Me.ItemSwitch.Location = New System.Drawing.Point(121, 172)
        Me.ItemSwitch.Name = "ItemSwitch"
        Me.ItemSwitch.Size = New System.Drawing.Size(87, 23)
        Me.ItemSwitch.TabIndex = 35
        Me.ItemSwitch.Text = "数据驱动"
        Me.ItemSwitch.UseVisualStyleBackColor = True
        '
        'NumberSwitch
        '
        Me.NumberSwitch.AutoSize = True
        Me.NumberSwitch.Checked = True
        Me.NumberSwitch.Font = New System.Drawing.Font("微软雅黑", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.NumberSwitch.ForeColor = System.Drawing.Color.Black
        Me.NumberSwitch.Location = New System.Drawing.Point(31, 172)
        Me.NumberSwitch.Name = "NumberSwitch"
        Me.NumberSwitch.Size = New System.Drawing.Size(72, 23)
        Me.NumberSwitch.TabIndex = 34
        Me.NumberSwitch.TabStop = True
        Me.NumberSwitch.Text = "随机数"
        Me.NumberSwitch.UseVisualStyleBackColor = True
        '
        'pool
        '
        Me.pool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pool.Enabled = False
        Me.pool.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.pool.Location = New System.Drawing.Point(132, 111)
        Me.pool.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.pool.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.pool.Name = "pool"
        Me.pool.ReadOnly = True
        Me.pool.Size = New System.Drawing.Size(48, 23)
        Me.pool.TabIndex = 16
        Me.pool.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.pool.Value = New Decimal(New Integer() {16, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("微软雅黑", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(51, 111)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 20)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "抽取范围:"
        '
        'timepool
        '
        Me.timepool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.timepool.Enabled = False
        Me.timepool.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.timepool.Location = New System.Drawing.Point(132, 76)
        Me.timepool.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.timepool.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.timepool.Name = "timepool"
        Me.timepool.ReadOnly = True
        Me.timepool.Size = New System.Drawing.Size(48, 23)
        Me.timepool.TabIndex = 14
        Me.timepool.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.timepool.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(51, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "抽取次数:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(389, 305)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "保存"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(285, 305)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 41)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "取消"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 21
        Me.ListBox1.Location = New System.Drawing.Point(27, 50)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(227, 256)
        Me.ListBox1.TabIndex = 3
        '
        'ModeEditor
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RandomMakerv6PP.My.Resources.Resources.桥梁邮件Ｓ
        Me.ClientSize = New System.Drawing.Size(513, 381)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "ModeEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "模式编辑器"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pool, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.timepool, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents pool As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents timepool As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents RepeatSwitch As CheckBox
    Friend WithEvents ExtremeSwitch As CheckBox
    Friend WithEvents ItemSwitch As RadioButton
    Friend WithEvents NumberSwitch As RadioButton
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
End Class
