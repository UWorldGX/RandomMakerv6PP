Imports System.Windows.Forms

Public Class UniversalDialog1
    Dim level As Integer, IO As Boolean, DoOK As Boolean
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        IO = False
        DoOK = True
        Anime.Enabled = True
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        IO = False
        DoOK = False
        Anime.Enabled = True
    End Sub

    Private Sub UniversalDialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        level = 0
        IO = True
        Anime.Enabled = True
        If Form1.DoReadOnly = True Then
            Cancel_Button.Visible = False
        Else
            Cancel_Button.Visible = True
        End If
        If Form1.DoMultiLine = True Then
            Label2.Visible = True
        Else
            Label2.Visible = False
        End If
    End Sub

    Private Sub Anime_Tick(sender As Object, e As EventArgs) Handles Anime.Tick
        Select Case IO
            Case Is = True
                level += 1
            Case Is = False
                level -= 1
        End Select
        If level > 10 Then
            Anime.Enabled = False
        ElseIf level < 1 Then
            Anime.Enabled = False
            If DoOK = True Then
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            End If
            Me.Close()
        End If
        Anima(level)
    End Sub

    Sub Anima(e As Integer)
        Me.Opacity = e / 10
    End Sub
End Class
