<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRegistro = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.pnlInicio = New System.Windows.Forms.Panel()
        Me.pnlContenido = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.menu = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TemasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CiclosDeProgramaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CiclosWhileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CiclosDoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CiclosForToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CiclosForEachToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.pnlInicio.SuspendLayout()
        Me.pnlContenido.SuspendLayout()
        Me.menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(152, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(395, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sistema de aprendizaje"
        '
        'btnRegistro
        '
        Me.btnRegistro.Location = New System.Drawing.Point(218, 334)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(217, 37)
        Me.btnRegistro.TabIndex = 1
        Me.btnRegistro.Text = "Registrarse"
        Me.btnRegistro.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(13, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(612, 59)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(124, 60)
        Me.txtPassword.MaxLength = 50
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(191, 22)
        Me.txtPassword.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 17)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Contraseña"
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(124, 32)
        Me.txtIdentificacion.MaxLength = 100
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(191, 22)
        Me.txtIdentificacion.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 17)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Usuario"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnIngresar)
        Me.GroupBox1.Controls.Add(Me.txtIdentificacion)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(171, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(321, 154)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Iniciar sesión"
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(113, 100)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(85, 34)
        Me.btnIngresar.TabIndex = 28
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'pnlInicio
        '
        Me.pnlInicio.Controls.Add(Me.Label1)
        Me.pnlInicio.Controls.Add(Me.GroupBox1)
        Me.pnlInicio.Controls.Add(Me.btnRegistro)
        Me.pnlInicio.Controls.Add(Me.Label2)
        Me.pnlInicio.Location = New System.Drawing.Point(12, 32)
        Me.pnlInicio.Name = "pnlInicio"
        Me.pnlInicio.Size = New System.Drawing.Size(628, 383)
        Me.pnlInicio.TabIndex = 29
        '
        'pnlContenido
        '
        Me.pnlContenido.BackColor = System.Drawing.SystemColors.Control
        Me.pnlContenido.Controls.Add(Me.Label4)
        Me.pnlContenido.Controls.Add(Me.Label3)
        Me.pnlContenido.Location = New System.Drawing.Point(15, 32)
        Me.pnlContenido.Name = "pnlContenido"
        Me.pnlContenido.Size = New System.Drawing.Size(628, 383)
        Me.pnlContenido.TabIndex = 30
        Me.pnlContenido.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(54, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(532, 122)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Bienvenido al sistema de aprendizaje de la UNAD."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(121, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(395, 39)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Sistema de aprendizaje"
        '
        'menu
        '
        Me.menu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.TemasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.menu.Location = New System.Drawing.Point(0, 0)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(653, 28)
        Me.menu.TabIndex = 31
        Me.menu.Text = "MenuStrip1"
        Me.menu.Visible = False
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'TemasToolStripMenuItem
        '
        Me.TemasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CiclosDeProgramaciónToolStripMenuItem})
        Me.TemasToolStripMenuItem.Name = "TemasToolStripMenuItem"
        Me.TemasToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.TemasToolStripMenuItem.Text = "Temas"
        '
        'CiclosDeProgramaciónToolStripMenuItem
        '
        Me.CiclosDeProgramaciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.CiclosWhileToolStripMenuItem, Me.CiclosDoToolStripMenuItem, Me.CiclosForToolStripMenuItem, Me.CiclosForEachToolStripMenuItem, Me.VideoToolStripMenuItem})
        Me.CiclosDeProgramaciónToolStripMenuItem.Name = "CiclosDeProgramaciónToolStripMenuItem"
        Me.CiclosDeProgramaciónToolStripMenuItem.Size = New System.Drawing.Size(250, 26)
        Me.CiclosDeProgramaciónToolStripMenuItem.Text = "Ciclos de programación"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(189, 26)
        Me.ToolStripMenuItem2.Text = "Definición"
        '
        'CiclosWhileToolStripMenuItem
        '
        Me.CiclosWhileToolStripMenuItem.Name = "CiclosWhileToolStripMenuItem"
        Me.CiclosWhileToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.CiclosWhileToolStripMenuItem.Text = "Ciclos while"
        '
        'CiclosDoToolStripMenuItem
        '
        Me.CiclosDoToolStripMenuItem.Name = "CiclosDoToolStripMenuItem"
        Me.CiclosDoToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.CiclosDoToolStripMenuItem.Text = "Ciclos Do"
        '
        'CiclosForToolStripMenuItem
        '
        Me.CiclosForToolStripMenuItem.Name = "CiclosForToolStripMenuItem"
        Me.CiclosForToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.CiclosForToolStripMenuItem.Text = "Ciclos for"
        '
        'CiclosForEachToolStripMenuItem
        '
        Me.CiclosForEachToolStripMenuItem.Name = "CiclosForEachToolStripMenuItem"
        Me.CiclosForEachToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.CiclosForEachToolStripMenuItem.Text = "Ciclos for each"
        '
        'VideoToolStripMenuItem
        '
        Me.VideoToolStripMenuItem.Name = "VideoToolStripMenuItem"
        Me.VideoToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.VideoToolStripMenuItem.Text = "Video"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 431)
        Me.Controls.Add(Me.pnlInicio)
        Me.Controls.Add(Me.pnlContenido)
        Me.Controls.Add(Me.menu)
        Me.MainMenuStrip = Me.menu
        Me.Name = "Main"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = ":: Visual Basic Básico ::.."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlInicio.ResumeLayout(False)
        Me.pnlInicio.PerformLayout()
        Me.pnlContenido.ResumeLayout(False)
        Me.pnlContenido.PerformLayout()
        Me.menu.ResumeLayout(False)
        Me.menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegistro As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtIdentificacion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents pnlInicio As Panel
    Friend WithEvents pnlContenido As Panel
    Friend WithEvents menu As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TemasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CiclosDeProgramaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents CiclosWhileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CiclosDoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CiclosForToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CiclosForEachToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents VideoToolStripMenuItem As ToolStripMenuItem
End Class
