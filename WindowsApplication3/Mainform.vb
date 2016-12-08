Public Class Mainform
    Dim numberSongSeconds As Integer
    Dim songList As DataGridViewSelectedRowCollection
    Const titleColumn = 0
    Const artistColumn = 1
    Const timeColumn = 3
    'loads the library form
    Private Sub CreatePlaylistToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreatePlaylistToolStripMenuItem.Click
        Library.ShowDialog()
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        'calls the playsong method and handles the button enabling
        btnStop.Enabled = True
        btnRewind.Enabled = True
        playSong()

    End Sub
    'converts seconds to minutes:seconds
    Private Function convertSecondstoMinutesSeconds(ByVal numberSongSeconds As Integer)
        Dim songMinutes As Integer
        Dim songSeconds As Integer
        'math to convert seconds to min:seconds
        songMinutes = numberSongSeconds \ 60
        songSeconds = (numberSongSeconds Mod 60)

        Return songMinutes.ToString & ":" & songSeconds.ToString.PadLeft(2, "0"c)
    End Function

    Public Sub SetSongList(ByVal SongNames As DataGridViewSelectedRowCollection)
        ' How many items are in the list?
        songList = SongNames

        ' This goes into the Play button Click
        For songCount = SongNames.Count - 1 To 0 Step -1
            lstNowPlaying.Items.Add(songList(songCount).Cells(titleColumn).Value & " - " & songList(songCount).Cells(artistColumn).Value)

        Next
        lstNowPlaying.SelectedIndex = 0
        numberSongSeconds = CInt(songList(lstNowPlaying.SelectedIndex).Cells(timeColumn).Value)
        lblSongTimer.Text = convertSecondstoMinutesSeconds(numberSongSeconds)
        btnPlay.Enabled = True
        btnFastForward.Enabled = True

    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        btnPlay.Visible = True
        timCounter.Enabled = False
    End Sub

    Private Sub playSong()
        ' Get the song time and display in lblSongTimer (convert time from seconds to min:seconds)\
        btnPlay.Visible = False
        ' Start the timCounter (set to one second each)
        timCounter.Interval = 1000
        timCounter.Enabled = True

    End Sub
    Private Sub lstNowPlaying_DoubleClick(sender As Object, e As EventArgs) Handles lstNowPlaying.DoubleClick
        playSong()
    End Sub
    Private Sub lstNowPlaying_Click(sender As Object, e As EventArgs) Handles lstNowPlaying.Click
        numberSongSeconds = CInt(songList(lstNowPlaying.SelectedIndex).Cells(timeColumn).Value)
        lblSongTimer.Text = convertSecondstoMinutesSeconds(numberSongSeconds)
        If lstNowPlaying.SelectedIndex = 0 Then
            btnRewind.Enabled = False
        Else
            btnRewind.Enabled = True
        End If
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        'rules for button visibility/useability when stop is pushed
        If btnStop.Enabled = True Then
            btnStop.Enabled = False
            btnPlay.Visible = True
            'pause timer
            timCounter.Enabled = False
        End If

    End Sub
    Private Sub btnFastForward_Click(sender As Object, e As EventArgs) Handles btnFastForward.Click
        If lstNowPlaying.SelectedIndex = songList.Count - 1 Then
            ' We are at the end of the list - start over
            lstNowPlaying.SelectedIndex = 0
            numberSongSeconds = CInt(songList(lstNowPlaying.SelectedIndex).Cells(timeColumn).Value)
            lblSongTimer.Text = convertSecondstoMinutesSeconds(numberSongSeconds)
        Else
            ' We are not at the end, just get the next song in the list
            lstNowPlaying.SelectedIndex = lstNowPlaying.SelectedIndex + 1
            numberSongSeconds = CInt(songList(lstNowPlaying.SelectedIndex).Cells(timeColumn).Value)
            lblSongTimer.Text = convertSecondstoMinutesSeconds(numberSongSeconds)
        End If
    End Sub

    Private Sub btnRewind_Click(sender As Object, e As EventArgs) Handles btnRewind.Click
        ' We are not at the end, just get the next song in the list
        If lstNowPlaying.SelectedIndex > 0 Then
            lstNowPlaying.SelectedIndex = lstNowPlaying.SelectedIndex - 1
            numberSongSeconds = CInt(songList(lstNowPlaying.SelectedIndex).Cells(timeColumn).Value)
            lblSongTimer.Text = convertSecondstoMinutesSeconds(numberSongSeconds)
        Else
            lstNowPlaying.SelectedIndex = lstNowPlaying.Items.Count - 1
            numberSongSeconds = CInt(songList(lstNowPlaying.SelectedIndex).Cells(timeColumn).Value)
            lblSongTimer.Text = convertSecondstoMinutesSeconds(numberSongSeconds)

        End If
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs)
        AddSong.ShowDialog()
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.ShowDialog()
    End Sub
End Class
