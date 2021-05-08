Public Class Registro
    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TallerDBLocalDataSet1.EstudiantesTabla' table. You can move, or remove it, as needed.
        Me.EstudiantesTablaTableAdapter.Fill(Me.TallerDBLocalDataSet1.EstudiantesTabla)
        'TODO: This line of code loads data into the 'TallerDBLocalDataSet.Escuelas' table. You can move, or remove it, as needed.
        Me.EscuelasTableAdapter.Fill(Me.TallerDBLocalDataSet.Escuelas)

    End Sub

    Private Sub txtIdentificacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdentificacion.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ValidarDatos() Then
            Dim estudiante As New Estudiante

            estudiante.Identificacion = txtIdentificacion.Text
            estudiante.Nombre = txtNombre.Text
            estudiante.Apellido = txtApellido.Text
            estudiante.Correo = txtCorreo.Text
            estudiante.Escuela = cmbEscuela.SelectedValue
            estudiante.Contrasena = Encriptar.Encriptar(txtPassword.Text)
            Dim persistir As New PersistenciaEstudiante
            Dim resultado = persistir.InsertarEstudiante(estudiante)
            If resultado.Resultado Then
                MessageBox.Show("Estudiante Creado", "Proceso exitoso")
                Me.Close()
            Else
                MessageBox.Show(String.Join("\n", resultado.Errores), "Error al guardar")
            End If

        End If
    End Sub

    Private Function ValidarDatos() As Boolean
        lblRequeridos.Visible = False

        ValidarContenido(txtApellido, lblRequeridoApellido)
        ValidarContenido(txtCorreo, lblRequeridoCorreo)
        ValidarContenido(txtIdentificacion, lblRequeridoIdentificacion)
        ValidarContenido(txtNombre, lblRequeridoNombre)
        ValidarContenido(txtTelefono, lblRequeridoTelefono)
        ValidarContenido(txtPassword, lblRequeridoPassword)
        ValidarContenido(txtPasswordConfirmacion, lblRequeridoPasswordConfirmar)

        If cmbEscuela.SelectedItem Is Nothing Then
            lblRequeridoEscuela.Visible = True
        End If

        lblPasswordNoCoincide.Visible = False
        If Not txtPassword.Text.Equals(txtPasswordConfirmacion.Text) Then
            lblPasswordNoCoincide.Visible = True
        End If


        If lblRequeridoApellido.Visible Or
            lblRequeridoCorreo.Visible Or
            lblRequeridoEscuela.Visible Or
            lblRequeridoIdentificacion.Visible Or
            lblRequeridoNombre.Visible Or
            lblRequeridoTelefono.Visible Or
            lblRequeridoPassword.Visible Or
            lblRequeridoPasswordConfirmar.Visible Or
            lblPasswordNoCoincide.Visible Then

            lblRequeridos.Visible = True
        End If

        Return Not lblRequeridos.Visible
    End Function

    Private Function ValidarContenido(entrada As TextBox, lblRequiereEntrada As Label)
        lblRequiereEntrada.Visible = False

        If String.IsNullOrWhiteSpace(entrada.Text) Then
            lblRequiereEntrada.Visible = True
        End If
    End Function
End Class