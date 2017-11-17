Public Class frmDiscardFiletype

    Private selectedFolders As List(Of String)
    Private currentWorkingDir As String

    Public Sub AddFolder(folder As String)
        selectedFolders.Add(folder)
    End Sub

    Public Sub Init(workingDir As String)
        currentWorkingDir = workingDir

    End Sub

    Private Sub cbSelectedFolders_CheckedChanged(sender As Object, e As EventArgs) Handles cbSelectedFolders.CheckedChanged
        If cbSelectedFolders.Checked Then
            cbAllFolders.Checked = False
        Else
            cbAllFolders.Checked = True
        End If
    End Sub

    Private Sub cbAllFolders_CheckedChanged(sender As Object, e As EventArgs) Handles cbAllFolders.CheckedChanged
        If cbAllFolders.Checked Then
            cbSelectedFolders.Checked = False
        Else
            cbSelectedFolders.Checked = True
        End If
    End Sub
End Class