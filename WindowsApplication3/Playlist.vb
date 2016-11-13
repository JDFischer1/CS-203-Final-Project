Public Class Playlist
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSongList.SelectedIndexChanged

    End Sub

    Private Sub Playlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the song list.  Pull information from database 
        lstSongList.Items.Add("Mary Had a Little Lamb,   Guns and Roses,   2:30")
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Mainform.SetSongList(lstSongList.SelectedItem)
        Me.Close()

    End Sub


End Class