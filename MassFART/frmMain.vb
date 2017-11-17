Public Class frmMain
    Private folderEmptyImage As Image
    Private folderPopulatedImage As Image
    Private folderSubFoldersImage As Image
    Private folderMixImage As Image

    Private resourcePath As String

    Private Sub LoadPath(path As String)
        dgwFolders.Rows.Clear()
        Dim dirs() As String = IO.Directory.GetDirectories(path)
        For Each dir As String In dirs
            Dim subFiles() As String = IO.Directory.GetFiles(dir)
            Dim pos As Integer = dir.LastIndexOf("\") + 1
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
            LoadPath(fbdFolder.SelectedPath)
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

        folderEmptyImage = Image.FromFile(resourcePath + "emp_fol.bmp")
        folderMixImage = Image.FromFile(resourcePath + "mix_fol.bmp")
        folderPopulatedImage = Image.FromFile(resourcePath + "pop_fol.bmp")
        folderSubFoldersImage = Image.FromFile(resourcePath + "sub_fol.bmp")
    End Sub

    Private Sub btnRename_Click(sender As Object, e As EventArgs) Handles btnRename.Click
        If MessageBox.Show("ARE YOU SURE???", "Confirmation", Windows.Forms.MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            DoRename()
        End If
    End Sub

    Private Sub dgwFolders_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgwFolders.CellBeginEdit

    End Sub

    Private Sub dgwFolders_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgwFolders.CellEndEdit

    End Sub

    Private Sub RenameFiletypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameFiletypeToolStripMenuItem.Click

    End Sub

    Private Sub PaseCtrlVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaseCtrlVToolStripMenuItem.Click

    End Sub
End Class
