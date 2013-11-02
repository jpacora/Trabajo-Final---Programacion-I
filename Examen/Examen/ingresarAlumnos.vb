Public Class ingresarAlumnos

    Private Sub ingresarAlumnos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim x As Integer
        For x = 0 To 5
            If Not alumnos(x).nombre Is Nothing Then
                ListBox1.Items.Add(alumnos(x).nombre)
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        alumnos(punteroAlumnos).nombre = txtName.Text
        punteroAlumnos = punteroAlumnos + 1
        ListBox1.Items.Add(txtName.Text)
        txtName.Text = ""
        txtName.Focus()
    End Sub
End Class