Public Class UniversalDG2
    Inherits Sunny.UI.UIForm

    Friend WithEvents UiButton1 As Sunny.UI.UIButton
    Friend WithEvents UiButton2 As Sunny.UI.UIButton
    Friend WithEvents UiLabel1 As Sunny.UI.UILabel

    Private Sub InitializeComponent()
        Me.UiButton1 = New Sunny.UI.UIButton()
        Me.UiButton2 = New Sunny.UI.UIButton()
        Me.UiLabel1 = New Sunny.UI.UILabel()
        Me.SuspendLayout()
        '
        'UiButton1
        '
        Me.UiButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UiButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.UiButton1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.UiButton1.FillHoverColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.UiButton1.FillPressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UiButton1.FillSelectedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UiButton1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UiButton1.Location = New System.Drawing.Point(186, 139)
        Me.UiButton1.MinimumSize = New System.Drawing.Size(1, 1)
        Me.UiButton1.Name = "UiButton1"
        Me.UiButton1.RectColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.UiButton1.RectHoverColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.UiButton1.RectPressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UiButton1.RectSelectedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UiButton1.Size = New System.Drawing.Size(121, 52)
        Me.UiButton1.Style = Sunny.UI.UIStyle.Colorful
        Me.UiButton1.TabIndex = 0
        Me.UiButton1.Text = "确定"
        Me.UiButton1.TipsFont = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        '
        'UiButton2
        '
        Me.UiButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UiButton2.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.UiButton2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.UiButton2.FillHoverColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.UiButton2.FillPressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UiButton2.FillSelectedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UiButton2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UiButton2.Location = New System.Drawing.Point(341, 139)
        Me.UiButton2.MinimumSize = New System.Drawing.Size(1, 1)
        Me.UiButton2.Name = "UiButton2"
        Me.UiButton2.RectColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.UiButton2.RectHoverColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.UiButton2.RectPressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UiButton2.RectSelectedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UiButton2.Size = New System.Drawing.Size(121, 52)
        Me.UiButton2.Style = Sunny.UI.UIStyle.Colorful
        Me.UiButton2.TabIndex = 1
        Me.UiButton2.Text = "取消"
        Me.UiButton2.TipsFont = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UiButton2.TipsText = "1111"
        '
        'UiLabel1
        '
        Me.UiLabel1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UiLabel1.Location = New System.Drawing.Point(58, 55)
        Me.UiLabel1.Name = "UiLabel1"
        Me.UiLabel1.Size = New System.Drawing.Size(521, 69)
        Me.UiLabel1.Style = Sunny.UI.UIStyle.Colorful
        Me.UiLabel1.TabIndex = 2
        Me.UiLabel1.Text = "调试完成...累死喵了..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "现在就要去主界面查看劳动成果吗?"
        Me.UiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UniversalDG2
        '
        Me.ClientSize = New System.Drawing.Size(654, 211)
        Me.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Controls.Add(Me.UiLabel1)
        Me.Controls.Add(Me.UiButton2)
        Me.Controls.Add(Me.UiButton1)
        Me.IsForbidAltF4 = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UniversalDG2"
        Me.RectColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Style = Sunny.UI.UIStyle.Colorful
        Me.Text = "提示"
        Me.TitleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.ResumeLayout(False)

    End Sub

    Private Sub UiButton1_Click(sender As Object, e As EventArgs) Handles UiButton1.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub UiButton2_Click(sender As Object, e As EventArgs) Handles UiButton2.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub UniversalDG2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeComponent()
    End Sub
End Class
