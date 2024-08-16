Imports System.IO

Public Class F4_Album

    Private a As Album
    Private IDArtista As String

    Public Sub New(ByVal IDArtista As String)
        InitializeComponent()

        Me.IDArtista = IDArtista
    End Sub
    Private Sub btnCambiarUsuario_Click(sender As Object, e As EventArgs) Handles btnCambiarUsuario.Click
        Dim f1 As New F1_Iniciar_Sesion()
        f1.ShowDialog()
    End Sub

    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
        If Me.txtIDAlbum.Text <> String.Empty AndAlso Me.txtNombre.Text <> String.Empty AndAlso Me.txtFecha.Text <> String.Empty AndAlso Me.txtArtista.Text <> String.Empty AndAlso Me.txtPortada.Text <> String.Empty Then
            Dim a As New Album
            a.IDAlbum = txtIDAlbum.Text
            a.Nombre = txtNombre.Text
            a.Fecha = txtFecha.Text
            a.Artista = txtArtista.Text
            a.Portada = txtPortada.Text ' Asignar la ruta de la portada

            Try
                If a.InsertarAlbum() <> 1 Then
                    MessageBox.Show("INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.lstAlbum.Items.Add(a.Artista)
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If Not a Is Nothing Then
            a.Nombre = txtNombre.Text
            a.Fecha = txtFecha.Text
            a.Artista = txtArtista.Text
            a.Portada = txtPortada.Text ' Asignar la ruta de la imagen

            Try
                If a.ActualizarAlbum() <> 1 Then
                    MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            MessageBox.Show(a.Nombre & " actualizado correctamente!")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If Not Me.a Is Nothing Then
            If MessageBox.Show("¿Estás seguro que quieres borrar " & Me.a.IDAlbum & "?", "Por favor, confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    If Me.a.BorrarAlbum() <> 1 Then
                        MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try
                Me.lstAlbum.Items.Remove(a.IDAlbum)
            End If
            Me.btnLimpiar.PerformClick()
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Me.txtIDAlbum.Text = String.Empty
        Me.txtNombre.Text = String.Empty
        Me.txtFecha.Text = String.Empty
        Me.txtArtista.Text = String.Empty
        Me.txtPortada.Text = String.Empty ' Limpiar la ruta de la imagen
        Me.btnActualizar.Enabled = False
        Me.btnEliminar.Enabled = False
        Me.txtIDAlbum.Enabled = True
        Me.picBoxPortada.Image = Nothing ' Limpiar la portada en el PictureBox
    End Sub

    Private Sub lstAlbum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAlbum.SelectedIndexChanged
        Me.btnActualizar.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.txtIDAlbum.Enabled = False
        If Not Me.lstAlbum.SelectedItem Is Nothing Then
            Me.a = New Album(Me.lstAlbum.SelectedItem.ToString)
            Try
                Me.a.LeerAlbum()

                ' Leer todas las canciones del álbum
                Dim canciones As Collection = Me.a.AlbDAO.LeerTodasCancionesDeAlbum(Me.a.IDAlbum)

                ' Calcular la duración total del álbum
                Dim duracionTotal As Integer = 0
                For Each cancion As Cancion In canciones
                    ' Sumar la duración de cada canción
                    duracionTotal += cancion.Duracion
                Next

                ' Convertir la duración total a formato de tiempo adecuado (horas:minutos:segundos)
                Dim horas As Integer = duracionTotal \ 3600
                Dim minutos As Integer = (duracionTotal Mod 3600) \ 60
                Dim segundos As Integer = duracionTotal Mod 60

                ' Mostrar la duración total en un formato adecuado
                Me.txtDuracionAlbum.Text = $"{horas:00}:{minutos:00}:{segundos:00}"
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try

            ' Resto del código para mostrar los detalles del álbum
            Me.txtIDAlbum.Text = Me.a.IDAlbum.ToString
            Me.txtNombre.Text = Me.a.Nombre.ToString
            Me.txtFecha.Text = Me.a.Fecha.ToString("dd/MM/yyyy")
            Me.txtArtista.Text = Me.a.Artista.ToString
            Me.txtPortada.Text = Me.a.Portada.ToString ' Mostrar la ruta de la imagen

            ' Cargar la imagen en el PictureBox
            Dim rutaProyecto As String = Directory.GetCurrentDirectory()
            Dim rutaImagen As String = Path.Combine(rutaProyecto, "Imagenes", Me.a.Portada)
            Console.WriteLine("Ruta de la imagen: " & rutaImagen)
            If File.Exists(rutaImagen) Then
                Me.picBoxPortada.Image = Image.FromFile(rutaImagen)
                Me.picBoxPortada.SizeMode = PictureBoxSizeMode.Zoom
            Else
                MessageBox.Show("La portada no se encuentra en la ruta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            ' Abrir el formulario de canciones para mostrar las canciones del álbum
            Dim IDAlbum As String = Me.lstAlbum.SelectedItem.ToString()
            Dim f5 As New F5_Cancion(IDAlbum)
            f5.ShowDialog()
        End If
    End Sub


    Private Sub F4_Album_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim aAux As Album
        Me.a = New Album
        Try
            Me.a.LeerTodosAlbumes(IDArtista)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        Me.lstAlbum.Items.Clear()
        For Each aAux In Me.a.AlbDAO.Albumes
            Me.lstAlbum.Items.Add(aAux.IDAlbum)
        Next
        btnAnadir.Enabled = True
    End Sub

    Private Sub picBoxPortada_Click(sender As Object, e As EventArgs) Handles picBoxPortada.Click

    End Sub

    Private Sub txtIDAlbum_TextChanged(sender As Object, e As EventArgs) Handles txtIDAlbum.TextChanged

    End Sub
End Class