<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IngresoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CursosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlumonsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CursosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.reloj = New System.Windows.Forms.Timer(Me.components)
        Me.hora = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ConsolidadoFinalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresoToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(584, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'IngresoToolStripMenuItem
        '
        Me.IngresoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlumnosToolStripMenuItem, Me.CursosToolStripMenuItem, Me.NotasToolStripMenuItem})
        Me.IngresoToolStripMenuItem.Image = CType(resources.GetObject("IngresoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IngresoToolStripMenuItem.Name = "IngresoToolStripMenuItem"
        Me.IngresoToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.IngresoToolStripMenuItem.Text = "I&ngreso"
        '
        'AlumnosToolStripMenuItem
        '
        Me.AlumnosToolStripMenuItem.Image = CType(resources.GetObject("AlumnosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AlumnosToolStripMenuItem.Name = "AlumnosToolStripMenuItem"
        Me.AlumnosToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.AlumnosToolStripMenuItem.Text = "A&lumnos"
        '
        'CursosToolStripMenuItem
        '
        Me.CursosToolStripMenuItem.Image = CType(resources.GetObject("CursosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CursosToolStripMenuItem.Name = "CursosToolStripMenuItem"
        Me.CursosToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.CursosToolStripMenuItem.Text = "Cu&rsos"
        '
        'NotasToolStripMenuItem
        '
        Me.NotasToolStripMenuItem.Image = CType(resources.GetObject("NotasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NotasToolStripMenuItem.Name = "NotasToolStripMenuItem"
        Me.NotasToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.NotasToolStripMenuItem.Text = "&Notas"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlumonsToolStripMenuItem, Me.NotasToolStripMenuItem1, Me.CursosToolStripMenuItem1, Me.ConsolidadoFinalToolStripMenuItem})
        Me.ConsultarToolStripMenuItem.Image = CType(resources.GetObject("ConsultarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.ConsultarToolStripMenuItem.Text = "Con&sultar"
        '
        'AlumonsToolStripMenuItem
        '
        Me.AlumonsToolStripMenuItem.Image = CType(resources.GetObject("AlumonsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AlumonsToolStripMenuItem.Name = "AlumonsToolStripMenuItem"
        Me.AlumonsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AlumonsToolStripMenuItem.Text = "Alu&mnos"
        '
        'NotasToolStripMenuItem1
        '
        Me.NotasToolStripMenuItem1.Image = CType(resources.GetObject("NotasToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.NotasToolStripMenuItem1.Name = "NotasToolStripMenuItem1"
        Me.NotasToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.NotasToolStripMenuItem1.Text = "&Notas"
        '
        'CursosToolStripMenuItem1
        '
        Me.CursosToolStripMenuItem1.Image = CType(resources.GetObject("CursosToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.CursosToolStripMenuItem1.Name = "CursosToolStripMenuItem1"
        Me.CursosToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.CursosToolStripMenuItem1.Text = "Cur&sos"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Image = CType(resources.GetObject("AyudaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.AyudaToolStripMenuItem.Text = "&Ayuda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Ac&erca de..."
        '
        'reloj
        '
        Me.reloj.Enabled = True
        '
        'hora
        '
        Me.hora.AutoSize = True
        Me.hora.BackColor = System.Drawing.Color.Transparent
        Me.hora.Location = New System.Drawing.Point(381, 171)
        Me.hora.Name = "hora"
        Me.hora.Size = New System.Drawing.Size(58, 25)
        Me.hora.TabIndex = 1
        Me.hora.Text = "Hora"
        '
        'fecha
        '
        Me.fecha.AutoSize = True
        Me.fecha.BackColor = System.Drawing.Color.Transparent
        Me.fecha.Location = New System.Drawing.Point(381, 220)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(72, 25)
        Me.fecha.TabIndex = 2
        Me.fecha.Text = "Fecha"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 153)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(140, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(436, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Universidad Privada deTacna"
        '
        'ConsolidadoFinalToolStripMenuItem
        '
        Me.ConsolidadoFinalToolStripMenuItem.Name = "ConsolidadoFinalToolStripMenuItem"
        Me.ConsolidadoFinalToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ConsolidadoFinalToolStripMenuItem.Text = "Consolidado Final"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(584, 320)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.hora)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UPT"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents IngresoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlumnosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CursosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlumonsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CursosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents reloj As System.Windows.Forms.Timer
    Friend WithEvents hora As System.Windows.Forms.Label
    Friend WithEvents fecha As System.Windows.Forms.Label
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ConsolidadoFinalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
