<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.superiorPanel = New System.Windows.Forms.Panel()
        Me.btnRestaurate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.formsPanel = New System.Windows.Forms.Panel()
        Me.hiddenMenuTimer = New System.Windows.Forms.Timer(Me.components)
        Me.showMenuTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.menuPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnFormEmpleados = New System.Windows.Forms.Button()
        Me.btnFormClientes = New System.Windows.Forms.Button()
        Me.picboxLogo = New System.Windows.Forms.PictureBox()
        Me.btnAcordeon = New System.Windows.Forms.PictureBox()
        Me.superiorPanel.SuspendLayout()
        Me.menuPanel.SuspendLayout()
        CType(Me.picboxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAcordeon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'superiorPanel
        '
        Me.superiorPanel.BackColor = System.Drawing.Color.SteelBlue
        Me.superiorPanel.Controls.Add(Me.btnRestaurate)
        Me.superiorPanel.Controls.Add(Me.Label1)
        Me.superiorPanel.Controls.Add(Me.btnMinimize)
        Me.superiorPanel.Controls.Add(Me.btnMaximize)
        Me.superiorPanel.Controls.Add(Me.btnClose)
        Me.superiorPanel.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.superiorPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.superiorPanel.Location = New System.Drawing.Point(0, 0)
        Me.superiorPanel.Name = "superiorPanel"
        Me.superiorPanel.Size = New System.Drawing.Size(1100, 40)
        Me.superiorPanel.TabIndex = 0
        '
        'btnRestaurate
        '
        Me.btnRestaurate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurate.FlatAppearance.BorderSize = 0
        Me.btnRestaurate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRestaurate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnRestaurate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurate.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestaurate.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnRestaurate.Image = Global.ProyectoDHL.My.Resources.Resources.Icono_Restaurar
        Me.btnRestaurate.Location = New System.Drawing.Point(1014, 0)
        Me.btnRestaurate.Name = "btnRestaurate"
        Me.btnRestaurate.Size = New System.Drawing.Size(40, 40)
        Me.btnRestaurate.TabIndex = 3
        Me.btnRestaurate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRestaurate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(525, 40)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Control de vinculación académica"
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMinimize.Image = Global.ProyectoDHL.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimize.Location = New System.Drawing.Point(968, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimize.TabIndex = 2
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximize.FlatAppearance.BorderSize = 0
        Me.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaximize.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMaximize.Image = Global.ProyectoDHL.My.Resources.Resources.Icono_Maximizar
        Me.btnMaximize.Location = New System.Drawing.Point(1014, 0)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(40, 40)
        Me.btnMaximize.TabIndex = 1
        Me.btnMaximize.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMaximize.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClose.Image = Global.ProyectoDHL.My.Resources.Resources.Icono_cerrar_FN
        Me.btnClose.Location = New System.Drawing.Point(1060, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 40)
        Me.btnClose.TabIndex = 0
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'formsPanel
        '
        Me.formsPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.formsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.formsPanel.Location = New System.Drawing.Point(220, 40)
        Me.formsPanel.Name = "formsPanel"
        Me.formsPanel.Size = New System.Drawing.Size(880, 660)
        Me.formsPanel.TabIndex = 2
        '
        'hiddenMenuTimer
        '
        '
        'showMenuTimer
        '
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Location = New System.Drawing.Point(0, 158)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 38)
        Me.Panel2.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.Location = New System.Drawing.Point(0, 204)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 38)
        Me.Panel3.TabIndex = 4
        '
        'menuPanel
        '
        Me.menuPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.menuPanel.Controls.Add(Me.Panel1)
        Me.menuPanel.Controls.Add(Me.btnAbout)
        Me.menuPanel.Controls.Add(Me.Panel3)
        Me.menuPanel.Controls.Add(Me.Panel2)
        Me.menuPanel.Controls.Add(Me.btnFormEmpleados)
        Me.menuPanel.Controls.Add(Me.btnFormClientes)
        Me.menuPanel.Controls.Add(Me.picboxLogo)
        Me.menuPanel.Controls.Add(Me.btnAcordeon)
        Me.menuPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.menuPanel.Location = New System.Drawing.Point(0, 40)
        Me.menuPanel.Name = "menuPanel"
        Me.menuPanel.Size = New System.Drawing.Size(220, 660)
        Me.menuPanel.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Location = New System.Drawing.Point(0, 310)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 38)
        Me.Panel1.TabIndex = 8
        '
        'btnAbout
        '
        Me.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Lato Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.ForeColor = System.Drawing.Color.White
        Me.btnAbout.Image = Global.ProyectoDHL.My.Resources.Resources.empleados
        Me.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbout.Location = New System.Drawing.Point(0, 310)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(220, 40)
        Me.btnAbout.TabIndex = 9
        Me.btnAbout.Text = "Acerca de"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnFormEmpleados
        '
        Me.btnFormEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormEmpleados.FlatAppearance.BorderSize = 0
        Me.btnFormEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnFormEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnFormEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormEmpleados.Font = New System.Drawing.Font("Lato Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormEmpleados.ForeColor = System.Drawing.Color.White
        Me.btnFormEmpleados.Image = Global.ProyectoDHL.My.Resources.Resources.clientes
        Me.btnFormEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormEmpleados.Location = New System.Drawing.Point(0, 158)
        Me.btnFormEmpleados.Name = "btnFormEmpleados"
        Me.btnFormEmpleados.Size = New System.Drawing.Size(220, 40)
        Me.btnFormEmpleados.TabIndex = 7
        Me.btnFormEmpleados.Text = "Registros"
        Me.btnFormEmpleados.UseVisualStyleBackColor = True
        '
        'btnFormClientes
        '
        Me.btnFormClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormClientes.FlatAppearance.BorderSize = 0
        Me.btnFormClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnFormClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnFormClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormClientes.Font = New System.Drawing.Font("Lato Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormClientes.ForeColor = System.Drawing.Color.White
        Me.btnFormClientes.Image = Global.ProyectoDHL.My.Resources.Resources.Icono_Restaurar
        Me.btnFormClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormClientes.Location = New System.Drawing.Point(0, 204)
        Me.btnFormClientes.Name = "btnFormClientes"
        Me.btnFormClientes.Size = New System.Drawing.Size(220, 40)
        Me.btnFormClientes.TabIndex = 6
        Me.btnFormClientes.Text = "Papelera"
        Me.btnFormClientes.UseVisualStyleBackColor = True
        '
        'picboxLogo
        '
        Me.picboxLogo.Image = Global.ProyectoDHL.My.Resources.Resources.logo_ceutec_blanco
        Me.picboxLogo.Location = New System.Drawing.Point(3, 76)
        Me.picboxLogo.Name = "picboxLogo"
        Me.picboxLogo.Size = New System.Drawing.Size(214, 76)
        Me.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxLogo.TabIndex = 1
        Me.picboxLogo.TabStop = False
        '
        'btnAcordeon
        '
        Me.btnAcordeon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAcordeon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAcordeon.Image = Global.ProyectoDHL.My.Resources.Resources.Mobile_Menu_Icon
        Me.btnAcordeon.Location = New System.Drawing.Point(166, 0)
        Me.btnAcordeon.Name = "btnAcordeon"
        Me.btnAcordeon.Size = New System.Drawing.Size(54, 50)
        Me.btnAcordeon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAcordeon.TabIndex = 0
        Me.btnAcordeon.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 700)
        Me.Controls.Add(Me.formsPanel)
        Me.Controls.Add(Me.menuPanel)
        Me.Controls.Add(Me.superiorPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.superiorPanel.ResumeLayout(False)
        Me.menuPanel.ResumeLayout(False)
        CType(Me.picboxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAcordeon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents superiorPanel As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnMaximize As Button
    Friend WithEvents btnRestaurate As Button
    Friend WithEvents formsPanel As Panel
    Friend WithEvents hiddenMenuTimer As Timer
    Friend WithEvents showMenuTimer As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAcordeon As PictureBox
    Friend WithEvents picboxLogo As PictureBox
    Friend WithEvents btnFormClientes As Button
    Friend WithEvents btnFormEmpleados As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents menuPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAbout As Button
End Class
