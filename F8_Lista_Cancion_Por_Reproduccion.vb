Imports System.Text.RegularExpressions
Public Class F8_Lista_Cancion_Por_Reproduccion
    Private Sub CargarDatosReproduccion()
        ' Limpiamos el ListBox antes de cargar los nuevos datos
        lstCancionReproduccion.Items.Clear()

        ' Verificamos si se ha proporcionado el ID del usuario activo desde F1_Iniciar_Sesion
        If Not String.IsNullOrEmpty(F1_Iniciar_Sesion.idUsuarioActivo) Then
            ' Creamos una instancia de ReproduccionDAO para acceder a los datos de reproducción
            Dim repDAO As New ReproduccionDAO()
            ' Llamamos al método para leer todas las reproducciones
            repDAO.LeerTodasReproducciones()

            ' Creamos un diccionario para almacenar el número de reproducciones por canción
            Dim reproduccionesPorCancion As New Dictionary(Of Integer, Integer)

            ' Iteramos sobre la colección de reproducciones y contamos las reproducciones por canción para el usuario actual
            For Each reproduccion As Reproduccion In repDAO.Reproducciones
                ' Verificamos si la reproducción pertenece al usuario actual
                If reproduccion.Usuario = F1_Iniciar_Sesion.idUsuarioActivo Then
                    ' Verificamos si la canción ya está en el diccionario, si no, la agregamos con un contador inicial de 1
                    If reproduccionesPorCancion.ContainsKey(reproduccion.Cancion) Then
                        reproduccionesPorCancion(reproduccion.Cancion) += 1
                    Else
                        reproduccionesPorCancion(reproduccion.Cancion) = 1
                    End If
                End If
            Next

            ' Ordenamos el diccionario por el número de reproducciones (de mayor a menor)
            Dim cancionesOrdenadas = reproduccionesPorCancion.OrderByDescending(Function(x) x.Value)

            ' Iteramos sobre las canciones ordenadas y las agregamos al ListBox
            For Each cancion As KeyValuePair(Of Integer, Integer) In cancionesOrdenadas
                lstCancionReproduccion.Items.Add($"ID Canción: {cancion.Key} - Repeticiones: {cancion.Value}")
            Next
        End If
    End Sub

    Private Sub lstCancionReproduccion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCancionReproduccion.SelectedIndexChanged
        ' No se requiere ninguna acción al seleccionar una canción en el ListBox
    End Sub

    Private Sub F8_Lista_Cancion_Por_Reproduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llamamos al método para cargar automáticamente los datos de reproducción al abrir el formulario
        CargarDatosReproduccion()
    End Sub

    Private Sub btnAbrirUsuario_Click(sender As Object, e As EventArgs) Handles btnAbrirUsuario.Click
        Dim f1 As New F1_Iniciar_Sesion()
        f1.ShowDialog()
    End Sub
End Class
