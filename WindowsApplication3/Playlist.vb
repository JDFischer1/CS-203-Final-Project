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
            Mainform.SetSongList(dgvLibrary.SelectedRows(0).Cells(0).Value, dgvLibrary.SelectedRows(0).Cells(1).Value)

        End If

        Me.Close()
    End Sub

    Private Sub GetbygenreToolStripButton_Click(sender As Object, e As EventArgs) Handles GetbygenreToolStripButton.Click

        Try
            Me.LibraryTableAdapter.Getbygenre(Me.SongLibraryDataSet.Library, GenreToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

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

End Class