
Public Class Configs
    Public Property Name As String
    Public Property CurrentMode As Integer
    Public Property TotalMode As Integer
    Public Property MaxArea As Integer
    Public Property Voicespeed As Integer
    Public Property BackGroundImage As String
    Public Property DialogImage As String
    Public Property CreateTime As String
    Public Property Version As String
    Public Property Fonts As String
    Public Property DoCustomFonts As Boolean
    Public Structure CLR
        Public Property R As Byte
        Public Property G As Byte
        Public Property B As Byte
    End Structure
    Public MyColor As CLR
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

Public Class Stat
    Public Property Statistics As List(Of String)
    Public Property StaCounts As List(Of Integer)
End Class

