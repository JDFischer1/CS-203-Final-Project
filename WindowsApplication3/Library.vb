Public Class Library
    Private mSongs As New Music
    Private adapter As New SongLibraryDataSetTableAdapters.LibraryTableAdapter


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub Playlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the song list.  Pull information from database 
        Me.LibraryTableAdapter.Fill(Me.SongLibraryDataSet.Library)
        chkGenre.Checked = False
        gbxGenre.Enabled = False
        'set radio buttons to unchecked
        btnOK.Focus()
        radPop.Checked = False
        radCountry.Checked = False
        radRock.Checked = False
        'clear the mainform listbox
        Mainform.lstNowPlaying.Items.Clear()




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
    Private Sub CheckBoxes(ByVal Check As Boolean)
        Dim i As Integer

        For i = 0 To dgvLibrary.Rows.Count - 1
            dgvLibrary.Rows(i).Selected = Check
        Next

    End Sub
    ' Private Sub radPop_CheckedChanged(sender As Object, e As EventArgs) Handles radPop.CheckedChanged, radCountry.CheckedChanged, radRock.CheckedChanged


    'Dim genre As String = "Pop"
    '    CheckBoxes(True)
    'If radPop.Checked = True Then
    '       GenreToolStripTextBox.Text = "Pop"
    '  GetbygenreToolStripButton.CheckOnClick = True
    'ElseIf radCountry.Checked = True Then
    '       GenreToolStripTextBox.Text = "Country"
    '  GetbygenreToolStripButton.CheckOnClick = True
    'ElseIf radRock.Checked = True Then
    '       GenreToolStripTextBox.Text = "Rock"
    '  GetbygenreToolStripButton.CheckOnClick = True
    '      CheckBoxes(True)
    'End If


    'End Sub


    Private Sub radCountry_Click(sender As Object, e As EventArgs) Handles radCountry.Click
        GenreToolStripTextBox.Text = "Country"
        getGenre()
        CheckBoxes(True)
    End Sub

    Private Sub radPop_Click(sender As Object, e As EventArgs) Handles radPop.Click
        GenreToolStripTextBox.Text = "Pop"
        getGenre()
        CheckBoxes(True)
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
        CheckBoxes(True)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddSong.ShowDialog()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim index As Integer
        index = dgvLibrary.CurrentCell.RowIndex
        dgvLibrary.Rows.RemoveAt(index)

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.LibraryTableAdapter.Fill(Me.SongLibraryDataSet.Library)
    End Sub

    Private Sub chkGenre_CheckedChanged(sender As Object, e As EventArgs) Handles chkGenre.CheckedChanged
        If chkGenre.Checked = True Then
            gbxGenre.Enabled = True
        Else
            gbxGenre.Enabled = False
            Me.LibraryTableAdapter.Fill(Me.SongLibraryDataSet.Library)
        End If
    End Sub


End Class