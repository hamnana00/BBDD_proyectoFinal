Public Class Usuario
    Public Property Email As String
    Public Property Nombre As String
    Public Property Apellidos As String
    Public Property FechaNacimiento As Date
    Public ReadOnly Property UserDAO As UsuarioDAO

    Public Sub New()
        ' Se instancia un nuevo objeto UsuariosDAO para interactuar con la base de datos'
        Me.UserDAO = New UsuarioDAO
    End Sub

    Public Sub New(id As String)
        Me.UserDAO = New UsuarioDAO    ' Se instancia un nuevo objeto UsuariosDAO para interactuar con la base de datos
        Me.Email = id                   ' Se asigna el email proporcionado al objeto Usuario'
    End Sub

    Public Sub LeerTodasUsuarios()
        Me.UserDAO.LeerTodasUsuarios()
    End Sub

    Public Sub LeerUsuario()
        Me.UserDAO.LeerUsuario(Me)
    End Sub

    Public Function InsertarUsuario() As Integer
        Return Me.UserDAO.Insertar(Me)
    End Function

    Public Function ActualizarUsuario() As Integer
        Return Me.UserDAO.Actualizar(Me)
    End Function

    Public Function BorrarUsuario() As Integer
        Return Me.UserDAO.Borrar(Me)
    End Function
End Class