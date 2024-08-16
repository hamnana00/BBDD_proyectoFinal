Public Class Reproduccion
    Public Property IDReproduccion As Integer
    Public Property Usuario As String
    Public Property Cancion As Integer
    Public Property Fecha As DateTime

    Public ReadOnly Property RepDAO As ReproduccionDAO

    Public Sub New()
        Me.RepDAO = New ReproduccionDAO
    End Sub

    Public Sub New(id As String)
        Me.RepDAO = New ReproduccionDAO
        Me.IDReproduccion = id
    End Sub

    Public Sub LeerTodasReproducciones()
        Me.RepDAO.LeerTodasReproducciones()
    End Sub

    Public Sub LeerReproduccion()
        Me.RepDAO.LeerReproduccion(Me)
    End Sub

    Public Function InsertarReproduccion() As Integer
        Return Me.RepDAO.Insertar(Me)
    End Function

    Public Function ActualizarReproduccion() As Integer
        Return Me.RepDAO.Actualizar(Me)
    End Function

    Public Function BorrarReproduccion() As Integer
        Return Me.RepDAO.Borrar(Me)
    End Function
End Class
