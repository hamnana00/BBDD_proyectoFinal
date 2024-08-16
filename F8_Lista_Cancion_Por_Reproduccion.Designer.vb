<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F8_Lista_Cancion_Por_Reproduccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F8_Lista_Cancion_Por_Reproduccion))
        Me.btnAbrirUsuario = New System.Windows.Forms.Button()
        Me.lstCancionReproduccion = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnAbrirUsuario
        '
        Me.btnAbrirUsuario.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbrirUsuario.Location = New System.Drawing.Point(30, 25)
        Me.btnAbrirUsuario.Name = "btnAbrirUsuario"
        Me.btnAbrirUsuario.Size = New System.Drawing.Size(189, 39)
        Me.btnAbrirUsuario.TabIndex = 0
        Me.btnAbrirUsuario.Text = "Cambiar Usuario"
        Me.btnAbrirUsuario.UseVisualStyleBackColor = True
        '
        'lstCancionReproduccion
        '
        Me.lstCancionReproduccion.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCancionReproduccion.FormattingEnabled = True
        Me.lstCancionReproduccion.ItemHeight = 21
        Me.lstCancionReproduccion.Location = New System.Drawing.Point(30, 102)
        Me.lstCancionReproduccion.Name = "lstCancionReproduccion"
        Me.lstCancionReproduccion.Size = New System.Drawing.Size(351, 382)
        Me.lstCancionReproduccion.TabIndex = 1
        '
        'F8_Lista_Cancion_Por_Reproduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(797, 577)
        Me.Controls.Add(Me.lstCancionReproduccion)
        Me.Controls.Add(Me.btnAbrirUsuario)
        Me.Name = "F8_Lista_Cancion_Por_Reproduccion"
        Me.Text = "F8_Lista_Cancion_Por_Reproduccion"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAbrirUsuario As Button
    Friend WithEvents lstCancionReproduccion As ListBox
End Class
