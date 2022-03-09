Public Class ModeEditor
    Dim DeadLocker As Boolean, setting， setting2 As Configs
    Dim memo As Byte
    Private Sub ModeEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        For i As Integer = 1 To Form1.Setting.TotalMode + 1
            ListBox1.Items.Add(Form1.Setting.ModeCollections(i - 1).Name)
        Next
        setting = Form1.Setting
        setting2 = setting
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If DeadLocker = True Then Exit Sub
        If ListBox1.SelectedIndex <= setting.TotalMode - 1 Then
            GroupBox1.Enabled = True
            DeadLocker = True
            TextBox1.Text = setting.ModeCollections(ListBox1.SelectedIndex).Name
            timepool.Value = setting.ModeCollections(ListBox1.SelectedIndex).Times
            pool.Value = setting.ModeCollections(ListBox1.SelectedIndex).Range
            ExtremeSwitch.Checked = setting.ModeCollections(ListBox1.SelectedIndex).DoExtreme
            RepeatSwitch.Checked = setting.ModeCollections(ListBox1.SelectedIndex).DoRepeat
            If setting.ModeCollections(ListBox1.SelectedIndex).Type = False Then
                NumberSwitch.Checked = True
                RepeatSwitch.Enabled = False
            Else
                ItemSwitch.Checked = True
                RepeatSwitch.Enabled = True
            End If
            DeadLocker = False
        Else
            UniversalDialog1.Label1.Text = "即将创建新模式,确定吗?"
            If UniversalDialog1.ShowDialog() = DialogResult.OK Then
                setting.TotalMode += 1
                If setting.TotalMode > 10 Then
                    UniversalDialog1.Label1.Text = "最多共存11个模式,已超出模式上限"
                    UniversalDialog1.ShowDialog()
                    Exit Sub
                End If
                With setting.ModeCollections(ListBox1.SelectedIndex)
                    .Name = "新的自定义模式"
                    .Type = setting.ModeCollections(ListBox1.SelectedIndex - 1).Type
                    .Range = setting.ModeCollections(ListBox1.SelectedIndex - 1).Range
                    .Times = setting.ModeCollections(ListBox1.SelectedIndex - 1).Times
                    .DoExtreme = setting.ModeCollections(ListBox1.SelectedIndex - 1).DoExtreme
                    .DoRepeat = setting.ModeCollections(ListBox1.SelectedIndex - 1).DoRepeat
                End With
                memo = ListBox1.SelectedIndex
                ListBox1.Items.Clear()
                For i As Integer = 1 To setting.TotalMode + 1
                    ListBox1.Items.Add(Form1.Setting.ModeCollections(i - 1).Name)
                Next
                GroupBox1.Enabled = True
                DeadLocker = True
                TextBox1.Text = setting.ModeCollections(memo).Name
                timepool.Value = setting.ModeCollections(memo).Times
                pool.Value = setting.ModeCollections(memo).Range
                ExtremeSwitch.Checked = setting.ModeCollections(memo).DoExtreme
                RepeatSwitch.Checked = setting.ModeCollections(memo).DoRepeat
                If setting.ModeCollections(memo).Type = False Then
                    NumberSwitch.Checked = True
                    RepeatSwitch.Enabled = False
                Else
                    ItemSwitch.Checked = True
                    RepeatSwitch.Enabled = True
                End If
                DeadLocker = False
                UniversalDialog1.Label1.Text = "创建完毕。现可自定义该新模式的参数。"
                UniversalDialog1.ShowDialog()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Setting = setting
        Form1.Show()
        Form1.MadePreparation()
        Form1.Xs()
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If ListBox1.SelectedIndex = -1 Then Exit Sub
        If DeadLocker = True Then Exit Sub
        setting.ModeCollections(ListBox1.SelectedIndex).Name = TextBox1.Text
        ListBox1.Items.Item(ListBox1.SelectedIndex) = TextBox1.Text
    End Sub

    Private Sub NumberSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles NumberSwitch.CheckedChanged
        If ListBox1.SelectedIndex = -1 Then Exit Sub
        If DeadLocker = True Then Exit Sub
        If setting.ModeCollections(ListBox1.SelectedIndex).Type <> False Then
            setting.ModeCollections(ListBox1.SelectedIndex).Type = False
            RepeatSwitch.Enabled = False
        End If
    End Sub

    Private Sub ItemSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles ItemSwitch.CheckedChanged
        If ListBox1.SelectedIndex = -1 Then Exit Sub
        If DeadLocker = True Then Exit Sub
        If setting.ModeCollections(ListBox1.SelectedIndex).Type <> True Then
            setting.ModeCollections(ListBox1.SelectedIndex).Type = True
            RepeatSwitch.Enabled = True
        End If
    End Sub

    Private Sub timepool_ValueChanged(sender As Object, e As EventArgs) Handles timepool.ValueChanged
        If DeadLocker = True Then Exit Sub
        setting.ModeCollections(ListBox1.SelectedIndex).Times = timepool.Value
    End Sub

    Private Sub pool_ValueChanged(sender As Object, e As EventArgs) Handles pool.ValueChanged
        If DeadLocker = True Then Exit Sub
        setting.ModeCollections(ListBox1.SelectedIndex).Range = pool.Value
    End Sub

    Sub SettingOverlay()
        Dim i As Byte = 0, j As Byte = 0
        Do
            If i = memo Then i += 1
            setting.ModeCollections(j).Name = setting2.ModeCollections(i).Name
            setting.ModeCollections(j).Type = setting2.ModeCollections(i).Type
            setting.ModeCollections(j).DoExtreme = setting2.ModeCollections(i).DoExtreme
            setting.ModeCollections(j).DoRepeat = setting2.ModeCollections(i).DoRepeat
            setting.ModeCollections(j).Range = setting2.ModeCollections(i).Range
            setting.ModeCollections(j).Times = setting2.ModeCollections(i).Times
            j += 1
            i += 1
        Loop Until j > ListBox1.Items.Count - 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DeadLocker = True
        UniversalDialog1.Label1.Text = "确定永久删除" & TextBox1.Text & "吗?"
        If UniversalDialog1.ShowDialog() = DialogResult.OK Then
            memo = ListBox1.SelectedIndex
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            SettingOverlay()
            setting.TotalMode -= 1
        End If
        DeadLocker = False
    End Sub
End Class