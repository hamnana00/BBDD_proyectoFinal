<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F12_Usuario_Mas_Activo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F12_Usuario_Mas_Activo))
        Me.btnAbrirUsuario = New System.Windows.Forms.Button()
        Me.lstUsuarioActivo = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTiempoReproduccion = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAbrirUsuario
        '
        Me.btnAbrirUsuario.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbrirUsuario.Location = New System.Drawing.Point(83, 72)
        Me.btnAbrirUsuario.Name = "btnAbrirUsuario"
        Me.btnAbrirUsuario.Size = New System.Drawing.Size(173, 35)
        Me.btnAbrirUsuario.TabIndex = 0
        Me.btnAbrirUsuario.Text = "Cambiar Usuario"
        Me.btnAbrirUsuario.UseVisualStyleBackColor = True
        '
        'lstUsuarioActivo
        '
        Me.lstUsuarioActivo.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstUsuarioActivo.FormattingEnabled = True
        Me.lstUsuarioActivo.ItemHeight = 21
        Me.lstUsuarioActivo.Location = New System.Drawing.Point(83, 187)
        Me.lstUsuarioActivo.Name = "lstUsuarioActivo"
        Me.lstUsuarioActivo.Size = New System.Drawing.Size(202, 256)
        Me.lstUsuarioActivo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(360, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tiempo de reproducción"
        '
        'txtTiempoReproduccion
        '
        Me.txtTiempoReproduccion.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTiempoReproduccion.Location = New System.Drawing.Point(364, 153)
        Me.txtTiempoReproduccion.Name = "txtTiempoReproduccion"
        Me.txtTiempoReproduccion.Size = New System.Drawing.Size(206, 29)
        Me.txtTiempoReproduccion.TabIndex = 3
        '
        'F12_Usuario_Mas_Activo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(703, 640)
        Me.Controls.Add(Me.txtTiempoReproduccion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstUsuarioActivo)
        Me.Controls.Add(Me.btnAbrirUsuario)
        Me.Name = "F12_Usuario_Mas_Activo"
        Me.Text = "F12_Usuario_Mas_Activo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAbrirUsuario As Button
    Friend WithEvents lstUsuarioActivo As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTiempoReproduccion As TextBox
End Class
