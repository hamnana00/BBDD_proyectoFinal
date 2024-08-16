Public Class UsuarioDAO

    Public ReadOnly Property Usuarios As Collection

    Public Sub New()
        Me.Usuarios = New Collection
    End Sub

    ' Método para leer todos los usuarios de la base de datos y almacenarlos en la colección Usuarios'
    Public Sub LeerTodasUsuarios()
        Dim u As Usuario
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Usuarios ORDER BY Email")
        For Each aux In col
            u = New Usuario(aux(1).ToString)
            u.Nombre = aux(2).ToString
            Me.Usuarios.Add(u)
        Next
    End Sub

    ' Método para leer un usuario específico de la base de datos y actualizar sus datos'
    Public Sub LeerUsuario(ByRef u As Usuario)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Usuarios WHERE Email='" & u.Email & "';")
        For Each aux In col
            u.Nombre = aux(2).ToString
            u.Apellidos = aux(3).ToString
            u.FechaNacimiento = aux(4).ToString
        Next
    End Sub

    Public Function ObtenerArtistasPorReproducciones(usuarioEmail As String, Optional pais As String = "") As Dictionary(Of String, Integer)
        Dim artistasReproducciones As New Dictionary(Of String, Integer)()

        ' Consulta SQL para obtener el número de reproducciones de cada artista para el usuario actual
        Dim query As String = "SELECT Artistas.Nombre, COUNT(Reproducciones.IDReproduccion) AS Reproducciones " &
                          "FROM Reproducciones " &
                          "INNER JOIN Canciones ON Reproducciones.Cancion = Canciones.IDCancion " &
                          "INNER JOIN Albumes ON Canciones.Album = Albumes.IDAlbum " &
                          "INNER JOIN Artistas ON Albumes.Artista = Artistas.IDArtistas " &
                          "WHERE Reproducciones.Usuario = '" & usuarioEmail & "'"

        If pais <> "" Then
            query &= " AND Artistas.Pais = '" & pais & "'"
        End If

        query &= " GROUP BY Artistas.Nombre " &
              "ORDER BY Reproducciones DESC"

        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente().Leer(query)

        For Each aux In col
            artistasReproducciones.Add(aux(1).ToString, CInt(aux(2).ToString))
        Next

        Return artistasReproducciones
    End Function

    ' Método para insertar un nuevo usuario en la base de datos'
    Public Function Insertar(ByVal u As Usuario) As Integer
        Dim fechaNacimiento As String = u.FechaNacimiento.ToString("yyyy-MM-dd")
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Usuarios VALUES ('" & u.Email & "', '" & u.Nombre & "','" & u.Apellidos & "','" & fechaNacimiento & "');")
    End Function

    ' Método para actualizar los datos de un usuario en la base de datos'
    Public Function Actualizar(ByVal u As Usuario) As Integer
        Dim fechaNacimiento As String = u.FechaNacimiento.ToString("yyyy-MM-dd")
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Usuarios SET Nombre='" & u.Nombre & "', Apellidos='" & u.Apellidos & "', FechaNacimiento='" & fechaNacimiento & "' WHERE Email='" & u.Email & "';")
    End Function

    ' Método para borrar un usuario de la base de datos'
    Public Function Borrar(ByVal u As Usuario) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Usuarios WHERE Email='" & u.Email & "';")
    End Function

End Class