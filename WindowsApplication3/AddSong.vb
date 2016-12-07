Public Class AddSong
    Private mMusic As New Music

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub CustomPlaylist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With cboGenre
            .Items.Add("Pop")
            .Items.Add("Rock")
            .Items.Add("Country")
        End With
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim Title As String = txtTitle.Text
        Dim Artist As String = txtArtist.Text
        Dim genre As String = (cboGenre.SelectedItem)
        Dim seconds As Integer = CInt(txtSeconds.Text)

        If mMusic.Insert(Title, Artist, genre, seconds) Then
            Me.Close()
        End If

    End Sub
End Class