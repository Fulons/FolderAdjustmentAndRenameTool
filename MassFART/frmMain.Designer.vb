<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoCtrlZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoCtrlYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RenameFiletypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyCtrlVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaseCtrlVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.RenameParentFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameFiletypeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FiletypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CurrentFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectedFoldersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileDeletionUtilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.fbdFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.dgwFolders = New System.Windows.Forms.DataGridView()
        Me.FullPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FolderPic = New System.Windows.Forms.DataGridViewImageColumn()
        Me.OldName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlUCHeader = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDisplayNoFiles = New System.Windows.Forms.TextBox()
        Me.flpUserControls = New System.Windows.Forms.FlowLayoutPanel()
        Me.ccFileExtensionEditor = New MassFART.FileExtensionEditor()
        Me.ccFileDeletion = New MassFART.DeleteFiletype()
        Me.ccRenameParentFolder = New MassFART.RenameParentFolder()
        Me.Button2 = New MassFART.ccButton()
        Me.btnRename = New MassFART.ccButton()
        Me.btnDelete = New MassFART.ccButton()
        Me.btnAddFol = New MassFART.ccButton()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgwFolders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUCHeader.SuspendLayout()
        Me.flpUserControls.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(795, 23)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ToolStripSeparator6, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 19)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.OpenToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.OpenToolStripMenuItem.Text = "Open..."
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(152, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoCtrlZToolStripMenuItem, Me.RedoCtrlYToolStripMenuItem, Me.ToolStripSeparator1, Me.RenameFiletypeToolStripMenuItem, Me.CopyCtrlVToolStripMenuItem, Me.PaseCtrlVToolStripMenuItem, Me.DelToolStripMenuItem, Me.ToolStripSeparator2, Me.FindToolStripMenuItem, Me.ToolStripSeparator3, Me.SelectAllToolStripMenuItem, Me.ToolStripSeparator4, Me.RenameParentFolderToolStripMenuItem, Me.RenameFiletypeToolStripMenuItem1, Me.FileDeletionUtilityToolStripMenuItem})
        Me.EditToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F6), System.Windows.Forms.Keys)
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 19)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UndoCtrlZToolStripMenuItem
        '
        Me.UndoCtrlZToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UndoCtrlZToolStripMenuItem.Name = "UndoCtrlZToolStripMenuItem"
        Me.UndoCtrlZToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoCtrlZToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.UndoCtrlZToolStripMenuItem.Text = "Undo                  "
        '
        'RedoCtrlYToolStripMenuItem
        '
        Me.RedoCtrlYToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RedoCtrlYToolStripMenuItem.Name = "RedoCtrlYToolStripMenuItem"
        Me.RedoCtrlYToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoCtrlYToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.RedoCtrlYToolStripMenuItem.Text = "Redo                   "
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(234, 6)
        '
        'RenameFiletypeToolStripMenuItem
        '
        Me.RenameFiletypeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RenameFiletypeToolStripMenuItem.Name = "RenameFiletypeToolStripMenuItem"
        Me.RenameFiletypeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.RenameFiletypeToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.RenameFiletypeToolStripMenuItem.Text = "Cut           "
        '
        'CopyCtrlVToolStripMenuItem
        '
        Me.CopyCtrlVToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CopyCtrlVToolStripMenuItem.Name = "CopyCtrlVToolStripMenuItem"
        Me.CopyCtrlVToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyCtrlVToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.CopyCtrlVToolStripMenuItem.Text = "Copy "
        '
        'PaseCtrlVToolStripMenuItem
        '
        Me.PaseCtrlVToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PaseCtrlVToolStripMenuItem.Name = "PaseCtrlVToolStripMenuItem"
        Me.PaseCtrlVToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.PaseCtrlVToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.PaseCtrlVToolStripMenuItem.Text = "Paste"
        '
        'DelToolStripMenuItem
        '
        Me.DelToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DelToolStripMenuItem.Name = "DelToolStripMenuItem"
        Me.DelToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DelToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.DelToolStripMenuItem.Text = "Delete"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(234, 6)
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.FindToolStripMenuItem.Text = "Find..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(234, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(234, 6)
        '
        'RenameParentFolderToolStripMenuItem
        '
        Me.RenameParentFolderToolStripMenuItem.Name = "RenameParentFolderToolStripMenuItem"
        Me.RenameParentFolderToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.RenameParentFolderToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.RenameParentFolderToolStripMenuItem.Text = "Rename Parent Folder"
        '
        'RenameFiletypeToolStripMenuItem1
        '
        Me.RenameFiletypeToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FiletypeToolStripMenuItem})
        Me.RenameFiletypeToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RenameFiletypeToolStripMenuItem1.Name = "RenameFiletypeToolStripMenuItem1"
        Me.RenameFiletypeToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F5), System.Windows.Forms.Keys)
        Me.RenameFiletypeToolStripMenuItem1.Size = New System.Drawing.Size(237, 22)
        Me.RenameFiletypeToolStripMenuItem1.Text = "File Extension Rename"
        '
        'FiletypeToolStripMenuItem
        '
        Me.FiletypeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CurrentFolderToolStripMenuItem, Me.SelectedFoldersToolStripMenuItem})
        Me.FiletypeToolStripMenuItem.Name = "FiletypeToolStripMenuItem"
        Me.FiletypeToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.FiletypeToolStripMenuItem.Text = "Filetype"
        '
        'CurrentFolderToolStripMenuItem
        '
        Me.CurrentFolderToolStripMenuItem.Name = "CurrentFolderToolStripMenuItem"
        Me.CurrentFolderToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.CurrentFolderToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CurrentFolderToolStripMenuItem.Text = "Current Folder"
        '
        'SelectedFoldersToolStripMenuItem
        '
        Me.SelectedFoldersToolStripMenuItem.Name = "SelectedFoldersToolStripMenuItem"
        Me.SelectedFoldersToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.SelectedFoldersToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.SelectedFoldersToolStripMenuItem.Text = "Selected Folders"
        '
        'FileDeletionUtilityToolStripMenuItem
        '
        Me.FileDeletionUtilityToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FileDeletionUtilityToolStripMenuItem.Name = "FileDeletionUtilityToolStripMenuItem"
        Me.FileDeletionUtilityToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F6), System.Windows.Forms.Keys)
        Me.FileDeletionUtilityToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.FileDeletionUtilityToolStripMenuItem.Text = "File Deletion Utility"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHelpToolStripMenuItem, Me.ToolStripSeparator5, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 19)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ViewHelpToolStripMenuItem
        '
        Me.ViewHelpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem"
        Me.ViewHelpToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ViewHelpToolStripMenuItem.Text = "View Help"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(124, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'dgwFolders
        '
        Me.dgwFolders.AllowUserToAddRows = False
        Me.dgwFolders.AllowUserToDeleteRows = False
        Me.dgwFolders.AllowUserToResizeRows = False
        Me.dgwFolders.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgwFolders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwFolders.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.dgwFolders.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgwFolders.ColumnHeadersHeight = 26
        Me.dgwFolders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FullPath, Me.FolderPic, Me.OldName, Me.NewName})
        Me.dgwFolders.Location = New System.Drawing.Point(141, 41)
        Me.dgwFolders.Name = "dgwFolders"
        Me.dgwFolders.Size = New System.Drawing.Size(306, 600)
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
        Me.FolderPic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.FolderPic.FillWeight = 0.001!
        Me.FolderPic.HeaderText = "O"
        Me.FolderPic.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.FolderPic.Name = "FolderPic"
        Me.FolderPic.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FolderPic.Width = 20
        '
        'OldName
        '
        Me.OldName.FillWeight = 134.7716!
        Me.OldName.HeaderText = "Old"
        Me.OldName.Name = "OldName"
        Me.OldName.ReadOnly = True
        '
        'NewName
        '
        Me.NewName.FillWeight = 134.7716!
        Me.NewName.HeaderText = "New"
        Me.NewName.Name = "NewName"
        '
        'pnlUCHeader
        '
        Me.pnlUCHeader.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlUCHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlUCHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlUCHeader.Controls.Add(Me.Label1)
        Me.pnlUCHeader.Location = New System.Drawing.Point(459, 41)
        Me.pnlUCHeader.Name = "pnlUCHeader"
        Me.pnlUCHeader.Size = New System.Drawing.Size(307, 30)
        Me.pnlUCHeader.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(10, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Controls"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(15, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Total No. of Files"
        '
        'txtDisplayNoFiles
        '
        Me.txtDisplayNoFiles.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtDisplayNoFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDisplayNoFiles.ForeColor = System.Drawing.Color.White
        Me.txtDisplayNoFiles.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtDisplayNoFiles.Location = New System.Drawing.Point(18, 87)
        Me.txtDisplayNoFiles.Name = "txtDisplayNoFiles"
        Me.txtDisplayNoFiles.Size = New System.Drawing.Size(105, 23)
        Me.txtDisplayNoFiles.TabIndex = 19
        '
        'flpUserControls
        '
        Me.flpUserControls.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpUserControls.AutoScroll = True
        Me.flpUserControls.Controls.Add(Me.ccFileExtensionEditor)
        Me.flpUserControls.Controls.Add(Me.ccFileDeletion)
        Me.flpUserControls.Controls.Add(Me.ccRenameParentFolder)
        Me.flpUserControls.Location = New System.Drawing.Point(453, 73)
        Me.flpUserControls.Name = "flpUserControls"
        Me.flpUserControls.Size = New System.Drawing.Size(338, 571)
        Me.flpUserControls.TabIndex = 22
        '
        'ccFileExtensionEditor
        '
        Me.ccFileExtensionEditor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ccFileExtensionEditor.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ccFileExtensionEditor.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ccFileExtensionEditor.Location = New System.Drawing.Point(3, 3)
        Me.ccFileExtensionEditor.Name = "ccFileExtensionEditor"
        Me.ccFileExtensionEditor.Size = New System.Drawing.Size(313, 204)
        Me.ccFileExtensionEditor.TabIndex = 12
        Me.ccFileExtensionEditor.Visible = False
        '
        'ccFileDeletion
        '
        Me.ccFileDeletion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ccFileDeletion.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ccFileDeletion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ccFileDeletion.Location = New System.Drawing.Point(3, 213)
        Me.ccFileDeletion.Name = "ccFileDeletion"
        Me.ccFileDeletion.Size = New System.Drawing.Size(313, 204)
        Me.ccFileDeletion.TabIndex = 13
        Me.ccFileDeletion.Visible = False
        '
        'ccRenameParentFolder
        '
        Me.ccRenameParentFolder.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ccRenameParentFolder.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ccRenameParentFolder.Location = New System.Drawing.Point(3, 423)
        Me.ccRenameParentFolder.Name = "ccRenameParentFolder"
        Me.ccRenameParentFolder.Size = New System.Drawing.Size(313, 147)
        Me.ccRenameParentFolder.TabIndex = 20
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Button2.borderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button2.disabledBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Button2.disabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button2.disabledForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Enabled = False
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.DarkGray
        Me.Button2.Location = New System.Drawing.Point(18, 614)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 27)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Generate ID List"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnRename
        '
        Me.btnRename.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnRename.borderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnRename.disabledBackColor = System.Drawing.Color.Empty
        Me.btnRename.disabledBorderColor = System.Drawing.Color.Empty
        Me.btnRename.disabledForeColor = System.Drawing.Color.Empty
        Me.btnRename.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRename.ForeColor = System.Drawing.Color.DarkGray
        Me.btnRename.Location = New System.Drawing.Point(18, 244)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(105, 27)
        Me.btnRename.TabIndex = 10
        Me.btnRename.Text = "Rename Folder(s)"
        Me.btnRename.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnDelete.borderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnDelete.disabledBackColor = System.Drawing.Color.Empty
        Me.btnDelete.disabledBorderColor = System.Drawing.Color.Empty
        Me.btnDelete.disabledForeColor = System.Drawing.Color.Empty
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.DarkGray
        Me.btnDelete.Location = New System.Drawing.Point(18, 201)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(105, 27)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete Folder(s)"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnAddFol
        '
        Me.btnAddFol.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnAddFol.borderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnAddFol.disabledBackColor = System.Drawing.Color.Empty
        Me.btnAddFol.disabledBorderColor = System.Drawing.Color.Empty
        Me.btnAddFol.disabledForeColor = System.Drawing.Color.Empty
        Me.btnAddFol.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnAddFol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddFol.ForeColor = System.Drawing.Color.DarkGray
        Me.btnAddFol.Location = New System.Drawing.Point(18, 158)
        Me.btnAddFol.Name = "btnAddFol"
        Me.btnAddFol.Size = New System.Drawing.Size(105, 27)
        Me.btnAddFol.TabIndex = 6
        Me.btnAddFol.Text = "Add Folder"
        Me.btnAddFol.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(795, 656)
        Me.Controls.Add(Me.flpUserControls)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDisplayNoFiles)
        Me.Controls.Add(Me.pnlUCHeader)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dgwFolders)
        Me.Controls.Add(Me.btnRename)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAddFol)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgwFolders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUCHeader.ResumeLayout(False)
        Me.pnlUCHeader.PerformLayout()
        Me.flpUserControls.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fbdFolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents dgwFolders As DataGridView
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoCtrlZToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoCtrlYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents RenameFiletypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyCtrlVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaseCtrlVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents FindToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents RenameFiletypeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FiletypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CurrentFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectedFoldersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewHelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ccFileExtensionEditor As MassFART.FileExtensionEditor
    Friend WithEvents ccFileDeletion As DeleteFiletype
    Friend WithEvents pnlUCHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnAddFol As ccButton
    Friend WithEvents btnDelete As ccButton
    Friend WithEvents btnRename As ccButton
    Friend WithEvents Button2 As ccButton
    Friend WithEvents FileDeletionUtilityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RenameParentFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDisplayNoFiles As TextBox
    Friend WithEvents ccRenameParentFolder As RenameParentFolder
    Friend WithEvents flpUserControls As FlowLayoutPanel
    Friend WithEvents FullPath As DataGridViewTextBoxColumn
    Friend WithEvents FolderPic As DataGridViewImageColumn
    Friend WithEvents OldName As DataGridViewTextBoxColumn
    Friend WithEvents NewName As DataGridViewTextBoxColumn
End Class
