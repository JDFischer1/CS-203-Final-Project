Public Class Music
    Private mTitle As String
    Private mArtist As String
    Private mGenre As String
    Private mSongTime As Integer
    Private adapter As New SongLibraryDataSetTableAdapters.LibraryTableAdapter

    Public Function GetByGenre(ByVal genre As String) As DataTable
        Dim table As DataTable = adapter.GetData()
        table.DefaultView.RowFilter = "Genre" & genre
        Return table

    End Function

    Public Function Insert(ByVal title As String, ByVal Artist As String, ByVal genre As String, ByVal seconds As Integer) As Boolean
        Try
            adapter.Insert(title, Artist, genre, seconds)
            Return True
        Catch ex As Exception
            MessageBox.Show("Insert error")
            Return False
        End Try
    End Function
    Public ReadOnly Property Items As DataTable
        Get
            Return adapter.GetData()
        End Get
    End Property
    Public Function FindByTitle(ByVal title As String) As SongLibraryDataSet.LibraryRow
        Dim table As SongLibraryDataSet.LibraryDataTable
        table = adapter.GetData()
        Return table.FindBySong_Title(title)
    End Function
End Class
