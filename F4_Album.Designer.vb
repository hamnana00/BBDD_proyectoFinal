<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F4_Album
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F4_Album))
        Me.btnCambiarUsuario = New System.Windows.Forms.Button()
        Me.lstAlbum = New System.Windows.Forms.ListBox()
        Me.picBoxPortada = New System.Windows.Forms.PictureBox()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIDAlbum = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtArtista = New System.Windows.Forms.TextBox()
        Me.txtPortada = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDuracionAlbum = New System.Windows.Forms.TextBox()
        CType(Me.picBoxPortada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCambiarUsuario
        '
        Me.btnCambiarUsuario.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarUsuario.Location = New System.Drawing.Point(31, 12)
        Me.btnCambiarUsuario.Name = "btnCambiarUsuario"
        Me.btnCambiarUsuario.Size = New System.Drawing.Size(174, 40)
        Me.btnCambiarUsuario.TabIndex = 0
        Me.btnCambiarUsuario.Text = "Cambiar Usuario"
        Me.btnCambiarUsuario.UseVisualStyleBackColor = True
        '
        'lstAlbum
        '
        Me.lstAlbum.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAlbum.FormattingEnabled = True
        Me.lstAlbum.ItemHeight = 21
        Me.lstAlbum.Location = New System.Drawing.Point(31, 88)
        Me.lstAlbum.Name = "lstAlbum"
        Me.lstAlbum.Size = New System.Drawing.Size(174, 361)
        Me.lstAlbum.TabIndex = 2
        '
        'picBoxPortada
        '
        Me.picBoxPortada.Location = New System.Drawing.Point(519, 388)
        Me.picBoxPortada.Name = "picBoxPortada"
        Me.picBoxPortada.Size = New System.Drawing.Size(357, 280)
        Me.picBoxPortada.TabIndex = 3
        Me.picBoxPortada.TabStop = False
        '
        'btnAnadir
        '
        Me.btnAnadir.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnadir.Location = New System.Drawing.Point(639, 88)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(112, 50)
        Me.btnAnadir.TabIndex = 5
        Me.btnAnadir.Text = "Añadir"
        Me.btnAnadir.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Location = New System.Drawing.Point(639, 164)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(112, 50)
        Me.btnActualizar.TabIndex = 6
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(639, 247)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(112, 50)
        Me.btnEliminar.TabIndex = 7
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(639, 319)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(112, 51)
        Me.btnLimpiar.TabIndex = 8
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(214, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "IDAlbum:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(214, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(213, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 23)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(213, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 23)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Artista:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(213, 347)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 23)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Portada:"
        '
        'txtIDAlbum
        '
        Me.txtIDAlbum.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDAlbum.Location = New System.Drawing.Point(321, 100)
        Me.txtIDAlbum.Name = "txtIDAlbum"
        Me.txtIDAlbum.Size = New System.Drawing.Size(174, 29)
        Me.txtIDAlbum.TabIndex = 14
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(321, 151)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(174, 29)
        Me.txtNombre.TabIndex = 15
        '
        'txtFecha
        '
        Me.txtFecha.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(321, 211)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(174, 29)
        Me.txtFecha.TabIndex = 16
        '
        'txtArtista
        '
        Me.txtArtista.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArtista.Location = New System.Drawing.Point(321, 273)
        Me.txtArtista.Name = "txtArtista"
        Me.txtArtista.Size = New System.Drawing.Size(174, 29)
        Me.txtArtista.TabIndex = 17
        '
        'txtPortada
        '
        Me.txtPortada.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPortada.Location = New System.Drawing.Point(321, 341)
        Me.txtPortada.Name = "txtPortada"
        Me.txtPortada.Size = New System.Drawing.Size(174, 29)
        Me.txtPortada.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(214, 419)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 23)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Duración:"
        '
        'txtDuracionAlbum
        '
        Me.txtDuracionAlbum.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuracionAlbum.Location = New System.Drawing.Point(321, 413)
        Me.txtDuracionAlbum.Name = "txtDuracionAlbum"
        Me.txtDuracionAlbum.Size = New System.Drawing.Size(174, 29)
        Me.txtDuracionAlbum.TabIndex = 20
        '
        'F4_Album
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(918, 733)
        Me.Controls.Add(Me.txtDuracionAlbum)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPortada)
        Me.Controls.Add(Me.txtArtista)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtIDAlbum)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnAnadir)
        Me.Controls.Add(Me.picBoxPortada)
        Me.Controls.Add(Me.lstAlbum)
        Me.Controls.Add(Me.btnCambiarUsuario)
        Me.Name = "F4_Album"
        Me.Text = "F4_Album"
        CType(Me.picBoxPortada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCambiarUsuario As Button
    Friend WithEvents lstAlbum As ListBox
    Friend WithEvents picBoxPortada As PictureBox
    Friend WithEvents btnAnadir As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIDAlbum As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtArtista As TextBox
    Friend WithEvents txtPortada As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDuracionAlbum As TextBox
End Class
