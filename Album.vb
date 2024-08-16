Public Class Album
    Public Property IDAlbum As Integer
    Public Property Nombre As String
    Public Property Fecha As Date
    Public Property Artista As Integer
    Public Property Portada As String

    Public ReadOnly Property AlbDAO As AlbumDAO

    Public Sub New()
        Me.AlbDAO = New AlbumDAO
    End Sub

    Public Sub New(id As String)
        Me.AlbDAO = New AlbumDAO
        Me.IDAlbum = id
    End Sub

    Public Sub LeerTodosAlbumes(ByVal IDArtista As String)
        Me.AlbDAO.LeerTodosAlbumes(IDArtista)
    End Sub

    Public Sub LeerAlbum()
        Me.AlbDAO.LeerAlbum(Me)
    End Sub

    Public Function InsertarAlbum() As Integer
        Return Me.AlbDAO.Insertar(Me)
    End Function

    Public Function ActualizarAlbum() As Integer
        Return Me.AlbDAO.Actualizar(Me)
    End Function

    Public Function BorrarAlbum() As Integer
        Return Me.AlbDAO.Borrar(Me)
    End Function

End Class
