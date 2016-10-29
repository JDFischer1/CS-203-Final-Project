<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mainform))
        Me.btnRewind = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnFastForward = New System.Windows.Forms.Button()
        Me.lblNowPlaying = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlaylistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreatePlaylistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRewind
        '
        Me.btnRewind.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRewind.Image = CType(resources.GetObject("btnRewind.Image"), System.Drawing.Image)
        Me.btnRewind.Location = New System.Drawing.Point(51, 171)
        Me.btnRewind.Name = "btnRewind"
        Me.btnRewind.Size = New System.Drawing.Size(97, 104)
        Me.btnRewind.TabIndex = 0
        Me.btnRewind.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Image = CType(resources.GetObject("btnPlay.Image"), System.Drawing.Image)
        Me.btnPlay.Location = New System.Drawing.Point(170, 172)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(104, 104)
        Me.btnPlay.TabIndex = 1
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.Image = CType(resources.GetObject("btnStop.Image"), System.Drawing.Image)
        Me.btnStop.Location = New System.Drawing.Point(427, 172)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(119, 104)
        Me.btnStop.TabIndex = 2
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnFastForward
        '
        Me.btnFastForward.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFastForward.Image = CType(resources.GetObject("btnFastForward.Image"), System.Drawing.Image)
        Me.btnFastForward.Location = New System.Drawing.Point(552, 172)
        Me.btnFastForward.Name = "btnFastForward"
        Me.btnFastForward.Size = New System.Drawing.Size(115, 104)
        Me.btnFastForward.TabIndex = 3
        Me.btnFastForward.UseVisualStyleBackColor = True
        '
        'lblNowPlaying
        '
        Me.lblNowPlaying.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNowPlaying.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNowPlaying.Location = New System.Drawing.Point(47, 66)
        Me.lblNowPlaying.Name = "lblNowPlaying"
        Me.lblNowPlaying.Size = New System.Drawing.Size(620, 85)
        Me.lblNowPlaying.TabIndex = 4
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PlaylistToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(708, 33)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(50, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'PlaylistToolStripMenuItem
        '
        Me.PlaylistToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreatePlaylistToolStripMenuItem})
        Me.PlaylistToolStripMenuItem.Name = "PlaylistToolStripMenuItem"
        Me.PlaylistToolStripMenuItem.Size = New System.Drawing.Size(78, 29)
        Me.PlaylistToolStripMenuItem.Text = "Playlist"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(61, 29)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(211, 30)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'CreatePlaylistToolStripMenuItem
        '
        Me.CreatePlaylistToolStripMenuItem.Name = "CreatePlaylistToolStripMenuItem"
        Me.CreatePlaylistToolStripMenuItem.Size = New System.Drawing.Size(211, 30)
        Me.CreatePlaylistToolStripMenuItem.Text = "Create Playlist"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(211, 30)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(293, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 103)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 342)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblNowPlaying)
        Me.Controls.Add(Me.btnFastForward)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.btnRewind)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Mainform"
        Me.Text = "Digital Music Player"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRewind As Button
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnFastForward As Button
    Friend WithEvents lblNowPlaying As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlaylistToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreatePlaylistToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
End Class
