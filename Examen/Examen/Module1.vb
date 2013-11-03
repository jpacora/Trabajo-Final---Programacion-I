Module Module1
    Public usuario, pass As String
    Public intentos, punteroAlumnos, punteroCursos, punteroNotas, punteroPromedio As Integer

    Public Structure strucAlumno
        Dim nombre As String
        Dim promedio As String
    End Structure
    Public Structure strucCurso
        Dim curso As String
    End Structure
    Public Structure strucNotas
        Dim nombre As String
        Dim promedio As Integer
        Dim curso As String
    End Structure
    Public Structure strucPromedio
        Dim nombre As String
        Dim promedio As Integer
        Dim estado As String
    End Structure

    Public alumnos(50) As strucAlumno
    Public cursos(50) As strucCurso
    Public notas(50) As strucNotas
    Public promedio(50) As strucPromedio

End Module
