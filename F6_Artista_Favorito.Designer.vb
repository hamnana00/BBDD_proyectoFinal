<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F6_Artista_Favorito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F6_Artista_Favorito))
        Me.btnCambiarUsuario = New System.Windows.Forms.Button()
        Me.lstArtistaFavorito = New System.Windows.Forms.ListBox()
        Me.btnAbrirBD = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtMinutosReproduccion = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCambiarUsuario
        '
        Me.btnCambiarUsuario.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarUsuario.Location = New System.Drawing.Point(37, 22)
        Me.btnCambiarUsuario.Name = "btnCambiarUsuario"
        Me.btnCambiarUsuario.Size = New System.Drawing.Size(161, 34)
        Me.btnCambiarUsuario.TabIndex = 0
        Me.btnCambiarUsuario.Text = "Cambiar Usuario"
        Me.btnCambiarUsuario.UseVisualStyleBackColor = True
        '
        'lstArtistaFavorito
        '
        Me.lstArtistaFavorito.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstArtistaFavorito.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstArtistaFavorito.FormattingEnabled = True
        Me.lstArtistaFavorito.ItemHeight = 21
        Me.lstArtistaFavorito.Location = New System.Drawing.Point(37, 127)
        Me.lstArtistaFavorito.Name = "lstArtistaFavorito"
        Me.lstArtistaFavorito.Size = New System.Drawing.Size(194, 466)
        Me.lstArtistaFavorito.TabIndex = 1
        '
        'btnAbrirBD
        '
        Me.btnAbrirBD.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbrirBD.Location = New System.Drawing.Point(37, 72)
        Me.btnAbrirBD.Name = "btnAbrirBD"
        Me.btnAbrirBD.Size = New System.Drawing.Size(119, 39)
        Me.btnAbrirBD.TabIndex = 2
        Me.btnAbrirBD.Text = "AbrirBD"
        Me.btnAbrirBD.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(285, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(189, 54)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Mirar tiempo de reproducción"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtMinutosReproduccion
        '
        Me.txtMinutosReproduccion.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinutosReproduccion.Location = New System.Drawing.Point(524, 171)
        Me.txtMinutosReproduccion.Name = "txtMinutosReproduccion"
        Me.txtMinutosReproduccion.Size = New System.Drawing.Size(162, 29)
        Me.txtMinutosReproduccion.TabIndex = 4
        '
        'F6_Artista_Favorito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(877, 694)
        Me.Controls.Add(Me.txtMinutosReproduccion)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAbrirBD)
        Me.Controls.Add(Me.lstArtistaFavorito)
        Me.Controls.Add(Me.btnCambiarUsuario)
        Me.Name = "F6_Artista_Favorito"
        Me.Text = "F6_Artista_Favorito"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCambiarUsuario As Button
    Friend WithEvents lstArtistaFavorito As ListBox
    Friend WithEvents btnAbrirBD As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtMinutosReproduccion As TextBox
End Class
