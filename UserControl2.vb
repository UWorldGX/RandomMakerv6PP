Public Class UserControl2
    Public Property Items As List(Of String)
    Public Property Warn As Boolean = False

    Public Property Type As Integer
    Public Property BlueText As String = "Hety"

    Public Property SIndex As Integer = 0
    Public Property TIndex As Integer = 0
    Private Sub UserControl2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Items = New List(Of String)
        Reload2()

    End Sub

    Public Sub Reload2()
        Label1.Text = BlueText
        Label2.Text = Items.Item(SIndex)
        TIndex = Items.Count - 1
        Me.Refresh()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        SIndex -= 1
        If SIndex < 0 Then
            SIndex += 1
            PictureBox1.Image = My.Resources.虚化左箭头
            PictureBox2.Image = My.Resources.右箭头
            Exit Sub
        End If
        PictureBox2.Image = My.Resources.右箭头
        Label2.Text = Items.Item(SIndex)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Warn = True Then
            Warn = False
            Label2.ForeColor = Color.MediumOrchid
            Timer1.Enabled = False
            Label2.Text = Items.Item(SIndex)
            Exit Sub
        End If
        Warn = True
        Label2.ForeColor = Color.Red
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        SIndex += 1
        If SIndex > TIndex Then
            SIndex -= 1
            PictureBox1.Image = My.Resources.左箭头
            PictureBox2.Image = My.Resources.虚化右箭头
            Exit Sub
        End If
        PictureBox1.Image = My.Resources.左箭头
        Label2.Text = Items.Item(SIndex)
    End Sub
End Class
