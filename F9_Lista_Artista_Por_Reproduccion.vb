Public Class F9_Lista_Artista_Por_Reproduccion
    Private Sub btnCambiarUsuario_Click(sender As Object, e As EventArgs) Handles btnCambiarUsuario.Click
        Dim f1 As New F1_Iniciar_Sesion()
        f1.ShowDialog()
    End Sub

    Private Sub btnGeneral_Click(sender As Object, e As EventArgs) Handles btnGeneral.Click
        ' Obtener el listado de artistas ordenados por número de reproducciones del usuario actual
        Dim usuarioEmail As String = F1_Iniciar_Sesion.idUsuarioActivo
        Dim usuarioDAO As New UsuarioDAO()
        Dim artistasReproducciones As Dictionary(Of String, Integer) = usuarioDAO.ObtenerArtistasPorReproducciones(usuarioEmail)

        ' Mostrar los artistas en el ListBox
        MostrarArtistas(artistasReproducciones)
    End Sub

    Private Sub btnPais_Click(sender As Object, e As EventArgs) Handles btnPais.Click
        ' Obtener el listado de artistas ordenados por número de reproducciones del usuario actual y filtrados por país
        Dim usuarioEmail As String = F1_Iniciar_Sesion.idUsuarioActivo
        Dim pais As String = txtPais.Text.Trim()
        Dim usuarioDAO As New UsuarioDAO()
        Dim artistasReproducciones As Dictionary(Of String, Integer) = usuarioDAO.ObtenerArtistasPorReproducciones(usuarioEmail, pais)

        ' Mostrar los artistas en el ListBox
        MostrarArtistas(artistasReproducciones)
    End Sub

    Private Sub MostrarArtistas(artistasReproducciones As Dictionary(Of String, Integer))
        lstArtistaReproduccion.Items.Clear()
        For Each kvp As KeyValuePair(Of String, Integer) In artistasReproducciones
            lstArtistaReproduccion.Items.Add(kvp.Key & " - Reproducciones: " & kvp.Value)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGeneral.Click

    End Sub

    Private Sub F9_Lista_Artista_Por_Reproduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class