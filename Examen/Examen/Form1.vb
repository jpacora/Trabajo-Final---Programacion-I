Public Class Form1

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If (UserBox.Text = usuario And PassBox.Text = pass) Then
            Me.Hide()
            MsgBox("Bienvenido!")
            Form2.Show()
        Else
            MsgBox("Datos incorrectos")
            intentos = intentos + 1
            If intentos = 3 Then
                UserBox.Enabled = False
                PassBox.Enabled = False
                Button1.Enabled = False
            End If
            lblVces.Text = intentos
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        UserBox.Focus()
        usuario = "admin"
        pass = "admin123"
        intentos = 0
    End Sub

    Private Sub PassBox_TextChanged(sender As Object, e As EventArgs) Handles PassBox.TextChanged

    End Sub
End Class
