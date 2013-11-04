Public Class ingresarAlumnos

    Private Sub ingresarAlumnos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim x As Integer
        For x = 0 To 5
            If Not alumnos(x).nombre Is Nothing Then
                ListBox1.Items.Add(alumnos(x).nombre)
            End If
        Next
    End Sub
    Private Sub Button1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown
        Button1.BackgroundImage = My.Resources._1button_click
    End Sub
    Private Sub Button1_MouseEnter(ByVal Sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Button1.BackgroundImage = My.Resources._1button_hover
    End Sub
    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackgroundImage = My.Resources._1button
    End Sub
    Private Sub Button1_MouseUp(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseUp
        Button1.BackgroundImage = My.Resources._1button_hover
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        alumnos(punteroAlumnos).nombre = txtName.Text
        punteroAlumnos = punteroAlumnos + 1
        ListBox1.Items.Add(txtName.Text)
        txtName.Text = ""
        txtName.Focus()
    End Sub
End Class