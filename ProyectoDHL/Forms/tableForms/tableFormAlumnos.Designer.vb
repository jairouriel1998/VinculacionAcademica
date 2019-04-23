<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tableFormAlumnos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tableFormAlumnos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExitForm = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtVinculadas = New System.Windows.Forms.TextBox()
        Me.labVinculadas = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSaveNew = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Busqueda = New System.Windows.Forms.Label()
        Me.btnDeleteAlumno = New System.Windows.Forms.Button()
        Me.btnEditAlumno = New System.Windows.Forms.Button()
        Me.btnAddNewAlumno = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.datalistAlumnos = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCarrera = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAsignatura = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPeriodo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEvaluacion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHoras = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEvaluador = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBeneficiado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProyecto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VinculacionAcademicaPT_TGU_DBDataSet1 = New ProyectoDHL.VinculacionAcademicaPT_TGU_DBDataSet1()
        Me.AlumnosTableAdapter = New ProyectoDHL.VinculacionAcademicaPT_TGU_DBDataSet1TableAdapters.AlumnosTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.datalistAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VinculacionAcademicaPT_TGU_DBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.btnExitForm)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(833, 55)
        Me.Panel1.TabIndex = 0
        '
        'btnExitForm
        '
        Me.btnExitForm.BackColor = System.Drawing.Color.DarkGray
        Me.btnExitForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExitForm.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnExitForm.FlatAppearance.BorderSize = 0
        Me.btnExitForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExitForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExitForm.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExitForm.Image = Global.ProyectoDHL.My.Resources.Resources.Icono_cerrar_FN
        Me.btnExitForm.Location = New System.Drawing.Point(0, 0)
        Me.btnExitForm.Name = "btnExitForm"
        Me.btnExitForm.Size = New System.Drawing.Size(68, 55)
        Me.btnExitForm.TabIndex = 3
        Me.btnExitForm.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Lato Semibold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(74, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(691, 42)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "REGISTROS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.txtVinculadas)
        Me.Panel2.Controls.Add(Me.labVinculadas)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 533)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(833, 39)
        Me.Panel2.TabIndex = 1
        '
        'txtVinculadas
        '
        Me.txtVinculadas.BackColor = System.Drawing.Color.White
        Me.txtVinculadas.Font = New System.Drawing.Font("Lato Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVinculadas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtVinculadas.Location = New System.Drawing.Point(527, 7)
        Me.txtVinculadas.Name = "txtVinculadas"
        Me.txtVinculadas.Size = New System.Drawing.Size(84, 23)
        Me.txtVinculadas.TabIndex = 34
        Me.txtVinculadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtVinculadas.Visible = False
        '
        'labVinculadas
        '
        Me.labVinculadas.AutoSize = True
        Me.labVinculadas.Font = New System.Drawing.Font("Lato Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labVinculadas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.labVinculadas.Location = New System.Drawing.Point(417, 10)
        Me.labVinculadas.Name = "labVinculadas"
        Me.labVinculadas.Size = New System.Drawing.Size(106, 16)
        Me.labVinculadas.TabIndex = 33
        Me.labVinculadas.Text = "Total de horas:"
        Me.labVinculadas.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.Controls.Add(Me.btnSaveNew)
        Me.Panel3.Controls.Add(Me.btnExportar)
        Me.Panel3.Controls.Add(Me.btnClear)
        Me.Panel3.Controls.Add(Me.btnBuscar)
        Me.Panel3.Controls.Add(Me.txtBusqueda)
        Me.Panel3.Controls.Add(Me.Busqueda)
        Me.Panel3.Controls.Add(Me.btnDeleteAlumno)
        Me.Panel3.Controls.Add(Me.btnEditAlumno)
        Me.Panel3.Controls.Add(Me.btnAddNewAlumno)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(633, 55)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 478)
        Me.Panel3.TabIndex = 2
        '
        'btnSaveNew
        '
        Me.btnSaveNew.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSaveNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveNew.FlatAppearance.BorderSize = 0
        Me.btnSaveNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnSaveNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnSaveNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveNew.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnSaveNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveNew.Location = New System.Drawing.Point(0, 130)
        Me.btnSaveNew.Name = "btnSaveNew"
        Me.btnSaveNew.Size = New System.Drawing.Size(200, 40)
        Me.btnSaveNew.TabIndex = 34
        Me.btnSaveNew.Text = "Guardar como nuevo"
        Me.btnSaveNew.UseVisualStyleBackColor = False
        Me.btnSaveNew.Visible = False
        '
        'btnExportar
        '
        Me.btnExportar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportar.FlatAppearance.BorderSize = 0
        Me.btnExportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportar.Font = New System.Drawing.Font("Lato", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(0, 421)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(200, 40)
        Me.btnExportar.TabIndex = 33
        Me.btnExportar.Text = "Exportar a Excel"
        Me.btnExportar.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Lato Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(6, 69)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(89, 31)
        Me.btnClear.TabIndex = 32
        Me.btnClear.Text = "Ver todo"
        Me.btnClear.UseVisualStyleBackColor = False
        Me.btnClear.Visible = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Lato Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(101, 69)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(88, 31)
        Me.btnBuscar.TabIndex = 31
        Me.btnBuscar.Text = "Filtrar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtBusqueda
        '
        Me.txtBusqueda.BackColor = System.Drawing.Color.White
        Me.txtBusqueda.Font = New System.Drawing.Font("Lato Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtBusqueda.Location = New System.Drawing.Point(27, 36)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(161, 23)
        Me.txtBusqueda.TabIndex = 30
        Me.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Busqueda
        '
        Me.Busqueda.AutoSize = True
        Me.Busqueda.Font = New System.Drawing.Font("Lato Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Busqueda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Busqueda.Location = New System.Drawing.Point(3, 13)
        Me.Busqueda.Name = "Busqueda"
        Me.Busqueda.Size = New System.Drawing.Size(125, 16)
        Me.Busqueda.TabIndex = 8
        Me.Busqueda.Text = "Filtrar por cuenta"
        '
        'btnDeleteAlumno
        '
        Me.btnDeleteAlumno.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnDeleteAlumno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteAlumno.FlatAppearance.BorderSize = 0
        Me.btnDeleteAlumno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnDeleteAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnDeleteAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteAlumno.Font = New System.Drawing.Font("Lato Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAlumno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnDeleteAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteAlumno.Location = New System.Drawing.Point(0, 375)
        Me.btnDeleteAlumno.Name = "btnDeleteAlumno"
        Me.btnDeleteAlumno.Size = New System.Drawing.Size(200, 40)
        Me.btnDeleteAlumno.TabIndex = 7
        Me.btnDeleteAlumno.Text = "Eliminar "
        Me.btnDeleteAlumno.UseVisualStyleBackColor = False
        '
        'btnEditAlumno
        '
        Me.btnEditAlumno.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditAlumno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditAlumno.FlatAppearance.BorderSize = 0
        Me.btnEditAlumno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnEditAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnEditAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditAlumno.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditAlumno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnEditAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditAlumno.Location = New System.Drawing.Point(0, 176)
        Me.btnEditAlumno.Name = "btnEditAlumno"
        Me.btnEditAlumno.Size = New System.Drawing.Size(200, 41)
        Me.btnEditAlumno.TabIndex = 6
        Me.btnEditAlumno.Text = "Editar"
        Me.btnEditAlumno.UseVisualStyleBackColor = False
        '
        'btnAddNewAlumno
        '
        Me.btnAddNewAlumno.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddNewAlumno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNewAlumno.FlatAppearance.BorderSize = 0
        Me.btnAddNewAlumno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnAddNewAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnAddNewAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewAlumno.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewAlumno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnAddNewAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddNewAlumno.Location = New System.Drawing.Point(0, 130)
        Me.btnAddNewAlumno.Name = "btnAddNewAlumno"
        Me.btnAddNewAlumno.Size = New System.Drawing.Size(200, 40)
        Me.btnAddNewAlumno.TabIndex = 5
        Me.btnAddNewAlumno.Text = "Nuevo "
        Me.btnAddNewAlumno.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(0, 177)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(200, 40)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Guardar edición"
        Me.btnSave.UseVisualStyleBackColor = False
        Me.btnSave.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 55)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(633, 478)
        Me.Panel4.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.datalistAlumnos)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 228)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(633, 250)
        Me.Panel6.TabIndex = 2
        '
        'datalistAlumnos
        '
        Me.datalistAlumnos.AllowUserToAddRows = False
        Me.datalistAlumnos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkTurquoise
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistAlumnos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datalistAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.datalistAlumnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.datalistAlumnos.BackgroundColor = System.Drawing.Color.White
        Me.datalistAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.datalistAlumnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistAlumnos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datalistAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistAlumnos.DefaultCellStyle = DataGridViewCellStyle3
        Me.datalistAlumnos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datalistAlumnos.Location = New System.Drawing.Point(0, 0)
        Me.datalistAlumnos.MultiSelect = False
        Me.datalistAlumnos.Name = "datalistAlumnos"
        Me.datalistAlumnos.ReadOnly = True
        Me.datalistAlumnos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistAlumnos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Lato", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.datalistAlumnos.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.datalistAlumnos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.datalistAlumnos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.datalistAlumnos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Lato Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datalistAlumnos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.datalistAlumnos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        Me.datalistAlumnos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datalistAlumnos.RowTemplate.Height = 18
        Me.datalistAlumnos.RowTemplate.ReadOnly = True
        Me.datalistAlumnos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datalistAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistAlumnos.Size = New System.Drawing.Size(633, 250)
        Me.datalistAlumnos.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(633, 228)
        Me.Panel5.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(633, 228)
        Me.Panel8.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel9.Controls.Add(Me.txtObservaciones)
        Me.Panel9.Controls.Add(Me.Label13)
        Me.Panel9.Controls.Add(Me.txtCarrera)
        Me.Panel9.Controls.Add(Me.Label12)
        Me.Panel9.Controls.Add(Me.txtAsignatura)
        Me.Panel9.Controls.Add(Me.Label11)
        Me.Panel9.Controls.Add(Me.txtValor)
        Me.Panel9.Controls.Add(Me.Label10)
        Me.Panel9.Controls.Add(Me.txtPeriodo)
        Me.Panel9.Controls.Add(Me.Label9)
        Me.Panel9.Controls.Add(Me.txtEvaluacion)
        Me.Panel9.Controls.Add(Me.Label8)
        Me.Panel9.Controls.Add(Me.txtHoras)
        Me.Panel9.Controls.Add(Me.Label7)
        Me.Panel9.Controls.Add(Me.txtEvaluador)
        Me.Panel9.Controls.Add(Me.Label6)
        Me.Panel9.Controls.Add(Me.txtBeneficiado)
        Me.Panel9.Controls.Add(Me.Label5)
        Me.Panel9.Controls.Add(Me.txtProyecto)
        Me.Panel9.Controls.Add(Me.Label4)
        Me.Panel9.Controls.Add(Me.txtNombre)
        Me.Panel9.Controls.Add(Me.Label2)
        Me.Panel9.Controls.Add(Me.txtCuenta)
        Me.Panel9.Controls.Add(Me.Label3)
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(633, 228)
        Me.Panel9.TabIndex = 2
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtObservaciones.BackColor = System.Drawing.Color.White
        Me.txtObservaciones.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.ForeColor = System.Drawing.Color.Black
        Me.txtObservaciones.Location = New System.Drawing.Point(329, 165)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ReadOnly = True
        Me.txtObservaciones.Size = New System.Drawing.Size(298, 53)
        Me.txtObservaciones.TabIndex = 159
        '
        'Label13
        '
        Me.Label13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lato Semibold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(326, 144)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 16)
        Me.Label13.TabIndex = 158
        Me.Label13.Text = "Observaciones"
        '
        'txtCarrera
        '
        Me.txtCarrera.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtCarrera.BackColor = System.Drawing.Color.White
        Me.txtCarrera.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarrera.ForeColor = System.Drawing.Color.Black
        Me.txtCarrera.Location = New System.Drawing.Point(398, 114)
        Me.txtCarrera.Name = "txtCarrera"
        Me.txtCarrera.ReadOnly = True
        Me.txtCarrera.Size = New System.Drawing.Size(229, 23)
        Me.txtCarrera.TabIndex = 157
        Me.txtCarrera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lato Semibold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(326, 117)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 16)
        Me.Label12.TabIndex = 156
        Me.Label12.Text = "Carrera"
        '
        'txtAsignatura
        '
        Me.txtAsignatura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtAsignatura.BackColor = System.Drawing.Color.White
        Me.txtAsignatura.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsignatura.ForeColor = System.Drawing.Color.Black
        Me.txtAsignatura.Location = New System.Drawing.Point(398, 86)
        Me.txtAsignatura.Name = "txtAsignatura"
        Me.txtAsignatura.ReadOnly = True
        Me.txtAsignatura.Size = New System.Drawing.Size(229, 23)
        Me.txtAsignatura.TabIndex = 155
        Me.txtAsignatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lato Semibold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(326, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 16)
        Me.Label11.TabIndex = 154
        Me.Label11.Text = "Asignatura"
        '
        'txtValor
        '
        Me.txtValor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtValor.BackColor = System.Drawing.Color.White
        Me.txtValor.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.ForeColor = System.Drawing.Color.Black
        Me.txtValor.Location = New System.Drawing.Point(398, 58)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.ReadOnly = True
        Me.txtValor.Size = New System.Drawing.Size(229, 23)
        Me.txtValor.TabIndex = 153
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lato Semibold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(326, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 16)
        Me.Label10.TabIndex = 152
        Me.Label10.Text = "Valor"
        '
        'txtPeriodo
        '
        Me.txtPeriodo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtPeriodo.BackColor = System.Drawing.Color.White
        Me.txtPeriodo.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeriodo.ForeColor = System.Drawing.Color.Black
        Me.txtPeriodo.Location = New System.Drawing.Point(398, 32)
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.ReadOnly = True
        Me.txtPeriodo.Size = New System.Drawing.Size(229, 23)
        Me.txtPeriodo.TabIndex = 151
        Me.txtPeriodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lato Semibold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(326, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 150
        Me.Label9.Text = "Periodo"
        '
        'txtEvaluacion
        '
        Me.txtEvaluacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtEvaluacion.BackColor = System.Drawing.Color.White
        Me.txtEvaluacion.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEvaluacion.ForeColor = System.Drawing.Color.Black
        Me.txtEvaluacion.Location = New System.Drawing.Point(398, 6)
        Me.txtEvaluacion.Name = "txtEvaluacion"
        Me.txtEvaluacion.ReadOnly = True
        Me.txtEvaluacion.Size = New System.Drawing.Size(229, 23)
        Me.txtEvaluacion.TabIndex = 149
        Me.txtEvaluacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lato Semibold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(326, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 16)
        Me.Label8.TabIndex = 148
        Me.Label8.Text = "Evaluacion"
        '
        'txtHoras
        '
        Me.txtHoras.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtHoras.BackColor = System.Drawing.Color.White
        Me.txtHoras.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoras.ForeColor = System.Drawing.Color.Black
        Me.txtHoras.Location = New System.Drawing.Point(74, 196)
        Me.txtHoras.Name = "txtHoras"
        Me.txtHoras.ReadOnly = True
        Me.txtHoras.Size = New System.Drawing.Size(241, 23)
        Me.txtHoras.TabIndex = 111
        Me.txtHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lato Semibold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(4, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 16)
        Me.Label7.TabIndex = 110
        Me.Label7.Text = "Horas"
        '
        'txtEvaluador
        '
        Me.txtEvaluador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtEvaluador.BackColor = System.Drawing.Color.White
        Me.txtEvaluador.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEvaluador.ForeColor = System.Drawing.Color.Black
        Me.txtEvaluador.Location = New System.Drawing.Point(74, 171)
        Me.txtEvaluador.Name = "txtEvaluador"
        Me.txtEvaluador.ReadOnly = True
        Me.txtEvaluador.Size = New System.Drawing.Size(241, 23)
        Me.txtEvaluador.TabIndex = 109
        Me.txtEvaluador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lato Semibold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(4, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 16)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "Evaluador"
        '
        'txtBeneficiado
        '
        Me.txtBeneficiado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtBeneficiado.BackColor = System.Drawing.Color.White
        Me.txtBeneficiado.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeneficiado.ForeColor = System.Drawing.Color.Black
        Me.txtBeneficiado.Location = New System.Drawing.Point(74, 117)
        Me.txtBeneficiado.Multiline = True
        Me.txtBeneficiado.Name = "txtBeneficiado"
        Me.txtBeneficiado.ReadOnly = True
        Me.txtBeneficiado.Size = New System.Drawing.Size(241, 49)
        Me.txtBeneficiado.TabIndex = 107
        Me.txtBeneficiado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lato Semibold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(4, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 16)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Beneficiado"
        '
        'txtProyecto
        '
        Me.txtProyecto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtProyecto.BackColor = System.Drawing.Color.White
        Me.txtProyecto.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProyecto.ForeColor = System.Drawing.Color.Black
        Me.txtProyecto.Location = New System.Drawing.Point(74, 58)
        Me.txtProyecto.Multiline = True
        Me.txtProyecto.Name = "txtProyecto"
        Me.txtProyecto.ReadOnly = True
        Me.txtProyecto.Size = New System.Drawing.Size(241, 52)
        Me.txtProyecto.TabIndex = 105
        Me.txtProyecto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lato Semibold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(4, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 16)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Proyecto"
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Location = New System.Drawing.Point(74, 30)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(241, 23)
        Me.txtNombre.TabIndex = 103
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lato Semibold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(4, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Alumno"
        '
        'txtCuenta
        '
        Me.txtCuenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtCuenta.BackColor = System.Drawing.Color.White
        Me.txtCuenta.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.ForeColor = System.Drawing.Color.Black
        Me.txtCuenta.Location = New System.Drawing.Point(74, 3)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.ReadOnly = True
        Me.txtCuenta.Size = New System.Drawing.Size(241, 23)
        Me.txtCuenta.TabIndex = 101
        Me.txtCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lato Semibold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(4, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 16)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Cuenta"
        '
        'AlumnosBindingSource
        '
        Me.AlumnosBindingSource.DataMember = "Alumnos"
        Me.AlumnosBindingSource.DataSource = Me.VinculacionAcademicaPT_TGU_DBDataSet1
        '
        'VinculacionAcademicaPT_TGU_DBDataSet1
        '
        Me.VinculacionAcademicaPT_TGU_DBDataSet1.DataSetName = "VinculacionAcademicaPT_TGU_DBDataSet1"
        Me.VinculacionAcademicaPT_TGU_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlumnosTableAdapter
        '
        Me.AlumnosTableAdapter.ClearBeforeFill = True
        '
        'tableFormAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(833, 572)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "tableFormAlumnos"
        Me.Text = "tableFormEmployees"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.datalistAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VinculacionAcademicaPT_TGU_DBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExitForm As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents datalistAlumnos As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDeleteAlumno As Button
    Friend WithEvents btnEditAlumno As Button
    Friend WithEvents btnAddNewAlumno As Button
    Friend WithEvents VinculacionAcademicaPT_TGU_DBDataSet1 As VinculacionAcademicaPT_TGU_DBDataSet1
    Friend WithEvents AlumnosBindingSource As BindingSource
    Friend WithEvents AlumnosTableAdapter As VinculacionAcademicaPT_TGU_DBDataSet1TableAdapters.AlumnosTableAdapter
    Friend WithEvents Busqueda As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents txtVinculadas As TextBox
    Friend WithEvents labVinculadas As Label
    Friend WithEvents btnExportar As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtHoras As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEvaluador As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBeneficiado As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtProyecto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCuenta As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCarrera As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtAsignatura As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPeriodo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtEvaluacion As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSaveNew As Button
End Class
