Public Class Mainform
    Dim numberSongSeconds As Integer

    Private Sub CreatePlaylistToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreatePlaylistToolStripMenuItem.Click
        Playlist.ShowDialog()

    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        ' Get the song time and display in lblSongTimer (convert time from seconds to min:seconds)
        numberSongSeconds = 150
        lblSongTimer.Text = convertSecondstoMinutesSeconds(numberSongSeconds)

        btnPlay.Visible = False

        ' Start the timCounter (set to one second each)
        timCounter.Interval = 1000
        timCounter.Enabled = True

        ' Change the button to a pause button
    End Sub

    Private Function convertSecondstoMinutesSeconds(ByVal numberSongSeconds As Integer)
        Dim songMinutes As Integer
        Dim songSeconds As Integer

        songMinutes = numberSongSeconds / 60
        songSeconds = numberSongSeconds Mod 60

        Return Str(songMinutes) & ":" & Str(songSeconds)

    End Function
    Public Sub SetSongList(ByVal SongName As String)
        ' How many items are in the list?
        lblNowPlaying.Text = SongName

        ' This goes into the Play button Click
        'lblSongTimer.Text = convertSecondstoMinutesSeconds(Songlist)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        btnPlay.Visible = True
    End Sub
End Class
