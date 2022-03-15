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
End Module
