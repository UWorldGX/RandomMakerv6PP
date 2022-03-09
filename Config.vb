
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
    Public Structure Mode
        Public Property Name As String
        Public Property Type As Boolean
        Public Property Range As Integer
        Public Property Times As Integer
        Public Property DoExtreme As Boolean
        Public Property DoRepeat As Boolean
    End Structure

    Public ModeCollections(10) As Mode
End Class

