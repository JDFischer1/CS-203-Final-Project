<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Playlist
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Playlist))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radCustom = New System.Windows.Forms.RadioButton()
        Me.radCountry = New System.Windows.Forms.RadioButton()
        Me.radRock = New System.Windows.Forms.RadioButton()
        Me.radPop = New System.Windows.Forms.RadioButton()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.dgvLibrary = New System.Windows.Forms.DataGridView()
        Me.SongTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtistDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LengthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibraryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SongLibraryDataSet = New WindowsApplication3.SongLibraryDataSet()
        Me.LibraryTableAdapter = New WindowsApplication3.SongLibraryDataSetTableAdapters.LibraryTableAdapter()
        Me.GetbygenreToolStrip = New System.Windows.Forms.ToolStrip()
        Me.GenreToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.GenreToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvLibrary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SongLibraryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GetbygenreToolStrip.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GroupBox1.Controls.Add(Me.radCustom)
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
        'radCustom
        '
        Me.radCustom.AutoSize = True
        Me.radCustom.Location = New System.Drawing.Point(19, 163)
        Me.radCustom.Name = "radCustom"
        Me.radCustom.Size = New System.Drawing.Size(89, 24)
        Me.radCustom.TabIndex = 3
        Me.radCustom.TabStop = True
        Me.radCustom.Text = "Custom"
        Me.radCustom.UseVisualStyleBackColor = True
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
        Me.btnOK.Location = New System.Drawing.Point(296, 410)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(86, 45)
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(478, 410)
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
        Me.dgvLibrary.Location = New System.Drawing.Point(296, 67)
        Me.dgvLibrary.Name = "dgvLibrary"
        Me.dgvLibrary.ReadOnly = True
        Me.dgvLibrary.RowTemplate.Height = 28
        Me.dgvLibrary.Size = New System.Drawing.Size(1045, 310)
        Me.dgvLibrary.TabIndex = 7
        '
        'SongTitleDataGridViewTextBoxColumn
        '
        Me.SongTitleDataGridViewTextBoxColumn.DataPropertyName = "Song Title"
        Me.SongTitleDataGridViewTextBoxColumn.HeaderText = "Song Title"
        Me.SongTitleDataGridViewTextBoxColumn.Name = "SongTitleDataGridViewTextBoxColumn"
        Me.SongTitleDataGridViewTextBoxColumn.ReadOnly = True
        Me.SongTitleDataGridViewTextBoxColumn.Width = 250
        '
        'ArtistDataGridViewTextBoxColumn
        '
        Me.ArtistDataGridViewTextBoxColumn.DataPropertyName = "Artist"
        Me.ArtistDataGridViewTextBoxColumn.HeaderText = "Artist"
        Me.ArtistDataGridViewTextBoxColumn.Name = "ArtistDataGridViewTextBoxColumn"
        Me.ArtistDataGridViewTextBoxColumn.ReadOnly = True
        Me.ArtistDataGridViewTextBoxColumn.Width = 200
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
        'LibraryBindingSource
        '
        Me.LibraryBindingSource.DataMember = "Library"
        Me.LibraryBindingSource.DataSource = Me.SongLibraryDataSet
        '
        'SongLibraryDataSet
        '
        Me.SongLibraryDataSet.DataSetName = "SongLibraryDataSet"
        Me.SongLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LibraryTableAdapter
        '
        Me.LibraryTableAdapter.ClearBeforeFill = True
        '
        'GetbygenreToolStrip
        '
        Me.GetbygenreToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.GetbygenreToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenreToolStripLabel, Me.GenreToolStripTextBox, Me.btnAdd, Me.ToolStripSeparator1, Me.btnDelete})
        Me.GetbygenreToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.GetbygenreToolStrip.Name = "GetbygenreToolStrip"
        Me.GetbygenreToolStrip.Size = New System.Drawing.Size(1443, 32)
        Me.GetbygenreToolStrip.TabIndex = 8
        Me.GetbygenreToolStrip.Text = "GetbygenreToolStrip"
        '
        'GenreToolStripLabel
        '
        Me.GenreToolStripLabel.Name = "GenreToolStripLabel"
        Me.GenreToolStripLabel.Size = New System.Drawing.Size(61, 29)
        Me.GenreToolStripLabel.Text = "genre:"
        '
        'GenreToolStripTextBox
        '
        Me.GenreToolStripTextBox.Name = "GenreToolStripTextBox"
        Me.GenreToolStripTextBox.Size = New System.Drawing.Size(100, 32)
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(177, 29)
        Me.btnAdd.Text = "Add Song to Library"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(215, 29)
        Me.btnDelete.Text = "Delete Song from Library"
        '
        'Playlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1443, 669)
        Me.Controls.Add(Me.GetbygenreToolStrip)
        Me.Controls.Add(Me.dgvLibrary)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Playlist"
        Me.Text = "Playlist"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvLibrary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SongLibraryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GetbygenreToolStrip.ResumeLayout(False)
        Me.GetbygenreToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radCustom As RadioButton
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
    Friend WithEvents GetbygenreToolStrip As ToolStrip
    Friend WithEvents GenreToolStripLabel As ToolStripLabel
    Friend WithEvents GenreToolStripTextBox As ToolStripTextBox
    Friend WithEvents btnAdd As ToolStripButton
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
