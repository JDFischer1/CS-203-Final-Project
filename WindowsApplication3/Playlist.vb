Public Class Playlist
    ' Private mSongs As Music
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub Playlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SongLibraryDataSet.Library' table. You can move, or remove it, as needed.
        Me.LibraryTableAdapter.Fill(Me.SongLibraryDataSet.Library)
        ' Populate the song list.  Pull information from database 
        ' lstSongList.Items.Add("Mary Had a Little Lamb,   Guns and Roses,   2:30")

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        ' Mainform.SetSongList(lstSongList.SelectedItem)

        If dgvLibrary.SelectedRows.Count > 0 Then
            Mainform.SetSongList(dgvLibrary.SelectedRows(0).Cells(0).Value, dgvLibrary.SelectedRows(0).Cells(1).Value)

        End If

        Me.Close()
    End Sub

    'Private Sub radPop_CheckedChanged(sender As Object, e As EventArgs) Handles radPop.CheckedChanged, radCountry.CheckedChanged, radRock.CheckedChanged
    '    Dim genre As String = "Pop"
    '    If radPop.Checked = True Then

    '        dgvLibrary.DataSource = mSongs.GetByGenre(genre)
    '    End If
    '  End Sub
End Class