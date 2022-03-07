Public Class DebugForm
    Private Sub DebugOutput_Click(sender As Object, e As EventArgs) Handles DebugOutput.Click
        Dim c As String
        c = Form1.reader.Serialize(Form1.Setting)
        TextBox1.Text = c
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.makesure = 1
        Dim cir As Int16
        For cir = 1 To 10000
            Call Form1.CoreProgram()
        Next
        MsgBox("调试完成.", vbOKOnly)

    End Sub
End Class