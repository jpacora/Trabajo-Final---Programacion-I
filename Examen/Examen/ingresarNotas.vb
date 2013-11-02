Public Class ingresarNotas

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btn_guardar.Click
        notas(punteroNotas).nombre = ComboBox1.Text
        notas(punteroNotas).curso = ComboBox2.Text
        notas(punteroNotas).promedio = input_promedio.Text
        punteroNotas = punteroNotas + 1
        MsgBox("Notas agregadas satisfactoriamente!")
        'Reseteamos el formulario y lo vaciamos
        btn_guardar.Enabled = False
        btn_calcular.Enabled = True
        input_nota1.Text = ""
        input_nota2.Text = ""
        input_nota3.Text = ""
        input_promedio.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""

    End Sub

    Private Sub ingresarNotas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btn_guardar.Enabled = False
        For x = 0 To 5
            If Not alumnos(x).nombre Is Nothing Then
                ComboBox1.Items.Add(alumnos(x).nombre)
            End If
            If Not cursos(x).curso Is Nothing Then
                ComboBox2.Items.Add(cursos(x).curso)
            End If
        Next
    End Sub

    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        Dim nota1, nota2, nota3, promedio As Integer
        nota1 = input_nota1.Text
        nota2 = input_nota2.Text
        nota3 = input_nota3.Text
        promedio = (nota1 + nota2 + nota3) / 3
        input_promedio.Text = promedio
        btn_calcular.Enabled = False
        btn_guardar.Enabled = True
    End Sub
End Class