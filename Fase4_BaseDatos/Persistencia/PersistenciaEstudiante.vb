
Public Class PersistenciaEstudiante

    Function InsertarEstudiante(estudiante As Estudiante) As TransaccionBD
        Dim mensajes As New List(Of String)
        Dim resultadoInsertar As Integer = 0

        Dim adapter As New tallerDBLocalDataSetTableAdapters.EstudiantesTableAdapter

        Dim estudianteBD = adapter.GetDataBy(Long.Parse(estudiante.Identificacion))
        If Not estudianteBD.Rows.Count().Equals(0) Then
            mensajes.Add("Ya existe un estudiante con esta identificación, debe ingresar y actualizar los datos.")
        Else
            Try
                resultadoInsertar = adapter.Insert(estudiante.Identificacion,
                                                      estudiante.Nombre,
                                                      estudiante.Apellido,
                                                      estudiante.Correo,
                                                      estudiante.Telefono,
                                                      estudiante.Escuela,
                                                      estudiante.Contrasena)


                If resultadoInsertar.Equals(0) Then
                    mensajes.Add("No se ha podido crear el estudiante")
                End If
            Catch ex As Exception
                mensajes.Add(ex.Message)
            End Try
        End If

        Dim respuesta As New TransaccionBD
        respuesta.Resultado = mensajes.Count.Equals(0)
        respuesta.Errores = mensajes

        Return respuesta
    End Function

    Shared Function IniciarSesion(identificacion As String, contrasena As String) As TransaccionBD
        Dim resultado As New TransaccionBD
        Dim adapter As New tallerDBLocalDataSetTableAdapters.EstudiantesTableAdapter

        Dim estudianteBD = adapter.GetDataBy(Long.Parse(identificacion))
        If estudianteBD.Rows.Count.Equals(0) Then
            resultado.Errores.Add("No existe usuario con esa identificación")
        Else
            Dim _contrasena = estudianteBD.Rows(0).Field(Of String)("contrasena")
            If Not _contrasena.Equals(contrasena) Then
                resultado.Errores.Add("La contraseña no coincide.")
            End If
        End If

        resultado.Resultado = resultado.Errores.Count.Equals(0)

        Return resultado
    End Function
End Class
