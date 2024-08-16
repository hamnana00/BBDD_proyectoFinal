Public Class ArtistaDAO
    Public ReadOnly Property Artistas As Collection

    Public Sub New()
        Me.Artistas = New Collection
    End Sub

    Public Sub LeerTodasArtistas()
        Dim a As Artista
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Artistas ORDER BY IDArtistas")
        For Each aux In col
            a = New Artista(aux(1).ToString)
            a.Nombre = aux(2).ToString
            a.Pais = aux(3).ToString
            a.Imagen = aux(4).ToString ' Cargar la ruta de la imagen
            Me.Artistas.Add(a)
        Next
    End Sub

    Public Sub LeerArtista(ByRef a As Artista)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Artistas WHERE IDArtistas='" & a.IDArtistas & "';")
        For Each aux In col
            a.Nombre = aux(2).ToString
            a.Pais = aux(3).ToString
            a.Imagen = aux(4).ToString ' Cargar la ruta de la imagen
        Next
    End Sub

    Public Function Insertar(ByVal a As Artista) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Artistas VALUES ('" & a.IDArtistas & "', '" & a.Nombre & "', '" & a.Pais & "', '" & a.Imagen & "');")
    End Function

    Public Function Actualizar(ByVal a As Artista) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Artistas SET Nombre='" & a.Nombre & "', Pais='" & a.Pais & "', Imagen='" & a.Imagen & "' WHERE IDArtistas='" & a.IDArtistas & "';")
    End Function

    Public Function Borrar(ByVal a As Artista) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Artistas WHERE IDArtistas='" & a.IDArtistas & "';")
    End Function
End Class