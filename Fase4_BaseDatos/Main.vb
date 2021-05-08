Public Class Main
    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        Dim registroForm As New Registro
        registroForm.ShowDialog()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim resultado = PersistenciaEstudiante.IniciarSesion(txtIdentificacion.Text, Encriptar.Encriptar(txtPassword.Text))

        If resultado.Resultado Then
            pnlContenido.Visible = True
            pnlInicio.Visible = False
            menu.Visible = True
        Else
            MessageBox.Show(String.Join("\n", resultado.Errores), "Error en inicio de sesión")
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        pnlContenido.Visible = False
        menu.Visible = False
        pnlInicio.Visible = True
        txtIdentificacion.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        pnlContenido.Controls.Clear()
        pnlContenido.Controls.Add(New Tema5A)
    End Sub

    Private Sub CiclosWhileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CiclosWhileToolStripMenuItem.Click
        pnlContenido.Controls.Clear()
        pnlContenido.Controls.Add(New Tema5B)
    End Sub

    Private Sub CiclosDoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CiclosDoToolStripMenuItem.Click
        pnlContenido.Controls.Clear()
        pnlContenido.Controls.Add(New Tema5C)
    End Sub

    Private Sub CiclosForToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CiclosForToolStripMenuItem.Click
        pnlContenido.Controls.Clear()
        pnlContenido.Controls.Add(New Tema5D)
    End Sub

    Private Sub CiclosForEachToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CiclosForEachToolStripMenuItem.Click
        pnlContenido.Controls.Clear()
        pnlContenido.Controls.Add(New Tema5E)
    End Sub

    Private Sub VideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VideoToolStripMenuItem.Click
        pnlContenido.Controls.Clear()
        pnlContenido.Controls.Add(New Tema5Video)
    End Sub

    Private Sub txtIdentificacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdentificacion.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
