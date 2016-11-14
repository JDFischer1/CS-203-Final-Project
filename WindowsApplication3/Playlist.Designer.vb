<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Playlist
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lstSongList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.radCountry = New System.Windows.Forms.RadioButton()
        Me.radRock = New System.Windows.Forms.RadioButton()
        Me.radPop = New System.Windows.Forms.RadioButton()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.dgvLibrary = New System.Windows.Forms.DataGridView()
        Me.SongLibraryDataSet = New WindowsApplication3.SongLibraryDataSet()
        Me.LibraryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryTableAdapter = New WindowsApplication3.SongLibraryDataSetTableAdapters.LibraryTableAdapter()
        Me.SongTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtistDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LengthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvLibrary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SongLibraryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstSongList
        '
        Me.lstSongList.FormattingEnabled = True
        Me.lstSongList.ItemHeight = 20
        Me.lstSongList.Location = New System.Drawing.Point(372, 67)
        Me.lstSongList.Name = "lstSongList"
        Me.lstSongList.Size = New System.Drawing.Size(296, 224)
        Me.lstSongList.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(487, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Playlist"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.radCountry)
        Me.GroupBox1.Controls.Add(Me.radRock)
        Me.GroupBox1.Controls.Add(Me.radPop)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(222, 224)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Genre"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(19, 163)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(89, 24)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Custom"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'radCountry
        '
        Me.radCountry.AutoSize = True
        Me.radCountry.Location = New System.Drawing.Point(19, 122)
        Me.radCountry.Name = "radCountry"
        Me.radCountry.Size = New System.Drawing.Size(89, 24)
        Me.radCountry.TabIndex = 2
        Me.radCountry.TabStop = True
        Me.radCountry.Text = "Country"
        Me.radCountry.UseVisualStyleBackColor = True
        '
        'radRock
        '
        Me.radRock.AutoSize = True
        Me.radRock.Location = New System.Drawing.Point(19, 78)
        Me.radRock.Name = "radRock"
        Me.radRock.Size = New System.Drawing.Size(71, 24)
        Me.radRock.TabIndex = 1
        Me.radRock.TabStop = True
        Me.radRock.Text = "Rock"
        Me.radRock.UseVisualStyleBackColor = True
        '
        'radPop
        '
        Me.radPop.AutoSize = True
        Me.radPop.Location = New System.Drawing.Point(19, 36)
        Me.radPop.Name = "radPop"
        Me.radPop.Size = New System.Drawing.Size(62, 24)
        Me.radPop.TabIndex = 0
        Me.radPop.TabStop = True
        Me.radPop.Text = "Pop"
        Me.radPop.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(372, 323)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(86, 45)
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(582, 323)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 45)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dgvLibrary
        '
        Me.dgvLibrary.AllowUserToAddRows = False
        Me.dgvLibrary.AllowUserToDeleteRows = False
        Me.dgvLibrary.AutoGenerateColumns = False
        Me.dgvLibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLibrary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SongTitleDataGridViewTextBoxColumn, Me.ArtistDataGridViewTextBoxColumn, Me.GenreDataGridViewTextBoxColumn, Me.LengthDataGridViewTextBoxColumn})
        Me.dgvLibrary.DataSource = Me.LibraryBindingSource
        Me.dgvLibrary.Location = New System.Drawing.Point(692, 58)
        Me.dgvLibrary.Name = "dgvLibrary"
        Me.dgvLibrary.ReadOnly = True
        Me.dgvLibrary.RowTemplate.Height = 28
        Me.dgvLibrary.Size = New System.Drawing.Size(507, 310)
        Me.dgvLibrary.TabIndex = 7
        '
        'SongLibraryDataSet
        '
        Me.SongLibraryDataSet.DataSetName = "SongLibraryDataSet"
        Me.SongLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LibraryBindingSource
        '
        Me.LibraryBindingSource.DataMember = "Library"
        Me.LibraryBindingSource.DataSource = Me.SongLibraryDataSet
        '
        'LibraryTableAdapter
        '
        Me.LibraryTableAdapter.ClearBeforeFill = True
        '
        'SongTitleDataGridViewTextBoxColumn
        '
        Me.SongTitleDataGridViewTextBoxColumn.DataPropertyName = "Song Title"
        Me.SongTitleDataGridViewTextBoxColumn.HeaderText = "Song Title"
        Me.SongTitleDataGridViewTextBoxColumn.Name = "SongTitleDataGridViewTextBoxColumn"
        Me.SongTitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ArtistDataGridViewTextBoxColumn
        '
        Me.ArtistDataGridViewTextBoxColumn.DataPropertyName = "Artist"
        Me.ArtistDataGridViewTextBoxColumn.HeaderText = "Artist"
        Me.ArtistDataGridViewTextBoxColumn.Name = "ArtistDataGridViewTextBoxColumn"
        Me.ArtistDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GenreDataGridViewTextBoxColumn
        '
        Me.GenreDataGridViewTextBoxColumn.DataPropertyName = "Genre"
        Me.GenreDataGridViewTextBoxColumn.HeaderText = "Genre"
        Me.GenreDataGridViewTextBoxColumn.Name = "GenreDataGridViewTextBoxColumn"
        Me.GenreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LengthDataGridViewTextBoxColumn
        '
        Me.LengthDataGridViewTextBoxColumn.DataPropertyName = "Length"
        Me.LengthDataGridViewTextBoxColumn.HeaderText = "Length"
        Me.LengthDataGridViewTextBoxColumn.Name = "LengthDataGridViewTextBoxColumn"
        Me.LengthDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Playlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 669)
        Me.Controls.Add(Me.dgvLibrary)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstSongList)
        Me.Name = "Playlist"
        Me.Text = "Playlist"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvLibrary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SongLibraryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstSongList As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents radCountry As RadioButton
    Friend WithEvents radRock As RadioButton
    Friend WithEvents radPop As RadioButton
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents dgvLibrary As DataGridView
    Friend WithEvents SongLibraryDataSet As SongLibraryDataSet
    Friend WithEvents LibraryBindingSource As BindingSource
    Friend WithEvents LibraryTableAdapter As SongLibraryDataSetTableAdapters.LibraryTableAdapter
    Friend WithEvents SongTitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ArtistDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LengthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
