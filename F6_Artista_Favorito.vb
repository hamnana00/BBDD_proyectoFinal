Public Class F6_Artista_Favorito
    Private Sub btnCambiarUsuario_Click(sender As Object, e As EventArgs) Handles btnCambiarUsuario.Click
        Dim f1 As New F1_Iniciar_Sesion()
        f1.ShowDialog()
        ' Recargar la lista de artistas favoritos cuando el usuario cambie
        CargarArtistasFavoritos()
    End Sub

    Private Sub F6_Artista_Favorito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar la lista de artistas favoritos al cargar el formulario
        CargarArtistasFavoritos()
    End Sub

    Private Sub CargarArtistasFavoritos()
        ' Limpiar la lista antes de cargar los nuevos artistas favoritos
        lstArtistaFavorito.Items.Clear()

        ' Verificar si hay un usuario activo
        If Not String.IsNullOrEmpty(F1_Iniciar_Sesion.idUsuarioActivo) Then
            Dim artistaFavoritoDAO As New Artista_FavoritoDAO()
            Dim artistaFavorito As Artista_Favorito = New Artista_Favorito(F1_Iniciar_Sesion.idUsuarioActivo)

            Try
                ' Leer los artistas favoritos del usuario activo
                artistaFavoritoDAO.LeerArtista_Favorito(artistaFavorito)

                ' Agregar los artistas favoritos al ListBox
                For Each favorito As Artista_Favorito In artistaFavoritoDAO.Artistas_Favoritos
                    lstArtistaFavorito.Items.Add(favorito.Artista)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub
End Class