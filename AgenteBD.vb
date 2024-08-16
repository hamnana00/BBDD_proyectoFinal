Imports System.Data

Public Class AgenteBD

    Private Shared _instancia As AgenteBD
    Private Shared conexion As MySql.Data.MySqlClient.MySqlConnection
    Private Const cadenaConexion As String = "server=localhost;database=cancionify;uid=root;pwd=root"

    'Establecer conexion al instanciar la clase'
    Private Sub New()
        AgenteBD.conexion = New MySql.Data.MySqlClient.MySqlConnection(AgenteBD.cadenaConexion)
    End Sub

    'Método para obtener una instancia única del AgenteBD (patrón Singleton)'
    Public Shared Function ObtenerAgente() As AgenteBD
        If AgenteBD._instancia Is Nothing Then
            AgenteBD._instancia = New AgenteBD
        End If
        Return AgenteBD._instancia
    End Function

    ' Método para leer datos de la base de datos y devolverlos en una colección'
    Public Function Leer(sql As String) As Collection
        Dim result As New Collection
        Dim fila As Collection
        Dim i As Integer
        Dim reader As MySql.Data.MySqlClient.MySqlDataReader
        Dim com As New MySql.Data.MySqlClient.MySqlCommand(sql, AgenteBD.conexion)
        Conectar()
        reader = com.ExecuteReader
        While reader.Read
            fila = New Collection
            For i = 0 To reader.FieldCount - 1
                fila.Add(reader(i).ToString)
            Next
            result.Add(fila)
        End While
        Desconectar()
        Return result
    End Function

    'Método para realizar operaciones de modificación en la base de datos (insert, update, delete)'
    Public Function Modificar(sql As String) As Integer
        Dim com As New MySql.Data.MySqlClient.MySqlCommand(sql, AgenteBD.conexion)
        Dim result As Integer
        Conectar()
        result = com.ExecuteNonQuery
        Desconectar()
        Return result
    End Function

    ' Método privado para cerrar la conexión si está abierta'
    Private Sub Conectar()
        If AgenteBD.conexion.State = ConnectionState.Closed Then
            AgenteBD.conexion.Open()
        End If
    End Sub

    'Método privado para cerrar la conexión si está abierta'
    Private Sub Desconectar()
        If AgenteBD.conexion.State = ConnectionState.Open Then
            AgenteBD.conexion.Close()
        End If
    End Sub

End Class
