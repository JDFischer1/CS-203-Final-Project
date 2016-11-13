Public MustInherit Class Music
    Private mTitle As String
    Private mArtist As String

    Public Sub New(ByVal pTitle As String, ByVal pArtist As String, ByVal pGenre As String, ByVal pSongTime As Integer)
        mTitle = pTitle
        mArtist = pArtist
    End Sub

End Class
