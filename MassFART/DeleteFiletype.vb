Public Class DeleteFiletype
    Private filetypeList As New List(Of String)
    Private folderList As New List(Of String)

    Public Sub AddFolder(path As String)
        folderList.Add(path)
    End Sub

    Public Sub ResetForm()

    End Sub

    Public Sub Init()

    End Sub

    Private Sub CcButton2_Click(sender As Object, e As EventArgs) Handles CcButton2.Click
        Me.Visible = False
    End Sub
End Class
