<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DebugForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DebugForm))
        Me.DebugOutput = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New HZH_Controls.Controls.UCProcessLineExt()
        Me.SuspendLayout()
        '
        'DebugOutput
        '
        Me.DebugOutput.BackColor = System.Drawing.Color.Transparent
        Me.DebugOutput.BackgroundImage = CType(resources.GetObject("DebugOutput.BackgroundImage"), System.Drawing.Image)
        Me.DebugOutput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DebugOutput.FlatAppearance.BorderSize = 0
        Me.DebugOutput.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DebugOutput.ForeColor = System.Drawing.Color.White
        Me.DebugOutput.Location = New System.Drawing.Point(151, 163)
        Me.DebugOutput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DebugOutput.Name = "DebugOutput"
        Me.DebugOutput.Size = New System.Drawing.Size(93, 45)
        Me.DebugOutput.TabIndex = 0
        Me.DebugOutput.Text = "输出JSON"
        Me.DebugOutput.UseVisualStyleBackColor = False
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "txt"
        Me.SaveFileDialog1.InitialDirectory = "D:\"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(25, 163)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 45)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "一键批量输出"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsReturn = True
        Me.TextBox1.Location = New System.Drawing.Point(25, 21)
        Me.TextBox1.MaxLength = 65536
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TextBox1.Size = New System.Drawing.Size(236, 90)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "这里将输出该程序实时的JSON配置文件。"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.ProgressBar1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ProgressBar1.Location = New System.Drawing.Point(16, 125)
        Me.ProgressBar1.MaxValue = 100
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(261, 28)
        Me.ProgressBar1.TabIndex = 3
        Me.ProgressBar1.Value = 0
        Me.ProgressBar1.ValueBGColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ProgressBar1.ValueColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        '
        'DebugForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RandomMakerv6PP.My.Resources.Resources.桥梁邮件Ｈ
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(297, 221)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DebugOutput)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "DebugForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "调试窗口"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DebugOutput As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ProgressBar1 As HZH_Controls.Controls.UCProcessLineExt
End Class
