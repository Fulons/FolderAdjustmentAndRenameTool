Public Class frmMain

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LoadPath(path As String)
        Dim dirs() As String = IO.Directory.GetDirectories(path)
        For Each dir As String In dirs
            Dim pos As Integer = dir.LastIndexOf("\") + 1
            dgwFolders.Rows.Add(dir, Nothing, dir.Substring(pos, dir.Length - pos), "")
        Next
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        fbdFolder.ShowDialog()
        LoadPath(fbdFolder.SelectedPath())
    End Sub

    Private Sub dgwFolders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwFolders.CellContentClick

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
End Class
