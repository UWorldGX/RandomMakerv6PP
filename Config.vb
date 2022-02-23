Public Class Mode
    Public Name As String
    Public Type As Boolean
    Public Range As Byte
    Public Times As Byte
    Public DoExtreme As Boolean
    Public DoRepeat As Boolean
End Class

Public Class Config
    Public Name As String
    Public Ver As String
    Public TotalMode As Byte
    Public CurrentMode As Byte
    Public MaximaArea As Byte
    Public BackGroundImage As String
    Public VoiceSpeed As Byte
    Public CreateTime As String
    Public ModeCollection() As Mode
End Class
