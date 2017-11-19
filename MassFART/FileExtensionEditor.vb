Public Class FileExtensionEditor
    Private filetypeList As New List(Of String)
    Private folderList As New List(Of String)

    Public Sub ResetForm()
        folderList.Clear()
        filetypeList.Clear()
        cmbExistingFileTypes.Items.Clear()
        txtReplacement.Text = ""
    End Sub

    Public Sub AddFolder(path As String)
        folderList.Add(path)
    End Sub

    Public Sub Init()
        filetypeList = FileHelper.FindAllFileTypes(folderList)
        For Each fileExtension As String In filetypeList
            cmbExistingFileTypes.Items.Add(fileExtension)
        Next
    End Sub

    Private Sub RecursiveRename(path As String)
        Dim subFiles() As String = IO.Directory.GetFiles(path)
        For Each file In subFiles
            If IO.Path.GetExtension(file) = cmbExistingFileTypes.Text Then
                Dim newExtension As String = txtReplacement.Text
                IO.File.Move(file, IO.Path.ChangeExtension(file, newExtension))
            End If
        Next
        If cbSubfolders.Checked Then
            Dim subFolders() As String = IO.Directory.GetDirectories(path)
            For Each folder In subFolders
                RecursiveRename(folder)
            Next
        End If
    End Sub

    Private Sub btnRename_Click(sender As Object, e As EventArgs) Handles btnRename.Click
        For Each folder As String In folderList
            RecursiveRename(folder)
        Next
    End Sub

    Private Sub CcButton2_Click(sender As Object, e As EventArgs) Handles CcButton2.Click
        Me.Visible = False
    End Sub
End Class
