Public Class Status
    Private Sub Status_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.memories = 0 Then
            Me.Close()
            Exit Sub
        End If
        If Form1.tms > 1 Then
            UniversalDialog1.Label1.Text = "统计连续抽取的数据没有意义."
            UniversalDialog1.Label2.Text = "将退出统计。"
            Form1.DoReadOnly = True : Form1.DoMultiLine = True
            UniversalDialog1.ShowDialog()
            Form1.Show()
            Me.Close()
            Exit Sub
        End If
        If Form1.Setting.ModeCollections(Form1.Setting.CurrentMode).DoExtreme = True Then
            UniversalDialog1.Label1.Text = "统计极限模式的数据没有意义."
            UniversalDialog1.Label2.Text = "将退出统计。"
            Form1.DoReadOnly = True : Form1.DoMultiLine = True
            UniversalDialog1.ShowDialog()
            Form1.Show()
            Me.Close()
            Exit Sub
        End If
        Dim a As New List(Of Integer)
        a = Form1.Statistics.StaCounts
        For i As Integer = 0 To Form1.Statistics.Statistics.Count - 1
            Chart1.Series(0).Points.AddXY(Form1.Statistics.Statistics.Item(i), a.Item(i))
            ComboBox1.Items.Add(Form1.Statistics.Statistics.Item(i))
        Next
        RangeDisplay.Text = Form1.RangeDisplay.Text
        TimesDisplay.Text = Form1.TimesDisplay.Text
        RoundDisplay.Text = Form1.RoundDisplay.Text
        RangeDisplay2.Text = Form1.RangeDisplay.Text
        TimesDisplay2.Text = Form1.TimesDisplay.Text
        RoundDisplay2.Text = Form1.RoundDisplay.Text
        Label5.Text = Form1.Statistics.Statistics.Item(a.IndexOf(a.Max))
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Status_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label6.Visible = True
        Label7.Visible = True
        'UiLedDisplay1.Visible = True
        'UiLedDisplay2.Visible = True
        UiLabel1.Visible = True
        UiLabel2.Visible = True
        UiLedDisplay1.Text = Form1.Statistics.StaCounts.Item(Form1.Statistics.Statistics.IndexOf(ComboBox1.SelectedItem))
        Dim b As Decimal = Form1.Statistics.StaCounts.Item(Form1.Statistics.Statistics.IndexOf(ComboBox1.SelectedItem)) / Form1.memories
        b *= 100
        UiLedDisplay2.Text = b
        UiLedDisplay2.Text = UiLedDisplay2.Text.Substring(0, 4) & "%"
        UiLabel1.Text = UiLedDisplay1.Text
        UiLabel2.Text = UiLedDisplay2.Text
    End Sub
End Class