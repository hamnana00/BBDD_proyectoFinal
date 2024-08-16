Public Class Artista
    Public Property IDArtistas As Integer
    Public Property Nombre As String
    Public Property Pais As String
    Public Property Imagen As String

    Public ReadOnly Property ArtDAO As ArtistaDAO

    Public Sub New()
        Me.ArtDAO = New ArtistaDAO
    End Sub

    Public Sub New(id As String)
        Me.ArtDAO = New ArtistaDAO
        Me.IDArtistas = id
    End Sub

    Public Sub LeerTodasArtistas()
        Me.ArtDAO.LeerTodasArtistas()
    End Sub

    Public Sub LeerArtista()
        Me.ArtDAO.LeerArtista(Me)
    End Sub


    Public Function InsertarArtista() As Integer
        Return Me.ArtDAO.Insertar(Me)
    End Function

    Public Function ActualizarArtista() As Integer
        Return Me.ArtDAO.Actualizar(Me)
    End Function

    Public Function BorrarArtista() As Integer
        Return Me.ArtDAO.Borrar(Me)
    End Function
End Class
