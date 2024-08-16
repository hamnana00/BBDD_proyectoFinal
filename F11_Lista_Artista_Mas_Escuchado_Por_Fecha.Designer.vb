<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F11_Lista_Artista_Mas_Escuchado_Por_Fecha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F11_Lista_Artista_Mas_Escuchado_Por_Fecha))
        Me.btnAbrirUsuario = New System.Windows.Forms.Button()
        Me.lstArtistas = New System.Windows.Forms.ListBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtFechaInicio = New System.Windows.Forms.TextBox()
        Me.txtFechaFin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAbrirUsuario
        '
        Me.btnAbrirUsuario.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbrirUsuario.Location = New System.Drawing.Point(23, 12)
        Me.btnAbrirUsuario.Name = "btnAbrirUsuario"
        Me.btnAbrirUsuario.Size = New System.Drawing.Size(166, 35)
        Me.btnAbrirUsuario.TabIndex = 1
        Me.btnAbrirUsuario.Text = "Cambiar Usuario"
        Me.btnAbrirUsuario.UseVisualStyleBackColor = True
        '
        'lstArtistas
        '
        Me.lstArtistas.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstArtistas.FormattingEnabled = True
        Me.lstArtistas.ItemHeight = 21
        Me.lstArtistas.Location = New System.Drawing.Point(23, 111)
        Me.lstArtistas.Name = "lstArtistas"
        Me.lstArtistas.Size = New System.Drawing.Size(220, 277)
        Me.lstArtistas.TabIndex = 2
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(658, 293)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 48)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtFechaInicio
        '
        Me.txtFechaInicio.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaInicio.Location = New System.Drawing.Point(458, 127)
        Me.txtFechaInicio.Name = "txtFechaInicio"
        Me.txtFechaInicio.Size = New System.Drawing.Size(139, 29)
        Me.txtFechaInicio.TabIndex = 4
        '
        'txtFechaFin
        '
        Me.txtFechaFin.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaFin.Location = New System.Drawing.Point(458, 216)
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Size = New System.Drawing.Size(139, 29)
        Me.txtFechaFin.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(327, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fecha Inicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(327, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Fecha Fin"
        '
        'F11_Lista_Artista_Mas_Escuchado_Por_Fecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(832, 573)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFechaFin)
        Me.Controls.Add(Me.txtFechaInicio)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lstArtistas)
        Me.Controls.Add(Me.btnAbrirUsuario)
        Me.Name = "F11_Lista_Artista_Mas_Escuchado_Por_Fecha"
        Me.Text = "F11_Lista_Artista_Mas_Escuchado_Por_Fecha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAbrirUsuario As Button
    Friend WithEvents lstArtistas As ListBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtFechaInicio As TextBox
    Friend WithEvents txtFechaFin As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
