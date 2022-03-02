Module Module1
    Public Sub DebugCoreProgram()
        Dim datas, tmsreal As Integer, temp As String
        Dim selCell As DataGridViewCell
        tmsreal = Form1.tms - 1
        Form1.memories += 1
        '随机数模式
        If Form1.dodata = False Then
CX1:
            Randomize()
            datas = Rnd() * Form1.ranges
            If datas = 0 Then GoTo CX1
            Form1.DialogText = "抽出数值:" & Str(datas)
            temp = Str(datas)
            For circle = 1 To tmsreal
CX2:
                Randomize()
                datas = Rnd() * Form1.ranges
                If datas = 0 Then GoTo CX2
                Form1.DialogText = Form1.DialogText & "/" & Str(datas)
                temp = temp & "/" & Str(datas)
            Next
            Form1.ListBox1.Items.Add(temp)
            If Form1.doextreme = True Then
                MessageBox.Show("检测到极限模式已开启，调试失败。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Form1.Timer2.Enabled = True
        ElseIf Form1.dodata = True Then
            '数据驱动模式1
            Try
                Dim repeat(6), errortimes As Integer, check As String, trigger As Integer = 1
                If errortimes = 1 Then
                    MsgBox("警告:" & "请检查数据库中是否存在可以抽出的项！", vbCritical + vbOKOnly, "错误")
                    Exit Sub
                End If
                '一次监测
                Do
                    selCell = Form1.DataGridView1(2, trigger)
                    trigger += 1
                Loop Until selCell.Value = False
                '监测范围内是否有可用项
                For trigger = 1 To Form1.dataRange
                    selCell = Form1.DataGridView1(2, trigger)
                    If selCell.Value = True Then errortimes += 1
                Next
CX7:
                If Form1.dataRange - errortimes <= tmsreal Then GoTo CX7
                Randomize()
                datas = Rnd() * Form1.dataRange
                If datas > Form1.Area Then GoTo CX7
                repeat(0) = datas
                selCell = Form1.DataGridView1(1, datas)
                temp = selCell.Value
                selCell = Form1.DataGridView1(2, datas)
                If selCell.Value = False Then
                    Form1.DialogText = "抽取对象为:" & temp
                    For circle = 1 To tmsreal Step 1
CX6:
                        Randomize()
                        datas = Rnd() * Form1.dataRange
                        If datas = 0 Then GoTo CX6
                        selCell = Form1.DataGridView1(1, datas)
                        check = temp = selCell.Value
                        Form1.ProgressBar1.Value = 70
                        selCell = Form1.DataGridView1(2, datas)
                        If selCell.Value = False Then
                            repeat(circle) = datas
                            Dim repeat2 As Integer
                            For repeat2 = 0 To circle - 1 Step 1
                                If repeat(repeat2) = datas Then GoTo CX6
                            Next
                        Else
                            GoTo CX6
                        End If
                        selCell = Form1.DataGridView1(1, datas)
                        Form1.DialogText += "/" & selCell.Value
                        temp = temp & "/" & selCell.Value
                    Next
                    Form1.ListBox1.Items.Add(temp)
                Else
                    GoTo CX7
                End If
                If Form1.doextreme = True Then
                    MessageBox.Show("检测到极限模式已开启，调试失败。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox("警告:" & Err.Description, vbCritical + vbOKOnly, "错误")
            End Try
        End If
        Form1.Timer2.Enabled = True
    End Sub
    '调试核心程序
    Public Sub AutoSaveRecord()
        Dim DialogText As Integer, dt As DateTime
        Form1.SaveFileDialog2.FileName = "抽取记录" & dt.Year & "." & dt.Month & "." & dt.Day & "." & dt.Hour & "/" & dt.Minute & "/" & dt.Second
        If Form1.SaveFileDialog2.ShowDialog = DialogResult.OK Then
            dt = Date.Now
            FileOpen(2, Form1.SaveFileDialog2.FileName, OpenMode.Output, OpenAccess.Default)
            WriteLine(2, "抽取时间" & dt.Year & dt.Month & dt.Day)
            For DialogText = 1 To Form1.ListBox1.Items.Count - 1
                WriteLine(2, Form1.ListBox1.Items.Item(DialogText))
            Next
            WriteLine(2, "一共抽取了" & Form1.ListBox1.Items.Count - 1 & "次!")
            WriteLine(2, "使用的模式:" & Form1.ComboBox1.SelectedItem)
            FileClose(2)
            MessageBox.Show("调试全部结束")
        Else
            Exit Sub
        End If
    End Sub
    Public Sub Initialization()
        Form1.Setting.Name = "Default"
        Form1.Setting.TotalMode = 4
        Form1.Setting.CurrentMode = 0
        Form1.Setting.MaxArea = 69
        Form1.Setting.Voicespeed = 25
        Form1.Setting.Version = "6.0.0"
        Form1.Setting.BackGroundImage = "天空邮件"
        Form1.Setting.DialogImage = "Pt(默认)"
        Form1.Setting.CreateTime = "2022.03.02"
        ReDim Form1.Setting.ModeCollections(3)
        Form1.Setting.ModeCollections(0).Name = "随机数模式(正常)"
        Form1.Setting.ModeCollections(0).Range = 16
        Form1.Setting.ModeCollections(0).Times = 1
        Form1.Setting.ModeCollections(0).Type = False
        Form1.Setting.ModeCollections(0).DoExtreme = False
        Form1.Setting.ModeCollections(0).DoRepeat = False
        '
        Form1.Setting.ModeCollections(1).Name = "随机数模式(极限)"
        Form1.Setting.ModeCollections(1).Range = 16
        Form1.Setting.ModeCollections(1).Times = 1
        Form1.Setting.ModeCollections(1).Type = False
        Form1.Setting.ModeCollections(1).DoExtreme = True
        Form1.Setting.ModeCollections(1).DoRepeat = False
        '
        Form1.Setting.ModeCollections(2).Name = "数据库模式Normal"
        Form1.Setting.ModeCollections(2).Range = 69
        Form1.Setting.ModeCollections(2).Times = 1
        Form1.Setting.ModeCollections(2).Type = True
        Form1.Setting.ModeCollections(2).DoExtreme = False
        Form1.Setting.ModeCollections(2).DoRepeat = False
        '
        Form1.Setting.ModeCollections(3).Name = "数据库模式Premium"
        Form1.Setting.ModeCollections(3).Range = 36
        Form1.Setting.ModeCollections(3).Times = 1
        Form1.Setting.ModeCollections(3).Type = True
        Form1.Setting.ModeCollections(3).DoExtreme = False
        Form1.Setting.ModeCollections(3).DoRepeat = False

    End Sub
End Module
