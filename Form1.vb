Imports System.Web.Script.Serialization
Imports System.IO
Imports System.Data.OleDb
Imports System.Text
Imports RandomMakerv6PP.Configs
Public Class Form1

    '=========定义公用变量=========
    Public circle, tms, ranges, memories, dataRange, makesure, checked, checked2 As Integer, DialogText As String

    '抽取核心变量，不可以更改
    Public memo, dodata, def, DeadLocker, doextreme, donew, dorepeat As Boolean, lock As Boolean = True

    '记忆模式，判定变量，不可以修改
    Public Area, mimo, seo As Integer

    '最大范围，单列
    Public Const readme As String = "这里可以显示对话框的预览效果.", opening As String = "准备就绪.点击抽取键抽号."
    Public Const ver As String = "6.0.0"
    Public Const fast As Integer = 10, medium As Integer = 25, slow As Integer = 100
    '常量列表

    Public Setting As New Configs()
    '核心参数
    Public DoReadOnly As Boolean
    '控制对话框是否为单按钮
    Public JsonWord As String
    Public reader As New JavaScriptSerializer

    '内部存储

    '=======Page 1 of 4,主页=======
    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ModeSelection.SelectedIndexChanged
        If memo = True Then Exit Sub
        If def = True Then
            Dim xr As Int16
            lock = True
            donew = False
            xr = ModeSelection.SelectedIndex
            tms = Setting.ModeCollections(xr).Times
            timepool.Value = tms
            If Setting.ModeCollections(xr).Type = False Then
                ranges = Setting.ModeCollections(xr).Range
                pool.Maximum = 100
                pool.Value = ranges
                NumberSwitch.Checked = True
                ItemSwitch.Checked = False
                dodata = False
                ToolStripLabel4.Enabled = False
                RangeDisplay.Text = Str(ranges)
                dorepeat = False
                RepeatSwitch.Enabled = False
                If DeadLocker = True Then
                    Logs.Items.Clear()
                    DialogText = "随机数模式已就绪.等待抽取."
                    Logs.Items.Add(Setting.ModeCollections(xr).Name & "就绪.")
                End If
                ToolStripLabel4.Enabled = False
            Else
                dataRange = Setting.ModeCollections(xr).Range
                pool.Maximum = Setting.MaxArea
                pool.Value = dataRange
                ToolStripLabel4.Enabled = True
                dodata = True
                NumberSwitch.Checked = False
                ItemSwitch.Checked = True
                RangeDisplay.Text = Str(dataRange)
                RepeatSwitch.Enabled = True
                RepeatSwitch.Checked = Setting.ModeCollections(xr).DoRepeat
                If DeadLocker = True Then
                    Logs.Items.Clear()
                    DialogText = "数据库模式已就绪.等待抽取."
                    Logs.Items.Add(Setting.ModeCollections(xr).Name & "就绪.")
                End If
                ToolStripLabel4.Enabled = True
            End If
            If DeadLocker = True Then
                memories = 0
            End If
            TimesDisplay.Text = Str(timepool.Value)
            If Setting.ModeCollections(xr).DoExtreme = True Then
                ExtremeSwitch.Checked = True
                doextreme = True
                CoreButton.Enabled = True
                ExtremeLabel.Visible = True
            Else
                ExtremeSwitch.Checked = False
                doextreme = False
                CoreButton.Enabled = True
                ExtremeLabel.Visible = False
            End If
            ToolStripStatusLabel3.Text = "当前模式:" & Setting.ModeCollections(xr).Name
            Call ColorSwitch(xc:=xr)
        End If
        ToolStripLabel5.Enabled = True
        Timer2.Enabled = True
        lock = False
    End Sub

    '模式切换OK
    Private Sub ColorSwitch(ByVal xc As Integer)
        Select Case xc + 1
            Case Is = 0
                Logs.ResetForeColor()
            Case Is = 1
                Logs.ForeColor = Color.Blue
            Case Is = 2
                Logs.ForeColor = Color.Red
            Case Is = 3
                Logs.ForeColor = Color.Purple
            Case Is = 4
                Logs.ForeColor = Color.DarkGoldenrod
            Case Is = 5
                Logs.ForeColor = Color.IndianRed
            Case Is = 6
                Logs.ForeColor = Color.DarkOrange
            Case Is = 8
                Logs.ForeColor = Color.Gray
            Case Is = 9
                Logs.ForeColor = Color.Olive
            Case Is = 10
                Logs.ForeColor = Color.DarkCyan
            Case Is = 7
                Logs.ForeColor = Color.Brown
        End Select
    End Sub

    '颜色切换核心程序

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CoreButton.Click
        Call CoreProgram()
    End Sub

    '核心程序触发

    Public Sub CoreProgram()
        Dim datas, tmsreal As Integer, temp As String
        Dim selCell As DataGridViewCell
        If makesure = 0 Then
