Public Class UserControl1
    Public Property Minimum As Integer = 1
    Public Property Maximum As Integer = 100
    Public Property Value As Integer = 1
    Public Property Warn As Boolean = False

    Public Property Type As Integer = 0 '决定该控件是干啥的
    Public Property BlueText As String = "Hety"
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Value -= 1
        If Value < Minimum Then
            Value += 1
            Timer1.Enabled = True
        End If
        If Value = Minimum Then
            PictureBox1.Image = My.Resources.虚化左箭头
        End If
        Label2.Text = Value
        PictureBox2.Image = My.Resources.右箭头
        '对form1特化的妥协方案
        If Type = 0 Then
            Form1.tms = Form1.timepool.Value
            Form1.timepool.Reload()
            Form1.donew = True
            If Form1.dodata = False Then
                Form1.NumberSwitch.Checked = True
                Form1.ItemSwitch.Checked = False
                Form1.RangeDisplay.Text = Str(Form1.ranges)
                Form1.TimesDisplay.Text = Str(Form1.tms)
                Form1.Logs.ForeColor = Color.Black
                Form1.ToolStripStatusLabel3.Text = "当前模式:新随机数模式(未保存)"
                Form1.TempMdName = "新随机数模式(未保存)"
            Else
                Form1.NumberSwitch.Checked = False
                Form1.ItemSwitch.Checked = True
                Form1.RangeDisplay.Text = Str(Form1.dataRange)
                Form1.TimesDisplay.Text = Str(Form1.tms)
                Form1.Logs.ForeColor = Color.Chocolate
                Form1.TempMdName = "新数据库模式(未保存)"
                Form1.ToolStripStatusLabel3.Text = "当前模式:" & "新数据库模式(未保存)"
            End If
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Warn = True Then
            Warn = False
            Label2.ForeColor = Color.MediumOrchid
            Timer1.Enabled = False
            Label2.Text = Value
            Exit Sub
        End If
        Warn = True
        Label2.ForeColor = Color.Red
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Value += 1
        If Value > Maximum Then
            Value -= 1
            Timer1.Enabled = True
        End If
        If Value = Maximum Then
            PictureBox2.Image = My.Resources.虚化右箭头
        End If
        PictureBox1.Image = My.Resources.左箭头
        Label2.Text = Value
        '对form1特化的妥协方案
        If Type = 0 Then
            Form1.tms = Form1.timepool.Value
            Form1.timepool.Reload()
            Form1.donew = True
            If Form1.dodata = False Then
                Form1.NumberSwitch.Checked = True
                Form1.ItemSwitch.Checked = False
                Form1.RangeDisplay.Text = Str(Form1.ranges)
                Form1.TimesDisplay.Text = Str(Form1.tms)
                Form1.Logs.ForeColor = Color.Black
                Form1.ToolStripStatusLabel3.Text = "当前模式:新随机数模式(未保存)"
                Form1.TempMdName = "新随机数模式(未保存)"
            Else
                Form1.NumberSwitch.Checked = False
                Form1.ItemSwitch.Checked = True
                Form1.RangeDisplay.Text = Str(Form1.dataRange)
                Form1.TimesDisplay.Text = Str(Form1.tms)
                Form1.Logs.ForeColor = Color.Chocolate
                Form1.TempMdName = "新数据库模式(未保存)"
                Form1.ToolStripStatusLabel3.Text = "当前模式:" & "新数据库模式(未保存)"
            End If
        End If
    End Sub

    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Value
        Label1.Text = BlueText
        If Value = Maximum Then
            PictureBox2.Image = My.Resources.虚化右箭头
            PictureBox1.Image = My.Resources.左箭头
        ElseIf Value = Minimum Then
            PictureBox1.Image = My.Resources.虚化左箭头
            PictureBox2.Image = My.Resources.右箭头
        Else
            PictureBox1.Image = My.Resources.左箭头
            PictureBox2.Image = My.Resources.右箭头

        End If

    End Sub


    Private Sub UserControl1_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        Me.BackgroundImage = My.Resources.常规选项卡
    End Sub

    Private Sub UserControl1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        Me.BackgroundImage = My.Resources.选定选项卡
    End Sub

    Public Sub Reload()
        Label2.Text = Value
        Label1.Text = BlueText
        If Value = Maximum Then
            PictureBox2.Image = My.Resources.虚化右箭头
            PictureBox1.Image = My.Resources.左箭头
        ElseIf Value = Minimum Then
            PictureBox1.Image = My.Resources.虚化左箭头
            PictureBox2.Image = My.Resources.右箭头
        Else
            PictureBox1.Image = My.Resources.左箭头
            PictureBox2.Image = My.Resources.右箭头

        End If
        Me.Refresh()
    End Sub
End Class
