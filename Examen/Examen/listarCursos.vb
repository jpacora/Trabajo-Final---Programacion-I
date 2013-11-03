Public Class listarCursos

    Private Sub listarCursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Integer
        For x = 0 To 5
            If Not alumnos(x).nombre Is Nothing Then
                ListBox1.Items.Add(cursos(x).curso)
            End If
        Next
    End Sub
End Class