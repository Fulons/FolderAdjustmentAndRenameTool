Public Class frmFiletypeChanger

    Private folderList As New List(Of String)
    Private filetypeList As New List(Of String)

    Public Sub AddFolder(path As String)
        folderList.Add(path)
    End Sub

    Private Sub RecursiveFiletypeScanner(path As String)
        Dim subFiles() As String = IO.Directory.GetFiles(path)  'Get all sub files
        For Each file In subFiles
            Dim extension As String = IO.Path.GetExtension(file)
            If String.IsNullOrEmpty(filetypeList.Find(Function(ft) extension = ft)) Then    'Check if extension already exist
                filetypeList.Add(extension)
            End If
        Next
        Dim subFolders() As String = IO.Directory.GetDirectories(path)
        For Each folder In subFolders
            RecursiveFiletypeScanner(folder)
        Next
    End Sub

    Public Sub Init()
        For Each folder In folderList
            RecursiveFiletypeScanner(folder)
        Next
        For Each fileExtension As String In filetypeList
            cmbExistingFileTypes.Items.Add(fileExtension)
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim lvItem As ListViewItem
        Dim replacement As String = txtReplacement.Text
        If replacement(0) <> "." Then
            replacement = "." + replacement
        End If
        lvItem = lvItems.Items.Add(cmbExistingFileTypes.Text)
        lvItem.SubItems.Add(replacement)
    End Sub

    Private Sub RecursiveRename(path As String)
        Dim subFiles() As String = IO.Directory.GetFiles(path)
        For Each file In subFiles
            For Each item As ListViewItem In lvItems.Items
                If IO.Path.GetExtension(file) = item.Text Then
                    Dim newExtension As String = item.SubItems(1).Text
                    IO.File.Move(file, IO.Path.ChangeExtension(file, newExtension))
                End If
            Next
        Next
        Dim subFolders() As String = IO.Directory.GetDirectories(path)
        For Each folder In subFolders
            RecursiveRename(folder)
        Next
    End Sub

    Private Sub btnRename_Click(sender As Object, e As EventArgs) Handles btnRename.Click
        For Each folder As String In folderList
            RecursiveRename(folder)
        Next
    End Sub
End Class