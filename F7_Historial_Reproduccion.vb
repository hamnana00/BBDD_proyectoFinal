Public Class F7_Historial_Reproduccion
    Private Sub F7_Historial_Reproduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llamamos al método para cargar automáticamente los datos de reproducción al abrir el formulario
        CargarDatosReproduccion()
    End Sub
    Private Sub btnCambiarUsuario_Click(sender As Object, e As EventArgs) Handles btnCambiarUsuario.Click
        Dim f1 As New F1_Iniciar_Sesion()
        f1.ShowDialog()
    End Sub
    Private Sub CargarDatosReproduccion()
        ' Limpiamos el ListBox antes de cargar los nuevos datos
        listReproduccion.Items.Clear()

        ' Verificamos si se ha proporcionado el ID del usuario activo desde F1_Iniciar_Sesion
        If Not String.IsNullOrEmpty(F1_Iniciar_Sesion.idUsuarioActivo) Then
            ' Creamos una instancia de ReproduccionDAO para acceder a los datos de reproducción
            Dim repDAO As New ReproduccionDAO()
            ' Llamamos al método para leer todas las reproducciones
            repDAO.LeerTodasReproducciones()

            ' Iteramos sobre la colección de reproducciones y las agregamos al ListBox
            For Each reproduccion As Reproduccion In repDAO.Reproducciones
                ' Verificamos si la reproducción pertenece al usuario actual
                If reproduccion.Usuario = F1_Iniciar_Sesion.idUsuarioActivo Then
                    ' Mostramos el ID de reproducción en el ListBox
                    listReproduccion.Items.Add(reproduccion.IDReproduccion)
                End If
            Next
        End If
    End Sub

    Private Sub listReproduccion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listReproduccion.SelectedIndexChanged
        ' Aquí mostramos los detalles de la reproducción seleccionada en los TextBox

        ' Verificamos si se ha seleccionado algún elemento en el ListBox
        If listReproduccion.SelectedIndex >= 0 Then
            ' Obtenemos el ID de reproducción seleccionado
            Dim idReproduccionSeleccionado As Integer = CInt(listReproduccion.SelectedItem)

            ' Creamos una instancia de ReproduccionDAO para acceder a los datos de reproducción
            Dim repDAO As New ReproduccionDAO()
            ' Creamos una instancia de Reproduccion para almacenar los datos de la reproducción seleccionada
            Dim reproduccionSeleccionada As New Reproduccion(idReproduccionSeleccionado.ToString())
            ' Llamamos al método para leer los detalles de la reproducción seleccionada
            repDAO.LeerReproduccion(reproduccionSeleccionada)

            ' Mostramos los detalles de la reproducción en los TextBox
            txtIDReproduccion.Text = reproduccionSeleccionada.IDReproduccion.ToString()
            txtUsuario.Text = reproduccionSeleccionada.Usuario
            txtCancion.Text = reproduccionSeleccionada.Cancion.ToString()
            txtFecha.Text = reproduccionSeleccionada.Fecha.ToString()
        End If
    End Sub
End Class