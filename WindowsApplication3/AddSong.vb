Public Class AddSong
    Private mMusic As New Music
    'close the form
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub CustomPlaylist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load up the combo box when form loads
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
        Dim seconds As Integer
        errProvider.Clear()
        'ensures an input was made
        If txtTitle.Text = "" Then
            errProvider.SetError(txtTitle, "Please enter a song title")
            txtTitle.Focus()
            Return
        End If

        If txtArtist.Text = "" Then
            errProvider.SetError(txtArtist, "Please enter an Artist Name")
            txtArtist.Focus()
            Return
        End If
        'ensures an integer was input
        If Not Integer.TryParse(txtSeconds.Text, seconds) Then
            errProvider.SetError(txtSeconds, "Please enter song length in seconds")
            txtSeconds.Text = ""
            txtSeconds.Focus()
            Return
        End If
        'ensures an input
        If txtSeconds.Text = "" Then
            errProvider.SetError(txtSeconds, "Please enter song length in seconds")
            txtSeconds.Text = ""
            txtSeconds.Focus()
            Return
        End If
        'ensures integer for seconds was positive
        If seconds < 0 Then
            errProvider.SetError(txtSeconds, "Please enter song length in seconds")
            '  MessageBox.Show("Please enter a numeric value in seconds")
            txtSeconds.Text = ""
            txtSeconds.Focus()
            Return
        End If
        'ensures a genre was selected
        If cboGenre.SelectedIndex < 0 Then
            errProvider.SetError(cboGenre, "Please select a genre")
            cboGenre.Focus()
            Return
        End If
        'if all the inputs are there then put in the database

        If mMusic.Insert(Title, Artist, genre, seconds) Then
            Library.LibraryTableAdapter.Fill(Library.SongLibraryDataSet.Library)
            Me.Close()
        End If

    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clears all inputs
        txtSeconds.Clear()
        txtArtist.Clear()
        txtTitle.Clear()
        txtTitle.Focus()
    End Sub
End Class