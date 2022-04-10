Public Class Class1
    Inherits Sunny.UI.UIForm

    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents UiTabControl1 As Sunny.UI.UITabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents UiRichTextBox1 As Sunny.UI.UIRichTextBox
    Friend WithEvents UiRoundProcess1 As Sunny.UI.UIRoundProcess
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents UiNavMenu1 As Sunny.UI.UINavMenu

    Private Sub InitializeComponent()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("节点0")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("节点1")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("节点2")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("节点3")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("节点4")
        Me.Database1DataSet = New RandomMakerv6PP.Database1DataSet()
        Me.UiNavMenu1 = New Sunny.UI.UINavMenu()
        Me.UiTabControl1 = New Sunny.UI.UITabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.UiRoundProcess1 = New Sunny.UI.UIRoundProcess()
        Me.UiRichTextBox1 = New Sunny.UI.UIRichTextBox()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UiNavMenu1
        '
        Me.UiNavMenu1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UiNavMenu1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll
        Me.UiNavMenu1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UiNavMenu1.FullRowSelect = True
        Me.UiNavMenu1.ItemHeight = 50
        Me.UiNavMenu1.Location = New System.Drawing.Point(3, 38)
        Me.UiNavMenu1.Name = "UiNavMenu1"
        TreeNode1.Name = "节点0"
        TreeNode1.Text = "节点0"
        TreeNode2.Name = "节点1"
        TreeNode2.Text = "节点1"
        TreeNode3.Name = "节点2"
        TreeNode3.Text = "节点2"
        TreeNode4.Name = "节点3"
        TreeNode4.Text = "节点3"
        TreeNode5.Name = "节点4"
        TreeNode5.Text = "节点4"
        Me.UiNavMenu1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5})
        Me.UiNavMenu1.SelectedForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.UiNavMenu1.SelectedHighColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.UiNavMenu1.ShowLines = False
        Me.UiNavMenu1.Size = New System.Drawing.Size(124, 305)
        Me.UiNavMenu1.Style = Sunny.UI.UIStyle.Colorful
        Me.UiNavMenu1.TabControl = Me.UiTabControl1
        Me.UiNavMenu1.TabIndex = 0
        Me.UiNavMenu1.TipsFont = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        '
        'UiTabControl1
        '
        Me.UiTabControl1.Controls.Add(Me.TabPage1)
        Me.UiTabControl1.Controls.Add(Me.TabPage2)
        Me.UiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.UiTabControl1.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.UiTabControl1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UiTabControl1.ItemSize = New System.Drawing.Size(150, 40)
        Me.UiTabControl1.Location = New System.Drawing.Point(156, 50)
        Me.UiTabControl1.MainPage = ""
        Me.UiTabControl1.Name = "UiTabControl1"
        Me.UiTabControl1.SelectedIndex = 0
        Me.UiTabControl1.Size = New System.Drawing.Size(613, 404)
        Me.UiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.UiTabControl1.Style = Sunny.UI.UIStyle.Colorful
        Me.UiTabControl1.TabIndex = 1
        Me.UiTabControl1.TabSelectedForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.UiTabControl1.TabSelectedHighColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.UiTabControl1.TipsFont = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.UiRichTextBox1)
        Me.TabPage1.Controls.Add(Me.UiRoundProcess1)
        Me.TabPage1.Location = New System.Drawing.Point(0, 40)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(613, 364)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(0, 40)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(613, 364)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'UiRoundProcess1
        '
        Me.UiRoundProcess1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UiRoundProcess1.Location = New System.Drawing.Point(96, 68)
        Me.UiRoundProcess1.MinimumSize = New System.Drawing.Size(1, 1)
        Me.UiRoundProcess1.Name = "UiRoundProcess1"
        Me.UiRoundProcess1.Size = New System.Drawing.Size(264, 175)
        Me.UiRoundProcess1.TabIndex = 0
        Me.UiRoundProcess1.Text = "UiRoundProcess1"
        '
        'UiRichTextBox1
        '
        Me.UiRichTextBox1.FillColor = System.Drawing.Color.White
        Me.UiRichTextBox1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UiRichTextBox1.Location = New System.Drawing.Point(323, 42)
        Me.UiRichTextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UiRichTextBox1.MinimumSize = New System.Drawing.Size(1, 1)
        Me.UiRichTextBox1.Name = "UiRichTextBox1"
        Me.UiRichTextBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.UiRichTextBox1.ShowText = False
        Me.UiRichTextBox1.Size = New System.Drawing.Size(273, 276)
        Me.UiRichTextBox1.Style = Sunny.UI.UIStyle.Custom
        Me.UiRichTextBox1.TabIndex = 1
        Me.UiRichTextBox1.Text = "UiRichTextBox1"
        Me.UiRichTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Class1
        '
        Me.ClientSize = New System.Drawing.Size(800, 480)
        Me.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Controls.Add(Me.UiTabControl1)
        Me.Controls.Add(Me.UiNavMenu1)
        Me.Name = "Class1"
        Me.RectColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Style = Sunny.UI.UIStyle.Colorful
        Me.TitleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(172, Byte), Integer))
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private Sub UiNavMenu1_MenuItemClick(node As TreeNode, item As Sunny.UI.NavMenuItem, pageIndex As Integer) Handles UiNavMenu1.MenuItemClick

    End Sub

    Private Sub Class1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
