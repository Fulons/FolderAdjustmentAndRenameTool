Public Class RenameParentFolder

    Private deletedDefaultString As Boolean = False

    Private Sub CcButton2_Click(sender As Object, e As EventArgs) Handles CcButton2.Click
        Me.Visible = False
    End Sub

    Private Sub btnRename_Click(sender As Object, e As EventArgs) Handles btnRename.Click
        Try
            My.Computer.FileSystem.RenameDirectory(frmMain.fbdFolder.SelectedPath, txtReplacement.Text)
        Catch ex As Exception
            MessageBox.Show("Could not rename folder: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
        MessageBox.Show("Rename success!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub RenameParentFolder_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            Dim count As Integer = frmMain.fbdFolder.SelectedPath.Count() - 2
            If count < 0 Then count = 0
            Dim str As String = frmMain.fbdFolder.SelectedPath.Substring(frmMain.fbdFolder.SelectedPath.LastIndexOf("\", count) + 1)
            If str(str.Length - 1) = "\" Then
                str = str.Substring(0, str.Count() - 1)
            End If
            txtReplacement.Text = str
        End If
        txtReplacement.Select()
    End Sub
End Class
