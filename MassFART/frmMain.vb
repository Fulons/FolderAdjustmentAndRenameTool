Public Class frmMain
    Private folderEmptyImage As Image
    Private resourcePath As String
    Private Sub LoadPath(path As String)
        Dim dirs() As String = IO.Directory.GetDirectories(path)
        For Each dir As String In dirs
            Dim pos As Integer = dir.LastIndexOf("\") + 1
            dgwFolders.Rows.Add(dir, folderEmptyImage, dir.Substring(pos, dir.Length - pos), "")
        Next
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        fbdFolder.ShowDialog()
        LoadPath(fbdFolder.SelectedPath())
    End Sub

    Private Sub dgwFolders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwFolders.CellContentClick

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resourcePath = Application.StartupPath() + "\..\..\Resource\"
        folderEmptyImage = Image.FromFile(resourcePath + "folder_a.png")
    End Sub
End Class
