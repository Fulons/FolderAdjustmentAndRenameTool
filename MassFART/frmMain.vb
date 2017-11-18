Public Class frmMain
    Private folderEmptyImage As Image
    Private folderPopulatedImage As Image
    Private folderSubFoldersImage As Image
    Private folderMixImage As Image
    Private folderUnaccesible As Image

    Private resourcePath As String

    Private Const formWitdh As Integer = 565
    Private Const extendedFormWidt As Integer = 884

    Private extensionEditorShown As Boolean = False
    Private deleteFileEditorShow As Boolean = False

    Private Sub DisplayedControlsChanged()
        If ccFileExtensionEditor.Visible Or ccFileDeletion.Visible Then
            Me.Size = New Size(884, 640)
            pnlUCHeader.Show()
        Else
            Me.Size = New Size(565, 640)
            pnlUCHeader.Hide()
        End If
    End Sub

    Private Sub LoadPath(path As String, Optional errorLoad As Boolean = False)
        If errorLoad Then

        Else
        End If
        dgwFolders.Rows.Clear()
        Dim fileCount As Integer = 0
        Dim folderCount As Integer = 0
        Dim dirs() As String = IO.Directory.GetDirectories(path)
        folderCount += dirs.Count()
        For Each dir As String In dirs
            Dim pos As Integer = dir.LastIndexOf("\") + 1
            Dim subFiles() As String
            Try
                subFiles = IO.Directory.GetFiles(dir)
            Catch ex As Exception
                dgwFolders.Rows.Add(dir, folderUnaccesible, dir.Substring(pos, dir.Length - pos), "")
                Continue For
            End Try
            If subFiles.Count = 0 Then
                Dim subFolders() As String = IO.Directory.GetDirectories(dir)
                If subFolders.Count = 0 Then
                    dgwFolders.Rows.Add(dir, folderEmptyImage, dir.Substring(pos, dir.Length - pos), "")
                Else
                    dgwFolders.Rows.Add(dir, folderSubFoldersImage, dir.Substring(pos, dir.Length - pos), "")
                End If
            Else
                Dim subFolders() As String = IO.Directory.GetDirectories(dir)
                If subFolders.Count = 0 Then
                    dgwFolders.Rows.Add(dir, folderPopulatedImage, dir.Substring(pos, dir.Length - pos), "")
                Else
                    dgwFolders.Rows.Add(dir, folderMixImage, dir.Substring(pos, dir.Length - pos), "")
                End If
            End If
        Next
    End Sub

    Private Sub DoRename()
        Dim errorHappened As Boolean = False
        For i As Integer = 0 To dgwFolders.RowCount - 1
            'Dim oldName As String = dgwFolders.Rows(i).Cells(2).Value.ToString
            Dim newName As String = dgwFolders.Rows(i).Cells(3).Value.ToString
            Dim path As String = dgwFolders.Rows(i).Cells("FullPath").Value.ToString
            If Not String.IsNullOrEmpty(newName) Then
                Try
                    My.Computer.FileSystem.RenameDirectory(path, newName)
                Catch ex As IO.IOException
                    If IO.Directory.Exists(path) Then   'Path exist
                        MessageBox.Show(ex.Message, "Error")
                        errorHappened = True
                    Else                                'Path does not exist
                        If IO.Directory.Exists(path.Substring(0, path.LastIndexOf("\") + 1)) Then 'Parent folder exist
                            MessageBox.Show(ex.Message, "Error")
                            errorHappened = True
                        Else                                                        'Parent folder does not exist
                            MessageBox.Show("Parent folder deleted.")
                            dgwFolders.Rows.Clear()
                            Exit For
                        End If
                    End If
                End Try
                If Not errorHappened Then
                    dgwFolders.Rows(i).Cells(2).Value = newName
                    dgwFolders.Rows(i).Cells(3).Value = ""
                    dgwFolders.Rows(i).Cells("FullPath").Value = path.Substring(0, path.LastIndexOf("\") + 1) + newName
                End If
            End If
        Next
        If errorHappened Then
            LoadPath(fbdFolder.SelectedPath, True)
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        fbdFolder.ShowDialog()
        If Not String.IsNullOrEmpty(fbdFolder.SelectedPath()) Then
            LoadPath(fbdFolder.SelectedPath())
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resourcePath = Application.StartupPath() + "\..\..\Resource\"

        fbdFolder.SelectedPath = resourcePath

        folderEmptyImage = Image.FromFile(resourcePath + "emp_fol.png")
        folderMixImage = Image.FromFile(resourcePath + "mix_fol.png")
        folderPopulatedImage = Image.FromFile(resourcePath + "pop_fol.png")
        folderSubFoldersImage = Image.FromFile(resourcePath + "sub_fol.png")
        Try
            folderUnaccesible = Image.FromFile(resourcePath + "lock_fol.png")
        Catch ex As Exception
            folderUnaccesible = Nothing
        End Try
    End Sub

    Private Sub btnRename_Click(sender As Object, e As EventArgs) Handles btnRename.Click
        If MessageBox.Show("ARE YOU SURE???", "Confirmation", Windows.Forms.MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            DoRename()
        End If
    End Sub

    Private Sub SelectedFoldersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectedFoldersToolStripMenuItem.Click, CurrentFolderToolStripMenuItem.Click
        'For Each folder In dgwFolders.SelectedRows
        '    frmFiletypeChanger.AddFolder(folder.Cells("Fullpath").Value.ToString)
        'Next
        'frmFiletypeChanger.Init()
        'frmFiletypeChanger.Show()
        ccFileExtensionEditor.ResetForm()
        For Each folder In dgwFolders.SelectedRows
            ccFileExtensionEditor.AddFolder(folder.Cells("Fullpath").Value.ToString)
        Next
        ccFileExtensionEditor.Init()
        ccFileExtensionEditor.Visible = True
        DisplayedControlsChanged()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgwFolders.SelectedRows.Count = 0 Then Return
        If MessageBox.Show("Are you sure you want to delete the " +
                        dgwFolders.SelectedRows.Count.ToString() +
                        " selected folders?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            For Each folder In dgwFolders.SelectedRows
                IO.Directory.Delete(folder.Cells("Fullpath").Value.ToString, True)
                dgwFolders.Rows.Remove(folder)
            Next
        End If
    End Sub

    Private Sub dgwFolders_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgwFolders.RowStateChanged
        If ccFileExtensionEditor.Visible Then
            ccFileExtensionEditor.ResetForm()
            For Each folder In dgwFolders.SelectedRows
                ccFileExtensionEditor.AddFolder(folder.Cells("Fullpath").Value.ToString)
            Next
            ccFileExtensionEditor.Init()
        End If
    End Sub

    Private Sub RenameFiletypeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RenameFiletypeToolStripMenuItem1.Click
        OpenFileExtension()
    End Sub

    Private Sub FileDeletionUtilityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileDeletionUtilityToolStripMenuItem.Click
        OpenFileDeletion()
    End Sub

    Private Sub btnCloseFileExtensionEditor_Click(sender As Object, e As EventArgs) Handles btnCloseFileExtensionEditor.Click
        ccFileDeletion.Location = New Point(ccFileDeletion.Location.X, 81)
        ccFileExtensionEditor.Visible = False
        DisplayedControlsChanged()
    End Sub

    Private Sub btnCloseFileDeletion_Click(sender As Object, e As EventArgs)
        ccFileExtensionEditor.Location = New Point(ccFileExtensionEditor.Location.X, 81)
        ccFileDeletion.Visible = False
        DisplayedControlsChanged()
    End Sub

    Private Sub OpenFileDeletion()
        If ccFileExtensionEditor.Visible Then
            ccFileDeletion.Location = New Point(ccFileDeletion.Location.X,
                                                ccFileExtensionEditor.Location.Y +
                                                ccFileExtensionEditor.Size.Height + 6)
            ccFileExtensionEditor.Location = New Point(ccFileExtensionEditor.Location.X, 81)
        Else
            ccFileDeletion.Location = New Point(ccFileDeletion.Location.X, 81)
        End If

        ccFileDeletion.ResetForm()
        For Each folder In dgwFolders.SelectedRows
            ccFileDeletion.AddFolder(folder.Cells("Fullpath").Value.ToString)
        Next
        ccFileDeletion.Init()
        ccFileDeletion.Visible = True
        DisplayedControlsChanged()
    End Sub

    Private Sub OpenFileExtension()
        If ccFileDeletion.Visible Then
            ccFileExtensionEditor.Location = New Point(ccFileExtensionEditor.Location.X,
                                                       ccFileDeletion.Location.Y +
                                                       ccFileDeletion.Size.Height + 6)
            ccFileDeletion.Location = New Point(ccFileDeletion.Location.X, 81)
        Else
            ccFileExtensionEditor.Location = New Point(ccFileExtensionEditor.Location.X, 81)
        End If
        ccFileExtensionEditor.ResetForm()
        For Each folder In dgwFolders.SelectedRows
            ccFileExtensionEditor.AddFolder(folder.Cells("Fullpath").Value.ToString)
        Next
        ccFileExtensionEditor.Init()
        ccFileExtensionEditor.Visible = True
        DisplayedControlsChanged()
    End Sub

    Private Sub CcButton1_Click(sender As Object, e As EventArgs) Handles CcButton1.Click
        ccFileExtensionEditor.Location = New Point(ccFileExtensionEditor.Location.X, 81)
        ccFileDeletion.Visible = False
        DisplayedControlsChanged()
    End Sub
End Class
'81-292