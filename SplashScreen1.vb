Public NotInheritable Class SplashScreen1

    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Enabled = True
        Form1.Hide()
        Form1.Refresh()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Refresh()
        Timer2.Enabled = True
        Timer1.Enabled = False
        Label1.Text = "Now Loading."
        UiProcessBar1.Value = 33
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Refresh()
        Timer3.Enabled = True
        Timer2.Enabled = False
        Label1.Text = "Now Loading.."
        Form1.Show()
        UiProcessBar1.Value = 66
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Me.Refresh()
        Timer4.Enabled = True
        Timer3.Enabled = False
        Label1.Text = "Now Loading..."
        UiProcessBar1.Value = 99
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        UiProcessBar1.Value = 100
        Me.Close()
    End Sub

End Class