
Public Class Mode
    Public Name As String
    Public Type As Boolean
    Public Range As Integer
    Public Times As Integer
    Public DoExtreme As Boolean
    Public DoRepeat As Boolean
End Class
Public Class Configs
    Public Name As String
    Public CurrentMode As Integer
    Public TotalMode As Integer
    Public MaxArea As Integer
    Public Voicespeed As Integer
    Public BackGroundImage As String
    Public DialogImage As String
    Public CreateTime As String
    Public Version As String
    Public ModeCollections() As Mode
End Class

