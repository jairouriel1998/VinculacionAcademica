﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.formsPanel = New System.Windows.Forms.Panel()
        Me.hiddenMenuTimer = New System.Windows.Forms.Timer(Me.components)
        Me.showMenuTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAcordeon = New System.Windows.Forms.PictureBox()
        Me.picboxLogo = New System.Windows.Forms.PictureBox()
        Me.btnFormClientes = New System.Windows.Forms.Button()
        Me.btnFormEmpleados = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnFormAbout = New System.Windows.Forms.Button()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.menuPanel = New System.Windows.Forms.Panel()
        Me.superiorPanel.SuspendLayout()
        CType(Me.btnAcordeon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuPanel.SuspendLayout()
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
        Me.formsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer))
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
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 40)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "  Vinculación Académica"
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
        'btnFormClientes
        '
        Me.btnFormClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormClientes.FlatAppearance.BorderSize = 0
        Me.btnFormClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnFormClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnFormClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormClientes.Font = New System.Drawing.Font("Minion Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'btnFormEmpleados
        '
        Me.btnFormEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormEmpleados.FlatAppearance.BorderSize = 0
        Me.btnFormEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnFormEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnFormEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormEmpleados.Font = New System.Drawing.Font("Minion Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormEmpleados.ForeColor = System.Drawing.Color.White
        Me.btnFormEmpleados.Image = Global.ProyectoDHL.My.Resources.Resources.clientes
        Me.btnFormEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormEmpleados.Location = New System.Drawing.Point(0, 158)
        Me.btnFormEmpleados.Name = "btnFormEmpleados"
        Me.btnFormEmpleados.Size = New System.Drawing.Size(220, 40)
        Me.btnFormEmpleados.TabIndex = 7
        Me.btnFormEmpleados.Text = "Alumnos"
        Me.btnFormEmpleados.UseVisualStyleBackColor = True
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
        'btnFormAbout
        '
        Me.btnFormAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormAbout.FlatAppearance.BorderSize = 0
        Me.btnFormAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnFormAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnFormAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormAbout.Font = New System.Drawing.Font("Minion Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormAbout.ForeColor = System.Drawing.Color.White
        Me.btnFormAbout.Image = Global.ProyectoDHL.My.Resources.Resources.empleados
        Me.btnFormAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormAbout.Location = New System.Drawing.Point(0, 492)
        Me.btnFormAbout.Name = "btnFormAbout"
        Me.btnFormAbout.Size = New System.Drawing.Size(220, 40)
        Me.btnFormAbout.TabIndex = 14
        Me.btnFormAbout.Text = "About"
        Me.btnFormAbout.UseVisualStyleBackColor = True
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel12.Location = New System.Drawing.Point(0, 492)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(5, 38)
        Me.Panel12.TabIndex = 6
        '
        'menuPanel
        '
        Me.menuPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.menuPanel.Controls.Add(Me.Panel12)
        Me.menuPanel.Controls.Add(Me.btnFormAbout)
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
        Me.superiorPanel.ResumeLayout(False)
        CType(Me.btnAcordeon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuPanel.ResumeLayout(False)
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
    Friend WithEvents btnFormAbout As Button
    Friend WithEvents Panel12 As Panel
    Friend WithEvents menuPanel As Panel
End Class
