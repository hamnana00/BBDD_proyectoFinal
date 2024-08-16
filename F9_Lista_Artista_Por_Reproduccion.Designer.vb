<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F9_Lista_Artista_Por_Reproduccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F9_Lista_Artista_Por_Reproduccion))
        Me.lstArtistaReproduccion = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.btnGeneral = New System.Windows.Forms.Button()
        Me.btnPais = New System.Windows.Forms.Button()
        Me.btnCambiarUsuario = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstArtistaReproduccion
        '
        Me.lstArtistaReproduccion.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstArtistaReproduccion.FormattingEnabled = True
        Me.lstArtistaReproduccion.ItemHeight = 21
        Me.lstArtistaReproduccion.Location = New System.Drawing.Point(313, 236)
        Me.lstArtistaReproduccion.Name = "lstArtistaReproduccion"
        Me.lstArtistaReproduccion.Size = New System.Drawing.Size(295, 256)
        Me.lstArtistaReproduccion.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(212, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pais"
        '
        'txtPais
        '
        Me.txtPais.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPais.Location = New System.Drawing.Point(210, 104)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(192, 29)
        Me.txtPais.TabIndex = 2
        '
        'btnGeneral
        '
        Me.btnGeneral.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGeneral.Location = New System.Drawing.Point(337, 171)
        Me.btnGeneral.Name = "btnGeneral"
        Me.btnGeneral.Size = New System.Drawing.Size(141, 47)
        Me.btnGeneral.TabIndex = 3
        Me.btnGeneral.Text = "General"
        Me.btnGeneral.UseVisualStyleBackColor = True
        '
        'btnPais
        '
        Me.btnPais.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPais.Location = New System.Drawing.Point(453, 101)
        Me.btnPais.Name = "btnPais"
        Me.btnPais.Size = New System.Drawing.Size(99, 32)
        Me.btnPais.TabIndex = 4
        Me.btnPais.Text = "Pais"
        Me.btnPais.UseVisualStyleBackColor = True
        '
        'btnCambiarUsuario
        '
        Me.btnCambiarUsuario.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarUsuario.Location = New System.Drawing.Point(12, 22)
        Me.btnCambiarUsuario.Name = "btnCambiarUsuario"
        Me.btnCambiarUsuario.Size = New System.Drawing.Size(179, 46)
        Me.btnCambiarUsuario.TabIndex = 5
        Me.btnCambiarUsuario.Text = "Cambiar usuario"
        Me.btnCambiarUsuario.UseVisualStyleBackColor = True
        '
        'F9_Lista_Artista_Por_Reproduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 531)
        Me.Controls.Add(Me.btnCambiarUsuario)
        Me.Controls.Add(Me.btnPais)
        Me.Controls.Add(Me.btnGeneral)
        Me.Controls.Add(Me.txtPais)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstArtistaReproduccion)
        Me.Name = "F9_Lista_Artista_Por_Reproduccion"
        Me.Text = "F9_Lista_Artista_Por_Reproduccion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstArtistaReproduccion As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPais As TextBox
    Friend WithEvents btnGeneral As Button
    Friend WithEvents btnPais As Button
    Friend WithEvents btnCambiarUsuario As Button
End Class
