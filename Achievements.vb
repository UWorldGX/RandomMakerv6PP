Public Class Achievements
    Public Structure Achievementcollection
        Public Property Name As String
        Public Property Statements As String
        Public Property IsAchieved As Boolean

        Public Property Difficulty As Byte
        '0-common,1-uncommon,2-rare,3-epic
    End Structure


    Public AchievementCollections(-1) As Achievementcollection


End Class