CX8:
            If doextreme = False Then
                If MsgBox("都准备好了吗?" & Chr(13) & Chr(10) & "抽取模式:" & Setting.ModeCollections(Setting.CurrentMode).Name & Chr(13) & Chr(10) & "抽取次数:" & Str(tms), vbOKCancel + vbQuestion, "确认对话框") <> MsgBoxResult.Ok Then Exit Sub
            Else
                If MsgBox("都准备好了吗?" & Chr(13) & Chr(10) & "抽取模式:" & Setting.ModeCollections(Setting.CurrentMode).Name & Chr(13) & Chr(10) & "抽取次数:" & Str(tms) & Chr(13) & Chr(10) & "警告!该模式为极限模式,抽取后将无法重复,确定吗?", vbOKCancel + vbCritical, "确认对话框") <> MsgBoxResult.Ok Then
                    Exit Sub
                End If
            End If
        End If
        tmsreal = tms - 1
        memories = 1 + memories
        ProgressBar1.Value = 10
        '随机数模式
        If dodata = False Then
            Dim repeat(6) As Int16
CX1:
            Randomize()
            datas = Rnd() * ranges
            If datas = 0 Then GoTo CX1
            DialogText = "抽出数值:" & Str(datas)
            temp = "第" & Str(memories) & "次:" & Str(datas)
            ProgressBar1.Value = 50
            For circle = 1 To tmsreal
CX2:
                Randomize()
                datas = Rnd() * ranges
                If datas = 0 Then GoTo CX2
                If dorepeat = False Then
                    repeat(circle) = datas
                    Dim repeat2 As Integer
                    For repeat2 = 0 To circle - 1 Step 1
                        If repeat(repeat2) = datas Then GoTo CX2
                    Next
                End If
                DialogText = DialogText & "/" & Str(datas)
                temp = temp & "/" & Str(datas)
            Next
            ProgressBar1.Value = 75
            Logs.Items.Add(temp)
            If doextreme = True Then
                Logs.Items.Add("极限模式抽取已结束!")
                CoreButton.Enabled = False
                ProgressBar1.Value = 99
            End If
            SaveLogs.Visible = True
            ProgressBar1.Value = 100
            Timer2.Enabled = True
        ElseIf dodata = True Then
            '数据模式1
            Try
                ProgressBar1.Value = 30
                Dim repeat(6), errortimes As Integer, trigger As Integer = 1
                If errortimes = 1 Then
                    MsgBox("警告:" & "请检查数据库中是否存在可以抽出的项！", vbCritical + vbOKOnly, "错误")
                    Exit Sub
                End If
                '一次监测
                Do
                    selCell = DataGridView1(2, trigger)
                    trigger += 1
                Loop Until selCell.Value = False
                '监测范围内是否有可用项
CX7:
                ProgressBar1.Value = 50
                Randomize()
                datas = Rnd() * (dataRange - 1)
                If datas > Setting.MaxArea Then GoTo CX7
                repeat(0) = datas
                selCell = DataGridView1(1, datas)
                temp = selCell.Value
                If temp = "" Then GoTo CX7
                selCell = DataGridView1(2, datas)
                If selCell.Value = False Then
                    DialogText = "抽取对象:" & temp
                    temp = "第" & Str(memories) & "次:" & temp
                    ProgressBar1.Value = 60
                    For circle = 1 To tmsreal Step 1
