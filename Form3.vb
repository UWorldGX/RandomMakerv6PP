Public Class Form3
    Public web As Boolean = False
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/UWorldGX/RandomMakerv6PP")
        Form1.Show()
        web = True
        DoGitHub(web)
        Me.Close()
    End Sub
End Class