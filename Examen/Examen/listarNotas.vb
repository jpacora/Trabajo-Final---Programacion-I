Public Class listarNotas

    Private Sub listarNotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim status As String
        dtgv_notas.Columns.Add("", "Nombre")
        dtgv_notas.Columns.Add("", "Curso")
        dtgv_notas.Columns.Add("", "Promedio")
        dtgv_notas.Columns.Add("", "Estado")
        For X = 0 To notas.Length - 1
            If Not notas(X).nombre Is Nothing Then
                'Agregamos una fila
                dtgv_notas.Rows.Add(1)
                'Asignamos un valor a la fila en la columna 0
                dtgv_notas.Item(0, X).Value = notas(X).nombre
                dtgv_notas.Item(1, X).Value = notas(X).curso
                dtgv_notas.Item(2, X).Value = notas(X).promedio
                If notas(X).promedio >= 11 Then
                    status = "Aprobado"
                Else
                    status = "Desaprobado"
                End If
                dtgv_notas.Item(3, X).Value = status
            End If
        Next
    End Sub
End Class