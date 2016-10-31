Public Class Country
    Inherits Music
    Private Property Genre As String
    Public Sub New(ByVal pTitle As String, ByVal pArtist As String, ByVal pGenre As String)
        MyBase.New(pTitle, pArtist)
        Genre = pGenre

    End Sub
End Class
