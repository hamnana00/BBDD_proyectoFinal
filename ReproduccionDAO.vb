Public Class ReproduccionDAO
    Public ReadOnly Property Reproducciones As Collection


    Public Sub New()
        Me.Reproducciones = New Collection
    End Sub

    Public Sub LeerTodasReproducciones()
        Dim a As Reproduccion
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Reproducciones ORDER BY IDReproduccion")
        For Each aux In col
            a = New Reproduccion(aux(1).ToString)
            a.Usuario = aux(2).ToString
            a.Cancion = aux(3).ToString
            a.Fecha = DateTime.Parse(aux(4).ToString)
            Me.Reproducciones.Add(a)
        Next
    End Sub

    Public Sub LeerReproduccion(ByRef a As Reproduccion)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Reproducciones WHERE IDReproduccion='" & a.IDReproduccion & "';")
        For Each aux In col
            a.Usuario = aux(2).ToString
            a.Cancion = aux(3).ToString
            a.Fecha = DateTime.Parse(aux(4).ToString)
        Next
    End Sub

    Public Sub CancionReproducir(ByVal a As Reproduccion)

        Dim colUsuario As Collection
        colUsuario = AgenteBD.ObtenerAgente().Leer("SELECT Email FROM Usuarios WHERE Email='" & a.Usuario & "';")
        If colUsuario.Count = 0 Then
            Throw New Exception("El usuario especificado no existe.")
        End If

        ' Obtener la duración de la canción en segundos
        Dim duracion As Integer
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT Duracion FROM Canciones WHERE IDCancion='" & a.Cancion & "';")
        For Each aux In col
            duracion = CInt(aux(1).ToString)
        Next

        ' Simular la reproducción (en este caso, solo mostrando el tiempo de reproducción)
        Dim minutos As Integer = duracion \ 60
        Dim segundos As Integer = duracion Mod 60
        Console.WriteLine("Reproduciendo canción con ID: " & a.Cancion)
        Console.WriteLine("Duración: " & minutos.ToString("D2") & ":" & segundos.ToString("D2"))

        ' Registrar la reproducción en la base de datos
        Dim idReproduccion As Integer = ObtenerNuevoIDReproduccion()
        a.IDReproduccion = idReproduccion
        a.Fecha = DateTime.Now ' Nos aseguramos de que se registra la fecha actual
        Me.Insertar(a)
    End Sub

    Private Function ObtenerNuevoIDReproduccion() As Integer
        ' Obtener el último ID de reproducción registrado y agregar 1
        Dim ultimoID As Integer = ObtenerUltimoIDReproduccion()
        Return ultimoID + 1
    End Function

    Private Function ObtenerUltimoIDReproduccion() As Integer
        ' Obtener el último ID de reproducción registrado en la base de datos
        Dim ultimoID As Integer = 0
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT MAX(IDReproduccion) FROM Reproducciones;")
        For Each aux In col
            If Not String.IsNullOrEmpty(aux(1).ToString) Then
                ultimoID = CInt(aux(1).ToString)
            End If
        Next
        Return ultimoID
    End Function


    Public Function Insertar(ByVal a As Reproduccion) As Integer
        Dim fechaFormateada As String = a.Fecha.ToString("yyyy-MM-dd HH:mm:ss")
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Reproducciones VALUES ('" & a.IDReproduccion & "', '" & a.Usuario & "', '" & a.Cancion & "', '" & fechaFormateada & "');")
    End Function

    Public Function Actualizar(ByVal a As Reproduccion) As Integer
        Dim fechaFormateada As String = a.Fecha.ToString("yyyy-MM-dd HH:mm:ss")
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Reproducciones SET Usuario='" & a.Usuario & "', Cancion='" & a.Cancion & "', Fecha='" & fechaFormateada & "' WHERE IDReproduccion='" & a.IDReproduccion & "';")
    End Function

    Public Function Borrar(ByVal a As Reproduccion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Reproducciones WHERE IDReproduccion='" & a.IDReproduccion & "';")
    End Function
    Public Function ObtenerIdArtistaPorReproduccion(idReproduccion As Integer) As Integer
        Dim idArtista As Integer = -1 ' Valor por defecto si no se encuentra el ID del artista

        ' Consulta SQL para obtener el ID del artista asociado a la reproducción
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT Canciones.Artista FROM Reproducciones JOIN Canciones ON Reproducciones.Cancion = Canciones.IDCancion WHERE Reproducciones.IDReproduccion = " & idReproduccion)

        For Each aux In col
            idArtista = Convert.ToInt32(aux(1))
            Exit For ' Solo necesitamos el primer resultado
        Next

        Return idArtista
    End Function

    Public Function ObtenerTiempoReproduccionPorUsuario(ByVal emailUsuario As String) As TimeSpan
        Dim tiempoTotal As TimeSpan = TimeSpan.Zero
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT Duracion FROM Canciones INNER JOIN Reproducciones ON Canciones.IDCancion = Reproducciones.Cancion WHERE Reproducciones.Usuario = '" & emailUsuario & "';")
        For Each aux In col
            Dim duracionCancion As Integer = CInt(aux(1).ToString)
            tiempoTotal = tiempoTotal.Add(TimeSpan.FromSeconds(duracionCancion))
        Next
        Return tiempoTotal
    End Function
End Class
