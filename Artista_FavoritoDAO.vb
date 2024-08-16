Imports System.Data.SqlClient

Public Class Artista_FavoritoDAO
    Private Shared _instancia As AgenteBD
    Private Shared conexion As MySql.Data.MySqlClient.MySqlConnection
    Private Const cadenaConexion As String = "server=localhost;database=cancionify;uid=root;pwd=root"
    Public ReadOnly Property Artistas_Favoritos As Collection

    Public Sub New()
        Me.Artistas_Favoritos = New Collection
    End Sub

    Public Sub LeerTodosArtistas_Favoritos()
        Dim a As Artista_Favorito
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Artistas_Favoritos ORDER BY Usuario")
        For Each aux In col
            a = New Artista_Favorito(aux(1).ToString)
            a.Artista = aux(2).ToString
            a.Fecha = aux(3).ToString
            Me.Artistas_Favoritos.Add(a)
        Next
    End Sub

    Public Sub LeerArtista_Favorito(ByRef a As Artista_Favorito)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Artistas_Favoritos WHERE Usuario='" & a.Usuario & "';")
        For Each aux In col
            a.Usuario = aux(1).ToString 'quitar si da error'
            a.Artista = aux(2).ToString
            a.Fecha = aux(3).ToString
        Next
    End Sub

    Public Function Insertar(ByVal a As Artista_Favorito) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Artistas_Favoritos VALUES ('" & a.Usuario & "', '" & a.Artista & "', sysdate());")
    End Function

    Public Function Actualizar(ByVal a As Artista_Favorito) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Artistas_Favoritos SET Nombre='" & a.Artista & "', Fecha='" & a.Fecha & "' WHERE Usuario='" & a.Usuario & "';")
    End Function

    Public Function Borrar(ByVal a As Artista_Favorito) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Artistas_Favoritos WHERE Usuario='" & a.Usuario & "';")
    End Function


End Class
