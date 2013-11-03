Public Class listadoFinal

    Private Sub listadoFinal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim p As Integer
        Dim name As String
        For X = 0 To alumnos.Length - 1
            If Not alumnos(X).nombre Is Nothing Then
                name = alumnos(X).nombre
                'Iteramos una vez mas para sacar el promedio
                For Y = 0 To notas.Length - 1
                    If Not notas(Y).nombre Is Nothing Then
                        If notas(Y).nombre = alumnos(X).nombre Then
                            promedio(name).promedio = promedio(name).promedio + notas(Y).promedio
                        End If
                    End If
                Next
                MsgBox("Promedio de: " + alumnos(X).nombre + "es: " + promedio(name).promedio)
            End If
        Next
    End Sub
End Class