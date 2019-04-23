<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tableFormPapelera
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExitForm = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnVaciarPapelera = New System.Windows.Forms.Button()
        Me.btnEliminarDelTodo = New System.Windows.Forms.Button()
        Me.btnRestaurarRegistro = New System.Windows.Forms.Button()
        Me.btnVerDetalles = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.datalistEliminados = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.datalistEliminados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnExitForm)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(875, 58)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Lato Semibold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(97, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(747, 43)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "PAPELERA DE RECICLAJE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnExitForm.Size = New System.Drawing.Size(68, 58)
        Me.btnExitForm.TabIndex = 4
        Me.btnExitForm.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.btnVaciarPapelera)
        Me.Panel2.Controls.Add(Me.btnEliminarDelTodo)
        Me.Panel2.Controls.Add(Me.btnRestaurarRegistro)
        Me.Panel2.Controls.Add(Me.btnVerDetalles)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(670, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(205, 494)
        Me.Panel2.TabIndex = 1
        '
        'btnVaciarPapelera
        '
        Me.btnVaciarPapelera.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnVaciarPapelera.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVaciarPapelera.FlatAppearance.BorderSize = 0
        Me.btnVaciarPapelera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnVaciarPapelera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnVaciarPapelera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVaciarPapelera.Font = New System.Drawing.Font("Lato Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVaciarPapelera.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnVaciarPapelera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVaciarPapelera.Location = New System.Drawing.Point(1, 327)
        Me.btnVaciarPapelera.Name = "btnVaciarPapelera"
        Me.btnVaciarPapelera.Size = New System.Drawing.Size(204, 40)
        Me.btnVaciarPapelera.TabIndex = 11
        Me.btnVaciarPapelera.Text = "Vaciar Papelera"
        Me.btnVaciarPapelera.UseVisualStyleBackColor = False
        '
        'btnEliminarDelTodo
        '
        Me.btnEliminarDelTodo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEliminarDelTodo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarDelTodo.FlatAppearance.BorderSize = 0
        Me.btnEliminarDelTodo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnEliminarDelTodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnEliminarDelTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarDelTodo.Font = New System.Drawing.Font("Lato Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarDelTodo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEliminarDelTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarDelTodo.Location = New System.Drawing.Point(0, 260)
        Me.btnEliminarDelTodo.Name = "btnEliminarDelTodo"
        Me.btnEliminarDelTodo.Size = New System.Drawing.Size(204, 40)
        Me.btnEliminarDelTodo.TabIndex = 10
        Me.btnEliminarDelTodo.Text = "Eliminar"
        Me.btnEliminarDelTodo.UseVisualStyleBackColor = False
        '
        'btnRestaurarRegistro
        '
        Me.btnRestaurarRegistro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRestaurarRegistro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurarRegistro.FlatAppearance.BorderSize = 0
        Me.btnRestaurarRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnRestaurarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnRestaurarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurarRegistro.Font = New System.Drawing.Font("Lato Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestaurarRegistro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRestaurarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRestaurarRegistro.Location = New System.Drawing.Point(0, 192)
        Me.btnRestaurarRegistro.Name = "btnRestaurarRegistro"
        Me.btnRestaurarRegistro.Size = New System.Drawing.Size(204, 40)
        Me.btnRestaurarRegistro.TabIndex = 9
        Me.btnRestaurarRegistro.Text = "Restaurar"
        Me.btnRestaurarRegistro.UseVisualStyleBackColor = False
        '
        'btnVerDetalles
        '
        Me.btnVerDetalles.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnVerDetalles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerDetalles.FlatAppearance.BorderSize = 0
        Me.btnVerDetalles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnVerDetalles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnVerDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerDetalles.Font = New System.Drawing.Font("Lato Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerDetalles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnVerDetalles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerDetalles.Location = New System.Drawing.Point(1, 128)
        Me.btnVerDetalles.Name = "btnVerDetalles"
        Me.btnVerDetalles.Size = New System.Drawing.Size(200, 40)
        Me.btnVerDetalles.TabIndex = 8
        Me.btnVerDetalles.Text = "Detalles"
        Me.btnVerDetalles.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 489)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(670, 63)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel4.Controls.Add(Me.datalistEliminados)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 58)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(670, 431)
        Me.Panel4.TabIndex = 3
        '
        'datalistEliminados
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.datalistEliminados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datalistEliminados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datalistEliminados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.datalistEliminados.BackgroundColor = System.Drawing.Color.White
        Me.datalistEliminados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistEliminados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datalistEliminados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistEliminados.DefaultCellStyle = DataGridViewCellStyle3
        Me.datalistEliminados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datalistEliminados.Location = New System.Drawing.Point(0, 0)
        Me.datalistEliminados.MultiSelect = False
        Me.datalistEliminados.Name = "datalistEliminados"
        Me.datalistEliminados.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistEliminados.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.datalistEliminados.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.datalistEliminados.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.datalistEliminados.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.datalistEliminados.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datalistEliminados.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.datalistEliminados.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        Me.datalistEliminados.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datalistEliminados.RowTemplate.Height = 30
        Me.datalistEliminados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistEliminados.Size = New System.Drawing.Size(670, 431)
        Me.datalistEliminados.TabIndex = 1
        '
        'tableFormPapelera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(875, 552)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "tableFormPapelera"
        Me.Text = "tableFormConsumers"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.datalistEliminados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExitForm As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnRestaurarRegistro As Button
    Friend WithEvents btnVerDetalles As Button
    Friend WithEvents datalistEliminados As DataGridView
    Friend WithEvents btnVaciarPapelera As Button
    Friend WithEvents btnEliminarDelTodo As Button
End Class
