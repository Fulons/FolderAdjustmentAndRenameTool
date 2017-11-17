Public Class FileHelper

    Private Shared Sub RecursiveFiletypeScanner(path As String, ByRef filetypeList As List(Of String))
        Dim subFiles() As String = IO.Directory.GetFiles(path)  'Get all sub files
        For Each file In subFiles
            Dim extension As String = IO.Path.GetExtension(file)
            If String.IsNullOrEmpty(filetypeList.Find(Function(ft) extension = ft)) Then    'Check if extension already exist
                filetypeList.Add(extension)
            End If
        Next
        Dim subFolders() As String = IO.Directory.GetDirectories(path)
        For Each folder In subFolders
            RecursiveFiletypeScanner(folder, filetypeList)
        Next
    End Sub

    Public Shared Function FindAllFileTypes(path As List(Of String)) As List(Of String)
        Dim ret As New List(Of String)
        For Each folder As String In path
            RecursiveFiletypeScanner(folder, ret)
        Next
        Return ret
    End Function

End Class
