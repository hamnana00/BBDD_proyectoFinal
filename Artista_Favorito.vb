Imports System.Data.SqlClient

Public Class Artista_Favorito
    Public Property Usuario As String
    Public Property Artista As Integer
    Public Property Fecha As Date
    Private Const cadenaConexion As String = "server=localhost;database=cancionify;uid=root;pwd=root"

    Public ReadOnly Property ArFDAO As Artista_FavoritoDAO

    Public Sub New()
        Me.ArFDAO = New Artista_FavoritoDAO
    End Sub

    Public Sub New(id As String)
        Me.ArFDAO = New Artista_FavoritoDAO
        Me.Usuario = id
    End Sub

    Public Sub LeerTodosArtistas_Favoritos()
        Me.ArFDAO.LeerTodosArtistas_Favoritos()
    End Sub

    Public Sub LeerArtista_Favorito()
        Me.ArFDAO.LeerArtista_Favorito(Me)
    End Sub

    Public Function MarcarArtistaComoFavorito() As Integer
        Return Me.ArFDAO.Insertar(Me)
    End Function

    Public Function DesmarcarArtistaComoFavorito() As Integer
        Return Me.ArFDAO.Borrar(Me)
    End Function
    Public Function ActualizarArtista_Favorito() As Integer
        Return Me.ArFDAO.Actualizar(Me)
    End Function
    Public Function EsArtistaFavorito() As Boolean
        ' Consulta si el artista actual es favorito para el usuario activo
        Dim query As String = "SELECT COUNT(*) FROM ArtistaFavorito WHERE usuario = @usuario AND artista = @artista"
        Using conn As New SqlConnection("cadenaConexion"),
              cmd As New SqlCommand(query, conn)

            conn.Open()
            cmd.Parameters.AddWithValue("@usuario", Me.Usuario)
            cmd.Parameters.AddWithValue("@artista", Me.Artista)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0
        End Using
    End Function
End Class
