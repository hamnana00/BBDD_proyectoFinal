Public Class F12_Usuario_Mas_Activo
    Private Sub btnAbrirUsuario_Click(sender As Object, e As EventArgs) Handles btnAbrirUsuario.Click
        Dim f1 As New F1_Iniciar_Sesion()
        f1.ShowDialog()
    End Sub

    Private Sub F12_Usuario_Mas_Activo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarUsuarios()
    End Sub

    Private Sub CargarUsuarios()
        ' Limpiar el ListBox
        lstUsuarioActivo.Items.Clear()

        ' Obtener la lista de usuarios desde la base de datos
        Dim dao As New UsuarioDAO()
        dao.LeerTodasUsuarios()

        ' Crear una lista auxiliar para almacenar el tiempo de reproducción por usuario
        Dim usuariosConTiempo As New List(Of KeyValuePair(Of String, TimeSpan))

        ' Calcular el tiempo de reproducción por usuario y almacenarlo en la lista auxiliar
        For Each usuario As Usuario In dao.Usuarios
            Dim tiempoReproduccion As TimeSpan = ObtenerTiempoReproduccion(usuario.Email)
            usuariosConTiempo.Add(New KeyValuePair(Of String, TimeSpan)(usuario.Email, tiempoReproduccion))
        Next

        ' Ordenar la lista de usuarios según el tiempo de reproducción de mayor a menor
        usuariosConTiempo = usuariosConTiempo.OrderByDescending(Function(pair) pair.Value).ToList()

        ' Agregar los usuarios ordenados al ListBox
        For Each usuarioConTiempo As KeyValuePair(Of String, TimeSpan) In usuariosConTiempo
            lstUsuarioActivo.Items.Add(usuarioConTiempo.Key)
        Next
    End Sub

    Private Sub lstUsuarioActivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUsuarioActivo.SelectedIndexChanged
        If lstUsuarioActivo.SelectedItem IsNot Nothing Then
            Dim emailUsuario As String = lstUsuarioActivo.SelectedItem.ToString()
            Dim tiempoReproduccion As TimeSpan = ObtenerTiempoReproduccion(emailUsuario)
            txtTiempoReproduccion.Text = tiempoReproduccion.ToString("h\:mm\:ss")
        End If
    End Sub

    Private Function ObtenerTiempoReproduccion(ByVal emailUsuario As String) As TimeSpan
        Dim dao As New ReproduccionDAO()
        Return dao.ObtenerTiempoReproduccionPorUsuario(emailUsuario)
    End Function


End Class