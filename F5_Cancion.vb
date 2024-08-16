Public Class F5_Cancion
    Private a As Cancion
    Private IDAlbum As String

    ' Constructor que acepta el ID del álbum seleccionado
    Public Sub New(ByVal IDAlbum As String)
        InitializeComponent()
        ' Asigna el ID del álbum seleccionado
        Me.IDAlbum = IDAlbum
    End Sub

    Private Sub btnCambiarUsuario_Click(sender As Object, e As EventArgs) Handles btnCambiarUsuario.Click
        Dim f1 As New F1_Iniciar_Sesion()
        f1.ShowDialog()
    End Sub
    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
        If Me.txtIDCancion.Text <> String.Empty AndAlso Me.txtNombre.Text <> String.Empty AndAlso Me.txtAlbum.Text <> String.Empty AndAlso Me.txtDuracion.Text <> String.Empty Then
            Dim a As New Cancion
            a.IDCancion = txtIDCancion.Text
            a.Nombre = txtNombre.Text
            a.Album = txtAlbum.Text
            Dim partesDuracion As String() = txtDuracion.Text.Split(":"c)
            Dim duracionSegundos As Integer = (Integer.Parse(partesDuracion(0)) * 60) + Integer.Parse(partesDuracion(1))
            a.Duracion = duracionSegundos.ToString()

            Try
                If a.InsertarCancion() <> 1 Then
                    MessageBox.Show("INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.lstCanciones.Items.Add(a.IDCancion)
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If Not a Is Nothing Then
            a.Nombre = txtNombre.Text
            a.Album = txtAlbum.Text
            Dim partesDuracion As String() = txtDuracion.Text.Split(":"c)
            Dim duracionSegundos As Integer = (Integer.Parse(partesDuracion(0)) * 60) + Integer.Parse(partesDuracion(1))
            a.Duracion = duracionSegundos.ToString()


            Try
                If a.ActualizarCancion() <> 1 Then
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
        Me.txtIDCancion.Text = String.Empty
        Me.txtNombre.Text = String.Empty
        Me.txtAlbum.Text = String.Empty
        Me.txtDuracion.Text = String.Empty
        Me.btnActualizar.Enabled = False
        Me.btnEliminar.Enabled = False
        Me.txtIDCancion.Enabled = True
        Me.btnReproducirCancion.Enabled = False
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If Not Me.a Is Nothing Then
            If MessageBox.Show("¿Estás seguro que quieres borrar " & Me.a.IDCancion & "?", "Por favor, confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    If Me.a.BorrarCancion() <> 1 Then
                        MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try
                Me.lstCanciones.Items.Remove(a.IDCancion)
            End If
            Me.btnLimpiar.PerformClick()
        End If
    End Sub

    Private Sub btnReproducirCancion_Click(sender As Object, e As EventArgs) Handles btnReproducirCancion.Click
        If Not Me.a Is Nothing Then
            Dim reproduccion As New Reproduccion()
            reproduccion.Cancion = Me.a.IDCancion
            reproduccion.Usuario = F1_Iniciar_Sesion.idUsuarioActivo ' Aquí debes asignar el nombre de usuario que está reproduciendo la canción

            ' Simulación de la reproducción (mostrar un mensaje)
            MessageBox.Show("Reproduciendo la canción " & Me.a.Nombre & "...")

            ' Registrar la reproducción en la base de datos
            Try
                reproduccion.RepDAO.CancionReproducir(reproduccion)
                MessageBox.Show("La reproducción ha sido registrada correctamente.")
            Catch ex As Exception
                MessageBox.Show("Error al registrar la reproducción: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    Private Sub lstCanciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCanciones.SelectedIndexChanged
        Me.btnActualizar.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.txtIDCancion.Enabled = False
        Me.btnReproducirCancion.Enabled = True
        If Not Me.lstCanciones.SelectedItem Is Nothing Then
            Me.a = New Cancion(Me.lstCanciones.SelectedItem.ToString)
            Try
                Me.a.LeerCancion()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.txtIDCancion.Text = Me.a.IDCancion.ToString
            Me.txtNombre.Text = Me.a.Nombre.ToString
            Me.txtAlbum.Text = Me.a.Album.ToString
            Dim duracionSegundos As Integer
            If Integer.TryParse(Me.a.Duracion, duracionSegundos) Then
                Dim minutos As Integer = duracionSegundos \ 60
                Dim segundos As Integer = duracionSegundos Mod 60
                Dim duracionFormato As String = minutos.ToString("D2") & ":" & segundos.ToString("D2")
                Me.txtDuracion.Text = duracionFormato
            Else
                MessageBox.Show("Error al convertir la duración de la canción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub F5_Cancion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.a = New Cancion
        Try
            Me.a.LeerTodasCanciones(IDAlbum)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each aAux In Me.a.CanDAO.Canciones
            Me.lstCanciones.Items.Add(aAux.IDCancion)
        Next
        btnAnadir.Enabled = True
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtDuracion_TextChanged(sender As Object, e As EventArgs) Handles txtDuracion.TextChanged

    End Sub
End Class