Public Class F0_Principal
    Public Sub New()
        InitializeComponent()

        ' Configura la barra de progreso
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0

        ' Deshabilita el botón
        btnAbrir.Enabled = False
    End Sub

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        Dim f1 As New F1_Iniciar_Sesion()
        f1.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Aumenta el valor de la barra de progreso
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 5
        Else
            ' Detiene el temporizador cuando la barra alcanza el 100%
            Timer1.Stop()
        End If

        ' Habilita el botón si la barra de progreso alcanza el 90% o más
        If ProgressBar1.Value >= 90 Then
            btnAbrir.Enabled = True
        End If
    End Sub

    Private Sub FormularioPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicia el temporizador cuando se carga el formulario
        Timer1.Start()
    End Sub


End Class
