Public Class Form1
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
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseDown
        Button2.BackgroundImage = My.Resources._1button_click
    End Sub
    Private Sub Button2_MouseEnter(ByVal Sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Button2.BackgroundImage = My.Resources._1button_hover
    End Sub
    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.BackgroundImage = My.Resources._1button
    End Sub
    Private Sub Button2_MouseUp(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseUp
        Button2.BackgroundImage = My.Resources._1button_hover
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
