Public Class Form2

    Private Sub reloj_Tick(sender As System.Object, e As System.EventArgs) Handles reloj.Tick
        hora.Text = Date.Now.ToLongTimeString
    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fecha.Text = DateTime.Now().ToString("dd/MM/yyyy")
    End Sub
    Private Sub Form2_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Form1.Close()
    End Sub

    Private Sub NotaFinalToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        calcNotaFinal.Show()
    End Sub

    Private Sub hora_Click(sender As System.Object, e As System.EventArgs) Handles hora.Click

    End Sub

    Private Sub PromedioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Form3.Show()
    End Sub

    Private Sub AlumnosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AlumnosToolStripMenuItem.Click
        ingresarAlumnos.Show()
    End Sub

    Private Sub CursosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CursosToolStripMenuItem.Click
        ingresarCursos.Show()
    End Sub

    Private Sub NotasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NotasToolStripMenuItem.Click
        ingresarNotas.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        'MsgBox("Creado por Jorge Pacora,  y Bruno Vega")
        Acerca.Show()
    End Sub

    Private Sub AlumonsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AlumonsToolStripMenuItem.Click
        ingresarAlumnos.Show()
    End Sub

    Private Sub NotasToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles NotasToolStripMenuItem1.Click
        listarNotas.Show()
    End Sub
End Class