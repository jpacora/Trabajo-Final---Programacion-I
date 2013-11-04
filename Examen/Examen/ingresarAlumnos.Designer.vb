<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ingresarAlumnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ingresarAlumnos))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(381, 27)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(235, 279)
        Me.ListBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(97, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre del alumno:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(65, 65)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(279, 31)
        Me.txtName.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Button1.BackgroundImage = Global.ProyectoFinal.My.Resources.Resources._1button
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(119, 111)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 45)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Añadir Alumno ->"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ingresarAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(644, 362)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "ingresarAlumnos"
        Me.Text = "Ingresar Alumnos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
