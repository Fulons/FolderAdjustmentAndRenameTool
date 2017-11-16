<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.fbdFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.dgwFolders = New System.Windows.Forms.DataGridView()
        Me.FullPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FolderPic = New System.Windows.Forms.DataGridViewImageColumn()
        Me.OldName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgwFolders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(519, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.OpenToolStripMenuItem.Text = "Open Folder Location"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(14, 37)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 39)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Create Folder"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(14, 102)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(126, 39)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Delete Folder"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(378, 434)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 39)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Rename Parent Folder"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(14, 167)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(126, 39)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Rename All"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.MassFART.My.Resources.Resources.redo1
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button6.Location = New System.Drawing.Point(213, 431)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(43, 42)
        Me.Button6.TabIndex = 12
        Me.Button6.UseVisualStyleBackColor = True
        '
        'dgwFolders
        '
        Me.dgwFolders.AllowUserToAddRows = False
        Me.dgwFolders.AllowUserToDeleteRows = False
        Me.dgwFolders.AllowUserToResizeRows = False
        Me.dgwFolders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwFolders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FullPath, Me.FolderPic, Me.OldName, Me.NewName})
        Me.dgwFolders.Location = New System.Drawing.Point(164, 37)
        Me.dgwFolders.Name = "dgwFolders"
        Me.dgwFolders.Size = New System.Drawing.Size(340, 380)
        Me.dgwFolders.TabIndex = 0
        '
        'FullPath
        '
        Me.FullPath.HeaderText = ""
        Me.FullPath.Name = "FullPath"
        Me.FullPath.Visible = False
        '
        'FolderPic
        '
        Me.FolderPic.HeaderText = "O"
        Me.FolderPic.Name = "FolderPic"
        Me.FolderPic.Width = 20
        '
        'OldName
        '
        Me.OldName.HeaderText = "Old"
        Me.OldName.Name = "OldName"
        Me.OldName.ReadOnly = True
        '
        'NewName
        '
        Me.NewName.HeaderText = "New"
        Me.NewName.Name = "NewName"
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.MassFART.My.Resources.Resources.undo_ico1
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button5.Location = New System.Drawing.Point(164, 431)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(43, 42)
        Me.Button5.TabIndex = 11
        Me.Button5.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(519, 487)
        Me.Controls.Add(Me.dgwFolders)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgwFolders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents fbdFolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents dgwFolders As DataGridView
    Friend WithEvents FullPath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolderPic As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents OldName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NewName As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
