Public Class DebugForm
    Private Sub DebugOutput_Click(sender As Object, e As EventArgs) Handles DebugOutput.Click
        Dim c As String
        c = Form1.reader.Serialize(Form1.Setting)
        TextBox1.Text = c
    End Sub
    Private Sub Anime(e As Integer, f As Integer)
        Label1.Text = "Loading...进度" & e & "/" & f
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.makesure = 1
        ProgressBar1.Value = 0
        Dim cir As Integer， d As Integer
        Try
            d = Val(InputBox("请输入要一键抽取的次数:", "提示"))
            ProgressBar1.Maximum = d
        Catch f As InvalidCastException
            MsgBox("无效的数据!", vbOKOnly + vbCritical)
            Exit Sub
        End Try
        If d = Nothing Or d = 0 Then
            MsgBox("无效的数据!", vbOKOnly + vbCritical)
            Exit Sub
        End If
        Label1.Visible = True

        For cir = 1 To d
            Call Form1.CoreProgram()
            ProgressBar1.Value += 1
            Anime(cir, d)
        Next
        MsgBox("调试完成...累死喵了..." & Chr(13) & Chr(10) & "快去主界面查看下劳动成果吧...~o( =∩ω∩= )m", vbOKOnly)
        Label1.Visible = False

    End Sub

    Private Sub DebugForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()

    End Sub
End Class