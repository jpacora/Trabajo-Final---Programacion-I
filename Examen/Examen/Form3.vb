Public Class Form3

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim name As String
        Dim nota1, nota2, nota3, suma, promedio As Integer
        name = TextBox2.Text
        nota1 = TextBox3.Text
        nota2 = TextBox4.Text
        nota3 = TextBox5.Text
        suma = nota1 + nota2 + nota3
        promedio = suma / 3

        'alumnos(puntero, 1) = nota1
        'alumnos(puntero, 2) = nota2
        'alumnos(puntero, 3) = nota3
        TextBox6.Text = promedio
        'puntero = puntero + 1
    End Sub

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'puntero = 0
    End Sub
End Class