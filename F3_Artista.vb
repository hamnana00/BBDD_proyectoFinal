Imports System.Globalization
Imports System.Windows.Forms
Imports System.IO

Public Class F3_Artista
    Private a As Artista
    Private idUsuarioActivo As String
    Public Sub New(idUsuario As String)
        InitializeComponent()
        idUsuarioActivo = idUsuario
        ' btnAccederAlbum.Enabled = False
    End Sub

    Private Sub btnCambiarUsuario_Click(sender As Object, e As EventArgs) Handles btnCambiarUsuario.Click
        Dim f1 As New F1_Iniciar_Sesion()
        f1.ShowDialog()
    End Sub

    'Private Sub btnAccederAlbum_Click(sender As Object, e As EventArgs) Handles btnAccederAlbum.Click
    'Dim f4 As New F4_Album()
    '   f4.ShowDialog()
    'End Sub

    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
        If Me.txtIDArtista.Text <> String.Empty AndAlso Me.txtNombre.Text <> String.Empty AndAlso Me.txtPais.Text <> String.Empty AndAlso Me.txtImagen.Text <> String.Empty Then
            Dim a As New Artista
            a.IDArtistas = txtIDArtista.Text
            a.Nombre = txtNombre.Text
            a.Pais = txtPais.Text
            a.Imagen = txtImagen.Text ' Asignar la ruta de la imagen

            Try
                If a.InsertarArtista() <> 1 Then
                    MessageBox.Show("INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.lstArtista.Items.Add(a.IDArtistas)
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If Not a Is Nothing Then
            a.Nombre = txtNombre.Text
            a.Pais = txtPais.Text
            a.Imagen = txtImagen.Text ' Asignar la ruta de la imagen

            Try
                If a.ActualizarArtista() <> 1 Then
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

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Me.txtIDArtista.Text = String.Empty
        Me.txtNombre.Text = String.Empty
        Me.txtPais.Text = String.Empty
        Me.txtImagen.Text = String.Empty ' Limpiar la ruta de la imagen
        Me.btnActualizar.Enabled = False
        Me.btnEliminar.Enabled = False
        Me.txtIDArtista.Enabled = True
        Me.picBoxImagen.Image = Nothing ' Limpiar la imagen en el PictureBox
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If Not Me.a Is Nothing Then
            If MessageBox.Show("¿Estás seguro que quieres borrar " & Me.a.IDArtistas & "?", "Por favor, confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    If Me.a.BorrarArtista() <> 1 Then
                        MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try
                Me.lstArtista.Items.Remove(a.IDArtistas)
            End If
            Me.btnLimpiar.PerformClick()
        End If
    End Sub

    Private Sub lstArtista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstArtista.SelectedIndexChanged
        Me.btnActualizar.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.txtIDArtista.Enabled = False
        If Not Me.lstArtista.SelectedItem Is Nothing Then
            Me.a = New Artista(Me.lstArtista.SelectedItem.ToString)
            Try
                Me.a.LeerArtista()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.txtIDArtista.Text = Me.a.IDArtistas.ToString
            Me.txtNombre.Text = Me.a.Nombre.ToString
            Me.txtPais.Text = Me.a.Pais.ToString
            Me.txtImagen.Text = Me.a.Imagen ' Mostrar la ruta de la imagen

            ' Cargar la imagen en el PictureBox
            Dim rutaProyecto As String = Directory.GetCurrentDirectory()
            Dim rutaImagen As String = Path.Combine(rutaProyecto, "Imagenes", Me.a.Imagen)
            Console.WriteLine("Ruta de la imagen: " & rutaImagen)
            If File.Exists(rutaImagen) Then
                Me.picBoxImagen.Image = Image.FromFile(rutaImagen)
                Me.picBoxImagen.SizeMode = PictureBoxSizeMode.Zoom
            Else
                MessageBox.Show(rutaImagen, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If



            Dim IDArtista As String = lstArtista.SelectedItem.ToString()
            Dim f4 As New F4_Album(IDArtista)
            f4.ShowDialog()
        End If
    End Sub
    Private Sub F3_Artista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Aquí se carga automáticamente la base de datos al abrir el formulario
        Me.a = New Artista
        Try
            Me.a.LeerTodasArtistas()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each aAux In Me.a.ArtDAO.Artistas
            Me.lstArtista.Items.Add(aAux.IDArtistas)
        Next
        btnAnadir.Enabled = True
    End Sub
    Private artistasFavoritos As New List(Of String)

    Private Sub picBoxImagen_Click(sender As Object, e As EventArgs) Handles picBoxImagen.Click

    End Sub


End Class
