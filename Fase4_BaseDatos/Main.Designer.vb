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
        Me.Tema2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tema3CondicionalesParaProgramaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.Label1.Location = New System.Drawing.Point(114, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sistema de aprendizaje"
        '
        'btnRegistro
        '
        Me.btnRegistro.Location = New System.Drawing.Point(164, 271)
        Me.btnRegistro.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(163, 30)
        Me.btnRegistro.TabIndex = 1
        Me.btnRegistro.Text = "Registrarse"
        Me.btnRegistro.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(459, 48)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(93, 49)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassword.MaxLength = 50
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(144, 20)
        Me.txtPassword.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 51)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Contraseña"
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(93, 26)
        Me.txtIdentificacion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdentificacion.MaxLength = 100
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(144, 20)
        Me.txtIdentificacion.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 28)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
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
        Me.GroupBox1.Location = New System.Drawing.Point(128, 112)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(241, 125)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Iniciar sesión"
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(85, 81)
        Me.btnIngresar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(64, 28)
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
        Me.pnlInicio.Location = New System.Drawing.Point(9, 26)
        Me.pnlInicio.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlInicio.Name = "pnlInicio"
        Me.pnlInicio.Size = New System.Drawing.Size(471, 311)
        Me.pnlInicio.TabIndex = 29
        '
        'pnlContenido
        '
        Me.pnlContenido.BackColor = System.Drawing.SystemColors.Control
        Me.pnlContenido.Controls.Add(Me.Label4)
        Me.pnlContenido.Controls.Add(Me.Label3)
        Me.pnlContenido.Location = New System.Drawing.Point(11, 26)
        Me.pnlContenido.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlContenido.Name = "pnlContenido"
        Me.pnlContenido.Size = New System.Drawing.Size(471, 311)
        Me.pnlContenido.TabIndex = 30
        Me.pnlContenido.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 138)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(399, 99)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Bienvenido al sistema de aprendizaje de la UNAD."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(91, 62)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(318, 31)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Sistema de aprendizaje"
        '
        'menu
        '
        Me.menu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.TemasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.menu.Location = New System.Drawing.Point(0, 0)
        Me.menu.Name = "menu"
        Me.menu.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.menu.Size = New System.Drawing.Size(490, 24)
        Me.menu.TabIndex = 31
        Me.menu.Text = "MenuStrip1"
        Me.menu.Visible = False
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'TemasToolStripMenuItem
        '
        Me.TemasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CiclosDeProgramaciónToolStripMenuItem, Me.Tema2ToolStripMenuItem, Me.Tema3CondicionalesParaProgramaciónToolStripMenuItem})
        Me.TemasToolStripMenuItem.Name = "TemasToolStripMenuItem"
        Me.TemasToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.TemasToolStripMenuItem.Text = "Temas"
        '
        'CiclosDeProgramaciónToolStripMenuItem
        '
        Me.CiclosDeProgramaciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.CiclosWhileToolStripMenuItem, Me.CiclosDoToolStripMenuItem, Me.CiclosForToolStripMenuItem, Me.CiclosForEachToolStripMenuItem, Me.VideoToolStripMenuItem})
        Me.CiclosDeProgramaciónToolStripMenuItem.Name = "CiclosDeProgramaciónToolStripMenuItem"
        Me.CiclosDeProgramaciónToolStripMenuItem.Size = New System.Drawing.Size(296, 22)
        Me.CiclosDeProgramaciónToolStripMenuItem.Text = "Ciclos de programación"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem2.Text = "Definición"
        '
        'CiclosWhileToolStripMenuItem
        '
        Me.CiclosWhileToolStripMenuItem.Name = "CiclosWhileToolStripMenuItem"
        Me.CiclosWhileToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CiclosWhileToolStripMenuItem.Text = "Ciclos while"
        '
        'CiclosDoToolStripMenuItem
        '
        Me.CiclosDoToolStripMenuItem.Name = "CiclosDoToolStripMenuItem"
        Me.CiclosDoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CiclosDoToolStripMenuItem.Text = "Ciclos Do"
        '
        'CiclosForToolStripMenuItem
        '
        Me.CiclosForToolStripMenuItem.Name = "CiclosForToolStripMenuItem"
        Me.CiclosForToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CiclosForToolStripMenuItem.Text = "Ciclos for"
        '
        'CiclosForEachToolStripMenuItem
        '
        Me.CiclosForEachToolStripMenuItem.Name = "CiclosForEachToolStripMenuItem"
        Me.CiclosForEachToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CiclosForEachToolStripMenuItem.Text = "Ciclos for each"
        '
        'VideoToolStripMenuItem
        '
        Me.VideoToolStripMenuItem.Name = "VideoToolStripMenuItem"
        Me.VideoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VideoToolStripMenuItem.Text = "Video"
        '
        'Tema2ToolStripMenuItem
        '
        Me.Tema2ToolStripMenuItem.Name = "Tema2ToolStripMenuItem"
        Me.Tema2ToolStripMenuItem.Size = New System.Drawing.Size(296, 22)
        Me.Tema2ToolStripMenuItem.Text = "tema 2 Interaccion Humano computador"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Tema3CondicionalesParaProgramaciónToolStripMenuItem
        '
        Me.Tema3CondicionalesParaProgramaciónToolStripMenuItem.Name = "Tema3CondicionalesParaProgramaciónToolStripMenuItem"
        Me.Tema3CondicionalesParaProgramaciónToolStripMenuItem.Size = New System.Drawing.Size(296, 22)
        Me.Tema3CondicionalesParaProgramaciónToolStripMenuItem.Text = "Tema 3. Condicionales para programación"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 350)
        Me.Controls.Add(Me.pnlInicio)
        Me.Controls.Add(Me.pnlContenido)
        Me.Controls.Add(Me.menu)
        Me.MainMenuStrip = Me.menu
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents Tema2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tema3CondicionalesParaProgramaciónToolStripMenuItem As ToolStripMenuItem
End Class
