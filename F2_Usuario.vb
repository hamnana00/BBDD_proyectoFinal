Public Class F2_Usuario
    Private Sub btnUsuario_Click(sender As Object, e As EventArgs) Handles btnUsuario.Click
        Dim f1 As New F1_Iniciar_Sesion()
        f1.ShowDialog()
    End Sub

    Private Sub btnAccederArtista_Click(sender As Object, e As EventArgs) Handles btnAccederArtista.Click
        Dim idUsuarioActivo As String = F1_Iniciar_Sesion.idUsuarioActivo
        Dim f3 As New F3_Artista(idUsuarioActivo)
        f3.ShowDialog()
    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        Dim f7 As New F7_Historial_Reproduccion()
        f7.ShowDialog()
    End Sub

    Private Sub btnArtistasFavoritos_Click(sender As Object, e As EventArgs) Handles btnArtistasFavoritos.Click
        Dim f6 As New F6_Artista_Favorito()
        f6.ShowDialog()
    End Sub

    Private Sub btnArtistaReproducion_Click(sender As Object, e As EventArgs) Handles btnArtistaReproducion.Click
        Dim f9 As New F9_Lista_Artista_Por_Reproduccion()
        f9.ShowDialog()
    End Sub

    Private Sub btnCancionReproduccion_Click(sender As Object, e As EventArgs) Handles btnCancionReproduccion.Click
        Dim f8 As New F8_Lista_Cancion_Por_Reproduccion()
        f8.ShowDialog()
    End Sub

    Private Sub btnArtistaMasEscuchadoEnFecha_Click(sender As Object, e As EventArgs) Handles btnArtistaMasEscuchadoEnFecha.Click
        Dim f11 As New F11_Lista_Artista_Mas_Escuchado_Por_Fecha()
        f11.ShowDialog()
    End Sub

    Private Sub F2_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class