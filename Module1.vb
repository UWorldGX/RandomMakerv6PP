Module Module1
    Public Function Timeformat(dt As DateTime)
        Dim month, day, hour, minute, second, all As String
        If dt.Month < 10 Then
            month = "0" & dt.Month
        Else
            month = dt.Month
        End If
        If dt.Day < 10 Then
            day = "0" & dt.Day
        Else
            day = dt.Day
        End If
        If dt.Hour < 10 Then
            hour = "0" & dt.Hour
        Else
            hour = dt.Hour
        End If
        If dt.Minute < 10 Then
            minute = "0" & dt.Minute
        Else
            minute = dt.Minute
        End If
        If dt.Second < 10 Then
            second = "0" & dt.Second
        Else
            second = dt.Second
        End If
        all = dt.Year & "-" & month & "-" & day & "," & hour & "-" & minute & "-" & second
        Return all
    End Function

    Public Sub GeneralD()
        DoTimes(Form1.AC.TTimes)
    End Sub

    Public Sub DoNiuMa(a As Integer, b As Stat)
        If Form1.AC.AchievementCollections(6).IsAchieved = False Then
            If a = 0 Then Form1.AC.AchievementCollections(6).IsAchieved = True
            Achieved(Form1, Form1.AC.AchievementCollections(6).Name)
        End If
        If Form1.AC.AchievementCollections(7).IsAchieved = False Then
            Dim c As Integer
            For Each i As String In b.Statistics
                If i = "付世凯" Then
                    c += 1
                End If
            Next
            If c > 9 Then
                Form1.AC.AchievementCollections(7).IsAchieved = True
                Achieved(Form1, Form1.AC.AchievementCollections(7).Name)
            End If
        End If
    End Sub

    Public Sub DoTimes(a As Integer)
        '确定其中四个成就的达成
        If Form1.AC.AchievementCollections(0).IsAchieved = False Then
            If a > 100 Then
                Form1.AC.AchievementCollections(0).IsAchieved = True
                Achieved(Form1, Form1.AC.AchievementCollections(0).Name)
            End If
        End If
        If Form1.AC.AchievementCollections(1).IsAchieved = False Then

            If a > 500 Then
                Form1.AC.AchievementCollections(1).IsAchieved = True
                Achieved(Form1, Form1.AC.AchievementCollections(1).Name)
            End If
        End If
        If Form1.AC.AchievementCollections(2).IsAchieved = False Then
            If a > 1000 Then
                Form1.AC.AchievementCollections(2).IsAchieved = True
                Achieved(Form1, Form1.AC.AchievementCollections(2).Name)
            End If
        End If
        If Form1.AC.AchievementCollections(8).IsAchieved = False Then
            If a > 7500 Then
                Form1.AC.AchievementCollections(8).IsAchieved = True
                Achieved(Form1, Form1.AC.AchievementCollections(8).Name)
            End If
        End If
    End Sub

    Sub DoGitHub(a As Boolean)
        If Form1.AC.AchievementCollections(9).IsAchieved = False Then
            If a = True Then Form1.AC.AchievementCollections(9).IsAchieved = True
            Achieved(Form1, Form1.AC.AchievementCollections(9).Name)
        End If
    End Sub
    Sub DoLucky(b As Stat)
        If Form1.AC.AchievementCollections(5).IsAchieved = False Then

            If b.Statistics.Count > 15 Then
                For i As Integer = 0 To b.Statistics.Count - 1
                    If b.StaCounts(i) / b.StaCounts.Count > 0.15 Then
                        Achieved(Form1, Form1.AC.AchievementCollections(5).Name)
                        Form1.AC.AchievementCollections(5).IsAchieved = True
                    End If
                Next
            End If
        End If
    End Sub

    Sub Achieved(f As Form, st As String)
        Notice.ShowTipsSuccess(f, st & " 成就达成!")
    End Sub
End Module
