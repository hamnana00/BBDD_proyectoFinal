Imports System.Globalization

Public Class F1_Iniciar_Sesion
    Private u As Usuario
    Public Shared Property idUsuarioActivo As String
    Private Sub lstUsuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUsuarios.SelectedIndexChanged
        Me.btnActualizar.Enabled = False
        Me.btnActualizar.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.btnLimpiar.Enabled = True
        Me.btnIniciar_Sesion.Enabled = True
        Me.txtEmail.Enabled = False
        If Not Me.lstUsuarios.SelectedItem Is Nothing Then
            Me.u = New Usuario(Me.lstUsuarios.SelectedItem.ToString)
            Try
                Me.u.LeerUsuario()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.txtEmail.Text = Me.u.Email.ToString
            Me.txtNombre.Text = Me.u.Nombre.ToString
            Me.txtApellidos.Text = Me.u.Apellidos.ToString
            Me.txtFechaNacimiento.Text = Me.u.FechaNacimiento.ToString("dd/MM/yyyy")
        End If

    End Sub

    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
        If Me.txtEmail.Text <> String.Empty AndAlso Me.txtNombre.Text <> String.Empty AndAlso Me.txtApellidos.Text <> String.Empty AndAlso Me.txtFechaNacimiento.Text <> String.Empty Then
            Dim u As New Usuario
            u.Email = Me.txtEmail.Text
            u.Nombre = Me.txtNombre.Text
            u.Apellidos = Me.txtApellidos.Text

            ' Convertir el texto de la fecha a un objeto Date
            Dim fechaNacimiento As Date
            If DateTime.TryParseExact(Me.txtFechaNacimiento.Text, "dd/MM/yyyy", Nothing, DateTimeStyles.None, fechaNacimiento) Then
                u.FechaNacimiento = fechaNacimiento
            Else
                MessageBox.Show("La fecha de nacimiento no tiene un formato válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Try
                If u.InsertarUsuario() <> 1 Then
                    MessageBox.Show("INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.lstUsuarios.Items.Add(u.Email)
        End If
        Me.btnAnadir.Enabled = True
        Me.btnActualizar.Enabled = True
        Me.btnLimpiar.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.btnIniciar_Sesion.Enabled = False
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If Not u Is Nothing Then
            u.Nombre = Me.txtNombre.Text
            u.Apellidos = Me.txtApellidos.Text
            Dim fechaNacimiento As Date
            If DateTime.TryParseExact(Me.txtFechaNacimiento.Text, "dd/MM/yyyy", Nothing, DateTimeStyles.None, fechaNacimiento) Then
                u.FechaNacimiento = fechaNacimiento
            Else
                MessageBox.Show("La fecha de nacimiento no tiene un formato válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Try
                If u.ActualizarUsuario() <> 1 Then
                    MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            MessageBox.Show(u.Nombre & " actualizado correctamente!")
        End If
        Me.btnAnadir.Enabled = False
        Me.btnLimpiar.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.btnIniciar_Sesion.Enabled = False
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If Not Me.u Is Nothing Then
            If MessageBox.Show("¿Estás seguro que quieres borrar " & Me.u.Email & "?", "Por favor, confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    If Me.u.BorrarUsuario() <> 1 Then
                        MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try
                Me.lstUsuarios.Items.Remove(u.Email)
            End If
            Me.btnLimpiar.PerformClick()
        End If
        Me.btnAnadir.Enabled = True
        Me.btnActualizar.Enabled = True
        Me.btnLimpiar.Enabled = True
        Me.btnIniciar_Sesion.Enabled = False
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Me.txtEmail.Text = String.Empty
        Me.txtNombre.Text = String.Empty
        Me.txtApellidos.Text = String.Empty
        Me.txtFechaNacimiento.Text = String.Empty
        Me.btnAnadir.Enabled = True
        Me.btnActualizar.Enabled = False
        Me.btnEliminar.Enabled = False
        Me.btnIniciar_Sesion.Enabled = False
        Me.txtEmail.Enabled = True
    End Sub

    Private Sub btnIniciar_Sesion_Click(sender As Object, e As EventArgs) Handles btnIniciar_Sesion.Click
        ' Cuando se hace clic en el botón "Iniciar Sesión", guardar el ID del usuario seleccionado
        If Not Me.lstUsuarios.SelectedItem Is Nothing Then
            Me.idUsuarioActivo = Me.lstUsuarios.SelectedItem.ToString()
            ' Mostrar un mensaje de confirmación u otra acción relacionada con el inicio de sesión
            MessageBox.Show("Inicio de sesión exitoso para el usuario: " & Me.idUsuarioActivo, "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Dim f2 As New F2_Usuario()
        f2.ShowDialog()
    End Sub

    Private Sub btnUsuarioActivo_Click(sender As Object, e As EventArgs) Handles btnUsuarioActivo.Click
        Dim f12 As New F12_Usuario_Mas_Activo()
        f12.ShowDialog()
    End Sub

    Private Sub F1_Iniciar_Sesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim uAux As Usuario
        Me.u = New Usuario
        Try
            Me.u.LeerTodasUsuarios()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each uAux In Me.u.UserDAO.Usuarios
            Me.lstUsuarios.Items.Add(uAux.Email)
        Next
        btnAnadir.Enabled = True
    End Sub

End Class