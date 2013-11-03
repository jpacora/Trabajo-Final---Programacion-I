Public Class ingresarCursos

    Private Sub ingresarCursos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim x As Integer
        For x = 0 To 5
            If Not cursos(x).curso Is Nothing Then
                ListBox1.Items.Add(cursos(x).curso)
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        cursos(punteroCursos).curso = txtName.Text
        punteroCursos = punteroCursos + 1
        ListBox1.Items.Add(txtName.Text)
        txtName.Text = ""
        txtName.Focus()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
        For x = 0 To 5
            MsgBox(cursos(x).curso)
            'MsgBox("Hola")
        Next
    End Sub
End Class