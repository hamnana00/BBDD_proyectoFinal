Public Class AlbumDAO
    Public ReadOnly Property Albumes As Collection

    Public Sub New()
        Me.Albumes = New Collection
    End Sub

    Public Sub LeerTodosAlbumes(ByVal IDArtista As String)
        Dim a As Album
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Albumes WHERE Artista = '" & IDArtista & "'  ORDER BY IDAlbum")
        For Each aux In col
            a = New Album(aux(1).ToString)
            a.Nombre = aux(2).ToString
            a.Fecha = aux(3).ToString
            a.Artista = aux(4).ToString
            a.Portada = aux(5).ToString ' Cargar la ruta de la imagen'
            Me.Albumes.Add(a)
        Next
    End Sub

    Public Sub LeerAlbum(ByRef a As Album)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Albumes WHERE IDAlbum='" & a.IDAlbum & "';")
        For Each aux In col
            a.Nombre = aux(2).ToString
            a.Fecha = aux(3).ToString
            a.Artista = aux(4).ToString
            a.Portada = aux(5).ToString ' Cargar la ruta de la imagen
        Next
    End Sub

    Public Function Insertar(ByVal a As Album) As Integer
        Dim Fecha As String = a.Fecha.ToString("yyyy-MM-dd")
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Albumes VALUES ('" & a.IDAlbum & "', '" & a.Nombre & "', '" & Fecha & "', '" & a.Artista & "' ,'" & a.Portada & "');")
    End Function

    Public Function Actualizar(ByVal a As Album) As Integer
        Dim Fecha As String = a.Fecha.ToString("yyyy-MM-dd")
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Albumes SET Nombre='" & a.Nombre & "', Fecha='" & Fecha & "', Artista='" & a.Artista & "', Portada='" & a.Portada & "' WHERE IDAlbum='" & a.IDAlbum & "';")
    End Function

    Public Function Borrar(ByVal a As Album) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Albumes WHERE IDAlbum='" & a.IDAlbum & "';")
    End Function
    Public Function LeerTodasCancionesDeAlbum(ByVal IDAlbum As String) As Collection
        Dim col, aux As Collection
        Dim canciones As New Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Canciones WHERE Album = '" & IDAlbum & "' ORDER BY IDCancion")
        For Each aux In col
            Dim cancion As New Cancion(aux(1).ToString)
            cancion.Nombre = aux(2).ToString
            cancion.Album = aux(3).ToString
            cancion.Duracion = aux(4).ToString
            canciones.Add(cancion)
        Next
        Return canciones
    End Function

End Class