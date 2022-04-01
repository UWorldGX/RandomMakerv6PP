Public Class UserControl1
    Public Property Minimum As Integer = 1
    Public Property Maximum As Integer = 100
    Public Property Value As Integer = 1
    Public Property Warn As Boolean = False

    Public Property Type As Integer
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
        If Value = Minimum Then
            PictureBox2.Image = My.Resources.虚化右箭头
        End If
        PictureBox1.Image = My.Resources.左箭头
        Label2.Text = Value
    End Sub

    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Value
        Label1.Text = BlueText
    End Sub


    Private Sub UserControl1_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        Me.BackgroundImage = My.Resources.常规选项卡
    End Sub

    Private Sub UserControl1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        Me.BackgroundImage = My.Resources.选定选项卡
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Public Sub Reload()
        Label2.Text = Value
        Label1.Text = BlueText
        Me.Refresh()
    End Sub
End Class
