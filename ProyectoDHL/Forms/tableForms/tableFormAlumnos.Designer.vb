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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Busqueda = New System.Windows.Forms.Label()
        Me.btnDeleteAlumno = New System.Windows.Forms.Button()
        Me.btnEditAlumno = New System.Windows.Forms.Button()
        Me.btnAddNewAlumno = New System.Windows.Forms.Button()
        Me.btnViewDetailsEmployee = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.datalistAlumnos = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCompletoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDelProyectoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrganizacionBeneficiadaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatedraticoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorasInvertidasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EvaluacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeriodoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorEconomicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AsignaturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarreraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VinculacionAcademicaPT_TGU_DBDataSet1 = New ProyectoDHL.VinculacionAcademicaPT_TGU_DBDataSet1()
        Me.AlumnosTableAdapter = New ProyectoDHL.VinculacionAcademicaPT_TGU_DBDataSet1TableAdapters.AlumnosTableAdapter()
        Me.btnExitForm = New System.Windows.Forms.Button()
        Me.txtVinculadas = New System.Windows.Forms.TextBox()
        Me.labVinculadas = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.datalistAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VinculacionAcademicaPT_TGU_DBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnExitForm)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(833, 55)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.Label1.Location = New System.Drawing.Point(74, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(747, 42)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "REGISTRO DE ALUMNOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 533)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(833, 39)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtVinculadas)
        Me.Panel3.Controls.Add(Me.btnClear)
        Me.Panel3.Controls.Add(Me.labVinculadas)
        Me.Panel3.Controls.Add(Me.btnBuscar)
        Me.Panel3.Controls.Add(Me.txtBusqueda)
        Me.Panel3.Controls.Add(Me.Busqueda)
        Me.Panel3.Controls.Add(Me.btnDeleteAlumno)
        Me.Panel3.Controls.Add(Me.btnEditAlumno)
        Me.Panel3.Controls.Add(Me.btnAddNewAlumno)
        Me.Panel3.Controls.Add(Me.btnViewDetailsEmployee)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(633, 55)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 478)
        Me.Panel3.TabIndex = 2
        '
        'btnClear
        '
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Minion Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(27, 76)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 31)
        Me.btnClear.TabIndex = 32
        Me.btnClear.Text = "Ver todo"
        Me.btnClear.UseVisualStyleBackColor = True
        Me.btnClear.Visible = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Minion Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(113, 76)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 31)
        Me.btnBuscar.TabIndex = 31
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBusqueda
        '
        Me.txtBusqueda.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.txtBusqueda.Location = New System.Drawing.Point(27, 51)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(161, 19)
        Me.txtBusqueda.TabIndex = 30
        Me.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Busqueda
        '
        Me.Busqueda.AutoSize = True
        Me.Busqueda.Font = New System.Drawing.Font("Minion Pro SmBd", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Busqueda.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Busqueda.Location = New System.Drawing.Point(6, 26)
        Me.Busqueda.Name = "Busqueda"
        Me.Busqueda.Size = New System.Drawing.Size(130, 22)
        Me.Busqueda.TabIndex = 8
        Me.Busqueda.Text = "Buscar por cuenta"
        '
        'btnDeleteAlumno
        '
        Me.btnDeleteAlumno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteAlumno.Enabled = False
        Me.btnDeleteAlumno.FlatAppearance.BorderSize = 0
        Me.btnDeleteAlumno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnDeleteAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnDeleteAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteAlumno.Font = New System.Drawing.Font("Minion Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAlumno.ForeColor = System.Drawing.Color.White
        Me.btnDeleteAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteAlumno.Location = New System.Drawing.Point(0, 345)
        Me.btnDeleteAlumno.Name = "btnDeleteAlumno"
        Me.btnDeleteAlumno.Size = New System.Drawing.Size(200, 40)
        Me.btnDeleteAlumno.TabIndex = 7
        Me.btnDeleteAlumno.Text = "Eliminar Registro"
        Me.btnDeleteAlumno.UseVisualStyleBackColor = True
        '
        'btnEditAlumno
        '
        Me.btnEditAlumno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditAlumno.Enabled = False
        Me.btnEditAlumno.FlatAppearance.BorderSize = 0
        Me.btnEditAlumno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnEditAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEditAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditAlumno.Font = New System.Drawing.Font("Minion Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditAlumno.ForeColor = System.Drawing.Color.White
        Me.btnEditAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditAlumno.Location = New System.Drawing.Point(0, 278)
        Me.btnEditAlumno.Name = "btnEditAlumno"
        Me.btnEditAlumno.Size = New System.Drawing.Size(200, 40)
        Me.btnEditAlumno.TabIndex = 6
        Me.btnEditAlumno.Text = "Editar Registro"
        Me.btnEditAlumno.UseVisualStyleBackColor = True
        '
        'btnAddNewAlumno
        '
        Me.btnAddNewAlumno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNewAlumno.Enabled = False
        Me.btnAddNewAlumno.FlatAppearance.BorderSize = 0
        Me.btnAddNewAlumno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnAddNewAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAddNewAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewAlumno.Font = New System.Drawing.Font("Minion Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewAlumno.ForeColor = System.Drawing.Color.White
        Me.btnAddNewAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddNewAlumno.Location = New System.Drawing.Point(0, 210)
        Me.btnAddNewAlumno.Name = "btnAddNewAlumno"
        Me.btnAddNewAlumno.Size = New System.Drawing.Size(200, 40)
        Me.btnAddNewAlumno.TabIndex = 5
        Me.btnAddNewAlumno.Text = "Nuevo Registro"
        Me.btnAddNewAlumno.UseVisualStyleBackColor = True
        '
        'btnViewDetailsEmployee
        '
        Me.btnViewDetailsEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewDetailsEmployee.FlatAppearance.BorderSize = 0
        Me.btnViewDetailsEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnViewDetailsEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnViewDetailsEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewDetailsEmployee.Font = New System.Drawing.Font("Minion Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewDetailsEmployee.ForeColor = System.Drawing.Color.White
        Me.btnViewDetailsEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewDetailsEmployee.Location = New System.Drawing.Point(0, 146)
        Me.btnViewDetailsEmployee.Name = "btnViewDetailsEmployee"
        Me.btnViewDetailsEmployee.Size = New System.Drawing.Size(197, 40)
        Me.btnViewDetailsEmployee.TabIndex = 4
        Me.btnViewDetailsEmployee.Text = "Ver detalles"
        Me.btnViewDetailsEmployee.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.datalistAlumnos)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 55)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(633, 478)
        Me.Panel4.TabIndex = 3
        '
        'datalistAlumnos
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        Me.datalistAlumnos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datalistAlumnos.AutoGenerateColumns = False
        Me.datalistAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datalistAlumnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.datalistAlumnos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.datalistAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistAlumnos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datalistAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.CuentaDataGridViewTextBoxColumn, Me.NombreCompletoDataGridViewTextBoxColumn, Me.NombreDelProyectoDataGridViewTextBoxColumn, Me.OrganizacionBeneficiadaDataGridViewTextBoxColumn, Me.CatedraticoDataGridViewTextBoxColumn, Me.HorasInvertidasDataGridViewTextBoxColumn, Me.EvaluacionDataGridViewTextBoxColumn, Me.PeriodoDataGridViewTextBoxColumn, Me.ValorEconomicoDataGridViewTextBoxColumn, Me.AsignaturaDataGridViewTextBoxColumn, Me.CarreraDataGridViewTextBoxColumn, Me.ObservacionesDataGridViewTextBoxColumn, Me.ActivoDataGridViewCheckBoxColumn})
        Me.datalistAlumnos.DataSource = Me.AlumnosBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistAlumnos.DefaultCellStyle = DataGridViewCellStyle3
        Me.datalistAlumnos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datalistAlumnos.Location = New System.Drawing.Point(0, 0)
        Me.datalistAlumnos.MultiSelect = False
        Me.datalistAlumnos.Name = "datalistAlumnos"
        Me.datalistAlumnos.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistAlumnos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.datalistAlumnos.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.datalistAlumnos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.datalistAlumnos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.datalistAlumnos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.datalistAlumnos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.datalistAlumnos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        Me.datalistAlumnos.RowTemplate.Height = 30
        Me.datalistAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistAlumnos.Size = New System.Drawing.Size(633, 478)
        Me.datalistAlumnos.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CuentaDataGridViewTextBoxColumn
        '
        Me.CuentaDataGridViewTextBoxColumn.DataPropertyName = "Cuenta"
        Me.CuentaDataGridViewTextBoxColumn.HeaderText = "Cuenta"
        Me.CuentaDataGridViewTextBoxColumn.Name = "CuentaDataGridViewTextBoxColumn"
        Me.CuentaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreCompletoDataGridViewTextBoxColumn
        '
        Me.NombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "Nombre Completo"
        Me.NombreCompletoDataGridViewTextBoxColumn.HeaderText = "Nombre Completo"
        Me.NombreCompletoDataGridViewTextBoxColumn.Name = "NombreCompletoDataGridViewTextBoxColumn"
        Me.NombreCompletoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDelProyectoDataGridViewTextBoxColumn
        '
        Me.NombreDelProyectoDataGridViewTextBoxColumn.DataPropertyName = "Nombre del Proyecto"
        Me.NombreDelProyectoDataGridViewTextBoxColumn.HeaderText = "Nombre del Proyecto"
        Me.NombreDelProyectoDataGridViewTextBoxColumn.Name = "NombreDelProyectoDataGridViewTextBoxColumn"
        Me.NombreDelProyectoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OrganizacionBeneficiadaDataGridViewTextBoxColumn
        '
        Me.OrganizacionBeneficiadaDataGridViewTextBoxColumn.DataPropertyName = "Organizacion Beneficiada"
        Me.OrganizacionBeneficiadaDataGridViewTextBoxColumn.HeaderText = "Organizacion Beneficiada"
        Me.OrganizacionBeneficiadaDataGridViewTextBoxColumn.Name = "OrganizacionBeneficiadaDataGridViewTextBoxColumn"
        Me.OrganizacionBeneficiadaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CatedraticoDataGridViewTextBoxColumn
        '
        Me.CatedraticoDataGridViewTextBoxColumn.DataPropertyName = "Catedratico"
        Me.CatedraticoDataGridViewTextBoxColumn.HeaderText = "Catedratico"
        Me.CatedraticoDataGridViewTextBoxColumn.Name = "CatedraticoDataGridViewTextBoxColumn"
        Me.CatedraticoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HorasInvertidasDataGridViewTextBoxColumn
        '
        Me.HorasInvertidasDataGridViewTextBoxColumn.DataPropertyName = "Horas Invertidas"
        Me.HorasInvertidasDataGridViewTextBoxColumn.HeaderText = "Horas Invertidas"
        Me.HorasInvertidasDataGridViewTextBoxColumn.Name = "HorasInvertidasDataGridViewTextBoxColumn"
        Me.HorasInvertidasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EvaluacionDataGridViewTextBoxColumn
        '
        Me.EvaluacionDataGridViewTextBoxColumn.DataPropertyName = "Evaluacion"
        Me.EvaluacionDataGridViewTextBoxColumn.HeaderText = "Evaluacion"
        Me.EvaluacionDataGridViewTextBoxColumn.Name = "EvaluacionDataGridViewTextBoxColumn"
        Me.EvaluacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PeriodoDataGridViewTextBoxColumn
        '
        Me.PeriodoDataGridViewTextBoxColumn.DataPropertyName = "Periodo"
        Me.PeriodoDataGridViewTextBoxColumn.HeaderText = "Periodo"
        Me.PeriodoDataGridViewTextBoxColumn.Name = "PeriodoDataGridViewTextBoxColumn"
        Me.PeriodoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValorEconomicoDataGridViewTextBoxColumn
        '
        Me.ValorEconomicoDataGridViewTextBoxColumn.DataPropertyName = "Valor Economico"
        Me.ValorEconomicoDataGridViewTextBoxColumn.HeaderText = "Valor Economico"
        Me.ValorEconomicoDataGridViewTextBoxColumn.Name = "ValorEconomicoDataGridViewTextBoxColumn"
        Me.ValorEconomicoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AsignaturaDataGridViewTextBoxColumn
        '
        Me.AsignaturaDataGridViewTextBoxColumn.DataPropertyName = "Asignatura"
        Me.AsignaturaDataGridViewTextBoxColumn.HeaderText = "Asignatura"
        Me.AsignaturaDataGridViewTextBoxColumn.Name = "AsignaturaDataGridViewTextBoxColumn"
        Me.AsignaturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CarreraDataGridViewTextBoxColumn
        '
        Me.CarreraDataGridViewTextBoxColumn.DataPropertyName = "Carrera"
        Me.CarreraDataGridViewTextBoxColumn.HeaderText = "Carrera"
        Me.CarreraDataGridViewTextBoxColumn.Name = "CarreraDataGridViewTextBoxColumn"
        Me.CarreraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObservacionesDataGridViewTextBoxColumn
        '
        Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
        Me.ObservacionesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ActivoDataGridViewCheckBoxColumn
        '
        Me.ActivoDataGridViewCheckBoxColumn.DataPropertyName = "Activo"
        Me.ActivoDataGridViewCheckBoxColumn.HeaderText = "Activo"
        Me.ActivoDataGridViewCheckBoxColumn.Name = "ActivoDataGridViewCheckBoxColumn"
        Me.ActivoDataGridViewCheckBoxColumn.ReadOnly = True
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
        'btnExitForm
        '
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
        Me.btnExitForm.UseVisualStyleBackColor = True
        '
        'txtVinculadas
        '
        Me.txtVinculadas.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtVinculadas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVinculadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVinculadas.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.txtVinculadas.Location = New System.Drawing.Point(104, 453)
        Me.txtVinculadas.Name = "txtVinculadas"
        Me.txtVinculadas.Size = New System.Drawing.Size(84, 19)
        Me.txtVinculadas.TabIndex = 34
        Me.txtVinculadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtVinculadas.Visible = False
        '
        'labVinculadas
        '
        Me.labVinculadas.AutoSize = True
        Me.labVinculadas.Font = New System.Drawing.Font("Minion Pro SmBd", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labVinculadas.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.labVinculadas.Location = New System.Drawing.Point(3, 428)
        Me.labVinculadas.Name = "labVinculadas"
        Me.labVinculadas.Size = New System.Drawing.Size(184, 22)
        Me.labVinculadas.TabIndex = 33
        Me.labVinculadas.Text = "Total de horas vinculadas: "
        Me.labVinculadas.Visible = False
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
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.datalistAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnViewDetailsEmployee As Button
    Friend WithEvents btnDeleteAlumno As Button
    Friend WithEvents btnEditAlumno As Button
    Friend WithEvents btnAddNewAlumno As Button
    Friend WithEvents VinculacionAcademicaPT_TGU_DBDataSet1 As VinculacionAcademicaPT_TGU_DBDataSet1
    Friend WithEvents AlumnosBindingSource As BindingSource
    Friend WithEvents AlumnosTableAdapter As VinculacionAcademicaPT_TGU_DBDataSet1TableAdapters.AlumnosTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CuentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreCompletoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDelProyectoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrganizacionBeneficiadaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CatedraticoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HorasInvertidasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EvaluacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PeriodoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorEconomicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AsignaturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CarreraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActivoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents Busqueda As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents txtVinculadas As TextBox
    Friend WithEvents labVinculadas As Label
End Class
