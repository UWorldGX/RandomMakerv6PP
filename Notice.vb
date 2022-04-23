Public Class Notice
    Inherits HZH_Controls.Forms.FrmTips

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Notice
        '
        Me.ClientSize = New System.Drawing.Size(340, 47)
        Me.CloseTime = 500
        Me.Name = "Notice"
        Me.ResumeLayout(False)

    End Sub

    Private Sub Notice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeComponent()
    End Sub

    Sub DoNotice(ac As Achievements)

    End Sub


End Class
