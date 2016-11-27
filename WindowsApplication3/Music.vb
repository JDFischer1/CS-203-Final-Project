Public Class Music
    Private mTitle As String
    Private mArtist As String
    Private mGenre As String
    Private mSongTime As Integer
    Private adapter As New SongLibraryDataSetTableAdapters.LibraryTableAdapter
    Public Sub New(ByVal pTitle As String, ByVal pArtist As String, ByVal pGenre As String, ByVal pSongTime As Integer)
        mTitle = pTitle
        mArtist = pArtist
        mGenre = pGenre
        mSongTime = pSongTime
    End Sub


    Public Function GetByGenre(ByVal genre As String) As DataTable
        Dim table As DataTable = adapter.GetData()
        table.DefaultView.RowFilter = "Genre" & genre
        Return table

    End Function
    'Public Function getTitle(ByVal title As String)
    '    Dim table As DataTable = adapter.GetData()
    '    table.DefaultView.RowFilter = "Title" & title
    '    Return mTitle

    'End Function
End Class