CX6:
                        Randomize()
                        datas = Rnd() * (dataRange - 1)
                        'If datas = 0 Then GoTo CX6
                        selCell = DataGridView1(1, datas)
                        ProgressBar1.Value = 70
                        selCell = DataGridView1(2, datas)
                        If selCell.Value = False Then
                            If dorepeat = False Then
                                repeat(circle) = datas
                                Dim repeat2 As Integer
                                For repeat2 = 0 To circle - 1 Step 1
                                    If repeat(repeat2) = datas Then GoTo CX6
                                Next
                            End If
                        Else
                            GoTo CX6
                        End If
                        selCell = DataGridView1(1, datas)
                        DialogText += "/" & selCell.Value
                        temp = temp & "/" & selCell.Value
                    Next
                    ProgressBar1.Value = 90
                    Logs.Items.Add(temp)
                Else
                    GoTo CX7
                End If
                If doextreme = True Then
                    Logs.Items.Add("极限模式抽取已结束!")
                    CoreButton.Enabled = False
                    ProgressBar1.Value = 80
                End If
            Catch ex As Exception
                MsgBox("警告:" & Err.Description, vbCritical + vbOKOnly, "错误")
            End Try
        End If
        ProgressBar1.Value = 100
        SaveLogs.Visible = True
        Timer2.Enabled = True
        ToolStripLabel5.Enabled = True
    End Sub

    '核心程序

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles DoMakesureSwitch.CheckedChanged
        If lock = True Then Exit Sub
        If DoMakesureSwitch.Checked = True Then
            makesure = 1
        Else
            makesure = 0
        End If
    End Sub

    '确认对话框控制

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles SaveLogs.Click
        Dim dts As DateTime
        dts = Now()
        Dim dtstring As String = Timeformat(dts)
        SaveFileDialog2.FileName = "抽取记录" & dtstring
        If SaveFileDialog2.ShowDialog = DialogResult.OK Then
            Dim temp As Integer
            FileOpen(2, SaveFileDialog2.FileName, OpenMode.Output, OpenAccess.Default)
            WriteLine(2, "抽取时间" & Date.Now)
            For temp = 1 To memories
                WriteLine(2, Logs.Items.Item(temp))
            Next
            WriteLine(2, "一共抽取了" & Logs.Items.Count - 1 & "次")
            WriteLine(2, "使用的模式:" & Setting.ModeCollections(Setting.CurrentMode).Name)
            FileClose(2)
            DoReadOnly = False
            UniversalDialog1.Label1.Text = "抽取记录保存成功！"
            UniversalDialog1.ShowDialog()
        Else
            Exit Sub
        End If
    End Sub

    '保存抽取记录
    Private Sub ToolStripLabel5_Click(sender As Object, e As EventArgs) Handles ToolStripLabel5.Click
        Dim xr As Integer
        xr = ModeSelection.SelectedIndex
        donew = False
        Logs.Items.Clear()
        Logs.Items.Add(ModeSelection.Text & "就绪.")
        tms = Setting.ModeCollections(xr).Times
        Select Case dodata
            Case Is = False
                circle = 1
                timepool.Value = tms
                TimesDisplay.Text = Str(tms)
                memories = 0
                ranges = Setting.ModeCollections(xr).Range
                pool.Maximum = 100
                pool.Value = ranges
                dataRange = Nothing
                RangeDisplay.Text = Str(ranges)
                MainDialog.ForeColor = Color.Black
                ToolStripLabel4.Enabled = False
                ModeSelection.Text = Setting.ModeCollections(xr).Name
                NumberSwitch.Checked = True
                ItemSwitch.Checked = False
                RangeDisplay.Text = Str(ranges)
                TimesDisplay.Text = Str(tms)
                DialogText = "随机数模式已初始化完毕."
                ToolStripStatusLabel3.Text = "当前模式:" & Setting.ModeCollections(xr).Name
            Case Is = True
                circle = 1
                memories = 0
                dataRange = Setting.ModeCollections(xr).Range
                timepool.Value = tms
                memories = 0
                pool.Maximum = Setting.MaxArea
                pool.Value = dataRange
                MainDialog.ForeColor = Color.Black
                ToolStripLabel4.Enabled = True
                RangeDisplay.Text = Str(dataRange)
                TimesDisplay.Text = Str(tms)
                NumberSwitch.Checked = False
                ItemSwitch.Checked = True
                DialogText = "数据库模式已初始化完毕."
                ToolStripStatusLabel3.Text = "当前模式:" & Setting.ModeCollections(xr).Name
        End Select
        If Setting.ModeCollections(xr).DoExtreme = True Then
            doextreme = True
            ExtremeLabel.Visible = True
            CoreButton.Enabled = True
            ExtremeSwitch.Checked = True
        Else
            doextreme = False
            ExtremeLabel.Visible = False
            CoreButton.Enabled = True
            ExtremeSwitch.Checked = False
        End If
        Timer2.Enabled = True
        SaveLogs.Visible = False
    End Sub

    '初始化
    '=======Page 2 of 4,参数设定=======

    Private Sub 关于ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于ToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub NumericUpDown1_ValueChanged_1(sender As Object, e As EventArgs) Handles timepool.ValueChanged
        If lock = True Then Exit Sub
        tms = timepool.Value
        donew = True
        If dodata = False Then
            ModeSelection.Text = "自定义模式"
            NumberSwitch.Checked = True
            ItemSwitch.Checked = False
            RangeDisplay.Text = Str(ranges)
            TimesDisplay.Text = Str(tms)
            Logs.ForeColor = Color.Black
            ToolStripStatusLabel3.Text = "当前模式:" & ModeSelection.Text
        Else
            ModeSelection.Text = "数据库模式Personaize"
            NumberSwitch.Checked = False
            ItemSwitch.Checked = True
            RangeDisplay.Text = Str(dataRange)
            TimesDisplay.Text = Str(tms)
            Logs.ForeColor = Color.Chocolate
            ToolStripStatusLabel3.Text = "当前模式:" & ModeSelection.Text
        End If
        TextBox1.Text = ModeSelection.Text & dodata - 3
    End Sub

    '抽取次数
    Private Sub Pool_ValueChanged_1(sender As Object, e As EventArgs) Handles pool.ValueChanged
        If lock = True Then Exit Sub
        If dodata = False Then
            pool.Maximum = 100
            ranges = pool.Value
            RangeDisplay.Text = Str(ranges)
            TimesDisplay.Text = Str(timepool.Value)
            ModeSelection.Text = "自定义模式"
            ToolStripStatusLabel3.Text = "当前模式:" & ModeSelection.Text
            TextBox1.Text = "自定义模式"
        Else
            pool.Maximum = Setting.MaxArea
            dataRange = pool.Value
            RangeDisplay.Text = Str(dataRange)
            TimesDisplay.Text = Str(timepool.Value)
            ModeSelection.Text = "数据驱动模式Personaize"
            ToolStripStatusLabel3.Text = "当前模式:" & ModeSelection.Text
            TextBox1.Text = "自定义模式(数据库)"
        End If
    End Sub

    '微调范围

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles ExtremeSwitch.CheckedChanged
        If lock = True Then Exit Sub
        If doextreme = False Then
            doextreme = True
            CoreButton.Enabled = True
            ExtremeLabel.Visible = True
        Else
            doextreme = False
            CoreButton.Enabled = True
            ExtremeLabel.Visible = False
        End If

    End Sub

    '极限模式开关

    Private Sub NumberSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles NumberSwitch.CheckedChanged
        If lock = True Then Exit Sub
        If dodata <> False Then
            dodata = False
            RepeatSwitch.Enabled = False
            ModeSelection.Text = "自定义模式"
            ToolStripStatusLabel3.Text = "当前模式:" & ModeSelection.Text
            TextBox1.Text = ModeSelection.Text & Setting.TotalMode - 3
            ToolStripLabel4.Enabled = False
            ranges = pool.Value
        End If
    End Sub

    '随机数开关
    Private Sub ItemSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles ItemSwitch.CheckedChanged
        If lock = True Then Exit Sub
        If Setting.MaxArea < pool.Value Then
            MsgBox("错误!数据库模式抽取范围不应超过" & Setting.MaxArea & "!", vbOKOnly + vbCritical, "错误")
            lock = True
            ItemSwitch.Checked = False
            NumberSwitch.Checked = True
            lock = False
            Exit Sub
        End If
        If dodata <> True Then
            dodata = True
            RepeatSwitch.Enabled = True
            ModeSelection.Text = "数据库模式Personailze"
            ToolStripStatusLabel3.Text = "当前模式:" & ModeSelection.Text
            TextBox1.Text = ModeSelection.Text & Setting.TotalMode - 3
            ToolStripLabel4.Enabled = True
            dataRange = pool.Value
        End If
    End Sub

    '数据库模式开关

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        lock = True
        Dim fs As FileStream
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            fs = File.Open(SaveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write)
            Dim sw As New StreamWriter(fs, Encoding.UTF8)
            Setting.Name = SaveFileDialog1.FileName
            Dim saver As New JavaScriptSerializer
            JsonWord = saver.Serialize(Setting)
            sw.Write(JsonWord)
            sw.Close()
            fs.Close()
            UniversalDialog1.Label1.Text = "用户配置保存成功！"
            DoReadOnly = True
            UniversalDialog1.ShowDialog()
        End If
        lock = False
    End Sub

    '保存配置

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles ImportButton.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Try
                Dim fs As FileStream
                fs = File.Open(OpenFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Read)
                Dim sr As New StreamReader(fs, Encoding.UTF8)
                JsonWord = sr.ReadToEnd()
                sr.Close()
                Setting = reader.Deserialize(Of Configs)(JsonWord)
                lock = True
                ModeSelection.Items.Clear()
                For i As Integer = 0 To Setting.TotalMode - 1
                    ModeSelection.Items.Add(Setting.ModeCollections(i).Name)
                Next
                BackGroundBase.SelectedItem = Setting.ModeCollections(Setting.CurrentMode).Name
                BackGroundBase.Text = Setting.ModeCollections(Setting.CurrentMode).Name
                Timer2.Interval = Setting.Voicespeed
                lock = False
                MadePreparation()
                UniversalDialog1.Label1.Text = "用户配置载入成功！"
                DoReadOnly = True
                UniversalDialog1.ShowDialog()
            Catch g As Exception
                UniversalDialog1.Label1.Text = "载入错误！配置文件不是合法的JSON文件"
                DoReadOnly = True
                UniversalDialog1.ShowDialog()
                Exit Sub
            End Try
        Else
            Exit Sub
        End If
    End Sub

    Private Sub 更新记录ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 更新记录ToolStripMenuItem.Click
        Form3.Show()
    End Sub


    '更新记录

    '载入配置

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles RepeatSwitch.CheckedChanged
        If lock = True Then Exit Sub
        If dodata = False Then
            MsgBox("警告!该选项仅供数据库模式使用!", vbOKOnly + vbCritical, "提示")
            RepeatSwitch.Checked = False
            Exit Sub
        End If
        If dorepeat = False Then
            dorepeat = True
        Else
            dorepeat = False
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        DoReadOnly = False
        UniversalDialog1.Label1.Text = "这是测试按钮"
        If UniversalDialog1.ShowDialog() = DialogResult.OK Then
            'MsgBox("测试成功")
            DialogText = "测试成功"
            Timer2.Enabled = True
        End If
    End Sub
    '测试按钮
    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim selCell As DataGridViewCell, lblCellInfoColIndex, lblCellInfoRowIndex As Byte
        selCell = DataGridView1.CurrentCell
        lblCellInfoColIndex = selCell.ColumnIndex
        lblCellInfoRowIndex = selCell.RowIndex
        Dim odc As New OleDbConnection() With {
            .ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;data source=Database1.mdb"
        }
        Dim a As Boolean
        If selCell.Value = True Then
            a = False
        Else
            a = True
        End If
        Try
            Dim odccmd As New OleDbCommand With {
            .CommandText = "UPDATE Students SET IsChecked = " & a & " WHERE ID= " & selCell.RowIndex + 1,
            .Connection = odc
        }
            odc.Open()
            Dim odcread As OleDbDataReader
            'Dim dt As DataTable
            'dt = odc.GetOleDbSchemaTable
            odcread = odccmd.ExecuteReader(CommandBehavior.SingleResult)
        Catch g As Exception
            MsgBox("检查数据库是否正常!", vbOKOnly, "提示")
        End Try
        odc.Close()

    End Sub



    '是否允许重复抽取
    Private Sub Saver_Click_1(sender As Object, e As EventArgs) Handles Saver.Click
        Me.Hide()
        ModeEditor.Show()
        'If ModeSelection.Items.Count > 10 Then
        '    MsgBox("最多存在11个模式", vbOKOnly, "提示")
        '    Exit Sub
        'End If
        'If lock = True Then Exit Sub
        'ModeSelection.Items.Add(TextBox1.Text)
        'Setting.TotalMode += 1
        'ReDim Preserve Setting.ModeCollections(Setting.TotalMode - 1)
        'Setting.ModeCollections(Setting.TotalMode - 1).Name = TextBox1.Text
        'If dodata = True Then
        '    Setting.ModeCollections(Setting.TotalMode - 1).Range = dataRange
        '    Setting.ModeCollections(Setting.TotalMode - 1).Type = True
        '    Select Case dorepeat
        '        Case Is = True
        '            Setting.ModeCollections(Setting.TotalMode - 1).DoRepeat = True
        '        Case Else
        '            Setting.ModeCollections(Setting.TotalMode - 1).DoRepeat = False
        '    End Select
        'Else
        '    Setting.ModeCollections(Setting.TotalMode - 1).Range = ranges
        '    Setting.ModeCollections(Setting.TotalMode - 1).Type = False
        '    Setting.ModeCollections(Setting.TotalMode - 1).DoRepeat = False
        'End If
        'Setting.ModeCollections(Setting.TotalMode - 1).Times = tms
        'If doextreme = True Then
        '    Setting.ModeCollections(Setting.TotalMode - 1).DoExtreme = True
        'Else
        '    Setting.ModeCollections(Setting.TotalMode - 1).DoExtreme = False
        'End If
        'donew = False
        'MsgBox("保存成功,请返回模式列表查看", vbOKOnly + vbInformation, "祝贺")
        'DeadLocker = False
        'Call Xs()
        'DeadLocker = True
    End Sub

    '保存自定义模式


    Private Sub LinkLabel2_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        UniversalDialog1.Label1.Text = "即将重置全部设置,未保存配置将会丢失,确定吗?"
        DoReadOnly = False
        If UniversalDialog1.ShowDialog = DialogResult.OK Then
            Initialization()
            Xs()
            MadePreparation()
            ToolStripLabel2.LinkVisited = False
            DialogText = "重置成功."
        Else
            Exit Sub
        End If
    End Sub

    Public Sub Initialization()
        ReDim Setting.ModeCollections(10)
        Setting.Name = "Default"
        Setting.TotalMode = 4
        Setting.CurrentMode = 0
        Setting.MaxArea = 69
        Setting.Voicespeed = 25
        Setting.Version = "6.0.0"
        Setting.BackGroundImage = "天空邮件"
        Setting.DialogImage = "Pt(默认)"
        Setting.CreateTime = "2022.03.02"
        Setting.ModeCollections(0).Name = "随机数模式(正常)"
        Setting.ModeCollections(0).Range = 16
        Setting.ModeCollections(0).Times = 1
        Setting.ModeCollections(0).Type = False
        Setting.ModeCollections(0).DoExtreme = False
        Setting.ModeCollections(0).DoRepeat = False
        '
        Setting.ModeCollections(1).Name = "随机数模式(极限)"
        Setting.ModeCollections(1).Range = 16
        Setting.ModeCollections(1).Times = 1
        Setting.ModeCollections(1).Type = False
        Setting.ModeCollections(1).DoExtreme = True
        Setting.ModeCollections(1).DoRepeat = False
        '
        Setting.ModeCollections(2).Name = "数据库模式Normal"
        Setting.ModeCollections(2).Range = 69
        Setting.ModeCollections(2).Times = 1
        Setting.ModeCollections(2).Type = True
        Setting.ModeCollections(2).DoExtreme = False
        Setting.ModeCollections(2).DoRepeat = False
        '
        With Setting.ModeCollections(3)
            .Name = "数据库模式Premium"
            .Range = 36
            .Times = 1
            .Type = True
            .DoExtreme = False
            .DoRepeat = False
        End With
        '
        For i = 4 To 10
            With Setting.ModeCollections(i)
                .Name = "添加新模式..."
                .Range = Nothing
                .Times = Nothing
                .Type = Nothing
                .DoExtreme = Nothing
                .DoRepeat = Nothing
            End With

        Next
    End Sub

    '全重置

    Sub MadePreparation()
        ModeSelection.Items.Clear()
        DoReadOnly = False
        For i As Integer = 0 To Setting.TotalMode - 1
            ModeSelection.Items.Add(Setting.ModeCollections(i).Name)
        Next
        ModeSelection.SelectedItem = Setting.ModeCollections(Setting.CurrentMode).Name
        ColorSwitch(Setting.CurrentMode)
        BackGroundBase.Text = Setting.ModeCollections(Setting.CurrentMode).Name
        Timer2.Interval = Setting.Voicespeed
        Timer4.Interval = Timer2.Interval
        ChangeBackGround(Setting.BackGroundImage)
        ChangeDialogStyle(Setting.DialogImage)
        ToolStripLabel1.LinkVisited = True
        ToolStripLabel5.Enabled = False
        Panel1.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        tms = Setting.ModeCollections(Setting.CurrentMode).Times
        BackGroundBase.SelectedItem = Setting.BackGroundImage
        DialogBase.SelectedItem = Setting.DialogImage
        Select Case Setting.Voicespeed
            Case Is = 10
                VoiceSpeedBase.SelectedItem = "快"
            Case Is = 25
                VoiceSpeedBase.SelectedItem = "中"
            Case Is = 100
                VoiceSpeedBase.SelectedItem = "慢"
            Case Else
                MsgBox("错误！无效的语速数据！"， vbOKOnly, "错误")
                End
        End Select
        TimesDisplay.Text = Str(tms)
        RangeDisplay.Text = Setting.ModeCollections(Setting.CurrentMode).Range
        If Setting.ModeCollections(Setting.CurrentMode).Type = False Then
            ranges = Setting.ModeCollections(Setting.CurrentMode).Range
            ToolStripLabel4.Enabled = False
            RepeatSwitch.Enabled = False
        Else
            dataRange = Setting.ModeCollections(Setting.CurrentMode).Range
            ToolStripLabel4.Enabled = True
            RepeatSwitch.Enabled = True
        End If
        doextreme = Setting.ModeCollections(Setting.CurrentMode).DoExtreme
        If Setting.ModeCollections(Setting.CurrentMode).DoExtreme = True Then
            ExtremeLabel.Text = "极限模式警告"
        Else
            ExtremeLabel.Text = ""
        End If
        memories = 0
        makesure = 0
        lock = True
        DoMakesureSwitch.Checked = False
        lock = False
        memo = False
        Timer1.Enabled = True
        def = True
        ToolStripStatusLabel3.Text = "使用的模式:" & Setting.ModeCollections(Setting.CurrentMode).Name
    End Sub

    '预加载
    Private Sub Debugselect_Click_1(sender As Object, e As EventArgs) Handles Debugselect.Click
        DebugForm.Show()
    End Sub

    'Debug

    '=======Page 3 of 4,个性化=======
    Private Sub ComboBox2_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles BackGroundBase.SelectedIndexChanged
        DeadLocker = False
        ChangeBackGround(BackGroundBase.SelectedItem)
        Setting.BackGroundImage = BackGroundBase.SelectedItem
        Xs()
        DeadLocker = True
        ToolStripLabel5.Enabled = False
    End Sub



    Private Sub ChangeBackGround(ByVal a As String)
        Select Case a
            Case Is = "空间邮件"
                Me.BackgroundImage = My.Resources.空间邮件
                Call Wht()
            Case Is = "彩嵌邮件"
                Me.BackgroundImage = My.Resources.彩嵌邮件
                Call Bla()
            Case Is = "青草邮件"
                Me.BackgroundImage = My.Resources.青草邮件
                Call Bla()
            Case Is = "初次邮件"
                Me.BackgroundImage = My.Resources.初次邮件
                Call Bla()
            Case Is = "钢铁邮件"
                Me.BackgroundImage = My.Resources.钢铁邮件
                Call Wht()
            Case Is = "回复邮件"
                Me.BackgroundImage = My.Resources.回复邮件
                Call Bla()
            Case Is = "桥梁邮件W"
                Me.BackgroundImage = My.Resources.桥梁邮件Ｗ
                Call Bla()
            Case Is = "桥梁邮件C"
                Me.BackgroundImage = My.Resources.桥梁邮件Ｃ
                Call Bla()
            Case Is = "桥梁邮件V"
                Me.BackgroundImage = My.Resources.桥梁邮件Ｖ
                Call Bla()
            Case Is = "桥梁邮件H"
                Me.BackgroundImage = My.Resources.桥梁邮件Ｈ
                Call Wht()
            Case Is = "桥梁邮件S"
                Me.BackgroundImage = My.Resources.桥梁邮件Ｓ
                Call Bla()
            Case Is = "水蓝邮件"
                Me.BackgroundImage = My.Resources.水蓝邮件
                Call Wht()
            Case Is = "砖块邮件"
                Me.BackgroundImage = My.Resources.砖块邮件
                Call Wht()
            Case Is = "暴雪邮件"
                Me.BackgroundImage = My.Resources.暴雪邮件
                Call Bla()
            Case Is = "天空邮件"
                Me.BackgroundImage = My.Resources.天空邮件
                Call Bla()
            Case Is = "喜爱邮件"
                Me.BackgroundImage = My.Resources.喜爱邮件
                Call Bla()
            Case Is = "感谢邮件"
                Me.BackgroundImage = My.Resources.感谢邮件
                Call Bla()
        End Select
    End Sub

    '更换背景

    Private Sub Wht()
        ToolStripLabel1.LinkColor = Color.White
        ToolStripLabel2.LinkColor = Color.White
        ToolStripLabel3.LinkColor = Color.White
        ToolStripLabel4.LinkColor = Color.White
        ToolStripLabel5.LinkColor = Color.White
        GroupBox1.ForeColor = Color.White
        GroupBox2.ForeColor = Color.White
        GroupBox3.ForeColor = Color.White
        Label2.ForeColor = Color.White
        Label3.ForeColor = Color.White
        Label4.ForeColor = Color.White
        Label5.ForeColor = Color.White
        Label8.ForeColor = Color.White
        Label13.ForeColor = Color.White
        Label10.ForeColor = Color.White
        Label11.ForeColor = Color.White
        Label12.ForeColor = Color.White
        DoMakesureSwitch.ForeColor = Color.White
        NumberSwitch.ForeColor = Color.White
        ItemSwitch.ForeColor = Color.White
        ExtremeSwitch.ForeColor = Color.White
        RepeatSwitch.ForeColor = Color.White
        If lock = True Then Exit Sub
        Call Xs()
    End Sub

    Private Sub Bla()
        ToolStripLabel1.LinkColor = Color.Black
        ToolStripLabel2.LinkColor = Color.Black
        ToolStripLabel3.LinkColor = Color.Black
        ToolStripLabel4.LinkColor = Color.Black
        ToolStripLabel5.LinkColor = Color.Black
        GroupBox1.ForeColor = Color.Black
        GroupBox2.ForeColor = Color.Black
        GroupBox3.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        Label3.ForeColor = Color.Black
        Label4.ForeColor = Color.Black
        Label5.ForeColor = Color.Black
        Label8.ForeColor = Color.Black
        Label13.ForeColor = Color.Black
        Label10.ForeColor = Color.Black
        Label11.ForeColor = Color.Black
        Label12.ForeColor = Color.Black
        DoMakesureSwitch.ForeColor = Color.Black
        NumberSwitch.ForeColor = Color.Black
        ItemSwitch.ForeColor = Color.Black
        ExtremeSwitch.ForeColor = Color.Black
        RepeatSwitch.ForeColor = Color.Black
        If lock = True Then Exit Sub
        Call Xs()
    End Sub

    '黑白切换
    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DialogBase.SelectedIndexChanged
        ChangeDialogStyle(DialogBase.SelectedItem)
        Setting.DialogImage = DialogBase.SelectedItem
        If lock = True Then Exit Sub
        DeadLocker = False
        Call Xs()
        DeadLocker = True
        ToolStripLabel5.Enabled = False
    End Sub

    Sub ChangeDialogStyle(ByVal e As String)
        Select Case e
            Case Is = "E"
                MainDialog.Image = My.Resources.EDialog
                PreviewDialog.Image = My.Resources.EDialog
            Case Is = "Pt(默认)"
                MainDialog.Image = My.Resources.PtDialog
                PreviewDialog.Image = My.Resources.PtDialog
            Case Is = "HGSS"
                MainDialog.Image = My.Resources.hgssdialog
                PreviewDialog.Image = My.Resources.hgssdialog
            Case Is = "DP"
                MainDialog.Image = My.Resources.DialogDP
                PreviewDialog.Image = My.Resources.DialogDP
            Case Is = "ORAS"
                MainDialog.Image = My.Resources.ORASDialog
                PreviewDialog.Image = My.Resources.ORASDialog
        End Select

    End Sub
    '更换对话框

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles PersonalizeColor.Click
        ColorDialog1.Color = MainDialog.ForeColor
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            MainDialog.ForeColor = ColorDialog1.Color
            PreviewDialog.ForeColor = ColorDialog1.Color
        Else
            Exit Sub
        End If
    End Sub

    '更换颜色
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles PersonalizeFonts.Click
        FontDialog1.Font = MainDialog.Font
        FontDialog1.ShowColor = True
        If FontDialog1.ShowDialog = DialogResult.OK Then
            MainDialog.Font = FontDialog1.Font
            MainDialog.ForeColor = FontDialog1.Color
            PreviewDialog.Font = FontDialog1.Font
            PreviewDialog.ForeColor = FontDialog1.Color
        Else
            Exit Sub
        End If
    End Sub

    '更换字体

    Private Sub ComboBox3_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles VoiceSpeedBase.SelectedIndexChanged
        If lock = True Then Exit Sub
        DeadLocker = False
        ChangeVoiceSpeed()
        Setting.Voicespeed = ChangeVoiceSpeed()
        Call Xs()
        DeadLocker = True
        ToolStripLabel5.Enabled = False
    End Sub

    Function ChangeVoiceSpeed()
        Select Case VoiceSpeedBase.SelectedItem
            Case Is = "快"
                Timer2.Interval = fast
                Timer4.Interval = fast
            Case Is = "中"
                Timer2.Interval = medium
                Timer4.Interval = medium
            Case Is = "慢"
                Timer2.Interval = slow
                Timer4.Interval = slow
        End Select
        Timer4.Enabled = True
        Return Timer2.Interval
    End Function

    '语速
    Private Sub ReDiveP_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ReDiveP.LinkClicked
        UniversalDialog1.Label1.Text = "即将重置本页面设置，确定吗?"
        DoReadOnly = False
        If UniversalDialog1.ShowDialog = DialogResult.OK Then
            Setting.BackGroundImage = "天空邮件"
            Me.BackgroundImage = My.Resources.天空邮件
            DeadLocker = False
            BackGroundBase.SelectedItem = "天空邮件"
            DialogBase.SelectedItem = "Pt(默认)"
            VoiceSpeedBase.SelectedItem = "中"
            Call Bla()
            DeadLocker = True
            Setting.DialogImage = "Pt(默认)"
            MainDialog.Image = My.Resources.PtDialog
            PreviewDialog.Image = My.Resources.PtDialog
            Setting.Voicespeed = 25
            DeadLocker = False
            Call Xs()
            DeadLocker = True
        End If
    End Sub

    '个性化页面-重置

    '=======Page 4 of 4,数据库相关=======


    '=======Page 5 of 4,预加载和其他设定=======

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Logs.SelectedIndexChanged
        If Logs.SelectedIndex = 0 Then Exit Sub
        DialogText = Logs.SelectedItem
        Timer2.Enabled = True
    End Sub

    'Listbox1的响应动画

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Panel1.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        ToolStripLabel2.LinkVisited = False
        ToolStripLabel1.LinkVisited = True
        ToolStripLabel3.LinkVisited = False
        ToolStripLabel4.LinkVisited = False
        ToolStripLabel5.LinkVisited = False
        ToolStripLabel5.Enabled = True

    End Sub

    Private Sub ToolStripLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripLabel3.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True
        Panel4.Visible = False
        ToolStripLabel2.LinkVisited = False
        ToolStripLabel1.LinkVisited = False
        ToolStripLabel3.LinkVisited = True
        ToolStripLabel4.LinkVisited = False
        ToolStripLabel5.LinkVisited = False
        ToolStripLabel5.Enabled = False
    End Sub

    Private Sub ToolStripLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripLabel4.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = True
        ToolStripLabel2.LinkVisited = False
        ToolStripLabel1.LinkVisited = False
        ToolStripLabel3.LinkVisited = False
        ToolStripLabel4.LinkVisited = True
        ToolStripLabel5.LinkVisited = False
        ToolStripLabel5.Enabled = False
    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        Panel1.Visible = False
        Panel2.Visible = True
        Panel3.Visible = False
        Panel4.Visible = False
        ToolStripLabel2.LinkVisited = True
        ToolStripLabel1.LinkVisited = False
        ToolStripLabel3.LinkVisited = False
        ToolStripLabel4.LinkVisited = False
        ToolStripLabel5.LinkVisited = False
        ToolStripLabel5.Enabled = False
    End Sub
    '页面切换
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Dim iris As Integer
        If readme = Nothing Then Exit Sub
        iris = readme.Length
        checked2 += 1
        PreviewDialog.Text = readme.Substring(0, checked2)
        If checked2 > iris - 1 Then
            checked2 = 1
            Timer4.Enabled = False
        End If
    End Sub

    '预览
    Public Sub Xs()
        Dim te As String
        te = reader.Serialize(Setting)
        If File.Exists("RMNewConfig.json") Then
            Try
                File.Delete("RMNewConfig.json")
            Catch ex As Exception
                UniversalDialog1.Label1.Text = "未知的错误..."
                DoReadOnly = True
                UniversalDialog1.ShowDialog()
                Exit Sub
            End Try
        End If
        Setting.CreateTime = Date.Now
        Setting.Name = "AutoSave:" & Setting.CreateTime
        Dim fs As FileStream
        fs = File.Open("RMNewConfig.json", FileMode.OpenOrCreate, FileAccess.Write)
        Dim sw As New StreamWriter(fs, Encoding.UTF8)
        sw.Write(te)
        sw.Close()
        fs.Close()
        lock = False
        Timer3.Enabled = True
    End Sub

    '保存通用过程

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim iris As Integer
        If DialogText = Nothing Then Exit Sub
        iris = DialogText.Length
        If checked > iris - 1 Then
            checked = 1
            Timer2.Enabled = False
            Exit Sub
        End If
        checked += 1
        MainDialog.Text = DialogText.Substring(0, checked)
        If checked > iris - 1 Then
            checked = 1
            Timer2.Enabled = False
        End If
    End Sub

    '主对话框动画效果

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim dts As DateTime
        dts = Date.Now
        ToolStripStatusLabel2.Text = "现在时间:" & dts
    End Sub

    '实时时间

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“Database1DataSet1.Students”中。您可以根据需要移动或删除它。
        Me.StudentsTableAdapter1.Fill(Me.Database1DataSet1.Students)
        Dim sw As New StreamReader("RMNewConfig.json")
        JsonWord = sw.ReadToEnd
        Setting = reader.Deserialize(Of Configs)(JsonWord)
        sw.Close()
        MadePreparation()
        Dim odc As New OleDbConnection() With {
            .ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;data source=Database1.mdb"
        }
        odc.Open()
        Try
            Dim odccmd As New OleDbCommand With {
            .CommandText = "SELECT * FROM Students WHERE ID =" & Setting.MaxArea - 2,
            .Connection = odc
        }
            odc.Open()
            Dim odcread As OleDbDataReader
            Dim f As Object
            odcread = odccmd.ExecuteReader(CommandBehavior.SingleResult)
            If odcread.HasRows = False Then
                MsgBox("检查数据库是否正常!", vbOKOnly, "提示")
            Else
                f = odcread.GetValue(0)
            End If
        Catch g As Exception
            MsgBox("检查数据库是否正常!", vbOKOnly, "提示")
        End Try
        odc.Close()
        DeadLocker = True
        '
        Me.Show()
    End Sub

    '初始化数据
End Class