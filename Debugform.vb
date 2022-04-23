Public Class DebugForm
    Private Sub DebugOutput_Click(sender As Object, e As EventArgs) Handles DebugOutput.Click
        Dim c As String
        c = Form1.reader.Serialize(Form1.Setting)
        TextBox1.Text = c
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.makesure = 1
        ProgressBar1.Value = 0
        Dim cir As Integer， d As Integer
        Try
            d = Val(InputBox("请输入要一键抽取的次数:", "提示"))
            If d > 99999 Then
                MsgBox("抽取次数过大!", vbOKOnly + vbCritical)
                Exit Sub
            ElseIf d > 45000 Then
                MsgBox("抽取次数过大,可能导致记录显示不全!", vbOKOnly + vbInformation)
            End If
            ProgressBar1.Maximum = d
        Catch f As InvalidCastException
            MsgBox("无效的数据!", vbOKOnly + vbCritical)
            Exit Sub
        End Try
        If d = Nothing Or d = 0 Then
            MsgBox("无效的数据!", vbOKOnly + vbCritical)
            Exit Sub
        End If

        For cir = 1 To d
            Dim rng As New Random()
            Dim nand As New Random(rng.Next())
            Call Form1.CoreProgram(nand)
            ProgressBar1.Value += 1
        Next
        If UniversalDG2.ShowDialog() = DialogResult.OK Then
            With Form1
                .Panel1.Visible = True
                .Panel2.Visible = False
                .Panel3.Visible = False
                .Panel4.Visible = False
                .ToolStripLabel2.LinkVisited = False
                .ToolStripLabel1.LinkVisited = True
                .ToolStripLabel3.LinkVisited = False
                .ToolStripLabel4.LinkVisited = False
                .ToolStripLabel5.LinkVisited = False
                .ToolStripLabel5.Enabled = True
            End With
            Me.Close()
        End If

    End Sub

    Private Sub DebugForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()

    End Sub
End Class