Imports System.Globalization

' En el formulario F11_Lista_Artista_Mas_Escuchado_Por_Fecha
Public Class F11_Lista_Artista_Mas_Escuchado_Por_Fecha
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ' Obtener las reproducciones entre las fechas especificadas
        Dim reproducciones As New List(Of Reproduccion)
        Try

            ' reproducciones = ReproduccionDAO.ObtenerReproduccionesEntreFechas(fechaInicio, fechaFin)
        Catch ex As Exception
            MessageBox.Show("Error al obtener las reproducciones: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        ' Contar cuántas veces cada artista ha sido reproducido
        Dim conteoArtistas As New Dictionary(Of Integer, Integer)()
        Dim reproduccionDAO As New ReproduccionDAO()

        For Each reproduccion In reproducciones
            Dim idArtista As Integer = reproduccionDAO.ObtenerIdArtistaPorReproduccion(reproduccion.IDReproduccion)

            If idArtista <> -1 Then
                If Not conteoArtistas.ContainsKey(idArtista) Then
                    conteoArtistas(idArtista) = 1
                Else
                    conteoArtistas(idArtista) += 1
                End If
            End If
        Next

        ' Ordenar los artistas por cantidad de reproducciones
        Dim artistasOrdenados = conteoArtistas.OrderByDescending(Function(pair) pair.Value)

        ' Limpiar el ListBox
        lstArtistas.Items.Clear()

        ' Mostrar los nombres de los artistas en el ListBox
        For Each par In artistasOrdenados
            lstArtistas.Items.Add(par.Key)
        Next
    End Sub

    Private Sub F11_Lista_Artista_Mas_Escuchado_Por_Fecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
