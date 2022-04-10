<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.UcPanelTitle1 = New HZH_Controls.Controls.UCPanelTitle()
        Me.UcKeyBorderAll1 = New HZH_Controls.Controls.UCKeyBorderAll()
        Me.UcBlower1 = New HZH_Controls.Controls.UCBlower()
        Me.UcDialAisle1 = New HZH_Controls.Controls.UCDialAisle()
        Me.UcledTime1 = New HZH_Controls.Controls.UCLEDTime()
        Me.UcRollText1 = New HZH_Controls.Controls.UCRollText()
        Me.UcWave1 = New HZH_Controls.Controls.UCWave()
        Me.UcPanelTitle1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UcPanelTitle1
        '
        Me.UcPanelTitle1.BackColor = System.Drawing.Color.Transparent
        Me.UcPanelTitle1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.UcPanelTitle1.ConerRadius = 10
        Me.UcPanelTitle1.Controls.Add(Me.UcRollText1)
        Me.UcPanelTitle1.FillColor = System.Drawing.Color.White
        Me.UcPanelTitle1.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.UcPanelTitle1.IsCanExpand = True
        Me.UcPanelTitle1.IsExpand = False
        Me.UcPanelTitle1.IsRadius = True
        Me.UcPanelTitle1.IsShowRect = True
        Me.UcPanelTitle1.Location = New System.Drawing.Point(100, 111)
        Me.UcPanelTitle1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcPanelTitle1.Name = "UcPanelTitle1"
        Me.UcPanelTitle1.Padding = New System.Windows.Forms.Padding(1)
        Me.UcPanelTitle1.RectColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.UcPanelTitle1.RectWidth = 1
        Me.UcPanelTitle1.Size = New System.Drawing.Size(476, 207)
        Me.UcPanelTitle1.TabIndex = 0
        Me.UcPanelTitle1.Title = "面板"
        '
        'UcKeyBorderAll1
        '
        Me.UcKeyBorderAll1.BackColor = System.Drawing.Color.White
        Me.UcKeyBorderAll1.CharType = HZH_Controls.Controls.KeyBorderCharType.[CHAR]
        Me.UcKeyBorderAll1.Location = New System.Drawing.Point(151, 252)
        Me.UcKeyBorderAll1.Margin = New System.Windows.Forms.Padding(0)
        Me.UcKeyBorderAll1.Name = "UcKeyBorderAll1"
        Me.UcKeyBorderAll1.Size = New System.Drawing.Size(498, 189)
        Me.UcKeyBorderAll1.TabIndex = 1
        '
        'UcBlower1
        '
        Me.UcBlower1.BlowerColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.UcBlower1.EntranceDirection = HZH_Controls.Controls.BlowerEntranceDirection.None
        Me.UcBlower1.ExitDirection = HZH_Controls.Controls.BlowerExitDirection.Right
        Me.UcBlower1.FanColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.UcBlower1.Location = New System.Drawing.Point(29, 31)
        Me.UcBlower1.Name = "UcBlower1"
        Me.UcBlower1.Size = New System.Drawing.Size(156, 48)
        Me.UcBlower1.TabIndex = 2
        Me.UcBlower1.TurnAround = HZH_Controls.Controls.TurnAround.Clockwise
        Me.UcBlower1.TurnSpeed = 100
        '
        'UcDialAisle1
        '
        Me.UcDialAisle1.DialColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.UcDialAisle1.EnabledClick = False
        Me.UcDialAisle1.ItemColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UcDialAisle1.ItemForeColor = System.Drawing.Color.Black
        Me.UcDialAisle1.ItemSelectColor = System.Drawing.Color.Green
        Me.UcDialAisle1.ItemSelectForeColor = System.Drawing.Color.White
        Me.UcDialAisle1.ItemTexts = New String() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"}
        Me.UcDialAisle1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.UcDialAisle1.Location = New System.Drawing.Point(465, 46)
        Me.UcDialAisle1.Name = "UcDialAisle1"
        Me.UcDialAisle1.Size = New System.Drawing.Size(247, 163)
        Me.UcDialAisle1.TabIndex = 3
        '
        'UcledTime1
        '
        Me.UcledTime1.ForeColor = System.Drawing.Color.Bisque
        Me.UcledTime1.LineWidth = 8
        Me.UcledTime1.Location = New System.Drawing.Point(238, 37)
        Me.UcledTime1.Name = "UcledTime1"
        Me.UcledTime1.Size = New System.Drawing.Size(266, 74)
        Me.UcledTime1.TabIndex = 4
        Me.UcledTime1.Value = New Date(2022, 4, 10, 17, 55, 8, 286)
        '
        'UcRollText1
        '
        Me.UcRollText1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.UcRollText1.Location = New System.Drawing.Point(43, 71)
        Me.UcRollText1.MoveSleepTime = 100
        Me.UcRollText1.Name = "UcRollText1"
        Me.UcRollText1.RollStyle = HZH_Controls.Controls.RollStyle.LeftToRight
        Me.UcRollText1.Size = New System.Drawing.Size(331, 54)
        Me.UcRollText1.TabIndex = 1
        Me.UcRollText1.Text = "我做着瞎玩的"
        '
        'UcWave1
        '
        Me.UcWave1.Location = New System.Drawing.Point(589, 217)
        Me.UcWave1.Name = "UcWave1"
        Me.UcWave1.Size = New System.Drawing.Size(173, 56)
        Me.UcWave1.TabIndex = 5
        Me.UcWave1.Text = "UcWave1"
        Me.UcWave1.WaveColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.UcWave1.WaveHeight = 30
        Me.UcWave1.WaveSleep = 50
        Me.UcWave1.WaveWidth = 200
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.UcWave1)
        Me.Controls.Add(Me.UcledTime1)
        Me.Controls.Add(Me.UcDialAisle1)
        Me.Controls.Add(Me.UcBlower1)
        Me.Controls.Add(Me.UcKeyBorderAll1)
        Me.Controls.Add(Me.UcPanelTitle1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.UcPanelTitle1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcPanelTitle1 As HZH_Controls.Controls.UCPanelTitle
    Friend WithEvents UcRollText1 As HZH_Controls.Controls.UCRollText
    Friend WithEvents UcKeyBorderAll1 As HZH_Controls.Controls.UCKeyBorderAll
    Friend WithEvents UcBlower1 As HZH_Controls.Controls.UCBlower
    Friend WithEvents UcDialAisle1 As HZH_Controls.Controls.UCDialAisle
    Friend WithEvents UcledTime1 As HZH_Controls.Controls.UCLEDTime
    Friend WithEvents UcWave1 As HZH_Controls.Controls.UCWave
End Class
