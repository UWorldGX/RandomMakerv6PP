<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen1
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UiProcessBar1 = New Sunny.UI.UIProcessBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Typewriter", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(209, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Now Loading..."
        '
        'Timer1
        '
        Me.Timer1.Interval = 375
        '
        'Timer2
        '
        Me.Timer2.Interval = 375
        '
        'Timer3
        '
        Me.Timer3.Interval = 375
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(8, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Using .NET Framework 4.8"
        '
        'Timer4
        '
        Me.Timer4.Interval = 250
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(8, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Version 6.1.0 ""Judgment Jolt"""
        '
        'UiProcessBar1
        '
        Me.UiProcessBar1.BackColor = System.Drawing.Color.Transparent
        Me.UiProcessBar1.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.UiProcessBar1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UiProcessBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.UiProcessBar1.Location = New System.Drawing.Point(24, 24)
        Me.UiProcessBar1.MinimumSize = New System.Drawing.Size(70, 3)
        Me.UiProcessBar1.Name = "UiProcessBar1"
        Me.UiProcessBar1.Radius = 15
        Me.UiProcessBar1.RectColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.UiProcessBar1.Size = New System.Drawing.Size(336, 31)
        Me.UiProcessBar1.Style = Sunny.UI.UIStyle.Colorful
        Me.UiProcessBar1.TabIndex = 4
        Me.UiProcessBar1.Text = "UiProcessBar1"
        Me.UiProcessBar1.Value = 100
        '
        'SplashScreen1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RandomMakerv6PP.My.Resources.Resources.PG0
        Me.ClientSize = New System.Drawing.Size(373, 108)
        Me.ControlBox = False
        Me.Controls.Add(Me.UiProcessBar1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreen1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents UiProcessBar1 As Sunny.UI.UIProcessBar
End Class
