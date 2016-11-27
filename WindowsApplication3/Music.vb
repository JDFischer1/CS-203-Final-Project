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

    'Public Property Title() As String
    '    Get
    '        Return mTitle
    '    End Get
    '    Set(value As String)
    '        mTitle = value
    '    End Set
    'End Property
    'Public Property Artist As String
    '    Get
    '        Return mArtist
    '    End Get
    '    Set(value As String)
    '        mArtist = value
    '    End Set
    'End Property
    'Public Property Genre As String
    '    Get
    '        Return mGenre
    '    End Get
    '    Set(value As String)
    '        mGenre = value
    '    End Set
    'End Property
    'Public Property SongTime As Integer
    '    Get
    '        Return mSongTime
    '    End Get
    '    Set(value As Integer)
    '        mSongTime = value
    '    End Set
    'End Property


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
