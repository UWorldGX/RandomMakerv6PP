<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MainDialog = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.更多ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.更新记录ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ModeSelection = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TimesDisplay = New Sunny.UI.UILedDisplay()
        Me.RangeDisplay = New Sunny.UI.UILedDisplay()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CoreButton = New System.Windows.Forms.Button()
        Me.ExtremeLabel = New System.Windows.Forms.Label()
        Me.SaveLogs = New System.Windows.Forms.Button()
        Me.DoMakesureSwitch = New System.Windows.Forms.CheckBox()
        Me.Logs = New System.Windows.Forms.ListBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.timepool = New RandomMakerv6PP.UserControl1()
        Me.pool = New RandomMakerv6PP.UserControl1()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Saver = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.ImportButton = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RepeatSwitch = New System.Windows.Forms.CheckBox()
        Me.Debugselect = New System.Windows.Forms.Button()
        Me.ExtremeSwitch = New System.Windows.Forms.CheckBox()
        Me.ItemSwitch = New System.Windows.Forms.RadioButton()
        Me.NumberSwitch = New System.Windows.Forms.RadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PreviewDialog = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DialogBase = New System.Windows.Forms.ComboBox()
        Me.ReDiveP = New System.Windows.Forms.LinkLabel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.VoiceSpeedBase = New System.Windows.Forms.ComboBox()
        Me.BackGroundBase = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PersonalizeFonts = New System.Windows.Forms.Button()
        Me.PersonalizeColor = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.StudentsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet1 = New RandomMakerv6PP.Database1DataSet1()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New RandomMakerv6PP.Database1DataSet()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        Me.StudentsTableAdapter = New RandomMakerv6PP.Database1DataSetTableAdapters.StudentsTableAdapter()
        Me.StudentsTableAdapter1 = New RandomMakerv6PP.Database1DataSet1TableAdapters.StudentsTableAdapter()
        Me.RoundDisplay = New Sunny.UI.UILedDisplay()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainDialog
        '
        Me.MainDialog.AutoEllipsis = True
        Me.MainDialog.BackColor = System.Drawing.Color.Transparent
        Me.MainDialog.Cursor = System.Windows.Forms.Cursors.Cross
        Me.MainDialog.Font = New System.Drawing.Font("方正像素12", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MainDialog.ForeColor = System.Drawing.Color.Black
        Me.MainDialog.Image = Global.RandomMakerv6PP.My.Resources.Resources.PtDialog
        Me.MainDialog.Location = New System.Drawing.Point(38, 3)
        Me.MainDialog.Name = "MainDialog"
        Me.MainDialog.Size = New System.Drawing.Size(398, 72)
        Me.MainDialog.TabIndex = 1
        Me.MainDialog.Text = "准备就绪.点击""抽取""键抽号."
        Me.MainDialog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ColorDialog1
        '
        Me.ColorDialog1.AnyColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.更多ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(513, 25)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '更多ToolStripMenuItem
        '
        Me.更多ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.更新记录ToolStripMenuItem, Me.关于ToolStripMenuItem})
        Me.更多ToolStripMenuItem.Name = "更多ToolStripMenuItem"
        Me.更多ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.更多ToolStripMenuItem.Text = "更多"
        '
        '更新记录ToolStripMenuItem
        '
        Me.更新记录ToolStripMenuItem.Name = "更新记录ToolStripMenuItem"
        Me.更新记录ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.更新记录ToolStripMenuItem.Text = "更新记录"
        '
        '关于ToolStripMenuItem
        '
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.关于ToolStripMenuItem.Text = "关于"
        '
        'FontDialog1
        '
        Me.FontDialog1.AllowVerticalFonts = False
        Me.FontDialog1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FontDialog1.FontMustExist = True
        '
        'ModeSelection
        '
        Me.ModeSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ModeSelection.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ModeSelection.FormattingEnabled = True
        Me.ModeSelection.Items.AddRange(New Object() {"英语/语文模式(正常)", "英语/语文模式(极限)", "数据驱动模式Normal", "数据驱动模式Premium"})
        Me.ModeSelection.Location = New System.Drawing.Point(6, 96)
        Me.ModeSelection.MaxDropDownItems = 10
        Me.ModeSelection.Name = "ModeSelection"
        Me.ModeSelection.Size = New System.Drawing.Size(163, 25)
        Me.ModeSelection.TabIndex = 13
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 386)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(513, 22)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(249, 17)
        Me.ToolStripStatusLabel2.Spring = True
        Me.ToolStripStatusLabel2.Text = "Now Loading..."
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(249, 17)
        Me.ToolStripStatusLabel3.Spring = True
        Me.ToolStripStatusLabel3.Text = "Now Loading..."
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(137, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.ToolStripMenuItem1.Text = "快速初始化"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.ToolStripSeparator2, Me.ToolStripLabel3, Me.ToolStripSeparator3, Me.ToolStripLabel4, Me.ToolStripSeparator4, Me.ToolStripLabel5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(87, 361)
        Me.ToolStrip1.TabIndex = 20
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripLabel1.Image = Global.RandomMakerv6PP.My.Resources.Resources.Bag_精灵球_Sprite
        Me.ToolStripLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripLabel1.IsLink = True
        Me.ToolStripLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.ToolStripLabel1.LinkColor = System.Drawing.Color.Black
        Me.ToolStripLabel1.LinkVisited = True
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.ToolStripLabel1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 25)
        Me.ToolStripLabel1.Size = New System.Drawing.Size(84, 55)
        Me.ToolStripLabel1.Text = "主页"
        Me.ToolStripLabel1.ToolTipText = "抽号发生器的主面板"
        Me.ToolStripLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(84, 6)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Black
        Me.ToolStripLabel2.Image = Global.RandomMakerv6PP.My.Resources.Resources.Bag_弱点保险_Sprite
        Me.ToolStripLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripLabel2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripLabel2.IsLink = True
        Me.ToolStripLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.ToolStripLabel2.LinkColor = System.Drawing.Color.Black
        Me.ToolStripLabel2.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.ToolStripLabel2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 25)
        Me.ToolStripLabel2.Size = New System.Drawing.Size(84, 55)
        Me.ToolStripLabel2.Text = "参数设置"
        Me.ToolStripLabel2.ToolTipText = "对抽取参数，行为进行设置"
        Me.ToolStripLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(84, 6)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel3.ForeColor = System.Drawing.Color.Black
        Me.ToolStripLabel3.Image = Global.RandomMakerv6PP.My.Resources.Resources.Bag_讲究围巾_Sprite
        Me.ToolStripLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripLabel3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripLabel3.IsLink = True
        Me.ToolStripLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.ToolStripLabel3.LinkColor = System.Drawing.Color.Black
        Me.ToolStripLabel3.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Padding = New System.Windows.Forms.Padding(0, 0, 0, 25)
        Me.ToolStripLabel3.Size = New System.Drawing.Size(84, 55)
        Me.ToolStripLabel3.Text = "个性化"
        Me.ToolStripLabel3.ToolTipText = "个性化设置，如背景等"
        Me.ToolStripLabel3.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(84, 6)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel4.ForeColor = System.Drawing.Color.Black
        Me.ToolStripLabel4.Image = Global.RandomMakerv6PP.My.Resources.Resources.Bag_吃剩的东西_Sprite
        Me.ToolStripLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripLabel4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripLabel4.IsLink = True
        Me.ToolStripLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.ToolStripLabel4.LinkColor = System.Drawing.Color.Black
        Me.ToolStripLabel4.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Padding = New System.Windows.Forms.Padding(0, 0, 0, 25)
        Me.ToolStripLabel4.Size = New System.Drawing.Size(84, 55)
        Me.ToolStripLabel4.Text = "数据库"
        Me.ToolStripLabel4.ToolTipText = "数据库模式专属的选项"
        Me.ToolStripLabel4.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(84, 6)
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Image = Global.RandomMakerv6PP.My.Resources.Resources.Bag_生命宝珠_Sprite
        Me.ToolStripLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripLabel5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripLabel5.IsLink = True
        Me.ToolStripLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.ToolStripLabel5.LinkColor = System.Drawing.Color.Black
        Me.ToolStripLabel5.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Padding = New System.Windows.Forms.Padding(0, 0, 0, 25)
        Me.ToolStripLabel5.Size = New System.Drawing.Size(84, 55)
        Me.ToolStripLabel5.Text = "重置"
        Me.ToolStripLabel5.ToolTipText = "重置抽取记录"
        Me.ToolStripLabel5.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.RoundDisplay)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.CoreButton)
        Me.Panel1.Controls.Add(Me.ExtremeLabel)
        Me.Panel1.Controls.Add(Me.SaveLogs)
        Me.Panel1.Controls.Add(Me.DoMakesureSwitch)
        Me.Panel1.Controls.Add(Me.MainDialog)
        Me.Panel1.Controls.Add(Me.Logs)
        Me.Panel1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Panel1.Location = New System.Drawing.Point(55, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(455, 359)
        Me.Panel1.TabIndex = 21
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.BackgroundImage = Global.RandomMakerv6PP.My.Resources.Resources.bton1
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button8.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(267, 296)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(80, 32)
        Me.Button8.TabIndex = 31
        Me.Button8.Text = "Test"
        Me.Button8.UseVisualStyleBackColor = False
        Me.Button8.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TimesDisplay)
        Me.GroupBox4.Controls.Add(Me.RangeDisplay)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.ModeSelection)
        Me.GroupBox4.Location = New System.Drawing.Point(261, 94)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(178, 143)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "配置"
        '
        'TimesDisplay
        '
        Me.TimesDisplay.BackColor = System.Drawing.Color.Black
        Me.TimesDisplay.CharCount = 3
        Me.TimesDisplay.Font = New System.Drawing.Font("微软雅黑", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TimesDisplay.ForeColor = System.Drawing.Color.Lime
        Me.TimesDisplay.IntervalOn = 1
        Me.TimesDisplay.Location = New System.Drawing.Point(105, 55)
        Me.TimesDisplay.Name = "TimesDisplay"
        Me.TimesDisplay.Size = New System.Drawing.Size(45, 27)
        Me.TimesDisplay.TabIndex = 33
        Me.TimesDisplay.Text = "90002"
        '
        'RangeDisplay
        '
        Me.RangeDisplay.BackColor = System.Drawing.Color.Black
        Me.RangeDisplay.CharCount = 3
        Me.RangeDisplay.Font = New System.Drawing.Font("微软雅黑", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RangeDisplay.ForeColor = System.Drawing.Color.Lime
        Me.RangeDisplay.IntervalOn = 1
        Me.RangeDisplay.Location = New System.Drawing.Point(104, 22)
        Me.RangeDisplay.Name = "RangeDisplay"
        Me.RangeDisplay.Size = New System.Drawing.Size(45, 27)
        Me.RangeDisplay.TabIndex = 32
        Me.RangeDisplay.Text = "90002"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(26, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 19)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "抽取次数:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(25, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 19)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "抽取范围:"
        '
        'CoreButton
        '
        Me.CoreButton.BackgroundImage = Global.RandomMakerv6PP.My.Resources.Resources.bton1
        Me.CoreButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CoreButton.FlatAppearance.BorderSize = 0
        Me.CoreButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CoreButton.Font = New System.Drawing.Font("微软雅黑", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CoreButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CoreButton.Location = New System.Drawing.Point(302, 239)
        Me.CoreButton.Name = "CoreButton"
        Me.CoreButton.Size = New System.Drawing.Size(96, 43)
        Me.CoreButton.TabIndex = 29
        Me.CoreButton.Text = "抽取"
        Me.CoreButton.UseVisualStyleBackColor = True
        '
        'ExtremeLabel
        '
        Me.ExtremeLabel.AutoSize = True
        Me.ExtremeLabel.BackColor = System.Drawing.Color.Transparent
        Me.ExtremeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ExtremeLabel.Font = New System.Drawing.Font("微软雅黑", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ExtremeLabel.ForeColor = System.Drawing.Color.Red
        Me.ExtremeLabel.Location = New System.Drawing.Point(164, 328)
        Me.ExtremeLabel.Name = "ExtremeLabel"
        Me.ExtremeLabel.Size = New System.Drawing.Size(101, 21)
        Me.ExtremeLabel.TabIndex = 27
        Me.ExtremeLabel.Text = "极限模式警告"
        Me.ExtremeLabel.Visible = False
        '
        'SaveLogs
        '
        Me.SaveLogs.BackColor = System.Drawing.Color.Transparent
        Me.SaveLogs.BackgroundImage = Global.RandomMakerv6PP.My.Resources.Resources.bton1
        Me.SaveLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SaveLogs.FlatAppearance.BorderSize = 0
        Me.SaveLogs.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SaveLogs.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.SaveLogs.ForeColor = System.Drawing.Color.White
        Me.SaveLogs.Location = New System.Drawing.Point(349, 296)
        Me.SaveLogs.Name = "SaveLogs"
        Me.SaveLogs.Size = New System.Drawing.Size(80, 32)
        Me.SaveLogs.TabIndex = 26
        Me.SaveLogs.Text = "保存记录"
        Me.SaveLogs.UseVisualStyleBackColor = False
        Me.SaveLogs.Visible = False
        '
        'DoMakesureSwitch
        '
        Me.DoMakesureSwitch.AutoSize = True
        Me.DoMakesureSwitch.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.DoMakesureSwitch.ForeColor = System.Drawing.Color.Black
        Me.DoMakesureSwitch.Location = New System.Drawing.Point(35, 328)
        Me.DoMakesureSwitch.Name = "DoMakesureSwitch"
        Me.DoMakesureSwitch.Size = New System.Drawing.Size(123, 21)
        Me.DoMakesureSwitch.TabIndex = 25
        Me.DoMakesureSwitch.Text = "不显示确认对话框"
        Me.DoMakesureSwitch.UseVisualStyleBackColor = True
        '
        'Logs
        '
        Me.Logs.BackColor = System.Drawing.SystemColors.Info
        Me.Logs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Logs.Cursor = System.Windows.Forms.Cursors.Help
        Me.Logs.Font = New System.Drawing.Font("微软雅黑", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Logs.FormattingEnabled = True
        Me.Logs.HorizontalScrollbar = True
        Me.Logs.ItemHeight = 17
        Me.Logs.Items.AddRange(New Object() {"这里显示抽取结果的历史记录"})
        Me.Logs.Location = New System.Drawing.Point(43, 84)
        Me.Logs.Name = "Logs"
        Me.Logs.Size = New System.Drawing.Size(207, 206)
        Me.Logs.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.timepool)
        Me.Panel2.Controls.Add(Me.pool)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Saver)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.LinkLabel2)
        Me.Panel2.Controls.Add(Me.ImportButton)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Location = New System.Drawing.Point(0, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(513, 358)
        Me.Panel2.TabIndex = 22
        Me.Panel2.Visible = False
        '
        'timepool
        '
        Me.timepool.BackgroundImage = CType(resources.GetObject("timepool.BackgroundImage"), System.Drawing.Image)
        Me.timepool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.timepool.BlueText = "抽取次数"
        Me.timepool.Font = New System.Drawing.Font("方正粗圆_GBK", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.timepool.Location = New System.Drawing.Point(94, 53)
        Me.timepool.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.timepool.Maximum = 7
        Me.timepool.Minimum = 1
        Me.timepool.Name = "timepool"
        Me.timepool.Size = New System.Drawing.Size(417, 51)
        Me.timepool.TabIndex = 35
        Me.timepool.Type = 0
        Me.timepool.Value = 1
        Me.timepool.Warn = False
        '
        'pool
        '
        Me.pool.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pool.BackgroundImage = CType(resources.GetObject("pool.BackgroundImage"), System.Drawing.Image)
        Me.pool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pool.BlueText = "抽取范围"
        Me.pool.Font = New System.Drawing.Font("方正粗圆_GBK", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.pool.Location = New System.Drawing.Point(94, 102)
        Me.pool.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pool.Maximum = 100
        Me.pool.Minimum = 1
        Me.pool.Name = "pool"
        Me.pool.Size = New System.Drawing.Size(417, 51)
        Me.pool.TabIndex = 37
        Me.pool.Type = 1
        Me.pool.Value = 16
        Me.pool.Warn = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.RandomMakerv6PP.My.Resources.Resources.设置主界面
        Me.PictureBox2.Location = New System.Drawing.Point(85, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(426, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'Saver
        '
        Me.Saver.BackColor = System.Drawing.Color.Transparent
        Me.Saver.BackgroundImage = Global.RandomMakerv6PP.My.Resources.Resources.bton1
        Me.Saver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Saver.FlatAppearance.BorderSize = 0
        Me.Saver.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Saver.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Saver.ForeColor = System.Drawing.Color.White
        Me.Saver.Location = New System.Drawing.Point(271, 246)
        Me.Saver.Name = "Saver"
        Me.Saver.Size = New System.Drawing.Size(80, 32)
        Me.Saver.TabIndex = 31
        Me.Saver.Text = "编辑..."
        Me.Saver.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(139, 252)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 20)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "添加和删除模式"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(333, 304)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(129, 20)
        Me.LinkLabel2.TabIndex = 28
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "还原全部默认设置" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ImportButton
        '
        Me.ImportButton.BackColor = System.Drawing.Color.Transparent
        Me.ImportButton.BackgroundImage = Global.RandomMakerv6PP.My.Resources.Resources.bton1
        Me.ImportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImportButton.FlatAppearance.BorderSize = 0
        Me.ImportButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ImportButton.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ImportButton.ForeColor = System.Drawing.Color.White
        Me.ImportButton.Location = New System.Drawing.Point(119, 296)
        Me.ImportButton.Name = "ImportButton"
        Me.ImportButton.Size = New System.Drawing.Size(80, 32)
        Me.ImportButton.TabIndex = 26
        Me.ImportButton.Text = "导入配置"
        Me.ImportButton.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = Global.RandomMakerv6PP.My.Resources.Resources.bton1
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button5.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(205, 296)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 32)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "导出配置"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RepeatSwitch)
        Me.GroupBox3.Controls.Add(Me.Debugselect)
        Me.GroupBox3.Controls.Add(Me.ExtremeSwitch)
        Me.GroupBox3.Controls.Add(Me.ItemSwitch)
        Me.GroupBox3.Controls.Add(Me.NumberSwitch)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(98, 151)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(373, 92)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "数据相关"
        '
        'RepeatSwitch
        '
        Me.RepeatSwitch.AutoSize = True
        Me.RepeatSwitch.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RepeatSwitch.ForeColor = System.Drawing.Color.Black
        Me.RepeatSwitch.Location = New System.Drawing.Point(143, 26)
        Me.RepeatSwitch.Name = "RepeatSwitch"
        Me.RepeatSwitch.Size = New System.Drawing.Size(75, 21)
        Me.RepeatSwitch.TabIndex = 33
        Me.RepeatSwitch.Text = "允许重复"
        Me.RepeatSwitch.UseVisualStyleBackColor = True
        '
        'Debugselect
        '
        Me.Debugselect.BackColor = System.Drawing.Color.Transparent
        Me.Debugselect.BackgroundImage = Global.RandomMakerv6PP.My.Resources.Resources.bton1
        Me.Debugselect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Debugselect.FlatAppearance.BorderSize = 0
        Me.Debugselect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Debugselect.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Debugselect.ForeColor = System.Drawing.Color.White
        Me.Debugselect.Location = New System.Drawing.Point(241, 46)
        Me.Debugselect.Name = "Debugselect"
        Me.Debugselect.Size = New System.Drawing.Size(80, 32)
        Me.Debugselect.TabIndex = 32
        Me.Debugselect.Text = "Debug"
        Me.Debugselect.UseVisualStyleBackColor = False
        '
        'ExtremeSwitch
        '
        Me.ExtremeSwitch.AutoSize = True
        Me.ExtremeSwitch.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ExtremeSwitch.ForeColor = System.Drawing.Color.Black
        Me.ExtremeSwitch.Location = New System.Drawing.Point(43, 26)
        Me.ExtremeSwitch.Name = "ExtremeSwitch"
        Me.ExtremeSwitch.Size = New System.Drawing.Size(75, 21)
        Me.ExtremeSwitch.TabIndex = 26
        Me.ExtremeSwitch.Text = "极限模式"
        Me.ExtremeSwitch.UseVisualStyleBackColor = True
        '
        'ItemSwitch
        '
        Me.ItemSwitch.AutoSize = True
        Me.ItemSwitch.Font = New System.Drawing.Font("微软雅黑", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ItemSwitch.ForeColor = System.Drawing.Color.Black
        Me.ItemSwitch.Location = New System.Drawing.Point(143, 51)
        Me.ItemSwitch.Name = "ItemSwitch"
        Me.ItemSwitch.Size = New System.Drawing.Size(87, 23)
        Me.ItemSwitch.TabIndex = 9
        Me.ItemSwitch.Text = "数据驱动"
        Me.ItemSwitch.UseVisualStyleBackColor = True
        '
        'NumberSwitch
        '
        Me.NumberSwitch.AutoSize = True
        Me.NumberSwitch.Checked = True
        Me.NumberSwitch.Font = New System.Drawing.Font("微软雅黑", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.NumberSwitch.ForeColor = System.Drawing.Color.Black
        Me.NumberSwitch.Location = New System.Drawing.Point(43, 52)
        Me.NumberSwitch.Name = "NumberSwitch"
        Me.NumberSwitch.Size = New System.Drawing.Size(72, 23)
        Me.NumberSwitch.TabIndex = 8
        Me.NumberSwitch.TabStop = True
        Me.NumberSwitch.Text = "随机数"
        Me.NumberSwitch.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.PreviewDialog)
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Location = New System.Drawing.Point(55, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(458, 353)
        Me.Panel3.TabIndex = 23
        '
        'PreviewDialog
        '
        Me.PreviewDialog.AutoEllipsis = True
        Me.PreviewDialog.BackColor = System.Drawing.Color.Transparent
        Me.PreviewDialog.Cursor = System.Windows.Forms.Cursors.No
        Me.PreviewDialog.Font = New System.Drawing.Font("方正像素12", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.PreviewDialog.ForeColor = System.Drawing.Color.Black
        Me.PreviewDialog.Image = Global.RandomMakerv6PP.My.Resources.Resources.PtDialog
        Me.PreviewDialog.Location = New System.Drawing.Point(41, 17)
        Me.PreviewDialog.Name = "PreviewDialog"
        Me.PreviewDialog.Size = New System.Drawing.Size(399, 71)
        Me.PreviewDialog.TabIndex = 10
        Me.PreviewDialog.Text = "这里显示对话框的预览效果."
        Me.PreviewDialog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.DialogBase)
        Me.GroupBox2.Controls.Add(Me.ReDiveP)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.VoiceSpeedBase)
        Me.GroupBox2.Controls.Add(Me.BackGroundBase)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.PersonalizeFonts)
        Me.GroupBox2.Controls.Add(Me.PersonalizeColor)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(58, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(371, 225)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "个性化"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(26, 108)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 20)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "更换对话框:"
        '
        'DialogBase
        '
        Me.DialogBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DialogBase.FormattingEnabled = True
        Me.DialogBase.Items.AddRange(New Object() {"Pt(默认)", "HGSS", "DP", "E", "ORAS"})
        Me.DialogBase.Location = New System.Drawing.Point(129, 103)
        Me.DialogBase.Name = "DialogBase"
        Me.DialogBase.Size = New System.Drawing.Size(172, 28)
        Me.DialogBase.TabIndex = 17
        '
        'ReDiveP
        '
        Me.ReDiveP.AutoSize = True
        Me.ReDiveP.Location = New System.Drawing.Point(49, 200)
        Me.ReDiveP.Name = "ReDiveP"
        Me.ReDiveP.Size = New System.Drawing.Size(129, 20)
        Me.ReDiveP.TabIndex = 16
        Me.ReDiveP.TabStop = True
        Me.ReDiveP.Text = "还原本页默认设置" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(71, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 20)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "语速:"
        '
        'VoiceSpeedBase
        '
        Me.VoiceSpeedBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VoiceSpeedBase.FormattingEnabled = True
        Me.VoiceSpeedBase.Items.AddRange(New Object() {"快", "中", "慢"})
        Me.VoiceSpeedBase.Location = New System.Drawing.Point(129, 145)
        Me.VoiceSpeedBase.Name = "VoiceSpeedBase"
        Me.VoiceSpeedBase.Size = New System.Drawing.Size(63, 28)
        Me.VoiceSpeedBase.TabIndex = 13
        '
        'BackGroundBase
        '
        Me.BackGroundBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BackGroundBase.FormattingEnabled = True
        Me.BackGroundBase.Items.AddRange(New Object() {"推荐邮件(PICK UP)", "天空邮件", "空间邮件", "彩嵌邮件", "青草邮件", "火焰邮件", "水蓝邮件", "暴雪邮件", "钢铁邮件", "砖块邮件", "隧道邮件", "绽放邮件", "甜蜜邮件", "初次邮件", "邀请邮件", "回复邮件", "喜爱邮件", "感谢邮件", "桥梁邮件W", "桥梁邮件C", "桥梁邮件V", "桥梁邮件H", "桥梁邮件S"})
        Me.BackGroundBase.Location = New System.Drawing.Point(129, 64)
        Me.BackGroundBase.Name = "BackGroundBase"
        Me.BackGroundBase.Size = New System.Drawing.Size(172, 28)
        Me.BackGroundBase.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(41, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "更换背景:"
        '
        'PersonalizeFonts
        '
        Me.PersonalizeFonts.BackgroundImage = Global.RandomMakerv6PP.My.Resources.Resources.bton1
        Me.PersonalizeFonts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PersonalizeFonts.FlatAppearance.BorderSize = 0
        Me.PersonalizeFonts.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.PersonalizeFonts.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.PersonalizeFonts.ForeColor = System.Drawing.SystemColors.Window
        Me.PersonalizeFonts.Location = New System.Drawing.Point(192, 23)
        Me.PersonalizeFonts.Name = "PersonalizeFonts"
        Me.PersonalizeFonts.Size = New System.Drawing.Size(80, 32)
        Me.PersonalizeFonts.TabIndex = 10
        Me.PersonalizeFonts.Text = "自定义字体"
        Me.PersonalizeFonts.UseVisualStyleBackColor = True
        '
        'PersonalizeColor
        '
        Me.PersonalizeColor.BackgroundImage = Global.RandomMakerv6PP.My.Resources.Resources.bton1
        Me.PersonalizeColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PersonalizeColor.FlatAppearance.BorderSize = 0
        Me.PersonalizeColor.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.PersonalizeColor.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.PersonalizeColor.ForeColor = System.Drawing.SystemColors.Window
        Me.PersonalizeColor.Location = New System.Drawing.Point(78, 23)
        Me.PersonalizeColor.Name = "PersonalizeColor"
        Me.PersonalizeColor.Size = New System.Drawing.Size(80, 32)
        Me.PersonalizeColor.TabIndex = 9
        Me.PersonalizeColor.Text = "自定义颜色"
        Me.PersonalizeColor.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.DataGridView1)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(51, 29)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(459, 357)
        Me.Panel4.TabIndex = 24
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewCheckBoxColumn1})
        Me.DataGridView1.DataSource = Me.StudentsBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(97, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(336, 278)
        Me.DataGridView1.TabIndex = 34
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "IsChecked"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "IsChecked"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'StudentsBindingSource1
        '
        Me.StudentsBindingSource1.DataMember = "Students"
        Me.StudentsBindingSource1.DataSource = Me.Database1DataSet1
        '
        'Database1DataSet1
        '
        Me.Database1DataSet1.DataSetName = "Database1DataSet1"
        Me.Database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(153, 307)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(287, 19)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "提示:选中某个对象以在实际抽取中忽略它."
        '
        'StudentsBindingSource
        '
        Me.StudentsBindingSource.DataMember = "Students"
        Me.StudentsBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.CreatePrompt = True
        Me.SaveFileDialog1.DefaultExt = "Json"
        Me.SaveFileDialog1.FileName = "RMConfig"
        Me.SaveFileDialog1.Filter = "JSON源文件|*.Json"
        Me.SaveFileDialog1.InitialDirectory = """D:\"""
        Me.SaveFileDialog1.RestoreDirectory = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.AddExtension = False
        Me.OpenFileDialog1.DefaultExt = "Json"
        Me.OpenFileDialog1.FileName = "default"
        Me.OpenFileDialog1.Filter = "JSON源文件|*.json"
        Me.OpenFileDialog1.RestoreDirectory = True
        Me.OpenFileDialog1.ValidateNames = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 25
        '
        'Timer3
        '
        Me.Timer3.Interval = 50
        '
        'Timer4
        '
        Me.Timer4.Interval = 25
        '
        'SaveFileDialog2
        '
        Me.SaveFileDialog2.CreatePrompt = True
        Me.SaveFileDialog2.DefaultExt = "txt"
        Me.SaveFileDialog2.Filter = "文本文件|*.txt"
        Me.SaveFileDialog2.InitialDirectory = "D:\"
        Me.SaveFileDialog2.Title = "保存抽取记录"
        '
        'StudentsTableAdapter
        '
        Me.StudentsTableAdapter.ClearBeforeFill = True
        '
        'StudentsTableAdapter1
        '
        Me.StudentsTableAdapter1.ClearBeforeFill = True
        '
        'RoundDisplay
        '
        Me.RoundDisplay.BackColor = System.Drawing.Color.Black
        Me.RoundDisplay.CharCount = 5
        Me.RoundDisplay.Font = New System.Drawing.Font("微软雅黑", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RoundDisplay.ForeColor = System.Drawing.Color.Lime
        Me.RoundDisplay.IntervalOn = 1
        Me.RoundDisplay.Location = New System.Drawing.Point(150, 295)
        Me.RoundDisplay.Name = "RoundDisplay"
        Me.RoundDisplay.Size = New System.Drawing.Size(69, 27)
        Me.RoundDisplay.TabIndex = 34
        Me.RoundDisplay.Text = "90002"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 19)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "抽取回数:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.RandomMakerv6PP.My.Resources.Resources.推荐邮件
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(513, 408)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("微软雅黑", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "减速风扇抽号发生器.NET 6.0.0 ""LANDSLIDE"""
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainDialog As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 更多ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 更新记录ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 关于ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ModeSelection As ComboBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Logs As ListBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents ItemSwitch As RadioButton
    Friend WithEvents NumberSwitch As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PersonalizeFonts As Button
    Friend WithEvents PersonalizeColor As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BackGroundBase As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DoMakesureSwitch As CheckBox
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents PreviewDialog As Label
    Friend WithEvents SaveLogs As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Label10 As Label
    Friend WithEvents VoiceSpeedBase As ComboBox
    Friend WithEvents Timer4 As Timer
    Friend WithEvents ImportButton As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ReDiveP As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Saver As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents ExtremeSwitch As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents DialogBase As ComboBox
    Friend WithEvents ExtremeLabel As Label
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripLabel5 As ToolStripLabel
    Friend WithEvents Debugselect As Button
    Friend WithEvents SaveFileDialog2 As SaveFileDialog
    Friend WithEvents CoreButton As Button
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsCheckedDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents RepeatSwitch As CheckBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents StudentsBindingSource As BindingSource
    Friend WithEvents StudentsTableAdapter As Database1DataSetTableAdapters.StudentsTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Database1DataSet1 As Database1DataSet1
    Friend WithEvents StudentsBindingSource1 As BindingSource
    Friend WithEvents StudentsTableAdapter1 As Database1DataSet1TableAdapters.StudentsTableAdapter
    Friend WithEvents timepool As UserControl1
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pool As UserControl1
    Friend WithEvents RangeDisplay As Sunny.UI.UILedDisplay
    Friend WithEvents TimesDisplay As Sunny.UI.UILedDisplay
    Friend WithEvents Label1 As Label
    Friend WithEvents RoundDisplay As Sunny.UI.UILedDisplay
End Class
