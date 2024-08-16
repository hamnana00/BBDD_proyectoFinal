Public Class Cancion
    Public Property IDCancion As Integer
    Public Property Nombre As String
    Public Property Album As Integer
    Public Property Duracion As Integer

    Public ReadOnly Property CanDAO As CancionDAO

    Public Sub New()
        Me.CanDAO = New CancionDAO
    End Sub

    Public Sub New(id As String)
        Me.CanDAO = New CancionDAO
        Me.IDCancion = id
    End Sub

    Public Sub LeerTodasCanciones(ByVal IDAlbum As String)
        Me.CanDAO.LeerTodasCanciones(IDAlbum)
    End Sub

    Public Sub LeerCancion()
        Me.CanDAO.LeerCancion(Me)
    End Sub

    Public Function InsertarCancion() As Integer
        Return Me.CanDAO.Insertar(Me)
    End Function

    Public Function ActualizarCancion() As Integer
        Return Me.CanDAO.Actualizar(Me)
    End Function

    Public Function BorrarCancion() As Integer
        Return Me.CanDAO.Borrar(Me)
    End Function
End Class
