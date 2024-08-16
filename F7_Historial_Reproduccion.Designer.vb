<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F7_Historial_Reproduccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F7_Historial_Reproduccion))
        Me.btnCambiarUsuario = New System.Windows.Forms.Button()
        Me.listReproduccion = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIDReproduccion = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtCancion = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCambiarUsuario
        '
        Me.btnCambiarUsuario.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarUsuario.Location = New System.Drawing.Point(30, 27)
        Me.btnCambiarUsuario.Name = "btnCambiarUsuario"
        Me.btnCambiarUsuario.Size = New System.Drawing.Size(175, 41)
        Me.btnCambiarUsuario.TabIndex = 0
        Me.btnCambiarUsuario.Text = "Cambiar Usuario"
        Me.btnCambiarUsuario.UseVisualStyleBackColor = True
        '
        'listReproduccion
        '
        Me.listReproduccion.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listReproduccion.FormattingEnabled = True
        Me.listReproduccion.ItemHeight = 21
        Me.listReproduccion.Location = New System.Drawing.Point(30, 114)
        Me.listReproduccion.Name = "listReproduccion"
        Me.listReproduccion.Size = New System.Drawing.Size(208, 361)
        Me.listReproduccion.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(255, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "IDReproducción:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(255, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Usuario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(255, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Canción:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(255, 307)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha:"
        '
        'txtIDReproduccion
        '
        Me.txtIDReproduccion.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDReproduccion.Location = New System.Drawing.Point(424, 114)
        Me.txtIDReproduccion.Name = "txtIDReproduccion"
        Me.txtIDReproduccion.Size = New System.Drawing.Size(254, 29)
        Me.txtIDReproduccion.TabIndex = 7
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(424, 180)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(254, 29)
        Me.txtUsuario.TabIndex = 8
        '
        'txtCancion
        '
        Me.txtCancion.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCancion.Location = New System.Drawing.Point(424, 246)
        Me.txtCancion.Name = "txtCancion"
        Me.txtCancion.Size = New System.Drawing.Size(254, 29)
        Me.txtCancion.TabIndex = 9
        '
        'txtFecha
        '
        Me.txtFecha.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(424, 307)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(254, 29)
        Me.txtFecha.TabIndex = 10
        '
        'F7_Historial_Reproduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(855, 738)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtCancion)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtIDReproduccion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listReproduccion)
        Me.Controls.Add(Me.btnCambiarUsuario)
        Me.Name = "F7_Historial_Reproduccion"
        Me.Text = "F7_Historial_Reproduccion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCambiarUsuario As Button
    Friend WithEvents listReproduccion As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIDReproduccion As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtCancion As TextBox
    Friend WithEvents txtFecha As TextBox
End Class
