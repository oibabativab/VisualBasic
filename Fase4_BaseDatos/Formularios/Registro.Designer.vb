<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Me.components = New System.ComponentModel.Container()
        Me.cmbEscuela = New System.Windows.Forms.ComboBox()
        Me.EscuelasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TallerDBLocalDataSet = New Fase4_BaseDatos.tallerDBLocalDataSet()
        Me.EscuelasTableAdapter = New Fase4_BaseDatos.tallerDBLocalDataSetTableAdapters.EscuelasTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblRequeridos = New System.Windows.Forms.Label()
        Me.lblRequeridoIdentificacion = New System.Windows.Forms.Label()
        Me.lblRequeridoNombre = New System.Windows.Forms.Label()
        Me.lblRequeridoCorreo = New System.Windows.Forms.Label()
        Me.lblRequeridoTelefono = New System.Windows.Forms.Label()
        Me.lblRequeridoApellido = New System.Windows.Forms.Label()
        Me.lblRequeridoEscuela = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblRequeridoPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblRequeridoPasswordConfirmar = New System.Windows.Forms.Label()
        Me.txtPasswordConfirmacion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblPasswordNoCoincide = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdentificaciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoElectrónicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeléfonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreEscuelaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstudiantesTablaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TallerDBLocalDataSet1 = New Fase4_BaseDatos.tallerDBLocalDataSet()
        Me.EstudiantesTablaTableAdapter = New Fase4_BaseDatos.tallerDBLocalDataSetTableAdapters.EstudiantesTablaTableAdapter()
        CType(Me.EscuelasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TallerDBLocalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstudiantesTablaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TallerDBLocalDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbEscuela
        '
        Me.cmbEscuela.DataSource = Me.EscuelasBindingSource
        Me.cmbEscuela.DisplayMember = "Nombre"
        Me.cmbEscuela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEscuela.FormattingEnabled = True
        Me.cmbEscuela.Location = New System.Drawing.Point(166, 187)
        Me.cmbEscuela.Name = "cmbEscuela"
        Me.cmbEscuela.Size = New System.Drawing.Size(601, 24)
        Me.cmbEscuela.TabIndex = 6
        Me.cmbEscuela.ValueMember = "Id"
        '
        'EscuelasBindingSource
        '
        Me.EscuelasBindingSource.DataMember = "Escuelas"
        Me.EscuelasBindingSource.DataSource = Me.TallerDBLocalDataSet
        '
        'TallerDBLocalDataSet
        '
        Me.TallerDBLocalDataSet.DataSetName = "tallerDBLocalDataSet"
        Me.TallerDBLocalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EscuelasTableAdapter
        '
        Me.EscuelasTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(274, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Formulario de registro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(645, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Por favor diligencie los siguientes datos para que pueda ingresar y aprovechar el" &
    " material de estudio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(412, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Apellido"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(166, 124)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(224, 22)
        Me.txtNombre.TabIndex = 2
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(543, 124)
        Me.txtApellido.MaxLength = 100
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(224, 22)
        Me.txtApellido.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Identificación"
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(166, 92)
        Me.txtIdentificacion.MaxLength = 12
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(224, 22)
        Me.txtIdentificacion.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Escuela"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Correo"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(166, 156)
        Me.txtCorreo.MaxLength = 100
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(224, 22)
        Me.txtCorreo.TabIndex = 4
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(543, 156)
        Me.txtTelefono.MaxLength = 15
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(224, 22)
        Me.txtTelefono.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(412, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Teléfono"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(370, 277)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(84, 30)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblRequeridos
        '
        Me.lblRequeridos.ForeColor = System.Drawing.Color.Red
        Me.lblRequeridos.Location = New System.Drawing.Point(47, 321)
        Me.lblRequeridos.Name = "lblRequeridos"
        Me.lblRequeridos.Size = New System.Drawing.Size(723, 23)
        Me.lblRequeridos.TabIndex = 15
        Me.lblRequeridos.Text = "Los campos marcados con * son requeridos"
        Me.lblRequeridos.Visible = False
        '
        'lblRequeridoIdentificacion
        '
        Me.lblRequeridoIdentificacion.ForeColor = System.Drawing.Color.Red
        Me.lblRequeridoIdentificacion.Location = New System.Drawing.Point(122, 92)
        Me.lblRequeridoIdentificacion.Name = "lblRequeridoIdentificacion"
        Me.lblRequeridoIdentificacion.Size = New System.Drawing.Size(25, 23)
        Me.lblRequeridoIdentificacion.TabIndex = 16
        Me.lblRequeridoIdentificacion.Text = "*"
        Me.lblRequeridoIdentificacion.Visible = False
        '
        'lblRequeridoNombre
        '
        Me.lblRequeridoNombre.ForeColor = System.Drawing.Color.Red
        Me.lblRequeridoNombre.Location = New System.Drawing.Point(90, 124)
        Me.lblRequeridoNombre.Name = "lblRequeridoNombre"
        Me.lblRequeridoNombre.Size = New System.Drawing.Size(25, 23)
        Me.lblRequeridoNombre.TabIndex = 17
        Me.lblRequeridoNombre.Text = "*"
        Me.lblRequeridoNombre.Visible = False
        '
        'lblRequeridoCorreo
        '
        Me.lblRequeridoCorreo.ForeColor = System.Drawing.Color.Red
        Me.lblRequeridoCorreo.Location = New System.Drawing.Point(81, 156)
        Me.lblRequeridoCorreo.Name = "lblRequeridoCorreo"
        Me.lblRequeridoCorreo.Size = New System.Drawing.Size(25, 23)
        Me.lblRequeridoCorreo.TabIndex = 18
        Me.lblRequeridoCorreo.Text = "*"
        Me.lblRequeridoCorreo.Visible = False
        '
        'lblRequeridoTelefono
        '
        Me.lblRequeridoTelefono.ForeColor = System.Drawing.Color.Red
        Me.lblRequeridoTelefono.Location = New System.Drawing.Point(471, 156)
        Me.lblRequeridoTelefono.Name = "lblRequeridoTelefono"
        Me.lblRequeridoTelefono.Size = New System.Drawing.Size(25, 23)
        Me.lblRequeridoTelefono.TabIndex = 19
        Me.lblRequeridoTelefono.Text = "*"
        Me.lblRequeridoTelefono.Visible = False
        '
        'lblRequeridoApellido
        '
        Me.lblRequeridoApellido.ForeColor = System.Drawing.Color.Red
        Me.lblRequeridoApellido.Location = New System.Drawing.Point(471, 124)
        Me.lblRequeridoApellido.Name = "lblRequeridoApellido"
        Me.lblRequeridoApellido.Size = New System.Drawing.Size(25, 23)
        Me.lblRequeridoApellido.TabIndex = 20
        Me.lblRequeridoApellido.Text = "*"
        Me.lblRequeridoApellido.Visible = False
        '
        'lblRequeridoEscuela
        '
        Me.lblRequeridoEscuela.ForeColor = System.Drawing.Color.Red
        Me.lblRequeridoEscuela.Location = New System.Drawing.Point(90, 188)
        Me.lblRequeridoEscuela.Name = "lblRequeridoEscuela"
        Me.lblRequeridoEscuela.Size = New System.Drawing.Size(25, 23)
        Me.lblRequeridoEscuela.TabIndex = 21
        Me.lblRequeridoEscuela.Text = "*"
        Me.lblRequeridoEscuela.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(396, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(281, 17)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Su número de identificación sera el usuario"
        '
        'lblRequeridoPassword
        '
        Me.lblRequeridoPassword.ForeColor = System.Drawing.Color.Red
        Me.lblRequeridoPassword.Location = New System.Drawing.Point(113, 227)
        Me.lblRequeridoPassword.Name = "lblRequeridoPassword"
        Me.lblRequeridoPassword.Size = New System.Drawing.Size(25, 23)
        Me.lblRequeridoPassword.TabIndex = 25
        Me.lblRequeridoPassword.Text = "*"
        Me.lblRequeridoPassword.Visible = False
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(166, 227)
        Me.txtPassword.MaxLength = 50
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(224, 22)
        Me.txtPassword.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(35, 230)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 17)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Contraseña"
        '
        'lblRequeridoPasswordConfirmar
        '
        Me.lblRequeridoPasswordConfirmar.ForeColor = System.Drawing.Color.Red
        Me.lblRequeridoPasswordConfirmar.Location = New System.Drawing.Point(490, 224)
        Me.lblRequeridoPasswordConfirmar.Name = "lblRequeridoPasswordConfirmar"
        Me.lblRequeridoPasswordConfirmar.Size = New System.Drawing.Size(25, 23)
        Me.lblRequeridoPasswordConfirmar.TabIndex = 28
        Me.lblRequeridoPasswordConfirmar.Text = "*"
        Me.lblRequeridoPasswordConfirmar.Visible = False
        '
        'txtPasswordConfirmacion
        '
        Me.txtPasswordConfirmacion.Location = New System.Drawing.Point(543, 224)
        Me.txtPasswordConfirmacion.MaxLength = 50
        Me.txtPasswordConfirmacion.Name = "txtPasswordConfirmacion"
        Me.txtPasswordConfirmacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordConfirmacion.Size = New System.Drawing.Size(224, 22)
        Me.txtPasswordConfirmacion.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(412, 227)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 17)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Confirmar"
        '
        'lblPasswordNoCoincide
        '
        Me.lblPasswordNoCoincide.ForeColor = System.Drawing.Color.Red
        Me.lblPasswordNoCoincide.Location = New System.Drawing.Point(35, 252)
        Me.lblPasswordNoCoincide.Name = "lblPasswordNoCoincide"
        Me.lblPasswordNoCoincide.Size = New System.Drawing.Size(723, 23)
        Me.lblPasswordNoCoincide.TabIndex = 29
        Me.lblPasswordNoCoincide.Text = "Las constraseñas no coinciden"
        Me.lblPasswordNoCoincide.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificaciónDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.CorreoElectrónicoDataGridViewTextBoxColumn, Me.TeléfonoDataGridViewTextBoxColumn, Me.NombreEscuelaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EstudiantesTablaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(27, 362)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(875, 248)
        Me.DataGridView1.TabIndex = 30
        '
        'IdentificaciónDataGridViewTextBoxColumn
        '
        Me.IdentificaciónDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IdentificaciónDataGridViewTextBoxColumn.DataPropertyName = "Identificación"
        Me.IdentificaciónDataGridViewTextBoxColumn.HeaderText = "Identificación"
        Me.IdentificaciónDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdentificaciónDataGridViewTextBoxColumn.Name = "IdentificaciónDataGridViewTextBoxColumn"
        Me.IdentificaciónDataGridViewTextBoxColumn.Width = 119
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.Width = 87
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        Me.ApellidoDataGridViewTextBoxColumn.Width = 87
        '
        'CorreoElectrónicoDataGridViewTextBoxColumn
        '
        Me.CorreoElectrónicoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CorreoElectrónicoDataGridViewTextBoxColumn.DataPropertyName = "Correo electrónico"
        Me.CorreoElectrónicoDataGridViewTextBoxColumn.HeaderText = "Correo electrónico"
        Me.CorreoElectrónicoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CorreoElectrónicoDataGridViewTextBoxColumn.Name = "CorreoElectrónicoDataGridViewTextBoxColumn"
        Me.CorreoElectrónicoDataGridViewTextBoxColumn.Width = 140
        '
        'TeléfonoDataGridViewTextBoxColumn
        '
        Me.TeléfonoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TeléfonoDataGridViewTextBoxColumn.DataPropertyName = "Teléfono"
        Me.TeléfonoDataGridViewTextBoxColumn.HeaderText = "Teléfono"
        Me.TeléfonoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TeléfonoDataGridViewTextBoxColumn.Name = "TeléfonoDataGridViewTextBoxColumn"
        Me.TeléfonoDataGridViewTextBoxColumn.Width = 93
        '
        'NombreEscuelaDataGridViewTextBoxColumn
        '
        Me.NombreEscuelaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NombreEscuelaDataGridViewTextBoxColumn.DataPropertyName = "Nombre Escuela"
        Me.NombreEscuelaDataGridViewTextBoxColumn.HeaderText = "Nombre Escuela"
        Me.NombreEscuelaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreEscuelaDataGridViewTextBoxColumn.Name = "NombreEscuelaDataGridViewTextBoxColumn"
        Me.NombreEscuelaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NombreEscuelaDataGridViewTextBoxColumn.Width = 129
        '
        'EstudiantesTablaBindingSource
        '
        Me.EstudiantesTablaBindingSource.DataMember = "EstudiantesTabla"
        Me.EstudiantesTablaBindingSource.DataSource = Me.TallerDBLocalDataSet1
        '
        'TallerDBLocalDataSet1
        '
        Me.TallerDBLocalDataSet1.DataSetName = "tallerDBLocalDataSet"
        Me.TallerDBLocalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstudiantesTablaTableAdapter
        '
        Me.EstudiantesTablaTableAdapter.ClearBeforeFill = True
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 635)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblPasswordNoCoincide)
        Me.Controls.Add(Me.lblRequeridoPasswordConfirmar)
        Me.Controls.Add(Me.txtPasswordConfirmacion)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblRequeridoPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblRequeridoEscuela)
        Me.Controls.Add(Me.lblRequeridoApellido)
        Me.Controls.Add(Me.lblRequeridoTelefono)
        Me.Controls.Add(Me.lblRequeridoCorreo)
        Me.Controls.Add(Me.lblRequeridoNombre)
        Me.Controls.Add(Me.lblRequeridoIdentificacion)
        Me.Controls.Add(Me.lblRequeridos)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtIdentificacion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbEscuela)
        Me.Name = "Registro"
        Me.Text = ":: Registro nuevo estudiante ::.."
        CType(Me.EscuelasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TallerDBLocalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstudiantesTablaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TallerDBLocalDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbEscuela As ComboBox
    Friend WithEvents TallerDBLocalDataSet As tallerDBLocalDataSet
    Friend WithEvents EscuelasBindingSource As BindingSource
    Friend WithEvents EscuelasTableAdapter As tallerDBLocalDataSetTableAdapters.EscuelasTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIdentificacion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblRequeridos As Label
    Friend WithEvents lblRequeridoIdentificacion As Label
    Friend WithEvents lblRequeridoNombre As Label
    Friend WithEvents lblRequeridoCorreo As Label
    Friend WithEvents lblRequeridoTelefono As Label
    Friend WithEvents lblRequeridoApellido As Label
    Friend WithEvents lblRequeridoEscuela As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblRequeridoPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lblRequeridoPasswordConfirmar As Label
    Friend WithEvents txtPasswordConfirmacion As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lblPasswordNoCoincide As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TallerDBLocalDataSet1 As tallerDBLocalDataSet
    Friend WithEvents EstudiantesTablaBindingSource As BindingSource
    Friend WithEvents EstudiantesTablaTableAdapter As tallerDBLocalDataSetTableAdapters.EstudiantesTablaTableAdapter
    Friend WithEvents IdentificacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdentificaciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoElectrónicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeléfonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreEscuelaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
