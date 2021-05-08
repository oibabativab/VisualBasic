Public Class Registro
    Dim actualizar As Boolean

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
            estudiante.Telefono = txtTelefono.Text
            estudiante.Escuela = cmbEscuela.SelectedValue
            estudiante.Contrasena = Encriptar.Encriptar(txtPassword.Text)
            Dim persistir As New PersistenciaEstudiante
            Dim resultado As TransaccionBD

            If actualizar Then
                resultado = persistir.ActualizarEstudiante(estudiante)
            Else
                resultado = persistir.InsertarEstudiante(estudiante)
            End If

            If resultado.Resultado Then
                If actualizar Then
                    MessageBox.Show("Estudiante Actualizado", "Proceso exitoso")
                Else
                    MessageBox.Show("Estudiante Creado", "Proceso exitoso")
                End If
            Else
                MessageBox.Show(String.Join("\n", resultado.Errores), "Error al guardar")
            End If
            Registro_Load(Nothing, Nothing)
            btnNuevoEstudiante_Click(Nothing, Nothing)
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

    Private Sub dataGridUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridUsers.CellContentClick
        If e.ColumnIndex = 0 Then
            ModificarRegistro(e.RowIndex)
        ElseIf e.ColumnIndex = 1 Then
            EliminarRegistro(e.RowIndex)
        End If
    End Sub

    Private Sub EliminarRegistro(rowIndex As Integer)
        Dim identificacion = Long.Parse(dataGridUsers.Rows(rowIndex).Cells(2).Value)
        If identificacion = 2021 Then
            MessageBox.Show("No puede eliminar el administrador", "Acción inválida")
            Return
        End If

        Dim resultado = PersistenciaEstudiante.EliminarEstudiante(identificacion)
        If resultado.Resultado Then
            MessageBox.Show("El estudiante se ha eliminado correctamente", "Proceso exitoso")
        Else
            MessageBox.Show("Ha ocurrido un error en la eliminación", "Proceso no terminado")
        End If

        Registro_Load(Nothing, Nothing)
    End Sub

    Private Sub ModificarRegistro(rowIndex As Integer)
        Dim registro = dataGridUsers.Rows(rowIndex).Cells

        txtIdentificacion.Text = ObtenerValor(registro(2).Value)

        txtNombre.Text = ObtenerValor(registro(3).Value)
        txtApellido.Text = ObtenerValor(registro(4).Value)
        txtCorreo.Text = ObtenerValor(registro(5).Value)
        txtTelefono.Text = ObtenerValor(registro(6).Value)
        cmbEscuela.SelectedValue = ObtenerValor(registro(8).Value)
        txtPassword.Text = ""
        txtPasswordConfirmacion.Text = ""

        actualizar = True
        ModificarIdentificacionEnable()
    End Sub

    Function ModificarIdentificacionEnable()
        txtIdentificacion.Enabled = Not actualizar
    End Function

    Function ObtenerValor(valorBD As Object) As String
        If IsDBNull(valorBD) Then
            Return ""
        End If
        Return valorBD
    End Function

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.EstudiantesTablaTableAdapter.FillBy(Me.TallerDBLocalDataSet.EstudiantesTabla)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnNuevoEstudiante_Click(sender As Object, e As EventArgs) Handles btnNuevoEstudiante.Click
        actualizar = False
        ModificarIdentificacionEnable()

        txtIdentificacion.Text = ""

        txtNombre.Text = ""
        txtApellido.Text = ""
        txtCorreo.Text = ""
        txtTelefono.Text = ""
        cmbEscuela.SelectedIndex = 0
        txtPassword.Text = ""
        txtPasswordConfirmacion.Text = ""
    End Sub
End Class