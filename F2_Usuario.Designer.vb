<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F2_Usuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F2_Usuario))
        Me.btnAccederArtista = New System.Windows.Forms.Button()
        Me.btnUsuario = New System.Windows.Forms.Button()
        Me.btnHistorial = New System.Windows.Forms.Button()
        Me.btnArtistasFavoritos = New System.Windows.Forms.Button()
        Me.btnArtistaReproducion = New System.Windows.Forms.Button()
        Me.btnCancionReproduccion = New System.Windows.Forms.Button()
        Me.btnArtistaMasEscuchadoEnFecha = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAccederArtista
        '
        Me.btnAccederArtista.BackColor = System.Drawing.Color.White
        Me.btnAccederArtista.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccederArtista.Location = New System.Drawing.Point(82, 274)
        Me.btnAccederArtista.Name = "btnAccederArtista"
        Me.btnAccederArtista.Size = New System.Drawing.Size(182, 49)
        Me.btnAccederArtista.TabIndex = 2
        Me.btnAccederArtista.Text = "Buscar Artista"
        Me.btnAccederArtista.UseVisualStyleBackColor = False
        '
        'btnUsuario
        '
        Me.btnUsuario.BackColor = System.Drawing.Color.White
        Me.btnUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuario.Location = New System.Drawing.Point(24, 39)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(192, 38)
        Me.btnUsuario.TabIndex = 3
        Me.btnUsuario.Text = "Cambiar Usuario"
        Me.btnUsuario.UseVisualStyleBackColor = False
        '
        'btnHistorial
        '
        Me.btnHistorial.BackColor = System.Drawing.Color.White
        Me.btnHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistorial.Location = New System.Drawing.Point(490, 106)
        Me.btnHistorial.Name = "btnHistorial"
        Me.btnHistorial.Size = New System.Drawing.Size(380, 38)
        Me.btnHistorial.TabIndex = 4
        Me.btnHistorial.Text = "Ver Historial"
        Me.btnHistorial.UseVisualStyleBackColor = False
        '
        'btnArtistasFavoritos
        '
        Me.btnArtistasFavoritos.BackColor = System.Drawing.Color.White
        Me.btnArtistasFavoritos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArtistasFavoritos.Location = New System.Drawing.Point(490, 195)
        Me.btnArtistasFavoritos.Name = "btnArtistasFavoritos"
        Me.btnArtistasFavoritos.Size = New System.Drawing.Size(380, 35)
        Me.btnArtistasFavoritos.TabIndex = 5
        Me.btnArtistasFavoritos.Text = "Lista Artistas Favoritos"
        Me.btnArtistasFavoritos.UseVisualStyleBackColor = False
        '
        'btnArtistaReproducion
        '
        Me.btnArtistaReproducion.BackColor = System.Drawing.Color.White
        Me.btnArtistaReproducion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArtistaReproducion.Location = New System.Drawing.Point(490, 279)
        Me.btnArtistaReproducion.Name = "btnArtistaReproducion"
        Me.btnArtistaReproducion.Size = New System.Drawing.Size(380, 38)
        Me.btnArtistaReproducion.TabIndex = 6
        Me.btnArtistaReproducion.Text = "Lista de Artista por Reproducción"
        Me.btnArtistaReproducion.UseVisualStyleBackColor = False
        '
        'btnCancionReproduccion
        '
        Me.btnCancionReproduccion.BackColor = System.Drawing.Color.White
        Me.btnCancionReproduccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancionReproduccion.Location = New System.Drawing.Point(490, 362)
        Me.btnCancionReproduccion.Name = "btnCancionReproduccion"
        Me.btnCancionReproduccion.Size = New System.Drawing.Size(380, 39)
        Me.btnCancionReproduccion.TabIndex = 7
        Me.btnCancionReproduccion.Text = "Lista de Canciones por reproducción"
        Me.btnCancionReproduccion.UseVisualStyleBackColor = False
        '
        'btnArtistaMasEscuchadoEnFecha
        '
        Me.btnArtistaMasEscuchadoEnFecha.BackColor = System.Drawing.Color.White
        Me.btnArtistaMasEscuchadoEnFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArtistaMasEscuchadoEnFecha.Location = New System.Drawing.Point(490, 446)
        Me.btnArtistaMasEscuchadoEnFecha.Name = "btnArtistaMasEscuchadoEnFecha"
        Me.btnArtistaMasEscuchadoEnFecha.Size = New System.Drawing.Size(380, 39)
        Me.btnArtistaMasEscuchadoEnFecha.TabIndex = 8
        Me.btnArtistaMasEscuchadoEnFecha.Text = "Lista Artistas Más Escuchados en Fecha"
        Me.btnArtistaMasEscuchadoEnFecha.UseVisualStyleBackColor = False
        '
        'F2_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(916, 797)
        Me.Controls.Add(Me.btnArtistaMasEscuchadoEnFecha)
        Me.Controls.Add(Me.btnCancionReproduccion)
        Me.Controls.Add(Me.btnArtistaReproducion)
        Me.Controls.Add(Me.btnArtistasFavoritos)
        Me.Controls.Add(Me.btnHistorial)
        Me.Controls.Add(Me.btnUsuario)
        Me.Controls.Add(Me.btnAccederArtista)
        Me.Name = "F2_Usuario"
        Me.Text = "F2_Usuario"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAccederArtista As Button
    Friend WithEvents btnUsuario As Button
    Friend WithEvents btnHistorial As Button
    Friend WithEvents btnArtistasFavoritos As Button
    Friend WithEvents btnArtistaReproducion As Button
    Friend WithEvents btnCancionReproduccion As Button
    Friend WithEvents btnArtistaMasEscuchadoEnFecha As Button
End Class
