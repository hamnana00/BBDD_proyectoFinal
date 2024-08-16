Public Class CancionDAO
    Public ReadOnly Property Canciones As Collection

    Public Sub New()
        Me.Canciones = New Collection
    End Sub

    Public Sub LeerTodasCanciones(ByVal IDAlbum As String)
        Dim a As Cancion
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Canciones WHERE Album = '" & IDAlbum & "' ORDER BY IDCancion")
        For Each aux In col
            a = New Cancion(aux(1).ToString)
            a.Nombre = aux(2).ToString
            a.Album = aux(3).ToString
            a.Duracion = aux(4).ToString ' Cargar la ruta de la imagen
            Me.Canciones.Add(a)
        Next
    End Sub

    Public Sub LeerCancion(ByRef a As Cancion)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Canciones WHERE IDCancion='" & a.IDCancion & "';")
        For Each aux In col
            a.Nombre = aux(2).ToString
            a.Album = aux(3).ToString
            a.Duracion = aux(4).ToString
        Next
    End Sub

    Public Function Insertar(ByVal a As Cancion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Canciones VALUES ('" & a.IDCancion & "', '" & a.Nombre & "', '" & a.Album & "', '" & a.Duracion & "');")
    End Function

    Public Function Actualizar(ByVal a As Cancion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Canciones SET Nombre='" & a.Nombre & "', Album='" & a.Album & "', Duracion='" & a.Duracion & "' WHERE IDCancion='" & a.IDCancion & "';")
    End Function

    Public Function Borrar(ByVal a As Cancion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Canciones WHERE IDCancion='" & a.IDCancion & "';")
    End Function

End Class