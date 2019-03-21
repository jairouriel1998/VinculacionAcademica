Imports System.Runtime.InteropServices
Public Class detailsFormAlumnos
    Dim newAlumno, editAlumno, viewAlumno As Boolean
    Dim id_registro As Integer

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Public Sub prepareForm(newData As Boolean, editData As Boolean, viewData As Boolean)
        newAlumno = newData
        editAlumno = editData
        viewAlumno = viewData
        prepareButtons()
        prepareTextBox()
    End Sub

    Private Sub prepareButtons()
        If newAlumno Or editAlumno Then
            btnSave.Visible = True
            btnClear.Visible = True
            btnCancel.Visible = True
            btnClose.Visible = False
        ElseIf viewAlumno Then
            btnSave.Visible = False
            btnClear.Visible = False
            btnCancel.Visible = False
            btnClose.Visible = True
        End If
    End Sub

    Private Sub prepareTextBox()
        If newAlumno Or editAlumno Then
            txtCuenta.ReadOnly = False
            txtNombre.ReadOnly = False
            txtProyecto.ReadOnly = False
            txtBeneficiado.ReadOnly = False
            txtEvaluador.ReadOnly = False
            txtHoras.ReadOnly = False
            txtEvaluacion.ReadOnly = False
            txtPeriodo.ReadOnly = False
            txtValor.ReadOnly = False
            txtAsignatura.ReadOnly = False
            txtCarrera.ReadOnly = False
            txtObservaciones.ReadOnly = False
        ElseIf viewAlumno Then
            txtCuenta.ReadOnly = True
            txtNombre.ReadOnly = True
            txtProyecto.ReadOnly = True
            txtBeneficiado.ReadOnly = True
            txtEvaluador.ReadOnly = True
            txtHoras.ReadOnly = True
            txtEvaluacion.ReadOnly = True
            txtPeriodo.ReadOnly = True
            txtValor.ReadOnly = True
            txtAsignatura.ReadOnly = True
            txtCarrera.ReadOnly = True
            txtObservaciones.ReadOnly = True
        End If
    End Sub


    Public Sub reciveData(alumnoData As eAlumnos)
        If alumnoData.Id1 <> 0 Then
            txtCuenta.Text = alumnoData.Cuenta1
            txtNombre.Text = alumnoData.NombreCompleto1
            txtProyecto.Text = alumnoData.NombreProyecto1
            txtBeneficiado.Text = alumnoData.OrganizacionBeneficiada1
            txtEvaluador.Text = alumnoData.Catedratico1
            txtHoras.Text = alumnoData.HorasInvertidas1
            txtEvaluacion.Text = alumnoData.Evaluacion1
            txtPeriodo.Text = alumnoData.Periodo1
            txtValor.Text = alumnoData.ValorEconomico1
            txtAsignatura.Text = alumnoData.Asignatura1
            txtCarrera.Text = alumnoData.Carrera1
            txtObservaciones.Text = alumnoData.Observaciones1
        Else
            txtCuenta.Text = ""
            txtNombre.Text = ""
            txtProyecto.Text = ""
            txtBeneficiado.Text = ""
            txtEvaluador.Text = ""
            txtHoras.Text = ""
            txtEvaluacion.Text = ""
            txtPeriodo.Text = ""
            txtValor.Text = ""
            txtAsignatura.Text = ""
            txtCarrera.Text = ""
            txtObservaciones.Text = ""
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If newAlumno Then
            'If txtCuenta.Text <> "" And txtEmployeeLastName.Text <> "" And
            'txtEmployeeIdCard.Text <> "" And txtEmployeePhone.Text <> "" And
            'txtEmployeeEmail.Text <> "" And txtEmployeePosition.Text <> "" Then
            'Try
            'Dim tablaDatos As New eEmployees
            'Dim funciones As New dEmployees
            'tablaDatos.Nombre1 = txtCuenta.Text
            'tablaDatos.Apellido1 = txtEmployeeLastName.Text
            'tablaDatos.Identidad1 = txtEmployeeIdCard.Text
            'tablaDatos.Telefono1 = txtEmployeePhone.Text
            'tablaDatos.Email1 = txtEmployeeEmail.Text
            'tablaDatos.Cargo1 = txtEmployeePosition.Text
            ' If funciones.insertar(tablaDatos) Then
            'MessageBox.Show("Empleado registrado exitosamente",
            '                   "Guardando registro", MessageBoxButtons.OK,
            'MessageBoxIcon.Information)
            'Else
            'MessageBox.Show("Ha ocurrido un error! Registro no realizado",
            '                   "Guardando registro", MessageBoxButtons.OK,
            'MessageBoxIcon.Error)
            'End If
            'Catch evento As Exception
            'MsgBox(evento.Message)
            'End Try
            'Else
            'MessageBox.Show("Falta Informacion para almacenar en la Base de Datos",
            '                    "Guardando registro", MessageBoxButtons.OK,
            'MessageBoxIcon.Information)
        ElseIf editAlumno Then
            'If txtCuenta.Text <> "" And txtEmployeeLastName.Text <> "" And
            'txtEmployeeIdCard.Text <> "" And txtEmployeePhone.Text <> "" And
            'txtEmployeeEmail.Text <> "" And txtEmployeePosition.Text <> "" Then
            'Try
            'Dim tablaDatos As New eEmployees
            '       Dim funciones As New dEmployees
            'tablaDatos.Id_persona1 = person_id
            'tablaDatos.Id_empleado1 = employee_id
            'tablaDatos.Nombre1 = txtCuenta.Text
            'tablaDatos.Apellido1 = txtEmployeeLastName.Text
            'tablaDatos.Identidad1 = txtEmployeeIdCard.Text
            'tablaDatos.Telefono1 = txtEmployeePhone.Text
            'tablaDatos.Email1 = txtEmployeeEmail.Text
            'tablaDatos.Cargo1 = txtEmployeePosition.Text
            '      If funciones.actualizar(tablaDatos) Then
            '     MessageBox.Show("Cambios guardados exitosamente",
            '                        "Guardando registro", MessageBoxButtons.OK,
            '   MessageBoxIcon.Information)
            '  Else
            ' MessageBox.Show("Ha ocurrido un error! No se guardaron los cambios",
            '                    "Guardando registro", MessageBoxButtons.OK,
            'MessageBoxIcon.Error)
            'End If
            'Catch evento As Exception
            'MsgBox(evento.Message)
            'End Try
        Else
                MessageBox.Show("Falta Informacion para almacenar en la Base de Datos",
                                "Guardando registro", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            End If
        'End If
        Me.Close()
        MainForm.refreshAlumnosData()
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub AlumnosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        'Me.AlumnosBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.VinculacionAcademicaPT_TGU_DBDataSet1)
    End Sub

    Private Sub AlumnosBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        'Me.AlumnosBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.VinculacionAcademicaPT_TGU_DBDataSet1)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'txtCuenta.Text = ""
        'txtEmployeeLastName.Text = ""
        'txtEmployeeIdCard.Text = ""
        'txtEmployeePhone.Text = ""
        'txtEmployeeEmail.Text = ""
        'txtEmployeePosition.Text = ""
    End Sub

End Class