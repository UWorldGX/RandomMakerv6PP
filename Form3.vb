Public Class Form3
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/UWorldGX/RandomMakerv6PP")
        Form1.Show()

        Me.Close()
    End Sub
End Class