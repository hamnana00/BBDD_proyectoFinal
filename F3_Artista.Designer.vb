<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F3_Artista
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F3_Artista))
        Me.btnCambiarUsuario = New System.Windows.Forms.Button()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.lstArtista = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIDArtista = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.picBoxImagen = New System.Windows.Forms.PictureBox()
        Me.txtImagen = New System.Windows.Forms.TextBox()
        Me.NoFavorito = New System.Windows.Forms.CheckBox()
        Me.SiFavorito = New System.Windows.Forms.CheckBox()
        CType(Me.picBoxImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCambiarUsuario
        '
        Me.btnCambiarUsuario.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarUsuario.Location = New System.Drawing.Point(23, 12)
        Me.btnCambiarUsuario.Name = "btnCambiarUsuario"
        Me.btnCambiarUsuario.Size = New System.Drawing.Size(164, 45)
        Me.btnCambiarUsuario.TabIndex = 1
        Me.btnCambiarUsuario.Text = "Cambiar Usuario"
        Me.btnCambiarUsuario.UseVisualStyleBackColor = True
        '
        'btnAnadir
        '
        Me.btnAnadir.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnadir.Location = New System.Drawing.Point(512, 187)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(110, 51)
        Me.btnAnadir.TabIndex = 5
        Me.btnAnadir.Text = "Añadir"
        Me.btnAnadir.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Location = New System.Drawing.Point(695, 187)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(110, 51)
        Me.btnActualizar.TabIndex = 6
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(512, 314)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(110, 50)
        Me.btnLimpiar.TabIndex = 7
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(695, 314)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(110, 50)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'lstArtista
        '
        Me.lstArtista.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstArtista.FormattingEnabled = True
        Me.lstArtista.ItemHeight = 21
        Me.lstArtista.Location = New System.Drawing.Point(33, 101)
        Me.lstArtista.Name = "lstArtista"
        Me.lstArtista.Size = New System.Drawing.Size(154, 340)
        Me.lstArtista.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(214, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "IDArtista:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(228, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 23)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(228, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 23)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "País:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(228, 325)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 23)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Imagen:"
        '
        'txtIDArtista
        '
        Me.txtIDArtista.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDArtista.Location = New System.Drawing.Point(332, 101)
        Me.txtIDArtista.Name = "txtIDArtista"
        Me.txtIDArtista.Size = New System.Drawing.Size(149, 29)
        Me.txtIDArtista.TabIndex = 14
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(329, 176)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(149, 29)
        Me.txtNombre.TabIndex = 15
        '
        'txtPais
        '
        Me.txtPais.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPais.Location = New System.Drawing.Point(329, 254)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(149, 29)
        Me.txtPais.TabIndex = 16
        '
        'picBoxImagen
        '
        Me.picBoxImagen.Location = New System.Drawing.Point(292, 450)
        Me.picBoxImagen.Name = "picBoxImagen"
        Me.picBoxImagen.Size = New System.Drawing.Size(318, 242)
        Me.picBoxImagen.TabIndex = 17
        Me.picBoxImagen.TabStop = False
        '
        'txtImagen
        '
        Me.txtImagen.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImagen.Location = New System.Drawing.Point(329, 335)
        Me.txtImagen.Name = "txtImagen"
        Me.txtImagen.Size = New System.Drawing.Size(149, 29)
        Me.txtImagen.TabIndex = 19
        '
        'NoFavorito
        '
        Me.NoFavorito.AutoSize = True
        Me.NoFavorito.Location = New System.Drawing.Point(687, 107)
        Me.NoFavorito.Name = "NoFavorito"
        Me.NoFavorito.Size = New System.Drawing.Size(118, 17)
        Me.NoFavorito.TabIndex = 4
        Me.NoFavorito.Text = "Desmarcar Favorito"
        Me.NoFavorito.UseVisualStyleBackColor = True
        '
        'SiFavorito
        '
        Me.SiFavorito.AutoSize = True
        Me.SiFavorito.Location = New System.Drawing.Point(510, 107)
        Me.SiFavorito.Name = "SiFavorito"
        Me.SiFavorito.Size = New System.Drawing.Size(100, 17)
        Me.SiFavorito.TabIndex = 3
        Me.SiFavorito.Text = "Marcar Favorito"
        Me.SiFavorito.UseVisualStyleBackColor = True
        '
        'F3_Artista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(912, 731)
        Me.Controls.Add(Me.txtImagen)
        Me.Controls.Add(Me.picBoxImagen)
        Me.Controls.Add(Me.txtPais)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtIDArtista)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstArtista)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnAnadir)
        Me.Controls.Add(Me.NoFavorito)
        Me.Controls.Add(Me.SiFavorito)
        Me.Controls.Add(Me.btnCambiarUsuario)
        Me.Name = "F3_Artista"
        Me.Text = "F3_Artista"
        CType(Me.picBoxImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCambiarUsuario As Button
    Friend WithEvents btnAnadir As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents lstArtista As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIDArtista As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPais As TextBox
    Friend WithEvents picBoxImagen As PictureBox
    Friend WithEvents txtImagen As TextBox
    Friend WithEvents NoFavorito As CheckBox
    Friend WithEvents SiFavorito As CheckBox
End Class
