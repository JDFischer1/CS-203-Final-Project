Public Class Playlist
    ' Private mSongs As New Music
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub Playlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radRock.Checked = False
        radPop.Checked = False
        radCountry.Checked = False
        radCustom.Checked = False

        'TODO: This line of code loads data into the 'SongLibraryDataSet.Library' table. You can move, or remove it, as needed.
        ' Populate the song list.  Pull information from database 
        Me.LibraryTableAdapter.Fill(Me.SongLibraryDataSet.Library)


    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        ' Mainform.SetSongList(lstSongList.SelectedItem)



        If dgvLibrary.SelectedRows.Count > 0 Then
            Mainform.SetSongList(dgvLibrary.SelectedRows)
        End If

        Me.Close()
    End Sub

    Private Sub GetbygenreToolStripButton_Click(sender As Object, e As EventArgs)

        getGenre()

    End Sub

    Private Sub radPop_CheckedChanged(sender As Object, e As EventArgs) Handles radPop.CheckedChanged, radCountry.CheckedChanged, radRock.CheckedChanged
        'Dim genre As String = "Pop"
        If radPop.Checked = True Then
            GenreToolStripTextBox.Text = "Pop"
            '  GetbygenreToolStripButton.CheckOnClick = True
        ElseIf radCountry.Checked = True Then
            GenreToolStripTextBox.Text = "Country"
            '  GetbygenreToolStripButton.CheckOnClick = True
        ElseIf radRock.Checked = True Then
            GenreToolStripTextBox.Text = "Rock"
            '  GetbygenreToolStripButton.CheckOnClick = True
        End If
    End Sub

    Private Sub radCountry_Click(sender As Object, e As EventArgs) Handles radCountry.Click
        GenreToolStripTextBox.Text = "Country"
        getGenre()
    End Sub

    Private Sub radPop_Click(sender As Object, e As EventArgs) Handles radPop.Click
        GenreToolStripTextBox.Text = "Pop"
        getGenre()
    End Sub

    Private Sub getGenre()
        Try
            Me.LibraryTableAdapter.Getbygenre(Me.SongLibraryDataSet.Library, GenreToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub radRock_Click(sender As Object, e As EventArgs) Handles radRock.Click
        GenreToolStripTextBox.Text = "Rock"
        getGenre()

    End Sub
End Class