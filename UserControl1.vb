Public Class UserControl1
    Public Property Minimum As Integer = 1
    Public Property Maximum As Integer = 100
    Public Property Value As Integer = 1
    Public Property Warn As Boolean = False

    Public Property Type As Integer
    Public Property BlueText As String = "Hety"
    Dim WithEvents EClass As New EventClass
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
        DecideBehavior(Type)
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
        DecideBehavior(Type)
    End Sub

    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Value
        Label1.Text = BlueText
        EClass = New EventClass
    End Sub
    Private Sub DecideBehavior(a As Integer)
        Select Case a
            Case Is = 0
                Form1.TimesChanged()
            Case Is = 1
                Form1.RangeChanged()
        End Select
    End Sub

    Private Sub UserControl1_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        Me.BackgroundImage = My.Resources.常规选项卡

    End Sub

    Private Sub UserControl1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        Me.BackgroundImage = My.Resources.选定选项卡
    End Sub

    Sub EventHandler() Handles EClass.ValueChanged
        MsgBox("Handles OK.")
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

    Class EventClass
        Public Event ValueChanged()
        Sub RO()
            RaiseEvent ValueChanged()
        End Sub

    End Class
End Class
